//ÇOK DAHA KISA YAZABILIRDIM BILIYORUM FAZLA GOZUKSUN DIYE BOYLE YAPTIM
namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (label1.ForeColor == Color.Green && label2.ForeColor == Color.Black)
            {
                button1.Text = "X";
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Green;
                button1.Enabled = false;
            }
            else if (label1.ForeColor == Color.Black && label2.ForeColor == Color.Green)
            {
                button1.Text = "O";
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Black;
                button1.Enabled = false;

            }
            if (button1.Text == button2.Text && button3.Text == button1.Text)
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
                button3.BackColor = Color.Green;
                button3.ForeColor = Color.White;
            }
            else if (button1.Text == button5.Text && button1.Text == button9.Text)
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                button5.BackColor = Color.Green;
                button5.ForeColor = Color.White;
                button9.BackColor = Color.Green;
                button9.ForeColor = Color.White;
            }
            else if (button1.Text == button4.Text && button1.Text == button7.Text)
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                button4.BackColor = Color.Green;
                button4.ForeColor = Color.White;
                button7.BackColor = Color.Green;
                button7.ForeColor = Color.White;

            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            int lbl8txt = Convert.ToInt32(label8.Text);
            int lbl7txt = Convert.ToInt32(label7.Text);
            if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt > lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 1 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt < lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 2 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt == lbl8txt)
            {
                MessageBox.Show("Game Over \n Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Text = "";
            listBox2.Text = "";
            listBox3.Text = "";
            listBox4.Text = "";
            button1.FlatStyle = FlatStyle.Flat;
            button2.FlatStyle = FlatStyle.Flat;
            button3.FlatStyle = FlatStyle.Flat;
            button4.FlatStyle = FlatStyle.Flat;
            button5.FlatStyle = FlatStyle.Flat;
            button6.FlatStyle = FlatStyle.Flat;
            button7.FlatStyle = FlatStyle.Flat;
            button8.FlatStyle = FlatStyle.Flat;
            button9.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Green && label2.ForeColor == Color.Black)
            {
                button2.Text = "X";
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Green;
                button2.Enabled = false;
            }
            else if (label1.ForeColor == Color.Black && label2.ForeColor == Color.Green)
            {
                button2.Text = "O";
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Black;
                button2.Enabled = false;
            }
            if (button1.Text == button2.Text && button3.Text == button2.Text)
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
                button3.BackColor = Color.Green;
                button3.ForeColor = Color.White;
            }
            else if (button2.Text == button5.Text && button2.Text == button8.Text)
            {
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
                button5.BackColor = Color.Green;
                button5.ForeColor = Color.White;
                button8.BackColor = Color.Green;
                button8.ForeColor = Color.White;
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            int lbl8txt = Convert.ToInt32(label8.Text);
            int lbl7txt = Convert.ToInt32(label7.Text);
            if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt > lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 1 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt < lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 2 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt == lbl8txt)
            {
                MessageBox.Show("Game Over \n Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Green && label2.ForeColor == Color.Black)
            {
                button3.Text = "X";
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Green;
                button3.Enabled = false;
            }
            else if (label1.ForeColor == Color.Black && label2.ForeColor == Color.Green)
            {
                button3.Text = "O";
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Black;
                button3.Enabled = false;
            }
            if (button1.Text == button3.Text && button3.Text == button2.Text)
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
                button3.BackColor = Color.Green;
                button3.ForeColor = Color.White;
            }
            else if (button3.Text == button5.Text && button3.Text == button7.Text)
            {
                button3.BackColor = Color.Green;
                button3.ForeColor = Color.White;
                button5.BackColor = Color.Green;
                button5.ForeColor = Color.White;
                button7.BackColor = Color.Green;
                button7.ForeColor = Color.White;

            }
            else if (button3.Text == button6.Text && button9.Text == button3.Text)
            {
                button3.BackColor = Color.Green;
                button3.ForeColor = Color.White;
                button6.BackColor = Color.Green;
                button6.ForeColor = Color.White;
                button9.BackColor = Color.Green;
                button9.ForeColor = Color.White;
            }

            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            int lbl8txt = Convert.ToInt32(label8.Text);
            int lbl7txt = Convert.ToInt32(label7.Text);
            if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt > lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 1 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt < lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 2 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt == lbl8txt)
            {
                MessageBox.Show("Game Over \n Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Green && label2.ForeColor == Color.Black)
            {
                button6.Text = "X";
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Green;
                button6.Enabled = false;
            }
            else if (label1.ForeColor == Color.Black && label2.ForeColor == Color.Green)
            {
                button6.Text = "O";
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Black;
                button6.Enabled = false;
            }
            if (button6.Text == button4.Text && button6.Text == button5.Text)
            {
                button4.BackColor = Color.Green;
                button4.ForeColor = Color.White;
                button5.BackColor = Color.Green;
                button5.ForeColor = Color.White;
                button6.BackColor = Color.Green;
                button6.ForeColor = Color.White;
            }
            else if (button6.Text == button3.Text && button6.Text == button9.Text)
            {
                button3.BackColor = Color.Green;
                button3.ForeColor = Color.White;
                button6.BackColor = Color.Green;
                button6.ForeColor = Color.White;
                button9.BackColor = Color.Green;
                button9.ForeColor = Color.White;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            int lbl8txt = Convert.ToInt32(label8.Text);
            int lbl7txt = Convert.ToInt32(label7.Text);
            if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt > lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 1 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt < lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 2 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt == lbl8txt)
            {
                MessageBox.Show("Game Over \n Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Green && label2.ForeColor == Color.Black)
            {
                button5.Text = "X";
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Green;
                button5.Enabled = false;
            }
            else if (label1.ForeColor == Color.Black && label2.ForeColor == Color.Green)
            {
                button5.Text = "O";
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Black;
                button5.Enabled = false;
            }
            if (button5.Text == button4.Text && button5.Text == button6.Text)
            {
                button4.BackColor = Color.Green;
                button4.ForeColor = Color.White;
                button5.BackColor = Color.Green;
                button5.ForeColor = Color.White;
                button6.BackColor = Color.Green;
                button6.ForeColor = Color.White;
            }
            else if (button5.Text == button2.Text && button5.Text == button8.Text)
            {
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
                button5.BackColor = Color.Green;
                button5.ForeColor = Color.White;
                button8.BackColor = Color.Green;
                button8.ForeColor = Color.White;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            int lbl8txt = Convert.ToInt32(label8.Text);
            int lbl7txt = Convert.ToInt32(label7.Text);
            if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt > lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 1 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt < lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 2 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt == lbl8txt)
            {
                MessageBox.Show("Game Over \n Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Green && label2.ForeColor == Color.Black)
            {
                button4.Text = "X";
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Green;
                button4.Enabled = false;
            }
            else if (label1.ForeColor == Color.Black && label2.ForeColor == Color.Green)
            {
                button4.Text = "O";
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Black;
                button4.Enabled = false;
            }
            if (button4.Text == button5.Text && button4.Text == button6.Text)
            {
                button4.BackColor = Color.Green;
                button4.ForeColor = Color.White;
                button5.BackColor = Color.Green;
                button5.ForeColor = Color.White;
                button6.BackColor = Color.Green;
                button6.ForeColor = Color.White;
            }
            else if (button4.Text == button1.Text && button4.Text == button7.Text)
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                button4.BackColor = Color.Green;
                button4.ForeColor = Color.White;
                button7.BackColor = Color.Green;
                button7.ForeColor = Color.White;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            int lbl8txt = Convert.ToInt32(label8.Text);
            int lbl7txt = Convert.ToInt32(label7.Text);
            if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt > lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 1 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt < lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 2 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt == lbl8txt)
            {
                MessageBox.Show("Game Over \n Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Green && label2.ForeColor == Color.Black)
            {
                button9.Text = "X";
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Green;
                button9.Enabled = false;
            }
            else if (label1.ForeColor == Color.Black && label2.ForeColor == Color.Green)
            {
                button9.Text = "O";
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Black;
                button9.Enabled = false;
            }
            if (button9.Text == button8.Text && button9.Text == button7.Text)
            {
                button7.BackColor = Color.Green;
                button7.ForeColor = Color.White;
                button8.BackColor = Color.Green;
                button8.ForeColor = Color.White;
                button9.BackColor = Color.Green;
                button9.ForeColor = Color.White;
            }
            else if (button9.Text == button5.Text && button1.Text == button9.Text)
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                button5.BackColor = Color.Green;
                button5.ForeColor = Color.White;
                button9.BackColor = Color.Green;
                button9.ForeColor = Color.White;
            }
            else if (button9.Text == button6.Text && button9.Text == button3.Text)
            {
                button3.BackColor = Color.Green;
                button3.ForeColor = Color.White;
                button6.BackColor = Color.Green;
                button6.ForeColor = Color.White;
                button9.BackColor = Color.Green;
                button9.ForeColor = Color.White;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            int lbl8txt = Convert.ToInt32(label8.Text);
            int lbl7txt = Convert.ToInt32(label7.Text);
            if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt > lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 1 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt < lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 2 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt == lbl8txt)
            {
                MessageBox.Show("Game Over \n Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Green && label2.ForeColor == Color.Black)
            {
                button8.Text = "X";
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Green;
                button8.Enabled = false;
            }
            else if (label1.ForeColor == Color.Black && label2.ForeColor == Color.Green)
            {
                button8.Text = "O";
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Black;
                button8.Enabled = false;
            }
            if (button8.Text == button7.Text && button8.Text == button9.Text)
            {
                button7.BackColor = Color.Green;
                button7.ForeColor = Color.White;
                button8.BackColor = Color.Green;
                button8.ForeColor = Color.White;
                button9.BackColor = Color.Green;
                button9.ForeColor = Color.White;
            }
            else if (button8.Text == button5.Text && button8.Text == button2.Text)
            {
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
                button5.BackColor = Color.Green;
                button5.ForeColor = Color.White;
                button8.BackColor = Color.Green;
                button8.ForeColor = Color.White;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            int lbl8txt = Convert.ToInt32(label8.Text);
            int lbl7txt = Convert.ToInt32(label7.Text);
            if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt > lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 1 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt < lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 2 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt == lbl8txt)
            {
                MessageBox.Show("Game Over \n Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Green && label2.ForeColor == Color.Black)
            {
                button7.Text = "X";
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Green;
                button7.Enabled = false;
            }
            else if (label1.ForeColor == Color.Black && label2.ForeColor == Color.Green)
            {
                button7.Text = "O";
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Black;
                button7.Enabled = false;
            }
            if (button7.Text == button8.Text && button7.Text == button9.Text)
            {
                button7.BackColor = Color.Green;
                button7.ForeColor = Color.White;
                button8.BackColor = Color.Green;
                button8.ForeColor = Color.White;
                button9.BackColor = Color.Green;
                button9.ForeColor = Color.White;
            }
            else if (button7.Text == button4.Text && button1.Text == button7.Text)
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                button4.BackColor = Color.Green;
                button4.ForeColor = Color.White;
                button7.BackColor = Color.Green;
                button7.ForeColor = Color.White;
            }
            else if (button7.Text == button5.Text && button7.Text == button3.Text)
            {
                button3.BackColor = Color.Green;
                button3.ForeColor = Color.White;
                button5.BackColor = Color.Green;
                button5.ForeColor = Color.White;
                button7.BackColor = Color.Green;
                button7.ForeColor = Color.White;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                int p1pts = Convert.ToInt32(label7.Text);
                p1pts = p1pts + 1;
                label7.Text = p1pts.ToString();
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                int p2pts = Convert.ToInt32(label8.Text);
                p2pts = p2pts + 1;
                label8.Text = p2pts.ToString();
            }
            int lbl8txt = Convert.ToInt32(label8.Text);
            int lbl7txt = Convert.ToInt32(label7.Text);
            if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt > lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 1 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt < lbl8txt)
            {
                MessageBox.Show("Game Over \n Player 2 Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            lbl7txt == lbl8txt)
            {
                MessageBox.Show("Game Over \n Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {




        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void themesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purpleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orangeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pinkToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blackToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void brownToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void brownToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Brown;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grayToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void whiteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void defaultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Teal;
            label3.BackColor = Color.Teal;
        }

        private void yellowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Yellow;
            label3.BackColor = Color.Yellow;
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Red;
            label3.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void blueToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Blue;
            label3.BackColor = Color.Blue;
        }

        private void purpleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void purpleToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Purple;
            label3.BackColor = Color.Purple;
        }

        private void orangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void orangeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Orange;
            label3.BackColor = Color.Orange;
        }

        private void pinkToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pinkToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Pink;
            label3.BackColor = Color.Pink;
        }

        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Black;
            label3.BackColor = Color.Black;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void greenToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Green;
            label3.BackColor = Color.Green;
        }

        private void brownToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void brownToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Brown;
            label3.BackColor = Color.Brown;
        }

        private void grayToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void grayToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Gray;
            label3.BackColor = Color.Gray;
        }

        private void whiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void whiteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.White;
            label3.BackColor = Color.White;
        }

        private void defaultToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listBox4.BackColor = Color.Lime;
            label6.BackColor = Color.Lime;
        }

        private void yellowToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listBox4.BackColor = Color.Yellow;
            label6.BackColor = Color.Yellow;
        }

        private void redToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listBox4.BackColor = Color.Red;
            label6.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listBox4.BackColor = Color.Blue;
            label6.BackColor = Color.Blue;
        }

        private void purpleToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void purpleToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            listBox4.BackColor = Color.Purple;
            label6.BackColor = Color.Purple;
        }

        private void orangeToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void orangeToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            listBox4.BackColor = Color.Orange;
            label6.BackColor = Color.Orange;
        }

        private void pinkToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void pinkToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            listBox4.BackColor = Color.Pink;
            label6.BackColor = Color.Pink;
        }

        private void blackToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void blackToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            listBox4.BackColor = Color.Black;
            label6.BackColor = Color.Black;
        }

        private void greenToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void greenToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            listBox4.BackColor = Color.Green;
            label6.BackColor = Color.Green;
        }

        private void brownToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listBox4.BackColor = Color.Brown;
            label6.BackColor = Color.Brown;
        }

        private void grayToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void grayToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            listBox4.BackColor = Color.Gray;
            label6.BackColor = Color.Gray;
        }

        private void whiteToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void whiteToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            listBox4.BackColor = Color.White;
            label6.BackColor = Color.White;
        }

        private void yellowToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.Yellow;
            button4.BackColor = Color.Yellow;
            button5.BackColor = Color.Yellow;
            button6.BackColor = Color.Yellow;
            button7.BackColor = Color.Yellow;
            button8.BackColor = Color.Yellow;
            button9.BackColor = Color.Yellow;
        }

        private void defaultToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;
        }

        private void redToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            button9.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
            button2.BackColor = Color.Blue;
            button3.BackColor = Color.Blue;
            button4.BackColor = Color.Blue;
            button5.BackColor = Color.Blue;
            button6.BackColor = Color.Blue;
            button7.BackColor = Color.Blue;
            button8.BackColor = Color.Blue;
            button9.BackColor = Color.Blue;

        }

        private void purpleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Purple;
            button2.BackColor = Color.Purple;
            button3.BackColor = Color.Purple;
            button4.BackColor = Color.Purple;
            button5.BackColor = Color.Purple;
            button6.BackColor = Color.Purple;
            button7.BackColor = Color.Purple;
            button8.BackColor = Color.Purple;
            button9.BackColor = Color.Purple;
        }

        private void buttonsBackcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orangeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
            button2.BackColor = Color.Orange;
            button3.BackColor = Color.Orange;
            button4.BackColor = Color.Orange;
            button5.BackColor = Color.Orange;
            button6.BackColor = Color.Orange;
            button7.BackColor = Color.Orange;
            button8.BackColor = Color.Orange;
            button9.BackColor = Color.Orange;
        }

        private void pinkToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void pinkToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Pink;
            button2.BackColor = Color.Pink;
            button3.BackColor = Color.Pink;
            button4.BackColor = Color.Pink;
            button5.BackColor = Color.Pink;
            button6.BackColor = Color.Pink;
            button7.BackColor = Color.Pink;
            button8.BackColor = Color.Pink;
            button9.BackColor = Color.Pink;
        }

        private void greenToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Green;
            button9.BackColor = Color.Green;
        }

        private void brownToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Brown;
            button2.BackColor = Color.Brown;
            button3.BackColor = Color.Brown;
            button4.BackColor = Color.Brown;
            button5.BackColor = Color.Brown;
            button6.BackColor = Color.Brown;
            button7.BackColor = Color.Brown;
            button8.BackColor = Color.Brown;
            button9.BackColor = Color.Brown;
        }

        private void grayToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
            button8.BackColor = Color.Gray;
            button9.BackColor = Color.Gray;
        }

        private void whiteToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void whiteToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }

        private void plueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void whiteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void yellowToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void yellowToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Yellow;
        }

        private void redToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void blueToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void blueToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        private void greenToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {

        }

        private void greenToolStripMenuItem3_Click_2(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Green;
        }

        private void pinkToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void pinkToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Pink;
        }

        private void blackToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void whiteToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void whiteToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            label6.ForeColor = Color.White;
        }

        private void yellowToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void yellowToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Yellow;
        }

        private void greenToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void greenToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Green;
        }

        private void pinkToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void pinkToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Pink;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label1.ForeColor = Color.Green;
            label2.ForeColor = Color.Black;
            label7.Text = "0";
            label8.Text = "0";
            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 awaa = new Form2();
            this.Hide();
            awaa.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }
    }
}
//ÇOK DAHA KISA YAZABILIRDIM BILIYORUM FAZLA GOZUKSUN DIYE BOYLE YAPTIM