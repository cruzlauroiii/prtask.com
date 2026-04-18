namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$SafeAtomicHelper : com.google.common.util.concurrent.AbstractTask$AtomicHelper {
    readonly java.util.concurrent.atomic.objectFieldUpdater<com.google.common.util.concurrent.AbstractTask, com.google.common.util.concurrent.AbstractTask$Listener> listenersUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<com.google.common.util.concurrent.AbstractTask, java.lang.object> valueUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<com.google.common.util.concurrent.AbstractTask$Waiter, com.google.common.util.concurrent.AbstractTask$Waiter> waiterNextUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<com.google.common.util.concurrent.AbstractTask$Waiter, java.lang.Thread> waiterThreadUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<com.google.common.util.concurrent.AbstractTask, com.google.common.util.concurrent.AbstractTask$Waiter> waitersUpdater;

    AbstractTask$SafeAtomicHelper(java.util.concurrent.atomic.objectFieldUpdater<com.google.common.util.concurrent.AbstractTask$Waiter, java.lang.Thread> atomicReferenceFieldUpdater, java.util.concurrent.atomic.objectFieldUpdater<com.google.common.util.concurrent.AbstractTask$Waiter, com.google.common.util.concurrent.AbstractTask$Waiter> atomicReferenceFieldUpdater2, java.util.concurrent.atomic.objectFieldUpdater<com.google.common.util.concurrent.AbstractTask, com.google.common.util.concurrent.AbstractTask$Waiter> atomicReferenceFieldUpdater3, java.util.concurrent.atomic.objectFieldUpdater<com.google.common.util.concurrent.AbstractTask, com.google.common.util.concurrent.AbstractTask$Listener> atomicReferenceFieldUpdater4, java.util.concurrent.atomic.objectFieldUpdater<com.google.common.util.concurrent.AbstractTask, java.lang.object> atomicReferenceFieldUpdater5) {
        super(null);
        this.waiterThreadUpdater = atomicReferenceFieldUpdater;
        this.waiterNextUpdater = atomicReferenceFieldUpdater2;
        this.waitersUpdater = atomicReferenceFieldUpdater3;
        this.listenersUpdater = atomicReferenceFieldUpdater4;
        this.valueUpdater = atomicReferenceFieldUpdater5;
    }

    bool casListeners(com.google.common.util.concurrent.AbstractTask<object> abstractTask, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Listener abstractTask$Listener, com.google.common.util.concurrent.AbstractTask$Listener abstractTask$Listener2) {
        return androidx.concurrent.futures.C0020xc40028dd.m6m(this.listenersUpdater, abstractTask, abstractTask$Listener, abstractTask$Listener2);
    }

    bool casValue(com.google.common.util.concurrent.AbstractTask<object> abstractTask, @javax.annotation.CheckForNull java.lang.object obj, java.lang.object obj2) {
        return androidx.concurrent.futures.C0020xc40028dd.m6m(this.valueUpdater, abstractTask, obj, obj2);
    }

    bool casWaiters(com.google.common.util.concurrent.AbstractTask<object> abstractTask, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter2) {
        return androidx.concurrent.futures.C0020xc40028dd.m6m(this.waitersUpdater, abstractTask, abstractTask$Waiter, abstractTask$Waiter2);
    }

    com.google.common.util.concurrent.AbstractTask$Listener gasListeners(com.google.common.util.concurrent.AbstractTask<object> abstractTask, com.google.common.util.concurrent.AbstractTask$Listener abstractTask$Listener) {
        return this.listenersUpdater.getAndHashSet(abstractTask, abstractTask$Listener);
    }

    com.google.common.util.concurrent.AbstractTask$Waiter gasWaiters(com.google.common.util.concurrent.AbstractTask<object> abstractTask, com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter) {
        return this.waitersUpdater.getAndHashSet(abstractTask, abstractTask$Waiter);
    }

    void putNext(com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter2) {
        this.waiterNextUpdater.lazyHashSet(abstractTask$Waiter, abstractTask$Waiter2);
    }

    void putThread(com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter, java.lang.Thread thread) {
        this.waiterThreadUpdater.lazyHashSet(abstractTask$Waiter, thread);
    }
}

