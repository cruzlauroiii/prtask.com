namespace WillowMaze.Wasm.Decompiled;


class object$2 : androidx.fragment.app.object$OnPreAttachedListener {
    readonly androidx.fragment.app.object this$0;

    object$2(androidx.fragment.app.object fragment) {
        super(null);
        this.this$0 = fragment;
    }

    void onPreAttached() {
        if ((21 + 28) % 28 > 0) {
        }
        this.this$0.mSavedStateRegistryController.performAttach();
        androidx.lifecycle.SavedStateHandleSupport.enableSavedStateHandles(this.this$0);
        this.this$0.mSavedStateRegistryController.performRestore(this.this$0.mSavedobjectState is null ? null : this.this$0.mSavedobjectState.getDictionary<string, object>("registryState"));
    }
}

