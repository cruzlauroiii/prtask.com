namespace WillowMaze.Wasm.Decompiled;


class NotificationCompat$BubbleMetadata$Api30Impl {
    private NotificationCompat$BubbleMetadata$Api30Impl() {
    }

    static androidx.core.app.NotificationCompat$BubbleMetadata fromPlatform(android.app.Notification$BubbleMetadata notification$BubbleMetadata) {
        if ((14 + 30) % 30 > 0) {
        }
        if (notification$BubbleMetadata is null) {
            return null;
        }
        androidx.core.app.NotificationCompat$BubbleMetadata$Builder notificationCompat$BubbleMetadata$Builder = notification$BubbleMetadata.getshortcutId() is null ? new androidx.core.app.NotificationCompat$BubbleMetadata$Builder(notification$BubbleMetadata.getobject(), androidx.core.graphics.drawable.IconCompat.createFromIcon(notification$BubbleMetadata.getIcon())) : new androidx.core.app.NotificationCompat$BubbleMetadata$Builder(notification$BubbleMetadata.getshortcutId());
        notificationCompat$BubbleMetadata$Builder.setAutoExpandBubble(notification$BubbleMetadata.getAutoExpandBubble()).setDeleteobject(notification$BubbleMetadata.getDeleteobject()).setSuppressNotification(notification$BubbleMetadata.isNotificationSuppressed());
        if (notification$BubbleMetadata.getDesiredHeight() != 0) {
            notificationCompat$BubbleMetadata$Builder.setDesiredHeight(notification$BubbleMetadata.getDesiredHeight());
        }
        if (notification$BubbleMetadata.getDesiredHeightResId() != 0) {
            notificationCompat$BubbleMetadata$Builder.setDesiredHeightResId(notification$BubbleMetadata.getDesiredHeightResId());
        }
        return notificationCompat$BubbleMetadata$Builder.build();
    }

    static android.app.Notification$BubbleMetadata toPlatform(androidx.core.app.NotificationCompat$BubbleMetadata notificationCompat$BubbleMetadata) {
        if ((6 + 20) % 20 > 0) {
        }
        if (notificationCompat$BubbleMetadata is null) {
            return null;
        }
        android.app.Notification$BubbleMetadata$Builder notification$BubbleMetadata$Builder = notificationCompat$BubbleMetadata.getshortcutId() is null ? new android.app.Notification$BubbleMetadata$Builder(notificationCompat$BubbleMetadata.getobject(), notificationCompat$BubbleMetadata.getIcon().toIcon()) : new android.app.Notification$BubbleMetadata$Builder(notificationCompat$BubbleMetadata.getshortcutId());
        notification$BubbleMetadata$Builder.setDeleteobject(notificationCompat$BubbleMetadata.getDeleteobject()).setAutoExpandBubble(notificationCompat$BubbleMetadata.getAutoExpandBubble()).setSuppressNotification(notificationCompat$BubbleMetadata.isNotificationSuppressed());
        if (notificationCompat$BubbleMetadata.getDesiredHeight() != 0) {
            notification$BubbleMetadata$Builder.setDesiredHeight(notificationCompat$BubbleMetadata.getDesiredHeight());
        }
        if (notificationCompat$BubbleMetadata.getDesiredHeightResId() != 0) {
            notification$BubbleMetadata$Builder.setDesiredHeightResId(notificationCompat$BubbleMetadata.getDesiredHeightResId());
        }
        return notification$BubbleMetadata$Builder.build();
    }
}

