namespace Figures
{
    public partial class Form1 : Form
    {
        private Circle circle;
        private Square square;
        private Rhomb rhomb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            circle = new Circle(100, 100, 50);
            circle.DrawBlack(this.CreateGraphics());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            circle?.MoveRight(this.CreateGraphics(), this.BackColor, 200);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            square = new Square(200, 200, 100);
            square.DrawBlack(this.CreateGraphics());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (square != null)
            {
                square.MoveRight(this.CreateGraphics(), this.BackColor, 100);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            rhomb = new Rhomb(300, 300, 120, 80);
            rhomb.DrawBlack(this.CreateGraphics());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rhomb?.MoveRight(this.CreateGraphics(), this.BackColor, 200);
        }
    }
}