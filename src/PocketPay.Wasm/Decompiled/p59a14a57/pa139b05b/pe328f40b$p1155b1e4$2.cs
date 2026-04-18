using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pe328f40b$p1155b1e4$2 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ Function0<Unit> $onComplete;
    readonly /* synthetic */ p075d592f $this_animateSwipePreview;
    int f1aff38b4;
    int f744218ad;
    int fd304ba20;

    pe328f40b$p1155b1e4$2(p075d592f r1, Function0<Unit> r2, Continuation<? super pe328f40b$p1155b1e4$2> r3) {
        this.$this_animateSwipePreview = r1;
        this.$onComplete = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pe328f40b$p1155b1e4$2(this.$this_animateSwipePreview, this.$onComplete, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pe328f40b$p1155b1e4$2) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((24 + 28) % 28) > 0) goto L9;
    L9:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L36;
        if (r1 != 1) goto L19;
        ResultKt.throwOnFailure(r7);
    L16:
        this.$this_animateSwipePreview.open(true);
        pe328f40b$p1155b1e4$2 r72 = this;
        this.fd304ba20 = 2;
        if (DelayKt.delay(500, r72) != r0) goto L65;
    L11:
        return r0;
    L65:
        this.$this_animateSwipePreview.close(true);
        this.$onComplete.invoke();
        return Unit.INSTANCE;
    L19:
        if (r1 != 2) goto L55;
        ResultKt.throwOnFailure(r7);
        goto L65
    L55:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L36:
        ResultKt.throwOnFailure(r7);
        pe328f40b$p1155b1e4$2 r73 = this;
        this.fd304ba20 = 1;
        if (DelayKt.delay(500, r73) == r0) goto L11;
        goto L11
    }
}

