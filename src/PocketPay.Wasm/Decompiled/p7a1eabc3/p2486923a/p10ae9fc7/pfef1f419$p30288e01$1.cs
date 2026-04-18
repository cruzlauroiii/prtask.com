using Com.Google.Firebase.Crashlytics;
using Java.Math;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P8325324b.Pac143fb7;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes3.dex */
readonly class pfef1f419$p30288e01$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd031d465 $position;
    int f73acc7bf;
    int fd304ba20;
    readonly /* synthetic */ pfef1f419 this$0;

    pfef1f419$p30288e01$1(pfef1f419 r1, pd031d465 r2, Continuation<? super pfef1f419$p30288e01$1> r3) {
        this.this$0 = r1;
        this.$position = r2;
        super(2, r3);
    }

    public static object AuXNnVMqoVZnCklZ(p0bfd7fb7 r1, pd031d465 r2, decimal r3, Continuation r4, int r5, object r6) {
        return p0bfd7fb7.pb0da8397.mf79db81e(r1, r2, r3, r4, r5, r6);
    }

    public static pd031d465 BIyXWOLxCOjgkuWe(pfef1f419 r1, List r2, pd031d465 r3) {
        return pfef1f419.mbaea185e(r1, r2, r3);
    }

    public static object CtwukvGroQqtuZmq(pfef1f419$p30288e01$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static object HziIMCRlqPyCOnPv(p0bfd7fb7 r1, Continuation r2) {
        return r1.getReceiptPositions(r2);
    }

    public static void IwDJonDMtViNzuVM(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static void JhRIrxRtZsyoRNXi(pfef1f419 r0) {
        pfef1f419.m920edbe7(r0);
    }

    public static object NXSsXjSnrGnFmbvC(pfef1f419$p30288e01$1 r1, CoroutineScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static void NzEKFkATEMfMMYjJ(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void PDSvYdVvIJdMVJQK(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static p0bfd7fb7 RekxOoxsjRiMQXbi(pfef1f419 r1) {
        return pfef1f419.m260c792f(r1);
    }

    public static FirebaseCrashlytics VMHqmFxKALdsvWAe() {
        return FirebaseCrashlytics.getInstance();
    }

    public static Continuation PFvVIyCClhJQAKEU(pfef1f419$p30288e01$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static void PInZflEaYvPgEWJi(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object USRlmyyVgYsJzskt(p0bfd7fb7 r1, pd031d465 r2, Continuation r3) {
        return r1.addPositionToReceipt(r2, r3);
    }

    public static object WfXyePttanwiPTqn() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static p0bfd7fb7 WgGUPJCrPvEtcbXq(pfef1f419 r1) {
        return pfef1f419.m260c792f(r1);
    }

    public static p0bfd7fb7 YPkGDbIjnFRbPYtA(pfef1f419 r1) {
        return pfef1f419.m260c792f(r1);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pfef1f419$p30288e01$1(this.this$0, this.$position, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return NXSsXjSnrGnFmbvC(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return CtwukvGroQqtuZmq((pfef1f419$p30288e01$1) pFvVIyCClhJQAKEU(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r12) {
        if (((2 + 14) % 14) > 0) goto L38;
    L38:
        object r0 = wfXyePttanwiPTqn();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L60;
        NzEKFkATEMfMMYjJ(r12);
        this.fd304ba20 = 1;     // Catch: Exception -> L6
        r12 = HziIMCRlqPyCOnPv(yPkGDbIjnFRbPYtA(this.this$0), this);     // Catch: Exception -> L6
        if (r12 == r0) goto L27;
    L20:
        pfef1f419 r13 = this.this$0;     // Catch: Exception -> L6
        pd031d465 r6 = BIyXWOLxCOjgkuWe(r13, (List) r12, this.$position);     // Catch: Exception -> L6
        if (r6 is null) goto L25;
        p0bfd7fb7 r5 = wgGUPJCrPvEtcbXq(this.this$0);     // Catch: Exception -> L6
        this.fd304ba20 = 2;     // Catch: Exception -> L6
        pfef1f419$p30288e01$1 r8 = this;
        if (AuXNnVMqoVZnCklZ(r5, r6, null, r8, 2, null) == r0) goto L27;
    L28:
        JhRIrxRtZsyoRNXi(r8.this$0);     // Catch: Exception -> L6
    L8:
        return Unit.INSTANCE;
    L25:
        r8 = this;
        r8.fd304ba20 = 3;     // Catch: Exception -> L6
        if (uSRlmyyVgYsJzskt(RekxOoxsjRiMQXbi(r8.this$0), r8.$position, r8) != r0) goto L28;
    L27:
        return r0;
    L60:
        if (r1 != 1) goto L63;
        PDSvYdVvIJdMVJQK(r12);     // Catch: Exception -> L6
        goto L20
    L63:
        if (r1 != 2) goto L43;
    L12:
        pInZflEaYvPgEWJi(r12);     // Catch: Exception -> L6
        r8 = this;
        goto L28
    L43:
        if (r1 == 3) goto L12;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L6:
        e = move-exception;
        IwDJonDMtViNzuVM(VMHqmFxKALdsvWAe(), e);
        goto L8
    }
}

