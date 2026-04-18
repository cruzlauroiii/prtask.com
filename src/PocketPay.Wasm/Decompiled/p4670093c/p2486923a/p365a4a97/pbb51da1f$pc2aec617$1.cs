using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P4670093c.Pfd9160bb;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pbb51da1f$pc2aec617$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd031d465 $position;
    int f5d61dd36;
    int f659eb411;
    int f855f3e17;
    int f955bb309;
    int fd304ba20;
    readonly /* synthetic */ pbb51da1f this$0;

    pbb51da1f$pc2aec617$1(pbb51da1f r1, pd031d465 r2, Continuation<? super pbb51da1f$pc2aec617$1> r3) {
        this.this$0 = r1;
        this.$position = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pbb51da1f$pc2aec617$1(this.this$0, this.$position, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pbb51da1f$pc2aec617$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((26 + 4) % 4) > 0) goto L50;
    L50:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L17;
        ResultKt.throwOnFailure(r5);
        this.fd304ba20 = 1;     // Catch: Exception -> L41
        r5 = pbb51da1f.m4ff275f6(this.this$0, this);     // Catch: Exception -> L41
        if (r5 != r0) goto L56;
    L59:
        return r0;
    L56:
        if (((bool) r5).boolValue() == false) goto L60;
        this.fd304ba20 = 2;     // Catch: Exception -> L41
        if (pbb51da1f.mc6d5d1db(this.this$0).emit(Unit.INSTANCE, this) == r0) goto L59;
    L21:
        return Unit.INSTANCE;
    L60:
        p1b3a5bf0.pb0da8397.m962cbe9a(pbb51da1f.m89a7f193(this.this$0), this.$position, null, 2, null);     // Catch: Exception -> L41
        goto L21
    L17:
        if (r1 != 1) goto L6;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L41
        goto L56
    L6:
        if (r1 != 2) goto L25;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L41
        goto L21
    L25:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L41:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L21
    }
}

