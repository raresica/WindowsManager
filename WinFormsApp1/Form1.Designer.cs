
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.backButton = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1142, 562);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "folder.png");
            this.iconList.Images.SetKeyName(1, "file.png");
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(2, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "UP";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(83, 12);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(990, 23);
            this.FilePathTextBox.TabIndex = 2;
            this.FilePathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(1079, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 3;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "FileName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(141, 606);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(17, 15);
            this.fileNameLabel.TabIndex = 5;
            this.fileNameLabel.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(964, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "FileType";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(1079, 606);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(17, 15);
            this.fileTypeLabel.TabIndex = 7;
            this.fileTypeLabel.Text = "--";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(438, 609);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(172, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 672);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Button deleteButton;
    }
}

