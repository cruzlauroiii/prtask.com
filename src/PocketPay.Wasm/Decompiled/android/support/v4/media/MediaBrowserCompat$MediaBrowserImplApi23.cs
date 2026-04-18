namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplApi23 : android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 {
    MediaBrowserCompat$MediaBrowserImplApi23(android.content.object context, android.content.ComponentName componentName, android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, android.os.Dictionary<string, object> bundle) {
        super(context, componentName, mediaBrowserCompat$ConnectionCallback, bundle);
    }

    public static void DmtOdhzYDnkwYcRq(java.lang.object obj, java.lang.string str, java.lang.object obj2) {
        android.support.v4.media.MediaBrowserCompatApi23.getItem(obj, str, obj2);
    }

    public static void DmtOdhzYDnkwYcRq(java.lang.object obj, java.lang.string str, java.lang.object obj2, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DmtOdhzYDnkwYcRq(java.lang.object obj, java.lang.string str, java.lang.object obj2, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DmtOdhzYDnkwYcRq(java.lang.object obj, java.lang.string str, java.lang.object obj2, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NeGEjNUZBFeTjPUP(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, java.lang.string str, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback) {
        super.getItem(str, mediaBrowserCompat$ItemCallback);
    }

    public static void NeGEjNUZBFeTjPUP(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, java.lang.string str, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, int i, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NeGEjNUZBFeTjPUP(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, java.lang.string str, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str2, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NeGEjNUZBFeTjPUP(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, java.lang.string str, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str2, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public override void GetItem(java.lang.string str, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback) {
        if (this.mServiceBinderWrapper is not null) {
            neGEjNUZBFeTjPUP(this, str, mediaBrowserCompat$ItemCallback);
        } else {
            dmtOdhzYDnkwYcRq(this.mBrowserObj, str, mediaBrowserCompat$ItemCallback.mItemCallbackObj);
        }
    }
}

