using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SifrovacDesifrovac {
    public partial class Form1 : Form {
        public static Form1 instance;
        public TextBox vysledek;
        public Form1() {
            InitializeComponent();
            instance = this;
            vysledek = textOutput;
        }
        Button click;
        private void SifraClick(object sender, EventArgs e) {
            click = (Button)sender;
            progressBar1.Value = 0;
            timerBar.Start();
        }
        void Zasifrovat() {
            string binary = ZasifrovatTextToBinary();
            binary = ZasifrovatZvetseniBinary(binary);
            binary = ZasifrovatBinaryToTextPlusAscii(binary);
            textOutput.Text = binary;
        }
        string ZasifrovatTextToBinary() {
            // text na binary
            string binary = "";
            foreach(char ch in textInput.Text) {
                int tmp = ch;
                binary += Convert.ToString(ch,2).PadLeft(8,'0');
            }
            return binary;
        }
        string ZasifrovatZvetseniBinary(string binary) {
            // změnění binary čísla ze zádu
            char[] changedBinary = binary.ToCharArray();
            int y = 1;
            for(int i = 1; i <= (binary.Length / 8); i++) {
                while(true) {
                    if(changedBinary[binary.Length - y] == '0') {
                        changedBinary[binary.Length - y] = '1';
                        break;
                    }
                    else {
                        changedBinary[binary.Length - y] = '0';
                        y++;
                    }
                }
                y = i * 8 +1;
            }
            return new string(changedBinary);
        }
        string ZasifrovatBinaryToTextPlusAscii(string binary) {
            // binary dát na text + ob 2 číslo
            string changedBinary = "";
            for(int i = 0; i < binary.Length; i+= 8) {
                string t = binary.Substring(i, 8);
                if((i % 24) == 0) {
                    changedBinary += Convert.ToByte(t, 2);
                }
                else {
                    changedBinary += Convert.ToChar(Convert.ToByte(t, 2));
                }
            }

            return changedBinary;
        }
        //
        void Desifrovat() {
            string binary = DesifrovatTextToBinary();
            binary = DesifrovatZmenseniBinary(binary);
            binary = DesifrovatBinaryToText(binary);
            textOutput.Text = binary;
        }
        string DesifrovatTextToBinary() {
            string text = textInput.Text;
            string changed = "";

            string s = "";
            for(int i = 0; i < text.Length; i ++) {
                try {
                    Convert.ToInt32(text[i].ToString());
                    s += text[i];
                    if((i + 1) == text.Length) {
                        changed += Convert.ToString(Convert.ToByte(s), 2).PadLeft(8, '0');
                    }
                } catch(Exception) {
                    if(s != "") {
                        changed += Convert.ToString(Convert.ToByte(s), 2).PadLeft(8,'0');
                        s = "";
                    }
                    char t = text[i];
                    changed += Convert.ToString(Convert.ToByte(t), 2).PadLeft(8, '0');
                }
            }
            return changed;
        }
        string DesifrovatZmenseniBinary(string binary) {
            char[] changedBinary = binary.ToCharArray();
            int y = 1;
            for(int i = 1; i <= (binary.Length / 8); i++) {
                while(true) {
                    if(changedBinary[binary.Length - y] == '1') {
                        changedBinary[binary.Length - y] = '0';
                        break;
                    }
                    else {
                        changedBinary[binary.Length - y] = '1';
                        y++;
                    }
                }
                y = i * 8 +1;
            }
            return new string(changedBinary);
        }
        string DesifrovatBinaryToText(string binary) {
            // vzít 8
            // to byte-> to ascii
            string changed = "";
            for(int i = 0; i < binary.Length; i+= 8) {
                string t = Convert.ToInt32(binary.Substring(i, 8),2).ToString();
                changed += Convert.ToChar(int.Parse(t));
            }
            return changed;
        }
        //
        private void btnCh_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Vyberte text";
            ofd.Filter = "TXT|*.txt";
            if(ofd.ShowDialog() == DialogResult.OK) {
                using (StreamReader rd = new StreamReader(@"" + ofd.FileName)) {
                    textInput.Text = rd.ReadToEnd();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            textInput.Text = "";
        }

        private void btnClear2_Click(object sender, EventArgs e) {
            textOutput.Text = "";
        }

        private void btnUlozit_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Vyberte umístění";
            sfd.Filter = "TXT|*.txt";
            if(sfd.ShowDialog() == DialogResult.OK) {
                using(StreamWriter wr = new StreamWriter(@"" + sfd.FileName)) {
                    wr.Write(textOutput.Text);
                }
            }
        }
        private void btnUlozit2_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Vyberte umístění";
            sfd.Filter = "TXT|*.txt";
            if(sfd.ShowDialog() == DialogResult.OK) {
                using(StreamWriter wr = new StreamWriter(@"" + sfd.FileName)) {
                    wr.Write(textInput.Text);

                }
            }
        }

        private void btnOpenOkno_Click(object sender, EventArgs e) {
            Form2 form = new Form2();
            form.Show();
        }

        private void btnPrevist_Click(object sender, EventArgs e) {
            textInput.Text = textOutput.Text;
            textOutput.Text = "";
        }

        private void timerBar_Tick(object sender, EventArgs e) {
            progressBar1.Value = 100;
            timerBar.Stop();
            if(click.Text == "Encrypt")
                Zasifrovat();
            else
                Desifrovat();
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            Graphics grf = e.Graphics;
            Color clr = Color.FromArgb(240, 48, 21);
            Pen pn = new Pen(clr, 5);
            grf.DrawRectangle(pn, textInput.Location.X, textInput.Location.Y, textInput.Size.Width-1, textInput.Size.Height-1);
            grf.DrawRectangle(pn, textOutput.Location.X, textOutput.Location.Y, textOutput.Size.Width - 1, textOutput.Size.Height - 1);
            grf.DrawRectangle(pn, progressBar1.Location.X, progressBar1.Location.Y, progressBar1.Size.Width - 1, progressBar1.Size.Height - 1);
        }
    }
}
