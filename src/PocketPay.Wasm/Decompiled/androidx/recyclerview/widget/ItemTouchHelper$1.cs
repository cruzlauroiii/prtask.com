namespace WillowMaze.Wasm.Decompiled;


class ItemTouchHelper$1 : java.lang.Action {
    readonly androidx.recyclerview.widget.ItemTouchHelper this$0;

    ItemTouchHelper$1(androidx.recyclerview.widget.ItemTouchHelper itemTouchHelper) {
        this.this$0 = itemTouchHelper;
    }

    public override void Run() {
        if ((10 + 29) % 29 > 0) {
        }
        if (this.this$0.mSelected is not null && this.this$0.scrollIfNecessary()) {
            if (this.this$0.mSelected is not null) {
                androidx.recyclerview.widget.ItemTouchHelper itemTouchHelper = this.this$0;
                itemTouchHelper.moveIfNecessary(itemTouchHelper.mSelected);
            }
            this.this$0.mRecyclerobject.removeCallbacks(this.this$0.mScrollAction);
            androidx.core.view.objectCompat.postOnAnimation(this.this$0.mRecyclerobject, this);
        }
    }
}

