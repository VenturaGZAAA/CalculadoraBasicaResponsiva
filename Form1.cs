namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Screen.Text = string.Empty;
            Screen.Location = new Point(0, 0);
            Screen.Size = new Size(ClientSize.Width, ClientSize.Height / 6);
            ClearB.Location = new Point(0, Screen.Bottom);
            ClearB.Size = new Size((int)(ClientSize.Width * (3.0d / 4.0d)), ClientSize.Height / 6);
            resultButtom.Size = new Size(ClientSize.Width / 4, ClientSize.Height / 6);
            resultButtom.Top = ClientSize.Height - resultButtom.Height;
            resultButtom.Left = ClientSize.Width - resultButtom.Width;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (ClientSize.Height % 6 != 0)
            {
                int H = Screen.Height / 6;
                Screen.Height = H * 6;
            }
            Screen.Location = new Point(0, 0);
            Screen.Size = new Size(ClientSize.Width, ClientSize.Height / 6);
            ClearB.Location = new Point(0, Screen.Bottom);
            ClearB.Size = new Size((int)(ClientSize.Width * (3.0d / 4.0d)), ClientSize.Height / 6);
            resultButtom.Size = new Size(ClientSize.Width / 4, ClientSize.Height / 6);
            resultButtom.Top = ClientSize.Height - resultButtom.Height;
            resultButtom.Left = ClientSize.Width - resultButtom.Width;
        }
    }
}