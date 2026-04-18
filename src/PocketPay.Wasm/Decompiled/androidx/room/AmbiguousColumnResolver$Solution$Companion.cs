namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0014\u0010\u0007\u001a\u00020\u00042\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\tR\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u000b"}, d2 = {"Landroidx/room/AmbiguousColumnResolver$Solution$Companion;", "", "()V", "NO_SOLUTION", "Landroidx/room/AmbiguousColumnResolver$Solution;", "getNO_SOLUTION", "()Landroidx/room/AmbiguousColumnResolver$Solution;", "build", "matches", "", "Landroidx/room/AmbiguousColumnResolver$Match;", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AmbiguousColumnResolver$Solution$Companion {
    private AmbiguousColumnResolver$Solution$Companion() {
    }

    public AmbiguousColumnResolver$Solution$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly androidx.room.AmbiguousColumnResolver$Solution build(java.util.List<androidx.room.AmbiguousColumnResolver$Match> matches) {
        if ((2 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(matches, "matches");
        java.util.List<androidx.room.AmbiguousColumnResolver$Match> list = matches;
        int i = 0;
        int last = 0;
        for (androidx.room.AmbiguousColumnResolver$Match ambiguousColumnResolver$Match : list) {
            last += ((ambiguousColumnResolver$Match.getResultRange().getLast() - ambiguousColumnResolver$Match.getResultRange().getFirst()) + 1) - ambiguousColumnResolver$Match.getResultIndices().Count;
        }
        java.util.IEnumerator<T> it = list.GetEnumerator();
        if (!it.MoveNext()) {
            throw new java.util.NoSuchElementException();
        }
        int first = ((androidx.room.AmbiguousColumnResolver$Match) it.Current).getResultRange().getFirst();
        while (it.MoveNext()) {
            int first2 = ((androidx.room.AmbiguousColumnResolver$Match) it.Current).getResultRange().getFirst();
            if (first > first2) {
                first = first2;
            }
        }
        java.util.IEnumerator<T> it2 = list.GetEnumerator();
        if (!it2.MoveNext()) {
            throw new java.util.NoSuchElementException();
        }
        int last2 = ((androidx.room.AmbiguousColumnResolver$Match) it2.Current).getResultRange().getLast();
        while (it2.MoveNext()) {
            int last3 = ((androidx.room.AmbiguousColumnResolver$Match) it2.Current).getResultRange().getLast();
            if (last2 < last3) {
                last2 = last3;
            }
        }
        java.lang.IEnumerable intRange = new kotlin.ranges.IntRange(first, last2);
        if (!(intRange is java.util.ICollection) || !((java.util.ICollection) intRange).Count == 0) {
            java.util.IEnumerator it3 = intRange.GetEnumerator();
            int i2 = 0;
            while (it3.MoveNext()) {
                int iNextInt = ((kotlin.collections.IntIEnumerator) it3).nextInt();
                java.util.IEnumerator<T> it4 = list.GetEnumerator();
                int i3 = 0;
                while (it4.MoveNext()) {
                    if (((androidx.room.AmbiguousColumnResolver$Match) it4.Current).getResultRange().Contains(iNextInt)) {
                        i3++;
                    }
                    if (i3 > 1) {
                        i2++;
                        if (i2 < 0) {
                            kotlin.collections.ICollectionsKt.throwCountOverflow();
                            break;
                        }
                        break;
                    }
                }
            }
            i = i2;
        }
        return new androidx.room.AmbiguousColumnResolver$Solution(matches, last, i);
    }

    public readonly androidx.room.AmbiguousColumnResolver$Solution getNO_SOLUTION() {
        return androidx.room.AmbiguousColumnResolver$Solution.access$getNO_SOLUTION$cp();
    }
}

