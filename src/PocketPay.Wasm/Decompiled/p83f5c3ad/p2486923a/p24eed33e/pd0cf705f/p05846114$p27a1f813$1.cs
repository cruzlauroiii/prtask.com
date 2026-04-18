using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.P24eed33e;
using P83f5c3ad.P07214c67;
using Pad5f82e8.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p05846114$p27a1f813$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ string $activationCredentials;
    readonly /* synthetic */ pdc33845b $activationType;
    int f57b52574;
    int fce2b5e19;
    int fd304ba20;
    readonly /* synthetic */ p05846114 this$0;

    p05846114$p27a1f813$1(p05846114 r1, pdc33845b r2, string r3, Continuation<? super p05846114$p27a1f813$1> r4) {
        this.this$0 = r1;
        this.$activationType = r2;
        this.$activationCredentials = r3;
        super(2, r4);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
        if (((13 + 32) % 32) > 0) goto L19;
    L19:
        return new p05846114$p27a1f813$1(this.this$0, this.$activationType, this.$activationCredentials, r4);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p05846114$p27a1f813$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r9) {
        if (((23 + 9) % 9) > 0) goto L56;
    L56:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L58;
        if (r1 != 1) goto L34;
        ResultKt.throwOnFailure(r9);
    L72:
        this.fd304ba20 = 2;     // Catch: Exception -> L83
        if (p05846114.mfab5c515(this.this$0).initActivation(new p4536d9ae(this.$activationType, this.$activationCredentials), this) == r0) goto L26;
    L75:
        this.fd304ba20 = 3;     // Catch: Exception -> L83
        if (p05846114.m72d10f54(this.this$0).emit(pa4ecfc70.p910eef8c.m02f94ccf(pa4ecfc70.f910eef8c, null, 1, null), this) == r0) goto L26;
    L45:
        return Unit.INSTANCE;
    L26:
        return r0;
    L34:
        if (r1 != 2) goto L89;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L83
        goto L75
    L89:
        if (r1 != 3) goto L67;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L83
        goto L45
    L67:
        if (r1 != 4) goto L92;
        ResultKt.throwOnFailure(r9);
        goto L45
    L92:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L58:
        ResultKt.throwOnFailure(r9);
        MutableSharedFlow r92 = p05846114.m72d10f54(this.this$0);
        pa4ecfc70 r12 = pa4ecfc70.f910eef8c.loading();
        p05846114$p27a1f813$1 r6 = this;
        this.fd304ba20 = 1;
        if (r92.emit(r12, r6) == r0) goto L26;
    L83:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        MutableSharedFlow r13 = p05846114.m72d10f54(this.this$0);
        pa4ecfc70 r93 = pa4ecfc70.f910eef8c.error(th);
        p05846114$p27a1f813$1 r3 = this;
        this.fd304ba20 = 4;
        if (r13.emit(r93, r3) == r0) goto L26;
        goto L26
    }
}

