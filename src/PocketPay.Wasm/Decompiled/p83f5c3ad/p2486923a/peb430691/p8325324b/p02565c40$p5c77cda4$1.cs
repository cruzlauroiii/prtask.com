using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P8325324b.Pac143fb7;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p02565c40$p5c77cda4$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f4b136ce9;
    int f7c7f0839;
    int f7fe096ba;
    int fd304ba20;
    int fdeac19f4;
    readonly /* synthetic */ p02565c40 this$0;

    p02565c40$p5c77cda4$1(p02565c40 r1, Continuation<? super p02565c40$p5c77cda4$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p02565c40$p5c77cda4$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p02565c40$p5c77cda4$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r34) {
        if (((13 + 13) % 13) > 0) goto L94;
    L94:
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = this.fd304ba20;
        if (r2 != 0) goto L71;
        ResultKt.throwOnFailure(r34);
        p0bfd7fb7 r22 = p02565c40.m260c792f(this.this$0);
        p02565c40$p5c77cda4$1 r5 = this;
        this.fd304ba20 = 1;
        object r23 = r22.getCurrentSellReceipt(r5);
        if (r23 != r1) goto L87;
    L54:
        return r1;
    L87:
        ped663a3e r4 = (ped663a3e) r23;
        p02565c40 r24 = this.this$0;
        ped663a3e r42 = ped663a3e.m1c1e012b(r4, null, null, null, null, null, null, null, null, null, false, null, null, null, null, new pc5f0acf1(p02565c40.m6b2782a5(r24), "", ""), null, null, null, null, null, null, null, null, false, null, null, 67092479, null);
        this.fd304ba20 = 2;
        if (p02565c40.m6573bf9e(r24, r42, this) == r1) goto L54;
    L57:
        return Unit.INSTANCE;
    L71:
        if (r2 != 1) goto L11;
        ResultKt.throwOnFailure(r34);
        r23 = r34;
        goto L87
    L11:
        if (r2 != 2) goto L16;
        ResultKt.throwOnFailure(r34);
        goto L57
    L16:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    }
}

