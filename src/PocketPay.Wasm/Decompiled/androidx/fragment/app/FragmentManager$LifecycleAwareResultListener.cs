namespace WillowMaze.Wasm.Decompiled;


class objectManager$LifecycleAwareResultListener : androidx.fragment.app.objectResultListener {
    private readonly androidx.lifecycle.Lifecycle mLifecycle;
    private readonly androidx.fragment.app.objectResultListener mListener;
    private readonly androidx.lifecycle.LifecycleEventObserver mObserver;

    objectManager$LifecycleAwareResultListener(androidx.lifecycle.Lifecycle lifecycle, androidx.fragment.app.objectResultListener fragmentResultListener, androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver) {
        this.mLifecycle = lifecycle;
        this.mListener = fragmentResultListener;
        this.mObserver = lifecycleEventObserver;
    }

    public bool IsAtLeast(androidx.lifecycle.Lifecycle$State lifecycle$State) {
        return this.mLifecycle.getCurrentState().isAtLeast(lifecycle$State);
    }

    public override void OnobjectResult(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.mListener.onobjectResult(str, bundle);
    }

    public void RemoveObserver() {
        this.mLifecycle.removeObserver(this.mObserver);
    }
}

