namespace Laboratorio12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double nota1;

            if (double.TryParse(textBox1.Text, out nota1))
            {

            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para la nota 1.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double nota2;

            if (double.TryParse(textBox2.Text, out nota2))
            {

            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para la nota 2.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double nota3;

            if (double.TryParse(textBox3.Text, out nota3))
            {

            }
            else
            {
                MessageBox.Show("Ingrese un valor valido para la nota 3");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3;

            if (double.TryParse(textBox1.Text, out nota1) &&
                double.TryParse(textBox2.Text, out nota2) &&
                double.TryParse(textBox3.Text, out nota3))
            {
                double promedio = (nota1 + nota2 + nota3) / 3;
                textBox4.Text = promedio.ToString("F2"); //muestra el promedio
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos en todas las notas.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}