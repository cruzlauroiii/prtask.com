namespace WillowMaze.Wasm.Decompiled;


class NotificationCompatBuilder$Api20Impl {
    private NotificationCompatBuilder$Api20Impl() {
    }

    static android.app.Notification$Builder addAction(android.app.Notification$Builder notification$Builder, android.app.Notification$Action notification$Action) {
        return notification$Builder.addAction(notification$Action);
    }

    static android.app.Notification$Action$Builder addExtras(android.app.Notification$Action$Builder notification$Action$Builder, android.os.Dictionary<string, object> bundle) {
        return notification$Action$Builder.addExtras(bundle);
    }

    static android.app.Notification$Action$Builder addRemoteInput(android.app.Notification$Action$Builder notification$Action$Builder, android.app.RemoteInput remoteInput) {
        return notification$Action$Builder.addRemoteInput(remoteInput);
    }

    static android.app.Notification$Action build(android.app.Notification$Action$Builder notification$Action$Builder) {
        return notification$Action$Builder.build();
    }

    static android.app.Notification$Action$Builder createBuilder(int i, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject) {
        return new android.app.Notification$Action$Builder(i, charSequence, pendingobject);
    }

    static java.lang.string GetGroup(android.app.Notification notification) {
        return notification.getGroup();
    }

    static android.app.Notification$Builder setGroup(android.app.Notification$Builder notification$Builder, java.lang.string str) {
        return notification$Builder.setGroup(str);
    }

    static android.app.Notification$Builder setGroupSummary(android.app.Notification$Builder notification$Builder, bool z) {
        return notification$Builder.setGroupSummary(z);
    }

    static android.app.Notification$Builder setLocalOnly(android.app.Notification$Builder notification$Builder, bool z) {
        return notification$Builder.setLocalOnly(z);
    }

    static android.app.Notification$Builder setSortKey(android.app.Notification$Builder notification$Builder, java.lang.string str) {
        return notification$Builder.setSortKey(str);
    }
}

