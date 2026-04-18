namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "T", "it", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RxAwaitKt$awaitOne$2$1$onSubscribe$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 $sub;

    RxAwaitKt$awaitOne$2$1$onSubscribe$1(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        super(1);
        this.$sub = p7beea252Var;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        this.$sub.dispose();
    }
}

