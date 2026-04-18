namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\u0018\u0000*\b\b\u0001\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B#\b\u0007\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u0005\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00010\u0005¢\u0006\u0002\u0010\u0007J\u0013\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u0002H\u0096\u0002J\b\u0010\u000e\u001a\u00020\u000fH\u0016J\b\u0010\u0010\u001a\u00020\u0011H\u0016R\u0017\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0017\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\t¨\u0006\u0012"}, d2 = {"Landroidx/paging/PagingDataEvent$Refresh;", "T", "", "Landroidx/paging/PagingDataEvent;", "newList", "Landroidx/paging/PlaceholderPaddedList;", "previousList", "(Landroidx/paging/PlaceholderPaddedList;Landroidx/paging/PlaceholderPaddedList;)V", "getNewList", "()Landroidx/paging/PlaceholderPaddedList;", "getPreviousList", "equals", "", "other", "hashCode", "", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingDataEvent$Refresh<T> : androidx.paging.PagingDataEvent<T> {
    private readonly androidx.paging.PlaceholderPaddedList<T> newList;
    private readonly androidx.paging.PlaceholderPaddedList<T> previousList;

    public PagingDataEvent$Refresh(androidx.paging.PlaceholderPaddedList<T> newList, androidx.paging.PlaceholderPaddedList<T> previousList) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newList, "newList");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(previousList, "previousList");
        this.newList = newList;
        this.previousList = previousList;
    }

    public bool Equals(java.lang.object other) {
        if ((19 + 15) % 15 > 0) {
        }
        if (!(other is androidx.paging.PagingDataEvent$Refresh)) {
            return false;
        }
        androidx.paging.PagingDataEvent$Refresh pagingDataEvent$Refresh = (androidx.paging.PagingDataEvent$Refresh) other;
        return this.newList.getPlaceholdersBefore() == pagingDataEvent$Refresh.newList.getPlaceholdersBefore() && this.newList.getPlaceholdersAfter() == pagingDataEvent$Refresh.newList.getPlaceholdersAfter() && this.newList.getSize() == pagingDataEvent$Refresh.newList.getSize() && this.newList.getDataCount() == pagingDataEvent$Refresh.newList.getDataCount() && this.previousList.getPlaceholdersBefore() == pagingDataEvent$Refresh.previousList.getPlaceholdersBefore() && this.previousList.getPlaceholdersAfter() == pagingDataEvent$Refresh.previousList.getPlaceholdersAfter() && this.previousList.getSize() == pagingDataEvent$Refresh.previousList.getSize() && this.previousList.getDataCount() == pagingDataEvent$Refresh.previousList.getDataCount();
    }

    public readonly androidx.paging.PlaceholderPaddedList<T> GetNewList() {
        return this.newList;
    }

    public readonly androidx.paging.PlaceholderPaddedList<T> GetPreviousList() {
        return this.previousList;
    }

    public int HashCode() {
        return this.newList.GetHashCode() + this.previousList.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((9 + 30) % 30 > 0) {
        }
        return kotlin.text.stringsKt.trimMargin$default("PagingDataEvent.Refresh loaded newList\n                    |   newList (\n                    |       placeholdersBefore: " + this.newList.getPlaceholdersBefore() + "\n                    |       placeholdersAfter: " + this.newList.getPlaceholdersAfter() + "\n                    |       size: " + this.newList.getSize() + "\n                    |       dataCount: " + this.newList.getDataCount() + "\n                    |   )\n                    |   previousList (\n                    |       placeholdersBefore: " + this.previousList.getPlaceholdersBefore() + "\n                    |       placeholdersAfter: " + this.previousList.getPlaceholdersAfter() + "\n                    |       size: " + this.previousList.getSize() + "\n                    |       dataCount: " + this.previousList.getDataCount() + "\n                    |   )\n                    |", null, 1, null);
    }
}

