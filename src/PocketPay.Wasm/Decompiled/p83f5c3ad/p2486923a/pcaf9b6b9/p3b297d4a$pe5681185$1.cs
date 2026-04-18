using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P83f5c3ad.P07214c67;
using Pad5f82e8.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p3b297d4a$pe5681185$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f342b7862;
    int f64c9fb76;
    int fd304ba20;
    int fe7e6b5f9;
    readonly /* synthetic */ p3b297d4a this$0;

    p3b297d4a$pe5681185$1(p3b297d4a r1, Continuation<? super p3b297d4a$pe5681185$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p3b297d4a$pe5681185$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p3b297d4a$pe5681185$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((29 + 12) % 12) > 0) goto L64;
    L64:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L68;
        ResultKt.throwOnFailure(r8);
        this.fd304ba20 = 1;     // Catch: Exception -> L15
        if (p3b297d4a.m3cb738d7(this.this$0).emit(pa4ecfc70.f910eef8c.loading(), this) == r0) goto L36;
    L56:
        this.fd304ba20 = 2;     // Catch: Exception -> L15
        r8 = p3b297d4a.m311115d1(this.this$0).getCurrentBatchInfo(this);     // Catch: Exception -> L15
        if (r8 == r0) goto L36;
    L59:
        MutableSharedFlow r12 = p3b297d4a.m3cb738d7(this.this$0);     // Catch: Exception -> L15
        pa4ecfc70.p910eef8c r4 = pa4ecfc70.f910eef8c;     // Catch: Exception -> L15
        this.fd304ba20 = 3;     // Catch: Exception -> L15
        if (r12.emit(r4.success((p0887a5ef) r8), this) == r0) goto L36;
    L48:
        return Unit.INSTANCE;
    L36:
        return r0;
    L68:
        if (r1 != 1) goto L21;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L15
        goto L56
    L21:
        if (r1 != 2) goto L25;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L15
        goto L59
    L25:
        if (r1 != 3) goto L45;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L15
        goto L48
    L45:
        if (r1 != 4) goto L80;
        ResultKt.throwOnFailure(r8);
        goto L48
    L80:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L15:
        e = move-exception;
        MutableSharedFlow r13 = p3b297d4a.m3cb738d7(this.this$0);
        pa4ecfc70 r82 = pa4ecfc70.f910eef8c.error(e);
        p3b297d4a$pe5681185$1 r3 = this;
        this.fd304ba20 = 4;
        if (r13.emit(r82, r3) == r0) goto L36;
        goto L36
    }
}

