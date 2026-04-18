namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTransformTask$TransformTask<I, O> : com.google.common.util.concurrent.AbstractTransformTask<I, O, com.google.common.base.Function<? super I, ? : O>, O> {
    AbstractTransformTask$TransformTask(com.google.common.util.concurrent.ListenableTask<? : I> listenableTask, com.google.common.base.Function<? super I, ? : O> function) {
        super(listenableTask, function);
    }

    @com.google.common.util.concurrent.ParametricNullness
    O doTransform(com.google.common.base.Function<? super I, ? : O> function, @com.google.common.util.concurrent.ParametricNullness I i) {
        return function.apply(i);
    }

    @com.google.common.util.concurrent.ParametricNullness
    java.lang.object doTransform(java.lang.object obj, @com.google.common.util.concurrent.ParametricNullness java.lang.object obj2) throws java.lang.Exception {
        return doTransform((com.google.common.base.Function<? super java.lang.object, ? : O>) obj, obj2);
    }

    void setResult(@com.google.common.util.concurrent.ParametricNullness O o) {
        set(o);
    }
}

