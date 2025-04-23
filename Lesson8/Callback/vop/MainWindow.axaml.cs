using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Threading;

namespace Callback.vop;

public partial class MainWindow : Window, ICallbackInterface
{
    private FacadeWithCallback _facade;
    public MainWindow()
    {
        InitializeComponent();
        ButtonStart.IsEnabled = true;
        ButtonStop.IsEnabled = false;
    }

    private void ButtonHandler(object? sender, RoutedEventArgs e)
    {
        if (Equals(sender, ButtonStart))
        {
            _facade = new FacadeWithCallback(this);
            _facade.Run();
            ButtonStart.IsEnabled = false;
            ButtonStop.IsEnabled = true;
        }
        else
        {
            _facade.Stop();
            ButtonStart.IsEnabled = true;
            ButtonStop.IsEnabled = false;
        }
    }

    public void UpdateMessage(string message)
    {
        Dispatcher.UIThread.Post(() =>
        {
            LabelInfo.Content = message;
        });
        
        if (!_facade.FacadeThread.IsAlive)
        {
            ButtonHandler(ButtonStop, new KeyEventArgs());
        }
    }

    public void UpdateImages(Image image1, Image image2)
    {
        Dispatcher.UIThread.Post(() =>
        {
            DieImage1.Source = image1.Source;
            DieImage2.Source = image2.Source;
        });
    }
}