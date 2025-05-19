namespace dz1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.arg1 = new System.Windows.Forms.Label();
            this.arg2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.spisok = new System.Windows.Forms.Label();
            this.skip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 4;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(23, 144);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(126, 21);
            this.go.TabIndex = 5;
            this.go.Text = "Выполнить";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.goClick);
            // 
            // arg1
            // 
            this.arg1.AutoSize = true;
            this.arg1.Location = new System.Drawing.Point(206, 19);
            this.arg1.Name = "arg1";
            this.arg1.Size = new System.Drawing.Size(95, 13);
            this.arg1.TabIndex = 6;
            this.arg1.Text = "первый аргумент";
            // 
            // arg2
            // 
            this.arg2.AutoSize = true;
            this.arg2.Location = new System.Drawing.Point(206, 57);
            this.arg2.Name = "arg2";
            this.arg2.Size = new System.Drawing.Size(92, 13);
            this.arg2.TabIndex = 7;
            this.arg2.Text = "второй аргумент";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(206, 206);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(58, 13);
            this.result.TabIndex = 8;
            this.result.Text = "результат";
            // 
            // spisok
            // 
            this.spisok.AutoSize = true;
            this.spisok.Location = new System.Drawing.Point(206, 102);
            this.spisok.Name = "spisok";
            this.spisok.Size = new System.Drawing.Size(77, 13);
            this.spisok.TabIndex = 9;
            this.spisok.Text = "мат операция";
            // 
            // skip
            // 
            this.skip.Location = new System.Drawing.Point(23, 259);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(126, 26);
            this.skip.TabIndex = 10;
            this.skip.Text = "Вызов второй формы";
            this.skip.UseVisualStyleBackColor = true;
            this.skip.Click += new System.EventHandler(this.ButtonSkipClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.skip);
            this.Controls.Add(this.spisok);
            this.Controls.Add(this.result);
            this.Controls.Add(this.arg2);
            this.Controls.Add(this.arg1);
            this.Controls.Add(this.go);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Label arg1;
        private System.Windows.Forms.Label arg2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label spisok;
        private System.Windows.Forms.Button skip;
    }
}

