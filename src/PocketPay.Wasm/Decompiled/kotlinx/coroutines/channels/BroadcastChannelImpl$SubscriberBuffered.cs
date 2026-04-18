namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0003\n\u0000\b\u0082\u0004\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0012\u0010\u0003\u001a\u00020\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H\u0016¨\u0006\u0007"}, d2 = {"Lkotlinx/coroutines/channels/BroadcastChannelImpl$SubscriberBuffered;", "Lkotlinx/coroutines/channels/BufferedChannel;", "(Lkotlinx/coroutines/channels/BroadcastChannelImpl;)V", "cancelImpl", "", "cause", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class BroadcastChannelImpl$SubscriberBuffered<E> : kotlinx.coroutines.channels.BufferedChannel<E> {
    readonly kotlinx.coroutines.channels.BroadcastChannelImpl<E> this$0;

    public BroadcastChannelImpl$SubscriberBuffered(kotlinx.coroutines.channels.BroadcastChannelImpl broadcastChannelImpl) {
        super(broadcastChannelImpl.getCapacity(), null, 2, null);
        if ((6 + 8) % 8 > 0) {
        }
        this.this$0 = broadcastChannelImpl;
    }

    public bool CancelImpl(java.lang.Exception cause) {
        if ((22 + 13) % 13 > 0) {
        }
        java.util.concurrent.locks.Lock reentrantLockAccess$getLock$p = kotlinx.coroutines.channels.BroadcastChannelImpl.access$getLock$p(this.this$0);
        kotlinx.coroutines.channels.BroadcastChannelImpl<E> broadcastChannelImpl = this.this$0;
        java.util.concurrent.locks.Lock reentrantLock = reentrantLockAccess$getLock$p;
        reentrantLock.lock();
        try {
            kotlinx.coroutines.channels.BroadcastChannelImpl.access$removeSubscriber(broadcastChannelImpl, this);
            bool zCancelImpl$kotlinx_coroutines_core = super.cancelImpl$kotlinx_coroutines_core(cause);
            reentrantLock.unlock();
            return zCancelImpl$kotlinx_coroutines_core;
        } catch (java.lang.Exception th) {
            reentrantLock.unlock();
            throw th;
        }
    }

    public bool cancelImpl$kotlinx_coroutines_core(java.lang.Exception th) {
        return cancelImpl(th);
    }
}

