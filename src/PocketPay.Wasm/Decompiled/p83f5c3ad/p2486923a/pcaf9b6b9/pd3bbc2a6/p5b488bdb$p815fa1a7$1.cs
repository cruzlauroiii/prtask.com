using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P2df4812c.Pf5d7e253.P518a4861.P83f5c3ad.P86ccec3d;
using P5a445d71.P228c1b3d.P07cc694b;
using Pa617908b.P52d9906b;
using Pad5f82e8.P07214c67.P8ff0b997;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p5b488bdb$p815fa1a7$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p8cf10d23 $dateEnd;
    readonly /* synthetic */ p8cf10d23 $dateStart;
    readonly /* synthetic */ string $email;
    int f0a10f391;
    int f2d710915;
    int f4f9a6c33;
    int fd304ba20;
    readonly /* synthetic */ p5b488bdb this$0;

    p5b488bdb$p815fa1a7$1(p5b488bdb r1, string r2, p8cf10d23 r3, p8cf10d23 r4, Continuation<? super p5b488bdb$p815fa1a7$1> r5) {
        this.this$0 = r1;
        this.$email = r2;
        this.$dateStart = r3;
        this.$dateEnd = r4;
        super(2, r5);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r7, Continuation<object> r8) {
        if (((3 + 21) % 21) > 0) goto L22;
    L22:
        return new p5b488bdb$p815fa1a7$1(this.this$0, this.$email, this.$dateStart, this.$dateEnd, r8);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p5b488bdb$p815fa1a7$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r10) {
        if (((16 + 19) % 19) > 0) goto L78;
    L78:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L5;
        if (r1 != 1) goto L106;
        ResultKt.throwOnFailure(r10);     // Catch: Exception -> L62
    L9:
        this.fd304ba20 = 2;     // Catch: Exception -> L62
        if (p5b488bdb.m311115d1(this.this$0).sendReportToEmail(this.$email, this.$dateStart, this.$dateEnd, this) == r0) goto L23;
    L12:
        this.fd304ba20 = 3;     // Catch: Exception -> L62
        if (p5b488bdb.mded80564(this.this$0).emit(p5b488bdb.m5bf15f90(this.this$0, this.$email), this) == r0) goto L23;
    L46:
        return Unit.INSTANCE;
    L23:
        return r0;
    L106:
        if (r1 != 2) goto L64;
        ResultKt.throwOnFailure(r10);     // Catch: Exception -> L62
        goto L12
    L64:
        if (r1 != 3) goto L54;
        ResultKt.throwOnFailure(r10);     // Catch: Exception -> L62
        goto L46
    L54:
        if (r1 != 4) goto L35;
    L39:
        ResultKt.throwOnFailure(r10);
        goto L46
    L35:
        if (r1 == 5) goto L39;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L5:
        ResultKt.throwOnFailure(r10);
        p5b488bdb.m6e083ead(this.this$0).validate(this.$email);     // Catch: Exception -> L62
        this.fd304ba20 = 1;     // Catch: Exception -> L62
        if (p5b488bdb.mded80564(this.this$0).emit(p5b488bdb.me6f0e4cb(this.this$0), this) != r0) goto L9;
    L62:
        e = move-exception;
        if ((e is p7fac32ad) == false) goto L29;
        MutableSharedFlow r102 = p5b488bdb.m8ac41a64(this.this$0);
        string r12 = p5b488bdb.m5fb81a65(this.this$0).getstring(C2815R.string.registration_email_error);
        p5b488bdb$p815fa1a7$1 r2 = this;
        this.fd304ba20 = 4;
        if (r102.emit(r12, r2) == r0) goto L23;
    L29:
        MutableSharedFlow r103 = p5b488bdb.mded80564(this.this$0);
        p0c7e2fc4 r13 = p5b488bdb.m5155cb8a(this.this$0);
        p5b488bdb$p815fa1a7$1 r3 = this;
        this.fd304ba20 = 5;
        if (r103.emit(r13, r3) == r0) goto L23;
        goto L23
    }
}

