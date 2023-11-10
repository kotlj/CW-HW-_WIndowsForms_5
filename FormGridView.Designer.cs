namespace CW_Forms_5
{
    partial class FormGridView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewCart = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Dock = DockStyle.Fill;
            dataGridViewCart.Location = new Point(0, 0);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersWidth = 51;
            dataGridViewCart.RowTemplate.Height = 29;
            dataGridViewCart.Size = new Size(800, 450);
            dataGridViewCart.TabIndex = 0;
            // 
            // FormGridView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewCart);
            Name = "FormGridView";
            Text = "FormGridView";
            Load += FormGridView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCart;
    }
}