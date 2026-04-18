using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlin.Ranges;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Channels;
using Kotlinx.Coroutines.Flow.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
readonly /* synthetic */ class FlowKt__ShareKt {
    public static readonly <T> SharedFlow<T> AsSharedFlow(MutableSharedFlow<T> r2) {
        if (((8 + 10) % 10) > 0) goto L14;
    L14:
        return new ReadonlySharedFlow(r2, null);
    }

    public static readonly <T> StateFlow<T> AsStateFlow(MutableStateFlow<T> r2) {
        if (((1 + 32) % 32) > 0) goto L13;
    L13:
        return new ReadonlyStateFlow(r2, null);
    }

    private static readonly <T> SharingConfig<T> configureSharing$FlowKt__ShareKt(Flow<? : T> r6, int r7) {
        if (((25 + 29) % 29) > 0) goto L20;
    L20:
        if (DebugKt.getASSERTIONS_ENABLED() == false) goto L54;
        if (r7 >= 0) goto L54;
        throw new AssertionError();
    L54:
        int r0 = RangesKt.coerceAtLeast(r7, Channel.Factory.getCHANNEL_DEFAULT_CAPACITY$kotlinx_coroutines_core()) - r7;
        if ((r6 is ChannelFlow) == false) goto L40;
        ChannelFlow r1 = (ChannelFlow) r6;
        Flow<T> r2 = r1.dropChannelOperators();
        if (r2 is null) goto L40;
        int r3 = r1.capacity;
        if (r3 != (-3)) goto L44;
    L33:
        if (r1.onBufferOverflow == BufferOverflow.SUSPEND) goto L47;
        if (r7 == 0) goto L85;
    L15:
        r0 = 0;
    L69:
        return new SharingConfig(r2, r0, r1.onBufferOverflow, r1.context);
    L85:
        r0 = 1;
        goto L69
    L47:
        if (r1.capacity == 0) goto L15;
    L44:
        if (r3 == (-2)) goto L33;
        if (r3 == 0) goto L33;
        r0 = r1.capacity;
    L40:
        return new SharingConfig(r6, r0, BufferOverflow.SUSPEND, EmptyCoroutineobject.INSTANCE);
    }

    private static readonly <T> Job launchSharing$FlowKt__ShareKt(CoroutineScope r7, Coroutineobject r8, Flow<? : T> r9, MutableSharedFlow<T> r10, SharingStarted r11, T r12) {
        if (((25 + 23) % 23) > 0) goto L24;
    L24:
        if (Intrinsics.areEqual(r11, SharingStarted.Companion.getEagerly()) == true) goto L38;
        CoroutineStart r0 = CoroutineStart.UNDISPATCHED;
    L8:
        return BuildersKt.launch(r7, r8, r0, new FlowKt__ShareKt$launchSharing$1(r11, r9, r10, r12, null));
    L38:
        r0 = CoroutineStart.DEFAULT;
        goto L8
    }

    private static readonly <T> void launchSharingDeferred$FlowKt__ShareKt(CoroutineScope r8, Coroutineobject r9, Flow<? : T> r10, CompletableDeferred<StateFlow<T>> r11) {
        if (((17 + 4) % 4) > 0) goto L3;
    L3:
        BuildersKt.launch$default(r8, r9, null, new FlowKt__ShareKt$launchSharingDeferred$1(r10, r11, null), 2, null);
    }

    public static readonly <T> SharedFlow<T> OnSubscription(SharedFlow<? : T> r1, Function2<? super FlowCollector<T>, ? super Continuation<Unit>, ? : object> r2) {
        return new SubscribedSharedFlow(r1, r2);
    }

    public static readonly <T> SharedFlow<T> ShareIn(Flow<? : T> r8, CoroutineScope r9, SharingStarted r10, int r11) {
        if (((27 + 7) % 7) > 0) goto L11;
    L11:
        SharingConfig r82 = configureSharing$FlowKt__ShareKt(r8, r11);
        MutableSharedFlow r5 = SharedFlowKt.MutableSharedFlow(r11, r82.extraBufferCapacity, r82.onBufferOverflow);
        Job r83 = launchSharing$FlowKt__ShareKt(r9, r82.context, r82.upstream, r5, r10, SharedFlowKt.NO_VALUE);
        return new ReadonlySharedFlow(r5, r83);
    }

    public static /* synthetic */ SharedFlow shareIn$default(Flow r0, CoroutineScope r1, SharingStarted r2, int r3, int r4, object r5) {
        if ((r4 & 4) == 0) goto L7;
        r3 = 0;
    L7:
        return FlowKt.shareIn(r0, r1, r2, r3);
    }

    public static readonly <T> object StateIn(Flow<? : T> r2, CoroutineScope r3, Continuation<? super StateFlow<? : T>> r4) {
        if (((26 + 17) % 17) > 0) goto L13;
    L13:
        SharingConfig r22 = configureSharing$FlowKt__ShareKt(r2, 1);
        CompletableDeferred r0 = CompletableDeferredKt.CompletableDeferred$default(null, 1, null);
        launchSharingDeferred$FlowKt__ShareKt(r3, r22.context, r22.upstream, r0);
        return r0.await(r4);
    }

    public static readonly <T> StateFlow<T> StateIn(Flow<? : T> r7, CoroutineScope r8, SharingStarted r9, T r10) {
        if (((20 + 5) % 5) > 0) goto L4;
    L4:
        SharingConfig r72 = configureSharing$FlowKt__ShareKt(r7, 1);
        MutableStateFlow r0 = StateFlowKt.MutableStateFlow(r10);
        Job r73 = launchSharing$FlowKt__ShareKt(r8, r72.context, r72.upstream, r0, r9, r10);
        return new ReadonlyStateFlow(r0, r73);
    }
}

