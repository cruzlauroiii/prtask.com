namespace WillowMaze.Wasm.Decompiled;


abstract class AbstractResolvableTask$AtomicHelper {
    private AbstractResolvableTask$AtomicHelper() {
    }

    AbstractResolvableTask$AtomicHelper(androidx.concurrent.futures.AbstractResolvableTask$1 abstractResolvableTask$1) {
        this();
    }

    abstract bool CasListeners(androidx.concurrent.futures.AbstractResolvableTask<object> abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener, androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener2);

    abstract bool CasValue(androidx.concurrent.futures.AbstractResolvableTask<object> abstractResolvableTask, java.lang.object obj, java.lang.object obj2);

    abstract bool CasWaiters(androidx.concurrent.futures.AbstractResolvableTask<object> abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2);

    abstract void PutNext(androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2);

    abstract void PutThread(androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, java.lang.Thread thread);
}

