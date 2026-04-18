namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractResolvableTask$SafeAtomicHelper : androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper {
    readonly java.util.concurrent.atomic.objectFieldUpdater<androidx.concurrent.futures.AbstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Listener> listenersUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<androidx.concurrent.futures.AbstractResolvableTask, java.lang.object> valueUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<androidx.concurrent.futures.AbstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter> waiterNextUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<androidx.concurrent.futures.AbstractResolvableTask$Waiter, java.lang.Thread> waiterThreadUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<androidx.concurrent.futures.AbstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Waiter> waitersUpdater;

    AbstractResolvableTask$SafeAtomicHelper(java.util.concurrent.atomic.objectFieldUpdater<androidx.concurrent.futures.AbstractResolvableTask$Waiter, java.lang.Thread> atomicReferenceFieldUpdater, java.util.concurrent.atomic.objectFieldUpdater<androidx.concurrent.futures.AbstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter> atomicReferenceFieldUpdater2, java.util.concurrent.atomic.objectFieldUpdater<androidx.concurrent.futures.AbstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Waiter> atomicReferenceFieldUpdater3, java.util.concurrent.atomic.objectFieldUpdater<androidx.concurrent.futures.AbstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Listener> atomicReferenceFieldUpdater4, java.util.concurrent.atomic.objectFieldUpdater<androidx.concurrent.futures.AbstractResolvableTask, java.lang.object> atomicReferenceFieldUpdater5) {
        super(null);
        this.waiterThreadUpdater = atomicReferenceFieldUpdater;
        this.waiterNextUpdater = atomicReferenceFieldUpdater2;
        this.waitersUpdater = atomicReferenceFieldUpdater3;
        this.listenersUpdater = atomicReferenceFieldUpdater4;
        this.valueUpdater = atomicReferenceFieldUpdater5;
    }

    public static bool GIFbNfLYBhpUSlDP(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, obj, obj2, obj3);
    }

    public static void GOthdZWOCSJZssSV(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2) {
        atomicReferenceFieldUpdater.lazyHashSet(obj, obj2);
    }

    public static void VOdzqQYhwsWKreDC(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2) {
        atomicReferenceFieldUpdater.lazyHashSet(obj, obj2);
    }

    public static bool THAlofoMQUhDJnIh(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, obj, obj2, obj3);
    }

    public static bool XWsurNsyvRjDFjsn(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, obj, obj2, obj3);
    }

    bool casListeners(androidx.concurrent.futures.AbstractResolvableTask<object> abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener, androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener2) {
        return tHAlofoMQUhDJnIh(this.listenersUpdater, abstractResolvableTask, abstractResolvableTask$Listener, abstractResolvableTask$Listener2);
    }

    bool casValue(androidx.concurrent.futures.AbstractResolvableTask<object> abstractResolvableTask, java.lang.object obj, java.lang.object obj2) {
        return xWsurNsyvRjDFjsn(this.valueUpdater, abstractResolvableTask, obj, obj2);
    }

    bool casWaiters(androidx.concurrent.futures.AbstractResolvableTask<object> abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2) {
        return GIFbNfLYBhpUSlDP(this.waitersUpdater, abstractResolvableTask, abstractResolvableTask$Waiter, abstractResolvableTask$Waiter2);
    }

    void putNext(androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2) {
        GOthdZWOCSJZssSV(this.waiterNextUpdater, abstractResolvableTask$Waiter, abstractResolvableTask$Waiter2);
    }

    void putThread(androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, java.lang.Thread thread) {
        VOdzqQYhwsWKreDC(this.waiterThreadUpdater, abstractResolvableTask$Waiter, thread);
    }
}

