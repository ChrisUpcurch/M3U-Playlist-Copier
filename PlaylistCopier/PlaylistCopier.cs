using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace PlaylistCopier
{
    public partial class PlayListCopier : Form
    {
        DialogResult dlgResult;
        OpenFileDialog fileDlg = new OpenFileDialog();
        string errLog = null;

        public PlayListCopier()
        {
            InitializeComponent();
        }

         private void loadGrid() // Loads the Songs from the Playlist to the Grid.
        {
            songsList.Rows.Clear();
            
            if (fileDlg.FileName.Substring(fileDlg.FileName.LastIndexOf(".")) == ".m3u") // Checks if the extension of the file is M3U
            {
                string fileName = null;         //Used to store the filename
                FileStream fStream = null;      
                StreamReader sReader = null;    

                try
                {
                    fStream = new FileStream(fileDlg.FileName, FileMode.Open, FileAccess.Read); //Open the Playlist in read mode
                    sReader = new StreamReader(fStream);

                    while ((fileName = sReader.ReadLine()) != null)
                    {
                        if (fileName.Length > 0 && fileName.Substring(0, 1) != "#" && fileName.Substring(0, 1) != "\n") //Checks whether the first character of the line is not # or Enter
                        {
                            string[] row1 = { "false", fileName.Substring(fileName.LastIndexOf("\\")+1), fileName.Substring(0, fileName.LastIndexOf("\\")) }; //Stores the song details in string array so that it can be added to the Grid
                            songsList.Rows.Add(row1);                            
                        }
                    }
                    fStream.Close();
                    sReader.Close();
                }
                catch (Exception ex)
                {
                    errLog = ex.Message;

                    if (fStream != null)
                        fStream.Close();

                    if (sReader != null)
                        sReader.Close();
                }
            }
            else if (fileDlg.FileName.Substring(fileDlg.FileName.LastIndexOf(".")) == ".wpl") // Checks if the extension of the file is WPL
            {
                XmlDocument xmlDoc = new XmlDocument(); 
                XmlNodeList xmlList = null;
                XmlAttributeCollection xmlAttriColl = null;
                int i = 0;

                xmlDoc.Load(fileDlg.FileName);

                xmlList = xmlDoc.SelectNodes("smil/body/seq/media"); 

                while (i <= xmlList.Count)
                {
                    if (xmlList != null && xmlList.Item(i) != null)
                    {
                        xmlAttriColl = xmlList.Item(i).Attributes;
                        try
                        {
                            string[] row1 = { "false", xmlAttriColl.Item(0).Value.Substring(xmlAttriColl.Item(0).Value.LastIndexOf("\\")+1), xmlAttriColl.Item(0).Value.Substring(0, xmlAttriColl.Item(0).Value.LastIndexOf("\\")) };
                            songsList.Rows.Add(row1);
                        }
                        catch (Exception ex)
                        {
                            errLog += ex.Message + "\n";
                        }
                    }
                    i++;
                }
                if (errLog != null)
                    MessageBox.Show(errLog, "Error");
            }
        }
                       
        private void btnDestFolder_Click(object sender, EventArgs e)
        {
            folderBrowse.ShowDialog();
            txtDestFolder.Text = folderBrowse.SelectedPath;
        }

        private void btnOpenPlaylist_Click(object sender, EventArgs e)
        {
            errLog = null;
            fileDlg.Filter = "M3U Playlist|*.m3u";
            dlgResult = fileDlg.ShowDialog();

            if (dlgResult == DialogResult.OK)
                loadGrid();
        }

        private void btnSaveSongs_Click(object sender, EventArgs e)
        {
            if (txtDestFolder.Text == "")
            {
                MessageBox.Show("You must select a local destination on your computer where you want the Bible copied");
                return;
            }
            else
            {
            }

            
            int i = 0;
            while (i < songsList.Rows.Count)
            {
                if (songsList.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    try
                    {
                        File.Copy(songsList.Rows[i].Cells[2].Value.ToString() + "\\" + songsList.Rows[i].Cells[1].Value.ToString(), txtDestFolder.Text + "\\" + songsList.Rows[i].Cells[1].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        errLog += ex.Message + "\n";
                    }
                }
                i++;
                progressBar1.Value = (100 / songsList.Rows.Count) * i;
            }
            if (errLog == null)
                MessageBox.Show("All the selected Bible Books were successfully copied.", "Success -The Streaming Bible.com");
            else
                MessageBox.Show(errLog, "Failure");
        }

        private void PlayListCopier_Load(object sender, EventArgs e)
        {
            MessageBox.Show("You must load the Audio Bible's Playlist before you can copy the contents to your harddrive. The playlist is located on this disc. Please load the playlist and select the chapters you want to copy.","The Streaming Bible.com");
       
           // load bible playlist
            errLog = null;
            fileDlg.Filter = "M3U Playlist|*.m3u";
            dlgResult = fileDlg.ShowDialog();

            if (dlgResult == DialogResult.OK)
                loadGrid();
        
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i < songsList.Rows.Count)
            {
                if (songsList.Rows[i].Cells[0].Value.ToString() == "True")
                    songsList.Rows[i].Cells[0].Value = false;
                else
                    songsList.Rows[i].Cells[0].Value = true;
                i++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}