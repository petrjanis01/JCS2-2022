using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCS2.Multithreading.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PerformLongRunningOperation()
        {
            Thread.Sleep(5000);

            MessageBox.Show("Operation completed");
        }

        private void WithThreadsBtn_Click(object sender, System.EventArgs e)
        {
            PerformLongRunningOperation();
        }

        private void NoThreadsBtn_Click(object sender, System.EventArgs e)
        {
            var operationThread = new Thread(PerformLongRunningOperation);
            operationThread.Start();
        }
    }
}
