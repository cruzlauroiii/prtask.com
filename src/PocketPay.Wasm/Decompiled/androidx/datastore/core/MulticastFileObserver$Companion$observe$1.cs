using Androidx.Datastore.Core;
using Java.Io;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Channels;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes5.dex */
readonly class MulticaststringObserver$Companion$observe$1 : SuspendLambda : Function2<ProducerScope<Unit>, Continuation<Unit>, object> {
    readonly /* synthetic */ string $file;
    private /* synthetic */ object L$0;
    object L$1;
    int label;

    /* JADX INFO: renamed from: androidx.datastore.core.MulticaststringObserver$Companion$observe$1$1 */
    static readonly class C03771 : Lambda : Function0<Unit> {
        readonly /* synthetic */ DisposableHandle $disposeListener;

        C03771(DisposableHandle r1) {
            this.$disposeListener = r1;
            super(0);
        }

        public static void EgnVqtjLqxyXyOXm(C03771 r0) {
            r0.invoke2();
        }

        public static void SnJDogDCnqJTPQSC(DisposableHandle r0) {
            r0.dispose();
        }

        @Override // kotlin.jvm.functions.Function0
        public /* bridge */ /* synthetic */ Unit invoke() {
            EgnVqtjLqxyXyOXm(this);
            return Unit.INSTANCE;
        }

        /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
        public readonly void Invoke2() {
            SnJDogDCnqJTPQSC(this.$disposeListener);
        }
    }

    MulticaststringObserver$Companion$observe$1(string r1, Continuation<? super MulticaststringObserver$Companion$observe$1> r2) {
        this.$file = r1;
        super(2, r2);
    }

    public static object CAzFtdGuFvNswCHx(MulticaststringObserver$Companion$observe$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static object EAxrNxljTKiGAjrv(ProducerScope r1, Function0 r2, Continuation r3) {
        return ProduceKt.awaitClose(r1, r2, r3);
    }

    public static string INADTLfkwkVRXNCU(string r1) {
        return r1.getParentstring();
    }

    public static void LUKVmyMrQmbjlbTP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static Continuation VSkcJbCKuUGLdAqV(MulticaststringObserver$Companion$observe$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static object VWkcnuGtxFHtXbvA(ProducerScope r1, object r2, Continuation r3) {
        return r1.send(r2, r3);
    }

    public static object XDqVDwvXfbwmFlEc() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object DePfJEfiCpMtMeeh(MulticaststringObserver$Companion$observe$1 r1, ProducerScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static void FHolvXcaUQDNyKMx(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void KcHRcLKeETZvIQtz(object r0) {
        Intrinsics.checkNotNull(r0);
    }

    public static void TBzneiAYGuQBgytq(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static DisposableHandle WYSqPAUEYVqiFLNe(MulticaststringObserver.Companion r1, string r2, Function1 r3) {
        return MulticaststringObserver.Companion.access$observe(r1, r2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        MulticaststringObserver$Companion$observe$1 r0 = new MulticaststringObserver$Companion$observe$1(this.$file, r3);
        r0.L$0 = r2;
        return r0;
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(ProducerScope<Unit> r1, Continuation<Unit> r2) {
        return dePfJEfiCpMtMeeh(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(ProducerScope<Unit> r1, Continuation<Unit> r2) {
        return CAzFtdGuFvNswCHx((MulticaststringObserver$Companion$observe$1) VSkcJbCKuUGLdAqV(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((1 + 16) % 16) > 0) goto L26;
    L26:
        object r0 = XDqVDwvXfbwmFlEc();
        int r1 = this.label;
        if (r1 == 0) goto L48;
        if (r1 == 1) goto L27;
        if (r1 != 2) goto L77;
        fHolvXcaUQDNyKMx(r7);
    L50:
        return Unit.INSTANCE;
    L77:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L27:
        DisposableHandle r12 = (DisposableHandle) this.L$1;
        ProducerScope r3 = (ProducerScope) this.L$0;
        LUKVmyMrQmbjlbTP(r7);
    L12:
        C03771 r72 = new C03771(r12);
        MulticaststringObserver$Companion$observe$1 r13 = this;
        this.L$0 = null;
        this.L$1 = null;
        this.label = 2;
        if (EAxrNxljTKiGAjrv(r3, r72, r13) != r0) goto L50;
    L13:
        return r0;
    L48:
        tBzneiAYGuQBgytq(r7);
        ProducerScope r73 = (ProducerScope) this.L$0;
        MulticaststringObserver$Companion$observe$1$flowObserver$1 r14 = new MulticaststringObserver$Companion$observe$1$flowObserver$1(this.$file, r73);
        MulticaststringObserver.Companion r4 = MulticaststringObserver.Companion;
        string r5 = INADTLfkwkVRXNCU(this.$file);
        kcHRcLKeETZvIQtz(r5);
        r12 = wYSqPAUEYVqiFLNe(r4, r5, r14);
        Unit r42 = Unit.INSTANCE;
        MulticaststringObserver$Companion$observe$1 r52 = this;
        this.L$0 = r73;
        this.L$1 = r12;
        this.label = 1;
        if (VWkcnuGtxFHtXbvA(r73, r42, r52) == r0) goto L13;
        r3 = r73;
        goto L12
    }
}

