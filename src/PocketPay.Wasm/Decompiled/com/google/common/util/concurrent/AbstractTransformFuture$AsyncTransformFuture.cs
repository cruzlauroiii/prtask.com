namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTransformTask$AsyncTransformTask<I, O> : com.google.common.util.concurrent.AbstractTransformTask<I, O, com.google.common.util.concurrent.AsyncFunction<? super I, ? : O>, com.google.common.util.concurrent.ListenableTask<? : O>> {
    AbstractTransformTask$AsyncTransformTask(com.google.common.util.concurrent.ListenableTask<? : I> listenableTask, com.google.common.util.concurrent.AsyncFunction<? super I, ? : O> asyncFunction) {
        super(listenableTask, asyncFunction);
    }

    com.google.common.util.concurrent.ListenableTask<? : O> doTransform(com.google.common.util.concurrent.AsyncFunction<? super I, ? : O> asyncFunction, @com.google.common.util.concurrent.ParametricNullness I i) throws java.lang.Exception {
        com.google.common.util.concurrent.ListenableTask<? : O> listenableTaskApply = asyncFunction.apply(i);
        com.google.common.base.Preconditions.checkNotNull(listenableTaskApply, "AsyncFunction.apply returned null instead of a Task. Did you mean to return immediateTask(null)? %s", asyncFunction);
        return listenableTaskApply;
    }

    java.lang.object doTransform(java.lang.object obj, @com.google.common.util.concurrent.ParametricNullness java.lang.object obj2) throws java.lang.Exception {
        return doTransform((com.google.common.util.concurrent.AsyncFunction<? super java.lang.object, ? : O>) obj, obj2);
    }

    void setResult(com.google.common.util.concurrent.ListenableTask<? : O> listenableTask) {
        setTask(listenableTask);
    }

    void setResult(java.lang.object obj) {
        setResult((com.google.common.util.concurrent.ListenableTask) obj);
    }
}

