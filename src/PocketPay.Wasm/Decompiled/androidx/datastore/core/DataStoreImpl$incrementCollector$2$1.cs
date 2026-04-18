using Androidx.Datastore.Core;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes5.dex */
readonly class DataStoreImpl$incrementCollector$2$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int label;
    readonly /* synthetic */ DataStoreImpl<T> this$0;

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$incrementCollector$2$1$1 */
    static readonly class C03531<T> : FlowCollector {
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03531(DataStoreImpl<T> r1) {
            this.this$0 = r1;
        }

        public static State BxjWBMKRplWluLdt(DataStoreInMemoryCache r1) {
            return r1.getCurrentState();
        }

        public static object HdDsSroFusgejUAu(DataStoreImpl r1, bool r2, Continuation r3) {
            return DataStoreImpl.access$readDataAndUpdateCache(r1, r2, r3);
        }

        public static object OdZhpExFelPJprNV(C03531 r1, Unit r2, Continuation r3) {
            return r1.emit(r2, r3);
        }

        public static DataStoreInMemoryCache JkVDVMMNYqgohabH(DataStoreImpl r1) {
            return DataStoreImpl.access$getInMemoryCache$p(r1);
        }

        public static object KyBqrSJfugZFIrNy() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        @Override // kotlinx.coroutines.flow.FlowCollector
        public /* bridge */ /* synthetic */ object emit(object r1, Continuation r2) {
            return OdZhpExFelPJprNV(this, (Unit) r1, r2);
        }

        public readonly object Emit(Unit r1, Continuation<Unit> r2) {
            if ((BxjWBMKRplWluLdt(jkVDVMMNYqgohabH(this.this$0)) instanceof Final) == true) goto L4;
            object r0 = HdDsSroFusgejUAu(this.this$0, true, r2);
            if (r0 != kyBqrSJfugZFIrNy()) goto L25;
            return r0;
        L25:
            return Unit.INSTANCE;
        L4:
            return Unit.INSTANCE;
        }
    }

    DataStoreImpl$incrementCollector$2$1(DataStoreImpl<T> r1, Continuation<? super DataStoreImpl$incrementCollector$2$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    public static void CokhihogqHmVgRxe(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static Continuation ETqnYtmjqJOtTcnO(DataStoreImpl$incrementCollector$2$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static void QEovWByQlZGCcqXT(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void QKbuwwPMsFcMvqEw(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object VyMpLtXmyfLOjeOA(DataStoreImpl$incrementCollector$2$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static Flow WgwyhsLpWyHqWEYb(Flow r1) {
        return FlowKt.conflate(r1);
    }

    public static Flow XziPiPSVOWWORhMQ(InterProcessCoordinator r1) {
        return r1.getUpdateNotifications();
    }

    public static DataStoreImpl.InitDataStore GShyGdeBHRrdRSCx(DataStoreImpl r1) {
        return DataStoreImpl.access$getReadAndInit$p(r1);
    }

    public static InterProcessCoordinator LyqpBWuAQWVUAGOd(DataStoreImpl r1) {
        return DataStoreImpl.access$getCoordinator(r1);
    }

    public static object OLqVTZfimPUKiMwP(DataStoreImpl.InitDataStore r1, Continuation r2) {
        return r1.awaitComplete(r2);
    }

    public static object QTiBuBjTIXRaeDIe() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object SsDsgsXEuxuXzvIG(DataStoreImpl$incrementCollector$2$1 r1, CoroutineScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static object TmctnlQehKHqZQuI(Flow r1, FlowCollector r2, Continuation r3) {
        return r1.collect(r2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new DataStoreImpl$incrementCollector$2$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return ssDsgsXEuxuXzvIG(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return VyMpLtXmyfLOjeOA((DataStoreImpl$incrementCollector$2$1) ETqnYtmjqJOtTcnO(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((18 + 16) % 16) > 0) goto L9;
    L9:
        object r0 = qTiBuBjTIXRaeDIe();
        int r1 = this.label;
        if (r1 != 0) goto L4;
        QEovWByQlZGCcqXT(r5);
        DataStoreImpl.InitDataStore r52 = gShyGdeBHRrdRSCx(this.this$0);
        DataStoreImpl$incrementCollector$2$1 r12 = this;
        this.label = 1;
        if (oLqVTZfimPUKiMwP(r52, r12) != r0) goto L44;
    L49:
        return r0;
    L44:
        Flow r53 = WgwyhsLpWyHqWEYb(XziPiPSVOWWORhMQ(lyqpBWuAQWVUAGOd(this.this$0)));
        C03531 r13 = new C03531(this.this$0);
        DataStoreImpl$incrementCollector$2$1 r3 = this;
        this.label = 2;
        if (tmctnlQehKHqZQuI(r53, r13, r3) == r0) goto L49;
    L52:
        return Unit.INSTANCE;
    L4:
        if (r1 == 1) goto L16;
        if (r1 != 2) goto L64;
        QKbuwwPMsFcMvqEw(r5);
        goto L52
    L64:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L16:
        CokhihogqHmVgRxe(r5);
        goto L44
    }
}

