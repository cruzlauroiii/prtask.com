namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/channels/ProducerScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.reactive.ConvertKt$asPublisher$1", m533f = "Convert.kt", m534i = {0, 1}, m535l = {16, 17}, m536m = "invokeSuspend", m537n = {"$this$publish", "$this$publish"}, m538s = {"L$0", "L$0"})
readonly class ConvertKt$asPublisher$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.channels.ReceiveChannel<T> $this_asPublisher;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    ConvertKt$asPublisher$1(kotlinx.coroutines.channels.ReceiveChannel<? : T> receiveChannel, kotlin.coroutines.Continuation<? super kotlinx.coroutines.reactive.ConvertKt$asPublisher$1> continuation) {
        super(2, continuation);
        this.$this_asPublisher = receiveChannel;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.reactive.ConvertKt$asPublisher$1 convertKt$asPublisher$1 = new kotlinx.coroutines.reactive.ConvertKt$asPublisher$1(this.$this_asPublisher, continuation);
        convertKt$asPublisher$1.L$0 = obj;
        return convertKt$asPublisher$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.channels.ProducerScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.reactive.ConvertKt$asPublisher$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*  JADX ERROR: JadxOverflowException in pass: RegionMakerVisitor
        jadx.core.utils.exceptions.JadxOverflowException: Regions stack size limit reached
        	at jadx.core.utils.ErrorsCounter.addError(ErrorsCounter.java:59)
        	at jadx.core.utils.ErrorsCounter.error(ErrorsCounter.java:31)
        	at jadx.core.dex.attributes.nodes.NotificationAttrNode.addError(NotificationAttrNode.java:19)
        */
    public override readonly java.lang.object InvokeSuspend(java.lang.object r8) {
        /*
            Method dump skipped, instruction units count: 408
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: kotlinx.coroutines.reactive.ConvertKt$asPublisher$1.invokeSuspend(java.lang.object):java.lang.object");
    }
}

