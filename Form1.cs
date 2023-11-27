using CW_Forms_5.Models;
using Newtonsoft.Json;
using System.Text;
using static System.Net.WebRequestMethods;

namespace CW_Forms_5
{
    public partial class MainForm : Form
    {
        List<Models.Category> categories = new List<Models.Category>();
        List<Models.Product> products = new List<Models.Product>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData(comboBoxCategory);
            listBoxProducts.SelectionMode = SelectionMode.MultiExtended;
            listBoxCart.SelectionMode = SelectionMode.MultiExtended;
            listBoxProducts.ContextMenuStrip = contextMenuStrip1;
            listBoxCart.ContextMenuStrip = contextMenuStrip1;
            listBoxCart.DisplayMember = "Name" + " " + "Price" + " " + "Count";
            //categories = Models.Seeder.initCategory();
            //products = Models.Seeder.initProduct(categories);
            //comboBoxCategory.DataSource = categories;
            //comboBoxCategory.DisplayMember = "Name";
            //comboBoxCategory.ValueMember = "ID";
        }
        private async void FillData(string id, ListBox lb)
        {
            string pathToServer = $"https://53e9-188-163-101-141.ngrok.io/products?IdCategory={id}";

            var client = new HttpClient();
            var response = await client.GetAsync(pathToServer);
            if (response != null && response.IsSuccessStatusCode)
            {
                string jsonContext = await response.Content.ReadAsStringAsync();
                var prod = JsonConvert.DeserializeObject<List<Product>>(jsonContext);
                lb.DataSource = prod;
            }
        }
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillData(((Category)comboBoxCategory.SelectedItem).ID, listBoxCart);
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            var selectedProducts = listBoxProducts.SelectedItems.OfType<Product>().ToList();
            bool equal = false;
            if (selectedProducts != null)
            {
                foreach (var product in selectedProducts)
                {
                    foreach (Product item in listBoxCart.Items)
                    {
                        if (product == item)
                        {
                            equal = true;
                            item.Count += 1;
                        }
                    }
                    if (!equal)
                    {
                        listBoxCart.Items.Add(product);
                    }
                }
                textBoxPay.Text = listBoxCart.Items.OfType<Product>().Sum(e => e.Price).ToString();
            }
        }

        private void buttonDeleteFromCart_Click(object sender, EventArgs e)
        {
            var selectedProducts = listBoxCart.SelectedItems.OfType<Product>().ToList();
            if (selectedProducts != null)
            {
                foreach (var product in selectedProducts)
                {
                    listBoxCart.Items.Remove(product);
                }
            }
            textBoxPay.Text = listBoxCart.Items.OfType<Product>().Sum(e => e.Price).ToString();
        }

        private void buttonDataGrid_Click(object sender, EventArgs e)
        {
            FormGridView formGridView = new FormGridView();
            formGridView.ShowDialog();
        }
        private static async void GetData(ComboBox cmbx)
        {
            string pathToServer = "https://53e9-188-163-101-141.ngrok.io/categories";

            var client = new HttpClient();
            var response = await client.GetAsync(pathToServer);
            if (response != null && response.IsSuccessStatusCode)
            {
                string jsonContext = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<Category>>(jsonContext);
                //StringBuilder stringBuilder = new StringBuilder();
                //foreach(var item in data)
                //{
                //    stringBuilder.Append(item.Name);
                //    stringBuilder.Append("\n");
                //}
                //MessageBox.Show(stringBuilder.ToString());
                cmbx.DataSource = data;
                cmbx.DisplayMember = "Name";
                cmbx.ValueMember = "ID";
            }
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetailDialog formDetailDialog = new FormDetailDialog();
            formDetailDialog.ShowDialog();
        }
    }
}