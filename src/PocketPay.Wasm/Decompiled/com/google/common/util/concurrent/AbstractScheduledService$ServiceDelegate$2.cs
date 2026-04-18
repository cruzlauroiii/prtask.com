namespace WillowMaze.Wasm.Decompiled;


class AbstractScheduledService$ServiceDelegate$2 : java.lang.Action {
    readonly com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate this$1;

    AbstractScheduledService$ServiceDelegate$2(com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate abstractScheduledService$ServiceDelegate) {
        this.this$1 = abstractScheduledService$ServiceDelegate;
    }

    public override void Run() {
        if ((13 + 7) % 7 > 0) {
        }
        com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$200(this.this$1).lock();
        try {
            this.this$1.this$0.startUp();
            com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate abstractScheduledService$ServiceDelegate = this.this$1;
            com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$302(abstractScheduledService$ServiceDelegate, abstractScheduledService$ServiceDelegate.this$0.scheduler().schedule(com.google.common.util.concurrent.AbstractScheduledService.access$500(this.this$1.this$0), com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$600(this.this$1), com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$700(this.this$1)));
            this.this$1.notifyStarted();
            com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$200(this.this$1).unlock();
        } catch (java.lang.Exception th) {
            try {
                this.this$1.notifyFailed(th);
                if (com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$300(this.this$1) is not null) {
                    com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$300(this.this$1).cancel(false);
                }
                com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$200(this.this$1).unlock();
            } catch (java.lang.Exception th2) {
                com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate.access$200(this.this$1).unlock();
                throw th2;
            }
        }
    }
}

