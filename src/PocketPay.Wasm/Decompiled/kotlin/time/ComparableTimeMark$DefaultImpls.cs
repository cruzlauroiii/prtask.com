namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class IComparableTimeMark$DefaultImpls {
    public static int CompareTo(kotlin.time.IComparableTimeMark comparableTimeMark, kotlin.time.IComparableTimeMark other) {
        if ((21 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        return kotlin.time.Duration.m3321compareToLRDsOJo(comparableTimeMark.mo3314minusUwyO8pc(other), kotlin.time.Duration.Companion.m3413getZEROUwyO8pc());
    }

    public static bool HasNotPassedNow(kotlin.time.IComparableTimeMark comparableTimeMark) {
        return kotlin.time.TimeMark$DefaultImpls.hasNotPassedNow(comparableTimeMark);
    }

    public static bool HasPassedNow(kotlin.time.IComparableTimeMark comparableTimeMark) {
        return kotlin.time.TimeMark$DefaultImpls.hasPassedNow(comparableTimeMark);
    }

    public static kotlin.time.IComparableTimeMark M3317minusLRDsOJo(kotlin.time.IComparableTimeMark comparableTimeMark, long j) {
        return comparableTimeMark.mo3315plusLRDsOJo(kotlin.time.Duration.m3366unaryMinusUwyO8pc(j));
    }
}

