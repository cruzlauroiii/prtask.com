using Android.Util;
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
readonly class pbb51da1f$p9b63e6e8$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f4537265e;
    int f4addd5f4;
    int f8f33a7a3;
    int fd304ba20;
    int ff3154713;
    readonly /* synthetic */ pbb51da1f this$0;

    pbb51da1f$p9b63e6e8$1(pbb51da1f r1, Continuation<? super pbb51da1f$p9b63e6e8$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new pbb51da1f$p9b63e6e8$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pbb51da1f$p9b63e6e8$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((2 + 4) % 4) > 0) goto L17;
    L17:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L45;
        ResultKt.throwOnFailure(r5);
        this.fd304ba20 = 1;     // Catch: Exception -> L39
        r5 = pbb51da1f.md95a43c7(this.this$0).getCurrentPaybackReceipt(this);     // Catch: Exception -> L39
        if (r5 == r0) goto L9;
    L25:
        p18cf5223 r52 = (p18cf5223) r5;     // Catch: Exception -> L39
        pbb51da1f.m3757dd67(this.this$0, r52);     // Catch: Exception -> L39
        pbb51da1f.mf38c1956(this.this$0, r52);     // Catch: Exception -> L39
        this.fd304ba20 = 2;     // Catch: Exception -> L39
        if (pbb51da1f.mf4cf454e(this.this$0, this) == r0) goto L9;
    L62:
        return Unit.INSTANCE;
    L9:
        return r0;
    L45:
        if (r1 != 1) goto L51;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L39
        goto L25
    L51:
        if (r1 != 2) goto L48;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L39
        goto L62
    L48:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L39:
        e = move-exception;
        Console.e(this.this$0.tostring(), string.valueOf(e.getMessage()));
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L62
    }
}

