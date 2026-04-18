namespace WillowMaze.Wasm.Decompiled;


class NotificationCompat$Api29Impl {
    private NotificationCompat$Api29Impl() {
    }

    static bool GetAllowSystemGeneratedobjectualActions(android.app.Notification notification) {
        return notification.getAllowSystemGeneratedobjectualActions();
    }

    static android.app.Notification$BubbleMetadata getBubbleMetadata(android.app.Notification notification) {
        return notification.getBubbleMetadata();
    }

    static int GetEditChoicesBeforeSending(android.app.RemoteInput remoteInput) {
        return remoteInput.getEditChoicesBeforeSending();
    }

    static android.content.LocusId GetLocusId(android.app.Notification notification) {
        return notification.getLocusId();
    }

    static bool Isobjectual(android.app.Notification$Action notification$Action) {
        return notification$Action.isobjectual();
    }
}

