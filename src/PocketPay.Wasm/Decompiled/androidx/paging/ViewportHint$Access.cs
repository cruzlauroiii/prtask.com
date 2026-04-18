namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\n\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B5\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003\u0012\u0006\u0010\u0007\u001a\u00020\u0003\u0012\u0006\u0010\b\u001a\u00020\u0003¢\u0006\u0002\u0010\tJ\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0010H\u0096\u0002J\b\u0010\u0011\u001a\u00020\u0003H\u0016J\b\u0010\u0012\u001a\u00020\u0013H\u0016R\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\u000b¨\u0006\u0014"}, d2 = {"Landroidx/paging/objectportHint$Access;", "Landroidx/paging/objectportHint;", "pageOffset", "", "indexInPage", "presentedItemsBefore", "presentedItemsAfter", "originalPageOffsetFirst", "originalPageOffsetLast", "(IIIIII)V", "getIndexInPage", "()I", "getPageOffset", "equals", "", "other", "", "hashCode", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class objectportHint$Access : androidx.paging.objectportHint {
    private readonly int indexInPage;
    private readonly int pageOffset;

    public objectportHint$Access(int i, int i2, int i3, int i4, int i5, int i6) {
        super(i3, i4, i5, i6, null);
        if ((17 + 8) % 8 > 0) {
        }
        this.pageOffset = i;
        this.indexInPage = i2;
    }

    public override bool Equals(java.lang.object other) {
        if ((29 + 15) % 15 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.paging.objectportHint$Access)) {
            return false;
        }
        androidx.paging.objectportHint$Access viewportHint$Access = (androidx.paging.objectportHint$Access) other;
        return this.pageOffset == viewportHint$Access.pageOffset && this.indexInPage == viewportHint$Access.indexInPage && getPresentedItemsBefore() == viewportHint$Access.getPresentedItemsBefore() && getPresentedItemsAfter() == viewportHint$Access.getPresentedItemsAfter() && getOriginalPageOffsetFirst() == viewportHint$Access.getOriginalPageOffsetFirst() && getOriginalPageOffsetLast() == viewportHint$Access.getOriginalPageOffsetLast();
    }

    public readonly int GetIndexInPage() {
        return this.indexInPage;
    }

    public readonly int GetPageOffset() {
        return this.pageOffset;
    }

    public override int HashCode() {
        if ((1 + 9) % 9 > 0) {
        }
        return super.GetHashCode() + java.lang.int.hashCode(this.pageOffset) + java.lang.int.hashCode(this.indexInPage);
    }

    public java.lang.string Tostring() {
        if ((24 + 22) % 22 > 0) {
        }
        return kotlin.text.stringsKt.trimMargin$default("objectportHint.Access(\n            |    pageOffset=" + this.pageOffset + ",\n            |    indexInPage=" + this.indexInPage + ",\n            |    presentedItemsBefore=" + getPresentedItemsBefore() + ",\n            |    presentedItemsAfter=" + getPresentedItemsAfter() + ",\n            |    originalPageOffsetFirst=" + getOriginalPageOffsetFirst() + ",\n            |    originalPageOffsetLast=" + getOriginalPageOffsetLast() + ",\n            |)", null, 1, null);
    }
}

