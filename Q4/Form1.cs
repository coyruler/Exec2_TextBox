using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblResult.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string result = string.Empty;
			int charge;

			//取車輸入值
			charge =GetInt(txtcars.Text);
			//費用
			int carsFee = charge * 200;

			//取人輸入值
			charge = GetInt(txtPeople.Text);
			//費用
			int pepplrFee = charge * 60;

			//輸出結果
			if(carsFee>0 && pepplrFee > 0)
			{
				MessageBox.Show("只能選一種計費方式");
				return;
			}
			else if (carsFee>0)
			{
				result = ($"費用為{carsFee}元");
			}
			else
			{
				result = ($"費用為{pepplrFee}元");
			}
			lblResult.Visible = true;
			lblResult.Text = result;

			

		}
		private int GetInt(string type)
		{
			bool isInt1 = int.TryParse(type, out int charge);
			if (isInt1 == false)
			{
				MessageBox.Show("只能輸入數字");				
			}
			if (charge < 0)
			{
				MessageBox.Show("只能輸入大於或等於0的整數");
			}
			
			return charge;
		

		}

	}
}
