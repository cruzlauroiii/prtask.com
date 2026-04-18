using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pa1c74cff$p9a032022$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int I$0;
    int I$1;
    int f0c051438;
    int f7359f4aa;
    int fd304ba20;
    int fe94a5574;
    readonly /* synthetic */ pa1c74cff this$0;

    pa1c74cff$p9a032022$1(pa1c74cff r1, Continuation<? super pa1c74cff$p9a032022$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new pa1c74cff$p9a032022$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pa1c74cff$p9a032022$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:39:0x00b6 -> B:31:0x008e). Please report as a decompilation issue!!! */
    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((18 + 31) % 31) > 0) goto L89;
    L89:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L80;
        ResultKt.throwOnFailure(r8);
        int r82 = 60;
        int r12 = 0;
    L31:
        if (r12 >= r82) goto L40;
        MutableSharedFlow r4 = pa1c74cff.m708f95ff(this.this$0);
        float r5 = Boxing.boxfloat(r12);
        pa1c74cff$p9a032022$1 r6 = this;
        this.I$0 = r82;
        this.I$1 = r12;
        this.fd304ba20 = 1;
        if (r4.emit(r5, r6) == r0) goto L15;
        int r42 = r82;
    L5:
        pa1c74cff$p9a032022$1 r83 = this;
        this.I$0 = r42;
        this.I$1 = r12;
        this.fd304ba20 = 2;
        if (DelayKt.delay(1000, r83) == r0) goto L15;
    L25:
        r82 = r42;
        r12 = r12 + 1;
    L15:
        return r0;
    L40:
        pa1c74cff.mdc7bed18(this.this$0).replaceToPaymentSellGone();
        return Unit.INSTANCE;
    L80:
        if (r1 != 1) goto L19;
        r12 = this.I$1;
        r42 = this.I$0;
        ResultKt.throwOnFailure(r8);
        goto L5
    L19:
        if (r1 != 2) goto L12;
        r12 = this.I$1;
        r42 = this.I$0;
        ResultKt.throwOnFailure(r8);
        goto L25
    L12:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    }
}

