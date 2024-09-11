using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProFormaLibraries;



namespace ProFormaUI
{
    public partial class MainPanel : Form
    {
        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;


        //Constructor
        public MainPanel()
        {
            InitializeComponent();
            random = new Random();
        }


        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        // Highlight the buitton that has been clicked
        // select random color from theme
        // change bckgrnd of buttom
        // Selected font color of button
        //  change font size of button
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
        }

        private void btnCounts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        //private void button9_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        //private void button10_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        //private void button11_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        //private void button12_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        ////exit button
        //private void button13_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    this.Close();
        //}

        private void MainPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        // exit button
        private void button10_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Close();
        }
    }
}
