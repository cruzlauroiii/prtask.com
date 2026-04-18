using Java.Math;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P2b3583e6;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.P0eb9b3af.P8a5da52e.P07214c67;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p02565c40$pff060ee7$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ int $qrSize;
    object L$0;
    object L$1;
    object L$2;
    int fa73adfbf;
    int fd304ba20;
    int fe4cec0d5;
    readonly /* synthetic */ p02565c40 this$0;

    p02565c40$pff060ee7$1(p02565c40 r1, int r2, Continuation<? super p02565c40$pff060ee7$1> r3) {
        this.this$0 = r1;
        this.$qrSize = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p02565c40$pff060ee7$1(this.this$0, this.$qrSize, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p02565c40$pff060ee7$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r11) {
        if (((5 + 23) % 23) > 0) goto L63;
    L63:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L59;
        ResultKt.throwOnFailure(r11);
        this.this$0.setQrState(p8c66a8cc.ffaee4ca3);     // Catch: Exception -> L5
        p02565c40.md57a29d2(this.this$0).setValue(pa4ecfc70.f910eef8c.loading());     // Catch: Exception -> L5
        this.fd304ba20 = 1;     // Catch: Exception -> L5
        r11 = p02565c40.m260c792f(this.this$0).getCurrentSellReceipt(this);     // Catch: Exception -> L5
        if (r11 == r0) goto L54;
    L22:
        decimal r112 = p434d238d.m29a3256d((p9ded6185) r11);     // Catch: Exception -> L5
        p02565c40.mca62959a(this.this$0).setValue(r112);     // Catch: Exception -> L5
        this.fd304ba20 = 2;     // Catch: Exception -> L5
        r11 = p02565c40.mffe677bc(this.this$0).createQR(p7667d148.m55ce55f7(r112), this);     // Catch: Exception -> L5
        if (r11 == r0) goto L54;
    L25:
        p150f1761 r4 = (p150f1761) r11;     // Catch: Exception -> L5
        MutableStateFlow r113 = p02565c40.md57a29d2(this.this$0);     // Catch: Exception -> L5
        pa4ecfc70.p910eef8c r12 = pa4ecfc70.f910eef8c;     // Catch: Exception -> L5
        this.L$0 = r4;     // Catch: Exception -> L5
        this.L$1 = r113;     // Catch: Exception -> L5
        this.L$2 = r12;     // Catch: Exception -> L5
        this.fd304ba20 = 3;     // Catch: Exception -> L5
        object r3 = p02565c40.m1319e0c2(this.this$0, r4.getQrCode(), this.$qrSize, this);     // Catch: Exception -> L5
        if (r3 == r0) goto L54;
        MutableStateFlow r32 = r113;
        r11 = r3;
    L29:
        r32.setValue(r12.success(r11));     // Catch: Exception -> L5
        this.this$0.startTimer();     // Catch: Exception -> L5
        p02565c40.m520ee9e8(this.this$0, r4.getTransactionRef());     // Catch: Exception -> L5
        this.L$0 = null;     // Catch: Exception -> L5
        this.L$1 = null;     // Catch: Exception -> L5
        this.L$2 = null;     // Catch: Exception -> L5
        this.fd304ba20 = 4;     // Catch: Exception -> L5
        if (p02565c40.m5927e830(this.this$0, this) == r0) goto L54;
    L66:
        return Unit.INSTANCE;
    L54:
        return r0;
    L59:
        if (r1 != 1) goto L79;
        ResultKt.throwOnFailure(r11);     // Catch: Exception -> L5
        goto L22
    L79:
        if (r1 != 2) goto L10;
        ResultKt.throwOnFailure(r11);     // Catch: Exception -> L5
        goto L25
    L10:
        if (r1 == 3) goto L40;
        if (r1 != 4) goto L71;
        ResultKt.throwOnFailure(r11);     // Catch: Exception -> L5
        goto L66
    L71:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L40:
        r12 = (pa4ecfc70.p910eef8c) this.L$2;
        r32 = (MutableStateFlow) this.L$1;
        r4 = (p150f1761) this.L$0;
        ResultKt.throwOnFailure(r11);     // Catch: Exception -> L5
    L5:
        th = move-exception;
        p02565c40.md57a29d2(this.this$0).setValue(pa4ecfc70.f910eef8c.error(th));
        goto L66
    }
}

