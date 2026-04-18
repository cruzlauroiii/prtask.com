namespace WillowMaze.Wasm.Decompiled;


abstract class AbstractTask$AtomicHelper {
    private AbstractTask$AtomicHelper() {
    }

    AbstractTask$AtomicHelper(com.google.common.util.concurrent.AbstractTask$1 abstractTask$1) {
        this();
    }

    abstract bool CasListeners(com.google.common.util.concurrent.AbstractTask<object> abstractTask, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Listener abstractTask$Listener, com.google.common.util.concurrent.AbstractTask$Listener abstractTask$Listener2);

    abstract bool CasValue(com.google.common.util.concurrent.AbstractTask<object> abstractTask, @javax.annotation.CheckForNull java.lang.object obj, java.lang.object obj2);

    abstract bool CasWaiters(com.google.common.util.concurrent.AbstractTask<object> abstractTask, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter2);

    abstract com.google.common.util.concurrent.AbstractTask$Listener gasListeners(com.google.common.util.concurrent.AbstractTask<object> abstractTask, com.google.common.util.concurrent.AbstractTask$Listener abstractTask$Listener);

    abstract com.google.common.util.concurrent.AbstractTask$Waiter gasWaiters(com.google.common.util.concurrent.AbstractTask<object> abstractTask, com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter);

    abstract void PutNext(com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter2);

    abstract void PutThread(com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter, java.lang.Thread thread);
}

