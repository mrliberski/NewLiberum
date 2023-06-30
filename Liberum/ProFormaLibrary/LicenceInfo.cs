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
            richTextBox1.Text = @"Copyright © 2020 - 2023 Pawel Liberski. All rights reserved...

Conditional license is hereby provided to Antolin Interiors Redditch only to use this software for the period not exceeding author's employment with Antolin Interiors. 
This software is a proof-of concept version and is provided on as-is basis. It may contain multiple errors. 
Author reserves the right to amend this software as and when required, but also to withdraw any given permissions at any time.

DISCLAIMER!
This sofware is for demonstration purposes only and generated invoices are props which are not to be used for commercial purposes or in conjuction with any commercial activity.
This software does not collect or share any personal information.
Local databases are not shared with any other instance of this sofware. 

THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

By using this software you agree to terms in full.
                ";
        }

    }
}
