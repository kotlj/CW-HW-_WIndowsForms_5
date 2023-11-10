namespace CW_Forms_5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxCategory = new ComboBox();
            listBoxProducts = new ListBox();
            listBoxCart = new ListBox();
            buttonAddToCart = new Button();
            textBoxPay = new TextBox();
            buttonDeleteFromCart = new Button();
            buttonDataGrid = new Button();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(12, 12);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(294, 28);
            comboBoxCategory.TabIndex = 0;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.HorizontalScrollbar = true;
            listBoxProducts.ItemHeight = 20;
            listBoxProducts.Location = new Point(312, 12);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(476, 424);
            listBoxProducts.TabIndex = 1;
            // 
            // listBoxCart
            // 
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 20;
            listBoxCart.Location = new Point(12, 52);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(294, 384);
            listBoxCart.TabIndex = 2;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Location = new Point(12, 442);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(143, 59);
            buttonAddToCart.TabIndex = 3;
            buttonAddToCart.Text = "Buy";
            buttonAddToCart.UseVisualStyleBackColor = true;
            buttonAddToCart.Click += buttonAddToCart_Click;
            // 
            // textBoxPay
            // 
            textBoxPay.Location = new Point(312, 442);
            textBoxPay.Name = "textBoxPay";
            textBoxPay.Size = new Size(476, 27);
            textBoxPay.TabIndex = 4;
            // 
            // buttonDeleteFromCart
            // 
            buttonDeleteFromCart.Location = new Point(161, 442);
            buttonDeleteFromCart.Name = "buttonDeleteFromCart";
            buttonDeleteFromCart.Size = new Size(145, 59);
            buttonDeleteFromCart.TabIndex = 5;
            buttonDeleteFromCart.Text = "Delete from cart";
            buttonDeleteFromCart.UseVisualStyleBackColor = true;
            buttonDeleteFromCart.Click += buttonDeleteFromCart_Click;
            // 
            // buttonDataGrid
            // 
            buttonDataGrid.Location = new Point(312, 475);
            buttonDataGrid.Name = "buttonDataGrid";
            buttonDataGrid.Size = new Size(473, 42);
            buttonDataGrid.TabIndex = 6;
            buttonDataGrid.Text = "Detal Information";
            buttonDataGrid.UseVisualStyleBackColor = true;
            buttonDataGrid.Click += buttonDataGrid_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 529);
            Controls.Add(buttonDataGrid);
            Controls.Add(buttonDeleteFromCart);
            Controls.Add(textBoxPay);
            Controls.Add(buttonAddToCart);
            Controls.Add(listBoxCart);
            Controls.Add(listBoxProducts);
            Controls.Add(comboBoxCategory);
            Name = "MainForm";
            Text = "MainForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCategory;
        private ListBox listBoxProducts;
        private ListBox listBoxCart;
        private Button buttonAddToCart;
        private TextBox textBoxPay;
        private Button buttonDeleteFromCart;
        private Button buttonDataGrid;
    }
}