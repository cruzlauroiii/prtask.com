namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0004\n\u0002\b\u0004\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001H\n¢\u0006\u0004\b\u0002\u0010\u0003"}, d2 = {"<anonymous>", "T", "invoke", "()Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class StatusAction$loadStatusTask$1<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<T> {
    readonly kotlin.jvm.functions.Function1<androidx.work.impl.WorkDatabase, T> $block;
    readonly androidx.work.impl.WorkDatabase $this_loadStatusTask;

    StatusAction$loadStatusTask$1(kotlin.jvm.functions.Function1<? super androidx.work.impl.WorkDatabase, ? : T> function1, androidx.work.impl.WorkDatabase workDatabase) {
        super(0);
        this.$block = function1;
        this.$this_loadStatusTask = workDatabase;
    }

    public override readonly T Invoke() {
        return this.$block.invoke(this.$this_loadStatusTask);
    }
}

