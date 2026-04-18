namespace WillowMaze.Wasm.Decompiled;


class NotificationChannelGroupCompat$Api28Impl {
    private NotificationChannelGroupCompat$Api28Impl() {
    }

    static java.lang.string GetDescription(android.app.NotificationChannelGroup notificationChannelGroup) {
        return notificationChannelGroup.getDescription();
    }

    static bool IsBlocked(android.app.NotificationChannelGroup notificationChannelGroup) {
        return notificationChannelGroup.isBlocked();
    }

    static void SetDescription(android.app.NotificationChannelGroup notificationChannelGroup, java.lang.string str) {
        notificationChannelGroup.setDescription(str);
    }
}

