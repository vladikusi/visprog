using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace _3
{
    public partial class MosaicPanno : Form
    {
        private string curdir = AppDomain.CurrentDomain.BaseDirectory;
        private string basefilename = "/img/red.jpg";
        private string jsonfilename = "/saves/save.json";
        public List<Button> buttons = new List<Button>();
        private Dictionary<string, string> imageSrcs = new Dictionary<string, string>();
        int in_x = 50, in_y = 62, w = 80, h = 80;
        public MosaicPanno()
        {
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    var button = new Button();
                    button.Name = "ImgButton " + (1 + j * 5 + i);
                    button.Text = "#" + (1 + j * 5 + i);
                    button.Location = new Point(in_x + i * 80, in_y + j * 80);
                    button.Size = new Size(w, h);
                    button.TabIndex = 2 + j * 5 + i;
                    button.Click += new EventHandler(OnImButton_Click);
                    if (File.Exists(curdir + basefilename) && !File.Exists(curdir + jsonfilename))
                    {
                        imageSrcs[button.Name] = curdir + basefilename;
                    }
                    buttons.Add(button);
                }
            }
            if (File.Exists(curdir + jsonfilename))
                loadPicNames();
            else
                savePicNames();
            loadPics();
            foreach (var button in buttons)
                Controls.Add(button);
            InitializeComponent();
            SaveName.MaxLength = 12;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            jsonfilename = "/saves/" + SaveName.Text + ".json";
            if (SaveName.Text == "")
            {
                MessageBox.Show("Слишком мало символов", "Ошибка");
                return;
            }
            savePicNames();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            jsonfilename = "/saves/" + SaveName.Text + ".json";
            if (File.Exists(curdir + jsonfilename))
            {
                loadPicNames();
                loadPics();
                return;
            }
            MessageBox.Show("Такого файла не существует", "Ошибка");
        }

        private void OnImButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = curdir + "/img";
            openFileDialog.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|Все файлы (*.*)|*.*";
            openFileDialog.FilterIndex = 3;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    imageSrcs[((Button)sender).Name] = openFileDialog.FileName;
                    ((Button)sender).BackgroundImage = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        public void savePicNames()
        {
            string jsonString = JsonSerializer.Serialize(imageSrcs);
            File.WriteAllText(curdir + jsonfilename, jsonString);
        }
        public void loadPicNames()
        {
            string jsonString = File.ReadAllText(curdir + jsonfilename);
            imageSrcs = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
        }
        public void loadPics()
        {
            bool flag = false;
            foreach(var button in buttons)
            {
                if (imageSrcs.ContainsKey(button.Name))
                {
                    if (File.Exists(imageSrcs[button.Name]))
                        button.BackgroundImage = Image.FromFile(imageSrcs[button.Name]);
                    else
                        flag = true;
                }
            }
            if (flag)
            {
                MessageBox.Show("Как минимум одного файла изображения не существует", "Ошибка");
            }
        }

    }
}
