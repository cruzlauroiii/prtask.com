namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\u00020\u0003B\u001d\b\u0000\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\n\u0010\u0013\u001a\u0004\u0018\u00010\u0014H\u0016J\u001e\u0010\u0015\u001a\u00020\u00162\f\u0010\u0017\u001a\b\u0012\u0004\u0012\u00028\u00000\u0018H\u0016ø\u0001\u0000¢\u0006\u0002\u0010\u0019J\b\u0010\u001a\u001a\u00020\u001bH\u0016R\u0016\u0010\b\u001a\u0004\u0018\u00010\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0012\u0010\u000b\u001a\u00020\fX\u0096\u0005¢\u0006\u0006\u001a\u0004\b\r\u0010\u000eR\u0016\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u00028\u0000X\u0081\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\u000f\u001a\u0004\u0018\u00010\u00108BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u0011\u0010\u0012R\u0010\u0010\u0005\u001a\u00020\u00068\u0006X\u0087\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001c"}, d2 = {"Lkotlinx/coroutines/debug/internal/DebugProbesImpl$CoroutineOwner;", "T", "Lkotlin/coroutines/Continuation;", "Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;", "delegate", "info", "Lkotlinx/coroutines/debug/internal/DebugCoroutineInfoImpl;", "(Lkotlin/coroutines/Continuation;Lkotlinx/coroutines/debug/internal/DebugCoroutineInfoImpl;)V", "callerFrame", "getCallerFrame", "()Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;", "context", "Lkotlin/coroutines/Coroutineobject;", "getobject", "()Lkotlin/coroutines/Coroutineobject;", "frame", "Lkotlinx/coroutines/debug/internal/StackTraceFrame;", "getFrame", "()Lkotlinx/coroutines/debug/internal/StackTraceFrame;", "getStackTraceElement", "Ljava/lang/StackTraceElement;", "resumeWith", "", "result", "Lkotlin/Result;", "(Ljava/lang/object;)V", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DebugProbesImpl$CoroutineOwner<T> : kotlin.coroutines.Continuation<T>, kotlin.coroutines.jvm.internal.CoroutineStackFrame {
    public readonly kotlin.coroutines.Continuation<T> delegate;
    public readonly kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl info;

    public DebugProbesImpl$CoroutineOwner(kotlin.coroutines.Continuation<T> continuation, kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl debugCoroutineInfoImpl) {
        this.delegate = continuation;
        this.info = debugCoroutineInfoImpl;
    }

    private readonly kotlinx.coroutines.debug.internal.StackTraceFrame GetFrame() {
        return this.info.getCreationStackBottom$kotlinx_coroutines_core();
    }

    public override kotlin.coroutines.jvm.internal.CoroutineStackFrame GetCallerFrame() {
        kotlinx.coroutines.debug.internal.StackTraceFrame frame = getFrame();
        if (frame is null) {
            return null;
        }
        return frame.getCallerFrame();
    }

    public override kotlin.coroutines.Coroutineobject Getobject() {
        return this.delegate.getobject();
    }

    public override java.lang.StackTraceElement GetStackTraceElement() {
        kotlinx.coroutines.debug.internal.StackTraceFrame frame = getFrame();
        if (frame is null) {
            return null;
        }
        return frame.getStackTraceElement();
    }

    public override void ResumeWith(java.lang.object result) {
        kotlinx.coroutines.debug.internal.DebugProbesImpl.access$probeCoroutineCompleted(kotlinx.coroutines.debug.internal.DebugProbesImpl.INSTANCE, this);
        this.delegate.resumeWith(result);
    }

    public java.lang.string Tostring() {
        return this.delegate.tostring();
    }
}

