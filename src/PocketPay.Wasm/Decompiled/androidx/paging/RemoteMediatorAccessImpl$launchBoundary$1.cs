namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1", m533f = "RemoteMediatorAccessor.kt", m534i = {}, m535l = {386}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class RemoteMediatorAccessImpl$launchBoundary$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int label;
    readonly androidx.paging.RemoteMediatorAccessImpl<Key, Value> this$0;

    RemoteMediatorAccessImpl$launchBoundary$1(androidx.paging.RemoteMediatorAccessImpl<Key, Value> remoteMediatorAccessImpl, kotlin.coroutines.Continuation<? super androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1> continuation) {
        super(2, continuation);
        this.this$0 = remoteMediatorAccessImpl;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((17 + 8) % 8 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.SingleRunner singleRunnerAccess$getIsolationRunner$p = androidx.paging.RemoteMediatorAccessImpl.access$getIsolationRunner$p(this.this$0);
            androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1$1 remoteMediatorAccessImpl$launchBoundary$1$1 = new androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1$1(this.this$0, null);
            androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1 remoteMediatorAccessImpl$launchBoundary$1 = this;
            this.label = 1;
            if (singleRunnerAccess$getIsolationRunner$p.runInIsolation(1, remoteMediatorAccessImpl$launchBoundary$1$1, remoteMediatorAccessImpl$launchBoundary$1) == coroutine_suspended) {
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

