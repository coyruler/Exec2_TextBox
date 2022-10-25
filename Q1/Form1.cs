using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number ;
            //取得輸入值
            try
            {
                number = GetNumber();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            //比較介於1-99

            int value1 = 1;
            int value2 = 99;
            string result;
            if(number<=99 && number >= 1)
            {
                result=($"{number}介於{value1}到{value2}");
            }
            else
            {
                result = ($"{number}不介於{value1}到{value2}");
            }
            //顯示結果
            lblResult.Text = result;
        }

        private int GetNumber()
         {
            string value = txtNumber.Text;
            bool isInt = int.TryParse(value, out int number);
            return isInt ? number : throw new Exception("必須填寫數值");        
         }

    }
    
}
