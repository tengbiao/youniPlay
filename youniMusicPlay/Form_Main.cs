using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using youni.Helper;
using youni.Model;
using System.Media;
using WMPLib;
using System.IO;

namespace youni
{
    public partial class Form_Main : Form
    {
        #region  属性区

        //当前歌词路径
        public string currLrcLink = string.Empty;
        public string currSongLink = string.Empty;
        //当前歌词信息
        private LrcInfo lrcInfo;
        //更换皮肤
        private int SkinNum = 0;
        #endregion 

        public Form_Main()
        {
            InitializeComponent();
        }
        public int musicNum = 0;
        /// <summary>
        /// 窗体加载事件  注意注释哦 @_@
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // this.pictureBox4.Image = this.imageList_skin.Images[0];
            CheckSkinButtonState();
            BindLeftSongList();

            toolTip1.SetToolTip(this.lbl_closeMaxWindow, "关闭");
            toolTip1.SetToolTip(this.lbl_minWindow, "最小化");
            toolTip1.SetToolTip(this.lbl_SkinNext, "下一张");
            toolTip1.SetToolTip(this.lbl_SkinRandom, "顺序播放");
            toolTip1.SetToolTip(this.lbl_skinPrev, "上一张");
        }

        /// <summary>
        /// 加载皮肤更换状态
        /// </summary>
        private void CheckSkinButtonState()
        {
            if (SkinNum == 0)
            {
                this.lbl_skinPrev.Enabled = false;
            }
            else
            {
                this.lbl_skinPrev.Enabled = true;
            }
            if (SkinNum == this.imageList_skin.Images.Count - 1)
            {
                this.lbl_SkinNext.Enabled = false;
            }
            else
            {
                this.lbl_SkinNext.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SkinNum++;
            if (SkinNum == this.imageList_skin.Images.Count)
            {
                SkinNum = 0;
            }
            this.pictureBox4.Image = this.imageList_skin.Images[SkinNum];
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
        }

        //无边框拖动
        bool beigingMove = false;
        int x = 0;
        int y = 0;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beigingMove)
            {
                this.Left += MousePosition.X - x;
                this.Top += MousePosition.Y - y;
                x = MousePosition.X;
                y = MousePosition.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            beigingMove = true;
            x = MousePosition.X;
            y = MousePosition.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            beigingMove = false;
        }

        //双击最大化 双击还原
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// 歌词点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_lrc_Click(object sender, EventArgs e)
        {
            if (this.pictureBox4.Visible)
                return;
            //停止mv
            var currentPosition = this.axWm_MV.Ctlcontrols.currentPosition;
            this.axWm_MV.Ctlcontrols.stop();
            this.axWm_MV.Visible = false;
           
            //播放MP3
            this.pictureBox4.Visible = true;
            this.wmp_music.Ctlcontrols.currentPosition = currentPosition;
            this.wmp_music.Ctlcontrols.play();
        }

        /// <summary>
        /// mv点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mv_Click(object sender, EventArgs e)
        {
            if (!this.pictureBox4.Visible)
                return;

            this.dataGridView1.Visible = false;
            this.pictureBox4.Visible = false;
            this.timer_lrc.Stop();
            //暂停MP3播放
            this.wmp_music.Ctlcontrols.pause();
            //当前MP3播放进度
            var currentPosition = this.wmp_music.Ctlcontrols.currentPosition;

            this.axWm_MV.Size = new Size(832, 594);
            this.axWm_MV.Location = new Point(0, 50);
            this.axWm_MV.Visible = true;

            string[] urls = currSongLink.Split('|');
            if (!string.IsNullOrEmpty(urls[2]))
            {
                string mvurl = string.Empty;
                if (urls[2].Contains("http"))
                    mvurl = urls[2];
                else
                    mvurl = Path.Combine(LrcInfo.BaseUrl, "mv\\" + urls[2]);
                this.axWm_MV.URL = mvurl;
                this.axWm_MV.Ctlcontrols.currentPosition = currentPosition;
                this.axWm_MV.Ctlcontrols.play();
            }
        }

