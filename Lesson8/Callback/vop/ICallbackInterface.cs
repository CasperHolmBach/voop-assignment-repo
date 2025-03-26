using Avalonia.Controls;

namespace Callback.vop;

public interface ICallbackInterface
{
    void UpdateMessage(string message);
    void UpdateImages(Image image1, Image image2);
}