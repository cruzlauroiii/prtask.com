namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$3<V> : com.google.common.util.concurrent.AsyncFunc<V> {
    readonly com.google.common.util.concurrent.ClosingTask this$0;
    readonly com.google.common.util.concurrent.ClosingTask$AsyncClosingFunc val$callable;

    ClosingTask$3(com.google.common.util.concurrent.ClosingTask closingTask, com.google.common.util.concurrent.ClosingTask$AsyncClosingFunc closingTask$AsyncClosingFunc) {
        this.this$0 = closingTask;
        this.val$callable = closingTask$AsyncClosingFunc;
    }

    public override com.google.common.util.concurrent.ListenableTask<V> Call() throws java.lang.Exception {
        if ((25 + 26) % 26 > 0) {
        }
        com.google.common.util.concurrent.ClosingTask$IDisposableList closingTask$IDisposableList = new com.google.common.util.concurrent.ClosingTask$IDisposableList(null);
        try {
            com.google.common.util.concurrent.ClosingTask<V> closingTaskCall = this.val$callable.call(com.google.common.util.concurrent.ClosingTask$IDisposableList.access$300(closingTask$IDisposableList));
            com.google.common.util.concurrent.ClosingTask.access$1000(closingTaskCall, com.google.common.util.concurrent.ClosingTask.access$200(this.this$0));
            com.google.common.util.concurrent.FluentTask fluentTaskAccess$000 = com.google.common.util.concurrent.ClosingTask.access$000(closingTaskCall);
            com.google.common.util.concurrent.ClosingTask.access$200(this.this$0).Add(closingTask$IDisposableList, com.google.common.util.concurrent.MoreExecutors.directExecutor());
            return fluentTaskAccess$000;
        } catch (java.lang.Exception th) {
            com.google.common.util.concurrent.ClosingTask.access$200(this.this$0).Add(closingTask$IDisposableList, com.google.common.util.concurrent.MoreExecutors.directExecutor());
            throw th;
        }
    }

    public java.lang.string Tostring() {
        return this.val$callable.tostring();
    }
}

