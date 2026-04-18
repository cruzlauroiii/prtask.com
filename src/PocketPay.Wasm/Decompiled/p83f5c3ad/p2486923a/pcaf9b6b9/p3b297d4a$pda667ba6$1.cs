using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using Pad5f82e8.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p3b297d4a$pda667ba6$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f41ae3682;
    int f54912efc;
    int f8b693377;
    int fd304ba20;
    int fe58a8e0a;
    readonly /* synthetic */ p3b297d4a this$0;

    p3b297d4a$pda667ba6$1(p3b297d4a r1, Continuation<? super p3b297d4a$pda667ba6$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p3b297d4a$pda667ba6$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p3b297d4a$pda667ba6$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((28 + 7) % 7) > 0) goto L70;
    L70:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L18;
        if (r1 != 1) goto L77;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L29
    L22:
        this.fd304ba20 = 2;     // Catch: Exception -> L29
        if (p3b297d4a.m311115d1(this.this$0).closeBatch(this) == r0) goto L44;
    L25:
        this.fd304ba20 = 3;     // Catch: Exception -> L29
        if (p3b297d4a.me42d1448(this.this$0).emit(pa4ecfc70.p910eef8c.m02f94ccf(pa4ecfc70.f910eef8c, null, 1, null), this) == r0) goto L44;
    L13:
        return Unit.INSTANCE;
    L44:
        return r0;
    L77:
        if (r1 != 2) goto L51;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L29
        goto L25
    L51:
        if (r1 != 3) goto L71;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L29
        goto L13
    L71:
        if (r1 != 4) goto L39;
        ResultKt.throwOnFailure(r8);
        goto L13
    L39:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L18:
        ResultKt.throwOnFailure(r8);
        this.fd304ba20 = 1;     // Catch: Exception -> L29
        if (p3b297d4a.me42d1448(this.this$0).emit(pa4ecfc70.f910eef8c.loading(), this) != r0) goto L22;
    L29:
        e = move-exception;
        MutableSharedFlow r12 = p3b297d4a.me42d1448(this.this$0);
        pa4ecfc70 r82 = pa4ecfc70.f910eef8c.error(e);
        p3b297d4a$pda667ba6$1 r3 = this;
        this.fd304ba20 = 4;
        if (r12.emit(r82, r3) == r0) goto L44;
        goto L44
    }
}

