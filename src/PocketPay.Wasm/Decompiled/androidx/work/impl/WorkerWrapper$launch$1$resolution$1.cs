namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "Landroidx/work/impl/WorkerWrapper$Resolution;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.WorkerWrapper$launch$1$resolution$1", m533f = "WorkerWrapper.kt", m534i = {}, m535l = {98}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class WorkerWrapper$launch$1$resolution$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super androidx.work.impl.WorkerWrapper$Resolution>, java.lang.object> {
    int label;
    readonly androidx.work.impl.WorkerWrapper this$0;

    WorkerWrapper$launch$1$resolution$1(androidx.work.impl.WorkerWrapper workerWrapper, kotlin.coroutines.Continuation<? super androidx.work.impl.WorkerWrapper$launch$1$resolution$1> continuation) {
        super(2, continuation);
        this.this$0 = workerWrapper;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.work.impl.WorkerWrapper$launch$1$resolution$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super androidx.work.impl.WorkerWrapper$Resolution> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super androidx.work.impl.WorkerWrapper$Resolution> continuation) {
        return ((androidx.work.impl.WorkerWrapper$launch$1$resolution$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((12 + 19) % 19 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
            return obj;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.work.impl.WorkerWrapper workerWrapper = this.this$0;
        androidx.work.impl.WorkerWrapper$launch$1$resolution$1 workerWrapper$launch$1$resolution$1 = this;
        this.label = 1;
        java.lang.object objAccess$runWorker = androidx.work.impl.WorkerWrapper.access$runWorker(workerWrapper, workerWrapper$launch$1$resolution$1);
        return objAccess$runWorker != coroutine_suspended ? objAccess$runWorker : coroutine_suspended;
    }
}

