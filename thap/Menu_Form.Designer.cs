﻿namespace thap
{
	partial class Menu_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
			this.button2 = new System.Windows.Forms.Button();
			this.click_exit = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.BackgroundImage = global::thap.Properties.Resources.text_luật_chơi;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new System.Drawing.Point(138, 211);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(158, 40);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// click_exit
			// 
			this.click_exit.BackColor = System.Drawing.Color.Transparent;
			this.click_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.click_exit.Image = global::thap.Properties.Resources.text_exit;
			this.click_exit.Location = new System.Drawing.Point(168, 257);
			this.click_exit.Name = "click_exit";
			this.click_exit.Size = new System.Drawing.Size(94, 44);
			this.click_exit.TabIndex = 2;
			this.click_exit.UseVisualStyleBackColor = false;
			this.click_exit.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = global::thap.Properties.Resources.text_play;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(168, 160);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 45);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Location = new System.Drawing.Point(75, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(297, 123);
			this.panel1.TabIndex = 3;
			// 
			// Menu_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::thap.Properties.Resources.menu;
			this.ClientSize = new System.Drawing.Size(465, 438);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.click_exit);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Menu_Form";
			this.Text = "Menu_Form";
			this.Load += new System.EventHandler(this.Menu_Form_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button click_exit;
		private System.Windows.Forms.Panel panel1;
	}
}