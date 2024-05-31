namespace ArchNET_Lab1
{
    public partial class Form1 : Form
    {
        private int Count {  get; set; }

        private void CountingTotalClicsOnCheckboxs() 
        {
            ++Count;
            toolStripStatusLabel1.Text = $"Total chechbox change: {Count}";
        }
        public Form1()
        {
            InitializeComponent();
            Count = 0;
            //binaryComponent1.counting += CountingTotalClicsOnCheckboxs;
            //binaryComponent2.counting += CountingTotalClicsOnCheckboxs;
            //binaryComponent3.counting += CountingTotalClicsOnCheckboxs;
            //binaryComponent4.counting += CountingTotalClicsOnCheckboxs;
        }


    }
}
