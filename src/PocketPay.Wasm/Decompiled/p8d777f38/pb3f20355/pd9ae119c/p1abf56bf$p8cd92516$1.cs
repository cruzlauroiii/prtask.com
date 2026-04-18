using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P7ddcfee1;
using Pad5f82e8.P07214c67.P9efab239;
using Pad5f82e8.P07214c67.Pfa53b91c;
using Retrofit2;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
readonly class p1abf56bf$p8cd92516$1 : SuspendLambda : Function2<CoroutineScope, Continuation<string>, object> {
    readonly /* synthetic */ string $phone;
    object L$0;
    int f18f3eac9;
    int faa6052ac;
    int fd304ba20;
    readonly /* synthetic */ p1abf56bf this$0;

    p1abf56bf$p8cd92516$1(p1abf56bf r1, string r2, Continuation<? super p1abf56bf$p8cd92516$1> r3) {
        this.this$0 = r1;
        this.$phone = r2;
        super(2, r3);
    }

    public static string CBjaDEIqhukthwic(p42c567ea r1) {
        return r1.string();
    }

    public static Continuation GYDuUACgMDAImCqn(p1abf56bf$p8cd92516$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static object HcWPOsxZBApRBFVM() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object JKLMeelawCwMISZr(p1abf56bf$p8cd92516$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static object JvmDrOMMEdeZuaKY(Response r1) {
        return r1.body();
    }

    public static void KbBwPszKxVNUOrBl(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object LAyUexSTupcNlBAD(p1abf56bf r1, string r2, Continuation r3) {
        return p1abf56bf.m7ade4777(r1, r2, r3);
    }

    public static object NcdZqLKHFCOmjRAO(p1abf56bf$p8cd92516$1 r1, CoroutineScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static bool BQPfQBNIVqDhygLT(Response r1) {
        return r1.isSuccessful();
    }

    public static p5d5d995f FVoBXTFeBHoCWrMk(p1abf56bf r1) {
        return p1abf56bf.m06c5d46f(r1);
    }

    public static void KIdLbwLZBTVJvGuP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void NUjuhulrIuSBvdFr(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object YaUQIrprpPGGiyDL(p5d5d995f r1, p88067889 r2, Continuation r3) {
        return r1.getToken(r2, r3);
    }

    public static void YrIsJrtfysuPzArY(p1abf56bf r0, string r1) {
        p1abf56bf.mf1304e65(r0, r1);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p1abf56bf$p8cd92516$1(this.this$0, this.$phone, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<string> r2) {
        return NcdZqLKHFCOmjRAO(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<string> r2) {
        return JKLMeelawCwMISZr((p1abf56bf$p8cd92516$1) GYDuUACgMDAImCqn(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((18 + 15) % 15) > 0) goto L45;
    L45:
        object r0 = HcWPOsxZBApRBFVM();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L41;
        if (r1 == 1) goto L76;
        if (r1 != 2) goto L18;
        KbBwPszKxVNUOrBl(r7);
    L86:
        Response r72 = (Response) r7;
        if (bQPfQBNIVqDhygLT(r72) == false) goto L32;
        p42c567ea r73 = (p42c567ea) JvmDrOMMEdeZuaKY(r72);
        if (r73 is null) goto L32;
        p1abf56bf r6 = this.this$0;
        string r74 = CBjaDEIqhukthwic(r73);
        yrIsJrtfysuPzArY(r6, r74);
        return r74;
    L32:
        throw new pb6756f88("Error receiving token");
    L18:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L76:
        p5d5d995f r12 = (p5d5d995f) this.L$0;
        nUjuhulrIuSBvdFr(r7);
    L77:
        p88067889 r75 = (p88067889) r7;
        p1abf56bf$p8cd92516$1 r3 = this;
        this.L$0 = null;
        this.fd304ba20 = 2;
        r7 = yaUQIrprpPGGiyDL(r12, r75, r3);
        if (r7 != r0) goto L86;
    L50:
        return r0;
    L41:
        kIdLbwLZBTVJvGuP(r7);
        r12 = fVoBXTFeBHoCWrMk(this.this$0);
        p1abf56bf r76 = this.this$0;
        string r4 = this.$phone;
        p1abf56bf$p8cd92516$1 r5 = this;
        this.L$0 = r12;
        this.fd304ba20 = 1;
        r7 = LAyUexSTupcNlBAD(r76, r4, r5);
        if (r7 == r0) goto L50;
        goto L50
    }
}

