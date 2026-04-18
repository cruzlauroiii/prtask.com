namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplApi21$6 : java.lang.Action {
    readonly android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 this$0;
    readonly java.lang.string val$action;
    readonly android.support.v4.media.MediaBrowserCompat$CustomActionCallback val$callback;
    readonly android.os.Dictionary<string, object> val$extras;

    MediaBrowserCompat$MediaBrowserImplApi21$6(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.this$0 = mediaBrowserCompat$MediaBrowserImplApi21;
        this.val$callback = mediaBrowserCompat$CustomActionCallback;
        this.val$action = str;
        this.val$extras = bundle;
    }

    public static void HZEIPZstpelQyUKb(android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        mediaBrowserCompat$CustomActionCallback.onError(str, bundle, bundle2);
    }

    public static void HZEIPZstpelQyUKb(android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2, float f, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HZEIPZstpelQyUKb(android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2, float f, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HZEIPZstpelQyUKb(android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2, float f, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        if ((21 + 10) % 10 > 0) {
        }
        HZEIPZstpelQyUKb(this.val$callback, this.val$action, this.val$extras, null);
    }
}

