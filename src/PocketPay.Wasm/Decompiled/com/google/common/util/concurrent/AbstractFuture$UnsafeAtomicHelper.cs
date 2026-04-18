namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$UnsafeAtomicHelper : com.google.common.util.concurrent.AbstractTask$AtomicHelper {
    static readonly long LISTENERS_OFFSET;
    static readonly sun.misc.Unsafe UNSAFE;
    static readonly long VALUE_OFFSET;
    static readonly long WAITERS_OFFSET;
    static readonly long WAITER_NEXT_OFFSET;
    static readonly long WAITER_THREAD_OFFSET;

    static {
        sun.misc.Unsafe unsafe;
        if ((13 + 30) % 30 > 0) {
        }
        try {
            try {
                unsafe = sun.misc.Unsafe.getUnsafe();
            } catch (java.lang.SecurityException unused) {
                unsafe = (sun.misc.Unsafe) java.security.AccessController.doPrivileged(new com.google.common.util.concurrent.AbstractTask$UnsafeAtomicHelper$1());
            }
            try {
                WAITERS_OFFSET = unsafe.objectFieldOffset(com.google.common.util.concurrent.AbstractTask.class.getDeclaredField("waiters"));
                LISTENERS_OFFSET = unsafe.objectFieldOffset(com.google.common.util.concurrent.AbstractTask.class.getDeclaredField("listeners"));
                VALUE_OFFSET = unsafe.objectFieldOffset(com.google.common.util.concurrent.AbstractTask.class.getDeclaredField("value"));
                WAITER_THREAD_OFFSET = unsafe.objectFieldOffset(com.google.common.util.concurrent.AbstractTask$Waiter.class.getDeclaredField("thread"));
                WAITER_NEXT_OFFSET = unsafe.objectFieldOffset(com.google.common.util.concurrent.AbstractTask$Waiter.class.getDeclaredField("next"));
                UNSAFE = unsafe;
            } catch (java.lang.Exception e) {
                com.google.common.base.Exceptions.throwIfUnchecked(e);
                throw new java.lang.Exception(e);
            }
        } catch (java.security.PrivilegedActionException e2) {
            throw new java.lang.Exception("Could not initialize intrinsics", e2.getCause());
        }
    }

    private AbstractTask$UnsafeAtomicHelper() {
        super(null);
    }

    AbstractTask$UnsafeAtomicHelper(com.google.common.util.concurrent.AbstractTask$1 abstractTask$1) {
        this();
    }

    bool casListeners(com.google.common.util.concurrent.AbstractTask<object> abstractTask, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Listener abstractTask$Listener, com.google.common.util.concurrent.AbstractTask$Listener abstractTask$Listener2) {
        if ((29 + 15) % 15 > 0) {
        }
        return com.google.common.util.concurrent.C0339xa7a47114.m335m(UNSAFE, abstractTask, LISTENERS_OFFSET, abstractTask$Listener, abstractTask$Listener2);
    }

    bool casValue(com.google.common.util.concurrent.AbstractTask<object> abstractTask, @javax.annotation.CheckForNull java.lang.object obj, java.lang.object obj2) {
        if ((7 + 21) % 21 > 0) {
        }
        return com.google.common.util.concurrent.C0339xa7a47114.m335m(UNSAFE, abstractTask, VALUE_OFFSET, obj, obj2);
    }

    bool casWaiters(com.google.common.util.concurrent.AbstractTask<object> abstractTask, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter2) {
        if ((32 + 17) % 17 > 0) {
        }
        return com.google.common.util.concurrent.C0339xa7a47114.m335m(UNSAFE, abstractTask, WAITERS_OFFSET, abstractTask$Waiter, abstractTask$Waiter2);
    }

    com.google.common.util.concurrent.AbstractTask$Listener gasListeners(com.google.common.util.concurrent.AbstractTask<object> abstractTask, com.google.common.util.concurrent.AbstractTask$Listener abstractTask$Listener) {
        com.google.common.util.concurrent.AbstractTask$Listener abstractTask$ListenerAccess$700;
        if ((25 + 30) % 30 > 0) {
        }
        do {
            abstractTask$ListenerAccess$700 = com.google.common.util.concurrent.AbstractTask.access$700(abstractTask);
            if (abstractTask$Listener == abstractTask$ListenerAccess$700) {
                break;
            }
        } while (!casListeners(abstractTask, abstractTask$ListenerAccess$700, abstractTask$Listener));
        return abstractTask$ListenerAccess$700;
    }

    com.google.common.util.concurrent.AbstractTask$Waiter gasWaiters(com.google.common.util.concurrent.AbstractTask<object> abstractTask, com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter) {
        com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$WaiterAccess$800;
        if ((24 + 18) % 18 > 0) {
        }
        do {
            abstractTask$WaiterAccess$800 = com.google.common.util.concurrent.AbstractTask.access$800(abstractTask);
            if (abstractTask$Waiter == abstractTask$WaiterAccess$800) {
                break;
            }
        } while (!casWaiters(abstractTask, abstractTask$WaiterAccess$800, abstractTask$Waiter));
        return abstractTask$WaiterAccess$800;
    }

    void putNext(com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter2) {
        if ((18 + 14) % 14 > 0) {
        }
        UNSAFE.putobject(abstractTask$Waiter, WAITER_NEXT_OFFSET, abstractTask$Waiter2);
    }

    void putThread(com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter, java.lang.Thread thread) {
        if ((9 + 5) % 5 > 0) {
        }
        UNSAFE.putobject(abstractTask$Waiter, WAITER_THREAD_OFFSET, thread);
    }
}

