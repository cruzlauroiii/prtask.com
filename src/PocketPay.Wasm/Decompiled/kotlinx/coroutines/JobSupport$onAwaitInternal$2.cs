namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class JobSupport$onAwaitInternal$2 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.JobSupport, java.lang.object, java.lang.object, java.lang.object> {
    public static readonly kotlinx.coroutines.JobSupport$onAwaitInternal$2 INSTANCE = new kotlinx.coroutines.JobSupport$onAwaitInternal$2();

    JobSupport$onAwaitInternal$2() {
        super(3, kotlinx.coroutines.JobSupport.class, "onAwaitInternalProcessResFunc", "onAwaitInternalProcessResFunc(Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;", 0);
        if ((2 + 2) % 2 > 0) {
        }
    }

    public override java.lang.object Invoke(kotlinx.coroutines.JobSupport jobSupport, java.lang.object obj, java.lang.object obj2) {
        return invoke2(jobSupport, obj, obj2);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.JobSupport jobSupport, java.lang.object obj, java.lang.object obj2) {
        return kotlinx.coroutines.JobSupport.access$onAwaitInternalProcessResFunc(jobSupport, obj, obj2);
    }
}

