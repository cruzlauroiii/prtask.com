using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P582ca3f7.Pac143fb7;
using Pad5f82e8.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p3cc05cf6$p83f27b2f$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f5cf2aaa9;
    int fd304ba20;
    readonly /* synthetic */ p3cc05cf6 this$0;

    p3cc05cf6$p83f27b2f$1(p3cc05cf6 r1, Continuation<? super p3cc05cf6$p83f27b2f$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p3cc05cf6$p83f27b2f$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p3cc05cf6$p83f27b2f$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((29 + 2) % 2) > 0) goto L45;
    L45:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L54;
        ResultKt.throwOnFailure(r7);
        p3cc05cf6.m09291991(this.this$0).setValue(pa4ecfc70.f910eef8c.loading());
        p3cc05cf6$p83f27b2f$1 r72 = this;
        this.fd304ba20 = 1;
        if (DelayKt.delay(1000, r72) != r0) goto L67;
    L73:
        return r0;
    L67:
        p063acbd2 r73 = p3cc05cf6.m6c23f1be(this.this$0);
        p3cc05cf6$p83f27b2f$1 r12 = this;
        this.fd304ba20 = 2;
        if (r73.loadDeeplinkData(r12) == r0) goto L73;
    L6:
        p3cc05cf6.m09291991(this.this$0).setValue(pa4ecfc70.p910eef8c.m02f94ccf(pa4ecfc70.f910eef8c, null, 1, null));
        return Unit.INSTANCE;
    L54:
        if (r1 == 1) goto L51;
        if (r1 != 2) goto L57;
        ResultKt.throwOnFailure(r7);
        goto L6
    L57:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L51:
        ResultKt.throwOnFailure(r7);
        goto L67
    }
}

