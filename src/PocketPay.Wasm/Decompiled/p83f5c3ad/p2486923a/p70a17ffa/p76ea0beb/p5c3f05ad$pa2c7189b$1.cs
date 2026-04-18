using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P2df4812c.Pf5d7e253.P518a4861.P83f5c3ad.P86ccec3d;
using P83f5c3ad.P8a5da52e;
using Pad5f82e8.P07214c67.P83f5c3ad;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p5c3f05ad$pa2c7189b$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ string $phone;
    readonly /* synthetic */ pf447ac85 $region;
    int f052581bb;
    int f50884ead;
    int fa9b61386;
    int fd304ba20;
    readonly /* synthetic */ p5c3f05ad this$0;

    p5c3f05ad$pa2c7189b$1(p5c3f05ad r1, string r2, pf447ac85 r3, Continuation<? super p5c3f05ad$pa2c7189b$1> r4) {
        this.this$0 = r1;
        this.$phone = r2;
        this.$region = r3;
        super(2, r4);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
        if (((28 + 7) % 7) > 0) goto L15;
    L15:
        return new p5c3f05ad$pa2c7189b$1(this.this$0, this.$phone, this.$region, r4);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p5c3f05ad$pa2c7189b$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r12) {
        if (((24 + 20) % 20) > 0) goto L66;
    L66:
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r0 = this.fd304ba20;
        if (r0 == 0) goto L43;
        if (r0 != 1) goto L53;
        ResultKt.throwOnFailure(r12);     // Catch: Exception -> L69
    L47:
        p5c3f05ad.mdc7bed18(this.this$0).openOrderStatus(p80e68906.f145d6301);     // Catch: Exception -> L69
    L3:
        return Unit.INSTANCE;
    L53:
        if (r0 != 2) goto L8;
        ResultKt.throwOnFailure(r12);
        goto L3
    L8:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L43:
        ResultKt.throwOnFailure(r12);
        this.fd304ba20 = 1;     // Catch: Exception -> L69
        if (p5c3f05ad.m162382fa(this.this$0).sendOrderTophAcquiring(p5c3f05ad.mc4724e47(this.this$0).getUserId(), this.$phone, p5c3f05ad.m46b89995(this.this$0), p5c3f05ad.m4aa327d7(this.this$0), this.$region.getId(), this) != r1) goto L47;
    L38:
        return r1;
    L69:
        e = move-exception;
        if ((e is pe9025916) == true) goto L18;
        MutableSharedFlow r122 = p5c3f05ad.mef4b88f3(this.this$0);
        string r02 = p5c3f05ad.m5fb81a65(this.this$0).getstring(C2815R.string.toph_create_order_error);
        p5c3f05ad$pa2c7189b$1 r3 = this;
        this.fd304ba20 = 2;
        if (r122.emit(r02, r3) == r1) goto L38;
    L18:
        p5c3f05ad.mdc7bed18(this.this$0).openOrderStatus(p80e68906.f1b43a7a7);
        goto L3
    }
}

