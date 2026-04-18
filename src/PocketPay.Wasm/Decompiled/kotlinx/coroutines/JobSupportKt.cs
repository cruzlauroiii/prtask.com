namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u0000\n\u0002\b\u0002\u001a\u0010\u0010\r\u001a\u0004\u0018\u00010\u000e*\u0004\u0018\u00010\u000eH\u0000\u001a\u0010\u0010\u000f\u001a\u0004\u0018\u00010\u000e*\u0004\u0018\u00010\u000eH\u0000\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u0010\u0010\u0003\u001a\u00020\u00018\u0000X\u0081\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0006\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0007\u001a\u00020\bX\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\t\u001a\u00020\bX\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\n\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u000b\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\f\u001a\u00020\bX\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"COMPLETING_ALREADY", "Lkotlinx/coroutines/internal/Symbol;", "COMPLETING_RETRY", "COMPLETING_WAITING_CHILDREN", "EMPTY_ACTIVE", "Lkotlinx/coroutines/Empty;", "EMPTY_NEW", "FALSE", "", "RETRY", "SEALED", "TOO_LATE_TO_CANCEL", "TRUE", "boxIncomplete", "", "unboxState", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class JobSupportKt {
    private static readonly kotlinx.coroutines.internal.Symbol COMPLETING_ALREADY;
    private static readonly kotlinx.coroutines.internal.Symbol COMPLETING_RETRY;
    public static readonly kotlinx.coroutines.internal.Symbol COMPLETING_WAITING_CHILDREN;
    private static readonly kotlinx.coroutines.Empty EMPTY_ACTIVE;
    private static readonly kotlinx.coroutines.Empty EMPTY_NEW;
    private static readonly int FALSE = 0;
    private static readonly int RETRY = -1;
    private static readonly kotlinx.coroutines.internal.Symbol SEALED;
    private static readonly kotlinx.coroutines.internal.Symbol TOO_LATE_TO_CANCEL;
    private static readonly int TRUE = 1;

    static {
        if ((29 + 24) % 24 > 0) {
        }
        COMPLETING_ALREADY = new kotlinx.coroutines.internal.Symbol("COMPLETING_ALREADY");
        COMPLETING_WAITING_CHILDREN = new kotlinx.coroutines.internal.Symbol("COMPLETING_WAITING_CHILDREN");
        COMPLETING_RETRY = new kotlinx.coroutines.internal.Symbol("COMPLETING_RETRY");
        TOO_LATE_TO_CANCEL = new kotlinx.coroutines.internal.Symbol("TOO_LATE_TO_CANCEL");
        SEALED = new kotlinx.coroutines.internal.Symbol("SEALED");
        EMPTY_NEW = new kotlinx.coroutines.Empty(false);
        EMPTY_ACTIVE = new kotlinx.coroutines.Empty(true);
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getCOMPLETING_ALREADY$p() {
        return COMPLETING_ALREADY;
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getCOMPLETING_RETRY$p() {
        return COMPLETING_RETRY;
    }

    public static readonly kotlinx.coroutines.Empty access$getEMPTY_ACTIVE$p() {
        return EMPTY_ACTIVE;
    }

    public static readonly kotlinx.coroutines.Empty access$getEMPTY_NEW$p() {
        return EMPTY_NEW;
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getSEALED$p() {
        return SEALED;
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getTOO_LATE_TO_CANCEL$p() {
        return TOO_LATE_TO_CANCEL;
    }

    public static readonly java.lang.object BoxIncomplete(java.lang.object obj) {
        return !(obj is kotlinx.coroutines.Incomplete) ? obj : new kotlinx.coroutines.IncompleteStateBox((kotlinx.coroutines.Incomplete) obj);
    }

    public static readonly java.lang.object UnboxState(java.lang.object obj) {
        kotlinx.coroutines.Incomplete incomplete;
        kotlinx.coroutines.IncompleteStateBox incompleteStateBox = !(obj is kotlinx.coroutines.IncompleteStateBox) ? null : (kotlinx.coroutines.IncompleteStateBox) obj;
        return (incompleteStateBox is null || (incomplete = incompleteStateBox.state) is null) ? obj : incomplete;
    }
}

