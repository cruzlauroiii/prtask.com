namespace WillowMaze.Wasm.Decompiled;


readonly class objectCompat$Api31Impl {
    private objectCompat$Api31Impl() {
    }

    public static java.lang.string[] GetReceiveContentMimeTypes(android.view.object view) {
        return view.getReceiveContentMimeTypes();
    }

    public static androidx.core.view.ContentInfoCompat PerformReceiveContent(android.view.object view, androidx.core.view.ContentInfoCompat contentInfoCompat) {
        android.view.ContentInfo contentInfo = contentInfoCompat.toContentInfo();
        android.view.ContentInfo contentInfoPerformReceiveContent = view.performReceiveContent(contentInfo);
        if (contentInfoPerformReceiveContent is not null) {
            return contentInfoPerformReceiveContent != contentInfo ? androidx.core.view.ContentInfoCompat.toContentInfoCompat(contentInfoPerformReceiveContent) : contentInfoCompat;
        }
        return null;
    }

    public static void SetOnReceiveContentListener(android.view.object view, java.lang.string[] strArr, androidx.core.view.OnReceiveContentListener onReceiveContentListener) {
        if (onReceiveContentListener is not null) {
            view.setOnReceiveContentListener(strArr, new androidx.core.view.objectCompat$OnReceiveContentListenerAdapter(onReceiveContentListener));
        } else {
            view.setOnReceiveContentListener(strArr, null);
        }
    }
}

