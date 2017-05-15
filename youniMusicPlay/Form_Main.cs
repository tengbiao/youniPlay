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

namespace youni
{
    public partial class Form_Main : Form
    {
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
            this.pictureBox4.Image = this.imageList1.Images[0];
            this.label6.Enabled = false;
            sss();

            toolTip1.SetToolTip(this.label4, "关闭");
            toolTip1.SetToolTip(this.label9, "最小化");
            toolTip1.SetToolTip(this.label7, "下一张");
            toolTip1.SetToolTip(this.label8, "顺序播放");
            toolTip1.SetToolTip(this.label6, "上一张");
        }

        //更换皮肤
        int id = 0;
        private void ss()
        {
            if (id == 0)
            {
                this.label6.Enabled = false;
            }
            else
            {
                this.label6.Enabled = true;
            }
            if (id == this.imageList1.Images.Count - 1)
            {
                this.label7.Enabled = false;
            }
            else
            {
                this.label7.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //id--;
            //ss();
            //this.pictureBox4.Image = this.imageList1.Images[id];
            //this.timer2.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //id++;
            //ss();
            //this.pictureBox4.Image = this.imageList1.Images[id];
            //this.timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.timer2.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int index = r.Next(this.imageList1.Images.Count);
            this.pictureBox4.Image = this.imageList1.Images[index];
            this.timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            id++;
            if (id == this.imageList1.Images.Count)
            {
                id = 0;
            }
            this.pictureBox4.Image = this.imageList1.Images[id];
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

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

        //最小化
        private void button9_Click(object sender, EventArgs e)
        {

        }

        //双击最大化
        private void Form1_DoubleClick(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;
        }

        //歌曲列表 treeView1加载
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        //最大化
        private void button10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            this.label10.Visible = true;
            this.wmp1.Visible = true;
            this.wmp1.Ctlcontrols.play();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }
        //歌曲列表播放
        private void sss()
        {
            try
            {
                string sqlStr = "select title,singername ,URL,SPURL from yn";
                DataTable result = DBHelper.GDT(sqlStr);
                if (result != null && result.Rows.Count > 0)
                {
                    foreach (DataRow item in result.Rows)
                    {
                        ListViewItem listView = new ListViewItem(item["title"].ToString());
                        listView.SubItems.Add(item["singername"].ToString());
                        listView.Tag = item["URL"];
                        this.listView1.Items.Add(listView);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.Message);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string url = @"song\" + this.listView1.SelectedItems[0].Tag.ToString();
            this.wmp.URL = url;
            this.wmp.Ctlcontrols.play();
            string url1 = @"mv\" + this.listView1.SelectedItems[0].Tag.ToString();
            this.wmp1.URL = url1;
            this.wmp1.Ctlcontrols.stop();
        }

        private void qqq()
        {
            string sqlStr = string.Format("select title,singername,hit from yn");
            DataTable dt = DBHelper.GDT(sqlStr);
            this.dataGridView1.DataSource = dt;
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

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            id--;
            ss();
            this.pictureBox4.Image = this.imageList1.Images[id];
            this.timer2.Stop();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            id++;
            ss();
            this.pictureBox4.Image = this.imageList1.Images[id];
            this.timer2.Stop();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
        }

        private void www()
        {
            try
            {
                string sqlStr = "select title,singername,URL,SPURL from yn";
                DataTable result = DBHelper.GDT(sqlStr);
                if (result != null && result.Rows.Count > 0)
                {
                    foreach (DataRow item in result.Rows)
                    {
                        ListViewItem listVireItem = new ListViewItem(item["title"].ToString());
                        listVireItem.SubItems.Add(item["singername"].ToString());
                        listVireItem.Tag = item["SPURL"];
                        this.listView1.Items.Add(listVireItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.Message);
            }
        }

        private void listView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            string url = @"song\" + this.listView1.SelectedItems[0].Tag.ToString();
            this.wmp.URL = url;
            this.wmp.Ctlcontrols.play();

            string url1 = @"mv\" + this.listView1.SelectedItems[0].Tag.ToString();
            this.wmp1.URL = url1;
            this.wmp1.Ctlcontrols.play();

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string url = @"song\" + this.dataGridView1.SelectedRows[0].Cells[1].Tag.ToString();
            //string url = @"song\" + this.dataGridView1.SelectedCells[0].Value.ToString();
            this.wmp.URL = url;
            this.wmp.Ctlcontrols.play();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //string url = @"song\" + this.dataGridView1 .SelectedRows[0].Cells [1].Value .ToString();
            //this.wmp1.URL = url;
            //this.wmp1.Ctlcontrols.play();
        }
        //按钮美化
        private void label4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            this.label4.ForeColor = Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.label4.ForeColor = Color.White;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            this.label5.Visible = false;
            this.label9.Visible = true;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            this.label5.Visible = true;
            this.label9.Visible = false;
            this.label9.ForeColor = Color.White;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            this.label9.ForeColor = Color.Red;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            this.label6.BackColor = Color.PaleTurquoise;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            this.label6.BackColor = Color.White;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            this.label8.BackColor = Color.PaleTurquoise;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            this.label8.BackColor = Color.White;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            this.label7.BackColor = Color.PaleTurquoise;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            this.label7.BackColor = Color.White;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            this.button7.BackColor = Color.PaleTurquoise;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            this.button7.BackColor = Color.White;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            this.button8.BackColor = Color.PaleTurquoise;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            this.button8.BackColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.label2.ForeColor = Color.Black;
        }

        private void label10_MouseEnter_1(object sender, EventArgs e)
        {
            this.label10.BackColor = Color.White;
        }

        private void label10_MouseLeave_1(object sender, EventArgs e)
        {
            this.label10.BackColor = Color.Black;
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            //this.label10.Visible = false;
            //this.wmp1.Visible = false;
            //this.wmp1.Ctlcontrols.pause ();
        }

        //视频循环
        private void wmp1_StatusChange(object sender, EventArgs e)
        {
            if ((int)wmp1.playState == 1)
            {
                System.Threading.Thread.Sleep(2000);
                wmp1.Ctlcontrols.play();
            }
        }

        //歌曲循环
        private void wmp_StatusChange(object sender, EventArgs e)
        {
            if ((int)wmp.playState == 1)
            {
                System.Threading.Thread.Sleep(2000);
                wmp.Ctlcontrols.play();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.label10.Visible = false;
            this.wmp1.Visible = false;
            this.wmp1.Ctlcontrols.pause();
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            this.label10.ForeColor = Color.White;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            this.label10.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
