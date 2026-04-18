namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "T", "it", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AwaitKt$awaitOne$2$1$onSubscribe$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly p5a445d71.p18f29add.p787ad0b7 $sub;
    readonly kotlinx.coroutines.reactive.AwaitKt$awaitOne$2$1<T> this$0;

    AwaitKt$awaitOne$2$1$onSubscribe$2(kotlinx.coroutines.reactive.AwaitKt$awaitOne$2$1<T> awaitKt$awaitOne$2$1, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        super(1);
        this.this$0 = awaitKt$awaitOne$2$1;
        this.$sub = p787ad0b7Var;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        kotlinx.coroutines.reactive.AwaitKt$awaitOne$2$1.access$withSubscriptionLock(this.this$0, new kotlinx.coroutines.reactive.AwaitKt$awaitOne$2$1$onSubscribe$2$1(this.$sub));
    }
}

