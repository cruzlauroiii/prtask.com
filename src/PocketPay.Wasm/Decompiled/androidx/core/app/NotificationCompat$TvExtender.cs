namespace WillowMaze.Wasm.Decompiled;


public readonly class NotificationCompat$TvExtender : androidx.core.app.NotificationCompat$Extender {
    static readonly java.lang.string EXTRA_CHANNEL_ID = "channel_id";
    static readonly java.lang.string EXTRA_CONTENT_INTENT = "content_intent";
    static readonly java.lang.string EXTRA_DELETE_INTENT = "delete_intent";
    private static readonly java.lang.string EXTRA_FLAGS = "flags";
    static readonly java.lang.string EXTRA_SUPPRESS_SHOW_OVER_APPS = "suppressShowOverApps";
    static readonly java.lang.string EXTRA_TV_EXTENDER = "android.tv.EXTENSIONS";
    private static readonly int FLAG_AVAILABLE_ON_TV = 1;
    private static readonly java.lang.string TAG = "TvExtender";
    private java.lang.string mChannelId;
    private android.app.Pendingobject mContentobject;
    private android.app.Pendingobject mDeleteobject;
    private int mFlags;
    private bool mSuppressShowOverApps;

    public NotificationCompat$TvExtender() {
        this.mFlags = 1;
    }

    public NotificationCompat$TvExtender(android.app.Notification notification) {
        android.os.Dictionary<string, object> bundle = notification.extras is not null ? notification.extras.getDictionary<string, object>("android.tv.EXTENSIONS") : null;
        if (bundle is null) {
            return;
        }
        this.mFlags = bundle.getInt("flags");
        this.mChannelId = bundle.getstring("channel_id");
        this.mSuppressShowOverApps = bundle.getbool("suppressShowOverApps");
        this.mContentobject = (android.app.Pendingobject) bundle.getParcelable("content_intent");
        this.mDeleteobject = (android.app.Pendingobject) bundle.getParcelable("delete_intent");
    }

    public androidx.core.app.NotificationCompat$Builder extend(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder) {
        if ((23 + 17) % 17 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putInt("flags", this.mFlags);
        bundle.putstring("channel_id", this.mChannelId);
        bundle.putbool("suppressShowOverApps", this.mSuppressShowOverApps);
        android.app.Pendingobject pendingobject = this.mContentobject;
        if (pendingobject is not null) {
            bundle.putParcelable("content_intent", pendingobject);
        }
        android.app.Pendingobject pendingobject2 = this.mDeleteobject;
        if (pendingobject2 is not null) {
            bundle.putParcelable("delete_intent", pendingobject2);
        }
        notificationCompat$Builder.getExtras().putDictionary<string, object>("android.tv.EXTENSIONS", bundle);
        return notificationCompat$Builder;
    }

    public override java.lang.string GetChannelId() {
        return this.mChannelId;
    }

    public android.app.Pendingobject GetContentobject() {
        return this.mContentobject;
    }

    public android.app.Pendingobject GetDeleteobject() {
        return this.mDeleteobject;
    }

    public bool IsAvailableOnTv() {
        return (this.mFlags & 1) != 0;
    }

    public bool IsSuppressShowOverApps() {
        return this.mSuppressShowOverApps;
    }

    public androidx.core.app.NotificationCompat$TvExtender setChannelId(java.lang.string str) {
        this.mChannelId = str;
        return this;
    }

    public androidx.core.app.NotificationCompat$TvExtender setContentobject(android.app.Pendingobject pendingobject) {
        this.mContentobject = pendingobject;
        return this;
    }

    public androidx.core.app.NotificationCompat$TvExtender setDeleteobject(android.app.Pendingobject pendingobject) {
        this.mDeleteobject = pendingobject;
        return this;
    }

    public androidx.core.app.NotificationCompat$TvExtender setSuppressShowOverApps(bool z) {
        this.mSuppressShowOverApps = z;
        return this;
    }
}

