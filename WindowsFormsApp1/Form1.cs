using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        int[,] cell = new int[126,126];//abstraction to split  form into 126*126 grid
        int[,] newCell = new int[126, 126];
        int x = 0;
        int y = 0;
        Brush blackBrush = (Brush)Brushes.Black;
        Brush whiteBrush = (Brush)Brushes.White;
        public Form1()
        {
            InitializeComponent();
            this.Height = 543;
            this.Width = 520;
            InitializeMyButton();
            
        } 
        private void InitializeMyButton()
        {
            // Create and initialize a Button.
            Button button1 = new Button();

            // Set the button to return a value of OK when clicked.
            button1.DialogResult = DialogResult.OK;
            button1.Text = "Insert1";
            button1.Click += new EventHandler(button1_Click);
            button1.Location = new Point(50, 450);
            // Add the button to the form.

            Controls.Add(button1);
            // Create and initialize a Button.
            Button button2 = new Button();

            // Set the button to return a value of OK when clicked.
            button2.DialogResult = DialogResult.OK;
            button2.Text = "Perform";
            button2.Click += new EventHandler(button2_Click);
            button2.Location = new Point(410, 450);
            // Add the button to the form.
            
            Controls.Add(button2);

            // Create and initialize a Button.
            Button button3 = new Button();

            // Set the button to return a value of OK when clicked.
            button3.DialogResult = DialogResult.OK;
            button3.Text = "Insert2";
            button3.Click += new EventHandler(button3_Click);
            button3.Location = new Point(140, 450);
            // Add the button to the form.

            Controls.Add(button3);
            // Create and initialize a Button.

            // Create and initialize a Button.
            Button button4 = new Button();

            // Set the button to return a value of OK when clicked.
            button4.DialogResult = DialogResult.OK;
            button4.Text = "Insert3";
            button4.Click += new EventHandler(button4_Click);
            button4.Location = new Point(230, 450);
            // Add the button to the form.

            Controls.Add(button4);
            // Create and initialize a Button.

            // Create and initialize a Button.
            Button button5 = new Button();

            // Set the button to return a value of OK when clicked.
            button5.DialogResult = DialogResult.OK;
            button5.Text = "Insert4";
            button5.Click += new EventHandler(button5_Click);
            button5.Location = new Point(320, 450);
            // Add the button to the form.

            Controls.Add(button5);
            // Create and initialize a Button.
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cell[40, 40] = 1;
            cell[40, 41] = 1;
            cell[40, 42] = 1;
            cell[40, 43] = 1;
            cell[40, 44] = 1;
            cell[42, 40] = 1;
            cell[44, 40] = 1;
            cell[44, 41] = 1;
            cell[44, 42] = 1;
            cell[44, 43] = 1;
            cell[44, 44] = 1;
            cell[42, 44] = 1;
            for (int i = 1; i < 125; i++)
            {
                for (int j = 1; j < 125; j++)
                {
                    newCell[i, j] = cell[i, j];
                }
            }
            Graphics g = this.CreateGraphics();
            for (int i = 0; i < 126; i++)
            {
                for (int j = 0; j < 126; j++)
                {
                    if (cell[i, j] == 1)
                    {
                        g.FillRectangle(blackBrush, i * 4, j * 4, 4, 4);
                    }
                    else
                    {
                        g.FillRectangle(whiteBrush, i * 4, j * 4, 4, 4);
                    }
                }
            }
            g.Dispose();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cell[60, 60] = 1;
            cell[61, 60] = 1;
            cell[61, 62] = 1;
            cell[63, 61] = 1;
            cell[64, 60] = 1;
            cell[65, 60] = 1;
            cell[66, 60] = 1;
            for (int i = 1; i < 125; i++)
            {
                for (int j = 1; j < 125; j++)
                {
                    newCell[i, j] = cell[i, j];
                }
            }
            Graphics g = this.CreateGraphics();
            for (int i = 0; i < 126; i++)
            {
                for (int j = 0; j < 126; j++)
                {
                    if (cell[i, j] == 1)
                    {
                        g.FillRectangle(blackBrush, i * 4, j * 4, 4, 4);
                    }
                    else
                    {
                        g.FillRectangle(whiteBrush, i * 4, j * 4, 4, 4);
                    }
                }
            }
            g.Dispose();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            cell[80, 80] = 1;
            cell[80, 81] = 1;
            cell[80, 82] = 1;
            cell[80, 83] = 1;
            cell[80, 84] = 1;
            for (int i = 1; i < 125; i++)
            {
                for (int j = 1; j < 125; j++)
                {
                    newCell[i, j] = cell[i, j];
                }
            }
            Graphics g = this.CreateGraphics();
            for (int i = 0; i < 126; i++)
            {
                for (int j = 0; j < 126; j++)
                {
                    if (cell[i, j] == 1)
                    {
                        g.FillRectangle(blackBrush, i * 4, j * 4, 4, 4);
                    }
                    else
                    {
                        g.FillRectangle(whiteBrush, i * 4, j * 4, 4, 4);
                    }
                }
            }
            g.Dispose();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            cell[68, 67] = 1;
            cell[68, 69] = 1;
            cell[69, 68] = 1;
            cell[69, 69] = 1;
            cell[67, 69] = 1;
            for (int i = 1; i < 125; i++)
            {
                for (int j = 1; j < 125; j++)
                {
                    newCell[i, j] = cell[i, j];
                }
            }
            Graphics g = this.CreateGraphics();
            for (int i = 0; i < 126; i++)
            {
                for (int j = 0; j < 126; j++)
                {
                    if (cell[i, j] == 1)
                    {
                        g.FillRectangle(blackBrush, i * 4, j * 4, 4, 4);
                    }
                    else
                    {
                        g.FillRectangle(whiteBrush, i * 4, j * 4, 4, 4);
                    }
                }
            }
            g.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int neightbor;//temp variable to count live adjacent cell
            for(int i = 1; i < 125; i++)
            {
                for (int j = 1; j < 125; j++)
                {
                    neightbor = cell[i - 1, j - 1] + cell[i, j - 1] + cell[i + 1, j - 1] + cell[i - 1, j] + cell[i + 1, j] + cell[i - 1, j + 1] + cell[i, j + 1] + cell[i + 1, j + 1];
                    //conway's game of life function
                    if (cell[i, j] == 1)
                    {
                        if ((neightbor != 2) && (neightbor != 3))
                        {
                            newCell[i, j] = 0;
                        }
                    }
                    else
                    {
                        if (neightbor == 3)
                        {
                            newCell[i, j] = 1;
                        }
                    }
                }
            }
            for (int i = 1; i < 125; i++)
            {
                for (int j = 1; j < 125; j++)
                {
                    cell[i,j] = newCell[i,j];
                }
            }
            Graphics g2 = this.CreateGraphics();
            for (int i = 1; i < 126; i++)
            {
                for(int j = 1; j < 126; j++)
                {
                    if(cell[i,j] == 1)
                    {
                        g2.FillRectangle(blackBrush, i * 4, j * 4, 4, 4);
                    }
                    else
                    {
                        g2.FillRectangle(whiteBrush, i * 4, j * 4, 4, 4);
                    }
                }
            }
        }
    }
    
}
