﻿namespace Makhazen
{
    partial class reports
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
            this.dayMove = new System.Windows.Forms.Button();
            this.moveMonth = new System.Windows.Forms.Button();
            this.report_product = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayMove
            // 
            this.dayMove.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dayMove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dayMove.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayMove.ForeColor = System.Drawing.Color.White;
            this.dayMove.Location = new System.Drawing.Point(67, 90);
            this.dayMove.Name = "dayMove";
            this.dayMove.Size = new System.Drawing.Size(510, 39);
            this.dayMove.TabIndex = 0;
            this.dayMove.Text = "تقرير الفواتير ";
            this.dayMove.UseVisualStyleBackColor = false;
            this.dayMove.Click += new System.EventHandler(this.DayMove_Click);
            // 
            // moveMonth
            // 
            this.moveMonth.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.moveMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moveMonth.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveMonth.ForeColor = System.Drawing.Color.White;
            this.moveMonth.Location = new System.Drawing.Point(67, 135);
            this.moveMonth.Name = "moveMonth";
            this.moveMonth.Size = new System.Drawing.Size(510, 39);
            this.moveMonth.TabIndex = 1;
            this.moveMonth.Text = "تقرير المنتجات علي وشك الانتهاء";
            this.moveMonth.UseVisualStyleBackColor = false;
            this.moveMonth.Click += new System.EventHandler(this.MoveMonth_Click);
            // 
            // report_product
            // 
            this.report_product.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.report_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.report_product.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_product.ForeColor = System.Drawing.Color.White;
            this.report_product.Location = new System.Drawing.Point(67, 180);
            this.report_product.Name = "report_product";
            this.report_product.Size = new System.Drawing.Size(510, 39);
            this.report_product.TabIndex = 2;
            this.report_product.Text = "تقرير المنتجات الراكده";
            this.report_product.UseVisualStyleBackColor = false;
            this.report_product.Click += new System.EventHandler(this.Report_product_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(67, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(510, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "رجوع";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(67, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(510, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "تقرير المنتجات التالفة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.report_product);
            this.Controls.Add(this.moveMonth);
            this.Controls.Add(this.dayMove);
            this.Name = "reports";
            this.Text = "reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dayMove;
        private System.Windows.Forms.Button moveMonth;
        private System.Windows.Forms.Button report_product;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}