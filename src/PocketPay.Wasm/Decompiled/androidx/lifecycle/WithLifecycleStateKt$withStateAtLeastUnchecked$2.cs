namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 176)
public readonly class WithLifecycleStateKt$withStateAtLeastUnchecked$2<R> : kotlin.jvm.functions.Function0<R> {
    readonly kotlin.jvm.functions.Function0<R> $block;

    public WithLifecycleStateKt$withStateAtLeastUnchecked$2(kotlin.jvm.functions.Function0<? : R> function0) {
        this.$block = function0;
    }

    public override readonly R Invoke() {
        return this.$block.invoke();
    }
}

