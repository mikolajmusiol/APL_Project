namespace DijkstraAsm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = AssemblyFunctions.AddTwoNumbers(1,2);
            MessageBox.Show($"Result: {result}");

        }
    }
}
