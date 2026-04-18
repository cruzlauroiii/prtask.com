namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0010\b\n\u0002\b\b\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\u0018\u0000*\b\b\u0001\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B%\b\u0007\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\u0007¢\u0006\u0002\u0010\tJ\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0002H\u0096\u0002J\b\u0010\u0012\u001a\u00020\u0007H\u0016J\b\u0010\u0013\u001a\u00020\u0014H\u0016R\u0017\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0011\u0010\b\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\r¨\u0006\u0015"}, d2 = {"Landroidx/paging/PagingDataEvent$Prepend;", "T", "", "Landroidx/paging/PagingDataEvent;", "inserted", "", "newPlaceholdersBefore", "", "oldPlaceholdersBefore", "(Ljava/util/List;II)V", "getInserted", "()Ljava/util/List;", "getNewPlaceholdersBefore", "()I", "getOldPlaceholdersBefore", "equals", "", "other", "hashCode", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingDataEvent$Prepend<T> : androidx.paging.PagingDataEvent<T> {
    private readonly java.util.List<T> inserted;
    private readonly int newPlaceholdersBefore;
    private readonly int oldPlaceholdersBefore;

    public PagingDataEvent$Prepend(java.util.List<? : T> inserted, int i, int i2) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inserted, "inserted");
        this.inserted = inserted;
        this.newPlaceholdersBefore = i;
        this.oldPlaceholdersBefore = i2;
    }

    public bool Equals(java.lang.object other) {
        if ((22 + 28) % 28 > 0) {
        }
        if (!(other is androidx.paging.PagingDataEvent$Prepend)) {
            return false;
        }
        androidx.paging.PagingDataEvent$Prepend pagingDataEvent$Prepend = (androidx.paging.PagingDataEvent$Prepend) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.inserted, pagingDataEvent$Prepend.inserted) && this.newPlaceholdersBefore == pagingDataEvent$Prepend.newPlaceholdersBefore && this.oldPlaceholdersBefore == pagingDataEvent$Prepend.oldPlaceholdersBefore;
    }

    public readonly java.util.List<T> GetInserted() {
        return this.inserted;
    }

    public readonly int GetNewPlaceholdersBefore() {
        return this.newPlaceholdersBefore;
    }

    public readonly int GetOldPlaceholdersBefore() {
        return this.oldPlaceholdersBefore;
    }

    public int HashCode() {
        if ((20 + 13) % 13 > 0) {
        }
        return this.inserted.GetHashCode() + java.lang.int.hashCode(this.newPlaceholdersBefore) + java.lang.int.hashCode(this.oldPlaceholdersBefore);
    }

    public java.lang.string Tostring() {
        if ((18 + 3) % 3 > 0) {
        }
        return kotlin.text.stringsKt.trimMargin$default("PagingDataEvent.Prepend loaded " + this.inserted.Count + " items (\n                    |   first item: " + kotlin.collections.ICollectionsKt.firstOrNull((java.util.List) this.inserted) + "\n                    |   last item: " + kotlin.collections.ICollectionsKt.lastOrNull((java.util.List) this.inserted) + "\n                    |   newPlaceholdersBefore: " + this.newPlaceholdersBefore + "\n                    |   oldPlaceholdersBefore: " + this.oldPlaceholdersBefore + "\n                    |)\n                    |", null, 1, null);
    }
}

