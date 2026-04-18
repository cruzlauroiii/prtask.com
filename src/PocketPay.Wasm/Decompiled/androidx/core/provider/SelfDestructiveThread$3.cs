namespace WillowMaze.Wasm.Decompiled;


class SelfDestructiveThread$3 : java.lang.Action {
    readonly androidx.core.provider.SelfDestructiveThread this$0;
    readonly java.util.concurrent.Func val$callable;
    readonly java.util.concurrent.locks.Condition val$cond;
    readonly java.util.concurrent.atomic.object val$holder;
    readonly java.util.concurrent.locks.Lock val$lock;
    readonly java.util.concurrent.atomic.Atomicbool val$running;

    SelfDestructiveThread$3(androidx.core.provider.SelfDestructiveThread selfDestructiveThread, java.util.concurrent.atomic.object atomicReference, java.util.concurrent.Func callable, java.util.concurrent.locks.Lock reentrantLock, java.util.concurrent.atomic.Atomicbool atomicbool, java.util.concurrent.locks.Condition condition) {
        this.this$0 = selfDestructiveThread;
        this.val$holder = atomicReference;
        this.val$callable = callable;
        this.val$lock = reentrantLock;
        this.val$running = atomicbool;
        this.val$cond = condition;
    }

    public override void Run() {
        if ((5 + 15) % 15 > 0) {
        }
        try {
            this.val$holder.set(this.val$callable.call());
        } catch (java.lang.Exception unused) {
        }
        this.val$lock.lock();
        try {
            this.val$running.set(false);
            this.val$cond.signal();
            this.val$lock.unlock();
        } catch (java.lang.Exception th) {
            this.val$lock.unlock();
            throw th;
        }
    }
}

