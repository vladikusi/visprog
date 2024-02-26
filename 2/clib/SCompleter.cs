using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clib
{
    public partial class SCompleter: UserControl
    {
        private TextBox textBox1;
        private Dictionary<string, AutoCompleteStringCollection> collections;
        private string curname = "";
        public SCompleter()
        {
            collections = new Dictionary<string, AutoCompleteStringCollection>();
            textBox1 = new TextBox();
            collections.Add("Base Collection", new AutoCompleteStringCollection());
            collections["Base Collection"].AddRange(new string[] {});
            textBox1.AutoCompleteCustomSource = collections["Base Collection"];
            curname = "Base Collection";
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.Location = new Point(35, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 20);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            Controls.Add(textBox1);
            InitializeComponent();
        }

        public void setCollection(string name)
        {
            if (collections.ContainsKey(name))
            {
                textBox1.AutoCompleteCustomSource = collections[name];
                curname = name;
            }
        }
        
        public void addCollection(string name, List<string> list)
        {
            if (!collections.ContainsKey(name))
            {
                collections.Add(name, new AutoCompleteStringCollection());
                foreach (var item in list)
                    collections[name].Add(item);
            }
        }

        public void removeCollection(string name)
        {
            if (collections.ContainsKey(name) && curname != name)
                collections.Remove(name);
            else
                MessageBox.Show(
                    "Попытка удалить используемый словарь подсказок",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
        }

        public Dictionary<string, AutoCompleteStringCollection> getCollections()
        {
            return collections;
        }

        public AutoCompleteStringCollection getCurrentCollection()
        {
            if (collections.ContainsKey(curname))
                return collections[curname];
            return null;
        }

        public string getCurColName()
        {
            return curname;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SCompleter_Load(object sender, EventArgs e)
        {

        }
    }
}
