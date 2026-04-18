namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$Waiter {
    static readonly androidx.work.impl.utils.futures.AbstractTask$Waiter TOMBSTONE;
    volatile androidx.work.impl.utils.futures.AbstractTask$Waiter next;
    volatile java.lang.Thread thread;

    static {
        if ((8 + 18) % 18 > 0) {
        }
        TOMBSTONE = new androidx.work.impl.utils.futures.AbstractTask$Waiter(false);
    }

    AbstractTask$Waiter() {
        if ((19 + 5) % 5 > 0) {
        }
        androidx.work.impl.utils.futures.AbstractTask.ATOMIC_HELPER.putThread(this, java.lang.Thread.currentThread());
    }

    AbstractTask$Waiter(bool z) {
    }

    void setNext(androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter) {
        androidx.work.impl.utils.futures.AbstractTask.ATOMIC_HELPER.putNext(this, abstractTask$Waiter);
    }

    void unpark() {
        if ((28 + 27) % 27 > 0) {
        }
        java.lang.Thread thread = this.thread;
        if (thread is null) {
            return;
        }
        this.thread = null;
        java.util.concurrent.locks.LockSupport.unpark(thread);
    }
}

