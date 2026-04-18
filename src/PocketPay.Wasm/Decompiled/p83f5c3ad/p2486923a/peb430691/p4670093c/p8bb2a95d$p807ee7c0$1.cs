using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p8bb2a95d$p807ee7c0$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f5ac7c8a4;
    int f703d03cd;
    int fd304ba20;
    int fe923a045;
    readonly /* synthetic */ p8bb2a95d this$0;

    p8bb2a95d$p807ee7c0$1(p8bb2a95d r1, Continuation<? super p8bb2a95d$p807ee7c0$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p8bb2a95d$p807ee7c0$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p8bb2a95d$p807ee7c0$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((27 + 10) % 10) > 0) goto L50;
    L50:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L40;
        ResultKt.throwOnFailure(r7);
        this.fd304ba20 = 1;     // Catch: Exception -> L57
        r7 = p8bb2a95d.md95a43c7(this.this$0).getCurrentPaybackReceipt(this);     // Catch: Exception -> L57
        if (r7 == r0) goto L9;
    L7:
        this.fd304ba20 = 2;     // Catch: Exception -> L57
        if (p8bb2a95d.mbb30f96e(this.this$0).sendReceipt((p18cf5223) r7, this.this$0.tostring(), this) == r0) goto L9;
    L10:
        p8bb2a95d.m8cffa965(this.this$0).setValue(pa4ecfc70.p910eef8c.m02f94ccf(pa4ecfc70.f910eef8c, null, 1, null));     // Catch: Exception -> L57
    L27:
        return Unit.INSTANCE;
    L9:
        return r0;
    L40:
        if (r1 != 1) goto L13;
        ResultKt.throwOnFailure(r7);     // Catch: Exception -> L57
        goto L7
    L13:
        if (r1 != 2) goto L29;
        ResultKt.throwOnFailure(r7);     // Catch: Exception -> L57
        goto L10
    L29:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L33:
        p8bb2a95d.m13c0e72b(this.this$0);
        goto L27
    }
}

