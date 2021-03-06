using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sleep 
{
    public partial class Form2 : Form 
    {
        Module md = new Module();
        public static int Result { get; set; }

        public Form2()
        {
            InitializeComponent();
            rb1.Hide();
            rb2.Hide();
            rb3.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            md.Sum = md.Sum + Int32.Parse(textBox1.Text);
            textBox1.Hide();
            rb1.Show();
            rb2.Show();
            rb3.Show();
            button1.Hide();
            Restore();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(md.Index < 7)
            {
                Check();
                Restore();
                Form2.Result = md.Sum;
                Console.WriteLine(md.Sum);
            }
            else
            {
                Form3 f3 = new Form3();        
                this.Close();
                f3.Show();             
            }
        }

        private void Restore()
        {
            lb.Text = md.Question;
            rb1.Text = md.Answer_1;
            rb2.Text = md.Answer_2;
            rb3.Text = md.Answer_3;
        }

        public void Check()
        {
            if (rb1.Checked)
            {
                md.Index++;
                md.Sum = md.Sum + 2;
            }
            else if (rb2.Checked)
            {
                md.Index++;
                md.Sum = md.Sum + 1;
            }
            else if (rb3.Checked)
            {
                md.Index++;
                md.Sum = md.Sum + 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
