using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Microsoft.Xaml.Behaviors;
using System.Windows.Media.Animation;

namespace BirdViewer
{
    class twoParams
    {
        Node curNode;
        string strParam;
    }
    public class ViewModel : INotifyPropertyChanged
    {
        static public string curdir = AppDomain.CurrentDomain.BaseDirectory;
        static public string redfile = "/img/red.jpg";
        static public string yellowfile = "/img/yellow.png";
        private string currentName;
        private string currentText;
        public string CurrentText
        {
            get
            {
                return currentText;
            }
            set
            {
                currentText = value;
                OnPropertyChanged("CurrentText");
            }
        }
        public string CurrentName
        {
            get
            {
                return currentName;
            }
            set
            {
                currentName = value;
                OnPropertyChanged("CurrentName");
            }
        }
        private string currentImg;
        public string CurrentImg
        {
            get
            {
                return currentImg;
            }
            set
            {
                currentImg = value;
                OnPropertyChanged("CurrentImg");
            }
        }
        public ObservableCollection<Node> nodes { get; set; }
        public ViewModel()
        {
            Node Domain = new Node
            {
                Name = "Эукариоты",
                Description = "test1",
                ImageSource = curdir + redfile,
                Nodes = new ObservableCollection<Node>(),
                Parent = null,
                HiLevel = 7
            };
            Node Kingdom = new Node
            {
                Name = "Животные",
                Description = "test2",
                ImageSource = curdir + yellowfile,
                Nodes = new ObservableCollection<Node>(),
                HiLevel = 6
            };
            Node Phylum = new Node
            {
                Name = "Хордовые",
                Description = "test3",
                ImageSource = curdir + redfile,
                Nodes = new ObservableCollection<Node>(),
                HiLevel = 5
            };
            Node BioClass = new Node
            {
                Name = "Птицы",
                Description = "test4",
                ImageSource = curdir + yellowfile,
                Nodes = new ObservableCollection<Node>(),
                HiLevel = 4
            };
            Node Order = new Node
            {
                Name = "Пеликанообразные",
                Description = "test5",
                ImageSource = curdir + redfile,
                Nodes = new ObservableCollection<Node>(),
                HiLevel = 3
            };
            Node Family = new Node
            {
                Name = "Китоглавые",
                Description = "test6",
                ImageSource = curdir + yellowfile,
                Nodes = new ObservableCollection<Node>(),
                HiLevel = 2
            };
            Node Genus = new Node
            {
                Name = "Китоглавы",
                Description = "test7",
                ImageSource = curdir + redfile,
                Nodes = new ObservableCollection<Node>(),
                HiLevel = 1
            };
            Node Specie = new Node
            {
                Name = "Китоглав",
                Description = "test8",
                ImageSource = curdir + yellowfile,
                Nodes = null,
                HiLevel = 0
            };
            Domain.Nodes.Add(Kingdom);
            Kingdom.Nodes.Add(Phylum);
            Phylum.Nodes.Add(BioClass);
            BioClass.Nodes.Add(Order);
            Order.Nodes.Add(Family);
            Family.Nodes.Add(Genus);
            Genus.Nodes.Add(Specie);
            
            Specie.Parent = Genus;
            Genus.Parent = Family;
            Family.Parent = Order;
            Order.Parent = BioClass;
            BioClass.Parent = Phylum;
            Phylum.Parent = Kingdom;
            Kingdom.Parent = Domain;

            nodes = new ObservableCollection<Node>
            {
                Domain
            };
            CurrentText = string.Empty;
            CurrentImg = curdir + redfile;
            
        }
        public RelayCommand SelectDesc { get => new RelayCommand(onSelectDesc); }
        public RelayCommand RemoveItem { get => new RelayCommand(onItemRemove); }
        public RelayCommand SaveDesc { get => new RelayCommand(onSaveDesc); }
        public RelayCommand SaveName { get => new RelayCommand(onSaveName); }
        public RelayCommand AddItem { get => new RelayCommand(onAddNode); }
        public RelayCommand ChangeImg { get => new RelayCommand(onImgChange); }
        public void onSelectDesc(object obj)
        {
            CurrentText = ((Node)obj).Description;
            CurrentImg = ((Node)obj).ImageSource;
        }
        public void onSaveDesc(object obj)
        {
            if (obj is Node node)
                node.Description = CurrentText;
        }
        public void onSaveName(object obj)
        {
            if (obj is Node node)
                node.Name = CurrentName;
        }
        public void onItemRemove(object obj)
        {
            if (obj is Node node)
                if (node.Parent != null)
                    node.Parent.Nodes.Remove(node);
        }
        public void onAddNode(object obj)
        {
            if (obj is Node node)
            {
                if (node.HiLevel != 0 && !string.IsNullOrEmpty(currentName))
                {
                    Node newItem = new Node();
                    newItem.Name = CurrentName;
                    newItem.Description = "";
                    newItem.ImageSource = curdir + redfile;
                    newItem.Parent = node;
                    newItem.HiLevel = node.HiLevel - 1;
                    if (node.HiLevel != 1) 
                    {
                        newItem.Nodes = new ObservableCollection<Node>();
                    }
                    node.Nodes.Add(newItem);
                }
            }
        }
        public void onImgChange(object obj)
        {
            if (obj is Node node)
            {
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.FileName = "Изображение";
                dlg.DefaultExt = ".png";
                dlg.Filter = "Изображения (.png)|*.png";
                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    CurrentImg = dlg.FileName;
                }
                node.ImageSource = CurrentImg;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
    /*public class Domain : HierarchyElement
    {
        public ObservableCollection<Kingdom> Kingdoms { get; set; }
        public Domain() 
        { 
            Kingdoms = new ObservableCollection<Kingdom>(new[]
            {
                new Kingdom { Name = "Животные", Description = "test2", ImageSource = ViewModel.curdir + ViewModel.yellowfile}
            });
        }
        public override void RemoveItems(HierarchyElement item)
        {
            Kingdoms.Remove((Kingdom)item);
        }
    }
    public class Kingdom : HierarchyElement
    {
        public ObservableCollection<Phylum> Phylums { get; set; }
        public Kingdom() 
        { 
            Phylums = new ObservableCollection<Phylum>(new[]
            {
                new Phylum{ Name = "Хордовые", Description = "test3", ImageSource = ViewModel.curdir + ViewModel.redfile }
            });
        }
        public override void RemoveItems(HierarchyElement item)
        {
            Phylums.Remove((Phylum)item);
        }
    }
    public class Phylum : HierarchyElement
    {
        public ObservableCollection<BioClass> Classes { get; set; }
        public Phylum() 
        {
            Classes = new ObservableCollection<BioClass>(new[]
            {
                new BioClass{ Name = "Птицы", Description = "test4", ImageSource = ViewModel.curdir + ViewModel.yellowfile }
            });
        }
        public override void RemoveItems(HierarchyElement item)
        {
            Classes.Remove((BioClass)item);
        }
    }
    public class BioClass : HierarchyElement
    {
        public ObservableCollection<Order> Orders { get; set; }
        public BioClass() 
        {
            Orders = new ObservableCollection<Order>(new[]
            {
                new Order{ Name = "Пеликанообразные", Description = "test5", ImageSource = ViewModel.curdir + ViewModel.redfile }
            });
        }
        public override void RemoveItems(HierarchyElement item)
        {
            Orders.Remove((Order)item);
        }
    }
    public class Order : HierarchyElement
    {
        public ObservableCollection<Family> Families { get; set; }
        public Order() 
        {
            Families = new ObservableCollection<Family>(new[]
            {
                new Family{ Name = "Китоглавые", Description = "test6", ImageSource = ViewModel.curdir + ViewModel.yellowfile }
            });
        }
        public override void RemoveItems(HierarchyElement item)
        {
            Families.Remove((Family)item);
        }
    }
    public class Family : HierarchyElement
    {
        public ObservableCollection<Genus> Genera { get; set; }
        public Family()
        {
            Genera = new ObservableCollection<Genus>(new[]{
                new Genus{ Name = "Китоглавы", Description = "test7", ImageSource = ViewModel.curdir + ViewModel.redfile }
            });
        }
        public override void RemoveItems(HierarchyElement item)
        {
            Genera.Remove((Genus)item);
        }
    }
    public class Genus : HierarchyElement
    {
        public ObservableCollection<HierarchyElement> Species { get; set; }
        public Genus() { 
            Species = new ObservableCollection<HierarchyElement>(new[]{
                new HierarchyElement{ Name = "Китоглав", Description = "test8", ImageSource = ViewModel.curdir + ViewModel.yellowfile }
            });
        }
        public override void RemoveItems(HierarchyElement item)
        {
            Species.Remove(item);
        }
    }*/
    public class Node : INotifyPropertyChanged
    {
        private string name;
        private string description;
        private string imageSource;
        private int hiLevel;
        public ObservableCollection<Node> Nodes { get; set; }
        public Node Parent;
        public string Name {
            get {
                return name; 
            }
            set {
                name = value;
                OnPropertyChanged("Name");
            } 
        }
        public string Description {
            get {
                return description; 
            }
            set {
                description = value;
                OnPropertyChanged("Description");
            } 
        }
        public string ImageSource {
            get
            {
                return imageSource;
            }
            set
            {
                imageSource = value;
                OnPropertyChanged("ImageSource");
            }
        }
        public int HiLevel
        {
            get
            {
                return hiLevel;
            }
            set
            {
                hiLevel = value;
                OnPropertyChanged("HiLevel");
            }
        }
        public virtual void RemoveItems(Node item) { }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
