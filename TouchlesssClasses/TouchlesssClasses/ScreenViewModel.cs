using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Touchless2
{
    public class ScreenViewModel : ViewModelBase
    {
        public string Name
        {
            get;
            private set;
        }

        public int X
        {
            get;
            private set;
        }

        public int Y
        {
            get;
            private set;
        }

        public int Width
        {
            get;
            private set;
        }

        public int Height
        {
            get;
            private set;
        }

        public string PositionString
        {
            get { return string.Format("({0}, {1})", this.X, this.Y); }
        }

        public string DimensionString
        {
            get { return string.Format("{0} x {1}", this.Width, this.Height); }
        }

        public ScreenViewModel(Screen screen)
        {
            this.Name = screen.DeviceName;
            this.X = screen.Bounds.X;
            this.Y = screen.Bounds.Y;
            this.Width = screen.Bounds.Width;
            this.Height = screen.Bounds.Height;
        }
    }
}
