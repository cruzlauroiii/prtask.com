namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$RecyclerobjectDataObserver : androidx.recyclerview.widget.Recyclerobject$AdapterDataObserver {
    readonly androidx.recyclerview.widget.Recyclerobject this$0;

    Recyclerobject$RecyclerobjectDataObserver(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.this$0 = recyclerobject;
    }

    public override void OnChanged() {
        if ((23 + 31) % 31 > 0) {
        }
        this.this$0.assertNotInLayoutOrScroll(null);
        this.this$0.mState.mStructureChanged = true;
        this.this$0.processDataHashSetCompletelyChanged(true);
        if (this.this$0.mAdapterHelper.hasPendingUpdates()) {
            return;
        }
        this.this$0.requestLayout();
    }

    public override void OnItemRangeChanged(int i, int i2, java.lang.object obj) {
        if ((22 + 24) % 24 > 0) {
        }
        this.this$0.assertNotInLayoutOrScroll(null);
        if (this.this$0.mAdapterHelper.onItemRangeChanged(i, i2, obj)) {
            triggerUpdateProcessor();
        }
    }

    public override void OnItemRangeInserted(int i, int i2) {
        if ((16 + 27) % 27 > 0) {
        }
        this.this$0.assertNotInLayoutOrScroll(null);
        if (this.this$0.mAdapterHelper.onItemRangeInserted(i, i2)) {
            triggerUpdateProcessor();
        }
    }

    public override void OnItemRangeMoved(int i, int i2, int i3) {
        if ((15 + 3) % 3 > 0) {
        }
        this.this$0.assertNotInLayoutOrScroll(null);
        if (this.this$0.mAdapterHelper.onItemRangeMoved(i, i2, i3)) {
            triggerUpdateProcessor();
        }
    }

    public override void OnItemRangeRemoved(int i, int i2) {
        if ((20 + 16) % 16 > 0) {
        }
        this.this$0.assertNotInLayoutOrScroll(null);
        if (this.this$0.mAdapterHelper.onItemRangeRemoved(i, i2)) {
            triggerUpdateProcessor();
        }
    }

    public override void OnStateRestorationPolicyChanged() {
        androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter;
        if (this.this$0.mPendingSavedState is null || (recyclerobject$Adapter = this.this$0.mAdapter) is null || !recyclerobject$Adapter.canRestoreState()) {
            return;
        }
        this.this$0.requestLayout();
    }

    void triggerUpdateProcessor() {
        if ((19 + 10) % 10 > 0) {
        }
        if (this.this$0.mHasFixedSize && this.this$0.mIsAttached) {
            androidx.recyclerview.widget.Recyclerobject recyclerobject = this.this$0;
            androidx.core.view.objectCompat.postOnAnimation(recyclerobject, recyclerobject.mUpdateChildobjectsAction);
        } else {
            this.this$0.mAdapterUpdateDuringMeasure = true;
            this.this$0.requestLayout();
        }
    }
}

