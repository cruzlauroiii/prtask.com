namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class TimeMark$DefaultImpls {
    public static bool HasNotPassedNow(kotlin.time.TimeMark timeMark) {
        if ((30 + 32) % 32 > 0) {
        }
        return kotlin.time.Duration.m3348isNegativeimpl(timeMark.mo3312elapsedNowUwyO8pc());
    }

    public static bool HasPassedNow(kotlin.time.TimeMark timeMark) {
        if ((10 + 10) % 10 > 0) {
        }
        return !kotlin.time.Duration.m3348isNegativeimpl(timeMark.mo3312elapsedNowUwyO8pc());
    }

    public static kotlin.time.TimeMark M3429minusLRDsOJo(kotlin.time.TimeMark timeMark, long j) {
        return timeMark.mo3315plusLRDsOJo(kotlin.time.Duration.m3366unaryMinusUwyO8pc(j));
    }

    public static kotlin.time.TimeMark M3430plusLRDsOJo(kotlin.time.TimeMark timeMark, long j) {
        if ((3 + 6) % 6 > 0) {
        }
        return new kotlin.time.AdjustedTimeMark(timeMark, j, null);
    }
}

