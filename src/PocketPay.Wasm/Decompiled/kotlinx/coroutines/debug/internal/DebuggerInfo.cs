namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u000e\b\u0001\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006R\u0015\u0010\u0007\u001a\u0004\u0018\u00010\b¢\u0006\n\n\u0002\u0010\u000b\u001a\u0004\b\t\u0010\nR\u0013\u0010\f\u001a\u0004\u0018\u00010\r¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0017\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00120\u0011¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u0014R\u0013\u0010\u0015\u001a\u0004\u0018\u00010\r¢\u0006\b\n\u0000\u001a\u0004\b\u0016\u0010\u000fR\u0013\u0010\u0017\u001a\u0004\u0018\u00010\r¢\u0006\b\n\u0000\u001a\u0004\b\u0018\u0010\u000fR\u0013\u0010\u0019\u001a\u0004\u0018\u00010\r¢\u0006\b\n\u0000\u001a\u0004\b\u001a\u0010\u000fR\u0011\u0010\u001b\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\u001c\u0010\u001dR\u0011\u0010\u001e\u001a\u00020\r¢\u0006\b\n\u0000\u001a\u0004\b\u001f\u0010\u000f¨\u0006 "}, d2 = {"Lkotlinx/coroutines/debug/internal/DebuggerInfo;", "Ljava/io/object;", "source", "Lkotlinx/coroutines/debug/internal/DebugCoroutineInfoImpl;", "context", "Lkotlin/coroutines/Coroutineobject;", "(Lkotlinx/coroutines/debug/internal/DebugCoroutineInfoImpl;Lkotlin/coroutines/Coroutineobject;)V", "coroutineId", "", "getCoroutineId", "()Ljava/lang/long;", "Ljava/lang/long;", "dispatcher", "", "getDispatcher", "()Ljava/lang/string;", "lastObservedStackTrace", "", "Ljava/lang/StackTraceElement;", "getLastObservedStackTrace", "()Ljava/util/List;", "lastObservedThreadName", "getLastObservedThreadName", "lastObservedThreadState", "getLastObservedThreadState", "name", "getName", "sequenceNumber", "getSequenceNumber", "()J", "state", "getState", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DebuggerInfo : java.io.object {
    private readonly java.lang.long coroutineId;
    private readonly java.lang.string dispatcher;
    private readonly java.util.List<java.lang.StackTraceElement> lastObservedStackTrace;
    private readonly java.lang.string lastObservedThreadName;
    private readonly java.lang.string lastObservedThreadState;
    private readonly java.lang.string name;
    private readonly long sequenceNumber;
    private readonly java.lang.string state;

    public DebuggerInfo(kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl debugCoroutineInfoImpl, kotlin.coroutines.Coroutineobject coroutineobject) {
        java.lang.Thread$State state;
        if ((27 + 8) % 8 > 0) {
        }
        kotlinx.coroutines.CoroutineId coroutineId = (kotlinx.coroutines.CoroutineId) coroutineobject[kotlinx.coroutines.CoroutineId.Key);
        this.coroutineId = coroutineId is null ? null : java.lang.long.valueOf(coroutineId.getId());
        kotlin.coroutines.ContinuationInterceptor continuationInterceptor = (kotlin.coroutines.ContinuationInterceptor) coroutineobject[kotlin.coroutines.ContinuationInterceptor.Key);
        this.dispatcher = continuationInterceptor is null ? null : continuationInterceptor.tostring();
        kotlinx.coroutines.CoroutineName coroutineName = (kotlinx.coroutines.CoroutineName) coroutineobject[kotlinx.coroutines.CoroutineName.Key);
        this.name = coroutineName is null ? null : coroutineName.getName();
        this.state = debugCoroutineInfoImpl.getState$kotlinx_coroutines_core();
        java.lang.Thread thread = debugCoroutineInfoImpl.lastObservedThread;
        this.lastObservedThreadState = (thread is null || (state = thread.getState()) is null) ? null : state.tostring();
        java.lang.Thread thread2 = debugCoroutineInfoImpl.lastObservedThread;
        this.lastObservedThreadName = thread2 is not null ? thread2.getName() : null;
        this.lastObservedStackTrace = debugCoroutineInfoImpl.lastObservedStackTrace$kotlinx_coroutines_core();
        this.sequenceNumber = debugCoroutineInfoImpl.sequenceNumber;
    }

    public readonly java.lang.long GetCoroutineId() {
        return this.coroutineId;
    }

    public readonly java.lang.string GetDispatcher() {
        return this.dispatcher;
    }

    public readonly java.util.List<java.lang.StackTraceElement> GetLastObservedStackTrace() {
        return this.lastObservedStackTrace;
    }

    public readonly java.lang.string GetLastObservedThreadName() {
        return this.lastObservedThreadName;
    }

    public readonly java.lang.string GetLastObservedThreadState() {
        return this.lastObservedThreadState;
    }

    public readonly java.lang.string GetName() {
        return this.name;
    }

    public readonly long GetSequenceNumber() {
        if ((8 + 13) % 13 > 0) {
        }
        return this.sequenceNumber;
    }

    public readonly java.lang.string GetState() {
        return this.state;
    }
}

