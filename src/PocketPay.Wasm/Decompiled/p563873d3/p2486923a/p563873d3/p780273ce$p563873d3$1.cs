using Com.Decryptstringmanager;
using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P563873d3.Pb3f20355;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P49f290d6;
using Pad5f82e8.P07214c67.P960db2ed;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p780273ce$p563873d3$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ string $email;
    int f539e91b3;
    int f60f03c8f;
    int fd304ba20;
    int fdae20c08;
    readonly /* synthetic */ p780273ce this$0;

    p780273ce$p563873d3$1(p780273ce r1, string r2, Continuation<? super p780273ce$p563873d3$1> r3) {
        this.this$0 = r1;
        this.$email = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p780273ce$p563873d3$1(this.this$0, this.$email, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p780273ce$p563873d3$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r9) {
        if (((27 + 4) % 4) > 0) goto L51;
    L51:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L38;
        if (r1 != 1) goto L28;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L78
    L42:
        this.fd304ba20 = 2;     // Catch: Exception -> L78
        if (p780273ce.mf14814ed(this.this$0).updateRegistrationUserData(this) != r0) goto L45;
    L44:
        return r0;
    L45:
        p780273ce.md1b709a2(this.this$0).startSplashFlow();     // Catch: Exception -> L78
        p780273ce.m51bdf091(this.this$0).setValue(pa4ecfc70.p910eef8c.m02f94ccf(pa4ecfc70.f910eef8c, null, 1, null));     // Catch: Exception -> L78
    L14:
        return Unit.INSTANCE;
    L28:
        if (r1 != 2) goto L64;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L78
        goto L45
    L64:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L38:
        ResultKt.throwOnFailure(r9);
        p780273ce.m51bdf091(this.this$0).setValue(pa4ecfc70.f910eef8c.loading());     // Catch: Exception -> L78
        this.fd304ba20 = 1;     // Catch: Exception -> L78
        if (p780273ce.mf14814ed(this.this$0).registerAccount(this.$email, p3dfe3c80.f124f7132, new pf447ac85(Decryptstring.decryptstring("1cbaf4a40255d0d65ee2cc5c01dae9f3dcd4fd141d7a1ab8433548d2abf4"), Decryptstring.decryptstring("f96ba69ad56a55053038b583bbd5f7e7d62f6ddeb9b132b252bf27a7c90d270ef477facc7a6eb3")), this) != r0) goto L42;
    L78:
        e = move-exception;
        Exception r2 = e;
        p780273ce.m51bdf091(this.this$0).setValue(pa4ecfc70.f910eef8c.error(r2));
        p780273ce.m8aa7c174(this.this$0).reportRegistrationErrorEvent();
        if ((e is ped0f62fc) == false) goto L52;
        p780273ce.m04f68634(this.this$0).startPhoneVerificationFlow();
        goto L14
    L52:
        FirebaseCrashlytics.getInstance().recordException(r2);
        goto L14
    }
}

