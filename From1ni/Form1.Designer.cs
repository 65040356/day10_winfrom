namespace From1ni
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.question_text = new System.Windows.Forms.TextBox();
            this.solution_textbox = new System.Windows.Forms.TextBox();
            this.botton1 = new System.Windows.Forms.Button();
            this.solution_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question_text
            // 
            this.question_text.Location = new System.Drawing.Point(119, 110);
            this.question_text.Multiline = true;
            this.question_text.Name = "question_text";
            this.question_text.Size = new System.Drawing.Size(292, 45);
            this.question_text.TabIndex = 1;
            // 
            // solution_textbox
            // 
            this.solution_textbox.Location = new System.Drawing.Point(119, 214);
            this.solution_textbox.Multiline = true;
            this.solution_textbox.Name = "solution_textbox";
            this.solution_textbox.Size = new System.Drawing.Size(158, 45);
            this.solution_textbox.TabIndex = 2;
            // 
            // botton1
            // 
            this.botton1.Location = new System.Drawing.Point(456, 110);
            this.botton1.Name = "botton1";
            this.botton1.Size = new System.Drawing.Size(132, 45);
            this.botton1.TabIndex = 3;
            this.botton1.Text = "คำนวณ";
            this.botton1.UseVisualStyleBackColor = true;
            this.botton1.Click += new System.EventHandler(this.botton1_Click);
            // 
            // solution_label
            // 
            this.solution_label.AutoSize = true;
            this.solution_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.solution_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.solution_label.Location = new System.Drawing.Point(395, 228);
            this.solution_label.Name = "solution_label";
            this.solution_label.Size = new System.Drawing.Size(29, 31);
            this.solution_label.TabIndex = 4;
            this.solution_label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solution_label);
            this.Controls.Add(this.botton1);
            this.Controls.Add(this.solution_textbox);
            this.Controls.Add(this.question_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question_text;
        private System.Windows.Forms.TextBox solution_textbox;
        private System.Windows.Forms.Button botton1;
        private System.Windows.Forms.Label solution_label;
    }
}

