namespace _2
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
            this.How = new System.Windows.Forms.Button();
            this.Where = new System.Windows.Forms.Button();
            this.Who = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // How
            // 
            this.How.Location = new System.Drawing.Point(12, 12);
            this.How.Name = "How";
            this.How.Size = new System.Drawing.Size(75, 23);
            this.How.TabIndex = 0;
            this.How.Text = "Как";
            this.How.UseVisualStyleBackColor = true;
            this.How.Click += new System.EventHandler(this.butHow);
            // 
            // Where
            // 
            this.Where.Location = new System.Drawing.Point(93, 12);
            this.Where.Name = "Where";
            this.Where.Size = new System.Drawing.Size(75, 23);
            this.Where.TabIndex = 1;
            this.Where.Text = "Где";
            this.Where.UseVisualStyleBackColor = true;
            this.Where.Click += new System.EventHandler(this.butWhere);
            // 
            // Who
            // 
            this.Who.Location = new System.Drawing.Point(174, 12);
            this.Who.Name = "Who";
            this.Who.Size = new System.Drawing.Size(75, 23);
            this.Who.TabIndex = 2;
            this.Who.Text = "Кто";
            this.Who.UseVisualStyleBackColor = true;
            this.Who.Click += new System.EventHandler(this.butWho);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(631, 17);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(90, 13);
            this.Status.TabIndex = 3;
            this.Status.Text = "Коллекция: How";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Who);
            this.Controls.Add(this.Where);
            this.Controls.Add(this.How);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button How;
        private System.Windows.Forms.Button Where;
        private System.Windows.Forms.Button Who;
        private System.Windows.Forms.Label Status;
    }
}

