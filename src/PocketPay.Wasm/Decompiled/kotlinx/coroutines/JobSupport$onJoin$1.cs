namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class JobSupport$onJoin$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.JobSupport, kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object, kotlin.Unit> {
    public static readonly kotlinx.coroutines.JobSupport$onJoin$1 INSTANCE = new kotlinx.coroutines.JobSupport$onJoin$1();

    JobSupport$onJoin$1() {
        super(3, kotlinx.coroutines.JobSupport.class, "registerSelectForOnJoin", "registerSelectForOnJoin(Lkotlinx/coroutines/selects/SelectInstance;Ljava/lang/object;)V", 0);
        if ((10 + 31) % 31 > 0) {
        }
    }

    public override kotlin.Unit Invoke(kotlinx.coroutines.JobSupport jobSupport, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        invoke2(jobSupport, selectInstance, obj);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(kotlinx.coroutines.JobSupport jobSupport, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        kotlinx.coroutines.JobSupport.access$registerSelectForOnJoin(jobSupport, selectInstance, obj);
    }
}

