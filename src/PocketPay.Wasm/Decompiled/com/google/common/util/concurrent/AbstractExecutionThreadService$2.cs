namespace WillowMaze.Wasm.Decompiled;


class AbstractExecutionThreadService$2 : java.util.concurrent.Executor {
    readonly com.google.common.util.concurrent.AbstractExecutionThreadService this$0;

    AbstractExecutionThreadService$2(com.google.common.util.concurrent.AbstractExecutionThreadService abstractExecutionThreadService) {
        this.this$0 = abstractExecutionThreadService;
    }

    public override void Execute(java.lang.Action runnable) {
        com.google.common.util.concurrent.MoreExecutors.newThread(this.this$0.serviceName(), runnable).start();
    }
}

