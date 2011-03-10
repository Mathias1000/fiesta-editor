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
    public partial class Replace : Form
    {
        private MainForm main;
        private SHNFile file;
        private DataGridView grid;
        private string oldfilter;
        public Replace(MainForm form)
        {
            InitializeComponent();

            main = form;
            file = form.GetFileByTab();
            grid = form.GetGridByTab();
            if (grid == null || file == null) this.Close();
            oldfilter = file.DefaultView.RowFilter;
            InitColumns();
        }

        private void InitColumns()
        {
            cmbColumn.Items.Clear();
            for (int i = 0; i < file.Columns.Count; ++i)
            {
                cmbColumn.Items.Add(i + " - " + file.Columns[i].Caption);
            }
            cmbColumn.SelectedIndex = 0;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                file.DefaultView.RowFilter = txtFilter.Text;
                lblInfo.Text = file.DefaultView.Count + " rows will be affected.";
            }
            catch
            {
                file.DefaultView.RowFilter = string.Empty;
            }
        }

        private void Replace_FormClosed(object sender, FormClosedEventArgs e)
        {
            file.DefaultView.RowFilter = oldfilter;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            try
            {
                int colindex = int.Parse(cmbColumn.Text.Split(' ')[0]);
                if (colindex >= file.Columns.Count) return;
                foreach (DataGridViewRow vrow in grid.Rows)
                {
                    if (vrow.Visible)
                    {
                        if (vrow.DataBoundItem == null) continue;
                        DataRow row = (vrow.DataBoundItem as DataRowView).Row;
                        row[colindex] = txtWith.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
