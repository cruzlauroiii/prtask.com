using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.P593616de;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P83f5c3ad.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pcef97c41$p942def94$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ bool $showLoading;
    int f09eb1161;
    int f3dc9c001;
    int fd304ba20;
    int fd7a65242;
    readonly /* synthetic */ pcef97c41 this$0;

    pcef97c41$p942def94$1(bool r1, pcef97c41 r2, Continuation<? super pcef97c41$p942def94$1> r3) {
        this.$showLoading = r1;
        this.this$0 = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pcef97c41$p942def94$1(this.$showLoading, this.this$0, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pcef97c41$p942def94$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((26 + 19) % 19) > 0) goto L7;
    L7:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L62;
        ResultKt.throwOnFailure(r7);
        if (this.$showLoading == false) goto L50;
        this.fd304ba20 = 1;     // Catch: Exception -> L66
        if (pcef97c41.m724546ab(this.this$0).emit(p0890727b.fa82b419a, this) != r0) goto L50;
    L76:
        return r0;
    L50:
        this.fd304ba20 = 2;     // Catch: Exception -> L66
        r7 = pcef97c41.ma843dda3(this.this$0).getPaymentTerminal(this);     // Catch: Exception -> L66
        if (r7 == r0) goto L76;
    L53:
        pd0910e67 r72 = (pd0910e67) r7;     // Catch: Exception -> L66
        pcef97c41.ma461eda3(this.this$0, r72);     // Catch: Exception -> L66
        if (r72.getTerminalStatus() != p83d39779.f18ff74f4) goto L57;
        pcef97c41.m75f6cb3d(this.this$0, r72);     // Catch: Exception -> L66
    L33:
        return Unit.INSTANCE;
    L57:
        throw new IllegalArgumentException("terminal status is LOCKED");     // Catch: Exception -> L66
    L62:
        if (r1 != 1) goto L73;
        ResultKt.throwOnFailure(r7);     // Catch: Exception -> L66
        goto L50
    L73:
        if (r1 != 2) goto L15;
        ResultKt.throwOnFailure(r7);     // Catch: Exception -> L66
        goto L53
    L15:
        if (r1 != 3) goto L36;
        ResultKt.throwOnFailure(r7);
        goto L33
    L36:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L66:
        th = move-exception;
        MutableSharedFlow r12 = pcef97c41.mad452160(this.this$0);
        pcef97c41$p942def94$1 r3 = this;
        this.fd304ba20 = 3;
        if (r12.emit(th, r3) == r0) goto L76;
        goto L76
    }
}

