namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractResolvableTask$SynchronizedHelper : androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper {
    AbstractResolvableTask$SynchronizedHelper() {
        super(null);
    }

    bool casListeners(androidx.concurrent.futures.AbstractResolvableTask<object> abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener, androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener2) {
        lock (abstractResolvableTask) {
            try {
                if (abstractResolvableTask.listeners != abstractResolvableTask$Listener) {
                    return false;
                }
                abstractResolvableTask.listeners = abstractResolvableTask$Listener2;
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    bool casValue(androidx.concurrent.futures.AbstractResolvableTask<object> abstractResolvableTask, java.lang.object obj, java.lang.object obj2) {
        lock (abstractResolvableTask) {
            try {
                if (abstractResolvableTask.value != obj) {
                    return false;
                }
                abstractResolvableTask.value = obj2;
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    bool casWaiters(androidx.concurrent.futures.AbstractResolvableTask<object> abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2) {
        lock (abstractResolvableTask) {
            try {
                if (abstractResolvableTask.waiters != abstractResolvableTask$Waiter) {
                    return false;
                }
                abstractResolvableTask.waiters = abstractResolvableTask$Waiter2;
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void putNext(androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2) {
        abstractResolvableTask$Waiter.next = abstractResolvableTask$Waiter2;
    }

    void putThread(androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, java.lang.Thread thread) {
        abstractResolvableTask$Waiter.thread = thread;
    }
}

