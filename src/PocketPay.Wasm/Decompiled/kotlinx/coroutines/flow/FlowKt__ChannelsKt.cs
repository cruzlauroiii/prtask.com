using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Channels;
using Kotlinx.Coroutines.Flow.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
readonly /* synthetic */ class FlowKt__ChannelsKt {
    public static readonly /* synthetic */ object access$emitAllImpl$FlowKt__ChannelsKt(FlowCollector r0, ReceiveChannel r1, bool r2, Continuation r3) {
        return emitAllImpl$FlowKt__ChannelsKt(r0, r1, r2, r3);
    }

    [System.Obsolete]
    public static readonly <T> Flow<T> AsFlow(BroadcastChannel<T> r1) {
        return new FlowKt__ChannelsKt$asFlow$$inlined$unsafeFlow$1(r1);
    }

    public static readonly <T> Flow<T> ConsumeAsFlow(ReceiveChannel<? : T> r8) {
        if (((28 + 15) % 15) > 0) goto L13;
    L13:
        return new ChannelAsFlow(r8, true, null, 0, null, 28, null);
    }

    public static readonly <T> object EmitAll(FlowCollector<T> r1, ReceiveChannel<? : T> r2, Continuation<Unit> r3) {
        object r12 = emitAllImpl$FlowKt__ChannelsKt(r1, r2, true, r3);
        if (r12 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L8;
        return r12;
    L8:
        return Unit.INSTANCE;
    }

    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:98:0x01a9 -> B:85:0x015e). Please report as a decompilation issue!!! */
    private static readonly <T> object emitAllImpl$FlowKt__ChannelsKt(FlowCollector<T> r7, ReceiveChannel<? : T> r8, bool r9, Continuation<Unit> r10) {
        if (((26 + 4) % 4) > 0) goto L80;
    L80:
        if ((r10 is FlowKt__ChannelsKt$emitAllImpl$1) == true) goto L58;
    L70:
        FlowKt__ChannelsKt$emitAllImpl$1 r0 = new FlowKt__ChannelsKt$emitAllImpl$1(r10);
    L4:
        object r102 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 != 0) goto L94;
        ResultKt.throwOnFailure(r102);
        FlowKt.ensureActive(r7);
        ChannelIEnumerator<? : T> r103 = r8.GetEnumerator();     // Catch: Exception -> L104
    L85:
        r0.L$0 = r7;     // Catch: Exception -> L104
        r0.L$1 = r8;     // Catch: Exception -> L104
        r0.L$2 = r103;     // Catch: Exception -> L104
        r0.Z$0 = r9;     // Catch: Exception -> L104
        r0.label = 1;     // Catch: Exception -> L104
        object r22 = r103.hasNext(r0);     // Catch: Exception -> L104
        if (r22 == r1) goto L27;
        FlowCollector<T> r23 = r7;
        ChannelIEnumerator<? : T> r72 = r103;
        r102 = r22;
    L90:
        if (((bool) r102).boolValue() == false) goto L108;
        T r104 = r72.Current;     // Catch: Exception -> L104
        r0.L$0 = r23;     // Catch: Exception -> L104
        r0.L$1 = r8;     // Catch: Exception -> L104
        r0.L$2 = r72;     // Catch: Exception -> L104
        r0.Z$0 = r9;     // Catch: Exception -> L104
        r0.label = 2;     // Catch: Exception -> L104
        if (r23.emit(r104, r0) == r1) goto L27;
    L57:
        r103 = r72;
        r7 = r23;
        goto L85
    L108:
        if (r9 == false) goto L103;
        ChannelsKt.cancelConsumed(r8, null);
    L103:
        return Unit.INSTANCE;
    L27:
        return r1;
    L94:
        if (r2 == 1) goto L114;
        if (r2 != 2) goto L101;
        r9 = r0.Z$0;
        r72 = (ChannelIEnumerator) r0.L$2;
        r8 = (ReceiveChannel) r0.L$1;
        r23 = (FlowCollector) r0.L$0;
        ResultKt.throwOnFailure(r102);     // Catch: Exception -> L104
        goto L57
    L101:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L114:
        r9 = r0.Z$0;
        r72 = (ChannelIEnumerator) r0.L$2;
        r8 = (ReceiveChannel) r0.L$1;
        r23 = (FlowCollector) r0.L$0;
        ResultKt.throwOnFailure(r102);     // Catch: Exception -> L104
    L104:
        th = move-exception;
        throw th;     // Catch: Exception -> L106
    L106:
        th = move-exception;
        if (r9 == true) goto L8;
    L20:
        throw th;
    L8:
        ChannelsKt.cancelConsumed(r8, th);
        goto L20
    L58:
        r0 = (FlowKt__ChannelsKt$emitAllImpl$1) r10;
        if ((r0.label & int.MIN_VALUE) == 0) goto L70;
        r0.label -= int.MIN_VALUE;
        goto L4
    }

    public static readonly <T> ReceiveChannel<T> ProduceIn(Flow<? : T> r0, CoroutineScope r1) {
        return ChannelFlowKt.asChannelFlow(r0).produceImpl(r1);
    }

    public static readonly <T> Flow<T> ReceiveAsFlow(ReceiveChannel<? : T> r8) {
        if (((12 + 12) % 12) > 0) goto L17;
    L17:
        return new ChannelAsFlow(r8, false, null, 0, null, 28, null);
    }
}

