using System.Runtime.InteropServices;

namespace DijkstraAsm
{
    public partial class Form1 : Form
    {

        // Import a function from the DLL
        [DllImport("JADll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddTwoNumbers(int a, int b);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Example usage of the function
            int result = AddTwoNumbers(1,2);
            MessageBox.Show($"Result: {result}");

        }
    }
}
