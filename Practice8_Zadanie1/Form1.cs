using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice8_Zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Student stud = new Student();
            if (textBox1.Text != "")
            {
                stud.name = textBox1.Text;
                stud.rost = (double)numericUpDown1.Value;
                MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()));
                double eat = 1;
                
                stud.SetEat(eat);
                MessageBox.Show(string.Format("Студент: {0} \ncъел еды: {1}  \nрост: {2} \nвес: {3}", stud.name, eat, stud.rost, stud.GetEat()));

                eat = 5;
                stud.SetEat(eat);
                MessageBox.Show(string.Format("Студент: {0}  \ncъел еды: {1} \nрост: {2} \nвес: {3}", stud.name, eat, stud.rost, stud.GetEat()));

                eat = 11;
                stud.SetEat(eat);
                MessageBox.Show(string.Format("Студент: {0}  \ncъел еды: {1} \nрост: {2} \nвес: {3}", stud.name, eat, stud.rost, stud.GetEat()));
            }
            else
            {
                MessageBox.Show("Введите имя и фамилию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);     
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
