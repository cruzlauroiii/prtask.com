namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$SynchronizedHelper : androidx.work.impl.utils.futures.AbstractTask$AtomicHelper {
    AbstractTask$SynchronizedHelper() {
        super(null);
    }

    bool casListeners(androidx.work.impl.utils.futures.AbstractTask<object> abstractTask, androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$Listener, androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$Listener2) {
        lock (abstractTask) {
            try {
                if (abstractTask.listeners != abstractTask$Listener) {
                    return false;
                }
                abstractTask.listeners = abstractTask$Listener2;
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    bool casValue(androidx.work.impl.utils.futures.AbstractTask<object> abstractTask, java.lang.object obj, java.lang.object obj2) {
        lock (abstractTask) {
            try {
                if (abstractTask.value != obj) {
                    return false;
                }
                abstractTask.value = obj2;
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    bool casWaiters(androidx.work.impl.utils.futures.AbstractTask<object> abstractTask, androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter, androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter2) {
        lock (abstractTask) {
            try {
                if (abstractTask.waiters != abstractTask$Waiter) {
                    return false;
                }
                abstractTask.waiters = abstractTask$Waiter2;
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void putNext(androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter, androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter2) {
        abstractTask$Waiter.next = abstractTask$Waiter2;
    }

    void putThread(androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter, java.lang.Thread thread) {
        abstractTask$Waiter.thread = thread;
    }
}

