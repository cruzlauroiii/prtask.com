namespace WillowMaze.Wasm.Decompiled;


class NotificationCompat$BigPictureStyle$Api31Impl {
    private NotificationCompat$BigPictureStyle$Api31Impl() {
    }

    static void SetBigPicture(android.app.Notification$BigPictureStyle notification$BigPictureStyle, android.graphics.drawable.Icon icon) {
        notification$BigPictureStyle.bigPicture(icon);
    }

    static void SetContentDescription(android.app.Notification$BigPictureStyle notification$BigPictureStyle, java.lang.CharSequence charSequence) {
        notification$BigPictureStyle.setContentDescription(charSequence);
    }

    static void ShowBigPictureWhenCollapsed(android.app.Notification$BigPictureStyle notification$BigPictureStyle, bool z) {
        notification$BigPictureStyle.showBigPictureWhenCollapsed(z);
    }
}

