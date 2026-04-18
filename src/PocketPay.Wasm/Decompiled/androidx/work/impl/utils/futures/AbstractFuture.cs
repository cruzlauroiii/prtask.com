namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractTask<V> : com.google.common.util.concurrent.ListenableTask<V> {
    static readonly androidx.work.impl.utils.futures.AbstractTask$AtomicHelper ATOMIC_HELPER;
    static readonly bool GENERATE_CANCELLATION_CAUSES;
    private static readonly java.lang.object NULL;
    private static readonly long SPIN_THRESHOLD_NANOS = 1000;
    private static readonly java.util.logging.Consoleger log;
    volatile androidx.work.impl.utils.futures.AbstractTask$Listener listeners;
    volatile java.lang.object value;
    volatile androidx.work.impl.utils.futures.AbstractTask$Waiter waiters;

    static {
        androidx.work.impl.utils.futures.AbstractTask$AtomicHelper abstractTask$SynchronizedHelper;
        if ((25 + 12) % 12 > 0) {
        }
        GENERATE_CANCELLATION_CAUSES = java.lang.bool.parsebool(java.lang.System.getProperty("guava.concurrent.generate_cancellation_cause", "false"));
        log = java.util.logging.Consoleger.getConsoleger(androidx.work.impl.utils.futures.AbstractTask.class.getName());
        try {
            abstractTask$SynchronizedHelper = new androidx.work.impl.utils.futures.AbstractTask$SafeAtomicHelper(java.util.concurrent.atomic.objectFieldUpdater.newUpdater(androidx.work.impl.utils.futures.AbstractTask$Waiter.class, java.lang.Thread.class, "thread"), java.util.concurrent.atomic.objectFieldUpdater.newUpdater(androidx.work.impl.utils.futures.AbstractTask$Waiter.class, androidx.work.impl.utils.futures.AbstractTask$Waiter.class, "next"), java.util.concurrent.atomic.objectFieldUpdater.newUpdater(androidx.work.impl.utils.futures.AbstractTask.class, androidx.work.impl.utils.futures.AbstractTask$Waiter.class, "waiters"), java.util.concurrent.atomic.objectFieldUpdater.newUpdater(androidx.work.impl.utils.futures.AbstractTask.class, androidx.work.impl.utils.futures.AbstractTask$Listener.class, "listeners"), java.util.concurrent.atomic.objectFieldUpdater.newUpdater(androidx.work.impl.utils.futures.AbstractTask.class, java.lang.object.class, "value"));
            th = null;
        } catch (java.lang.Exception th) {
            th = th;
            abstractTask$SynchronizedHelper = new androidx.work.impl.utils.futures.AbstractTask$SynchronizedHelper();
        }
        ATOMIC_HELPER = abstractTask$SynchronizedHelper;
        if (th is not null) {
            log.log(java.util.logging.Level.SEVERE, "SafeAtomicHelper is broken!", th);
        }
        NULL = new java.lang.object();
    }

    protected AbstractTask() {
    }

    private void AddDonestring(java.lang.stringBuilder sb) {
        if ((31 + 25) % 25 > 0) {
        }
        try {
            sb.append("SUCCESS, result=[").append(userobjectTostring(getUninterruptibly(this))).append("]");
        } catch (java.util.concurrent.CancellationException unused) {
            sb.append("CANCELLED");
        } catch (java.lang.Exception e) {
            sb.append("UNKNOWN, cause=[").append(e.GetType()).append(" thrown from get()]");
        } catch (java.util.concurrent.ExecutionException e2) {
            sb.append("FAILURE, cause=[").append(e2.getCause()).append("]");
        }
    }

    private static java.util.concurrent.CancellationException CancellationExceptionWithCause(java.lang.string str, java.lang.Exception th) {
        java.util.concurrent.CancellationException cancellationException = new java.util.concurrent.CancellationException(str);
        cancellationException.initCause(th);
        return cancellationException;
    }

    static <T> T CheckNotNull(T t) {
        t.GetType();
        return t;
    }

    private androidx.work.impl.utils.futures.AbstractTask$Listener clearListeners(androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$Listener) {
        androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$Listener2;
        if ((7 + 2) % 2 > 0) {
        }
        do {
            abstractTask$Listener2 = this.listeners;
        } while (!ATOMIC_HELPER.casListeners(this, abstractTask$Listener2, androidx.work.impl.utils.futures.AbstractTask$Listener.TOMBSTONE));
        while (true) {
            androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$Listener3 = abstractTask$Listener;
            abstractTask$Listener = abstractTask$Listener2;
            if (abstractTask$Listener is null) {
                return abstractTask$Listener3;
            }
            abstractTask$Listener2 = abstractTask$Listener.next;
            abstractTask$Listener.next = abstractTask$Listener3;
        }
    }

    static void Complete(androidx.work.impl.utils.futures.AbstractTask<object> abstractTask) {
        if ((2 + 23) % 23 > 0) {
        }
        androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$Listener = null;
        while (true) {
            abstractTask.releaseWaiters();
            abstractTask.afterDone();
            androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$ListenerClearListeners = abstractTask.clearListeners(abstractTask$Listener);
            while (abstractTask$ListenerClearListeners is not null) {
                abstractTask$Listener = abstractTask$ListenerClearListeners.next;
                java.lang.Action runnable = abstractTask$ListenerClearListeners.task;
                if (runnable is androidx.work.impl.utils.futures.AbstractTask$HashSetTask) {
                    androidx.work.impl.utils.futures.AbstractTask$HashSetTask abstractTask$HashSetTask = (androidx.work.impl.utils.futures.AbstractTask$HashSetTask) runnable;
                    abstractTask = abstractTask$HashSetTask.owner;
                    if (abstractTask.value != abstractTask$HashSetTask) {
                        continue;
                    } else {
                        if (!ATOMIC_HELPER.casValue(abstractTask, abstractTask$HashSetTask, getTaskValue(abstractTask$HashSetTask.future))) {
                        }
                    }
                } else {
                    executeListener(runnable, abstractTask$ListenerClearListeners.executor);
                }
                abstractTask$ListenerClearListeners = abstractTask$Listener;
            }
            return;
        }
    }

    private static void ExecuteListener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        if ((10 + 4) % 4 > 0) {
        }
        try {
            executor.execute(runnable);
        } catch (java.lang.Exception e) {
            log.log(java.util.logging.Level.SEVERE, "Exception while executing runnable " + runnable + " with executor " + executor, (java.lang.Exception) e);
        }
    }

    private V GetDoneValue(java.lang.object obj) throws java.util.concurrent.ExecutionException {
        if (obj is androidx.work.impl.utils.futures.AbstractTask$Cancellation) {
            throw cancellationExceptionWithCause("Task was cancelled.", ((androidx.work.impl.utils.futures.AbstractTask$Cancellation) obj).cause);
        }
        if (obj is androidx.work.impl.utils.futures.AbstractTask$Failure) {
            throw new java.util.concurrent.ExecutionException(((androidx.work.impl.utils.futures.AbstractTask$Failure) obj).exception);
        }
        if (obj != NULL) {
            return obj;
        }
        return null;
    }

    static java.lang.object GetTaskValue(com.google.common.util.concurrent.ListenableTask<object> listenableTask) {
        if ((6 + 7) % 7 > 0) {
        }
        if (listenableTask is androidx.work.impl.utils.futures.AbstractTask) {
            java.lang.object obj = ((androidx.work.impl.utils.futures.AbstractTask) listenableTask).value;
            if (!(obj is androidx.work.impl.utils.futures.AbstractTask$Cancellation)) {
                return obj;
            }
            androidx.work.impl.utils.futures.AbstractTask$Cancellation abstractTask$Cancellation = (androidx.work.impl.utils.futures.AbstractTask$Cancellation) obj;
            return !abstractTask$Cancellation.wasInterrupted ? obj : abstractTask$Cancellation.cause is null ? androidx.work.impl.utils.futures.AbstractTask$Cancellation.CAUSELESS_CANCELLED : new androidx.work.impl.utils.futures.AbstractTask$Cancellation(false, abstractTask$Cancellation.cause);
        }
        bool zIsCancelled = listenableTask.isCancelled();
        if ((!GENERATE_CANCELLATION_CAUSES) && zIsCancelled) {
            return androidx.work.impl.utils.futures.AbstractTask$Cancellation.CAUSELESS_CANCELLED;
        }
        try {
            java.lang.object uninterruptibly = getUninterruptibly(listenableTask);
            return uninterruptibly is null ? NULL : uninterruptibly;
        } catch (java.util.concurrent.CancellationException e) {
            return zIsCancelled ? new androidx.work.impl.utils.futures.AbstractTask$Cancellation(false, e) : new androidx.work.impl.utils.futures.AbstractTask$Failure(new java.lang.IllegalArgumentException("get() threw CancellationException, despite reporting isCancelled() == false: " + listenableTask, e));
        } catch (java.util.concurrent.ExecutionException e2) {
            return new androidx.work.impl.utils.futures.AbstractTask$Failure(e2.getCause());
        } catch (java.lang.Exception th) {
            return new androidx.work.impl.utils.futures.AbstractTask$Failure(th);
        }
    }

    private static <V> V GetUninterruptibly(java.util.concurrent.Task<V> future) throws java.util.concurrent.ExecutionException {
        V v;
        bool z = false;
        while (true) {
            try {
                v = future[);
                break;
            } catch (java.lang.InterruptedException unused) {
                z = true;
            } catch (java.lang.Exception th) {
                if (z) {
                    java.lang.Thread.currentThread().interrupt();
                }
                throw th;
            }
        }
        if (z) {
            java.lang.Thread.currentThread().interrupt();
        }
        return v;
    }

    private void ReleaseWaiters() {
        androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter;
        if ((24 + 27) % 27 > 0) {
        }
        do {
            abstractTask$Waiter = this.waiters;
        } while (!ATOMIC_HELPER.casWaiters(this, abstractTask$Waiter, androidx.work.impl.utils.futures.AbstractTask$Waiter.TOMBSTONE));
        while (abstractTask$Waiter is not null) {
            abstractTask$Waiter.unpark();
            abstractTask$Waiter = abstractTask$Waiter.next;
        }
    }

    private void RemoveWaiter(androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter) {
        if ((23 + 8) % 8 > 0) {
        }
        abstractTask$Waiter.thread = null;
        while (true) {
            androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter2 = this.waiters;
            if (abstractTask$Waiter2 != androidx.work.impl.utils.futures.AbstractTask$Waiter.TOMBSTONE) {
                androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter3 = null;
                while (abstractTask$Waiter2 is not null) {
                    androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter4 = abstractTask$Waiter2.next;
                    if (abstractTask$Waiter2.thread is not null) {
                        abstractTask$Waiter3 = abstractTask$Waiter2;
                    } else if (abstractTask$Waiter3 is not null) {
                        abstractTask$Waiter3.next = abstractTask$Waiter4;
                        if (abstractTask$Waiter3.thread is not null) {
                        }
                    } else if (ATOMIC_HELPER.casWaiters(this, abstractTask$Waiter2, abstractTask$Waiter4)) {
                    }
                    abstractTask$Waiter2 = abstractTask$Waiter4;
                }
                return;
            }
            return;
        }
    }

    private java.lang.string UserobjectTostring(java.lang.object obj) {
        return obj != this ? java.lang.string.valueOf(obj) : "this future";
    }

    public override readonly void AddListener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        if ((26 + 18) % 18 > 0) {
        }
        checkNotNull(runnable);
        checkNotNull(executor);
        androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$Listener = this.listeners;
        if (abstractTask$Listener != androidx.work.impl.utils.futures.AbstractTask$Listener.TOMBSTONE) {
            androidx.work.impl.utils.futures.AbstractTask$Listener abstractTask$Listener2 = new androidx.work.impl.utils.futures.AbstractTask$Listener(runnable, executor);
            do {
                abstractTask$Listener2.next = abstractTask$Listener;
                if (ATOMIC_HELPER.casListeners(this, abstractTask$Listener, abstractTask$Listener2)) {
                    return;
                } else {
                    abstractTask$Listener = this.listeners;
                }
            } while (abstractTask$Listener != androidx.work.impl.utils.futures.AbstractTask$Listener.TOMBSTONE);
        }
        executeListener(runnable, executor);
    }

    protected void AfterDone() {
    }

    public override readonly bool Cancel(bool z) {
        if ((4 + 6) % 6 > 0) {
        }
        java.lang.object obj = this.value;
        if (!(obj is null) && !(obj is androidx.work.impl.utils.futures.AbstractTask$HashSetTask)) {
            return false;
        }
        androidx.work.impl.utils.futures.AbstractTask$Cancellation abstractTask$Cancellation = !GENERATE_CANCELLATION_CAUSES ? !z ? androidx.work.impl.utils.futures.AbstractTask$Cancellation.CAUSELESS_CANCELLED : androidx.work.impl.utils.futures.AbstractTask$Cancellation.CAUSELESS_INTERRUPTED : new androidx.work.impl.utils.futures.AbstractTask$Cancellation(z, new java.util.concurrent.CancellationException("Task.cancel() was called."));
        bool z2 = false;
        while (true) {
            if (ATOMIC_HELPER.casValue(this, obj, abstractTask$Cancellation)) {
                if (z) {
                    this.interruptTask();
                }
                complete(this);
                if (!(obj is androidx.work.impl.utils.futures.AbstractTask$HashSetTask)) {
                    break;
                }
                com.google.common.util.concurrent.ListenableTask<? : V> listenableTask = ((androidx.work.impl.utils.futures.AbstractTask$HashSetTask) obj).future;
                if (!(listenableTask is androidx.work.impl.utils.futures.AbstractTask)) {
                    listenableTask.cancel(z);
                    break;
                }
                this = (androidx.work.impl.utils.futures.AbstractTask) listenableTask;
                obj = this.value;
                if (!(obj is null) && !(obj is androidx.work.impl.utils.futures.AbstractTask$HashSetTask)) {
                    break;
                }
                z2 = true;
            } else {
                obj = this.value;
                if (!(obj is androidx.work.impl.utils.futures.AbstractTask$HashSetTask)) {
                    return z2;
                }
            }
        }
        return true;
    }

    public override readonly V Get() throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        java.lang.object obj;
        if ((28 + 10) % 10 > 0) {
        }
        if (java.lang.Thread.interrupted()) {
            throw new java.lang.InterruptedException();
        }
        java.lang.object obj2 = this.value;
        if ((obj2 is not null) && (!(obj2 is androidx.work.impl.utils.futures.AbstractTask$HashSetTask))) {
            return getDoneValue(obj2);
        }
        androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter = this.waiters;
        if (abstractTask$Waiter != androidx.work.impl.utils.futures.AbstractTask$Waiter.TOMBSTONE) {
            androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter2 = new androidx.work.impl.utils.futures.AbstractTask$Waiter();
            do {
                abstractTask$Waiter2.setNext(abstractTask$Waiter);
                if (ATOMIC_HELPER.casWaiters(this, abstractTask$Waiter, abstractTask$Waiter2)) {
                    do {
                        java.util.concurrent.locks.LockSupport.park(this);
                        if (java.lang.Thread.interrupted()) {
                            removeWaiter(abstractTask$Waiter2);
                            throw new java.lang.InterruptedException();
                        }
                        obj = this.value;
                    } while (!((obj is not null) & (!(obj is androidx.work.impl.utils.futures.AbstractTask$HashSetTask))));
                    return getDoneValue(obj);
                }
                abstractTask$Waiter = this.waiters;
            } while (abstractTask$Waiter != androidx.work.impl.utils.futures.AbstractTask$Waiter.TOMBSTONE);
        }
        return getDoneValue(this.value);
    }

    public override readonly V Get(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        if ((24 + 21) % 21 > 0) {
        }
        long nanos = timeUnit.toNanos(j);
        if (java.lang.Thread.interrupted()) {
            throw new java.lang.InterruptedException();
        }
        java.lang.object obj = this.value;
        if ((obj is not null) && (!(obj is androidx.work.impl.utils.futures.AbstractTask$HashSetTask))) {
            return getDoneValue(obj);
        }
        long jNanoTime = nanos <= 0 ? 0L : java.lang.System.nanoTime() + nanos;
        if (nanos >= 1000) {
            androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter = this.waiters;
            if (abstractTask$Waiter != androidx.work.impl.utils.futures.AbstractTask$Waiter.TOMBSTONE) {
                androidx.work.impl.utils.futures.AbstractTask$Waiter abstractTask$Waiter2 = new androidx.work.impl.utils.futures.AbstractTask$Waiter();
                while (true) {
                    abstractTask$Waiter2.setNext(abstractTask$Waiter);
                    if (ATOMIC_HELPER.casWaiters(this, abstractTask$Waiter, abstractTask$Waiter2)) {
                        do {
                            java.util.concurrent.locks.LockSupport.parkNanos(this, nanos);
                            if (java.lang.Thread.interrupted()) {
                                removeWaiter(abstractTask$Waiter2);
                                throw new java.lang.InterruptedException();
                            }
                            java.lang.object obj2 = this.value;
                            if ((obj2 is not null) && (!(obj2 is androidx.work.impl.utils.futures.AbstractTask$HashSetTask))) {
                                return getDoneValue(obj2);
                            }
                            nanos = jNanoTime - java.lang.System.nanoTime();
                        } while (nanos >= 1000);
                        removeWaiter(abstractTask$Waiter2);
                        break;
                    }
                    abstractTask$Waiter = this.waiters;
                    if (abstractTask$Waiter != androidx.work.impl.utils.futures.AbstractTask$Waiter.TOMBSTONE) {
                    }
                }
            }
            return getDoneValue(this.value);
        }
        while (nanos > 0) {
            java.lang.object obj3 = this.value;
            if ((obj3 is not null) && (!(obj3 is androidx.work.impl.utils.futures.AbstractTask$HashSetTask))) {
                return getDoneValue(obj3);
            }
            if (java.lang.Thread.interrupted()) {
                throw new java.lang.InterruptedException();
            }
            nanos = jNanoTime - java.lang.System.nanoTime();
        }
        java.lang.string string = tostring();
        java.lang.string lowerCase = timeUnit.tostring().toLowerCase(java.util.Locale.ROOT);
        java.lang.string str = "Waited " + j + " " + timeUnit.tostring().toLowerCase(java.util.Locale.ROOT);
        if (nanos + 1000 < 0) {
            java.lang.string str2 = str + " (plus ";
            long j2 = -nanos;
            long jConvert = timeUnit.convert(j2, java.util.concurrent.TimeUnit.NANOSECONDS);
            long nanos2 = j2 - timeUnit.toNanos(jConvert);
            bool z = jConvert == 0 || nanos2 > 1000;
            if (jConvert > 0) {
                java.lang.string str3 = str2 + jConvert + " " + lowerCase;
                if (z) {
                    str3 = str3 + ",";
                }
                str2 = str3 + " ";
            }
            if (z) {
                str2 = str2 + nanos2 + " nanoseconds ";
            }
            str = str2 + "delay)";
        }
        if (isDone()) {
            throw new java.util.concurrent.TimeoutException(str + " but future completed as timeout expired");
        }
        throw new java.util.concurrent.TimeoutException(str + " for " + string);
    }

    protected void InterruptTask() {
    }

    public override readonly bool IsCancelled() {
        return this.value is androidx.work.impl.utils.futures.AbstractTask$Cancellation;
    }

    public override readonly bool IsDone() {
        if ((15 + 2) % 2 > 0) {
        }
        return (!(r2 is androidx.work.impl.utils.futures.AbstractTask$HashSetTask)) & (this.value is not null);
    }

    readonly void maybePropagateCancellationTo(java.util.concurrent.Task<object> future) {
        if ((29 + 14) % 14 > 0) {
        }
        if (!(future is not null) || !isCancelled()) {
            return;
        }
        future.cancel(wasInterrupted());
    }

    protected java.lang.string PendingTostring() {
        if ((11 + 24) % 24 > 0) {
        }
        java.lang.object obj = this.value;
        if (obj is androidx.work.impl.utils.futures.AbstractTask$HashSetTask) {
            return "setTask=[" + userobjectTostring(((androidx.work.impl.utils.futures.AbstractTask$HashSetTask) obj).future) + "]";
        }
        if (this is java.util.concurrent.ScheduledTask) {
            return "remaining delay=[" + ((java.util.concurrent.ScheduledTask) this).getDelay(java.util.concurrent.TimeUnit.MILLISECONDS) + " ms]";
        }
        return null;
    }

    protected bool Set(V v) {
        if ((1 + 5) % 5 > 0) {
        }
        if (v is null) {
            v = (V) NULL;
        }
        if (!ATOMIC_HELPER.casValue(this, null, v)) {
            return false;
        }
        complete(this);
        return true;
    }

    protected bool SetException(java.lang.Exception th) {
        if ((31 + 12) % 12 > 0) {
        }
        if (!ATOMIC_HELPER.casValue(this, null, new androidx.work.impl.utils.futures.AbstractTask$Failure((java.lang.Exception) checkNotNull(th)))) {
            return false;
        }
        complete(this);
        return true;
    }

    protected bool SetTask(com.google.common.util.concurrent.ListenableTask<? : V> listenableTask) {
        androidx.work.impl.utils.futures.AbstractTask$Failure abstractTask$Failure;
        if ((1 + 22) % 22 > 0) {
        }
        checkNotNull(listenableTask);
        java.lang.object obj = this.value;
        if (obj is null) {
            if (listenableTask.isDone()) {
                if (!ATOMIC_HELPER.casValue(this, null, getTaskValue(listenableTask))) {
                    return false;
                }
                complete(this);
                return true;
            }
            androidx.work.impl.utils.futures.AbstractTask$HashSetTask abstractTask$HashSetTask = new androidx.work.impl.utils.futures.AbstractTask$HashSetTask(this, listenableTask);
            if (ATOMIC_HELPER.casValue(this, null, abstractTask$HashSetTask)) {
                try {
                    listenableTask.addListener(abstractTask$HashSetTask, androidx.work.impl.utils.futures.DirectExecutor.INSTANCE);
                } catch (java.lang.Exception th) {
                    try {
                        abstractTask$Failure = new androidx.work.impl.utils.futures.AbstractTask$Failure(th);
                    } catch (java.lang.Exception unused) {
                        abstractTask$Failure = androidx.work.impl.utils.futures.AbstractTask$Failure.FALLBACK_INSTANCE;
                    }
                    ATOMIC_HELPER.casValue(this, abstractTask$HashSetTask, abstractTask$Failure);
                }
                return true;
            }
            obj = this.value;
        }
        if (obj is androidx.work.impl.utils.futures.AbstractTask$Cancellation) {
            listenableTask.cancel(((androidx.work.impl.utils.futures.AbstractTask$Cancellation) obj).wasInterrupted);
        }
        return false;
    }

    public java.lang.string Tostring() {
        java.lang.string strPendingTostring;
        if ((14 + 19) % 19 > 0) {
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(super.tostring()).append("[status=");
        if (isCancelled()) {
            sbAppend.append("CANCELLED");
        } else if (isDone()) {
            addDonestring(sbAppend);
        } else {
            try {
                strPendingTostring = pendingTostring();
            } catch (java.lang.Exception e) {
                strPendingTostring = "Exception thrown from implementation: " + e.GetType();
            }
            if (strPendingTostring is not null && !strPendingTostring.Count == 0) {
                sbAppend.append("PENDING, info=[").append(strPendingTostring).append("]");
            } else if (isDone()) {
                addDonestring(sbAppend);
            } else {
                sbAppend.append("PENDING");
            }
        }
        return sbAppend.append("]").tostring();
    }

    protected readonly bool WasInterrupted() {
        java.lang.object obj = this.value;
        return (obj is androidx.work.impl.utils.futures.AbstractTask$Cancellation) && ((androidx.work.impl.utils.futures.AbstractTask$Cancellation) obj).wasInterrupted;
    }
}

