namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000f\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0005\bÂ\u0002\u0018\u00002\u001e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00030\u00020\u0001j\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00030\u0002`\u0004B\t\b\u0002¢\u0006\u0004\b\u0005\u0010\u0006J$\u0010\u0007\u001a\u00020\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00030\u00022\f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00030\u0002H\u0016J'\u0010\u000b\u001a\u001e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00030\u00020\u0001j\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00030\u0002`\u0004¢\u0006\u0002\u0010\f¨\u0006\r"}, d2 = {"Lkotlin/comparisons/ReverseOrderComparator;", "Ljava/util/Comparator;", "", "", "Lkotlin/Comparator;", "<init>", "()V", "compare", "", "a", "b", "reversed", "()Ljava/util/Comparator;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class ReverseOrderComparator : java.util.Comparator<java.lang.IComparable<java.lang.object>> {
    public static readonly kotlin.comparisons.ReverseOrderComparator INSTANCE = new kotlin.comparisons.ReverseOrderComparator();

    private ReverseOrderComparator() {
    }

    public int Compare2(java.lang.IComparable<java.lang.object> a2, java.lang.IComparable<java.lang.object> b) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(a2, "a");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(b, "b");
        return b.compareTo(a2);
    }

    public override int Compare(java.lang.IComparable<java.lang.object> comparable, java.lang.IComparable<java.lang.object> comparable2) {
        return compare2((java.lang.IComparable<java.lang.object>) comparable, (java.lang.IComparable<java.lang.object>) comparable2);
    }

    public override readonly java.util.Comparator<java.lang.IComparable<java.lang.object>> Reversed() {
        return kotlin.comparisons.NaturalOrderComparator.INSTANCE;
    }
}

