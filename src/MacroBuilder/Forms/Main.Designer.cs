
namespace MacroBuilder
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MacroResult_Box = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinimazeBtn = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.FilenameBox = new System.Windows.Forms.TextBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ObfuscateChk = new System.Windows.Forms.CheckBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimazeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // MacroResult_Box
            // 
            this.MacroResult_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.MacroResult_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MacroResult_Box.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MacroResult_Box.ForeColor = System.Drawing.Color.Cyan;
            this.MacroResult_Box.Location = new System.Drawing.Point(201, 44);
            this.MacroResult_Box.Name = "MacroResult_Box";
            this.MacroResult_Box.ReadOnly = true;
            this.MacroResult_Box.Size = new System.Drawing.Size(282, 315);
            this.MacroResult_Box.TabIndex = 2;
            this.MacroResult_Box.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MacroBuilder.Properties.Resources.WolfLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MinimazeBtn
            // 
            this.MinimazeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimazeBtn.Image = global::MacroBuilder.Properties.Resources.minus;
            this.MinimazeBtn.Location = new System.Drawing.Point(402, 7);
            this.MinimazeBtn.Name = "MinimazeBtn";
            this.MinimazeBtn.Size = new System.Drawing.Size(33, 31);
            this.MinimazeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimazeBtn.TabIndex = 1;
            this.MinimazeBtn.TabStop = false;
            this.MinimazeBtn.Click += new System.EventHandler(this.MinimazeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::MacroBuilder.Properties.Resources.close;
            this.CloseBtn.Location = new System.Drawing.Point(450, 7);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(33, 31);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Macro Builder 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "By K3rnel-Dev";
            // 
            // UrlBox
            // 
            this.UrlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.UrlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UrlBox.ForeColor = System.Drawing.Color.Cyan;
            this.UrlBox.Location = new System.Drawing.Point(12, 113);
            this.UrlBox.Multiline = true;
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(172, 26);
            this.UrlBox.TabIndex = 6;
            this.UrlBox.Text = "http://127.0.0.1/malware.exe";
            this.UrlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FilenameBox
            // 
            this.FilenameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.FilenameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilenameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FilenameBox.ForeColor = System.Drawing.Color.Cyan;
            this.FilenameBox.Location = new System.Drawing.Point(12, 171);
            this.FilenameBox.Multiline = true;
            this.FilenameBox.Name = "FilenameBox";
            this.FilenameBox.Size = new System.Drawing.Size(172, 26);
            this.FilenameBox.TabIndex = 7;
            this.FilenameBox.Text = "MalwareMan.exe";
            this.FilenameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.GenerateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateBtn.ForeColor = System.Drawing.Color.White;
            this.GenerateBtn.Location = new System.Drawing.Point(15, 300);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(169, 59);
            this.GenerateBtn.TabIndex = 8;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = false;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "URL TO EXE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "FILENAME:";
            // 
            // ObfuscateChk
            // 
            this.ObfuscateChk.AutoSize = true;
            this.ObfuscateChk.ForeColor = System.Drawing.Color.White;
            this.ObfuscateChk.Location = new System.Drawing.Point(15, 212);
            this.ObfuscateChk.Name = "ObfuscateChk";
            this.ObfuscateChk.Size = new System.Drawing.Size(75, 17);
            this.ObfuscateChk.TabIndex = 11;
            this.ObfuscateChk.Text = "Obfuscate";
            this.ObfuscateChk.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(15, 244);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(169, 50);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Copy Result";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(96, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(495, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ObfuscateChk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.FilenameBox);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MacroResult_Box);
            this.Controls.Add(this.MinimazeBtn);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro Builder 1.0";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimazeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.PictureBox MinimazeBtn;
        private System.Windows.Forms.RichTextBox MacroResult_Box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.TextBox FilenameBox;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ObfuscateChk;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button button1;
    }
}

