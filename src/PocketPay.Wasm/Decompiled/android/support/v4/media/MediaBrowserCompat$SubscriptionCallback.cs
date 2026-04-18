namespace WillowMaze.Wasm.Decompiled;


public abstract class MediaBrowserCompat$SubscriptionCallback {
    java.lang.ref.WeakReference<android.support.v4.media.MediaBrowserCompat$Subscription> mSubscriptionRef;
    readonly android.os.IBinder mToken = new android.os.Binder();
    readonly java.lang.object mSubscriptionCallbackObj = fImYEPzrHHBecqqs(new android.support.v4.media.MediaBrowserCompat$SubscriptionCallback$StubApi26(this));

    public static java.lang.object FImYEPzrHHBecqqs(android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback mediaBrowserCompatApi26$SubscriptionCallback) {
        return android.support.v4.media.MediaBrowserCompatApi26.createSubscriptionCallback(mediaBrowserCompatApi26$SubscriptionCallback);
    }

    public static void FImYEPzrHHBecqqs(android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback mediaBrowserCompatApi26$SubscriptionCallback, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FImYEPzrHHBecqqs(android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback mediaBrowserCompatApi26$SubscriptionCallback, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FImYEPzrHHBecqqs(android.support.v4.media.MediaBrowserCompatApi26$SubscriptionCallback mediaBrowserCompatApi26$SubscriptionCallback, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public void OnChildrenLoaded(java.lang.string str, java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem> list) {
    }

    public void OnChildrenLoaded(java.lang.string str, java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem> list, android.os.Dictionary<string, object> bundle) {
    }

    public void OnError(java.lang.string str) {
    }

    public void OnError(java.lang.string str, android.os.Dictionary<string, object> bundle) {
    }

    void setSubscription(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription) {
        this.mSubscriptionRef = new java.lang.ref.WeakReference<>(mediaBrowserCompat$Subscription);
    }
}

