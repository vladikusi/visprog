using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        private clib.SCompleter sCompleter1;
        public Form1()
        {
            sCompleter1 = new clib.SCompleter();
            sCompleter1.Location = new Point(179, 154);
            sCompleter1.Name = "sCompleter1";
            sCompleter1.Size = new Size(450, 58);
            sCompleter1.TabIndex = 0;
            sCompleter1.addCollection("How", new List<string>
            {
                "какой сегодня праздник",
                "какой праздник 29 октября",
                "как отдыхаем в ноябре",
                "как варить кукурузу",
                "как отрастить хвост",
                "как варить гречку",
                "как варить гречу и получить гречку",
                "как"
            });
            sCompleter1.addCollection("Where", new List<string>
            {
                "где посылка",
                "где ближайшая аптека",
                "где я",
                "где погулять в Урюпинске",
                "где трамвай",
                "где жить",
                "где шаверма"
            });
            sCompleter1.addCollection("Who", new List<string>
            {
                "кто звонил",
                "кто выиграл там-то там-то",
                "кто такой сигма",
                "кто победил где-то там",
                "кто такой меломан",
                "кто сегодня умер",
                "Кто хочет стать миллионером? (телеигра)",
                "кто я"
            });
            sCompleter1.setCollection("How");
            
            Controls.Add(sCompleter1);
            InitializeComponent();
        }
        private void butHow(object sender, EventArgs e)
        {
            sCompleter1.setCollection("How");
            Status.Text = "Коллекция: " + sCompleter1.getCurColName();
        }
        private void butWhere(object sender, EventArgs e)
        {
            sCompleter1.setCollection("Where");
            Status.Text = "Коллекция: " + sCompleter1.getCurColName();
        }
        private void butWho(object sender, EventArgs e)
        {
            sCompleter1.setCollection("Who");
            Status.Text = "Коллекция: " + sCompleter1.getCurColName();
        }


    }
}
