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

THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

By using this software you agree to this terms.
                ";
        }

        private void CustomerModelValue_Click(object sender, EventArgs e)
        {

        }
    }
}
