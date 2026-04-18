using Androidx.Lifecycle;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlin.Reflect;
using Kotlinx.Coroutines;
using P0c985ebf.P2486923a.P1e11b989;
using P0c985ebf.Pac143fb7;
using P0c985ebf.Pfd9160bb;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.Pac143fb7.P1e11b989;
using Pf3e08b51.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
readonly class p78015202$p807ee7c0$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p013bab85.p0750a1fd $currentState;
    readonly /* synthetic */ string $reason;
    object L$0;
    int f0d6a0788;
    int f18044771;
    int fd304ba20;
    readonly /* synthetic */ p78015202 this$0;

    p78015202$p807ee7c0$1(p013bab85.p0750a1fd r1, p78015202 r2, string r3, Continuation<? super p78015202$p807ee7c0$1> r4) {
        this.$currentState = r1;
        this.this$0 = r2;
        this.$reason = r3;
        super(2, r4);
    }

    public static void AZqNoAYNddhHuGtL(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void DPWUXDjYcCHJouyz(MutableLiveData r0, object r1) {
        r0.setValue(r1);
    }

    public static object EeWnGVhDsNBtqbSl(p4ee8dd59 r1, Continuation r2) {
        return r1.clearInspectedPositions(r2);
    }

    public static object GCNgdWFNRexgljjl(p4ee8dd59 r1, string r2, Continuation r3) {
        return r1.updateInspectionReason(r2, r3);
    }

    public static p02eb2260 GunntuxAltOWwHvC(p78015202 r1) {
        return p78015202.m245216f0(r1);
    }

    public static void OSWUouYjZzeChurx(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void ObSuWjshyhAcegGm(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void OxIgeYmjHJOVnAMK(p41e6ee8c r0) {
        r0.back();
    }

    public static object PaqMUfkfyvjNcdmz() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static MutableLiveData PnFqLOTJNflbUjPT(p78015202 r1) {
        return p78015202.mdbbe0d99(r1);
    }

    public static p41e6ee8c RWcBrDjXtZtCVghU(p78015202 r1) {
        return p78015202.m26e218d3(r1);
    }

    public static string SdBpGSWnrDqwxyXJ(object r1) {
        return r1.tostring();
    }

    public static object TFnBElAGPXStKDex(p78015202 r1, Continuation r2) {
        return p78015202.mc8e7b41d(r1, r2);
    }

    public static void ULzfFWzuVtYsUuGK(p02eb2260 r0) {
        r0.backToLauncher();
    }

    public static object XhHUKXHEWgwWbsUT(p78015202$p807ee7c0$1 r1, CoroutineScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static Continuation ZPrjCrqAjyiuzbyw(p78015202$p807ee7c0$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static object BzJjIKaRknEhegxd(p4ee8dd59 r1, Continuation r2) {
        return r1.getInspectionReceipt(r2);
    }

    public static void CNuZbPLDfzDtCYoB(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static p4ee8dd59 CsoZjAccFqerZnCv(p78015202 r1) {
        return p78015202.m4aee790e(r1);
    }

    public static pf21d5ed1 DIuDQreUrWYvOeHl(p78015202 r1) {
        return p78015202.mbb30f96e(r1);
    }

    public static void EXXpRloqAQqvyAQJ(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static MutableLiveData JVfOfFohNcWkqpzK(p78015202 r1) {
        return p78015202.mdbbe0d99(r1);
    }

    public static object LdJqFXDcouxVjuUx(pf21d5ed1 r1, p9ded6185 r2, string r3, Continuation r4) {
        return r1.sendReceipt(r2, r3, r4);
    }

    public static void LqWiDdQxqweAdKmT(MutableLiveData r0, object r1) {
        r0.setValue(r1);
    }

    public static object LvTrettxOyqnfcbP(p78015202$p807ee7c0$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static p4ee8dd59 LysNcOitIHhhjoyX(p78015202 r1) {
        return p78015202.m4aee790e(r1);
    }

    public static p4ee8dd59 RTPULfSEofPpSGPL(p78015202 r1) {
        return p78015202.m4aee790e(r1);
    }

    public static void VVMIrtHzrXJdXWyU(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static KClass XdrCjdhJsMzXzJTn(Class r1) {
        return Reflection.getOrCreateKotlinClass(r1);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
        if (((15 + 23) % 23) > 0) goto L19;
    L19:
        return new p78015202$p807ee7c0$1(this.$currentState, this.this$0, this.$reason, r4);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return XhHUKXHEWgwWbsUT(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return lvTrettxOyqnfcbP((p78015202$p807ee7c0$1) ZPrjCrqAjyiuzbyw(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((31 + 20) % 20) > 0) goto L7;
    L7:
        object r0 = PaqMUfkfyvjNcdmz();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L81;
        AZqNoAYNddhHuGtL(r8);
        if (this.$currentState != p013bab85.p0750a1fd.f3ad28de0) goto L15;
        this.fd304ba20 = 1;     // Catch: Exception -> L46
        if (TFnBElAGPXStKDex(this.this$0, this) != r0) goto L15;
    L26:
        return r0;
    L15:
        this.fd304ba20 = 2;     // Catch: Exception -> L46
        if (GCNgdWFNRexgljjl(csoZjAccFqerZnCv(this.this$0), this.$reason, this) == r0) goto L26;
    L18:
        pf21d5ed1 r12 = dIuDQreUrWYvOeHl(this.this$0);     // Catch: Exception -> L46
        this.L$0 = r12;     // Catch: Exception -> L46
        this.fd304ba20 = 3;     // Catch: Exception -> L46
        r8 = bzJjIKaRknEhegxd(rTPULfSEofPpSGPL(this.this$0), this);     // Catch: Exception -> L46
        if (r8 == r0) goto L26;
    L21:
        this.L$0 = null;     // Catch: Exception -> L46
        this.fd304ba20 = 4;     // Catch: Exception -> L46
        if (ldJqFXDcouxVjuUx(r12, (p9ded6185) r8, SdBpGSWnrDqwxyXJ(xdrCjdhJsMzXzJTn(p78015202.class)), this) == r0) goto L26;
    L24:
        this.fd304ba20 = 5;     // Catch: Exception -> L46
        if (EeWnGVhDsNBtqbSl(lysNcOitIHhhjoyX(this.this$0), this) == r0) goto L26;
    L27:
        lqWiDdQxqweAdKmT(jVfOfFohNcWkqpzK(this.this$0), pb532d556.fd0749aab);     // Catch: Exception -> L46
        ULzfFWzuVtYsUuGK(GunntuxAltOWwHvC(this.this$0));     // Catch: Exception -> L46
    L54:
        return Unit.INSTANCE;
    L81:
        if (r1 != 1) goto L36;
        vVMIrtHzrXJdXWyU(r8);     // Catch: Exception -> L46
        goto L15
    L36:
        if (r1 != 2) goto L68;
        cNuZbPLDfzDtCYoB(r8);     // Catch: Exception -> L46
        goto L18
    L68:
        if (r1 == 3) goto L75;
        if (r1 != 4) goto L47;
        ObSuWjshyhAcegGm(r8);     // Catch: Exception -> L46
        goto L24
    L47:
        if (r1 != 5) goto L4;
        OSWUouYjZzeChurx(r8);     // Catch: Exception -> L46
        goto L27
    L4:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L75:
        r12 = (pf21d5ed1) this.L$0;
        eXXpRloqAQqvyAQJ(r8);     // Catch: Exception -> L46
    L93:
        DPWUXDjYcCHJouyz(PnFqLOTJNflbUjPT(this.this$0), pb532d556.fbb1ca97e);
        OxIgeYmjHJOVnAMK(RWcBrDjXtZtCVghU(this.this$0));
        goto L54
    }
}

