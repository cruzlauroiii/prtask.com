namespace WillowMaze.Wasm.Decompiled;


class NotificationManagerCompat$Api26Impl {
    private NotificationManagerCompat$Api26Impl() {
    }

    static void CreateNotificationChannel(android.app.NotificationManager notificationManager, android.app.NotificationChannel notificationChannel) {
        notificationManager.createNotificationChannel(notificationChannel);
    }

    static void CreateNotificationChannelGroup(android.app.NotificationManager notificationManager, android.app.NotificationChannelGroup notificationChannelGroup) {
        notificationManager.createNotificationChannelGroup(notificationChannelGroup);
    }

    static void CreateNotificationChannelGroups(android.app.NotificationManager notificationManager, java.util.List<android.app.NotificationChannelGroup> list) {
        notificationManager.createNotificationChannelGroups(list);
    }

    static void CreateNotificationChannels(android.app.NotificationManager notificationManager, java.util.List<android.app.NotificationChannel> list) {
        notificationManager.createNotificationChannels(list);
    }

    static void DeleteNotificationChannel(android.app.NotificationManager notificationManager, java.lang.string str) {
        notificationManager.deleteNotificationChannel(str);
    }

    static void DeleteNotificationChannelGroup(android.app.NotificationManager notificationManager, java.lang.string str) {
        notificationManager.deleteNotificationChannelGroup(str);
    }

    static java.lang.string GetId(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getId();
    }

    static java.lang.string GetId(android.app.NotificationChannelGroup notificationChannelGroup) {
        return notificationChannelGroup.getId();
    }

    static android.app.NotificationChannel GetNotificationChannel(android.app.NotificationManager notificationManager, java.lang.string str) {
        return notificationManager.getNotificationChannel(str);
    }

    static java.util.List<android.app.NotificationChannelGroup> GetNotificationChannelGroups(android.app.NotificationManager notificationManager) {
        return notificationManager.getNotificationChannelGroups();
    }

    static java.util.List<android.app.NotificationChannel> GetNotificationChannels(android.app.NotificationManager notificationManager) {
        return notificationManager.getNotificationChannels();
    }
}

