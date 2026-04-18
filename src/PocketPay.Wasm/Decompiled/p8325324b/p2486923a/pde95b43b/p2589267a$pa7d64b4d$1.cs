using Androidx.Lifecycle;
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
readonly class p2589267a$pa7d64b4d$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ ped663a3e $receipt;
    int f3cf1465e;
    int fd304ba20;
    readonly /* synthetic */ p2589267a this$0;

    p2589267a$pa7d64b4d$1(p2589267a r1, ped663a3e r2, Continuation<? super p2589267a$pa7d64b4d$1> r3) {
        this.this$0 = r1;
        this.$receipt = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p2589267a$pa7d64b4d$1(this.this$0, this.$receipt, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p2589267a$pa7d64b4d$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((2 + 3) % 3) > 0) goto L57;
    L57:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L21;
        ResultKt.throwOnFailure(r6);
        this.fd304ba20 = 1;     // Catch: Exception -> L11
        if (p2589267a.m260c792f(this.this$0).openNotEmptySellReceipt(this.$receipt, this) == r0) goto L32;
    L30:
        this.fd304ba20 = 2;     // Catch: Exception -> L11
        if (p2589267a.m025bedbb(this.this$0, this) == r0) goto L32;
    L33:
        MutableLiveData r62 = p2589267a.m78918dd4(this.this$0);     // Catch: Exception -> L11
        string r5 = this.$receipt.getNote();     // Catch: Exception -> L11
        if (r5 is not null) goto L36;
        r5 = "";
    L36:
        r62.setValue(r5);     // Catch: Exception -> L11
    L13:
        return Unit.INSTANCE;
    L32:
        return r0;
    L21:
        if (r1 != 1) goto L53;
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L11
        goto L30
    L53:
        if (r1 != 2) goto L58;
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L11
        goto L33
    L58:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L11:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L13
    }
}

