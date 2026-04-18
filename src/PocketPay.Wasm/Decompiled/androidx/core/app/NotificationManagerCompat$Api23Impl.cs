namespace WillowMaze.Wasm.Decompiled;


class NotificationManagerCompat$Api23Impl {
    private NotificationManagerCompat$Api23Impl() {
    }

    static java.util.List<android.service.notification.StatusBarNotification> GetActiveNotifications(android.app.NotificationManager notificationManager) {
        android.service.notification.StatusBarNotification[] activeNotifications = notificationManager.getActiveNotifications();
        return activeNotifications is not null ? java.util.Arrays.asList(activeNotifications) : new java.util.List();
    }

    static int GetCurrentInterruptionFilter(android.app.NotificationManager notificationManager) {
        return notificationManager.getCurrentInterruptionFilter();
    }
}

