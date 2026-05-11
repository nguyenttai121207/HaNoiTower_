using HanoiTowerP.Core;
using System.Windows.Forms;

namespace HanoiTowerP
{
    public partial class fMain : Form
    {
        // Số lượng đĩa, có thể thay đổi để chơi với số đĩa khác
        public int diskCount = 3;
        // Timer để tự động giải
        private System.Windows.Forms.Timer solveTimer;

        private HanoiController controller;
        public fMain()
        {

            InitializeComponent();
            controller = new HanoiController();
            controller.Initialize(diskCount); // khởi tạo trò chơi với 3 đĩa

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // defer drawing until controls are laid out (Load event)
            this.Load += fMain_Load;
        }

        private void fMain_Load(object? sender, System.EventArgs e)
        {
            // Initialize timer for auto-solving
            solveTimer = new System.Windows.Forms.Timer();//tạo timer 
            solveTimer.Tick += SolveTimer_Tick;//gán event khi tick
            numericUpDownSpeed.ValueChanged += numericUpDownSpeed_ValueChanged;// cập nhật tốc độ 




            // GÁN EVENT BUTTON Ở ĐÂY
            btnSolve.Click += btnSolve_Click;
            btnPause.Click += btnPause_Click;
            btnReset.Click += btnReset_Click;
            pDisk.Click += pDisk_Click;
            dDisk.Click += dDisk_Click;
            

            
            
            


            Render();
        }

        

        // Render placeholder
        public void Render()
        {

            DrawPegStructure(PegA);
            DrawPegStructure(PegB);
            DrawPegStructure(PegC);

            if (controller == null) return;

            var pegStacks = controller.GetPeg();
            if (pegStacks == null) return;

            DrawAllDisks(PegA, pegStacks[0]);
            DrawAllDisks(PegB, pegStacks[1]);
            DrawAllDisks(PegC, pegStacks[2]);
        }

       
    }
}
