using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFormaUI.Forms
{
    public partial class ProductionPlan : Form
    {
        private Button[] buttons;

        public ProductionPlan()
        {
            InitializeComponent();
            
            InitializeButtons();
        }


 

        private void InitializeButtons()
        {
            buttons = new Button[24]; // Change the array size to 6
            for (int i = 0; i < 24; i++) // Loop through 6 buttons
            {
                buttons[i] = new Button();
                buttons[i].Text = "Button " + (i + 1);
                buttons[i].Size = new Size(80, 80); // Set size to 80x80
                buttons[i].Location = new Point(10 + i * 80, 300); // Position in a line without gaps
                buttons[i].Click += new EventHandler(Button_Click);
                this.Controls.Add(buttons[i]);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int buttonIndex = Array.IndexOf(buttons, clickedButton);

            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter a number (1-5):", "Input Required", "1");
            if (int.TryParse(input, out int x) && x >= 1 && x <= 24)
            {
                for (int i = buttonIndex; i < buttonIndex + x && i < buttons.Length; i++)
                {
                    buttons[i].BackColor = Color.Red;
                    buttons[(i + 1)].BackColor = Color.Orange;
                    //buttons[(i + 1)].Text = "Tool Change";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number between 1 and 5.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }





        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new ProductionPlanForm());
        //}
    }
}
