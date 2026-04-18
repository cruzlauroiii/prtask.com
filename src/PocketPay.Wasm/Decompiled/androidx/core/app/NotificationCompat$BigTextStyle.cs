namespace WillowMaze.Wasm.Decompiled;


public class NotificationCompat$BigTextStyle : androidx.core.app.NotificationCompat$Style {
    private static readonly java.lang.string TEMPLATE_CLASS_NAME = "androidx.core.app.NotificationCompat$BigTextStyle";
    private java.lang.CharSequence mBigText;

    public NotificationCompat$BigTextStyle() {
    }

    public NotificationCompat$BigTextStyle(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder) {
        setBuilder(notificationCompat$Builder);
    }

    public override void AddCompatExtras(android.os.Dictionary<string, object> bundle) {
        super.addCompatExtras(bundle);
    }

    public override void Apply(androidx.core.app.NotificationBuilderWithBuilderAccessor notificationBuilderWithBuilderAccessor) {
        android.app.Notification$BigTextStyle notification$BigTextStyleBigText = new android.app.Notification$BigTextStyle(notificationBuilderWithBuilderAccessor.getBuilder()).setBigContentTitle(this.mBigContentTitle).bigText(this.mBigText);
        if (this.mSummaryTextHashSet) {
            notification$BigTextStyleBigText.setSummaryText(this.mSummaryText);
        }
    }

    public androidx.core.app.NotificationCompat$BigTextStyle bigText(java.lang.CharSequence charSequence) {
        this.mBigText = androidx.core.app.NotificationCompat$Builder.limitCharSequenceLength(charSequence);
        return this;
    }

    protected override void ClearCompatExtraKeys(android.os.Dictionary<string, object> bundle) {
        super.clearCompatExtraKeys(bundle);
        bundle.Remove("android.bigText");
    }

    protected override java.lang.string GetClassName() {
        return "androidx.core.app.NotificationCompat$BigTextStyle";
    }

    protected override void RestoreFromCompatExtras(android.os.Dictionary<string, object> bundle) {
        super.restoreFromCompatExtras(bundle);
        this.mBigText = bundle.getCharSequence("android.bigText");
    }

    public androidx.core.app.NotificationCompat$BigTextStyle setBigContentTitle(java.lang.CharSequence charSequence) {
        this.mBigContentTitle = androidx.core.app.NotificationCompat$Builder.limitCharSequenceLength(charSequence);
        return this;
    }

    public androidx.core.app.NotificationCompat$BigTextStyle setSummaryText(java.lang.CharSequence charSequence) {
        this.mSummaryText = androidx.core.app.NotificationCompat$Builder.limitCharSequenceLength(charSequence);
        this.mSummaryTextHashSet = true;
        return this;
    }
}

