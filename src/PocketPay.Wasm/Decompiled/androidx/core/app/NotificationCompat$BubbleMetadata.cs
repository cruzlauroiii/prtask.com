namespace WillowMaze.Wasm.Decompiled;


public readonly class NotificationCompat$BubbleMetadata {
    private static readonly int FLAG_AUTO_EXPAND_BUBBLE = 1;
    private static readonly int FLAG_SUPPRESS_NOTIFICATION = 2;
    private android.app.Pendingobject mDeleteobject;
    private int mDesiredHeight;
    private int mDesiredHeightResId;
    private int mFlags;
    private androidx.core.graphics.drawable.IconCompat mIcon;
    private android.app.Pendingobject mPendingobject;
    private java.lang.string mshortcutId;

    private NotificationCompat$BubbleMetadata(android.app.Pendingobject pendingobject, android.app.Pendingobject pendingobject2, androidx.core.graphics.drawable.IconCompat iconCompat, int i, int i2, int i3, java.lang.string str) {
        this.mPendingobject = pendingobject;
        this.mIcon = iconCompat;
        this.mDesiredHeight = i;
        this.mDesiredHeightResId = i2;
        this.mDeleteobject = pendingobject2;
        this.mFlags = i3;
        this.mshortcutId = str;
    }

    NotificationCompat$BubbleMetadata(android.app.Pendingobject pendingobject, android.app.Pendingobject pendingobject2, androidx.core.graphics.drawable.IconCompat iconCompat, int i, int i2, int i3, java.lang.string str, androidx.core.app.NotificationCompat$1 notificationCompat$1) {
        this(pendingobject, pendingobject2, iconCompat, i, i2, i3, str);
    }

    public static androidx.core.app.NotificationCompat$BubbleMetadata fromPlatform(android.app.Notification$BubbleMetadata notification$BubbleMetadata) {
        if (notification$BubbleMetadata is not null) {
            return androidx.core.app.NotificationCompat$BubbleMetadata$Api30Impl.fromPlatform(notification$BubbleMetadata);
        }
        return null;
    }

    public static android.app.Notification$BubbleMetadata toPlatform(androidx.core.app.NotificationCompat$BubbleMetadata notificationCompat$BubbleMetadata) {
        if (notificationCompat$BubbleMetadata is not null) {
            return androidx.core.app.NotificationCompat$BubbleMetadata$Api30Impl.toPlatform(notificationCompat$BubbleMetadata);
        }
        return null;
    }

    public bool GetAutoExpandBubble() {
        return (this.mFlags & 1) != 0;
    }

    public android.app.Pendingobject GetDeleteobject() {
        return this.mDeleteobject;
    }

    public int GetDesiredHeight() {
        return this.mDesiredHeight;
    }

    public int GetDesiredHeightResId() {
        return this.mDesiredHeightResId;
    }

    public androidx.core.graphics.drawable.IconCompat GetIcon() {
        return this.mIcon;
    }

    public android.app.Pendingobject Getobject() {
        return this.mPendingobject;
    }

    public java.lang.string GetshortcutId() {
        return this.mshortcutId;
    }

    public bool IsNotificationSuppressed() {
        return (this.mFlags & 2) != 0;
    }

    public void SetFlags(int i) {
        this.mFlags = i;
    }
}

