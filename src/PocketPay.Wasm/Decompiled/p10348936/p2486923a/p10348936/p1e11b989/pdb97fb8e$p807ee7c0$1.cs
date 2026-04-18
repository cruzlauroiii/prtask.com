using Androidx.Lifecycle;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlin.Reflect;
using Kotlinx.Coroutines;
using P10348936.Pac143fb7;
using P10348936.Pf5e638cc;
using P10348936.Pfd9160bb;
using P2b3583e6.P4a931512;
using P4d236d9a.P2df4812c.Pf5d7e253.P705f8913.P518a4861.P10348936.P86ccec3d;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe907423b;
using Pad5f82e8.Pac143fb7.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
readonly class pdb97fb8e$p807ee7c0$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    object L$0;
    int f2dd6f4e1;
    int f5889802b;
    int fd304ba20;
    int fd5c6a61a;
    readonly /* synthetic */ pdb97fb8e this$0;

    pdb97fb8e$p807ee7c0$1(pdb97fb8e r1, Continuation<? super pdb97fb8e$p807ee7c0$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    public static MutableLiveData BshMEgIrLCJBmBLA(pdb97fb8e r1) {
        return pdb97fb8e.m4bd6e7f5(r1);
    }

    public static void BvHEoBgxVNzFYhIP(MutableLiveData r0, object r1) {
        r0.setValue(r1);
    }

    public static string EhdeQRrguFdWpTsk(p2e423cc6 r1, int r2) {
        return r1.getstring(r2);
    }

    public static p2e423cc6 HztkDRzeSyWwblKa(pdb97fb8e r1) {
        return pdb97fb8e.m5fb81a65(r1);
    }

    public static pd47d680b KiYQfEvRSxTyKhLV(pdb97fb8e r1) {
        return pdb97fb8e.ma0e3f333(r1);
    }

    public static object KvDZkmbiYJBgboBX(pd47d680b r1, Continuation r2) {
        return r1.getCurrentInventorization(r2);
    }

    public static void LGRgPAGOzupJGEAe(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static pd47d680b OHXjakUxPPpQNpTp(pdb97fb8e r1) {
        return pdb97fb8e.ma0e3f333(r1);
    }

    public static pd47d680b OufXkDroOLiHAFHG(pdb97fb8e r1) {
        return pdb97fb8e.ma0e3f333(r1);
    }

    public static void PbAzCFOXQRBqKWrb(pabe3770e r0) {
        r0.backToInventorizationConsole();
    }

    public static string PshILJCkvLEGMGam(p2e423cc6 r1, int r2) {
        return r1.getstring(r2);
    }

    public static object QfcPbHYGMkSitLDg(pd47d680b r1, p0690dac5 r2, Continuation r3) {
        return r1.saveCurrentInventorization(r2, r3);
    }

    public static object QqpRjwConPeYpDWd(pdb97fb8e$p807ee7c0$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static void TuaIHpLkbfAIaswT(pabe3770e r0) {
        r0.back();
    }

    public static Continuation TuekWYIokfRVZpKY(pdb97fb8e$p807ee7c0$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static KClass WsCEsYaidSlvtAGl(Class r1) {
        return Reflection.getOrCreateKotlinClass(r1);
    }

    public static p2e423cc6 XABUXTrBwzUPVdjv(pdb97fb8e r1) {
        return pdb97fb8e.m5fb81a65(r1);
    }

    public static List CyUhiriyqoNRFjjZ(p0690dac5 r1) {
        return r1.getPositions();
    }

    public static void EWhJomuPtipnHClb(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object EXFalZjXlNpHFmgX(pdb97fb8e r1, p0690dac5 r2, Continuation r3) {
        return pdb97fb8e.m4457f093(r1, r2, r3);
    }

    public static object EsdMZMSdPvdXCycU(pf21d5ed1 r1, p9ded6185 r2, string r3, Continuation r4) {
        return r1.sendReceipt(r2, r3, r4);
    }

    public static MutableLiveData FSkKPGnssKfdaRIM(pdb97fb8e r1) {
        return pdb97fb8e.m4bd6e7f5(r1);
    }

    public static void FzxfxyGcgjLyGsGz(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void GnUzrynDTuTmauyw(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string HCGhHxyGlWmjglBt(object r1) {
        return r1.tostring();
    }

    public static pabe3770e HWPaXKiUZWmZstZG(pdb97fb8e r1) {
        return pdb97fb8e.m74e3994c(r1);
    }

    public static void NBKjRhEZNhfQfxwy(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void NeDyugTmXgkvZrSg(MutableLiveData r0, object r1) {
        r0.setValue(r1);
    }

    public static object OCAgKphruVACLlto(pd47d680b r1, p0690dac5 r2, Continuation r3) {
        return r1.createInventorizationReceipt(r2, r3);
    }

    public static List OaNKiGhcpPrnteIM(ICollection r1, IEnumerable r2) {
        return ICollectionsKt.plus(r1, r2);
    }

    public static pabe3770e QjeLxRMTaoqPbdCH(pdb97fb8e r1) {
        return pdb97fb8e.m74e3994c(r1);
    }

    public static object RSLPkHhzlhaCScVv() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static p0690dac5 TyXBBIhKvRhIiIFc(p0690dac5 r1, string r2, string r3, p14abd389 r4, List r5, int r6, object r7) {
        return p0690dac5.m1c1e012b(r1, r2, r3, r4, r5, r6, r7);
    }

    public static pf21d5ed1 VIgijsbaQjDMXOKW(pdb97fb8e r1) {
        return pdb97fb8e.mbb30f96e(r1);
    }

    public static object WFqTagkbgRuApDHM(pdb97fb8e$p807ee7c0$1 r1, CoroutineScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static void ZAFdvaGUFDuqAkjp(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new pdb97fb8e$p807ee7c0$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return wFqTagkbgRuApDHM(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return QqpRjwConPeYpDWd((pdb97fb8e$p807ee7c0$1) TuekWYIokfRVZpKY(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r14) {
        if (((24 + 1) % 1) > 0) goto L57;
    L57:
        object r0 = rSLPkHhzlhaCScVv();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L25;
        fzxfxyGcgjLyGsGz(r14);
        this.fd304ba20 = 1;     // Catch: Exception -> L105
        r14 = KvDZkmbiYJBgboBX(OufXkDroOLiHAFHG(this.this$0), this);     // Catch: Exception -> L105
        if (r14 == r0) goto L86;
    L73:
        pdb97fb8e r12 = this.this$0;     // Catch: Exception -> L105
        p0690dac5 r142 = (p0690dac5) r14;     // Catch: Exception -> L105
        this.L$0 = r142;     // Catch: Exception -> L105
        this.fd304ba20 = 2;     // Catch: Exception -> L105
        object r13 = eXFalZjXlNpHFmgX(r12, r142, this);     // Catch: Exception -> L105
        if (r13 == r0) goto L86;
        p0690dac5 r5 = r142;
        r14 = r13;
    L77:
        p0690dac5 r143 = tyXBBIhKvRhIiIFc(r5, null, null, null, oaNKiGhcpPrnteIM(cyUhiriyqoNRFjjZ(r5), (List) r14), 7, null);     // Catch: Exception -> L105
        this.L$0 = r143;     // Catch: Exception -> L105
        this.fd304ba20 = 3;     // Catch: Exception -> L105
        object r15 = oCAgKphruVACLlto(KiYQfEvRSxTyKhLV(this.this$0), r143, this);     // Catch: Exception -> L105
        if (r15 == r0) goto L86;
        p0690dac5 r16 = r143;
        r14 = r15;
    L81:
        pf21d5ed1 r4 = vIgijsbaQjDMXOKW(this.this$0);     // Catch: Exception -> L105
        this.L$0 = r16;     // Catch: Exception -> L105
        this.fd304ba20 = 4;     // Catch: Exception -> L105
        if (esdMZMSdPvdXCycU(r4, (p9ded6185) r14, hCGhHxyGlWmjglBt(WsCEsYaidSlvtAGl(pdb97fb8e.class)), this) == r0) goto L86;
    L84:
        this.L$0 = null;     // Catch: Exception -> L105
        this.fd304ba20 = 5;     // Catch: Exception -> L105
        if (QfcPbHYGMkSitLDg(OHXjakUxPPpQNpTp(this.this$0), r16, this) == r0) goto L86;
    L87:
        BvHEoBgxVNzFYhIP(BshMEgIrLCJBmBLA(this.this$0), new p325296ab(EhdeQRrguFdWpTsk(HztkDRzeSyWwblKa(this.this$0), C2824R.string.inventorization_send_receipt_success)));     // Catch: Exception -> L105
        PbAzCFOXQRBqKWrb(qjeLxRMTaoqPbdCH(this.this$0));     // Catch: Exception -> L105
    L17:
        return Unit.INSTANCE;
    L86:
        return r0;
    L25:
        if (r1 != 1) goto L95;
        nBKjRhEZNhfQfxwy(r14);     // Catch: Exception -> L105
        goto L73
    L95:
        if (r1 == 2) goto L11;
        if (r1 == 3) goto L65;
        if (r1 == 4) goto L35;
        if (r1 != 5) goto L63;
        zAFdvaGUFDuqAkjp(r14);     // Catch: Exception -> L105
        goto L87
    L63:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L35:
        r16 = (p0690dac5) this.L$0;
        gnUzrynDTuTmauyw(r14);     // Catch: Exception -> L105
        goto L84
    L65:
        r16 = (p0690dac5) this.L$0;
        eWhJomuPtipnHClb(r14);     // Catch: Exception -> L105
        goto L81
    L11:
        p0690dac5 r17 = (p0690dac5) this.L$0;
        LGRgPAGOzupJGEAe(r14);     // Catch: Exception -> L105
        r5 = r17;
    L103:
        neDyugTmXgkvZrSg(fSkKPGnssKfdaRIM(this.this$0), new p89a5ff7f(PshILJCkvLEGMGam(XABUXTrBwzUPVdjv(this.this$0), C2824R.string.inventorization_send_receipt_error)));
        TuaIHpLkbfAIaswT(hWPaXKiUZWmZstZG(this.this$0));
        goto L17
    }
}

