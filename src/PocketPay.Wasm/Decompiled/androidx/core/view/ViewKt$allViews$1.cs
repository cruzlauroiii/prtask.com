using Android.View;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Sequences;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes6.dex */
readonly class objectKt$allobjects$1 : RestrictedSuspendLambda : Function2<SequenceScope<object>, Continuation<Unit>, object> {
    readonly /* synthetic */ object $this_allobjects;
    private /* synthetic */ object L$0;
    int label;

    objectKt$allobjects$1(object r1, Continuation<? super objectKt$allobjects$1> r2) {
        this.$this_allobjects = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        objectKt$allobjects$1 r0 = new objectKt$allobjects$1(this.$this_allobjects, r3);
        r0.L$0 = r2;
        return r0;
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(SequenceScope<object> r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(SequenceScope<object> r1, Continuation<Unit> r2) {
        return ((objectKt$allobjects$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((5 + 14) % 14) > 0) goto L41;
    L41:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.label;
        if (r1 != 0) goto L37;
        ResultKt.throwOnFailure(r6);
        SequenceScope r12 = (SequenceScope) this.L$0;
        object r62 = this.$this_allobjects;
        objectKt$allobjects$1 r4 = this;
        this.L$0 = r12;
        this.label = 1;
        if (r12.yield(r62, r4) == r0) goto L47;
    L59:
        object r63 = this.$this_allobjects;
        if ((r63 is objectGroup) == true) goto L6;
    L66:
        return Unit.INSTANCE;
    L6:
        Sequence<object> r64 = objectGroupKt.getDescendants((objectGroup) r63);
        objectKt$allobjects$1 r3 = this;
        this.L$0 = null;
        this.label = 2;
        if (r12.yieldAll(r64, r3) != r0) goto L66;
    L47:
        return r0;
    L37:
        if (r1 == 1) goto L72;
        if (r1 != 2) goto L44;
        ResultKt.throwOnFailure(r6);
        goto L66
    L44:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L72:
        r12 = (SequenceScope) this.L$0;
        ResultKt.throwOnFailure(r6);
        goto L59
    }
}

