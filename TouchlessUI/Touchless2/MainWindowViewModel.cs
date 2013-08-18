using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Touchless2
{
    public enum Mode
    {
        Desktop,
        Presentation
    }

    public enum Option
    {
        Touch,
        Gestures
    }

    public class MainWindowViewModel : ViewModelBase
    {
        private Mode mode;
        public Mode Mode
        {
            get { return this.mode; }
            set
            {
                if (this.mode != value)
                {
                    this.mode = value;
                    this.OnPropertyChanged("Mode");
                }
            }
        }

        private Option option;
        public Option Option
        {
            get { return this.option; }
            set
            {
                if (this.option != value)
                {
                    this.option = value;
                    this.OnPropertyChanged("Option");
                    this.OnPropertyChanged("TouchPanelVisibility");
                    this.OnPropertyChanged("GesturesPanelVisibility");
                }
            }
        }

        public Visibility TouchPanelVisibility
        {
            get { return this.option == Option.Touch ? Visibility.Visible : Visibility.Collapsed; }
        }

        public Visibility GesturesPanelVisibility
        {
            get { return this.option == Option.Gestures ? Visibility.Visible : Visibility.Collapsed; }
        }
        
        public ObservableCollection<ScreenViewModel> Screens
        {
            get;
            private set;
        }
        
        public MainWindowViewModel()
        {
            this.Screens = new ObservableCollection<ScreenViewModel>();
            this.LoadData();
        }

        private void LoadData()
        {
            this.mode = Mode.Desktop;
            this.option = Option.Touch;
            this.Screens.Clear();
            foreach (var screen in Screen.AllScreens)
            {
                this.Screens.Add(new ScreenViewModel(screen));
            }
        }
    }
}
