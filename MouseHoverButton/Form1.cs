namespace MouseHoverButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColourButtonInit();
        }

        private void BackColourButtonInit()
        {
            foreach(var button in this.Controls.OfType<Button>())
            {
                button.MouseEnter += Button_Ent;
                button.MouseLeave += Button_MouseLeav;
            }
        }

        // 1 option
        Color CurrentColour;
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            int newR = 0;
            int newG = 0;
            int newB = 0;

            Button button = sender as Button;
            CurrentColour = button.BackColor;
            int R = int.Parse(CurrentColour.R.ToString());
            int G = int.Parse(CurrentColour.G.ToString());
            int B = int.Parse(CurrentColour.B.ToString());

            if (R * 1.25 >= 255)
            {
                newR = 255;
                Console.WriteLine($"R IS {R}");
            }
            else
            {
                newR = (int)Math.Round(R * 1.25, 0);
                Console.WriteLine($"R NEW IS {newR}");
            }

            if (G * 1.25 >= 255)
            {
                newG = 255;
                Console.WriteLine($"G IS {G}");
            }
            else
            {
                newG = (int)Math.Round(G * 1.25, 0);
                Console.WriteLine($"G NEW IS {newG}");
            }


            if (B * 1.25 >= 255)
            {
                newB = 255;
                Console.WriteLine($"B IS {B}");
            }
            else
            {
                newB = (int)Math.Round(B * 1.25, 0);
                Console.WriteLine($"B NEW IS {newB}");
            }
            Console.WriteLine($"OLD COLOUR -> {R},{G},{B}");
            Console.WriteLine($"NEW COLOUR -> {newR},{newG},{newB}");
            button.BackColor = Color.FromArgb(newR, newG, newB);
        }

        // 2 option
        private void Button_Ent(object sender, EventArgs e)
        {

            Button button = sender as Button;
            CurrentColour = button.BackColor;

            int newR = Math.Min(255, (int) Math.Round(CurrentColour.R * 1.25,0));
            int newG = Math.Min(255, (int)Math.Round(CurrentColour.G * 1.25, 0));
            int newB = Math.Min(255, (int)Math.Round(CurrentColour.B * 1.25, 0));

            Console.WriteLine($"OLD COLOUR -> {CurrentColour.R},{CurrentColour.G},{CurrentColour.B}");
            Console.WriteLine($"NEW COLOUR -> {newR},{newG},{newB}");
            button.BackColor = Color.FromArgb(newR, newG, newB);
        }

        private void Button_MouseLeav(Object sender, EventArgs e)
        {
            Button button = sender as Button;


            int R = int.Parse(CurrentColour.R.ToString());
            int G = int.Parse(CurrentColour.G.ToString());
            int B = int.Parse(CurrentColour.B.ToString());
            Console.WriteLine($"LEAVE: {R},{G},{B}");
            button.BackColor = CurrentColour;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}