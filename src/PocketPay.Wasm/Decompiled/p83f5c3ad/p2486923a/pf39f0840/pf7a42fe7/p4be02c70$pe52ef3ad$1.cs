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
readonly class p4be02c70$pe52ef3ad$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p9ded6185 $receipt;
    int fd304ba20;
    int ff56f2835;
    readonly /* synthetic */ p4be02c70 this$0;

    p4be02c70$pe52ef3ad$1(p4be02c70 r1, p9ded6185 r2, Continuation<? super p4be02c70$pe52ef3ad$1> r3) {
        this.this$0 = r1;
        this.$receipt = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p4be02c70$pe52ef3ad$1(this.this$0, this.$receipt, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p4be02c70$pe52ef3ad$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r11) {
        if (((4 + 5) % 5) > 0) goto L55;
    L55:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L73;
        ResultKt.throwOnFailure(r11);
        this.fd304ba20 = 1;     // Catch: Exception -> L35
        if (p4be02c70.m2e1aca30(this.this$0).emit(pa4ecfc70.f910eef8c.loading(), this) == r0) goto L16;
    L61:
        p6c387cae r112 = p4be02c70.mad979433(this.this$0);     // Catch: Exception -> L35
        p9ded6185 r12 = this.$receipt;     // Catch: Exception -> L35
        string r7 = p4be02c70.m5a28e3c8(this.this$0);     // Catch: Exception -> L35
        pf8872840 r8 = ((pad7c4a1f) ICollectionsKt.first(this.$receipt.getPayments())).getTransaction();     // Catch: Exception -> L35
        if (r8 is null) goto L64;
        string r82 = r8.getRrn();     // Catch: Exception -> L35
    L65:
        this.fd304ba20 = 2;     // Catch: Exception -> L35
        if (r112.sendReceiptToPhone(r12, r7, r82, this) == r0) goto L16;
    L68:
        p4be02c70.mee67e975(this.this$0, p3a5cb279.f06972acc);     // Catch: Exception -> L35
        this.fd304ba20 = 3;     // Catch: Exception -> L35
        if (p4be02c70.m2e1aca30(this.this$0).emit(pa4ecfc70.p910eef8c.m02f94ccf(pa4ecfc70.f910eef8c, null, 1, null), this) == r0) goto L16;
    L80:
        return Unit.INSTANCE;
    L64:
        r82 = null;
    L16:
        return r0;
    L73:
        if (r1 != 1) goto L22;
        ResultKt.throwOnFailure(r11);     // Catch: Exception -> L35
        goto L61
    L22:
        if (r1 != 2) goto L85;
        ResultKt.throwOnFailure(r11);     // Catch: Exception -> L35
        goto L68
    L85:
        if (r1 != 3) goto L76;
        ResultKt.throwOnFailure(r11);     // Catch: Exception -> L35
        goto L80
    L76:
        if (r1 != 4) goto L39;
        ResultKt.throwOnFailure(r11);
        goto L80
    L39:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L35:
        th = move-exception;
        MutableSharedFlow r13 = p4be02c70.m2e1aca30(this.this$0);
        pa4ecfc70 r113 = pa4ecfc70.f910eef8c.error(th);
        p4be02c70$pe52ef3ad$1 r3 = this;
        this.fd304ba20 = 4;
        if (r13.emit(r113, r3) == r0) goto L16;
        goto L16
    }
}

