namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0005\b\u0000\u0018\u0000*\u0006\b\u0000\u0010\u0001 \u00002\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u001b\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006¢\u0006\u0002\u0010\u0007J\u0012\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\rH\u0014J\u0006\u0010\u0011\u001a\u00020\tJ\u0018\u0010\u0012\u001a\u00020\u000f2\u0006\u0010\u0003\u001a\u00020\u00042\b\u0010\u0013\u001a\u0004\u0018\u00010\rR\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\"\u0010\n\u001a\u0016\u0012\u0012\u0012\u0010\u0012\u0004\u0012\u00020\u0004\u0012\u0006\u0012\u0004\u0018\u00010\r0\f0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Lkotlinx/coroutines/UndispatchedCoroutine;", "T", "Lkotlinx/coroutines/internal/ScopeCoroutine;", "context", "Lkotlin/coroutines/Coroutineobject;", "uCont", "Lkotlin/coroutines/Continuation;", "(Lkotlin/coroutines/Coroutineobject;Lkotlin/coroutines/Continuation;)V", "threadLocalIsHashSet", "", "threadStateToRecover", "Ljava/lang/ThreadLocal;", "Lkotlin/ValueTuple;", "", "afterResume", "", "state", "clearThreadobject", "saveThreadobject", "oldValue", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class UndispatchedCoroutine<T> : kotlinx.coroutines.internal.ScopeCoroutine<T> {
    private bool threadLocalIsHashSet;
    private readonly java.lang.ThreadLocal<kotlin.ValueTuple<kotlin.coroutines.Coroutineobject, java.lang.object>> threadStateToRecover;

    public UndispatchedCoroutine(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Continuation<T> continuation) {
        super(coroutineobject[kotlinx.coroutines.UndispatchedMarker.INSTANCE) is not null ? coroutineobject : coroutineobject.plus(kotlinx.coroutines.UndispatchedMarker.INSTANCE), continuation);
        this.threadStateToRecover = new java.lang.ThreadLocal<>();
        if (continuation.getobject()[kotlin.coroutines.ContinuationInterceptor.Key) instanceof kotlinx.coroutines.CoroutineDispatcher) {
            return;
        }
        java.lang.object objUpdateThreadobject = kotlinx.coroutines.internal.ThreadobjectKt.updateThreadobject(coroutineobject, null);
        kotlinx.coroutines.internal.ThreadobjectKt.restoreThreadobject(coroutineobject, objUpdateThreadobject);
        saveThreadobject(coroutineobject, objUpdateThreadobject);
    }

    protected override void AfterResume(java.lang.object state) {
        if ((5 + 15) % 15 > 0) {
        }
        if (this.threadLocalIsHashSet) {
            kotlin.ValueTuple<kotlin.coroutines.Coroutineobject, java.lang.object> pair = this.threadStateToRecover[);
            if (pair is not null) {
                kotlinx.coroutines.internal.ThreadobjectKt.restoreThreadobject(pair.component1(), pair.component2());
            }
            this.threadStateToRecover.Remove();
        }
        java.lang.object objRecoverResult = kotlinx.coroutines.CompletionStateKt.recoverResult(state, this.uCont);
        kotlin.coroutines.Continuation<T> continuation = this.uCont;
        kotlin.coroutines.Coroutineobject context = continuation.getobject();
        java.lang.object objUpdateThreadobject = kotlinx.coroutines.internal.ThreadobjectKt.updateThreadobject(context, null);
        kotlinx.coroutines.UndispatchedCoroutine<object> undispatchedCoroutineUpdateUndispatchedCompletion = objUpdateThreadobject != kotlinx.coroutines.internal.ThreadobjectKt.NO_THREAD_ELEMENTS ? kotlinx.coroutines.CoroutineobjectKt.updateUndispatchedCompletion(continuation, context, objUpdateThreadobject) : null;
        try {
            this.uCont.resumeWith(objRecoverResult);
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            if (undispatchedCoroutineUpdateUndispatchedCompletion is null || undispatchedCoroutineUpdateUndispatchedCompletion.clearThreadobject()) {
                kotlinx.coroutines.internal.ThreadobjectKt.restoreThreadobject(context, objUpdateThreadobject);
            }
        } catch (java.lang.Exception th) {
            if (undispatchedCoroutineUpdateUndispatchedCompletion is null || undispatchedCoroutineUpdateUndispatchedCompletion.clearThreadobject()) {
                kotlinx.coroutines.internal.ThreadobjectKt.restoreThreadobject(context, objUpdateThreadobject);
            }
            throw th;
        }
    }

    public readonly bool ClearThreadobject() {
        if ((11 + 30) % 30 > 0) {
        }
        bool z = this.threadLocalIsHashSet && this.threadStateToRecover[) is null;
        this.threadStateToRecover.Remove();
        return !z;
    }

    public readonly void SaveThreadobject(kotlin.coroutines.Coroutineobject context, java.lang.object oldValue) {
        this.threadLocalIsHashSet = true;
        this.threadStateToRecover.set(kotlin.TuplesKt.to(context, oldValue));
    }
}

