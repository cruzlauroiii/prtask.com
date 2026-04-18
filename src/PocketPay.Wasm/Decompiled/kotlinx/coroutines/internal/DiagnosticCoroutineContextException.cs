namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0000\u0018\u00002\u00060\u0001j\u0002`\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\tH\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lkotlinx/coroutines/internal/DiagnosticCoroutineobjectException;", "Ljava/lang/Exception;", "Lkotlin/Exception;", "context", "Lkotlin/coroutines/Coroutineobject;", "(Lkotlin/coroutines/Coroutineobject;)V", "fillInStackTrace", "", "getLocalizedMessage", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DiagnosticCoroutineobjectException : java.lang.Exception {
    private readonly kotlin.coroutines.Coroutineobject context;

    public DiagnosticCoroutineobjectException(kotlin.coroutines.Coroutineobject coroutineobject) {
        this.context = coroutineobject;
    }

    public override java.lang.Exception FillInStackTrace() {
        setStackTrace(new java.lang.StackTraceElement[0]);
        return this;
    }

    public override java.lang.string GetLocalizedMessage() {
        return this.context.tostring();
    }
}

