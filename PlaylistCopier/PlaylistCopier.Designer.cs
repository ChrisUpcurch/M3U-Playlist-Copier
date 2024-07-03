namespace PlaylistCopier
{
    partial class PlayListCopier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListCopier));
            this.btnOpenPlaylist = new System.Windows.Forms.Button();
            this.txtDestFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDestFolder = new System.Windows.Forms.Button();
            this.songsList = new System.Windows.Forms.DataGridView();
            this.btnSaveSongs = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.songsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenPlaylist
            // 
            this.btnOpenPlaylist.Location = new System.Drawing.Point(389, 32);
            this.btnOpenPlaylist.Name = "btnOpenPlaylist";
            this.btnOpenPlaylist.Size = new System.Drawing.Size(115, 22);
            this.btnOpenPlaylist.TabIndex = 0;
            this.btnOpenPlaylist.Text = "Open Bible Playlist";
            this.btnOpenPlaylist.UseVisualStyleBackColor = true;
            this.btnOpenPlaylist.Click += new System.EventHandler(this.btnOpenPlaylist_Click);
            // 
            // txtDestFolder
            // 
            this.txtDestFolder.Enabled = false;
            this.txtDestFolder.Location = new System.Drawing.Point(11, 33);
            this.txtDestFolder.Multiline = true;
            this.txtDestFolder.Name = "txtDestFolder";
            this.txtDestFolder.Size = new System.Drawing.Size(191, 22);
            this.txtDestFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bible Destination Folder:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDestFolder
            // 
            this.btnDestFolder.Location = new System.Drawing.Point(211, 33);
            this.btnDestFolder.Name = "btnDestFolder";
            this.btnDestFolder.Size = new System.Drawing.Size(107, 22);
            this.btnDestFolder.TabIndex = 3;
            this.btnDestFolder.Text = "Select Destination";
            this.btnDestFolder.UseVisualStyleBackColor = true;
            this.btnDestFolder.Click += new System.EventHandler(this.btnDestFolder_Click);
            // 
            // songsList
            // 
            this.songsList.AllowUserToAddRows = false;
            this.songsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.songsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Song,
            this.Location});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.songsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.songsList.Location = new System.Drawing.Point(12, 60);
            this.songsList.Name = "songsList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.songsList.Size = new System.Drawing.Size(620, 447);
            this.songsList.TabIndex = 4;
            // 
            // btnSaveSongs
            // 
            this.btnSaveSongs.Location = new System.Drawing.Point(18, 513);
            this.btnSaveSongs.Name = "btnSaveSongs";
            this.btnSaveSongs.Size = new System.Drawing.Size(164, 22);
            this.btnSaveSongs.TabIndex = 5;
            this.btnSaveSongs.Text = "Copy Selected Audio Books";
            this.btnSaveSongs.UseVisualStyleBackColor = true;
            this.btnSaveSongs.Click += new System.EventHandler(this.btnSaveSongs_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(188, 513);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(437, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(510, 32);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(115, 22);
            this.btnSelectAll.TabIndex = 7;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.Width = 25;
            // 
            // Song
            // 
            this.Song.HeaderText = "Track";
            this.Song.Name = "Song";
            this.Song.Width = 250;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.Width = 280;
            // 
            // PlayListCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 548);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSaveSongs);
            this.Controls.Add(this.songsList);
            this.Controls.Add(this.btnDestFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDestFolder);
            this.Controls.Add(this.btnOpenPlaylist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayListCopier";
            this.Text = "TheStreamingBible.com -  Bible Copier";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PlayListCopier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.songsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPlaylist;
        private System.Windows.Forms.TextBox txtDestFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowse;
        private System.Windows.Forms.Button btnDestFolder;
        private System.Windows.Forms.DataGridView songsList;
        private System.Windows.Forms.Button btnSaveSongs;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Song;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;

    }
}

