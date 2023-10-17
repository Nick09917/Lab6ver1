using System.Text;

namespace labver6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder digits = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {

            string predl = textBox1.Text;
             textBox1.Clear();

            foreach (char c in predl)
            {
                if (Char.IsDigit(c))
                {
                    digits.Append(" ");
                    digits.Append(c);
                }
            }
            if (digits.Length == 0)
            {
                textBox1.Text = "В Вашм Тексте нет цифр проверьте все";
            }
            else
            {

                textBox1.Clear(); // Очищаем текстовое поле перед выводом цифр.

                textBox1.Text = digits.ToString();
                digits.Clear();
                // Выводим цифры в текстовое поле.
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}