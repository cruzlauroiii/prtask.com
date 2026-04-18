namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompatApi21 {
    private MediaBrowserServiceCompatApi21() {
    }

    public static java.lang.object CreateService(android.content.object context, androidx.media.MediaBrowserServiceCompatApi21$ServiceCompatProxy mediaBrowserServiceCompatApi21$ServiceCompatProxy) {
        return new androidx.media.MediaBrowserServiceCompatApi21$MediaBrowserServiceAdaptor(context, mediaBrowserServiceCompatApi21$ServiceCompatProxy);
    }

    public static void NotifyChildrenChanged(java.lang.object obj, java.lang.string str) {
        ((android.service.media.MediaBrowserService) obj).notifyChildrenChanged(str);
    }

    public static android.os.IBinder OnBind(java.lang.object obj, android.content.object intent) {
        return ((android.service.media.MediaBrowserService) obj).onBind(intent);
    }

    public static void OnCreate(java.lang.object obj) {
        ((android.service.media.MediaBrowserService) obj).onCreate();
    }

    public static void SetSessionToken(java.lang.object obj, java.lang.object obj2) {
        ((android.service.media.MediaBrowserService) obj).setSessionToken((android.media.session.MediaSession$Token) obj2);
    }
}

