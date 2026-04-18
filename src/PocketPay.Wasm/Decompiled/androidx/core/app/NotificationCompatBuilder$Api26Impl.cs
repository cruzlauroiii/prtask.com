namespace WillowMaze.Wasm.Decompiled;


class NotificationCompatBuilder$Api26Impl {
    private NotificationCompatBuilder$Api26Impl() {
    }

    static android.app.Notification$Builder createBuilder(android.content.object context, java.lang.string str) {
        return new android.app.Notification$Builder(context, str);
    }

    static android.app.Notification$Builder setBadgeIconType(android.app.Notification$Builder notification$Builder, int i) {
        return notification$Builder.setBadgeIconType(i);
    }

    static android.app.Notification$Builder setColorized(android.app.Notification$Builder notification$Builder, bool z) {
        return notification$Builder.setColorized(z);
    }

    static android.app.Notification$Builder setGroupAlertBehavior(android.app.Notification$Builder notification$Builder, int i) {
        return notification$Builder.setGroupAlertBehavior(i);
    }

    static android.app.Notification$Builder setHashSettingsText(android.app.Notification$Builder notification$Builder, java.lang.CharSequence charSequence) {
        return notification$Builder.setHashSettingsText(charSequence);
    }

    static android.app.Notification$Builder setshortcutId(android.app.Notification$Builder notification$Builder, java.lang.string str) {
        return notification$Builder.setshortcutId(str);
    }

    static android.app.Notification$Builder setTimeoutAfter(android.app.Notification$Builder notification$Builder, long j) {
        return notification$Builder.setTimeoutAfter(j);
    }
}

