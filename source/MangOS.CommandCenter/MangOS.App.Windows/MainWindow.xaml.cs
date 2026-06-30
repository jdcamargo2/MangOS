using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MangOS.App.Windows
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Title = "MangOS Command Center";
        }
        private void CaptureButton_Click(object sender, RoutedEventArgs e) 
        {
            ClearCaptureBox();
        }
        private void CaptureTextBox_KeyDown(object sender, KeyRoutedEventArgs e) 
        { 
            if (e.Key == VirtualKey.Enter) 
            {
                ClearCaptureBox();
            }
        }
        private void ClearCaptureBox() 
        { 
            CaptureTextBox.Text = string.Empty;
            CaptureTextBox.Focus(FocusState.Programmatic);
        }
    }
}
