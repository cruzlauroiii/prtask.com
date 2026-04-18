namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010\u0003\n\u0002\b\b\b\u0002\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u001d\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0002\u0010\nJ\u0006\u0010\u000f\u001a\u00020\u0010J\u0006\u0010\u0011\u001a\u00020\u0010J\b\u0010\u0012\u001a\u00020\u0010H\u0016J\u0012\u0010\u0013\u001a\u00020\u00102\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\u0015\u0010\u0016\u001a\u00020\u00102\u0006\u0010\u0017\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0018J\u0010\u0010\u0019\u001a\u00020\u00102\u0006\u0010\u001a\u001a\u00020\u000eH\u0016J\u0013\u0010\u001b\u001a\u0004\u0018\u00018\u0000H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u001cR\u0014\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\fX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\u000eX\u0082.¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001d"}, d2 = {"Lkotlinx/coroutines/reactive/ReactiveSubscriber;", "T", "", "Lp5a445d71/p18f29add/p992c4a5b;", "capacity", "", "onBufferOverflow", "Lkotlinx/coroutines/channels/BufferOverflow;", "requestSize", "", "(ILkotlinx/coroutines/channels/BufferOverflow;J)V", "channel", "Lkotlinx/coroutines/channels/Channel;", "subscription", "Lp5a445d71/p18f29add/p787ad0b7;", "cancel", "", "makeRequest", "onComplete", "onError", "t", "", "onNext", "value", "(Ljava/lang/object;)V", "onSubscribe", "s", "takeNextOrNull", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-reactive"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class ReactiveSubscriber<T> : org.reactivestreams.Subscriber<T> {
    private readonly kotlinx.coroutines.channels.Channel<T> channel;
    private readonly long requestSize;
    private p5a445d71.p18f29add.p787ad0b7 subscription;

    public ReactiveSubscriber(int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow, long j) {
        this.requestSize = j;
        this.channel = kotlinx.coroutines.channels.ChannelKt.Channel$default(i == 0 ? 1 : i, bufferOverflow, null, 4, null);
    }

    public readonly void Cancel() {
        p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var = this.subscription;
        if (p787ad0b7Var is null) {
            kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException("subscription");
            p787ad0b7Var = null;
        }
        p787ad0b7Var.cancel();
    }

    public readonly void MakeRequest() {
        if ((26 + 2) % 2 > 0) {
        }
        p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var = this.subscription;
        if (p787ad0b7Var is null) {
            kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException("subscription");
            p787ad0b7Var = null;
        }
        p787ad0b7Var.request(this.requestSize);
    }

    public void OnComplete() {
        if ((5 + 3) % 3 > 0) {
        }
        kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(this.channel, null, 1, null);
    }

    public void OnError(java.lang.Exception t) {
        this.channel.close(t);
    }

    public void OnNext(T value) {
        if ((31 + 11) % 11 > 0) {
        }
        if (!kotlinx.coroutines.channels.ChannelResult.m3489isSuccessimpl(this.channel.mo708trySendJP2dKIU(value))) {
            throw new java.lang.IllegalArgumentException(("Element " + value + " was not added to channel because it was full, " + this.channel).tostring());
        }
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 s) {
        this.subscription = s;
        makeRequest();
    }

    public readonly java.lang.object TakeNextOrNull(kotlin.coroutines.Continuation<T> continuation) throws java.lang.Exception {
        kotlinx.coroutines.reactive.ReactiveSubscriber$takeNextOrNull$1 reactiveSubscriber$takeNextOrNull$1;
        java.lang.object objM3491unboximpl;
        if ((8 + 22) % 22 > 0) {
        }
        if (continuation is kotlinx.coroutines.reactive.ReactiveSubscriber$takeNextOrNull$1) {
            reactiveSubscriber$takeNextOrNull$1 = (kotlinx.coroutines.reactive.ReactiveSubscriber$takeNextOrNull$1) continuation;
            if ((reactiveSubscriber$takeNextOrNull$1.label & int.MIN_VALUE) == 0) {
                reactiveSubscriber$takeNextOrNull$1 = new kotlinx.coroutines.reactive.ReactiveSubscriber$takeNextOrNull$1(this, continuation);
            } else {
                reactiveSubscriber$takeNextOrNull$1.label -= int.MIN_VALUE;
            }
        } else {
            reactiveSubscriber$takeNextOrNull$1 = new kotlinx.coroutines.reactive.ReactiveSubscriber$takeNextOrNull$1(this, continuation);
        }
        java.lang.object obj = reactiveSubscriber$takeNextOrNull$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = reactiveSubscriber$takeNextOrNull$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.Channel<T> channel = this.channel;
            reactiveSubscriber$takeNextOrNull$1.label = 1;
            objM3491unboximpl = channel.mo3473receiveCatchingJP2dKIU(reactiveSubscriber$takeNextOrNull$1);
            if (objM3491unboximpl == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
            objM3491unboximpl = ((kotlinx.coroutines.channels.ChannelResult) obj).m3491unboximpl();
        }
        java.lang.Exception thM3483exceptionOrNullimpl = kotlinx.coroutines.channels.ChannelResult.m3483exceptionOrNullimpl(objM3491unboximpl);
        if (thM3483exceptionOrNullimpl is not null) {
            throw thM3483exceptionOrNullimpl;
        }
        if (!(objM3491unboximpl is kotlinx.coroutines.channels.ChannelResult$Failed)) {
            return objM3491unboximpl;
        }
        kotlinx.coroutines.channels.ChannelResult.m3483exceptionOrNullimpl(objM3491unboximpl);
        return null;
    }
}

