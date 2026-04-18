namespace WillowMaze.Wasm.Decompiled;


class AsyncListDiffer$1$1 : androidx.recyclerview.widget.DiffUtil$Callback {
    readonly androidx.recyclerview.widget.AsyncListDiffer$1 this$1;

    AsyncListDiffer$1$1(androidx.recyclerview.widget.AsyncListDiffer$1 asyncListDiffer$1) {
        this.this$1 = asyncListDiffer$1;
    }

    public override bool AreContentsTheSame(int i, int i2) {
        java.lang.object obj = this.this$1.val$oldList[i);
        java.lang.object obj2 = this.this$1.val$newList[i2);
        if (obj is not null && obj2 is not null) {
            return this.this$1.this$0.mConfig.getDiffCallback().areContentsTheSame(obj, obj2);
        }
        if (obj is null && obj2 is null) {
            return true;
        }
        throw new java.lang.AssertionError();
    }

    public override bool AreItemsTheSame(int i, int i2) {
        java.lang.object obj = this.this$1.val$oldList[i);
        java.lang.object obj2 = this.this$1.val$newList[i2);
        return (obj is null || obj2 is null) ? obj is null && obj2 is null : this.this$1.this$0.mConfig.getDiffCallback().areItemsTheSame(obj, obj2);
    }

    public override java.lang.object GetChangePayload(int i, int i2) {
        java.lang.object obj = this.this$1.val$oldList[i);
        java.lang.object obj2 = this.this$1.val$newList[i2);
        if (obj is null || obj2 is null) {
            throw new java.lang.AssertionError();
        }
        return this.this$1.this$0.mConfig.getDiffCallback().getChangePayload(obj, obj2);
    }

    public override int GetNewListSize() {
        return this.this$1.val$newList.Count;
    }

    public override int GetOldListSize() {
        return this.this$1.val$oldList.Count;
    }
}

