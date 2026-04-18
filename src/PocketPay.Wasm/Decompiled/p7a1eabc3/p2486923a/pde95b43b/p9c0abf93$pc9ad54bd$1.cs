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
readonly class p9c0abf93$pc9ad54bd$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd031d465 $position;
    int fd304ba20;
    int ffd8b37a8;
    readonly /* synthetic */ p9c0abf93 this$0;

    p9c0abf93$pc9ad54bd$1(p9c0abf93 r1, pd031d465 r2, Continuation<? super p9c0abf93$pc9ad54bd$1> r3) {
        this.this$0 = r1;
        this.$position = r2;
        super(2, r3);
    }

    public static object AIiPggAKLSCbZHYO(p9c0abf93$pc9ad54bd$1 r1, CoroutineScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static void CAagzATOOJhixSku(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static object FzEsrszZhwEzHlbt() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static p4ee8dd59 GWmEtbyvewRawgBf(p9c0abf93 r1) {
        return p9c0abf93.m4aee790e(r1);
    }

    public static void HhPcUvfnxdAGJbDG(p41e6ee8c r0) {
        r0.backToInspectedPositions();
    }

    public static void IOQtJDKFjNxmvEXM(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object JYKRPRPQUtvMqWjd(p4ee8dd59 r1, pd031d465 r2, Continuation r3) {
        return r1.addPositionToInspect(r2, r3);
    }

    public static void LtGRxxaRuKGsDnjB(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void MFRrJevNEsFDEIaG(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static FirebaseCrashlytics VAukENFLkReeCsTe() {
        return FirebaseCrashlytics.getInstance();
    }

    public static p4ee8dd59 XFoxfVuBWqPAQUZP(p9c0abf93 r1) {
        return p9c0abf93.m4aee790e(r1);
    }

    public static p41e6ee8c XUvNixbHeOgnSMjC(p9c0abf93 r1) {
        return p9c0abf93.m26e218d3(r1);
    }

    public static p4ee8dd59 XgnbWfIXlUuqpWPU(p9c0abf93 r1) {
        return p9c0abf93.m4aee790e(r1);
    }

    public static object ENujCJKnaiAMolvD(p9c0abf93$pc9ad54bd$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static pd031d465 FBmuNrsVgAJzxAKv(p9c0abf93 r1, List r2, pd031d465 r3) {
        return p9c0abf93.mab6204b8(r1, r2, r3);
    }

    public static object HfNxCMclOeAHHdlE(p4ee8dd59 r1, Continuation r2) {
        return r1.getInspectedPositions(r2);
    }

    public static Continuation JAkqLqIXkDEfcMMJ(p9c0abf93$pc9ad54bd$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static object NyxHxNnuosAVTjuC(p4ee8dd59 r1, pd031d465 r2, Continuation r3) {
        return r1.increaseInspectedPositionQuantity(r2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p9c0abf93$pc9ad54bd$1(this.this$0, this.$position, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return AIiPggAKLSCbZHYO(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return eNujCJKnaiAMolvD((p9c0abf93$pc9ad54bd$1) jAkqLqIXkDEfcMMJ(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((9 + 8) % 8) > 0) goto L24;
    L24:
        object r0 = FzEsrszZhwEzHlbt();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L57;
        MFRrJevNEsFDEIaG(r6);
        this.fd304ba20 = 1;     // Catch: Exception -> L13
        r6 = hfNxCMclOeAHHdlE(XgnbWfIXlUuqpWPU(this.this$0), this);     // Catch: Exception -> L13
        if (r6 == r0) goto L45;
    L38:
        p9c0abf93 r12 = this.this$0;     // Catch: Exception -> L13
        pd031d465 r62 = fBmuNrsVgAJzxAKv(r12, (List) r6, this.$position);     // Catch: Exception -> L13
        if (r62 is null) goto L43;
        p4ee8dd59 r13 = GWmEtbyvewRawgBf(this.this$0);     // Catch: Exception -> L13
        this.fd304ba20 = 2;     // Catch: Exception -> L13
        if (nyxHxNnuosAVTjuC(r13, r62, this) == r0) goto L45;
    L46:
        HhPcUvfnxdAGJbDG(XUvNixbHeOgnSMjC(this.this$0));     // Catch: Exception -> L13
    L8:
        return Unit.INSTANCE;
    L43:
        this.fd304ba20 = 3;     // Catch: Exception -> L13
        if (JYKRPRPQUtvMqWjd(XFoxfVuBWqPAQUZP(this.this$0), this.$position, this) != r0) goto L46;
    L45:
        return r0;
    L57:
        if (r1 != 1) goto L65;
        LtGRxxaRuKGsDnjB(r6);     // Catch: Exception -> L13
        goto L38
    L65:
        if (r1 != 2) goto L60;
    L62:
        IOQtJDKFjNxmvEXM(r6);     // Catch: Exception -> L13
        goto L46
    L60:
        if (r1 == 3) goto L62;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L13:
        e = move-exception;
        CAagzATOOJhixSku(VAukENFLkReeCsTe(), e);
        goto L8
    }
}

