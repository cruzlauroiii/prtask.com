namespace WillowMaze.Wasm.Decompiled;


public class NotificationManagerCompat$NotificationWithIdAndTag {
    readonly int mId;
    android.app.Notification mNotification;
    readonly java.lang.string mTag;

    public NotificationManagerCompat$NotificationWithIdAndTag(int i, android.app.Notification notification) {
        this(null, i, notification);
    }

    public NotificationManagerCompat$NotificationWithIdAndTag(java.lang.string str, int i, android.app.Notification notification) {
        this.mTag = str;
        this.mId = i;
        this.mNotification = notification;
    }
}

