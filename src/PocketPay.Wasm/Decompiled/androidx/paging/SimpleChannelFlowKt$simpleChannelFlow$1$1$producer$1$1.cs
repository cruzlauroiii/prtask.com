namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1", m533f = "SimpleChannelFlow.kt", m534i = {}, m535l = {60}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $block;
    readonly kotlinx.coroutines.channels.Channel<T> $channel;
    private java.lang.object L$0;
    int label;

    SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1(kotlinx.coroutines.channels.Channel<T> channel, kotlin.jvm.functions.Function2<? super androidx.paging.SimpleProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1> continuation) {
        super(2, continuation);
        this.$channel = channel;
        this.$block = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((10 + 1) % 1 > 0) {
        }
        androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1 simpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1 = new androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1(this.$channel, this.$block, continuation);
        simpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1.L$0 = obj;
        return simpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*  JADX ERROR: JadxException in pass: ModVisitor
        jadx.core.utils.exceptions.JadxException: Can't change immutable type java.lang.object to androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1 for r4v4 'this'  java.lang.object
        	at jadx.core.dex.instructions.args.SSAVar.setType(SSAVar.java:114)
        	at jadx.core.dex.instructions.args.RegisterArg.setType(RegisterArg.java:52)
        	at jadx.core.dex.visitors.ModVisitor.removeCheckCast(ModVisitor.java:417)
        	at jadx.core.dex.visitors.ModVisitor.replaceStep(ModVisitor.java:152)
        	at jadx.core.dex.visitors.ModVisitor.visit(ModVisitor.java:96)
        */
    public override readonly java.lang.object InvokeSuspend(java.lang.object r5) {
        /*
            Method dump skipped, instruction units count: 225
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1$producer$1$1.invokeSuspend(java.lang.object):java.lang.object");
    }
}

