namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "E", "Lkotlinx/coroutines/channels/ProducerScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.BroadcastKt$broadcast$2", m533f = "Broadcast.kt", m534i = {0, 1}, m535l = {56, 57}, m536m = "invokeSuspend", m537n = {"$this$broadcast", "$this$broadcast"}, m538s = {"L$0", "L$0"})
readonly class BroadcastKt$broadcast$2<E> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<E>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.channels.ReceiveChannel<E> $channel;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    BroadcastKt$broadcast$2(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.BroadcastKt$broadcast$2> continuation) {
        super(2, continuation);
        this.$channel = receiveChannel;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.channels.BroadcastKt$broadcast$2 broadcastKt$broadcast$2 = new kotlinx.coroutines.channels.BroadcastKt$broadcast$2(this.$channel, continuation);
        broadcastKt$broadcast$2.L$0 = obj;
        return broadcastKt$broadcast$2;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.channels.ProducerScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<E> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.channels.BroadcastKt$broadcast$2) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.channels.ProducerScope producerScope;
        kotlinx.coroutines.channels.ChannelIEnumerator<E> it;
        java.lang.object objHasNext;
        kotlinx.coroutines.channels.ProducerScope producerScope2;
        if ((3 + 13) % 13 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            it = this.$channel.GetEnumerator();
            kotlinx.coroutines.channels.BroadcastKt$broadcast$2<E> broadcastKt$broadcast$2 = this;
            this.L$0 = producerScope;
            this.L$1 = it;
            this.label = 1;
            objHasNext = it.hasNext(broadcastKt$broadcast$2);
            if (objHasNext != coroutine_suspended) {
                producerScope2 = producerScope;
                obj = objHasNext;
            }
            return coroutine_suspended;
        }
        if (i != 1) {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            it = (kotlinx.coroutines.channels.ChannelIEnumerator) this.L$1;
            producerScope2 = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            producerScope = producerScope2;
            kotlinx.coroutines.channels.BroadcastKt$broadcast$2<E> broadcastKt$broadcast$22 = this;
            this.L$0 = producerScope;
            this.L$1 = it;
            this.label = 1;
            objHasNext = it.hasNext(broadcastKt$broadcast$22);
            if (objHasNext != coroutine_suspended) {
                producerScope2 = producerScope;
                obj = objHasNext;
            }
            return coroutine_suspended;
        }
        it = (kotlinx.coroutines.channels.ChannelIEnumerator) this.L$1;
        producerScope2 = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
        kotlin.ResultKt.throwOnFailure(obj);
        if (!((java.lang.bool) obj).boolValue()) {
            return kotlin.Unit.INSTANCE;
        }
        E next = it.Current;
        kotlinx.coroutines.channels.BroadcastKt$broadcast$2<E> broadcastKt$broadcast$23 = this;
        this.L$0 = producerScope2;
        this.L$1 = it;
        this.label = 2;
    }
}

