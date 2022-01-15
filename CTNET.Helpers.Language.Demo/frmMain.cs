using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CTNET.Helpers.Language;

namespace CTNET.Helpers.Language.Test
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLanguages();
            cboLanguage.SelectedItem = @".\Langs\en.json";
        }

        private void LoadLanguages()
        {
            cboLanguage.Items.Clear();
            foreach (var file in System.IO.Directory.EnumerateFiles(@".\Langs", "*.json"))
            {
                cboLanguage.Items.Add(file);
            }
        }

        private void cboLanguage_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Translations.LoadDictionary(cboLanguage.Text);
                RefreshList();
                TranslateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butTranslate_Click(object sender, EventArgs e)
        {
            txtTranslation.Text = txtText.Text.Translate();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            lvDictionary.Items.Clear();
            foreach (KeyValuePair<String, String> pair in Translations.Dictionary)
            {
                ListViewItem listViewItem = lvDictionary.Items.Add(new ListViewItem() { Name = pair.Key, Text = pair.Key } );
                listViewItem.SubItems.Add(pair.Value);
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Translations.AddTranslation(txtNewText.Text, txtNewTranslation.Text, true);
                RefreshList();
            }
            catch (Exception ex)
            {
                //If the text you are adding already exists in the dictionary an exception will be thrown.
                //You can manage this exception showing a message or replacing the existent text by deleting and adding it.
                //MessageBox.Show(ex.Message);
                Translations.RemoveTranslation(txtNewText.Text);
                Translations.AddTranslation(txtNewText.Text, txtNewTranslation.Text, true);
                RefreshList();
            }
        }
        private void butDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvDictionary.SelectedItems)
            {
                Translations.RemoveTranslation(item.Name.ToString(), true);
            }
            RefreshList();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            try 
            {
                Translations.SaveDictionary(cboLanguage.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butTranslateUI_Click(object sender, EventArgs e)
        {
            TranslateUI();
        }

        private void TranslateUI()
        {
            lblLanguage.Text = lblLanguage.Name.Translate();
            lblNewText.Text = lblNewText.Name.Translate();
            lblNewTranslation.Text = lblNewTranslation.Name.Translate();
            lblDictionary.Text = lblDictionary.Name.Translate();
            lblText.Text = lblText.Name.Translate();
            lblTranslation.Text = lblTranslation.Name.Translate();
            butAdd.Text = butAdd.Name.Translate();
            butSave.Text = butSave.Name.Translate();
            butDelete.Text = butDelete.Name.Translate();
            butTranslate.Text = butTranslate.Name.Translate();
            butTranslateUI.Text = butTranslateUI.Name.Translate();
            butRefresh.Text = butRefresh.Name.Translate();
        }

        private void lvDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lvDictionary.FocusedItem;
            if (item != null)
            { 
                txtNewText.Text = item.Text;
                txtNewTranslation.Text = item.SubItems[1].Text;
            }
        }

        private void butShowForm_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSample1())
            { 
                frm.ShowDialog();
            }
        }
    }
}
