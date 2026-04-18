using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes5.dex */
readonly class DataStoreImpl$writeData$2<T> : SuspendLambda : Function2<WriteScope<T>, Continuation<Unit>, object> {
    readonly /* synthetic */ T $newData;
    readonly /* synthetic */ Ref.IntRef $newVersion;
    readonly /* synthetic */ bool $updateCache;
    private /* synthetic */ object L$0;
    object L$1;
    int label;
    readonly /* synthetic */ DataStoreImpl<T> this$0;

    DataStoreImpl$writeData$2(Ref.IntRef r1, DataStoreImpl<T> r2, T r3, bool r4, Continuation<? super DataStoreImpl$writeData$2> r5) {
        this.$newVersion = r1;
        this.this$0 = r2;
        this.$newData = r3;
        this.$updateCache = r4;
        super(2, r5);
    }

    public static object DkfxMPMmXJVfyvZC(DataStoreImpl$writeData$2 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static void EJnyOesRUcweaiTB(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object FzmpuTrITTiDdNLe() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object JWqgRbewWyIaObwB(DataStoreImpl$writeData$2 r1, WriteScope r2, Continuation r3) {
        return r1.invoke(r2, r3);
    }

    public static void QXIqyXzxAzuVtKPv(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static State QYVXOoPgKZOCWcLv(DataStoreInMemoryCache r1, State r2) {
        return r1.tryUpdate(r2);
    }

    public static int ZOKDCmgKETSwIbzY(Number r1) {
        return r1.intValue();
    }

    public static void ZuIsEjndwdXwwFYo(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object DYbbtkQoqZyLwNUw(InterProcessCoordinator r1, Continuation r2) {
        return r1.incrementAndGetVersion(r2);
    }

    public static int KIFLvUavprsxkSIv(object r1) {
        return r1.GetHashCode();
    }

    public static object KKclgsFUHAeJhPgw(WriteScope r1, object r2, Continuation r3) {
        return r1.writeData(r2, r3);
    }

    public static Continuation TTnkWBPenhfHGHNZ(DataStoreImpl$writeData$2 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static InterProcessCoordinator ThiFuULFWXVBZGAw(DataStoreImpl r1) {
        return DataStoreImpl.access$getCoordinator(r1);
    }

    public static DataStoreInMemoryCache WnJhGFniZzEYsjIc(DataStoreImpl r1) {
        return DataStoreImpl.access$getInMemoryCache$p(r1);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r7, Continuation<object> r8) {
        if (((14 + 22) % 22) > 0) goto L21;
    L21:
        DataStoreImpl$writeData$2 r0 = new DataStoreImpl$writeData$2(this.$newVersion, this.this$0, this.$newData, this.$updateCache, r8);
        r0.L$0 = r7;
        return r0;
    }

    public readonly object Invoke(WriteScope<T> r1, Continuation<Unit> r2) {
        return DkfxMPMmXJVfyvZC((DataStoreImpl$writeData$2) tTnkWBPenhfHGHNZ(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(object r1, Continuation<Unit> r2) {
        return JWqgRbewWyIaObwB(this, (WriteScope) r1, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((10 + 8) % 8) > 0) goto L63;
    L63:
        object r0 = FzmpuTrITTiDdNLe();
        int r1 = this.label;
        if (r1 == 0) goto L60;
        if (r1 == 1) goto L15;
        if (r1 != 2) goto L70;
        QXIqyXzxAzuVtKPv(r8);
    L40:
        if (this.$updateCache == true) goto L101;
    L32:
        return Unit.INSTANCE;
    L101:
        DataStoreInMemoryCache r82 = wnJhGFniZzEYsjIc(this.this$0);
        T r12 = this.$newData;
        if (r12 is null) goto L77;
        int r2 = kIFLvUavprsxkSIv(r12);
    L7:
        QYVXOoPgKZOCWcLv(r82, new Data(r12, r2, this.$newVersion.element));
        goto L32
    L77:
        r2 = 0;
        goto L7
    L70:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L15:
        Ref.IntRef r13 = (Ref.IntRef) this.L$1;
        WriteScope r3 = (WriteScope) this.L$0;
        EJnyOesRUcweaiTB(r8);
    L19:
        r13.element = ZOKDCmgKETSwIbzY((Number) r8);
        T r83 = this.$newData;
        DataStoreImpl$writeData$2<T> r14 = this;
        this.L$0 = null;
        this.L$1 = null;
        this.label = 2;
        if (kKclgsFUHAeJhPgw(r3, r83, r14) != r0) goto L40;
    L84:
        return r0;
    L60:
        ZuIsEjndwdXwwFYo(r8);
        WriteScope r84 = (WriteScope) this.L$0;
        r13 = this.$newVersion;
        InterProcessCoordinator r4 = thiFuULFWXVBZGAw(this.this$0);
        DataStoreImpl$writeData$2<T> r5 = this;
        this.L$0 = r84;
        this.L$1 = r13;
        this.label = 1;
        object r32 = dYbbtkQoqZyLwNUw(r4, r5);
        if (r32 == r0) goto L84;
        r3 = r84;
        r8 = r32;
        goto L19
    }
}

