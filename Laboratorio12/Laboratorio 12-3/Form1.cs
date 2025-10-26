namespace Laboratorio_12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double ladoC;
            double.TryParse(textBox3.Text, out ladoC);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double ladoA;
            double.TryParse(textBox1.Text, out ladoA);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double ladoB;
            double.TryParse(textBox2.Text, out ladoB);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;

            if (double.TryParse(textBox1.Text, out a) &&
                double.TryParse(textBox2.Text, out b) &&
                double.TryParse(textBox3.Text, out c))
            {
                double s = (a + b + c) / 2;
                textBox4.Text = s.ToString("0.00");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c;

            if (double.TryParse(textBox1.Text, out a) &&
                double.TryParse(textBox2.Text, out b) &&
                double.TryParse(textBox3.Text, out c))
            {
                double s = (a + b + c) / 2;

                if (a + b > c && a + c > b && b + c > a)
                {
                    double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    textBox5.Text = area.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Los valores ingresados no forman un triángulo válido.");
                }
            }
        } // Aquí faltaba esta llave

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear(); //  También borrar resultados
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

