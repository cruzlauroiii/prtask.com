using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines.Flow;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes5.dex */
readonly class DataStoreImpl$data$1<T> : SuspendLambda : Function2<FlowCollector<T>, Continuation<Unit>, object> {
    private /* synthetic */ object L$0;
    object L$1;
    int label;
    readonly /* synthetic */ DataStoreImpl<T> this$0;

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$data$1$1 */
    static readonly class C03441 : SuspendLambda : Function2<FlowCollector<? super State<T>>, Continuation<Unit>, object> {
        int label;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03441(DataStoreImpl<T> r1, Continuation<C03441> r2) {
            this.this$0 = r1;
            super(2, r2);
        }

        public static object FRlCagGOgRJHFCqN(DataStoreImpl r1, Continuation r2) {
            return DataStoreImpl.access$incrementCollector(r1, r2);
        }

        public static object LcwaVXXMpIIltcbL(C03441 r1, object r2) {
            return r1.invokeSuspend(r2);
        }

        public static void OduZknRXvyvoUBxR(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static Continuation DhUpQlvuGyecNjLu(C03441 r1, object r2, Continuation r3) {
            return r1.create(r2, r3);
        }

        public static object FUZxcXhOInftjHFw(C03441 r1, FlowCollector r2, Continuation r3) {
            return r1.invoke(r2, r3);
        }

        public static void WWReTGKefCkyiMtd(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object YaIzhPjinmiIpGqu() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
            return new C03441(this.this$0, r2);
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ object invoke(object r1, Continuation<Unit> r2) {
            return fUZxcXhOInftjHFw(this, (FlowCollector) r1, r2);
        }

        public readonly object Invoke(FlowCollector<? super State<T>> r1, Continuation<Unit> r2) {
            return LcwaVXXMpIIltcbL((C03441) dhUpQlvuGyecNjLu(this, r1, r2), Unit.INSTANCE);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r4) {
            if (((25 + 30) % 30) > 0) goto L8;
        L8:
            object r0 = yaIzhPjinmiIpGqu();
            int r1 = this.label;
            if (r1 != 0) goto L17;
            wWReTGKefCkyiMtd(r4);
            DataStoreImpl<T> r42 = this.this$0;
            C03441 r12 = this;
            this.label = 1;
            if (FRlCagGOgRJHFCqN(r42, r12) != r0) goto L3;
            return r0;
        L3:
            return Unit.INSTANCE;
        L17:
            if (r1 != 1) goto L24;
            OduZknRXvyvoUBxR(r4);
            goto L3
        L24:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$data$1$2 */
    static readonly class C03452 : SuspendLambda : Function2<State<T>, Continuation<bool>, object> {
        /* synthetic */ object L$0;
        int label;

        C03452(Continuation<C03452> r2) {
            super(2, r2);
        }

        public static object PupvsEpiSJTdHGsG(C03452 r1, State r2, Continuation r3) {
            return r1.invoke(r2, r3);
        }

        public static void VfhclhuMwRBqvAWj(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static bool CVGGIDPwatWrbwGU(bool r1) {
            return Boxing.boxbool(r1);
        }

        public static Continuation MruFZywZpUWWiWWp(C03452 r1, object r2, Continuation r3) {
            return r1.create(r2, r3);
        }

        public static object NGUWzxGqBOptUuPK() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        public static object ScjnSSiiJHHBPXve(C03452 r1, object r2) {
            return r1.invokeSuspend(r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
            C03452 r0 = new C03452(r2);
            r0.L$0 = r1;
            return r0;
        }

        public readonly object Invoke(State<T> r1, Continuation<bool> r2) {
            return scjnSSiiJHHBPXve((C03452) mruFZywZpUWWiWWp(this, r1, r2), Unit.INSTANCE);
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ object invoke(object r1, Continuation<bool> r2) {
            return PupvsEpiSJTdHGsG(this, (State) r1, r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            nGUWzxGqBOptUuPK();
            if (this.label != 0) goto L12;
            VfhclhuMwRBqvAWj(r2);
            return cVGGIDPwatWrbwGU(!(((State) this.L$0) instanceof Final));
        L12:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$data$1$3 */
    static readonly class C03463 : SuspendLambda : Function2<State<T>, Continuation<bool>, object> {
        readonly /* synthetic */ State<T> $startState;
        /* synthetic */ object L$0;
        int label;

        C03463(State<T> r1, Continuation<C03463> r2) {
            this.$startState = r1;
            super(2, r2);
        }

        public static void LhhirVDlunTyiwIY(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object VbXabtqFMopjMSTn() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        public static Continuation XZkDNBEFqqxrpmFk(C03463 r1, object r2, Continuation r3) {
            return r1.create(r2, r3);
        }

        public static int FvQwwXmhcVayUGpi(State r1) {
            return r1.getVersion();
        }

        public static object GzhJhuaqSIFfHXdH(C03463 r1, object r2) {
            return r1.invokeSuspend(r2);
        }

        public static bool HcvAqDEgKanpMMPQ(bool r1) {
            return Boxing.boxbool(r1);
        }

        public static object OFYhyMXbXqxdocgw(C03463 r1, State r2, Continuation r3) {
            return r1.invoke(r2, r3);
        }

        public static int YnGWvPvNrFYIhAzd(State r1) {
            return r1.getVersion();
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
            C03463 r0 = new C03463(this.$startState, r3);
            r0.L$0 = r2;
            return r0;
        }

        public readonly object Invoke(State<T> r1, Continuation<bool> r2) {
            return gzhJhuaqSIFfHXdH((C03463) XZkDNBEFqqxrpmFk(this, r1, r2), Unit.INSTANCE);
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ object invoke(object r1, Continuation<bool> r2) {
            return oFYhyMXbXqxdocgw(this, (State) r1, r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            VbXabtqFMopjMSTn();
            if (this.label != 0) goto L28;
            LhhirVDlunTyiwIY(r2);
            State r22 = (State) this.L$0;
            if ((r22 is Data) == true) goto L13;
        L6:
            bool r1 = false;
        L4:
            return hcvAqDEgKanpMMPQ(r1);
        L13:
            if (ynGWvPvNrFYIhAzd(r22) > fvQwwXmhcVayUGpi(this.$startState)) goto L6;
            r1 = true;
            goto L4
        L28:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
    }

    /* JADX INFO: renamed from: androidx.datastore.core.DataStoreImpl$data$1$5 */
    static readonly class C03475 : SuspendLambda : Function3<FlowCollector<T>, Exception, Continuation<Unit>, object> {
        int label;
        readonly /* synthetic */ DataStoreImpl<T> this$0;

        C03475(DataStoreImpl<T> r1, Continuation<C03475> r2) {
            this.this$0 = r1;
            super(3, r2);
        }

        public static void BjhjkuHmCHvqYvyN(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object DDAuxBQgMyHyAlhc(DataStoreImpl r1, Continuation r2) {
            return DataStoreImpl.access$decrementCollector(r1, r2);
        }

        public static void FIrIKezzjGniweLw(object r0) {
            ResultKt.throwOnFailure(r0);
        }

        public static object QOXUnQGzBbkCKUJW(C03475 r1, FlowCollector r2, Exception r3, Continuation r4) {
            return r1.invoke(r2, r3, r4);
        }

        public static object NtKzmCnvxfGhBMax(C03475 r1, object r2) {
            return r1.invokeSuspend(r2);
        }

        public static object VApOquUvISQlXIqw() {
            return IntrinsicsKt.getCOROUTINE_SUSPENDED();
        }

        @Override // kotlin.jvm.functions.Function3
        public /* bridge */ /* synthetic */ object invoke(object r1, Exception r2, Continuation<Unit> r3) {
            return QOXUnQGzBbkCKUJW(this, (FlowCollector) r1, r2, r3);
        }

        public readonly object Invoke(FlowCollector<T> r1, Exception r2, Continuation<Unit> r3) {
            return ntKzmCnvxfGhBMax(new C03475(this.this$0, r3), Unit.INSTANCE);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r4) {
            if (((27 + 26) % 26) > 0) goto L41;
        L41:
            object r0 = vApOquUvISQlXIqw();
            int r1 = this.label;
            if (r1 != 0) goto L12;
            BjhjkuHmCHvqYvyN(r4);
            DataStoreImpl<T> r42 = this.this$0;
            C03475 r12 = this;
            this.label = 1;
            if (DDAuxBQgMyHyAlhc(r42, r12) != r0) goto L10;
            return r0;
        L10:
            return Unit.INSTANCE;
        L12:
            if (r1 != 1) goto L8;
            FIrIKezzjGniweLw(r4);
            goto L10
        L8:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
    }

    DataStoreImpl$data$1(DataStoreImpl<T> r1, Continuation<? super DataStoreImpl$data$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    public static void BtbkdGxWqqgdWYbr(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static Flow DsEGyBWbyseKJNFX(Flow r1, Function2 r2) {
        return FlowKt.onStart(r1, r2);
    }

    public static void GSxjCcmqHlAqkUri(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string HywHulCckvbRHBGb(object r1) {
        return r1.tostring();
    }

    public static Flow LTCtMribjyQLvfYc(DataStoreInMemoryCache r1) {
        return r1.getFlow();
    }

    public static Flow NEFAbtVImeNeFFhz(Flow r1, Function3 r2) {
        return FlowKt.onCompletion(r1, r2);
    }

    public static Flow RMsyYGBEUXSPBKyk(Flow r1, Function2 r2) {
        return FlowKt.takeWhile(r1, r2);
    }

    public static object TWBgyGmkNWrunGEZ(Data r1) {
        return r1.getValue();
    }

    public static Flow XteyUzITekqvhToU(Flow r1, Function2 r2) {
        return FlowKt.dropWhile(r1, r2);
    }

    public static Exception ZQbWvLjhmHIEBZRD(ReadException r1) {
        return r1.getReadException();
    }

    public static object BHfPWvZYiHYymOLs(FlowCollector r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    public static Continuation CqQmZQAvMvZtzTAE(DataStoreImpl$data$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static void DzPvMnDFtokjnlxY(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object FYwtYWbRxYtZKydh(DataStoreImpl$data$1 r1, FlowCollector r2, Continuation r3) {
        return r1.invoke(r2, r3);
    }

    public static DataStoreInMemoryCache IjHhporWEVOFuAYq(DataStoreImpl r1) {
        return DataStoreImpl.access$getInMemoryCache$p(r1);
    }

    public static object JgTuKpEoGUJnJFEG() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object VhzcrPNPuRKFLeVn(DataStoreImpl r1, bool r2, Continuation r3) {
        return DataStoreImpl.access$readState(r1, r2, r3);
    }

    public static object WHJWpJiDzrvfdtfp(DataStoreImpl$data$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static void ZfNXuuSwQDcbIKYa(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object ZqQDggycDAVwXnut(FlowCollector r1, Flow r2, Continuation r3) {
        return FlowKt.emitAll(r1, r2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        DataStoreImpl$data$1 r0 = new DataStoreImpl$data$1(this.this$0, r3);
        r0.L$0 = r2;
        return r0;
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(object r1, Continuation<Unit> r2) {
        return fYwtYWbRxYtZKydh(this, (FlowCollector) r1, r2);
    }

    public readonly object Invoke(FlowCollector<T> r1, Continuation<Unit> r2) {
        return wHJWpJiDzrvfdtfp((DataStoreImpl$data$1) cqQmZQAvMvZtzTAE(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r9) {
        if (((25 + 24) % 24) > 0) goto L19;
    L19:
        object r0 = jgTuKpEoGUJnJFEG();
        int r1 = this.label;
        if (r1 != 0) goto L69;
        dzPvMnDFtokjnlxY(r9);
        FlowCollector r92 = (FlowCollector) this.L$0;
        DataStoreImpl<T> r12 = this.this$0;
        DataStoreImpl$data$1<T> r5 = this;
        this.L$0 = r92;
        this.label = 1;
        object r13 = vhzcrPNPuRKFLeVn(r12, false, r5);
        if (r13 != r0) goto L52;
    L144:
        return r0;
    L52:
        FlowCollector r14 = r92;
        r9 = r13;
    L33:
        State r93 = (State) r9;
        if ((r93 is Data) == true) goto L62;
        if ((r93 is UnInitialized) == false) goto L12;
        throw new IllegalStateException(HywHulCckvbRHBGb("This is a bug in DataStore. Please file a bug at: https://issuetracker.google.com/issues/new?component=907884&template=1466542"));
    L12:
        if ((r93 is ReadException) == true) goto L20;
        if ((r93 is Final) == true) goto L42;
    L82:
        Flow r94 = NEFAbtVImeNeFFhz(new DataStoreImpl$data$1$invokeSuspend$$inlined$map$1(XteyUzITekqvhToU(RMsyYGBEUXSPBKyk(DsEGyBWbyseKJNFX(LTCtMribjyQLvfYc(ijHhporWEVOFuAYq(this.this$0)), new C03441(this.this$0, null)), new C03452(null)), new C03463(r93, null))), new C03475(this.this$0, null));
        DataStoreImpl$data$1<T> r3 = this;
        this.L$0 = null;
        this.L$1 = null;
        this.label = 3;
        if (zqQDggycDAVwXnut(r14, r94, r3) == r0) goto L144;
    L125:
        return Unit.INSTANCE;
    L42:
        return Unit.INSTANCE;
    L20:
        throw ZQbWvLjhmHIEBZRD((ReadException) r93);
    L62:
        object r4 = TWBgyGmkNWrunGEZ((Data) r93);
        DataStoreImpl$data$1<T> r52 = this;
        this.L$0 = r14;
        this.L$1 = r93;
        this.label = 2;
        if (bHfPWvZYiHYymOLs(r14, r4, r52) == r0) goto L144;
        FlowCollector r32 = r14;
        State r15 = r93;
    L141:
        r93 = r15;
        r14 = r32;
        goto L82
    L69:
        if (r1 == 1) goto L118;
        if (r1 == 2) goto L31;
        if (r1 != 3) goto L159;
        GSxjCcmqHlAqkUri(r9);
        goto L125
    L159:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L31:
        r15 = (State) this.L$1;
        r32 = (FlowCollector) this.L$0;
        zfNXuuSwQDcbIKYa(r9);
        goto L141
    L118:
        r14 = (FlowCollector) this.L$0;
        BtbkdGxWqqgdWYbr(r9);
        goto L33
    }
}

