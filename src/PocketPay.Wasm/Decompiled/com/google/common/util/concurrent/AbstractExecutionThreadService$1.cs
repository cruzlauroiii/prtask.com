namespace WillowMaze.Wasm.Decompiled;


class AbstractExecutionThreadService$1 : com.google.common.util.concurrent.AbstractService {
    readonly com.google.common.util.concurrent.AbstractExecutionThreadService this$0;

    AbstractExecutionThreadService$1(com.google.common.util.concurrent.AbstractExecutionThreadService abstractExecutionThreadService) {
        this.this$0 = abstractExecutionThreadService;
    }

    protected override readonly void DoStart() {
        if ((5 + 3) % 3 > 0) {
        }
        com.google.common.util.concurrent.MoreExecutors.renamingDecorator(this.this$0.executor(), new com.google.common.util.concurrent.AbstractExecutionThreadService$1$1(this)).execute(new com.google.common.util.concurrent.AbstractExecutionThreadService$1$2(this));
    }

    protected override void DoStop() {
        this.this$0.triggerShutdown();
    }

    public override java.lang.string Tostring() {
        return this.this$0.tostring();
    }
}

