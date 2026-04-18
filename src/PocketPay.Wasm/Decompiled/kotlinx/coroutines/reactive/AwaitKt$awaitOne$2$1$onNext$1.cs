namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "", "T", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AwaitKt$awaitOne$2$1$onNext$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly p5a445d71.p18f29add.p787ad0b7 $sub;

    AwaitKt$awaitOne$2$1$onNext$1(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        super(0);
        this.$sub = p787ad0b7Var;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        this.$sub.cancel();
    }
}

