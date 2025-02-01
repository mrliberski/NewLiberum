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
    public partial class IMM1 : Form
    {

        IToolSelection callingForm;

        public IMM1(IToolSelection caller, int ButtonIndex)
        {
            InitializeComponent();
            callingForm = caller; //somebody will call ya
            ResetMe();
        }

        //
        private void ResetMe()
        {
            errorLabel.Text = string.Empty;
            ProjQtyLabel.Text = string.Empty;
            ToolNumberLabel.Text = string.Empty;
            CycleTimeTextBox.Text = string.Empty;
            LabourtextBox.Text = string.Empty;
            ProductionTimeTextBox.Text = string.Empty;
            ProductionQtyTextBox.Text = string.Empty;
            ProjectNameCombo.Text = string.Empty;
            ProductNameCombo.Text = string.Empty ;
        }

        //void IToolSelection.SelectedItem(ToolChangeModel SelectedToolChange)
        //{
        //    throw new NotImplementedException();
        //}

        //Insert button
        private void button1_Click(object sender, EventArgs e)
        {
            //if (AvailableItemsComboBox.SelectedItem != null && int.Parse(ItemQtyTextBox.Text) > 0)
            //{
            ToolChangeModel SelectedToolChange = new ToolChangeModel();
            callingForm.SelectedItem(SelectedToolChange);
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("No items could be selected...", "Empty selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            //}
        }


    }
}
