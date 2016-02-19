using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Calculator {
    public partial class Form_main : Form {
		string smap;
		Button[] but = new Button[20];

        public Form_main() {
            InitializeComponent();
            int i = 0;
            foreach (Control t in tableLayoutPanel.Controls) {
                if (t is Button) {
                    but[i++] = (Button)t;
                }
            }
        }

        private void button_Click(object sender, System.EventArgs e) {
            Button t = (Button)sender;
			if (t.Text == "=") {
				solve_problem();
			}
			else if (t.Text == "C") {
				int len = label_show.Text.Length;
				if (len > 0) {
					label_show.Text = label_show.Text.Substring(0, len - 1);
				}
			}
			else if (t.Text == "CE") {
				label_show.Text = "";
			}
			else {
				label_show.Text += t.Text;
			}
			label_show.Focus();
        }

		private void Form_main_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == 27) {
				label_show.Text = "";
				return;
			}
			if (e.KeyChar == '=' || e.KeyChar == 13) {
				solve_problem();
				return;
			}
			if (e.KeyChar == 8) {
				int len = label_show.Text.Length;
				if (len > 0) {
					label_show.Text = label_show.Text.Substring(0, len - 1);
				}
				return;
			}
			foreach (Button t in but) {
				if(t == null) continue;
				if (t.Text == "" + e.KeyChar) {
					label_show.Text += t.Text;
					break;
				}
            }
        }

#region Solve_Trie
		class Data {
			public char oper;
			public double num;
			public Data ls, rs;
		}

		Data build(int l, int r) {
			int[] pos = new int[] {-1, -1};
			int is_num = 1, d = 0, cnt = 0;
			double num = 0, now = 1;

			for (int i = l; i <= r; i++) {
				if ('0' <= smap[i] && smap[i] <= '9') {
					if (d == 0) {
						num = num * 10 + smap[i] - '0';
					}
					else {
						now /= 10;
						num += now * (smap[i] - '0');
					}
				}
				else if (smap[i] == '.') {
					d = 1;
				}
				else {
					is_num = 0;
					break;
				}
			}

			if (is_num == 1) {
				Data t = new Data();
				t.num = num; t.oper = '.';
				return t;
			}

			for (int i = l; i <= r; i++) {
				switch (smap[i]) {
					case '(': cnt++; break;
					case ')': cnt--; break;
					case '+':
					case '-': if (cnt == 0) pos[0] = i; break;
					case '*':
					case '/': if (cnt == 0) pos[1] = i; break;
				}
			}

			Data u;
			if (pos[0] < 0) pos[0] = pos[1];
			if (pos[0] < 0) u = build(l + 1, r - 1);
			else {
				u = new Data();
				u.oper = smap[pos[0]];
				u.ls = build(l, pos[0] - 1);
				u.rs = build(pos[0] + 1, r);
			}
			return u;
		}

		double solve(Data u) {
			if (u.oper == '.') {
				double ret = u.num;
				u = null;
				return ret;
			}
			double l = solve(u.ls), r = solve(u.rs);
			switch (u.oper) {
				case '+': return l + r;
				case '-': return l - r;
				case '*': return l * r;
				case '/': return l / r;
			}
			return 0;
		}
#endregion

		private void solve_problem() {
			smap = label_show.Text;
			Data rt = build(0, smap.Length - 1);
			double res = solve(rt);
			label_show.Text += "\r\n = " + res;
		}

		private void 复制结果ToolStripMenuItem_Click(object sender, System.EventArgs e) {
			Clipboard.SetDataObject(label_show.Text, true);
		}
    }
}
