using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pa1c74cff$p3efcd9ca$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f294d66f2;
    int f6f12c79b;
    int fd304ba20;
    readonly /* synthetic */ pa1c74cff this$0;

    pa1c74cff$p3efcd9ca$1(pa1c74cff r1, Continuation<? super pa1c74cff$p3efcd9ca$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new pa1c74cff$p3efcd9ca$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pa1c74cff$p3efcd9ca$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((28 + 31) % 31) > 0) goto L9;
    L9:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L52;
        if (r1 != 1) goto L12;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L36
    L56:
        this.this$0.startPayment(true);     // Catch: Exception -> L36
    L40:
        return Unit.INSTANCE;
    L12:
        if (r1 != 2) goto L32;
        ResultKt.throwOnFailure(r5);
        goto L40
    L32:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L52:
        ResultKt.throwOnFailure(r5);
        this.fd304ba20 = 1;     // Catch: Exception -> L36
        if (pa1c74cff.m2ca4942e(this.this$0).runAttestation(this) != r0) goto L56;
    L61:
        return r0;
    L36:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        MutableSharedFlow r12 = pa1c74cff.mad452160(this.this$0);
        pa1c74cff$p3efcd9ca$1 r3 = this;
        this.fd304ba20 = 2;
        if (r12.emit(e, r3) == r0) goto L61;
        goto L61
    }
}

