using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string tahminKelime = "muvaffakiyetsizleştirebileceklerimiştenmişsizcesine";

        char[] tahminEdilen = new char[tahminKelime.Length];
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;

            for (int i = 0; i < tahminKelime.Length; i++)
            {
                tahminEdilen[i] = '_';
            }

        }

        int sayac = 0;

        private void button8_Click(object sender, EventArgs e)
        {
            int sayac1 = 0;
            label1.Text = "";
            label2.Text = "";

            if (tahminKelime.IndexOf(textBox1.Text[0]) >= 0)
            {
                foreach (var item in tahminKelime)
                {
                    if (textBox1.Text[0] == item)
                    {
                        tahminEdilen[sayac1] = item;
                    }
                    sayac1++;
                }
                foreach (var item in tahminEdilen)
                {
                    label1.Text += item + " ";
                    label2.Text += item;
                }
            }
            else
            {

                AdamAs(sayac);
                sayac++;
            }

            label2.Text = label2.Text.Trim(' ');
            if (label2.Text == tahminKelime)
            {
                DialogResult = MessageBox.Show("Kazandınız");
                if (DialogResult == DialogResult.OK) this.Close();
            }
            textBox1.Text = "";
        }

        private void AdamAs(int sayac)
        {
            foreach (var item in tahminEdilen)
            {
                label1.Text += item + " ";
            }
            switch (sayac)
            {
                case 0:
                    button2.Visible = true; break;
                case 1:
                    button3.Visible = true; break;
                case 2:
                    button4.Visible = true; break;
                case 3:
                    button5.Visible = true; break;
                case 4:
                    button6.Visible = true; break;
                case 5:
                    button7.Visible = true; break;
                default:
                    GameOver();
                    break;
            }
        }

        private void GameOver()
        {
            DialogResult result = MessageBox.Show($"{tahminKelime}\nOyun Bitti", "Yandınız", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {

                Form1 form1 = new Form1();
                this.Close();
                form1.Show();
            }
            else
            {
                this.Close();
            }
        }

    }
}
