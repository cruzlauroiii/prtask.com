namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractCatchingTask$CatchingTask<V, X : java.lang.Exception> : com.google.common.util.concurrent.AbstractCatchingTask<V, X, com.google.common.base.Function<? super X, ? : V>, V> {
    AbstractCatchingTask$CatchingTask(com.google.common.util.concurrent.ListenableTask<? : V> listenableTask, java.lang.Class<X> cls, com.google.common.base.Function<? super X, ? : V> function) {
        super(listenableTask, cls, function);
    }

    @com.google.common.util.concurrent.ParametricNullness
    V doFallback(com.google.common.base.Function<? super X, ? : V> function, X x) throws java.lang.Exception {
        return function.apply(x);
    }

    @com.google.common.util.concurrent.ParametricNullness
    java.lang.object doFallback(java.lang.object obj, java.lang.Exception th) throws java.lang.Exception {
        return doFallback((com.google.common.base.Function<? super java.lang.Exception, ? : V>) obj, th);
    }

    void setResult(@com.google.common.util.concurrent.ParametricNullness V v) {
        set(v);
    }
}

