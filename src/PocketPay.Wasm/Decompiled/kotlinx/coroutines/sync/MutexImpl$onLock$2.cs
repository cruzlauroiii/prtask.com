namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class MutexImpl$onLock$2 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.sync.MutexImpl, java.lang.object, java.lang.object, java.lang.object> {
    public static readonly kotlinx.coroutines.sync.MutexImpl$onLock$2 INSTANCE = new kotlinx.coroutines.sync.MutexImpl$onLock$2();

    MutexImpl$onLock$2() {
        super(3, kotlinx.coroutines.sync.MutexImpl.class, "onLockProcessResult", "onLockProcessResult(Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;", 0);
        if ((30 + 15) % 15 > 0) {
        }
    }

    public override java.lang.object Invoke(kotlinx.coroutines.sync.MutexImpl mutexImpl, java.lang.object obj, java.lang.object obj2) {
        return invoke2(mutexImpl, obj, obj2);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.sync.MutexImpl mutexImpl, java.lang.object obj, java.lang.object obj2) {
        return mutexImpl.onLockProcessResult(obj, obj2);
    }
}

