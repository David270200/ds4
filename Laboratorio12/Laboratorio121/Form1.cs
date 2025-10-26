namespace Laboratorio121
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double velocidad;

            if (double.TryParse(textBox1.Text, out velocidad))
            {
            }
            else
            {
                MessageBox.Show("ingrese la velocidad ");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double tiempo;

            if (double.TryParse(textBox2.Text, out tiempo))
            {
                // Aquí luego podrás usar la variable 'tiempo' para calcular la distancia
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido para el tiempo.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double velocidad, tiempo;

            if (double.TryParse(textBox1.Text, out velocidad) && double.TryParse(textBox2.Text, out tiempo))
            {
                double distancia = velocidad * tiempo;
                textBox3.Text = distancia.ToString(); // muestra la distancia en textBox3
            }
            else
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos en ambos campos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // limpia la velocidad
            textBox2.Clear(); // limpia el tiempo
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); //para salir de la copilacion
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
