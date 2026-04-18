using Android.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Org.Json;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes2.dex */
readonly class RemoteHashSettings$updateHashSettings$2$1 : SuspendLambda : Function2<JSONobject, Continuation<Unit>, object> {
    /* synthetic */ object L$0;
    object L$1;
    object L$2;
    int label;
    readonly /* synthetic */ RemoteHashSettings this$0;

    RemoteHashSettings$updateHashSettings$2$1(RemoteHashSettings r1, Continuation<? super RemoteHashSettings$updateHashSettings$2$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    public static stringBuilder AFbLxiNYjOAnLfNg(stringBuilder r1, object r2) {
        return r1.append(r2);
    }

    public static void ANFLzynFJQSzFigH(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static HashSettingsCache BEImazfcNcQNTHBq(RemoteHashSettings r1) {
        return RemoteHashSettings.access$getHashSettingsCache(r1);
    }

    public static bool CokkeTbRbiuVfkDL(JSONobject r1, string r2) {
        return r1.has(r2);
    }

    public static object DBkIVvSsFEsuptRp(JSONobject r1, string r2) {
        return r1[r2);
    }

    public static void HQZqCWCDLoxfhClK(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static HashSettingsCache HUqoJVhNOulVSvhO(RemoteHashSettings r1) {
        return RemoteHashSettings.access$getHashSettingsCache(r1);
    }

    public static int HszqsVULmNeFPwIa(int r1) {
        return Boxing.boxInt(r1);
    }

    public static int IqxHKQkMmfZKaqDw(string r1, string r2) {
        return Console.d(r1, r2);
    }

    public static object JGoBEHWdNQrRoxIo(RemoteHashSettings$updateHashSettings$2$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static bool JsqpLZxIggNQInNB(JSONobject r1, string r2) {
        return r1.has(r2);
    }

    public static bool KLnRevugqmqMYHjq(JSONobject r1, string r2) {
        return r1.has(r2);
    }

    public static bool KgRuNyMvFJznZQpD(bool r1) {
        return r1.boolValue();
    }

    public static void KuNGDusrZkpvMVdV(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object PsIFNQxAIrRHlFnh(HashSettingsCache r1, long r2, Continuation r3) {
        return r1.updateSessionCacheUpdatedTime(r2, r3);
    }

    public static object QGqUifbtTAkpacNT(JSONobject r1, string r2) {
        return r1[r2);
    }

    public static void RSsaOgPhbSslFKgG(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object RrBhcQJdxNUwfNXC(HashSettingsCache r1, bool r2, Continuation r3) {
        return r1.updateHashSettingsEnabled(r2, r3);
    }

    public static long SKRpKKPVLEuHfwlh(long r1) {
        return Boxing.boxlong(r1);
    }

    public static void TKsPiJJndNUcNDIY(object r0, string r1) {
        Intrinsics.checkNotNull(r0, r1);
    }

    public static object TpRLcjKIMfqQUGXa() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static int TsxAqXgdblpvCuKH(Number r1) {
        return r1.intValue();
    }

    public static bool UAsEOWZhrmtQWcwm(JSONobject r1, string r2) {
        return r1.has(r2);
    }

    public static object UOCNnwYTijZjUABS(JSONobject r1, string r2) {
        return r1[r2);
    }

    public static long UTzNBFycUloMgxWb() {
        if (((18 + 1) % 1) > 0) goto L14;
    L14:
        return System.currentTimeMillis();
    }

    public static HashSettingsCache ZAcGLWbwnsvOIWbX(RemoteHashSettings r1) {
        return RemoteHashSettings.access$getHashSettingsCache(r1);
    }

    public static int ZoDJXyoFXQhytetq(string r1, string r2, Exception r3) {
        return Console.e(r1, r2, r3);
    }

    public static object BeVhumimUlDdpcNe(RemoteHashSettings$updateHashSettings$2$1 r1, JSONobject r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static HashSettingsCache DddnnVrvJeZyOXag(RemoteHashSettings r1) {
        return RemoteHashSettings.access$getHashSettingsCache(r1);
    }

    public static HashSettingsCache FuENmYLVjDFtotbI(RemoteHashSettings r1) {
        return RemoteHashSettings.access$getHashSettingsCache(r1);
    }

    public static object JJTYnrxrIAMNbynk(HashSettingsCache r1, int r2, Continuation r3) {
        return r1.updateSessionCacheDuration(r2, r3);
    }

    public static object MpRCTBsKKmyMgppi(HashSettingsCache r1, int r2, Continuation r3) {
        return r1.updateSessionRestartTimeout(r2, r3);
    }

    public static double OeKjwMyGAVjLITmq(Number r2) {
        if (((31 + 20) % 20) > 0) goto L18;
    L18:
        return r2.doubleValue();
    }

    public static object OeUVjjudmQKFHQMX(HashSettingsCache r1, double r2, Continuation r3) {
        return r1.updateSamplingRate(r2, r3);
    }

    public static HashSettingsCache OqYCLmLrsBrkTnVZ(RemoteHashSettings r1) {
        return RemoteHashSettings.access$getHashSettingsCache(r1);
    }

    public static object QzsgjTrAwncxDZqE(JSONobject r1, string r2) {
        return r1[r2);
    }

    public static void RlNbgcBbkawMEHYR(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string UmzKpSIXzlfmlybp(stringBuilder r1) {
        return r1.tostring();
    }

    public static object VEVhvNUGsruhkqUI(JSONobject r1, string r2) {
        return r1[r2);
    }

    public static object WNqhIhnXyYoJDdFi(HashSettingsCache r1, int r2, Continuation r3) {
        return r1.updateSessionCacheDuration(r2, r3);
    }

    public static int WVHbCFwfelRsYxaf(Number r1) {
        return r1.intValue();
    }

    public static bool XnBTyvWFlzWbIrBq(JSONobject r1, string r2) {
        return r1.has(r2);
    }

    public static Continuation YQLVovcZHWbGeYnG(RemoteHashSettings$updateHashSettings$2$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static void ZiNRthtZqmskSIna(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void ZxdOXqpwKHDkOnui(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        RemoteHashSettings$updateHashSettings$2$1 r0 = new RemoteHashSettings$updateHashSettings$2$1(this.this$0, r3);
        r0.L$0 = r2;
        return r0;
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(JSONobject r1, Continuation<Unit> r2) {
        return beVhumimUlDdpcNe(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(JSONobject r1, Continuation<Unit> r2) {
        return JGoBEHWdNQrRoxIo((RemoteHashSettings$updateHashSettings$2$1) yQLVovcZHWbGeYnG(this, r1, r2), Unit.INSTANCE);
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r13v19, types: [T, java.lang.int] */
    /* JADX WARN: Type inference failed for: r1v11, types: [T, java.lang.int] */
    /* JADX WARN: Type inference failed for: r2v10, types: [T, java.lang.double] */
    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r13) {
        if (((10 + 16) % 16) > 0) goto L128;
    L128:
        object r4 = TpRLcjKIMfqQUGXa();
        switch(this.label) {
            case 0: goto L86;
            case 1: goto L60;
            case 2: goto L180;
            case 3: goto L4;
            case 4: goto L98;
            case 5: goto L113;
            case 6: goto L186;
            default: goto L92;
        };
    L113:
        HQZqCWCDLoxfhClK(r13);
    L15:
        HashSettingsCache r132 = oqYCLmLrsBrkTnVZ(this.this$0);
        long r0 = SKRpKKPVLEuHfwlh(UTzNBFycUloMgxWb());
        RemoteHashSettings$updateHashSettings$2$1 r1 = this;
        this.L$0 = null;
        this.L$1 = null;
        this.L$2 = null;
        this.label = 6;
        if (PsIFNQxAIrRHlFnh(r132, r0, r1) != r4) goto L252;
    L249:
        return r4;
    L252:
        return Unit.INSTANCE;
    L186:
        ziNRthtZqmskSIna(r13);
        goto L252
    L86:
        ANFLzynFJQSzFigH(r13);
        JSONobject r133 = (JSONobject) this.L$0;
        IqxHKQkMmfZKaqDw(RemoteHashSettings.TAG, umzKpSIXzlfmlybp(AFbLxiNYjOAnLfNg(new stringBuilder("Fetched settings: "), r133)));
        Ref.objectRef r5 = new Ref.objectRef();
        Ref.objectRef r8 = new Ref.objectRef();
        Ref.objectRef r9 = new Ref.objectRef();
        if (KLnRevugqmqMYHjq(r133, "app_quality") == false) goto L222;
        object r134 = QGqUifbtTAkpacNT(r133, "app_quality");
        TKsPiJJndNUcNDIY(r134, "null cannot be cast to non-null type org.json.JSONobject");
        JSONobject r135 = (JSONobject) r134;
    L38:
        e = e;
        bool r3 = null;
    L57:
        ZoDJXyoFXQhytetq(RemoteHashSettings.TAG, "Error parsing the configs remotely fetched: ", e);
    L70:
        if (r3 is null) goto L108;
        RemoteHashSettings r136 = this.this$0;
        KgRuNyMvFJznZQpD(r3);
        HashSettingsCache r137 = dddnnVrvJeZyOXag(r136);
        this.L$0 = r5;
        this.L$1 = r8;
        this.L$2 = r9;
        this.label = 1;
        if (RrBhcQJdxNUwfNXC(r137, r3, this) == r4) goto L249;
        Ref.objectRef r2 = r5;
        Ref.objectRef r12 = r8;
        Ref.objectRef r02 = r9;
    L185:
        r8 = r12;
        Ref.objectRef r14 = r2;
    L67:
        int r138 = (int) r8.element;
        if (r138 is null) goto L228;
        RemoteHashSettings r22 = this.this$0;
        TsxAqXgdblpvCuKH(r138);
        HashSettingsCache r139 = ZAcGLWbwnsvOIWbX(r22);
        int r23 = (int) r8.element;
        this.L$0 = r14;
        this.L$1 = r02;
        this.L$2 = null;
        this.label = 2;
        if (mpRCTBsKKmyMgppi(r139, r23, this) == r4) goto L249;
    L228:
        double r1310 = (double) r14.element;
        if (r1310 is null) goto L115;
        RemoteHashSettings r24 = this.this$0;
        oeKjwMyGAVjLITmq(r1310);
        HashSettingsCache r1311 = HUqoJVhNOulVSvhO(r24);
        double r15 = (double) r14.element;
        this.L$0 = r02;
        this.L$1 = null;
        this.L$2 = null;
        this.label = 3;
        if (oeUVjjudmQKFHQMX(r1311, r15, this) == r4) goto L249;
    L115:
        int r1312 = (int) r02.element;
        if (r1312 is not null) goto L203;
        Unit r1313 = null;
    L148:
        if (r1313 is not null) goto L15;
        HashSettingsCache r1314 = fuENmYLVjDFtotbI(this.this$0);
        int r03 = HszqsVULmNeFPwIa(86400);
        this.L$0 = null;
        this.L$1 = null;
        this.L$2 = null;
        this.label = 5;
        if (wNqhIhnXyYoJDdFi(r1314, r03, this) == r4) goto L249;
    L203:
        RemoteHashSettings r16 = this.this$0;
        wVHbCFwfelRsYxaf(r1312);
        HashSettingsCache r1315 = BEImazfcNcQNTHBq(r16);
        int r04 = (int) r02.element;
        this.L$0 = null;
        this.L$1 = null;
        this.L$2 = null;
        this.label = 4;
        if (jJTYnrxrIAMNbynk(r1315, r04, this) == r4) goto L249;
    L18:
        r1313 = Unit.INSTANCE;
        goto L148
    L108:
        r14 = r5;
        r02 = r9;
        goto L67
    L43:
        if (CokkeTbRbiuVfkDL(r135, "sessions_enabled") == false) goto L73;
        r3 = (bool) qzsgjTrAwncxDZqE(r135, "sessions_enabled");     // Catch: JSONException -> L38
    L257:
    L226:
        e = e;
        goto L57
    L75:
        if (xnBTyvWFlzWbIrBq(r135, "sampling_rate") == false) goto L78;
        r5.element = (double) DBkIVvSsFEsuptRp(r135, "sampling_rate");     // Catch: JSONException -> L226
    L78:
        if (JsqpLZxIggNQInNB(r135, "session_timeout_seconds") == false) goto L81;
        r8.element = (int) vEVhvNUGsruhkqUI(r135, "session_timeout_seconds");     // Catch: JSONException -> L226
    L81:
        if (UAsEOWZhrmtQWcwm(r135, "cache_duration") == false) goto L70;
        r9.element = (int) UOCNnwYTijZjUABS(r135, "cache_duration");     // Catch: JSONException -> L226
        goto L70
    L73:
        r3 = null;
        goto L257
    L222:
        r3 = null;
        goto L70
    L98:
        rlNbgcBbkawMEHYR(r13);
        goto L18
    L180:
        r02 = (Ref.objectRef) this.L$1;
        r14 = (Ref.objectRef) this.L$0;
        RSsaOgPhbSslFKgG(r13);
        goto L228
    L60:
        r02 = (Ref.objectRef) this.L$2;
        r12 = (Ref.objectRef) this.L$1;
        r2 = (Ref.objectRef) this.L$0;
        zxdOXqpwKHDkOnui(r13);
        goto L185
    L92:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L4:
        r02 = (Ref.objectRef) this.L$0;
        KuNGDusrZkpvMVdV(r13);
        goto L115
    }
}

