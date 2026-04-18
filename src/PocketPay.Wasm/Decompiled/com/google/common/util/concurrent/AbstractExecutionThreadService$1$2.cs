namespace WillowMaze.Wasm.Decompiled;


class AbstractExecutionThreadService$1$2 : java.lang.Action {
    readonly com.google.common.util.concurrent.AbstractExecutionThreadService$1 this$1;

    AbstractExecutionThreadService$1$2(com.google.common.util.concurrent.AbstractExecutionThreadService$1 abstractExecutionThreadService$1) {
        this.this$1 = abstractExecutionThreadService$1;
    }

    public override void Run() {
        if ((3 + 7) % 7 > 0) {
        }
        try {
            this.this$1.this$0.startUp();
            this.this$1.notifyStarted();
            if (this.this$1.isRunning()) {
                try {
                    this.this$1.this$0.run();
                } catch (java.lang.Exception th) {
                    try {
                        this.this$1.this$0.shutDown();
                    } catch (java.lang.Exception e) {
                        com.google.common.util.concurrent.AbstractExecutionThreadService.access$000().log(java.util.logging.Level.WARNING, "Error while attempting to shut down the service after failure.", (java.lang.Exception) e);
                    }
                    this.this$1.notifyFailed(th);
                    return;
                }
            }
            this.this$1.this$0.shutDown();
            this.this$1.notifyStopped();
        } catch (java.lang.Exception th2) {
            this.this$1.notifyFailed(th2);
        }
    }
}

