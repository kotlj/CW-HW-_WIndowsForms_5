using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_Forms_5
{
    public partial class FormGridView : Form
    {
        public FormGridView()
        {
            InitializeComponent();
        }

        private void FormGridView_Load(object sender, EventArgs e)
        {
            IEnumerable<ListBox> Box = Application.OpenForms[0].Controls.OfType<ListBox>();
            dataGridViewCart.DataSource = Box.Where(e => e.Name.Equals("listBoxCart")).First().Items;
        }
    }
}