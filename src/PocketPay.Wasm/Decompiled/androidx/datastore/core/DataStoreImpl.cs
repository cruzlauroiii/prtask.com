using Androidx.Constraintlayout.Core.Motion.Utils;
using Androidx.Datastore.Core;
using Androidx.Datastore.Core.Handlers;
using Com.Google.Android.Gms.Measurement.Api;
using Com.Google.Android.Material.Card;
using Com.Google.Firebase.Messaging;
using Java.Util;
using Java.Util.Concurrent;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using Kotlinx.Coroutines.Sync;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes5.dex */
public readonly class DataStoreImpl<T> : DataStore<T> {
    private static readonly string BUG_MESSAGE = "This is a bug in DataStore. Please file a bug at: https://issuetracker.google.com/issues/new?component=907884&template=1466542";
    public static readonly Companion Companion = null;
    private int collectorCounter;
    private Job collectorJob;
    private readonly Mutex collectorMutex;
    private readonly Lazy coordinator$delegate;
    private readonly CorruptionHandler<T> corruptionHandler;

    /* JADX INFO: renamed from: data, reason: collision with root package name */
    private readonly Flow<T> f3874data;
    private readonly DataStoreInMemoryCache<T> inMemoryCache;
    private readonly DataStoreImpl<T>.InitDataStore readAndInit;
    private readonly CoroutineScope scope;
    private readonly Storage<T> storage;
    private readonly Lazy<StorageConnection<T>> storageConnectionDelegate;
    private readonly SimpleActor<Message.Update<T>> writeActor;

    public static readonly class Companion {
        private Companion() {
        }

        public /* synthetic */ Companion(DefaultConstructorMarker r1) {
            this();
        }
    }

    private readonly class InitDataStore : RunOnce {
        private List<? : Function2<? super InitializerApi<T>, ? super Continuation<Unit>, ? : object>> initTasks;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        public InitDataStore(DataStoreImpl r2, List<? : Function2<? super InitializerApi<T>, ? super Continuation<Unit>, ? : object>> r3) {
            YMepovvMjymZbPTE(r3, "initTasksList");
            this.this$0 = r2;
            this.initTasks = SmWwDxmCVTmyksLu(r3);
        }

        public static void EOvzXtEaBItPAGPV(object r0) {
            Intrinsics.checkNotNull(r0);
        }

        public static void EolTrTqjAkTKIUqM(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static bool OJiAvOdBTOAOupIY(List r1) {
            return r1.Count == 0;
        }

        public static List SmWwDxmCVTmyksLu(IEnumerable r1) {
            return ICollectionsKt.toList(r1);
        }

        public static void YMepovvMjymZbPTE(object r0, string r1) {
            Intrinsics.checkNotNullParameter(r0, r1);
        }

        public static object ZFzRDictionaryLmZcffPKO(InterProcessCoordinator r1, Function1 r2, Continuation r3) {
            return r1.lock(r2, r3);
        }

        public static readonly /* synthetic */ List access$getInitTasks$p(InitDataStore r0) {
            return r0.initTasks;
        }

        public static readonly /* synthetic */ void access$setInitTasks$p(InitDataStore r0, List r1) {
            r0.initTasks = r1;
        }

        public static void ApMmmoryDzqJmjVR(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static DataStoreInMemoryCache GGDhrRGevAEiwDLe(DataStoreImpl r1) {
            return DataStoreImpl.access$getInMemoryCache$p(r1);
        }

        public static State HDeeXCQVBaLiSxMk(DataStoreInMemoryCache r1, State r2) {
            return r1.tryUpdate(r2);
        }

        public static void IMPJDYCwticKOCDJ(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object OPlsnUsAuagMyGua() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        public static InterProcessCoordinator TUygVaDbChHEuIpJ(DataStoreImpl r1) {
            return DataStoreImpl.access$getCoordinator(r1);
        }

        public static object UHZlEErohqRLIbpY(DataStoreImpl r1, bool r2, Continuation r3) {
            return DataStoreImpl.access$readDataOrHandleCorruption(r1, r2, r3);
        }

        @Override // androidx.datastore.core.RunOnce
        protected object DoRun(Continuation<Unit> r7) {
            if (((16 + 14) % 14) > 0) goto L13;
        L13:
            if ((r7 is DataStoreImpl$InitDataStore$doRun$1) == false) goto L53;
            DataStoreImpl$InitDataStore$doRun$1 r0 = (DataStoreImpl$InitDataStore$doRun$1) r7;
            if ((r0.label & int.MIN_VALUE) == 0) goto L53;
            r0.label -= int.MIN_VALUE;
        L111:
            object r72 = r0.result;
            object r1 = oPlsnUsAuagMyGua();
            int r2 = r0.label;
            if (r2 != 0) goto L101;
            iMPJDYCwticKOCDJ(r72);
            List<? : Function2<? super InitializerApi<T>, ? super Continuation<Unit>, ? : object>> r73 = this.initTasks;
            if (r73 is null) goto L57;
            EOvzXtEaBItPAGPV(r73);
            if (OJiAvOdBTOAOupIY(r73) == true) goto L57;
            InterProcessCoordinator r74 = tUygVaDbChHEuIpJ(this.this$0);
            DataStoreImpl$InitDataStore$doRun$initData$1 r22 = new DataStoreImpl$InitDataStore$doRun$initData$1(this.this$0, this, null);
            r0.L$0 = this;
            r0.label = 2;
            r72 = ZFzRDictionaryLmZcffPKO(r74, r22, r0);
            if (r72 == r1) goto L50;
        L60:
            Data r75 = (Data) r72;
        L56:
            hDeeXCQVBaLiSxMk(gGDhrRGevAEiwDLe(this.this$0), r75);
            return Unit.INSTANCE;
        L50:
            return r1;
        L57:
            DataStoreImpl<T> r76 = this.this$0;
            r0.L$0 = this;
            r0.label = 1;
            r72 = uHZlEErohqRLIbpY(r76, false, r0);
            if (r72 == r1) goto L50;
        L3:
            r75 = (Data) r72;
            goto L56
        L101:
            if (r2 == 1) goto L85;
            if (r2 != 2) goto L21;
            InitDataStore this = (InitDataStore) r0.L$0;
            EolTrTqjAkTKIUqM(r72);
            goto L60
        L21:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        L85:
            this = (InitDataStore) r0.L$0;
            apMmmoryDzqJmjVR(r72);
        L53:
            r0 = new DataStoreImpl$InitDataStore$doRun$1(this, r7);
            goto L111
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$decrementCollector$1 */
    static readonly class C03491 : ContinuationImpl {
        object L$0;
        object L$1;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03491(DataStoreImpl<T> r1, Continuation<C03491> r2) {
            this.this$0 = r1;
            super(r2);
        }

        public static object HfRHLnCljklcTFQY(DataStoreImpl r1, Continuation r2) {
            return DataStoreImpl.access$decrementCollector(r1, r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return hfRHLnCljklcTFQY(this.this$0, this);
        }
    }

    /* JADX INFO: Add missing generic type declarations: [R] */
    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$doWithWritestringLock$3 */
    static readonly class C03503<R> : SuspendLambda : Function1<Continuation<R>, object> {
        readonly /* synthetic */ Function1<Continuation<R>, object> $block;
        int label;

        /* JADX WARN: Multi-variable type inference failed */
        C03503(Function1<? super Continuation<R>, ? : object> r1, Continuation<C03503> r2) {
            this.$block = r1;
            super(1, r2);
        }

        public static object EdRxSJCyvkmFusrQ(Function1 r1, object r2) {
            return r1.invoke(r2);
        }

        public static object QarNzDMPtuzEXRgi() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        public static object RGMLoXEsWxKRYYxx(C03503 r1, Continuation r2) {
            return r1.invoke(r2);
        }

        public static void EODkklCuWXeGaDYf(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static Continuation FBHhnFxFVDVLHLEr(C03503 r1, Continuation r2) {
            return r1.create(r2);
        }

        public static void GVtVLQocPxpyBrgI(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object ZfFrTspigNdPUHYz(C03503 r1, object r2) {
            return r1.invokeSuspend(r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(Continuation<object> r2) {
            return new C03503(this.$block, r2);
        }

        @Override // kotlin.jvm.functions.Function1
        public /* bridge */ /* synthetic */ object invoke(object r1) {
            return RGMLoXEsWxKRYYxx(this, (Continuation) r1);
        }

        public readonly object Invoke(Continuation<R> r1) {
            return zfFrTspigNdPUHYz((C03503) fBHhnFxFVDVLHLEr(this, r1), Unit.INSTANCE);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r4) {
            if (((25 + 27) % 27) > 0) goto L33;
        L33:
            object r0 = QarNzDMPtuzEXRgi();
            int r1 = this.label;
            if (r1 == 0) goto L7;
            if (r1 != 1) goto L42;
            eODkklCuWXeGaDYf(r4);
            return r4;
        L42:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        L7:
            gVtVLQocPxpyBrgI(r4);
            Function1<Continuation<R>, object> r42 = this.$block;
            this.label = 1;
            object r3 = EdRxSJCyvkmFusrQ(r42, this);
            if (r3 == r0) goto L4;
            return r3;
        L4:
            return r0;
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$handleUpdate$1 */
    static readonly class C03511 : ContinuationImpl {
        object L$0;
        object L$1;
        object L$2;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03511(DataStoreImpl<T> r1, Continuation<C03511> r2) {
            this.this$0 = r1;
            super(r2);
        }

        public static object UjPulMYtknZVnwDS(DataStoreImpl r1, Message.Update r2, Continuation r3) {
            return DataStoreImpl.access$handleUpdate(r1, r2, r3);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return ujPulMYtknZVnwDS(this.this$0, null, this);
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$incrementCollector$1 */
    static readonly class C03521 : ContinuationImpl {
        object L$0;
        object L$1;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03521(DataStoreImpl<T> r1, Continuation<C03521> r2) {
            this.this$0 = r1;
            super(r2);
        }

        public static object FkcSbQJrNpkzZyOd(DataStoreImpl r1, Continuation r2) {
            return DataStoreImpl.access$incrementCollector(r1, r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return fkcSbQJrNpkzZyOd(this.this$0, this);
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$readAndInitOrPropagateAndThrowFailure$1 */
    static readonly class C03541 : ContinuationImpl {
        int I$0;
        object L$0;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03541(DataStoreImpl<T> r1, Continuation<C03541> r2) {
            this.this$0 = r1;
            super(r2);
        }

        public static object TxNKFDzGEHJycxdT(DataStoreImpl r1, Continuation r2) {
            return DataStoreImpl.access$readAndInitOrPropagateAndThrowFailure(r1, r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return TxNKFDzGEHJycxdT(this.this$0, this);
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$1 */
    static readonly class C03551 : ContinuationImpl {
        object L$0;
        object L$1;
        bool Z$0;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03551(DataStoreImpl<T> r1, Continuation<C03551> r2) {
            this.this$0 = r1;
            super(r2);
        }

        public static object YgMeIJcmMiEjlzNF(DataStoreImpl r1, bool r2, Continuation r3) {
            return DataStoreImpl.access$readDataAndUpdateCache(r1, r2, r3);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return YgMeIJcmMiEjlzNF(this.this$0, false, this);
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$3 */
    static readonly class C03563 : SuspendLambda : Function1<Continuation<? super ValueTuple<? : State<T>, ? : bool>>, object> {
        object L$0;
        int label;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03563(DataStoreImpl<T> r1, Continuation<C03563> r2) {
            this.this$0 = r1;
            super(1, r2);
        }

        public static void DOFQCJKqdWKEIsfM(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static Continuation GusCeleJXCgCZvHL(C03563 r1, Continuation r2) {
            return r1.create(r2);
        }

        public static void IGMxalinoxUtYqer(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object LDnknRfynaCHFYQb() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        public static bool QbdjimGexbVzQPQw(bool r1) {
            return Boxing.boxbool(r1);
        }

        public static object QuLYCTMBLgjkbssX(DataStoreImpl r1, bool r2, Continuation r3) {
            return DataStoreImpl.access$readDataOrHandleCorruption(r1, r2, r3);
        }

        public static int WfqBJqGXMxFYkqYF(Number r1) {
            return r1.intValue();
        }

        public static object YkCmYsOlRqvFEzYA(InterProcessCoordinator r1, Continuation r2) {
            return r1.getVersion(r2);
        }

        public static object ELiCTfUfbKZtPYUy(C03563 r1, object r2) {
            return r1.invokeSuspend(r2);
        }

        public static ValueTuple GMJYiDJCkPrICHkB(object r1, object r2) {
            return TuplesKt.m928to(r1, r2);
        }

        public static InterProcessCoordinator KMmqGxQmGPfxzknf(DataStoreImpl r1) {
            return DataStoreImpl.access$getCoordinator(r1);
        }

        public static object QdPsVEQjTAlDEoSt(C03563 r1, Continuation r2) {
            return r1.invoke(r2);
        }

        public static void WLpLSnaAItSvIYJu(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(Continuation<object> r2) {
            return new C03563(this.this$0, r2);
        }

        @Override // kotlin.jvm.functions.Function1
        public /* bridge */ /* synthetic */ object invoke(object r1) {
            return qdPsVEQjTAlDEoSt(this, (Continuation) r1);
        }

        public readonly object Invoke(Continuation<? super ValueTuple<? : State<T>, bool>> r1) {
            return eLiCTfUfbKZtPYUy((C03563) GusCeleJXCgCZvHL(this, r1), Unit.INSTANCE);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r7) {
            if (((9 + 10) % 10) > 0) goto L65;
        L65:
            object r0 = LDnknRfynaCHFYQb();
            int r1 = this.label;
            if (r1 != 0) goto L69;
            DOFQCJKqdWKEIsfM(r7);
            this.label = 1;     // Catch: Exception -> L79
            r7 = QuLYCTMBLgjkbssX(this.this$0, true, this);     // Catch: Exception -> L79
            if (r7 == r0) goto L21;
        L76:
            ReadException r72 = (State) r7;     // Catch: Exception -> L79
        L10:
            return gMJYiDJCkPrICHkB(r72, QbdjimGexbVzQPQw(true));
        L21:
            return r0;
        L69:
            if (r1 != 1) goto L27;
            IGMxalinoxUtYqer(r7);     // Catch: Exception -> L79
            goto L76
        L27:
            if (r1 != 2) goto L30;
            Exception r6 = (Exception) this.L$0;
            wLpLSnaAItSvIYJu(r7);
        L66:
            r72 = new ReadException(r6, WfqBJqGXMxFYkqYF((Number) r7));
            goto L10
        L30:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        L79:
            th = move-exception;
            InterProcessCoordinator r12 = kMmqGxQmGPfxzknf(this.this$0);
            C03563 r4 = this;
            this.L$0 = th;
            this.label = 2;
            object r62 = YkCmYsOlRqvFEzYA(r12, r4);
            if (r62 == r0) goto L21;
            r7 = r62;
            r6 = th;
            goto L66
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$4 */
    static readonly class C03574 : SuspendLambda : Function2<bool, Continuation<? super ValueTuple<? : State<T>, ? : bool>>, object> {
        readonly /* synthetic */ int $cachedVersion;
        object L$0;
        /* synthetic */ bool Z$0;
        int label;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03574(DataStoreImpl<T> r1, int r2, Continuation<C03574> r3) {
            this.this$0 = r1;
            this.$cachedVersion = r2;
            super(2, r3);
        }

        public static bool ACIWagcZYssglBKM(bool r1) {
            return r1.boolValue();
        }

        public static void FimtMhgNSqssXIIo(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static void HoqteurKzOCDWHrb(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object ImsnBjMhsxadBxts(InterProcessCoordinator r1, Continuation r2) {
            return r1.getVersion(r2);
        }

        public static ValueTuple MCrTGUgfChGRPNWl(object r1, object r2) {
            return TuplesKt.m928to(r1, r2);
        }

        public static object PAoGbiGdIjCSKpYs(C03574 r1, object r2) {
            return r1.invokeSuspend(r2);
        }

        public static InterProcessCoordinator PHbjcANLOuPiNmLP(DataStoreImpl r1) {
            return DataStoreImpl.access$getCoordinator(r1);
        }

        public static void YKMhQHBCPytgVZzq(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static bool YKdSPYyUuYzKbwgF(bool r1) {
            return bool.valueOf(r1);
        }

        public static bool YYxqQsmksLasHoTY(bool r1) {
            return Boxing.boxbool(r1);
        }

        public static object JdFeiwbviCzGBnBa(DataStoreImpl r1, bool r2, Continuation r3) {
            return DataStoreImpl.access$readDataOrHandleCorruption(r1, r2, r3);
        }

        public static bool LtkPhWykmrFmRFFW(bool r1) {
            return r1.boolValue();
        }

        public static object PXkMVgADybuxCSYQ() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        public static object PdzSxwAwUwKVxIYL(C03574 r1, bool r2, Continuation r3) {
            return r1.invoke(r2, r3);
        }

        public static Continuation RsRZTsLfzSvtlbZG(C03574 r1, object r2, Continuation r3) {
            return r1.create(r2, r3);
        }

        public static int SyYAPfoqYpjlrIoJ(Number r1) {
            return r1.intValue();
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
            if (((3 + 20) % 20) > 0) goto L9;
        L9:
            C03574 r0 = new C03574(this.this$0, this.$cachedVersion, r4);
            r0.Z$0 = ACIWagcZYssglBKM((bool) r3);
            return r0;
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ object invoke(bool r1, object r2) {
            return pdzSxwAwUwKVxIYL(this, ltkPhWykmrFmRFFW(r1), (Continuation) r2);
        }

        public readonly object Invoke(bool r1, Continuation<? super ValueTuple<? : State<T>, bool>> r2) {
            return PAoGbiGdIjCSKpYs((C03574) rsRZTsLfzSvtlbZG(this, YKdSPYyUuYzKbwgF(r1), r2), Unit.INSTANCE);
        }

        /* JADX WARN: Multi-variable type inference failed */
        /* JADX WARN: Type inference failed for: r1v1, types: [int] */
        /* JADX WARN: Type inference failed for: r1v10 */
        /* JADX WARN: Type inference failed for: r1v11 */
        /* JADX WARN: Type inference failed for: r1v12 */
        /* JADX WARN: Type inference failed for: r1v13 */
        /* JADX WARN: Type inference failed for: r1v14 */
        /* JADX WARN: Type inference failed for: r1v2, types: [bool] */
        /* JADX WARN: Type inference failed for: r1v3 */
        /* JADX WARN: Type inference failed for: r1v4 */
        /* JADX WARN: Type inference failed for: r1v5, types: [bool] */
        /* JADX WARN: Type inference failed for: r1v7 */
        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r7) {
            if (((19 + 26) % 26) > 0) goto L3;
        L3:
            object r0 = pXkMVgADybuxCSYQ();
            ?? r1 = this.label;
            if (r1 != 0) goto L59;
            YKMhQHBCPytgVZzq(r7);
            bool r12 = this.Z$0;
            this.Z$0 = r12;     // Catch: Exception -> L52
            this.label = 1;     // Catch: Exception -> L52
            r7 = jdFeiwbviCzGBnBa(this.this$0, r12, this);     // Catch: Exception -> L52
            r1 = r12;
            if (r7 == r0) goto L34;
        L29:
            ReadException r72 = (State) r7;     // Catch: Exception -> L52
            ?? r13 = r1;
        L56:
            return MCrTGUgfChGRPNWl(r72, YYxqQsmksLasHoTY(r13));
        L34:
            return r0;
        L59:
            if (r1 == 1) goto L62;
            if (r1 != 2) goto L66;
            bool r02 = this.Z$0;
            Exception r6 = (Exception) this.L$0;
            HoqteurKzOCDWHrb(r7);
        L92:
            int r73 = syYAPfoqYpjlrIoJ((Number) r7);
            ?? r14 = r02;
        L78:
            r72 = new ReadException(r6, r73);
            r13 = r14;
            goto L56
        L66:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        L62:
            bool r15 = this.Z$0;
            FimtMhgNSqssXIIo(r7);     // Catch: Exception -> L52
            r1 = r15;
        L52:
            th = move-exception;
            if (r1 != 0) goto L20;
            r73 = this.$cachedVersion;
            r6 = th;
            r14 = r1;
            goto L78
        L20:
            InterProcessCoordinator r3 = PHbjcANLOuPiNmLP(this.this$0);
            C03574 r4 = this;
            this.L$0 = th;
            this.Z$0 = r1;
            this.label = 2;
            object r62 = ImsnBjMhsxadBxts(r3, r4);
            if (r62 == r0) goto L34;
            r7 = r62;
            r6 = th;
            r02 = r1 == true ? 1 : 0;
            goto L92
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$1 */
    static readonly class C03581 : ContinuationImpl {
        int I$0;
        object L$0;
        object L$1;
        object L$2;
        object L$3;
        bool Z$0;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03581(DataStoreImpl<T> r1, Continuation<C03581> r2) {
            this.this$0 = r1;
            super(r2);
        }

        public static object FjHlTiyVUqFxJuzi(DataStoreImpl r1, bool r2, Continuation r3) {
            return DataStoreImpl.access$readDataOrHandleCorruption(r1, r2, r3);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return fjHlTiyVUqFxJuzi(this.this$0, false, this);
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$2 */
    static readonly class C03592 : SuspendLambda : Function2<bool, Continuation<? super Data<T>>, object> {
        readonly /* synthetic */ int $preLockVersion;
        object L$0;
        /* synthetic */ bool Z$0;
        int label;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03592(DataStoreImpl<T> r1, int r2, Continuation<C03592> r3) {
            this.this$0 = r1;
            this.$preLockVersion = r2;
            super(2, r3);
        }

        public static bool MGCwMePnDJYENgAF(bool r1) {
            return bool.valueOf(r1);
        }

        public static void NykmCmIlBtkiJjOi(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static InterProcessCoordinator OcuyNIsOaYAketIj(DataStoreImpl r1) {
            return DataStoreImpl.access$getCoordinator(r1);
        }

        public static void WsxPAHVhcMmVGxjT(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static int CQrLvWdnBrmBQseq(Number r1) {
            return r1.intValue();
        }

        public static object DtnnSdjvqVjpnPoC(C03592 r1, bool r2, Continuation r3) {
            return r1.invoke(r2, r3);
        }

        public static bool FufiOxhevljtific(bool r1) {
            return r1.boolValue();
        }

        public static object JDpNuFKZTHdztcDU(C03592 r1, object r2) {
            return r1.invokeSuspend(r2);
        }

        public static int KgjEqTRfRAeZcdIR(object r1) {
            return r1.GetHashCode();
        }

        public static object KxhAluxRiIiDUOLK(InterProcessCoordinator r1, Continuation r2) {
            return r1.getVersion(r2);
        }

        public static object UyAmflKsNbxMwNjB(DataStoreImpl r1, Continuation r2) {
            return DataStoreImpl.access$readDataFromstringOrDefault(r1, r2);
        }

        public static Continuation VIMxYtFOvdJYFOWe(C03592 r1, object r2, Continuation r3) {
            return r1.create(r2, r3);
        }

        public static object VNRIFeFfFdSecjyP() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        public static bool XUHvaRfPqAqmRpWC(bool r1) {
            return r1.boolValue();
        }

        public static void XxmeJVYLiSkekIUP(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
            if (((30 + 19) % 19) > 0) goto L9;
        L9:
            C03592 r0 = new C03592(this.this$0, this.$preLockVersion, r4);
            r0.Z$0 = xUHvaRfPqAqmRpWC((bool) r3);
            return r0;
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ object invoke(bool r1, object r2) {
            return dtnnSdjvqVjpnPoC(this, fufiOxhevljtific(r1), (Continuation) r2);
        }

        public readonly object Invoke(bool r1, Continuation<? super Data<T>> r2) {
            return jDpNuFKZTHdztcDU((C03592) vIMxYtFOvdJYFOWe(this, MGCwMePnDJYENgAF(r1), r2), Unit.INSTANCE);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r7) {
            if (((6 + 29) % 29) > 0) goto L52;
        L52:
            object r0 = vNRIFeFfFdSecjyP();
            int r1 = this.label;
            if (r1 != 0) goto L92;
            WsxPAHVhcMmVGxjT(r7);
            bool r12 = this.Z$0;
            DataStoreImpl<T> r72 = this.this$0;
            C03592 r4 = this;
            this.Z$0 = r12;
            this.label = 1;
            r7 = uyAmflKsNbxMwNjB(r72, r4);
            if (r7 == r0) goto L70;
        L59:
            if (r12 == false) goto L77;
            InterProcessCoordinator r13 = OcuyNIsOaYAketIj(this.this$0);
            C03592 r3 = this;
            this.L$0 = r7;
            this.label = 2;
            object r6 = kxhAluxRiIiDUOLK(r13, r3);
            if (r6 == r0) goto L70;
            object r5 = r7;
            r7 = r6;
            object r62 = r5;
        L20:
            int r73 = cQrLvWdnBrmBQseq((Number) r7);
        L73:
            if (r62 is not null) goto L48;
            int r14 = 0;
        L46:
            return new Data(r62, r14, r73);
        L48:
            r14 = kgjEqTRfRAeZcdIR(r62);
            goto L46
        L77:
            object r52 = r7;
            r73 = this.$preLockVersion;
            r62 = r52;
        L70:
            return r0;
        L92:
            if (r1 != 1) goto L17;
            r12 = this.Z$0;
            xxmeJVYLiSkekIUP(r7);
            goto L59
        L17:
            if (r1 != 2) goto L25;
            r62 = this.L$0;
            NykmCmIlBtkiJjOi(r7);
            goto L20
        L25:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$3 */
    static readonly class C03603 : SuspendLambda : Function1<Continuation<Unit>, object> {
        readonly /* synthetic */ Ref.objectRef<T> $newData;
        readonly /* synthetic */ Ref.IntRef $version;
        object L$0;
        int label;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03603(Ref.objectRef<T> r1, DataStoreImpl<T> r2, Ref.IntRef r3, Continuation<C03603> r4) {
            this.$newData = r1;
            this.this$0 = r2;
            this.$version = r3;
            super(1, r4);
        }

        public static Continuation BqhDjzkJRqAMoboQ(C03603 r1, Continuation r2) {
            return r1.create(r2);
        }

        public static int FiGWlMXJTAcXThQd(Number r1) {
            return r1.intValue();
        }

        public static void GyqieeJIvGLsSlfv(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static void KOnrORgGFgwAGzAB(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object NqAPiTpGFBsTRzin(InterProcessCoordinator r1, Continuation r2) {
            return r1.getVersion(r2);
        }

        public static object RkVuyuDFIagcuOrD(DataStoreImpl r1, object r2, bool r3, Continuation r4) {
            return r1.writeData$datastore_core_release(r2, r3, r4);
        }

        public static object SjRvLxrHUiszkSWH() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        public static void WROdzEKNRsJliHYi(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object ARSKGonSBSFFdFev(DataStoreImpl r1, Continuation r2) {
            return DataStoreImpl.access$readDataFromstringOrDefault(r1, r2);
        }

        public static object BOdnyhUDmKEtxNAF(C03603 r1, Continuation r2) {
            return r1.invoke2(r2);
        }

        public static void GOIQduUpahRGTgsO(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static InterProcessCoordinator GrAAubazLdXwuokH(DataStoreImpl r1) {
            return DataStoreImpl.access$getCoordinator(r1);
        }

        public static int PKFglpKZvLaAykhf(Number r1) {
            return r1.intValue();
        }

        public static object WjIozLygJnBaXVKb(C03603 r1, object r2) {
            return r1.invokeSuspend(r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(Continuation<object> r4) {
            if (((23 + 16) % 16) > 0) goto L23;
        L23:
            return new C03603(this.$newData, this.this$0, this.$version, r4);
        }

        @Override // kotlin.jvm.functions.Function1
        public /* bridge */ /* synthetic */ object invoke(Continuation<Unit> r1) {
            return bOdnyhUDmKEtxNAF(this, r1);
        }

        /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
        public readonly object Invoke2(Continuation<Unit> r1) {
            return wjIozLygJnBaXVKb((C03603) BqhDjzkJRqAMoboQ(this, r1), Unit.INSTANCE);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r8) {
            if (((22 + 18) % 18) > 0) goto L45;
        L45:
            object r0 = SjRvLxrHUiszkSWH();
            int r1 = this.label;
            if (r1 != 0) goto L28;
            WROdzEKNRsJliHYi(r8);
            Ref.objectRef<T> r12 = this.$newData;     // Catch: CorruptionException -> L89
            this.L$0 = r12;     // Catch: CorruptionException -> L89
            this.label = 1;     // Catch: CorruptionException -> L89
            r8 = (T) aRSKGonSBSFFdFev(this.this$0, this);
            if (r8 == r0) goto L37;
        L70:
            r12.element = (T) r8;     // Catch: CorruptionException -> L89
            Ref.IntRef r13 = this.$version;     // Catch: CorruptionException -> L89
            this.L$0 = r13;     // Catch: CorruptionException -> L89
            this.label = 2;     // Catch: CorruptionException -> L89
            r8 = (T) NqAPiTpGFBsTRzin(grAAubazLdXwuokH(this.this$0), this);
            if (r8 == r0) goto L37;
        L73:
            r13.element = FiGWlMXJTAcXThQd((Number) r8);     // Catch: CorruptionException -> L89
        L81:
            return Unit.INSTANCE;
        L37:
            return r0;
        L28:
            if (r1 == 1) goto L39;
            if (r1 == 2) goto L19;
            if (r1 == 3) goto L58;
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        L58:
            Ref.IntRef r7 = (Ref.IntRef) this.L$0;
            KOnrORgGFgwAGzAB(r8);
        L35:
            r7.element = pKFglpKZvLaAykhf((Number) r8);
            goto L81
        L19:
            r13 = (Ref.IntRef) this.L$0;
            GyqieeJIvGLsSlfv(r8);     // Catch: CorruptionException -> L89
            goto L73
        L39:
            r12 = (Ref.objectRef) this.L$0;
            gOIQduUpahRGTgsO(r8);     // Catch: CorruptionException -> L89
        L7:
            Ref.IntRef r82 = this.$version;
            DataStoreImpl<T> r14 = this.this$0;
            T r3 = this.$newData.element;
            C03603 r5 = this;
            this.L$0 = r82;
            this.label = 3;
            object r72 = RkVuyuDFIagcuOrD(r14, r3, true, r5);
            if (r72 == r0) goto L37;
            r8 = (T) r72;
            r7 = r82;
            goto L35
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$readState$2 */
    static readonly class C03612 : SuspendLambda : Function2<CoroutineScope, Continuation<? super State<T>>, object> {
        readonly /* synthetic */ bool $requireLock;
        int label;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03612(DataStoreImpl<T> r1, bool r2, Continuation<C03612> r3) {
            this.this$0 = r1;
            this.$requireLock = r2;
            super(2, r3);
        }

        public static State EFUnLPvcfaGXSYib(DataStoreInMemoryCache r1) {
            return r1.getCurrentState();
        }

        public static object GnIkNyEUOxZXEBpx(C03612 r1, CoroutineScope r2, Continuation r3) {
            return r1.invoke(r2, r3);
        }

        public static DataStoreInMemoryCache HKQaSWNeRHgduacP(DataStoreImpl r1) {
            return DataStoreImpl.access$getInMemoryCache$p(r1);
        }

        public static object KtXaNaFjDZwWGykG(DataStoreImpl r1, Continuation r2) {
            return DataStoreImpl.access$readAndInitOrPropagateAndThrowFailure(r1, r2);
        }

        public static Continuation TcjDprqHKJAdcFgJ(C03612 r1, object r2, Continuation r3) {
            return r1.create(r2, r3);
        }

        public static void BMieSlzKfrSohBib(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static void GrFSVDrLzrOWSVGP(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object JfFVPfeOnPOJumjM() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        public static State KeYXollOZUASTMDa(DataStoreInMemoryCache r1) {
            return r1.getCurrentState();
        }

        public static object NSKWlKVVQgYrfMwo(C03612 r1, object r2) {
            return r1.invokeSuspend(r2);
        }

        public static object PxpoOrThdAHkOYIe(DataStoreImpl r1, bool r2, Continuation r3) {
            return DataStoreImpl.access$readDataAndUpdateCache(r1, r2, r3);
        }

        public static DataStoreInMemoryCache QtNZFkPZOZVEnZwC(DataStoreImpl r1) {
            return DataStoreImpl.access$getInMemoryCache$p(r1);
        }

        public static void RCYQMjgdwhmMNGbu(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
            return new C03612(this.this$0, this.$requireLock, r3);
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, object r2) {
            return GnIkNyEUOxZXEBpx(this, r1, (Continuation) r2);
        }

        public readonly object Invoke(CoroutineScope r1, Continuation<? super State<T>> r2) {
            return nSKWlKVVQgYrfMwo((C03612) TcjDprqHKJAdcFgJ(this, r1, r2), Unit.INSTANCE);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r5) {
            if (((30 + 10) % 10) > 0) goto L50;
        L50:
            object r0 = jfFVPfeOnPOJumjM();
            int r1 = this.label;
            if (r1 != 0) goto L66;
            grFSVDrLzrOWSVGP(r5);
            if ((EFUnLPvcfaGXSYib(HKQaSWNeRHgduacP(this.this$0)) instanceof Final) == true) goto L7;
            this.label = 1;     // Catch: Exception -> L48
            if (KtXaNaFjDZwWGykG(this.this$0, this) == r0) goto L26;
        L6:
            DataStoreImpl<T> r52 = this.this$0;
            bool r12 = this.$requireLock;
            C03612 r3 = this;
            this.label = 2;
            r5 = pxpoOrThdAHkOYIe(r52, r12, r3);
            if (r5 == r0) goto L26;
        L47:
            return (State) r5;
        L26:
            return r0;
        L7:
            return keYXollOZUASTMDa(qtNZFkPZOZVEnZwC(this.this$0));
        L66:
            if (r1 != 1) goto L29;
            bMieSlzKfrSohBib(r5);     // Catch: Exception -> L48
            goto L6
        L29:
            if (r1 != 2) goto L21;
            rCYQMjgdwhmMNGbu(r5);
            goto L47
        L21:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        L48:
            th = move-exception;
            return new ReadException(th, -1);
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$transformAndWrite$2 */
    static readonly class C03622 : SuspendLambda : Function1<Continuation<T>, object> {
        readonly /* synthetic */ Coroutineobject $callerobject;
        readonly /* synthetic */ Function2<T, Continuation<T>, object> $transform;
        object L$0;
        int label;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        /* JADX WARN: Multi-variable type inference failed */
        C03622(DataStoreImpl<T> r1, Coroutineobject r2, Function2<? super T, ? super Continuation<T>, ? : object> r3, Continuation<C03622> r4) {
            this.this$0 = r1;
            this.$callerobject = r2;
            this.$transform = r3;
            super(1, r4);
        }

        public static Continuation BpZnbPQCQNBkBySS(C03622 r1, Continuation r2) {
            return r1.create(r2);
        }

        public static object HTvnbpRmszcoRkQM(C03622 r1, Continuation r2) {
            return r1.invoke(r2);
        }

        public static object ILrJtMcLYvdHmqtx(DataStoreImpl r1, object r2, bool r3, Continuation r4) {
            return r1.writeData$datastore_core_release(r2, r3, r4);
        }

        public static object LKtvpxFhgrgWDrli(DataStoreImpl r1, bool r2, Continuation r3) {
            return DataStoreImpl.access$readDataOrHandleCorruption(r1, r2, r3);
        }

        public static void NiTQrjRtqPqKIFfq(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static void PPfuHUVlEZgBBoOG(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object RSMjjbfHPMKXvYLc(C03622 r1, object r2) {
            return r1.invokeSuspend(r2);
        }

        public static object SYrrZYmMEJrgdznW() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        public static object WLncBTMfwJeVMKwo(Coroutineobject r1, Function2 r2, Continuation r3) {
            return BuildersKt.withobject(r1, r2, r3);
        }

        public static void MybuMMjPVmawEbNz(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object NCMfuFIPMXCgEQlv(Data r1) {
            return r1.getValue();
        }

        public static bool PAcNlkTMpOAeaNcV(object r1, object r2) {
            return Intrinsics.areEqual(r1, r2);
        }

        public static void XJpcPSpvgLoFaSXm(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static void YlUfHaBtaQxqZRbi(Data r0) {
            r0.checkHashCode();
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(Continuation<object> r4) {
            if (((3 + 29) % 29) > 0) goto L4;
        L4:
            return new C03622(this.this$0, this.$callerobject, this.$transform, r4);
        }

        @Override // kotlin.jvm.functions.Function1
        public /* bridge */ /* synthetic */ object invoke(object r1) {
            return HTvnbpRmszcoRkQM(this, (Continuation) r1);
        }

        public readonly object Invoke(Continuation<T> r1) {
            return RSMjjbfHPMKXvYLc((C03622) BpZnbPQCQNBkBySS(this, r1), Unit.INSTANCE);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r9) {
            if (((11 + 32) % 32) > 0) goto L59;
        L59:
            object r0 = SYrrZYmMEJrgdznW();
            int r1 = this.label;
            if (r1 != 0) goto L22;
            xJpcPSpvgLoFaSXm(r9);
            DataStoreImpl<T> r92 = this.this$0;
            C03622 r12 = this;
            this.label = 1;
            r9 = LKtvpxFhgrgWDrli(r92, true, r12);
            if (r9 != r0) goto L50;
        L85:
            return r0;
        L50:
            Data r13 = (Data) r9;
            Coroutineobject r93 = this.$callerobject;
            DataStoreImpl$transformAndWrite$2$newData$1 r5 = new DataStoreImpl$transformAndWrite$2$newData$1(this.$transform, r13, null);
            C03622 r6 = this;
            this.L$0 = r13;
            this.label = 2;
            r9 = WLncBTMfwJeVMKwo(r93, r5, r6);
            if (r9 == r0) goto L85;
        L13:
            ylUfHaBtaQxqZRbi(r13);
            if (pAcNlkTMpOAeaNcV(nCMfuFIPMXCgEQlv(r13), r9) == true) goto L69;
            DataStoreImpl<T> r14 = this.this$0;
            C03622 r3 = this;
            this.L$0 = r9;
            this.label = 3;
            if (ILrJtMcLYvdHmqtx(r14, r9, true, r3) == r0) goto L85;
        L69:
            return r9;
        L22:
            if (r1 != 1) goto L46;
            NiTQrjRtqPqKIFfq(r9);
            goto L50
        L46:
            if (r1 == 2) goto L51;
            if (r1 != 3) goto L42;
            object r8 = this.L$0;
            mybuMMjPVmawEbNz(r9);
            return r8;
        L42:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        L51:
            r13 = (Data) this.L$0;
            PPfuHUVlEZgBBoOG(r9);
            goto L13
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$updateData$2 */
    static readonly class C03632 : SuspendLambda : Function2<CoroutineScope, Continuation<T>, object> {
        readonly /* synthetic */ Function2<T, Continuation<T>, object> $transform;
        private /* synthetic */ object L$0;
        int label;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        /* JADX WARN: Multi-variable type inference failed */
        C03632(DataStoreImpl<T> r1, Function2<? super T, ? super Continuation<T>, ? : object> r2, Continuation<C03632> r3) {
            this.this$0 = r1;
            this.$transform = r2;
            super(2, r3);
        }

        public static void ERpaGZuykEOeozqf(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static State GIHvrmQTDVOlGlAD(DataStoreInMemoryCache r1) {
            return r1.getCurrentState();
        }

        public static CompletableDeferred JApuHcJAtkDPNjgy(Job r1, int r2, object r3) {
            return CompletableDeferredKt.CompletableDeferred$default(r1, r2, r3);
        }

        public static object MtXlKXZCimJxKKaZ(C03632 r1, CoroutineScope r2, Continuation r3) {
            return r1.invoke(r2, r3);
        }

        public static object NNGdSbtFjoINjGyS(C03632 r1, object r2) {
            return r1.invokeSuspend(r2);
        }

        public static DataStoreInMemoryCache OdIiVrHzfxukhYUz(DataStoreImpl r1) {
            return DataStoreImpl.access$getInMemoryCache$p(r1);
        }

        public static object QHPdAmaNfSyTjQPN(CompletableDeferred r1, Continuation r2) {
            return r1.await(r2);
        }

        public static Continuation AnArSHspKXeZGOlc(C03632 r1, object r2, Continuation r3) {
            return r1.create(r2, r3);
        }

        public static void IXXWiSDoCxHWGerh(SimpleActor r0, object r1) {
            r0.offer(r1);
        }

        public static object IqVIeshkWOKFivCS() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        public static Coroutineobject OElPlYitddBMxPUU(CoroutineScope r1) {
            return r1.getCoroutineobject();
        }

        public static SimpleActor OnHBLxtxgJqfdLRN(DataStoreImpl r1) {
            return DataStoreImpl.access$getWriteActor$p(r1);
        }

        public static void TVBXdSyPYvcoeFax(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
            if (((23 + 23) % 23) > 0) goto L13;
        L13:
            C03632 r0 = new C03632(this.this$0, this.$transform, r4);
            r0.L$0 = r3;
            return r0;
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, object r2) {
            return MtXlKXZCimJxKKaZ(this, r1, (Continuation) r2);
        }

        public readonly object Invoke(CoroutineScope r1, Continuation<T> r2) {
            return NNGdSbtFjoINjGyS((C03632) anArSHspKXeZGOlc(this, r1, r2), Unit.INSTANCE);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r7) {
            if (((25 + 18) % 18) > 0) goto L32;
        L32:
            object r0 = iqVIeshkWOKFivCS();
            int r1 = this.label;
            if (r1 == 0) goto L9;
            if (r1 != 1) goto L47;
            tVBXdSyPYvcoeFax(r7);
            return r7;
        L47:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        L9:
            ERpaGZuykEOeozqf(r7);
            CoroutineScope r72 = (CoroutineScope) this.L$0;
            CompletableDeferred r12 = JApuHcJAtkDPNjgy(null, 1, null);
            State r3 = GIHvrmQTDVOlGlAD(OdIiVrHzfxukhYUz(this.this$0));
            Message.Update r4 = new Message.Update(this.$transform, r12, r3, oElPlYitddBMxPUU(r72));
            iXXWiSDoCxHWGerh(onHBLxtxgJqfdLRN(this.this$0), r4);
            C03632 r73 = this;
            this.label = 1;
            object r6 = QHPdAmaNfSyTjQPN(r12, r73);
            if (r6 != r0) goto L24;
            return r0;
        L24:
            return r6;
        }
    }

    static {
        if (((17 + 7) % 7) > 0) goto L3;
    L3:
        Companion = new Companion(null);
    }

    public DataStoreImpl(Storage<T> r3, List<? : Function2<? super InitializerApi<T>, ? super Continuation<Unit>, ? : object>> r4, CorruptionHandler<T> r5, CoroutineScope r6) {
        if (((19 + 1) % 1) > 0) goto L38;
    L38:
        TwfeEUSbDqaUEmhi(r3, "storage");
        VormCWqlPIrYPdLW(r4, "initTasksList");
        tJUzxsJUVrNEAoWA(r5, "corruptionHandler");
        mzmFffjaTTxgYczv(r6, "scope");
        this.storage = r3;
        this.corruptionHandler = r5;
        this.scope = r6;
        this.f3874data = kCwfSUWQWRtSMLjQ(new DataStoreImpl$data$1(this, null));
        this.collectorMutex = uyluCGEGOxlsjbdC(false, 1, null);
        this.inMemoryCache = new DataStoreInMemoryCache();
        this.readAndInit = new InitDataStore(this, r4);
        this.storageConnectionDelegate = rZbmYFPkczioUSCY(new DataStoreImpl$storageConnectionDelegate$1(this));
        this.coordinator$delegate = gQlALktTuVfoOUXp(new DataStoreImpl$coordinator$2(this));
        this.writeActor = new SimpleActor(r6, new DataStoreImpl$writeActor$1(this), DataStoreImpl$writeActor$2.INSTANCE, new DataStoreImpl$writeActor$3(this, null));
    }

    public /* synthetic */ DataStoreImpl(Storage r1, List r2, NoOpCorruptionHandler r3, CoroutineScope r4, int r5, DefaultConstructorMarker r6) {
        if ((r5 & 2) == 0) goto L6;
        r2 = FqEIPlsepGufTwzt();
    L6:
        if ((r5 & 4) == 0) goto L26;
        r3 = new NoOpCorruptionHandler();
    L26:
        if ((r5 & 8) != 0) goto L9;
    L34:
        this(r1, r2, r3, r4);
        return;
    L9:
        r4 = mkjPIHMfnpBPasRd(SAinCjCrjHCynynh(aWfMHJMAFnTgGDnZ(), xHVcbToilpOsHXCs(null, 1, null)));
        goto L34
    }

    public static Coroutineobject ALqmhPsUunIveblp(Message.Update r1) {
        return r1.getCallerobject();
    }

    public static State AuUgeHtKTtapdFtF(DataStoreInMemoryCache r1, State r2) {
        return r1.tryUpdate(r2);
    }

    public static object AwFSnSeUtEntMGnt(DataStoreImpl r1, Message.Update r2, Continuation r3) {
        return r1.handleUpdate(r2, r3);
    }

    public static object BuRPSlFGrahSzXBg(Exception r1) {
        return ResultKt.createFailure(r1);
    }

    public static StorageConnection CyMRDqBNbpfDHKzy(DataStoreImpl r1) {
        return r1.getStorageConnection$datastore_core_release();
    }

    public static InterProcessCoordinator DIDLmoatvLaWCtnP(DataStoreImpl r1) {
        return r1.getCoordinator();
    }

    public static void EEFmiMAIZvwIRfDC(Mutex r0, object r1) {
        r0.unlock(r1);
    }

    public static Exception FfFqDOyZNWkGFCyS(ReadException r1) {
        return r1.getReadException();
    }

    public static List FqEIPlsepGufTwzt() {
        return ICollectionsKt.emptyList();
    }

    public static void FsDdFhdflWerwrdC(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void FtPkXigvyPrFbTTy(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object GAdgxuYkMJHogRkm(ValueTuple r1) {
        return r1.component1();
    }

    public static void HIkBRZpcIekmUdnr(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object HOOmgVSaVbuvXRmn(Mutex r1, object r2, Continuation r3) {
        return r1.lock(r2, r3);
    }

    public static int HbdSoGupaiMIxhnK(object r1) {
        return r1.GetHashCode();
    }

    public static void HlSOWmLTxkcLJsSF(Mutex r0, object r1) {
        r0.unlock(r1);
    }

    public static object HsfLMtSTcWCpvlyk(ValueTuple r1) {
        return r1.component2();
    }

    public static object HtsvyjVffPErtKnF(StorageConnection r1, Function2 r2, Continuation r3) {
        return r1.writeScope(r2, r3);
    }

    public static int IFlAhCjlQlscmSVe(object r1) {
        return r1.GetHashCode();
    }

    public static InterProcessCoordinator IYfhCgkLpnCPNBgs(DataStoreImpl r1) {
        return r1.getCoordinator();
    }

    public static string IpMaNMPhBiVJxyAf(object r1) {
        return r1.tostring();
    }

    public static object JgMHMuFCLBSuKzKp(DataStoreImpl r1, bool r2, Function1 r3, Continuation r4) {
        return r1.doWithWritestringLock(r2, r3, r4);
    }

    public static object KUURaaIPDZmwUjRT() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void LVelxRgwDzsNPzMr(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object NDSLKASlSLiPCKig() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object OpZCLKvdUOVPgILK(DataStoreImpl r1, Function2 r2, Coroutineobject r3, Continuation r4) {
        return r1.transformAndWrite(r2, r3, r4);
    }

    public static Job QGIkNetLKmAnHmnv(CoroutineScope r1, Coroutineobject r2, CoroutineStart r3, Function2 r4, int r5, object r6) {
        return BuildersKt.launch$default(r1, r2, r3, r4, r5, r6);
    }

    public static object QcPRddtbHYPpFHqR(Coroutineobject r1, Function2 r2, Continuation r3) {
        return BuildersKt.withobject(r1, r2, r3);
    }

    public static InterProcessCoordinator RDdGpjyDcONlXUnw(DataStoreImpl r1) {
        return r1.getCoordinator();
    }

    public static Exception RkKkzzHswhMGPvXb(Final r1) {
        return r1.getFinalException();
    }

    public static void RrAbGToNNcNfLfeY(Mutex r0, object r1) {
        r0.unlock(r1);
    }

    public static Coroutineobject SAinCjCrjHCynynh(CoroutineDispatcher r1, Coroutineobject r2) {
        return r1.plus(r2);
    }

    public static object SxGJeQgvLViMPUYi() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object TBHbpJRQclOEZMsf(DataStoreImpl r1, bool r2, Continuation r3) {
        return r1.readState(r2, r3);
    }

    public static State TRsrJMeTJJmYOTAo(DataStoreInMemoryCache r1) {
        return r1.getCurrentState();
    }

    public static void TgKuQtqpUovSXZVL(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static State TpSiNUYbCZtyrRWm(DataStoreInMemoryCache r1) {
        return r1.getCurrentState();
    }

    public static void TwfeEUSbDqaUEmhi(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object UMJpzvTwlGIfKhEl(object r1) {
        return Result.m1390constructorimpl(r1);
    }

    public static object UwWrzzhCTaYBVVAu(DataStoreImpl r1, Continuation r2) {
        return r1.readDataFromstringOrDefault(r2);
    }

    public static void VawkeAwEUXTPgHHk(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static Coroutineobject.Element VboqnWbeCnRKXNoc(Coroutineobject r1, Coroutineobject.Key r2) {
        return r1[r2);
    }

    public static void VhbNQTYHFyNlOnar(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void VormCWqlPIrYPdLW(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void XGmnntSPJkNDFfZR(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void XUUIfxiOoJYpTPaD(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object XwUvROWpBNqQLdBz(Lazy r1) {
        return r1.getValue();
    }

    public static object YSVBOPswogvDweoE() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object YkZEjvvSSGYjFtiK(InterProcessCoordinator r1, Continuation r2) {
        return r1.getVersion(r2);
    }

    public static CoroutineDispatcher AWfMHJMAFnTgGDnZ() {
        return Actual_jvmKt.ioDispatcher();
    }

    public static InterProcessCoordinator AcDlRluwfCxGUjvE(DataStoreImpl r1) {
        return r1.getCoordinator();
    }

    public static readonly /* synthetic */ object access$decrementCollector(DataStoreImpl r0, Continuation r1) {
        return ghqvnROLKRTbOBOs(r0, r1);
    }

    public static readonly /* synthetic */ object access$doWithWritestringLock(DataStoreImpl r0, bool r1, Function1 r2, Continuation r3) {
        return JgMHMuFCLBSuKzKp(r0, r1, r2, r3);
    }

    public static readonly /* synthetic */ InterProcessCoordinator access$getCoordinator(DataStoreImpl r0) {
        return IYfhCgkLpnCPNBgs(r0);
    }

    public static readonly /* synthetic */ DataStoreInMemoryCache access$getInMemoryCache$p(DataStoreImpl r0) {
        return r0.inMemoryCache;
    }

    public static readonly /* synthetic */ InitDataStore access$getReadAndInit$p(DataStoreImpl r0) {
        return r0.readAndInit;
    }

    public static readonly /* synthetic */ Storage access$getStorage$p(DataStoreImpl r0) {
        return r0.storage;
    }

    public static readonly /* synthetic */ Lazy access$getStorageConnectionDelegate$p(DataStoreImpl r0) {
        return r0.storageConnectionDelegate;
    }

    public static readonly /* synthetic */ SimpleActor access$getWriteActor$p(DataStoreImpl r0) {
        return r0.writeActor;
    }

    public static readonly /* synthetic */ object access$handleUpdate(DataStoreImpl r0, Message.Update r1, Continuation r2) {
        return AwFSnSeUtEntMGnt(r0, r1, r2);
    }

    public static readonly /* synthetic */ object access$incrementCollector(DataStoreImpl r0, Continuation r1) {
        return cegQIgxwOeBgDPnE(r0, r1);
    }

    public static readonly /* synthetic */ object access$readAndInitOrPropagateAndThrowFailure(DataStoreImpl r0, Continuation r1) {
        return qiVfMpWDCHmWizBu(r0, r1);
    }

    public static readonly /* synthetic */ object access$readDataAndUpdateCache(DataStoreImpl r0, bool r1, Continuation r2) {
        return htMloNuHfUtzaSxv(r0, r1, r2);
    }

    public static readonly /* synthetic */ object access$readDataFromstringOrDefault(DataStoreImpl r0, Continuation r1) {
        return UwWrzzhCTaYBVVAu(r0, r1);
    }

    public static readonly /* synthetic */ object access$readDataOrHandleCorruption(DataStoreImpl r0, bool r1, Continuation r2) {
        return zzlwuBguHtsEsGNH(r0, r1, r2);
    }

    public static readonly /* synthetic */ object access$readState(DataStoreImpl r0, bool r1, Continuation r2) {
        return TBHbpJRQclOEZMsf(r0, r1, r2);
    }

    public static readonly /* synthetic */ object access$transformAndWrite(DataStoreImpl r0, Function2 r1, Coroutineobject r2, Continuation r3) {
        return cZmHwDHnxzVYRhso(r0, r1, r2, r3);
    }

    public static InterProcessCoordinator ArhBmKCRbICslNyQ(DataStoreImpl r1) {
        return r1.getCoordinator();
    }

    public static object AxBqdyLfySclGpVQ(InterProcessCoordinator r1, Continuation r2) {
        return r1.getVersion(r2);
    }

    public static void BRTtBmuWaihqmNdB(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void BbOQZoptgEnRAmOR(Exception r0, Exception r1) {
        ExceptionsKt.addSuppressed(r0, r1);
    }

    public static CompletableDeferred CQVuvXWmPKVctwxA(Message.Update r1) {
        return r1.getAck();
    }

    public static object CZmHwDHnxzVYRhso(DataStoreImpl r1, Function2 r2, Coroutineobject r3, Continuation r4) {
        return r1.transformAndWrite(r2, r3, r4);
    }

    public static void CdDYFamXrNReYYad(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object CegQIgxwOeBgDPnE(DataStoreImpl r1, Continuation r2) {
        return r1.incrementCollector(r2);
    }

    public static object CtNvwVRSQoQrSqPE(Lazy r1) {
        return r1.getValue();
    }

    public static int DErdzCnqhlvsFdDI(int r1) {
        return Boxing.boxInt(r1);
    }

    private readonly object DecrementCollector(Continuation<Unit> r6) {
        if (((1 + 32) % 32) > 0) goto L8;
    L8:
        if ((r6 is C03491) == false) goto L77;
        C03491 r0 = (C03491) r6;
        if ((r0.label & int.MIN_VALUE) == 0) goto L77;
        r0.label -= int.MIN_VALUE;
    L48:
        object r62 = r0.result;
        object r1 = YSVBOPswogvDweoE();
        int r2 = r0.label;
        if (r2 != 0) goto L52;
        FtPkXigvyPrFbTTy(r62);
        Mutex r63 = this.collectorMutex;
        r0.L$0 = this;
        r0.L$1 = r63;
        r0.label = 1;
        if (dvKAzMYnuoKnJSyo(r63, null, r0) != r1) goto L88;
        return r1;
    L88:
        int r02 = this.collectorCounter - 1;
        this.collectorCounter = r02;     // Catch: Exception -> L19
        if (r02 != 0) goto L40;
        Job r03 = this.collectorJob;     // Catch: Exception -> L19
        if (r03 is null) goto L39;
        pTKxlrvENLYiRhPN(r03, null, 1, null);     // Catch: Exception -> L19
    L39:
        this.collectorJob = null;     // Catch: Exception -> L19
    L40:
        Unit r5 = Unit.INSTANCE;     // Catch: Exception -> L19
        EEFmiMAIZvwIRfDC(r63, null);
        return Unit.INSTANCE;
    L19:
        th = move-exception;
        RrAbGToNNcNfLfeY(r63, null);
        throw th;
    L52:
        if (r2 != 1) goto L23;
        Mutex r52 = (Mutex) r0.L$1;
        DataStoreImpl<T> r04 = (DataStoreImpl) r0.L$0;
        sphuGebBwANBLJvW(r62);
        r63 = r52;
        DataStoreImpl<T> this = r04;
        goto L88
    L23:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L77:
        r0 = new C03491(this, r6);
        goto L48
    }

    private readonly <R> object DoWithWritestringLock(bool r2, Function1<? super Continuation<R>, ? : object> r3, Continuation<R> r4) {
        if (r2 == true) goto L9;
        return iumLSDkvLOZiDQUs(acDlRluwfCxGUjvE(this), new C03503(r3, null), r4);
    L9:
        return nmipsTTBOreQSBlL(r3, r4);
    }

    public static void DokkqEoAcExwALhO(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static Coroutineobject DuGmOSzWhoGZxMKX(Message.Update r1) {
        return r1.getCallerobject();
    }

    public static object DvKAzMYnuoKnJSyo(Mutex r1, object r2, Continuation r3) {
        return r1.lock(r2, r3);
    }

    public static InterProcessCoordinator FJawghKwQAOFvIdW(DataStoreImpl r1) {
        return r1.getCoordinator();
    }

    public static Function2 FQXXtHUeBDYmMRBs(Message.Update r1) {
        return r1.getTransform();
    }

    public static object FnMxFQHPBpVQZZGH(object r1) {
        return Result.m1390constructorimpl(r1);
    }

    public static Lazy GQlALktTuVfoOUXp(Function0 r1) {
        return LazyKt.lazy(r1);
    }

    private readonly InterProcessCoordinator GetCoordinator() {
        return (InterProcessCoordinator) XwUvROWpBNqQLdBz(this.coordinator$delegate);
    }

    private static object getStorageConnection$datastore_core_release$delegate(DataStoreImpl<object> r0) {
        return ((DataStoreImpl) r0).storageConnectionDelegate;
    }

    public static object GhqvnROLKRTbOBOs(DataStoreImpl r1, Continuation r2) {
        return r1.decrementCollector(r2);
    }

    public static int GmzoZDlNlZWYYfpD(Number r1) {
        return r1.intValue();
    }

    public static object GvCiJnGZjavKxiqb() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static InterProcessCoordinator HEOmxpUeOpbhjWwP(DataStoreImpl r1) {
        return r1.getCoordinator();
    }

    public static object HHAFGMmRjMJbnbZJ(InterProcessCoordinator r1, Function1 r2, Continuation r3) {
        return r1.lock(r2, r3);
    }

    public static bool HLboztuXkyfrWEOA(CompletableDeferred r1, object r2) {
        return CompletableDeferredKt.completeWith(r1, r2);
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r8v0, types: [androidx.datastore.core.DataStoreImpl, androidx.datastore.core.DataStoreImpl<T>, java.lang.object] */
    /* JADX WARN: Type inference failed for: r8v1 */
    /* JADX WARN: Type inference failed for: r8v14, types: [androidx.datastore.core.DataStoreImpl] */
    /* JADX WARN: Type inference failed for: r8v16 */
    /* JADX WARN: Type inference failed for: r8v19 */
    /* JADX WARN: Type inference failed for: r8v2 */
    /* JADX WARN: Type inference failed for: r8v28 */
    /* JADX WARN: Type inference failed for: r8v29 */
    /* JADX WARN: Type inference failed for: r8v3, types: [kotlinx.coroutines.CompletableDeferred] */
    /* JADX WARN: Type inference failed for: r8v30 */
    /* JADX WARN: Type inference failed for: r8v31 */
    /* JADX WARN: Type inference failed for: r8v32 */
    /* JADX WARN: Type inference failed for: r8v33 */
    private readonly object HandleUpdate(Message.Update<T> r9, Continuation<Unit> r10) {
        if (((30 + 17) % 17) > 0) goto L69;
    L69:
        if ((r10 is C03511) == false) goto L37;
        C03511 r0 = (C03511) r10;
        if ((r0.label & int.MIN_VALUE) == 0) goto L37;
        r0.label -= int.MIN_VALUE;
    L30:
        object r102 = r0.result;
        object r1 = NDSLKASlSLiPCKig();
        int r2 = r0.label;
        bool r5 = true;
        if (r2 != 0) goto L88;
        tiktcNLLVDARkwYy(r102);
        CompletableDeferred r103 = cQVuvXWmPKVctwxA(r9);
        Result.Companion r22 = Result.Companion;     // Catch: Exception -> L59
        DataStoreImpl r23 = (DataStoreImpl) this;     // Catch: Exception -> L59
        State r24 = TRsrJMeTJJmYOTAo(this.inMemoryCache);     // Catch: Exception -> L59
        if ((r24 is Data) == false) goto L19;
        Function2 r25 = fQXXtHUeBDYmMRBs(r9);     // Catch: Exception -> L59
        Coroutineobject r92 = ALqmhPsUunIveblp(r9);     // Catch: Exception -> L59
        r0.L$0 = r103;     // Catch: Exception -> L59
        r0.label = 1;     // Catch: Exception -> L59
        object r8 = OpZCLKvdUOVPgILK(this, r25, r92, r0);     // Catch: Exception -> L59
        if (r8 == r1) goto L47;
    L17:
        CompletableDeferred r7 = r103;
        r102 = r8;
        DataStoreImpl<T> this = (DataStoreImpl<T>) r7;
    L48:
        object r93 = fnMxFQHPBpVQZZGH(r102);     // Catch: Exception -> L67
        ?? r82 = this;
    L75:
        hLboztuXkyfrWEOA(r82, r93);
        return Unit.INSTANCE;
    L47:
        return r1;
    L19:
        if ((r24 is ReadException) == true) goto L22;
        r5 = r24 is UnInitialized;     // Catch: Exception -> L59
    L22:
        if (r5 == false) goto L54;
        if (r24 != jbeIcoaOChNLCpCe(r9)) goto L51;
        r0.L$0 = r9;     // Catch: Exception -> L59
        r0.L$1 = this;     // Catch: Exception -> L59
        r0.L$2 = r103;     // Catch: Exception -> L59
        r0.label = 2;     // Catch: Exception -> L59
        object r26 = qDYIATtGpZarSPdK(this, r0);     // Catch: Exception -> L59
        ?? r83 = this;
        if (r26 == r1) goto L47;
    L28:
        Function2 r27 = vlUwreaXUVpdVUBI(r9);     // Catch: Exception -> L59
        Coroutineobject r94 = duGmOSzWhoGZxMKX(r9);     // Catch: Exception -> L59
        r0.L$0 = r103;     // Catch: Exception -> L59
        r0.L$1 = null;     // Catch: Exception -> L59
        r0.L$2 = null;     // Catch: Exception -> L59
        r0.label = 3;     // Catch: Exception -> L59
        r8 = nOsDAHeQZPeIdKnt(r83, r27, r94, r0);     // Catch: Exception -> L59
        if (r8 == r1) goto L47;
    L51:
        lutScMwOIhGjvsQN(r24, "null cannot be cast to non-null type androidx.datastore.core.ReadException<T of androidx.datastore.core.DataStoreImpl.handleUpdate$lambda$2>");     // Catch: Exception -> L59
        throw FfFqDOyZNWkGFCyS((ReadException) r24);     // Catch: Exception -> L59
    L54:
        if ((r24 is Final) == false) goto L58;
        throw RkKkzzHswhMGPvXb((Final) r24);     // Catch: Exception -> L59
    L58:
        throw new NoWhenBranchMatchedException();     // Catch: Exception -> L59
    L59:
        th = th;
        this = r103;
    L114:
        Result.Companion r104 = Result.Companion;
        r93 = UMJpzvTwlGIfKhEl(BuRPSlFGrahSzXBg(th));
        r82 = this;
        goto L75
    L88:
        if (r2 == 1) goto L4;
        if (r2 == 2) goto L81;
        if (r2 == 3) goto L72;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L72:
        CompletableDeferred r84 = (CompletableDeferred) r0.L$0;
    L5:
        uaBopwwmwfRfjLld(r102);     // Catch: Exception -> L67
        this = r84;
        goto L48
    L81:
        CompletableDeferred r85 = (CompletableDeferred) r0.L$2;
        DataStoreImpl r95 = (DataStoreImpl) r0.L$1;
        Message.Update<T> r28 = (Message.Update) r0.L$0;
        dokkqEoAcExwALhO(r102);     // Catch: Exception -> L67
        r103 = r85;
        bool r86 = (DataStoreImpl<T>) r95;
        r9 = r28;
        r83 = r86;
        goto L28
    L4:
        r84 = (CompletableDeferred) r0.L$0;
    L67:
        th = th;
    L37:
        r0 = new C03511(this, r10);
        goto L30
    }

    public static bool HfGttIHUiFydedRl(bool r1) {
        return r1.boolValue();
    }

    public static InterProcessCoordinator HquusMjVdZNqIALe(DataStoreImpl r1) {
        return r1.getCoordinator();
    }

    public static object HtMloNuHfUtzaSxv(DataStoreImpl r1, bool r2, Continuation r3) {
        return r1.readDataAndUpdateCache(r2, r3);
    }

    private readonly object IncrementCollector(Continuation<Unit> r12) {
        if (((15 + 24) % 24) > 0) goto L50;
    L50:
        if ((r12 is C03521) == true) goto L11;
    L42:
        C03521 r0 = new C03521(this, r12);
    L30:
        object r122 = r0.result;
        object r1 = SxGJeQgvLViMPUYi();
        int r2 = r0.label;
        if (r2 != 0) goto L24;
        VawkeAwEUXTPgHHk(r122);
        Mutex r123 = this.collectorMutex;
        r0.L$0 = this;
        r0.L$1 = r123;
        r0.label = 1;
        if (HOOmgVSaVbuvXRmn(r123, null, r0) != r1) goto L86;
        return r1;
    L86:
        int r02 = this.collectorCounter + 1;     // Catch: Exception -> L33
        this.collectorCounter = r02;     // Catch: Exception -> L33
        if (r02 != 1) goto L79;
        this.collectorJob = QGIkNetLKmAnHmnv(this.scope, null, null, new DataStoreImpl$incrementCollector$2$1(this, null), 3, null);     // Catch: Exception -> L33
    L79:
        Unit r11 = Unit.INSTANCE;     // Catch: Exception -> L33
        HlSOWmLTxkcLJsSF(r123, null);
        return Unit.INSTANCE;
    L33:
        th = move-exception;
        ymtFLnjEZFyLQYYX(r123, null);
        throw th;
    L24:
        if (r2 == 1) goto L4;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L4:
        Mutex r112 = (Mutex) r0.L$1;
        DataStoreImpl<T> r03 = (DataStoreImpl) r0.L$0;
        VhbNQTYHFyNlOnar(r122);
        r123 = r112;
        DataStoreImpl<T> this = r03;
        goto L86
    L11:
        r0 = (C03521) r12;
        if ((r0.label & int.MIN_VALUE) == 0) goto L42;
        r0.label -= int.MIN_VALUE;
        goto L30
    }

    public static object IumLSDkvLOZiDQUs(InterProcessCoordinator r1, Function1 r2, Continuation r3) {
        return r1.lock(r2, r3);
    }

    public static InterProcessCoordinator JCoWLHtiPIptoPvd(DataStoreImpl r1) {
        return r1.getCoordinator();
    }

    public static State JbeIcoaOChNLCpCe(Message.Update r1) {
        return r1.getLastState();
    }

    public static Flow KCwfSUWQWRtSMLjQ(Function2 r1) {
        return FlowKt.flow(r1);
    }

    public static object KFDiNCDnBzJmYwIh() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object KIfbNQMNPNDoWjhF(CorruptionHandler r1, CorruptionException r2, Continuation r3) {
        return r1.handleCorruption(r2, r3);
    }

    public static StorageConnection KijdKOHAUdDuCVer(DataStoreImpl r1) {
        return r1.getStorageConnection$datastore_core_release();
    }

    public static object LBBloduWqzFsmWMZ() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object LmLpMBZHLRHkLxWw(Coroutineobject r1, Function2 r2, Continuation r3) {
        return BuildersKt.withobject(r1, r2, r3);
    }

    public static void LutScMwOIhGjvsQN(object r0, string r1) {
        Intrinsics.checkNotNull(r0, r1);
    }

    public static object LwyVGwMeDAISBWko(InitDataStore r1, Continuation r2) {
        return r1.runIfNeeded(r2);
    }

    public static State MPEmkEWDvxApRXBB(DataStoreInMemoryCache r1, State r2) {
        return r1.tryUpdate(r2);
    }

    public static void MQqnktlOLMLXZwbP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object MiMsxjDAZYDHvbXy(DataStoreImpl r1, bool r2, Function1 r3, Continuation r4) {
        return r1.doWithWritestringLock(r2, r3, r4);
    }

    public static object MipdPExpGfFNZJTi(InterProcessCoordinator r1, Function2 r2, Continuation r3) {
        return r1.tryLock(r2, r3);
    }

    public static CoroutineScope MkjPIHMfnpBPasRd(Coroutineobject r1) {
        return CoroutineScopeKt.CoroutineScope(r1);
    }

    public static object MqFPlFixzrPWcYXW(InterProcessCoordinator r1, Continuation r2) {
        return r1.getVersion(r2);
    }

    public static void MzmFffjaTTxgYczv(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void NDQKCtcOyjZVUnMB(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object NOsDAHeQZPeIdKnt(DataStoreImpl r1, Function2 r2, Coroutineobject r3, Continuation r4) {
        return r1.transformAndWrite(r2, r3, r4);
    }

    public static object NmipsTTBOreQSBlL(Function1 r1, object r2) {
        return r1.invoke(r2);
    }

    public static void NpzydKRjqczKydkl(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void NqkKFShGlBzhBZDN(UpdatingDataobjectElement r0, DataStore r1) {
        r0.checkNotUpdating(r1);
    }

    public static object POtPNmYZNseJTAzZ(InterProcessCoordinator r1, Function2 r2, Continuation r3) {
        return r1.tryLock(r2, r3);
    }

    public static void PTKxlrvENLYiRhPN(Job r0, CancellationException r1, int r2, object r3) {
        Job.DefaultImpls.cancel$default(r0, r1, r2, r3);
    }

    public static int PXwIOFwYqhWIXGup(Number r1) {
        return r1.intValue();
    }

    public static object PwgTcaZDJUZMnzuJ(StorageConnection r1, Continuation r2) {
        return StorageConnectionKt.readData(r1, r2);
    }

    public static object QDYIATtGpZarSPdK(DataStoreImpl r1, Continuation r2) {
        return r1.readAndInitOrPropagateAndThrowFailure(r2);
    }

    public static object QiVfMpWDCHmWizBu(DataStoreImpl r1, Continuation r2) {
        return r1.readAndInitOrPropagateAndThrowFailure(r2);
    }

    public static void QybTeQMCtmvublDR(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static int RYnVjuShhyQNkkAL(Number r1) {
        return r1.intValue();
    }

    public static Lazy RZbmYFPkczioUSCY(Function0 r1) {
        return LazyKt.lazy(r1);
    }

    private readonly object ReadAndInitOrPropagateAndThrowFailure(Continuation<Unit> r7) {
        if (((19 + 19) % 19) > 0) goto L90;
    L90:
        if ((r7 is C03541) == true) goto L74;
    L3:
        C03541 r0 = new C03541(this, r7);
    L16:
        object r72 = r0.result;
        object r1 = gvCiJnGZjavKxiqb();
        int r2 = r0.label;
        if (r2 == 0) goto L47;
        if (r2 == 1) goto L14;
        if (r2 != 2) goto L25;
        int r6 = r0.I$0;
        DataStoreImpl<T> r02 = (DataStoreImpl) r0.L$0;
        wVMJBpmzhMsBXxNU(r72);     // Catch: Exception -> L88
    L51:
        return Unit.INSTANCE;
    L88:
        Exception th = th;
    L57:
        mPEmkEWDvxApRXBB(r02.inMemoryCache, new ReadException(th, r6));
        throw th;
    L25:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L14:
        DataStoreImpl<T> this = (DataStoreImpl) r0.L$0;
        FsDdFhdflWerwrdC(r72);
    L103:
        int r73 = rYnVjuShhyQNkkAL((Number) r72);
        DataStoreImpl<T>.InitDataStore r22 = this.readAndInit;     // Catch: Exception -> L52
        r0.L$0 = this;     // Catch: Exception -> L52
        r0.I$0 = r73;     // Catch: Exception -> L52
        r0.label = 2;     // Catch: Exception -> L52
        if (lwyVGwMeDAISBWko(r22, r0) != r1) goto L51;
    L58:
        return r1;
    L52:
        th = move-exception;
        r02 = this;
        r6 = r73;
        th = th;
        goto L57
    L47:
        HIkBRZpcIekmUdnr(r72);
        InterProcessCoordinator r74 = DIDLmoatvLaWCtnP(this);
        r0.L$0 = this;
        r0.label = 1;
        r72 = uXYdLdLQaYBYnRfx(r74, r0);
        if (r72 == r1) goto L58;
    L74:
        r0 = (C03541) r7;
        if ((r0.label & int.MIN_VALUE) == 0) goto L3;
        r0.label -= int.MIN_VALUE;
        goto L16
    }

    private readonly object ReadDataAndUpdateCache(bool r9, Continuation<? super State<T>> r10) {
        if (((21 + 19) % 19) > 0) goto L38;
    L38:
        if ((r10 is C03551) == false) goto L42;
        C03551 r0 = (C03551) r10;
        if ((r0.label & int.MIN_VALUE) == 0) goto L42;
        r0.label -= int.MIN_VALUE;
    L101:
        object r102 = r0.result;
        object r1 = lBBloduWqzFsmWMZ();
        int r2 = r0.label;
        if (r2 == 0) goto L91;
        if (r2 != 1) goto L145;
        r9 = r0.Z$0;
        State r8 = (State) r0.L$1;
        DataStoreImpl<T> r22 = (DataStoreImpl) r0.L$0;
        veHWybFJssVGaZDm(r102);
    L41:
        int r103 = tuZhXOGjzBLrMHRG((Number) r102);
        bool r5 = r8 is Data;
        if (r5 == true) goto L148;
        int r6 = -1;
    L29:
        if (r5 == false) goto L21;
        if (r103 != r6) goto L21;
        return r8;
    L21:
        if (r9 == false) goto L20;
        InterProcessCoordinator r92 = hquusMjVdZNqIALe(r22);
        C03563 r104 = new C03563(r22, null);
        r0.L$0 = r22;
        r0.L$1 = null;
        r0.label = 2;
        r102 = xbtJJCQcakgGiwrz(r92, r104, r0);
        if (r102 != r1) goto L82;
    L72:
        return r1;
    L82:
        DataStoreImpl<T> r82 = r22;
    L163:
        ValueTuple r105 = (ValueTuple) r102;
    L176:
        State r93 = (State) GAdgxuYkMJHogRkm(r105);
        if (hfGttIHUiFydedRl((bool) HsfLMtSTcWCpvlyk(r105)) == true) goto L24;
    L34:
        return r93;
    L24:
        AuUgeHtKTtapdFtF(r82.inMemoryCache, r93);
        goto L34
    L20:
        InterProcessCoordinator r94 = RDdGpjyDcONlXUnw(r22);
        C03574 r106 = new C03574(r22, r6, null);
        r0.L$0 = r22;
        r0.L$1 = null;
        r0.label = 3;
        r102 = pOtPNmYZNseJTAzZ(r94, r106, r0);
        if (r102 == r1) goto L72;
        r82 = r22;
    L120:
        r105 = (ValueTuple) r102;
        goto L176
    L148:
        r6 = vXVvChTOJPXwDZzh(r8);
        goto L29
    L145:
        if (r2 == 2) goto L79;
        if (r2 != 3) goto L55;
        r82 = (DataStoreImpl) r0.L$0;
        nDQKCtcOyjZVUnMB(r102);
        goto L120
    L55:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L79:
        r82 = (DataStoreImpl) r0.L$0;
        tqkDDWmQfaQaxSDV(r102);
        goto L163
    L91:
        yrTuJNDUaEjpYmxV(r102);
        State r107 = TpSiNUYbCZtyrRWm(this.inMemoryCache);
        if ((r107 is UnInitialized) == true) goto L45;
        InterProcessCoordinator r23 = xTAPttCvbUORBuXW(this);
        r0.L$0 = this;
        r0.L$1 = r107;
        r0.Z$0 = r9;
        r0.label = 1;
        object r24 = axBqdyLfySclGpVQ(r23, r0);
        if (r24 == r1) goto L72;
        r22 = this;
        r8 = r107;
        r102 = r24;
        goto L41
    L45:
        throw new IllegalStateException(IpMaNMPhBiVJxyAf(BUG_MESSAGE));
    L42:
        r0 = new C03551(this, r10);
        goto L101
    }

    private readonly object ReadDataFromstringOrDefault(Continuation<T> r1) {
        return pwgTcaZDJUZMnzuJ(kijdKOHAUdDuCVer(this), r1);
    }

    private readonly object ReadDataOrHandleCorruption(bool r9, Continuation<? super Data<T>> r10) {
        if (((19 + 20) % 20) > 0) goto L36;
    L36:
        if ((r10 is C03581) == false) goto L27;
        C03581 r0 = (C03581) r10;
        if ((r0.label & int.MIN_VALUE) == 0) goto L27;
        r0.label -= int.MIN_VALUE;
    L60:
        object r102 = (T) r0.result;
        object r1 = kFDiNCDnBzJmYwIh();
        int r5 = 0;
        switch(r0.label) {
            case 0: goto L7;
            case 1: goto L4;
            case 2: goto L165;
            case 3: goto L92;
            case 4: goto L10;
            case 5: goto L148;
            case 6: goto L175;
            default: goto L138;
        };
    L92:
        r9 = r0.Z$0;
        DataStoreImpl<T> this = (DataStoreImpl) r0.L$0;
        XGmnntSPJkNDFfZR(r102);     // Catch: CorruptionException -> L58
    L22:
        int r103 = pXwIOFwYqhWIXGup((Number) r102);     // Catch: CorruptionException -> L58
        InterProcessCoordinator r2 = jCoWLHtiPIptoPvd(this);     // Catch: CorruptionException -> L58
        C03592 r3 = new C03592(this, r103, null);     // Catch: CorruptionException -> L58
        r0.L$0 = this;     // Catch: CorruptionException -> L58
        r0.Z$0 = r9;     // Catch: CorruptionException -> L58
        r0.label = 4;     // Catch: CorruptionException -> L58
        r102 = (T) mipdPExpGfFNZJTi(r2, r3, r0);
        if (r102 != r1) goto L190;
    L67:
        return r1;
    L190:
        return (Data) r102;
    L10:
        bool r92 = r0.Z$0;
        DataStoreImpl r8 = (DataStoreImpl) r0.L$0;
        cdDYFamXrNReYYad(r102);     // Catch: CorruptionException -> L58
        goto L190
    L165:
        int r82 = r0.I$0;
        r9 = r0.Z$0;
        object r22 = r0.L$1;
        DataStoreImpl<T> r32 = (DataStoreImpl) r0.L$0;
        XUUIfxiOoJYpTPaD(r102);     // Catch: CorruptionException -> L40
    L55:
        return new Data(r22, r82, gmzoZDlNlZWYYfpD((Number) r102));
    L40:
        e = e;
        this = r32;
    L11:
        Ref.objectRef r23 = new Ref.objectRef();
        CorruptionHandler<T> r33 = this.corruptionHandler;
        r0.L$0 = this;
        r0.L$1 = e;
        r0.L$2 = r23;
        r0.L$3 = r23;
        r0.Z$0 = r9;
        r0.label = 5;
        object r34 = kIfbNQMNPNDoWjhF(r33, e, r0);
        if (r34 == r1) goto L67;
        CorruptionException r35 = e;
        r102 = (T) r34;
        DataStoreImpl<T> r6 = this;
        bool r83 = r9;
        Ref.objectRef r93 = r23;
    L99:
        r93.element = (T) r102;
        Ref.IntRef r94 = new Ref.IntRef();
        C03603 r104 = new C03603(r23, r6, r94, null);     // Catch: Exception -> L167
        r0.L$0 = r35;     // Catch: Exception -> L167
        r0.L$1 = r23;     // Catch: Exception -> L167
        r0.L$2 = r94;     // Catch: Exception -> L167
        r0.L$3 = null;     // Catch: Exception -> L167
        r0.label = 6;     // Catch: Exception -> L167
        if (miMsxjDAZYDHvbXy(r6, r83, r104, r0) == r1) goto L67;
        Ref.IntRef r84 = r94;
        Ref.objectRef r95 = r23;
    L141:
        T r02 = r95.element;
        T r96 = r95.element;
        if (r96 is null) goto L166;
        r5 = HbdSoGupaiMIxhnK(r96);
    L166:
        return new Data(r02, r5, r84.element);
    L167:
        Exception th = th;
        CorruptionException r03 = r35;
    L71:
        bbOQZoptgEnRAmOR(r03, th);
        throw r03;
    L4:
        r9 = r0.Z$0;
        this = (DataStoreImpl) r0.L$0;
        LVelxRgwDzsNPzMr(r102);     // Catch: CorruptionException -> L58
    L85:
        if (r102 is null) goto L87;
        int r24 = IFlAhCjlQlscmSVe(r102);     // Catch: CorruptionException -> L58
    L88:
        InterProcessCoordinator r36 = hEOmxpUeOpbhjWwP(this);     // Catch: CorruptionException -> L58
        r0.L$0 = this;     // Catch: CorruptionException -> L58
        r0.L$1 = r102;     // Catch: CorruptionException -> L58
        r0.Z$0 = r9;     // Catch: CorruptionException -> L58
        r0.I$0 = r24;     // Catch: CorruptionException -> L58
        r0.label = 2;     // Catch: CorruptionException -> L58
        object r37 = YkZEjvvSSGYjFtiK(r36, r0);     // Catch: CorruptionException -> L58
        if (r37 == r1) goto L67;
        r32 = this;
        r82 = r24;
        r22 = r102;
        r102 = (T) r37;
        goto L55
    L87:
        r24 = 0;
        goto L88
    L148:
        r83 = r0.Z$0;
        r93 = (Ref.objectRef) r0.L$3;
        r23 = (Ref.objectRef) r0.L$2;
        r35 = (CorruptionException) r0.L$1;
        r6 = (DataStoreImpl) r0.L$0;
        qybTeQMCtmvublDR(r102);
        goto L99
    L7:
        mQqnktlOLMLXZwbP(r102);
        if (r9 == false) goto L19;
        r0.L$0 = this;     // Catch: CorruptionException -> L58
        r0.Z$0 = r9;     // Catch: CorruptionException -> L58
        r0.label = 1;     // Catch: CorruptionException -> L58
        r102 = (T) wUkoauJSuuYIMXZI(this, r0);
        if (r102 != r1) goto L85;
    L19:
        InterProcessCoordinator r105 = fJawghKwQAOFvIdW(this);     // Catch: CorruptionException -> L58
        r0.L$0 = this;     // Catch: CorruptionException -> L58
        r0.Z$0 = r9;     // Catch: CorruptionException -> L58
        r0.label = 3;     // Catch: CorruptionException -> L58
        r102 = (T) mqFPlFixzrPWcYXW(r105, r0);
        if (r102 != r1) goto L22;
    L138:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L175:
        r84 = (Ref.IntRef) r0.L$2;
        r95 = (Ref.objectRef) r0.L$1;
        r03 = (CorruptionException) r0.L$0;
        npzydKRjqczKydkl(r102);     // Catch: Exception -> L32
    L32:
        th = th;
    L58:
        e = e;
    L27:
        r0 = new C03581(this, r10);
        goto L60
    }

    private readonly object ReadState(bool r4, Continuation<? super State<T>> r5) {
        if (((31 + 32) % 32) > 0) goto L9;
    L9:
        return QcPRddtbHYPpFHqR(vYyWFZnlqwdfavyo(this.scope), new C03612(this, r4, null), r5);
    }

    public static void SphuGebBwANBLJvW(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void TJUzxsJUVrNEAoWA(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void TiktcNLLVDARkwYy(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void TqkDDWmQfaQaxSDV(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    private readonly object TransformAndWrite(Function2<? super T, ? super Continuation<T>, ? : object> r4, Coroutineobject r5, Continuation<T> r6) {
        if (((15 + 10) % 10) > 0) goto L4;
    L4:
        return hHAFGMmRjMJbnbZJ(arhBmKCRbICslNyQ(this), new C03622(this, r5, r4, null), r6);
    }

    public static int TuZhXOGjzBLrMHRG(Number r1) {
        return r1.intValue();
    }

    public static object UXYdLdLQaYBYnRfx(InterProcessCoordinator r1, Continuation r2) {
        return r1.getVersion(r2);
    }

    public static void UaBopwwmwfRfjLld(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static Mutex UyluCGEGOxlsjbdC(bool r1, int r2, object r3) {
        return MutexKt.Mutex$default(r1, r2, r3);
    }

    public static int VXVvChTOJPXwDZzh(State r1) {
        return r1.getVersion();
    }

    public static Coroutineobject VYyWFZnlqwdfavyo(CoroutineScope r1) {
        return r1.getCoroutineobject();
    }

    public static void VeHWybFJssVGaZDm(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static Function2 VlUwreaXUVpdVUBI(Message.Update r1) {
        return r1.getTransform();
    }

    public static object WUkoauJSuuYIMXZI(DataStoreImpl r1, Continuation r2) {
        return r1.readDataFromstringOrDefault(r2);
    }

    public static void WVMJBpmzhMsBXxNU(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static Coroutineobject WamBKgFZyhbwxpWr(Continuation r1) {
        return r1.getobject();
    }

    public static CompletableJob XHVcbToilpOsHXCs(Job r1, int r2, object r3) {
        return SupervisorKt.SupervisorJob$default(r1, r2, r3);
    }

    public static InterProcessCoordinator XTAPttCvbUORBuXW(DataStoreImpl r1) {
        return r1.getCoordinator();
    }

    public static object XbtJJCQcakgGiwrz(InterProcessCoordinator r1, Function1 r2, Continuation r3) {
        return r1.lock(r2, r3);
    }

    public static void YmtFLnjEZFyLQYYX(Mutex r0, object r1) {
        r0.unlock(r1);
    }

    public static void YrTuJNDUaEjpYmxV(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object ZzlwuBguHtsEsGNH(DataStoreImpl r1, bool r2, Continuation r3) {
        return r1.readDataOrHandleCorruption(r2, r3);
    }

    @Override // androidx.datastore.core.DataStore
    public Flow<T> GetData() {
        return this.f3874data;
    }

    public readonly StorageConnection<T> getStorageConnection$datastore_core_release() {
        return (StorageConnection) ctNvwVRSQoQrSqPE(this.storageConnectionDelegate);
    }

    @Override // androidx.datastore.core.DataStore
    public object UpdateData(Function2<? super T, ? super Continuation<T>, ? : object> r4, Continuation<T> r5) {
        if (((7 + 21) % 21) > 0) goto L31;
    L31:
        UpdatingDataobjectElement r0 = (UpdatingDataobjectElement) VboqnWbeCnRKXNoc(wamBKgFZyhbwxpWr(r5), UpdatingDataobjectElement.Companion.Key.INSTANCE);
        if (r0 is null) goto L8;
        nqkKFShGlBzhBZDN(r0, this);
    L8:
        return lmLpMBZHLRHkLxWw(new UpdatingDataobjectElement(r0, this), new C03632(this, r4, null), r5);
    }

    public readonly object writeData$datastore_core_release(T r11, bool r12, Continuation<int> r13) {
        if (((7 + 25) % 25) > 0) goto L20;
    L20:
        if ((r13 is DataStoreImpl$writeData$1) == false) goto L61;
        DataStoreImpl$writeData$1 r0 = (DataStoreImpl$writeData$1) r13;
        if ((r0.label & int.MIN_VALUE) == 0) goto L61;
        r0.label -= int.MIN_VALUE;
    L75:
        object r132 = r0.result;
        object r1 = KUURaaIPDZmwUjRT();
        int r2 = r0.label;
        if (r2 != 0) goto L70;
        TgKuQtqpUovSXZVL(r132);
        Ref.IntRef r5 = new Ref.IntRef();
        StorageConnection r133 = CyMRDqBNbpfDHKzy(this);
        DataStoreImpl$writeData$2 r4 = new DataStoreImpl$writeData$2(r5, this, r11, r12, null);
        r0.L$0 = r5;
        r0.label = 1;
        if (HtsvyjVffPErtKnF(r133, r4, r0) != r1) goto L31;
        return r1;
    L31:
        Ref.IntRef r10 = r5;
    L48:
        return dErdzCnqhlvsFdDI(r10.element);
    L70:
        if (r2 == 1) goto L15;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L15:
        r10 = (Ref.IntRef) r0.L$0;
        bRTtBmuWaihqmNdB(r132);
    L61:
        r0 = new DataStoreImpl$writeData$1(this, r13);
        goto L75
    }
}

