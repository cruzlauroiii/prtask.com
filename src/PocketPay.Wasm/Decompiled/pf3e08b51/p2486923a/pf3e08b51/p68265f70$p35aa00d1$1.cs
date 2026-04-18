using Android.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
readonly class p68265f70$p35aa00d1$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int fa4a0873a;
    int fd304ba20;
    readonly /* synthetic */ p68265f70 this$0;

    p68265f70$p35aa00d1$1(p68265f70 r1, Continuation<? super p68265f70$p35aa00d1$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p68265f70$p35aa00d1$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p68265f70$p35aa00d1$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((13 + 32) % 32) > 0) goto L35;
    L35:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L45;
        if (r1 != 1) goto L16;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L79
    L49:
        ped663a3e r52 = (ped663a3e) r5;     // Catch: Exception -> L79
        if (r52.getPaymentType() == p8c261c90.f9cb40e51) goto L52;
    L63:
        this.fd304ba20 = 2;     // Catch: Exception -> L43
        r5 = p68265f70.md95a43c7(this.this$0).getCurrentPaybackReceipt(this);     // Catch: Exception -> L43
        if (r5 != r0) goto L66;
    L65:
        return r0;
    L66:
        p18cf5223 r53 = (p18cf5223) r5;     // Catch: Exception -> L43
        if (r53.getPaymentType() != p8c261c90.f9cb40e51) goto L33;
        if (r53.getPayments().Count == 0 == true) goto L33;
        p68265f70.mc8f818ae(this.this$0).setValue(pa4ecfc70.f910eef8c.success(r53));     // Catch: Exception -> L43
        return Unit.INSTANCE;
    L33:
        p68265f70.mc8f818ae(this.this$0).setValue(pa4ecfc70.f910eef8c.error(new Exception()));
        return Unit.INSTANCE;
    L52:
        if (r52.getPayments().Count == 0 == true) goto L63;
        p68265f70.mc8f818ae(this.this$0).setValue(pa4ecfc70.f910eef8c.success(r52));     // Catch: Exception -> L79
        return Unit.INSTANCE;
    L16:
        if (r1 != 2) goto L8;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L43
        goto L66
    L8:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L45:
        ResultKt.throwOnFailure(r5);
        this.fd304ba20 = 1;     // Catch: Exception -> L79
        r5 = p68265f70.m260c792f(this.this$0).getCurrentSellReceipt(this);     // Catch: Exception -> L79
        if (r5 != r0) goto L49;
    L79:
        e = move-exception;
        Console.e(this.this$0.tostring(), string.valueOf(e.getMessage()));
    L43:
        e = move-exception;
        Console.e(this.this$0.tostring(), string.valueOf(e.getMessage()));
        goto L33
    }
}

