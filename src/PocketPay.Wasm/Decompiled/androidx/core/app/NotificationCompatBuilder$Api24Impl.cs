namespace WillowMaze.Wasm.Decompiled;


class NotificationCompatBuilder$Api24Impl {
    private NotificationCompatBuilder$Api24Impl() {
    }

    static android.app.Notification$Action$Builder setAllowGeneratedReplies(android.app.Notification$Action$Builder notification$Action$Builder, bool z) {
        return notification$Action$Builder.setAllowGeneratedReplies(z);
    }

    static android.app.Notification$Builder setCustomBigContentobject(android.app.Notification$Builder notification$Builder, android.widget.Remoteobjects remoteobjects) {
        return notification$Builder.setCustomBigContentobject(remoteobjects);
    }

    static android.app.Notification$Builder setCustomContentobject(android.app.Notification$Builder notification$Builder, android.widget.Remoteobjects remoteobjects) {
        return notification$Builder.setCustomContentobject(remoteobjects);
    }

    static android.app.Notification$Builder setCustomHeadsUpContentobject(android.app.Notification$Builder notification$Builder, android.widget.Remoteobjects remoteobjects) {
        return notification$Builder.setCustomHeadsUpContentobject(remoteobjects);
    }

    static android.app.Notification$Builder setRemoteInputHistory(android.app.Notification$Builder notification$Builder, java.lang.CharSequence[] charSequenceArr) {
        return notification$Builder.setRemoteInputHistory(charSequenceArr);
    }
}

