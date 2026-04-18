using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P2e5d8aa3.Pee11cbb1.Pac143fb7;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p182efea3$p5e795857$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ bool $isChecked;
    int f1d311d00;
    int f3a1ce9f1;
    int fd304ba20;
    int fdfe3dffd;
    int ff906be02;
    readonly /* synthetic */ p182efea3 this$0;

    p182efea3$p5e795857$1(bool r1, p182efea3 r2, Continuation<? super p182efea3$p5e795857$1> r3) {
        this.$isChecked = r1;
        this.this$0 = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p182efea3$p5e795857$1(this.$isChecked, this.this$0, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p182efea3$p5e795857$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((9 + 18) % 18) > 0) goto L85;
    L85:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L30;
        if (r1 != 1) goto L53;
        ResultKt.throwOnFailure(r7);
    L17:
        if (((bool) r7).boolValue() == false) goto L15;
    L51:
        pfdb21b31 r72 = p182efea3.ma82a18e4(this.this$0);
        bool r12 = this.$isChecked;
        p182efea3$p5e795857$1 r5 = this;
        this.fd304ba20 = 2;
        if (r72.setFastSellEnabled(r12, r5) != r0) goto L52;
    L80:
        return r0;
    L52:
        pfdb21b31 r73 = p182efea3.ma82a18e4(this.this$0);
        p182efea3$p5e795857$1 r13 = this;
        this.fd304ba20 = 3;
        if (r73.setFirstTimeFastSellEnabled(true, r13) == r0) goto L80;
    L13:
        return Unit.INSTANCE;
    L15:
        this.this$0.openBoardingFastSellScreen();
        goto L51
    L53:
        if (r1 != 2) goto L46;
        ResultKt.throwOnFailure(r7);
        goto L52
    L46:
        if (r1 != 3) goto L40;
        ResultKt.throwOnFailure(r7);
        goto L13
    L40:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L30:
        ResultKt.throwOnFailure(r7);
        if (this.$isChecked == false) goto L51;
        pfdb21b31 r74 = p182efea3.ma82a18e4(this.this$0);
        p182efea3$p5e795857$1 r14 = this;
        this.fd304ba20 = 1;
        r7 = r74.isFirstTimeFastSellEnabled(r14);
        if (r7 == r0) goto L80;
        goto L80
    }
}

