namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplApi21$7 : java.lang.Action {
    readonly android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 this$0;
    readonly java.lang.string val$action;
    readonly android.support.v4.media.MediaBrowserCompat$CustomActionCallback val$callback;
    readonly android.os.Dictionary<string, object> val$extras;

    MediaBrowserCompat$MediaBrowserImplApi21$7(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.this$0 = mediaBrowserCompat$MediaBrowserImplApi21;
        this.val$callback = mediaBrowserCompat$CustomActionCallback;
        this.val$action = str;
        this.val$extras = bundle;
    }

    public static void PBTvUQapOvBkGOOd(android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        mediaBrowserCompat$CustomActionCallback.onError(str, bundle, bundle2);
    }

    public static void PBTvUQapOvBkGOOd(android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PBTvUQapOvBkGOOd(android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PBTvUQapOvBkGOOd(android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        if ((18 + 25) % 25 > 0) {
        }
        PBTvUQapOvBkGOOd(this.val$callback, this.val$action, this.val$extras, null);
    }
}

