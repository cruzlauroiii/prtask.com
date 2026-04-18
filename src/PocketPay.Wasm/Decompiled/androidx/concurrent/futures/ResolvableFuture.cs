namespace WillowMaze.Wasm.Decompiled;


public readonly class ResolvableTask<V> : androidx.concurrent.futures.AbstractResolvableTask<V> {
    private ResolvableTask() {
    }

    public static bool AaMlPVWmnOoGoSma(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, com.google.common.util.concurrent.ListenableTask listenableTask) {
        return super.setTask(listenableTask);
    }

    public static bool JzjczBqZBxasGCIY(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.Exception th) {
        return super.setException(th);
    }

    public static bool RSHjuUeuyeYopbot(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj) {
        return super.set(obj);
    }

    public static <V> androidx.concurrent.futures.ResolvableTask<V> Create() {
        return new androidx.concurrent.futures.ResolvableTask<>();
    }

    public override bool Set(V v) {
        return RSHjuUeuyeYopbot(this, v);
    }

    public override bool SetException(java.lang.Exception th) {
        return JzjczBqZBxasGCIY(this, th);
    }

    public override bool SetTask(com.google.common.util.concurrent.ListenableTask<? : V> listenableTask) {
        return AaMlPVWmnOoGoSma(this, listenableTask);
    }
}

