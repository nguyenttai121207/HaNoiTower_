using HanoiTowerP.Core;
using System.Collections;

namespace HanoiTowerP
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            MainPanel = new TableLayoutPanel();
            GamePanel = new TableLayoutPanel();
            PegC = new Panel();
            PegB = new Panel();
            PegA = new Panel();
            TitlePanel = new Panel();
            Title = new Label();
            ControllPanel = new Panel();
            numericUpDownSpeed = new NumericUpDown();
            btnPause = new Button();
            dDisk = new Button();
            pDisk = new Button();
            btnReset = new Button();
            btnSolve = new Button();
            MainPanel.SuspendLayout();
            GamePanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            ControllPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.ColumnCount = 1;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainPanel.Controls.Add(GamePanel, 0, 1);
            MainPanel.Controls.Add(TitlePanel, 0, 0);
            MainPanel.Controls.Add(ControllPanel, 0, 2);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.RowCount = 3;
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            MainPanel.Size = new Size(2772, 1426);
            MainPanel.TabIndex = 0;
            // 
            // GamePanel
            // 
            GamePanel.BackColor = Color.FromArgb(15, 23, 42);
            GamePanel.ColumnCount = 3;
            GamePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GamePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GamePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GamePanel.Controls.Add(PegC, 2, 0);
            GamePanel.Controls.Add(PegB, 1, 0);
            GamePanel.Controls.Add(PegA, 0, 0);
            GamePanel.Dock = DockStyle.Fill;
            GamePanel.Location = new Point(3, 123);
            GamePanel.Name = "GamePanel";
            GamePanel.RowCount = 1;
            GamePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            GamePanel.Size = new Size(2766, 1100);
            GamePanel.TabIndex = 0;
            // 
            // PegC
            // 
            PegC.BackColor = SystemColors.ControlText;
            PegC.Dock = DockStyle.Fill;
            PegC.Location = new Point(1847, 3);
            PegC.Name = "PegC";
            PegC.Size = new Size(916, 1094);
            PegC.TabIndex = 2;
            // 
            // PegB
            // 
            PegB.BackColor = SystemColors.ControlText;
            PegB.Dock = DockStyle.Fill;
            PegB.Location = new Point(925, 3);
            PegB.Name = "PegB";
            PegB.Size = new Size(916, 1094);
            PegB.TabIndex = 1;
            // 
            // PegA
            // 
            PegA.BackColor = SystemColors.ControlText;
            PegA.Dock = DockStyle.Fill;
            PegA.Location = new Point(3, 3);
            PegA.Name = "PegA";
            PegA.Size = new Size(916, 1094);
            PegA.TabIndex = 0;
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = Color.FromArgb(31, 41, 55);
            TitlePanel.Controls.Add(Title);
            TitlePanel.Dock = DockStyle.Fill;
            TitlePanel.Location = new Point(3, 3);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(2766, 114);
            TitlePanel.TabIndex = 1;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.FromArgb(31, 41, 55);
            Title.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = SystemColors.ButtonHighlight;
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(355, 74);
            Title.TabIndex = 0;
            Title.Text = "Hanoi Tower\r\n";
            // 
            // ControllPanel
            // 
            ControllPanel.BackColor = Color.FromArgb(30, 41, 59);
            ControllPanel.Controls.Add(numericUpDownSpeed);
            ControllPanel.Controls.Add(btnPause);
            ControllPanel.Controls.Add(dDisk);
            ControllPanel.Controls.Add(pDisk);
            ControllPanel.Controls.Add(btnReset);
            ControllPanel.Controls.Add(btnSolve);
            ControllPanel.Dock = DockStyle.Fill;
            ControllPanel.Location = new Point(3, 1229);
            ControllPanel.Name = "ControllPanel";
            ControllPanel.Size = new Size(2766, 194);
            ControllPanel.TabIndex = 2;
            // 
            // numericUpDownSpeed
            // 
            numericUpDownSpeed.Location = new Point(1091, 87);
            numericUpDownSpeed.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSpeed.Name = "numericUpDownSpeed";
            numericUpDownSpeed.Size = new Size(67, 35);
            numericUpDownSpeed.TabIndex = 5;
            numericUpDownSpeed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPause
            // 
            btnPause.Location = new Point(483, 76);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(150, 46);
            btnPause.TabIndex = 4;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            // 
            // dDisk
            // 
            dDisk.Location = new Point(885, 76);
            dDisk.Name = "dDisk";
            dDisk.Size = new Size(150, 46);
            dDisk.TabIndex = 3;
            dDisk.Text = "-1 Disk";
            dDisk.UseVisualStyleBackColor = true;
            // 
            // pDisk
            // 
            pDisk.Location = new Point(686, 76);
            pDisk.Name = "pDisk";
            pDisk.Size = new Size(150, 46);
            pDisk.TabIndex = 2;
            pDisk.Text = "+1 Disk";
            pDisk.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(302, 76);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(82, 76);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(150, 46);
            btnSolve.TabIndex = 0;
            btnSolve.Text = "Solve";
            btnSolve.UseVisualStyleBackColor = true;
            // 
            // fMain
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.FromArgb(13, 23, 42);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(2772, 1426);
            Controls.Add(MainPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fMain";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "HanoiTowerSolve";
            WindowState = FormWindowState.Maximized;
            MainPanel.ResumeLayout(false);
            GamePanel.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ControllPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).EndInit();
            ResumeLayout(false);








        }




        // Draw the structure of the peg
        private void DrawPegStructure(Panel pegPanel)
        {
            pegPanel.Controls.Clear(); // clear old controls but we'll re-add rod and base

            int w = pegPanel.ClientSize.Width;
            int h = pegPanel.ClientSize.Height;

            // Vẽ cây cột (rod)
            Panel rod = new Panel();
            rod.Name = "rod";
            rod.Width = Math.Max(6, w / 60);
            rod.Height = Math.Max(50, h - 120);
            rod.BackColor = Color.FromArgb(148, 163, 184);
            rod.Left = (w - rod.Width) / 2;
            rod.Top = 100   ;

            // Vẽ đế cột (base plate)
            Panel basePlate = new Panel();
            basePlate.Name = "basePlate";
            basePlate.Width = Math.Max(60, w - 80);
            basePlate.Height = Math.Max(8, h / 40);
            basePlate.BackColor = Color.FromArgb(71, 85, 105);
            basePlate.Left = (w - basePlate.Width) / 2;
            basePlate.Top = h - basePlate.Height - 10;

            // Add base then rod (rod behind disks)
            pegPanel.Controls.Add(basePlate);
            pegPanel.Controls.Add(rod);
            basePlate.SendToBack();

            // Set background
            pegPanel.BackColor = Color.FromArgb(15, 23, 42);
        }
        
        //Draw the disks by size
        private Panel CreateDiskControl( int diskSize)
        {

            // Random color for disk
            int r = (diskSize * 50) % 256;
            int g = (diskSize * 80) % 256;
            int b = (diskSize * 120) % 256;
            //


            // Vẻ đĩa trên cột
            Panel diskPanel = new Panel();
            diskPanel.Width = diskSize * 10+40; // Kích thước đĩa dựa trên kích thước của nó 
            diskPanel.Height = 20;
            diskPanel.BackColor = Color.FromArgb(r,g,b);

            return diskPanel;
        }

        //Draw the disks on the peg
        void DrawAllDisks(Panel pegPanel, Core.Stack<int> pegStack)
        {
            RenderDiskFromNode(pegPanel, pegStack.GetHead(), pegStack.Count()-1);
        }

        // Recursive render disks from stack node 
        void RenderDiskFromNode(Panel peg, Node<int> node, int level)
        {
            if (node == null) return;// base case: no more disk to draw

            // Đi từ dưới lên trên: vẽ đĩa ở node tiếp theo trước, sau đó mới vẽ đĩa hiện tại
            RenderDiskFromNode(peg, node.Next, level - 1);

            // vẽ đĩa hiện tại
            Panel diskPanel = CreateDiskControl(node.Data);

            // Vị trí của đĩa: căn giữa theo chiều ngang, và xếp chồng lên nhau theo chiều dọc
            diskPanel.Left = (peg.ClientSize.Width - diskPanel.Width) / 2;
            diskPanel.Top = peg.ClientSize.Height - 30 - (level * 20);

            // Thêm đĩa vào cột
            peg.Controls.Add(diskPanel);
            diskPanel.BringToFront();
        }

        // Timer for auto-solving
        private void btnSolve_Click(object sender, EventArgs e)
        {
            solveTimer.Start();
        }

        // Timer for Pause
        private void btnPause_Click(object sender, EventArgs e)
        {
            solveTimer.Stop();
        }

        // Reset game when button clicked
        private void btnReset_Click(object sender, EventArgs e )
        {
            solveTimer.Stop();
            controller.Initialize(diskCount);// khởi tạo lại trò chơi với số đĩa hiện tại
            Render();
        }

        // Start solving when button clicked
        private void SolveTimer_Tick(object sender, EventArgs e)
        {
            if (controller.HasNext())
            {
                controller.NextStep();
                Render();

                solveTimer.Interval = GetDelay();
            }
            else
            {
                solveTimer.Stop();
            }
        }

        // Add disk when button clicked
        private void pDisk_Click(object sender, EventArgs e)
        {
            if (diskCount < 10) // Giới hạn số đĩa tối đa là 10 để tránh quá tải giao diện  
                diskCount++;
            btnReset_Click(sender, e);
            
        }

        // Remove disk when button clicked
        private void dDisk_Click(object sender, EventArgs e )
        {
            if (diskCount > 1)
            {
                diskCount--;
                btnReset_Click(sender, e); 
            }
        }


        // Speed levels corresponding to numericUpDownSpeed values (1-5)
        private readonly int[] speedLevels = { 1000, 700, 500, 300, 150 };

        // Get delay based on current speed level
        private int GetDelay()
        {
            int index = (int)numericUpDownSpeed.Value - 1;
            return speedLevels[index];
        }

        // Update timer interval when speed level changes
        private void numericUpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            solveTimer.Interval = GetDelay();
        }













        #endregion

        private TableLayoutPanel MainPanel;
        private TableLayoutPanel GamePanel;
        private Panel PegC;
        private Panel PegB;
        private Panel PegA;
        private Panel TitlePanel;
        private Label Title;
        private Panel ControllPanel;
        private Button dDisk;
        private Button pDisk;
        private Button btnReset;
        private Button btnSolve;
        private Button btnPause;
        private NumericUpDown numericUpDownSpeed;
    }
}
