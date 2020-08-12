using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vips_Store_ManageProgram
{
    public partial class Form1_Table : Form
    {
        int count_adult = 0;
        int count_adult2 = 0;
        int count_adult3 = 0;
        int count_adult4 = 0;
        int count_kid = 0;
        int count_kid2 = 0;
        int count_kid3 = 0;
        int count_kid4 = 0;

        public Form1_Table()
        {
            InitializeComponent();

            //List_Box Table List 항목 저장
            string[] Table_List = { "Table1", "Table2", "Table3", "Table4"};

            foreach (var item in Table_List)
            {
                listBox1.Items.Add(item);
            }
        }



        //회원 관리 프로그램 Form2로 이동
        private void button1_Click(object sender, EventArgs e)
        {
            Form2_Customer test = new Form2_Customer();
            test.Show();
        }

        //Table_Button에 직접 Display되도록 설정
        private void Table1_Click(object sender, EventArgs e)
        {
            Table1.Text = "- 1번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult + "명\n" + "- 아동 " + count_kid + "명";       // Textbox 자체에서 display
            //MessageBox.Show("1번고객입장\n" + "입실 시간 : " + DateTime.Now.ToString() + "\n성인 " + count_adult + "명\n" + "\n아동" + count_kid + "명");  // Messagebox에서 display
        }
        private void Table2_Click(object sender, EventArgs e)
        {
            Table2.Text = "- 2번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult2 + "명\n" + "- 아동 " + count_kid2 + "명";       // Textbox 자체에서 display
        }
        private void Table3_Click(object sender, EventArgs e)
        {
            Table3.Text = "- 3번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult3 + "명\n" + "- 아동 " + count_kid3 + "명";       // Textbox 자체에서 display
        }
        private void Table4_Click(object sender, EventArgs e)
        {
            Table3.Text = "- 4번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult4 + "명\n" + "- 아동 " + count_kid4 + "명";       // Textbox 자체에서 display
        }

        //원하는 ListBox index를 찾아가서 성인 인원 수 count ++
        private void Adults_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    count_adult++;
                    Table1.Text = "- 1번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult + "명\n" + "- 아동 " + count_kid + "명";       // Textbox 자체에서 display
                    break;
                case 1:
                    count_adult2++;
                    Table2.Text = "- 2번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult2 + "명\n" + "- 아동 " + count_kid2 + "명";       // Textbox 자체에서 display
                    break;
                case 2:
                    count_adult3++;
                    Table3.Text = "- 3번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult3 + "명\n" + "- 아동 " + count_kid3 + "명";       // Textbox 자체에서 display
                    break;
                case 3:
                    count_adult4++;
                    Table4.Text = "- 4번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult4 + "명\n" + "- 아동 " + count_kid4 + "명";       // Textbox 자체에서 display
                    break;
                default:
                    break;
            }
        }

        //원하는 ListBox index를 찾아가서 아동 인원 수 count ++
        private void Kids_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    count_kid++;
                    Table1.Text = "- 1번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult + "명\n" + "- 아동 " + count_kid + "명";       // Textbox 자체에서 display
                    break;
                case 1:
                    count_kid2++;
                    Table2.Text = "- 2번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult2 + "명\n" + "- 아동 " + count_kid2 + "명";       // Textbox 자체에서 display
                    break;
                case 2:
                    count_kid3++;
                    Table3.Text = "- 3번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult3 + "명\n" + "- 아동 " + count_kid3 + "명";       // Textbox 자체에서 display
                    break;
                case 3:
                    count_kid4++;
                    Table4.Text = "- 4번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult4 + "명\n" + "- 아동 " + count_kid4 + "명";       // Textbox 자체에서 display
                    break;
                default:
                    break;
            }
        }

        //원하는 ListBox index를 찾아가서 성인 인원 수 count --
        private void Adult_Minus_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    count_adult--;
                    Table1.Text = "- 1번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult + "명\n" + "- 아동 " + count_kid + "명";       // Textbox 자체에서 display
                    break;
                case 1:
                    count_adult2--;
                    Table2.Text = "- 2번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult2 + "명\n" + "- 아동 " + count_kid2 + "명";       // Textbox 자체에서 display
                    break;
                case 2:
                    count_adult3--;
                    Table3.Text = "- 3번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult3 + "명\n" + "- 아동 " + count_kid3 + "명";       // Textbox 자체에서 display
                    break;
                case 3:
                    count_adult4--;
                    Table4.Text = "- 4번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult4 + "명\n" + "- 아동 " + count_kid4 + "명";       // Textbox 자체에서 display
                    break;
                default:
                    break;
            }
        }

        //원하는 ListBox index를 찾아가서 아동 인원 수 count --
        private void Kids_Minus_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    count_kid--;
                    Table1.Text = "- 1번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult + "명\n" + "- 아동 " + count_kid + "명";       // Textbox 자체에서 display
                    break;
                case 1:
                    count_kid2--;
                    Table2.Text = "- 2번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult2 + "명\n" + "- 아동 " + count_kid2 + "명";       // Textbox 자체에서 display
                    break;
                case 2:
                    count_kid3--;
                    Table3.Text = "- 3번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult3 + "명\n" + "- 아동 " + count_kid3 + "명";       // Textbox 자체에서 display
                    break;
                case 3:
                    count_kid4--;
                    Table4.Text = "- 4번 Table \n" + "- 입실 시간 \n" + DateTime.Now.ToString() + "\n- 성인 " + count_adult4 + "명\n" + "- 아동 " + count_kid4 + "명";       // Textbox 자체에서 display
                    break;

                default:
                    break;
            }
        }
    }
}


