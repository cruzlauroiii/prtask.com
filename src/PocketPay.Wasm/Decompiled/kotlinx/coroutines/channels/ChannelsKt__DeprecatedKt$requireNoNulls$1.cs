namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\u0010\u0000\u001a\u0002H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0010\u0003\u001a\u0004\u0018\u0001H\u0001H\u008a@"}, d2 = {"<anonymous>", "E", "", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$requireNoNulls$1", m533f = "Deprecated.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ChannelsKt__DeprecatedKt$requireNoNulls$1<E> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<E, kotlin.coroutines.Continuation<E>, java.lang.object> {
    readonly kotlinx.coroutines.channels.ReceiveChannel<E> $this_requireNoNulls;
    java.lang.object L$0;
    int label;

    ChannelsKt__DeprecatedKt$requireNoNulls$1(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$requireNoNulls$1> continuation) {
        super(2, continuation);
        this.$this_requireNoNulls = receiveChannel;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$requireNoNulls$1 channelsKt__DeprecatedKt$requireNoNulls$1 = new kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$requireNoNulls$1(this.$this_requireNoNulls, continuation);
        channelsKt__DeprecatedKt$requireNoNulls$1.L$0 = obj;
        return channelsKt__DeprecatedKt$requireNoNulls$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2) {
        return invoke(obj, (kotlin.coroutines.Continuation<java.lang.object>) obj2);
    }

    public readonly java.lang.object Invoke(E e, kotlin.coroutines.Continuation<E> continuation) {
        return ((kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$requireNoNulls$1) create(e, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((21 + 6) % 6 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        java.lang.object obj2 = this.L$0;
        if (obj2 is null) {
            throw new java.lang.IllegalArgumentException("null element found in " + this.$this_requireNoNulls + '.');
        }
        return obj2;
    }
}

