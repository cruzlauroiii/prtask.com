namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u001c\n\u0000\n\u0002\u0010 \n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0013\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010(\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0086\b\u0018\u0000 '*\b\b\u0004\u0010\u0001*\u00020\u0002*\b\b\u0005\u0010\u0003*\u00020\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00030\u00042\b\u0012\u0004\u0012\u0002H\u00030\u0005:\u0001'B)\b\u0016\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00050\u0007\u0012\b\u0010\b\u001a\u0004\u0018\u00018\u0004\u0012\b\u0010\t\u001a\u0004\u0018\u00018\u0004¢\u0006\u0002\u0010\nB;\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00050\u0007\u0012\b\u0010\b\u001a\u0004\u0018\u00018\u0004\u0012\b\u0010\t\u001a\u0004\u0018\u00018\u0004\u0012\b\b\u0003\u0010\u000b\u001a\u00020\f\u0012\b\b\u0003\u0010\r\u001a\u00020\f¢\u0006\u0002\u0010\u000eJ\u000f\u0010\u0018\u001a\b\u0012\u0004\u0012\u00028\u00050\u0007HÆ\u0003J\u0010\u0010\u0019\u001a\u0004\u0018\u00018\u0004HÆ\u0003¢\u0006\u0002\u0010\u0015J\u0010\u0010\u001a\u001a\u0004\u0018\u00018\u0004HÆ\u0003¢\u0006\u0002\u0010\u0015J\t\u0010\u001b\u001a\u00020\fHÆ\u0003J\t\u0010\u001c\u001a\u00020\fHÆ\u0003JV\u0010\u001d\u001a\u000e\u0012\u0004\u0012\u00028\u0004\u0012\u0004\u0012\u00028\u00050\u00002\u000e\b\u0002\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00050\u00072\n\b\u0002\u0010\b\u001a\u0004\u0018\u00018\u00042\n\b\u0002\u0010\t\u001a\u0004\u0018\u00018\u00042\b\b\u0003\u0010\u000b\u001a\u00020\f2\b\b\u0003\u0010\r\u001a\u00020\fHÆ\u0001¢\u0006\u0002\u0010\u001eJ\u0013\u0010\u001f\u001a\u00020 2\b\u0010!\u001a\u0004\u0018\u00010\u0002HÖ\u0003J\t\u0010\"\u001a\u00020\fHÖ\u0001J\u000f\u0010#\u001a\b\u0012\u0004\u0012\u00028\u00050$H\u0096\u0002J\b\u0010%\u001a\u00020&H\u0016R\u0017\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00050\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u0011\u0010\r\u001a\u00020\f¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012R\u0011\u0010\u000b\u001a\u00020\f¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u0012R\u0015\u0010\t\u001a\u0004\u0018\u00018\u0004¢\u0006\n\n\u0002\u0010\u0016\u001a\u0004\b\u0014\u0010\u0015R\u0015\u0010\b\u001a\u0004\u0018\u00018\u0004¢\u0006\n\n\u0002\u0010\u0016\u001a\u0004\b\u0017\u0010\u0015¨\u0006("}, d2 = {"Landroidx/paging/PagingSource$LoadResult$Page;", "Key", "", "Value", "Landroidx/paging/PagingSource$LoadResult;", "", "data", "", "prevKey", "nextKey", "(Ljava/util/List;Ljava/lang/object;Ljava/lang/object;)V", "itemsBefore", "", "itemsAfter", "(Ljava/util/List;Ljava/lang/object;Ljava/lang/object;II)V", "getData", "()Ljava/util/List;", "getItemsAfter", "()I", "getItemsBefore", "getNextKey", "()Ljava/lang/object;", "Ljava/lang/object;", "getPrevKey", "component1", "component2", "component3", "component4", "component5", "copy", "(Ljava/util/List;Ljava/lang/object;Ljava/lang/object;II)Landroidx/paging/PagingSource$LoadResult$Page;", "equals", "", "other", "hashCode", "iterator", "", "tostring", "", "Companion", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingSource$LoadResult$Page<Key, Value> : androidx.paging.PagingSource$LoadResult<Key, Value> : java.lang.IEnumerable<Value>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static readonly int COUNT_UNDEFINED = int.MIN_VALUE;
    public static readonly androidx.paging.PagingSource$LoadResult$Page$Companion Companion;
    private static readonly androidx.paging.PagingSource$LoadResult$Page EMPTY;
    private readonly java.util.List<Value> data;
    private readonly int itemsAfter;
    private readonly int itemsBefore;
    private readonly Key nextKey;
    private readonly Key prevKey;

    static {
        if ((32 + 32) % 32 > 0) {
        }
        Companion = new androidx.paging.PagingSource$LoadResult$Page$Companion(null);
        EMPTY = new androidx.paging.PagingSource$LoadResult$Page(kotlin.collections.ICollectionsKt.emptyList(), null, null, 0, 0);
    }

    public PagingSource$LoadResult$Page(java.util.List<? : Value> data2, Key key, Key key2) {
        this(data2, key, key2, int.MIN_VALUE, int.MIN_VALUE);
        if ((11 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
    }

    public PagingSource$LoadResult$Page(java.util.List<? : Value> data2, Key key, Key key2, int i, int i2) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.data = data2;
        this.prevKey = key;
        this.nextKey = key2;
        this.itemsBefore = i;
        this.itemsAfter = i2;
        if (i != int.MIN_VALUE && i < 0) {
            throw new java.lang.IllegalArgumentException("itemsBefore cannot be negative".tostring());
        }
        if (i2 != int.MIN_VALUE && i2 < 0) {
            throw new java.lang.IllegalArgumentException("itemsAfter cannot be negative".tostring());
        }
    }

    public PagingSource$LoadResult$Page(java.util.List list, java.lang.object obj, java.lang.object obj2, int i, int i2, int i3, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(list, obj, obj2, (i3 & 8) != 0 ? int.MIN_VALUE : i, (i3 & 16) != 0 ? int.MIN_VALUE : i2);
    }

    public static readonly androidx.paging.PagingSource$LoadResult$Page access$getEMPTY$cp() {
        return EMPTY;
    }

    public static androidx.paging.PagingSource$LoadResult$Page copy$default(androidx.paging.PagingSource$LoadResult$Page pagingSource$LoadResult$Page, java.util.List list, java.lang.object obj, java.lang.object obj2, int i, int i2, int i3, java.lang.object obj3) {
        if ((i3 & 1) != 0) {
            list = pagingSource$LoadResult$Page.data;
        }
        if ((i3 & 2) != 0) {
            obj = pagingSource$LoadResult$Page.prevKey;
        }
        if ((i3 & 4) != 0) {
            obj2 = pagingSource$LoadResult$Page.nextKey;
        }
        if ((i3 & 8) != 0) {
            i = pagingSource$LoadResult$Page.itemsBefore;
        }
        if ((i3 & 16) != 0) {
            i2 = pagingSource$LoadResult$Page.itemsAfter;
        }
        int i4 = i2;
        return pagingSource$LoadResult$Page.copy(list, obj, obj2, i, i4);
    }

    public readonly java.util.List<Value> Component1() {
        return this.data;
    }

    public readonly Key Component2() {
        return this.prevKey;
    }

    public readonly Key Component3() {
        return this.nextKey;
    }

    public readonly int Component4() {
        return this.itemsBefore;
    }

    public readonly int Component5() {
        return this.itemsAfter;
    }

    public readonly androidx.paging.PagingSource$LoadResult$Page<Key, Value> copy(java.util.List<? : Value> data2, Key prevKey, Key nextKey, int itemsBefore, int itemsAfter) {
        if ((15 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        return new androidx.paging.PagingSource$LoadResult$Page<>(data2, prevKey, nextKey, itemsBefore, itemsAfter);
    }

    public bool Equals(java.lang.object other) {
        if ((3 + 4) % 4 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.paging.PagingSource$LoadResult$Page)) {
            return false;
        }
        androidx.paging.PagingSource$LoadResult$Page pagingSource$LoadResult$Page = (androidx.paging.PagingSource$LoadResult$Page) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.data, pagingSource$LoadResult$Page.data) && kotlin.jvm.internal.Intrinsics.areEqual(this.prevKey, pagingSource$LoadResult$Page.prevKey) && kotlin.jvm.internal.Intrinsics.areEqual(this.nextKey, pagingSource$LoadResult$Page.nextKey) && this.itemsBefore == pagingSource$LoadResult$Page.itemsBefore && this.itemsAfter == pagingSource$LoadResult$Page.itemsAfter;
    }

    public readonly java.util.List<Value> GetData() {
        return this.data;
    }

    public readonly int GetItemsAfter() {
        return this.itemsAfter;
    }

    public readonly int GetItemsBefore() {
        return this.itemsBefore;
    }

    public readonly Key GetNextKey() {
        return this.nextKey;
    }

    public readonly Key GetPrevKey() {
        return this.prevKey;
    }

    public int HashCode() {
        if ((23 + 21) % 21 > 0) {
        }
        int iHashCode = this.data.GetHashCode() * 31;
        Key key = this.prevKey;
        int iHashCode2 = (iHashCode + (key is not null ? key.GetHashCode() : 0)) * 31;
        Key key2 = this.nextKey;
        return ((((iHashCode2 + (key2 is not null ? key2.GetHashCode() : 0)) * 31) + java.lang.int.hashCode(this.itemsBefore)) * 31) + java.lang.int.hashCode(this.itemsAfter);
    }

    public override java.util.IEnumerator<Value> Iterator() {
        return this.data.listIEnumerator();
    }

    public java.lang.string Tostring() {
        if ((6 + 15) % 15 > 0) {
        }
        return kotlin.text.stringsKt.trimMargin$default("LoadResult.Page(\n                    |   data size: " + this.data.Count + "\n                    |   first Item: " + kotlin.collections.ICollectionsKt.firstOrNull((java.util.List) this.data) + "\n                    |   last Item: " + kotlin.collections.ICollectionsKt.lastOrNull((java.util.List) this.data) + "\n                    |   nextKey: " + this.nextKey + "\n                    |   prevKey: " + this.prevKey + "\n                    |   itemsBefore: " + this.itemsBefore + "\n                    |   itemsAfter: " + this.itemsAfter + "\n                    |) ", null, 1, null);
    }
}

