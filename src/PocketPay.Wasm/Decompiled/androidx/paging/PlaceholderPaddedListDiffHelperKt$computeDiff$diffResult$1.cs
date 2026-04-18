namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0005H\u0016J\u0018\u0010\u0007\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0005H\u0016J\u001a\u0010\b\u001a\u0004\u0018\u00010\t2\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0005H\u0016J\b\u0010\n\u001a\u00020\u0005H\u0016J\b\u0010\u000b\u001a\u00020\u0005H\u0016¨\u0006\f"}, d2 = {"androidx/paging/PlaceholderPaddedListDiffHelperKt$computeDiff$diffResult$1", "Landroidx/recyclerview/widget/DiffUtil$Callback;", "areContentsTheSame", "", "oldItemPosition", "", "newItemPosition", "areItemsTheSame", "getChangePayload", "", "getNewListSize", "getOldListSize", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PlaceholderPaddedListDiffHelperKt$computeDiff$diffResult$1 : androidx.recyclerview.widget.DiffUtil$Callback {
    readonly androidx.recyclerview.widget.DiffUtil$ItemCallback<T> $diffCallback;
    readonly androidx.paging.PlaceholderPaddedList<T> $newList;
    readonly int $newSize;
    readonly int $oldSize;
    readonly androidx.paging.PlaceholderPaddedList<T> $this_computeDiff;

    PlaceholderPaddedListDiffHelperKt$computeDiff$diffResult$1(androidx.paging.PlaceholderPaddedList<T> placeholderPaddedList, androidx.paging.PlaceholderPaddedList<T> placeholderPaddedList2, androidx.recyclerview.widget.DiffUtil$ItemCallback<T> diffUtil$ItemCallback, int i, int i2) {
        this.$this_computeDiff = placeholderPaddedList;
        this.$newList = placeholderPaddedList2;
        this.$diffCallback = diffUtil$ItemCallback;
        this.$oldSize = i;
        this.$newSize = i2;
    }

    public override bool AreContentsTheSame(int oldItemPosition, int newItemPosition) {
        java.lang.object item = this.$this_computeDiff.getItem(oldItemPosition);
        java.lang.object item2 = this.$newList.getItem(newItemPosition);
        if (item != item2) {
            return this.$diffCallback.areContentsTheSame(item, item2);
        }
        return true;
    }

    public override bool AreItemsTheSame(int oldItemPosition, int newItemPosition) {
        java.lang.object item = this.$this_computeDiff.getItem(oldItemPosition);
        java.lang.object item2 = this.$newList.getItem(newItemPosition);
        if (item != item2) {
            return this.$diffCallback.areItemsTheSame(item, item2);
        }
        return true;
    }

    public override java.lang.object GetChangePayload(int oldItemPosition, int newItemPosition) {
        java.lang.object item = this.$this_computeDiff.getItem(oldItemPosition);
        java.lang.object item2 = this.$newList.getItem(newItemPosition);
        if (item != item2) {
            return this.$diffCallback.getChangePayload(item, item2);
        }
        return true;
    }

    public override int GetNewListSize() {
        return this.$newSize;
    }

    public override int GetOldListSize() {
        return this.$oldSize;
    }
}

