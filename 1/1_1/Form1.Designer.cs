namespace _1_1
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
            this.butperc = new System.Windows.Forms.Button();
            this.butCE = new System.Windows.Forms.Button();
            this.butC = new System.Windows.Forms.Button();
            this.butbackspace = new System.Windows.Forms.Button();
            this.butdivide = new System.Windows.Forms.Button();
            this.butsqrt = new System.Windows.Forms.Button();
            this.butsqr = new System.Windows.Forms.Button();
            this.butxth = new System.Windows.Forms.Button();
            this.butmultiply = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.butsubstract = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.butplus = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.butequals = new System.Windows.Forms.Button();
            this.butcomma = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.butplssub = new System.Windows.Forms.Button();
            this.butMC = new System.Windows.Forms.Button();
            this.butMR = new System.Windows.Forms.Button();
            this.butMinc = new System.Windows.Forms.Button();
            this.butMdec = new System.Windows.Forms.Button();
            this.butMS = new System.Windows.Forms.Button();
            this.labelCalcMode = new System.Windows.Forms.Label();
            this.butSettings = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.journalTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.journalTab.SuspendLayout();
            this.historyTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // butperc
            // 
            this.butperc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butperc.Location = new System.Drawing.Point(1, 256);
            this.butperc.Margin = new System.Windows.Forms.Padding(0);
            this.butperc.Name = "butperc";
            this.butperc.Size = new System.Drawing.Size(64, 64);
            this.butperc.TabIndex = 0;
            this.butperc.Text = "%";
            this.butperc.UseVisualStyleBackColor = false;
            this.butperc.Click += new System.EventHandler(this.butnumClick);
            // 
            // butCE
            // 
            this.butCE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butCE.Location = new System.Drawing.Point(65, 256);
            this.butCE.Margin = new System.Windows.Forms.Padding(0);
            this.butCE.Name = "butCE";
            this.butCE.Size = new System.Drawing.Size(64, 64);
            this.butCE.TabIndex = 1;
            this.butCE.Text = "CE";
            this.butCE.UseVisualStyleBackColor = false;
            this.butCE.Click += new System.EventHandler(this.butclearClick);
            // 
            // butC
            // 
            this.butC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butC.Location = new System.Drawing.Point(129, 256);
            this.butC.Margin = new System.Windows.Forms.Padding(0);
            this.butC.Name = "butC";
            this.butC.Size = new System.Drawing.Size(64, 64);
            this.butC.TabIndex = 2;
            this.butC.Text = "C";
            this.butC.UseVisualStyleBackColor = false;
            this.butC.Click += new System.EventHandler(this.butclearClick);
            // 
            // butbackspace
            // 
            this.butbackspace.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butbackspace.Location = new System.Drawing.Point(193, 256);
            this.butbackspace.Margin = new System.Windows.Forms.Padding(0);
            this.butbackspace.Name = "butbackspace";
            this.butbackspace.Size = new System.Drawing.Size(64, 64);
            this.butbackspace.TabIndex = 3;
            this.butbackspace.Text = "⌫";
            this.butbackspace.UseVisualStyleBackColor = false;
            this.butbackspace.Click += new System.EventHandler(this.buteraseClick);
            // 
            // butdivide
            // 
            this.butdivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butdivide.Location = new System.Drawing.Point(193, 320);
            this.butdivide.Margin = new System.Windows.Forms.Padding(0);
            this.butdivide.Name = "butdivide";
            this.butdivide.Size = new System.Drawing.Size(64, 64);
            this.butdivide.TabIndex = 7;
            this.butdivide.Text = "÷";
            this.butdivide.UseVisualStyleBackColor = false;
            this.butdivide.Click += new System.EventHandler(this.butnumClick);
            // 
            // butsqrt
            // 
            this.butsqrt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butsqrt.Location = new System.Drawing.Point(129, 320);
            this.butsqrt.Margin = new System.Windows.Forms.Padding(0);
            this.butsqrt.Name = "butsqrt";
            this.butsqrt.Size = new System.Drawing.Size(64, 64);
            this.butsqrt.TabIndex = 6;
            this.butsqrt.Text = "√";
            this.butsqrt.UseVisualStyleBackColor = false;
            this.butsqrt.Click += new System.EventHandler(this.butnumClick);
            // 
            // butsqr
            // 
            this.butsqr.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butsqr.Location = new System.Drawing.Point(65, 320);
            this.butsqr.Margin = new System.Windows.Forms.Padding(0);
            this.butsqr.Name = "butsqr";
            this.butsqr.Size = new System.Drawing.Size(64, 64);
            this.butsqr.TabIndex = 5;
            this.butsqr.Text = "x²";
            this.butsqr.UseVisualStyleBackColor = false;
            // 
            // butxth
            // 
            this.butxth.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butxth.Location = new System.Drawing.Point(1, 320);
            this.butxth.Margin = new System.Windows.Forms.Padding(0);
            this.butxth.Name = "butxth";
            this.butxth.Size = new System.Drawing.Size(64, 64);
            this.butxth.TabIndex = 4;
            this.butxth.Text = "1/x";
            this.butxth.UseVisualStyleBackColor = false;
            // 
            // butmultiply
            // 
            this.butmultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butmultiply.Location = new System.Drawing.Point(193, 384);
            this.butmultiply.Margin = new System.Windows.Forms.Padding(0);
            this.butmultiply.Name = "butmultiply";
            this.butmultiply.Size = new System.Drawing.Size(64, 64);
            this.butmultiply.TabIndex = 11;
            this.butmultiply.Text = "×";
            this.butmultiply.UseVisualStyleBackColor = false;
            this.butmultiply.Click += new System.EventHandler(this.butnumClick);
            // 
            // but9
            // 
            this.but9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but9.Location = new System.Drawing.Point(129, 384);
            this.but9.Margin = new System.Windows.Forms.Padding(0);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(64, 64);
            this.but9.TabIndex = 10;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = false;
            this.but9.Click += new System.EventHandler(this.butnumClick);
            // 
            // but8
            // 
            this.but8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but8.Location = new System.Drawing.Point(65, 384);
            this.but8.Margin = new System.Windows.Forms.Padding(0);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(64, 64);
            this.but8.TabIndex = 9;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = false;
            this.but8.Click += new System.EventHandler(this.butnumClick);
            // 
            // but7
            // 
            this.but7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but7.Location = new System.Drawing.Point(1, 384);
            this.but7.Margin = new System.Windows.Forms.Padding(0);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(64, 64);
            this.but7.TabIndex = 8;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = false;
            this.but7.Click += new System.EventHandler(this.butnumClick);
            // 
            // butsubstract
            // 
            this.butsubstract.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butsubstract.Location = new System.Drawing.Point(193, 448);
            this.butsubstract.Margin = new System.Windows.Forms.Padding(0);
            this.butsubstract.Name = "butsubstract";
            this.butsubstract.Size = new System.Drawing.Size(64, 64);
            this.butsubstract.TabIndex = 15;
            this.butsubstract.Text = "-";
            this.butsubstract.UseVisualStyleBackColor = false;
            this.butsubstract.Click += new System.EventHandler(this.butnumClick);
            // 
            // but6
            // 
            this.but6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but6.Location = new System.Drawing.Point(129, 448);
            this.but6.Margin = new System.Windows.Forms.Padding(0);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(64, 64);
            this.but6.TabIndex = 14;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = false;
            this.but6.Click += new System.EventHandler(this.butnumClick);
            // 
            // but5
            // 
            this.but5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but5.Location = new System.Drawing.Point(65, 448);
            this.but5.Margin = new System.Windows.Forms.Padding(0);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(64, 64);
            this.but5.TabIndex = 13;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = false;
            this.but5.Click += new System.EventHandler(this.butnumClick);
            // 
            // but4
            // 
            this.but4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but4.Location = new System.Drawing.Point(1, 448);
            this.but4.Margin = new System.Windows.Forms.Padding(0);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(64, 64);
            this.but4.TabIndex = 12;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = false;
            this.but4.Click += new System.EventHandler(this.butnumClick);
            // 
            // butplus
            // 
            this.butplus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butplus.Location = new System.Drawing.Point(193, 512);
            this.butplus.Margin = new System.Windows.Forms.Padding(0);
            this.butplus.Name = "butplus";
            this.butplus.Size = new System.Drawing.Size(64, 64);
            this.butplus.TabIndex = 19;
            this.butplus.Text = "+";
            this.butplus.UseVisualStyleBackColor = false;
            this.butplus.Click += new System.EventHandler(this.butnumClick);
            // 
            // but3
            // 
            this.but3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but3.Location = new System.Drawing.Point(129, 512);
            this.but3.Margin = new System.Windows.Forms.Padding(0);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(64, 64);
            this.but3.TabIndex = 18;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = false;
            this.but3.Click += new System.EventHandler(this.butnumClick);
            // 
            // but2
            // 
            this.but2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but2.Location = new System.Drawing.Point(65, 512);
            this.but2.Margin = new System.Windows.Forms.Padding(0);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(64, 64);
            this.but2.TabIndex = 17;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = false;
            this.but2.Click += new System.EventHandler(this.butnumClick);
            // 
            // but1
            // 
            this.but1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but1.Location = new System.Drawing.Point(1, 512);
            this.but1.Margin = new System.Windows.Forms.Padding(0);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(64, 64);
            this.but1.TabIndex = 16;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = false;
            this.but1.Click += new System.EventHandler(this.butnumClick);
            // 
            // butequals
            // 
            this.butequals.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butequals.Location = new System.Drawing.Point(193, 576);
            this.butequals.Margin = new System.Windows.Forms.Padding(0);
            this.butequals.Name = "butequals";
            this.butequals.Size = new System.Drawing.Size(64, 64);
            this.butequals.TabIndex = 23;
            this.butequals.Text = "=";
            this.butequals.UseVisualStyleBackColor = false;
            this.butequals.Click += new System.EventHandler(this.butnumClick);
            // 
            // butcomma
            // 
            this.butcomma.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butcomma.Location = new System.Drawing.Point(129, 576);
            this.butcomma.Margin = new System.Windows.Forms.Padding(0);
            this.butcomma.Name = "butcomma";
            this.butcomma.Size = new System.Drawing.Size(64, 64);
            this.butcomma.TabIndex = 22;
            this.butcomma.Text = ",";
            this.butcomma.UseVisualStyleBackColor = false;
            this.butcomma.Click += new System.EventHandler(this.butnumClick);
            // 
            // but0
            // 
            this.but0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but0.Location = new System.Drawing.Point(65, 576);
            this.but0.Margin = new System.Windows.Forms.Padding(0);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(64, 64);
            this.but0.TabIndex = 21;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = false;
            this.but0.Click += new System.EventHandler(this.butnumClick);
            // 
            // butplssub
            // 
            this.butplssub.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butplssub.Location = new System.Drawing.Point(1, 576);
            this.butplssub.Margin = new System.Windows.Forms.Padding(0);
            this.butplssub.Name = "butplssub";
            this.butplssub.Size = new System.Drawing.Size(64, 64);
            this.butplssub.TabIndex = 20;
            this.butplssub.Text = "±";
            this.butplssub.UseVisualStyleBackColor = false;
            // 
            // butMC
            // 
            this.butMC.Location = new System.Drawing.Point(1, 224);
            this.butMC.Margin = new System.Windows.Forms.Padding(0);
            this.butMC.Name = "butMC";
            this.butMC.Size = new System.Drawing.Size(51, 32);
            this.butMC.TabIndex = 24;
            this.butMC.Text = "MC";
            this.butMC.UseVisualStyleBackColor = true;
            // 
            // butMR
            // 
            this.butMR.Location = new System.Drawing.Point(52, 224);
            this.butMR.Margin = new System.Windows.Forms.Padding(0);
            this.butMR.Name = "butMR";
            this.butMR.Size = new System.Drawing.Size(51, 32);
            this.butMR.TabIndex = 25;
            this.butMR.Text = "MR";
            this.butMR.UseVisualStyleBackColor = true;
            // 
            // butMinc
            // 
            this.butMinc.Location = new System.Drawing.Point(103, 224);
            this.butMinc.Margin = new System.Windows.Forms.Padding(0);
            this.butMinc.Name = "butMinc";
            this.butMinc.Size = new System.Drawing.Size(51, 32);
            this.butMinc.TabIndex = 26;
            this.butMinc.Text = "M+";
            this.butMinc.UseVisualStyleBackColor = true;
            // 
            // butMdec
            // 
            this.butMdec.Location = new System.Drawing.Point(154, 224);
            this.butMdec.Margin = new System.Windows.Forms.Padding(0);
            this.butMdec.Name = "butMdec";
            this.butMdec.Size = new System.Drawing.Size(51, 32);
            this.butMdec.TabIndex = 27;
            this.butMdec.Text = "M-";
            this.butMdec.UseVisualStyleBackColor = true;
            // 
            // butMS
            // 
            this.butMS.Location = new System.Drawing.Point(206, 224);
            this.butMS.Margin = new System.Windows.Forms.Padding(0);
            this.butMS.Name = "butMS";
            this.butMS.Size = new System.Drawing.Size(51, 32);
            this.butMS.TabIndex = 28;
            this.butMS.Text = "MS";
            this.butMS.UseVisualStyleBackColor = true;
            // 
            // labelCalcMode
            // 
            this.labelCalcMode.AutoSize = true;
            this.labelCalcMode.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalcMode.Location = new System.Drawing.Point(63, 14);
            this.labelCalcMode.Name = "labelCalcMode";
            this.labelCalcMode.Size = new System.Drawing.Size(94, 24);
            this.labelCalcMode.TabIndex = 29;
            this.labelCalcMode.Text = "Обычный";
            // 
            // butSettings
            // 
            this.butSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.butSettings.Location = new System.Drawing.Point(9, 12);
            this.butSettings.Margin = new System.Windows.Forms.Padding(0);
            this.butSettings.Name = "butSettings";
            this.butSettings.Size = new System.Drawing.Size(51, 32);
            this.butSettings.TabIndex = 30;
            this.butSettings.Text = "≡";
            this.butSettings.UseVisualStyleBackColor = true;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.journalTab);
            this.tabs.Controls.Add(this.historyTab);
            this.tabs.Location = new System.Drawing.Point(262, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(200, 627);
            this.tabs.TabIndex = 31;
            // 
            // journalTab
            // 
            this.journalTab.Controls.Add(this.label1);
            this.journalTab.Location = new System.Drawing.Point(4, 22);
            this.journalTab.Name = "journalTab";
            this.journalTab.Padding = new System.Windows.Forms.Padding(3);
            this.journalTab.Size = new System.Drawing.Size(192, 601);
            this.journalTab.TabIndex = 0;
            this.journalTab.Text = "Журнал";
            this.journalTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Журнала ещё нет";
            // 
            // historyTab
            // 
            this.historyTab.Controls.Add(this.label2);
            this.historyTab.Location = new System.Drawing.Point(4, 22);
            this.historyTab.Name = "historyTab";
            this.historyTab.Padding = new System.Windows.Forms.Padding(3);
            this.historyTab.Size = new System.Drawing.Size(192, 601);
            this.historyTab.TabIndex = 1;
            this.historyTab.Text = "Память";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Памяти ещё нет";
            // 
            // mainLabel
            // 
            this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(1, 70);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(255, 132);
            this.mainLabel.TabIndex = 32;
            this.mainLabel.Text = "0";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 641);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.butSettings);
            this.Controls.Add(this.labelCalcMode);
            this.Controls.Add(this.butMS);
            this.Controls.Add(this.butMdec);
            this.Controls.Add(this.butMinc);
            this.Controls.Add(this.butMR);
            this.Controls.Add(this.butMC);
            this.Controls.Add(this.butequals);
            this.Controls.Add(this.butcomma);
            this.Controls.Add(this.but0);
            this.Controls.Add(this.butplssub);
            this.Controls.Add(this.butplus);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.butsubstract);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.butmultiply);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.butdivide);
            this.Controls.Add(this.butsqrt);
            this.Controls.Add(this.butsqr);
            this.Controls.Add(this.butxth);
            this.Controls.Add(this.butbackspace);
            this.Controls.Add(this.butC);
            this.Controls.Add(this.butCE);
            this.Controls.Add(this.butperc);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.journalTab.ResumeLayout(false);
            this.journalTab.PerformLayout();
            this.historyTab.ResumeLayout(false);
            this.historyTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butperc;
        private System.Windows.Forms.Button butCE;
        private System.Windows.Forms.Button butC;
        private System.Windows.Forms.Button butbackspace;
        private System.Windows.Forms.Button butdivide;
        private System.Windows.Forms.Button butsqrt;
        private System.Windows.Forms.Button butsqr;
        private System.Windows.Forms.Button butxth;
        private System.Windows.Forms.Button butmultiply;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button butsubstract;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button butplus;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button butequals;
        private System.Windows.Forms.Button butcomma;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button butplssub;
        private System.Windows.Forms.Button butMC;
        private System.Windows.Forms.Button butMR;
        private System.Windows.Forms.Button butMinc;
        private System.Windows.Forms.Button butMdec;
        private System.Windows.Forms.Button butMS;
        private System.Windows.Forms.Label labelCalcMode;
        private System.Windows.Forms.Button butSettings;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage journalTab;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mainLabel;
    }
}

