using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FiestaLib;

namespace FiestaEditor
{
    // Sheesh, you and your names.
    public partial class TranslateForm : Form
    {
        private MainForm main;
        public TranslateForm(MainForm mainform)
        {
            main = mainform;
            InitializeComponent();
            LoadBoxes();
        }

        private void LoadBoxes()
        {
            cmbTo.Items.Clear();
            cmbTo.Items.Clear();
            foreach (TabPage tab in main.tabContainer.TabPages)
            {
                cmbTo.Items.Add(tab.Text);
                cmbFrom.Items.Add(tab.Text);
            }
            cmbTo.SelectedIndex = 0;
            cmbFrom.SelectedIndex = 0;
        }

        private void cmbTo_MouseClick(object sender, MouseEventArgs e)
        {
        // gets all columns from the shn & populates cmbToRef and cmbToTranslate with it
            // Also, the query gives you back a collection, not a single element.
            // To get just one you wanna do:
            TabPage page = main.tabContainer.TabPages.Cast<TabPage>().FirstOrDefault(tabPage => tabPage.Text == cmbTo.Text);
            if (page == null) return;
            SHNFile file = main.GetFileByTab(page);
            if (file == null) return;
            cmbToRef.Items.Clear();

            foreach (SHNColumn column in file.Columns)
            {
                cmbToRef.Items.Add(column.ColumnName);
            }
            if (cmbToRef.Items.Count > 0)
            {
                cmbToRef.SelectedIndex = 0;
            }
            else
            {
                cmbToRef.SelectedIndex = -1;
            }
        }
    }
}
