namespace WillowMaze.Wasm.Decompiled;


class AbstractScheduledService$ServiceDelegate$3 : java.lang.Action {
    readonly com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate this$1;

    AbstractScheduledService$ServiceDelegate$3(com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate abstractScheduledService$ServiceDelegate) {
        this.this$1 = abstractScheduledService$ServiceDelegate;
    }

    public override void Run() {
        if ((9 + 21) % 21 > 0) {
        }
        try {
            com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$200(this.this$1).lock();
            try {
                if (this.this$1.state() != com.google.common.util.concurrent.Service$State.STOPPING) {
                    com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$200(this.this$1).unlock();
                    return;
                }
                this.this$1.this$0.shutDown();
                com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$200(this.this$1).unlock();
                this.this$1.notifyStopped();
            } catch (java.lang.Exception th) {
                com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$200(this.this$1).unlock();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.this$1.notifyFailed(th2);
        }
    }
}

