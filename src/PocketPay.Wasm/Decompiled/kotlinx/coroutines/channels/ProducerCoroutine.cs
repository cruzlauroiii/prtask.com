namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0005\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u001b\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0002\u0010\bJ\u0018\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\nH\u0014J\u0015\u0010\u0011\u001a\u00020\r2\u0006\u0010\u0012\u001a\u00020\rH\u0014¢\u0006\u0002\u0010\u0013R\u0014\u0010\t\u001a\u00020\n8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\u000b¨\u0006\u0014"}, d2 = {"Lkotlinx/coroutines/channels/ProducerCoroutine;", "E", "Lkotlinx/coroutines/channels/ChannelCoroutine;", "Lkotlinx/coroutines/channels/ProducerScope;", "parentobject", "Lkotlin/coroutines/Coroutineobject;", "channel", "Lkotlinx/coroutines/channels/Channel;", "(Lkotlin/coroutines/Coroutineobject;Lkotlinx/coroutines/channels/Channel;)V", "isActive", "", "()Z", "onCancelled", "", "cause", "", "handled", "onCompleted", "value", "(Lkotlin/Unit;)V", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class ProducerCoroutine<E> : kotlinx.coroutines.channels.ChannelCoroutine<E> : kotlinx.coroutines.channels.ProducerScope<E> {
    public ProducerCoroutine(kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.channels.Channel<E> channel) {
        super(coroutineobject, channel, true, true);
    }

    public override kotlinx.coroutines.channels.SendChannel GetChannel() {
        return getChannel();
    }

    public override bool IsActive() {
        return super.isActive();
    }

    protected override void OnCancelled(java.lang.Exception cause, bool handled) {
        if (get_channel().close(cause) || handled) {
            return;
        }
        kotlinx.coroutines.CoroutineExceptionHandlerKt.handleCoroutineException(getobject(), cause);
    }

    public override void OnCompleted(kotlin.Unit unit) {
        onCompleted2(unit);
    }

    protected void OnCompleted2(kotlin.Unit value) {
        kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(get_channel(), null, 1, null);
    }
}

