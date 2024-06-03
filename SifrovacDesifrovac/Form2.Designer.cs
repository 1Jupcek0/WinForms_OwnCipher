
namespace SifrovacDesifrovac {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new System.Windows.Forms.Label();
            textFinal = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold",26.25F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            label1.Location = new System.Drawing.Point(378,12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(147,60);
            label1.TabIndex = 0;
            label1.Text = "Result";
            // 
            // textFinal
            // 
            textFinal.BackColor = System.Drawing.Color.FromArgb(22,20,20);
            textFinal.Font = new System.Drawing.Font("Segoe UI",12F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point);
            textFinal.ForeColor = System.Drawing.Color.FromArgb(240,48,21);
            textFinal.Location = new System.Drawing.Point(14,91);
            textFinal.Margin = new System.Windows.Forms.Padding(3,4,3,4);
            textFinal.Multiline = true;
            textFinal.Name = "textFinal";
            textFinal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textFinal.Size = new System.Drawing.Size(853,104);
            textFinal.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F,20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.FromArgb(22,20,20);
            ClientSize = new System.Drawing.Size(881,235);
            Controls.Add(textFinal);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3,4,3,4);
            Name = "Form2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Result";
            TopMost = true;
            Paint += Form2_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFinal;
    }
}