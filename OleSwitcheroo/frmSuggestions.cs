using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OleSwitcheroo
{
    public partial class frmSuggestions : Form
    {
        List<Control> masters;
        List<Control> cboxes;
        TextBox txtSubs;
        public frmSuggestions(TextBox txtSubs)
        {
            this.txtSubs = txtSubs;
            InitializeComponent();
            masters = new List<Control>();
            cboxes = new List<Control>();
            FindControls(this, cboxes, "cbx",true);
            FindControls(this, masters, "chk",false);
        }

        private void FindControls(Control owner, List<Control> list, string name,bool isCheckBox)
        {
            foreach (Control c in owner.Controls)
            {
                if (c.Name.Contains(name))
                {
                    if (isCheckBox)
                        list.Add((CheckedListBox)c);
                    else
                        list.Add((CheckBox)c);
                }
                if (c.HasChildren) FindControls(c, list, name,isCheckBox);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newSubs = "";
            foreach (CheckedListBox cbox in cboxes)
            {
                foreach (string sub in cbox.CheckedItems)
                {
                    if (!(sub == "corgi" && newSubs.Contains("corgi"))) // test for stupid corgi joke
                        newSubs += sub.ToLower() + ",";
                }
            }

            if (newSubs.Length > 1)
            {
                newSubs = newSubs.Substring(0, newSubs.Length - 1);
            }
            txtSubs.Text = newSubs;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuggestions_Load(object sender, EventArgs e)
        {//debug - comment this
            string[] allSubs = txtSubs.Text.Split(',');
            foreach (CheckedListBox cbox in cboxes)
            {
                for (int i = 0; i < cbox.Items.Count; i++)
                {
                    foreach (string sub in allSubs)
                    {
                        string tester = (string)cbox.Items[i];
                        if (tester.ToLower() == sub.ToLower())
                            cbox.SetItemChecked(i, true);
                    }
                   
                }
            }

        }

        private void cbxCool_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkGeneral_CheckedChanged(object sender, EventArgs e)
        {
            CheckToggleAll(cbxGeneral, chkGeneral);
        }

        private void CheckToggleAll(CheckedListBox chibby,CheckBox master)
        {
            if (master.Checked)
            {
                for (int i = 0; i < chibby.Items.Count; i++)
                {
                    chibby.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < chibby.Items.Count; i++)
                {
                    chibby.SetItemChecked(i, false);
                }
            }

        }

        private void chkNSFW_CheckedChanged(object sender, EventArgs e)
        {
            CheckToggleAll(cbxNSFW, chkNSFW);

        }

        private void chkThemes_CheckedChanged(object sender, EventArgs e)
        {
            CheckToggleAll(cbxTheme, chkThemes);

        }

        private void chkImaginary_CheckedChanged(object sender, EventArgs e)
        {

            CheckToggleAll(cbxImagination, chkImaginary);
        }

        private void chkCorgi_CheckedChanged(object sender, EventArgs e)
        {
            CheckToggleAll(cbxCorgi, chkCorgi);

        }

        private void chkNature_CheckedChanged(object sender, EventArgs e)
        {
            CheckToggleAll(cbxNature, chkNature);
        }

        private void chkSynthetic_CheckedChanged(object sender, EventArgs e)
        {
            CheckToggleAll(cbxSynthetic, chkSynthetic);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chkScholastic_CheckedChanged(object sender, EventArgs e)
        {
            CheckToggleAll(cbxScholastic, chkScholastic);
        }

        private void chkOrganic_CheckedChanged(object sender, EventArgs e)
        {
            CheckToggleAll(cbxOrganic, chkOrganic);
        }

        private void chkAesthetic_CheckedChanged(object sender, EventArgs e)
        {
            CheckToggleAll(cbxAesthetic, chkAesthetic);
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            ToggleAll(false);
        }

        private void ToggleAll(bool check)
        {
            foreach (CheckedListBox bawx in cboxes)
            {
                for (int i = 0; i < bawx.Items.Count; i++)
                {
                    bawx.SetItemChecked(i, check);
                }
            }
            foreach (CheckBox master in masters)
            {
                master.Checked = check;
            }

        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            ToggleAll(true);
        }
    }
}
