namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\bÂ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J*\u0010\u000b\u001a\u0014\u0012\u0004\u0012\u00020\b\u0012\u0006\u0012\u0004\u0018\u00010\b0\tj\u0002`\n2\u000e\u0010\f\u001a\n\u0012\u0006\b\u0001\u0012\u00020\b0\u0007H\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R4\u0010\u0005\u001a(\u0012\f\u0012\n\u0012\u0006\b\u0001\u0012\u00020\b0\u0007\u0012\u0016\u0012\u0014\u0012\u0004\u0012\u00020\b\u0012\u0006\u0012\u0004\u0018\u00010\b0\tj\u0002`\n0\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lkotlinx/coroutines/internal/WeakDictionaryCtorCache;", "Lkotlinx/coroutines/internal/CtorCache;", "()V", "cacheLock", "Ljava/util/concurrent/locks/ReentrantReadWriteLock;", "exceptionCtors", "Ljava/util/WeakHashDictionary;", "Ljava/lang/Class;", "", "Lkotlin/Function1;", "Lkotlinx/coroutines/internal/Ctor;", "get", "key", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class WeakDictionaryCtorCache : kotlinx.coroutines.internal.CtorCache {
    public static readonly kotlinx.coroutines.internal.WeakDictionaryCtorCache INSTANCE = new kotlinx.coroutines.internal.WeakDictionaryCtorCache();
    private static readonly java.util.concurrent.locks.ReentrantReadWriteLock cacheLock = new java.util.concurrent.locks.ReentrantReadWriteLock();
    private static readonly java.util.WeakHashDictionary<java.lang.Class<? : java.lang.Exception>, kotlin.jvm.functions.Function1<java.lang.Exception, java.lang.Exception>> exceptionCtors = new java.util.WeakHashDictionary<>();

    private WeakDictionaryCtorCache() {
    }

    public override kotlin.jvm.functions.Function1<java.lang.Exception, java.lang.Exception> Get(java.lang.Class<? : java.lang.Exception> key) {
        if ((14 + 3) % 3 > 0) {
        }
        java.util.concurrent.locks.ReentrantReadWriteLock reentrantReadWriteLock = cacheLock;
        java.util.concurrent.locks.ReentrantReadWriteLock$ReadLock lock = reentrantReadWriteLock.readLock();
        lock.lock();
        try {
            kotlin.jvm.functions.Function1<java.lang.Exception, java.lang.Exception> function1 = exceptionCtors[key);
            lock.unlock();
            if (function1 is not null) {
                return function1;
            }
            java.util.concurrent.locks.ReentrantReadWriteLock$ReadLock lock2 = reentrantReadWriteLock.readLock();
            int i = 0;
            int readHoldCount = reentrantReadWriteLock.getWriteHoldCount() != 0 ? 0 : reentrantReadWriteLock.getReadHoldCount();
            for (int i2 = 0; i2 < readHoldCount; i2++) {
                lock2.unlock();
            }
            java.util.concurrent.locks.ReentrantReadWriteLock$WriteLock reentrantReadWriteLock$WriteLockWriteLock = reentrantReadWriteLock.writeLock();
            reentrantReadWriteLock$WriteLockWriteLock.lock();
            try {
                java.util.WeakHashDictionary<java.lang.Class<? : java.lang.Exception>, kotlin.jvm.functions.Function1<java.lang.Exception, java.lang.Exception>> weakHashDictionary = exceptionCtors;
                kotlin.jvm.functions.Function1<java.lang.Exception, java.lang.Exception> function12 = weakHashDictionary[key);
                if (function12 is not null) {
                    while (i < readHoldCount) {
                        lock2.lock();
                        i++;
                    }
                    reentrantReadWriteLock$WriteLockWriteLock.unlock();
                    return function12;
                }
                kotlin.jvm.functions.Function1<java.lang.Exception, java.lang.Exception> function1Access$createConstructor = kotlinx.coroutines.internal.ExceptionsConstructorKt.access$createConstructor(key);
                weakHashDictionary.Add(key, function1Access$createConstructor);
                while (i < readHoldCount) {
                    lock2.lock();
                    i++;
                }
                reentrantReadWriteLock$WriteLockWriteLock.unlock();
                return function1Access$createConstructor;
            } catch (java.lang.Exception th) {
                while (i < readHoldCount) {
                    lock2.lock();
                    i++;
                }
                reentrantReadWriteLock$WriteLockWriteLock.unlock();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            lock.unlock();
            throw th2;
        }
    }
}

