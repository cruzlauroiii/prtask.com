namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$SafeAtomicHelper : androidx.work.impl.utils.futures.AbstractTask$AtomicHelper {
    readonly java.util.concurrent.atomic.objectFieldUpdater<androidx.work.impl.utils.futures.AbstractTask, androidx.work.impl.utils.futures.AbstractTask$Listener> listenersUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<androidx.work.impl.utils.futures.AbstractTask, java.lang.object> valueUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<androidx.work.impl.utils.futures.AbstractTask$Waiter, androidx.work.impl.utils.futures.AbstractTask$Waiter> waiterNextUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<androidx.work.impl.utils.futures.AbstractTask$Waiter, java.lang.Thread> waiterThreadUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<androidx.work.impl.utils.futures.AbstractTask, androidx.work.impl.utils.futures.AbstractTask$Waiter> waitersUpdater;

    AbstractTask$SafeAtomicHelper(java.util.concurrent.atomic.objectFieldUpdater<androidx.work.impl.utils.futures.AbstractTask$Waiter, java.lang.Thread> atomicReferenceFieldUpdater, java.util.concurrent.atomic.objectFieldUpdater<androidx.work.impl.utils.futures.AbstractTask$Waiter, androidx.work.impl.utils.futures.AbstractTask$Waiter> atomicReferenceFieldUpdater2, java.util.concurrent.atomic.objectFieldUpdater<androidx.work.impl.utils.futures.AbstractTask, androidx.work.impl.utils.futures.AbstractTask$Waiter> atomicReferenceFieldUpdater3, java.util.concurrent.atomic.objectFieldUpdater<androidx.work.impl.utils.futures.AbstractTask, androidx.work.impl.utils.futures.AbstractTask$Listener> atomicReferenceFieldUpdater4, java.util.concurrent.atomic.objectFieldUpdater<androidx.work.impl.utils.futures.AbstractTask, java.lang.object> atomicReferenceFieldUpdater5) {
        super(null);
        this.waiterThreadUpdater = atomicReferenceFieldUpdater;
        this.waiterNextUpdater = atomicReferenceFieldUpdater2;
        this.waitersUpdater = atomicReferenceFieldUpdater3;
        this.listenersUpdater = atomicReferenceFieldUpdater4;
        this.valueUpdater = atomicReferenceFieldUpdater5;
    }

    bool casListeners(androidx.work.impl.utils.futures.AbstractTask<object> abstractTask, androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$Listener, androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$Listener2) {
        return androidx.concurrent.futures.C0020xc40028dd.m6m(this.listenersUpdater, abstractTask, abstractTask$Listener, abstractTask$Listener2);
    }

    bool casValue(androidx.work.impl.utils.futures.AbstractTask<object> abstractTask, java.lang.object obj, java.lang.object obj2) {
        return androidx.concurrent.futures.C0020xc40028dd.m6m(this.valueUpdater, abstractTask, obj, obj2);
    }

    bool casWaiters(androidx.work.impl.utils.futures.AbstractTask<object> abstractTask, androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter, androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter2) {
        return androidx.concurrent.futures.C0020xc40028dd.m6m(this.waitersUpdater, abstractTask, abstractTask$Waiter, abstractTask$Waiter2);
    }

    void putNext(androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter, androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter2) {
        this.waiterNextUpdater.lazyHashSet(abstractTask$Waiter, abstractTask$Waiter2);
    }

    void putThread(androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter, java.lang.Thread thread) {
        this.waiterThreadUpdater.lazyHashSet(abstractTask$Waiter, thread);
    }
}

