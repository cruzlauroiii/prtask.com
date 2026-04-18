namespace WillowMaze.Wasm.Decompiled;


class NotificationManagerCompat$Api28Impl {
    private NotificationManagerCompat$Api28Impl() {
    }

    static android.app.NotificationChannelGroup GetNotificationChannelGroup(android.app.NotificationManager notificationManager, java.lang.string str) {
        return notificationManager.getNotificationChannelGroup(str);
    }
}

