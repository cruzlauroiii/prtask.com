namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$4 : androidx.recyclerview.widget.objectInfoStore$ProcessCallback {
    readonly androidx.recyclerview.widget.Recyclerobject this$0;

    Recyclerobject$4(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.this$0 = recyclerobject;
    }

    public override void ProcessAppeared(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2) {
        this.this$0.animateAppearance(recyclerobject$objectHolder, recyclerobject$ItemAnimator$ItemHolderInfo, recyclerobject$ItemAnimator$ItemHolderInfo2);
    }

    public override void ProcessDisappeared(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2) {
        this.this$0.mRecycler.unscrapobject(recyclerobject$objectHolder);
        this.this$0.animateDisappearance(recyclerobject$objectHolder, recyclerobject$ItemAnimator$ItemHolderInfo, recyclerobject$ItemAnimator$ItemHolderInfo2);
    }

    public override void ProcessPersistent(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2) {
        recyclerobject$objectHolder.setIsRecyclable(false);
        if (this.this$0.mDataHashSetHasChangedAfterLayout) {
            if (this.this$0.mItemAnimator.animateChange(recyclerobject$objectHolder, recyclerobject$objectHolder, recyclerobject$ItemAnimator$ItemHolderInfo, recyclerobject$ItemAnimator$ItemHolderInfo2)) {
                this.this$0.postAnimationRunner();
            }
        } else if (this.this$0.mItemAnimator.animatePersistence(recyclerobject$objectHolder, recyclerobject$ItemAnimator$ItemHolderInfo, recyclerobject$ItemAnimator$ItemHolderInfo2)) {
            this.this$0.postAnimationRunner();
        }
    }

    public override void Unused(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        this.this$0.mLayout.removeAndRecycleobject(recyclerobject$objectHolder.itemobject, this.this$0.mRecycler);
    }
}

