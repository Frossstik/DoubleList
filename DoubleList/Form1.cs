using DoublyConnectedDeck;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoubleList
{
    public partial class Form1 : Form
    {
        private DoublyLinkedList<Minions> doublyLinkeedList = new DoublyLinkedList<Minions>();
        public Form1()
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
                doublyLinkeedList.Add(minions);
                MessageBox.Show("Успех!", "Сообщение");
            }
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Одно из полей пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /* foreach (var m in doublyLinkeedList)
                 {
                     if (m.id == Convert.ToInt32(textBox1.Text))
                     {
                         m.name = textBox2.Text;
                         m.age = Convert.ToInt32(textBox3.Text);
                     }
                 }*/
                doublyLinkeedList[Convert.ToInt32(textBox1.Text) - 1].name = textBox2.Text;
                doublyLinkeedList[Convert.ToInt32(textBox1.Text) - 1].age = Convert.ToInt32(textBox3.Text);
                MessageBox.Show("Успех!", "Сообщение");
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Minions temp =  doublyLinkeedList.Remove();
            textBox4.Text += temp.id + ") " + temp.name + " " + temp.age;
            MessageBox.Show("Успех!", "Сообщение");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (var m in doublyLinkeedList)
            {
                richTextBox1.Text += m.id + ") " + m.name + " " + m.age + Environment.NewLine;
            }
            richTextBox1.Update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            doublyLinkeedList.Clear();
            richTextBox1.Clear();
            richTextBox1.Update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Close();

        }
    }
}
