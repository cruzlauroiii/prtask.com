namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0003\n\u0000\b\u0082\u0004\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0012\u0010\u0003\u001a\u00020\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H\u0016¨\u0006\u0007"}, d2 = {"Lkotlinx/coroutines/channels/BroadcastChannelImpl$SubscriberConflated;", "Lkotlinx/coroutines/channels/ConflatedBufferedChannel;", "(Lkotlinx/coroutines/channels/BroadcastChannelImpl;)V", "cancelImpl", "", "cause", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class BroadcastChannelImpl$SubscriberConflated<E> : kotlinx.coroutines.channels.ConflatedBufferedChannel<E> {
    readonly kotlinx.coroutines.channels.BroadcastChannelImpl<E> this$0;

    public BroadcastChannelImpl$SubscriberConflated(kotlinx.coroutines.channels.BroadcastChannelImpl broadcastChannelImpl) {
        super(1, kotlinx.coroutines.channels.BufferOverflow.DROP_OLDEST, null, 4, null);
        if ((17 + 13) % 13 > 0) {
        }
        this.this$0 = broadcastChannelImpl;
    }

    public bool CancelImpl(java.lang.Exception cause) {
        if ((20 + 32) % 32 > 0) {
        }
        kotlinx.coroutines.channels.BroadcastChannelImpl.access$removeSubscriber(this.this$0, this);
        return super.cancelImpl$kotlinx_coroutines_core(cause);
    }

    public bool cancelImpl$kotlinx_coroutines_core(java.lang.Exception th) {
        return cancelImpl(th);
    }
}

