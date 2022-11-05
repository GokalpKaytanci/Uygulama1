namespace WinFormsApp1
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);
            int c = int.Parse(textBox5.Text);
            int d = int.Parse(textBox2.Text);
            int hacim = a * b * c / 1000;
            textBox8.Text = hacim.ToString();
            int hacimsonuc = hacim / 3;
            if (hacim / 3 > d)
            {
                textBox6.Text = hacimsonuc.ToString();
            }
            else
            {
                textBox6.Text = d.ToString();
            }

            
        }
    }
}