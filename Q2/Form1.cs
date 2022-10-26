using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblBirth.Visible = false;
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			//取得使用者輸入值
			
			DateTime today = DateTime.Today;

			string date = txtBirth.Text;
			bool isDate = DateTime.TryParse(date, out DateTime birth);

			if(isDate == false) 
			{
				MessageBox.Show("請重新輸入");
				return; 
			}


			//判斷日期
			string result;
			if (birth < today)
			{
				result = $"您的生日是{birth:yyyy/MM/dd}";
			}
			else
			{
				result = ($"生日不能晚於今天{today:yyyy/MM/dd}");
			}

			//輸出
			lblBirth.Visible = true;
			lblBirth.Text= result;
		}

	}
}
