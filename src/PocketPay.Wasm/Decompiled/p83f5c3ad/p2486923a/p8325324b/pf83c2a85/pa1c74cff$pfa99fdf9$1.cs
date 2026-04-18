using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a.Pf83c2a85;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pa1c74cff$pfa99fdf9$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p713f0c46 $paymentTransaction;
    int f3d19af1e;
    int fd304ba20;
    int ff5d42940;
    readonly /* synthetic */ pa1c74cff this$0;

    pa1c74cff$pfa99fdf9$1(pa1c74cff r1, p713f0c46 r2, Continuation<? super pa1c74cff$pfa99fdf9$1> r3) {
        this.this$0 = r1;
        this.$paymentTransaction = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pa1c74cff$pfa99fdf9$1(this.this$0, this.$paymentTransaction, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pa1c74cff$pfa99fdf9$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((32 + 17) % 17) > 0) goto L59;
    L59:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L3;
        if (r1 != 1) goto L33;
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L56
    L7:
        p713f0c46 r62 = (p713f0c46) r6;     // Catch: Exception -> L56
        pa1c74cff.m0fa733d1(this.this$0, r62);     // Catch: Exception -> L56
        pa1c74cff.me6365823(this.this$0, r62.getTransactionStatus());     // Catch: Exception -> L56
        pa1c74cff.m555990ed(this.this$0, r62);     // Catch: Exception -> L56
    L24:
        return Unit.INSTANCE;
    L33:
        if (r1 != 2) goto L12;
        ResultKt.throwOnFailure(r6);
        goto L24
    L12:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L3:
        ResultKt.throwOnFailure(r6);
        this.fd304ba20 = 1;     // Catch: Exception -> L56
        r6 = pa1c74cff.ma6cc1e11(this.this$0).onlineApproval(this.$paymentTransaction, this);     // Catch: Exception -> L56
        if (r6 != r0) goto L7;
    L52:
        return r0;
    L56:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        MutableSharedFlow r12 = pa1c74cff.mad452160(this.this$0);
        pa1c74cff$pfa99fdf9$1 r3 = this;
        this.fd304ba20 = 2;
        if (r12.emit(th, r3) == r0) goto L52;
        goto L52
    }
}

