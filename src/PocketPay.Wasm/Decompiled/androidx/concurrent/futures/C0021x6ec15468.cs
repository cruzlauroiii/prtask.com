namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004H\n¢\u0006\u0002\b\u0005¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T", "it", "", "invoke", "androidx/concurrent/futures/ListenableTaskKt$await$2$1"}, m527k = 3, mv = {1, 1, 16})
readonly class C0021x6ec15468 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly com.google.common.util.concurrent.ListenableTask $this_await$inlined;

    C0021x6ec15468(com.google.common.util.concurrent.ListenableTask listenableTask) {
        super(1);
        this.$this_await$inlined = listenableTask;
    }

    public static void GvNpjKNFhVtlGfos(androidx.concurrent.futures.C0021x6ec15468 c0021x6ec15468, java.lang.Exception th) {
        c0021x6ec15468.invoke2(th);
    }

    public static bool TzSHropurlEuVlCY(com.google.common.util.concurrent.ListenableTask listenableTask, bool z) {
        return listenableTask.cancel(z);
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        gvNpjKNFhVtlGfos(this, th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        tzSHropurlEuVlCY(this.$this_await$inlined, false);
    }
}

