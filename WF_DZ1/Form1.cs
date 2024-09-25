namespace WF_DZ1
{
    public partial class MainForm : Form
    {
        private int currentColor = 0;
        private Color[] colors = new Color[] { Color.Red, Color.Yellow, Color.Green };

        public MainForm()
        {
            InitializeComponent();
            colorBtn.BackColor = colors[currentColor];
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void randomPosBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            randomPosBtn.Location = new Point(random.Next(0, ClientSize.Width - randomPosBtn.Width + 1), random.Next(0, ClientSize.Height - randomPosBtn.Height + 1));
        }

        private void randomPosForm_Click(object sender, EventArgs e)
        {
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            Random random = new Random();
            this.Location = new Point(random.Next(0, resolution.Width - this.Width + 1), random.Next(0, resolution.Height - this.Height + 1));
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            colorBtn.BackColor = colors[currentColor == 2 ? currentColor = 0 : ++currentColor];
        }
    }
}
