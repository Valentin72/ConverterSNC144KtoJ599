using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Конвертер_СНЦ144К_в_J599
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            // XX сочетания контактов таблица соответсвия
            hash = new Hashtable();
            hash.Add("1QG/9", "NA");
            hash.Add("2/9", "02");
            hash.Add("3/9", "03");
            hash.Add("6/9", "35");
            hash.Add("9/9", "NA");
            hash.Add("1/11", "01");
            hash.Add("2/11", "02");
            hash.Add("4/11", "04");
            hash.Add("5/11", "05");
            hash.Add("6/11", "98");
            hash.Add("7/11", "99");
            hash.Add("13/11", "35");
            hash.Add("19/11", "NA");
            hash.Add("4/13", "04");
            hash.Add("8/13", "08");
            hash.Add("10/13", "98");
            hash.Add("22/13", "35");
            hash.Add("26/13", "NA");
            hash.Add("32/13", "NA");
            hash.Add("4/15", "38");
            hash.Add("5/15", "05");
            hash.Add("12/15", "97");
            hash.Add("15/15", "15");
            hash.Add("18/15", "18");
            hash.Add("19/15", "19");
            hash.Add("37/15", "35");
            hash.Add("55/15", "NA");
            hash.Add("2/17", "75");
            hash.Add("4/17", "NA");
            hash.Add("6/17", "06");
            hash.Add("8/17", "08");
            hash.Add("23/17", "99");
            hash.Add("26/17", "26");
            hash.Add("39/17", "NA");
            hash.Add("55/17", "35");
            hash.Add("73/17", "NA");
            hash.Add("11/19", "11");
            hash.Add("15/19", "NA");
            hash.Add("18/19", "18");
            hash.Add("32/19", "32");
            hash.Add("66/19", "35");
            hash.Add("88/19", "NA");
            hash.Add("4/21", "NA");
            hash.Add("4А/21", "NA");
            hash.Add("11/21", "NA");
            hash.Add("16/21", "16");
            hash.Add("20/21", "NA");
            hash.Add("39/21", "39");
            hash.Add("41/21", "41");
            hash.Add("79/21", "35");
            hash.Add("121/21", "NA");
            hash.Add("6/23", "NA");
            hash.Add("14/23", "NA");
            hash.Add("21/23", "21");
            hash.Add("53/23", "53");
            hash.Add("55/23", "55");
            hash.Add("100/23", "35");
            hash.Add("151/23", "NA");
            hash.Add("8/25", "NA");
            hash.Add("11/25", "11");
            hash.Add("19/25", "19");
            hash.Add("24/25", "24");
            hash.Add("25/25", "NA");
            hash.Add("29/25", "29");
            hash.Add("30/25", "20");
            hash.Add("37/25", "37");
            hash.Add("42/25", "NA");
            hash.Add("43/25", "NA");
            hash.Add("46/25", "46");
            hash.Add("56/25", "04");
            hash.Add("61/25", "61");
            hash.Add("66/25", "NA");
            hash.Add("99/25", "NA");
            hash.Add("128/25", "35");
            hash.Add("187/25", "NA");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ну и зачем?");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ну и зачем?");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        // Translate
        string j599 = "J599/";
        string CASE_TYPE = "XX"; // 
        string CASE_SIZE = "X";
        string INSERT = "XX";  // INSERT ARRANGMENT
        string PIN_TYPE = "X";
        string POLARITY = "X";
        string CASECOAT = "X";
        string SOLDER_PINS = "";
        Hashtable hash;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cb1_text = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            string[] words = cb1_text.Split('/');

            comboBox2.SelectedIndex = comboBox2.Items.IndexOf(words[1]);
            if (words[0] != "1QG")
            {
                INSERT = hash[cb1_text].ToString(); 
                if(hash[cb1_text].ToString() == "NA")
                {
                    INSERT = "NA"; labelError.Text = "NA - NOT APPLICABLE... нет такого в J599";
                    textBox1.BackColor = Color.Red;
                }
                else
                {
                    labelError.Text = "Нет ошибок";
                    textBox1.BackColor = Color.WhiteSmoke;
                }

            }
            else
            {
                INSERT = "NA"; labelError.Text = "NA - NOT APPLICABLE... нет такого в J599";
                textBox1.BackColor = Color.Red;
            }
                

            switch (Int32.Parse(words[1]))
            {
                case 9: CASE_SIZE = "A"; break;
                case 11: CASE_SIZE = "B"; break;
                case 13: CASE_SIZE = "C"; break;
                case 15: CASE_SIZE = "D"; break;
                case 17: CASE_SIZE = "E"; break;
                case 19: CASE_SIZE = "F"; break;
                case 21: CASE_SIZE = "G"; break;
                case 23: CASE_SIZE = "H"; break;
                case 25: CASE_SIZE = "J"; break;
                default:;break;
            }

            update_out();//textBox1.Text = j599 + FLANGE + PIN_TYPE + POLARITY + CASECOAT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_out();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // pin type
            if (comboBox3.Items[comboBox3.SelectedIndex].ToString() == "В")
                PIN_TYPE = "P";
            else
                PIN_TYPE = "S";
            update_out();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            POLARITY = comboBox7.Items[comboBox7.SelectedIndex].ToString();
            update_out();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FLANGE
            
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CADMIUM STEEL NIKEL
            CASECOAT = comboBox8.Items[comboBox8.SelectedIndex].ToString();
            update_out();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CASE TYPE
            if (comboBox9.Items[comboBox9.SelectedIndex].ToString() == "П")
                CASE_TYPE = "20";
            else if (comboBox9.Items[comboBox9.SelectedIndex].ToString() == "К")
                CASE_TYPE = "26";
            else
                CASE_TYPE = "24";
            update_out();
        }
        private void update_out()
        {
            textBox1.Text = j599 + CASE_TYPE + CASECOAT + CASE_SIZE + INSERT + PIN_TYPE + POLARITY + SOLDER_PINS;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SOLSER
            if (comboBox4.Items[comboBox4.SelectedIndex].ToString() == "О")
            { SOLDER_PINS = ""; comboBox5.SelectedIndex = 0;  }
            else
            { SOLDER_PINS = "H"; comboBox5.SelectedIndex = 1;  }
            update_out();
        }
    }
}
