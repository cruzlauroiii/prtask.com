using Androidx.Lifecycle;
using Com.Google.Firebase.Crashlytics;
using Domain.Entities;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using P582ca3f7.Pac143fb7;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.Pfa547353;
using Pe0bd4e89.Pdd56421b.P07214c67;
using Pe0bd4e89.Pdd56421b.Pac143fb7;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes5.dex */
readonly class pacc8b56c$p9c49843a$1$1 : SuspendLambda : Function2<LiveDataScope<Event<? : List<? : p3a208855>>>, Continuation<Unit>, object> {
    readonly /* synthetic */ string $query;
    private /* synthetic */ object L$0;
    object L$1;
    object L$2;
    object L$3;
    int f6db5acaf;
    int f6fb081d2;
    int fd304ba20;
    int fd79227f3;
    readonly /* synthetic */ pacc8b56c this$0;

    pacc8b56c$p9c49843a$1$1(pacc8b56c r1, string r2, Continuation<? super pacc8b56c$p9c49843a$1$1> r3) {
        this.this$0 = r1;
        this.$query = r2;
        super(2, r3);
    }

    public static void AFkRuCxaqGgkZQkU(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void AFkRuCxaqGgkZQkU(object r0, byte r1, float r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AFkRuCxaqGgkZQkU(object r0, bool r1, byte r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AFkRuCxaqGgkZQkU(object r0, bool r1, short r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CNyNSXUdsDctMTQr(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void CNyNSXUdsDctMTQr(object r0, byte r1, char r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CNyNSXUdsDctMTQr(object r0, char r1, string r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CNyNSXUdsDctMTQr(object r0, int r1, string r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static FirebaseCrashlytics CiXWbotOkFGcqybp() {
        return FirebaseCrashlytics.getInstance();
    }

    public static void CiXWbotOkFGcqybp(float r0, char r1, short r2, bool r3) {
        double r02 = (42 * 210) + 210;
    }

    public static void CiXWbotOkFGcqybp(bool r0, float r1, char r2, short r3) {
        double r02 = (42 * 210) + 210;
    }

    public static void CiXWbotOkFGcqybp(bool r0, short r1, float r2, char r3) {
        double r02 = (42 * 210) + 210;
    }

    public static object DNvnZoNeyKAmHxQx(pacc8b56c$p9c49843a$1$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static void DNvnZoNeyKAmHxQx(pacc8b56c$p9c49843a$1$1 r0, object r1, string r2, bool r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DNvnZoNeyKAmHxQx(pacc8b56c$p9c49843a$1$1 r0, object r1, short r2, string r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DNvnZoNeyKAmHxQx(pacc8b56c$p9c49843a$1$1 r0, object r1, short r2, string r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string HeJKKKVmPCYXDWnO(pf8c8b903 r1) {
        return r1.getId();
    }

    public static void HeJKKKVmPCYXDWnO(pf8c8b903 r0, byte r1, char r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HeJKKKVmPCYXDWnO(pf8c8b903 r0, int r1, float r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HeJKKKVmPCYXDWnO(pf8c8b903 r0, int r1, float r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static p74e6e501 JtQNCmBBnQZMjVBs(pacc8b56c r1) {
        return pacc8b56c.m88749316(r1);
    }

    public static void JtQNCmBBnQZMjVBs(pacc8b56c r0, float r1, short r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JtQNCmBBnQZMjVBs(pacc8b56c r0, int r1, string r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JtQNCmBBnQZMjVBs(pacc8b56c r0, string r1, float r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object KOwrzokFSyVOdKAf(p74e6e501 r1, string r2, string r3, Continuation r4) {
        return r1.getAdvanceReceiptsByQuery(r2, r3, r4);
    }

    public static void KOwrzokFSyVOdKAf(p74e6e501 r0, string r1, string r2, Continuation r3, float r4, short r5, int r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void KOwrzokFSyVOdKAf(p74e6e501 r0, string r1, string r2, Continuation r3, int r4, char r5, float r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void KOwrzokFSyVOdKAf(p74e6e501 r0, string r1, string r2, Continuation r3, short r4, int r5, float r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static object LmCgiVXNGXorhTbR() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void LmCgiVXNGXorhTbR(float r0, int r1, bool r2, string r3) {
        double r02 = (42 * 210) + 210;
    }

    public static void LmCgiVXNGXorhTbR(int r0, string r1, bool r2, float r3) {
        double r02 = (42 * 210) + 210;
    }

    public static void LmCgiVXNGXorhTbR(bool r0, string r1, float r2, int r3) {
        double r02 = (42 * 210) + 210;
    }

    public static object OppecwrpHjQSdduB(LiveDataScope r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    public static void OppecwrpHjQSdduB(LiveDataScope r0, object r1, Continuation r2, float r3, char r4, int r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void OppecwrpHjQSdduB(LiveDataScope r0, object r1, Continuation r2, float r3, char r4, short r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void OppecwrpHjQSdduB(LiveDataScope r0, object r1, Continuation r2, int r3, short r4, char r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static object QABleeQOQQatycDY(p69d862b4 r1, Continuation r2) {
        return r1.getSelectedEmployee(r2);
    }

    public static void QABleeQOQQatycDY(p69d862b4 r0, Continuation r1, short r2, float r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QABleeQOQQatycDY(p69d862b4 r0, Continuation r1, short r2, float r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QABleeQOQQatycDY(p69d862b4 r0, Continuation r1, short r2, string r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static pa4ecfc70 VDJFgxHNAueGekiQ(pa4ecfc70.p910eef8c r1, object r2) {
        return r1.success(r2);
    }

    public static void VDJFgxHNAueGekiQ(pa4ecfc70.p910eef8c r0, object r1, int r2, short r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VDJFgxHNAueGekiQ(pa4ecfc70.p910eef8c r0, object r1, string r2, float r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VDJFgxHNAueGekiQ(pa4ecfc70.p910eef8c r0, object r1, short r2, float r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static pa4ecfc70 WCXiVpoTMfFbBloj(pa4ecfc70.p910eef8c r1) {
        return r1.loading();
    }

    public static void WCXiVpoTMfFbBloj(pa4ecfc70.p910eef8c r0, byte r1, bool r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WCXiVpoTMfFbBloj(pa4ecfc70.p910eef8c r0, bool r1, byte r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WCXiVpoTMfFbBloj(pa4ecfc70.p910eef8c r0, bool r1, float r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Continuation WNzuVyLFdbhfombt(pacc8b56c$p9c49843a$1$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static void WNzuVyLFdbhfombt(pacc8b56c$p9c49843a$1$1 r0, object r1, Continuation r2, float r3, short r4, string r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void WNzuVyLFdbhfombt(pacc8b56c$p9c49843a$1$1 r0, object r1, Continuation r2, short r3, float r4, string r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void WNzuVyLFdbhfombt(pacc8b56c$p9c49843a$1$1 r0, object r1, Continuation r2, short r3, string r4, float r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static pa4ecfc70 WXjaXBioTASGoznk(pa4ecfc70.p910eef8c r1, Exception r2) {
        return r1.error(r2);
    }

    public static void WXjaXBioTASGoznk(pa4ecfc70.p910eef8c r0, Exception r1, float r2, byte r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WXjaXBioTASGoznk(pa4ecfc70.p910eef8c r0, Exception r1, string r2, short r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WXjaXBioTASGoznk(pa4ecfc70.p910eef8c r0, Exception r1, short r2, float r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YLsLmPDfZGHYGQeW(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void YLsLmPDfZGHYGQeW(object r0, char r1, int r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YLsLmPDfZGHYGQeW(object r0, int r1, short r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YLsLmPDfZGHYGQeW(object r0, short r1, char r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static p69d862b4 FmMjDxkkneglMfJV(pacc8b56c r1) {
        return pacc8b56c.m2870858d(r1);
    }

    public static void FmMjDxkkneglMfJV(pacc8b56c r0, char r1, int r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FmMjDxkkneglMfJV(pacc8b56c r0, int r1, string r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FmMjDxkkneglMfJV(pacc8b56c r0, string r1, char r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object ItHioxGloCMwQaCi(pacc8b56c$p9c49843a$1$1 r1, LiveDataScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static void ItHioxGloCMwQaCi(pacc8b56c$p9c49843a$1$1 r0, LiveDataScope r1, Continuation r2, byte r3, string r4, short r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ItHioxGloCMwQaCi(pacc8b56c$p9c49843a$1$1 r0, LiveDataScope r1, Continuation r2, char r3, short r4, string r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ItHioxGloCMwQaCi(pacc8b56c$p9c49843a$1$1 r0, LiveDataScope r1, Continuation r2, short r3, string r4, char r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void PDFeiIBmtjaQPifk(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void PDFeiIBmtjaQPifk(object r0, float r1, int r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PDFeiIBmtjaQPifk(object r0, float r1, string r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PDFeiIBmtjaQPifk(object r0, string r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SMBaTeXAkeybLFAW(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void SMBaTeXAkeybLFAW(object r0, float r1, int r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SMBaTeXAkeybLFAW(object r0, int r1, float r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SMBaTeXAkeybLFAW(object r0, bool r1, float r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TShamqWHECikXHRA(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static void TShamqWHECikXHRA(FirebaseCrashlytics r0, Exception r1, float r2, int r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TShamqWHECikXHRA(FirebaseCrashlytics r0, Exception r1, string r2, float r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TShamqWHECikXHRA(FirebaseCrashlytics r0, Exception r1, string r2, int r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object XJSFmVLxHbHNZHbE(LiveDataScope r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    public static void XJSFmVLxHbHNZHbE(LiveDataScope r0, object r1, Continuation r2, byte r3, char r4, string r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void XJSFmVLxHbHNZHbE(LiveDataScope r0, object r1, Continuation r2, byte r3, string r4, float r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void XJSFmVLxHbHNZHbE(LiveDataScope r0, object r1, Continuation r2, char r3, byte r4, float r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void YJbrrpBYLtTzKazf(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void YJbrrpBYLtTzKazf(object r0, char r1, float r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YJbrrpBYLtTzKazf(object r0, int r1, char r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YJbrrpBYLtTzKazf(object r0, bool r1, int r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object ZaANaPicHvSISjRO(LiveDataScope r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    public static void ZaANaPicHvSISjRO(LiveDataScope r0, object r1, Continuation r2, bool r3, byte r4, short r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZaANaPicHvSISjRO(LiveDataScope r0, object r1, Continuation r2, bool r3, int r4, byte r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZaANaPicHvSISjRO(LiveDataScope r0, object r1, Continuation r2, bool r3, int r4, short r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
        if (((23 + 23) % 23) > 0) goto L14;
    L14:
        pacc8b56c$p9c49843a$1$1 r0 = new pacc8b56c$p9c49843a$1$1(this.this$0, this.$query, r4);
        r0.L$0 = r3;
        return r0;
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(LiveDataScope<Event<List<p3a208855>>> r1, Continuation<Unit> r2) {
        return DNvnZoNeyKAmHxQx((pacc8b56c$p9c49843a$1$1) WNzuVyLFdbhfombt(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(LiveDataScope<Event<? : List<? : p3a208855>>> r1, Continuation<Unit> r2) {
        return itHioxGloCMwQaCi(this, r1, r2);
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r1v1, types: [int] */
    /* JADX WARN: Type inference failed for: r1v2, types: [androidx.lifecycle.LiveDataScope] */
    /* JADX WARN: Type inference failed for: r1v7 */
    /* JADX WARN: Type inference failed for: r1v8 */
    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r12) {
        if (((12 + 25) % 25) > 0) goto L12;
    L12:
        object r0 = LmCgiVXNGXorhTbR();
        ?? r1 = this.fd304ba20;
        if (r1 == 0) goto L68;
        if (r1 == 1) goto L162;
        if (r1 == 2) goto L43;
        if (r1 == 3) goto L6;
        if (r1 == 4) goto L137;
        if (r1 == 5) goto L74;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L74:
        Exception r11 = (Exception) this.L$0;
        YLsLmPDfZGHYGQeW(r12);
    L157:
        tShamqWHECikXHRA(CiXWbotOkFGcqybp(), r11);
    L50:
        return Unit.INSTANCE;
    L137:
        LiveDataScope r13 = (LiveDataScope) this.L$0;
        pDFeiIBmtjaQPifk(r12);     // Catch: Exception -> L32
        goto L50
    L6:
        pa4ecfc70.p910eef8c r14 = (pa4ecfc70.p910eef8c) this.L$2;
        LiveDataScope r4 = (LiveDataScope) this.L$1;
        LiveDataScope r5 = (LiveDataScope) this.L$0;
        CNyNSXUdsDctMTQr(r12);     // Catch: Exception -> L110
    L19:
        this.L$0 = r5;     // Catch: Exception -> L110
        this.L$1 = null;     // Catch: Exception -> L110
        this.L$2 = null;     // Catch: Exception -> L110
        this.fd304ba20 = 4;     // Catch: Exception -> L110
        if (xJSFmVLxHbHNZHbE(r4, VDJFgxHNAueGekiQ(r14, r12), this) != r0) goto L50;
    L90:
        return r0;
    L110:
        e = e;
        r1 = r5;
    L115:
        pa4ecfc70 r3 = WXjaXBioTASGoznk(pa4ecfc70.f910eef8c, e);
        pacc8b56c$p9c49843a$1$1 r42 = this;
        this.L$0 = e;
        this.L$1 = null;
        this.L$2 = null;
        this.L$3 = null;
        this.fd304ba20 = 5;
        if (zaANaPicHvSISjRO(r1, r3, r42) == r0) goto L90;
        r11 = e;
        goto L157
    L43:
        p74e6e501 r15 = (p74e6e501) this.L$3;
        pa4ecfc70.p910eef8c r52 = (pa4ecfc70.p910eef8c) this.L$2;
        LiveDataScope r6 = (LiveDataScope) this.L$1;
        LiveDataScope r8 = (LiveDataScope) this.L$0;
        yJbrrpBYLtTzKazf(r12);     // Catch: Exception -> L85
    L124:
        this.L$0 = r8;     // Catch: Exception -> L85
        this.L$1 = r6;     // Catch: Exception -> L85
        this.L$2 = r52;     // Catch: Exception -> L85
        this.L$3 = null;     // Catch: Exception -> L85
        this.fd304ba20 = 3;     // Catch: Exception -> L85
        r12 = KOwrzokFSyVOdKAf(r15, HeJKKKVmPCYXDWnO((pf8c8b903) r12), this.$query, this);     // Catch: Exception -> L85
        if (r12 == r0) goto L90;
        r14 = r52;
        r4 = r6;
        r5 = r8;
    L85:
        e = e;
        r1 = r8;
        goto L115
    L162:
        LiveDataScope r16 = (LiveDataScope) this.L$0;
        sMBaTeXAkeybLFAW(r12);
    L29:
        pa4ecfc70.p910eef8c r122 = pa4ecfc70.f910eef8c;     // Catch: Exception -> L32
        p74e6e501 r62 = JtQNCmBBnQZMjVBs(this.this$0);     // Catch: Exception -> L32
        this.L$0 = r16;     // Catch: Exception -> L32
        this.L$1 = r16;     // Catch: Exception -> L32
        this.L$2 = r122;     // Catch: Exception -> L32
        this.L$3 = r62;     // Catch: Exception -> L32
        this.fd304ba20 = 2;     // Catch: Exception -> L32
        object r53 = QABleeQOQQatycDY(fmMjDxkkneglMfJV(this.this$0), this);     // Catch: Exception -> L32
        if (r53 == r0) goto L90;
        r52 = r122;
        r12 = r53;
        r8 = r16;
        r15 = r62;
        r6 = r8;
        goto L124
    L68:
        AFkRuCxaqGgkZQkU(r12);
        LiveDataScope r123 = (LiveDataScope) this.L$0;
        pa4ecfc70 r17 = WCXiVpoTMfFbBloj(pa4ecfc70.f910eef8c);
        pacc8b56c$p9c49843a$1$1 r82 = this;
        this.L$0 = r123;
        this.fd304ba20 = 1;
        if (OppecwrpHjQSdduB(r123, r17, r82) == r0) goto L90;
        r16 = r123;
    L32:
        e = e;
        goto L115
    }
}

