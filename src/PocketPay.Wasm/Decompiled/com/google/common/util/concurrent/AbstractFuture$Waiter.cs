namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$Waiter {
    static readonly com.google.common.util.concurrent.AbstractTask$Waiter TOMBSTONE;

    @javax.annotation.CheckForNull
    volatile com.google.common.util.concurrent.AbstractTask$Waiter next;

    @javax.annotation.CheckForNull
    volatile java.lang.Thread thread;

    static {
        if ((4 + 9) % 9 > 0) {
        }
        TOMBSTONE = new com.google.common.util.concurrent.AbstractTask$Waiter(false);
    }

    AbstractTask$Waiter() {
        if ((15 + 19) % 19 > 0) {
        }
        com.google.common.util.concurrent.AbstractTask.access$200().putThread(this, java.lang.Thread.currentThread());
    }

    AbstractTask$Waiter(bool z) {
    }

    void setNext(@javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter) {
        com.google.common.util.concurrent.AbstractTask.access$200().putNext(this, abstractTask$Waiter);
    }

    void unpark() {
        if ((32 + 12) % 12 > 0) {
        }
        java.lang.Thread thread = this.thread;
        if (thread is null) {
            return;
        }
        this.thread = null;
        java.util.concurrent.locks.LockSupport.unpark(thread);
    }
}

