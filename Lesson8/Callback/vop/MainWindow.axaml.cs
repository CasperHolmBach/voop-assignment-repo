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
            // Initialize the facade and start it.
            // Handle access to the buttons
        }
        else
        {
            // Stop the facade
        }
    }

    public void UpdateMessage(string message)
    {
        // This is the implementation of the CallBack. Remember to use the UI Thread!
        // Set the message of the Label and check if the facade thread is alive.
    }

    public void UpdateImages(Image image1, Image image2)
    {
        // Changes the pictures of the Images
        // Dispatcher.UIThread.Post(() =>
        // {
        //     DieImage1.Source = image1.Source;
        //     DieImage2.Source = image2.Source;
        // });
    }
}