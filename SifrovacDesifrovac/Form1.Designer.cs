
namespace SifrovacDesifrovac {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textInput = new System.Windows.Forms.TextBox();
            textOutput = new System.Windows.Forms.TextBox();
            lblNadpis = new System.Windows.Forms.Label();
            btnSifrovat = new System.Windows.Forms.Button();
            btnCh = new System.Windows.Forms.Button();
            OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            lblFileChoose = new System.Windows.Forms.Label();
            btnDesifrovat = new System.Windows.Forms.Button();
            btnUlozit = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnClear2 = new System.Windows.Forms.Button();
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            btnOpenOkno = new System.Windows.Forms.Button();
            btnUlozit2 = new System.Windows.Forms.Button();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            lbl1 = new System.Windows.Forms.Label();
            btnPrevist = new System.Windows.Forms.Button();
            timerBar = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textInput
            // 
            textInput.BackColor = System.Drawing.Color.FromArgb(22,20,20);
            textInput.Font = new System.Drawing.Font("Segoe UI",12F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point);
            textInput.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            textInput.Location = new System.Drawing.Point(50,119);
            textInput.Multiline = true;
            textInput.Name = "textInput";
            textInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textInput.Size = new System.Drawing.Size(300,300);
            textInput.TabIndex = 1;
            // 
            // textOutput
            // 
            textOutput.BackColor = System.Drawing.Color.FromArgb(22,20,20);
            textOutput.Font = new System.Drawing.Font("Segoe UI",12F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point);
            textOutput.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            textOutput.Location = new System.Drawing.Point(869,120);
            textOutput.Multiline = true;
            textOutput.Name = "textOutput";
            textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textOutput.Size = new System.Drawing.Size(300,300);
            textOutput.TabIndex = 2;
            // 
            // lblNadpis
            // 
            lblNadpis.AutoSize = true;
            lblNadpis.Font = new System.Drawing.Font("Segoe UI Semibold",26.25F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point);
            lblNadpis.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            lblNadpis.Location = new System.Drawing.Point(391,13);
            lblNadpis.Name = "lblNadpis";
            lblNadpis.Size = new System.Drawing.Size(437,60);
            lblNadpis.TabIndex = 14;
            lblNadpis.Text = "Encrypt and Decrypt";
            // 
            // btnSifrovat
            // 
            btnSifrovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSifrovat.Font = new System.Drawing.Font("Segoe UI Semibold",9.75F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point);
            btnSifrovat.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            btnSifrovat.Location = new System.Drawing.Point(562,136);
            btnSifrovat.Name = "btnSifrovat";
            btnSifrovat.Size = new System.Drawing.Size(97,45);
            btnSifrovat.TabIndex = 3;
            btnSifrovat.Text = "Encrypt";
            btnSifrovat.UseVisualStyleBackColor = true;
            btnSifrovat.Click += SifraClick;
            // 
            // btnCh
            // 
            btnCh.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnCh.BackgroundImage");
            btnCh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnCh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCh.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            btnCh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCh.Location = new System.Drawing.Point(50,432);
            btnCh.Margin = new System.Windows.Forms.Padding(3,4,3,4);
            btnCh.Name = "btnCh";
            btnCh.Size = new System.Drawing.Size(45,45);
            btnCh.TabIndex = 11;
            btnCh.UseVisualStyleBackColor = true;
            btnCh.Click += btnCh_Click;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // lblFileChoose
            // 
            lblFileChoose.AutoSize = true;
            lblFileChoose.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            lblFileChoose.Location = new System.Drawing.Point(102,445);
            lblFileChoose.Name = "lblFileChoose";
            lblFileChoose.Size = new System.Drawing.Size(119,20);
            lblFileChoose.TabIndex = 5;
            lblFileChoose.Text = "Choose from file";
            // 
            // btnDesifrovat
            // 
            btnDesifrovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDesifrovat.Font = new System.Drawing.Font("Segoe UI Semibold",9.75F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point);
            btnDesifrovat.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            btnDesifrovat.Location = new System.Drawing.Point(562,209);
            btnDesifrovat.Margin = new System.Windows.Forms.Padding(3,4,3,4);
            btnDesifrovat.Name = "btnDesifrovat";
            btnDesifrovat.Size = new System.Drawing.Size(97,45);
            btnDesifrovat.TabIndex = 4;
            btnDesifrovat.Text = "Decrypt";
            btnDesifrovat.UseVisualStyleBackColor = true;
            btnDesifrovat.Click += SifraClick;
            // 
            // btnUlozit
            // 
            btnUlozit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUlozit.Font = new System.Drawing.Font("Segoe UI Semibold",9.75F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point);
            btnUlozit.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            btnUlozit.Location = new System.Drawing.Point(733,248);
            btnUlozit.Margin = new System.Windows.Forms.Padding(3,4,3,4);
            btnUlozit.Name = "btnUlozit";
            btnUlozit.Size = new System.Drawing.Size(97,45);
            btnUlozit.TabIndex = 6;
            btnUlozit.Text = "Save";
            btnUlozit.UseVisualStyleBackColor = true;
            btnUlozit.Click += btnUlozit_Click;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Segoe UI Semibold",8F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point);
            btnClear.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            btnClear.Location = new System.Drawing.Point(50,81);
            btnClear.Margin = new System.Windows.Forms.Padding(3,4,3,4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(32,31);
            btnClear.TabIndex = 10;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClear2
            // 
            btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear2.Font = new System.Drawing.Font("Segoe UI Semibold",8F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point);
            btnClear2.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            btnClear2.Location = new System.Drawing.Point(1137,81);
            btnClear2.Margin = new System.Windows.Forms.Padding(3,4,3,4);
            btnClear2.Name = "btnClear2";
            btnClear2.Size = new System.Drawing.Size(32,31);
            btnClear2.TabIndex = 9;
            btnClear2.Text = "C";
            btnClear2.UseVisualStyleBackColor = true;
            btnClear2.Click += btnClear2_Click;
            // 
            // btnOpenOkno
            // 
            btnOpenOkno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenOkno.Font = new System.Drawing.Font("Segoe UI Semibold",8F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point);
            btnOpenOkno.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            btnOpenOkno.Location = new System.Drawing.Point(929,81);
            btnOpenOkno.Margin = new System.Windows.Forms.Padding(3,4,3,4);
            btnOpenOkno.Name = "btnOpenOkno";
            btnOpenOkno.Size = new System.Drawing.Size(201,31);
            btnOpenOkno.TabIndex = 8;
            btnOpenOkno.Text = "Open in new window";
            btnOpenOkno.UseVisualStyleBackColor = true;
            btnOpenOkno.Click += btnOpenOkno_Click;
            // 
            // btnUlozit2
            // 
            btnUlozit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUlozit2.Font = new System.Drawing.Font("Segoe UI Semibold",9.75F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point);
            btnUlozit2.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            btnUlozit2.Location = new System.Drawing.Point(391,248);
            btnUlozit2.Margin = new System.Windows.Forms.Padding(3,4,3,4);
            btnUlozit2.Name = "btnUlozit2";
            btnUlozit2.Size = new System.Drawing.Size(97,45);
            btnUlozit2.TabIndex = 5;
            btnUlozit2.Text = "Save";
            btnUlozit2.UseVisualStyleBackColor = true;
            btnUlozit2.Click += btnUlozit2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(430,436);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(314,29);
            progressBar1.TabIndex = 12;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new System.Drawing.Font("Segoe UI Semibold",12F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point);
            lbl1.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            lbl1.Location = new System.Drawing.Point(735,377);
            lbl1.Name = "lbl1";
            lbl1.Size = new System.Drawing.Size(106,28);
            lbl1.TabIndex = 13;
            lbl1.Text = "<----------";
            // 
            // btnPrevist
            // 
            btnPrevist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrevist.Font = new System.Drawing.Font("Segoe UI Semibold",9.75F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point);
            btnPrevist.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            btnPrevist.Location = new System.Drawing.Point(733,329);
            btnPrevist.Name = "btnPrevist";
            btnPrevist.Padding = new System.Windows.Forms.Padding(0,4,0,0);
            btnPrevist.Size = new System.Drawing.Size(97,45);
            btnPrevist.TabIndex = 7;
            btnPrevist.Text = "Move";
            btnPrevist.UseVisualStyleBackColor = true;
            btnPrevist.Click += btnPrevist_Click;
            // 
            // timerBar
            // 
            timerBar.Interval = 500;
            timerBar.Tick += timerBar_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F,20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.FromArgb(22,20,20);
            ClientSize = new System.Drawing.Size(1222,513);
            Controls.Add(btnPrevist);
            Controls.Add(lbl1);
            Controls.Add(progressBar1);
            Controls.Add(btnOpenOkno);
            Controls.Add(btnClear2);
            Controls.Add(btnClear);
            Controls.Add(btnUlozit2);
            Controls.Add(btnUlozit);
            Controls.Add(btnDesifrovat);
            Controls.Add(lblFileChoose);
            Controls.Add(btnCh);
            Controls.Add(btnSifrovat);
            Controls.Add(lblNadpis);
            Controls.Add(textOutput);
            Controls.Add(textInput);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Encrypt and Decrypt";
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Label lblNadpis;
        private System.Windows.Forms.Button btnSifrovat;
        private System.Windows.Forms.Button btnCh;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label lblFileChoose;
        private System.Windows.Forms.Button btnDesifrovat;
        private System.Windows.Forms.Button btnUlozit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnOpenOkno;
        private System.Windows.Forms.Button btnUlozit2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnPrevist;
        private System.Windows.Forms.Timer timerBar;
    }
}

