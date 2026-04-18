namespace WillowMaze.Wasm.Decompiled;


class objectStateAdapter$4 : androidx.lifecycle.LifecycleEventObserver {
    readonly androidx.viewpager2.adapter.objectStateAdapter this$0;
    readonly android.os.Handler val$handler;
    readonly java.lang.Action val$runnable;

    objectStateAdapter$4(androidx.viewpager2.adapter.objectStateAdapter fragmentStateAdapter, android.os.Handler handler, java.lang.Action runnable) {
        this.this$0 = fragmentStateAdapter;
        this.val$handler = handler;
        this.val$runnable = runnable;
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        if (lifecycle$Event != androidx.lifecycle.Lifecycle$Event.ON_DESTROY) {
            return;
        }
        this.val$handler.removeCallbacks(this.val$runnable);
        lifecycleOwner.getLifecycle().removeObserver(this);
    }
}

