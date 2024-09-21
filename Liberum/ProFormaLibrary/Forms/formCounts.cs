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


        /// <summary>
        /// SUBMITTING FORM DATA TO HTML LibRARY
        /// </summary>

        private void button3_Click(object sender, EventArgs e)
        {
            PackagingCount TopperBFS = new PackagingCount();
            PackagingCount Lower = new PackagingCount();
            PackagingCount Decor = new PackagingCount();
            PackagingCount TopcoverDS = new PackagingCount();

            PackagingCount StColLowAssy = new PackagingCount(); 
            PackagingCount Lklt6147 = new PackagingCount();
            PackagingCount Lklt6410 = new PackagingCount();
            PackagingCount Lklt8210 = new PackagingCount();
            PackagingCount projCover = new PackagingCount();
            PackagingCount projServCover = new PackagingCount();
            PackagingCount sideCover = new PackagingCount();
            PackagingCount lowerCap = new PackagingCount();
            PackagingCount cidCover = new PackagingCount();
            PackagingCount sideCap = new PackagingCount();
            PackagingCount StColUpAssy = new PackagingCount();

            PackagingCount lids = new PackagingCount();
            PackagingCount pallets = new PackagingCount();
            PackagingCount metalPallets = new PackagingCount();


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

            //PackagingCount StColLowAssy = new PackagingCount();
            StColLowAssy.PackagingName = "F6X Steering Column Lower Assy";
            StColLowAssy.PackagingNumber = "3084318";
            if (int.TryParse(lowColEmptyTextBox.Text, out result))
                StColLowAssy.CountOfEmpties = result;
            else
                StColLowAssy.CountOfEmpties = 0;
            if (int.TryParse(lowColFullTextBox.Text, out result))
                StColLowAssy.CountOfFulls = result;
            else
                StColLowAssy.CountOfFulls = 0;
            if (int.TryParse(LowColDamagedTextBox.Text, out result))
                StColLowAssy.CountOfDamaged = result;
            else
                StColLowAssy.CountOfDamaged = 0;
            StColLowAssy.PalletFactor = int.Parse(LowColPalletFactotTextBox.Text);
            StColLowAssy.PackFactor = int.Parse(LowColPackFactorTextBox.Text);
            StColLowAssy.TotalContainers = int.Parse(LowColTotalContTextBox.Text);

            //PackagingCount Lklt6147 = new PackagingCount();
            Lklt6147.PackagingName = "F6X Emergency Sp brkt; Puddle Lamp";
            Lklt6147.PackagingNumber = "3106147";
            if (int.TryParse(PuddleEmptiesTextBox.Text, out result))
                Lklt6147.CountOfEmpties = result;
            else
                Lklt6147.CountOfEmpties = 0;
            if (int.TryParse(PuddleFulltextBox.Text, out result))
                Lklt6147.CountOfFulls = result;
            else
                Lklt6147.CountOfFulls = 0;
            if (int.TryParse(PuddleDamagedTextBox.Text, out result))
                Lklt6147.CountOfDamaged = result;
            else
                Lklt6147.CountOfDamaged = 0;
            Lklt6147.PalletFactor = int.Parse(puddlePalletFactorLabel.Text);
            Lklt6147.PackFactor = int.Parse(puddlePackFactorLabel.Text);
            Lklt6147.TotalContainers = int.Parse(PuddletotalLabel.Text);

            //PackagingCount Lklt6410 = new PackagingCount();
            Lklt6410.PackagingName = "F6X Footwell Cover";
            Lklt6410.PackagingNumber = "3106410";
            if (int.TryParse(FootwellEmptytextBox.Text, out result))
                Lklt6410.CountOfEmpties = result;
            else
                Lklt6410.CountOfEmpties = 0;
            if (int.TryParse(FootwellFullTextBox.Text, out result))
                Lklt6410.CountOfFulls = result;
            else
                Lklt6410.CountOfFulls = 0;
            if (int.TryParse(FootwellDamagedTextbox.Text, out result))
                Lklt6410.CountOfDamaged = result;
            else
                Lklt6410.CountOfDamaged = 0;
            Lklt6410.PalletFactor = int.Parse(footwellPalletFactorLabel.Text);
            Lklt6410.PackFactor = int.Parse(footwellPackFactorLabel.Text);
            Lklt6410.TotalContainers = int.Parse(footwellTotalLabel.Text);

            //PackagingCount Lklt8210 = new PackagingCount();
            Lklt8210.PackagingName = "F6X Air Splitter";
            Lklt8210.PackagingNumber = "3108210";
            if (int.TryParse(AirsplitterEmptiesTextBox.Text, out result))
                Lklt8210.CountOfEmpties = result;
            else
                Lklt8210.CountOfEmpties = 0;
            if (int.TryParse(AirsplitterFullstextBox.Text, out result))
                Lklt8210.CountOfFulls = result;
            else
                Lklt8210.CountOfFulls = 0;
            if (int.TryParse(AirsplitterDamagedtextBox.Text, out result))
                Lklt8210.CountOfDamaged = result;
            else
                Lklt8210.CountOfDamaged = 0;
            Lklt8210.PalletFactor = int.Parse(AirsplitterPalletrFactorLabel.Text);
            Lklt8210.PackFactor = int.Parse(AirsplitterPackFactorlabel.Text);
            Lklt8210.TotalContainers = int.Parse(AirsplitterTotallabel.Text);

            //PackagingCount projCover = new PackagingCount();
            projCover.PackagingName = "F6X Projector Cover";
            projCover.PackagingNumber = "6214972";
            if (int.TryParse(ProjectorCoveremptiestextBox.Text, out result))
                projCover.CountOfEmpties = result;
            else
                projCover.CountOfEmpties = 0;
            if (int.TryParse(ProjectorCoverFullStextBox.Text, out result))
                projCover.CountOfFulls = result;
            else
                projCover.CountOfFulls = 0;
            if (int.TryParse(ProjectorCoverDamagedtextBox.Text, out result))
                projCover.CountOfDamaged = result;
            else
                projCover.CountOfDamaged = 0;
            projCover.PalletFactor = int.Parse(ProjectorCoverPalletFactorlabel.Text);
            projCover.PackFactor = int.Parse(ProjectorCoverPackFactorlabel.Text);
            projCover.TotalContainers = int.Parse(ProjectorCoverTotallabel.Text);

            //PackagingCount projServCover = new PackagingCount();
            projServCover.PackagingName = "F6X Projector Service Cover";
            projServCover.PackagingNumber = "6215016";
            if (int.TryParse(ProjServCoverEmptiestextBox.Text, out result))
                projServCover.CountOfEmpties = result;
            else
                projServCover.CountOfEmpties = 0;
            if (int.TryParse(ProjServCoverFullstextBox.Text, out result))
                projServCover.CountOfFulls = result;
            else
                projServCover.CountOfFulls = 0;
            if (int.TryParse(ProjServCoverDamagedtextBox.Text, out result))
                projServCover.CountOfDamaged = result;
            else
                projServCover.CountOfDamaged = 0;
            projServCover.PalletFactor = int.Parse(ProjServCoverPalletFactorlabel.Text);
            projServCover.PackFactor = int.Parse(ProjServCoverPckFactorlabel.Text);
            projServCover.TotalContainers = int.Parse(ProjServCoverTotalLabel.Text);

            //PackagingCount sideCover = new PackagingCount();
            sideCover.PackagingName = "F6X Projector Shutter & Side Cover";
            sideCover.PackagingNumber = "6215572";
            if (int.TryParse(SideCoverEmptiesTextBox.Text, out result))
                sideCover.CountOfEmpties = result;
            else
                sideCover.CountOfEmpties = 0;
            if (int.TryParse(SideCoverFulltextBox.Text, out result))
                sideCover.CountOfFulls = result;
            else
                sideCover.CountOfFulls = 0;
            if (int.TryParse(SideCoverDamagedtextBox.Text, out result))
                sideCover.CountOfDamaged = result;
            else
                sideCover.CountOfDamaged = 0;
            sideCover.PalletFactor = int.Parse(SideCoverPalletFactorlabel.Text);
            sideCover.PackFactor = int.Parse(SideCoverPackFactorlabel.Text);
            sideCover.TotalContainers = int.Parse(SideCoverTotallabel.Text);

            //PackagingCount lowerCap = new PackagingCount();
            lowerCap.PackagingName = "F6X Lower Cap";
            lowerCap.PackagingNumber = "6218708";
            if (int.TryParse(LoweCapEmptiesTextBox.Text, out result))
                lowerCap.CountOfEmpties = result;
            else
                lowerCap.CountOfEmpties = 0;
            if (int.TryParse(LoweCapFullstextBox.Text, out result))
                lowerCap.CountOfFulls = result;
            else
                lowerCap.CountOfFulls = 0;
            if (int.TryParse(LoweCapDamagedtextBox.Text, out result))
                lowerCap.CountOfDamaged = result;
            else
                lowerCap.CountOfDamaged = 0;
            lowerCap.PalletFactor = int.Parse(LoweCapPalletFactorlabel.Text);
            lowerCap.PackFactor = int.Parse(LoweCapPackFctorlabel.Text);
            lowerCap.TotalContainers = int.Parse(LoweCapTotallabel.Text);

            //PackagingCount cidCover = new PackagingCount();
            cidCover.PackagingName = "F6X CID Cover Base";
            cidCover.PackagingNumber = "6221407";
            if (int.TryParse(CIDcoverEmptiestextBox.Text, out result))
                cidCover.CountOfEmpties = result;
            else
                cidCover.CountOfEmpties = 0;
            if (int.TryParse(CIDcoverFullstextBox.Text, out result))
                cidCover.CountOfFulls = result;
            else
                cidCover.CountOfFulls = 0;
            if (int.TryParse(CIDcoverDamagedtextBox.Text, out result))
                cidCover.CountOfDamaged = result;
            else
                cidCover.CountOfDamaged = 0;
            cidCover.PalletFactor = int.Parse(CIDcoverPalletFactorlabel.Text);
            cidCover.PackFactor = int.Parse(CIDcoverPackFactorlabel.Text);
            cidCover.TotalContainers = int.Parse(CIDcoverTotallabel.Text);

            //PackagingCount sideCap = new PackagingCount();
            sideCap.PackagingName = "F6X Side Cap";
            sideCap.PackagingNumber = "6221431";
            if (int.TryParse(SideCapemptiesTextBox.Text, out result))
                sideCap.CountOfEmpties = result;
            else
                sideCap.CountOfEmpties = 0;
            if (int.TryParse(SideCapFullstextBox.Text, out result))
                sideCap.CountOfFulls = result;
            else
                sideCap.CountOfFulls = 0;
            if (int.TryParse(SideCapDamagedtextBox.Text, out result))
                sideCap.CountOfDamaged = result;
            else
                sideCap.CountOfDamaged = 0;
            sideCap.PalletFactor = int.Parse(SideCapPalletFactorlabel.Text);
            sideCap.PackFactor = int.Parse(SideCapPackFactorlabel.Text);
            sideCap.TotalContainers = int.Parse(SideCapTotallabel.Text);

            //PackagingCount StColUpAssy = new PackagingCount();
            StColUpAssy.PackagingName = "F6X Sttering Column Upper Assy";
            StColUpAssy.PackagingNumber = "6224798";
            if (int.TryParse(StColUpperEmptiesTextBox.Text, out result))
                StColUpAssy.CountOfEmpties = result;
            else
                StColUpAssy.CountOfEmpties = 0;
            if (int.TryParse(StColUpperFullstextBox.Text, out result))
                StColUpAssy.CountOfFulls = result;
            else
                StColUpAssy.CountOfFulls = 0;
            if (int.TryParse(StColUpperDamagedtextBox.Text, out result))
                StColUpAssy.CountOfDamaged = result;
            else
                StColUpAssy.CountOfDamaged = 0;
            StColUpAssy.PalletFactor = int.Parse(StColUpperPalletFactorLabel.Text);
            StColUpAssy.PackFactor = int.Parse(StColUpperPackFactorLabel.Text);
            StColUpAssy.TotalContainers = int.Parse(StColUpperTotalLabel.Text);


            //PackagingCount lids = new PackagingCount();
            lids.PackagingName = "Pallets Of Lids";
            lids.PackagingNumber = "3101208";
            if (int.TryParse(LidsEmptiesTextBox.Text, out result))
                lids.CountOfEmpties = result;
            else
                lids.CountOfEmpties = 0;

            lids.CountOfFulls = 0;
            lids.CountOfDamaged = 0;
            lids.PalletFactor = int.Parse(LidsPalletFactorlabel.Text);
            lids.PackFactor = 1;
            lids.TotalContainers = int.Parse(LidsTotallabel.Text);

            //PackagingCount pallets = new PackagingCount();
            pallets.PackagingName = "Euro Pallets";
            pallets.PackagingNumber = "3100062";
            if (int.TryParse(EuroPalletEmptiesTextBox.Text, out result))
                pallets.CountOfEmpties = result;
            else
                pallets.CountOfEmpties = 0;

            pallets.CountOfFulls = 0;
            pallets.CountOfDamaged = 0;
            pallets.PalletFactor = 1;
            pallets.PackFactor = 1;
            pallets.TotalContainers = int.Parse(EuroPalletTotallabel.Text);

            //PackagingCount metalPallets = new PackagingCount();
            metalPallets.PackagingName = "Steel Pallets";
            metalPallets.PackagingNumber = "3102560";
            if (int.TryParse(metalPalEmptyTextBox.Text, out result))
                metalPallets.CountOfEmpties = result;
            else
                metalPallets.CountOfEmpties = 0;

            metalPallets.CountOfFulls = 0;
            metalPallets.CountOfDamaged = 0;
            metalPallets.PalletFactor = 1;
            metalPallets.PackFactor = 1;
            metalPallets.TotalContainers = int.Parse(MetalPalTotalLabel.Text);

            counts.Add(TopperBFS);
            counts.Add(Lower);
            counts.Add(Decor);
            counts.Add(TopcoverDS);

            counts.Add(StColLowAssy);
            counts.Add(Lklt6147);
            counts.Add(Lklt6410);
            counts.Add(Lklt8210);
            counts.Add(projCover);
            counts.Add(projServCover);
            counts.Add(sideCover);
            counts.Add(lowerCap);
            counts.Add(cidCover);
            counts.Add(sideCap);
            counts.Add(StColUpAssy);

            counts.Add(lids);
            counts.Add(pallets);
            counts.Add(metalPallets);


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


        /// <summary>
        /// LOWER COWL BLOCK
        /// </summary>

        private void lowColEmptyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(lowColEmptyTextBox.Text, out int quantityOfItems))
            {
                UpdateLowCowlTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                lowColEmptyTextBox.Text = string.Empty;
                UpdateLowCowlTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void lowColFullTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(lowColFullTextBox.Text, out int quantityOfItems))
            {
                UpdateLowCowlTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                lowColFullTextBox.Text = string.Empty;
                UpdateLowCowlTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void LowColDamagedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LowColDamagedTextBox.Text, out int quantityOfItems))
            {
                UpdateLowCowlTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                LowColDamagedTextBox.Text = string.Empty;
                UpdateLowCowlTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdateLowCowlTotalLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(lowColFullTextBox.Text, out fulls))
            {
                fulls = int.Parse(lowColFullTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(lowColEmptyTextBox.Text, out empties))
            {
                empties = int.Parse(lowColEmptyTextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(LowColDamagedTextBox.Text, out damaged))
            {
                damaged = int.Parse(LowColDamagedTextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            LowColTotalContTextBox.Text = ((empties + fulls + damaged) * int.Parse(LowColPalletFactotTextBox.Text)).ToString();
        }

        ///END OF ST COL LOWER BLOCK
        ///
        private void PuddleEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(PuddleEmptiesTextBox.Text, out int quantityOfItems))
            {
                UpdatePuddleTotal();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                PuddleEmptiesTextBox.Text = string.Empty;
                UpdatePuddleTotal();
                errorLabel.Visible = true;
            }
        }

        private void PuddleFulltextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(PuddleFulltextBox.Text, out int quantityOfItems))
            {
                UpdatePuddleTotal();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                PuddleFulltextBox.Text = string.Empty;
                UpdatePuddleTotal();
                errorLabel.Visible = true;
            }
        }

        private void PuddleDamagedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(PuddleDamagedTextBox.Text, out int quantityOfItems))
            {
                UpdatePuddleTotal();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                PuddleDamagedTextBox.Text = string.Empty;
                UpdatePuddleTotal();
                errorLabel.Visible = true;
            }
        }

        private void UpdatePuddleTotal()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(PuddleFulltextBox.Text, out fulls))
            {
                fulls = int.Parse(PuddleFulltextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(PuddleEmptiesTextBox.Text, out empties))
            {
                empties = int.Parse(PuddleEmptiesTextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(PuddleDamagedTextBox.Text, out damaged))
            {
                damaged = int.Parse(PuddleDamagedTextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            PuddletotalLabel.Text = ((empties + fulls + damaged) * int.Parse(puddlePalletFactorLabel.Text)).ToString();
        }
        /// end of puddle lamp block
        private void FootwellEmptytextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(FootwellEmptytextBox.Text, out int quantityOfItems))
            {
                UpdateFootwellTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                FootwellEmptytextBox.Text = string.Empty;
                UpdateFootwellTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void FootwellFullTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(FootwellFullTextBox.Text, out int quantityOfItems))
            {
                UpdateFootwellTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                FootwellFullTextBox.Text = string.Empty;
                UpdateFootwellTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void FootwellDamagedTextbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(FootwellDamagedTextbox.Text, out int quantityOfItems))
            {
                UpdateFootwellTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                FootwellDamagedTextbox.Text = string.Empty;
                UpdateFootwellTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdateFootwellTotalLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(FootwellFullTextBox.Text, out fulls))
            {
                fulls = int.Parse(FootwellFullTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(FootwellEmptytextBox.Text, out empties))
            {
                empties = int.Parse(FootwellEmptytextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(FootwellDamagedTextbox.Text, out damaged))
            {
                damaged = int.Parse(FootwellDamagedTextbox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            footwellTotalLabel.Text = ((empties + fulls + damaged) * int.Parse(footwellPalletFactorLabel.Text)).ToString();
        }
        // END OF FOOTWELL BLOCK

        private void AirsplitterEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(AirsplitterEmptiesTextBox.Text, out int quantityOfItems))
            {
                UpdateAirSplitterTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                AirsplitterEmptiesTextBox.Text = string.Empty;
                UpdateAirSplitterTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void AirsplitterFullstextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(AirsplitterFullstextBox.Text, out int quantityOfItems))
            {
                UpdateAirSplitterTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                AirsplitterFullstextBox.Text = string.Empty;
                UpdateAirSplitterTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void AirsplitterDamagedtextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(AirsplitterDamagedtextBox.Text, out int quantityOfItems))
            {
                UpdateAirSplitterTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                AirsplitterDamagedtextBox.Text = string.Empty;
                UpdateAirSplitterTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdateAirSplitterTotalLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(AirsplitterFullstextBox.Text, out fulls))
            {
                fulls = int.Parse(AirsplitterFullstextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(AirsplitterEmptiesTextBox.Text, out empties))
            {
                empties = int.Parse(AirsplitterEmptiesTextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(AirsplitterDamagedtextBox.Text, out damaged))
            {
                damaged = int.Parse(AirsplitterDamagedtextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            AirsplitterTotallabel.Text = ((empties + fulls + damaged) * int.Parse(AirsplitterPalletrFactorLabel.Text)).ToString();
        }
        /// <summary>
        /// END OF AIR PLITTER BLOCK
        /// </summary>

        private void ProjectorCoveremptiestextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ProjectorCoveremptiestextBox.Text, out int quantityOfItems))
            {
                UpdateProjcovTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                ProjectorCoveremptiestextBox.Text = string.Empty;
                UpdateProjcovTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void ProjectorCoverFullStextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ProjectorCoverFullStextBox.Text, out int quantityOfItems))
            {
                UpdateProjcovTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                ProjectorCoverFullStextBox.Text = string.Empty;
                UpdateProjcovTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void ProjectorCoverDamagedtextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ProjectorCoverDamagedtextBox.Text, out int quantityOfItems))
            {
                UpdateProjcovTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                ProjectorCoverDamagedtextBox.Text = string.Empty;
                UpdateProjcovTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdateProjcovTotalLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(ProjectorCoverFullStextBox.Text, out fulls))
            {
                fulls = int.Parse(ProjectorCoverFullStextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(ProjectorCoveremptiestextBox.Text, out empties))
            {
                empties = int.Parse(ProjectorCoveremptiestextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(ProjectorCoverDamagedtextBox.Text, out damaged))
            {
                damaged = int.Parse(ProjectorCoverDamagedtextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            ProjectorCoverTotallabel.Text = ((empties + fulls + damaged) * int.Parse(ProjectorCoverPalletFactorlabel.Text)).ToString();
        }

        private void ProjServCoverEmptiestextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ProjServCoverEmptiestextBox.Text, out int quantityOfItems))
            {
                UpdateProjServCovTotaLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                ProjServCoverEmptiestextBox.Text = string.Empty;
                UpdateProjServCovTotaLabel();
                errorLabel.Visible = true;
            }
        }

        private void ProjServCoverFullstextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ProjServCoverFullstextBox.Text, out int quantityOfItems))
            {
                UpdateProjServCovTotaLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                ProjServCoverFullstextBox.Text = string.Empty;
                UpdateProjServCovTotaLabel();
                errorLabel.Visible = true;
            }
        }

        private void ProjServCoverDamagedtextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ProjServCoverDamagedtextBox.Text, out int quantityOfItems))
            {
                UpdateProjServCovTotaLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                ProjServCoverDamagedtextBox.Text = string.Empty;
                UpdateProjServCovTotaLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdateProjServCovTotaLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(ProjServCoverFullstextBox.Text, out fulls))
            {
                fulls = int.Parse(ProjServCoverFullstextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(ProjServCoverEmptiestextBox.Text, out empties))
            {
                empties = int.Parse(ProjServCoverEmptiestextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(ProjServCoverDamagedtextBox.Text, out damaged))
            {
                damaged = int.Parse(ProjServCoverDamagedtextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            ProjServCoverTotalLabel.Text = ((empties + fulls + damaged) * int.Parse(ProjServCoverPalletFactorlabel.Text)).ToString();
        }

        private void SideCoverEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SideCoverEmptiesTextBox.Text, out int quantityOfItems))
            {
                UpdateSideCoverTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                SideCoverEmptiesTextBox.Text = string.Empty;
                UpdateSideCoverTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void SideCoverFulltextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SideCoverFulltextBox.Text, out int quantityOfItems))
            {
                UpdateSideCoverTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                SideCoverFulltextBox.Text = string.Empty;
                UpdateSideCoverTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void SideCoverDamagedtextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SideCoverDamagedtextBox.Text, out int quantityOfItems))
            {
                UpdateSideCoverTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                SideCoverDamagedtextBox.Text = string.Empty;
                UpdateSideCoverTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdateSideCoverTotLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(SideCoverFulltextBox.Text, out fulls))
            {
                fulls = int.Parse(SideCoverFulltextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(SideCoverEmptiesTextBox.Text, out empties))
            {
                empties = int.Parse(SideCoverEmptiesTextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(SideCoverDamagedtextBox.Text, out damaged))
            {
                damaged = int.Parse(SideCoverDamagedtextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            SideCoverTotallabel.Text = ((empties + fulls + damaged) * int.Parse(SideCoverPalletFactorlabel.Text)).ToString();
        }
        /// <summary>
        /// END OF SIDE COVER BLOCK
        /// </summary>

        private void LoweCapEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LoweCapEmptiesTextBox.Text, out int quantityOfItems))
            {
                UpdateLowCapTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                LoweCapEmptiesTextBox.Text = string.Empty;
                UpdateLowCapTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void LoweCapFullstextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LoweCapFullstextBox.Text, out int quantityOfItems))
            {
                UpdateLowCapTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                LoweCapFullstextBox.Text = string.Empty;
                UpdateLowCapTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void LoweCapDamagedtextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LoweCapDamagedtextBox.Text, out int quantityOfItems))
            {
                UpdateLowCapTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                LoweCapDamagedtextBox.Text = string.Empty;
                UpdateLowCapTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdateLowCapTotLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(LoweCapFullstextBox.Text, out fulls))
            {
                fulls = int.Parse(LoweCapFullstextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(LoweCapEmptiesTextBox.Text, out empties))
            {
                empties = int.Parse(LoweCapEmptiesTextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(LoweCapDamagedtextBox.Text, out damaged))
            {
                damaged = int.Parse(LoweCapDamagedtextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            LoweCapTotallabel.Text = ((empties + fulls + damaged) * int.Parse(LoweCapPalletFactorlabel.Text)).ToString();
        }

        private void CIDcoverEmptiestextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(CIDcoverEmptiestextBox.Text, out int quantityOfItems))
            {
                UpdateCIDcoverTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                CIDcoverEmptiestextBox.Text = string.Empty;
                UpdateCIDcoverTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void CIDcoverFullstextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(CIDcoverFullstextBox.Text, out int quantityOfItems))
            {
                UpdateCIDcoverTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                CIDcoverFullstextBox.Text = string.Empty;
                UpdateCIDcoverTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void CIDcoverDamagedtextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(CIDcoverDamagedtextBox.Text, out int quantityOfItems))
            {
                UpdateCIDcoverTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                CIDcoverDamagedtextBox.Text = string.Empty;
                UpdateCIDcoverTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdateCIDcoverTotLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(CIDcoverFullstextBox.Text, out fulls))
            {
                fulls = int.Parse(CIDcoverFullstextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(CIDcoverEmptiestextBox.Text, out empties))
            {
                empties = int.Parse(CIDcoverEmptiestextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(CIDcoverDamagedtextBox.Text, out damaged))
            {
                damaged = int.Parse(CIDcoverDamagedtextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            CIDcoverTotallabel.Text = ((empties + fulls + damaged) * int.Parse(CIDcoverPalletFactorlabel.Text)).ToString();
        }

        private void SideCapemptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SideCapemptiesTextBox.Text, out int quantityOfItems))
            {
                UpdateSideCapTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                SideCapemptiesTextBox.Text = string.Empty;
                UpdateSideCapTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void SideCapFullstextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SideCapFullstextBox.Text, out int quantityOfItems))
            {
                UpdateSideCapTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                SideCapFullstextBox.Text = string.Empty;
                UpdateSideCapTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void SideCapDamagedtextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SideCapDamagedtextBox.Text, out int quantityOfItems))
            {
                UpdateSideCapTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                SideCapDamagedtextBox.Text = string.Empty;
                UpdateSideCapTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdateSideCapTotLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(SideCapFullstextBox.Text, out fulls))
            {
                fulls = int.Parse(SideCapFullstextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(SideCapemptiesTextBox.Text, out empties))
            {
                empties = int.Parse(SideCapemptiesTextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(SideCapDamagedtextBox.Text, out damaged))
            {
                damaged = int.Parse(SideCapDamagedtextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            SideCapTotallabel.Text = ((empties + fulls + damaged) * int.Parse(SideCapPalletFactorlabel.Text)).ToString();
        }

        private void StColUpperEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(StColUpperEmptiesTextBox.Text, out int quantityOfItems))
            {
                UpdateStColTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                StColUpperEmptiesTextBox.Text = string.Empty;
                UpdateStColTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void StColUpperFullstextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(StColUpperFullstextBox.Text, out int quantityOfItems))
            {
                UpdateStColTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                StColUpperFullstextBox.Text = string.Empty;
                UpdateStColTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void StColUpperDamagedtextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(StColUpperDamagedtextBox.Text, out int quantityOfItems))
            {
                UpdateStColTotLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                StColUpperDamagedtextBox.Text = string.Empty;
                UpdateStColTotLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdateStColTotLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(StColUpperFullstextBox.Text, out fulls))
            {
                fulls = int.Parse(StColUpperFullstextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(StColUpperEmptiesTextBox.Text, out empties))
            {
                empties = int.Parse(StColUpperEmptiesTextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(StColUpperDamagedtextBox.Text, out damaged))
            {
                damaged = int.Parse(StColUpperDamagedtextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            StColUpperTotalLabel.Text = ((empties + fulls + damaged) * int.Parse(StColUpperPalletFactorLabel.Text)).ToString();
        }

        private void EuroPalletEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(EuroPalletEmptiesTextBox.Text, out int quantityOfItems))
            {
                UpdatePalletsTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                EuroPalletEmptiesTextBox.Text = string.Empty;
                UpdatePalletsTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void EuroPalletFullstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EuroPalletDamagedtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePalletsTotalLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(EuroPalletFullstextBox.Text, out fulls))
            {
                fulls = int.Parse(EuroPalletFullstextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            int empties;
            if (int.TryParse(EuroPalletEmptiesTextBox.Text, out empties))
            {
                empties = int.Parse(EuroPalletEmptiesTextBox.Text);
            }
            else
            {
                empties = 0;
            }

            int damaged;
            if (int.TryParse(EuroPalletDamagedtextBox.Text, out damaged))
            {
                damaged = int.Parse(EuroPalletDamagedtextBox.Text);
            }
            else
            {
                damaged = 0;
            }
            // Update label (empties + fulls + damaged * pallet factor)
            EuroPalletTotallabel.Text = ((empties + fulls + damaged) * int.Parse(EuroPalletPalletFactorlabel.Text)).ToString();
        }

        private void metalPalEmptyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(metalPalEmptyTextBox.Text, out int quantityOfItems))
            {
                UpdateMetalPalletsTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                metalPalEmptyTextBox.Text = string.Empty;
                UpdateMetalPalletsTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdateMetalPalletsTotalLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls = 0;
            int damaged = 0;

            int empties;
            if (int.TryParse(metalPalEmptyTextBox.Text, out empties))
            {
                empties = int.Parse(metalPalEmptyTextBox.Text);
            }
            else
            {
                empties = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            MetalPalTotalLabel.Text = ((empties + fulls + damaged) * int.Parse(MetalPalPackFacLabel.Text)).ToString();
        }

        private void LidsEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LidsEmptiesTextBox.Text, out int quantityOfItems))
            {
                UpdateLidsTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value");
                LidsEmptiesTextBox.Text = string.Empty;
                UpdateLidsTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdateLidsTotalLabel()
        {
            //this block checks if all entries can be parsed to ints and updates total qty label
            int fulls = 0;
            int damaged = 0;

            int empties;
            if (int.TryParse(LidsEmptiesTextBox.Text, out empties))
            {
                empties = int.Parse(LidsEmptiesTextBox.Text);
            }
            else
            {
                empties = 0;
            }

            // Update label (empties + fulls + damaged * pallet factor)
            LidsTotallabel.Text = ((empties + fulls + damaged) * int.Parse(LidsPalletFactorlabel.Text)).ToString();
        }
    }
}
