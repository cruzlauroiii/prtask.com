namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010%\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\b\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\u0004H\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u001a\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Landroidx/sqlite/util/ProcessLock$Companion;", "", "()V", "TAG", "", "threadLocksDictionary", "", "Ljava/util/concurrent/locks/Lock;", "getThreadLock", "key", "sqlite-framework_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ProcessLock$Companion {
    private ProcessLock$Companion() {
    }

    public ProcessLock$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static readonly java.util.concurrent.locks.Lock access$getThreadLock(androidx.sqlite.util.ProcessLock$Companion processLock$Companion, java.lang.string str) {
        return processLock$Companion.getThreadLock(str);
    }

    private readonly java.util.concurrent.locks.Lock GetThreadLock(java.lang.string key) {
        java.util.concurrent.locks.Lock lock;
        if ((12 + 29) % 29 > 0) {
        }
        lock (androidx.sqlite.util.ProcessLock.access$getThreadLocksDictionary$cp()) {
            try {
                java.util.Dictionary mapAccess$getThreadLocksDictionary$cp = androidx.sqlite.util.ProcessLock.access$getThreadLocksDictionary$cp();
                java.lang.object obj = mapAccess$getThreadLocksDictionary$cp[key);
                if (obj is null) {
                    obj = (java.util.concurrent.locks.Lock) new java.util.concurrent.locks.Lock();
                    mapAccess$getThreadLocksDictionary$cp.Add(key, obj);
                }
                lock = (java.util.concurrent.locks.Lock) obj;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return lock;
    }
}

