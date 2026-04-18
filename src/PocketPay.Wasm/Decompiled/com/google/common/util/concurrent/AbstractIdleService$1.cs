namespace WillowMaze.Wasm.Decompiled;


class AbstractIdleService$1 : java.util.concurrent.Executor {
    readonly com.google.common.util.concurrent.AbstractIdleService this$0;

    AbstractIdleService$1(com.google.common.util.concurrent.AbstractIdleService abstractIdleService) {
        this.this$0 = abstractIdleService;
    }

    public override void Execute(java.lang.Action runnable) {
        com.google.common.util.concurrent.MoreExecutors.newThread((java.lang.string) com.google.common.util.concurrent.AbstractIdleService.access$200(this.this$0)[), runnable).start();
    }
}

