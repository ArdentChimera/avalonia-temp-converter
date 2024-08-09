using Avalonia.Controls;
using System;
using System.Diagnostics;

namespace TestProject.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Debug.WriteLine("Click !");
        Debug.WriteLine($"Click ! Celsius={celsius.Text}");
    }

    private void TextBox_PropertyChanged(object? sender, Avalonia.AvaloniaPropertyChangedEventArgs e)
    {
        Debug.WriteLine($"Input detected ! Celsius={celsius.Text}");

        if (Double.TryParse(celsius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            fahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            celsius.Text = "0";
            fahrenheit.Text = "0";
        }
    }
}
