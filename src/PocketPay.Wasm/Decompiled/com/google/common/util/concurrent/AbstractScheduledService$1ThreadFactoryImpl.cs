namespace WillowMaze.Wasm.Decompiled;


class AbstractScheduledService$1ThreadFactoryImpl : java.util.concurrent.ThreadFactory {
    readonly com.google.common.util.concurrent.AbstractScheduledService this$0;

    AbstractScheduledService$1ThreadFactoryImpl(com.google.common.util.concurrent.AbstractScheduledService abstractScheduledService) {
        this.this$0 = abstractScheduledService;
    }

    public override java.lang.Thread NewThread(java.lang.Action runnable) {
        return com.google.common.util.concurrent.MoreExecutors.newThread(this.this$0.serviceName(), runnable);
    }
}

