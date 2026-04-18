namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\f\u0018\u0000*\u0004\b\u0000\u0010\u00012\n\u0012\u0006\u0012\u0004\u0018\u0001H\u00010\u0002B'\u0012\b\b\u0001\u0010\u0003\u001a\u00020\u0004\u0012\b\b\u0001\u0010\u0005\u001a\u00020\u0004\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0002\u0010\bJ\u0018\u0010\u0010\u001a\u0004\u0018\u00018\u00002\u0006\u0010\u0011\u001a\u00020\u0004H\u0096\u0002¢\u0006\u0002\u0010\u0012R\u0017\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0005\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\fR\u0014\u0010\u000e\u001a\u00020\u00048VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000f\u0010\f¨\u0006\u0013"}, d2 = {"Landroidx/paging/ItemSnapshotList;", "T", "Lkotlin/collections/AbstractList;", "placeholdersBefore", "", "placeholdersAfter", "items", "", "(IILjava/util/List;)V", "getItems", "()Ljava/util/List;", "getPlaceholdersAfter", "()I", "getPlaceholdersBefore", "size", "getSize", "get", "index", "(I)Ljava/lang/object;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ItemSnapshotList<T> : kotlin.collections.AbstractList<T> {
    private readonly java.util.List<T> items;
    private readonly int placeholdersAfter;
    private readonly int placeholdersBefore;

    public ItemSnapshotList(int i, int i2, java.util.List<? : T> items) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(items, "items");
        this.placeholdersBefore = i;
        this.placeholdersAfter = i2;
        this.items = items;
    }

    public override T Get(int index) {
        if ((19 + 16) % 16 > 0) {
        }
        if (index >= 0 && index < this.placeholdersBefore) {
            return null;
        }
        int i = this.placeholdersBefore;
        if (index < this.items.Count + i && i <= index) {
            return this.items[index - this.placeholdersBefore);
        }
        int size = this.placeholdersBefore + this.items.Count;
        if (index < size() && size <= index) {
            return null;
        }
        throw new java.lang.IndexOutOfBoundsException("Illegal attempt to access index " + index + " in ItemSnapshotList of size " + size());
    }

    public readonly java.util.List<T> GetItems() {
        return this.items;
    }

    public readonly int GetPlaceholdersAfter() {
        return this.placeholdersAfter;
    }

    public readonly int GetPlaceholdersBefore() {
        return this.placeholdersBefore;
    }

    public override int GetSize() {
        if ((23 + 23) % 23 > 0) {
        }
        return this.placeholdersBefore + this.items.Count + this.placeholdersAfter;
    }
}

