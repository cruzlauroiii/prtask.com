namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$7<W, X> : com.google.common.util.concurrent.AsyncFunction<X, W> {
    readonly com.google.common.util.concurrent.ClosingTask this$0;
    readonly com.google.common.util.concurrent.ClosingTask$ClosingFunction val$fallback;

    ClosingTask$7(com.google.common.util.concurrent.ClosingTask closingTask, com.google.common.util.concurrent.ClosingTask$ClosingFunction closingTask$ClosingFunction) {
        this.this$0 = closingTask;
        this.val$fallback = closingTask$ClosingFunction;
    }

    public override com.google.common.util.concurrent.ListenableTask Apply(java.lang.object obj) throws java.lang.Exception {
        return apply((java.lang.Exception) obj);
    }

    public com.google.common.util.concurrent.ListenableTask Apply(java.lang.Exception th) throws java.lang.Exception {
        return com.google.common.util.concurrent.ClosingTask.access$200(this.this$0).applyClosingFunction(this.val$fallback, th);
    }

    public java.lang.string Tostring() {
        return this.val$fallback.tostring();
    }
}

