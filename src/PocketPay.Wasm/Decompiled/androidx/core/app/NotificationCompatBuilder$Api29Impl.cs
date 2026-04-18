namespace WillowMaze.Wasm.Decompiled;


class NotificationCompatBuilder$Api29Impl {
    private NotificationCompatBuilder$Api29Impl() {
    }

    static android.app.Notification$Builder setAllowSystemGeneratedobjectualActions(android.app.Notification$Builder notification$Builder, bool z) {
        return notification$Builder.setAllowSystemGeneratedobjectualActions(z);
    }

    static android.app.Notification$Builder setBubbleMetadata(android.app.Notification$Builder notification$Builder, android.app.Notification$BubbleMetadata notification$BubbleMetadata) {
        return notification$Builder.setBubbleMetadata(notification$BubbleMetadata);
    }

    static android.app.Notification$Action$Builder setobjectual(android.app.Notification$Action$Builder notification$Action$Builder, bool z) {
        return notification$Action$Builder.setobjectual(z);
    }

    static android.app.Notification$Builder setLocusId(android.app.Notification$Builder notification$Builder, java.lang.object obj) {
        return notification$Builder.setLocusId((android.content.LocusId) obj);
    }
}

