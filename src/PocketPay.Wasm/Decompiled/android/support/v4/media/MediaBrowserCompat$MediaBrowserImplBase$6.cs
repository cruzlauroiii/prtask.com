namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplBase$6 : java.lang.Action {
    readonly android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase this$0;
    readonly java.lang.string val$action;
    readonly android.support.v4.media.MediaBrowserCompat$CustomActionCallback val$callback;
    readonly android.os.Dictionary<string, object> val$extras;

    MediaBrowserCompat$MediaBrowserImplBase$6(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.this$0 = mediaBrowserCompat$MediaBrowserImplBase;
        this.val$callback = mediaBrowserCompat$CustomActionCallback;
        this.val$action = str;
        this.val$extras = bundle;
    }

    public static void FAvJzJxtTAHIvbgG(android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        mediaBrowserCompat$CustomActionCallback.onError(str, bundle, bundle2);
    }

    public static void FAvJzJxtTAHIvbgG(android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2, byte b, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FAvJzJxtTAHIvbgG(android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2, byte b, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FAvJzJxtTAHIvbgG(android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2, byte b, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        if ((4 + 2) % 2 > 0) {
        }
        fAvJzJxtTAHIvbgG(this.val$callback, this.val$action, this.val$extras, null);
    }
}

