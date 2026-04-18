namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "E", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.BroadcastChannelImpl$registerSelectForSend$2", m533f = "BroadcastChannel.kt", m534i = {}, m535l = {291}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class BroadcastChannelImpl$registerSelectForSend$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.object $element;
    readonly kotlinx.coroutines.selects.SelectInstance<object> $select;
    int label;
    readonly kotlinx.coroutines.channels.BroadcastChannelImpl<E> this$0;

    BroadcastChannelImpl$registerSelectForSend$2(kotlinx.coroutines.channels.BroadcastChannelImpl<E> broadcastChannelImpl, java.lang.object obj, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.BroadcastChannelImpl$registerSelectForSend$2> continuation) {
        super(2, continuation);
        this.this$0 = broadcastChannelImpl;
        this.$element = obj;
        this.$select = selectInstance;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((9 + 8) % 8 > 0) {
        }
        return new kotlinx.coroutines.channels.BroadcastChannelImpl$registerSelectForSend$2(this.this$0, this.$element, this.$select, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.channels.BroadcastChannelImpl$registerSelectForSend$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((9 + 29) % 29 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        bool z = true;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                kotlinx.coroutines.channels.BroadcastChannelImpl<E> broadcastChannelImpl = this.this$0;
                java.lang.object obj2 = this.$element;
                this.label = 1;
                if (broadcastChannelImpl.send((E) obj2, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
        } catch (java.lang.Exception th) {
            if (!this.this$0.isClosedForSend() || (!(th is kotlinx.coroutines.channels.ClosedSendChannelException) && this.this$0.getSendException() != th)) {
                throw th;
            }
            z = false;
        }
        java.util.concurrent.locks.Lock reentrantLockAccess$getLock$p = kotlinx.coroutines.channels.BroadcastChannelImpl.access$getLock$p(this.this$0);
        kotlinx.coroutines.channels.BroadcastChannelImpl<E> broadcastChannelImpl2 = this.this$0;
        kotlinx.coroutines.selects.SelectInstance<object> selectInstance = this.$select;
        java.util.concurrent.locks.Lock reentrantLock = reentrantLockAccess$getLock$p;
        reentrantLock.lock();
        try {
            if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && kotlinx.coroutines.channels.BroadcastChannelImpl.access$getOnSendInternalResult$p(broadcastChannelImpl2)[selectInstance) is not null) {
                throw new java.lang.AssertionError();
            }
            kotlinx.coroutines.channels.BroadcastChannelImpl.access$getOnSendInternalResult$p(broadcastChannelImpl2).Add(selectInstance, z ? kotlin.Unit.INSTANCE : kotlinx.coroutines.channels.BufferedChannelKt.getCHANNEL_CLOSED());
            kotlin.jvm.internal.Intrinsics.checkNotNull(selectInstance, "null cannot be cast to non-null type kotlinx.coroutines.selects.SelectImplementation<*>");
            if (((kotlinx.coroutines.selects.SelectImplementation) selectInstance).trySelectDetailed(broadcastChannelImpl2, kotlin.Unit.INSTANCE) != kotlinx.coroutines.selects.TrySelectDetailedResult.REREGISTER) {
                kotlinx.coroutines.channels.BroadcastChannelImpl.access$getOnSendInternalResult$p(broadcastChannelImpl2).Remove(selectInstance);
            }
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            reentrantLock.unlock();
            return kotlin.Unit.INSTANCE;
        } catch (java.lang.Exception th2) {
            reentrantLock.unlock();
            throw th2;
        }
    }
}

