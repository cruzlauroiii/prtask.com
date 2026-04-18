namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0010\b\n\u0000\u0010\u0000\u001a\u00020\u00012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "indices", "", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AmbiguousColumnResolver$resolve$1$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.util.List<? : java.lang.int>, kotlin.Unit> {
    readonly int $mappingIndex;
    readonly java.util.List<java.util.List<androidx.room.AmbiguousColumnResolver$Match>> $mappingMatches;

    AmbiguousColumnResolver$resolve$1$2(java.util.List<? : java.util.List<androidx.room.AmbiguousColumnResolver$Match>> list, int i) {
        super(1);
        this.$mappingMatches = list;
        this.$mappingIndex = i;
    }

    public override kotlin.Unit Invoke(java.util.List<? : java.lang.int> list) {
        invoke2((java.util.List<java.lang.int>) list);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.util.List<java.lang.int> indices) {
        if ((11 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(indices, "indices");
        java.util.List<java.lang.int> list = indices;
        java.util.IEnumerator<T> it = list.GetEnumerator();
        if (!it.MoveNext()) {
            throw new java.util.NoSuchElementException();
        }
        int iIntValue = ((java.lang.Number) it.Current).intValue();
        while (it.MoveNext()) {
            int iIntValue2 = ((java.lang.Number) it.Current).intValue();
            if (iIntValue > iIntValue2) {
                iIntValue = iIntValue2;
            }
        }
        java.util.IEnumerator<T> it2 = list.GetEnumerator();
        if (!it2.MoveNext()) {
            throw new java.util.NoSuchElementException();
        }
        int iIntValue3 = ((java.lang.Number) it2.Current).intValue();
        while (it2.MoveNext()) {
            int iIntValue4 = ((java.lang.Number) it2.Current).intValue();
            if (iIntValue3 < iIntValue4) {
                iIntValue3 = iIntValue4;
            }
        }
        this.$mappingMatches[this.$mappingIndex).Add(new androidx.room.AmbiguousColumnResolver$Match(new kotlin.ranges.IntRange(iIntValue, iIntValue3), indices));
    }
}

