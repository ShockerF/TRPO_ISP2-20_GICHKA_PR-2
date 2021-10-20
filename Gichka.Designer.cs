
namespace ТРПО_ИСП2_20_Гичка_ПР__2
{
    partial class pract
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
            this.XText = new System.Windows.Forms.TextBox();
            this.YText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBoxG = new System.Windows.Forms.RichTextBox();
            this.table = new System.Windows.Forms.Panel();
            this.UZ = new System.Windows.Forms.RadioButton();
            this.UY = new System.Windows.Forms.RadioButton();
            this.UX = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // XText
            // 
            this.XText.Location = new System.Drawing.Point(50, 65);
            this.XText.Name = "XText";
            this.XText.Size = new System.Drawing.Size(145, 20);
            this.XText.TabIndex = 0;
            // 
            // YText
            // 
            this.YText.Location = new System.Drawing.Point(50, 106);
            this.YText.Name = "YText";
            this.YText.Size = new System.Drawing.Size(145, 20);
            this.YText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y=";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "maxabs";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxG
            // 
            this.richTextBoxG.Location = new System.Drawing.Point(27, 183);
            this.richTextBoxG.Name = "richTextBoxG";
            this.richTextBoxG.Size = new System.Drawing.Size(295, 260);
            this.richTextBoxG.TabIndex = 7;
            this.richTextBoxG.Text = "";
            // 
            // table
            // 
            this.table.Controls.Add(this.UZ);
            this.table.Controls.Add(this.UY);
            this.table.Controls.Add(this.checkBox1);
            this.table.Controls.Add(this.UX);
            this.table.Location = new System.Drawing.Point(216, 41);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(106, 119);
            this.table.TabIndex = 8;
            // 
            // UZ
            // 
            this.UZ.AutoSize = true;
            this.UZ.Location = new System.Drawing.Point(14, 88);
            this.UZ.Name = "UZ";
            this.UZ.Size = new System.Drawing.Size(50, 17);
            this.UZ.TabIndex = 2;
            this.UZ.TabStop = true;
            this.UZ.Text = "fx=ex";
            this.UZ.UseVisualStyleBackColor = true;
            // 
            // UY
            // 
            this.UY.AutoSize = true;
            this.UY.Location = new System.Drawing.Point(14, 65);
            this.UY.Name = "UY";
            this.UY.Size = new System.Drawing.Size(50, 17);
            this.UY.TabIndex = 1;
            this.UY.TabStop = true;
            this.UY.Text = "fx=x2";
            this.UY.UseVisualStyleBackColor = true;
            // 
            // UX
            // 
            this.UX.AutoSize = true;
            this.UX.Location = new System.Drawing.Point(14, 42);
            this.UX.Name = "UX";
            this.UX.Size = new System.Drawing.Size(61, 17);
            this.UX.TabIndex = 0;
            this.UX.TabStop = true;
            this.UX.Text = "fx=sh(x)";
            this.UX.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "ПУСК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.richTextBoxG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YText);
            this.Controls.Add(this.XText);
            this.Name = "pract";
            this.Text = "Практическая работа №2";
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XText;
        private System.Windows.Forms.TextBox YText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBoxG;
        private System.Windows.Forms.Panel table;
        private System.Windows.Forms.RadioButton UZ;
        private System.Windows.Forms.RadioButton UY;
        private System.Windows.Forms.RadioButton UX;
        private System.Windows.Forms.Button button1;
    }
}

