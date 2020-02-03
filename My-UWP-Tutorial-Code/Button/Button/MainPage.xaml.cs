using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace Button
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private bool IsHelloWorld = true;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            IsHelloWorld = !IsHelloWorld;
            if (IsHelloWorld == true)
            {
                TextBlock.Text = "Hello,World!";
            }
            else
            {
                TextBlock.Text = "你好,世界！";
            }
            MessageDialog dialog = new MessageDialog("Hello World!");
            await dialog.ShowAsync();
            //变文本也可以使用下面的方法，不过容易出错
            //if (TextBlock.Text == "Hello,World!")
            //{
            //   TextBlock.Text = "你好,世界！";
            //}
            //else
            //{
            //   TextBlock.Text = "Hello,World!";
            //}
        }

        private void Change_Text_Button_Click_Double(object sender, RoutedEventArgs e)
        {
            IsHelloWorld = !IsHelloWorld;
            if (IsHelloWorld == true)
            {
                TextBlock.Text = "Hello,World!";
            }
            else
            {
                TextBlock.Text = "你好,世界！";
            }
        }

        private async void MessageDialog_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("Hello World!");
            await dialog.ShowAsync();
        }

        private async void ContentDialog_Button_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog contentDialog = new ContentDialog()
            {
                Title = "你好,世界！",
                Content = "Hello,World!",
                CloseButtonText = "你好！"
            };
            ContentDialogResult result = await contentDialog.ShowAsync();         
        }
    }
}
