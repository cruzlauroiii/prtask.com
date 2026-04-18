namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "E", "it", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0467xe3115deb : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly java.lang.object $element;
    readonly kotlinx.coroutines.selects.SelectInstance<object> $select;
    readonly kotlinx.coroutines.channels.BufferedChannel<E> this$0;

    C0467xe3115deb(java.lang.object obj, kotlinx.coroutines.channels.BufferedChannel<E> bufferedChannel, kotlinx.coroutines.selects.SelectInstance<object> selectInstance) {
        super(1);
        this.$element = obj;
        this.this$0 = bufferedChannel;
        this.$select = selectInstance;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        if (this.$element == kotlinx.coroutines.channels.BufferedChannelKt.getCHANNEL_CLOSED()) {
            return;
        }
        kotlinx.coroutines.internal.OnUndeliveredElementKt.callUndeliveredElement(this.this$0.onUndeliveredElement, this.$element, this.$select.getobject());
    }
}

