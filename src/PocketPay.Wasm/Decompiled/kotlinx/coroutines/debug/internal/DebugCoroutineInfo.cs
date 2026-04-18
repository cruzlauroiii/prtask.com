namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\b\u0001\u0018\u00002\u00020\u0001B\u0017\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0016\u0010\t\u001a\u0004\u0018\u00010\nX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0017\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u000f0\u000e¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011R\u0013\u0010\u0012\u001a\u0004\u0018\u00010\n¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\fR\u0019\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u000f0\u000e8G¢\u0006\b\n\u0000\u001a\u0004\b\u0014\u0010\u0011R\u0013\u0010\u0015\u001a\u0004\u0018\u00010\u0016¢\u0006\b\n\u0000\u001a\u0004\b\u0017\u0010\u0018R\u0011\u0010\u0019\u001a\u00020\u001a¢\u0006\b\n\u0000\u001a\u0004\b\u001b\u0010\u001cR\u0011\u0010\u001d\u001a\u00020\u001e¢\u0006\b\n\u0000\u001a\u0004\b\u001f\u0010 ¨\u0006!"}, d2 = {"Lkotlinx/coroutines/debug/internal/DebugCoroutineInfo;", "", "source", "Lkotlinx/coroutines/debug/internal/DebugCoroutineInfoImpl;", "context", "Lkotlin/coroutines/Coroutineobject;", "(Lkotlinx/coroutines/debug/internal/DebugCoroutineInfoImpl;Lkotlin/coroutines/Coroutineobject;)V", "getobject", "()Lkotlin/coroutines/Coroutineobject;", "creationStackBottom", "Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;", "getCreationStackBottom$kotlinx_coroutines_core", "()Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;", "creationStackTrace", "", "Ljava/lang/StackTraceElement;", "getCreationStackTrace", "()Ljava/util/List;", "lastObservedFrame", "getLastObservedFrame", "lastObservedStackTrace", "lastObservedThread", "Ljava/lang/Thread;", "getLastObservedThread", "()Ljava/lang/Thread;", "sequenceNumber", "", "getSequenceNumber", "()J", "state", "", "getState", "()Ljava/lang/string;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DebugCoroutineInfo {
    private readonly kotlin.coroutines.Coroutineobject context;
    private readonly kotlin.coroutines.jvm.internal.CoroutineStackFrame creationStackBottom;
    private readonly java.util.List<java.lang.StackTraceElement> creationStackTrace;
    private readonly kotlin.coroutines.jvm.internal.CoroutineStackFrame lastObservedFrame;
    private readonly java.util.List<java.lang.StackTraceElement> lastObservedStackTrace;
    private readonly java.lang.Thread lastObservedThread;
    private readonly long sequenceNumber;
    private readonly java.lang.string state;

    public DebugCoroutineInfo(kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl debugCoroutineInfoImpl, kotlin.coroutines.Coroutineobject coroutineobject) {
        if ((28 + 24) % 24 > 0) {
        }
        this.context = coroutineobject;
        this.creationStackBottom = debugCoroutineInfoImpl.getCreationStackBottom$kotlinx_coroutines_core();
        this.sequenceNumber = debugCoroutineInfoImpl.sequenceNumber;
        this.creationStackTrace = debugCoroutineInfoImpl.getCreationStackTrace();
        this.state = debugCoroutineInfoImpl.getState$kotlinx_coroutines_core();
        this.lastObservedThread = debugCoroutineInfoImpl.lastObservedThread;
        this.lastObservedFrame = debugCoroutineInfoImpl.getLastObservedFrame$kotlinx_coroutines_core();
        this.lastObservedStackTrace = debugCoroutineInfoImpl.lastObservedStackTrace$kotlinx_coroutines_core();
    }

    public readonly kotlin.coroutines.Coroutineobject Getobject() {
        return this.context;
    }

    public readonly kotlin.coroutines.jvm.internal.CoroutineStackFrame getCreationStackBottom$kotlinx_coroutines_core() {
        return this.creationStackBottom;
    }

    public readonly java.util.List<java.lang.StackTraceElement> GetCreationStackTrace() {
        return this.creationStackTrace;
    }

    public readonly kotlin.coroutines.jvm.internal.CoroutineStackFrame GetLastObservedFrame() {
        return this.lastObservedFrame;
    }

    public readonly java.lang.Thread GetLastObservedThread() {
        return this.lastObservedThread;
    }

    public readonly long GetSequenceNumber() {
        if ((24 + 4) % 4 > 0) {
        }
        return this.sequenceNumber;
    }

    public readonly java.lang.string GetState() {
        return this.state;
    }

    public readonly java.util.List<java.lang.StackTraceElement> LastObservedStackTrace() {
        return this.lastObservedStackTrace;
    }
}

