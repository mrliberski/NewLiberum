﻿using ProFormaLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFormaUI.Forms
{
    public partial class ControlPage : Form
    {
        public ControlPage()
        {
            InitializeComponent();
            LoadTheme();
        }

        //J:\Pub-LOGISTICS\Packaging\Packaging.accdb
        //\\redvmfil01\public\Pub-LOGISTICS\Shift Folder New\2021\Attendance\Redditch 2\Redditch 2 Timesheet 2022.xlsx")

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


            //MessageBox.Show("theme applied");
            // POSSIBLE MORE APPLICATIONS
            //label3.ForeColor = ThemeColor.PrimaryColor;
            //label4.ForeColor = ThemeColor.SecondaryColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Root";
            Process.Start("explorer.exe", folderPath);
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    }
}
