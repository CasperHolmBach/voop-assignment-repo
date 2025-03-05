using System;
using System.IO;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;

namespace Search_and_Replace.Search_and_Replace;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void OpenButton(object sender, RoutedEventArgs e)
    {
        var topLevel = GetTopLevel(this);

        var files = await topLevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
        {
            Title = "Open File",
            AllowMultiple = false
        });

        if (files.Count >= 1)
        {
            await using var stream = await files[0].OpenReadAsync();
            using var StreamReader = new StreamReader(stream);
            
            var fileContent = await StreamReader.ReadToEndAsync();
            FileShower.SelectedText = fileContent;
        }
    }

    private async void SaveButton(object sender, RoutedEventArgs e)
    {
        var topLevel = GetTopLevel(this);

        var file = await topLevel.StorageProvider.SaveFilePickerAsync(new FilePickerSaveOptions
        {
            Title = "Save File",
        });

        if (file != null)
        {
            await using var stream = await file.OpenWriteAsync();
            using var StreamWriter = new StreamWriter(stream);
            
            
            await StreamWriter.WriteLineAsync(FileShower.SelectedText);
        }
    }

    private async void ReplaceButton(object sender, RoutedEventArgs e)
    {
        string replaceText = ReplaceBox.Text;
        string searchWord = SearchBox.Text;
        string fullText = FileShower.Text;
        
        try
        {
            FileShower.SelectedText = fullText.Replace(searchWord, replaceText);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid strings for replacment: ");
            Console.WriteLine("Search word" + searchWord);
            Console.WriteLine("Replace word" + replaceText);
        }
    }
}