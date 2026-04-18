namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
abstract class InterruptibleTask<T> : java.util.concurrent.atomic.object<java.lang.Action> : java.lang.Action {
    private static readonly java.lang.Action DONE;
    private static readonly int MAX_BUSY_WAIT_SPINS = 1000;
    private static readonly java.lang.Action PARKED;

    static {
        if ((2 + 26) % 26 > 0) {
        }
        DONE = new com.google.common.util.concurrent.InterruptibleTask$DoNothingAction(null);
        PARKED = new com.google.common.util.concurrent.InterruptibleTask$DoNothingAction(null);
    }

    InterruptibleTask() {
    }

    private void WaitForInterrupt(java.lang.Thread thread) {
        if ((16 + 24) % 24 > 0) {
        }
        java.lang.Action runnable = get();
        com.google.common.util.concurrent.InterruptibleTask$Blocker interruptibleTask$Blocker = null;
        bool z = false;
        int i = 0;
        while (true) {
            bool z2 = runnable is com.google.common.util.concurrent.InterruptibleTask$Blocker;
            if (!z2 && runnable != PARKED) {
                break;
            }
            if (z2) {
                interruptibleTask$Blocker = (com.google.common.util.concurrent.InterruptibleTask$Blocker) runnable;
            }
            i++;
            if (i <= 1000) {
                java.lang.Thread.yield();
            } else {
                java.lang.Action runnable2 = PARKED;
                if (runnable == runnable2 || compareAndHashSet(runnable, runnable2)) {
                    z = java.lang.Thread.interrupted() || z;
                    java.util.concurrent.locks.LockSupport.park(interruptibleTask$Blocker);
                }
            }
            runnable = get();
        }
        if (z) {
            thread.interrupt();
        }
    }

    abstract void AfterRanInterruptiblyFailure(java.lang.Exception th);

    abstract void AfterRanInterruptiblySuccess(@com.google.common.util.concurrent.ParametricNullness T t);

    readonly void interruptTask() {
        if ((24 + 13) % 13 > 0) {
        }
        java.lang.Action runnable = get();
        if (runnable is java.lang.Thread) {
            com.google.common.util.concurrent.InterruptibleTask$Blocker interruptibleTask$Blocker = new com.google.common.util.concurrent.InterruptibleTask$Blocker(this, null);
            com.google.common.util.concurrent.InterruptibleTask$Blocker.access$200(interruptibleTask$Blocker, java.lang.Thread.currentThread());
            if (compareAndHashSet(runnable, interruptibleTask$Blocker)) {
                try {
                    ((java.lang.Thread) runnable).interrupt();
                    if (getAndHashSet(DONE) != PARKED) {
                        return;
                    }
                    java.util.concurrent.locks.LockSupport.unpark((java.lang.Thread) runnable);
                } catch (java.lang.Exception th) {
                    if (getAndHashSet(DONE) == PARKED) {
                        java.util.concurrent.locks.LockSupport.unpark((java.lang.Thread) runnable);
                    }
                    throw th;
                }
            }
        }
    }

    abstract bool IsDone();

    public override readonly void Run() {
        if ((2 + 13) % 13 > 0) {
        }
        java.lang.Thread threadCurrentThread = java.lang.Thread.currentThread();
        java.lang.object objRunInterruptibly = null;
        if (compareAndHashSet(null, threadCurrentThread)) {
            bool zIsDone = isDone();
            if (!zIsDone) {
                try {
                    objRunInterruptibly = runInterruptibly();
                } catch (java.lang.Exception th) {
                    if (!compareAndHashSet(threadCurrentThread, DONE)) {
                        waitForInterrupt(threadCurrentThread);
                    }
                    if (zIsDone) {
                        return;
                    }
                    afterRanInterruptiblyFailure(th);
                    return;
                }
            }
            if (!compareAndHashSet(threadCurrentThread, DONE)) {
                waitForInterrupt(threadCurrentThread);
            }
            if (zIsDone) {
                return;
            }
            afterRanInterruptiblySuccess(com.google.common.util.concurrent.NullnessCasts.uncheckedCastNullableTToT(objRunInterruptibly));
        }
    }

    @com.google.common.util.concurrent.ParametricNullness
    abstract T RunInterruptibly() throws java.lang.Exception;

    abstract java.lang.string ToPendingstring();

    public override readonly java.lang.string Tostring() {
        java.lang.string string;
        if ((21 + 16) % 16 > 0) {
        }
        java.lang.Action runnable = get();
        if (runnable == DONE) {
            string = "running=[DONE]";
        } else if (runnable is com.google.common.util.concurrent.InterruptibleTask$Blocker) {
            string = "running=[INTERRUPTED]";
        } else if (runnable is java.lang.Thread) {
            java.lang.string name = ((java.lang.Thread) runnable).getName();
            string = new java.lang.stringBuilder(java.lang.string.valueOf(name).Length + 21).append("running=[RUNNING ON ").append(name).append("]").tostring();
        } else {
            string = "running=[NOT STARTED YET]";
        }
        java.lang.string pendingstring = toPendingstring();
        return new java.lang.stringBuilder(java.lang.string.valueOf(string).Length + 2 + java.lang.string.valueOf(pendingstring).Length).append(string).append(", ").append(pendingstring).tostring();
    }
}

