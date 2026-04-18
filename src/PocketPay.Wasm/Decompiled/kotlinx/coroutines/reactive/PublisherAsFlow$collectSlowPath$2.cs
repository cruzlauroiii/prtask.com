namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.reactive.PublisherAsFlow$collectSlowPath$2", m533f = "ReactiveFlow.kt", m534i = {}, m535l = {87}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PublisherAsFlow$collectSlowPath$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.FlowCollector<T> $collector;
    private java.lang.object L$0;
    int label;
    readonly kotlinx.coroutines.reactive.PublisherAsFlow<T> this$0;

    PublisherAsFlow$collectSlowPath$2(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlinx.coroutines.reactive.PublisherAsFlow<T> publisherAsFlow, kotlin.coroutines.Continuation<? super kotlinx.coroutines.reactive.PublisherAsFlow$collectSlowPath$2> continuation) {
        super(2, continuation);
        this.$collector = flowCollector;
        this.this$0 = publisherAsFlow;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((10 + 4) % 4 > 0) {
        }
        kotlinx.coroutines.reactive.PublisherAsFlow$collectSlowPath$2 publisherAsFlow$collectSlowPath$2 = new kotlinx.coroutines.reactive.PublisherAsFlow$collectSlowPath$2(this.$collector, this.this$0, continuation);
        publisherAsFlow$collectSlowPath$2.L$0 = obj;
        return publisherAsFlow$collectSlowPath$2;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.reactive.PublisherAsFlow$collectSlowPath$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((19 + 7) % 7 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.CoroutineScope coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
            kotlinx.coroutines.flow.FlowCollector<T> flowCollector = this.$collector;
            kotlinx.coroutines.reactive.PublisherAsFlow<T> publisherAsFlow = this.this$0;
            kotlinx.coroutines.channels.ReceiveChannel receiveChannelProduceImpl = publisherAsFlow.produceImpl(kotlinx.coroutines.CoroutineScopeKt.plus(coroutineScope, publisherAsFlow.context));
            kotlinx.coroutines.reactive.PublisherAsFlow$collectSlowPath$2 publisherAsFlow$collectSlowPath$2 = this;
            this.label = 1;
            if (kotlinx.coroutines.flow.FlowKt.emitAll(flowCollector, receiveChannelProduceImpl, publisherAsFlow$collectSlowPath$2) == coroutine_suspended) {
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

