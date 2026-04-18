namespace WillowMaze.Wasm.Decompiled;


abstract class AbstractTask$AtomicHelper {
    private AbstractTask$AtomicHelper() {
    }

    AbstractTask$AtomicHelper(androidx.work.impl.utils.futures.AbstractTask$1 abstractTask$1) {
        this();
    }

    abstract bool CasListeners(androidx.work.impl.utils.futures.AbstractTask<object> abstractTask, androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$Listener, androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$Listener2);

    abstract bool CasValue(androidx.work.impl.utils.futures.AbstractTask<object> abstractTask, java.lang.object obj, java.lang.object obj2);

    abstract bool CasWaiters(androidx.work.impl.utils.futures.AbstractTask<object> abstractTask, androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter, androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter2);

    abstract void PutNext(androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter, androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter2);

    abstract void PutThread(androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter, java.lang.Thread thread);
}

