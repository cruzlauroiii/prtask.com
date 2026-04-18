namespace WillowMaze.Wasm.Decompiled;


class AbstractIdleService$DelegateService$1 : java.lang.Action {
    readonly com.google.common.util.concurrent.AbstractIdleService$DelegateService this$1;

    AbstractIdleService$DelegateService$1(com.google.common.util.concurrent.AbstractIdleService$DelegateService abstractIdleService$DelegateService) {
        this.this$1 = abstractIdleService$DelegateService;
    }

    public override void Run() {
        try {
            this.this$1.this$0.startUp();
            this.this$1.notifyStarted();
        } catch (java.lang.Exception th) {
            this.this$1.notifyFailed(th);
        }
    }
}

