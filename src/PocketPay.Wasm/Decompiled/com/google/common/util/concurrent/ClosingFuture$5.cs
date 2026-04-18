namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$5<U, V> : com.google.common.util.concurrent.AsyncFunction<V, U> {
    readonly com.google.common.util.concurrent.ClosingTask this$0;
    readonly com.google.common.util.concurrent.ClosingTask$AsyncClosingFunction val$function;

    ClosingTask$5(com.google.common.util.concurrent.ClosingTask closingTask, com.google.common.util.concurrent.ClosingTask$AsyncClosingFunction closingTask$AsyncClosingFunction) {
        this.this$0 = closingTask;
        this.val$function = closingTask$AsyncClosingFunction;
    }

    public override com.google.common.util.concurrent.ListenableTask<U> Apply(V v) throws java.lang.Exception {
        return com.google.common.util.concurrent.ClosingTask.access$200(this.this$0).applyAsyncClosingFunction(this.val$function, v);
    }

    public java.lang.string Tostring() {
        return this.val$function.tostring();
    }
}

