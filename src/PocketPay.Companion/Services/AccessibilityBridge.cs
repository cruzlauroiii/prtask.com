using Android.AccessibilityServices;
using Android.App;
using Android.Content;
using Android.Views.Accessibility;

namespace PocketPay.Companion.Services;

[Service(
    Permission = "android.permission.BIND_ACCESSIBILITY_SERVICE",
    Exported = false)]
[IntentFilter(["android.accessibilityservice.AccessibilityService"])]
[MetaData("android.accessibilityservice", Resource = "@xml/companion_accessibility_config")]
public class AccessibilityBridge : AccessibilityService
{
    private const int MaxEvents = 200;

    private static readonly System.Threading.Lock StateLock = new();
    private static readonly System.Collections.Generic.List<string> CapturedEventsList = [];

    private static AccessibilityBridge? ActiveInstance;

    public static string? MonitoredPackage { get; set; }

    public static string? State { get; private set; }

    public static System.Collections.Generic.IReadOnlyList<string> Events
    {
        get
        {
            lock (StateLock)
            {
                return [.. CapturedEventsList];
            }
        }
    }

    public static void ClearEvents()
    {
        lock (StateLock)
        {
            CapturedEventsList.Clear();
            State = null;
        }
    }

    public static string? ScreenText => ActiveInstance?.GetScreenTextInternal();

    private string? GetScreenTextInternal()
    {
        try
        {
            var Root = GetRootInActiveWindow(0);
            if (Root == null)
            {
                return null;
            }

            var Texts = new System.Collections.Generic.List<string>();
            TraverseNode(Root, Texts);
            return System.Text.Json.JsonSerializer.Serialize(Texts);
        }
        catch (System.Exception Ex)
        {
            Android.Util.Log.Error("CompanionA11y", $"GetScreenText error: {Ex.Message}");
            return null;
        }
    }

    public override void OnAccessibilityEvent(AccessibilityEvent? E)
    {
        if (E == null)
        {
            return;
        }

        var PackageName = E.PackageName;
        if (!string.IsNullOrEmpty(MonitoredPackage) &&
            !string.Equals(PackageName, MonitoredPackage, System.StringComparison.OrdinalIgnoreCase))
        {
            return;
        }

        var EventType = E.EventType;
        var Timestamp = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        var ClassName = E.ClassName ?? string.Empty;
        var TextContent = string.Empty;

        if (E.Text is { Count: > 0 })
        {
            var Parts = new System.Collections.Generic.List<string>();
            foreach (var T in E.Text)
            {
                if (T != null)
                {
                    Parts.Add(T.ToString());
                }
            }

            TextContent = string.Join(" | ", Parts);
        }

        var Entry = System.Text.Json.JsonSerializer.Serialize(new
        {
            Package = PackageName ?? string.Empty,
            Type = EventType.ToString(),
            Class = ClassName,
            Text = TextContent,
            Time = Timestamp,
        });

        lock (StateLock)
        {
            if (CapturedEventsList.Count >= MaxEvents)
            {
                CapturedEventsList.RemoveAt(0);
            }

            CapturedEventsList.Add(Entry);
        }

        if (EventType == EventTypes.WindowStateChanged)
        {
            lock (StateLock)
            {
                State = System.Text.Json.JsonSerializer.Serialize(new
                {
                    Package = PackageName ?? string.Empty,
                    Activity = ClassName,
                    Text = TextContent,
                    Time = Timestamp,
                });
            }

            Android.Util.Log.Info("CompanionA11y", $"Window: {PackageName}/{ClassName}");
        }

        if (EventType == EventTypes.ViewTextChanged)
        {
            Android.Util.Log.Info("CompanionA11y", $"TextChanged: {TextContent}");
        }

        if (EventType == EventTypes.ViewClicked)
        {
            Android.Util.Log.Info("CompanionA11y", $"Clicked: {ClassName} - {TextContent}");
        }
    }

    public override void OnInterrupt()
    {
        Android.Util.Log.Info("CompanionA11y", "Interrupted");
    }

    protected override void OnServiceConnected()
    {
        base.OnServiceConnected();
        ActiveInstance = this;
        Android.Util.Log.Info("CompanionA11y", "AccessibilityBridge connected");
    }

    public override void OnDestroy()
    {
        ActiveInstance = null;
        base.OnDestroy();
    }

    private static void TraverseNode(AccessibilityNodeInfo Node, System.Collections.Generic.List<string> Texts)
    {
        var NodeText = Node.Text;
        if (!string.IsNullOrEmpty(NodeText))
        {
            Texts.Add(NodeText);
        }

        var Desc = Node.ContentDescription;
        if (!string.IsNullOrEmpty(Desc))
        {
            Texts.Add($"[desc:{Desc}]");
        }

        for (var I = 0; I < Node.ChildCount; I++)
        {
            var Child = Node.GetChild(I);
            if (Child != null)
            {
                TraverseNode(Child, Texts);
            }
        }
    }
}
