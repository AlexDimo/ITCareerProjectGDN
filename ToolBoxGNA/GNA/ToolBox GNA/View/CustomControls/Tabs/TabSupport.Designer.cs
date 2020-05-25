﻿namespace ToolBox_GNA.View.CustomControls.Tabs
{
	partial class TabSupport
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.TbMessage = new System.Windows.Forms.TextBox();
			this.BtnSend = new System.Windows.Forms.Button();
			this.LbUsers = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TimerRefreshChat = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(154, 52);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(376, 316);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// TbMessage
			// 
			this.TbMessage.Location = new System.Drawing.Point(154, 386);
			this.TbMessage.Name = "TbMessage";
			this.TbMessage.Size = new System.Drawing.Size(265, 20);
			this.TbMessage.TabIndex = 1;
			// 
			// BtnSend
			// 
			this.BtnSend.Location = new System.Drawing.Point(455, 384);
			this.BtnSend.Name = "BtnSend";
			this.BtnSend.Size = new System.Drawing.Size(75, 23);
			this.BtnSend.TabIndex = 2;
			this.BtnSend.Text = "Send";
			this.BtnSend.UseVisualStyleBackColor = true;
			this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
			// 
			// LbUsers
			// 
			this.LbUsers.FormattingEnabled = true;
			this.LbUsers.Location = new System.Drawing.Point(13, 52);
			this.LbUsers.Name = "LbUsers";
			this.LbUsers.Size = new System.Drawing.Size(120, 355);
			this.LbUsers.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(10, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Chat to:";
			// 
			// TimerRefreshChat
			// 
			this.TimerRefreshChat.Tick += new System.EventHandler(this.TimerRefreshChat_Tick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(328, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Chat ";
			// 
			// TabSupport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LbUsers);
			this.Controls.Add(this.BtnSend);
			this.Controls.Add(this.TbMessage);
			this.Controls.Add(this.richTextBox1);
			this.Name = "TabSupport";
			this.Load += new System.EventHandler(this.TabSupport_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox TbMessage;
		private System.Windows.Forms.Button BtnSend;
		private System.Windows.Forms.ListBox LbUsers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer TimerRefreshChat;
		private System.Windows.Forms.Label label2;
	}
}
