namespace Balda
{
    partial class Form3
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
            this.NewGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.NewGame.FlatAppearance.BorderSize = 2;
            this.NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGame.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGame.Location = new System.Drawing.Point(169, 252);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(176, 51);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "Новая игра";
            this.NewGame.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Exit.FlatAppearance.BorderSize = 2;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(169, 333);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(176, 51);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Balda.Properties.Resources._13_1712_oboi_list_v_kletochku_1280x8001;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewGame);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Exit;
    }
}