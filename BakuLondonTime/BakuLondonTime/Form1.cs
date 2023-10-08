namespace BakuLondonTime
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer timer_1 = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.a25ec4ac_city_33415_1732e873f4b;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            label2.Visible = true;

            timer.Interval = 900;

            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.london;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            label2.Visible = true;

            ;
            timer_1.Interval = 700;

            timer_1.Tick += Timer_Tick_1;
            timer_1.Start();
        }

        private void Timer_Tick_1(object? sender, EventArgs e)
        {
            DateTime utcNow = DateTime.UtcNow;

            TimeZoneInfo londonTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            DateTime londonTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, londonTimeZone);

            label2.Text = londonTime.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.earth_blue_planet_globe_planet_87651;
            button1.Visible = true;
            button2.Visible = true;
            label2.Visible = false;
            button3.Visible = false;
            timer.Stop();
            timer_1.Stop();
        }
    }
}