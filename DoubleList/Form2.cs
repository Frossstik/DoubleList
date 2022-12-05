using DoublyConnectedDeck;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoubleList
{
    public partial class Form2 : Form
    {
        private Stack<Minions> stack1 = new Stack<Minions>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Поле с именем или возрастом пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Minions minions = new Minions();
                minions.name = textBox2.Text;
                minions.age = Convert.ToInt32(textBox3.Text);
                stack1.Push(minions);
                MessageBox.Show("Успех!", "Сообщение");
            }
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Minions temp = stack1.Pop();
            textBox1.Text += temp.id + ") " + temp.name + " " + temp.age;
            MessageBox.Show("Успех!", "Сообщение");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (var m in stack1)
            {
                richTextBox1.Text += m.id + ") " + m.name + " " + m.age + Environment.NewLine;
            }

            richTextBox1.Update();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            stack1.Clear();
            richTextBox1.Clear();
            richTextBox1.Update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stack1.Sort();
            MessageBox.Show("Успех!", "Сообщение");
        }
    }
}
