using ProFormaLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ProFormaUI.Forms
{
    public partial class HangOn : Form
    {
        public HangOn()
        {
            InitializeComponent();
            LoadTheme();
            ReloadForm();
        }

        private void ReloadForm()
        {
            try
            {
                // get info from DB
                HandoverText.Text = SqliteDataAccess.FetchCurrentHangOnState();
                // populate textbox
                errorLabel.Text = "";
                AutoSaveLabel.Text = "";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Mamma Mia"); errorLabel.Text = "Error occured"; }
        }

        private void SaveInfo()
        {
            try
            {
                // Save data to table
                SqliteDataAccess.SaveHangOnState(HandoverText.Text);
                errorLabel.Text = "";
                AutoSaveLabel.Text = "Info Saved";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                errorLabel.Text = "Error occured";
            }
        }

        // Apply button themes to current form
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

        // RELOAD BUTTON CLICK
        private void button3_Click(object sender, EventArgs e)
        {
            try { ReloadForm(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); errorLabel.Text = "Error occured"; }
        }

        // NEW button click
        private void button5_Click(object sender, EventArgs e)
        {
            // confirmation required
            DialogResult iExit;
            iExit = MessageBox.Show("All shipment info will be cleared, continue?", "Please confirm..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (iExit == DialogResult.Yes)
            {
                try
                {
                    // Save data to table
                    SqliteDataAccess.SaveHangOnState("");
                    ReloadForm();
                    errorLabel.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    errorLabel.Text = "Error occured";
                }
            }
        }

        // SAVE BUTTON CLICK 
        private void button2_Click(object sender, EventArgs e)
        {
            SaveInfo();
        }

        private void HandoverText_TextChanged(object sender, EventArgs e)
        {
            AutoSaveLabel.Text = "Make sure to save your information.";
        }
    }
}
