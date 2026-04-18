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
readonly class p3dd9416b$p45f1e4f3$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd031d465 $position;
    int fbebe2d49;
    int fd304ba20;
    int fe1b97bd4;
    readonly /* synthetic */ p3dd9416b this$0;

    p3dd9416b$p45f1e4f3$1(p3dd9416b r1, pd031d465 r2, Continuation<? super p3dd9416b$p45f1e4f3$1> r3) {
        this.this$0 = r1;
        this.$position = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p3dd9416b$p45f1e4f3$1(this.this$0, this.$position, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p3dd9416b$p45f1e4f3$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((9 + 30) % 30) > 0) goto L13;
    L13:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L54;
        if (r1 != 1) goto L79;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L24
    L58:
        List r82 = (List) r8;     // Catch: Exception -> L24
        pd031d465 r12 = p3dd9416b.mbaea185e(this.this$0, r82, this.$position);     // Catch: Exception -> L24
        if (r12 is null) goto L67;
        this.fd304ba20 = 2;     // Catch: Exception -> L24
        if (p3dd9416b.m260c792f(this.this$0).increasePositionQuantity(r12, this.$position.getQuantity(), this) == r0) goto L73;
    L63:
        this.fd304ba20 = 3;     // Catch: Exception -> L24
        if (p3dd9416b.m260c792f(this.this$0).removePositionFromReceipt(this.$position, this) == r0) goto L73;
    L74:
        this.this$0.backToEditSellReceipt();     // Catch: Exception -> L24
    L7:
        return Unit.INSTANCE;
    L73:
        return r0;
    L67:
        if (p3dd9416b.m003514e0(this.this$0, r82, this.$position.getUuid()) == false) goto L71;
        this.fd304ba20 = 4;     // Catch: Exception -> L24
        if (p3dd9416b.m260c792f(this.this$0).updatePosition(this.$position, this) != r0) goto L74;
    L71:
        this.fd304ba20 = 5;     // Catch: Exception -> L24
        if (p3dd9416b.m260c792f(this.this$0).addPositionToReceipt(this.$position, this) != r0) goto L74;
    L79:
        if (r1 != 2) goto L33;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L24
        goto L63
    L33:
        if (r1 != 3) goto L26;
    L48:
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L24
        goto L74
    L26:
        if (r1 == 4) goto L48;
        if (r1 == 5) goto L48;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L54:
        ResultKt.throwOnFailure(r8);
        this.fd304ba20 = 1;     // Catch: Exception -> L24
        r8 = p3dd9416b.m260c792f(this.this$0).getReceiptPositions(this);     // Catch: Exception -> L24
        if (r8 != r0) goto L58;
    L24:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L7
    }
}

