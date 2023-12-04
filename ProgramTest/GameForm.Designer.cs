namespace ProgramTest
{
    partial class GameForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainButton = new System.Windows.Forms.Button();
            this.SecondaryPanel = new System.Windows.Forms.Panel();
            this.MainLabelText = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SecondaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(8)))), ((int)(((byte)(24)))));
            this.MainPanel.Controls.Add(this.MainButton);
            this.MainPanel.Controls.Add(this.SecondaryPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // MainButton
            // 
            this.MainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainButton.Location = new System.Drawing.Point(339, 326);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(155, 50);
            this.MainButton.TabIndex = 1;
            this.MainButton.Text = "Начать";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            
            // 
            // SecondaryPanel
            // 
            this.SecondaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.SecondaryPanel.Controls.Add(this.MainLabelText);
            this.SecondaryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondaryPanel.Location = new System.Drawing.Point(0, 0);
            this.SecondaryPanel.Name = "SecondaryPanel";
            this.SecondaryPanel.Size = new System.Drawing.Size(800, 100);
            this.SecondaryPanel.TabIndex = 0;
            // 
            // MainLabelText
            // 
            this.MainLabelText.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabelText.ForeColor = System.Drawing.Color.White;
            this.MainLabelText.Location = new System.Drawing.Point(0, 0);
            this.MainLabelText.Name = "MainLabelText";
            this.MainLabelText.Size = new System.Drawing.Size(800, 100);
            this.MainLabelText.TabIndex = 0;
            this.MainLabelText.Text = "Главное меню";
            this.MainLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "GameForm";
            this.Text = "Программа которая в разработке";
            this.MainPanel.ResumeLayout(false);
            this.SecondaryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SecondaryPanel;
        private System.Windows.Forms.Label MainLabelText;
        private System.Windows.Forms.Button MainButton;
    }
}

