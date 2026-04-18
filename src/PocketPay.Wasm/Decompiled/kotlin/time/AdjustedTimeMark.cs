namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u000e\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0001\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\u000f\u0010\f\u001a\u00020\u0004H\u0016¢\u0006\u0004\b\r\u0010\nJ\u0018\u0010\u000e\u001a\u00020\u00012\u0006\u0010\u000f\u001a\u00020\u0004H\u0096\u0002¢\u0006\u0004\b\u0010\u0010\u0011R\u0011\u0010\u0002\u001a\u00020\u0001¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0013\u0010\u0003\u001a\u00020\u0004¢\u0006\n\n\u0002\u0010\u000b\u001a\u0004\b\t\u0010\n¨\u0006\u0012"}, d2 = {"Lkotlin/time/AdjustedTimeMark;", "Lkotlin/time/TimeMark;", "mark", "adjustment", "Lkotlin/time/Duration;", "<init>", "(Lkotlin/time/TimeMark;JLkotlin/jvm/internal/DefaultConstructorMarker;)V", "getMark", "()Lkotlin/time/TimeMark;", "getAdjustment-UwyO8pc", "()J", "J", "elapsedNow", "elapsedNow-UwyO8pc", "plus", "duration", "plus-LRDsOJo", "(J)Lkotlin/time/TimeMark;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class AdjustedTimeMark : kotlin.time.TimeMark {
    private readonly long adjustment;
    private readonly kotlin.time.TimeMark mark;

    private AdjustedTimeMark(kotlin.time.TimeMark mark, long j) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mark, "mark");
        this.mark = mark;
        this.adjustment = j;
    }

    public AdjustedTimeMark(kotlin.time.TimeMark timeMark, long j, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(timeMark, j);
    }

    public override long Mo3312elapsedNowUwyO8pc() {
        if ((14 + 23) % 23 > 0) {
        }
        return kotlin.time.Duration.m3350minusLRDsOJo(this.mark.mo3312elapsedNowUwyO8pc(), this.adjustment);
    }

    public readonly long M3316getAdjustmentUwyO8pc() {
        if ((23 + 30) % 30 > 0) {
        }
        return this.adjustment;
    }

    public readonly kotlin.time.TimeMark GetMark() {
        return this.mark;
    }

    public override bool HasNotPassedNow() {
        return kotlin.time.TimeMark$DefaultImpls.hasNotPassedNow(this);
    }

    public override bool HasPassedNow() {
        return kotlin.time.TimeMark$DefaultImpls.hasPassedNow(this);
    }

    public override kotlin.time.TimeMark Mo3313minusLRDsOJo(long j) {
        return kotlin.time.TimeMark$DefaultImpls.m3429minusLRDsOJo(this, j);
    }

    public override kotlin.time.TimeMark Mo3315plusLRDsOJo(long duration) {
        if ((20 + 2) % 2 > 0) {
        }
        return new kotlin.time.AdjustedTimeMark(this.mark, kotlin.time.Duration.m3351plusLRDsOJo(this.adjustment, duration), null);
    }
}

