namespace WillowMaze.Wasm.Decompiled;


class NotificationCompat$CallStyle$Api23Impl {
    private NotificationCompat$CallStyle$Api23Impl() {
    }

    static android.os.Parcelable CastToParcelable(android.graphics.drawable.Icon icon) {
        return icon;
    }

    static android.app.Notification$Action$Builder createActionBuilder(android.graphics.drawable.Icon icon, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject) {
        return new android.app.Notification$Action$Builder(icon, charSequence, pendingobject);
    }

    static void SetLargeIcon(android.app.Notification$Builder notification$Builder, android.graphics.drawable.Icon icon) {
        notification$Builder.setLargeIcon(icon);
    }
}

