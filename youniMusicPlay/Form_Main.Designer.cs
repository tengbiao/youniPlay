namespace youni
{
    partial class Form_Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最小化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wmp_music = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_lrc = new System.Windows.Forms.Button();
            this.btn_mv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_lrc = new System.Windows.Forms.Timer(this.components);
            this.lbl_closeMaxWindow = new System.Windows.Forms.Label();
            this.lbl_skinPrev = new System.Windows.Forms.Label();
            this.lbl_SkinNext = new System.Windows.Forms.Label();
            this.lbl_SkinRandom = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView_musicList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_LrcShow = new System.Windows.Forms.Label();
            this.lbl_minWindow = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.axWm_MV = new AxWMPLib.AxWindowsMediaPlayer();
            this.imageList_skin = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pictureBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWm_MV)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "有你音乐";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(101, 48);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.关闭ToolStripMenuItem,
            this.最小化ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 70);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 最小化ToolStripMenuItem
            // 
            this.最小化ToolStripMenuItem.Name = "最小化ToolStripMenuItem";
            this.最小化ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.最小化ToolStripMenuItem.Text = "最小化";
            this.最小化ToolStripMenuItem.Click += new System.EventHandler(this.最小化ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(413, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 23);
            this.textBox1.TabIndex = 12;
            // 
            // wmp_music
            // 
            this.wmp_music.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wmp_music.Enabled = true;
            this.wmp_music.Location = new System.Drawing.Point(0, 597);
            this.wmp_music.Margin = new System.Windows.Forms.Padding(0);
            this.wmp_music.Name = "wmp_music";
            this.wmp_music.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_music.OcxState")));
            this.wmp_music.Size = new System.Drawing.Size(832, 43);
            this.wmp_music.TabIndex = 14;
            this.wmp_music.Tag = "";
            this.wmp_music.StatusChange += new System.EventHandler(this.wmp_StatusChange);
            // 
            // btn_lrc
            // 
            this.btn_lrc.BackColor = System.Drawing.Color.White;
            this.btn_lrc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lrc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lrc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_lrc.Location = new System.Drawing.Point(11, 5);
            this.btn_lrc.Name = "btn_lrc";
            this.btn_lrc.Size = new System.Drawing.Size(35, 23);
            this.btn_lrc.TabIndex = 18;
            this.btn_lrc.Text = "词";
            this.btn_lrc.UseVisualStyleBackColor = false;
            this.btn_lrc.Visible = false;
            this.btn_lrc.Click += new System.EventHandler(this.btn_lrc_Click);
            // 
            // btn_mv
            // 
            this.btn_mv.BackColor = System.Drawing.Color.White;
            this.btn_mv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_mv.Location = new System.Drawing.Point(47, 5);
            this.btn_mv.Name = "btn_mv";
            this.btn_mv.Size = new System.Drawing.Size(41, 23);
            this.btn_mv.TabIndex = 19;
            this.btn_mv.Text = "MV";
            this.btn_mv.UseVisualStyleBackColor = false;
            this.btn_mv.Visible = false;
            this.btn_mv.Click += new System.EventHandler(this.btn_mv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(227, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 178);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.Visible = false;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "title";
            this.Column1.HeaderText = "歌曲";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "singername";
            this.Column2.HeaderText = "歌手";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "hit";
            this.Column3.HeaderText = "人气";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // timer_lrc
            // 
            this.timer_lrc.Interval = 500;
            this.timer_lrc.Tick += new System.EventHandler(this.timer_lrc_Tick);
            // 
            // lbl_closeMaxWindow
            // 
            this.lbl_closeMaxWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_closeMaxWindow.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.lbl_closeMaxWindow.ForeColor = System.Drawing.Color.Black;
            this.lbl_closeMaxWindow.Location = new System.Drawing.Point(987, 0);
            this.lbl_closeMaxWindow.Name = "lbl_closeMaxWindow";
            this.lbl_closeMaxWindow.Size = new System.Drawing.Size(20, 25);
            this.lbl_closeMaxWindow.TabIndex = 24;
            this.lbl_closeMaxWindow.Text = "x";
            this.lbl_closeMaxWindow.Click += new System.EventHandler(this.lbl_closeMaxWindow_Click);
            this.lbl_closeMaxWindow.MouseEnter += new System.EventHandler(this.lbl_closeMaxWindow_MouseEnter);
            this.lbl_closeMaxWindow.MouseLeave += new System.EventHandler(this.lbl_closeMaxWindow_MouseLeave);
            this.lbl_closeMaxWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_closeMaxWindow_MouseMove);
            // 
            // lbl_skinPrev
            // 
            this.lbl_skinPrev.AutoSize = true;
            this.lbl_skinPrev.BackColor = System.Drawing.Color.White;
            this.lbl_skinPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_skinPrev.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_skinPrev.ForeColor = System.Drawing.Color.Black;
            this.lbl_skinPrev.Location = new System.Drawing.Point(764, 9);
            this.lbl_skinPrev.Name = "lbl_skinPrev";
            this.lbl_skinPrev.Size = new System.Drawing.Size(16, 16);
            this.lbl_skinPrev.TabIndex = 26;
            this.lbl_skinPrev.Text = "<";
            this.lbl_skinPrev.Click += new System.EventHandler(this.lbl_skinPrev_Click);
            this.lbl_skinPrev.MouseEnter += new System.EventHandler(this.lbl_skinPrev_MouseEnter);
            this.lbl_skinPrev.MouseLeave += new System.EventHandler(this.lbl_skinPrev_MouseLeave);
            // 
            // lbl_SkinNext
            // 
            this.lbl_SkinNext.AutoSize = true;
            this.lbl_SkinNext.BackColor = System.Drawing.Color.White;
            this.lbl_SkinNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_SkinNext.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SkinNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_SkinNext.Location = new System.Drawing.Point(798, 9);
            this.lbl_SkinNext.Name = "lbl_SkinNext";
            this.lbl_SkinNext.Size = new System.Drawing.Size(16, 16);
            this.lbl_SkinNext.TabIndex = 27;
            this.lbl_SkinNext.Text = ">";
            this.lbl_SkinNext.Click += new System.EventHandler(this.label7_Click);
            this.lbl_SkinNext.MouseEnter += new System.EventHandler(this.label7_MouseEnter);
            this.lbl_SkinNext.MouseLeave += new System.EventHandler(this.label7_MouseLeave);
            // 
            // lbl_SkinRandom
            // 
            this.lbl_SkinRandom.AutoSize = true;
            this.lbl_SkinRandom.BackColor = System.Drawing.Color.White;
            this.lbl_SkinRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_SkinRandom.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SkinRandom.ForeColor = System.Drawing.Color.Black;
            this.lbl_SkinRandom.Location = new System.Drawing.Point(781, 9);
            this.lbl_SkinRandom.Name = "lbl_SkinRandom";
            this.lbl_SkinRandom.Size = new System.Drawing.Size(16, 16);
            this.lbl_SkinRandom.TabIndex = 28;
            this.lbl_SkinRandom.Text = "*";
            this.lbl_SkinRandom.Click += new System.EventHandler(this.label8_Click);
            this.lbl_SkinRandom.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            this.lbl_SkinRandom.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.BackgroundImage = global::youni.Properties.Resources.未标题_21;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(732, 13);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(5);
            this.button6.Size = new System.Drawing.Size(24, 23);
            this.button6.TabIndex = 21;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::youni.Properties.Resources._8881;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.listView_musicList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 640);
            this.panel1.TabIndex = 16;
            // 
            // listView_musicList
            // 
            this.listView_musicList.BackColor = System.Drawing.Color.White;
            this.listView_musicList.BackgroundImageTiled = true;
            this.listView_musicList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_musicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_musicList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView_musicList.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.listView_musicList.ForeColor = System.Drawing.Color.Black;
            this.listView_musicList.FullRowSelect = true;
            this.listView_musicList.Location = new System.Drawing.Point(0, 0);
            this.listView_musicList.Name = "listView_musicList";
            this.listView_musicList.Size = new System.Drawing.Size(188, 598);
            this.listView_musicList.TabIndex = 2;
            this.listView_musicList.Tag = "";
            this.listView_musicList.UseCompatibleStateImageBehavior = false;
            this.listView_musicList.View = System.Windows.Forms.View.Details;
            this.listView_musicList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_musicList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "歌曲";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "歌手";
            this.columnHeader2.Width = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Controls.Add(this.lbl_LrcShow);
            this.pictureBox4.Controls.Add(this.wmp_music);
            this.pictureBox4.Controls.Add(this.lbl_SkinRandom);
            this.pictureBox4.Controls.Add(this.lbl_skinPrev);
            this.pictureBox4.Controls.Add(this.lbl_SkinNext);
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::youni.Properties.Resources.IMG_9614;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(832, 640);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lbl_LrcShow
            // 
            this.lbl_LrcShow.AutoSize = true;
            this.lbl_LrcShow.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LrcShow.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_LrcShow.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_LrcShow.Location = new System.Drawing.Point(305, 531);
            this.lbl_LrcShow.Name = "lbl_LrcShow";
            this.lbl_LrcShow.Size = new System.Drawing.Size(197, 27);
            this.lbl_LrcShow.TabIndex = 35;
            this.lbl_LrcShow.Text = "歌词加载中...";
            this.lbl_LrcShow.Visible = false;
            // 
            // lbl_minWindow
            // 
            this.lbl_minWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minWindow.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.lbl_minWindow.ForeColor = System.Drawing.Color.Black;
            this.lbl_minWindow.Location = new System.Drawing.Point(962, 3);
            this.lbl_minWindow.Name = "lbl_minWindow";
            this.lbl_minWindow.Size = new System.Drawing.Size(20, 25);
            this.lbl_minWindow.TabIndex = 29;
            this.lbl_minWindow.Text = "—";
            this.lbl_minWindow.Click += new System.EventHandler(this.lbl_minWindow_Click);
            this.lbl_minWindow.MouseEnter += new System.EventHandler(this.lbl_minWindow_MouseEnter);
            this.lbl_minWindow.MouseLeave += new System.EventHandler(this.lbl_minWindow_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.axWm_MV);
            this.panel2.Controls.Add(this.btn_lrc);
            this.panel2.Controls.Add(this.btn_mv);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(186, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 640);
            this.panel2.TabIndex = 36;
            // 
            // axWm_MV
            // 
            this.axWm_MV.Enabled = true;
            this.axWm_MV.Location = new System.Drawing.Point(3, 418);
            this.axWm_MV.Name = "axWm_MV";
            this.axWm_MV.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWm_MV.OcxState")));
            this.axWm_MV.Size = new System.Drawing.Size(190, 180);
            this.axWm_MV.TabIndex = 29;
            this.axWm_MV.Visible = false;
            // 
            // imageList_skin
            // 
            this.imageList_skin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_skin.ImageStream")));
            this.imageList_skin.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_skin.Images.SetKeyName(0, "skin_1.jpg");
            this.imageList_skin.Images.SetKeyName(1, "skin_2.jpg");
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 689);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_minWindow);
            this.Controls.Add(this.lbl_closeMaxWindow);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "有你音乐";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmp_music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pictureBox4.ResumeLayout(false);
            this.pictureBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWm_MV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private AxWMPLib.AxWindowsMediaPlayer wmp_music;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_lrc;
        private System.Windows.Forms.Button btn_mv;
        private System.Windows.Forms.ListView listView_musicList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem 最小化ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer_lrc;
        private System.Windows.Forms.Label lbl_closeMaxWindow;
        private System.Windows.Forms.Label lbl_skinPrev;
        private System.Windows.Forms.Label lbl_SkinNext;
        private System.Windows.Forms.Label lbl_SkinRandom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lbl_minWindow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_LrcShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList_skin;
        private AxWMPLib.AxWindowsMediaPlayer axWm_MV;
    }
}

