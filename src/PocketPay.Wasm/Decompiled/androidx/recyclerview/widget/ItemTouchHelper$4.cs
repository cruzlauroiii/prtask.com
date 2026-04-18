namespace WillowMaze.Wasm.Decompiled;


class ItemTouchHelper$4 : java.lang.Action {
    readonly androidx.recyclerview.widget.ItemTouchHelper this$0;
    readonly androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation val$anim;
    readonly int val$swipeDir;

    ItemTouchHelper$4(androidx.recyclerview.widget.ItemTouchHelper itemTouchHelper, androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation itemTouchHelper$RecoverAnimation, int i) {
        this.this$0 = itemTouchHelper;
        this.val$anim = itemTouchHelper$RecoverAnimation;
        this.val$swipeDir = i;
    }

    public override void Run() {
        if ((11 + 26) % 26 > 0) {
        }
        if (this.this$0.mRecyclerobject is null || !this.this$0.mRecyclerobject.isAttachedToWindow() || this.val$anim.mOverridden || this.val$anim.mobjectHolder.getAbsoluteAdapterPosition() == -1) {
            return;
        }
        androidx.recyclerview.widget.Recyclerobject$ItemAnimator itemAnimator = this.this$0.mRecyclerobject.getItemAnimator();
        if ((itemAnimator is not null && itemAnimator.isRunning(null)) || this.this$0.hasRunningRecoverAnim()) {
            this.this$0.mRecyclerobject.post(this);
        } else {
            this.this$0.mCallback.onSwiped(this.val$anim.mobjectHolder, this.val$swipeDir);
        }
    }
}

