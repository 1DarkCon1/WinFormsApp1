namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // описываем переменные
            int a, b, c;
            // пытаем преобразовать строку из textBox1.Text в целое число
            bool rez1 = int.TryParse(textBox1.Text, out a);
            if (rez1 == false) // если возникла ли ошибка преобразования
            { // то выводим сообщение и заканчиваем работу метода
                MessageBox.Show(" Неверный формат числа " + textBox1.Text + "!");
                return; // заканчиваем работу метода
            }
            // пытаем преобразовать строку из textBox2.Text в целое число
            bool rez2 = int.TryParse(textBox2.Text, out b);
            if (rez2 == false) // если возникла ли ошибка преобразования
            { // то выводим сообщение и заканчиваем работу метода
                MessageBox.Show(" Неверный формат числа " + textBox2.Text + "!");
                return; // заканчиваем работу метода
            }
            c = (10 * a + 15 * b) / 2;
            string cStr = c.ToString();
            label2.Text = cStr;
            return; // заканчиваем работу метода
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}