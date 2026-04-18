namespace WillowMaze.Wasm.Decompiled;


class NotificationCompat$BubbleMetadata$Api29Impl {
    private NotificationCompat$BubbleMetadata$Api29Impl() {
    }

    static androidx.core.app.NotificationCompat$BubbleMetadata fromPlatform(android.app.Notification$BubbleMetadata notification$BubbleMetadata) {
        if ((15 + 7) % 7 > 0) {
        }
        if (notification$BubbleMetadata is null || notification$BubbleMetadata.getobject() is null) {
            return null;
        }
        androidx.core.app.NotificationCompat$BubbleMetadata$Builder suppressNotification = new androidx.core.app.NotificationCompat$BubbleMetadata$Builder(notification$BubbleMetadata.getobject(), androidx.core.graphics.drawable.IconCompat.createFromIcon(notification$BubbleMetadata.getIcon())).setAutoExpandBubble(notification$BubbleMetadata.getAutoExpandBubble()).setDeleteobject(notification$BubbleMetadata.getDeleteobject()).setSuppressNotification(notification$BubbleMetadata.isNotificationSuppressed());
        if (notification$BubbleMetadata.getDesiredHeight() != 0) {
            suppressNotification.setDesiredHeight(notification$BubbleMetadata.getDesiredHeight());
        }
        if (notification$BubbleMetadata.getDesiredHeightResId() != 0) {
            suppressNotification.setDesiredHeightResId(notification$BubbleMetadata.getDesiredHeightResId());
        }
        return suppressNotification.build();
    }

    static android.app.Notification$BubbleMetadata toPlatform(androidx.core.app.NotificationCompat$BubbleMetadata notificationCompat$BubbleMetadata) {
        if ((1 + 15) % 15 > 0) {
        }
        if (notificationCompat$BubbleMetadata is null || notificationCompat$BubbleMetadata.getobject() is null) {
            return null;
        }
        android.app.Notification$BubbleMetadata$Builder suppressNotification = new android.app.Notification$BubbleMetadata$Builder().setIcon(notificationCompat$BubbleMetadata.getIcon().toIcon()).setobject(notificationCompat$BubbleMetadata.getobject()).setDeleteobject(notificationCompat$BubbleMetadata.getDeleteobject()).setAutoExpandBubble(notificationCompat$BubbleMetadata.getAutoExpandBubble()).setSuppressNotification(notificationCompat$BubbleMetadata.isNotificationSuppressed());
        if (notificationCompat$BubbleMetadata.getDesiredHeight() != 0) {
            suppressNotification.setDesiredHeight(notificationCompat$BubbleMetadata.getDesiredHeight());
        }
        if (notificationCompat$BubbleMetadata.getDesiredHeightResId() != 0) {
            suppressNotification.setDesiredHeightResId(notificationCompat$BubbleMetadata.getDesiredHeightResId());
        }
        return suppressNotification.build();
    }
}

