namespace WillowMaze.Wasm.Decompiled;


class NotificationChannelCompat$Api26Impl {
    private NotificationChannelCompat$Api26Impl() {
    }

    static bool CanBypassDnd(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.canBypassDnd();
    }

    static bool CanShowBadge(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.canShowBadge();
    }

    static android.app.NotificationChannel CreateNotificationChannel(java.lang.string str, java.lang.CharSequence charSequence, int i) {
        return new android.app.NotificationChannel(str, charSequence, i);
    }

    static void EnableLights(android.app.NotificationChannel notificationChannel, bool z) {
        notificationChannel.enableLights(z);
    }

    static void EnableVibration(android.app.NotificationChannel notificationChannel, bool z) {
        notificationChannel.enableVibration(z);
    }

    static android.media.AudioAttributes GetAudioAttributes(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getAudioAttributes();
    }

    static java.lang.string GetDescription(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getDescription();
    }

    static java.lang.string GetGroup(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getGroup();
    }

    static java.lang.string GetId(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getId();
    }

    static int GetImportance(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getImportance();
    }

    static int GetLightColor(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getLightColor();
    }

    static int GetLockscreenVisibility(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getLockscreenVisibility();
    }

    static java.lang.CharSequence GetName(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getName();
    }

    static android.net.Uri GetSound(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getSound();
    }

    static long[] GetVibrationRegex(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getVibrationRegex();
    }

    static void SetDescription(android.app.NotificationChannel notificationChannel, java.lang.string str) {
        notificationChannel.setDescription(str);
    }

    static void SetGroup(android.app.NotificationChannel notificationChannel, java.lang.string str) {
        notificationChannel.setGroup(str);
    }

    static void SetLightColor(android.app.NotificationChannel notificationChannel, int i) {
        notificationChannel.setLightColor(i);
    }

    static void SetShowBadge(android.app.NotificationChannel notificationChannel, bool z) {
        notificationChannel.setShowBadge(z);
    }

    static void SetSound(android.app.NotificationChannel notificationChannel, android.net.Uri uri, android.media.AudioAttributes audioAttributes) {
        notificationChannel.setSound(uri, audioAttributes);
    }

    static void SetVibrationRegex(android.app.NotificationChannel notificationChannel, long[] jArr) {
        notificationChannel.setVibrationRegex(jArr);
    }

    static bool ShouldShowLights(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.shouldShowLights();
    }

    static bool ShouldVibrate(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.shouldVibrate();
    }
}

