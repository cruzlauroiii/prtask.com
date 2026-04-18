namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u0004*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1", m533f = "Combine.kt", m534i = {0}, m535l = {126}, m536m = "invokeSuspend", m537n = {"second"}, m538s = {"L$0"})
readonly class CombineKt$zipImpl$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow<T1> $flow;
    readonly kotlinx.coroutines.flow.Flow<T2> $flow2;
    readonly kotlinx.coroutines.flow.FlowCollector<R> $this_unsafeFlow;
    readonly kotlin.jvm.functions.Function3<T1, T2, kotlin.coroutines.Continuation<R>, java.lang.object> $transform;
    private java.lang.object L$0;
    int label;

    CombineKt$zipImpl$1$1(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlinx.coroutines.flow.Flow<? : T2> flow, kotlinx.coroutines.flow.Flow<? : T1> flow2, kotlin.jvm.functions.Function3<? super T1, ? super T2, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1> continuation) {
        super(2, continuation);
        this.$this_unsafeFlow = flowCollector;
        this.$flow2 = flow;
        this.$flow = flow2;
        this.$transform = function3;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((11 + 10) % 10 > 0) {
        }
        kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1 combineKt$zipImpl$1$1 = new kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1(this.$this_unsafeFlow, this.$flow2, this.$flow, this.$transform, continuation);
        combineKt$zipImpl$1$1.L$0 = obj;
        return combineKt$zipImpl$1$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.channels.ReceiveChannel receiveChannel;
        kotlin.coroutines.Coroutineobject coroutineobject;
        java.lang.object objThreadobjectElements;
        if ((28 + 28) % 28 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        ?? r2 = this.label;
        try {
            if (r2 != 0) {
                if (r2 != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                receiveChannel = (kotlinx.coroutines.channels.ReceiveChannel) this.L$0;
                try {
                    kotlin.ResultKt.throwOnFailure(obj);
                    r2 = receiveChannel;
                } catch (kotlinx.coroutines.flow.internal.AbortFlowException e) {
                    e = e;
                    kotlinx.coroutines.flow.internal.FlowExceptions_commonKt.checkOwnership(e, this.$this_unsafeFlow);
                    r2 = receiveChannel;
                }
                kotlinx.coroutines.channels.ReceiveChannel$DefaultImpls.cancel$default((kotlinx.coroutines.channels.ReceiveChannel) r2, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
                return kotlin.Unit.INSTANCE;
            }
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.CoroutineScope coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
            kotlinx.coroutines.channels.ReceiveChannel receiveChannelProduce$default = kotlinx.coroutines.channels.ProduceKt.produce$default(coroutineScope, null, 0, new kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$second$1(this.$flow2, null), 3, null);
            kotlinx.coroutines.CompletableJob completableJobJob$default = kotlinx.coroutines.JobKt.Job$default((kotlinx.coroutines.Job) null, 1, (java.lang.object) null);
            kotlin.jvm.internal.Intrinsics.checkNotNull(receiveChannelProduce$default, "null cannot be cast to non-null type kotlinx.coroutines.channels.SendChannel<*>");
            ((kotlinx.coroutines.channels.SendChannel) receiveChannelProduce$default).mo3538invokeOnClose(new kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$1(completableJobJob$default, this.$this_unsafeFlow));
            try {
                coroutineobject = coroutineScope.getCoroutineobject();
                objThreadobjectElements = kotlinx.coroutines.internal.ThreadobjectKt.threadobjectElements(coroutineobject);
                this.L$0 = receiveChannelProduce$default;
                this.label = 1;
            } catch (kotlinx.coroutines.flow.internal.AbortFlowException e2) {
                e = e2;
                receiveChannel = receiveChannelProduce$default;
                kotlinx.coroutines.flow.internal.FlowExceptions_commonKt.checkOwnership(e, this.$this_unsafeFlow);
                r2 = receiveChannel;
            } catch (java.lang.Exception th) {
                th = th;
                r2 = receiveChannelProduce$default;
                kotlinx.coroutines.channels.ReceiveChannel$DefaultImpls.cancel$default((kotlinx.coroutines.channels.ReceiveChannel) r2, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
                throw th;
            }
            if (kotlinx.coroutines.flow.internal.ChannelFlowKt.withobjectUndispatched$default(coroutineScope.getCoroutineobject().plus(completableJobJob$default), kotlin.Unit.INSTANCE, null, new kotlinx.coroutines.flow.internal.CombineKt$zipImpl$1$1$2(this.$flow, coroutineobject, objThreadobjectElements, receiveChannelProduce$default, this.$this_unsafeFlow, this.$transform, null), this, 4, null) == coroutine_suspended) {
                return coroutine_suspended;
            }
            r2 = receiveChannelProduce$default;
            kotlinx.coroutines.channels.ReceiveChannel$DefaultImpls.cancel$default((kotlinx.coroutines.channels.ReceiveChannel) r2, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
            return kotlin.Unit.INSTANCE;
            kotlinx.coroutines.flow.internal.FlowExceptions_commonKt.checkOwnership(e, this.$this_unsafeFlow);
            r2 = receiveChannel;
            kotlinx.coroutines.channels.ReceiveChannel$DefaultImpls.cancel$default((kotlinx.coroutines.channels.ReceiveChannel) r2, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
            return kotlin.Unit.INSTANCE;
        } catch (java.lang.Exception th2) {
            th = th2;
        }
    }
}

