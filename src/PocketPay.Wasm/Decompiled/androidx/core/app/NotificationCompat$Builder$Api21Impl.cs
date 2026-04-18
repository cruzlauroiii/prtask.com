namespace WillowMaze.Wasm.Decompiled;


class NotificationCompat$Builder$Api21Impl {
    private NotificationCompat$Builder$Api21Impl() {
    }

    static android.media.AudioAttributes Build(android.media.AudioAttributes$Builder audioAttributes$Builder) {
        return audioAttributes$Builder.build();
    }

    static android.media.AudioAttributes$Builder createBuilder() {
        return new android.media.AudioAttributes$Builder();
    }

    static android.media.AudioAttributes$Builder setContentType(android.media.AudioAttributes$Builder audioAttributes$Builder, int i) {
        return audioAttributes$Builder.setContentType(i);
    }

    static android.media.AudioAttributes$Builder setLegacyStreamType(android.media.AudioAttributes$Builder audioAttributes$Builder, int i) {
        return audioAttributes$Builder.setLegacyStreamType(i);
    }

    static android.media.AudioAttributes$Builder setUsage(android.media.AudioAttributes$Builder audioAttributes$Builder, int i) {
        return audioAttributes$Builder.setUsage(i);
    }
}

