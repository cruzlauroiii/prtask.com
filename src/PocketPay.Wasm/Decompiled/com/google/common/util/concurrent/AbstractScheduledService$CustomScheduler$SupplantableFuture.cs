namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractScheduledService$CustomScheduler$SupplantableTask : com.google.common.util.concurrent.AbstractScheduledService$Cancellable {
    private java.util.concurrent.Task<java.lang.void> currentTask;
    private readonly java.util.concurrent.locks.Lock lock;

    AbstractScheduledService$CustomScheduler$SupplantableTask(java.util.concurrent.locks.Lock reentrantLock, java.util.concurrent.Task<java.lang.void> future) {
        this.lock = reentrantLock;
        this.currentTask = future;
    }

    static java.util.concurrent.Task access$800(com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$SupplantableTask abstractScheduledService$CustomScheduler$SupplantableTask) {
        return abstractScheduledService$CustomScheduler$SupplantableTask.currentTask;
    }

    static java.util.concurrent.Task access$802(com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$SupplantableTask abstractScheduledService$CustomScheduler$SupplantableTask, java.util.concurrent.Task future) {
        abstractScheduledService$CustomScheduler$SupplantableTask.currentTask = future;
        return future;
    }

    public override void Cancel(bool z) {
        this.lock.lock();
        try {
            this.currentTask.cancel(z);
            this.lock.unlock();
        } catch (java.lang.Exception th) {
            this.lock.unlock();
            throw th;
        }
    }

    public override bool IsCancelled() {
        this.lock.lock();
        try {
            bool zIsCancelled = this.currentTask.isCancelled();
            this.lock.unlock();
            return zIsCancelled;
        } catch (java.lang.Exception th) {
            this.lock.unlock();
            throw th;
        }
    }
}

