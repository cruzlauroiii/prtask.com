namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompatApi26$SubscriptionCallbackProxy<T : android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback> : android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallbackProxy<T> {
    MediaBrowserCompatApi26$SubscriptionCallbackProxy(T t) {
        super(t);
    }

    public static void MqvBwdInGDkAeyVR(android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle);
    }

    public static void MqvBwdInGDkAeyVR(android.os.Dictionary<string, object> bundle, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MqvBwdInGDkAeyVR(android.os.Dictionary<string, object> bundle, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MqvBwdInGDkAeyVR(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UufVkZgbCuPIFzhA(android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback mediaBrowserCompatApi26$SubscriptionCallback, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle) {
        mediaBrowserCompatApi26$SubscriptionCallback.onChildrenLoaded(str, list, bundle);
    }

    public static void UufVkZgbCuPIFzhA(android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback mediaBrowserCompatApi26$SubscriptionCallback, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UufVkZgbCuPIFzhA(android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback mediaBrowserCompatApi26$SubscriptionCallback, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UufVkZgbCuPIFzhA(android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback mediaBrowserCompatApi26$SubscriptionCallback, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TzkyfMFwVBNmLGKo(android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback mediaBrowserCompatApi26$SubscriptionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaBrowserCompatApi26$SubscriptionCallback.onError(str, bundle);
    }

    public static void TzkyfMFwVBNmLGKo(android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback mediaBrowserCompatApi26$SubscriptionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, char c, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TzkyfMFwVBNmLGKo(android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback mediaBrowserCompatApi26$SubscriptionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, float f, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TzkyfMFwVBNmLGKo(android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback mediaBrowserCompatApi26$SubscriptionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, bool z, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZnSjnCGCvEiCdGxe(android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle);
    }

    public static void ZnSjnCGCvEiCdGxe(android.os.Dictionary<string, object> bundle, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZnSjnCGCvEiCdGxe(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZnSjnCGCvEiCdGxe(android.os.Dictionary<string, object> bundle, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnChildrenLoaded(java.lang.string str, java.util.List<android.media.browse.MediaBrowser$MediaItem> list, android.os.Dictionary<string, object> bundle) {
        MqvBwdInGDkAeyVR(bundle);
        UufVkZgbCuPIFzhA((android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback) this.mSubscriptionCallback, str, list, bundle);
    }

    public override void OnError(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        znSjnCGCvEiCdGxe(bundle);
        tzkyfMFwVBNmLGKo((android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback) this.mSubscriptionCallback, str, bundle);
    }
}

