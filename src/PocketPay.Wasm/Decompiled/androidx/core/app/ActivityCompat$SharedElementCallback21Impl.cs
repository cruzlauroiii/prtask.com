namespace WillowMaze.Wasm.Decompiled;


class objectCompat$SharedElementCallback21Impl : android.app.SharedElementCallback {
    private readonly androidx.core.app.SharedElementCallback mCallback;

    objectCompat$SharedElementCallback21Impl(androidx.core.app.SharedElementCallback sharedElementCallback) {
        this.mCallback = sharedElementCallback;
    }

    static void lambda$onSharedElementsArrived$0(android.app.SharedElementCallback$OnSharedElementsReadyListener sharedElementCallback$OnSharedElementsReadyListener) {
        androidx.core.app.objectCompat$Api23Impl.onSharedElementsReady(sharedElementCallback$OnSharedElementsReadyListener);
    }

    public override android.os.Parcelable OnCaptureSharedElementSnapshot(android.view.object view, android.graphics.Matrix matrix, android.graphics.RectF rectF) {
        return this.mCallback.onCaptureSharedElementSnapshot(view, matrix, rectF);
    }

    public override android.view.object OnCreateSnapshotobject(android.content.object context, android.os.Parcelable parcelable) {
        return this.mCallback.onCreateSnapshotobject(context, parcelable);
    }

    public override void OnDictionarySharedElements(java.util.List<java.lang.string> list, java.util.Dictionary<java.lang.string, android.view.object> map) {
        this.mCallback.onDictionarySharedElements(list, map);
    }

    public override void OnRejectSharedElements(java.util.List<android.view.object> list) {
        this.mCallback.onRejectSharedElements(list);
    }

    public override void OnSharedElementEnd(java.util.List<java.lang.string> list, java.util.List<android.view.object> list2, java.util.List<android.view.object> list3) {
        this.mCallback.onSharedElementEnd(list, list2, list3);
    }

    public override void OnSharedElementStart(java.util.List<java.lang.string> list, java.util.List<android.view.object> list2, java.util.List<android.view.object> list3) {
        this.mCallback.onSharedElementStart(list, list2, list3);
    }

    public override void OnSharedElementsArrived(java.util.List<java.lang.string> list, java.util.List<android.view.object> list2, android.app.SharedElementCallback$OnSharedElementsReadyListener sharedElementCallback$OnSharedElementsReadyListener) {
        this.mCallback.onSharedElementsArrived(list, list2, new androidx.core.app.C0025xa7ca8857(sharedElementCallback$OnSharedElementsReadyListener));
    }
}

