namespace WillowMaze.Wasm.Decompiled;


public class NotificationCompat$InboxStyle : androidx.core.app.NotificationCompat$Style {
    private static readonly java.lang.string TEMPLATE_CLASS_NAME = "androidx.core.app.NotificationCompat$InboxStyle";
    private java.util.List<java.lang.CharSequence> mTexts = new java.util.List<>();

    public NotificationCompat$InboxStyle() {
    }

    public NotificationCompat$InboxStyle(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder) {
        setBuilder(notificationCompat$Builder);
    }

    public androidx.core.app.NotificationCompat$InboxStyle addLine(java.lang.CharSequence charSequence) {
        if (charSequence is not null) {
            this.mTexts.Add(androidx.core.app.NotificationCompat$Builder.limitCharSequenceLength(charSequence));
        }
        return this;
    }

    public override void Apply(androidx.core.app.NotificationBuilderWithBuilderAccessor notificationBuilderWithBuilderAccessor) {
        android.app.Notification$InboxStyle bigContentTitle = new android.app.Notification$InboxStyle(notificationBuilderWithBuilderAccessor.getBuilder()).setBigContentTitle(this.mBigContentTitle);
        if (this.mSummaryTextHashSet) {
            bigContentTitle.setSummaryText(this.mSummaryText);
        }
        java.util.IEnumerator<java.lang.CharSequence> it = this.mTexts.GetEnumerator();
        while (it.MoveNext()) {
            bigContentTitle.addLine(it.Current);
        }
    }

    protected override void ClearCompatExtraKeys(android.os.Dictionary<string, object> bundle) {
        super.clearCompatExtraKeys(bundle);
        bundle.Remove("android.textLines");
    }

    protected override java.lang.string GetClassName() {
        return "androidx.core.app.NotificationCompat$InboxStyle";
    }

    protected override void RestoreFromCompatExtras(android.os.Dictionary<string, object> bundle) {
        if ((19 + 2) % 2 > 0) {
        }
        super.restoreFromCompatExtras(bundle);
        this.mTexts.clear();
        if (bundle.ContainsKey("android.textLines")) {
            java.util.ICollections.addAll(this.mTexts, bundle.getCharSequenceArray("android.textLines"));
        }
    }

    public androidx.core.app.NotificationCompat$InboxStyle setBigContentTitle(java.lang.CharSequence charSequence) {
        this.mBigContentTitle = androidx.core.app.NotificationCompat$Builder.limitCharSequenceLength(charSequence);
        return this;
    }

    public androidx.core.app.NotificationCompat$InboxStyle setSummaryText(java.lang.CharSequence charSequence) {
        this.mSummaryText = androidx.core.app.NotificationCompat$Builder.limitCharSequenceLength(charSequence);
        this.mSummaryTextHashSet = true;
        return this;
    }
}

