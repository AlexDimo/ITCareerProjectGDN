﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBox_GNA.View.CustomControls.Tabs.Design;
using UserInfo.Controller;
using UserInfo.Service;

namespace ToolBox_GNA.View.CustomControls.Tabs
{
	public partial class TabHome : ControlDesign
	{
		public TabHome()
		{
			InitializeComponent();
		}

		private void TabHome_Load(object sender, EventArgs e)
		{
			//Sets the Welcome text
			LblWelcome.Text = $"Welcome {UserController.GetUsername()}, Here is some information about you:";

			//Gets information about user
			RtbUserInfo.Text = UserController.GetUserInfo();
		}

		private void BtnChangePassword_Click(object sender, EventArgs e)
		{
			if (TbPassword.Text != "")
			{
				UserService.ChangeUserPassword(TbPassword.Text);
			}
			RtbUserInfo.Text = $"Congratulations your new password is: \"{TbPassword.Text}\"";
			TbPassword.Text = "";
		}
	}
}
