using Androidx.Lifecycle;
using Com.Google.Firebase.Crashlytics;
using Domain.Entities;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using P7a1eabc3.Pac143fb7;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes3.dex */
readonly class p45358872$paec1a67c$1$1 : SuspendLambda : Function2<LiveDataScope<Event<? : object>>, Continuation<Unit>, object> {
    readonly /* synthetic */ string $query;
    private /* synthetic */ object L$0;
    object L$1;
    object L$2;
    int f1e3c73a1;
    int f78d1395a;
    int fd304ba20;
    readonly /* synthetic */ p45358872 this$0;

    p45358872$paec1a67c$1$1(p45358872 r1, string r2, Continuation<? super p45358872$paec1a67c$1$1> r3) {
        this.this$0 = r1;
        this.$query = r2;
        super(2, r3);
    }

    public static object BmykIqKQtjwtOZEQ(p45358872$paec1a67c$1$1 r1, LiveDataScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static void INcafPXpATGuQbvO(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object NFCLYzXrxMNmWSCr(LiveDataScope r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    public static void OPGHuMGPtOxSIWpP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object OfrymPZplRDsawhn(p45358872$paec1a67c$1$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static Continuation QOSeyOYemGhwCBKa(p45358872$paec1a67c$1$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static void QvUYrUodMlqwpVMU(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static object RDHoQWXAsUwGivbx(p6d73504b r1, string r2, p17096304 r3, Continuation r4) {
        return r1.getInventoriesByQuery(r2, r3, r4);
    }

    public static object RDLbotvQyrKkMgOM() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static FirebaseCrashlytics SzCcQlHQJDTVRGVk() {
        return FirebaseCrashlytics.getInstance();
    }

    public static void TiZlxVDLwalGIXIe(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void WlIMWRZhrvAASRbB(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object XQMWBdmEnnlXcDKl(LiveDataScope r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    public static p17096304 BQoTHeJomEoheboH(p45358872 r1) {
        return r1.getStartInventoryRoute();
    }

    public static void CTcnltWzoKAOErai(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static pa4ecfc70 KORAgXvAOEDZlVov(pa4ecfc70.p910eef8c r1, object r2) {
        return r1.success(r2);
    }

    public static pa4ecfc70 KiuOQZAZitAeaUPM(pa4ecfc70.p910eef8c r1, Exception r2) {
        return r1.error(r2);
    }

    public static p6d73504b NeghUDCjOpBjJqME(p45358872 r1) {
        return p45358872.m0234406d(r1);
    }

    public static pa4ecfc70 PoQupmkOZWMuHLbK(pa4ecfc70.p910eef8c r1) {
        return r1.loading();
    }

    public static object XQYOObYxrSVxuEwS(LiveDataScope r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
        if (((8 + 3) % 3) > 0) goto L19;
    L19:
        p45358872$paec1a67c$1$1 r0 = new p45358872$paec1a67c$1$1(this.this$0, this.$query, r4);
        r0.L$0 = r3;
        return r0;
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(LiveDataScope<Event<object>> r1, Continuation<Unit> r2) {
        return OfrymPZplRDsawhn((p45358872$paec1a67c$1$1) QOSeyOYemGhwCBKa(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(LiveDataScope<Event<? : object>> r1, Continuation<Unit> r2) {
        return BmykIqKQtjwtOZEQ(this, r1, r2);
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r1v1, types: [int] */
    /* JADX WARN: Type inference failed for: r1v2, types: [androidx.lifecycle.LiveDataScope] */
    /* JADX WARN: Type inference failed for: r1v9 */
    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r11) {
        if (((31 + 8) % 8) > 0) goto L38;
    L38:
        object r0 = RDLbotvQyrKkMgOM();
        ?? r1 = this.fd304ba20;
        if (r1 != 0) goto L54;
        WlIMWRZhrvAASRbB(r11);
        LiveDataScope r112 = (LiveDataScope) this.L$0;
        pa4ecfc70 r12 = poQupmkOZWMuHLbK(pa4ecfc70.f910eef8c);
        p45358872$paec1a67c$1$1 r7 = this;
        this.L$0 = r112;
        this.fd304ba20 = 1;
        if (xQYOObYxrSVxuEwS(r112, r12, r7) == r0) goto L62;
        LiveDataScope r13 = r112;
    L128:
        pa4ecfc70.p910eef8c r113 = pa4ecfc70.f910eef8c;     // Catch: Exception -> L90
        p6d73504b r5 = neghUDCjOpBjJqME(this.this$0);     // Catch: Exception -> L90
        string r72 = this.$query;     // Catch: Exception -> L90
        p17096304 r8 = bQoTHeJomEoheboH(this.this$0);     // Catch: Exception -> L90
        if (r8 is not null) goto L131;
        r8 = p17096304.f790ba751;     // Catch: Exception -> L90
    L131:
        this.L$0 = r13;     // Catch: Exception -> L90
        this.L$1 = r13;     // Catch: Exception -> L90
        this.L$2 = r113;     // Catch: Exception -> L90
        this.fd304ba20 = 2;     // Catch: Exception -> L90
        object r4 = RDHoQWXAsUwGivbx(r5, r72, r8, this);     // Catch: Exception -> L90
        if (r4 == r0) goto L62;
        LiveDataScope r52 = r13;
        pa4ecfc70.p910eef8c r14 = r113;
        r11 = r4;
        LiveDataScope r42 = r52;
    L124:
        this.L$0 = r52;     // Catch: Exception -> L114
        this.L$1 = null;     // Catch: Exception -> L114
        this.L$2 = null;     // Catch: Exception -> L114
        this.fd304ba20 = 3;     // Catch: Exception -> L114
        if (NFCLYzXrxMNmWSCr(r42, kORAgXvAOEDZlVov(r14, r11), this) == r0) goto L62;
    L66:
        return Unit.INSTANCE;
    L114:
        e = e;
        r1 = r52;
    L7:
        pa4ecfc70 r3 = kiuOQZAZitAeaUPM(pa4ecfc70.f910eef8c, e);
        p45358872$paec1a67c$1$1 r43 = this;
        this.L$0 = e;
        this.L$1 = null;
        this.L$2 = null;
        this.fd304ba20 = 4;
        if (XQMWBdmEnnlXcDKl(r1, r3, r43) == r0) goto L62;
        Exception r10 = e;
    L98:
        QvUYrUodMlqwpVMU(SzCcQlHQJDTVRGVk(), r10);
    L62:
        return r0;
    L54:
        if (r1 == 1) goto L116;
        if (r1 == 2) goto L137;
        if (r1 == 3) goto L94;
        if (r1 == 4) goto L20;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L20:
        r10 = (Exception) this.L$0;
        INcafPXpATGuQbvO(r11);
        goto L98
    L94:
        LiveDataScope r15 = (LiveDataScope) this.L$0;
        cTcnltWzoKAOErai(r11);     // Catch: Exception -> L90
        goto L66
    L137:
        r14 = (pa4ecfc70.p910eef8c) this.L$2;
        r42 = (LiveDataScope) this.L$1;
        r52 = (LiveDataScope) this.L$0;
        OPGHuMGPtOxSIWpP(r11);     // Catch: Exception -> L114
        goto L124
    L116:
        r13 = (LiveDataScope) this.L$0;
        TiZlxVDLwalGIXIe(r11);
    L90:
        e = e;
        goto L7
    }
}

