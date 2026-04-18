namespace WillowMaze.Wasm.Decompiled;


class NotificationChannelGroupCompat$Api26Impl {
    private NotificationChannelGroupCompat$Api26Impl() {
    }

    static android.app.NotificationChannelGroup CreateNotificationChannelGroup(java.lang.string str, java.lang.CharSequence charSequence) {
        return new android.app.NotificationChannelGroup(str, charSequence);
    }

    static java.util.List<android.app.NotificationChannel> GetChannels(android.app.NotificationChannelGroup notificationChannelGroup) {
        return notificationChannelGroup.getChannels();
    }

    static java.lang.string GetGroup(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getGroup();
    }

    static java.lang.string GetId(android.app.NotificationChannelGroup notificationChannelGroup) {
        return notificationChannelGroup.getId();
    }

    static java.lang.CharSequence GetName(android.app.NotificationChannelGroup notificationChannelGroup) {
        return notificationChannelGroup.getName();
    }
}

