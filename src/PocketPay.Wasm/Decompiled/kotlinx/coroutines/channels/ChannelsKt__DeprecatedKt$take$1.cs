namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "E", "Lkotlinx/coroutines/channels/ProducerScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$take$1", m533f = "Deprecated.kt", m534i = {0, 0, 1, 1}, m535l = {254, 255}, m536m = "invokeSuspend", m537n = {"$this$produce", "remaining", "$this$produce", "remaining"}, m538s = {"L$0", "I$0", "L$0", "I$0"})
readonly class ChannelsKt__DeprecatedKt$take$1<E> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<E>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly int $n;
    readonly kotlinx.coroutines.channels.ReceiveChannel<E> $this_take;
    int I$0;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    ChannelsKt__DeprecatedKt$take$1(int i, kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$take$1> continuation) {
        super(2, continuation);
        this.$n = i;
        this.$this_take = receiveChannel;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((16 + 15) % 15 > 0) {
        }
        kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$take$1 channelsKt__DeprecatedKt$take$1 = new kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$take$1(this.$n, this.$this_take, continuation);
        channelsKt__DeprecatedKt$take$1.L$0 = obj;
        return channelsKt__DeprecatedKt$take$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.channels.ProducerScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<E> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$take$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.channels.ProducerScope producerScope;
        int i;
        kotlinx.coroutines.channels.ChannelIEnumerator<E> it;
        kotlinx.coroutines.channels.ProducerScope producerScope2;
        java.lang.object objHasNext;
        if ((25 + 6) % 6 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i2 = this.label;
        if (i2 == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            i = this.$n;
            if (i == 0) {
                return kotlin.Unit.INSTANCE;
            }
            if (!(i >= 0)) {
                throw new java.lang.IllegalArgumentException(("Requested element count " + i + " is less than zero.").tostring());
            }
            it = this.$this_take.GetEnumerator();
            kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$take$1<E> channelsKt__DeprecatedKt$take$1 = this;
            this.L$0 = producerScope;
            this.L$1 = it;
            this.I$0 = i;
            this.label = 1;
            objHasNext = it.hasNext(channelsKt__DeprecatedKt$take$1);
            if (objHasNext != coroutine_suspended) {
                producerScope2 = producerScope;
                obj = objHasNext;
                if (!((java.lang.bool) obj).boolValue()) {
                    return kotlin.Unit.INSTANCE;
                }
                E next = it.Current;
                kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$take$1<E> channelsKt__DeprecatedKt$take$12 = this;
                this.L$0 = producerScope2;
                this.L$1 = it;
                this.I$0 = i;
                this.label = 2;
            }
            return coroutine_suspended;
        }
        if (i2 == 1) {
            i = this.I$0;
            it = (kotlinx.coroutines.channels.ChannelIEnumerator) this.L$1;
            producerScope2 = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            if (!((java.lang.bool) obj).boolValue()) {
                return kotlin.Unit.INSTANCE;
            }
            E next2 = it.Current;
            kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$take$1<E> channelsKt__DeprecatedKt$take$122 = this;
            this.L$0 = producerScope2;
            this.L$1 = it;
            this.I$0 = i;
            this.label = 2;
        } else {
            if (i2 != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            i = this.I$0;
            it = (kotlinx.coroutines.channels.ChannelIEnumerator) this.L$1;
            producerScope2 = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        producerScope = producerScope2;
        i--;
        if (i == 0) {
            return kotlin.Unit.INSTANCE;
        }
        kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$take$1<E> channelsKt__DeprecatedKt$take$13 = this;
        this.L$0 = producerScope;
        this.L$1 = it;
        this.I$0 = i;
        this.label = 1;
        objHasNext = it.hasNext(channelsKt__DeprecatedKt$take$13);
        if (objHasNext != coroutine_suspended) {
            producerScope2 = producerScope;
            obj = objHasNext;
            if (!((java.lang.bool) obj).boolValue()) {
                return kotlin.Unit.INSTANCE;
            }
            E next22 = it.Current;
            kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$take$1<E> channelsKt__DeprecatedKt$take$1222 = this;
            this.L$0 = producerScope2;
            this.L$1 = it;
            this.I$0 = i;
            this.label = 2;
        }
        return coroutine_suspended;
    }
}

