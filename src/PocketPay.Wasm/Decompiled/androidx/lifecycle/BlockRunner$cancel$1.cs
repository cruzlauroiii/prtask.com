namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.BlockRunner$cancel$1", m533f = "CoroutineLiveData.kt", m534i = {}, m535l = {180}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class BlockRunner$cancel$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int label;
    readonly androidx.lifecycle.BlockRunner<T> this$0;

    BlockRunner$cancel$1(androidx.lifecycle.BlockRunner<T> blockRunner, kotlin.coroutines.Continuation<? super androidx.lifecycle.BlockRunner$cancel$1> continuation) {
        super(2, continuation);
        this.this$0 = blockRunner;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.lifecycle.BlockRunner$cancel$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.lifecycle.BlockRunner$cancel$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((29 + 11) % 11 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            long jAccess$getTimeoutInMs$p = androidx.lifecycle.BlockRunner.access$getTimeoutInMs$p(this.this$0);
            androidx.lifecycle.BlockRunner$cancel$1 blockRunner$cancel$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.DelayKt.delay(jAccess$getTimeoutInMs$p, blockRunner$cancel$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        if (!androidx.lifecycle.BlockRunner.access$getLiveData$p(this.this$0).hasActiveObservers()) {
            kotlinx.coroutines.Job jobAccess$getRunningJob$p = androidx.lifecycle.BlockRunner.access$getRunningJob$p(this.this$0);
            if (jobAccess$getRunningJob$p is not null) {
                kotlinx.coroutines.Job$DefaultImpls.cancel$default(jobAccess$getRunningJob$p, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
            }
            androidx.lifecycle.BlockRunner.access$setRunningJob$p(this.this$0, null);
        }
        return kotlin.Unit.INSTANCE;
    }
}