        /// <summary>
        /// 绑定左边歌曲列表
        /// </summary>
        private void BindLeftSongList()
        {
            try
            {
                string sqlStr = "select songid,title,singername,URL,SPURL,LrcLink from yn";
                DataTable result = DBHelper.GDT(sqlStr);
                if (result != null && result.Rows.Count > 0)
                {
                    foreach (DataRow item in result.Rows)
                    {
                        ListViewItem listView = new ListViewItem(item["title"].ToString());
                        listView.SubItems.Add(item["singername"].ToString());
                        listView.Tag = string.Format("{0}|{1}|{2}|{3}", item["songid"], item["URL"], item["SPURL"], item["LrcLink"]);
                        this.listView_musicList.Items.Add(listView);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.Message);
            }
        }

        private int SelectedIndex = 0;
        private void listView_musicList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string listViewTag = this.listView_musicList.SelectedItems[0].Tag.ToString();
            currSongLink = listViewTag;
            string[] urls = listViewTag.Split('|');
            string songUrl = string.Empty;
            if (urls[1].Contains("http"))
                songUrl = urls[1];
            else
                songUrl = Path.Combine(LrcInfo.BaseUrl, "song\\" + urls[1]);
            currLrcLink = urls[3].Contains("http") ? urls[3] : "song\\" + urls[3];
            this.wmp_music.URL = songUrl;
            this.wmp_music.Ctlcontrols.play();
            //开始播放时 触发歌词显示
            lbl_LrcShow.Text = "歌词加载中...";
            lrcInfo = null;
            timer_lrc.Start();
            this.btn_lrc.Visible = this.btn_mv.Visible = !string.IsNullOrEmpty(urls[2]);
            SelectedIndex = this.listView_musicList.SelectedItems[0].Index;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DataTable dt = null;
            string py = this.textBox1.Text;
            if (py == "")
            {
                MessageBox.Show("请输入歌曲首字母！");
                return;
            }
            string sqlStr = string.Format("select title,singername,hit from yn where pinyin like '{0}%'", py);
            dt = DBHelper.GDT(sqlStr);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataTable dtb = DBHelper.GDT(sqlStr);
                this.dataGridView1.DataSource = dtb;
                this.dataGridView1.AutoGenerateColumns = false;
            }
            this.dataGridView1.Visible = true;
        }

        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void lbl_skinPrev_Click(object sender, EventArgs e)
        {
            SkinNum--;
            CheckSkinButtonState();
            this.pictureBox4.Image = this.imageList_skin.Images[SkinNum];
            this.timer2.Stop();
        }

        private void lbl_skinPrev_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_skinPrev.BackColor = Color.PaleTurquoise;
        }

        private void lbl_skinPrev_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_skinPrev.BackColor = Color.White;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SkinNum++;
            CheckSkinButtonState();
            this.pictureBox4.Image = this.imageList_skin.Images[SkinNum];
            this.timer2.Stop();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string url = @"song\" + this.dataGridView1.SelectedRows[0].Cells[1].Tag.ToString();
            //string url = @"song\" + this.dataGridView1.SelectedCells[0].Value.ToString();
            this.wmp_music.URL = url;
            this.wmp_music.Ctlcontrols.play();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //string url = @"song\" + this.dataGridView1 .SelectedRows[0].Cells [1].Value .ToString();
            //this.wmp1.URL = url;
            //this.wmp1.Ctlcontrols.play();
        }

        //按钮美化
        private void lbl_closeMaxWindow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认完全退出播放器吗？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
            }
        }
        private void lbl_closeMaxWindow_MouseEnter(object sender, EventArgs e)
        {
        }
        private void lbl_closeMaxWindow_MouseMove(object sender, MouseEventArgs e)
        {
            this.lbl_closeMaxWindow.ForeColor = Color.Red;
        }
        private void lbl_closeMaxWindow_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_closeMaxWindow.ForeColor = Color.Black;
        }

        private void lbl_minWindow_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_minWindow.ForeColor = Color.Black;
        }

        private void lbl_minWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lbl_minWindow_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_minWindow.ForeColor = Color.Red;
        }


        private void label8_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_SkinRandom.BackColor = Color.PaleTurquoise;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_SkinRandom.BackColor = Color.White;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_SkinNext.BackColor = Color.PaleTurquoise;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_SkinNext.BackColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.label2.ForeColor = Color.Black;
        }
        //歌曲循环
        private void wmp_StatusChange(object sender, EventArgs e)
        {
            if (wmp_music.playState == WMPLib.WMPPlayState.wmppsMediaEnded)//播放结束
            {
                lbl_LrcShow.Visible = false;
                System.Threading.Thread.Sleep(2000);
                wmp_music.Ctlcontrols.play();
            }
            //歌词显示状态
            if (wmp_music.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lbl_LrcShow.Visible = true;
                timer_lrc.Start();
            }
            else
            {
                timer_lrc.Stop();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 歌词定时刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_lrc_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currLrcLink))
            {
                if (wmp_music.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    lbl_LrcShow.BackColor = Color.Transparent;
                    if (lrcInfo == null)
                        lrcInfo = LrcInfo.InitLrc(currLrcLink);
                    double times = wmp_music.Ctlcontrols.currentPosition;
                    if (lrcInfo == null || lrcInfo.LrcWord.Count<=0)
                    {
                        lbl_LrcShow.Text = "歌词加载失败";
                        timer_lrc.Stop();
                        return;
                    }
                    string lrcText = lrcInfo.LrcWord.Where(i => Math.Round(i.Key) == Math.Round(times)).Select(i => i.Value).FirstOrDefault();
                    if (lrcText != null)
                    {
                        lbl_LrcShow.Text = lrcText;
                        //歌词自动居中
                        lbl_LrcShow.Location = new Point((850 - lbl_LrcShow.Width) / 2, lbl_LrcShow.Location.Y);
                    }
                }
            }
        }

    }
}
