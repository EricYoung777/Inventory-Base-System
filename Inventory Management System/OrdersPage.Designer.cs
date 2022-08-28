
namespace Inventory_Management_System
{
    partial class OrdersPage
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
            this.id = new System.Windows.Forms.TextBox();
            this.OrdersGV = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.prodCateg = new System.Windows.Forms.ComboBox();
            this.orderId = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(21, 168);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(202, 28);
            this.id.TabIndex = 2;
            this.id.Text = "OrderID";
            // 
            // OrdersGV
            // 
            this.OrdersGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrdersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGV.Location = new System.Drawing.Point(277, 116);
            this.OrdersGV.Name = "OrdersGV";
            this.OrdersGV.Size = new System.Drawing.Size(449, 303);
            this.OrdersGV.TabIndex = 5;
            this.OrdersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGV_CellContentClick);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(21, 263);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(202, 20);
            this.date.TabIndex = 6;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // prodCateg
            // 
            this.prodCateg.FormattingEnabled = true;
            this.prodCateg.ItemHeight = 13;
            this.prodCateg.Items.AddRange(new object[] {
            "Cars",
            "Clothings",
            "Electronics",
            "Food Products",
            "Footwear",
            "Wood Works"});
            this.prodCateg.Location = new System.Drawing.Point(21, 216);
            this.prodCateg.Name = "prodCateg";
            this.prodCateg.Size = new System.Drawing.Size(202, 21);
            this.prodCateg.Sorted = true;
            this.prodCateg.TabIndex = 19;
            this.prodCateg.Text = "Product Category";
            // 
            // orderId
            // 
            this.orderId.BackColor = System.Drawing.Color.Black;
            this.orderId.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderId.ForeColor = System.Drawing.Color.White;
            this.orderId.Location = new System.Drawing.Point(4, 312);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(82, 53);
            this.orderId.TabIndex = 20;
            this.orderId.Text = "Add \r\nOrder";
            this.orderId.UseVisualStyleBackColor = false;
            this.orderId.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(92, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 53);
            this.button2.TabIndex = 21;
            this.button2.Text = "UpDate \r\nOrder";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(180, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 53);
            this.button3.TabIndex = 22;
            this.button3.Text = "Delete \r\nOrder";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(92, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 36);
            this.button4.TabIndex = 23;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 87);
            this.label2.TabIndex = 27;
            this.label2.Text = "Manage Orders";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Orders";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Inventory_Management_System.Properties.Resources.ShopRite;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(327, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 87);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // OrdersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.prodCateg);
            this.Controls.Add(this.date);
            this.Controls.Add(this.OrdersGV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.id);
            this.Name = "OrdersPage";
            this.Text = "OrdersPage";
            this.Load += new System.EventHandler(this.OrdersPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView OrdersGV;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox prodCateg;
        private System.Windows.Forms.Button orderId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}