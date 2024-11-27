using ProFormaLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFormaUI.Forms
{
    public partial class BentleyCount : Form
    {
        public List<BentleyCountModel> count = new List<BentleyCountModel>();

        public BentleyCount()
        {
            InitializeComponent();
            LoadTheme();
            ErrorLabel.Visible = false;
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

            ErrorLabel.Visible = false;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void LHassyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LHassyTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateLhAssyTotal();
            }
            else
            {
                LHassyTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateLhAssyTotal();
            }
        }

        private void UpdateLhAssyTotal()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(LHassyTextBox.Text, out fulls))
            {
                fulls = int.Parse(LHassyTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            LhAssyTotalParts.Text = (fulls * int.Parse(LhAssyPackFactor.Text)).ToString();
        }

        private void LhSubstrateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LhSubstrateTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateLhSub();
            }
            else
            {
                LhSubstrateTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateLhSub();
            }
        }

        private void UpdateLhSub()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(LhSubstrateTextBox.Text, out fulls))
            {
                fulls = int.Parse(LhSubstrateTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            LhSubTotalParts.Text = (fulls * int.Parse(LhSubPackFactor.Text)).ToString();
        }

        private void LHWadTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LHWadTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateLhWad();
            }
            else
            {
                LHWadTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateLhWad();
            }
        }

        private void UpdateLhWad()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(LHWadTextBox.Text, out fulls))
            {
                fulls = int.Parse(LHWadTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            LhWadTotalParts.Text = (fulls * int.Parse(LhWadPackFactor.Text)).ToString();
        }

        private void LhHudTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LhHudTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateLhHud();
            }
            else
            {
                LhHudTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateLhHud();
            }
        }

        private void UpdateLhHud()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(LhHudTextBox.Text, out fulls))
            {
                fulls = int.Parse(LhHudTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            LhHudTotal.Text = (fulls * int.Parse(LhHudPackFactor.Text)).ToString();
        }

        private void LhPabTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LhPabTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateLhPab();
            }
            else
            {
                LhPabTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateLhPab();
            }
        }

        private void UpdateLhPab()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(LhPabTextBox.Text, out fulls))
            {
                fulls = int.Parse(LhPabTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            LhPabTotalParts.Text = (fulls * int.Parse(LhPabPackFactor.Text)).ToString();
        }

        private void LhUnlaseredTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LhUnlaseredTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateUnlaseredLH();
            }
            else
            {
                LhUnlaseredTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateUnlaseredLH();
            }
        }

        private void UpdateUnlaseredLH()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(LhUnlaseredTextBox.Text, out fulls))
            {
                fulls = int.Parse(LhUnlaseredTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            LhUnlasTotalParts.Text = (fulls * int.Parse(LhUnlaseredPackFactor.Text)).ToString();
        }

        private void RhFinishedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(RhFinishedTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateRhFinished();
            }
            else
            {
                RhFinishedTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateRhFinished();
            }
        }

        private void UpdateRhFinished()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(RhFinishedTextBox.Text, out fulls))
            {
                fulls = int.Parse(RhFinishedTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            RhFinishedTotal.Text = (fulls * int.Parse(RhFinishedPackFactor.Text)).ToString();
        }

        private void RhSubTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(RhSubTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateRhSub();
            }
            else
            {
                RhSubTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateRhSub();
            }
        }

        private void UpdateRhSub()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(RhSubTextBox.Text, out fulls))
            {
                fulls = int.Parse(RhSubTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            RhSubTotal.Text = (fulls * int.Parse(RhSubPackFactor.Text)).ToString();
        }

        private void RhWadTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(RhWadTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateRhWad();
            }
            else
            {
                RhWadTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateRhWad();
            }
        }

        private void UpdateRhWad()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(RhWadTextBox.Text, out fulls))
            {
                fulls = int.Parse(RhWadTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            RhWadTotal.Text = (fulls * int.Parse(RhWadPackFactor.Text)).ToString();
        }

        private void RhHudTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(RhHudTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateRhHud();
            }
            else
            {
                RhHudTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateRhHud();
            }
        }

        private void UpdateRhHud()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(RhHudTextBox.Text, out fulls))
            {
                fulls = int.Parse(RhHudTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            RhHudTotal.Text = (fulls * int.Parse(RhHudPackFactor.Text)).ToString();
        }

        private void RhPabTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(RhPabTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateRhPab();
            }
            else
            {
                RhPabTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateRhPab();
            }
        }

        private void UpdateRhPab()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(RhPabTextBox.Text, out fulls))
            {
                fulls = int.Parse(RhPabTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            RhPabTotal.Text = (fulls * int.Parse(RhPabPackFactor.Text)).ToString();
        }

        private void RhUnlasTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(RhUnlasTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateRHUnlas();
            }
            else
            {
                RhUnlasTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateRHUnlas();
            }
        }

        private void UpdateRHUnlas()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(RhUnlasTextBox.Text, out fulls))
            {
                fulls = int.Parse(RhUnlasTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            RhUnlasTotal.Text = (fulls * int.Parse(RhUnlasPackFactor.Text)).ToString();
        }

        private void LhCmpTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LhCmpTextBox.Text, out int quantityOfItems))
            {
                ErrorLabel.Visible = false;
                UpdateCmp();
            }
            else
            {
                LhCmpTextBox.Text = string.Empty;
                ErrorLabel.Visible = true;
                UpdateCmp();
            }
        }

        private void UpdateCmp()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(LhCmpTextBox.Text, out fulls))
            {
                fulls = int.Parse(LhCmpTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            CmpTotal.Text = (fulls * int.Parse(CmpPackFactor.Text)).ToString();
        }

        //reset
        private void button2_Click_1(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
        }

        //submit
        private void button3_Click(object sender, EventArgs e)
        {
            BentleyCountModel LhFinished = new BentleyCountModel();
            BentleyCountModel LhSub = new BentleyCountModel();
            BentleyCountModel LhWad = new BentleyCountModel();
            BentleyCountModel LhHud = new BentleyCountModel();
            BentleyCountModel LhPab = new BentleyCountModel();
            BentleyCountModel LhUnlas = new BentleyCountModel();

            BentleyCountModel RhFinished = new BentleyCountModel();
            BentleyCountModel RhSub = new BentleyCountModel();
            BentleyCountModel RhWad = new BentleyCountModel();
            BentleyCountModel RhHud = new BentleyCountModel();
            BentleyCountModel RhPab = new BentleyCountModel();
            BentleyCountModel RhUnlas = new BentleyCountModel();

            BentleyCountModel LhCmp = new BentleyCountModel();

            LhFinished.PackagingName = label14.Text;
            LhFinished.PackagingNumber = label15.Text;
            LhFinished.CountOfEmpties = int.Parse(LHassyTextBox.Text);
            LhFinished.PackFactor = int.Parse(LhAssyPackFactor.Text);
            LhFinished.TotalParts = int.Parse(LhAssyTotalParts.Text);

            LhSub.PackagingName = label1.Text;
            LhSub.PackagingNumber = label2.Text;
            LhSub.CountOfEmpties = int.Parse(LhSubstrateTextBox.Text);
            LhSub.PackFactor = int.Parse(LhSubPackFactor.Text);
            LhSub.TotalParts = int.Parse(LhSubTotalParts.Text);

            LhWad.PackagingName = label5.Text;
            LhWad.PackagingNumber = label6.Text;
            LhWad.CountOfEmpties = int.Parse(LHWadTextBox.Text);
            LhWad.PackFactor = int.Parse(LhWadPackFactor.Text);
            LhWad.TotalParts = int.Parse(LhWadTotalParts.Text);

            LhHud.PackagingName = label18.Text;
            LhHud.PackagingNumber = label17.Text;
            LhHud.CountOfEmpties = int.Parse(LhHudTextBox.Text);
            LhHud.PackFactor = int.Parse(LhHudPackFactor.Text);
            LhHud.TotalParts = int.Parse(LhHudTotal.Text);

            LhPab.PackagingName = label22.Text;
            LhPab.PackagingNumber = label21.Text;
            LhPab.CountOfEmpties = int.Parse(LhPabTextBox.Text);
            LhPab.PackFactor = int.Parse(LhPabPackFactor.Text);
            LhPab.TotalParts = int.Parse(LhPabTotalParts.Text);

            LhUnlas.PackagingName = label23.Text;
            LhUnlas.PackagingNumber = label24.Text;
            LhUnlas.CountOfEmpties = int.Parse(LhUnlaseredTextBox.Text);
            LhUnlas.PackFactor = int.Parse(LhUnlaseredPackFactor.Text);
            LhUnlas.TotalParts = int.Parse(LhUnlasTotalParts.Text);

            RhFinished.PackagingName = label27.Text;
            RhFinished.PackagingNumber = label28.Text;
            RhFinished.CountOfEmpties = int.Parse(RhFinishedTextBox.Text);
            RhFinished.PackFactor = int.Parse(RhFinishedPackFactor.Text);
            RhFinished.TotalParts = int.Parse(RhFinishedTotal.Text);

            RhSub.PackagingName = label43.Text;
            RhSub.PackagingNumber = label44.Text;
            RhSub.CountOfEmpties = int.Parse(RhSubTextBox.Text);
            RhSub.PackFactor = int.Parse(RhSubPackFactor.Text);
            RhSub.TotalParts = int.Parse(RhSubTotal.Text);

            RhWad.PackagingName = label42.Text;
            RhWad.PackagingNumber = label41.Text;
            RhWad.CountOfEmpties = int.Parse(RhWadTextBox.Text);
            RhWad.PackFactor = int.Parse(RhWadPackFactor.Text);
            RhWad.TotalParts = int.Parse(RhWadTotal.Text);

            RhHud.PackagingName = label38.Text;
            RhHud.PackagingNumber = label37.Text;
            RhHud.CountOfEmpties = int.Parse(RhHudTextBox.Text);
            RhHud.PackFactor = int.Parse(RhHudPackFactor.Text);
            RhHud.TotalParts = int.Parse(RhHudTotal.Text);

            RhPab.PackagingName = label35.Text;
            RhPab.PackagingNumber = label34.Text;
            RhPab.CountOfEmpties = int.Parse(RhPabTextBox.Text);
            RhPab.PackFactor = int.Parse(RhPabPackFactor.Text);
            RhPab.TotalParts = int.Parse(RhPabTotal.Text);

            RhUnlas.PackagingName = label13.Text;
            RhUnlas.PackagingNumber = label20.Text;
            RhUnlas.CountOfEmpties = int.Parse(RhUnlasTextBox.Text);
            RhUnlas.PackFactor = int.Parse(RhUnlasPackFactor.Text);
            RhUnlas.TotalParts = int.Parse(RhUnlasTotal.Text);

            LhCmp.PackagingName = label47.Text;
            LhCmp.PackagingNumber = label48.Text;
            LhCmp.CountOfEmpties = int.Parse(LhCmpTextBox.Text);
            LhCmp.PackFactor = int.Parse(CmpPackFactor.Text);
            LhCmp.TotalParts = int.Parse(CmpTotal.Text);

            count.Add(LhFinished);
            count.Add(LhSub);
            count.Add(LhWad);
            count.Add(LhHud);
            count.Add(LhPab);
            count.Add(LhUnlas);

            count.Add(RhFinished);
            count.Add(RhSub);
            count.Add(RhWad);
            count.Add(RhHud);
            count.Add(RhPab);
            count.Add(RhUnlas);

            count.Add(LhCmp);

            //TODO:
            //SqliteDataAccess.AddBentleyCount();

            //Create email body and pass it to sender class
            string emails;
            emails = BentleyCountProcedures.BentleyCountEmailBody(count);
            BentleyCountProcedures.SendBentleyCount(emails);

            ClearAllTextBoxes(this);
            count.Clear();
        }
    }
}
