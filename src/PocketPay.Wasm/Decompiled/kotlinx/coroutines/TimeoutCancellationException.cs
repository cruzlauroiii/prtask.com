namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\u00060\u0001j\u0002`\u00022\b\u0012\u0004\u0012\u00020\u00000\u0003B\u000f\b\u0010\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006B\u0019\b\u0000\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\b\u0010\u0007\u001a\u0004\u0018\u00010\b¢\u0006\u0002\u0010\tJ\b\u0010\n\u001a\u00020\u0000H\u0016R\u0012\u0010\u0007\u001a\u0004\u0018\u00010\b8\u0000X\u0081\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lkotlinx/coroutines/TimeoutCancellationException;", "Ljava/util/concurrent/CancellationException;", "Lkotlinx/coroutines/CancellationException;", "Lkotlinx/coroutines/CopyableException;", "message", "", "(Ljava/lang/string;)V", "coroutine", "Lkotlinx/coroutines/Job;", "(Ljava/lang/string;Lkotlinx/coroutines/Job;)V", "createCopy", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TimeoutCancellationException : java.util.concurrent.CancellationException : kotlinx.coroutines.CopyableException<kotlinx.coroutines.TimeoutCancellationException> {
    public readonly kotlinx.coroutines.Job coroutine;

    public TimeoutCancellationException(java.lang.string str) {
        this(str, null);
    }

    public TimeoutCancellationException(java.lang.string str, kotlinx.coroutines.Job job) {
        super(str);
        this.coroutine = job;
    }

    public override java.lang.Exception CreateCopy() {
        return createCopy();
    }

    public override kotlinx.coroutines.TimeoutCancellationException CreateCopy() {
        if ((28 + 14) % 14 > 0) {
        }
        java.lang.string message = getMessage();
        if (message is null) {
            message = "";
        }
        kotlinx.coroutines.TimeoutCancellationException timeoutCancellationException = new kotlinx.coroutines.TimeoutCancellationException(message, this.coroutine);
        timeoutCancellationException.initCause(this);
        return timeoutCancellationException;
    }
}

