﻿namespace inventory.view
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.tab = new System.Windows.Forms.TabControl();
            this.dash = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.transac = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.dash.SuspendLayout();
            this.stock.SuspendLayout();
            this.transac.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tab.Controls.Add(this.dash);
            this.tab.Controls.Add(this.stock);
            this.tab.Controls.Add(this.transac);
            this.tab.Location = new System.Drawing.Point(109, 3);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(928, 647);
            this.tab.TabIndex = 0;
            // 
            // dash
            // 
            this.dash.BackColor = System.Drawing.Color.White;
            this.dash.Controls.Add(this.label2);
            this.dash.Location = new System.Drawing.Point(4, 25);
            this.dash.Name = "dash";
            this.dash.Padding = new System.Windows.Forms.Padding(3);
            this.dash.Size = new System.Drawing.Size(920, 618);
            this.dash.TabIndex = 0;
            this.dash.Text = "DASHBOARD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "DASHBOARD";
            // 
            // stock
            // 
            this.stock.BackColor = System.Drawing.Color.White;
            this.stock.Controls.Add(this.label4);
            this.stock.Location = new System.Drawing.Point(4, 25);
            this.stock.Name = "stock";
            this.stock.Padding = new System.Windows.Forms.Padding(3);
            this.stock.Size = new System.Drawing.Size(920, 568);
            this.stock.TabIndex = 1;
            this.stock.Text = "STOCKS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "STOCKS";
            // 
            // transac
            // 
            this.transac.BackColor = System.Drawing.Color.White;
            this.transac.Controls.Add(this.label3);
            this.transac.Location = new System.Drawing.Point(4, 25);
            this.transac.Name = "transac";
            this.transac.Padding = new System.Windows.Forms.Padding(3);
            this.transac.Size = new System.Drawing.Size(920, 609);
            this.transac.TabIndex = 2;
            this.transac.Text = "TRANSACTIONS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "TRANSACTIONS";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::inventory.Properties.Resources.transac64;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(20, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 71);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::inventory.Properties.Resources.stock64;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.Location = new System.Drawing.Point(20, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 71);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::inventory.Properties.Resources.dash64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(20, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 72);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::inventory.Properties.Resources._64x64;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(20, 569);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 71);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 652);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.home_Load);
            this.tab.ResumeLayout(false);
            this.dash.ResumeLayout(false);
            this.dash.PerformLayout();
            this.stock.ResumeLayout(false);
            this.stock.PerformLayout();
            this.transac.ResumeLayout(false);
            this.transac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage dash;
        private System.Windows.Forms.TabPage stock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage transac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}