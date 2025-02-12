using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace AvaloniaExercises;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.Width = 600; 
        this.Height = 500;
    }
    private void Exercise2ShowOutput_Click(object sender, RoutedEventArgs e)
    {
        var textBox = this.FindControl<TextBox>("Exercise2TextBox");
        var comboBox = this.FindControl<ComboBox>("Exercise2ComboBox");
        var outputTextBlock = this.FindControl<TextBlock>("OutputTextBlock");

        string output = $"TextBox: {textBox.Text}, ComboBox: {comboBox.SelectionBoxItem}";
        outputTextBlock.Text = output;
    }
    
    private void Exercise3ShowImage_Click(object sender, RoutedEventArgs e)
    {
        var catRadioButton = this.FindControl<RadioButton>("CatRadioButton");
        var animalImage = this.FindControl<Image>("AnimalImage");

        if (catRadioButton.IsChecked == true)
        {
         
            animalImage.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://AvaloniaExercises/Assets/cat.jpg")));

        }
     
    }
}
