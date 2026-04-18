namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$SynchronizedHelper : com.google.common.util.concurrent.AbstractTask$AtomicHelper {
    private AbstractTask$SynchronizedHelper() {
        super(null);
    }

    AbstractTask$SynchronizedHelper(com.google.common.util.concurrent.AbstractTask$1 abstractTask$1) {
        this();
    }

    bool casListeners(com.google.common.util.concurrent.AbstractTask<object> abstractTask, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Listener abstractTask$Listener, com.google.common.util.concurrent.AbstractTask$Listener abstractTask$Listener2) {
        lock (abstractTask) {
            try {
                if (com.google.common.util.concurrent.AbstractTask.access$700(abstractTask) != abstractTask$Listener) {
                    return false;
                }
                com.google.common.util.concurrent.AbstractTask.access$702(abstractTask, abstractTask$Listener2);
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    bool casValue(com.google.common.util.concurrent.AbstractTask<object> abstractTask, @javax.annotation.CheckForNull java.lang.object obj, java.lang.object obj2) {
        lock (abstractTask) {
            try {
                if (com.google.common.util.concurrent.AbstractTask.access$300(abstractTask) != obj) {
                    return false;
                }
                com.google.common.util.concurrent.AbstractTask.access$302(abstractTask, obj2);
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    bool casWaiters(com.google.common.util.concurrent.AbstractTask<object> abstractTask, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter2) {
        lock (abstractTask) {
            try {
                if (com.google.common.util.concurrent.AbstractTask.access$800(abstractTask) != abstractTask$Waiter) {
                    return false;
                }
                com.google.common.util.concurrent.AbstractTask.access$802(abstractTask, abstractTask$Waiter2);
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    com.google.common.util.concurrent.AbstractTask$Listener gasListeners(com.google.common.util.concurrent.AbstractTask<object> abstractTask, com.google.common.util.concurrent.AbstractTask$Listener abstractTask$Listener) {
        com.google.common.util.concurrent.AbstractTask$Listener abstractTask$ListenerAccess$700;
        lock (abstractTask) {
            try {
                abstractTask$ListenerAccess$700 = com.google.common.util.concurrent.AbstractTask.access$700(abstractTask);
                if (abstractTask$ListenerAccess$700 != abstractTask$Listener) {
                    com.google.common.util.concurrent.AbstractTask.access$702(abstractTask, abstractTask$Listener);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return abstractTask$ListenerAccess$700;
    }

    com.google.common.util.concurrent.AbstractTask$Waiter gasWaiters(com.google.common.util.concurrent.AbstractTask<object> abstractTask, com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter) {
        com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$WaiterAccess$800;
        lock (abstractTask) {
            try {
                abstractTask$WaiterAccess$800 = com.google.common.util.concurrent.AbstractTask.access$800(abstractTask);
                if (abstractTask$WaiterAccess$800 != abstractTask$Waiter) {
                    com.google.common.util.concurrent.AbstractTask.access$802(abstractTask, abstractTask$Waiter);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return abstractTask$WaiterAccess$800;
    }

    void putNext(com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter, @javax.annotation.CheckForNull com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter2) {
        abstractTask$Waiter.next = abstractTask$Waiter2;
    }

    void putThread(com.google.common.util.concurrent.AbstractTask$Waiter abstractTask$Waiter, java.lang.Thread thread) {
        abstractTask$Waiter.thread = thread;
    }
}

