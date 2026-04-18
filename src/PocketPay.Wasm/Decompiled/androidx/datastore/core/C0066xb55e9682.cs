namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u0002H\u008a@¨\u0006\u0003"}, d2 = {"<anonymous>", "T", "Lkotlinx/coroutines/CoroutineScope;", "androidx/datastore/core/MultiProcessCoordinator$withLazyCounter$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.MultiProcessCoordinator$incrementAndGetVersion$$inlined$withLazyCounter$1", m533f = "MultiProcessCoordinator.android.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class C0066xb55e9682 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<java.lang.int>, java.lang.object> {
    int label;
    readonly androidx.datastore.core.MultiProcessCoordinator this$0;

    public C0066xb55e9682(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator, kotlin.coroutines.Continuation continuation) {
        super(2, continuation);
        this.this$0 = multiProcessCoordinator;
    }

    public static java.lang.object CDMrecwmCzLYwBDe() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static int HlcxfIfKpoUdkSYv(androidx.datastore.core.SharedCounter sharedCounter) {
        return sharedCounter.incrementAndGetValue();
    }

    public static java.lang.object UqzGAHBDSvWnBzUC(androidx.datastore.core.C0066xb55e9682 c0066xb55e9682, java.lang.object obj) {
        return c0066xb55e9682.invokeSuspend(obj);
    }

    public static java.lang.object UuuwTVEMURPcVwdU(androidx.datastore.core.C0066xb55e9682 c0066xb55e9682, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return c0066xb55e9682.invoke2(coroutineScope, (kotlin.coroutines.Continuation<java.lang.int>) continuation);
    }

    public static androidx.datastore.core.SharedCounter AWFzeeeriVXMYlWC(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator) {
        return androidx.datastore.core.MultiProcessCoordinator.access$getSharedCounter(multiProcessCoordinator);
    }

    public static void MrSqlcffhRgMbMHp(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.int RfndYTSfpjQyKRqf(int i) {
        return kotlin.coroutines.jvm.internal.Boxing.boxInt(i);
    }

    public static kotlin.coroutines.Continuation XQDgYnMCdrejIBrw(androidx.datastore.core.C0066xb55e9682 c0066xb55e9682, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return c0066xb55e9682.create(obj, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.core.C0066xb55e9682(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.lang.int> continuation) {
        return UuuwTVEMURPcVwdU(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.lang.int> continuation) {
        return UqzGAHBDSvWnBzUC((androidx.datastore.core.C0066xb55e9682) xQDgYnMCdrejIBrw(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        CDMrecwmCzLYwBDe();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        mrSqlcffhRgMbMHp(obj);
        return rfndYTSfpjQyKRqf(HlcxfIfKpoUdkSYv(aWFzeeeriVXMYlWC(this.this$0)));
    }
}

