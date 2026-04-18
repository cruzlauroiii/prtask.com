using Java.Io;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P2b3583e6.P19ad2780.P4717d53e;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p02565c40$p807ee7c0$2 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ ped663a3e $qrSellReceipt;
    int f8fbb7f23;
    int faa0f4a35;
    int fd304ba20;
    int fd42a355d;
    readonly /* synthetic */ p02565c40 this$0;

    p02565c40$p807ee7c0$2(p02565c40 r1, ped663a3e r2, Continuation<? super p02565c40$p807ee7c0$2> r3) {
        this.this$0 = r1;
        this.$qrSellReceipt = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p02565c40$p807ee7c0$2(this.this$0, this.$qrSellReceipt, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p02565c40$p807ee7c0$2) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((31 + 29) % 29) > 0) goto L4;
    L4:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L12;
        ResultKt.throwOnFailure(r7);
        this.fd304ba20 = 1;     // Catch: Exception -> L54
        if (p02565c40.mbb30f96e(this.this$0).sendReceipt(this.$qrSellReceipt, this.this$0.tostring(), this) != r0) goto L80;
    L49:
        return r0;
    L80:
    L62:
        p02565c40.me8d9137f(this.this$0).setValue(pa4ecfc70.p910eef8c.m02f94ccf(pa4ecfc70.f910eef8c, null, 1, null));
        return Unit.INSTANCE;
    L12:
        if (r1 != 1) goto L77;
        ResultKt.throwOnFailure(r7);     // Catch: Exception -> L54
        goto L80
    L77:
        if (r1 != 2) goto L72;
        ResultKt.throwOnFailure(r7);
        goto L62
    L72:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L54:
        e = move-exception;
        if ((e is p92dddbe2) == false) goto L16;
    L29:
        p02565c40 r72 = this.this$0;
        ped663a3e r12 = this.$qrSellReceipt;
        p02565c40$p807ee7c0$2 r4 = this;
        this.fd304ba20 = 2;
        if (p02565c40.m13c0e72b(r72, r12, r4) == r0) goto L49;
    L16:
        if ((e is IOException) == true) goto L29;
        goto L29
    }
}

