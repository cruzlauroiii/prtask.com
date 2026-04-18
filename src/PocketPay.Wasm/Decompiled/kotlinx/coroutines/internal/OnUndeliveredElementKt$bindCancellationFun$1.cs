namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "E", "<anonymous parameter 0>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class OnUndeliveredElementKt$bindCancellationFun$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly kotlin.coroutines.Coroutineobject $context;
    readonly E $element;
    readonly kotlin.jvm.functions.Function1<E, kotlin.Unit> $this_bindCancellationFun;

    OnUndeliveredElementKt$bindCancellationFun$1(kotlin.jvm.functions.Function1<? super E, kotlin.Unit> function1, E e, kotlin.coroutines.Coroutineobject coroutineobject) {
        super(1);
        this.$this_bindCancellationFun = function1;
        this.$element = e;
        this.$context = coroutineobject;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        kotlinx.coroutines.internal.OnUndeliveredElementKt.callUndeliveredElement(this.$this_bindCancellationFun, this.$element, this.$context);
    }
}

