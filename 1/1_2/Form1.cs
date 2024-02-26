using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2
{
    public partial class Form1 : Form
    {
        private Label mainLabel;
        public Form1()
        {
            InitializeComponent();
            Text = "Калькулятор";
            ClientSize = new Size(464, 641);
            Button butperc;
            Button butCE;
            Button butC;
            Button butbackspace;
            Button butsqrt;
            Button butsqr;
            Button butdivide;
            Button butxth;
            Button butmultiply;
            Button but9;
            Button but8;
            Button but7;
            Button butsubstract;
            Button but6;
            Button but5;
            Button but4;
            Button butplus;
            Button but3;
            Button but2;
            Button but1;
            Button butequals;
            Button butcomma;
            Button but0;
            Button butplssub;
            Button butMC;
            Button butMR;
            Button butMinc;
            Button butMdec;
            Button butMS;
            Label labelCalcMode;
            Button butSettings;
            TabControl tabs;
            TabPage journalTab;
            TabPage historyTab;
            Label label1;
            Label label2;
            butperc = new System.Windows.Forms.Button();
            butCE = new System.Windows.Forms.Button();
            butC = new System.Windows.Forms.Button();
            butbackspace = new System.Windows.Forms.Button();
            butdivide = new System.Windows.Forms.Button();
            butsqrt = new System.Windows.Forms.Button();
            butsqr = new System.Windows.Forms.Button();
            butxth = new System.Windows.Forms.Button();
            butmultiply = new System.Windows.Forms.Button();
            but9 = new System.Windows.Forms.Button();
            but8 = new System.Windows.Forms.Button();
            but7 = new System.Windows.Forms.Button();
            butsubstract = new System.Windows.Forms.Button();
            but6 = new System.Windows.Forms.Button();
            but5 = new System.Windows.Forms.Button();
            but4 = new System.Windows.Forms.Button();
            butplus = new System.Windows.Forms.Button();
            but3 = new System.Windows.Forms.Button();
            but2 = new System.Windows.Forms.Button();
            but1 = new System.Windows.Forms.Button();
            butequals = new System.Windows.Forms.Button();
            butcomma = new System.Windows.Forms.Button();
            but0 = new System.Windows.Forms.Button();
            butplssub = new System.Windows.Forms.Button();
            butMC = new System.Windows.Forms.Button();
            butMR = new System.Windows.Forms.Button();
            butMinc = new System.Windows.Forms.Button();
            butMdec = new System.Windows.Forms.Button();
            butMS = new System.Windows.Forms.Button();
            labelCalcMode = new System.Windows.Forms.Label();
            butSettings = new System.Windows.Forms.Button();
            tabs = new System.Windows.Forms.TabControl();
            journalTab = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            historyTab = new System.Windows.Forms.TabPage();
            label2 = new System.Windows.Forms.Label();
            mainLabel = new System.Windows.Forms.Label();
            // 
            // butperc
            // 
            butperc.BackColor = System.Drawing.SystemColors.ControlLight;
            butperc.Location = new System.Drawing.Point(1, 256);
            butperc.Margin = new System.Windows.Forms.Padding(0);
            butperc.Name = "butperc";
            butperc.Size = new System.Drawing.Size(64, 64);
            butperc.TabIndex = 0;
            butperc.Text = "%";
            butperc.UseVisualStyleBackColor = false;
            butperc.Click += new System.EventHandler(butnumClick);
            // 
            // butCE
            // 
            butCE.BackColor = System.Drawing.SystemColors.ControlLight;
            butCE.Location = new System.Drawing.Point(65, 256);
            butCE.Margin = new System.Windows.Forms.Padding(0);
            butCE.Name = "butCE";
            butCE.Size = new System.Drawing.Size(64, 64);
            butCE.TabIndex = 1;
            butCE.Text = "CE";
            butCE.UseVisualStyleBackColor = false;
            butCE.Click += new System.EventHandler(butclearClick);
            // 
            // butC
            // 
            butC.BackColor = System.Drawing.SystemColors.ControlLight;
            butC.Location = new System.Drawing.Point(129, 256);
            butC.Margin = new System.Windows.Forms.Padding(0);
            butC.Name = "butC";
            butC.Size = new System.Drawing.Size(64, 64);
            butC.TabIndex = 2;
            butC.Text = "C";
            butC.UseVisualStyleBackColor = false;
            butC.Click += new System.EventHandler(butclearClick);
            // 
            // butbackspace
            // 
            butbackspace.BackColor = System.Drawing.SystemColors.ControlLight;
            butbackspace.Location = new System.Drawing.Point(193, 256);
            butbackspace.Margin = new System.Windows.Forms.Padding(0);
            butbackspace.Name = "butbackspace";
            butbackspace.Size = new System.Drawing.Size(64, 64);
            butbackspace.TabIndex = 3;
            butbackspace.Text = "⌫";
            butbackspace.UseVisualStyleBackColor = false;
            butbackspace.Click += new System.EventHandler(buteraseClick);
            // 
            // butdivide
            // 
            butdivide.BackColor = System.Drawing.SystemColors.ControlLight;
            butdivide.Location = new System.Drawing.Point(193, 320);
            butdivide.Margin = new System.Windows.Forms.Padding(0);
            butdivide.Name = "butdivide";
            butdivide.Size = new System.Drawing.Size(64, 64);
            butdivide.TabIndex = 7;
            butdivide.Text = "÷";
            butdivide.UseVisualStyleBackColor = false;
            butdivide.Click += new System.EventHandler(butnumClick);
            // 
            // button6
            // 
            butsqrt.BackColor = System.Drawing.SystemColors.ControlLight;
            butsqrt.Location = new System.Drawing.Point(129, 320);
            butsqrt.Margin = new System.Windows.Forms.Padding(0);
            butsqrt.Name = "button6";
            butsqrt.Size = new System.Drawing.Size(64, 64);
            butsqrt.TabIndex = 6;
            butsqrt.Text = "√";
            butsqrt.UseVisualStyleBackColor = false;
            butsqrt.Click += new System.EventHandler(butnumClick);
            // 
            // button7
            // 
            butsqr.BackColor = System.Drawing.SystemColors.ControlLight;
            butsqr.Location = new System.Drawing.Point(65, 320);
            butsqr.Margin = new System.Windows.Forms.Padding(0);
            butsqr.Name = "button7";
            butsqr.Size = new System.Drawing.Size(64, 64);
            butsqr.TabIndex = 5;
            butsqr.Text = "x²";
            butsqr.UseVisualStyleBackColor = false;
            // 
            // butxth
            // 
            butxth.BackColor = System.Drawing.SystemColors.ControlLight;
            butxth.Location = new System.Drawing.Point(1, 320);
            butxth.Margin = new System.Windows.Forms.Padding(0);
            butxth.Name = "butxth";
            butxth.Size = new System.Drawing.Size(64, 64);
            butxth.TabIndex = 4;
            butxth.Text = "1/x";
            butxth.UseVisualStyleBackColor = false;
            // 
            // butmultiply
            // 
            butmultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            butmultiply.Location = new System.Drawing.Point(193, 384);
            butmultiply.Margin = new System.Windows.Forms.Padding(0);
            butmultiply.Name = "butmultiply";
            butmultiply.Size = new System.Drawing.Size(64, 64);
            butmultiply.TabIndex = 11;
            butmultiply.Text = "×";
            butmultiply.UseVisualStyleBackColor = false;
            butmultiply.Click += new System.EventHandler(butnumClick);
            // 
            // but9
            // 
            but9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            but9.Location = new System.Drawing.Point(129, 384);
            but9.Margin = new System.Windows.Forms.Padding(0);
            but9.Name = "but9";
            but9.Size = new System.Drawing.Size(64, 64);
            but9.TabIndex = 10;
            but9.Text = "9";
            but9.UseVisualStyleBackColor = false;
            but9.Click += new System.EventHandler(butnumClick);
            // 
            // but8
            // 
            but8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            but8.Location = new System.Drawing.Point(65, 384);
            but8.Margin = new System.Windows.Forms.Padding(0);
            but8.Name = "but8";
            but8.Size = new System.Drawing.Size(64, 64);
            but8.TabIndex = 9;
            but8.Text = "8";
            but8.UseVisualStyleBackColor = false;
            but8.Click += new System.EventHandler(butnumClick);
            // 
            // but7
            // 
            but7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            but7.Location = new System.Drawing.Point(1, 384);
            but7.Margin = new System.Windows.Forms.Padding(0);
            but7.Name = "but7";
            but7.Size = new System.Drawing.Size(64, 64);
            but7.TabIndex = 8;
            but7.Text = "7";
            but7.UseVisualStyleBackColor = false;
            but7.Click += new System.EventHandler(butnumClick);
            // 
            // butsubstract
            // 
            butsubstract.BackColor = System.Drawing.SystemColors.ControlLight;
            butsubstract.Location = new System.Drawing.Point(193, 448);
            butsubstract.Margin = new System.Windows.Forms.Padding(0);
            butsubstract.Name = "butsubstract";
            butsubstract.Size = new System.Drawing.Size(64, 64);
            butsubstract.TabIndex = 15;
            butsubstract.Text = "-";
            butsubstract.UseVisualStyleBackColor = false;
            butsubstract.Click += new System.EventHandler(butnumClick);
            // 
            // but6
            // 
            but6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            but6.Location = new System.Drawing.Point(129, 448);
            but6.Margin = new System.Windows.Forms.Padding(0);
            but6.Name = "but6";
            but6.Size = new System.Drawing.Size(64, 64);
            but6.TabIndex = 14;
            but6.Text = "6";
            but6.UseVisualStyleBackColor = false;
            but6.Click += new System.EventHandler(butnumClick);
            // 
            // but5
            // 
            but5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            but5.Location = new System.Drawing.Point(65, 448);
            but5.Margin = new System.Windows.Forms.Padding(0);
            but5.Name = "but5";
            but5.Size = new System.Drawing.Size(64, 64);
            but5.TabIndex = 13;
            but5.Text = "5";
            but5.UseVisualStyleBackColor = false;
            but5.Click += new System.EventHandler(butnumClick);
            // 
            // but4
            // 
            but4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            but4.Location = new System.Drawing.Point(1, 448);
            but4.Margin = new System.Windows.Forms.Padding(0);
            but4.Name = "but4";
            but4.Size = new System.Drawing.Size(64, 64);
            but4.TabIndex = 12;
            but4.Text = "4";
            but4.UseVisualStyleBackColor = false;
            but4.Click += new System.EventHandler(butnumClick);
            // 
            // butplus
            // 
            butplus.BackColor = System.Drawing.SystemColors.ControlLight;
            butplus.Location = new System.Drawing.Point(193, 512);
            butplus.Margin = new System.Windows.Forms.Padding(0);
            butplus.Name = "butplus";
            butplus.Size = new System.Drawing.Size(64, 64);
            butplus.TabIndex = 19;
            butplus.Text = "+";
            butplus.UseVisualStyleBackColor = false;
            butplus.Click += new System.EventHandler(butnumClick);
            // 
            // but3
            // 
            but3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            but3.Location = new System.Drawing.Point(129, 512);
            but3.Margin = new System.Windows.Forms.Padding(0);
            but3.Name = "but3";
            but3.Size = new System.Drawing.Size(64, 64);
            but3.TabIndex = 18;
            but3.Text = "3";
            but3.UseVisualStyleBackColor = false;
            but3.Click += new System.EventHandler(butnumClick);
            // 
            // but2
            // 
            but2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            but2.Location = new System.Drawing.Point(65, 512);
            but2.Margin = new System.Windows.Forms.Padding(0);
            but2.Name = "but2";
            but2.Size = new System.Drawing.Size(64, 64);
            but2.TabIndex = 17;
            but2.Text = "2";
            but2.UseVisualStyleBackColor = false;
            but2.Click += new System.EventHandler(butnumClick);
            // 
            // but1
            // 
            but1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            but1.Location = new System.Drawing.Point(1, 512);
            but1.Margin = new System.Windows.Forms.Padding(0);
            but1.Name = "but1";
            but1.Size = new System.Drawing.Size(64, 64);
            but1.TabIndex = 16;
            but1.Text = "1";
            but1.UseVisualStyleBackColor = false;
            but1.Click += new System.EventHandler(butnumClick);
            // 
            // butequals
            // 
            butequals.BackColor = System.Drawing.SystemColors.ControlLight;
            butequals.Location = new System.Drawing.Point(193, 576);
            butequals.Margin = new System.Windows.Forms.Padding(0);
            butequals.Name = "butequals";
            butequals.Size = new System.Drawing.Size(64, 64);
            butequals.TabIndex = 23;
            butequals.Text = "=";
            butequals.UseVisualStyleBackColor = false;
            butequals.Click += new System.EventHandler(butnumClick);
            // 
            // butcomma
            // 
            butcomma.BackColor = System.Drawing.SystemColors.ControlLightLight;
            butcomma.Location = new System.Drawing.Point(129, 576);
            butcomma.Margin = new System.Windows.Forms.Padding(0);
            butcomma.Name = "butcomma";
            butcomma.Size = new System.Drawing.Size(64, 64);
            butcomma.TabIndex = 22;
            butcomma.Text = ",";
            butcomma.UseVisualStyleBackColor = false;
            butcomma.Click += new System.EventHandler(butnumClick);
            // 
            // but0
            // 
            but0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            but0.Location = new System.Drawing.Point(65, 576);
            but0.Margin = new System.Windows.Forms.Padding(0);
            but0.Name = "but0";
            but0.Size = new System.Drawing.Size(64, 64);
            but0.TabIndex = 21;
            but0.Text = "0";
            but0.UseVisualStyleBackColor = false;
            but0.Click += new System.EventHandler(butnumClick);
            // 
            // butplssub
            // 
            butplssub.BackColor = System.Drawing.SystemColors.ControlLightLight;
            butplssub.Location = new System.Drawing.Point(1, 576);
            butplssub.Margin = new System.Windows.Forms.Padding(0);
            butplssub.Name = "butplssub";
            butplssub.Size = new System.Drawing.Size(64, 64);
            butplssub.TabIndex = 20;
            butplssub.Text = "±";
            butplssub.UseVisualStyleBackColor = false;
            // 
            // butMC
            // 
            butMC.Location = new System.Drawing.Point(1, 224);
            butMC.Margin = new System.Windows.Forms.Padding(0);
            butMC.Name = "butMC";
            butMC.Size = new System.Drawing.Size(51, 32);
            butMC.TabIndex = 24;
            butMC.Text = "MC";
            butMC.UseVisualStyleBackColor = true;
            // 
            // butMR
            // 
            butMR.Location = new System.Drawing.Point(52, 224);
            butMR.Margin = new System.Windows.Forms.Padding(0);
            butMR.Name = "butMR";
            butMR.Size = new System.Drawing.Size(51, 32);
            butMR.TabIndex = 25;
            butMR.Text = "MR";
            butMR.UseVisualStyleBackColor = true;
            // 
            // butMinc
            // 
            butMinc.Location = new System.Drawing.Point(103, 224);
            butMinc.Margin = new System.Windows.Forms.Padding(0);
            butMinc.Name = "butMinc";
            butMinc.Size = new System.Drawing.Size(51, 32);
            butMinc.TabIndex = 26;
            butMinc.Text = "M+";
            butMinc.UseVisualStyleBackColor = true;
            // 
            // butMdec
            // 
            butMdec.Location = new System.Drawing.Point(154, 224);
            butMdec.Margin = new System.Windows.Forms.Padding(0);
            butMdec.Name = "butMdec";
            butMdec.Size = new System.Drawing.Size(51, 32);
            butMdec.TabIndex = 27;
            butMdec.Text = "M-";
            butMdec.UseVisualStyleBackColor = true;
            // 
            // butMS
            // 
            butMS.Location = new System.Drawing.Point(206, 224);
            butMS.Margin = new System.Windows.Forms.Padding(0);
            butMS.Name = "butMS";
            butMS.Size = new System.Drawing.Size(51, 32);
            butMS.TabIndex = 28;
            butMS.Text = "MS";
            butMS.UseVisualStyleBackColor = true;
            // 
            // labelCalcMode
            // 
            labelCalcMode.AutoSize = true;
            labelCalcMode.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCalcMode.Location = new System.Drawing.Point(63, 14);
            labelCalcMode.Name = "labelCalcMode";
            labelCalcMode.Size = new System.Drawing.Size(94, 24);
            labelCalcMode.TabIndex = 29;
            labelCalcMode.Text = "Обычный";
            // 
            // butSettings
            // 
            butSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            butSettings.Location = new System.Drawing.Point(9, 12);
            butSettings.Margin = new System.Windows.Forms.Padding(0);
            butSettings.Name = "butSettings";
            butSettings.Size = new System.Drawing.Size(51, 32);
            butSettings.TabIndex = 30;
            butSettings.Text = "≡";
            butSettings.UseVisualStyleBackColor = true;
            // 
            // tabs
            // 
            tabs.Controls.Add(journalTab);
            tabs.Controls.Add(historyTab);
            tabs.Location = new System.Drawing.Point(262, 12);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new System.Drawing.Size(200, 627);
            tabs.TabIndex = 31;
            // 
            // journalTab
            // 
            journalTab.Controls.Add(label1);
            journalTab.Location = new System.Drawing.Point(4, 22);
            journalTab.Name = "journalTab";
            journalTab.Padding = new System.Windows.Forms.Padding(3);
            journalTab.Size = new System.Drawing.Size(192, 601);
            journalTab.TabIndex = 0;
            journalTab.Text = "Журнал";
            journalTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 13);
            label1.TabIndex = 0;
            label1.Text = "Журнала ещё нет";
            // 
            // historyTab
            // 
            historyTab.Controls.Add(label2);
            historyTab.Location = new System.Drawing.Point(4, 22);
            historyTab.Name = "historyTab";
            historyTab.Padding = new System.Windows.Forms.Padding(3);
            historyTab.Size = new System.Drawing.Size(192, 601);
            historyTab.TabIndex = 1;
            historyTab.Text = "Память";
            historyTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 3);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 13);
            label2.TabIndex = 1;
            label2.Text = "Памяти ещё нет";
            // 
            // mainLabel
            // 
            mainLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            mainLabel.Location = new System.Drawing.Point(1, 70);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new System.Drawing.Size(255, 132);
            mainLabel.TabIndex = 32;
            mainLabel.Text = "0";
            mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            Controls.Add(mainLabel);
            Controls.Add(tabs);
            Controls.Add(butSettings);
            Controls.Add(labelCalcMode);
            Controls.Add(butMS);
            Controls.Add(butMdec);
            Controls.Add(butMinc);
            Controls.Add(butMR);
            Controls.Add(butMC);
            Controls.Add(butequals);
            Controls.Add(butcomma);
            Controls.Add(but0);
            Controls.Add(butplssub);
            Controls.Add(butplus);
            Controls.Add(but3);
            Controls.Add(but2);
            Controls.Add(but1);
            Controls.Add(butsubstract);
            Controls.Add(but6);
            Controls.Add(but5);
            Controls.Add(but4);
            Controls.Add(butmultiply);
            Controls.Add(but9);
            Controls.Add(but8);
            Controls.Add(but7);
            Controls.Add(butdivide);
            Controls.Add(butsqrt);
            Controls.Add(butsqr);
            Controls.Add(butxth);
            Controls.Add(butbackspace);
            Controls.Add(butC);
            Controls.Add(butCE);
            Controls.Add(butperc);
        }
        private void butnumClick(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length < 42)
                mainLabel.Text += ((Button)sender).Text;
        }
        private void butclearClick(object sender, EventArgs e)
        {
            mainLabel.Text = string.Empty;
        }
        private void buteraseClick(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length > 0)
            {
                mainLabel.Text = mainLabel.Text.Remove(mainLabel.Text.Length - 1);
            }
        }
    }
}
