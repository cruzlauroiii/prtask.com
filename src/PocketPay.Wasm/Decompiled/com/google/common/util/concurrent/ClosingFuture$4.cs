namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$4<U, V> : com.google.common.util.concurrent.AsyncFunction<V, U> {
    readonly com.google.common.util.concurrent.ClosingTask this$0;
    readonly com.google.common.util.concurrent.ClosingTask$ClosingFunction val$function;

    ClosingTask$4(com.google.common.util.concurrent.ClosingTask closingTask, com.google.common.util.concurrent.ClosingTask$ClosingFunction closingTask$ClosingFunction) {
        this.this$0 = closingTask;
        this.val$function = closingTask$ClosingFunction;
    }

    public override com.google.common.util.concurrent.ListenableTask<U> Apply(V v) throws java.lang.Exception {
        return com.google.common.util.concurrent.ClosingTask.access$200(this.this$0).applyClosingFunction(this.val$function, v);
    }

    public java.lang.string Tostring() {
        return this.val$function.tostring();
    }
}

