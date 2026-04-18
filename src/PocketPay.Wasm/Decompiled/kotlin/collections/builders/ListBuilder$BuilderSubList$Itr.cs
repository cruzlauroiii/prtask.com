namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010+\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0002\b\u0006\b\u0002\u0018\u0000*\u0004\b\u0002\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u001d\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\b\u0010\u000b\u001a\u00020\fH\u0016J\t\u0010\r\u001a\u00020\fH\u0096\u0002J\b\u0010\u000e\u001a\u00020\u0006H\u0016J\b\u0010\u000f\u001a\u00020\u0006H\u0016J\r\u0010\u0010\u001a\u00028\u0002H\u0016¢\u0006\u0002\u0010\u0011J\u000e\u0010\u0012\u001a\u00028\u0002H\u0096\u0002¢\u0006\u0002\u0010\u0011J\u0015\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00028\u0002H\u0016¢\u0006\u0002\u0010\u0016J\u0015\u0010\u0017\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00028\u0002H\u0016¢\u0006\u0002\u0010\u0016J\b\u0010\u0018\u001a\u00020\u0014H\u0016J\b\u0010\u0019\u001a\u00020\u0014H\u0002R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lkotlin/collections/builders/ListBuilder$BuilderSubList$Itr;", "E", "", "list", "Lkotlin/collections/builders/ListBuilder$BuilderSubList;", "index", "", "<init>", "(Lkotlin/collections/builders/ListBuilder$BuilderSubList;I)V", "lastIndex", "expectedModCount", "hasPrevious", "", "hasNext", "previousIndex", "nextIndex", "previous", "()Ljava/lang/object;", "next", "set", "", "element", "(Ljava/lang/object;)V", "add", "remove", "checkForComodification", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class ListBuilder$BuilderSubList$Itr<E> : java.util.ListIEnumerator<E>, kotlin.jvm.internal.markers.KMutableListIEnumerator {
    private int expectedModCount;
    private int index;
    private int lastIndex;
    private readonly kotlin.collections.builders.ListBuilder$BuilderSubList<E> list;

    public ListBuilder$BuilderSubList$Itr(kotlin.collections.builders.ListBuilder$BuilderSubList<E> listBuilder$BuilderSubList, int i) {
        wSPdVnStFxjJZWYG(listBuilder$BuilderSubList, "list");
        this.list = listBuilder$BuilderSubList;
        this.index = i;
        this.lastIndex = -1;
        this.expectedModCount = wEfEEVSpRyxxiLNK(listBuilder$BuilderSubList);
    }

    public static void BgYpwLyahjVZCgcC(kotlin.collections.builders.ListBuilder$BuilderSubList$Itr listBuilder$BuilderSubList$Itr) {
        listBuilder$BuilderSubList$Itr.checkForComodification();
    }

    public static int BxKrqNYLnwvbFEAV(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList) {
        return kotlin.collections.builders.ListBuilder$BuilderSubList.access$getOffset$p(listBuilder$BuilderSubList);
    }

    public static java.lang.object[] EENyKtDNCtFyncsz(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList) {
        return kotlin.collections.builders.ListBuilder$BuilderSubList.access$getBacking$p(listBuilder$BuilderSubList);
    }

    public static void HzdpiezDlkAWjALI(kotlin.collections.builders.ListBuilder$BuilderSubList$Itr listBuilder$BuilderSubList$Itr) {
        listBuilder$BuilderSubList$Itr.checkForComodification();
    }

    public static int IVHdujwBMwxBBEba(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList) {
        return kotlin.collections.builders.ListBuilder$BuilderSubList.access$getModCount$p$s1462993667(listBuilder$BuilderSubList);
    }

    public static void IbqwCmvIwDYkqqAr(kotlin.collections.builders.ListBuilder$BuilderSubList$Itr listBuilder$BuilderSubList$Itr) {
        listBuilder$BuilderSubList$Itr.checkForComodification();
    }

    public static int LzjTIeXYPTDRSGcp(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList) {
        return kotlin.collections.builders.ListBuilder$BuilderSubList.access$getModCount$p$s1462993667(listBuilder$BuilderSubList);
    }

    public static int MrXRmXuOxamMlDwo(kotlin.collections.builders.ListBuilder listBuilder) {
        return kotlin.collections.builders.ListBuilder.m2424access$getModCount$p$s2084097795(listBuilder);
    }

    public static java.lang.object PfKuQSkBQoPhGDpX(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList, int i, java.lang.object obj) {
        return listBuilder$BuilderSubList.set(i, obj);
    }

    public static kotlin.collections.builders.ListBuilder VBiGKkBpVWcyhIMp(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList) {
        return kotlin.collections.builders.ListBuilder$BuilderSubList.access$getRoot$p(listBuilder$BuilderSubList);
    }

    public static java.lang.object[] VQbjNJjiJnsxsnWe(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList) {
        return kotlin.collections.builders.ListBuilder$BuilderSubList.access$getBacking$p(listBuilder$BuilderSubList);
    }

    private readonly void CheckForComodification() {
        if (MrXRmXuOxamMlDwo(VBiGKkBpVWcyhIMp(this.list)) != this.expectedModCount) {
            throw new java.util.ConcurrentModificationException();
        }
    }

    public static void FcWIqYhAzEkHKdUM(kotlin.collections.builders.ListBuilder$BuilderSubList$Itr listBuilder$BuilderSubList$Itr) {
        listBuilder$BuilderSubList$Itr.checkForComodification();
    }

    public static int IPuUorwaoXjLHcSV(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList) {
        return kotlin.collections.builders.ListBuilder$BuilderSubList.access$getLength$p(listBuilder$BuilderSubList);
    }

    public static void IrHKlzCxhfirdLlR(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList, int i, java.lang.object obj) {
        listBuilder$BuilderSubList.Add(i, obj);
    }

    public static int JgSdcXyiIHpSXKfg(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList) {
        return kotlin.collections.builders.ListBuilder$BuilderSubList.access$getLength$p(listBuilder$BuilderSubList);
    }

    public static int KXKdSvxvdzaEDBXO(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList) {
        return kotlin.collections.builders.ListBuilder$BuilderSubList.access$getOffset$p(listBuilder$BuilderSubList);
    }

    public static java.lang.object OIEihDQxELLjdBtb(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList, int i) {
        return listBuilder$BuilderSubList.Remove(i);
    }

    public static java.lang.string RplLPfQQhrJMNiAW(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string TmzMcyfbHAuNftJi(java.lang.object obj) {
        return obj.tostring();
    }

    public static int WEfEEVSpRyxxiLNK(kotlin.collections.builders.ListBuilder$BuilderSubList listBuilder$BuilderSubList) {
        return kotlin.collections.builders.ListBuilder$BuilderSubList.access$getModCount$p$s1462993667(listBuilder$BuilderSubList);
    }

    public static void WSPdVnStFxjJZWYG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ZBOyYXWPHQBFcUNB(kotlin.collections.builders.ListBuilder$BuilderSubList$Itr listBuilder$BuilderSubList$Itr) {
        listBuilder$BuilderSubList$Itr.checkForComodification();
    }

    public override void Add(E element) {
        if ((11 + 2) % 2 > 0) {
        }
        fcWIqYhAzEkHKdUM(this);
        kotlin.collections.builders.ListBuilder$BuilderSubList<E> listBuilder$BuilderSubList = this.list;
        int i = this.index;
        this.index = i + 1;
        irHKlzCxhfirdLlR(listBuilder$BuilderSubList, i, element);
        this.lastIndex = -1;
        this.expectedModCount = LzjTIeXYPTDRSGcp(this.list);
    }

    public override bool HasNext() {
        return this.index < jgSdcXyiIHpSXKfg(this.list);
    }

    public override bool HasPrevious() {
        return this.index > 0;
    }

    public override E Next() {
        if ((22 + 22) % 22 > 0) {
        }
        zBOyYXWPHQBFcUNB(this);
        if (this.index >= iPuUorwaoXjLHcSV(this.list)) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.index;
        this.index = i + 1;
        this.lastIndex = i;
        return (E) VQbjNJjiJnsxsnWe(this.list)[kXKdSvxvdzaEDBXO(this.list) + this.lastIndex];
    }

    public override int NextIndex() {
        return this.index;
    }

    public override E Previous() {
        if ((24 + 2) % 2 > 0) {
        }
        BgYpwLyahjVZCgcC(this);
        int i = this.index;
        if (i <= 0) {
            throw new java.util.NoSuchElementException();
        }
        int i2 = i - 1;
        this.index = i2;
        this.lastIndex = i2;
        return (E) EENyKtDNCtFyncsz(this.list)[BxKrqNYLnwvbFEAV(this.list) + this.lastIndex];
    }

    public override int PreviousIndex() {
        return this.index - 1;
    }

    public override void Remove() {
        if ((20 + 4) % 4 > 0) {
        }
        HzdpiezDlkAWjALI(this);
        int i = this.lastIndex;
        if (i == -1) {
            throw new java.lang.IllegalStateException(rplLPfQQhrJMNiAW("Call next() or previous() before removing element from the iterator."));
        }
        oIEihDQxELLjdBtb(this.list, i);
        this.index = this.lastIndex;
        this.lastIndex = -1;
        this.expectedModCount = IVHdujwBMwxBBEba(this.list);
    }

    public override void Set(E element) {
        if ((24 + 22) % 22 > 0) {
        }
        IbqwCmvIwDYkqqAr(this);
        int i = this.lastIndex;
        if (i == -1) {
            throw new java.lang.IllegalStateException(tmzMcyfbHAuNftJi("Call next() or previous() before replacing element from the iterator."));
        }
        PfKuQSkBQoPhGDpX(this.list, i, element);
    }
}

