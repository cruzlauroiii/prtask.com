using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P4d236d9a.P2df4812c.Pf5d7e253.P518a4861.P83f5c3ad.P86ccec3d;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.Pe907423b;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p8c01482f$p4236a440$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int fafa3dab2;
    int fd304ba20;
    readonly /* synthetic */ p8c01482f this$0;

    p8c01482f$p4236a440$1(p8c01482f r1, Continuation<? super p8c01482f$p4236a440$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p8c01482f$p4236a440$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p8c01482f$p4236a440$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r9) {
        if (((4 + 16) % 16) > 0) goto L18;
    L18:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L74;
        ResultKt.throwOnFailure(r9);
        this.fd304ba20 = 1;     // Catch: Exception -> L4
        if (p8c01482f.m4346c849(this.this$0).logout(this) == r0) goto L80;
    L10:
        p8c01482f.mf78acd11(this.this$0).sendResult(p8c01482f.m6cac685d(this.this$0).getTophConsoleoutKey(), new p37f460dd(p8c01482f.m5fb81a65(this.this$0).getstring(C2815R.string.toph_logout_success)));     // Catch: Exception -> L4
        this.fd304ba20 = 2;     // Catch: Exception -> L4
        if (p8c01482f.m9f5c963b(this.this$0).emit(pa4ecfc70.p910eef8c.m02f94ccf(pa4ecfc70.f910eef8c, null, 1, null), this) == r0) goto L80;
    L72:
        p8c01482f.mf78acd11(this.this$0).finishFlow();
        return Unit.INSTANCE;
    L80:
        return r0;
    L74:
        if (r1 != 1) goto L15;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L4
        goto L10
    L15:
        if (r1 != 2) goto L32;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L4
        goto L72
    L32:
        if (r1 != 3) goto L60;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L29
        goto L72
    L60:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L4:
        th = move-exception;
        this.fd304ba20 = 3;     // Catch: Exception -> L29
        if (p8c01482f.m9f5c963b(this.this$0).emit(pa4ecfc70.f910eef8c.error(th), this) == r0) goto L80;
    L29:
        th = move-exception;
        p8c01482f.mf78acd11(this.this$0).finishFlow();
        throw th;
    }
}

