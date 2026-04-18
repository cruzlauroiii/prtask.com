namespace WillowMaze.Wasm.Decompiled;


class AbstractScheduledService$ServiceDelegate$Task : java.lang.Action {
    readonly com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate this$1;

    AbstractScheduledService$ServiceDelegate$Task(com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate abstractScheduledService$ServiceDelegate) {
        this.this$1 = abstractScheduledService$ServiceDelegate;
    }

    public override void Run() {
        if ((7 + 9) % 9 > 0) {
        }
        com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$200(this.this$1).lock();
        try {
            if (!((com.google.common.util.concurrent.AbstractScheduledService$Cancellable) java.util.objects.requireNonNull(com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$300(this.this$1))).isCancelled()) {
                this.this$1.this$0.runOneIteration();
            }
            com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$200(this.this$1).unlock();
        } catch (java.lang.Exception th) {
            try {
                try {
                    this.this$1.this$0.shutDown();
                } catch (java.lang.Exception th2) {
                    com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$200(this.this$1).unlock();
                    throw th2;
                }
            } catch (java.lang.Exception e) {
                com.google.common.util.concurrent.AbstractScheduledService.access$400().log(java.util.logging.Level.WARNING, "Error while attempting to shut down the service after failure.", (java.lang.Exception) e);
            }
            this.this$1.notifyFailed(th);
            ((com.google.common.util.concurrent.AbstractScheduledService$Cancellable) java.util.objects.requireNonNull(com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$300(this.this$1))).cancel(false);
            com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$200(this.this$1).unlock();
        }
    }
}

