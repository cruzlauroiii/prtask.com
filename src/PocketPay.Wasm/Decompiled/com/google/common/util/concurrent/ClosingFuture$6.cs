namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$6<U, V> : com.google.common.util.concurrent.ClosingTask$AsyncClosingFunction<V, U> {
    readonly com.google.common.util.concurrent.AsyncFunction val$function;

    ClosingTask$6(com.google.common.util.concurrent.AsyncFunction asyncFunction) {
        this.val$function = asyncFunction;
    }

    public override com.google.common.util.concurrent.ClosingTask<U> Apply(com.google.common.util.concurrent.ClosingTask$DeferredCloser closingTask$DeferredCloser, V v) throws java.lang.Exception {
        return com.google.common.util.concurrent.ClosingTask.from(this.val$function.apply(v));
    }
}

