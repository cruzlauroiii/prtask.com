using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using Pad5f82e8.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p02565c40$p9a032022$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int I$0;
    int I$1;
    int f575fe3f0;
    int fd304ba20;
    readonly /* synthetic */ p02565c40 this$0;

    p02565c40$p9a032022$1(p02565c40 r1, Continuation<? super p02565c40$p9a032022$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p02565c40$p9a032022$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p02565c40$p9a032022$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:38:0x00b3 -> B:45:0x00d1). Please report as a decompilation issue!!! */
    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((2 + 8) % 8) > 0) goto L4;
    L4:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L103;
        ResultKt.throwOnFailure(r8);
        int r82 = 90;
        int r12 = 0;
    L45:
        if (r12 < r82) goto L9;
        Job r83 = p02565c40.m554746e1(this.this$0);
        if (r83 is null) goto L69;
        Job.DefaultImpls.cancel$default(r83, null, 1, null);
    L69:
        p02565c40.me8d9137f(this.this$0).setValue(pa4ecfc70.f910eef8c.error(new Exception("QR code expired")));
        return Unit.INSTANCE;
    L9:
        MutableSharedFlow r4 = p02565c40.m708f95ff(this.this$0);
        float r5 = Boxing.boxfloat(r12);
        p02565c40$p9a032022$1 r6 = this;
        this.I$0 = r82;
        this.I$1 = r12;
        this.fd304ba20 = 1;
        if (r4.emit(r5, r6) == r0) goto L92;
        int r42 = r82;
    L36:
        p02565c40$p9a032022$1 r84 = this;
        this.I$0 = r42;
        this.I$1 = r12;
        this.fd304ba20 = 2;
        if (DelayKt.delay(1000, r84) == r0) goto L92;
    L72:
        r82 = r42;
        r12 = r12 + 1;
    L92:
        return r0;
    L103:
        if (r1 != 1) goto L79;
        r12 = this.I$1;
        r42 = this.I$0;
        ResultKt.throwOnFailure(r8);
        goto L36
    L79:
        if (r1 != 2) goto L15;
        r12 = this.I$1;
        r42 = this.I$0;
        ResultKt.throwOnFailure(r8);
        goto L72
    L15:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    }
}

