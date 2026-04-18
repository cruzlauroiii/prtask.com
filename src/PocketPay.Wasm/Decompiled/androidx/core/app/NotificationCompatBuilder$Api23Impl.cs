namespace WillowMaze.Wasm.Decompiled;


class NotificationCompatBuilder$Api23Impl {
    private NotificationCompatBuilder$Api23Impl() {
    }

    static android.app.Notification$Action$Builder createBuilder(android.graphics.drawable.Icon icon, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject) {
        return new android.app.Notification$Action$Builder(icon, charSequence, pendingobject);
    }

    static android.app.Notification$Builder setLargeIcon(android.app.Notification$Builder notification$Builder, android.graphics.drawable.Icon icon) {
        return notification$Builder.setLargeIcon(icon);
    }

    static android.app.Notification$Builder setSmallIcon(android.app.Notification$Builder notification$Builder, java.lang.object obj) {
        return notification$Builder.setSmallIcon((android.graphics.drawable.Icon) obj);
    }
}

