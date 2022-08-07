namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int a = 0;
        uint b = 0;
        byte c = 0;
        ubyte d = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sbyte MinValue = -128 and MaxValue = 127");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("byte MinValue = 0 and MaxValue = 255");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("short MinValue = -32768 and MaxValue = 32767");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ushort MinValue = 0 and MaxValue = 65536");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("int MinValue = -2147483648 and MaxValue = 2147483647");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("uint MinValue = 0 and MaxValue = 4294967295");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("long MinValue = -9223372036854775808 and MaxValue = 9223372036854775807");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ulong MinValue = 0 and MaxValue = 18446744073709551615");
        }
    }
}