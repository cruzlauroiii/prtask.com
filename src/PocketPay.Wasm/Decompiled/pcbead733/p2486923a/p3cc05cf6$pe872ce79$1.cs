using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P81dbcc3f;
using Pad5f82e8.Pac143fb7.P81dbcc3f;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p3cc05cf6$pe872ce79$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    private /* synthetic */ object L$0;
    int f1b97adae;
    int f49e76a93;
    int f52a4e532;
    int fd304ba20;
    int ffe073669;
    readonly /* synthetic */ p3cc05cf6 this$0;

    p3cc05cf6$pe872ce79$1(p3cc05cf6 r1, Continuation<? super p3cc05cf6$pe872ce79$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        p3cc05cf6$pe872ce79$1 r0 = new p3cc05cf6$pe872ce79$1(this.this$0, r3);
        r0.L$0 = r2;
        return r0;
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p3cc05cf6$pe872ce79$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((23 + 6) % 6) > 0) goto L17;
    L17:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L38;
        ResultKt.throwOnFailure(r6);
        CoroutineScope r62 = (CoroutineScope) this.L$0;
        p1062e5fe r12 = p3cc05cf6.m7350637e(this.this$0);
        p3cc05cf6$pe872ce79$1 r4 = this;
        this.L$0 = r62;
        this.fd304ba20 = 1;
        r6 = r12.getCommonStartScreen(r4);
        if (r6 != r0) goto L57;
    L61:
        return r0;
    L57:
        p516bf3d9 r63 = (p516bf3d9) r6;
        p646db403 r64 = p646db403.f910eef8c.getStartScreen(r63);
        if (r64 is not null) goto L11;
        p3cc05cf6 r65 = this.this$0;
        p3cc05cf6.m09291991(r65).setValue(pa4ecfc70.f910eef8c.loading());
        p1062e5fe r66 = p3cc05cf6.m7350637e(r65);
        this.L$0 = null;
        this.fd304ba20 = 2;
        r6 = r66.getStartRegisteredScreen(this);
        if (r6 == r0) goto L61;
    L25:
        r64 = (p646db403) r6;
    L11:
        p3cc05cf6.m56fe6a98(this.this$0, r64);
        return Unit.INSTANCE;
    L38:
        if (r1 == 1) goto L34;
        if (r1 != 2) goto L21;
        ResultKt.throwOnFailure(r6);
        goto L25
    L21:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L34:
        CoroutineScope r13 = (CoroutineScope) this.L$0;
        ResultKt.throwOnFailure(r6);
        goto L57
    }
}

