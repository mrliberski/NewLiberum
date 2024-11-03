using ProFormaLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProFormaUI.Forms
{
    public partial class InternalPackaging : Form
    {
        public List<PackagingCount> counts = new List<PackagingCount>();

        public InternalPackaging()
        {
            InitializeComponent();
            LoadTheme();
            ClearAllTextBoxes(this);
        }

        // resets textbox and error label
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

        // topcover recalculate Containers
        private void TopcoverTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TopcoverTextBox.Text, out int quantityOfItems))
            {
                UpdtaeTopcoverTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                TopcoverTextBox.Text = string.Empty;
                UpdtaeTopcoverTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdtaeTopcoverTotalLabel()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(TopcoverTextBox.Text, out fulls))
            {
                fulls = int.Parse(TopcoverTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            TopCoverTotalContainerLabel.Text = (fulls * int.Parse(TopcoverPalletFactorLabel.Text)).ToString();
        }

        private void GloveboxInnerEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(GloveboxInnerEmptiesTextBox.Text, out int quantityOfItems))
            {
                UpdtaeGloveboxTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                GloveboxInnerEmptiesTextBox.Text = string.Empty;
                UpdtaeGloveboxTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void UpdtaeGloveboxTotalLabel()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(GloveboxInnerEmptiesTextBox.Text, out fulls))
            {
                fulls = int.Parse(GloveboxInnerEmptiesTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            GloveboxinnertotalLabel.Text = (fulls * int.Parse(GloveboxinnerPalletFactorLabel.Text)).ToString();
        }

        private void TopperEmptytextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TopperEmptytextBox.Text, out int quantityOfItems))
            {
                topperTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                TopperEmptytextBox.Text = string.Empty;
                topperTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void topperTotalLabel()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(TopperEmptytextBox.Text, out fulls))
            {
                fulls = int.Parse(TopperEmptytextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            TopperTotal2.Text = (fulls * int.Parse(TopperPalletFactorLabel.Text)).ToString();
        }

        private void HousingEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(HousingEmptiesTextBox.Text, out int quantityOfItems))
            {
                HousingTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                HousingEmptiesTextBox.Text = string.Empty;
                HousingTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void HousingTotalLabel()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(HousingEmptiesTextBox.Text, out fulls))
            {
                fulls = int.Parse(HousingEmptiesTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            HousingTotal2.Text = (fulls * int.Parse(HousingPalletrFactorLabel.Text)).ToString();
        }


        private void DecorIMMemptiestextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(DecorIMMemptiestextBox.Text, out int quantityOfItems))
            {
                DecorIMMTotalLabel();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                DecorIMMemptiestextBox.Text = string.Empty;
                DecorIMMTotalLabel();
                errorLabel.Visible = true;
            }
        }

        private void DecorIMMTotalLabel()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(DecorIMMemptiestextBox.Text, out fulls))
            {
                fulls = int.Parse(DecorIMMemptiestextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            Decor2.Text = (fulls * int.Parse(DecorIMMPalletFactorlabel.Text)).ToString();
        }

        private void FuctionalEmptiestextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(FuctionalEmptiestextBox.Text, out int quantityOfItems))
            {
                FunctionalTotalLabelChange();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                FuctionalEmptiestextBox.Text = string.Empty;
                FunctionalTotalLabelChange();
                errorLabel.Visible = true;
            }
        }

        private void FunctionalTotalLabelChange()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(FuctionalEmptiestextBox.Text, out fulls))
            {
                fulls = int.Parse(FuctionalEmptiestextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            FuctionalTotalLabel.Text = (fulls * int.Parse(FuctionalPalletFactorlabel.Text)).ToString();
        }

        private void LowerCoverEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LowerCoverEmptiesTextBox.Text, out int quantityOfItems))
            {
                LowerCoverTotalLabelChange();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                LowerCoverEmptiesTextBox.Text = string.Empty;
                LowerCoverTotalLabelChange();
                errorLabel.Visible = true;
            }
        }

        private void LowerCoverTotalLabelChange()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(LowerCoverEmptiesTextBox.Text, out fulls))
            {
                fulls = int.Parse(LowerCoverEmptiesTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            LowerCoverTotallabel.Text = (fulls * int.Parse(LowerCoverPalletFactorlabel.Text)).ToString();
        }

        private void WadEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(WadEmptiesTextBox.Text, out int quantityOfItems))
            {
                WadTotalLabelChange();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                WadEmptiesTextBox.Text = string.Empty;
                WadTotalLabelChange();
                errorLabel.Visible = true;
            }
        }

        private void WadTotalLabelChange()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(WadEmptiesTextBox.Text, out fulls))
            {
                fulls = int.Parse(WadEmptiesTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            WadTotallabel.Text = (fulls * int.Parse(WadPalletFactorlabel.Text)).ToString();
        }

        private void VentEmptiestextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(VentEmptiestextBox.Text, out int quantityOfItems))
            {
                VentTotalLabelChange();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                VentEmptiestextBox.Text = string.Empty;
                VentTotalLabelChange();
                errorLabel.Visible = true;
            }
        }

        private void VentTotalLabelChange()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(VentEmptiestextBox.Text, out fulls))
            {
                fulls = int.Parse(VentEmptiestextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            VentTotallabel.Text = (fulls * int.Parse(VentPalletFactorlabel.Text)).ToString();
        }

        private void DecorWipEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(DecorWipEmptiesTextBox.Text, out int quantityOfItems))
            {
                DecorwipTotalLabelChange();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                DecorWipEmptiesTextBox.Text = string.Empty;
                DecorwipTotalLabelChange();
                errorLabel.Visible = true;
            }
        }

        private void DecorwipTotalLabelChange()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(DecorWipEmptiesTextBox.Text, out fulls))
            {
                fulls = int.Parse(DecorWipEmptiesTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            DecorWipTotallabel.Text = (fulls * int.Parse(DecorWipPalletFactorlabel.Text)).ToString();
        }

        private void AirbagFlapEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(AirbagFlapEmptiesTextBox.Text, out int quantityOfItems))
            {
                FlapTotalLabelChange();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                AirbagFlapEmptiesTextBox.Text = string.Empty;
                FlapTotalLabelChange();
                errorLabel.Visible = true;
            }
        }

        private void FlapTotalLabelChange()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(AirbagFlapEmptiesTextBox.Text, out fulls))
            {
                fulls = int.Parse(AirbagFlapEmptiesTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            AirbagFlapTotalLabel.Text = (fulls * int.Parse(AirbagFlapPalletFactorLabel.Text)).ToString();
        }

        private void AirbagChuteEmptiesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(AirbagChuteEmptiesTextBox.Text, out int quantityOfItems))
            {
                ChuteTotalLabelChange();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                AirbagChuteEmptiesTextBox.Text = string.Empty;
                ChuteTotalLabelChange();
                errorLabel.Visible = true;
            }
        }

        private void ChuteTotalLabelChange()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(AirbagChuteEmptiesTextBox.Text, out fulls))
            {
                fulls = int.Parse(AirbagChuteEmptiesTextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            AirbagChuteTotallabel.Text = (fulls * int.Parse(AirbagChutePalletFactorlabel.Text)).ToString();
        }

        private void ventBezelPStextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ventBezelPStextBox.Text, out int quantityOfItems))
            {
                ventPStotalLabelChange();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                ventBezelPStextBox.Text = string.Empty;
                ventPStotalLabelChange();
                errorLabel.Visible = true;
            }
        }

        private void ventPStotalLabelChange()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(ventBezelPStextBox.Text, out fulls))
            {
                fulls = int.Parse(ventBezelPStextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            ventBezelPStotalLabel.Text = (fulls * int.Parse(ventBezelPSpalletFactorLabel.Text)).ToString();
        }

        private void ventBezelDStextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ventBezelDStextBox.Text, out int quantityOfItems))
            {
                ventDStotalLabelChange();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                ventBezelDStextBox.Text = string.Empty;
                ventDStotalLabelChange();
                errorLabel.Visible = true;
            }
        }

        private void ventDStotalLabelChange()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(ventBezelDStextBox.Text, out fulls))
            {
                fulls = int.Parse(ventBezelDStextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            ventBezelDStotalContainerLabel.Text = (fulls * int.Parse(ventBezelDSpalletFactorLabel.Text)).ToString();
        }

        private void ventcentretextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ventcentretextBox.Text, out int quantityOfItems))
            {
                ventcentrtotalLabelChange();
                errorLabel.Visible = false;
            }
            else
            {
                //MessageBox.Show("Incorrect Value", "Incorrect entry");
                ventcentretextBox.Text = string.Empty;
                ventcentrtotalLabelChange();
                errorLabel.Visible = true;
            }
        }

        private void ventcentrtotalLabelChange()
        {
            //this block checks if entry can be parsed to ints and updates total qty label
            int fulls;
            if (int.TryParse(ventcentretextBox.Text, out fulls))
            {
                fulls = int.Parse(ventcentretextBox.Text);
            }
            else
            {
                fulls = 0;
            }

            ventCentreTotalLabel.Text = (fulls * int.Parse(ventCentrePalletFactorLabel.Text)).ToString();
        }





        //clear text boxes
        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
        }


        //SUBMIT COUNT
        private void button3_Click(object sender, EventArgs e)
        {
            PackagingCount Topcover = new PackagingCount();
            PackagingCount GloveboxLid = new PackagingCount();
            PackagingCount Topper = new PackagingCount();
            PackagingCount GloveboxHousing = new PackagingCount();
            PackagingCount DecorIMM = new PackagingCount();
            PackagingCount Functional = new PackagingCount();
            PackagingCount LowerCover = new PackagingCount();
            PackagingCount Wad = new PackagingCount();
            PackagingCount vent = new PackagingCount();
            //PackagingCount DecorWip = new PackagingCount();
            PackagingCount AirbagFlap = new PackagingCount();
            PackagingCount AirbagHute = new PackagingCount();
            PackagingCount VentBezelPS = new PackagingCount();
            PackagingCount VentBezelDS = new PackagingCount();
            PackagingCount VentBezel = new PackagingCount();


            //TOPcover
            Topcover.PackagingName = "F6X Top Cover BASE/HUD";
            Topcover.PackagingNumber = "not applicable";
            Topcover.CountOfFulls = 0;
            Topcover.CountOfDamaged = 0;
            Topcover.PalletFactor = int.Parse(TopcoverPalletFactorLabel.Text);
            Topcover.PackFactor = int.Parse(TopcoverFillFactorLabel.Text);
            Topcover.TotalContainers = int.Parse(TopCoverTotalContainerLabel.Text);

            if (int.TryParse(TopcoverTextBox.Text, out int result))
                Topcover.CountOfEmpties = result;
            else
                Topcover.CountOfEmpties = 0;
            // END OF TOPcover

            //GloveboxLid
            GloveboxLid.PackagingName = "F6X Glovebox Lid Set";
            GloveboxLid.PackagingNumber = "not applicable";
            if (int.TryParse(GloveboxInnerEmptiesTextBox.Text, out result))
                GloveboxLid.CountOfEmpties = result;
            else
                GloveboxLid.CountOfEmpties = 0;
            GloveboxLid.CountOfFulls = 0;
            GloveboxLid.CountOfDamaged = 0;
            GloveboxLid.PalletFactor = int.Parse(GloveboxinnerPalletFactorLabel.Text);
            GloveboxLid.PackFactor = int.Parse(GloveboxinnerPackFactorLabel.Text);
            GloveboxLid.TotalContainers = int.Parse(GloveboxinnertotalLabel.Text);
            // END OF GloveboxLid

            //Topper
            Topper.PackagingName = "F6X Topper Pad";
            Topper.PackagingNumber = "not applicable";
            if (int.TryParse(TopperEmptytextBox.Text, out result))
                Topper.CountOfEmpties = result;
            else
                Topper.CountOfEmpties = 0;

            Topper.CountOfFulls = 0;
            Topper.CountOfDamaged = 0;
            Topper.PalletFactor = int.Parse(TopperPalletFactorLabel.Text);
            Topper.PackFactor = int.Parse(TopperPackFactorLabel.Text);
            Topper.TotalContainers = int.Parse(TopperTotal2.Text);
            // END OF Topper

            //GloveboxHousing
            GloveboxHousing.PackagingName = "F6X Glovebox Housing";
            GloveboxHousing.PackagingNumber = "not applicable";
            if (int.TryParse(HousingEmptiesTextBox.Text, out result))
                GloveboxHousing.CountOfEmpties = result;
            else
                GloveboxHousing.CountOfEmpties = 0;

            GloveboxHousing.CountOfFulls = 0;
            GloveboxHousing.CountOfDamaged = 0;
            GloveboxHousing.PalletFactor = int.Parse(HousingPalletrFactorLabel.Text);
            GloveboxHousing.PackFactor = int.Parse(HousingackFactorlabel.Text);
            GloveboxHousing.TotalContainers = int.Parse(HousingTotal2.Text);
            // END OF GloveboxHousing

            //DecorIMM
            DecorIMM.PackagingName = "F6X Decor Pad Moulding";
            DecorIMM.PackagingNumber = "not applicable";
            if (int.TryParse(DecorIMMemptiestextBox.Text, out result))
                DecorIMM.CountOfEmpties = result;
            else
                DecorIMM.CountOfEmpties = 0;

            DecorIMM.CountOfFulls = 0;

            DecorIMM.CountOfDamaged = 0;
            DecorIMM.PalletFactor = int.Parse(DecorIMMPalletFactorlabel.Text);
            DecorIMM.PackFactor = int.Parse(DecorIMMPackFactorlabel.Text);
            DecorIMM.TotalContainers = int.Parse(Decor2.Text);

            //Functional
            Functional.PackagingName = "F6X Functional Carrier";
            Functional.PackagingNumber = "not applicable";
            if (int.TryParse(FuctionalEmptiestextBox.Text, out result))
                Functional.CountOfEmpties = result;
            else
                Functional.CountOfEmpties = 0;

            Functional.CountOfFulls = 0;

            Functional.CountOfDamaged = 0;
            Functional.PalletFactor = int.Parse(FuctionalPalletFactorlabel.Text);
            Functional.PackFactor = int.Parse(FuctionalFactorlabel.Text);
            Functional.TotalContainers = int.Parse(FuctionalTotalLabel.Text);

            //LowerCover
            LowerCover.PackagingName = "F6X Lower Cover Set";
            LowerCover.PackagingNumber = "not applicable";
            if (int.TryParse(LowerCoverEmptiesTextBox.Text, out result))
                LowerCover.CountOfEmpties = result;
            else
                LowerCover.CountOfEmpties = 0;

            LowerCover.CountOfFulls = 0;
            LowerCover.CountOfDamaged = 0;
            LowerCover.PalletFactor = int.Parse(LowerCoverPalletFactorlabel.Text);
            LowerCover.PackFactor = int.Parse(LowerCoverPackFactorlabel.Text);
            LowerCover.TotalContainers = int.Parse(LowerCoverTotallabel.Text);

            //Wad
            Wad.PackagingName = "F6X Warm Air Duct";
            Wad.PackagingNumber = "not applicable";
            if (int.TryParse(WadEmptiesTextBox.Text, out result))
                Wad.CountOfEmpties = result;
            else
                Wad.CountOfEmpties = 0;

            Wad.CountOfFulls = 0;
            Wad.CountOfDamaged = 0;
            Wad.PalletFactor = int.Parse(WadPalletFactorlabel.Text);
            Wad.PackFactor = int.Parse(WadPackFctorlabel.Text);
            Wad.TotalContainers = int.Parse(WadTotallabel.Text);

            //vent
            vent.PackagingName = "F6X Vent Bezel";
            vent.PackagingNumber = "not applicable";
            if (int.TryParse(VentEmptiestextBox.Text, out result))
                vent.CountOfEmpties = result;
            else
                vent.CountOfEmpties = 0;

            vent.CountOfFulls = 0;
            vent.CountOfDamaged = 0;
            vent.PalletFactor = int.Parse(VentPalletFactorlabel.Text);
            vent.PackFactor = int.Parse(VentPackFactorlabel.Text);
            vent.TotalContainers = int.Parse(VentTotallabel.Text);

            //DecorWip
            // DecorWip.PackagingName = "F6X Decor Pad Wip";
            //DecorWip.PackagingNumber = "not applicable";
            //if (int.TryParse(DecorWipEmptiesTextBox.Text, out result))
            //DecorWip.CountOfEmpties = result;
            // else
            //DecorWip.CountOfEmpties = 0;
            //DecorWip.CountOfFulls = 0;
            //DecorWip.CountOfDamaged = 0;
            //DecorWip.PalletFactor = int.Parse(DecorWipPalletFactorlabel.Text);
            // DecorWip.PackFactor = int.Parse(DecorWipPackFactorlabel.Text);
            //DecorWip.TotalContainers = int.Parse(DecorWipTotallabel.Text);

            //AirbagFlap
            AirbagFlap.PackagingName = "F6X Airbag Flap";
            AirbagFlap.PackagingNumber = "not applicable";
            if (int.TryParse(AirbagFlapEmptiesTextBox.Text, out result))
                AirbagFlap.CountOfEmpties = result;
            else
                AirbagFlap.CountOfEmpties = 0;
            AirbagFlap.CountOfFulls = 0;
            AirbagFlap.CountOfDamaged = 0;
            AirbagFlap.PalletFactor = int.Parse(AirbagFlapPalletFactorLabel.Text);
            AirbagFlap.PackFactor = int.Parse(AirbagFlapPackFactorLabel.Text);
            AirbagFlap.TotalContainers = int.Parse(AirbagFlapTotalLabel.Text);

            //AirbagHute
            AirbagHute.PackagingName = "F6X Airbag Chute";
            AirbagHute.PackagingNumber = "not applicable";
            if (int.TryParse(AirbagChuteEmptiesTextBox.Text, out result))
                AirbagHute.CountOfEmpties = result;
            else
                AirbagHute.CountOfEmpties = 0;

            AirbagHute.CountOfFulls = 0;

            AirbagHute.CountOfDamaged = 0;
            AirbagHute.PalletFactor = int.Parse(AirbagChutePalletFactorlabel.Text);
            AirbagHute.PackFactor = int.Parse(AirbagChutePackFactorlabel.Text);
            AirbagHute.TotalContainers = int.Parse(AirbagChuteTotallabel.Text);

            //vent bezelps
            VentBezelPS.PackagingName = "F6X Vent Bezel Passenger";
            VentBezelPS.PackagingNumber = "not applicable";
            if (int.TryParse(ventBezelPStextBox.Text, out result))
                VentBezelPS.CountOfEmpties = result;
            else
                VentBezelPS.CountOfEmpties = 0;

            VentBezelPS.CountOfFulls = 0;

            VentBezelPS.CountOfDamaged = 0;
            VentBezelPS.PalletFactor = int.Parse(ventBezelPSpalletFactorLabel.Text);
            VentBezelPS.PackFactor = int.Parse(ventBezelPSfillFactorlabel.Text);
            VentBezelPS.TotalContainers = int.Parse(ventBezelPStotalLabel.Text);

            //vant bezel ds
            VentBezelDS.PackagingName = "F6X Vent Bezel Driver";
            VentBezelDS.PackagingNumber = "not applicable";
            if (int.TryParse(ventBezelDStextBox.Text, out result))
                VentBezelDS.CountOfEmpties = result;
            else
                VentBezelDS.CountOfEmpties = 0;

            VentBezelDS.CountOfFulls = 0;

            VentBezelDS.CountOfDamaged = 0;
            VentBezelDS.PalletFactor = int.Parse(ventBezelDSpalletFactorLabel.Text);
            VentBezelDS.PackFactor = int.Parse(ventBezelDSfillFactorLabel.Text);
            VentBezelDS.TotalContainers = int.Parse(ventBezelDStotalContainerLabel.Text);

            //vent centre
            VentBezel.PackagingName = "F6X Vent Bezel Centre";
            VentBezel.PackagingNumber = "not applicable";
            if (int.TryParse(ventcentretextBox.Text, out result))
                VentBezel.CountOfEmpties = result;
            else
                VentBezel.CountOfEmpties = 0;

            VentBezel.CountOfFulls = 0;

            VentBezel.CountOfDamaged = 0;
            VentBezel.PalletFactor = int.Parse(ventCentrePalletFactorLabel.Text);
            VentBezel.PackFactor = int.Parse(ventCentreFillLabel.Text);
            VentBezel.TotalContainers = int.Parse(ventCentreTotalLabel.Text);



            //PackagingCount Topcover = new PackagingCount();
            //PackagingCount GloveboxLid = new PackagingCount();
            //PackagingCount Topper = new PackagingCount();
            //PackagingCount GloveboxHousing = new PackagingCount();
            //PackagingCount DecorIMM = new PackagingCount();
            //PackagingCount Functional = new PackagingCount();
            //PackagingCount LowerCover = new PackagingCount();
            //PackagingCount Wad = new PackagingCount();
            //PackagingCount vent = new PackagingCount();
            //PackagingCount DecorWip = new PackagingCount();
            //PackagingCount AirbagFlap = new PackagingCount();
            //PackagingCount AirbagHute = new PackagingCount();
            //PackagingCount SteeringPlate = new PackagingCount();

            counts.Add(Topcover);
            counts.Add(GloveboxLid);
            counts.Add(Topper);
            counts.Add(GloveboxHousing);
            counts.Add(DecorIMM);
            counts.Add(Functional);
            counts.Add(LowerCover);
            counts.Add(Wad);
            counts.Add(vent);
            //counts.Add(DecorWip);
            counts.Add(AirbagFlap);
            counts.Add(AirbagHute);
            counts.Add(VentBezel);
            counts.Add(VentBezelPS);
            counts.Add(VentBezelDS);

            //Create email body and pass it to sender class
            string emailsss;
            emailsss = PackagingCountTemplate.InternalPackagingCountEmailBody(counts);
            PackagingCountTemplate.SendInternalPackagingCount(emailsss);

            ClearAllTextBoxes(this);
            counts.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }
    }
}
