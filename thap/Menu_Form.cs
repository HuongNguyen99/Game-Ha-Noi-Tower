using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thap
{
	public partial class Menu_Form : Form
	{
		public Menu_Form()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			ThapHanoi thn = new ThapHanoi();
			thn.ShowDialog();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Cho một bộ các đĩa kích thước khác nhau, có lỗ ở giữa, nằm xuyên trên ba cái cọc.\n" +
			   "Bài toán đố bắt đầu bằng cách sắp xếp các đĩa theo trật tự kích thước vào một cọc sao cho đĩa nhỏ nhất nằm trên cùng, tức là tạo ra một dạng hình nón.\n" +
				"Yêu cầu của trò chơi là di chuyển toàn bộ số đĩa sang một cọc khác," +
				" tuân theo các quy tắc sau: Chỉ có 3 cột để di chuyển.\n" +
				"Một lần chỉ được di chuyển một đĩa(không được di chuyển đĩa nằm giữa).\n" +
				"Một đĩa chỉ có thể được đặt lên một đĩa lớn hơn" +
				"(không nhất thiết hai đĩa này phải có kích thước liền kề,\n" +
				"tức là đĩa nhỏ nhất có thể nằm trên đĩa lớn nhất)",
			   "Luật chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult mess = MessageBox.Show("Bạn có muốn thoát khỏi trò chơi không?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
			if (mess == DialogResult.Yes)
			{
				this.Close();			
			}
			else
			{
			}
		}

		private void Menu_Form_Load(object sender, EventArgs e)
		{

		}
	}
}
