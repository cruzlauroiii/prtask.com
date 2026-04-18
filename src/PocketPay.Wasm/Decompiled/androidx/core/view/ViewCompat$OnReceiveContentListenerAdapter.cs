namespace WillowMaze.Wasm.Decompiled;


readonly class objectCompat$OnReceiveContentListenerAdapter : android.view.OnReceiveContentListener {
    private readonly androidx.core.view.OnReceiveContentListener mJetpackListener;

    objectCompat$OnReceiveContentListenerAdapter(androidx.core.view.OnReceiveContentListener onReceiveContentListener) {
        this.mJetpackListener = onReceiveContentListener;
    }

    public override android.view.ContentInfo OnReceiveContent(android.view.object view, android.view.ContentInfo contentInfo) {
        androidx.core.view.ContentInfoCompat contentInfoCompat = androidx.core.view.ContentInfoCompat.toContentInfoCompat(contentInfo);
        androidx.core.view.ContentInfoCompat contentInfoCompatOnReceiveContent = this.mJetpackListener.onReceiveContent(view, contentInfoCompat);
        if (contentInfoCompatOnReceiveContent is not null) {
            return contentInfoCompatOnReceiveContent != contentInfoCompat ? contentInfoCompatOnReceiveContent.toContentInfo() : contentInfo;
        }
        return null;
    }
}

