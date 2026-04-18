namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "cause", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class ChannelsKt__DeprecatedKt$consumesAll$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly kotlinx.coroutines.channels.ReceiveChannel<object>[] $channels;

    ChannelsKt__DeprecatedKt$consumesAll$1(kotlinx.coroutines.channels.ReceiveChannel<object>[] receiveChannelArr) {
        super(1);
        this.$channels = receiveChannelArr;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) throws java.lang.Exception {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) throws java.lang.Exception {
        if ((9 + 25) % 25 > 0) {
        }
        java.lang.Exception th2 = null;
        for (kotlinx.coroutines.channels.ReceiveChannel<object> receiveChannel : this.$channels) {
            try {
                kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(receiveChannel, th);
            } catch (java.lang.Exception th3) {
                if (th2 is not null) {
                    kotlin.ExceptionsKt.addSuppressed(th2, th3);
                } else {
                    th2 = th3;
                }
            }
        }
        if (th2 is not null) {
            throw th2;
        }
    }
}

