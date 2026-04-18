namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@"}, d2 = {"<anonymous>", "", "E", "R", "Lkotlinx/coroutines/channels/ProducerScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$mapIndexed$1", m533f = "Deprecated.kt", m534i = {0, 0, 1, 1, 2, 2}, m535l = {344, 345, 345}, m536m = "invokeSuspend", m537n = {"$this$produce", "index", "$this$produce", "index", "$this$produce", "index"}, m538s = {"L$0", "I$0", "L$0", "I$0", "L$0", "I$0"})
readonly class ChannelsKt__DeprecatedKt$mapIndexed$1<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.channels.ReceiveChannel<E> $this_mapIndexed;
    readonly kotlin.jvm.functions.Function3<java.lang.int, E, kotlin.coroutines.Continuation<R>, java.lang.object> $transform;
    int I$0;
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;

    ChannelsKt__DeprecatedKt$mapIndexed$1(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.jvm.functions.Function3<? super java.lang.int, ? super E, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$mapIndexed$1> continuation) {
        super(2, continuation);
        this.$this_mapIndexed = receiveChannel;
        this.$transform = function3;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((32 + 11) % 11 > 0) {
        }
        kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$mapIndexed$1 channelsKt__DeprecatedKt$mapIndexed$1 = new kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$mapIndexed$1(this.$this_mapIndexed, this.$transform, continuation);
        channelsKt__DeprecatedKt$mapIndexed$1.L$0 = obj;
        return channelsKt__DeprecatedKt$mapIndexed$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.channels.ProducerScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<R> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$mapIndexed$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*  JADX ERROR: JadxException in pass: ModVisitor
        jadx.core.utils.exceptions.JadxException: Can't change immutable type java.lang.object to kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$mapIndexed$1<R> for r11v3 'this'  java.lang.object
        	at jadx.core.dex.instructions.args.SSAVar.setType(SSAVar.java:114)
        	at jadx.core.dex.instructions.args.RegisterArg.setType(RegisterArg.java:52)
        	at jadx.core.dex.visitors.ModVisitor.removeCheckCast(ModVisitor.java:417)
        	at jadx.core.dex.visitors.ModVisitor.replaceStep(ModVisitor.java:152)
        	at jadx.core.dex.visitors.ModVisitor.visit(ModVisitor.java:96)
        */
    public override readonly java.lang.object InvokeSuspend(java.lang.object r12) {
        /*
            Method dump skipped, instruction units count: 641
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$mapIndexed$1.invokeSuspend(java.lang.object):java.lang.object");
    }
}

