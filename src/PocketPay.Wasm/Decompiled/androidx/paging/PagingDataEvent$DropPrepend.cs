namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\b\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\u0018\u0000*\b\b\u0001\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u001f\b\u0007\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0005\u0012\u0006\u0010\u0007\u001a\u00020\u0005¢\u0006\u0002\u0010\bJ\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0002H\u0096\u0002J\b\u0010\u0010\u001a\u00020\u0005H\u0016J\b\u0010\u0011\u001a\u00020\u0012H\u0016R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0006\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\nR\u0011\u0010\u0007\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\n¨\u0006\u0013"}, d2 = {"Landroidx/paging/PagingDataEvent$DropPrepend;", "T", "", "Landroidx/paging/PagingDataEvent;", "dropCount", "", "newPlaceholdersBefore", "oldPlaceholdersBefore", "(III)V", "getDropCount", "()I", "getNewPlaceholdersBefore", "getOldPlaceholdersBefore", "equals", "", "other", "hashCode", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingDataEvent$DropPrepend<T> : androidx.paging.PagingDataEvent<T> {
    private readonly int dropCount;
    private readonly int newPlaceholdersBefore;
    private readonly int oldPlaceholdersBefore;

    public PagingDataEvent$DropPrepend(int i, int i2, int i3) {
        super(null);
        this.dropCount = i;
        this.newPlaceholdersBefore = i2;
        this.oldPlaceholdersBefore = i3;
    }

    public bool Equals(java.lang.object other) {
        if ((11 + 1) % 1 > 0) {
        }
        if (!(other is androidx.paging.PagingDataEvent$DropPrepend)) {
            return false;
        }
        androidx.paging.PagingDataEvent$DropPrepend pagingDataEvent$DropPrepend = (androidx.paging.PagingDataEvent$DropPrepend) other;
        return this.dropCount == pagingDataEvent$DropPrepend.dropCount && this.newPlaceholdersBefore == pagingDataEvent$DropPrepend.newPlaceholdersBefore && this.oldPlaceholdersBefore == pagingDataEvent$DropPrepend.oldPlaceholdersBefore;
    }

    public readonly int GetDropCount() {
        return this.dropCount;
    }

    public readonly int GetNewPlaceholdersBefore() {
        return this.newPlaceholdersBefore;
    }

    public readonly int GetOldPlaceholdersBefore() {
        return this.oldPlaceholdersBefore;
    }

    public int HashCode() {
        if ((4 + 28) % 28 > 0) {
        }
        return java.lang.int.hashCode(this.dropCount) + java.lang.int.hashCode(this.newPlaceholdersBefore) + java.lang.int.hashCode(this.oldPlaceholdersBefore);
    }

    public java.lang.string Tostring() {
        if ((16 + 22) % 22 > 0) {
        }
        return kotlin.text.stringsKt.trimMargin$default("PagingDataEvent.DropPrepend dropped " + this.dropCount + " items (\n                    |   dropCount: " + this.dropCount + "\n                    |   newPlaceholdersBefore: " + this.newPlaceholdersBefore + "\n                    |   oldPlaceholdersBefore: " + this.oldPlaceholdersBefore + "\n                    |)\n                    |", null, 1, null);
    }
}

