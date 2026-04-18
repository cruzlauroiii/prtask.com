using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using Pad5f82e8.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p05846114$pbb5eb0ce$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ string $otp;
    int fd304ba20;
    int ff808270f;
    readonly /* synthetic */ p05846114 this$0;

    p05846114$pbb5eb0ce$1(p05846114 r1, string r2, Continuation<? super p05846114$pbb5eb0ce$1> r3) {
        this.this$0 = r1;
        this.$otp = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p05846114$pbb5eb0ce$1(this.this$0, this.$otp, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p05846114$pbb5eb0ce$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((18 + 6) % 6) > 0) goto L96;
    L96:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L11;
        ResultKt.throwOnFailure(r8);
        MutableSharedFlow r82 = p05846114.m90ec6cc2(this.this$0);
        pa4ecfc70 r12 = pa4ecfc70.f910eef8c.loading();
        p05846114$pbb5eb0ce$1 r6 = this;
        this.fd304ba20 = 1;
        if (r82.emit(r12, r6) == r0) goto L78;
    L33:
        this.fd304ba20 = 2;     // Catch: Exception -> L62
        if (p05846114.mfab5c515(this.this$0).confirmRegWithOtp(this.$otp, this) == r0) goto L78;
    L36:
        p05846114.m8aa7c174(this.this$0).reportAuthSuccessEvent();     // Catch: Exception -> L62
        this.fd304ba20 = 3;     // Catch: Exception -> L62
        if (p05846114.m90ec6cc2(this.this$0).emit(pa4ecfc70.p910eef8c.m02f94ccf(pa4ecfc70.f910eef8c, null, 1, null), this) == r0) goto L78;
    L30:
        return Unit.INSTANCE;
    L78:
        return r0;
    L11:
        if (r1 == 1) goto L84;
        if (r1 != 2) goto L8;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L62
        goto L36
    L8:
        if (r1 != 3) goto L93;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L62
        goto L30
    L93:
        if (r1 != 4) goto L87;
        ResultKt.throwOnFailure(r8);
        goto L30
    L87:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L84:
        ResultKt.throwOnFailure(r8);
    L62:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        p05846114.m8aa7c174(this.this$0).reportAuthErrorEvent();
        MutableSharedFlow r13 = p05846114.m90ec6cc2(this.this$0);
        pa4ecfc70 r83 = pa4ecfc70.f910eef8c.error(th);
        p05846114$pbb5eb0ce$1 r3 = this;
        this.fd304ba20 = 4;
        if (r13.emit(r83, r3) == r0) goto L78;
        goto L78
    }
}

