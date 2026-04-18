using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p346d0a2c$p80ad8385$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd031d465 $position;
    int f77e881bc;
    int fd304ba20;
    int ffeec9665;
    readonly /* synthetic */ p346d0a2c this$0;

    p346d0a2c$p80ad8385$1(p346d0a2c r1, pd031d465 r2, Continuation<? super p346d0a2c$p80ad8385$1> r3) {
        this.this$0 = r1;
        this.$position = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p346d0a2c$p80ad8385$1(this.this$0, this.$position, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p346d0a2c$p80ad8385$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((3 + 4) % 4) > 0) goto L48;
    L48:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L12;
        if (r1 != 1) goto L49;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L43
    L17:
        if (((bool) r5).boolValue() == false) goto L21;
        this.fd304ba20 = 2;     // Catch: Exception -> L43
        if (p346d0a2c.mc6d5d1db(this.this$0).emit(Unit.INSTANCE, this) != r0) goto L33;
    L20:
        return r0;
    L33:
        return Unit.INSTANCE;
    L21:
        this.this$0.addPositionToReceipt(this.$position);     // Catch: Exception -> L43
        goto L33
    L49:
        if (r1 != 2) goto L39;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L43
        goto L33
    L39:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L12:
        ResultKt.throwOnFailure(r5);
        this.fd304ba20 = 1;     // Catch: Exception -> L43
        r5 = p346d0a2c.m4ff275f6(this.this$0, this);     // Catch: Exception -> L43
        if (r5 != r0) goto L17;
    L43:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L33
    }
}

