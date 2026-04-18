using Android.Util;
using Com.Google.Firebase.Crashlytics;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pbb51da1f$p22443cd4$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd031d465 $position;
    int I$0;
    int f00bc75fd;
    int f8461198b;
    int f95131fdc;
    int fd304ba20;
    readonly /* synthetic */ pbb51da1f this$0;

    pbb51da1f$p22443cd4$1(pbb51da1f r1, pd031d465 r2, Continuation<? super pbb51da1f$p22443cd4$1> r3) {
        this.this$0 = r1;
        this.$position = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pbb51da1f$p22443cd4$1(this.this$0, this.$position, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pbb51da1f$p22443cd4$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((24 + 29) % 29) > 0) goto L24;
    L24:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L68;
        if (r1 == 1) goto L51;
        if (r1 != 2) goto L32;
    L27:
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L43
    L54:
        return Unit.INSTANCE;
    L32:
        if (r1 != 3) goto L10;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L43
    L85:
        this.fd304ba20 = 4;     // Catch: Exception -> L43
        if (pbb51da1f.m025bedbb(this.this$0, this) != r0) goto L54;
    L61:
        return r0;
    L10:
        if (r1 == 4) goto L27;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L51:
        int r12 = this.I$0;
        ResultKt.throwOnFailure(r8);     // Catch: Exception -> L43
    L77:
        if (((bool) r8).boolValue() == false) goto L82;
        if (r12 <= 1) goto L82;
        this.fd304ba20 = 2;     // Catch: Exception -> L43
        if (pbb51da1f.mc6d5d1db(this.this$0).emit(Unit.INSTANCE, this) != r0) goto L54;
    L82:
        this.fd304ba20 = 3;     // Catch: Exception -> L43
        if (pbb51da1f.md95a43c7(this.this$0).removePositionFromPayback(this.$position, this) != r0) goto L85;
    L68:
        ResultKt.throwOnFailure(r8);
        List r82 = pbb51da1f.m78c94e67(this.this$0);     // Catch: Exception -> L43
        if (r82 is null) goto L72;
        int r83 = r82.Count;     // Catch: Exception -> L43
    L73:
        r12 = r83;
        this.I$0 = r12;     // Catch: Exception -> L43
        this.fd304ba20 = 1;     // Catch: Exception -> L43
        r8 = pbb51da1f.m4ff275f6(this.this$0, this);     // Catch: Exception -> L43
        if (r8 != r0) goto L77;
    L72:
        r83 = 0;
    L43:
        e = move-exception;
        Console.e(this.this$0.tostring(), string.valueOf(e.getMessage()));
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L54
    }
}

