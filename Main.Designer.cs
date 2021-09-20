namespace Элегантный_объект
{
    partial class Main
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
            this.pictureBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoard
            // 
            this.pictureBoard.ImageLocation = "";
            this.pictureBoard.Location = new System.Drawing.Point(0, 0);
            this.pictureBoard.Name = "pictureBoard";
            this.pictureBoard.Padding = new System.Windows.Forms.Padding(20);
            this.pictureBoard.Size = new System.Drawing.Size(360, 360);
            this.pictureBoard.TabIndex = 0;
            this.pictureBoard.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 362);
            this.Controls.Add(this.pictureBoard);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Элегантный объект";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoard;
    }
}

