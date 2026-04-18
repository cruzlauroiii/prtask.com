using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a.P2069ca79;
using P83f5c3ad.P684019bc;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pcef97c41$p8db5788c$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pd0910e67 $paymentTerminal;
    int f31ca0d57;
    int fd304ba20;
    readonly /* synthetic */ pcef97c41 this$0;

    pcef97c41$p8db5788c$1(pcef97c41 r1, pd0910e67 r2, Continuation<? super pcef97c41$p8db5788c$1> r3) {
        this.this$0 = r1;
        this.$paymentTerminal = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pcef97c41$p8db5788c$1(this.this$0, this.$paymentTerminal, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pcef97c41$p8db5788c$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((8 + 30) % 30) > 0) goto L17;
    L17:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L49;
        ResultKt.throwOnFailure(r7);
        p4bcfaa43 r72 = pcef97c41.m63317c84(this.this$0);     // Catch: Exception -> L24
        pd0910e67 r12 = this.$paymentTerminal;     // Catch: Exception -> L24
        string r4 = Guid.randomGuid().tostring();     // Catch: Exception -> L24
        Intrinsics.checkNotNullExpressionValue(r4, "tostring(...)");     // Catch: Exception -> L24
        this.fd304ba20 = 1;     // Catch: Exception -> L24
        r7 = r72.initBalanceInquiry(r12, r4, this);     // Catch: Exception -> L24
        if (r7 == r0) goto L34;
    L60:
        pcef97c41 r13 = this.this$0;     // Catch: Exception -> L24
        pcef97c41.m508a66b4(r13, (pdabbee7a) r7);     // Catch: Exception -> L24
    L15:
        return Unit.INSTANCE;
    L34:
        return r0;
    L49:
        if (r1 != 1) goto L12;
        ResultKt.throwOnFailure(r7);     // Catch: Exception -> L24
        goto L60
    L12:
        if (r1 != 2) goto L29;
        ResultKt.throwOnFailure(r7);
        goto L15
    L29:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L24:
        th = move-exception;
        MutableSharedFlow r14 = pcef97c41.mad452160(this.this$0);
        pcef97c41$p8db5788c$1 r3 = this;
        this.fd304ba20 = 2;
        if (r14.emit(th, r3) == r0) goto L34;
        goto L34
    }
}

