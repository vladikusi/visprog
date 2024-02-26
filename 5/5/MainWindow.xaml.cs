using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Security.Permissions;
using System.Net.Http.Headers;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;

namespace _5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private static FrameworkElement draggedItem;
        private static Point itemRelativePosition;
        public void AGI_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Данный объект назначается текущим передвигаемым
            draggedItem = (FrameworkElement)sender;
            //Сохраняется его текущая позиция
            itemRelativePosition = e.GetPosition(draggedItem);
            //Пометка что событие обработано и больше его обрабатывать не требуется
            e.Handled = true;
        }
        //Обработчик передвижения графического объекта
        private void MainCanvas_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            //Если передвигаемого объекта нет - закончить обработку события
            if (draggedItem == null)
                return;
            //Иначе - вычислить новые координаты относительно положения Canvas
            var newPos = e.GetPosition((Canvas)sender) - itemRelativePosition;
            //Установить требуемое смещение
            if (newPos.X > 0 && newPos.X < ((Canvas)sender).ActualWidth - draggedItem.ActualWidth)
                Canvas.SetLeft(draggedItem, newPos.X);
            if (newPos.Y > 0 && newPos.Y < ((Canvas)sender).ActualHeight - draggedItem.ActualHeight)
                Canvas.SetTop(draggedItem, newPos.Y);
            //Canvas захватывает мышь во избежание случайной реакции со стороны других элементов
            ((Canvas)sender).CaptureMouse();
            //Пометка что событие обработано и больше его обрабатывать не требуется
            e.Handled = true;
        }
        //Обработчик "отпускания" графического объекта
        private void MainCanvas_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //Если объект в данный момент переносился
            if (draggedItem != null)
            {
                //Объект отпускается
                draggedItem = null;
                //Canvas "отпускает" мышь
                ((Canvas)sender).ReleaseMouseCapture();
                //Пометка что событие обработано и больше его обрабатывать не требуется
                e.Handled = true;
            }
        }
    }
    public class ViewModel : INotifyPropertyChanged
    {
        private CustomWPFControl selectedItem;
        public CustomWPFControl SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }
        private int selectedIndex;
        public int SelectedIndex {
            get 
            {
                return selectedIndex;
            }
            set 
            { 
                selectedIndex = value;
                OnPropertyChanged("SelectedIndex");
            } 
        }
        public ObservableCollection<CustomWPFControl> CanvasElements { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel()
        {
            CanvasElements = new ObservableCollection<CustomWPFControl>();
        }
        public RelayCommand AddItem { get => new RelayCommand(onAddPressed); }
        public RelayCommand RemItem { get => new RelayCommand(onRemovePressed); }
        public void onAddPressed(object obj)
        {
            if (SelectedIndex == 0)
                CanvasElements.Add(new CloseButton(CanvasElements));
            else if (SelectedIndex == 1)
                CanvasElements.Add(new PrettyText());
            else if (SelectedIndex == 2)
                CanvasElements.Add(new UltraImage());
        }
        public void onRemovePressed(object obj) 
        {
            if (CanvasElements.Count > 0 && SelectedItem != null)
            {
                CanvasElements.Remove(SelectedItem);
                if (CanvasElements.Count > 0)
                    SelectedItem = CanvasElements[0];
            }
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
    public class CloseButton : CustomWPFControl
    {
        public ObservableCollection<CustomWPFControl> ParentCollection;
        public CloseButton(ObservableCollection<CustomWPFControl> parentCollection)
        {
            ParentCollection = parentCollection;
            Name = "Кнопка закрытия";
            Button thisButton = new Button();
            thisButton.Content = "Закрыть";

            thisButton.PreviewMouseDoubleClick += ondClick;
            thisButton.PreviewMouseRightButtonDown += onRMouse;

            ffElement = thisButton;
        }

        public void ondClick(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                window.Close();
            }
        }
        public void onRMouse(object sender, MouseEventArgs e)
        {
            ParentCollection.Remove(this);
        }
    }

    public class PrettyText : CustomWPFControl
    {
        private string curText;
        public string CurText
        {
            get
            {
                return curText;
            }
            set
            {
                curText = value;
                OnPropertyChanged("CurText");
            }
        }
        public PrettyText()
        {
            Name = "Циркумдукция";
            CurText = "Циркумдукция";
            Border thisBorder = new Border();
            thisBorder.BorderBrush = Brushes.MidnightBlue;
            thisBorder.BorderThickness = new Thickness(3);
            TextBlock thisTextBlock = new TextBlock();
            Binding binding = new Binding("CurText");
            thisTextBlock.SetBinding(TextBlock.TextProperty, binding);
            TextBlock.SetLineStackingStrategy(thisTextBlock, LineStackingStrategy.BlockLineHeight);
            TextBlock.SetLineHeight(thisTextBlock, 12);
            thisBorder.Child = thisTextBlock;
            ffElement = thisBorder;
            ffElement.PreviewMouseRightButtonDown += onRMouse;
        }

        public void onRMouse(object sender, MouseEventArgs e)
        {
            if (string.Compare(CurText, "Циркумдукция") == 0)
            {
                CurText = "д\nе\nз\nо\nк\nс\nи\nр\nи\nб\nо\nн\nу\nк\nл\nе\nи\nн\nо\nв\nа\nя";
            }
            else
                CurText = "Циркумдукция";
        }
    }

    public class UltraImage : CustomWPFControl
    {
        static public string curdir = AppDomain.CurrentDomain.BaseDirectory;
        static public string Arthur = curdir + "/img/ArthurDent.jpg";
        static public string Enterprise = curdir + "/img/Enterprise.jpg";
        private string curSource;
        public string CurSource
        {
            get
            {
                return curSource;
            }
            set
            {
                curSource = value;
                OnPropertyChanged("CurSource");
            }
        }
        public UltraImage()
        {
            Name = "Портрет";
            Image thisImage = new Image();
            thisImage.Width = 128;
            thisImage.Height = 128;
            CurSource = Arthur;
            Binding binding = new Binding("CurSource");
            thisImage.SetBinding(Image.SourceProperty, binding);
            ffElement = thisImage;
            ffElement.PreviewMouseRightButtonDown += onRMouse;
        }
        public void onRMouse(object sender, MouseEventArgs e)
        {
            if (string.Compare(CurSource, Arthur) == 0)
            {
                CurSource = Enterprise;
            }
            else
                CurSource = Arthur;
        }
    }

    public class CustomWPFControl : INotifyPropertyChanged
    {
        public FrameworkElement ffElement { get; set; }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
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
}