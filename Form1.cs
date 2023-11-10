using CW_Forms_5.Models;

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
            listBoxProducts.SelectionMode = SelectionMode.MultiExtended;
            listBoxCart.SelectionMode = SelectionMode.MultiExtended;
            categories = Models.Seeder.initCategory();
            products = Models.Seeder.initProduct(categories);
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "ID";
        }
        private void FillData()
        {
            listBoxProducts.DataSource = products
                .Where(e => e.Category.ID.Equals(comboBoxCategory.SelectedValue)).ToList();
        }
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            var selectedProducts = listBoxProducts.SelectedItems.OfType<Product>().ToList();
            if (selectedProducts != null)
            {
                foreach (var product in selectedProducts)
                {
                    listBoxCart.Items.Add(product);
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
    }
}