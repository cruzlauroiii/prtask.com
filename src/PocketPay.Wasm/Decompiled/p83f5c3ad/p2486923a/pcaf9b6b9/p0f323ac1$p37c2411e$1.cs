using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P2e5d8aa3.Pe0212e54.Pf5e638cc;
using Pad5f82e8.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p0f323ac1$p37c2411e$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f047b4036;
    int f0aaf56c8;
    int f2fedb6fb;
    int fd304ba20;
    int fe2c16414;
    readonly /* synthetic */ p0f323ac1 this$0;

    p0f323ac1$p37c2411e$1(p0f323ac1 r1, Continuation<? super p0f323ac1$p37c2411e$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p0f323ac1$p37c2411e$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p0f323ac1$p37c2411e$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((7 + 4) % 4) > 0) goto L29;
    L29:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L46;
        if (r1 != 1) goto L7;
        ResultKt.throwOnFailure(r7);     // Catch: Exception -> L27
    L50:
        p04decbae r72 = p0f323ac1.mb272891c(this.this$0).getTapOnPhoneQrInfo();     // Catch: Exception -> L27
        this.fd304ba20 = 2;     // Catch: Exception -> L27
        if (p0f323ac1.mf2580f5d(this.this$0).emit(pa4ecfc70.f910eef8c.success(r72), this) != r0) goto L24;
    L12:
        return r0;
    L24:
        return Unit.INSTANCE;
    L7:
        if (r1 != 2) goto L58;
        ResultKt.throwOnFailure(r7);     // Catch: Exception -> L27
        goto L24
    L58:
        if (r1 != 3) goto L53;
        ResultKt.throwOnFailure(r7);
        goto L24
    L53:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L46:
        ResultKt.throwOnFailure(r7);
        this.fd304ba20 = 1;     // Catch: Exception -> L27
        if (p0f323ac1.mf2580f5d(this.this$0).emit(pa4ecfc70.f910eef8c.loading(), this) != r0) goto L50;
    L27:
        e = move-exception;
        MutableStateFlow r12 = p0f323ac1.mf2580f5d(this.this$0);
        pa4ecfc70 r73 = pa4ecfc70.f910eef8c.error(e);
        p0f323ac1$p37c2411e$1 r3 = this;
        this.fd304ba20 = 3;
        if (r12.emit(r73, r3) == r0) goto L12;
        goto L12
    }
}

