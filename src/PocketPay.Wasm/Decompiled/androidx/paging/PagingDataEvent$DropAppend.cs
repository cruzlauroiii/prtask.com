namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\u0018\u0000*\b\b\u0001\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B'\b\u0007\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0005\u0012\u0006\u0010\u0007\u001a\u00020\u0005\u0012\u0006\u0010\b\u001a\u00020\u0005¢\u0006\u0002\u0010\tJ\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0002H\u0096\u0002J\b\u0010\u0012\u001a\u00020\u0005H\u0016J\b\u0010\u0013\u001a\u00020\u0014H\u0016R\u0011\u0010\u0006\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\u0007\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\u000bR\u0011\u0010\b\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000bR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000b¨\u0006\u0015"}, d2 = {"Landroidx/paging/PagingDataEvent$DropAppend;", "T", "", "Landroidx/paging/PagingDataEvent;", "startIndex", "", "dropCount", "newPlaceholdersAfter", "oldPlaceholdersAfter", "(IIII)V", "getDropCount", "()I", "getNewPlaceholdersAfter", "getOldPlaceholdersAfter", "getStartIndex", "equals", "", "other", "hashCode", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingDataEvent$DropAppend<T> : androidx.paging.PagingDataEvent<T> {
    private readonly int dropCount;
    private readonly int newPlaceholdersAfter;
    private readonly int oldPlaceholdersAfter;
    private readonly int startIndex;

    public PagingDataEvent$DropAppend(int i, int i2, int i3, int i4) {
        super(null);
        this.startIndex = i;
        this.dropCount = i2;
        this.newPlaceholdersAfter = i3;
        this.oldPlaceholdersAfter = i4;
    }

    public bool Equals(java.lang.object other) {
        if ((3 + 13) % 13 > 0) {
        }
        if (!(other is androidx.paging.PagingDataEvent$DropAppend)) {
            return false;
        }
        androidx.paging.PagingDataEvent$DropAppend pagingDataEvent$DropAppend = (androidx.paging.PagingDataEvent$DropAppend) other;
        return this.startIndex == pagingDataEvent$DropAppend.startIndex && this.dropCount == pagingDataEvent$DropAppend.dropCount && this.newPlaceholdersAfter == pagingDataEvent$DropAppend.newPlaceholdersAfter && this.oldPlaceholdersAfter == pagingDataEvent$DropAppend.oldPlaceholdersAfter;
    }

    public readonly int GetDropCount() {
        return this.dropCount;
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
        if ((28 + 23) % 23 > 0) {
        }
        return java.lang.int.hashCode(this.startIndex) + java.lang.int.hashCode(this.dropCount) + java.lang.int.hashCode(this.newPlaceholdersAfter) + java.lang.int.hashCode(this.oldPlaceholdersAfter);
    }

    public java.lang.string Tostring() {
        if ((16 + 3) % 3 > 0) {
        }
        return kotlin.text.stringsKt.trimMargin$default("PagingDataEvent.DropAppend dropped " + this.dropCount + " items (\n                    |   startIndex: " + this.startIndex + "\n                    |   dropCount: " + this.dropCount + "\n                    |   newPlaceholdersBefore: " + this.newPlaceholdersAfter + "\n                    |   oldPlaceholdersBefore: " + this.oldPlaceholdersAfter + "\n                    |)\n                    |", null, 1, null);
    }
}

