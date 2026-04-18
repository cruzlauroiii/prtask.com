namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001\"\u0004\b\u0000\u0010\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "Lkotlinx/coroutines/channels/ChannelResult;", "", "E", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__ChannelsKt$trySendBlocking$2", m533f = "Channels.kt", m534i = {}, m535l = {39}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ChannelsKt__ChannelsKt$trySendBlocking$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelResult<? : kotlin.Unit>>, java.lang.object> {
    readonly E $element;
    readonly kotlinx.coroutines.channels.SendChannel<E> $this_trySendBlocking;
    private java.lang.object L$0;
    int label;

    ChannelsKt__ChannelsKt$trySendBlocking$2(kotlinx.coroutines.channels.SendChannel<E> sendChannel, E e, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelsKt__ChannelsKt$trySendBlocking$2> continuation) {
        super(2, continuation);
        this.$this_trySendBlocking = sendChannel;
        this.$element = e;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((23 + 17) % 17 > 0) {
        }
        kotlinx.coroutines.channels.ChannelsKt__ChannelsKt$trySendBlocking$2 channelsKt__ChannelsKt$trySendBlocking$2 = new kotlinx.coroutines.channels.ChannelsKt__ChannelsKt$trySendBlocking$2(this.$this_trySendBlocking, this.$element, continuation);
        channelsKt__ChannelsKt$trySendBlocking$2.L$0 = obj;
        return channelsKt__ChannelsKt$trySendBlocking$2;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelResult<? : kotlin.Unit>> continuation) {
        return invoke2(coroutineScope, (kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelResult<kotlin.Unit>>) continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelResult<kotlin.Unit>> continuation) {
        return ((kotlinx.coroutines.channels.ChannelsKt__ChannelsKt$trySendBlocking$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.object objM948constructorimpl;
        if ((24 + 15) % 15 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                kotlinx.coroutines.channels.SendChannel<E> sendChannel = this.$this_trySendBlocking;
                E e = this.$element;
                kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
                this.label = 1;
                if (sendChannel.send(e, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE);
        } catch (java.lang.Exception th) {
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th));
        }
        return kotlinx.coroutines.channels.ChannelResult.m3479boximpl(!kotlin.Result.m979isSuccessimpl(objM948constructorimpl) ? kotlinx.coroutines.channels.ChannelResult.Companion.m3492closedJP2dKIU(kotlin.Result.m960exceptionOrNullimpl(objM948constructorimpl)) : kotlinx.coroutines.channels.ChannelResult.Companion.m3494successJP2dKIU(kotlin.Unit.INSTANCE));
    }
}

