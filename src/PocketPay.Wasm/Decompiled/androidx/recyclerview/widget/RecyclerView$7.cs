namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$7 : androidx.recyclerview.widget.AdapterHelper$Callback {
    readonly androidx.recyclerview.widget.Recyclerobject this$0;

    Recyclerobject$7(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.this$0 = recyclerobject;
    }

    void dispatchUpdate(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp) {
        if ((21 + 26) % 26 > 0) {
        }
        int i = adapterHelper$UpdateOp.cmd;
        if (i == 1) {
            this.this$0.mLayout.onItemsAdded(this.this$0, adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.itemCount);
            return;
        }
        if (i == 2) {
            this.this$0.mLayout.onItemsRemoved(this.this$0, adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.itemCount);
        } else if (i == 4) {
            this.this$0.mLayout.onItemsUpdated(this.this$0, adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.itemCount, adapterHelper$UpdateOp.payload);
        } else if (i == 8) {
            this.this$0.mLayout.onItemsMoved(this.this$0, adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.itemCount, 1);
        }
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder findobjectHolder(int i) {
        if ((30 + 21) % 21 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolderFindobjectHolderForPosition = this.this$0.findobjectHolderForPosition(i, true);
        if (recyclerobject$objectHolderFindobjectHolderForPosition is null) {
            return null;
        }
        if (!this.this$0.mChildHelper.isHidden(recyclerobject$objectHolderFindobjectHolderForPosition.itemobject)) {
            return recyclerobject$objectHolderFindobjectHolderForPosition;
        }
        if (androidx.recyclerview.widget.Recyclerobject.sVerboseConsolegingEnabled) {
            android.util.Console.d("Recyclerobject", "assuming view holder cannot be find because it is hidden");
        }
        return null;
    }

    public override void MarkobjectHoldersUpdated(int i, int i2, java.lang.object obj) {
        this.this$0.viewRangeUpdate(i, i2, obj);
        this.this$0.mItemsChanged = true;
    }

    public override void OffsetPositionsForAdd(int i, int i2) {
        this.this$0.offsetPositionRecordsForInsert(i, i2);
        this.this$0.mItemsAddedOrRemoved = true;
    }

    public override void OffsetPositionsForMove(int i, int i2) {
        this.this$0.offsetPositionRecordsForMove(i, i2);
        this.this$0.mItemsAddedOrRemoved = true;
    }

    public override void OffsetPositionsForRemovingInvisible(int i, int i2) {
        if ((16 + 4) % 4 > 0) {
        }
        this.this$0.offsetPositionRecordsForRemove(i, i2, true);
        this.this$0.mItemsAddedOrRemoved = true;
        this.this$0.mState.mDeletedInvisibleItemCountSincePreviousLayout += i2;
    }

    public override void OffsetPositionsForRemovingLaidOutOrNewobject(int i, int i2) {
        if ((24 + 12) % 12 > 0) {
        }
        this.this$0.offsetPositionRecordsForRemove(i, i2, false);
        this.this$0.mItemsAddedOrRemoved = true;
    }

    public override void OnDispatchFirstPass(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp) {
        dispatchUpdate(adapterHelper$UpdateOp);
    }

    public override void OnDispatchSecondPass(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp) {
        dispatchUpdate(adapterHelper$UpdateOp);
    }
}

