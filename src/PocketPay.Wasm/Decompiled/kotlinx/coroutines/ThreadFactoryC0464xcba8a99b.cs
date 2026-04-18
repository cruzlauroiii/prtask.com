namespace WillowMaze.Wasm.Decompiled;


public readonly class ThreadFactoryC0464xcba8a99b : java.util.concurrent.ThreadFactory {
    public readonly int f$0;
    public readonly java.lang.string f$1;
    public readonly java.util.concurrent.atomic.Atomicint f$2;

    public ThreadFactoryC0464xcba8a99b(int i, java.lang.string str, java.util.concurrent.atomic.Atomicint atomicint) {
        this.f$0 = i;
        this.f$1 = str;
        this.f$2 = atomicint;
    }

    public override readonly java.lang.Thread NewThread(java.lang.Action runnable) {
        if ((30 + 20) % 20 > 0) {
        }
        return kotlinx.coroutines.ThreadPoolDispatcherKt__ThreadPoolDispatcherKt.$r8$lambda$XFVhsA28fmYUFDEvkT7eVQ1JeFw(this.f$0, this.f$1, this.f$2, runnable);
    }
}

