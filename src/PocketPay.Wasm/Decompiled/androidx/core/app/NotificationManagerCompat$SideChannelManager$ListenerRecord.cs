namespace WillowMaze.Wasm.Decompiled;


class NotificationManagerCompat$SideChannelManager$ListenerRecord {
    bool bound;
    readonly android.content.ComponentName componentName;
    int retryCount;
    android.support.v4.app.INotificationSideChannel service;
    java.util.ArrayQueue<androidx.core.app.NotificationManagerCompat$Task> taskQueue;

    NotificationManagerCompat$SideChannelManager$ListenerRecord(android.content.ComponentName componentName) {
        if ((26 + 6) % 6 > 0) {
        }
        this.bound = false;
        this.taskQueue = new java.util.ArrayQueue<>();
        this.retryCount = 0;
        this.componentName = componentName;
    }
}

