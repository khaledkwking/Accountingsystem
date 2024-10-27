using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class FlashScreen : Form
    {
        public FlashScreen()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(this.BackgroundImage);
            b.MakeTransparent(b.GetPixel(1, 1));
            this.BackgroundImage = b;
        }

       
    }
}