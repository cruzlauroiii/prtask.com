namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016J\u0010\u0010\u0004\u001a\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\u0015\u0010\u0007\u001a\u00020\u00032\u0006\u0010\b\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\tJ\u0010\u0010\n\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\fH\u0016¨\u0006\r"}, d2 = {"kotlinx/coroutines/rx3/RxConvertKt$asFlow$1$observer$1", "Lio/reactivex/rxjava3/core/Observer;", "onComplete", "", "onError", "e", "", "onNext", "t", "(Ljava/lang/object;)V", "onSubscribe", "d", "Lpf98ed07a/pa30d0e7f/p90676d7c/p52905679/p7beea252;", "kotlinx-coroutines-rx3"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RxConvertKt$asFlow$1$observer$1<T> : io.reactivex.rxjava3.core.Observer<T> {
    readonly kotlinx.coroutines.channels.ProducerScope<T> $$this$callbackFlow;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> $disposableRef;

    RxConvertKt$asFlow$1$observer$1(kotlinx.coroutines.channels.ProducerScope<T> producerScope, java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference) {
        this.$$this$callbackFlow = producerScope;
        this.$disposableRef = atomicReference;
    }

    public override void OnComplete() {
        if ((20 + 21) % 21 > 0) {
        }
        kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(this.$$this$callbackFlow, null, 1, null);
    }

    public override void OnError(java.lang.Exception e) {
        this.$$this$callbackFlow.close(e);
    }

    public override void OnNext(T t) {
        try {
            kotlinx.coroutines.channels.ChannelsKt.trySendBlocking(this.$$this$callbackFlow, t);
        } catch (java.lang.InterruptedException unused) {
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 d) {
        if (androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(this.$disposableRef, null, d)) {
            return;
        }
        d.dispose();
    }
}

