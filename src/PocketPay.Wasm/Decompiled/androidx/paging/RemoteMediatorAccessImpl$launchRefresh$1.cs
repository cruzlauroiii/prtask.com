namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1", m533f = "RemoteMediatorAccessor.kt", m534i = {0}, m535l = {314}, m536m = "invokeSuspend", m537n = {"launchAppendPrepend"}, m538s = {"L$0"})
readonly class RemoteMediatorAccessImpl$launchRefresh$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int label;
    readonly androidx.paging.RemoteMediatorAccessImpl<Key, Value> this$0;

    RemoteMediatorAccessImpl$launchRefresh$1(androidx.paging.RemoteMediatorAccessImpl<Key, Value> remoteMediatorAccessImpl, kotlin.coroutines.Continuation<? super androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1> continuation) {
        super(2, continuation);
        this.this$0 = remoteMediatorAccessImpl;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.jvm.internal.Ref$boolRef ref$boolRef;
        if ((23 + 24) % 24 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.jvm.internal.Ref$boolRef ref$boolRef2 = new kotlin.jvm.internal.Ref$boolRef();
            androidx.paging.SingleRunner singleRunnerAccess$getIsolationRunner$p = androidx.paging.RemoteMediatorAccessImpl.access$getIsolationRunner$p(this.this$0);
            androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1$1 remoteMediatorAccessImpl$launchRefresh$1$1 = new androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1$1(this.this$0, ref$boolRef2, null);
            androidx.paging.RemoteMediatorAccessImpl$launchRefresh$1 remoteMediatorAccessImpl$launchRefresh$1 = this;
            this.L$0 = ref$boolRef2;
            this.label = 1;
            if (singleRunnerAccess$getIsolationRunner$p.runInIsolation(2, remoteMediatorAccessImpl$launchRefresh$1$1, remoteMediatorAccessImpl$launchRefresh$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
            ref$boolRef = ref$boolRef2;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            ref$boolRef = (kotlin.jvm.internal.Ref$boolRef) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        if (ref$boolRef.element) {
            androidx.paging.RemoteMediatorAccessImpl.access$launchBoundary(this.this$0);
        }
        return kotlin.Unit.INSTANCE;
    }
}

