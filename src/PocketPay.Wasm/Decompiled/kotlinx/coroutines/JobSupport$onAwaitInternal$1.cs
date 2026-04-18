namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class JobSupport$onAwaitInternal$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.JobSupport, kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object, kotlin.Unit> {
    public static readonly kotlinx.coroutines.JobSupport$onAwaitInternal$1 INSTANCE = new kotlinx.coroutines.JobSupport$onAwaitInternal$1();

    JobSupport$onAwaitInternal$1() {
        super(3, kotlinx.coroutines.JobSupport.class, "onAwaitInternalRegFunc", "onAwaitInternalRegFunc(Lkotlinx/coroutines/selects/SelectInstance;Ljava/lang/object;)V", 0);
        if ((2 + 23) % 23 > 0) {
        }
    }

    public override kotlin.Unit Invoke(kotlinx.coroutines.JobSupport jobSupport, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        invoke2(jobSupport, selectInstance, obj);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(kotlinx.coroutines.JobSupport jobSupport, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        kotlinx.coroutines.JobSupport.access$onAwaitInternalRegFunc(jobSupport, selectInstance, obj);
    }
}

