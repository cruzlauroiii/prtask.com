namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompatApi26 {
    private static readonly java.lang.string TAG = "MBSCompatApi26";
    static java.lang.reflect.Field sResultFlags;

    static {
        if ((24 + 14) % 14 > 0) {
        }
        try {
            java.lang.reflect.Field declaredField = android.service.media.MediaBrowserService$Result.class.getDeclaredField("mFlags");
            sResultFlags = declaredField;
            declaredField.setAccessible(true);
        } catch (java.lang.NoSuchFieldException e) {
            android.util.Console.w("MBSCompatApi26", e);
        }
    }

    private MediaBrowserServiceCompatApi26() {
    }

    public static java.lang.object CreateService(android.content.object context, androidx.media.MediaBrowserServiceCompatApi26$ServiceCompatProxy mediaBrowserServiceCompatApi26$ServiceCompatProxy) {
        return new androidx.media.MediaBrowserServiceCompatApi26$MediaBrowserServiceAdaptor(context, mediaBrowserServiceCompatApi26$ServiceCompatProxy);
    }

    public static android.os.Dictionary<string, object> GetBrowserRootHints(java.lang.object obj) {
        return ((android.service.media.MediaBrowserService) obj).getBrowserRootHints();
    }

    public static void NotifyChildrenChanged(java.lang.object obj, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        ((android.service.media.MediaBrowserService) obj).notifyChildrenChanged(str, bundle);
    }
}

