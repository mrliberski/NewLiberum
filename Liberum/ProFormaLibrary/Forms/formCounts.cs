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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int quantityOfItems))
            {
                updateBFSlabel();
            }
            else
            {
                MessageBox.Show("Incorrect Value", "Incorrect entry");
                textBox1.Text = string.Empty;
                updateBFSlabel();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //int quantityOfItems;
            if (int.TryParse(textBox2.Text, out int quantityOfItems))
            {
                updateBFSlabel();
            }
            else
            {
                MessageBox.Show("Incorrect Value");
                textBox2.Text = string.Empty;
                updateBFSlabel();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //int quantityOfItems;
            if (int.TryParse(textBox5.Text, out int quantityOfItems))
            {
                updateBFSlabel();
            }
            else
            {
                MessageBox.Show("Incorrect Value");
                textBox5.Text = string.Empty;
                updateBFSlabel();
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


            TopperBFS.PackagingName = "F6X Topper Pad BFS";
            TopperBFS.PackagingNumber = "6223190";
            TopperBFS.CountOfEmpties = int.Parse(textBox1.Text);
            TopperBFS.CountOfFulls = int.Parse(textBox2.Text);
            TopperBFS.CountOfDamaged = int.Parse(textBox5.Text);
            TopperBFS.PalletFactor = int.Parse(label9.Text);
            TopperBFS.PackFactor = int.Parse(label84.Text);
            TopperBFS.TotalContainers = (TopperBFS.CountOfEmpties + TopperBFS.CountOfFulls + TopperBFS.CountOfDamaged) * TopperBFS.PalletFactor;

            counts.Add(TopperBFS);
            counts.Add(Lower);
            counts.Add(Decor);  
            counts.Add(TopcoverDS);

            MessageBox.Show("Getting there");
        }
    }
}
