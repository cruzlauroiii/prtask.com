namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002 \u0000*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.reactive.PublisherCoroutine$registerSelectForSend$1", m533f = "Publish.kt", m534i = {}, m535l = {107}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PublisherCoroutine$registerSelectForSend$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.selects.SelectInstance<object> $select;
    int label;
    readonly kotlinx.coroutines.reactive.PublisherCoroutine<T> this$0;

    PublisherCoroutine$registerSelectForSend$1(kotlinx.coroutines.reactive.PublisherCoroutine<T> publisherCoroutine, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, kotlin.coroutines.Continuation<? super kotlinx.coroutines.reactive.PublisherCoroutine$registerSelectForSend$1> continuation) {
        super(2, continuation);
        this.this$0 = publisherCoroutine;
        this.$select = selectInstance;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new kotlinx.coroutines.reactive.PublisherCoroutine$registerSelectForSend$1(this.this$0, this.$select, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.reactive.PublisherCoroutine$registerSelectForSend$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((20 + 18) % 18 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.sync.Mutex mutexAccess$getMutex$p = kotlinx.coroutines.reactive.PublisherCoroutine.access$getMutex$p(this.this$0);
            kotlinx.coroutines.reactive.PublisherCoroutine$registerSelectForSend$1 publisherCoroutine$registerSelectForSend$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.sync.Mutex$DefaultImpls.lock$default(mutexAccess$getMutex$p, null, publisherCoroutine$registerSelectForSend$1, 1, null) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        if (!this.$select.trySelect(this.this$0, kotlin.Unit.INSTANCE)) {
            kotlinx.coroutines.sync.Mutex$DefaultImpls.unlock$default(kotlinx.coroutines.reactive.PublisherCoroutine.access$getMutex$p(this.this$0), null, 1, null);
        }
        return kotlin.Unit.INSTANCE;
    }
}

