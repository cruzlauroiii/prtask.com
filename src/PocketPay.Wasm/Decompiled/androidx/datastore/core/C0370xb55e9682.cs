namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.datastore.core.MultiProcessCoordinator$incrementAndGetVersion$$inlined$withLazyCounter$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u0002H\u008a@¨\u0006\u0003"}, d2 = {"<anonymous>", "T", "Lkotlinx/coroutines/CoroutineScope;", "androidx/datastore/core/MultiProcessCoordinator$withLazyCounter$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.MultiProcessCoordinator$incrementAndGetVersion$$inlined$withLazyCounter$1", m533f = "MultiProcessCoordinator.android.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class C0370xb55e9682 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<java.lang.int>, java.lang.object> {
    int label;
    readonly /* synthetic */ androidx.datastore.core.MultiProcessCoordinator this$0;

    public C0370xb55e9682(androidx.datastore.core.MultiProcessCoordinator r1, kotlin.coroutines.Continuation r2) {
            r0 = this;
            goto L11
        L4:
            goto L14
        L7:
            return
        L8:
            goto L4
        Lc:
            r1 = 2
            goto L18
        L11:
            goto L8
        L14:
            goto L1f
        L18:
            r0.<init>(r1, r2)
            goto L7
        L1f:
            r0.this$0 = r1
            goto Lc
    }

    public static java.lang.object CDMrecwmCzLYwBDe() {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static int HlcxfIfKpoUdkSYv(androidx.datastore.core.SharedCounter r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            int r0 = r1.incrementAndGetValue()
            goto Le
    }

    public static java.lang.object UqzGAHBDSvWnBzUC(androidx.datastore.core.C0370xb55e9682 r1, java.lang.object r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.object r0 = r1.invokeSuspend(r2)
            goto Le
    }

    public static java.lang.object UuuwTVEMURPcVwdU(androidx.datastore.core.C0370xb55e9682 r1, kotlinx.coroutines.CoroutineScope r2, kotlin.coroutines.Continuation r3) {
            goto Lc
        L4:
            java.lang.object r0 = r1.invoke2(r2, r3)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static androidx.datastore.core.SharedCounter AWFzeeeriVXMYlWC(androidx.datastore.core.MultiProcessCoordinator r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            androidx.datastore.core.SharedCounter r0 = androidx.datastore.core.MultiProcessCoordinator.access$getSharedCounter(r1)
            goto Le
    }

    public static void MrSqlcffhRgMbMHp(java.lang.object r0) {
            goto L13
        L4:
            kotlin.ResultKt.throwOnFailure(r0)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static java.lang.int RfndYTSfpjQyKRqf(int r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.int r0 = kotlin.coroutines.jvm.internal.Boxing.boxInt(r1)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static kotlin.coroutines.Continuation XQDgYnMCdrejIBrw(androidx.datastore.core.C0370xb55e9682 r1, java.lang.object r2, kotlin.coroutines.Continuation r3) {
            goto Lc
        L4:
            kotlin.coroutines.Continuation r0 = r1.create(r2, r3)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r1, kotlin.coroutines.Continuation<object> r2) {
            r0 = this;
            goto Lf
        L4:
            return r1
        L5:
            goto L1c
        L9:
            androidx.datastore.core.MultiProcessCoordinator$incrementAndGetVersion$$inlined$withLazyCounter$1 r1 = new androidx.datastore.core.MultiProcessCoordinator$incrementAndGetVersion$$inlined$withLazyCounter$1
            goto L16
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            androidx.datastore.core.MultiProcessCoordinator r0 = r0.this$0
            goto L1f
        L1c:
            goto L12
        L1f:
            r1.<init>(r0, r2)
            goto L26
        L26:
            kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
            goto L4
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<java.lang.int> r2) {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L23
        La:
            goto L16
        Le:
            java.lang.object r0 = UuuwTVEMURPcVwdU(r0, r1, r2)
            goto L22
        L16:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L1c
        L1c:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto Le
        L22:
            return r0
        L23:
            goto L4
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<java.lang.int> r2) {
            r0 = this;
            goto L20
        L4:
            goto L23
        L7:
            return r0
        L8:
            goto L4
        Lc:
            androidx.datastore.core.MultiProcessCoordinator$incrementAndGetVersion$$inlined$withLazyCounter$1 r0 = (androidx.datastore.core.C0370xb55e9682) r0
            goto L12
        L12:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L27
        L18:
            kotlin.coroutines.Continuation r0 = xQDgYnMCdrejIBrw(r0, r1, r2)
            goto Lc
        L20:
            goto L8
        L23:
            goto L18
        L27:
            java.lang.object r0 = UqzGAHBDSvWnBzUC(r0, r1)
            goto L7
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
            r1 = this;
            goto Ld
        L4:
            if (r0 == 0) goto L9
            goto L2f
        L9:
            goto L27
        Ld:
            goto L5d
        L10:
            goto L4d
        L14:
            java.lang.string r2 = "call to 'resume' before 'invoke' with coroutine"
            goto L1a
        L1a:
            r1.<init>(r2)
            goto L5c
        L21:
            int r0 = r1.label
            goto L4
        L27:
            mrSqlcffhRgMbMHp(r2)
            goto L33
        L2e:
            return r1
        L2f:
            goto L39
        L33:
            androidx.datastore.core.MultiProcessCoordinator r2 = r1.this$0
            goto L61
        L39:
            java.lang.IllegalStateException r1 = new java.lang.IllegalStateException
            goto L14
        L3f:
            java.lang.int r1 = rfndYTSfpjQyKRqf(r1)
            goto L2e
        L47:
            kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
            goto L54
        L4d:
            CDMrecwmCzLYwBDe()
            goto L21
        L54:
            int r1 = HlcxfIfKpoUdkSYv(r2)
            goto L3f
        L5c:
            throw r1
        L5d:
            goto L69
        L61:
            androidx.datastore.core.SharedCounter r2 = aWFzeeeriVXMYlWC(r2)
            goto L47
        L69:
            goto L10
    }
}

