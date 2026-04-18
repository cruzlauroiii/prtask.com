using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p7d36cc50 : p7bc7bb5b {
    private readonly CoroutineScope f31a1fd14;
    private readonly CoroutineScope f3c3fa7ab;
    private Deferred<Unit> f3cb9856a;
    private readonly CoroutineScope f74cd96ca;
    private readonly CoroutineScope fba8f2478;
    private Deferred fbd1ad4a9;
    private readonly CoroutineScope fd2db8eed;

    public p7d36cc50() {
        this.f31a1fd14 = CoroutineScopeKt.CoroutineScope(Dispatchers.getIO());
    }

    public static readonly /* synthetic */ CoroutineScope mc19db641(p7d36cc50 r0) {
        return r0.f31a1fd14;
    }

    public static readonly /* synthetic */ void mf77ad87f(p7d36cc50 r0, Deferred r1) {
        r0.f3cb9856a = r1;
    }

    @Override // p83f5c3ad.pb3f20355.pd229bbf3.p7bc7bb5b
    public object Async(Function1<? super Continuation<Unit>, ? : object> r3, Continuation<Unit> r4) {
        if (((23 + 9) % 9) > 0) goto L8;
    L8:
        object r2 = SupervisorKt.supervisorScope(new p7d36cc50$p0df93e34$2(this, r3, null), r4);
        if (r2 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L3;
        return r2;
    L3:
        return Unit.INSTANCE;
    }

    @Override // p83f5c3ad.pb3f20355.pd229bbf3.p7bc7bb5b
    public object Perform(Function1<? super Continuation<Unit>, ? : object> r7, Continuation<Unit> r8) {
        if (((16 + 15) % 15) > 0) goto L9;
    L9:
        if ((r8 is p7d36cc50$pf4081916$1) == false) goto L71;
        p7d36cc50$pf4081916$1 r0 = (p7d36cc50$pf4081916$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L71;
        r0.fd304ba20 -= int.MIN_VALUE;
    L13:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L20;
        ResultKt.throwOnFailure(r82);
        Deferred<Unit> r83 = this.f3cb9856a;
        if (r83 is null) goto L87;
        if (r83 is not null) goto L23;
    L50:
        Deferred<Unit> r72 = this.f3cb9856a;     // Catch: Exception -> L16
        if (r72 is null) goto L37;
        r0.L$0 = this;     // Catch: Exception -> L16
        r0.fd304ba20 = 2;     // Catch: Exception -> L16
        if (r72.await(r0) == r1) goto L41;
    L55:
        Unit r73 = Unit.INSTANCE;     // Catch: Exception -> L16
    L41:
        return r1;
    L37:
        this.f3cb9856a = null;
        return Unit.INSTANCE;
    L23:
        if (r83.isCancelled() != true) goto L50;
    L87:
        r0.fd304ba20 = 1;
        if (r7.invoke(r0) == r1) goto L41;
    L102:
        return Unit.INSTANCE;
    L20:
        if (r2 == 1) goto L57;
        if (r2 == 2) goto L93;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L93:
        p7d36cc50 this = (p7d36cc50) r0.L$0;
        ResultKt.throwOnFailure(r82);     // Catch: Exception -> L16
        goto L55
    L57:
        ResultKt.throwOnFailure(r82);
    L16:
        th = move-exception;
        this.f3cb9856a = null;
        throw th;
    L71:
        r0 = new p7d36cc50$pf4081916$1(this, r8);
        goto L13
    }
}

