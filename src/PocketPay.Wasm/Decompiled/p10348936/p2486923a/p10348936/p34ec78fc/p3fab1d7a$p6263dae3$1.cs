using Com.Google.Firebase.Crashlytics;
using Java.Math;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P10348936.Pac143fb7;
using P10348936.Pfd9160bb;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.P7a1eabc3;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
readonly class p3fab1d7a$p6263dae3$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd031d465 $position;
    int f54fa5995;
    int fd304ba20;
    readonly /* synthetic */ p3fab1d7a this$0;

    p3fab1d7a$p6263dae3$1(p3fab1d7a r1, pd031d465 r2, Continuation<? super p3fab1d7a$p6263dae3$1> r3) {
        this.this$0 = r1;
        this.$position = r2;
        super(2, r3);
    }

    public static pd47d680b AKsWcMuSNdCpQohz(p3fab1d7a r1) {
        return p3fab1d7a.ma0e3f333(r1);
    }

    public static pd031d465 CJifcYekrsGVwlav(p3fab1d7a r1, List r2, pd031d465 r3) {
        return p3fab1d7a.mab6204b8(r1, r2, r3);
    }

    public static pd47d680b EVwNRJYyoxAdSOhD(p3fab1d7a r1) {
        return p3fab1d7a.ma0e3f333(r1);
    }

    public static FirebaseCrashlytics IifyJkiIZJStZWZs() {
        return FirebaseCrashlytics.getInstance();
    }

    public static object JkDAkoPsZRmVPmOC(pd47d680b r1, pd031d465 r2, Continuation r3) {
        return r1.updateCurrentInventorizationPosition(r2, r3);
    }

    public static decimal KhmCYqDGYhlSBbGX(pd031d465 r1) {
        return r1.getQuantity();
    }

    public static object MkyXaEGzvnqLUIee(p3fab1d7a$p6263dae3$1 r1, CoroutineScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static object CIDBPxSWyNhmFeQq(p3fab1d7a$p6263dae3$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static void FYgpEDTpyRWBHCQC(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static pabe3770e HYGekZvhsZMMfmDZ(p3fab1d7a r1) {
        return p3fab1d7a.m74e3994c(r1);
    }

    public static void JmtLPetqSXdtdxbn(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static pd031d465 MfRKzNQYiESsouFc(pd031d465 r1, string r2, decimal r3, decimal r4, string r5, string r6, int r7, decimal r8, decimal r9, string r10, string r11, pa1fa2777 r12, decimal r13, decimal r14, decimal r15, p5267f68e r16, int r17, object r18) {
        return pd031d465.m1c1e012b(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18);
    }

    public static object MqBAfZeuIGNbcgGC(pd47d680b r1, pd031d465 r2, Continuation r3) {
        return r1.addPositionToCurrentInventorization(r2, r3);
    }

    public static void NEaCBeLZqzlfWHdd(pabe3770e r0) {
        r0.backToInventorization();
    }

    public static void RyuZZCkJiLcGFFjm(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static void SWowShlephSZuMVW(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object UTgAItHHbAHwUhjv(pd47d680b r1, Continuation r2) {
        return r1.getCurrentInventorizationPositions(r2);
    }

    public static Continuation VYbGtLQQtnyZOqlx(p3fab1d7a$p6263dae3$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static pd47d680b WSgSddONGooIRmPH(p3fab1d7a r1) {
        return p3fab1d7a.ma0e3f333(r1);
    }

    public static object ZnjRHvLiJZxVcXiM() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p3fab1d7a$p6263dae3$1(this.this$0, this.$position, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return MkyXaEGzvnqLUIee(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return cIDBPxSWyNhmFeQq((p3fab1d7a$p6263dae3$1) vYbGtLQQtnyZOqlx(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r26) {
        if (((22 + 9) % 9) > 0) goto L58;
    L58:
        object r1 = znjRHvLiJZxVcXiM();
        int r2 = this.fd304ba20;
        if (r2 != 0) goto L15;
        fYgpEDTpyRWBHCQC(r26);
        this.fd304ba20 = 1;     // Catch: Exception -> L19
        object r22 = uTgAItHHbAHwUhjv(wSgSddONGooIRmPH(this.this$0), this);     // Catch: Exception -> L19
        if (r22 == r1) goto L54;
    L47:
        p3fab1d7a r5 = this.this$0;     // Catch: Exception -> L19
        pd031d465 r7 = CJifcYekrsGVwlav(r5, (List) r22, this.$position);     // Catch: Exception -> L19
        if (r7 is null) goto L52;
        p3fab1d7a r23 = this.this$0;     // Catch: Exception -> L19
        pd031d465 r3 = this.$position;     // Catch: Exception -> L19
        pd47d680b r24 = EVwNRJYyoxAdSOhD(r23);     // Catch: Exception -> L19
        pd031d465 r32 = mfRKzNQYiESsouFc(r7, null, null, null, null, null, 0, KhmCYqDGYhlSBbGX(r3), null, null, null, null, null, null, null, null, 32703, null);     // Catch: Exception -> L19
        this.fd304ba20 = 2;     // Catch: Exception -> L19
        if (JkDAkoPsZRmVPmOC(r24, r32, this) == r1) goto L54;
    L55:
        nEaCBeLZqzlfWHdd(hYGekZvhsZMMfmDZ(this.this$0));     // Catch: Exception -> L19
    L32:
        return Unit.INSTANCE;
    L52:
        this.fd304ba20 = 3;     // Catch: Exception -> L19
        if (mqBAfZeuIGNbcgGC(AKsWcMuSNdCpQohz(this.this$0), this.$position, this) != r1) goto L55;
    L54:
        return r1;
    L15:
        if (r2 != 1) goto L28;
        jmtLPetqSXdtdxbn(r26);     // Catch: Exception -> L19
        r22 = r26;
        goto L47
    L28:
        if (r2 != 2) goto L8;
    L10:
        sWowShlephSZuMVW(r26);     // Catch: Exception -> L19
        goto L55
    L8:
        if (r2 == 3) goto L10;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L19:
        e = move-exception;
        ryuZZCkJiLcGFFjm(IifyJkiIZJStZWZs(), e);
        goto L32
    }
}

