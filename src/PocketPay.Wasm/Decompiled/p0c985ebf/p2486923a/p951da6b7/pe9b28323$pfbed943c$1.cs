using Com.Google.Firebase.Crashlytics;
using Java.Math;
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
using Pad5f82e8.P07214c67.P7a1eabc3;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
readonly class pe9b28323$pfbed943c$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd031d465 $position;
    int f50d17cd2;
    int f6c626057;
    int fd304ba20;
    readonly /* synthetic */ pe9b28323 this$0;

    pe9b28323$pfbed943c$1(pe9b28323 r1, pd031d465 r2, Continuation<? super pe9b28323$pfbed943c$1> r3) {
        this.this$0 = r1;
        this.$position = r2;
        super(2, r3);
    }

    public static decimal CTJNzZgJPTkpjhvB(pd031d465 r1) {
        return r1.getPurchasePrice();
    }

    public static p4ee8dd59 DGKtbDDOAWhSmVKv(pe9b28323 r1) {
        return pe9b28323.m4aee790e(r1);
    }

    public static object FaEXlWgEQrXfpZYp(p4ee8dd59 r1, pd031d465 r2, Continuation r3) {
        return r1.updateInspectedPosition(r2, r3);
    }

    public static p4ee8dd59 HQnOCSpvcATJWbvT(pe9b28323 r1) {
        return pe9b28323.m4aee790e(r1);
    }

    public static void HSqqoTFigEVDMWdT(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object KNTfnQpVBrIfZmAC(pe9b28323$pfbed943c$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static void LcPMXSJWJLWnKaBQ(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static pd031d465 VOjtbNRyrlsoNjxi(pe9b28323 r1, List r2, pd031d465 r3) {
        return pe9b28323.mab6204b8(r1, r2, r3);
    }

    public static p4ee8dd59 VlLYDBJHJMrANKgj(pe9b28323 r1) {
        return pe9b28323.m4aee790e(r1);
    }

    public static decimal WLZZaqlbapLlzTWl(pd031d465 r1) {
        return r1.getQuantity();
    }

    public static pd031d465 WgrPtAVWNiBksLzn(pd031d465 r1, string r2, decimal r3, decimal r4, string r5, string r6, int r7, decimal r8, decimal r9, string r10, string r11, pa1fa2777 r12, decimal r13, decimal r14, decimal r15, p5267f68e r16, int r17, object r18) {
        return pd031d465.m1c1e012b(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18);
    }

    public static object YJQgXrlgpdvJiUTR(pe9b28323$pfbed943c$1 r1, CoroutineScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static object AFglMDXvciHzkVkV() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static Continuation DSoBrPdLyXmnLXMV(pe9b28323$pfbed943c$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static FirebaseCrashlytics HiIeFuPJDDjNQVvi() {
        return FirebaseCrashlytics.getInstance();
    }

    public static void RSSjSjyfhpdHpMny(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static p41e6ee8c RVDAwTxZmevdovRg(pe9b28323 r1) {
        return pe9b28323.m26e218d3(r1);
    }

    public static void SZhqnAeGDceNvUUq(p41e6ee8c r0) {
        r0.backToInspectedPositions();
    }

    public static void VcnzutmTHreFfzRR(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object YOXPZJcJeknriIGH(p4ee8dd59 r1, pd031d465 r2, Continuation r3) {
        return r1.addPositionToInspect(r2, r3);
    }

    public static object ZpJoWCcNyyaMHcjG(p4ee8dd59 r1, Continuation r2) {
        return r1.getInspectedPositions(r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pe9b28323$pfbed943c$1(this.this$0, this.$position, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return YJQgXrlgpdvJiUTR(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return KNTfnQpVBrIfZmAC((pe9b28323$pfbed943c$1) dSoBrPdLyXmnLXMV(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r26) {
        if (((1 + 10) % 10) > 0) goto L63;
    L63:
        object r1 = aFglMDXvciHzkVkV();
        int r2 = this.fd304ba20;
        if (r2 == 0) goto L38;
        if (r2 != 1) goto L5;
        vcnzutmTHreFfzRR(r26);     // Catch: Exception -> L28
        object r22 = r26;
    L42:
        pe9b28323 r5 = this.this$0;     // Catch: Exception -> L28
        pd031d465 r7 = VOjtbNRyrlsoNjxi(r5, (List) r22, this.$position);     // Catch: Exception -> L28
        if (r7 is null) goto L47;
        pe9b28323 r23 = this.this$0;     // Catch: Exception -> L28
        pd031d465 r3 = this.$position;     // Catch: Exception -> L28
        p4ee8dd59 r24 = HQnOCSpvcATJWbvT(r23);     // Catch: Exception -> L28
        pd031d465 r32 = WgrPtAVWNiBksLzn(r7, null, null, CTJNzZgJPTkpjhvB(r3), null, null, 0, WLZZaqlbapLlzTWl(r3), null, null, null, null, null, null, null, null, 32699, null);     // Catch: Exception -> L28
        this.fd304ba20 = 2;     // Catch: Exception -> L28
        if (FaEXlWgEQrXfpZYp(r24, r32, this) == r1) goto L49;
    L50:
        sZhqnAeGDceNvUUq(rVDAwTxZmevdovRg(this.this$0));     // Catch: Exception -> L28
    L14:
        return Unit.INSTANCE;
    L49:
        return r1;
    L47:
        this.fd304ba20 = 3;     // Catch: Exception -> L28
        if (yOXPZJcJeknriIGH(DGKtbDDOAWhSmVKv(this.this$0), this.$position, this) != r1) goto L50;
    L5:
        if (r2 != 2) goto L55;
    L57:
        LcPMXSJWJLWnKaBQ(r26);     // Catch: Exception -> L28
        goto L50
    L55:
        if (r2 == 3) goto L57;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L38:
        HSqqoTFigEVDMWdT(r26);
        this.fd304ba20 = 1;     // Catch: Exception -> L28
        r22 = zpJoWCcNyyaMHcjG(VlLYDBJHJMrANKgj(this.this$0), this);     // Catch: Exception -> L28
        if (r22 != r1) goto L42;
    L28:
        e = move-exception;
        rSSjSjyfhpdHpMny(hiIeFuPJDDjNQVvi(), e);
        goto L14
    }
}

