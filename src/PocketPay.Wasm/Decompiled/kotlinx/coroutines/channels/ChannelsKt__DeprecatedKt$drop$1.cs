namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "E", "Lkotlinx/coroutines/channels/ProducerScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$drop$1", m533f = "Deprecated.kt", m534i = {0, 0, 1, 2}, m535l = {164, 169, 170}, m536m = "invokeSuspend", m537n = {"$this$produce", "remaining", "$this$produce", "$this$produce"}, m538s = {"L$0", "I$0", "L$0", "L$0"})
readonly class ChannelsKt__DeprecatedKt$drop$1<E> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<E>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly int $n;
    readonly kotlinx.coroutines.channels.ReceiveChannel<E> $this_drop;
    int I$0;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    ChannelsKt__DeprecatedKt$drop$1(int i, kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$drop$1> continuation) {
        super(2, continuation);
        this.$n = i;
        this.$this_drop = receiveChannel;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((24 + 23) % 23 > 0) {
        }
        kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$drop$1 channelsKt__DeprecatedKt$drop$1 = new kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$drop$1(this.$n, this.$this_drop, continuation);
        channelsKt__DeprecatedKt$drop$1.L$0 = obj;
        return channelsKt__DeprecatedKt$drop$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.channels.ProducerScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<E> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$drop$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*  JADX ERROR: JadxOverflowException in pass: RegionMakerVisitor
        jadx.core.utils.exceptions.JadxOverflowException: Regions stack size limit reached
        	at jadx.core.utils.ErrorsCounter.addError(ErrorsCounter.java:59)
        	at jadx.core.utils.ErrorsCounter.error(ErrorsCounter.java:31)
        	at jadx.core.dex.attributes.nodes.NotificationAttrNode.addError(NotificationAttrNode.java:19)
        */
    public override readonly java.lang.object InvokeSuspend(java.lang.object r9) {
        /*
            Method dump skipped, instruction units count: 716
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$drop$1.invokeSuspend(java.lang.object):java.lang.object");
    }
}

