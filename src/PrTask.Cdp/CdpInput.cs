using System.Globalization;
using System.Text.Json.Nodes;

namespace PrTask.Cdp;

#pragma warning disable SA1600
public static class CdpInput
{
    public static async Task DispatchMouseEventAsync(CdpClient Client, string SessionId, string Type, int X, int Y, string Button = "left", int ClickCount = 1, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Input.dispatchMouseEvent", new JsonObject
        {
            ["type"] = Type,
            ["x"] = X,
            ["y"] = Y,
            ["button"] = Button,
            ["clickCount"] = ClickCount,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task ClickAsync(CdpClient Client, string SessionId, int X, int Y, CancellationToken Cancel = default)
    {
        await DispatchMouseEventAsync(Client, SessionId, "mousePressed", X, Y, "left", 1, Cancel).ConfigureAwait(false);
        await DispatchMouseEventAsync(Client, SessionId, "mouseReleased", X, Y, "left", 1, Cancel).ConfigureAwait(false);
    }

    public static async Task DoubleClickAsync(CdpClient Client, string SessionId, int X, int Y, CancellationToken Cancel = default)
    {
        await DispatchMouseEventAsync(Client, SessionId, "mousePressed", X, Y, "left", 1, Cancel).ConfigureAwait(false);
        await DispatchMouseEventAsync(Client, SessionId, "mouseReleased", X, Y, "left", 1, Cancel).ConfigureAwait(false);
        await DispatchMouseEventAsync(Client, SessionId, "mousePressed", X, Y, "left", 2, Cancel).ConfigureAwait(false);
        await DispatchMouseEventAsync(Client, SessionId, "mouseReleased", X, Y, "left", 2, Cancel).ConfigureAwait(false);
    }

    public static async Task MoveAsync(CdpClient Client, string SessionId, int X, int Y, CancellationToken Cancel = default)
    {
        await DispatchMouseEventAsync(Client, SessionId, "mouseMoved", X, Y, "none", 0, Cancel).ConfigureAwait(false);
    }

    public static async Task DispatchKeyEventAsync(CdpClient Client, string SessionId, string Type, string Key, int WindowsVirtualKeyCode = 0, string? Text = null, CancellationToken Cancel = default)
    {
        var Params = new JsonObject
        {
            ["type"] = Type,
            ["key"] = Key,
        };

        if (WindowsVirtualKeyCode > 0)
        {
            Params["windowsVirtualKeyCode"] = WindowsVirtualKeyCode;
        }

        if (Text is not null)
        {
            Params["text"] = Text;
            Params["unmodifiedText"] = Text;
        }

        await Client.SendToTargetAsync(SessionId, "Input.dispatchKeyEvent", Params, Cancel).ConfigureAwait(false);
    }

    public static async Task TypeTextAsync(CdpClient Client, string SessionId, string Text, CancellationToken Cancel = default)
    {
        foreach (var Ch in Text)
        {
            var CharStr = Ch.ToString(CultureInfo.InvariantCulture);
            await DispatchKeyEventAsync(Client, SessionId, "keyDown", CharStr, 0, CharStr, Cancel).ConfigureAwait(false);
            await DispatchKeyEventAsync(Client, SessionId, "keyUp", CharStr, 0, null, Cancel).ConfigureAwait(false);
        }
    }

    public static async Task PressKeyAsync(CdpClient Client, string SessionId, string Key, CancellationToken Cancel = default)
    {
        var KeyCode = GetKeyCode(Key);
        await DispatchKeyEventAsync(Client, SessionId, "rawKeyDown", Key, KeyCode, null, Cancel).ConfigureAwait(false);
        await DispatchKeyEventAsync(Client, SessionId, "keyUp", Key, KeyCode, null, Cancel).ConfigureAwait(false);
    }

    public static async Task DragAsync(CdpClient Client, string SessionId, int FromX, int FromY, int ToX, int ToY, int Steps = 10, CancellationToken Cancel = default)
    {
        await DispatchMouseEventAsync(Client, SessionId, "mousePressed", FromX, FromY, "left", 1, Cancel).ConfigureAwait(false);
        for (var I = 1; I <= Steps; I++)
        {
            var X = FromX + ((ToX - FromX) * I / Steps);
            var Y = FromY + ((ToY - FromY) * I / Steps);
            await DispatchMouseEventAsync(Client, SessionId, "mouseMoved", X, Y, "none", 0, Cancel).ConfigureAwait(false);
        }

        await DispatchMouseEventAsync(Client, SessionId, "mouseReleased", ToX, ToY, "left", 1, Cancel).ConfigureAwait(false);
    }

    private static int GetKeyCode(string Key) => Key switch
    {
        "Enter" => 13,
        "Tab" => 9,
        "Backspace" => 8,
        "Delete" => 46,
        "Escape" => 27,
        "ArrowUp" => 38,
        "ArrowDown" => 40,
        "ArrowLeft" => 37,
        "ArrowRight" => 39,
        "Home" => 36,
        "End" => 35,
        "PageUp" => 33,
        "PageDown" => 34,
        "Space" or " " => 32,
        _ => 0,
    };
}
#pragma warning restore SA1600
