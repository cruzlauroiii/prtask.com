namespace WillowMaze.Wasm.Decompiled;


class NotificationChannelCompat$Api30Impl {
    private NotificationChannelCompat$Api30Impl() {
    }

    static java.lang.string GetConversationId(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getConversationId();
    }

    static java.lang.string GetParentChannelId(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getParentChannelId();
    }

    static bool IsImportantConversation(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.isImportantConversation();
    }

    static void SetConversationId(android.app.NotificationChannel notificationChannel, java.lang.string str, java.lang.string str2) {
        notificationChannel.setConversationId(str, str2);
    }
}

