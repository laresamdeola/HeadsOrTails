namespace HeadsOrTails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void coinTossButton_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            int toss = randomNumber.Next(0, 2);
            switch(toss)
            {
                case 0:
                    coinTossLabel.Text = "Heads";
                    break;
                case 1:
                    coinTossLabel.Text = "Tail";
                    break;
            }
        }

        private void coinResetButton_Click(object sender, EventArgs e)
        {
            coinTossLabel.Text = "";
        }
    }
}