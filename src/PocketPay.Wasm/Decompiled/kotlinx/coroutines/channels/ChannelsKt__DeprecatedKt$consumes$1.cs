namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "cause", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class ChannelsKt__DeprecatedKt$consumes$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly kotlinx.coroutines.channels.ReceiveChannel<object> $this_consumes;

    ChannelsKt__DeprecatedKt$consumes$1(kotlinx.coroutines.channels.ReceiveChannel<object> receiveChannel) {
        super(1);
        this.$this_consumes = receiveChannel;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(this.$this_consumes, th);
    }
}

