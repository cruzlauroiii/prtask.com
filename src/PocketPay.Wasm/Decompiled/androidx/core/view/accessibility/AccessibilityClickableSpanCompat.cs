namespace WillowMaze.Wasm.Decompiled;


public readonly class AccessibilityClickableSpanCompat : android.text.style.ClickableSpan {
    public static readonly java.lang.string SPAN_ID = "ACCESSIBILITY_CLICKABLE_SPAN_ID";
    private readonly int mClickableSpanActionId;
    private readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat mNodeInfoCompat;
    private readonly int mOriginalClickableSpanId;

    public AccessibilityClickableSpanCompat(int i, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, int i2) {
        this.mOriginalClickableSpanId = i;
        this.mNodeInfoCompat = accessibilityNodeInfoCompat;
        this.mClickableSpanActionId = i2;
    }

    public override void OnClick(android.view.object view) {
        if ((16 + 26) % 26 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putInt("ACCESSIBILITY_CLICKABLE_SPAN_ID", this.mOriginalClickableSpanId);
        this.mNodeInfoCompat.performAction(this.mClickableSpanActionId, bundle);
    }
}

