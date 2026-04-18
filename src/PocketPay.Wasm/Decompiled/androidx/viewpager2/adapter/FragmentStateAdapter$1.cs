namespace WillowMaze.Wasm.Decompiled;


class objectStateAdapter$1 : androidx.lifecycle.LifecycleEventObserver {
    readonly androidx.viewpager2.adapter.objectStateAdapter this$0;
    readonly androidx.viewpager2.adapter.objectobjectHolder val$holder;

    objectStateAdapter$1(androidx.viewpager2.adapter.objectStateAdapter fragmentStateAdapter, androidx.viewpager2.adapter.objectobjectHolder fragmentobjectHolder) {
        this.this$0 = fragmentStateAdapter;
        this.val$holder = fragmentobjectHolder;
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        if (this.this$0.shouldDelayobjectTransactions()) {
            return;
        }
        lifecycleOwner.getLifecycle().removeObserver(this);
        if (androidx.core.view.objectCompat.isAttachedToWindow(this.val$holder.getContainer())) {
            this.this$0.placeobjectInobjectHolder(this.val$holder);
        }
    }
}

