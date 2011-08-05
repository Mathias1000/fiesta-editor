using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FiestaLib;
using System.IO;
using System.Diagnostics;
using System.Xml.Serialization;

namespace FiestaEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //SHNFile file = new SHNFile(@"C:\Program Files (x86)\Outspark\Fiesta\ressystem\ClassName.shn");

            cmbEncoding.Items.Clear();
            cmbEncoding.Items.Add("ASCII");
            cmbEncoding.Items.Add("BigEndianUnicode");
            cmbEncoding.Items.Add("Unicode");
            cmbEncoding.Items.Add("UTF32");
            cmbEncoding.Items.Add("UTF7");
            cmbEncoding.Items.Add("UTF8");
            cmbEncoding.SelectedIndex = cmbEncoding.FindString(Program.AppConfig.FileEncoding);
            
            string[] args = Environment.GetCommandLineArgs();
            for(int i = 1; i < args.Length; i++)
            {
                OpenNewTab(args[i]);
            }
        }

        public void SetStatus(string pText)
        {
            pText += ".";
            if (this.BottomStrip.InvokeRequired)
            {
                this.BottomStrip.Invoke(new MethodInvoker(delegate { this.lblStatus.Text = pText; }));
            }
            else
            {
                lblStatus.Text = pText;
            }
        }

        public void OpenNewTab(string pPath)
        {
            SHNFile file = new SHNFile(pPath);
            file.OnSaveFinished += new DOnSaveFinished(file_OnSaveFinished);
            file.OnSaveError += new DOnSaveError(file_OnSaveError);
            TabPage npage = new TabPage();
            npage.Text = "/";

            DataGridView view = new DataGridView();
            view.Dock = DockStyle.Fill;
            view.DataSource = file;
            view.CellEnter += new DataGridViewCellEventHandler(view_CellEnter);
            view.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            view.DoubleBuffered(true);

            npage.Controls.Add(view);
            tabContainer.TabPages.Add(npage);
            tabContainer.SelectedTab = npage;

            spltContainer.Panel2.Enabled = true;
            UpdateTabs();
        }

        void view_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (view.SelectedCells.Count > 0)
            {
                SHNColumn col = (SHNColumn)(((SHNFile)view.DataSource).Columns[view.SelectedCells[0].ColumnIndex]);
                lblColumnName.Text = "Name: " + col.ColumnName;
                lblColumnSize.Text = "Size: " + col.Lenght;
                lblColumnType.Text = "Type: " + col.DataType.ToString();
                lblRowIndex.Text = "Row: " + view.SelectedCells[0].RowIndex;
            }
        }

        void file_OnSaveError(SHNFile file, string error)
        {
            SetStatus("Error saving " + Path.GetFileNameWithoutExtension(file.FileName) + ": " + error);
        }

        void file_OnSaveFinished(SHNFile file)
        {
            SetStatus("File saved to " + file.FileName);
        }

        private void OnRightTab(TabPage pPage, Point position)
        {
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add("Save", TabRight_Save_Click).Tag = pPage;
            menu.MenuItems.Add("Close", TabRight_Close_Click).Tag = pPage;
            menu.Show(pPage, position);
        }

        private void TabRight_Close_Click(object sender, EventArgs e)
        {
            MenuItem menu = (MenuItem)sender;
            TabPage page = (TabPage)menu.Tag;
            DataGridView view = (DataGridView)page.Controls[0];
            ((SHNFile)view.DataSource).Dispose();
            view.Dispose();
            tabContainer.TabPages.Remove(page);
            if (tabContainer.TabCount == 0)
                spltContainer.Panel2.Enabled = false;
            UpdateTabs();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void TabRight_Save_Click(object sender, EventArgs e)
        {
            MenuItem menu = (MenuItem)sender;
            TabPage page = (TabPage)menu.Tag;
            DataGridView view = (DataGridView)page.Controls[0];
            SHNFile file = (SHNFile)view.DataSource;
            SaveFile(file);
            UpdateTabs();
        }

        public void UpdateTabs()
        {
            for (int i = 0; i < tabContainer.TabPages.Count; ++i)
            {
                TabPage tab = tabContainer.TabPages[i];
                SHNFile file = GetFileByTab(tab);
                if (file != null)
                {
                    tab.Text = "[" + i + "] " + Path.GetFileNameWithoutExtension(file.FileName);
                }
                else
                {
                    tab.Text = "[/] Unknown";
                }
            }
        }

        public void SaveFile(SHNFile file)
        {
            SaveFileDialog diag = new SaveFileDialog();
            diag.Title = "Save SHN File";
            diag.Filter = "Fiesta File (*.shn)|*.shn";
            if (diag.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            if (Path.GetFullPath(diag.FileName) == file.FileName)
            {
                var overwrite = MessageBox.Show("Are you sure you want to overwrite current file?", "Overwrite file", MessageBoxButtons.YesNo);
                if (overwrite == System.Windows.Forms.DialogResult.Yes)
                {
                    StartSaving(file, diag.FileName);
                }
            }
            else
            {
                StartSaving(file, diag.FileName);
            }
        }

        private void StartSaving(SHNFile file, string path)
        {
            if (file.Save(path))
            {
                SetStatus("Saving " + Path.GetFileNameWithoutExtension(path) + ", please wait...");
            }
            else
            {
                SetStatus("Please wait till previous write routine is finished.");
            }
        }


        private void tabContainer_MouseUp(object sender, MouseEventArgs e)
        {
            // check if the right mouse button was pressed
            if (e.Button == MouseButtons.Right)
            {
                // iterate through all the tab pages
                for (int i = 0; i < tabContainer.TabCount; i++)
                {
                    // get their rectangle area and check if it contains the mouse cursor
                    Rectangle r = tabContainer.GetTabRect(i);
                    if (r.Contains(e.Location))
                    {
                        TabPage page = tabContainer.TabPages[i];
                        if (tabContainer.SelectedTab != page)
                            tabContainer.SelectedTab = page;
                        OnRightTab(page, new Point(e.X, e.Y - 20));
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog diag = new OpenFileDialog())
            {
                diag.Title = "Open SHN File";
                diag.Filter = "Fiesta SHN File (*.shn)|*.shn";
                if (diag.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                OpenNewTab(diag.FileName);
            }
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SHNFile file = GetFileByTab();
            if (file != null)
            {
                SaveFile(file);
            }
        }

        public SHNFile GetFileByTab(TabPage page = null)
        {
            if (page == null) page = tabContainer.SelectedTab;
            if (page == null) return null;
            DataGridView view = (DataGridView)page.Controls[0];
            return (SHNFile)view.DataSource;
        }

        public DataGridView GetGridByTab(TabPage page = null)
        {
            if (page == null) page = tabContainer.SelectedTab;
            if (page == null) return null;
            return (DataGridView)page.Controls[0];
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            SHNFile file = GetFileByTab();
            try
            {
                if (file == null) return;
                file.DefaultView.RowFilter = txtFilter.Text;
            }
            catch
            {
                file.DefaultView.RowFilter = "";
            }
        }

        private void lblFilterHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://msdn.microsoft.com/en-us/library/system.data.datacolumn.expression.aspx");
        }

        private void translatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabContainer.TabCount < 2)
            {
                MessageBox.Show("Please open both files before you continue.");
                return;
            }
            TranslateForm translator = new TranslateForm(this);
            translator.ShowDialog();
        }

        private void cmbEncoding_MouseUp(object sender, MouseEventArgs e)
        {
            if (cmbEncoding.SelectedItem != null)
            {
                Encoding enc = Config.GetEncodingByName(cmbEncoding.Text);
                SHNFile.Encoding = enc;
                Program.AppConfig.FileEncoding = cmbEncoding.Text.ToLower();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.AppConfig != null)
            {
                Program.AppConfig.Save(Program.AppPath + "\\config.xml");
            }
        }

        private void copyRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView grid = GetGridByTab();
            if (grid == null) return;

            using (MemoryStream stream = new MemoryStream())
            {
                using (DataTable copied = CreateCopyTable())
                {
                    if (copied == null) return;
                    XmlSerializer ser = new XmlSerializer(typeof(DataTable));
                    ser.Serialize(stream, copied);
                    Clipboard.SetData("fiestacopy", stream.ToArray());
                    lblStatus.Text = "Rows copied.";
                }
            }
        }

        private DataTable CreateCopyTable()
        {
            DataGridView grid = GetGridByTab();
            if (grid == null)
            {
                lblStatus.Text = "Error occured during copy: grid not found.";
                return null;
            }

            SHNFile file = GetFileByTab();
            DataTable copied = file.Clone();
            copied.TableName = Path.GetFileNameWithoutExtension(file.FileName) ?? "Fiesta Copy Content";

            for (int iz = grid.SelectedRows.Count - 1; iz >= 0; --iz)
            {
                DataGridViewRow viewrow = grid.SelectedRows[iz];
                DataRow row = (viewrow.DataBoundItem as DataRowView).Row;
                DataRow newrow = copied.NewRow();
                for (int i = 0; i < grid.Columns.Count; ++i)
                {
                    newrow[i] = row[i];
                }
                copied.Rows.Add(newrow);
            }
            /*
            foreach (DataGridViewRow viewrow in grid.SelectedRows)
            {
                DataRow row = (viewrow.DataBoundItem as DataRowView).Row;
                DataRow newrow = copied.NewRow();
                for (int i = 0; i < grid.Columns.Count; ++i)
                {
                    newrow[i] = row[i];
                }
                copied.Rows.Add(newrow);
            } */
            return copied;
        }

        private void pasteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] data;
            if ((data = (byte[])Clipboard.GetData("fiestacopy")) != null)
            {
                using (MemoryStream stream = new MemoryStream(data))
                {
                    try
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(DataTable));
                        using (DataTable table = (DataTable)ser.Deserialize(stream))
                        {
                            InsertRows(table);
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Exception(ex);
                    }
                }
            }
            else
            {
                lblStatus.Text = "Could not find any clipboard data.";
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();
            diag.Title = "Export Fiesta Editor Rows";
            diag.Filter = "Fiesta XML (*.xml)|*.xml";
            if (diag.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            using (DataTable table = CreateCopyTable())
            {
                if (table == null)
                    return;

                using (FileStream file = File.Create(diag.FileName))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(DataTable));
                    ser.Serialize(file, table);
                }
                lblStatus.Text = "Rows exported successfully.";
            }
        }

        private void InsertRows(DataTable table)
        {
            bool allok = true;
            SHNFile file = GetFileByTab();
            foreach (DataRow row in table.Rows)
            {
                DataRow newrow = file.NewRow();
                for (int i = 0; i < table.Columns.Count; ++i)
                {
                    if (file.Columns[i].Caption == table.Columns[i].Caption)
                    {
                        newrow[i] = row[i];
                    }
                    else
                    {
                        allok = false;
                    }
                }
                file.Rows.Add(newrow);
            }
            if (!allok)
                lblStatus.Text = "Some columns could not be imported. Please check your file layout.";
            else
                lblStatus.Text = "Imported rows from " + table.TableName + " successfully.";
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "Fiesta XML (*.xml)|*.xml";
            diag.Title = "Select Fiesta Row File";
            if (diag.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            using (FileStream file = File.Open(diag.FileName, FileMode.Open))
            {
                try
                {
                    XmlSerializer ser = new XmlSerializer(typeof(DataTable));
                    using (DataTable table = (DataTable)ser.Deserialize(file))
                    {
                        InsertRows(table);
                    }
                }
                catch (Exception ex)
                {
                    Log.Exception(ex);
                }
            }

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView grid = GetGridByTab();
            if (grid == null) return;

            Replace repl = new Replace(this);
            repl.ShowDialog();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!chkAutoFilter.Checked) return;
            SHNFile file = GetFileByTab();
            DataGridView view = GetGridByTab();
            if (file == null ||view == null) return;

            try
            {
                file.DefaultView.RowFilter = txtFilter.Text;
                view.Tag = txtFilter.Text;
            }
            catch
            {
                file.DefaultView.RowFilter = string.Empty;
                view.Tag = txtFilter.Text;
            }
        }

        private void chkAutoFilter_CheckedChanged(object sender, EventArgs e)
        {
            btnFilter.Visible = !chkAutoFilter.Checked;
            btnFilter_Click_1(null, null);
        }

        private void tabContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView view = GetGridByTab();
            if (view == null) return;
            txtFilter.Text = (string)view.Tag ?? "";
        }

        private void spltContainer_Panel2_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Top = spltContainer.Height - 40;
            lblCopyRight.Top = spltContainer.Height - 15;
        }
    }
}
