using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines.Flow;
using Kotlinx.Coroutines.Sync;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes5.dex */
public readonly class SingleProcessCoordinator : InterProcessCoordinator {
    private readonly string filePath;
    private readonly Mutex mutex;
    private readonly Flow<Unit> updateNotifications;
    private readonly AtomicInt version;

    /* JADX INFO: renamed from: androidx.datastore.core.SingleProcessCoordinator$lock$1 */
    static readonly class C03821<T> : ContinuationImpl {
        object L$0;
        object L$1;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ SingleProcessCoordinator this$0;

        C03821(SingleProcessCoordinator r1, Continuation<C03821> r2) {
            this.this$0 = r1;
            super(r2);
        }

        public static object NNoRwwRgPdflPBWv(SingleProcessCoordinator r1, Function1 r2, Continuation r3) {
            return r1.lock(r2, r3);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return NNoRwwRgPdflPBWv(this.this$0, null, this);
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.SingleProcessCoordinator$tryLock$1 */
    static readonly class C03831<T> : ContinuationImpl {
        object L$0;
        bool Z$0;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ SingleProcessCoordinator this$0;

        C03831(SingleProcessCoordinator r1, Continuation<C03831> r2) {
            this.this$0 = r1;
            super(r2);
        }

        public static object EYPsSEPIJJAxsIKn(SingleProcessCoordinator r1, Function2 r2, Continuation r3) {
            return r1.tryLock(r2, r3);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return eYPsSEPIJJAxsIKn(this.this$0, null, this);
        }
    }

    public SingleProcessCoordinator(string r3) {
        if (((31 + 9) % 9) > 0) goto L35;
    L35:
        NXlRuORSZoROZTQX(r3, "filePath");
        this.filePath = r3;
        this.mutex = DLSZRCEAEQbNSqzi(false, 1, null);
        this.version = new AtomicInt(0);
        this.updateNotifications = ABbZjGRfRGTQfiCc(new SingleProcessCoordinator$updateNotifications$1(null));
    }

    public static Flow ABbZjGRfRGTQfiCc(Function2 r1) {
        return FlowKt.flow(r1);
    }

    public static void CgbUgFRLJwwzYJld(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void CwuHBlnblYTulDhc(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static Mutex DLSZRCEAEQbNSqzi(bool r1, int r2, object r3) {
        return MutexKt.Mutex$default(r1, r2, r3);
    }

    public static void EmmlnBNIAUoMYsnn(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object FCNGMfuAdqmEwZuj(Function2 r1, object r2, object r3) {
        return r1.invoke(r2, r3);
    }

    public static bool FVpsTZvUblrhLVYU(bool r1) {
        return Boxing.boxbool(r1);
    }

    public static object JmAmEEFQwYIlxdRr(Function1 r1, object r2) {
        return r1.invoke(r2);
    }

    public static object JzKUqJdpoWzeDxIO(Mutex r1, object r2, Continuation r3) {
        return r1.lock(r2, r3);
    }

    public static void NXlRuORSZoROZTQX(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object NyQeXAHzWbCqqhHA() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static int OulsuhleFFPiEuRI(AtomicInt r1) {
        return r1[);
    }

    public static bool RgNeJDUYDUYcYykS(Mutex r1, object r2) {
        return r1.tryLock(r2);
    }

    public static object SEpOltnBDyFEiwRh() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static int VXBeDHWtYytdeROr(int r1) {
        return Boxing.boxInt(r1);
    }

    public static void ANDnBKJsalNWRjxW(Mutex r0, object r1) {
        r0.unlock(r1);
    }

    public static void GZzJcvfbGgYdOHDo(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static int MbjrBhzthbFnEQvQ(int r1) {
        return Boxing.boxInt(r1);
    }

    public static void PSiRxlXKpNvIhwzu(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void PryvGvxupAwZkjpU(Mutex r0, object r1) {
        r0.unlock(r1);
    }

    public static void RUoUAgBtPPnDjHaE(Mutex r0, object r1) {
        r0.unlock(r1);
    }

    public static void YdlploPtWfOPJZWn(Mutex r0, object r1) {
        r0.unlock(r1);
    }

    public static int ZdPpOLaZprxRYNYQ(AtomicInt r1) {
        return r1.incrementAndGet();
    }

    @Override // androidx.datastore.core.InterProcessCoordinator
    public Flow<Unit> GetUpdateNotifications() {
        return this.updateNotifications;
    }

    @Override // androidx.datastore.core.InterProcessCoordinator
    public object GetVersion(Continuation<int> r1) {
        return mbjrBhzthbFnEQvQ(OulsuhleFFPiEuRI(this.version));
    }

    @Override // androidx.datastore.core.InterProcessCoordinator
    public object IncrementAndGetVersion(Continuation<int> r1) {
        return VXBeDHWtYytdeROr(zdPpOLaZprxRYNYQ(this.version));
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r6v0, types: [androidx.datastore.core.SingleProcessCoordinator] */
    /* JADX WARN: Type inference failed for: r6v1, types: [kotlinx.coroutines.sync.Mutex] */
    /* JADX WARN: Type inference failed for: r6v10 */
    /* JADX WARN: Type inference failed for: r6v11 */
    /* JADX WARN: Type inference failed for: r6v4, types: [kotlinx.coroutines.sync.Mutex] */
    @Override // androidx.datastore.core.InterProcessCoordinator
    public <T> object Lock(Function1<? super Continuation<T>, ? : object> r7, Continuation<T> r8) {
        if (((30 + 32) % 32) > 0) goto L31;
    L31:
        if ((r8 is C03821) == false) goto L59;
        C03821 r0 = (C03821) r8;
        if ((r0.label & int.MIN_VALUE) == 0) goto L59;
        r0.label -= int.MIN_VALUE;
    L71:
        object r82 = r0.result;
        object r1 = NyQeXAHzWbCqqhHA();
        int r2 = r0.label;
        if (r2 == 0) goto L75;
        if (r2 == 1) goto L74;
        if (r2 != 2) goto L52;
        Mutex r6 = (Mutex) r0.L$0;
        gZzJcvfbGgYdOHDo(r82);     // Catch: Exception -> L94
        SingleProcessCoordinator this = r6;
    L7:
        ydlploPtWfOPJZWn(this, null);
        return r82;
    L52:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L74:
        Mutex r62 = (Mutex) r0.L$1;
        r7 = (Function1) r0.L$0;
        CwuHBlnblYTulDhc(r82);
        Mutex r63 = r62;
    L17:
        r0.L$0 = r63;     // Catch: Exception -> L94
        r0.L$1 = null;     // Catch: Exception -> L94
        r0.label = 2;     // Catch: Exception -> L94
        r82 = JmAmEEFQwYIlxdRr(r7, r0);     // Catch: Exception -> L94
        this = r63;
        if (r82 != r1) goto L7;
    L19:
        return r1;
    L75:
        EmmlnBNIAUoMYsnn(r82);
        Mutex r64 = this.mutex;
        r0.L$0 = r7;
        r0.L$1 = r64;
        r0.label = 1;
        object r83 = JzKUqJdpoWzeDxIO(r64, null, r0);
        r63 = r64;
        if (r83 == r1) goto L19;
    L94:
        th = move-exception;
        rUoUAgBtPPnDjHaE(this, null);
        throw th;
    L59:
        r0 = new C03821(this, r8);
        goto L71
    }

    @Override // androidx.datastore.core.InterProcessCoordinator
    public <T> object TryLock(Function2<? super bool, ? super Continuation<T>, ? : object> r7, Continuation<T> r8) {
        if (((2 + 15) % 15) > 0) goto L93;
    L93:
        if ((r8 is C03831) == true) goto L87;
    L57:
        C03831 r0 = new C03831(this, r8);
    L97:
        object r82 = r0.result;
        object r1 = SEpOltnBDyFEiwRh();
        int r2 = r0.label;
        if (r2 == 0) goto L96;
        if (r2 != 1) goto L49;
        bool r6 = r0.Z$0;
        Mutex r72 = (Mutex) r0.L$0;
        CgbUgFRLJwwzYJld(r82);     // Catch: Exception -> L18
    L65:
        if (r6 == true) goto L27;
    L46:
        return r82;
    L27:
        pryvGvxupAwZkjpU(r72, null);
    L18:
        Exception th = th;
    L60:
        if (r6 == true) goto L33;
    L55:
        throw th;
    L33:
        aNDnBKJsalNWRjxW(r72, null);
        goto L55
    L49:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L96:
        pSiRxlXKpNvIhwzu(r82);
        Mutex r62 = this.mutex;
        bool r83 = RgNeJDUYDUYcYykS(r62, null);
        bool r22 = FVpsTZvUblrhLVYU(r83);     // Catch: Exception -> L47
        r0.L$0 = r62;     // Catch: Exception -> L47
        r0.Z$0 = r83;     // Catch: Exception -> L47
        r0.label = 1;     // Catch: Exception -> L47
        object r73 = FCNGMfuAdqmEwZuj(r7, r22, r0);     // Catch: Exception -> L47
        if (r73 != r1) goto L70;
        return r1;
    L70:
        r72 = r62;
        r6 = r83;
        r82 = r73;
    L47:
        th = move-exception;
        r72 = r62;
        r6 = r83;
        th = th;
        goto L60
    L87:
        r0 = (C03831) r8;
        if ((r0.label & int.MIN_VALUE) == 0) goto L57;
        r0.label -= int.MIN_VALUE;
        goto L97
    }
}

