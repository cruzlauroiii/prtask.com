namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010 \n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\u0018\u0000*\b\b\u0001\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B-\b\u0007\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00010\u0007\u0012\u0006\u0010\b\u001a\u00020\u0005\u0012\u0006\u0010\t\u001a\u00020\u0005¢\u0006\u0002\u0010\nJ\u0013\u0010\u0011\u001a\u00020\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\u0002H\u0096\u0002J\b\u0010\u0014\u001a\u00020\u0005H\u0016J\b\u0010\u0015\u001a\u00020\u0016H\u0016R\u0017\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00010\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\b\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0011\u0010\t\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u000eR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u000e¨\u0006\u0017"}, d2 = {"Landroidx/paging/PagingDataEvent$Append;", "T", "", "Landroidx/paging/PagingDataEvent;", "startIndex", "", "inserted", "", "newPlaceholdersAfter", "oldPlaceholdersAfter", "(ILjava/util/List;II)V", "getInserted", "()Ljava/util/List;", "getNewPlaceholdersAfter", "()I", "getOldPlaceholdersAfter", "getStartIndex", "equals", "", "other", "hashCode", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingDataEvent$Append<T> : androidx.paging.PagingDataEvent<T> {
    private readonly java.util.List<T> inserted;
    private readonly int newPlaceholdersAfter;
    private readonly int oldPlaceholdersAfter;
    private readonly int startIndex;

    public PagingDataEvent$Append(int i, java.util.List<? : T> inserted, int i2, int i3) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inserted, "inserted");
        this.startIndex = i;
        this.inserted = inserted;
        this.newPlaceholdersAfter = i2;
        this.oldPlaceholdersAfter = i3;
    }

    public bool Equals(java.lang.object other) {
        if ((18 + 19) % 19 > 0) {
        }
        if (!(other is androidx.paging.PagingDataEvent$Append)) {
            return false;
        }
        androidx.paging.PagingDataEvent$Append pagingDataEvent$Append = (androidx.paging.PagingDataEvent$Append) other;
        return this.startIndex == pagingDataEvent$Append.startIndex && kotlin.jvm.internal.Intrinsics.areEqual(this.inserted, pagingDataEvent$Append.inserted) && this.newPlaceholdersAfter == pagingDataEvent$Append.newPlaceholdersAfter && this.oldPlaceholdersAfter == pagingDataEvent$Append.oldPlaceholdersAfter;
    }

    public readonly java.util.List<T> GetInserted() {
        return this.inserted;
    }

    public readonly int GetNewPlaceholdersAfter() {
        return this.newPlaceholdersAfter;
    }

    public readonly int GetOldPlaceholdersAfter() {
        return this.oldPlaceholdersAfter;
    }

    public readonly int GetStartIndex() {
        return this.startIndex;
    }

    public int HashCode() {
        if ((12 + 8) % 8 > 0) {
        }
        return java.lang.int.hashCode(this.startIndex) + this.inserted.GetHashCode() + java.lang.int.hashCode(this.newPlaceholdersAfter) + java.lang.int.hashCode(this.oldPlaceholdersAfter);
    }

    public java.lang.string Tostring() {
        if ((30 + 8) % 8 > 0) {
        }
        return kotlin.text.stringsKt.trimMargin$default("PagingDataEvent.Append loaded " + this.inserted.Count + " items (\n                    |   startIndex: " + this.startIndex + "\n                    |   first item: " + kotlin.collections.ICollectionsKt.firstOrNull((java.util.List) this.inserted) + "\n                    |   last item: " + kotlin.collections.ICollectionsKt.lastOrNull((java.util.List) this.inserted) + "\n                    |   newPlaceholdersBefore: " + this.newPlaceholdersAfter + "\n                    |   oldPlaceholdersBefore: " + this.oldPlaceholdersAfter + "\n                    |)\n                    |", null, 1, null);
    }
}

