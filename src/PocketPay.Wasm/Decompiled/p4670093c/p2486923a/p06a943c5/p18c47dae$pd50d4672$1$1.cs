using Androidx.Lifecycle;
using Com.Google.Firebase.Crashlytics;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p18c47dae$pd50d4672$1$1 : SuspendLambda : Function2<LiveDataScope<List<? : pd031d465>>, Continuation<Unit>, object> {
    readonly /* synthetic */ string $query;
    private /* synthetic */ object L$0;
    int f6664207f;
    int f982f5868;
    int fb7f88d85;
    int fd304ba20;
    int fe19f8803;
    readonly /* synthetic */ p18c47dae this$0;

    p18c47dae$pd50d4672$1$1(p18c47dae r1, string r2, Continuation<? super p18c47dae$pd50d4672$1$1> r3) {
        this.this$0 = r1;
        this.$query = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
        if (((17 + 12) % 12) > 0) goto L7;
    L7:
        p18c47dae$pd50d4672$1$1 r0 = new p18c47dae$pd50d4672$1$1(this.this$0, this.$query, r4);
        r0.L$0 = r3;
        return r0;
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(LiveDataScope<List<pd031d465>> r1, Continuation<Unit> r2) {
        return ((p18c47dae$pd50d4672$1$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(LiveDataScope<List<? : pd031d465>> r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r9) {
        if (((14 + 18) % 18) > 0) goto L22;
    L22:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L18;
        ResultKt.throwOnFailure(r9);
        LiveDataScope r92 = (LiveDataScope) this.L$0;
        this.L$0 = r92;     // Catch: Exception -> L72
        this.fd304ba20 = 1;     // Catch: Exception -> L72
        object r12 = p18c47dae.md95a43c7(this.this$0).getCurrentPaybackReceipt(this);     // Catch: Exception -> L72
        if (r12 == r0) goto L71;
        LiveDataScope r13 = r92;
        r9 = r12;
    L45:
        this.L$0 = r13;     // Catch: Exception -> L72
        this.fd304ba20 = 2;     // Catch: Exception -> L72
        r9 = p18c47dae.md95a43c7(this.this$0).getPositionsForPaybackByQuery(((p18cf5223) r9).getUuid(), this.$query, this);     // Catch: Exception -> L72
        if (r9 == r0) goto L71;
    L48:
        this.L$0 = null;     // Catch: Exception -> L72
        this.fd304ba20 = 3;     // Catch: Exception -> L72
        if (r13.emit((List) r9, this) == r0) goto L71;
    L33:
        return Unit.INSTANCE;
    L71:
        return r0;
    L18:
        if (r1 == 1) goto L52;
        if (r1 == 2) goto L59;
        if (r1 != 3) goto L31;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L72
        goto L33
    L31:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L59:
        r13 = (LiveDataScope) this.L$0;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L72
        goto L48
    L52:
        r13 = (LiveDataScope) this.L$0;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L72
    L72:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L33
    }
}

