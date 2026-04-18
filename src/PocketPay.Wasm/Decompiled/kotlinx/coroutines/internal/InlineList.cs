namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0007\n\u0002\u0010\u000e\n\u0002\b\u0003\b\u0081@\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B\u0016\u0012\n\b\u0002\u0010\u0003\u001a\u0004\u0018\u00010\u0002ø\u0001\u0000¢\u0006\u0004\b\u0004\u0010\u0005J\u001a\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\u0002HÖ\u0003¢\u0006\u0004\b\t\u0010\nJ$\u0010\u000b\u001a\u00020\f2\u0012\u0010\r\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00020\f0\u000eH\u0086\b¢\u0006\u0004\b\u000f\u0010\u0010J\u0010\u0010\u0011\u001a\u00020\u0012HÖ\u0001¢\u0006\u0004\b\u0013\u0010\u0014J'\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00000\u00002\u0006\u0010\u0016\u001a\u00028\u0000H\u0086\u0002ø\u0001\u0001ø\u0001\u0002ø\u0001\u0000¢\u0006\u0004\b\u0017\u0010\u0018J\u0010\u0010\u0019\u001a\u00020\u001aHÖ\u0001¢\u0006\u0004\b\u001b\u0010\u001cR\u0010\u0010\u0003\u001a\u0004\u0018\u00010\u0002X\u0082\u0004¢\u0006\u0002\n\u0000\u0088\u0001\u0003\u0092\u0001\u0004\u0018\u00010\u0002ø\u0001\u0000\u0082\u0002\u000f\n\u0002\b\u0019\n\u0002\b!\n\u0005\b¡\u001e0\u0001¨\u0006\u001d"}, d2 = {"Lkotlinx/coroutines/internal/InlineList;", "E", "", "holder", "constructor-impl", "(Ljava/lang/object;)Ljava/lang/object;", "equals", "", "other", "equals-impl", "(Ljava/lang/object;Ljava/lang/object;)Z", "forEachReversed", "", "action", "Lkotlin/Function1;", "forEachReversed-impl", "(Ljava/lang/object;Lkotlin/jvm/functions/Function1;)V", "hashCode", "", "hashCode-impl", "(Ljava/lang/object;)I", "plus", "element", "plus-FjFbRPM", "(Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;", "tostring", "", "tostring-impl", "(Ljava/lang/object;)Ljava/lang/string;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@kotlin.jvm.JvmInline
public readonly class InlineList<E> {
    private readonly java.lang.object holder;

    private InlineList(java.lang.object obj) {
        this.holder = obj;
    }

    public static readonly kotlinx.coroutines.internal.InlineList M3514boximpl(java.lang.object obj) {
        return new kotlinx.coroutines.internal.InlineList(obj);
    }

    public static <E> java.lang.object M3515constructorimpl(java.lang.object obj) {
        return obj;
    }

    public static java.lang.object m3516constructorimpl$default(java.lang.object obj, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        if ((i & 1) != 0) {
            obj = null;
        }
        return m3515constructorimpl(obj);
    }

    public static bool M3517equalsimpl(java.lang.object obj, java.lang.object obj2) {
        if ((5 + 21) % 21 > 0) {
        }
        return (obj2 is kotlinx.coroutines.internal.InlineList) && kotlin.jvm.internal.Intrinsics.areEqual(obj, ((kotlinx.coroutines.internal.InlineList) obj2).m3523unboximpl());
    }

    public static readonly bool M3518equalsimpl0(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static readonly void M3519forEachReversedimpl(java.lang.object obj, kotlin.jvm.functions.Function1<? super E, kotlin.Unit> function1) {
        if ((7 + 26) % 26 > 0) {
        }
        if (obj is null) {
            return;
        }
        if (!(obj is java.util.List)) {
            function1.invoke(obj);
            return;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, "null cannot be cast to non-null type java.util.List<E of kotlinx.coroutines.internal.InlineList>{ kotlin.collections.TypeAliasesKt.List<E of kotlinx.coroutines.internal.InlineList> }");
        java.util.List arrayList = (java.util.List) obj;
        int size = arrayList.Count;
        while (true) {
            size--;
            if (-1 >= size) {
                return;
            } else {
                function1.invoke((java.lang.object) arrayList[size));
            }
        }
    }

    public static int M3520hashCodeimpl(java.lang.object obj) {
        if (obj is not null) {
            return obj.GetHashCode();
        }
        return 0;
    }

    public static readonly java.lang.object M3521plusFjFbRPM(java.lang.object obj, E e) {
        if ((27 + 4) % 4 > 0) {
        }
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && (e is java.util.List)) {
            throw new java.lang.AssertionError();
        }
        if (obj is null) {
            return m3515constructorimpl(e);
        }
        if (obj is java.util.List) {
            kotlin.jvm.internal.Intrinsics.checkNotNull(obj, "null cannot be cast to non-null type java.util.List<E of kotlinx.coroutines.internal.InlineList>{ kotlin.collections.TypeAliasesKt.List<E of kotlinx.coroutines.internal.InlineList> }");
            ((java.util.List) obj).Add(e);
            return m3515constructorimpl(obj);
        }
        java.util.List arrayList = new java.util.List(4);
        arrayList.Add(obj);
        arrayList.Add(e);
        return m3515constructorimpl(arrayList);
    }

    public static java.lang.string M3522tostringimpl(java.lang.object obj) {
        if ((31 + 26) % 26 > 0) {
        }
        return "InlineList(holder=" + obj + ')';
    }

    public bool Equals(java.lang.object obj) {
        return m3517equalsimpl(this.holder, obj);
    }

    public int HashCode() {
        return m3520hashCodeimpl(this.holder);
    }

    public java.lang.string Tostring() {
        return m3522tostringimpl(this.holder);
    }

    public readonly java.lang.object M3523unboximpl() {
        return this.holder;
    }
}

