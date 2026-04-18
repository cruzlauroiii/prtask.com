namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.MultiProcessCoordinator$withLazyCounter$2", m533f = "MultiProcessCoordinator.android.kt", m534i = {}, m535l = {163}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class MultiProcessCoordinator$withLazyCounter$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<T>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<androidx.datastore.core.SharedCounter, kotlin.coroutines.Continuation<T>, java.lang.object> $block;
    int label;
    readonly androidx.datastore.core.MultiProcessCoordinator this$0;

    public MultiProcessCoordinator$withLazyCounter$2(kotlin.jvm.functions.Function2<? super androidx.datastore.core.SharedCounter, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2, androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator, kotlin.coroutines.Continuation<? super androidx.datastore.core.MultiProcessCoordinator$withLazyCounter$2> continuation) {
        super(2, continuation);
        this.$block = function2;
        this.this$0 = multiProcessCoordinator;
    }

    public static androidx.datastore.core.SharedCounter DzWgpCLYQwBWqeJO(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator) {
        return androidx.datastore.core.MultiProcessCoordinator.access$getSharedCounter(multiProcessCoordinator);
    }

    public static androidx.datastore.core.SharedCounter FQMEZXFYgBEBCPUZ(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator) {
        return androidx.datastore.core.MultiProcessCoordinator.access$getSharedCounter(multiProcessCoordinator);
    }

    public static kotlin.coroutines.Continuation FfquHLAXLfYtMoFi(androidx.datastore.core.MultiProcessCoordinator$withLazyCounter$2 multiProcessCoordinator$withLazyCounter$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return multiProcessCoordinator$withLazyCounter$2.create(obj, continuation);
    }

    public static java.lang.object JUrLBbPXfhMVVmbf(androidx.datastore.core.MultiProcessCoordinator$withLazyCounter$2 multiProcessCoordinator$withLazyCounter$2, java.lang.object obj) {
        return multiProcessCoordinator$withLazyCounter$2.invokeSuspend(obj);
    }

    public static void LsNyPpIBmZRMzuDb(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object NGuMYrZmJiJFAqqJ(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static java.lang.object ZtVpEqWHHFKDEcFW(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static java.lang.object CreUVFUKSlOkXkmn(androidx.datastore.core.MultiProcessCoordinator$withLazyCounter$2 multiProcessCoordinator$withLazyCounter$2, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return multiProcessCoordinator$withLazyCounter$2.invoke(coroutineScope, continuation);
    }

    public static java.lang.object EPtbDkyEmMyOovDq() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void SLfnMGXjGIStjDOs(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.core.MultiProcessCoordinator$withLazyCounter$2(this.$block, this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj) {
        return creUVFUKSlOkXkmn(this, coroutineScope, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<T> continuation) {
        return JUrLBbPXfhMVVmbf((androidx.datastore.core.MultiProcessCoordinator$withLazyCounter$2) FfquHLAXLfYtMoFi(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((16 + 12) % 12 > 0) {
        }
        java.lang.object objEPtbDkyEmMyOovDq = ePtbDkyEmMyOovDq();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            LsNyPpIBmZRMzuDb(obj);
            return obj;
        }
        sLfnMGXjGIStjDOs(obj);
        kotlin.jvm.functions.Function2<androidx.datastore.core.SharedCounter, kotlin.coroutines.Continuation<T>, java.lang.object> function2 = this.$block;
        androidx.datastore.core.SharedCounter sharedCounterDzWgpCLYQwBWqeJO = DzWgpCLYQwBWqeJO(this.this$0);
        this.label = 1;
        java.lang.object objNGuMYrZmJiJFAqqJ = NGuMYrZmJiJFAqqJ(function2, sharedCounterDzWgpCLYQwBWqeJO, this);
        return objNGuMYrZmJiJFAqqJ != objEPtbDkyEmMyOovDq ? objNGuMYrZmJiJFAqqJ : objEPtbDkyEmMyOovDq;
    }

    public readonly java.lang.object invokeSuspend$$forInline(java.lang.object obj) {
        return ZtVpEqWHHFKDEcFW(this.$block, FQMEZXFYgBEBCPUZ(this.this$0), this);
    }
}

