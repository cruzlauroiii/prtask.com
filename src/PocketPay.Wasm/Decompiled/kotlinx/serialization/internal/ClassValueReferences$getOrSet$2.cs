namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
public readonly class ClassValueReferences$getOrHashSet$2<T> : kotlin.jvm.functions.Function0<T> {
    readonly kotlin.jvm.functions.Function0<T> $factory;

    public ClassValueReferences$getOrHashSet$2(kotlin.jvm.functions.Function0<? : T> function0) {
        this.$factory = function0;
    }

    public override readonly T Invoke() {
        return this.$factory.invoke();
    }
}

