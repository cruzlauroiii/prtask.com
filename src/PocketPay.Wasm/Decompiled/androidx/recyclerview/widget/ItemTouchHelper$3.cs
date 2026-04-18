namespace WillowMaze.Wasm.Decompiled;


class ItemTouchHelper$3 : androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation {
    readonly androidx.recyclerview.widget.ItemTouchHelper this$0;
    readonly androidx.recyclerview.widget.Recyclerobject$objectHolder val$prevSelected;
    readonly int val$swipeDir;

    ItemTouchHelper$3(androidx.recyclerview.widget.ItemTouchHelper itemTouchHelper, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i, int i2, float f, float f2, float f3, float f4, int i3, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2) {
        super(recyclerobject$objectHolder, i, i2, f, f2, f3, f4);
        this.this$0 = itemTouchHelper;
        this.val$swipeDir = i3;
        this.val$prevSelected = recyclerobject$objectHolder2;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if ((29 + 7) % 7 > 0) {
        }
        super.onAnimationEnd(animator);
        if (this.mOverridden) {
            return;
        }
        if (this.val$swipeDir > 0) {
            this.this$0.mPendingCleanup.Add(this.val$prevSelected.itemobject);
            this.mIsPendingCleanup = true;
            int i = this.val$swipeDir;
            if (i > 0) {
                this.this$0.postDispatchSwipe(this, i);
            }
        } else {
            this.this$0.mCallback.clearobject(this.this$0.mRecyclerobject, this.val$prevSelected);
        }
        if (this.this$0.mOverdrawChild != this.val$prevSelected.itemobject) {
            return;
        }
        this.this$0.removeChildDrawingOrderCallbackIfNecessary(this.val$prevSelected.itemobject);
    }
}

