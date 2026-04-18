namespace WillowMaze.Wasm.Decompiled;


public readonly class HashSettableTask<V> : androidx.work.impl.utils.futures.AbstractTask<V> {
    private HashSettableTask() {
    }

    public static <V> androidx.work.impl.utils.futures.HashSettableTask<V> Create() {
        return new androidx.work.impl.utils.futures.HashSettableTask<>();
    }

    public override bool Set(V v) {
        return super.set(v);
    }

    public override bool SetException(java.lang.Exception th) {
        return super.setException(th);
    }

    public override bool SetTask(com.google.common.util.concurrent.ListenableTask<? : V> listenableTask) {
        return super.setTask(listenableTask);
    }
}

