using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int sch = 0;
        public Form1()
        {
            InitializeComponent();
            textBox2.KeyPress += (sender, e) => e.Handled = true;
            
        }
        

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
       
        }



        public void button1_Click(object sender, EventArgs e)
        {
            string[] mas_rus = new string[5] { "Екатеринбург", "Омск", "Катайск", "Новоуральск", "Москва" };
            string[] mas_china = new string[5] { "Шэньчжэнь", "Пекин", "Шанхай", "Чэнду", "Чугучак" };
            string[] mas_japan = new string[5] { "Токио", "Осака", "Киото", "Сайтама", "Кавасаки" };
            string[] mas_usa = new string[5] { "Вашингтон", "Нью-Йорк", "Чикаго", "Хьюстон", "Остин" };
            string[] mas_belarus = new string[5] { "Полоцк", "Минск", "Брест", "Могилёв", "Гродно" };
            string[] mas_mexico = new string[5] { "Матаморос", "Оахака", "Пуэбла", "Канкун", "Мерида" };
            string[][] rand_mas = new string[][] {mas_rus, mas_usa, mas_belarus, mas_japan, mas_china, mas_mexico };

            Random rnd = new Random();
            int i = rnd.Next(0, 6);
            int j = rnd.Next(0, 5);

            textBox2.Text = rand_mas[i][j].ToString();
            label4.Text = "";
            comboBox1.SelectedIndex = -1;
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            string[] mas_rus = new string[5] { "Екатеринбург", "Омск", "Катайск", "Новоуральск", "Москва" };
            string[] mas_china = new string[5] { "Шэньчжэнь", "Пекин", "Шанхай", "Чэнду", "Чугучак" };
            string[] mas_japan = new string[5] { "Токио", "Осака", "Киото", "Сайтама", "Кавасаки" };
            string[] mas_usa = new string[5] { "Вашингтон", "Нью-Йорк", "Чикаго", "Хьюстон", "Остин" };
            string[] mas_belarus = new string[5] { "Полоцк", "Минск", "Брест", "Могилёв", "Гродно" };
            string[] mas_mexico = new string[5] { "Матаморос", "Оахака", "Пуэбла", "Канкун", "Мерида" };

            string text = textBox2.Text;
            string a, b;

            a = textBox2.Text;
           
            if (comboBox1.Text == "Китай")
            {
                for(int i = 0; i<5; i++)
                {
                    b = mas_china[i];
                    if (a==b)
                    {
                        label4.Text = "Правильно";
                        i = 5;
                    }
                    else
                    {
                        label4.Text = "Неправильно";
                    }
                }
                Console.WriteLine("a=", a);
            }
            else if (comboBox1.Text == "Россия")
            {
                for (int i = 0; i < 5; i++)
                {
                    b = mas_rus[i];
                    if (a == b)
                    {
                        label4.Text = "Правильно";
                        i = 5;
                    }
                    else
                    {
                        label4.Text = "Неправильно";
                    }
                }
            }
            else if (comboBox1.Text == "Япония")
            {
                for (int i = 0; i < 5; i++)
                {
                    b = mas_japan[i];
                    if (a == b)
                    {
                        label4.Text = "Правильно";
                        i = 5;
                    }
                    else
                    {
                        label4.Text = "Неправильно";
                    }
                }
            }
            else if (comboBox1.Text == "США")
            {
                for (int i = 0; i < 5; i++)
                {
                    b = mas_usa[i];
                    if (a == b)
                    {
                        label4.Text = "Правильно";
                        i = 5;
                    }
                    else
                    {
                        label4.Text = "Неправильно";
                    }
                }
            }
            else if (comboBox1.Text == "Мексика")
            {
                for (int i = 0; i < 5; i++)
                {
                    b = mas_mexico[i];
                    if (a == b)
                    {
                        label4.Text = "Правильно";
                        i = 5;
                    }
                    else
                    {
                        label4.Text = "Неправильно";
                    }
                }
            }
            else if (comboBox1.Text == "Беларусь")
            {
                for (int i = 0; i < 5; i++)
                {
                    b = mas_belarus[i];
                    if (a == b)
                    {
                        label4.Text = "Правильно";
                        i = 5;
                    }
                    else
                    {
                        label4.Text = "Неправильно";
                    }
                }
            }

            if(textBox2.Text=="")
            {
                label4.Text = "";
                MessageBox.Show("Сгенерируйте город!!!","快来吧!");
            }

            if (comboBox1.Text == "")
            {
                label4.Text = "";
                MessageBox.Show("Выберите страну!!!","快来吧");
            }

            if (label4.Text=="Правильно")
            {
                sch += 1;
            }


            if (label4.Text == "Неправильно")
            {
                sch = 0;
            }

            label6.Text = sch.ToString();
            sch = Convert.ToInt32(sch);
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
