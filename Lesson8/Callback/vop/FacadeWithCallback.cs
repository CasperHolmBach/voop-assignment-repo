using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Logging;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace Callback.vop;

public class FacadeWithCallback
{
    private ICallbackInterface _callBack;
    private string _pathToPics;
    private Image[] _pictures;
    public Thread FacadeThread;
    public FacadeWithCallback(ICallbackInterface callBack) : this(callBack, "avares://Callback/resources/" ) {}

    public FacadeWithCallback(ICallbackInterface callBack, string pathToPics) {
        _callBack = callBack;
        _pathToPics = pathToPics;
        _pictures = LoadPictures();
    }

    private Image[] LoadPictures()
    {
        _pictures = new Image[6];
        for (int i = 1; i <= 6; i++)
        {
            string fileName = _pathToPics + "dice" + i + ".png";
            Image image = new Image();
            image.Source = LoadFromResource(fileName);
            _pictures[i - 1] = image;
        }
        return _pictures;
    }

    public Image GetPic(int index) {
        return _pictures[index];
    }

    public void Run()
    {
        FacadeThread = new Thread(RollDice);
        FacadeThread.Start();
    }

    public void Stop()
    {
        FacadeThread.Interrupt();
    }
    
    [MethodImpl(MethodImplOptions.Synchronized)]
    public void RollDice() {
        int d1 = 0;
        int d2 = 0;
        try {
            Dice dice = new Dice();
            while (!dice.EqualsMax()) {
                dice.ThrowDice();
                d1 = dice.Die1;
                d2 = dice.Die2;
                _callBack.UpdateMessage(dice.ToString());
                _callBack.UpdateImages(GetPic(d1 - 1), GetPic(d2 - 1));
                Thread.Sleep(100);
            }
            if (dice.EqualsMax())
            {
                _callBack.UpdateMessage("Over And Out...");
            }
        } catch (ThreadInterruptedException ex) {
            _callBack.UpdateMessage("I GOT INTERRUPTED!!!");
        } 
    }
    
    public static Bitmap LoadFromResource(string image)
    {
        Uri resourceUri = new Uri(image);
        return new Bitmap(AssetLoader.Open(resourceUri));
    }
    private void SetImage(Image image, Image newImage) => image.Source = newImage.Source;

}