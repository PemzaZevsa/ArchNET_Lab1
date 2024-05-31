namespace ArchNET_Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            binaryComponent1 = new WinFormsControlLibrary1.BinaryComponent();
            binaryComponent2 = new WinFormsControlLibrary1.BinaryComponent();
            binaryComponent3 = new WinFormsControlLibrary1.BinaryComponent();
            binaryComponent4 = new WinFormsControlLibrary1.BinaryComponent();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 351);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(570, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(176, 20);
            toolStripStatusLabel1.Text = "Total chechbox change: 0";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(binaryComponent1, 0, 0);
            tableLayoutPanel1.Controls.Add(binaryComponent2, 0, 1);
            tableLayoutPanel1.Controls.Add(binaryComponent3, 1, 0);
            tableLayoutPanel1.Controls.Add(binaryComponent4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(570, 351);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // binaryComponent1
            // 
            binaryComponent1.Count = 0;
            binaryComponent1.Dock = DockStyle.Top;
            binaryComponent1.Location = new Point(3, 3);
            binaryComponent1.Name = "binaryComponent1";
            binaryComponent1.Size = new Size(279, 67);
            binaryComponent1.TabIndex = 0;
            binaryComponent1.counting += CountingTotalClicsOnCheckboxs;
            // 
            // binaryComponent2
            // 
            binaryComponent2.Count = 0;
            binaryComponent2.Dock = DockStyle.Top;
            binaryComponent2.Location = new Point(3, 178);
            binaryComponent2.Name = "binaryComponent2";
            binaryComponent2.Size = new Size(279, 75);
            binaryComponent2.TabIndex = 1;
            binaryComponent2.counting += CountingTotalClicsOnCheckboxs;
            // 
            // binaryComponent3
            // 
            binaryComponent3.Count = 0;
            binaryComponent3.Dock = DockStyle.Bottom;
            binaryComponent3.Location = new Point(288, 95);
            binaryComponent3.Name = "binaryComponent3";
            binaryComponent3.Size = new Size(279, 77);
            binaryComponent3.TabIndex = 2;
            binaryComponent3.counting += CountingTotalClicsOnCheckboxs;
            // 
            // binaryComponent4
            // 
            binaryComponent4.Count = 0;
            binaryComponent4.Dock = DockStyle.Fill;
            binaryComponent4.Location = new Point(288, 178);
            binaryComponent4.Name = "binaryComponent4";
            binaryComponent4.Size = new Size(279, 170);
            binaryComponent4.TabIndex = 3;
            binaryComponent4.counting += CountingTotalClicsOnCheckboxs;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 377);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            MinimumSize = new Size(550, 250);
            Name = "Form1";
            Text = "Хвостовець Лаб1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private WinFormsControlLibrary1.BinaryComponent binaryComponent1;
        private WinFormsControlLibrary1.BinaryComponent binaryComponent2;
        private WinFormsControlLibrary1.BinaryComponent binaryComponent3;
        private WinFormsControlLibrary1.BinaryComponent binaryComponent4;
    }
}
