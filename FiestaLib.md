Here's how you can use FiestaLib with a few clicks.

# Imports #

Add FiestaLib.dll as a reference to your project. Now, in your codefile, at the top:

`using FiestaLib;`

# Code #

Next, you can initialize a file like this:
```
 SHNFile file;
        private void button1_Click(object sender, EventArgs e)
        {
            file = new SHNFile(@"C:\Users\XXXX\Desktop\ActiveSkill.shn");
            dataGridView1.DataSource = file;
            file.OnSaveFinished += new DOnSaveFinished(file_OnSaveFinished);
            file.OnSaveError += new DOnSaveError(file_OnSaveError);
        }

  void file_OnSaveError(SHNFile file, string error)
        {
            MessageBox.Show("Error saving shn: " + error);
        }

        void file_OnSaveFinished(SHNFile file)
        {
            MessageBox.Show("File has been saved.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (file != null)
                file.Save(@"C:\Users\XXXX\Desktop\Test.shn");
        }
```