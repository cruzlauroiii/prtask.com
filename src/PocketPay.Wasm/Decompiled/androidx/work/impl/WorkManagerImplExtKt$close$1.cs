namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.WorkManagerImplExtKt$close$1", m533f = "WorkManagerImplExt.kt", m534i = {}, m535l = {121}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class WorkManagerImplExtKt$close$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.work.impl.WorkManagerImpl $this_close;
    int label;

    WorkManagerImplExtKt$close$1(androidx.work.impl.WorkManagerImpl workManagerImpl, kotlin.coroutines.Continuation<? super androidx.work.impl.WorkManagerImplExtKt$close$1> continuation) {
        super(2, continuation);
        this.$this_close = workManagerImpl;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.work.impl.WorkManagerImplExtKt$close$1(this.$this_close, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.work.impl.WorkManagerImplExtKt$close$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((10 + 2) % 2 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.coroutines.Coroutineobject$Element coroutineobject$Element = this.$this_close.getWorkManagerScope().getCoroutineobject()[kotlinx.coroutines.Job.Key);
            kotlin.jvm.internal.Intrinsics.checkNotNull(coroutineobject$Element);
            kotlinx.coroutines.Job job = (kotlinx.coroutines.Job) coroutineobject$Element;
            androidx.work.impl.WorkManagerImplExtKt$close$1 workManagerImplExtKt$close$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.JobKt.cancelAndJoin(job, workManagerImplExtKt$close$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

