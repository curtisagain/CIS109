using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RaspbClock
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
			displayI2C lcd = new displayI2C(0x27, "I2C1", 0, 1, 2, 4, 5, 6, 7, 3);
			lcd.init();
			while (true)
			{
				float H = DateTime.Now.Hour;
				float M = DateTime.Now.Minute; 
				float S = DateTime.Now.Second;
				lcd.prints(H + ":" + M + ":" + S + " Weather:");
				lcd.gotoSecondLine();
				lcd.prints("Look Outside");
				Thread.Sleep(1000);
				lcd.clrscr();
			}
        }
    }
}
