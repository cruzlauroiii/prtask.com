using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P2df4812c.Pf5d7e253.P518a4861.P83f5c3ad.P86ccec3d;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p98cf21b1$p9a032022$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int I$0;
    int I$1;
    int f07315c8f;
    int f127f6f6c;
    int f5aa6ec4c;
    int f871f734b;
    int fd304ba20;
    readonly /* synthetic */ p98cf21b1 this$0;

    p98cf21b1$p9a032022$1(p98cf21b1 r1, Continuation<? super p98cf21b1$p9a032022$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p98cf21b1$p9a032022$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p98cf21b1$p9a032022$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:27:0x007a -> B:39:0x00a6). Please report as a decompilation issue!!! */
    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((1 + 31) % 31) > 0) goto L69;
    L69:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L64;
        ResultKt.throwOnFailure(r8);
        int r82 = 60;
        int r12 = 0;
    L39:
        if (r12 < r82) goto L57;
        p98cf21b1.m74e3994c(this.this$0).replaceToTophPaybackGone(p98cf21b1.m5fb81a65(this.this$0).getstring(C2815R.string.toph_payment_gone_title));
        return Unit.INSTANCE;
    L57:
        MutableSharedFlow r4 = p98cf21b1.m708f95ff(this.this$0);
        float r5 = Boxing.boxfloat(r12);
        p98cf21b1$p9a032022$1 r6 = this;
        this.I$0 = r82;
        this.I$1 = r12;
        this.fd304ba20 = 1;
        if (r4.emit(r5, r6) == r0) goto L82;
        int r42 = r82;
    L19:
        p98cf21b1$p9a032022$1 r83 = this;
        this.I$0 = r42;
        this.I$1 = r12;
        this.fd304ba20 = 2;
        if (DelayKt.delay(1000, r83) == r0) goto L82;
    L84:
        r82 = r42;
        r12 = r12 + 1;
    L82:
        return r0;
    L64:
        if (r1 != 1) goto L36;
        r12 = this.I$1;
        r42 = this.I$0;
        ResultKt.throwOnFailure(r8);
        goto L19
    L36:
        if (r1 != 2) goto L50;
        r12 = this.I$1;
        r42 = this.I$0;
        ResultKt.throwOnFailure(r8);
        goto L84
    L50:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    }
}

