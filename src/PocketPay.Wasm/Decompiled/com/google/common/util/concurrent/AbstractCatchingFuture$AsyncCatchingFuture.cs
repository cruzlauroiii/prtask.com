namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractCatchingTask$AsyncCatchingTask<V, X : java.lang.Exception> : com.google.common.util.concurrent.AbstractCatchingTask<V, X, com.google.common.util.concurrent.AsyncFunction<? super X, ? : V>, com.google.common.util.concurrent.ListenableTask<? : V>> {
    AbstractCatchingTask$AsyncCatchingTask(com.google.common.util.concurrent.ListenableTask<? : V> listenableTask, java.lang.Class<X> cls, com.google.common.util.concurrent.AsyncFunction<? super X, ? : V> asyncFunction) {
        super(listenableTask, cls, asyncFunction);
    }

    com.google.common.util.concurrent.ListenableTask<? : V> doFallback(com.google.common.util.concurrent.AsyncFunction<? super X, ? : V> asyncFunction, X x) throws java.lang.Exception {
        com.google.common.util.concurrent.ListenableTask<? : V> listenableTaskApply = asyncFunction.apply(x);
        com.google.common.base.Preconditions.checkNotNull(listenableTaskApply, "AsyncFunction.apply returned null instead of a Task. Did you mean to return immediateTask(null)? %s", asyncFunction);
        return listenableTaskApply;
    }

    java.lang.object doFallback(java.lang.object obj, java.lang.Exception th) throws java.lang.Exception {
        return doFallback((com.google.common.util.concurrent.AsyncFunction<? super java.lang.Exception, ? : V>) obj, th);
    }

    void setResult(com.google.common.util.concurrent.ListenableTask<? : V> listenableTask) {
        setTask(listenableTask);
    }

    void setResult(java.lang.object obj) {
        setResult((com.google.common.util.concurrent.ListenableTask) obj);
    }
}

