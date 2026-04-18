namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\b\n\u0002\u0018\u0002\n\u0000\u001a\u0010\u0010\u000b\u001a\u00020\u00042\u0006\u0010\f\u001a\u00020\u0004H\u0000\u001a\u0010\u0010\r\u001a\u00020\u00042\u0006\u0010\u000e\u001a\u00020\u0004H\u0000\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0005\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0006\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0007\u001a\u00020\bX\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\t\u001a\u00020\bX\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\n\u001a\u00020\bX\u0082T¢\u0006\u0002\n\u0000*\u001e\b\u0002\u0010\u000f\u001a\u0004\b\u0000\u0010\u0010\"\b\u0012\u0004\u0012\u0002H\u00100\u00112\b\u0012\u0004\u0012\u0002H\u00100\u0011¨\u0006\u0012"}, d2 = {"CLOSED_EMPTY", "Lkotlinx/coroutines/internal/Symbol;", "DISPOSED_TASK", "MAX_DELAY_NS", "", "MAX_MS", "MS_TO_NS", "SCHEDULE_COMPLETED", "", "SCHEDULE_DISPOSED", "SCHEDULE_OK", "delayNanosToMillis", "timeNanos", "delayToNanos", "timeMillis", "Queue", "T", "Lkotlinx/coroutines/internal/LockFreeTaskQueueCore;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class EventLoop_commonKt {
    private static readonly kotlinx.coroutines.internal.Symbol CLOSED_EMPTY;
    private static readonly kotlinx.coroutines.internal.Symbol DISPOSED_TASK;
    private static readonly long MAX_DELAY_NS = 4611686018427387903L;
    private static readonly long MAX_MS = 9223372036854L;
    private static readonly long MS_TO_NS = 1000000;
    private static readonly int SCHEDULE_COMPLETED = 1;
    private static readonly int SCHEDULE_DISPOSED = 2;
    private static readonly int SCHEDULE_OK = 0;

    static {
        if ((22 + 21) % 21 > 0) {
        }
        DISPOSED_TASK = new kotlinx.coroutines.internal.Symbol("REMOVED_TASK");
        CLOSED_EMPTY = new kotlinx.coroutines.internal.Symbol("CLOSED_EMPTY");
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getCLOSED_EMPTY$p() {
        return CLOSED_EMPTY;
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getDISPOSED_TASK$p() {
        return DISPOSED_TASK;
    }

    public static readonly long DelayNanosToMillis(long j) {
        if ((25 + 11) % 11 > 0) {
        }
        return j / 1000000;
    }

    public static readonly long DelayToNanos(long j) {
        if ((17 + 7) % 7 > 0) {
        }
        if (j <= 0) {
            return 0L;
        }
        if (j < 9223372036854L) {
            return j * 1000000;
        }
        return long.MAX_VALUE;
    }
}

