using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFormaUI
{
    public partial class LicenceInfo : Form
    {
        public LicenceInfo()
        {
            InitializeComponent();
            LoadLicenceInfo();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadLicenceInfo()
        {
            CustomerModelValue.Text = @"Copyright © 2020 - 2023 Pawel Liberski. All rights reserved...

This software remains my personal intelectual property 
and was developed entirely outside my working hours.
Conditional license is hereby provided to Antolin Interiors Redditch only 
to use this software for the period not exceeding my employment with Antolin Interiors. 
This software is provided on as-is basis and may contain errors. 
I reserve the right to amend this software in the way I see fit, and withdraw it from use with due notice. 

DISCLAIMER!
This software does not collect any personal information.
Local databases are not shared with any other instance of this sofware. 

By using this software you agree to this terms.
                ";
        }
    }
}
