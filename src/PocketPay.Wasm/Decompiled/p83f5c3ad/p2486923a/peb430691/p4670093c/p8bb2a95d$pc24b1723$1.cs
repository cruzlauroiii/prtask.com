using Java.Math;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P2b3583e6.P263e3cef;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p8bb2a95d$pc24b1723$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f1600610d;
    int f323b4a90;
    int fd304ba20;
    readonly /* synthetic */ p8bb2a95d this$0;

    p8bb2a95d$pc24b1723$1(p8bb2a95d r1, Continuation<? super p8bb2a95d$pc24b1723$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p8bb2a95d$pc24b1723$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p8bb2a95d$pc24b1723$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((8 + 6) % 6) > 0) goto L4;
    L4:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L40;
        if (r1 != 1) goto L30;
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L38
    L44:
        p18cf5223 r62 = (p18cf5223) r6;     // Catch: Exception -> L38
        decimal r12 = p517b902b.m29a3256d(r62);     // Catch: Exception -> L38
        pc5f0acf1 r63 = r62.getQrPayInfo();     // Catch: Exception -> L38
        if (r63 is null) goto L53;
        string r64 = r63.getOrderId();     // Catch: Exception -> L38
        if (r64 is null) goto L53;
        this.fd304ba20 = 2;     // Catch: Exception -> L38
        if (p8bb2a95d.mffe677bc(this.this$0).refund(r12, r64, this) != r0) goto L51;
    L50:
        return r0;
    L51:
        p8bb2a95d.m6573bf9e(this.this$0);     // Catch: Exception -> L38
    L66:
        return Unit.INSTANCE;
    L53:
        throw new Exception("ReferenceId is empty");     // Catch: Exception -> L38
    L30:
        if (r1 != 2) goto L61;
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L38
        goto L51
    L61:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L40:
        ResultKt.throwOnFailure(r6);
        p8bb2a95d.m8cffa965(this.this$0).setValue(pa4ecfc70.f910eef8c.loading());     // Catch: Exception -> L38
        this.fd304ba20 = 1;     // Catch: Exception -> L38
        r6 = p8bb2a95d.md95a43c7(this.this$0).getCurrentPaybackReceipt(this);     // Catch: Exception -> L38
        if (r6 != r0) goto L44;
    L38:
        e = move-exception;
        p8bb2a95d.m8cffa965(this.this$0).setValue(pa4ecfc70.f910eef8c.error(e));
        goto L66
    }
}

