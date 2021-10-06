using PraticalUWP.Model;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PraticalUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<string> Image = new List<string>();
        public MainPage()
        {
            this.InitializeComponent();
            RenderImg();
        }

        public void RenderImg()
        {
            Image.Add("/Assets/726222.jpg");
            Image.Add("/Assets/725355.png");
            Image.Add("/Assets/713053.png");
            Image.Add("/Assets/1008472.png");
            Image.Add("/Assets/733254.png");
        }

        private void GV_Loaded(object sender, RoutedEventArgs e)
        {
            GV.Items.Add(new PraticalModel()
            {
                img = "/Assets/726222.jpg",
                product = "abc",
                description = "Test Test Test Test"
            });            
            GV.Items.Add(new PraticalModel()
            {
                img = "/Assets/725355.png",
                product = "abc",
                description = "Product2 product2 product2 product2"
            });

            GV.Items.Add(new PraticalModel()
            {
                img = "/Assets/713053.png",
                product = "abc",
                description = "Product3 product3 product3 Teproduct3st"
            });

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var inputItem = new PraticalModel()
            {
                img = Img.Text,
                product = Product.Text,
                description = Description.Text
              
            };
            GV.Items.Add(inputItem);

        }
    }
}
