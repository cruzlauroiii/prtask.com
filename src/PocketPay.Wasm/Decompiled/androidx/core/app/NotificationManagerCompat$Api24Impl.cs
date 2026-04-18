namespace WillowMaze.Wasm.Decompiled;


class NotificationManagerCompat$Api24Impl {
    private NotificationManagerCompat$Api24Impl() {
    }

    static bool AreNotificationsEnabled(android.app.NotificationManager notificationManager) {
        return notificationManager.areNotificationsEnabled();
    }

    static int GetImportance(android.app.NotificationManager notificationManager) {
        return notificationManager.getImportance();
    }
}

