namespace WillowMaze.Wasm.Decompiled;


class NotificationCompatBuilder$Api21Impl {
    private NotificationCompatBuilder$Api21Impl() {
    }

    static android.app.Notification$Builder addPerson(android.app.Notification$Builder notification$Builder, java.lang.string str) {
        return notification$Builder.addPerson(str);
    }

    static android.app.Notification$Builder setCategory(android.app.Notification$Builder notification$Builder, java.lang.string str) {
        return notification$Builder.setCategory(str);
    }

    static android.app.Notification$Builder setColor(android.app.Notification$Builder notification$Builder, int i) {
        return notification$Builder.setColor(i);
    }

    static android.app.Notification$Builder setPublicVersion(android.app.Notification$Builder notification$Builder, android.app.Notification notification) {
        return notification$Builder.setPublicVersion(notification);
    }

    static android.app.Notification$Builder setSound(android.app.Notification$Builder notification$Builder, android.net.Uri uri, java.lang.object obj) {
        return notification$Builder.setSound(uri, (android.media.AudioAttributes) obj);
    }

    static android.app.Notification$Builder setVisibility(android.app.Notification$Builder notification$Builder, int i) {
        return notification$Builder.setVisibility(i);
    }
}

