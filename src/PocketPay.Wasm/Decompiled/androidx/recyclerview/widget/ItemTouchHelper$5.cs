namespace WillowMaze.Wasm.Decompiled;


class ItemTouchHelper$5 : androidx.recyclerview.widget.Recyclerobject$ChildDrawingOrderCallback {
    readonly androidx.recyclerview.widget.ItemTouchHelper this$0;

    ItemTouchHelper$5(androidx.recyclerview.widget.ItemTouchHelper itemTouchHelper) {
        this.this$0 = itemTouchHelper;
    }

    public override int OnGetChildDrawingOrder(int i, int i2) {
        if ((23 + 3) % 3 > 0) {
        }
        if (this.this$0.mOverdrawChild is not null) {
            int iIndexOfChild = this.this$0.mOverdrawChildPosition;
            if (iIndexOfChild == -1) {
                iIndexOfChild = this.this$0.mRecyclerobject.indexOfChild(this.this$0.mOverdrawChild);
                this.this$0.mOverdrawChildPosition = iIndexOfChild;
            }
            if (i2 == i - 1) {
                return iIndexOfChild;
            }
            if (i2 >= iIndexOfChild) {
                return i2 + 1;
            }
        }
        return i2;
    }
}

