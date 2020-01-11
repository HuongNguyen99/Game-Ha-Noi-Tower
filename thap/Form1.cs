using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace thap
{
  
    public partial class ThapHanoi : Form
    {
        TimeSpan time;
        int[]  a={ 1, 3, 7, 15, 31 ,63, 127, 254 };
        int moveCount;
        PictureBox[] dias;
        Stack<PictureBox> diaA, diaB, diaC, firstClickdias, secondClickdias;
		
        const int FirstY = 347;
        const int height = 25;
        public ThapHanoi()
        {
            InitializeComponent();
            dias = new PictureBox[] { dia1, dia2, dia3, dia4, dia5, dia6, dia7, dia8 };
            CotA.Tag=diaA = new Stack<PictureBox>();
            CotB.Tag=diaB = new Stack<PictureBox>();
            CotC.Tag=diaC = new Stack<PictureBox>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
		
        } 
        private void luatchoi_Click(object sender, EventArgs e)
        {
        }

		private void thoigian_Click(object sender, EventArgs e)
        {
        }

		private void tamdung_Click(object sender, EventArgs e)
        {
            counttime.Stop();
            sodia.Enabled = true;
            tamdung.Enabled = false;
            muc.Visible= true;
            De.Visible= true;
            kho.Visible = true;
           // play.Text = "Play";
        }

        private void play_Click(object sender, EventArgs e)
        {
            //reset
            counttime.Stop();
            foreach (PictureBox dia in dias)
            dia.Visible = false;
            muc.Visible = false;
            De.Visible = false;
            kho.Visible = false;
            time = new TimeSpan(0);
            thoigian.Text = "00:00:00";
            moveCount = 0;
            solandich.Text = "0";
         //   panel4.Visible = false;
         //   panel4.Enabled = false;
            diaA.Clear();
            diaB.Clear();
            diaC.Clear();
            CotA.BorderStyle = CotB.BorderStyle = CotC.BorderStyle = BorderStyle.None;
            firstClickdias = secondClickdias = null;
            //init
            sodia.Enabled = false;
            tamdung.Visible= true;
            tamdung.Enabled = true;
			int x = CotA.Location.X;
            int y = FirstY;
		
            for(int i = (int)sodia.Value - 1; i >= 0; i--,y-=height)
            {
                dias[i].Location = new Point(x, y);
                dias[i].Visible = true;
                diaA.Push(dias[i]);
            }
			if (sodia.Value == 0)
			{
				MessageBox.Show("Bạn chưa chọn đĩa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
				sodia.Enabled = true;
				muc.Visible = true;
				De.Visible = true;
				kho.Visible = true;
			}
			else
			{
				counttime.Start();
			}
        }

        private void solandich_Click(object sender, EventArgs e)
        {

        }

        private void counttime_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1));
            thoigian.Text = String.Format("{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
        }

        private void sodia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mức_Click(object sender, EventArgs e)
        {

        }

        private void kho_Click(object sender, EventArgs e)
        {
			panel4.Visible = true;
            solandichchuyentoida.Visible = true;
            solandichchuyentoida.Text = string.Format("{0}",a[(int)sodia.Value-1]);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void De_Click(object sender, EventArgs e)
        {
			panel4.Visible = false;
			solandichchuyentoida.Visible = false;
            solandichchuyentoida.Enabled = false;

        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Menu_Form menu = new Menu_Form();
			menu.ShowDialog();
			this.Close();
		}

		private void panel7_Paint(object sender, PaintEventArgs e)
		{

		}

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cot_Click(object sender, EventArgs e)
        {
            if (sodia.Enabled) return;
            PictureBox clickCot = (PictureBox)sender;
            Stack<PictureBox> diaOfClickCot = (Stack<PictureBox>)clickCot.Tag;
            if (firstClickdias == null)
            {
                if (diaOfClickCot.Count == 0) return;
                firstClickdias = diaOfClickCot;
                clickCot.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (secondClickdias == null)
            {
                if (diaOfClickCot == firstClickdias)
                {
                    firstClickdias= null;
                    clickCot.BorderStyle = BorderStyle.None;
                    return;
                }
                secondClickdias = diaOfClickCot;
                ProcessMovingdia(clickCot);
            }
        }
        private void ProcessMovingdia(PictureBox Clickcot)
        {
            if (secondClickdias.Count == 0)
                Movedia(new Point(Clickcot.Location.X, FirstY));
            else
            {
                PictureBox firstTopdia = firstClickdias.Peek();
                PictureBox secondTopdia = secondClickdias.Peek();
                if (int.Parse(firstTopdia.Tag.ToString()) < int.Parse(secondTopdia.Tag.ToString()))
                    Movedia(new Point(secondTopdia.Location.X, secondTopdia.Location.Y - height));
                else
                    secondClickdias = null;
            }
        }
        private void Movedia(Point point)
        {
            PictureBox firstTopdia = firstClickdias.Pop();
            firstTopdia.Location = point;
            secondClickdias.Push(firstTopdia);

            WindowsMediaPlayer Player = new WindowsMediaPlayer();
            Player.URL = "click_dia.mp3";
          	Player.controls.play();
            
         
            moveCount++;
            solandich.Text = string.Format("{0}", moveCount);
           if (solandichchuyentoida.Visible == true) {
                if (moveCount > a[(int)sodia.Value-1])
                {
                    tamdung.PerformClick();
                    MessageBox.Show("Bạn đã thua. Vui lòng chơi lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            firstClickdias = secondClickdias = null;
            CotA.BorderStyle = CotB.BorderStyle = CotC.BorderStyle = BorderStyle.None;
            if (diaC.Count == sodia.Value)
            {
                tamdung.PerformClick();
                MessageBox.Show("Chúc mừng bạn đã thắng", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dia_Click(object sender, EventArgs e)
        {
            PictureBox clickeddia = (PictureBox)sender;
            if (diaA.Contains(clickeddia))
                Cot_Click(CotA, new EventArgs());
            else if (diaB.Contains(clickeddia))
                Cot_Click(CotB, new EventArgs());
            else 
                Cot_Click(CotC, new EventArgs());

        }
    }
}
