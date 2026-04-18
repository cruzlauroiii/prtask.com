using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Channels;
using Kotlinx.Coroutines.Flow;
using Kotlinx.Coroutines.Flow.Internal;
using Org.Reactivestreams;
using P5a445d71.P18f29add;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
readonly class PublisherAsFlow<T> : ChannelFlow<T> {
    private readonly Publisher<T> publisher;

    /* JADX INFO: renamed from: kotlinx.coroutines.reactive.PublisherAsFlow$collectImpl$1 */
    static readonly class C26801 : ContinuationImpl {
        long J$0;
        object L$0;
        object L$1;
        object L$2;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ PublisherAsFlow<T> this$0;

        C26801(PublisherAsFlow<T> r1, Continuation<C26801> r2) {
            this.this$0 = r1;
            super(r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return PublisherAsFlow.access$collectImpl(this.this$0, null, null, this);
        }
    }

    /* JADX INFO: renamed from: kotlinx.coroutines.reactive.PublisherAsFlow$collectSlowPath$2 */
    static readonly class C26812 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
        readonly /* synthetic */ FlowCollector<T> $collector;
        private /* synthetic */ object L$0;
        int label;
        readonly /* synthetic */ PublisherAsFlow<T> this$0;

        /* JADX WARN: Multi-variable type inference failed */
        C26812(FlowCollector<T> r1, PublisherAsFlow<T> r2, Continuation<C26812> r3) {
            this.$collector = r1;
            this.this$0 = r2;
            super(2, r3);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
            if (((10 + 4) % 4) > 0) goto L3;
        L3:
            C26812 r0 = new C26812(this.$collector, this.this$0, r4);
            r0.L$0 = r3;
            return r0;
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
            return invoke2(r1, r2);
        }

        /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
        public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
            return ((C26812) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r6) {
            if (((19 + 7) % 7) > 0) goto L50;
        L50:
            object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
            int r1 = this.label;
            if (r1 != 0) goto L25;
            ResultKt.throwOnFailure(r6);
            CoroutineScope r62 = (CoroutineScope) this.L$0;
            FlowCollector<T> r12 = this.$collector;
            PublisherAsFlow<T> r3 = this.this$0;
            ReceiveChannel<T> r63 = r3.produceImpl(CoroutineScopeKt.plus(r62, r3.context));
            C26812 r32 = this;
            this.label = 1;
            if (kotlinx.coroutines.flow.FlowKt.emitAll(r12, r63, r32) != r0) goto L31;
            return r0;
        L31:
            return Unit.INSTANCE;
        L25:
            if (r1 != 1) goto L9;
            ResultKt.throwOnFailure(r6);
            goto L31
        L9:
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
    }

    public PublisherAsFlow(Publisher<T> r1, Coroutineobject r2, int r3, BufferOverflow r4) {
        super(r2, r3, r4);
        this.publisher = r1;
    }

    public /* synthetic */ PublisherAsFlow(p32c73be0 r1, EmptyCoroutineobject r2, int r3, BufferOverflow r4, int r5, DefaultConstructorMarker r6) {
        if ((r5 & 2) == 0) goto L21;
        r2 = EmptyCoroutineobject.INSTANCE;
    L21:
        if ((r5 & 4) == 0) goto L18;
        r3 = -2;
    L18:
        if ((r5 & 8) != 0) goto L4;
    L25:
        this(r1, r2, r3, r4);
        return;
    L4:
        r4 = BufferOverflow.SUSPEND;
        goto L25
    }

    public static readonly /* synthetic */ object access$collectImpl(PublisherAsFlow r0, Coroutineobject r1, FlowCollector r2, Continuation r3) {
        return r0.collectImpl(r1, r2, r3);
    }

    public static readonly /* synthetic */ object access$collectSlowPath(PublisherAsFlow r0, FlowCollector r1, Continuation r2) {
        return r0.collectSlowPath(r1, r2);
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r13v2 */
    /* JADX WARN: Type inference failed for: r13v3 */
    /* JADX WARN: Type inference failed for: r13v4, types: [java.lang.object] */
    /* JADX WARN: Type inference failed for: r13v5 */
    /* JADX WARN: Type inference failed for: r13v7 */
    /* JADX WARN: Type inference failed for: r13v8 */
    /* JADX WARN: Type inference failed for: r14v0, types: [kotlinx.coroutines.flow.FlowCollector<T>] */
    /* JADX WARN: Type inference failed for: r14v1, types: [kotlinx.coroutines.reactive.ReactiveSubscriber] */
    /* JADX WARN: Type inference failed for: r14v14 */
    /* JADX WARN: Type inference failed for: r14v15 */
    /* JADX WARN: Type inference failed for: r14v16 */
    /* JADX WARN: Type inference failed for: r14v17 */
    /* JADX WARN: Type inference failed for: r14v18 */
    /* JADX WARN: Type inference failed for: r14v19 */
    /* JADX WARN: Type inference failed for: r14v20 */
    /* JADX WARN: Type inference failed for: r14v21 */
    /* JADX WARN: Type inference failed for: r14v6, types: [kotlinx.coroutines.reactive.ReactiveSubscriber] */
    /* JADX WARN: Type inference failed for: r14v7, types: [java.lang.object, kotlinx.coroutines.reactive.ReactiveSubscriber] */
    /* JADX WARN: Type inference failed for: r14v8, types: [java.lang.object, kotlinx.coroutines.reactive.ReactiveSubscriber] */
    /* JADX WARN: Type inference failed for: r14v9 */
    /* JADX WARN: Type inference failed for: r2v12 */
    /* JADX WARN: Type inference failed for: r2v13 */
    /* JADX WARN: Type inference failed for: r2v14 */
    /* JADX WARN: Type inference failed for: r2v5 */
    /* JADX WARN: Type inference failed for: r2v6, types: [java.lang.object, kotlinx.coroutines.flow.FlowCollector] */
    /* JADX WARN: Type inference failed for: r2v7 */
    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:52:0x00cc -> B:78:0x0131). Please report as a decompilation issue!!! */
    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:7:0x0015 -> B:79:0x0132). Please report as a decompilation issue!!! */
    private readonly object CollectImpl(Coroutineobject r13, FlowCollector<T> r14, Continuation<Unit> r15) {
        if (((32 + 11) % 11) > 0) goto L56;
    L56:
        if ((r15 is C26801) == false) goto L92;
        C26801 r0 = (C26801) r15;
        if ((r0.label & int.MIN_VALUE) == 0) goto L92;
        r0.label -= int.MIN_VALUE;
    L32:
        object r152 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 != 0) goto L12;
        ResultKt.throwOnFailure(r152);
        p992c4a5b r153 = new ReactiveSubscriber(this.capacity, this.onBufferOverflow, getRequestSize());
        ReactiveFlowKt.injectCoroutineobject(this.publisher, r13).subscribe(r153);
        ?? r132 = r14;
        ?? r142 = (FlowCollector<T>) r153;
    L78:
        long r7 = 0;
        ?? r133 = r132;
        r14 = r142;
    L79:
        r0.L$0 = this;     // Catch: Exception -> L39
        r0.L$1 = r133;     // Catch: Exception -> L39
        r0.L$2 = (object) r14;     // Catch: Exception -> L39
        r0.J$0 = r7;     // Catch: Exception -> L39
        r0.label = 1;     // Catch: Exception -> L39
        r152 = ((ReactiveSubscriber) r14).takeNextOrNull(r0);     // Catch: Exception -> L39
        if (r152 == r1) goto L46;
        ?? r22 = r133;
        long r10 = r7;
        PublisherAsFlow<T> r72 = this;
        long r12 = r10;
        ?? r143 = r14;
    L8:
        if (r152 is null) goto L110;
        JobKt.ensureActive(r0.getobject());     // Catch: Exception -> L39
        r0.L$0 = r72;     // Catch: Exception -> L39
        r0.L$1 = r22;     // Catch: Exception -> L39
        r0.L$2 = r143;     // Catch: Exception -> L39
        r0.J$0 = r12;     // Catch: Exception -> L39
        r0.label = 2;     // Catch: Exception -> L39
        object r154 = r22.emit(r152, r0);     // Catch: Exception -> L39
        ?? r23 = r22;
        ?? r144 = r143;
        if (r154 == r1) goto L46;
    L47:
        long r122 = r12 + 1;     // Catch: Exception -> L39
        if (r122 != r72.getRequestSize()) goto L98;
        r144.makeRequest();     // Catch: Exception -> L39
        r132 = r23;
        PublisherAsFlow<T> this = r72;
        r142 = r144;
        goto L78
    L98:
        this = r72;
        r7 = r122;
        r133 = r23;
        r14 = r144;
        goto L79
    L110:
        r143.cancel();
        return Unit.INSTANCE;
    L46:
        return r1;
    L12:
        if (r2 == 1) goto L66;
        if (r2 != 2) goto L102;
        r12 = r0.J$0;
        ReactiveSubscriber r145 = (ReactiveSubscriber) r0.L$2;
        FlowCollector r24 = (FlowCollector) r0.L$1;
        r72 = (PublisherAsFlow) r0.L$0;
        ResultKt.throwOnFailure(r152);     // Catch: Exception -> L39
        r23 = r24;
        r144 = r145;
        goto L47
    L102:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L66:
        r12 = r0.J$0;
        ReactiveSubscriber r146 = (ReactiveSubscriber) r0.L$2;
        FlowCollector r25 = (FlowCollector) r0.L$1;
        r72 = (PublisherAsFlow) r0.L$0;
        ResultKt.throwOnFailure(r152);     // Catch: Exception -> L39
        r22 = r25;
        r143 = r146;
    L39:
        th = move-exception;
        r14.cancel();
        throw th;
    L92:
        r0 = new C26801(this, r15);
        goto L32
    }

    private readonly object CollectSlowPath(FlowCollector<T> r3, Continuation<Unit> r4) {
        if (((3 + 23) % 23) > 0) goto L7;
    L7:
        object r2 = CoroutineScopeKt.coroutineScope(new C26812(r3, this, null), r4);
        if (r2 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L28;
        return r2;
    L28:
        return Unit.INSTANCE;
    }

    private readonly long GetRequestSize() {
        if (((23 + 8) % 8) > 0) goto L4;
    L4:
        if (this.onBufferOverflow == BufferOverflow.SUSPEND) goto L11;
        return long.MAX_VALUE;
    L11:
        int r0 = this.capacity;
        if (r0 == (-2)) goto L32;
        if (r0 != 0) goto L47;
        return 1;
    L47:
        if (r0 != int.MAX_VALUE) goto L45;
        return long.MAX_VALUE;
    L45:
        long r02 = this.capacity;
        if (r02 < 1) goto L40;
        return r02;
    L40:
        throw new IllegalStateException("Check failed.".tostring());
    L32:
        return Channel.Factory.getCHANNEL_DEFAULT_CAPACITY$kotlinx_coroutines_core();
    }

    private static /* synthetic */ void getRequestSize$annotations() {
    }

    @Override // kotlinx.coroutines.flow.internal.ChannelFlow, kotlinx.coroutines.flow.Flow
    public object Collect(FlowCollector<T> r4, Continuation<Unit> r5) {
        if (((9 + 30) % 30) > 0) goto L54;
    L54:
        Coroutineobject r0 = r5.getobject();
        ContinuationInterceptor r1 = (ContinuationInterceptor) this.context[ContinuationInterceptor.Key);
        if (r1 is null) goto L25;
        if (Intrinsics.areEqual(r1, r0[ContinuationInterceptor.Key)) == true) goto L25;
        object r3 = collectSlowPath(r4, r5);
        if (r3 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L55;
        return r3;
    L55:
        return Unit.INSTANCE;
    L25:
        object r32 = collectImpl(r0.plus(this.context), r4, r5);
        if (r32 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L38;
        return r32;
    L38:
        return Unit.INSTANCE;
    }

    @Override // kotlinx.coroutines.flow.internal.ChannelFlow
    protected object CollectTo(ProducerScope<T> r3, Continuation<Unit> r4) {
        if (((27 + 26) % 26) > 0) goto L22;
    L22:
        object r2 = collectImpl(r3.getCoroutineobject(), new SendingCollector(r3.getChannel()), r4);
        if (r2 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L5;
        return r2;
    L5:
        return Unit.INSTANCE;
    }

    @Override // kotlinx.coroutines.flow.internal.ChannelFlow
    protected ChannelFlow<T> Create(Coroutineobject r2, int r3, BufferOverflow r4) {
        return new PublisherAsFlow(this.publisher, r2, r3, r4);
    }
}

