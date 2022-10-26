using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 單一乘法表
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.SelectedIndex = 0;
		}

		private void btnCaculate_Click(object sender, EventArgs e)
		{
			string value = comboBox1.SelectedIndex.ToString();
			int firstNumber = Convert.ToInt32(value);
			string result = string.Empty;
			for (int i = 1; i < 10; i++)
			{
				
				result += $"{firstNumber}*{i}={firstNumber * i}\r\n";
			}
			txtForm.Text = result;
		}
	}
}
