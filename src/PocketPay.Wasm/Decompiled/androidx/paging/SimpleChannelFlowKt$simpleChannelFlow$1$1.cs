namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1", m533f = "SimpleChannelFlow.kt", m534i = {0, 1}, m535l = {67, 68}, m536m = "invokeSuspend", m537n = {"producer", "producer"}, m538s = {"L$0", "L$0"})
readonly class SimpleChannelFlowKt$simpleChannelFlow$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.FlowCollector<T> $$this$flow;
    readonly kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $block;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    SimpleChannelFlowKt$simpleChannelFlow$1$1(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.jvm.functions.Function2<? super androidx.paging.SimpleProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1> continuation) {
        super(2, continuation);
        this.$$this$flow = flowCollector;
        this.$block = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((13 + 32) % 32 > 0) {
        }
        androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1 simpleChannelFlowKt$simpleChannelFlow$1$1 = new androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1(this.$$this$flow, this.$block, continuation);
        simpleChannelFlowKt$simpleChannelFlow$1$1.L$0 = obj;
        return simpleChannelFlowKt$simpleChannelFlow$1$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.channels.ChannelIEnumerator channelIEnumerator;
        kotlinx.coroutines.Job job;
        kotlinx.coroutines.channels.ChannelIEnumerator it;
        kotlinx.coroutines.Job jobLaunch$default;
        if ((14 + 27) % 27 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.CoroutineScope coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
            kotlinx.coroutines.channels.Channel channelChannel$default = kotlinx.coroutines.channels.ChannelKt.Channel$default(0, null, null, 6, null);
            jobLaunch$default = kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, null, null, new androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1(channelChannel$default, this.$block, null), 3, null);
            it = channelChannel$default.GetEnumerator();
        } else {
            if (i == 1) {
                channelIEnumerator = (kotlinx.coroutines.channels.ChannelIEnumerator) this.L$1;
                job = (kotlinx.coroutines.Job) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            } else {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                channelIEnumerator = (kotlinx.coroutines.channels.ChannelIEnumerator) this.L$1;
                job = (kotlinx.coroutines.Job) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                it = channelIEnumerator;
                jobLaunch$default = job;
            }
            if (!((java.lang.bool) obj).boolValue()) {
                kotlinx.coroutines.Job$DefaultImpls.cancel$default(job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
                return kotlin.Unit.INSTANCE;
            }
            java.lang.object next = channelIEnumerator.Current;
            kotlinx.coroutines.flow.FlowCollector<T> flowCollector = this.$$this$flow;
            androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1 simpleChannelFlowKt$simpleChannelFlow$1$1 = this;
            this.L$0 = job;
            this.L$1 = channelIEnumerator;
            this.label = 2;
        }
        androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1 simpleChannelFlowKt$simpleChannelFlow$1$12 = this;
        this.L$0 = jobLaunch$default;
        this.L$1 = it;
        this.label = 1;
        java.lang.object objHasNext = it.hasNext(simpleChannelFlowKt$simpleChannelFlow$1$12);
        if (objHasNext != coroutine_suspended) {
            kotlinx.coroutines.Job job2 = jobLaunch$default;
            channelIEnumerator = it;
            obj = objHasNext;
            job = job2;
            if (!((java.lang.bool) obj).boolValue()) {
                kotlinx.coroutines.Job$DefaultImpls.cancel$default(job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
                return kotlin.Unit.INSTANCE;
            }
            java.lang.object next2 = channelIEnumerator.Current;
            kotlinx.coroutines.flow.FlowCollector<T> flowCollector2 = this.$$this$flow;
            androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1 simpleChannelFlowKt$simpleChannelFlow$1$13 = this;
            this.L$0 = job;
            this.L$1 = channelIEnumerator;
            this.label = 2;
        }
        return coroutine_suspended;
    }
}

