namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u0002H\u008a@¨\u0006\u0003"}, d2 = {"<anonymous>", "T", "Lkotlinx/coroutines/CoroutineScope;", "androidx/datastore/core/MultiProcessCoordinator$withLazyCounter$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.MultiProcessCoordinator$getVersion$$inlined$withLazyCounter$1", m533f = "MultiProcessCoordinator.android.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class MultiProcessCoordinator$getVersion$$inlined$withLazyCounter$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<java.lang.int>, java.lang.object> {
    int label;
    readonly androidx.datastore.core.MultiProcessCoordinator this$0;

    public MultiProcessCoordinator$getVersion$$inlined$withLazyCounter$1(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator, kotlin.coroutines.Continuation continuation) {
        super(2, continuation);
        this.this$0 = multiProcessCoordinator;
    }

    public static int BoKIYxTWPqOnFZFp(androidx.datastore.core.SharedCounter sharedCounter) {
        return sharedCounter.getValue();
    }

    public static java.lang.object HzXeWNGpIMwrzlpl() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object TJkDudaCtMJeqzKS(androidx.datastore.core.MultiProcessCoordinator$getVersion$$inlined$withLazyCounter$1 multiProcessCoordinator$getVersion$$inlined$withLazyCounter$1, java.lang.object obj) {
        return multiProcessCoordinator$getVersion$$inlined$withLazyCounter$1.invokeSuspend(obj);
    }

    public static java.lang.object UOFGLNvsQkpbEFEc(androidx.datastore.core.MultiProcessCoordinator$getVersion$$inlined$withLazyCounter$1 multiProcessCoordinator$getVersion$$inlined$withLazyCounter$1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return multiProcessCoordinator$getVersion$$inlined$withLazyCounter$1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<java.lang.int>) continuation);
    }

    public static kotlin.coroutines.Continuation BnxwwBdkqfKAokEB(androidx.datastore.core.MultiProcessCoordinator$getVersion$$inlined$withLazyCounter$1 multiProcessCoordinator$getVersion$$inlined$withLazyCounter$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return multiProcessCoordinator$getVersion$$inlined$withLazyCounter$1.create(obj, continuation);
    }

    public static void CQtgQXOCYQKGivZC(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.int FYyleMsNHkgMlwum(int i) {
        return kotlin.coroutines.jvm.internal.Boxing.boxInt(i);
    }

    public static androidx.datastore.core.SharedCounter TCXitEpcVHcCMyhK(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator) {
        return androidx.datastore.core.MultiProcessCoordinator.access$getSharedCounter(multiProcessCoordinator);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.core.MultiProcessCoordinator$getVersion$$inlined$withLazyCounter$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.lang.int> continuation) {
        return UOFGLNvsQkpbEFEc(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.lang.int> continuation) {
        return TJkDudaCtMJeqzKS((androidx.datastore.core.MultiProcessCoordinator$getVersion$$inlined$withLazyCounter$1) bnxwwBdkqfKAokEB(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        HzXeWNGpIMwrzlpl();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        cQtgQXOCYQKGivZC(obj);
        return fYyleMsNHkgMlwum(BoKIYxTWPqOnFZFp(tCXitEpcVHcCMyhK(this.this$0)));
    }
}

