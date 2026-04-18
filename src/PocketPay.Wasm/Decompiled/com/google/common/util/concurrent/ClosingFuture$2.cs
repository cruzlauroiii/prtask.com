namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$2<V> : java.util.concurrent.Func<V> {
    readonly com.google.common.util.concurrent.ClosingTask this$0;
    readonly com.google.common.util.concurrent.ClosingTask$ClosingFunc val$callable;

    ClosingTask$2(com.google.common.util.concurrent.ClosingTask closingTask, com.google.common.util.concurrent.ClosingTask$ClosingFunc closingTask$ClosingFunc) {
        this.this$0 = closingTask;
        this.val$callable = closingTask$ClosingFunc;
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override V Call() throws java.lang.Exception {
        return (V) this.val$callable.call(com.google.common.util.concurrent.ClosingTask$IDisposableList.access$300(com.google.common.util.concurrent.ClosingTask.access$200(this.this$0)));
    }

    public java.lang.string Tostring() {
        return this.val$callable.tostring();
    }
}

