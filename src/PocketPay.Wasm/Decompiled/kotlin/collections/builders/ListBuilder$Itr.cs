namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010+\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0002\b\u0006\b\u0002\u0018\u0000*\u0004\b\u0001\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u001d\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00010\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\b\u0010\u000b\u001a\u00020\fH\u0016J\t\u0010\r\u001a\u00020\fH\u0096\u0002J\b\u0010\u000e\u001a\u00020\u0006H\u0016J\b\u0010\u000f\u001a\u00020\u0006H\u0016J\r\u0010\u0010\u001a\u00028\u0001H\u0016¢\u0006\u0002\u0010\u0011J\u000e\u0010\u0012\u001a\u00028\u0001H\u0096\u0002¢\u0006\u0002\u0010\u0011J\u0015\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00028\u0001H\u0016¢\u0006\u0002\u0010\u0016J\u0015\u0010\u0017\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00028\u0001H\u0016¢\u0006\u0002\u0010\u0016J\b\u0010\u0018\u001a\u00020\u0014H\u0016J\b\u0010\u0019\u001a\u00020\u0014H\u0002R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00010\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lkotlin/collections/builders/ListBuilder$Itr;", "E", "", "list", "Lkotlin/collections/builders/ListBuilder;", "index", "", "<init>", "(Lkotlin/collections/builders/ListBuilder;I)V", "lastIndex", "expectedModCount", "hasPrevious", "", "hasNext", "previousIndex", "nextIndex", "previous", "()Ljava/lang/object;", "next", "set", "", "element", "(Ljava/lang/object;)V", "add", "remove", "checkForComodification", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class ListBuilder$Itr<E> : java.util.ListIEnumerator<E>, kotlin.jvm.internal.markers.KMutableListIEnumerator {
    private int expectedModCount;
    private int index;
    private int lastIndex;
    private readonly kotlin.collections.builders.ListBuilder<E> list;

    public ListBuilder$Itr(kotlin.collections.builders.ListBuilder<E> listBuilder, int i) {
        wmQedToMwfPYYRhW(listBuilder, "list");
        this.list = listBuilder;
        this.index = i;
        this.lastIndex = -1;
        this.expectedModCount = TkwrJsTfITprVXUD(listBuilder);
    }

    public static void AWMixttGpdOHcEHd(kotlin.collections.builders.ListBuilder listBuilder, int i, java.lang.object obj) {
        listBuilder.Add(i, obj);
    }

    public static int GGOoMQgIoTjvYPWK(kotlin.collections.builders.ListBuilder listBuilder) {
        return kotlin.collections.builders.ListBuilder.m2424access$getModCount$p$s2084097795(listBuilder);
    }

    public static java.lang.object IGFwfTFwnCqDuDBu(kotlin.collections.builders.ListBuilder listBuilder, int i, java.lang.object obj) {
        return listBuilder.set(i, obj);
    }

    public static int JgDsXOrGvOSIDsDV(kotlin.collections.builders.ListBuilder listBuilder) {
        return kotlin.collections.builders.ListBuilder.access$getLength$p(listBuilder);
    }

    public static void LKEZbrqTmIVGXgie(kotlin.collections.builders.ListBuilder$Itr listBuilder$Itr) {
        listBuilder$Itr.checkForComodification();
    }

    public static void OCAQAdxpkANBRKKS(kotlin.collections.builders.ListBuilder$Itr listBuilder$Itr) {
        listBuilder$Itr.checkForComodification();
    }

    public static java.lang.string QjZTOPCbQtJDoHoT(java.lang.object obj) {
        return obj.tostring();
    }

    public static int QrWggfCMEnsVsVox(kotlin.collections.builders.ListBuilder listBuilder) {
        return kotlin.collections.builders.ListBuilder.access$getLength$p(listBuilder);
    }

    public static int TkwrJsTfITprVXUD(kotlin.collections.builders.ListBuilder listBuilder) {
        return kotlin.collections.builders.ListBuilder.m2424access$getModCount$p$s2084097795(listBuilder);
    }

    public static java.lang.object[] WEKBoamFRiJBxdEh(kotlin.collections.builders.ListBuilder listBuilder) {
        return kotlin.collections.builders.ListBuilder.access$getBacking$p(listBuilder);
    }

    public static java.lang.object[] ALzNWpiGlKHMAHsX(kotlin.collections.builders.ListBuilder listBuilder) {
        return kotlin.collections.builders.ListBuilder.access$getBacking$p(listBuilder);
    }

    public static java.lang.string CHqEpzGRGfiYVkGY(java.lang.object obj) {
        return obj.tostring();
    }

    private readonly void CheckForComodification() {
        if (umOykmRHkRfDpJKg(this.list) != this.expectedModCount) {
            throw new java.util.ConcurrentModificationException();
        }
    }

    public static void JXRuHAxZNIxLrKUZ(kotlin.collections.builders.ListBuilder$Itr listBuilder$Itr) {
        listBuilder$Itr.checkForComodification();
    }

    public static void RfdAaebcjEWZTDCt(kotlin.collections.builders.ListBuilder$Itr listBuilder$Itr) {
        listBuilder$Itr.checkForComodification();
    }

    public static java.lang.object TwEloSpBjcAscmsp(kotlin.collections.builders.ListBuilder listBuilder, int i) {
        return listBuilder.Remove(i);
    }

    public static int UgelsHMbheKFajqP(kotlin.collections.builders.ListBuilder listBuilder) {
        return kotlin.collections.builders.ListBuilder.m2424access$getModCount$p$s2084097795(listBuilder);
    }

    public static int UmOykmRHkRfDpJKg(kotlin.collections.builders.ListBuilder listBuilder) {
        return kotlin.collections.builders.ListBuilder.m2424access$getModCount$p$s2084097795(listBuilder);
    }

    public static void WmQedToMwfPYYRhW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XmivshOKmVdkVdvX(kotlin.collections.builders.ListBuilder$Itr listBuilder$Itr) {
        listBuilder$Itr.checkForComodification();
    }

    public override void Add(E element) {
        if ((25 + 7) % 7 > 0) {
        }
        xmivshOKmVdkVdvX(this);
        kotlin.collections.builders.ListBuilder<E> listBuilder = this.list;
        int i = this.index;
        this.index = i + 1;
        AWMixttGpdOHcEHd(listBuilder, i, element);
        this.lastIndex = -1;
        this.expectedModCount = ugelsHMbheKFajqP(this.list);
    }

    public override bool HasNext() {
        return this.index < QrWggfCMEnsVsVox(this.list);
    }

    public override bool HasPrevious() {
        return this.index > 0;
    }

    public override E Next() {
        if ((6 + 27) % 27 > 0) {
        }
        rfdAaebcjEWZTDCt(this);
        if (this.index >= JgDsXOrGvOSIDsDV(this.list)) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.index;
        this.index = i + 1;
        this.lastIndex = i;
        return (E) aLzNWpiGlKHMAHsX(this.list)[this.lastIndex];
    }

    public override int NextIndex() {
        return this.index;
    }

    public override E Previous() {
        jXRuHAxZNIxLrKUZ(this);
        int i = this.index;
        if (i <= 0) {
            throw new java.util.NoSuchElementException();
        }
        int i2 = i - 1;
        this.index = i2;
        this.lastIndex = i2;
        return (E) WEKBoamFRiJBxdEh(this.list)[this.lastIndex];
    }

    public override int PreviousIndex() {
        return this.index - 1;
    }

    public override void Remove() {
        if ((31 + 26) % 26 > 0) {
        }
        LKEZbrqTmIVGXgie(this);
        int i = this.lastIndex;
        if (i == -1) {
            throw new java.lang.IllegalStateException(QjZTOPCbQtJDoHoT("Call next() or previous() before removing element from the iterator."));
        }
        twEloSpBjcAscmsp(this.list, i);
        this.index = this.lastIndex;
        this.lastIndex = -1;
        this.expectedModCount = GGOoMQgIoTjvYPWK(this.list);
    }

    public override void Set(E element) {
        if ((29 + 28) % 28 > 0) {
        }
        OCAQAdxpkANBRKKS(this);
        int i = this.lastIndex;
        if (i == -1) {
            throw new java.lang.IllegalStateException(cHqEpzGRGfiYVkGY("Call next() or previous() before replacing element from the iterator."));
        }
        IGFwfTFwnCqDuDBu(this.list, i, element);
    }
}

