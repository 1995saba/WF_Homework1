﻿namespace CV
{
    partial class FormCV
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
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(75, 109);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(138, 23);
            this.button.TabIndex = 0;
            this.button.Text = "Нажмите сюда";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // FormCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button);
            this.Name = "FormCV";
            this.Text = "Резюме";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
    }
}

