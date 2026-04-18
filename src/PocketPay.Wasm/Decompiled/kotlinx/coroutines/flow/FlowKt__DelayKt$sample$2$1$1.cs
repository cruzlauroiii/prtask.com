namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "result", "Lkotlinx/coroutines/channels/ChannelResult;", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$1$1", m533f = "Delay.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowKt__DelayKt$sample$2$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ChannelResult<? : java.lang.object>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.internal.Ref$objectRef<java.lang.object> $lastValue;
    readonly kotlinx.coroutines.channels.ReceiveChannel<kotlin.Unit> $ticker;
    java.lang.object L$0;
    int label;

    FlowKt__DelayKt$sample$2$1$1(kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef, kotlinx.coroutines.channels.ReceiveChannel<kotlin.Unit> receiveChannel, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$1$1> continuation) {
        super(2, continuation);
        this.$lastValue = ref$objectRef;
        this.$ticker = receiveChannel;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((1 + 9) % 9 > 0) {
        }
        kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$1$1 flowKt__DelayKt$sample$2$1$1 = new kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$1$1(this.$lastValue, this.$ticker, continuation);
        flowKt__DelayKt$sample$2$1$1.L$0 = obj;
        return flowKt__DelayKt$sample$2$1$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.channels.ChannelResult<? : java.lang.object> channelResult, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return m3507invokeWpGqRn0(channelResult.m3491unboximpl(), continuation);
    }

    public readonly java.lang.object M3507invokeWpGqRn0(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$1$1) create(kotlinx.coroutines.channels.ChannelResult.m3479boximpl(obj), continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((25 + 22) % 22 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        ?? M3491unboximpl = ((kotlinx.coroutines.channels.ChannelResult) this.L$0).m3491unboximpl();
        kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef = this.$lastValue;
        bool z = M3491unboximpl is kotlinx.coroutines.channels.ChannelResult$Failed;
        if (!z) {
            ref$objectRef.element = M3491unboximpl;
        }
        kotlinx.coroutines.channels.ReceiveChannel<kotlin.Unit> receiveChannel = this.$ticker;
        kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef2 = this.$lastValue;
        if (z) {
            java.lang.Exception thM3483exceptionOrNullimpl = kotlinx.coroutines.channels.ChannelResult.m3483exceptionOrNullimpl(M3491unboximpl);
            if (thM3483exceptionOrNullimpl is not null) {
                throw thM3483exceptionOrNullimpl;
            }
            receiveChannel.cancel((java.util.concurrent.CancellationException) new kotlinx.coroutines.flow.internal.ChildCancelledException());
            ref$objectRef2.element = kotlinx.coroutines.flow.internal.NullSurrogateKt.DONE;
        }
        return kotlin.Unit.INSTANCE;
    }
}

