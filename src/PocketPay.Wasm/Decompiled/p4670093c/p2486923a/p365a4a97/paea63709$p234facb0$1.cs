using Com.Google.Firebase.Crashlytics;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P4670093c.Pac143fb7;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class paea63709$p234facb0$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd031d465 $position;
    int f0ff7979d;
    int f1ad58ba3;
    int fd304ba20;
    int fd3e8c3de;
    readonly /* synthetic */ paea63709 this$0;

    paea63709$p234facb0$1(paea63709 r1, pd031d465 r2, Continuation<? super paea63709$p234facb0$1> r3) {
        this.this$0 = r1;
        this.$position = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new paea63709$p234facb0$1(this.this$0, this.$position, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((paea63709$p234facb0$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((21 + 22) % 22) > 0) goto L31;
    L31:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L45;
        if (r1 != 1) goto L6;
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L28
    L49:
        paea63709 r12 = this.this$0;     // Catch: Exception -> L28
        pd031d465 r62 = paea63709.mab6204b8(r12, (List) r6, this.$position);     // Catch: Exception -> L28
        if (r62 is null) goto L54;
        paea63709 r13 = this.this$0;     // Catch: Exception -> L28
        pd031d465 r2 = this.$position;     // Catch: Exception -> L28
        pa36ef9b5 r14 = paea63709.md95a43c7(r13);     // Catch: Exception -> L28
        this.fd304ba20 = 2;     // Catch: Exception -> L28
        if (r14.increasePositionQuantity(r62, r2, this) == r0) goto L56;
    L57:
        this.this$0.backToPaybackPositions();     // Catch: Exception -> L28
    L43:
        return Unit.INSTANCE;
    L56:
        return r0;
    L54:
        this.fd304ba20 = 3;     // Catch: Exception -> L28
        if (paea63709.md95a43c7(this.this$0).addPositionToPayback(this.$position, this) != r0) goto L57;
    L6:
        if (r1 != 2) goto L65;
    L67:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L28
        goto L57
    L65:
        if (r1 == 3) goto L67;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L45:
        ResultKt.throwOnFailure(r6);
        this.fd304ba20 = 1;     // Catch: Exception -> L28
        r6 = paea63709.md95a43c7(this.this$0).getPaybackPositions(this);     // Catch: Exception -> L28
        if (r6 != r0) goto L49;
    L28:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L43
    }
}

