namespace Compras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Equals("Usuario") && textBox2.Equals("1234")) 
            {
                Compras a = new Compras();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Error, ingrese un usuario valido");
            }
        }
    }
}