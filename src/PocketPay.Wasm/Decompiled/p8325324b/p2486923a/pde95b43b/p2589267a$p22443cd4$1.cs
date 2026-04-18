using Com.Google.Firebase.Crashlytics;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P4d236d9a.P2df4812c.Pf5d7e253.P705f8913.P518a4861.P8325324b.P86ccec3d;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p2589267a$p22443cd4$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd031d465 $position;
    readonly /* synthetic */ ped663a3e $receipt;
    int f148f8443;
    int f29a00a23;
    int f6c8134df;
    int fd304ba20;
    readonly /* synthetic */ p2589267a this$0;

    p2589267a$p22443cd4$1(p2589267a r1, ped663a3e r2, pd031d465 r3, Continuation<? super p2589267a$p22443cd4$1> r4) {
        this.this$0 = r1;
        this.$receipt = r2;
        this.$position = r3;
        super(2, r4);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
        if (((10 + 16) % 16) > 0) goto L20;
    L20:
        return new p2589267a$p22443cd4$1(this.this$0, this.$receipt, this.$position, r4);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p2589267a$p22443cd4$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((32 + 17) % 17) > 0) goto L30;
    L30:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L42;
        if (r1 != 1) goto L31;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L55
    L47:
        if (((List) r5).Count != p2589267a.m5fb81a65(this.this$0).getInt(C2845R.integer.one)) goto L49;
        this.this$0.clearReceiptHandler(this.$receipt);     // Catch: Exception -> L55
    L26:
        return Unit.INSTANCE;
    L49:
        this.fd304ba20 = 2;     // Catch: Exception -> L55
        if (p2589267a.m4672f3ae(this.this$0, this.$position, this) != r0) goto L26;
    L54:
        return r0;
    L31:
        if (r1 != 2) goto L18;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L55
        goto L26
    L18:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L42:
        ResultKt.throwOnFailure(r5);
        this.fd304ba20 = 1;     // Catch: Exception -> L55
        r5 = p2589267a.m260c792f(this.this$0).getReceiptPositions(this);     // Catch: Exception -> L55
        if (r5 != r0) goto L47;
    L55:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L26
    }
}

