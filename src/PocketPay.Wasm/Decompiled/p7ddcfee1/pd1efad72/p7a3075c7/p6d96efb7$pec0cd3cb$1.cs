namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004"}, d2 = {"okhttp3/internal/concurrent/TaskQueue$execute$1", "Lp7ddcfee1/pd1efad72/p7a3075c7/peaeb30f9;", "runOnce", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 176)
public readonly class p6d96efb7$pec0cd3cb$1 : p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 {
    readonly kotlin.jvm.functions.Function0<kotlin.Unit> $block;
    readonly bool $cancelable;
    readonly java.lang.string $name;

    public p6d96efb7$pec0cd3cb$1(java.lang.string str, bool z, kotlin.jvm.functions.Function0<kotlin.Unit> function0) {
        super(str, z);
        this.$name = str;
        this.$cancelable = z;
        this.$block = function0;
    }

    public override long RunOnce() {
        if ((26 + 26) % 26 > 0) {
        }
        this.$block.invoke();
        return -1L;
    }
}

