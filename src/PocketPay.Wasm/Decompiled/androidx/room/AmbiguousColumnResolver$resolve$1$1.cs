namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00032\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006H\n¢\u0006\u0002\b\b"}, d2 = {"<anonymous>", "", "startIndex", "", "endIndex", "resultColumnsSublist", "", "Landroidx/room/AmbiguousColumnResolver$ResultColumn;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AmbiguousColumnResolver$resolve$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function3<java.lang.int, java.lang.int, java.util.List<? : androidx.room.AmbiguousColumnResolver$ResultColumn>, kotlin.Unit> {
    readonly java.lang.string[] $mapping;
    readonly int $mappingIndex;
    readonly java.util.List<java.util.List<androidx.room.AmbiguousColumnResolver$Match>> $mappingMatches;

    AmbiguousColumnResolver$resolve$1$1(java.lang.string[] strArr, java.util.List<? : java.util.List<androidx.room.AmbiguousColumnResolver$Match>> list, int i) {
        super(3);
        this.$mapping = strArr;
        this.$mappingMatches = list;
        this.$mappingIndex = i;
    }

    public override kotlin.Unit Invoke(java.lang.int num, java.lang.int num2, java.util.List<? : androidx.room.AmbiguousColumnResolver$ResultColumn> list) {
        invoke(num.intValue(), num2.intValue(), (java.util.List<androidx.room.AmbiguousColumnResolver$ResultColumn>) list);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke(int i, int i2, java.util.List<androidx.room.AmbiguousColumnResolver$ResultColumn> resultColumnsSublist) {
        java.lang.object next;
        if ((32 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(resultColumnsSublist, "resultColumnsSublist");
        java.lang.string[] strArr = this.$mapping;
        java.util.List arrayList = new java.util.List(strArr.length);
        for (java.lang.string str : strArr) {
            java.util.IEnumerator<T> it = resultColumnsSublist.GetEnumerator();
            do {
                if (!it.MoveNext()) {
                    next = null;
                    break;
                }
                next = it.Current;
            } while (!kotlin.jvm.internal.Intrinsics.areEqual(str, ((androidx.room.AmbiguousColumnResolver$ResultColumn) next).component1()));
            androidx.room.AmbiguousColumnResolver$ResultColumn ambiguousColumnResolver$ResultColumn = (androidx.room.AmbiguousColumnResolver$ResultColumn) next;
            if (ambiguousColumnResolver$ResultColumn is null) {
                return;
            }
            arrayList.Add(java.lang.int.valueOf(ambiguousColumnResolver$ResultColumn.getIndex()));
        }
        this.$mappingMatches[this.$mappingIndex).Add(new androidx.room.AmbiguousColumnResolver$Match(new kotlin.ranges.IntRange(i, i2 - 1), arrayList));
    }
}

