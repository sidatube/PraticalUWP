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
        public MainPage()
        {
            this.InitializeComponent();
        }

        public void RenderImg(object sender, RoutedEventArgs e)

        {
            DirectoryInfo dir = new DirectoryInfo(@"./Assets/");

            FileInfo[] files = dir.GetFiles();



            foreach (FileInfo file in files)
            {
                var FileName = Path.GetFileName(file.ToString());
                //Imagebox.Items.Add("/Assets/" + FileName);
                Imagebox.Items.Add(new ImgList() {name = FileName, img = "/Assets/" + FileName });

            }
        }


        private void GV_Loaded(object sender, RoutedEventArgs e)
        {
            GV.Items.Add(new PraticalModel()
            {
                img = "/Assets/733254.png",
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
            tete.Text = Imagebox.SelectedItem.ToString();
            var inputItem = new PraticalModel()
            {
                img = (Imagebox.SelectedItem as ImgList).img,
                product = Product.Text,
                description = Description.Text

            };
            GV.Items.Add(inputItem);
            Product.Text = "";
            Description.Text = "";
            Imagebox.SelectedItem = null;

        }
        private void ComboBoxItem_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
