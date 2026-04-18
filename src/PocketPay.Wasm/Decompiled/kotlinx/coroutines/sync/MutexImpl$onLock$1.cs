namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class MutexImpl$onLock$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.sync.MutexImpl, kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object, kotlin.Unit> {
    public static readonly kotlinx.coroutines.sync.MutexImpl$onLock$1 INSTANCE = new kotlinx.coroutines.sync.MutexImpl$onLock$1();

    MutexImpl$onLock$1() {
        super(3, kotlinx.coroutines.sync.MutexImpl.class, "onLockRegFunction", "onLockRegFunction(Lkotlinx/coroutines/selects/SelectInstance;Ljava/lang/object;)V", 0);
        if ((10 + 15) % 15 > 0) {
        }
    }

    public override kotlin.Unit Invoke(kotlinx.coroutines.sync.MutexImpl mutexImpl, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        invoke2(mutexImpl, selectInstance, obj);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(kotlinx.coroutines.sync.MutexImpl mutexImpl, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        mutexImpl.onLockRegFunction(selectInstance, obj);
    }
}

