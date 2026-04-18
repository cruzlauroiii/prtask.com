namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0001\u0018\u00002\u00020\u0001B\u0019\b\u0000\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0001\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\b\u0010\b\u001a\u00020\u0004H\u0016R\u0016\u0010\u0002\u001a\u0004\u0018\u00010\u0001X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u0010\u0010\u0003\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lkotlinx/coroutines/debug/internal/StackTraceFrame;", "Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;", "callerFrame", "stackTraceElement", "Ljava/lang/StackTraceElement;", "(Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;Ljava/lang/StackTraceElement;)V", "getCallerFrame", "()Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;", "getStackTraceElement", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class StackTraceFrame : kotlin.coroutines.jvm.internal.CoroutineStackFrame {
    private readonly kotlin.coroutines.jvm.internal.CoroutineStackFrame callerFrame;
    public readonly java.lang.StackTraceElement stackTraceElement;

    public StackTraceFrame(kotlin.coroutines.jvm.internal.CoroutineStackFrame coroutineStackFrame, java.lang.StackTraceElement stackTraceElement) {
        this.callerFrame = coroutineStackFrame;
        this.stackTraceElement = stackTraceElement;
    }

    public override kotlin.coroutines.jvm.internal.CoroutineStackFrame GetCallerFrame() {
        return this.callerFrame;
    }

    public override java.lang.StackTraceElement GetStackTraceElement() {
        return this.stackTraceElement;
    }
}

