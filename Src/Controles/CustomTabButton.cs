using System;
using System.Collections.Generic;
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

namespace Controles
{
   
    public class CustomTabButton : Button
    {
        static CustomTabButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomTabButton), new FrameworkPropertyMetadata(typeof(CustomTabButton)));
        }

        private Image image;

        public Image Imagen
        {
            get { return image; }
            set { image = value; }
        }


    }
}
