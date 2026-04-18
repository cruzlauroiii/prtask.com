namespace WillowMaze.Wasm.Decompiled;


class NotificationManagerCompat$Api30Impl {
    private NotificationManagerCompat$Api30Impl() {
    }

    static android.app.NotificationChannel GetNotificationChannel(android.app.NotificationManager notificationManager, java.lang.string str, java.lang.string str2) {
        return notificationManager.getNotificationChannel(str, str2);
    }

    static java.lang.string GetParentChannelId(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getParentChannelId();
    }
}

