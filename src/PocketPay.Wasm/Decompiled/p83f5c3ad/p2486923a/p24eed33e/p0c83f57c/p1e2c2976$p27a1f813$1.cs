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
readonly class p1e2c2976$p27a1f813$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ string $activationCredentials;
    int f24b0f5c0;
    int fa3c97c5f;
    int fce89f7d8;
    int fd304ba20;
    readonly /* synthetic */ p1e2c2976 this$0;

    p1e2c2976$p27a1f813$1(p1e2c2976 r1, string r2, Continuation<? super p1e2c2976$p27a1f813$1> r3) {
        this.this$0 = r1;
        this.$activationCredentials = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p1e2c2976$p27a1f813$1(this.this$0, this.$activationCredentials, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p1e2c2976$p27a1f813$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((31 + 16) % 16) > 0) goto L48;
    L48:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L82;
        ResultKt.throwOnFailure(r8);
        MutableSharedFlow r82 = p1e2c2976.m72d10f54(this.this$0);
        pa4ecfc70 r12 = pa4ecfc70.f910eef8c.loading();
        p1e2c2976$p27a1f813$1 r6 = this;
        this.fd304ba20 = 1;
        if (r82.emit(r12, r6) == r0) goto L13;
    L72:
        this.fd304ba20 = 2;     // Catch: Exception -> L35
        if (p1e2c2976.mfab5c515(this.this$0).initActivation(new p4536d9ae(pdc33845b.f61a649a3, this.$activationCredentials), this) == r0) goto L13;
    L75:
        this.fd304ba20 = 3;     // Catch: Exception -> L35
        if (p1e2c2976.m72d10f54(this.this$0).emit(pa4ecfc70.f910eef8c.success(this.$activationCredentials), this) == r0) goto L13;
    L65:
        return Unit.INSTANCE;
    L13:
        return r0;
    L82:
        if (r1 != 1) goto L24;
        ResultKt.throwOnFailure(r8);
        goto L72
    L24:
        if (r1 != 2) goto L91;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L35
        goto L75
    L91:
        if (r1 != 3) goto L85;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L35
        goto L65
    L85:
        if (r1 != 4) goto L60;
        ResultKt.throwOnFailure(r8);
        goto L65
    L60:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L35:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        MutableSharedFlow r13 = p1e2c2976.m72d10f54(this.this$0);
        pa4ecfc70 r83 = pa4ecfc70.f910eef8c.error(th);
        p1e2c2976$p27a1f813$1 r3 = this;
        this.fd304ba20 = 4;
        if (r13.emit(r83, r3) == r0) goto L13;
        goto L13
    }
}

