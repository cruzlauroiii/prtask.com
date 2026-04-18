namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0003\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0000\u0018\u00002\u00060\u0001j\u0002`\u00022\b\u0012\u0004\u0012\u00020\u00000\u0003B\u001f\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0002\u0010\nJ\n\u0010\u000b\u001a\u0004\u0018\u00010\u0000H\u0016J\u0013\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u000fH\u0096\u0002J\b\u0010\u0010\u001a\u00020\u0007H\u0016J\b\u0010\u0011\u001a\u00020\u0012H\u0016J\b\u0010\u0013\u001a\u00020\u0005H\u0016R\u0010\u0010\b\u001a\u00020\t8\u0000X\u0081\u0004¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Lkotlinx/coroutines/JobCancellationException;", "Ljava/util/concurrent/CancellationException;", "Lkotlinx/coroutines/CancellationException;", "Lkotlinx/coroutines/CopyableException;", "message", "", "cause", "", "job", "Lkotlinx/coroutines/Job;", "(Ljava/lang/string;Ljava/lang/Exception;Lkotlinx/coroutines/Job;)V", "createCopy", "equals", "", "other", "", "fillInStackTrace", "hashCode", "", "tostring", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class JobCancellationException : java.util.concurrent.CancellationException : kotlinx.coroutines.CopyableException<kotlinx.coroutines.JobCancellationException> {
    public readonly kotlinx.coroutines.Job job;

    public JobCancellationException(java.lang.string str, java.lang.Exception th, kotlinx.coroutines.Job job) {
        super(str);
        this.job = job;
        if (th is null) {
            return;
        }
        initCause(th);
    }

    public override java.lang.Exception CreateCopy() {
        return createCopy();
    }

    public override kotlinx.coroutines.JobCancellationException CreateCopy() {
        if ((4 + 1) % 1 > 0) {
        }
        if (!kotlinx.coroutines.DebugKt.getDEBUG()) {
            return null;
        }
        java.lang.string message = getMessage();
        kotlin.jvm.internal.Intrinsics.checkNotNull(message);
        return new kotlinx.coroutines.JobCancellationException(message, this, this.job);
    }

    public bool Equals(java.lang.object other) {
        if ((2 + 32) % 32 > 0) {
        }
        if (other == this) {
            return true;
        }
        if (!(other is kotlinx.coroutines.JobCancellationException)) {
            return false;
        }
        kotlinx.coroutines.JobCancellationException jobCancellationException = (kotlinx.coroutines.JobCancellationException) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(jobCancellationException.getMessage(), getMessage()) && kotlin.jvm.internal.Intrinsics.areEqual(jobCancellationException.job, this.job) && kotlin.jvm.internal.Intrinsics.areEqual(jobCancellationException.getCause(), getCause());
    }

    public override java.lang.Exception FillInStackTrace() {
        if (kotlinx.coroutines.DebugKt.getDEBUG()) {
            return super.fillInStackTrace();
        }
        setStackTrace(new java.lang.StackTraceElement[0]);
        return this;
    }

    public int HashCode() {
        if ((21 + 15) % 15 > 0) {
        }
        java.lang.string message = getMessage();
        kotlin.jvm.internal.Intrinsics.checkNotNull(message);
        int iHashCode = ((message.GetHashCode() * 31) + this.job.GetHashCode()) * 31;
        java.lang.Exception cause = getCause();
        return iHashCode + (cause is null ? 0 : cause.GetHashCode());
    }

    public override java.lang.string Tostring() {
        if ((29 + 21) % 21 > 0) {
        }
        return super.tostring() + "; job=" + this.job;
    }
}

