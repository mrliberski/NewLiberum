using DocumentFormat.OpenXml.Bibliography;
using ProFormaLibraries;
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
    public partial class formCounts : Form
    {
        public List<PackagingCount> counts = new List<PackagingCount>();

        public formCounts()
        {
            InitializeComponent();
            LoadTheme();
            ClearAllTextBoxes(this);
            errorLabel.Visible = false;
        }

        private void formCounts_Load(object sender, EventArgs e)
        {

        }


        // Apply button themes to current forms
        private void LoadTheme()
        {
            foreach (System.Windows.Forms.Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            //label3.ForeColor = ThemeColor.PrimaryColor;
            //label4.ForeColor = ThemeColor.SecondaryColor;
        }

        // Clear all textobxes
        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
        }

        private void ClearAllTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearAllTextBoxes(c);
                }
            }

            errorLabel.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int quantityOfItems))
            {
                updateBFSlabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                textBox1.Text = string.Empty;
                updateBFSlabel();
                errorLabel.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //int quantityOfItems;
            if (int.TryParse(textBox2.Text, out int quantityOfItems))
            {
                updateBFSlabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                textBox2.Text = string.Empty;
                updateBFSlabel();
                errorLabel.Visible = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //int quantityOfItems;
            if (int.TryParse(textBox5.Text, out int quantityOfItems))
            {
                updateBFSlabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                textBox5.Text = string.Empty;
                updateBFSlabel();
                errorLabel.Visible = true;
            }
        }

        private void updateBFSlabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(textBox2.Text, out fulls))
            {
                fulls = int.Parse(textBox2.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(textBox1.Text, out empties))
            {
                empties = int.Parse(textBox1.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(textBox5.Text, out damaged))
            {
                damaged = int.Parse(textBox5.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            label12.Text = ((empties + fulls + damaged) * int.Parse(label9.Text)).ToString();
            //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PackagingCount TopperBFS = new PackagingCount();
            PackagingCount Lower = new PackagingCount();
            PackagingCount Decor = new PackagingCount();
            PackagingCount TopcoverDS = new PackagingCount();

            //TOPPER BFS
            TopperBFS.PackagingName = "F6X Topper Pad BFS";
            TopperBFS.PackagingNumber = "6221438";
            if (int.TryParse(textBox1.Text, out int result))
                TopperBFS.CountOfEmpties = result;
            else
                TopperBFS.CountOfEmpties = 0;
            if (int.TryParse(textBox2.Text, out result))
                TopperBFS.CountOfFulls = result;
            else
                TopperBFS.CountOfFulls = 0;
            if (int.TryParse(textBox5.Text, out result))
                TopperBFS.CountOfDamaged = result;
            else
                TopperBFS.CountOfDamaged = 0;
            TopperBFS.PalletFactor = int.Parse(label9.Text);
            TopperBFS.PackFactor = int.Parse(label84.Text);
            TopperBFS.TotalContainers = int.Parse(label12.Text);
            // END OF TOPPER BFS

            //LOWER
            Lower.PackagingName = "F6X IP Lower";
            Lower.PackagingNumber = "6223190";
            if (int.TryParse(lowerEmpriesTextBox.Text, out result))
                Lower.CountOfEmpties = result;
            else
                Lower.CountOfEmpties = 0;
            if (int.TryParse(lowersFullsTextBox.Text, out result))
                Lower.CountOfFulls = result;
            else
                Lower.CountOfFulls = 0;
            if (int.TryParse(lowersDamagedTextBox.Text, out result))
                Lower.CountOfDamaged = result;
            else
                Lower.CountOfDamaged = 0;
            Lower.PalletFactor = int.Parse(lowerPalletFactorLabel.Text);
            Lower.PackFactor = int.Parse(label82.Text);
            Lower.TotalContainers = int.Parse(lowerTotalLabel.Text);
            // END OF LOWER

            //decor
            Decor.PackagingName = "F6X Decor Pad";
            Decor.PackagingNumber = "6221434";
            if (int.TryParse(DecorEmptiestextBox.Text, out result))
                Decor.CountOfEmpties = result;
            else
                Decor.CountOfEmpties = 0;
            if (int.TryParse(DecorFulltextBox.Text, out result))
                Decor.CountOfFulls = result;
            else
                Decor.CountOfFulls = 0;
            if (int.TryParse(DecorDamagedtextBox.Text, out result))
                Decor.CountOfDamaged = result;
            else
                Decor.CountOfDamaged = 0;
            Decor.PalletFactor = int.Parse(DecorPalletFactorlabel.Text);
            Decor.PackFactor = int.Parse(label81.Text);
            Decor.TotalContainers = int.Parse(DecorTotalLabel.Text);
            // END OF decor

            //Topper DS
            TopcoverDS.PackagingName = "F6X Topcover DS";
            TopcoverDS.PackagingNumber = "6221436";
            if (int.TryParse(topCoverEmptiestextBox.Text, out result))
                TopcoverDS.CountOfEmpties = result;
            else
                TopcoverDS.CountOfEmpties = 0;
            if (int.TryParse(topCoverFullsTextBox.Text, out result))
                TopcoverDS.CountOfFulls = result;
            else
                TopcoverDS.CountOfFulls = 0;
            if (int.TryParse(topcoverDamagedTextBox.Text, out result))
                TopcoverDS.CountOfDamaged = result;
            else
                TopcoverDS.CountOfDamaged = 0;
            TopcoverDS.PalletFactor = int.Parse(topCoverPalletFactorLabel.Text);
            TopcoverDS.PackFactor = int.Parse(label80.Text);
            TopcoverDS.TotalContainers = int.Parse(topCoverTotalLabel.Text);
            // END OF TOPPER BFS

            counts.Add(TopperBFS);
            counts.Add(Lower);
            counts.Add(Decor);
            counts.Add(TopcoverDS);

            //MessageBox.Show("Getting there");


            //Create email body and pass it to sender class
            string emailsss; 
            emailsss = PackagingCountTemplate.PackagingCountEmailBody(counts);
            PackagingCountTemplate.SendPackagingCount(emailsss);

            ClearAllTextBoxes(this);
        }

        //ip lowers
        private void lowerEmpriesTextBox_TextChanged(object sender, EventArgs e)
        {
            //int quantityOfItems;
            if (int.TryParse(lowerEmpriesTextBox.Text, out int quantityOfItems))
            {
                updateLowerLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                lowerEmpriesTextBox.Text = string.Empty;
                updateLowerLabel();
                errorLabel.Visible = true;
            }
        }

        private void lowersFullsTextBox_TextChanged(object sender, EventArgs e)
        {
            //int quantityOfItems;
            if (int.TryParse(lowersFullsTextBox.Text, out int quantityOfItems))
            {
                updateLowerLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                lowersFullsTextBox.Text = string.Empty;
                updateLowerLabel();
                errorLabel.Visible = true;
            }
        }

        private void lowersDamagedTextBox_TextChanged(object sender, EventArgs e)
        {
            //int quantityOfItems;
            if (int.TryParse(lowersDamagedTextBox.Text, out int quantityOfItems))
            {
                updateLowerLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                lowersDamagedTextBox.Text = string.Empty;
                updateLowerLabel();
                errorLabel.Visible = true;
            }
        }

        private void updateLowerLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(lowersFullsTextBox.Text, out fulls))
            {
                fulls = int.Parse(lowersFullsTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(lowerEmpriesTextBox.Text, out empties))
            {
                empties = int.Parse(lowerEmpriesTextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(lowersDamagedTextBox.Text, out damaged))
            {
                damaged = int.Parse(lowersDamagedTextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            lowerTotalLabel.Text = ((empties + fulls + damaged) * int.Parse(lowerPalletFactorLabel.Text)).ToString();
        }

        private void DecorEmptiestextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(DecorEmptiestextBox.Text, out int quantityOfItems))
            {
                updateDecorLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                DecorEmptiestextBox.Text = string.Empty;
                updateDecorLabel();
                errorLabel.Visible = true;
            }
        }

        private void updateDecorLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(DecorFulltextBox.Text, out fulls))
            {
                fulls = int.Parse(DecorFulltextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(DecorEmptiestextBox.Text, out empties))
            {
                empties = int.Parse(DecorEmptiestextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(DecorDamagedtextBox.Text, out damaged))
            {
                damaged = int.Parse(DecorDamagedtextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            DecorTotalLabel.Text = ((empties + fulls + damaged) * int.Parse(DecorPalletFactorlabel.Text)).ToString();
        }

        private void DecorFulltextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(DecorFulltextBox.Text, out int quantityOfItems))
            {
                updateDecorLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                DecorFulltextBox.Text = string.Empty;
                updateDecorLabel();
                errorLabel.Visible = true;
            }
        }

        private void DecorDamagedtextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(DecorDamagedtextBox.Text, out int quantityOfItems))
            {
                updateDecorLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                DecorDamagedtextBox.Text = string.Empty;
                updateDecorLabel();
                errorLabel.Visible = true;
            }
        }

        private void topCoverEmptiestextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(topCoverEmptiestextBox.Text, out int quantityOfItems))
            {
                updateTopCoverLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                topCoverEmptiestextBox.Text = string.Empty;
                updateTopCoverLabel();
                errorLabel.Visible = true;
            }
        }

        private void topCoverFullsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(topCoverFullsTextBox.Text, out int quantityOfItems))
            {
                updateTopCoverLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                topCoverFullsTextBox.Text = string.Empty;
                updateTopCoverLabel();
                errorLabel.Visible = true;
            }
        }

        private void topcoverDamagedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(topcoverDamagedTextBox.Text, out int quantityOfItems))
            {
                updateTopCoverLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                topcoverDamagedTextBox.Text = string.Empty;
                updateTopCoverLabel();
                errorLabel.Visible = true;
            }
        }

        private void updateTopCoverLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(topCoverFullsTextBox.Text, out fulls))
            {
                fulls = int.Parse(topCoverFullsTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(topCoverEmptiestextBox.Text, out empties))
            {
                empties = int.Parse(topCoverEmptiestextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(topcoverDamagedTextBox.Text, out damaged))
            {
                damaged = int.Parse(topcoverDamagedTextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            topCoverTotalLabel.Text = ((empties + fulls + damaged) * int.Parse(topCoverPalletFactorLabel.Text)).ToString();
        }
    }
}
