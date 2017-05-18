using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class CaesarCipher : Form
    {
        private List<TextBox> tbList = new List<TextBox>();
        private List<TextBox> tb2List = new List<TextBox>();
        private List<TextBox> tb3List = new List<TextBox>();

        public CaesarCipher()
        {
            InitializeComponent();

            #region -- List Add --
            tbList.Add(tb_a);
            tbList.Add(tb_b);
            tbList.Add(tb_c);
            tbList.Add(tb_d);
            tbList.Add(tb_e);
            tbList.Add(tb_f);
            tbList.Add(tb_g);
            tbList.Add(tb_h);
            tbList.Add(tb_i);
            tbList.Add(tb_j);
            tbList.Add(tb_k);
            tbList.Add(tb_l);
            tbList.Add(tb_m);
            tbList.Add(tb_n);
            tbList.Add(tb_o);
            tbList.Add(tb_p);
            tbList.Add(tb_q);
            tbList.Add(tb_r);
            tbList.Add(tb_s);
            tbList.Add(tb_t);
            tbList.Add(tb_u);
            tbList.Add(tb_v);
            tbList.Add(tb_w);
            tbList.Add(tb_x);
            tbList.Add(tb_y);
            tbList.Add(tb_z);

            #endregion

            #region -- List Add --
            tb2List.Add(tb2_a);
            tb2List.Add(tb2_b);
            tb2List.Add(tb2_c);
            tb2List.Add(tb2_d);
            tb2List.Add(tb2_e);
            tb2List.Add(tb2_f);
            tb2List.Add(tb2_g);
            tb2List.Add(tb2_h);
            tb2List.Add(tb2_i);
            tb2List.Add(tb2_j);
            tb2List.Add(tb2_k);
            tb2List.Add(tb2_l);
            tb2List.Add(tb2_m);
            tb2List.Add(tb2_n);
            tb2List.Add(tb2_o);
            tb2List.Add(tb2_p);
            tb2List.Add(tb2_q);
            tb2List.Add(tb2_r);
            tb2List.Add(tb2_s);
            tb2List.Add(tb2_t);
            tb2List.Add(tb2_u);
            tb2List.Add(tb2_v);
            tb2List.Add(tb2_w);
            tb2List.Add(tb2_x);
            tb2List.Add(tb2_y);
            tb2List.Add(tb2_z);

            #endregion

            #region -- List Add --
            tb3List.Add(tb_0);
            tb3List.Add(tb_1);
            tb3List.Add(tb_2);
            tb3List.Add(tb_3);
            tb3List.Add(tb_4);
            tb3List.Add(tb_5);
            tb3List.Add(tb_6);
            tb3List.Add(tb_7);
            tb3List.Add(tb_8);
            tb3List.Add(tb_9);

            #endregion

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;
            string output = "";

            #region -- foreach --
            foreach (char c in input)
            {
                switch (c)
                {
                    case 'a':
                        output += tb_a.Text;
                        break;
                    case 'b':
                        output += tb_b.Text;
                        break;
                    case 'c':
                        output += tb_c.Text;
                        break;
                    case 'd':
                        output += tb_d.Text;
                        break;
                    case 'e':
                        output += tb_e.Text;
                        break;
                    case 'f':
                        output += tb_f.Text;
                        break;
                    case 'g':
                        output += tb_g.Text;
                        break;
                    case 'h':
                        output += tb_h.Text;
                        break;
                    case 'i':
                        output += tb_i.Text;
                        break;
                    case 'j':
                        output += tb_j.Text;
                        break;
                    case 'k':
                        output += tb_k.Text;
                        break;
                    case 'l':
                        output += tb_l.Text;
                        break;
                    case 'm':
                        output += tb_m.Text;
                        break;
                    case 'n':
                        output += tb_n.Text;
                        break;
                    case 'o':
                        output += tb_o.Text;
                        break;
                    case 'p':
                        output += tb_p.Text;
                        break;
                    case 'q':
                        output += tb_q.Text;
                        break;
                    case 'r':
                        output += tb_r.Text;
                        break;
                    case 's':
                        output += tb_s.Text;
                        break;
                    case 't':
                        output += tb_t.Text;
                        break;
                    case 'u':
                        output += tb_u.Text;
                        break;
                    case 'v':
                        output += tb_v.Text;
                        break;
                    case 'w':
                        output += tb_w.Text;
                        break;
                    case 'x':
                        output += tb_x.Text;
                        break;
                    case 'y':
                        output += tb_y.Text;
                        break;
                    case 'z':
                        output += tb_z.Text;
                        break;
                    case 'A':
                        output += tb2_a.Text;
                        break;
                    case 'B':
                        output += tb2_b.Text;
                        break;
                    case 'C':
                        output += tb2_c.Text;
                        break;
                    case 'D':
                        output += tb2_d.Text;
                        break;
                    case 'E':
                        output += tb2_e.Text;
                        break;
                    case 'F':
                        output += tb2_f.Text;
                        break;
                    case 'G':
                        output += tb2_g.Text;
                        break;
                    case 'H':
                        output += tb2_h.Text;
                        break;
                    case 'I':
                        output += tb2_i.Text;
                        break;
                    case 'J':
                        output += tb2_j.Text;
                        break;
                    case 'K':
                        output += tb2_k.Text;
                        break;
                    case 'L':
                        output += tb2_l.Text;
                        break;
                    case 'M':
                        output += tb2_m.Text;
                        break;
                    case 'N':
                        output += tb2_n.Text;
                        break;
                    case 'O':
                        output += tb2_o.Text;
                        break;
                    case 'P':
                        output += tb2_p.Text;
                        break;
                    case 'Q':
                        output += tb2_q.Text;
                        break;
                    case 'R':
                        output += tb2_r.Text;
                        break;
                    case 'S':
                        output += tb2_s.Text;
                        break;
                    case 'T':
                        output += tb2_t.Text;
                        break;
                    case 'U':
                        output += tb2_u.Text;
                        break;
                    case 'V':
                        output += tb2_v.Text;
                        break;
                    case 'W':
                        output += tb2_w.Text;
                        break;
                    case 'X':
                        output += tb2_x.Text;
                        break;
                    case 'Y':
                        output += tb2_y.Text;
                        break;
                    case 'Z':
                        output += tb2_z.Text;
                        break;
                    case '0':
                        output += tb_0.Text;
                        break;
                    case '1':
                        output += tb_1.Text;
                        break;
                    case '2':
                        output += tb_2.Text;
                        break;
                    case '3':
                        output += tb_3.Text;
                        break;
                    case '4':
                        output += tb_4.Text;
                        break;
                    case '5':
                        output += tb_5.Text;
                        break;
                    case '6':
                        output += tb_6.Text;
                        break;
                    case '7':
                        output += tb_7.Text;
                        break;
                    case '8':
                        output += tb_8.Text;
                        break;
                    case '9':
                        output += tb_9.Text;
                        break;
                    default:
                        output += c;
                        break;
                }
            } 

            #endregion

            richTextBox2.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ascii = 97 + Convert.ToInt32(tb_offset.Text);
            for (int i = 0; i <= 25; i++)
            {
                char c = (char)ascii;
                tbList[i].Text = c.ToString();

                if (++ascii >= 123)
                    ascii = 97;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ascii = 65 + Convert.ToInt32(tb2_offset.Text);
            for (int i = 0; i <= 25; i++)
            {
                char c = (char)ascii;
                tb2List[i].Text = c.ToString();

                if (++ascii >= 91)
                    ascii = 65;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ascii = 48 + Convert.ToInt32(tb3_offset.Text);
            for (int i = 0; i <= 9; i++)
            {
                char c = (char)ascii;
                tb3List[i].Text = c.ToString();

                if (++ascii >= 58)
                    ascii = 48;

            }
        }
    }
}
