namespace Balda
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.beginn = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.player1lb = new System.Windows.Forms.ListBox();
            this.player2lb = new System.Windows.Forms.ListBox();
            this.back = new System.Windows.Forms.Button();
            this.Exitbbtn = new System.Windows.Forms.Button();
            this.nameplayer1 = new System.Windows.Forms.Label();
            this.nameplayer2 = new System.Windows.Forms.Label();
            this.Score1 = new System.Windows.Forms.Label();
            this.Score2 = new System.Windows.Forms.Label();
            this.inpWORD = new System.Windows.Forms.Label();
            this.inputt = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Label();
            this.tbWORD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // beginn
            // 
            this.beginn.FlatAppearance.BorderSize = 2;
            this.beginn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginn.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginn.Location = new System.Drawing.Point(190, 14);
            this.beginn.Name = "beginn";
            this.beginn.Size = new System.Drawing.Size(120, 40);
            this.beginn.TabIndex = 0;
            this.beginn.Text = "Начать";
            this.beginn.UseVisualStyleBackColor = true;
            this.beginn.Click += new System.EventHandler(this.beginn_Click);
            // 
            // Accept
            // 
            this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accept.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Accept.Location = new System.Drawing.Point(175, 415);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(150, 35);
            this.Accept.TabIndex = 1;
            this.Accept.Text = "Подтвердить";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Visible = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // player1lb
            // 
            this.player1lb.BackColor = System.Drawing.SystemColors.Window;
            this.player1lb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player1lb.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1lb.FormattingEnabled = true;
            this.player1lb.ItemHeight = 23;
            this.player1lb.Location = new System.Drawing.Point(15, 125);
            this.player1lb.Name = "player1lb";
            this.player1lb.Size = new System.Drawing.Size(80, 207);
            this.player1lb.TabIndex = 8;
            this.player1lb.Visible = false;
            // 
            // player2lb
            // 
            this.player2lb.BackColor = System.Drawing.SystemColors.Window;
            this.player2lb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player2lb.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2lb.FormattingEnabled = true;
            this.player2lb.ItemHeight = 23;
            this.player2lb.Location = new System.Drawing.Point(400, 125);
            this.player2lb.Name = "player2lb";
            this.player2lb.Size = new System.Drawing.Size(80, 207);
            this.player2lb.TabIndex = 9;
            this.player2lb.Visible = false;
            // 
            // back
            // 
            this.back.Image = global::Balda.Properties.Resources.button_black_repeat;
            this.back.Location = new System.Drawing.Point(391, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 50);
            this.back.TabIndex = 11;
            this.back.UseVisualStyleBackColor = true;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Exitbbtn
            // 
            this.Exitbbtn.Image = global::Balda.Properties.Resources.button_cancel__1_;
            this.Exitbbtn.Location = new System.Drawing.Point(447, 12);
            this.Exitbbtn.Name = "Exitbbtn";
            this.Exitbbtn.Size = new System.Drawing.Size(50, 50);
            this.Exitbbtn.TabIndex = 10;
            this.Exitbbtn.UseVisualStyleBackColor = true;
            this.Exitbbtn.Click += new System.EventHandler(this.Exitbbtn_Click);
            // 
            // nameplayer1
            // 
            this.nameplayer1.AutoSize = true;
            this.nameplayer1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameplayer1.Location = new System.Drawing.Point(12, 94);
            this.nameplayer1.Name = "nameplayer1";
            this.nameplayer1.Size = new System.Drawing.Size(0, 28);
            this.nameplayer1.TabIndex = 12;
            // 
            // nameplayer2
            // 
            this.nameplayer2.AutoSize = true;
            this.nameplayer2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameplayer2.Location = new System.Drawing.Point(395, 94);
            this.nameplayer2.Name = "nameplayer2";
            this.nameplayer2.Size = new System.Drawing.Size(0, 28);
            this.nameplayer2.TabIndex = 13;
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score1.Location = new System.Drawing.Point(12, 350);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(84, 26);
            this.Score1.TabIndex = 14;
            this.Score1.Text = "Очки = 0";
            this.Score1.Visible = false;
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score2.Location = new System.Drawing.Point(388, 350);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(84, 26);
            this.Score2.TabIndex = 15;
            this.Score2.Text = "Очки = 0";
            this.Score2.Visible = false;
            // 
            // inpWORD
            // 
            this.inpWORD.AutoSize = true;
            this.inpWORD.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpWORD.Location = new System.Drawing.Point(169, 82);
            this.inpWORD.Name = "inpWORD";
            this.inpWORD.Size = new System.Drawing.Size(173, 33);
            this.inpWORD.TabIndex = 16;
            this.inpWORD.Text = "Введите букву";
            this.inpWORD.Visible = false;
            // 
            // inputt
            // 
            this.inputt.AutoSize = true;
            this.inputt.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputt.Location = new System.Drawing.Point(169, 83);
            this.inputt.Name = "inputt";
            this.inputt.Size = new System.Drawing.Size(189, 33);
            this.inputt.TabIndex = 17;
            this.inputt.Text = "Выделите слово";
            this.inputt.Visible = false;
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player.Location = new System.Drawing.Point(203, 34);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(0, 35);
            this.player.TabIndex = 18;
            // 
            // tbWORD
            // 
            this.tbWORD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbWORD.Enabled = false;
            this.tbWORD.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWORD.Location = new System.Drawing.Point(125, 380);
            this.tbWORD.Name = "tbWORD";
            this.tbWORD.ReadOnly = true;
            this.tbWORD.Size = new System.Drawing.Size(250, 33);
            this.tbWORD.TabIndex = 19;
            this.tbWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWORD.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Balda.Properties.Resources._13_1712_oboi_list_v_kletochku_1280x800;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.tbWORD);
            this.Controls.Add(this.player);
            this.Controls.Add(this.inputt);
            this.Controls.Add(this.inpWORD);
            this.Controls.Add(this.Score2);
            this.Controls.Add(this.Score1);
            this.Controls.Add(this.nameplayer2);
            this.Controls.Add(this.nameplayer1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Exitbbtn);
            this.Controls.Add(this.player2lb);
            this.Controls.Add(this.player1lb);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.beginn);
            this.Name = "Form1";
            this.Text = "БАЛДА";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginn;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.ListBox player1lb;
        private System.Windows.Forms.ListBox player2lb;
        private System.Windows.Forms.Button Exitbbtn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label nameplayer1;
        private System.Windows.Forms.Label nameplayer2;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.Label inpWORD;
        private System.Windows.Forms.Label inputt;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.TextBox tbWORD;
    }
}

