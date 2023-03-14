namespace FileManageSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fileSize = new System.Windows.Forms.Label();
            this.fileType = new System.Windows.Forms.Label();
            this.modifyTime = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonCreateFolder = new System.Windows.Forms.Button();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.fileWindow = new MyControl.UserControl1();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDiskSize = new System.Windows.Forms.Label();
            this.labelBlockSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox5.Location = new System.Drawing.Point(940, 83);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(2, 48);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox4.Location = new System.Drawing.Point(1174, 83);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(2, 48);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(485, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(2, 48);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // fileSize
            // 
            this.fileSize.AutoSize = true;
            this.fileSize.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileSize.Location = new System.Drawing.Point(1256, 96);
            this.fileSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(79, 33);
            this.fileSize.TabIndex = 18;
            this.fileSize.Text = "大小";
            // 
            // fileType
            // 
            this.fileType.AutoSize = true;
            this.fileType.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileType.Location = new System.Drawing.Point(1021, 92);
            this.fileType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(81, 33);
            this.fileType.TabIndex = 17;
            this.fileType.Text = "类型";
            // 
            // modifyTime
            // 
            this.modifyTime.AutoSize = true;
            this.modifyTime.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modifyTime.Location = new System.Drawing.Point(647, 90);
            this.modifyTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyTime.Name = "modifyTime";
            this.modifyTime.Size = new System.Drawing.Size(143, 33);
            this.modifyTime.TabIndex = 16;
            this.modifyTime.Text = "修改日期";
            this.modifyTime.Click += new System.EventHandler(this.modifyTime_Click);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileName.Location = new System.Drawing.Point(330, 92);
            this.fileName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(111, 33);
            this.fileName.TabIndex = 15;
            this.fileName.Text = "文件名";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(278, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1136, 2);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Location = new System.Drawing.Point(664, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(2, 48);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSearch.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearch.Location = new System.Drawing.Point(1076, 18);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 44);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "搜索";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(384, 20);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(676, 35);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSearch_MouseClick);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(278, 129);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox6.Size = new System.Drawing.Size(1136, 2);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox7.Location = new System.Drawing.Point(664, 0);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox7.Size = new System.Drawing.Size(2, 48);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建文件夹ToolStripMenuItem,
            this.新建文件ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 76);
            // 
            // 新建文件夹ToolStripMenuItem
            // 
            this.新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem";
            this.新建文件夹ToolStripMenuItem.Size = new System.Drawing.Size(208, 36);
            this.新建文件夹ToolStripMenuItem.Text = "新建文件夹";
            this.新建文件夹ToolStripMenuItem.Click += new System.EventHandler(this.新建文件夹ToolStripMenuItem_Click);
            // 
            // 新建文件ToolStripMenuItem
            // 
            this.新建文件ToolStripMenuItem.Name = "新建文件ToolStripMenuItem";
            this.新建文件ToolStripMenuItem.Size = new System.Drawing.Size(208, 36);
            this.新建文件ToolStripMenuItem.Text = "新建文件";
            this.新建文件ToolStripMenuItem.Click += new System.EventHandler(this.新建文件ToolStripMenuItem_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBack.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBack.Location = new System.Drawing.Point(1188, 18);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(208, 42);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "返回上一级";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDelete.BackgroundImage = global::FileManageSystem.Properties.Resources.delete_s;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Location = new System.Drawing.Point(1464, 606);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(178, 178);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox8.Location = new System.Drawing.Point(1404, 0);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox8.Size = new System.Drawing.Size(10, 871);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "groupBox8";
            // 
            // buttonCreateFolder
            // 
            this.buttonCreateFolder.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCreateFolder.BackgroundImage = global::FileManageSystem.Properties.Resources.folder2_s;
            this.buttonCreateFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCreateFolder.Location = new System.Drawing.Point(1464, 328);
            this.buttonCreateFolder.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCreateFolder.Name = "buttonCreateFolder";
            this.buttonCreateFolder.Size = new System.Drawing.Size(178, 178);
            this.buttonCreateFolder.TabIndex = 27;
            this.buttonCreateFolder.UseVisualStyleBackColor = false;
            this.buttonCreateFolder.Click += new System.EventHandler(this.buttonCreateFolder_Click);
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCreateFile.BackgroundImage = global::FileManageSystem.Properties.Resources.text_s1;
            this.buttonCreateFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCreateFile.Location = new System.Drawing.Point(1464, 43);
            this.buttonCreateFile.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(178, 178);
            this.buttonCreateFile.TabIndex = 28;
            this.buttonCreateFile.Text = "\r\n";
            this.buttonCreateFile.UseVisualStyleBackColor = false;
            this.buttonCreateFile.Click += new System.EventHandler(this.buttonCreateFile_Click);
            // 
            // fileWindow
            // 
            this.fileWindow.AutoSize = true;
            this.fileWindow.ContextMenuStrip = this.contextMenuStrip1;
            this.fileWindow.Location = new System.Drawing.Point(278, 135);
            this.fileWindow.Margin = new System.Windows.Forms.Padding(12);
            this.fileWindow.Name = "fileWindow";
            this.fileWindow.Size = new System.Drawing.Size(1140, 734);
            this.fileWindow.TabIndex = 23;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox9.Location = new System.Drawing.Point(278, 0);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox9.Size = new System.Drawing.Size(2, 784);
            this.groupBox9.TabIndex = 35;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            // 
            // treeView
            // 
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(2, 0);
            this.treeView.Margin = new System.Windows.Forms.Padding(6);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 1;
            this.treeView.Size = new System.Drawing.Size(276, 869);
            this.treeView.TabIndex = 36;
            this.treeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "file18.png");
            this.imageList.Images.SetKeyName(1, "folder18.png");
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox10.Location = new System.Drawing.Point(278, 0);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox10.Size = new System.Drawing.Size(10, 871);
            this.groupBox10.TabIndex = 27;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "groupBox10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1480, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 37;
            this.label1.Text = "新建文件";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1467, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 38;
            this.label2.Text = "新建文件夹";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1467, 817);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 33);
            this.label3.TabIndex = 39;
            this.label3.Text = "格式化磁盘";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelDiskSize
            // 
            this.labelDiskSize.AutoSize = true;
            this.labelDiskSize.BackColor = System.Drawing.SystemColors.Control;
            this.labelDiskSize.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDiskSize.Location = new System.Drawing.Point(297, 834);
            this.labelDiskSize.Name = "labelDiskSize";
            this.labelDiskSize.Size = new System.Drawing.Size(111, 33);
            this.labelDiskSize.TabIndex = 41;
            this.labelDiskSize.Text = "label5";
            this.labelDiskSize.Click += new System.EventHandler(this.labelDiskSize_Click);
            // 
            // labelBlockSize
            // 
            this.labelBlockSize.AutoSize = true;
            this.labelBlockSize.BackColor = System.Drawing.SystemColors.Control;
            this.labelBlockSize.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBlockSize.Location = new System.Drawing.Point(866, 834);
            this.labelBlockSize.Name = "labelBlockSize";
            this.labelBlockSize.Size = new System.Drawing.Size(111, 33);
            this.labelBlockSize.TabIndex = 43;
            this.labelBlockSize.Text = "label6";
            this.labelBlockSize.Click += new System.EventHandler(this.labelBlockSize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(289, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 33);
            this.label5.TabIndex = 45;
            this.label5.Text = "路径";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1698, 871);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelBlockSize);
            this.Controls.Add(this.labelDiskSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.buttonCreateFile);
            this.Controls.Add(this.buttonCreateFolder);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.fileWindow);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.fileSize);
            this.Controls.Add(this.fileType);
            this.Controls.Add(this.modifyTime);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件系统     1852143董震宇";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label fileSize;
        private System.Windows.Forms.Label fileType;
        private System.Windows.Forms.Label modifyTime;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private MyControl.UserControl1 fileWindow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建文件ToolStripMenuItem;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonCreateFolder;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDiskSize;
        private System.Windows.Forms.Label labelBlockSize;
        private System.Windows.Forms.Label label5;
    }
}

