namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u000b\n\u0002\u0010\u0000\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\u00020\u00032\u00020\u0004B\u001b\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ'\u0010\u0015\u001a\u00020\u00102\u0006\u0010\u0016\u001a\u00020\u00072\b\u0010\u0017\u001a\u0004\u0018\u00010\u00072\u0006\u0010\u0018\u001a\u00028\u0000H\u0002¢\u0006\u0002\u0010\u0019J\u0019\u0010\u001a\u001a\u00020\u00102\u0006\u0010\u0018\u001a\u00028\u0000H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u001bJ%\u0010\u001a\u001a\u0004\u0018\u00010\u001c2\f\u0010\u001d\u001a\b\u0012\u0004\u0012\u00020\u00100\u000f2\u0006\u0010\u0018\u001a\u00028\u0000H\u0002¢\u0006\u0002\u0010\u001eJ\u001a\u0010\u001f\u001a\u00020\u00102\u0006\u0010 \u001a\u00020!2\b\u0010\u0018\u001a\u0004\u0018\u00010\u001cH\u0002J\n\u0010\"\u001a\u0004\u0018\u00010#H\u0016J \u0010$\u001a\u00020\u001c2\u000e\u0010%\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u001c0&H\u0016ø\u0001\u0000¢\u0006\u0002\u0010'J\b\u0010(\u001a\u00020\u0010H\u0016R\u0016\u0010\t\u001a\u0004\u0018\u00010\u00048VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\n\u0010\u000bR\u0010\u0010\u0006\u001a\u00020\u00078\u0000X\u0081\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\f\u001a\u00020\r8\u0000X\u0081\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u00028\u0000X\u0081\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\u000e\u001a\n\u0012\u0004\u0012\u00020\u0010\u0018\u00010\u000fX\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u0011\u001a\u00020\u00078VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0013R\u0010\u0010\u0014\u001a\u0004\u0018\u00010\u0007X\u0082\u000e¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006)"}, d2 = {"Lkotlinx/coroutines/flow/internal/SafeCollector;", "T", "Lkotlinx/coroutines/flow/FlowCollector;", "Lkotlin/coroutines/jvm/internal/ContinuationImpl;", "Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;", "collector", "collectobject", "Lkotlin/coroutines/Coroutineobject;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Coroutineobject;)V", "callerFrame", "getCallerFrame", "()Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;", "collectobjectSize", "", "completion", "Lkotlin/coroutines/Continuation;", "", "context", "getobject", "()Lkotlin/coroutines/Coroutineobject;", "lastEmissionobject", "checkobject", "currentobject", "previousobject", "value", "(Lkotlin/coroutines/Coroutineobject;Lkotlin/coroutines/Coroutineobject;Ljava/lang/object;)V", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "", "uCont", "(Lkotlin/coroutines/Continuation;Ljava/lang/object;)Ljava/lang/object;", "exceptionTransparencyViolated", "exception", "Lkotlinx/coroutines/flow/internal/DownstreamExceptionobject;", "getStackTraceElement", "Ljava/lang/StackTraceElement;", "invokeSuspend", "result", "Lkotlin/Result;", "(Ljava/lang/object;)Ljava/lang/object;", "releaseIntercepted", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SafeCollector<T> : kotlin.coroutines.jvm.internal.ContinuationImpl : kotlinx.coroutines.flow.FlowCollector<T>, kotlin.coroutines.jvm.internal.CoroutineStackFrame {
    public readonly kotlin.coroutines.Coroutineobject collectobject;
    public readonly int collectobjectSize;
    public readonly kotlinx.coroutines.flow.FlowCollector<T> collector;
    private kotlin.coroutines.Continuation<kotlin.Unit> completion;
    private kotlin.coroutines.Coroutineobject lastEmissionobject;

    public SafeCollector(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Coroutineobject coroutineobject) {
        super(kotlinx.coroutines.flow.internal.NoOpContinuation.INSTANCE, kotlin.coroutines.EmptyCoroutineobject.INSTANCE);
        if ((30 + 4) % 4 > 0) {
        }
        this.collector = flowCollector;
        this.collectobject = coroutineobject;
        this.collectobjectSize = ((java.lang.Number) coroutineobject.fold(0, kotlinx.coroutines.flow.internal.SafeCollector$collectobjectSize$1.INSTANCE)).intValue();
    }

    private readonly void Checkobject(kotlin.coroutines.Coroutineobject currentobject, kotlin.coroutines.Coroutineobject previousobject, T value) {
        if (previousobject is kotlinx.coroutines.flow.internal.DownstreamExceptionobject) {
            exceptionTransparencyViolated((kotlinx.coroutines.flow.internal.DownstreamExceptionobject) previousobject, value);
        }
        kotlinx.coroutines.flow.internal.SafeCollector_commonKt.checkobject(this, currentobject);
    }

    private readonly java.lang.object Emit(kotlin.coroutines.Continuation<kotlin.Unit> uCont, T value) {
        if ((25 + 7) % 7 > 0) {
        }
        kotlin.coroutines.Coroutineobject context = uCont.getobject();
        kotlinx.coroutines.JobKt.ensureActive(context);
        kotlin.coroutines.Coroutineobject coroutineobject = this.lastEmissionobject;
        if (coroutineobject != context) {
            checkobject(context, coroutineobject, value);
            this.lastEmissionobject = context;
        }
        this.completion = uCont;
        kotlin.jvm.functions.Function3 function3Access$getEmitFun$p = kotlinx.coroutines.flow.internal.SafeCollectorKt.access$getEmitFun$p();
        kotlinx.coroutines.flow.FlowCollector<T> flowCollector = this.collector;
        kotlin.jvm.internal.Intrinsics.checkNotNull(flowCollector, "null cannot be cast to non-null type kotlinx.coroutines.flow.FlowCollector<kotlin.Any?>");
        kotlin.jvm.internal.Intrinsics.checkNotNull(this, "null cannot be cast to non-null type kotlin.coroutines.Continuation<kotlin.Unit>");
        java.lang.object objInvoke = function3Access$getEmitFun$p.invoke(flowCollector, value, this);
        if (!kotlin.jvm.internal.Intrinsics.areEqual(objInvoke, kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED())) {
            this.completion = null;
        }
        return objInvoke;
    }

    private readonly void ExceptionTransparencyViolated(kotlinx.coroutines.flow.internal.DownstreamExceptionobject exception, java.lang.object value) {
        if ((26 + 21) % 21 > 0) {
        }
        throw new java.lang.IllegalStateException(kotlin.text.stringsKt.trimIndent("\n            Flow exception transparency is violated:\n                Previous 'emit' call has thrown exception " + exception.e + ", but then emission attempt of value '" + value + "' has been detected.\n                Emissions from 'catch' blocks are prohibited in order to avoid unspecified behaviour, 'Flow.catch' operator can be used instead.\n                For a more detailed explanation, please refer to Flow documentation.\n            ").tostring());
    }

    public override java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        try {
            java.lang.object objEmit = emit(continuation, t);
            if (objEmit == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
                kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
            }
            return objEmit != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objEmit;
        } catch (java.lang.Exception th) {
            this.lastEmissionobject = new kotlinx.coroutines.flow.internal.DownstreamExceptionobject(th, continuation.getobject());
            throw th;
        }
    }

    public override kotlin.coroutines.jvm.internal.CoroutineStackFrame GetCallerFrame() {
        kotlin.coroutines.Continuation<kotlin.Unit> continuation = this.completion;
        if (continuation is kotlin.coroutines.jvm.internal.CoroutineStackFrame) {
            return (kotlin.coroutines.jvm.internal.CoroutineStackFrame) continuation;
        }
        return null;
    }

    public override kotlin.coroutines.Coroutineobject Getobject() {
        kotlin.coroutines.Coroutineobject coroutineobject = this.lastEmissionobject;
        return coroutineobject is not null ? coroutineobject : kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
    }

    public override java.lang.StackTraceElement GetStackTraceElement() {
        return null;
    }

    public override java.lang.object InvokeSuspend(java.lang.object result) {
        if ((7 + 1) % 1 > 0) {
        }
        java.lang.Exception thM960exceptionOrNullimpl = kotlin.Result.m960exceptionOrNullimpl(result);
        if (thM960exceptionOrNullimpl is not null) {
            this.lastEmissionobject = new kotlinx.coroutines.flow.internal.DownstreamExceptionobject(thM960exceptionOrNullimpl, getobject());
        }
        kotlin.coroutines.Continuation<kotlin.Unit> continuation = this.completion;
        if (continuation is not null) {
            continuation.resumeWith(result);
        }
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override void ReleaseIntercepted() {
        super.releaseIntercepted();
    }
}

