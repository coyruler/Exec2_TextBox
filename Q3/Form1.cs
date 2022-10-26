using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
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
			string result=string.Empty;
			if (isDate == false)
			{
				MessageBox.Show("請重新輸入");
				return;
			}
			
			if (birth> today)
			{
				result = ($"生日不能晚於今天{today:yyyy/MM/dd}");
				lblBirth.Visible = true;
				lblBirth.Text = result;
				return;
			}

			//計算年齡
			int birthYear = birth.Year;
			int todayYear = today.Year;
			int year = todayYear - birthYear;
						
			if (year >-1 && year<13)
			{
				result = $"您今年{year}歲,未滿13歲";
			}
			else
			{
				result = $"您今年{year}歲";
			}
			
			//輸出
			lblBirth.Visible = true;
			lblBirth.Text = result;
		}
	}
}
