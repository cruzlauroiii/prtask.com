namespace WillowMaze.Wasm.Decompiled;


class NotificationChannelCompat$Api29Impl {
    private NotificationChannelCompat$Api29Impl() {
    }

    static bool CanBubble(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.canBubble();
    }
}

