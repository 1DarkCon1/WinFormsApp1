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
            // ��������� ����������
            int a, b, c;
            // ������ ������������� ������ �� textBox1.Text � ����� �����
            bool rez1 = int.TryParse(textBox1.Text, out a);
            if (rez1 == false) // ���� �������� �� ������ ��������������
            { // �� ������� ��������� � ����������� ������ ������
                MessageBox.Show(" �������� ������ ����� " + textBox1.Text + "!");
                return; // ����������� ������ ������
            }
            // ������ ������������� ������ �� textBox2.Text � ����� �����
            bool rez2 = int.TryParse(textBox2.Text, out b);
            if (rez2 == false) // ���� �������� �� ������ ��������������
            { // �� ������� ��������� � ����������� ������ ������
                MessageBox.Show(" �������� ������ ����� " + textBox2.Text + "!");
                return; // ����������� ������ ������
            }
            c = (10 * a + 15 * b) / 2;
            string cStr = c.ToString();
            label2.Text = cStr;
            return; // ����������� ������ ������
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}