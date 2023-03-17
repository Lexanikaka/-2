namespace WinFormsApp6
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

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox2.Text);
            double y = double.Parse(textBox1.Text);
            double z = double.Parse(textBox3.Text);
            textBox4.Text = "Результати роботи програми" + " Дмитренка І.І." + Environment.NewLine;
            textBox4.Text += "При X = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При Y = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При Z = " + textBox3.Text + Environment.NewLine;
            double u;
            if ((z ‐ x) == 0)
            u = y * Math.Sin(x) * Math.Sin(x) + z;
            else if ((z ‐ x) < 0)
            u = y * Math.Exp(Math.Sin(x)) ‐ z;
           else
                u = y * Math.Sin(Math.Sin(x)) + z;
            textBox4.Text += "U = " + u.ToString() + Environment.NewLine;
        }


    }
}
