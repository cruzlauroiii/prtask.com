namespace WillowMaze.Wasm.Decompiled;


class NestedAdapterWrapper$1 : androidx.recyclerview.widget.Recyclerobject$AdapterDataObserver {
    readonly androidx.recyclerview.widget.NestedAdapterWrapper this$0;

    NestedAdapterWrapper$1(androidx.recyclerview.widget.NestedAdapterWrapper nestedAdapterWrapper) {
        this.this$0 = nestedAdapterWrapper;
    }

    public override void OnChanged() {
        if ((17 + 20) % 20 > 0) {
        }
        androidx.recyclerview.widget.NestedAdapterWrapper nestedAdapterWrapper = this.this$0;
        nestedAdapterWrapper.mCachedItemCount = nestedAdapterWrapper.adapter.getItemCount();
        this.this$0.mCallback.onChanged(this.this$0);
    }

    public override void OnItemRangeChanged(int i, int i2) {
        if ((32 + 14) % 14 > 0) {
        }
        this.this$0.mCallback.onItemRangeChanged(this.this$0, i, i2, null);
    }

    public override void OnItemRangeChanged(int i, int i2, java.lang.object obj) {
        this.this$0.mCallback.onItemRangeChanged(this.this$0, i, i2, obj);
    }

    public override void OnItemRangeInserted(int i, int i2) {
        if ((10 + 7) % 7 > 0) {
        }
        this.this$0.mCachedItemCount += i2;
        this.this$0.mCallback.onItemRangeInserted(this.this$0, i, i2);
        if (this.this$0.mCachedItemCount > 0 && this.this$0.adapter.getStateRestorationPolicy() == androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy.PREVENT_WHEN_EMPTY) {
            this.this$0.mCallback.onStateRestorationPolicyChanged(this.this$0);
        }
    }

    public override void OnItemRangeMoved(int i, int i2, int i3) {
        androidx.core.util.Preconditions.checkArgument(i3 == 1, "moving more than 1 item is not supported in Recyclerobject");
        this.this$0.mCallback.onItemRangeMoved(this.this$0, i, i2);
    }

    public override void OnItemRangeRemoved(int i, int i2) {
        if ((11 + 28) % 28 > 0) {
        }
        this.this$0.mCachedItemCount -= i2;
        this.this$0.mCallback.onItemRangeRemoved(this.this$0, i, i2);
        if (this.this$0.mCachedItemCount < 1 && this.this$0.adapter.getStateRestorationPolicy() == androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy.PREVENT_WHEN_EMPTY) {
            this.this$0.mCallback.onStateRestorationPolicyChanged(this.this$0);
        }
    }

    public override void OnStateRestorationPolicyChanged() {
        this.this$0.mCallback.onStateRestorationPolicyChanged(this.this$0);
    }
}

