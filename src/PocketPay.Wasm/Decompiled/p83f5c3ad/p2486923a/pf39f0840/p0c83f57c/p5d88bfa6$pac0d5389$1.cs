using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P83f5c3ad.P684019bc;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p5d88bfa6$pac0d5389$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p9ded6185 $receipt;
    int fc773ddd3;
    int fd19be953;
    int fd304ba20;
    int ffe483fda;
    readonly /* synthetic */ p5d88bfa6 this$0;

    p5d88bfa6$pac0d5389$1(p5d88bfa6 r1, p9ded6185 r2, Continuation<? super p5d88bfa6$pac0d5389$1> r3) {
        this.this$0 = r1;
        this.$receipt = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p5d88bfa6$pac0d5389$1(this.this$0, this.$receipt, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p5d88bfa6$pac0d5389$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r11) {
        if (((20 + 11) % 11) > 0) goto L80;
    L80:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L47;
        if (r1 != 1) goto L86;
        ResultKt.throwOnFailure(r11);     // Catch: Exception -> L15
    L51:
        p6c387cae r112 = p5d88bfa6.mad979433(this.this$0);     // Catch: Exception -> L15
        p9ded6185 r12 = this.$receipt;     // Catch: Exception -> L15
        string r7 = p5d88bfa6.m8163c47d(this.this$0);     // Catch: Exception -> L15
        pf8872840 r8 = ((pad7c4a1f) ICollectionsKt.first(this.$receipt.getPayments())).getTransaction();     // Catch: Exception -> L15
        if (r8 is null) goto L54;
        string r82 = r8.getRrn();     // Catch: Exception -> L15
    L55:
        this.fd304ba20 = 2;     // Catch: Exception -> L15
        if (r112.sendReceiptToEmail(r12, r7, r82, this) == r0) goto L84;
    L58:
        p5d88bfa6.mee67e975(this.this$0, p3a5cb279.f06972acc);     // Catch: Exception -> L15
        this.fd304ba20 = 3;     // Catch: Exception -> L15
        if (p5d88bfa6.m2e1aca30(this.this$0).emit(pa4ecfc70.p910eef8c.m02f94ccf(pa4ecfc70.f910eef8c, null, 1, null), this) == r0) goto L84;
    L81:
        return Unit.INSTANCE;
    L84:
        return r0;
    L54:
        r82 = null;
        goto L55
    L86:
        if (r1 != 2) goto L24;
        ResultKt.throwOnFailure(r11);     // Catch: Exception -> L15
        goto L58
    L24:
        if (r1 != 3) goto L42;
        ResultKt.throwOnFailure(r11);     // Catch: Exception -> L15
        goto L81
    L42:
        if (r1 != 4) goto L17;
        ResultKt.throwOnFailure(r11);
        goto L81
    L17:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L47:
        ResultKt.throwOnFailure(r11);
        this.fd304ba20 = 1;     // Catch: Exception -> L15
        if (p5d88bfa6.m2e1aca30(this.this$0).emit(pa4ecfc70.f910eef8c.loading(), this) != r0) goto L51;
    L15:
        th = move-exception;
        MutableSharedFlow r13 = p5d88bfa6.m2e1aca30(this.this$0);
        pa4ecfc70 r113 = pa4ecfc70.f910eef8c.error(th);
        p5d88bfa6$pac0d5389$1 r3 = this;
        this.fd304ba20 = 4;
        if (r13.emit(r113, r3) == r0) goto L84;
        goto L84
    }
}

