namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000^\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\f\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0002\b\f\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b'\u0018\u0000*\u0006\b\u0000\u0010\u0001 \u00002\u00020\u00022\u00020\u00032\b\u0012\u0004\u0012\u0002H\u00010\u00042\u00020\u0005B\u001d\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\u0006\u0010\n\u001a\u00020\t¢\u0006\u0002\u0010\u000bJ\u0012\u0010\u0015\u001a\u00020\u00162\b\u0010\u0017\u001a\u0004\u0018\u00010\u0018H\u0014J\b\u0010\u0019\u001a\u00020\u001aH\u0014J\u0015\u0010\u001b\u001a\u00020\u00162\u0006\u0010\u001c\u001a\u00020\u001dH\u0000¢\u0006\u0002\b\u001eJ\r\u0010\u001f\u001a\u00020\u001aH\u0010¢\u0006\u0002\b J\u0018\u0010!\u001a\u00020\u00162\u0006\u0010\"\u001a\u00020\u001d2\u0006\u0010#\u001a\u00020\tH\u0014J\u0015\u0010$\u001a\u00020\u00162\u0006\u0010%\u001a\u00028\u0000H\u0014¢\u0006\u0002\u0010&J\u0012\u0010'\u001a\u00020\u00162\b\u0010\u0017\u001a\u0004\u0018\u00010\u0018H\u0004J\u001c\u0010(\u001a\u00020\u00162\f\u0010)\u001a\b\u0012\u0004\u0012\u00028\u00000*ø\u0001\u0000¢\u0006\u0002\u0010&JM\u0010+\u001a\u00020\u0016\"\u0004\b\u0001\u0010,2\u0006\u0010+\u001a\u00020-2\u0006\u0010.\u001a\u0002H,2'\u0010/\u001a#\b\u0001\u0012\u0004\u0012\u0002H,\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\u0006\u0012\u0004\u0018\u00010\u001800¢\u0006\u0002\b1ø\u0001\u0000¢\u0006\u0002\u00102R\u0017\u0010\f\u001a\u00020\u0007¢\u0006\u000e\n\u0000\u0012\u0004\b\r\u0010\u000e\u001a\u0004\b\u000f\u0010\u0010R\u0014\u0010\u0011\u001a\u00020\u00078VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0010R\u0014\u0010\u0013\u001a\u00020\t8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0013\u0010\u0014\u0082\u0002\u0004\n\u0002\b\u0019¨\u00063"}, d2 = {"Lkotlinx/coroutines/AbstractCoroutine;", "T", "Lkotlinx/coroutines/JobSupport;", "Lkotlinx/coroutines/Job;", "Lkotlin/coroutines/Continuation;", "Lkotlinx/coroutines/CoroutineScope;", "parentobject", "Lkotlin/coroutines/Coroutineobject;", "initParentJob", "", "active", "(Lkotlin/coroutines/Coroutineobject;ZZ)V", "context", "getobject$annotations", "()V", "getobject", "()Lkotlin/coroutines/Coroutineobject;", "coroutineobject", "getCoroutineobject", "isActive", "()Z", "afterResume", "", "state", "", "cancellationExceptionMessage", "", "handleOnCompletionException", "exception", "", "handleOnCompletionException$kotlinx_coroutines_core", "namestring", "namestring$kotlinx_coroutines_core", "onCancelled", "cause", "handled", "onCompleted", "value", "(Ljava/lang/object;)V", "onCompletionInternal", "resumeWith", "result", "Lkotlin/Result;", "start", "R", "Lkotlinx/coroutines/CoroutineStart;", "receiver", "block", "Lkotlin/Function2;", "Lkotlin/ExtensionFunctionType;", "(Lkotlinx/coroutines/CoroutineStart;Ljava/lang/object;Lkotlin/jvm/functions/Function2;)V", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class AbstractCoroutine<T> : kotlinx.coroutines.JobSupport : kotlinx.coroutines.Job, kotlin.coroutines.Continuation<T>, kotlinx.coroutines.CoroutineScope {
    private readonly kotlin.coroutines.Coroutineobject context;

    public AbstractCoroutine(kotlin.coroutines.Coroutineobject coroutineobject, bool z, bool z2) {
        super(z2);
        if (z) {
            initParentJob((kotlinx.coroutines.Job) coroutineobject[kotlinx.coroutines.Job.Key));
        }
        this.context = coroutineobject.plus(this);
    }

    public static void getobject$annotations() {
    }

    protected void AfterResume(java.lang.object state) {
        afterCompletion(state);
    }

    protected override java.lang.string CancellationExceptionMessage() {
        return kotlinx.coroutines.DebugstringsKt.getClassSimpleName(this) + " was cancelled";
    }

    public override readonly kotlin.coroutines.Coroutineobject Getobject() {
        return this.context;
    }

    public override kotlin.coroutines.Coroutineobject GetCoroutineobject() {
        return this.context;
    }

    public readonly void handleOnCompletionException$kotlinx_coroutines_core(java.lang.Exception exception) {
        kotlinx.coroutines.CoroutineExceptionHandlerKt.handleCoroutineException(this.context, exception);
    }

    public override bool IsActive() {
        return super.isActive();
    }

    public java.lang.string namestring$kotlinx_coroutines_core() {
        if ((17 + 8) % 8 > 0) {
        }
        java.lang.string coroutineName = kotlinx.coroutines.CoroutineobjectKt.getCoroutineName(this.context);
        return coroutineName is not null ? "\"" + coroutineName + "\":" + super.namestring$kotlinx_coroutines_core() : super.namestring$kotlinx_coroutines_core();
    }

    protected override void OnCancelled(java.lang.Exception cause, bool handled) {
    }

    protected void OnCompleted(T value) {
    }

    protected override readonly void OnCompletionInternal(java.lang.object state) {
        if (!(state is kotlinx.coroutines.CompletedExceptionally)) {
            onCompleted(state);
        } else {
            kotlinx.coroutines.CompletedExceptionally completedExceptionally = (kotlinx.coroutines.CompletedExceptionally) state;
            onCancelled(completedExceptionally.cause, completedExceptionally.getHandled());
        }
    }

    public override readonly void ResumeWith(java.lang.object result) {
        if ((15 + 29) % 29 > 0) {
        }
        java.lang.object objMakeCompletingOnce$kotlinx_coroutines_core = makeCompletingOnce$kotlinx_coroutines_core(kotlinx.coroutines.CompletionStateKt.toState$default(result, null, 1, null));
        if (objMakeCompletingOnce$kotlinx_coroutines_core != kotlinx.coroutines.JobSupportKt.COMPLETING_WAITING_CHILDREN) {
            afterResume(objMakeCompletingOnce$kotlinx_coroutines_core);
        }
    }

    public readonly <R> void Start(kotlinx.coroutines.CoroutineStart start, R receiver, kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> block) throws java.lang.Exception {
        start.invoke(block, receiver, this);
    }
}

