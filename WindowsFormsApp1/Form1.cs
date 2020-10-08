using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string[] dirs = Directory.GetFiles(@"photo");
            InitializeComponent();
            pictureBox1.Load(dirs[0]);
            save_data.Text = dirs[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("about.png", "Сама цікава і функціональна програма! Купіть мене!");
            f2.Show();
            f2.Text = "About";
            this.Hide();
        }

        private void massageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("error.png", "Трапилася помилка! Все для Вас і безкоштовно!");
            f2.Show();
            f2.Text = "Message";
            this.Hide();
        }

        private void Massage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Повідомлення");
        }


        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
    "Ви дійсно хочете вийти з програми",
    "Завершення роботи",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning
   );
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            string[] dirs = Directory.GetFiles(@"photo");
            for(int i = 0; i < dirs.Length; i++)
            {
                if (save_data.Text == dirs[i])
                {
                    if (i + 1 != dirs.Length)
                    {
                        save_data.Text = dirs[i + 1];
                        pictureBox1.Load(save_data.Text);
                        break;
                    }
                    if (i + 1 == dirs.Length)
                    {
                        save_data.Text = dirs[0];
                        pictureBox1.Load(save_data.Text);
                        break;
                    }
                }
            }
        }
    }
}
