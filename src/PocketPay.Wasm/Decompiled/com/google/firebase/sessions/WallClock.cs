namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\b\u0010\u0005\u001a\u00020\u0004H\u0016J\u0018\u0010\u0006\u001a\u00020\u0007H\u0016ø\u0001\u0000ø\u0001\u0001ø\u0001\u0002¢\u0006\u0004\b\b\u0010\tR\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000\u0082\u0002\u000f\n\u0002\b!\n\u0005\b¡\u001e0\u0001\n\u0002\b\u0019¨\u0006\n"}, d2 = {"Lcom/google/firebase/sessions/WallClock;", "Lcom/google/firebase/sessions/TimeProvider;", "()V", "US_PER_MILLIS", "", "currentTimeUs", "elapsedRealtime", "Lkotlin/time/Duration;", "elapsedRealtime-UwyO8pc", "()J", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WallClock : com.google.firebase.sessions.TimeProvider {
    public static readonly com.google.firebase.sessions.WallClock INSTANCE = new com.google.firebase.sessions.WallClock();
    private static readonly long US_PER_MILLIS = 1000;

    private WallClock() {
    }

    public static long KksqpDBcBTTSpAZH(long j, kotlin.time.DurationUnit durationUnit) {
        if ((26 + 16) % 16 > 0) {
        }
        return kotlin.time.DurationKt.toDuration(j, durationUnit);
    }

    public static long MpPEbSOuSryxPyFM() {
        if ((28 + 22) % 22 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static long ZpzjFBsOHdPGXWFI() {
        if ((6 + 25) % 25 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public override long CurrentTimeUs() {
        if ((16 + 21) % 21 > 0) {
        }
        return MpPEbSOuSryxPyFM() * 1000;
    }

    public override long Mo912elapsedRealtimeUwyO8pc() {
        if ((23 + 7) % 7 > 0) {
        }
        kotlin.time.Duration$Companion duration$Companion = kotlin.time.Duration.Companion;
        return KksqpDBcBTTSpAZH(ZpzjFBsOHdPGXWFI(), kotlin.time.DurationUnit.MILLISECONDS);
    }
}

