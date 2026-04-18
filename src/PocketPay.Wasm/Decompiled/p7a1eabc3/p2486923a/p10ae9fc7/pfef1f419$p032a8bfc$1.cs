using Com.Google.Firebase.Crashlytics;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P0c985ebf.Pac143fb7;
using P0c985ebf.Pfd9160bb;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes3.dex */
readonly class pfef1f419$p032a8bfc$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd031d465 $position;
    int f34307d80;
    int f40e0dc74;
    int fc5a5120d;
    int fd304ba20;
    int fe4e063d6;
    readonly /* synthetic */ pfef1f419 this$0;

    pfef1f419$p032a8bfc$1(pfef1f419 r1, pd031d465 r2, Continuation<? super pfef1f419$p032a8bfc$1> r3) {
        this.this$0 = r1;
        this.$position = r2;
        super(2, r3);
    }

    public static Continuation BxxFiwqdAnRpZXGY(pfef1f419$p032a8bfc$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static void DacFKHNigRJbykys(p41e6ee8c r0) {
        r0.backToInspectedPositions();
    }

    public static pd031d465 IkaUaFYRPvoVwCNF(pfef1f419 r1, List r2, pd031d465 r3) {
        return pfef1f419.mab6204b8(r1, r2, r3);
    }

    public static object JpRQDPOqggiZZEWg(p4ee8dd59 r1, pd031d465 r2, Continuation r3) {
        return r1.addPositionToInspect(r2, r3);
    }

    public static p4ee8dd59 LIRedFSlBATVkvtB(pfef1f419 r1) {
        return pfef1f419.m4aee790e(r1);
    }

    public static p4ee8dd59 LmzHTeDIxSSjBbaf(pfef1f419 r1) {
        return pfef1f419.m4aee790e(r1);
    }

    public static object NNNsufuRugLkGWZl() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void RRBPDvJWHxEqhYDt(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static object TlRUPTXrOTtJypaj(pfef1f419$p032a8bfc$1 r1, CoroutineScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static object ZfopUpYBsjqZXzXq(p4ee8dd59 r1, Continuation r2) {
        return r1.getInspectedPositions(r2);
    }

    public static void BxkpKKfknjvgXFxN(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static FirebaseCrashlytics CplsFXAOzgQKGhjv() {
        return FirebaseCrashlytics.getInstance();
    }

    public static void IInSyTYvzzJXTqRl(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static p41e6ee8c MXiHUrFxUbmwqYlX(pfef1f419 r1) {
        return pfef1f419.m26e218d3(r1);
    }

    public static object PDfxqiSVWMVUiJdl(pfef1f419$p032a8bfc$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static p4ee8dd59 VmQEvsRcTiDMziiX(pfef1f419 r1) {
        return pfef1f419.m4aee790e(r1);
    }

    public static void VmXoMkdKyNnhWhkV(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object ZgRkxYBnOZWxZtdC(p4ee8dd59 r1, pd031d465 r2, Continuation r3) {
        return r1.increaseInspectedPositionQuantity(r2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pfef1f419$p032a8bfc$1(this.this$0, this.$position, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return TlRUPTXrOTtJypaj(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return pDfxqiSVWMVUiJdl((pfef1f419$p032a8bfc$1) BxxFiwqdAnRpZXGY(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((20 + 11) % 11) > 0) goto L51;
    L51:
        object r0 = NNNsufuRugLkGWZl();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L20;
        iInSyTYvzzJXTqRl(r6);
        this.fd304ba20 = 1;     // Catch: Exception -> L49
        r6 = ZfopUpYBsjqZXzXq(LIRedFSlBATVkvtB(this.this$0), this);     // Catch: Exception -> L49
        if (r6 == r0) goto L34;
    L27:
        pfef1f419 r12 = this.this$0;     // Catch: Exception -> L49
        pd031d465 r62 = IkaUaFYRPvoVwCNF(r12, (List) r6, this.$position);     // Catch: Exception -> L49
        if (r62 is null) goto L32;
        p4ee8dd59 r13 = vmQEvsRcTiDMziiX(this.this$0);     // Catch: Exception -> L49
        this.fd304ba20 = 2;     // Catch: Exception -> L49
        if (zgRkxYBnOZWxZtdC(r13, r62, this) == r0) goto L34;
    L35:
        DacFKHNigRJbykys(mXiHUrFxUbmwqYlX(this.this$0));     // Catch: Exception -> L49
    L13:
        return Unit.INSTANCE;
    L32:
        this.fd304ba20 = 3;     // Catch: Exception -> L49
        if (JpRQDPOqggiZZEWg(LmzHTeDIxSSjBbaf(this.this$0), this.$position, this) != r0) goto L35;
    L34:
        return r0;
    L20:
        if (r1 != 1) goto L59;
        vmXoMkdKyNnhWhkV(r6);     // Catch: Exception -> L49
        goto L27
    L59:
        if (r1 != 2) goto L16;
    L18:
        bxkpKKfknjvgXFxN(r6);     // Catch: Exception -> L49
        goto L35
    L16:
        if (r1 == 3) goto L18;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L49:
        e = move-exception;
        RRBPDvJWHxEqhYDt(cplsFXAOzgQKGhjv(), e);
        goto L13
    }
}

