using System;
using System.IO;
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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            Console.WriteLine(Form2.Result);
            if(Form2.Result <= 10)
            {
                pictureBox1.Image = Image.FromFile("bad.jpg");
                label1.Text = "Ваш результат:" + Form2.Result + "из 24\nВы ужасно спите, советую обратиться к специалисту";
            }
            else if(Form2.Result > 10 && Form2.Result <= 20)
            {
                pictureBox1.Image = Image.FromFile("normal.jfif");
                label1.Text = "Ваш результат:" + Form2.Result + "из 24\nУ вас хороший сон, " +
                    "может быть, вам стоит принимать снотворное\n для восстановления режима ";
            }
            else if(Form2.Result > 20)
            {
                pictureBox1.Image = Image.FromFile("good.jfif");
                label1.Text = "Ваш результат:" + Form2.Result + "из 24\nУ вас прекрасный здоровый сон, так держать";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("result.txt", false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(Form2.Result);
                }
            }
            catch
            {
                Console.WriteLine("Готово");
            }
        }
    }
}
