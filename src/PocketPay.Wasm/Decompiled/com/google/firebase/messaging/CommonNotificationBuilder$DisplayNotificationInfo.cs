namespace WillowMaze.Wasm.Decompiled;


public class CommonNotificationBuilder$DisplayNotificationInfo {
    public readonly int id;
    public readonly androidx.core.app.NotificationCompat$Builder notificationBuilder;
    public readonly java.lang.string tag;

    CommonNotificationBuilder$DisplayNotificationInfo(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, java.lang.string str, int i) {
        this.notificationBuilder = notificationCompat$Builder;
        this.tag = str;
        this.id = i;
    }
}

