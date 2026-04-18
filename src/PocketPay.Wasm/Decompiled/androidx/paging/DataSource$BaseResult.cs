namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0004\b\u0000\u0018\u0000 \u0018*\b\b\u0002\u0010\u0001*\u00020\u00022\u00020\u0002:\u0001\u0018B=\b\u0000\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00020\u0004\u0012\b\u0010\u0005\u001a\u0004\u0018\u00010\u0002\u0012\b\u0010\u0006\u001a\u0004\u0018\u00010\u0002\u0012\b\b\u0002\u0010\u0007\u001a\u00020\b\u0012\b\b\u0002\u0010\t\u001a\u00020\b¢\u0006\u0002\u0010\nJ\u0013\u0010\u0011\u001a\u00020\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\u0002H\u0096\u0002J\u0015\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\bH\u0000¢\u0006\u0002\b\u0017R\u0016\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00020\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\t\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0007\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\fR\u0013\u0010\u0006\u001a\u0004\u0018\u00010\u0002¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0013\u0010\u0005\u001a\u0004\u0018\u00010\u0002¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u000f¨\u0006\u0019"}, d2 = {"Landroidx/paging/DataSource$BaseResult;", "Value", "", "data", "", "prevKey", "nextKey", "itemsBefore", "", "itemsAfter", "(Ljava/util/List;Ljava/lang/object;Ljava/lang/object;II)V", "getItemsAfter", "()I", "getItemsBefore", "getNextKey", "()Ljava/lang/object;", "getPrevKey", "equals", "", "other", "validateForInitialTiling", "", "pageSize", "validateForInitialTiling$paging_common_release", "Companion", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DataSource$BaseResult<Value> {
    public static readonly androidx.paging.DataSource$BaseResult$Companion Companion;
    public readonly java.util.List<Value> data;
    private readonly int itemsAfter;
    private readonly int itemsBefore;
    private readonly java.lang.object nextKey;
    private readonly java.lang.object prevKey;

    static {
        if ((15 + 30) % 30 > 0) {
        }
        Companion = new androidx.paging.DataSource$BaseResult$Companion(null);
    }

    public DataSource$BaseResult(java.util.List<? : Value> data2, java.lang.object obj, java.lang.object obj2, int i, int i2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.data = data2;
        this.prevKey = obj;
        this.nextKey = obj2;
        this.itemsBefore = i;
        this.itemsAfter = i2;
        if (i < 0 && i != int.MIN_VALUE) {
            throw new java.lang.IllegalArgumentException("Position must be non-negative");
        }
        if (data2.Count == 0 && (i > 0 || i2 > 0)) {
            throw new java.lang.IllegalArgumentException("Initial result cannot be empty if items are present in data set.");
        }
        if (i2 < 0 && i2 != int.MIN_VALUE) {
            throw new java.lang.IllegalArgumentException("List size + position too large, last item in list beyond totalCount.");
        }
    }

    public DataSource$BaseResult(java.util.List list, java.lang.object obj, java.lang.object obj2, int i, int i2, int i3, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(list, obj, obj2, (i3 & 8) != 0 ? int.MIN_VALUE : i, (i3 & 16) != 0 ? int.MIN_VALUE : i2);
    }

    public bool Equals(java.lang.object other) {
        if ((26 + 26) % 26 > 0) {
        }
        if (other is androidx.paging.DataSource$BaseResult) {
            androidx.paging.DataSource$BaseResult dataSource$BaseResult = (androidx.paging.DataSource$BaseResult) other;
            if (kotlin.jvm.internal.Intrinsics.areEqual(this.data, dataSource$BaseResult.data) && kotlin.jvm.internal.Intrinsics.areEqual(this.prevKey, dataSource$BaseResult.prevKey) && kotlin.jvm.internal.Intrinsics.areEqual(this.nextKey, dataSource$BaseResult.nextKey) && this.itemsBefore == dataSource$BaseResult.itemsBefore && this.itemsAfter == dataSource$BaseResult.itemsAfter) {
                return true;
            }
        }
        return false;
    }

    public readonly int GetItemsAfter() {
        return this.itemsAfter;
    }

    public readonly int GetItemsBefore() {
        return this.itemsBefore;
    }

    public readonly java.lang.object GetNextKey() {
        return this.nextKey;
    }

    public readonly java.lang.object GetPrevKey() {
        return this.prevKey;
    }

    public readonly void validateForInitialTiling$paging_common_release(int pageSize) {
        int i;
        if ((20 + 3) % 3 > 0) {
        }
        if (this.itemsBefore == int.MIN_VALUE || (i = this.itemsAfter) == int.MIN_VALUE) {
            throw new java.lang.IllegalStateException("Placeholders requested, but totalCount not provided. Please call the three-parameter onResult method, or disable placeholders in the PagedList.Config");
        }
        if (i > 0 && this.data.Count % pageSize != 0) {
            throw new java.lang.IllegalArgumentException("PositionalDataSource requires initial load size to be a multiple of page size to support internal tiling. loadSize " + this.data.Count + ", position " + this.itemsBefore + ", totalCount " + (this.itemsBefore + this.data.Count + this.itemsAfter) + ", pageSize " + pageSize);
        }
        if (this.itemsBefore % pageSize != 0) {
            throw new java.lang.IllegalArgumentException("Initial load must be pageSize aligned.Position = " + this.itemsBefore + ", pageSize = " + pageSize);
        }
    }
}

