using System.ComponentModel;

namespace WinFormsControlLibrary1
{
    [ToolboxBitmap("C:\\Users\\Pemza\\source\\repos\\ArchNET_Lab1\\WinFormsControlLibrary1\\BinaryComponent.ico")]
    public partial class BinaryComponent : UserControl
    {
        public delegate void Counting();

        public event Counting counting;

        private int number;

        [DisplayName("Total Clics")]
        public int Count { get; set; }

        public BinaryComponent()
        {
            InitializeComponent();
            Count = 0;
            number = 0;
            textBox1.Text = $"{number}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                number += 1;
                textBox1.Text = $"{number}";
            }
            else
            {
                number -= 1;
                textBox1.Text = $"{number}";
            }

            Count++;
            counting?.Invoke();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                number += 2;
                textBox1.Text = $"{number}";
            }
            else
            {
                number -= 2;
                textBox1.Text = $"{number}";
            }

            Count++;
            counting?.Invoke();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                number += 4;
                textBox1.Text = $"{number}";
            }
            else
            {
                number -= 4;
                textBox1.Text = $"{number}";
            }

            Count++;
            counting?.Invoke();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                number += 8;
                textBox1.Text = $"{number}";
            }
            else
            {
                number -= 8;
                textBox1.Text = $"{number}";
            }

            Count++;
            counting?.Invoke();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                number += 16;
                textBox1.Text = $"{number}";
            }
            else
            {
                number -= 16;
                textBox1.Text = $"{number}";
            }

            Count++;
            counting?.Invoke();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                number += 32;
                textBox1.Text = $"{number}";
            }
            else
            {
                number -= 32;
                textBox1.Text = $"{number}";
            }

            Count++;
            counting?.Invoke();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                number += 64;
                textBox1.Text = $"{number}";
            }
            else
            {
                number -= 64;
                textBox1.Text = $"{number}";
            }

            Count++;
            counting?.Invoke();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                number += 128;
                textBox1.Text = $"{number}";
            }
            else
            {
                number -= 128;
                textBox1.Text = $"{number}";
            }

            Count++;
            counting?.Invoke();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Copy();
        }
    }
}
