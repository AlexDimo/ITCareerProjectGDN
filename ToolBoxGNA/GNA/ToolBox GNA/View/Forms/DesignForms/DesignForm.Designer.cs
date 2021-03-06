﻿namespace ToolBox_GNA.View.Forms.DesignForms
{
	partial class DesignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
            this.PanelBorder = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.PanelBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBorder
            // 
            this.PanelBorder.Controls.Add(this.ButtonMinimize);
            this.PanelBorder.Controls.Add(this.ButtonExit);
            this.PanelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBorder.Location = new System.Drawing.Point(0, 0);
            this.PanelBorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelBorder.Name = "PanelBorder";
            this.PanelBorder.Size = new System.Drawing.Size(460, 34);
            this.PanelBorder.TabIndex = 0;
            this.PanelBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBorder_MouseMove);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackgroundImage = global::ToolBox_GNA.Properties.Resources.MinimizeButtonPicture;
            this.ButtonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.Location = new System.Drawing.Point(390, 0);
            this.ButtonMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(35, 34);
            this.ButtonMinimize.TabIndex = 1;
            this.ButtonMinimize.UseVisualStyleBackColor = true;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackgroundImage = global::ToolBox_GNA.Properties.Resources.CloseButtonPicture;
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Location = new System.Drawing.Point(425, 0);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(35, 34);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(460, 590);
            this.Controls.Add(this.PanelBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DesignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainDesign";
            this.PanelBorder.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PanelBorder;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.Button ButtonMinimize;
	}
}

