using Android.Util;
using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pbb51da1f$pfd7a4707$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f15c65a53;
    int f472abf65;
    int f8bd4f0e1;
    int fd304ba20;
    readonly /* synthetic */ pbb51da1f this$0;

    pbb51da1f$pfd7a4707$1(pbb51da1f r1, Continuation<? super pbb51da1f$pfd7a4707$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new pbb51da1f$pfd7a4707$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pbb51da1f$pfd7a4707$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((20 + 26) % 26) > 0) goto L49;
    L49:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L57;
        if (r1 != 1) goto L51;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L6
    L61:
        this.this$0.resetNoteReceipt();     // Catch: Exception -> L6
        this.fd304ba20 = 2;     // Catch: Exception -> L6
        if (pbb51da1f.m025bedbb(this.this$0, this) != r0) goto L17;
    L22:
        return r0;
    L17:
        return Unit.INSTANCE;
    L51:
        if (r1 != 2) goto L11;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L6
        goto L17
    L11:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L57:
        ResultKt.throwOnFailure(r5);
        this.fd304ba20 = 1;     // Catch: Exception -> L6
        if (pbb51da1f.md95a43c7(this.this$0).clearPaybackPositions(this) != r0) goto L61;
    L6:
        e = move-exception;
        Console.e(this.this$0.tostring(), string.valueOf(e.getMessage()));
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L17
    }
}

