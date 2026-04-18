using Com.Google.Firebase.Crashlytics;
using Java.Math;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;
using Pc69c522d.Pf83c2a85.Pac143fb7;
using Pc69c522d.Pf83c2a85.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
readonly class pc314e9a0$p89f84f65$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ decimal $amount;
    readonly /* synthetic */ bool $isFullAmount;
    readonly /* synthetic */ pad7c4a1f $payment;
    int f0bf176bc;
    int fd304ba20;
    readonly /* synthetic */ pc314e9a0 this$0;

    pc314e9a0$p89f84f65$1(pc314e9a0 r1, pad7c4a1f r2, decimal r3, bool r4, Continuation<? super pc314e9a0$p89f84f65$1> r5) {
        this.this$0 = r1;
        this.$payment = r2;
        this.$amount = r3;
        this.$isFullAmount = r4;
        super(2, r5);
    }

    public static pad7c4a1f CdLYrMTAeLeFEIze(pab691ef3 r1, p8c261c90 r2, decimal r3) {
        return r1.createPayment(r2, r3);
    }

    public static pab691ef3 CnxcFJNrvxqVHeCA(pc314e9a0 r1) {
        return pc314e9a0.m1d7af725(r1);
    }

    public static decimal CtkdOmWlyyRidDOQ(pad7c4a1f r1) {
        return r1.getAmount();
    }

    public static void CtkdOmWlyyRidDOQ(pad7c4a1f r0, byte r1, int r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CtkdOmWlyyRidDOQ(pad7c4a1f r0, byte r1, string r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CtkdOmWlyyRidDOQ(pad7c4a1f r0, bool r1, string r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DKFWoLrqmawWRUVx(pc314e9a0 r0, p3a5cb279 r1) {
        pc314e9a0.mee67e975(r0, r1);
    }

    public static void DmjdYYGlexmXKMyi(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void DmjdYYGlexmXKMyi(object r0, byte r1, int r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DmjdYYGlexmXKMyi(object r0, bool r1, byte r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DmjdYYGlexmXKMyi(object r0, bool r1, short r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HEnfNFeyNVlQbRpT(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static decimal HeDQEqchSiEZAyRb(decimal r1, decimal r2) {
        return r1.Add(r2);
    }

    public static void HeDQEqchSiEZAyRb(decimal r0, decimal r1, byte r2, string r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HeDQEqchSiEZAyRb(decimal r0, decimal r1, byte r2, short r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HeDQEqchSiEZAyRb(decimal r0, decimal r1, string r2, float r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static pad7c4a1f KCXSjcWOyJJeaPre(pad7c4a1f r1, string r2, p8c261c90 r3, decimal r4, pf8872840 r5, int r6, object r7) {
        return pad7c4a1f.m1c1e012b(r1, r2, r3, r4, r5, r6, r7);
    }

    public static void KCXSjcWOyJJeaPre(pad7c4a1f r0, string r1, p8c261c90 r2, decimal r3, pf8872840 r4, int r5, object r6, int r7, char r8, string r9, bool r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void KCXSjcWOyJJeaPre(pad7c4a1f r0, string r1, p8c261c90 r2, decimal r3, pf8872840 r4, int r5, object r6, int r7, bool r8, char r9, string r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void KCXSjcWOyJJeaPre(pad7c4a1f r0, string r1, p8c261c90 r2, decimal r3, pf8872840 r4, int r5, object r6, bool r7, char r8, string r9, int r10) {
        double r02 = (42 * 210) + 210;
    }

    public static Continuation QQZcARmzShANCBMp(pc314e9a0$p89f84f65$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static void QQZcARmzShANCBMp(pc314e9a0$p89f84f65$1 r0, object r1, Continuation r2, byte r3, short r4, int r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void QQZcARmzShANCBMp(pc314e9a0$p89f84f65$1 r0, object r1, Continuation r2, float r3, int r4, byte r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void QQZcARmzShANCBMp(pc314e9a0$p89f84f65$1 r0, object r1, Continuation r2, int r3, short r4, float r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static object RTqiRpUaajkltnmq(pab691ef3 r1, pad7c4a1f r2, Continuation r3) {
        return r1.addPaymentToReceipt(r2, r3);
    }

    public static object ThLKWTBJKkrCpRIf(pab691ef3 r1, pad7c4a1f r2, Continuation r3) {
        return r1.updatePayment(r2, r3);
    }

    public static void ThLKWTBJKkrCpRIf(pab691ef3 r0, pad7c4a1f r1, Continuation r2, string r3, int r4, float r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ThLKWTBJKkrCpRIf(pab691ef3 r0, pad7c4a1f r1, Continuation r2, string r3, short r4, float r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ThLKWTBJKkrCpRIf(pab691ef3 r0, pad7c4a1f r1, Continuation r2, short r3, float r4, int r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static object UoiBYwSbsvrhnBZO(pc314e9a0$p89f84f65$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static void UoiBYwSbsvrhnBZO(pc314e9a0$p89f84f65$1 r0, object r1, char r2, short r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UoiBYwSbsvrhnBZO(pc314e9a0$p89f84f65$1 r0, object r1, int r2, char r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UoiBYwSbsvrhnBZO(pc314e9a0$p89f84f65$1 r0, object r1, int r2, short r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object WOJDZOQGGcSutFpb(pc314e9a0$p89f84f65$1 r1, CoroutineScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static void WOJDZOQGGcSutFpb(pc314e9a0$p89f84f65$1 r0, CoroutineScope r1, Continuation r2, byte r3, bool r4, char r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void WOJDZOQGGcSutFpb(pc314e9a0$p89f84f65$1 r0, CoroutineScope r1, Continuation r2, char r3, short r4, bool r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void WOJDZOQGGcSutFpb(pc314e9a0$p89f84f65$1 r0, CoroutineScope r1, Continuation r2, short r3, char r4, byte r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void XDgFEAzcZOVaBBcB(pc32333e1 r0) {
        r0.back();
    }

    public static pab691ef3 BleQVapwMjaXzPHy(pc314e9a0 r1) {
        return pc314e9a0.m1d7af725(r1);
    }

    public static void BleQVapwMjaXzPHy(pc314e9a0 r0, float r1, string r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BleQVapwMjaXzPHy(pc314e9a0 r0, short r1, string r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BleQVapwMjaXzPHy(pc314e9a0 r0, bool r1, string r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EQmBFAvUwHDrPVmw(pc314e9a0 r0, p3a5cb279 r1) {
        pc314e9a0.mee67e975(r0, r1);
    }

    public static void EQmBFAvUwHDrPVmw(pc314e9a0 r0, p3a5cb279 r1, byte r2, short r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EQmBFAvUwHDrPVmw(pc314e9a0 r0, p3a5cb279 r1, short r2, byte r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EQmBFAvUwHDrPVmw(pc314e9a0 r0, p3a5cb279 r1, bool r2, short r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IAPqHgkCbMwzRxjk(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void IAPqHgkCbMwzRxjk(object r0, char r1, bool r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IAPqHgkCbMwzRxjk(object r0, float r1, char r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IAPqHgkCbMwzRxjk(object r0, bool r1, char r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KCbdWKtsXcCDGASV(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static void KCbdWKtsXcCDGASV(object r0, string r1, int r2, bool r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KCbdWKtsXcCDGASV(object r0, string r1, short r2, int r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KCbdWKtsXcCDGASV(object r0, string r1, bool r2, int r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object KSHEYuTZTaPyymnD() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void KSHEYuTZTaPyymnD(float r0, byte r1, short r2, int r3) {
        double r02 = (42 * 210) + 210;
    }

    public static void KSHEYuTZTaPyymnD(float r0, int r1, short r2, byte r3) {
        double r02 = (42 * 210) + 210;
    }

    public static void KSHEYuTZTaPyymnD(int r0, short r1, float r2, byte r3) {
        double r02 = (42 * 210) + 210;
    }

    public static pc32333e1 MWYLPdjRAAkZhvom(pc314e9a0 r1) {
        return pc314e9a0.m74e3994c(r1);
    }

    public static pab691ef3 SlLqxWoCFuFGBfbF(pc314e9a0 r1) {
        return pc314e9a0.m1d7af725(r1);
    }

    public static void SlLqxWoCFuFGBfbF(pc314e9a0 r0, byte r1, int r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SlLqxWoCFuFGBfbF(pc314e9a0 r0, char r1, byte r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SlLqxWoCFuFGBfbF(pc314e9a0 r0, int r1, byte r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TCbnHANuxnNwUxAf(pc314e9a0 r0, p3a5cb279 r1) {
        pc314e9a0.mee67e975(r0, r1);
    }

    public static FirebaseCrashlytics UrHRJPNRQxLvfjIN() {
        return FirebaseCrashlytics.getInstance();
    }

    public static object UslGvdLiLAtqeGpH(pc314e9a0 r1, Continuation r2) {
        return pc314e9a0.m6573bf9e(r1, r2);
    }

    public static void ZeSytnsphHDQHbaZ(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void ZeSytnsphHDQHbaZ(object r0, byte r1, short r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZeSytnsphHDQHbaZ(object r0, short r1, byte r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZeSytnsphHDQHbaZ(object r0, bool r1, int r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r7, Continuation<object> r8) {
        if (((23 + 14) % 14) > 0) goto L16;
    L16:
        return new pc314e9a0$p89f84f65$1(this.this$0, this.$payment, this.$amount, this.$isFullAmount, r8);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return WOJDZOQGGcSutFpb(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return UoiBYwSbsvrhnBZO((pc314e9a0$p89f84f65$1) QQZcARmzShANCBMp(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r13) {
        if (((30 + 25) % 25) > 0) goto L84;
    L84:
        object r0 = kSHEYuTZTaPyymnD();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L42;
        DmjdYYGlexmXKMyi(r13);
        eQmBFAvUwHDrPVmw(this.this$0, p3a5cb279.f17130e6c);     // Catch: Exception -> L24 Exception -> L80
        pad7c4a1f r132 = this.$payment;     // Catch: Exception -> L24 Exception -> L80
        if (r132 is null) goto L53;
        decimal r8 = HeDQEqchSiEZAyRb(CtkdOmWlyyRidDOQ(r132), this.$amount);     // Catch: Exception -> L24 Exception -> L80
        kCbdWKtsXcCDGASV(r8, "add(...)");     // Catch: Exception -> L24 Exception -> L80
        this.fd304ba20 = 1;     // Catch: Exception -> L24 Exception -> L80
        if (ThLKWTBJKkrCpRIf(bleQVapwMjaXzPHy(this.this$0), KCXSjcWOyJJeaPre(this.$payment, null, null, r8, null, 11, null), this) != r0) goto L57;
    L60:
        return r0;
    L57:
        if (this.$isFullAmount == false) goto L61;
        this.fd304ba20 = 3;     // Catch: Exception -> L24 Exception -> L80
        if (uslGvdLiLAtqeGpH(this.this$0, this) == r0) goto L60;
    L17:
        DKFWoLrqmawWRUVx(this.this$0, p3a5cb279.f06972acc);
        return Unit.INSTANCE;
    L61:
        XDgFEAzcZOVaBBcB(mWYLPdjRAAkZhvom(this.this$0));     // Catch: Exception -> L24 Exception -> L80
        goto L17
    L53:
        pad7c4a1f r133 = CdLYrMTAeLeFEIze(slLqxWoCFuFGBfbF(this.this$0), p8c261c90.fdf657148, this.$amount);     // Catch: Exception -> L24 Exception -> L80
        this.fd304ba20 = 2;     // Catch: Exception -> L24 Exception -> L80
        if (RTqiRpUaajkltnmq(CnxcFJNrvxqVHeCA(this.this$0), r133, this) != r0) goto L57;
    L42:
        if (r1 != 1) goto L28;
    L11:
        iAPqHgkCbMwzRxjk(r13);     // Catch: Exception -> L24 Exception -> L80
        goto L57
    L28:
        if (r1 == 2) goto L11;
        if (r1 != 3) goto L10;
        zeSytnsphHDQHbaZ(r13);     // Catch: Exception -> L24 Exception -> L80
        goto L17
    L10:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L80:
        th = move-exception;
        tCbnHANuxnNwUxAf(this.this$0, p3a5cb279.f06972acc);
        throw th;
    L24:
        e = move-exception;
        HEnfNFeyNVlQbRpT(urHRJPNRQxLvfjIN(), e);     // Catch: Exception -> L80
        goto L17
    }
}

