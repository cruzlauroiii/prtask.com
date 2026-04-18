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

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes3.dex */
readonly class p9c0abf93$pfaebc503$1 : SuspendLambda : Function2<LiveDataScope<Event<? : string>>, Continuation<Unit>, object> {
    private /* synthetic */ object L$0;
    int f8cf6864a;
    int f97824751;
    int fd304ba20;
    readonly /* synthetic */ p9c0abf93 this$0;

    p9c0abf93$pfaebc503$1(p9c0abf93 r1, Continuation<? super p9c0abf93$pfaebc503$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    public static pa4ecfc70 AIYcIUpFqMIVOuxV(pa4ecfc70.p910eef8c r1, object r2) {
        return r1.success(r2);
    }

    public static object CWTMnTyiUlkPJKmQ(LiveDataScope r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    public static object DRSFAnUKOlgnUnOX(p9c0abf93$pfaebc503$1 r1, LiveDataScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static object GIMwvLPGTyPEejVp(LiveDataScope r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    public static pa4ecfc70 GjXueMEQORGOHsnm(pa4ecfc70.p910eef8c r1, Exception r2) {
        return r1.error(r2);
    }

    public static void HOBlKHLXIuflBbci(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static object HabKuQWORsgBCdOu() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static FirebaseCrashlytics WBemsszTbldibVsZ() {
        return FirebaseCrashlytics.getInstance();
    }

    public static void WUvhEiIDTePVwVGw(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void XvbbzTBNIfkKmubn(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void YqPBsLLvuAnUZYkD(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static pa4ecfc70 CMGKHgFfdhGMGneu(pa4ecfc70.p910eef8c r1) {
        return r1.loading();
    }

    public static void DjeBankvzTAzLhWM(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static p6d73504b FtCLkwFTxcwmoMWe(p9c0abf93 r1) {
        return p9c0abf93.m0234406d(r1);
    }

    public static object OekTzJtsAJrTlnuG(p9c0abf93$pfaebc503$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static object SWvvfEDMoZfpPQtg(p6d73504b r1, Continuation r2) {
        return r1.getDefaultCommodityCode(r2);
    }

    public static void SqGkXBhplDkEeWWb(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object UhNLkpqHwVXQOoXC(LiveDataScope r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    public static Continuation ZTOVYOJLmSfCnOHv(p9c0abf93$pfaebc503$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        p9c0abf93$pfaebc503$1 r0 = new p9c0abf93$pfaebc503$1(this.this$0, r3);
        r0.L$0 = r2;
        return r0;
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(LiveDataScope<Event<string>> r1, Continuation<Unit> r2) {
        return oekTzJtsAJrTlnuG((p9c0abf93$pfaebc503$1) zTOVYOJLmSfCnOHv(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(LiveDataScope<Event<? : string>> r1, Continuation<Unit> r2) {
        return DRSFAnUKOlgnUnOX(this, r1, r2);
    }

    /* JADX WARN: Type inference failed for: r1v1, types: [androidx.lifecycle.LiveDataScope, int] */
    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((13 + 21) % 21) > 0) goto L87;
    L87:
        object r0 = HabKuQWORsgBCdOu();
        ?? r1 = this.fd304ba20;
        if (r1 != 0) goto L26;
        XvbbzTBNIfkKmubn(r8);
        LiveDataScope r82 = (LiveDataScope) this.L$0;
        pa4ecfc70 r12 = cMGKHgFfdhGMGneu(pa4ecfc70.f910eef8c);
        p9c0abf93$pfaebc503$1 r6 = this;
        this.L$0 = r82;
        this.fd304ba20 = 1;
        if (uhNLkpqHwVXQOoXC(r82, r12, r6) == r0) goto L34;
        LiveDataScope r13 = r82;
    L4:
        this.L$0 = r13;     // Catch: Exception -> L115
        this.fd304ba20 = 2;     // Catch: Exception -> L115
        r8 = sWvvfEDMoZfpPQtg(ftCLkwFTxcwmoMWe(this.this$0), this);     // Catch: Exception -> L115
        if (r8 == r0) goto L34;
    L7:
        pa4ecfc70.p910eef8c r4 = pa4ecfc70.f910eef8c;     // Catch: Exception -> L115
        this.L$0 = r13;     // Catch: Exception -> L115
        this.fd304ba20 = 3;     // Catch: Exception -> L115
        if (CWTMnTyiUlkPJKmQ(r13, AIYcIUpFqMIVOuxV(r4, (string) r8), this) == r0) goto L34;
    L101:
        return Unit.INSTANCE;
    L34:
        return r0;
    L26:
        if (r1 == 1) goto L41;
        if (r1 == 2) goto L15;
        if (r1 == 3) goto L10;
        if (r1 != 4) goto L56;
        Exception r7 = (Exception) this.L$0;
        sqGkXBhplDkEeWWb(r8);
    L58:
        HOBlKHLXIuflBbci(WBemsszTbldibVsZ(), r7);
        goto L101
    L56:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L10:
        LiveDataScope r14 = (LiveDataScope) this.L$0;
        YqPBsLLvuAnUZYkD(r8);     // Catch: Exception -> L115
        goto L101
    L15:
        r13 = (LiveDataScope) this.L$0;
        djeBankvzTAzLhWM(r8);     // Catch: Exception -> L115
        goto L7
    L41:
        r13 = (LiveDataScope) this.L$0;
        WUvhEiIDTePVwVGw(r8);
    L115:
        e = move-exception;
        pa4ecfc70 r3 = GjXueMEQORGOHsnm(pa4ecfc70.f910eef8c, e);
        p9c0abf93$pfaebc503$1 r42 = this;
        this.L$0 = e;
        this.fd304ba20 = 4;
        if (GIMwvLPGTyPEejVp(r1, r3, r42) == r0) goto L34;
        r7 = e;
        goto L58
    }
}

