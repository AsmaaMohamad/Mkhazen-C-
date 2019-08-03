namespace Makhazen
{
    partial class Reprisentative
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
            this.repnme = new System.Windows.Forms.TextBox();
            this.phonnume = new System.Windows.Forms.TextBox();
            this.repId = new System.Windows.Forms.TextBox();
            this.phonNum = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.Label();
            this.repName = new System.Windows.Forms.Label();
            this.deletrep = new System.Windows.Forms.Button();
            this.editRep = new System.Windows.Forms.Button();
            this.addRep = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.RepresentativeData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.repadress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RepresentativeData)).BeginInit();
            this.SuspendLayout();
            // 
            // repnme
            // 
            this.repnme.Location = new System.Drawing.Point(500, 149);
            this.repnme.Multiline = true;
            this.repnme.Name = "repnme";
            this.repnme.Size = new System.Drawing.Size(214, 42);
            this.repnme.TabIndex = 17;
            // 
            // phonnume
            // 
            this.phonnume.Location = new System.Drawing.Point(503, 207);
            this.phonnume.Multiline = true;
            this.phonnume.Name = "phonnume";
            this.phonnume.Size = new System.Drawing.Size(214, 35);
            this.phonnume.TabIndex = 16;
            // 
            // repId
            // 
            this.repId.Enabled = false;
            this.repId.Location = new System.Drawing.Point(499, 97);
            this.repId.Multiline = true;
            this.repId.Name = "repId";
            this.repId.Size = new System.Drawing.Size(214, 38);
            this.repId.TabIndex = 15;
            // 
            // phonNum
            // 
            this.phonNum.AutoSize = true;
            this.phonNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonNum.Location = new System.Drawing.Point(761, 207);
            this.phonNum.Name = "phonNum";
            this.phonNum.Size = new System.Drawing.Size(104, 25);
            this.phonNum.TabIndex = 14;
            this.phonNum.Text = "رقم التليفون";
            // 
            // productID
            // 
            this.productID.AutoSize = true;
            this.productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productID.Location = new System.Drawing.Point(760, 100);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(118, 25);
            this.productID.TabIndex = 13;
            this.productID.Text = "رقم المتسلسل";
            // 
            // repName
            // 
            this.repName.AutoSize = true;
            this.repName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repName.Location = new System.Drawing.Point(761, 152);
            this.repName.Name = "repName";
            this.repName.Size = new System.Drawing.Size(108, 25);
            this.repName.TabIndex = 18;
            this.repName.Text = "اسم المندوب";
            // 
            // deletrep
            // 
            this.deletrep.BackColor = System.Drawing.Color.Red;
            this.deletrep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletrep.ForeColor = System.Drawing.Color.White;
            this.deletrep.Location = new System.Drawing.Point(416, 364);
            this.deletrep.Name = "deletrep";
            this.deletrep.Size = new System.Drawing.Size(131, 50);
            this.deletrep.TabIndex = 21;
            this.deletrep.Text = "حذف مندوب";
            this.deletrep.UseVisualStyleBackColor = false;
            this.deletrep.Click += new System.EventHandler(this.deletrep_Click);
            // 
            // editRep
            // 
            this.editRep.BackColor = System.Drawing.Color.Peru;
            this.editRep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRep.ForeColor = System.Drawing.Color.White;
            this.editRep.Location = new System.Drawing.Point(584, 367);
            this.editRep.Name = "editRep";
            this.editRep.Size = new System.Drawing.Size(130, 50);
            this.editRep.TabIndex = 20;
            this.editRep.Text = "تعديل ";
            this.editRep.UseVisualStyleBackColor = false;
            this.editRep.Click += new System.EventHandler(this.editRep_Click);
            // 
            // addRep
            // 
            this.addRep.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addRep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRep.ForeColor = System.Drawing.Color.White;
            this.addRep.Location = new System.Drawing.Point(750, 364);
            this.addRep.Name = "addRep";
            this.addRep.Size = new System.Drawing.Size(128, 50);
            this.addRep.TabIndex = 19;
            this.addRep.Text = "اضافه مندوب";
            this.addRep.UseVisualStyleBackColor = false;
            this.addRep.Click += new System.EventHandler(this.AddRep_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Tomato;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(71, 364);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(146, 50);
            this.back.TabIndex = 22;
            this.back.Text = "رجوع";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.ForeColor = System.Drawing.Color.White;
            this.show.Location = new System.Drawing.Point(243, 364);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(142, 50);
            this.show.TabIndex = 23;
            this.show.Text = "عرض";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // RepresentativeData
            // 
            this.RepresentativeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RepresentativeData.Location = new System.Drawing.Point(35, 67);
            this.RepresentativeData.Name = "RepresentativeData";
            this.RepresentativeData.Size = new System.Drawing.Size(435, 237);
            this.RepresentativeData.TabIndex = 30;
            this.RepresentativeData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RepresentativeData_CellDoubleClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(731, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "بيانات المندوب";
            // 
            // repadress
            // 
            this.repadress.Location = new System.Drawing.Point(499, 269);
            this.repadress.Multiline = true;
            this.repadress.Name = "repadress";
            this.repadress.Size = new System.Drawing.Size(214, 35);
            this.repadress.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(766, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "االعنوان";
            // 
            // Reprisentative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 479);
            this.Controls.Add(this.repadress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepresentativeData);
            this.Controls.Add(this.show);
            this.Controls.Add(this.back);
            this.Controls.Add(this.deletrep);
            this.Controls.Add(this.editRep);
            this.Controls.Add(this.addRep);
            this.Controls.Add(this.repName);
            this.Controls.Add(this.repnme);
            this.Controls.Add(this.phonnume);
            this.Controls.Add(this.repId);
            this.Controls.Add(this.phonNum);
            this.Controls.Add(this.productID);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Reprisentative";
            this.Text = "بيانات المندوب";
            this.Load += new System.EventHandler(this.Reprisentative_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepresentativeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox repnme;
        private System.Windows.Forms.TextBox phonnume;
        private System.Windows.Forms.TextBox repId;
        private System.Windows.Forms.Label phonNum;
        private System.Windows.Forms.Label productID;
        private System.Windows.Forms.Label repName;
        private System.Windows.Forms.Button deletrep;
        private System.Windows.Forms.Button editRep;
        private System.Windows.Forms.Button addRep;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.DataGridView RepresentativeData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repadress;
        private System.Windows.Forms.Label label2;
    }
}