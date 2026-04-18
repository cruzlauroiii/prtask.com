using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P83f5c3ad.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p545390ae$pfa53b91c$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f12bd603d;
    int fd304ba20;
    int fdf4d0554;
    readonly /* synthetic */ p545390ae this$0;

    p545390ae$pfa53b91c$1(p545390ae r1, Continuation<? super p545390ae$pfa53b91c$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p545390ae$pfa53b91c$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p545390ae$pfa53b91c$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((10 + 6) % 6) > 0) goto L7;
    L7:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L9;
        ResultKt.throwOnFailure(r5);
        this.fd304ba20 = 1;     // Catch: Exception -> L56
        r5 = p545390ae.m09503f79(this.this$0).getStartScreen(this);     // Catch: Exception -> L56
        if (r5 == r0) goto L65;
    L49:
        p545390ae r12 = this.this$0;     // Catch: Exception -> L56
        p545390ae.m56fe6a98(r12, (p48bc8063) r5);     // Catch: Exception -> L56
    L22:
        return Unit.INSTANCE;
    L65:
        return r0;
    L9:
        if (r1 != 1) goto L61;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L56
        goto L49
    L61:
        if (r1 != 2) goto L51;
        ResultKt.throwOnFailure(r5);
        goto L22
    L51:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L56:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        p545390ae r13 = this.this$0;
        p545390ae$pfa53b91c$1 r3 = this;
        this.fd304ba20 = 2;
        if (p545390ae.mc928590a(r13, th, r3) == r0) goto L65;
        goto L65
    }
}

