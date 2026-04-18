using Com.Google.Firebase.Crashlytics;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pe688e27e$p45f1e4f3$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd031d465 $position;
    int f87248e35;
    int fae634a47;
    int fd304ba20;
    int fda6a2ad9;
    readonly /* synthetic */ pe688e27e this$0;

    pe688e27e$p45f1e4f3$1(pe688e27e r1, pd031d465 r2, Continuation<? super pe688e27e$p45f1e4f3$1> r3) {
        this.this$0 = r1;
        this.$position = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pe688e27e$p45f1e4f3$1(this.this$0, this.$position, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pe688e27e$p45f1e4f3$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((1 + 18) % 18) > 0) goto L61;
    L61:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L20;
        if (r1 != 1) goto L55;
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L48
    L24:
        pe688e27e r12 = this.this$0;     // Catch: Exception -> L48
        if (pe688e27e.m003514e0(r12, (List) r6, this.$position.getUuid()) == false) goto L29;
        this.fd304ba20 = 2;     // Catch: Exception -> L48
        if (pe688e27e.m260c792f(this.this$0).updatePosition(this.$position, this) == r0) goto L31;
    L32:
        this.this$0.openPreviousScreen();     // Catch: Exception -> L48
    L65:
        return Unit.INSTANCE;
    L31:
        return r0;
    L29:
        this.fd304ba20 = 3;     // Catch: Exception -> L48
        if (pe688e27e.m260c792f(this.this$0).addPositionToReceipt(this.$position, this) != r0) goto L32;
    L55:
        if (r1 != 2) goto L11;
    L13:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L48
        goto L32
    L11:
        if (r1 == 3) goto L13;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L20:
        ResultKt.throwOnFailure(r6);
        this.fd304ba20 = 1;     // Catch: Exception -> L48
        r6 = pe688e27e.m260c792f(this.this$0).getReceiptPositions(this);     // Catch: Exception -> L48
        if (r6 != r0) goto L24;
    L48:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L65
    }
}

