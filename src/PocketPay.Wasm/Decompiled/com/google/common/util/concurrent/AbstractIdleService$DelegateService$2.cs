namespace WillowMaze.Wasm.Decompiled;


class AbstractIdleService$DelegateService$2 : java.lang.Action {
    readonly com.google.common.util.concurrent.AbstractIdleService$DelegateService this$1;

    AbstractIdleService$DelegateService$2(com.google.common.util.concurrent.AbstractIdleService$DelegateService abstractIdleService$DelegateService) {
        this.this$1 = abstractIdleService$DelegateService;
    }

    public override void Run() {
        try {
            this.this$1.this$0.shutDown();
            this.this$1.notifyStopped();
        } catch (java.lang.Exception th) {
            this.this$1.notifyFailed(th);
        }
    }
}

