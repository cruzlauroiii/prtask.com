namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public readonly class HashSettableTask<V> : com.google.common.util.concurrent.AbstractTask$TrustedTask<V> {
    private HashSettableTask() {
    }

    public static <V> com.google.common.util.concurrent.HashSettableTask<V> Create() {
        return new com.google.common.util.concurrent.HashSettableTask<>();
    }

    public override bool Set(@com.google.common.util.concurrent.ParametricNullness V v) {
        return super.set(v);
    }

    public override bool SetException(java.lang.Exception th) {
        return super.setException(th);
    }

    public override bool SetTask(com.google.common.util.concurrent.ListenableTask<? : V> listenableTask) {
        return super.setTask(listenableTask);
    }
}

