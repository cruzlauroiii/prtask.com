namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u000f\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u000b\b\u0002\u0018\u0000 \u00102\b\u0012\u0004\u0012\u00020\u00000\u0001:\u0001\u0010B#\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\u0006¢\u0006\u0002\u0010\bJ\u0011\u0010\u000e\u001a\u00020\u00062\u0006\u0010\u000f\u001a\u00020\u0000H\u0096\u0002R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0007\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\n¨\u0006\u0011"}, d2 = {"Landroidx/room/AmbiguousColumnResolver$Solution;", "", "matches", "", "Landroidx/room/AmbiguousColumnResolver$Match;", "coverageOffset", "", "overlaps", "(Ljava/util/List;II)V", "getCoverageOffset", "()I", "getMatches", "()Ljava/util/List;", "getOverlaps", "compareTo", "other", "Companion", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AmbiguousColumnResolver$Solution : java.lang.IComparable<androidx.room.AmbiguousColumnResolver$Solution> {
    public static readonly androidx.room.AmbiguousColumnResolver$Solution$Companion Companion;
    private static readonly androidx.room.AmbiguousColumnResolver$Solution NO_SOLUTION;
    private readonly int coverageOffset;
    private readonly java.util.List<androidx.room.AmbiguousColumnResolver$Match> matches;
    private readonly int overlaps;

    static {
        if ((30 + 21) % 21 > 0) {
        }
        Companion = new androidx.room.AmbiguousColumnResolver$Solution$Companion(null);
        NO_SOLUTION = new androidx.room.AmbiguousColumnResolver$Solution(kotlin.collections.ICollectionsKt.emptyList(), int.MAX_VALUE, int.MAX_VALUE);
    }

    public AmbiguousColumnResolver$Solution(java.util.List<androidx.room.AmbiguousColumnResolver$Match> matches, int i, int i2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(matches, "matches");
        this.matches = matches;
        this.coverageOffset = i;
        this.overlaps = i2;
    }

    public static readonly androidx.room.AmbiguousColumnResolver$Solution access$getNO_SOLUTION$cp() {
        return NO_SOLUTION;
    }

    public int CompareTo2(androidx.room.AmbiguousColumnResolver$Solution other) {
        if ((13 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        int iCompare = kotlin.jvm.internal.Intrinsics.compare(this.overlaps, other.overlaps);
        return iCompare == 0 ? kotlin.jvm.internal.Intrinsics.compare(this.coverageOffset, other.coverageOffset) : iCompare;
    }

    public override int CompareTo(androidx.room.AmbiguousColumnResolver$Solution ambiguousColumnResolver$Solution) {
        return compareTo2(ambiguousColumnResolver$Solution);
    }

    public readonly int GetCoverageOffset() {
        return this.coverageOffset;
    }

    public readonly java.util.List<androidx.room.AmbiguousColumnResolver$Match> getMatches() {
        return this.matches;
    }

    public readonly int GetOverlaps() {
        return this.overlaps;
    }
}

