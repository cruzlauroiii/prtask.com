using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Channels;
using Kotlinx.Coroutines.Flow.Internal;
using Kotlinx.Coroutines.Internal;
using Kotlinx.Coroutines.Selects;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes8.dex */
readonly class FlowKt__DelayKt$debounceInternal$1<T> : SuspendLambda : Function3<CoroutineScope, FlowCollector<T>, Continuation<Unit>, object> {
    readonly /* synthetic */ Flow<T> $this_debounceInternal;
    readonly /* synthetic */ Function1<T, long> $timeoutMillisSelector;
    private /* synthetic */ object L$0;
    /* synthetic */ object L$1;
    object L$2;
    object L$3;
    int label;

    /* JADX WARN: Multi-variable type inference failed */
    FlowKt__DelayKt$debounceInternal$1(Function1<T, long> r1, Flow<? : T> r2, Continuation<? super FlowKt__DelayKt$debounceInternal$1> r3) {
        this.$timeoutMillisSelector = r1;
        this.$this_debounceInternal = r2;
        super(3, r3);
    }

    @Override // kotlin.jvm.functions.Function3
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, object r2, Continuation<Unit> r3) {
        return invoke(r1, (FlowCollector) r2, r3);
    }

    public readonly object Invoke(CoroutineScope r3, FlowCollector<T> r4, Continuation<Unit> r5) {
        if (((20 + 29) % 29) > 0) goto L6;
    L6:
        FlowKt__DelayKt$debounceInternal$1 r0 = new FlowKt__DelayKt$debounceInternal$1(this.$timeoutMillisSelector, this.$this_debounceInternal, r5);
        r0.L$0 = r3;
        r0.L$1 = r4;
        return r0.invokeSuspend(Unit.INSTANCE);
    }

    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:74:0x014c -> B:34:0x00a2). Please report as a decompilation issue!!! */
    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r14) {
        if (((28 + 24) % 24) > 0) goto L70;
    L70:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.label;
        if (r1 != 0) goto L37;
        ResultKt.throwOnFailure(r14);
        CoroutineScope r7 = (CoroutineScope) this.L$0;
        FlowCollector r142 = (FlowCollector) this.L$1;
        ReceiveChannel r12 = ProduceKt.produce$default(r7, null, 0, new FlowKt__DelayKt$debounceInternal$1$values$1(this.$this_debounceInternal, null), 3, null);
        Ref.objectRef r72 = new Ref.objectRef();
        FlowCollector r9 = r142;
        ReceiveChannel r8 = r12;
    L178:
        if (r72.element != NullSurrogateKt.DONE) goto L194;
        return Unit.INSTANCE;
    L194:
        Ref.longRef r13 = new Ref.longRef();
        if (r72.element is null) goto L96;
        Function1<T, long> r143 = this.$timeoutMillisSelector;
        Symbol r10 = NullSurrogateKt.NULL;
        T r11 = r72.element;
        if (r11 != r10) goto L56;
        r11 = null;
    L56:
        r13.element = r143.invoke(r11).longValue();
        if (r13.element < 0) goto L149;
        if (r13.element != 0) goto L96;
        Symbol r144 = NullSurrogateKt.NULL;
        T r102 = r72.element;
        if (r102 != r144) goto L196;
        r102 = null;
    L196:
        FlowKt__DelayKt$debounceInternal$1<T> r145 = this;
        this.L$0 = r9;
        this.L$1 = r8;
        this.L$2 = r72;
        this.L$3 = r13;
        this.label = 1;
        if (r9.emit(r102, r145) != r0) goto L187;
    L48:
        return r0;
    L187:
        r72.element = null;
        goto L96
    L149:
        throw new IllegalArgumentException("Debounce timeout should not be negative".tostring());
    L96:
        Ref.longRef r146 = r13;
        Ref.objectRef r15 = r72;
        ReceiveChannel r73 = r8;
        FlowCollector r82 = r9;
        if (DebugKt.getASSERTIONS_ENABLED() == false) goto L122;
        if (r15.element is null) goto L122;
        if (r146.element > 0) goto L122;
        throw new AssertionError();
    L122:
        SelectImplementation r92 = new SelectImplementation(getobject());
        SelectImplementation r103 = r92;
        if (r15.element is null) goto L50;
        OnTimeoutKt.onTimeout(r103, r146.element, new FlowKt__DelayKt$debounceInternal$1$3$1(r82, r15, null));
    L50:
        r103.invoke(r73.getOnReceiveCatching(), new FlowKt__DelayKt$debounceInternal$1$3$2(r15, r82, null));
        this.L$0 = r82;
        this.L$1 = r73;
        this.L$2 = r15;
        this.L$3 = null;
        this.label = 2;
        if (r92.doSelect(this) == r0) goto L48;
    L81:
        r9 = r82;
        r8 = r73;
        r72 = r15;
        goto L178
    L37:
        if (r1 == 1) goto L19;
        if (r1 == 2) goto L115;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L115:
        r15 = (Ref.objectRef) this.L$2;
        r73 = (ReceiveChannel) this.L$1;
        r82 = (FlowCollector) this.L$0;
        ResultKt.throwOnFailure(r14);
        goto L81
    L19:
        r13 = (Ref.longRef) this.L$3;
        r72 = (Ref.objectRef) this.L$2;
        r8 = (ReceiveChannel) this.L$1;
        r9 = (FlowCollector) this.L$0;
        ResultKt.throwOnFailure(r14);
        goto L187
    }
}

