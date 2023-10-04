using WinForms_C__LESSON_1._3.Properties;

namespace WinForms_C__LESSON_1._3
{
    public partial class Form1 : Form
    {

        System.Windows.Forms.Timer timer;
        int elaveVaxt = 4;
        DateTime d1 = new DateTime();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();

            timer.Interval = 950;

            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour + elaveVaxt, DateTime.Now.Minute, DateTime.Now.Second) { };


            label2.Text = dt.ToLongTimeString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // AZE
        {
            elaveVaxt = 4;

            pictureBox2.Image = Resources.aze;

            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)// ING
        {
            elaveVaxt = 0;

            pictureBox2.Image = Resources.ing;
            timer.Start();
        }
    }
}