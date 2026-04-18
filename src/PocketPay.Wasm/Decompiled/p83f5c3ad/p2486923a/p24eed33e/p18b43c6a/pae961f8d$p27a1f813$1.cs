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
readonly class pae961f8d$p27a1f813$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f0e6dbe92;
    int fd304ba20;
    readonly /* synthetic */ pae961f8d this$0;

    pae961f8d$p27a1f813$1(pae961f8d r1, Continuation<? super pae961f8d$p27a1f813$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new pae961f8d$p27a1f813$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pae961f8d$p27a1f813$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((17 + 11) % 11) > 0) goto L35;
    L35:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L70;
        if (r1 != 1) goto L42;
        ResultKt.throwOnFailure(r8);
    L56:
        this.fd304ba20 = 2;     // Catch: Exception -> L46
        if (pae961f8d.mfab5c515(this.this$0).initActivation(new p4536d9ae(pdc33845b.f4cecb21b, pae961f8d.m5a28e3c8(this.this$0)), this) == r0) goto L64;
    L59:
        this.fd304ba20 = 3;     // Catch: Exception -> L46
        if (pae961f8d.m72d10f54(this.this$0).emit(pa4ecfc70.f910eef8c.success(pae961f8d.m5a28e3c8(this.this$0)), this) == r0) goto L64;
    L31:
        return Unit.INSTANCE;
    L64:
        return r0;
    L42:
        if (r1 != 2) goto L28;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L46
        goto L59
    L28:
        if (r1 != 3) goto L93;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L46
        goto L31
    L93:
        if (r1 != 4) goto L13;
        ResultKt.throwOnFailure(r8);
        goto L31
    L13:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L70:
        ResultKt.throwOnFailure(r8);
        MutableSharedFlow r82 = pae961f8d.m72d10f54(this.this$0);
        pa4ecfc70 r12 = pa4ecfc70.f910eef8c.loading();
        pae961f8d$p27a1f813$1 r6 = this;
        this.fd304ba20 = 1;
        if (r82.emit(r12, r6) == r0) goto L64;
    L46:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        MutableSharedFlow r13 = pae961f8d.m72d10f54(this.this$0);
        pa4ecfc70 r83 = pa4ecfc70.f910eef8c.error(th);
        pae961f8d$p27a1f813$1 r3 = this;
        this.fd304ba20 = 4;
        if (r13.emit(r83, r3) == r0) goto L64;
        goto L64
    }
}

