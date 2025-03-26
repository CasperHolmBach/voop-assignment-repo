using System;
using System.Threading;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;

namespace FlashingText;

public partial class MainWindow : Window
{
    private string text;
    private Thread thread;
    private int waitTime;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ChangeLabel()
    {
        try
        {
            while (true)
            {
                string currentContent = "";
                Dispatcher.UIThread.InvokeAsync(() => currentContent = Title.Text).Wait();

                if (String.IsNullOrEmpty(currentContent))
                {
                    Dispatcher.UIThread.InvokeAsync(() => Title.Text = "Swamp izzo!").Wait();

                }
                else
                {
                    Dispatcher.UIThread.InvokeAsync(() => Title.Text = "").Wait();
                }
                
                Thread.Sleep(waitTime);
            }
        }
        catch (ThreadInterruptedException e)
        {
            Console.WriteLine("Interrupted");
        }
    }

    private void StartButton(object sender, RoutedEventArgs e)
    {
        thread = new Thread(ChangeLabel);
        thread.IsBackground = true;
        thread.Start();
    }

    private void StopButton(object sender, RoutedEventArgs e)
    {
        thread.Interrupt();
    }

    private void RadioButton(object sender, RoutedEventArgs e)
    {
        var radioButton = (RadioButton)sender;
        if (radioButton.Name == "slow")
        {
            waitTime = 100;
        }

        if (radioButton.Name == "medium")
        {
            waitTime = 200;
        }

        if (radioButton.Name == "fast")
        {
            waitTime = 400;
        }
    }
}