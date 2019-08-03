namespace Makhazen
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sup_btn = new System.Windows.Forms.Button();
            this.product_btn = new System.Windows.Forms.Button();
            this.represent_btn = new System.Windows.Forms.Button();
            this.customer_btn = new System.Windows.Forms.Button();
            this.report_btn = new System.Windows.Forms.Button();
            this.buybill = new System.Windows.Forms.Button();
            this.sellbill = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.permession = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sup_btn
            // 
            this.sup_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sup_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sup_btn.Location = new System.Drawing.Point(577, 128);
            this.sup_btn.Name = "sup_btn";
            this.sup_btn.Size = new System.Drawing.Size(97, 40);
            this.sup_btn.TabIndex = 0;
            this.sup_btn.Text = "الموردين";
            this.sup_btn.UseVisualStyleBackColor = false;
            this.sup_btn.Click += new System.EventHandler(this.Sup_btn_Click);
            // 
            // product_btn
            // 
            this.product_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.product_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.product_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.product_btn.Location = new System.Drawing.Point(577, 68);
            this.product_btn.Name = "product_btn";
            this.product_btn.Size = new System.Drawing.Size(97, 40);
            this.product_btn.TabIndex = 1;
            this.product_btn.Text = "المنتجات";
            this.product_btn.UseVisualStyleBackColor = false;
            this.product_btn.Click += new System.EventHandler(this.Product_btn_Click);
            // 
            // represent_btn
            // 
            this.represent_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.represent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.represent_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.represent_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.represent_btn.Location = new System.Drawing.Point(577, 200);
            this.represent_btn.Name = "represent_btn";
            this.represent_btn.Size = new System.Drawing.Size(97, 40);
            this.represent_btn.TabIndex = 2;
            this.represent_btn.Text = "المندوبين";
            this.represent_btn.UseVisualStyleBackColor = false;
            this.represent_btn.Click += new System.EventHandler(this.Represent_btn_Click);
            // 
            // customer_btn
            // 
            this.customer_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customer_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customer_btn.Location = new System.Drawing.Point(577, 260);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(97, 40);
            this.customer_btn.TabIndex = 3;
            this.customer_btn.Text = "العملاء";
            this.customer_btn.UseVisualStyleBackColor = false;
            this.customer_btn.Click += new System.EventHandler(this.Customer_btn_Click);
            // 
            // report_btn
            // 
            this.report_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.report_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.report_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.report_btn.Location = new System.Drawing.Point(12, 260);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(97, 40);
            this.report_btn.TabIndex = 4;
            this.report_btn.Text = "التقارير";
            this.report_btn.UseVisualStyleBackColor = false;
            this.report_btn.Click += new System.EventHandler(this.Report_btn_Click);
            // 
            // buybill
            // 
            this.buybill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buybill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buybill.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buybill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buybill.Location = new System.Drawing.Point(12, 23);
            this.buybill.Name = "buybill";
            this.buybill.Size = new System.Drawing.Size(97, 56);
            this.buybill.TabIndex = 5;
            this.buybill.Text = "فاتورة بيع ";
            this.buybill.UseVisualStyleBackColor = false;
            this.buybill.Click += new System.EventHandler(this.buybill_Click);
            // 
            // sellbill
            // 
            this.sellbill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sellbill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sellbill.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellbill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sellbill.Location = new System.Drawing.Point(12, 99);
            this.sellbill.Name = "sellbill";
            this.sellbill.Size = new System.Drawing.Size(97, 56);
            this.sellbill.TabIndex = 6;
            this.sellbill.Text = "فاتورة شراء";
            this.sellbill.UseVisualStyleBackColor = false;
            this.sellbill.Click += new System.EventHandler(this.Sellbill_Click);
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.category.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.category.Location = new System.Drawing.Point(577, 12);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(97, 40);
            this.category.TabIndex = 9;
            this.category.Text = "اصناف";
            this.category.UseVisualStyleBackColor = false;
            this.category.Click += new System.EventHandler(this.Category_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Makhazen.Properties.Resources._1;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // permession
            // 
            this.permession.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.permession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.permession.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permession.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.permession.Location = new System.Drawing.Point(12, 176);
            this.permession.Name = "permession";
            this.permession.Size = new System.Drawing.Size(97, 55);
            this.permession.TabIndex = 11;
            this.permession.Text = "اذن استلام";
            this.permession.UseVisualStyleBackColor = false;
            this.permession.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 350);
            this.Controls.Add(this.permession);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.sellbill);
            this.Controls.Add(this.buybill);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.customer_btn);
            this.Controls.Add(this.represent_btn);
            this.Controls.Add(this.product_btn);
            this.Controls.Add(this.sup_btn);
            this.Name = "Main";
            this.Text = "الصفحة الرئيسية ";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sup_btn;
        private System.Windows.Forms.Button product_btn;
        private System.Windows.Forms.Button represent_btn;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Button report_btn;
        private System.Windows.Forms.Button buybill;
        private System.Windows.Forms.Button sellbill;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button permession;
    }
}