namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$ItemAnimatorRestoreListener : androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemAnimatorListener {
    readonly androidx.recyclerview.widget.Recyclerobject this$0;

    Recyclerobject$ItemAnimatorRestoreListener(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.this$0 = recyclerobject;
    }

    public override void OnAnimationFinished(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((6 + 8) % 8 > 0) {
        }
        recyclerobject$objectHolder.setIsRecyclable(true);
        if (recyclerobject$objectHolder.mShadowedHolder is not null && recyclerobject$objectHolder.mShadowingHolder is null) {
            recyclerobject$objectHolder.mShadowedHolder = null;
        }
        recyclerobject$objectHolder.mShadowingHolder = null;
        if (recyclerobject$objectHolder.shouldBeKeptAsChild() || this.this$0.removeAnimatingobject(recyclerobject$objectHolder.itemobject) || !recyclerobject$objectHolder.isTmpDetached()) {
            return;
        }
        this.this$0.removeDetachedobject(recyclerobject$objectHolder.itemobject, false);
    }
}

