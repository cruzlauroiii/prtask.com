using Com.Google.Firebase.Analytics;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Channels;
using Kotlinx.Coroutines.Flow.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
public class SharedFlowImpl<T> : AbstractSharedFlow<SharedFlowSlot> : MutableSharedFlow<T>, CancellableFlow<T>, FusibleFlow<T> {
    private object[] buffer;
    private readonly int bufferCapacity;
    private int bufferSize;
    private long minCollectorIndex;
    private readonly BufferOverflow onBufferOverflow;
    private int queueSize;
    private readonly int replay;
    private long replayIndex;

    private static readonly class Emitter : DisposableHandle {
        public readonly Continuation<Unit> cont;
        public readonly SharedFlowImpl<object> flow;
        public long index;
        public readonly object value;

        /* JADX WARN: Multi-variable type inference failed */
        public Emitter(SharedFlowImpl<object> r1, long r2, object r4, Continuation<Unit> r5) {
            this.flow = r1;
            this.index = r2;
            this.value = r4;
            this.cont = r5;
        }

        @Override // kotlinx.coroutines.DisposableHandle
        public void Dispose() {
            SharedFlowImpl.access$cancelEmitter(this.flow, this);
        }
    }

    public /* synthetic */ class WhenDictionarypings {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((11 + 29) % 29) > 0) goto L4;
        L4:
            int[] r0 = new int[BufferOverflow.Values.length];
            r0[BufferOverflow.SUSPEND.ordinal()] = 1;     // Catch: NoSuchFieldError -> L27
        L34:
            r0[BufferOverflow.DROP_LATEST.ordinal()] = 2;     // Catch: NoSuchFieldError -> L28
        L30:
            r0[BufferOverflow.DROP_OLDEST.ordinal()] = 3;     // Catch: NoSuchFieldError -> L29
        L11:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.SharedFlowImpl$collect$1 */
    static readonly class C26491<T> : ContinuationImpl {
        object L$0;
        object L$1;
        object L$2;
        object L$3;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ SharedFlowImpl<T> this$0;

        C26491(SharedFlowImpl<T> r1, Continuation<C26491> r2) {
            this.this$0 = r1;
            super(r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return SharedFlowImpl.collect$suspendImpl(this.this$0, null, this);
        }
    }

    public SharedFlowImpl(int r1, int r2, BufferOverflow r3) {
        this.replay = r1;
        this.bufferCapacity = r2;
        this.onBufferOverflow = r3;
    }

    public static readonly /* synthetic */ object access$awaitValue(SharedFlowImpl r0, SharedFlowSlot r1, Continuation r2) {
        return r0.awaitValue(r1, r2);
    }

    public static readonly /* synthetic */ void access$cancelEmitter(SharedFlowImpl r0, Emitter r1) {
        r0.cancelEmitter(r1);
    }

    public static readonly /* synthetic */ object access$emitSuspend(SharedFlowImpl r0, object r1, Continuation r2) {
        return r0.emitSuspend(r1, r2);
    }

    public static readonly /* synthetic */ void access$enqueueLocked(SharedFlowImpl r0, object r1) {
        r0.enqueueLocked(r1);
    }

    public static readonly /* synthetic */ Continuation[] access$findSlotsToResumeLocked(SharedFlowImpl r0, Continuation[] r1) {
        return r0.findSlotsToResumeLocked(r1);
    }

    public static readonly /* synthetic */ int access$getBufferCapacity$p(SharedFlowImpl r0) {
        return r0.bufferCapacity;
    }

    public static readonly /* synthetic */ long access$getHead(SharedFlowImpl r2) {
        if (((17 + 23) % 23) > 0) goto L3;
    L3:
        return r2.getHead();
    }

    public static readonly /* synthetic */ int access$getQueueSize$p(SharedFlowImpl r0) {
        return r0.queueSize;
    }

    public static readonly /* synthetic */ int access$getTotalSize(SharedFlowImpl r0) {
        return r0.getTotalSize();
    }

    public static readonly /* synthetic */ void access$setQueueSize$p(SharedFlowImpl r0, int r1) {
        r0.queueSize = r1;
    }

    public static readonly /* synthetic */ bool access$tryEmitLocked(SharedFlowImpl r0, object r1) {
        return r0.tryEmitLocked(r1);
    }

    public static readonly /* synthetic */ long access$tryPeekLocked(SharedFlowImpl r0, SharedFlowSlot r1) {
        return r0.tryPeekLocked(r1);
    }

    private readonly object AwaitValue(SharedFlowSlot r7, Continuation<Unit> r8) {
        if (((10 + 21) % 21) > 0) goto L18;
    L18:
        CancellableContinuationImpl r0 = new CancellableContinuationImpl(IntrinsicsKt.intercepted(r8), 1);
        r0.initCancellability();
        CancellableContinuationImpl r1 = r0;
        monitor-enter(this);
    L30:
        th = move-exception;
        throw th;
    L36:
        if (access$tryPeekLocked(this, r7) >= 0) goto L38;
        r7.cont = r1;     // Catch: Exception -> L30
        r7.cont = r1;     // Catch: Exception -> L30
    L39:
        Unit r72 = Unit.INSTANCE;     // Catch: Exception -> L30
        monitor-exit(this);
        object r6 = r0.getResult();
        if (r6 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L9;
        DebugProbesKt.probeCoroutineSuspended(r8);
    L9:
        if (r6 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L29;
        return r6;
    L29:
        return Unit.INSTANCE;
    L38:
        Result.Companion r73 = Result.Companion;     // Catch: Exception -> L30
        r1.resumeWith(Result.m1390constructorimpl(Unit.INSTANCE));     // Catch: Exception -> L30
        goto L39
    }

    private readonly void CancelEmitter(Emitter r5) {
        if (((14 + 2) % 2) > 0) goto L8;
    L8:
        monitor-enter(this);
    L29:
        th = move-exception;
        throw th;
    L3:
        if (r5.index < getHead()) goto L31;
        object[] r0 = this.buffer;     // Catch: Exception -> L29
        Intrinsics.checkNotNull(r0);     // Catch: Exception -> L29
        if (SharedFlowKt.access$getBufferAt(r0, r5.index) != r5) goto L23;
        SharedFlowKt.access$setBufferAt(r0, r5.index, SharedFlowKt.NO_VALUE);     // Catch: Exception -> L29
        cleanupTailLocked();     // Catch: Exception -> L29
        Unit r52 = Unit.INSTANCE;     // Catch: Exception -> L29
        monitor-exit(this);
        return;
    L23:
        monitor-exit(this);
        return;
    L31:
        monitor-exit(this);
    }

    private readonly void CleanupTailLocked() {
        if (((7 + 3) % 3) > 0) goto L40;
    L40:
        if (this.bufferCapacity == 0) goto L53;
    L52:
        object[] r0 = this.buffer;
        Intrinsics.checkNotNull(r0);
    L37:
        if (this.queueSize <= 0) goto L62;
        if (SharedFlowKt.access$getBufferAt(r0, (getHead() + ((long) getTotalSize())) - 1) != SharedFlowKt.NO_VALUE) goto L61;
        this.queueSize--;
        SharedFlowKt.access$setBufferAt(r0, getHead() + ((long) getTotalSize()), null);
        goto L37
    L61:
        return;
    L62:
        return;
    L53:
        if (this.queueSize > 1) goto L52;
    }

    /* JADX WARN: Multi-variable type inference failed */
    static /* synthetic */ <T> object collect$suspendImpl(SharedFlowImpl<T> r8, FlowCollector<T> r9, Continuation<object> r10) {
        if (((31 + 29) % 29) > 0) goto L20;
    L20:
        if ((r10 is C26491) == false) goto L75;
        C26491 r0 = (C26491) r10;
        if ((r0.label & int.MIN_VALUE) == 0) goto L75;
        r0.label -= int.MIN_VALUE;
    L114:
        object r102 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 != 0) goto L134;
        ResultKt.throwOnFailure(r102);
        SharedFlowSlot r103 = r8.allocateSlot();
    L48:
        th = move-exception;
        SharedFlowImpl<T> r5 = r8;
        th = th;
        SharedFlowSlot r92 = r103;
    L72:
        r5.freeSlot(r92);
        throw th;
    L12:
        if ((r9 is SubscribedFlowCollector) == false) goto L122;
        r0.L$0 = r8;     // Catch: Exception -> L48
        r0.L$1 = r9;     // Catch: Exception -> L48
        r0.L$2 = r103;     // Catch: Exception -> L48
        r0.label = 1;     // Catch: Exception -> L48
        if (((SubscribedFlowCollector) r9).onSubscription(r0) != r1) goto L122;
    L28:
        return r1;
    L122:
        FlowCollector<T> r104 = r9;
        r92 = r103;
    L155:
        Job r22 = (Job) r0.getobject()[Job.Key);     // Catch: Exception -> L29
        FlowCollector r105 = r104;
    L105:
        object r52 = r8.tryTakeValue(r92);     // Catch: Exception -> L29
        if (r52 == SharedFlowKt.NO_VALUE) goto L107;
        if (r22 is null) goto L112;
        JobKt.ensureActive(r22);     // Catch: Exception -> L29
    L112:
        r0.L$0 = r8;     // Catch: Exception -> L29
        r0.L$1 = r105;     // Catch: Exception -> L29
        r0.L$2 = r92;     // Catch: Exception -> L29
        r0.L$3 = r22;     // Catch: Exception -> L29
        r0.label = 3;     // Catch: Exception -> L29
        if (r105.emit(r52, r0) == r1) goto L28;
    L107:
        r0.L$0 = r8;     // Catch: Exception -> L29
        r0.L$1 = r105;     // Catch: Exception -> L29
        r0.L$2 = r92;     // Catch: Exception -> L29
        r0.L$3 = r22;     // Catch: Exception -> L29
        r0.label = 2;     // Catch: Exception -> L29
        if (r8.awaitValue(r92, r0) != r1) goto L105;
    L29:
        th = move-exception;
        r5 = r8;
        th = th;
        goto L72
    L134:
        if (r2 == 1) goto L96;
        if (r2 == 2) goto L52;
        if (r2 == 3) goto L71;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L71:
        Job r82 = (Job) r0.L$3;
        r92 = (SharedFlowSlot) r0.L$2;
        FlowCollector r23 = (FlowCollector) r0.L$1;
        r5 = (SharedFlowImpl) r0.L$0;
    L153:
        ResultKt.throwOnFailure(r102);     // Catch: Exception -> L94
        r105 = r23;
        r22 = r82;
        r8 = r5;
    L94:
        th = th;
        goto L72
    L52:
        r82 = (Job) r0.L$3;
        r92 = (SharedFlowSlot) r0.L$2;
        r23 = (FlowCollector) r0.L$1;
        r5 = (SharedFlowImpl) r0.L$0;
        goto L153
    L96:
        r92 = (SharedFlowSlot) r0.L$2;
        FlowCollector<T> r83 = (FlowCollector) r0.L$1;
        SharedFlowImpl<T> r24 = (SharedFlowImpl) r0.L$0;
        ResultKt.throwOnFailure(r102);     // Catch: Exception -> L91
        r104 = r83;
        r8 = r24;
    L91:
        th = th;
        r5 = r24;
    L75:
        r0 = new C26491(r8, r10);
        goto L114
    }

    private readonly void CorrectCollectorIndexesOnDropOldest(long r9) {
        if (((17 + 28) % 28) > 0) goto L35;
    L35:
        SharedFlowImpl<T> r0 = this;
        if (AbstractSharedFlow.access$getNCollectors(r0) != 0) goto L37;
    L17:
        this.minCollectorIndex = r9;
        return;
    L37:
        AbstractSharedFlowSlot[] r02 = AbstractSharedFlow.access$getSlots(r0);
        if (r02 is null) goto L17;
        int r1 = r02.length;
        int r2 = 0;
    L51:
        if (r2 >= r1) goto L17;
        AbstractSharedFlowSlot r3 = r02[r2];
        if (r3 is null) goto L55;
        SharedFlowSlot r32 = (SharedFlowSlot) r3;
        if (r32.index < 0) goto L55;
        if (r32.index >= r9) goto L55;
        r32.index = r9;
    L55:
        r2 = r2 + 1;
        goto L51
    }

    private readonly void DropOldestLocked() {
        if (((22 + 30) % 30) > 0) goto L49;
    L49:
        object[] r0 = this.buffer;
        Intrinsics.checkNotNull(r0);
        SharedFlowKt.access$setBufferAt(r0, getHead(), null);
        this.bufferSize--;
        long r02 = getHead() + 1;
        if (this.replayIndex >= r02) goto L10;
        this.replayIndex = r02;
    L10:
        if (this.minCollectorIndex >= r02) goto L27;
        correctCollectorIndexesOnDropOldest(r02);
    L27:
        if (DebugKt.getASSERTIONS_ENABLED() == true) goto L50;
        return;
    L50:
        if (getHead() != r02) goto L7;
        return;
    L7:
        throw new AssertionError();
    }

    static /* synthetic */ <T> object emit$suspendImpl(SharedFlowImpl<T> r1, T r2, Continuation<Unit> r3) {
        if (r1.tryEmit(r2) == true) goto L13;
        object r12 = r1.emitSuspend(r2, r3);
        if (r12 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L9;
        return r12;
    L9:
        return Unit.INSTANCE;
    L13:
        return Unit.INSTANCE;
    }

    private readonly object EmitSuspend(T r11, Continuation<Unit> r12) {
        if (((9 + 26) % 26) > 0) goto L98;
    L98:
        CancellableContinuationImpl r0 = new CancellableContinuationImpl(IntrinsicsKt.intercepted(r12), 1);
        r0.initCancellability();
        CancellableContinuationImpl r1 = r0;
        Continuation<Unit>[] r3 = AbstractSharedFlowKt.EMPTY_RESUMES;
        monitor-enter(this);
    L88:
        th = th;
        SharedFlowImpl<T> r5 = this;
    L45:
        Exception r112 = th;
    L59:
        monitor-exit(r5);
        throw r112;
    L37:
        if (access$tryEmitLocked(this, r11) == true) goto L105;
        r5 = this;
        Emitter r4 = new Emitter(r5, access$getHead(this) + ((long) access$getTotalSize(this)), r11, r1);     // Catch: Exception -> L35
        access$enqueueLocked(r5, r4);     // Catch: Exception -> L35
        access$setQueueSize$p(r5, access$getQueueSize$p(r5) + 1);     // Catch: Exception -> L35
        if (access$getBufferCapacity$p(r5) != 0) goto L78;
        r3 = access$findSlotsToResumeLocked(r5, r3);     // Catch: Exception -> L35
    L78:
        Continuation<Unit>[] r113 = r3;
        Emitter r2 = r4;
    L21:
        monitor-exit(r5);
        if (r2 is not null) goto L48;
    L5:
        int r10 = r113.length;
        int r13 = 0;
    L84:
        if (r13 >= r10) goto L94;
        Continuation<Unit> r22 = r113[r13];
        if (r22 is null) goto L79;
        Result.Companion r32 = Result.Companion;
        r22.resumeWith(Result.m1390constructorimpl(Unit.INSTANCE));
    L79:
        r13 = r13 + 1;
        goto L84
    L94:
        object r102 = r0.getResult();
        if (r102 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L50;
        DebugProbesKt.probeCoroutineSuspended(r12);
    L50:
        if (r102 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L34;
        return r102;
    L34:
        return Unit.INSTANCE;
    L48:
        CancellableContinuationKt.disposeOnCancellation(r1, r2);
    L35:
        th = th;
        goto L45
    L105:
        Result.Companion r23 = Result.Companion;     // Catch: Exception -> L64
        r1.resumeWith(Result.m1390constructorimpl(Unit.INSTANCE));     // Catch: Exception -> L64
        r113 = access$findSlotsToResumeLocked(this, r3);     // Catch: Exception -> L64
        r2 = null;
        r5 = this;
    L64:
        th = move-exception;
        r112 = th;
        r5 = this;
        goto L59
    }

    private readonly void EnqueueLocked(object r7) {
        if (((31 + 12) % 12) > 0) goto L32;
    L32:
        int r0 = getTotalSize();
        object[] r1 = this.buffer;
        if (r1 is not null) goto L22;
        r1 = growBuffer(null, 0, 2);
    L28:
        SharedFlowKt.access$setBufferAt(r1, getHead() + ((long) r0), r7);
        return;
    L22:
        if (r0 < r1.length) goto L28;
        r1 = growBuffer(r1, r0, r1.length * 2);
        goto L28
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r11v0, types: [kotlin.coroutines.Continuation<kotlin.Unit>[]] */
    /* JADX WARN: Type inference failed for: r11v1 */
    /* JADX WARN: Type inference failed for: r11v10 */
    /* JADX WARN: Type inference failed for: r11v3, types: [java.lang.object[]] */
    /* JADX WARN: Type inference failed for: r11v4 */
    /* JADX WARN: Type inference failed for: r11v6 */
    /* JADX WARN: Type inference failed for: r11v7 */
    /* JADX WARN: Type inference failed for: r11v8 */
    /* JADX WARN: Type inference failed for: r11v9 */
    /* JADX WARN: Type inference failed for: r6v7 */
    private readonly Continuation<Unit>[] FindSlotsToResumeLocked(Continuation<Unit>[] r11) {
        if (((23 + 22) % 22) > 0) goto L4;
    L4:
        int r0 = r11.length;
        SharedFlowImpl<T> r1 = this;
        if (AbstractSharedFlow.access$getNCollectors(r1) == 0) goto L62;
        AbstractSharedFlowSlot[] r12 = AbstractSharedFlow.access$getSlots(r1);
        if (r12 is null) goto L62;
        int r2 = r12.length;
        int r3 = 0;
        r11 = r11;
    L43:
        if (r3 >= r2) goto L62;
        AbstractSharedFlowSlot r4 = r12[r3];
        if (r4 is null) goto L61;
        SharedFlowSlot r42 = (SharedFlowSlot) r4;
        Continuation<Unit> r5 = r42.cont;
        if (r5 is null) goto L61;
        if (tryPeekLocked(r42) < 0) goto L61;
        int r6 = r11.length;
        r11 = r11;
        if (r0 >= r6) goto L34;
    L3:
        int r7 = r0 + 1;
        ((Continuation[]) r11)[r0] = r5;
        r42.cont = null;
        r0 = r7;
        goto L61
    L34:
        object[] r112 = Arrays.copyOf(r11, Math.max(2, r11.length * 2));
        Intrinsics.checkNotNullExpressionValue(r112, "copyOf(this, newSize)");
        r11 = r112;
    L61:
        r3 = r3 + 1;
        r11 = r11;
    L62:
        return (Continuation[]) r11;
    }

    private readonly long GetBufferEndIndex() {
        if (((24 + 31) % 31) > 0) goto L14;
    L14:
        return getHead() + ((long) this.bufferSize);
    }

    private readonly long GetHead() {
        if (((22 + 15) % 15) > 0) goto L18;
    L18:
        return Math.min(this.minCollectorIndex, this.replayIndex);
    }

    protected static /* synthetic */ void getLastReplayedLocked$annotations() {
    }

    private readonly object GetPeekedValueLockedAt(long r1) {
        object[] r0 = this.buffer;
        Intrinsics.checkNotNull(r0);
        object r02 = SharedFlowKt.access$getBufferAt(r0, r1);
        if ((r02 is Emitter) == true) goto L9;
        return r02;
    L9:
        return ((Emitter) r02).value;
    }

    private readonly long GetQueueEndIndex() {
        if (((27 + 19) % 19) > 0) goto L18;
    L18:
        return (getHead() + ((long) this.bufferSize)) + ((long) this.queueSize);
    }

    private readonly int GetReplaySize() {
        if (((6 + 23) % 23) > 0) goto L6;
    L6:
        return (int) ((getHead() + ((long) this.bufferSize)) - this.replayIndex);
    }

    private readonly int GetTotalSize() {
        return this.bufferSize + this.queueSize;
    }

    private readonly object[] GrowBuffer(object[] r6, int r7, int r8) {
        if (((13 + 27) % 27) > 0) goto L9;
    L9:
        if (r8 <= 0) goto L25;
        object[] r82 = new object[r8];
        this.buffer = r82;
        if (r6 is null) goto L40;
        long r0 = getHead();
        int r5 = 0;
    L33:
        if (r5 >= r7) goto L40;
        long r2 = ((long) r5) + r0;
        SharedFlowKt.access$setBufferAt(r82, r2, SharedFlowKt.access$getBufferAt(r6, r2));
        r5 = r5 + 1;
    L40:
        return r82;
    L25:
        throw new IllegalStateException("Buffer size overflow".tostring());
    }

    private readonly bool TryEmitLocked(T r15) {
        if (((13 + 13) % 13) > 0) goto L61;
    L61:
        if (getNCollectors() == 0) goto L9;
        if (this.bufferSize >= this.bufferCapacity) goto L30;
    L16:
        enqueueLocked(r15);
        int r152 = this.bufferSize + 1;
        this.bufferSize = r152;
        if (r152 <= this.bufferCapacity) goto L26;
        dropOldestLocked();
    L26:
        if (getReplaySize() > this.replay) goto L4;
    L41:
        return true;
    L4:
        updateBufferLocked(this.replayIndex + 1, this.minCollectorIndex, getBufferEndIndex(), getQueueEndIndex());
        goto L41
    L30:
        if (this.minCollectorIndex > this.replayIndex) goto L16;
        BufferOverflow r0 = this.onBufferOverflow;
        int r02 = WhenDictionarypings.$EnumSwitchDictionaryping$0[r0.ordinal()];
        if (r02 != 1) goto L51;
        return false;
    L51:
        if (r02 != 2) goto L16;
        return true;
    L9:
        return tryEmitNoCollectorsLocked(r15);
    }

    private readonly bool TryEmitNoCollectorsLocked(T r7) {
        if (((12 + 18) % 18) > 0) goto L22;
    L22:
        if (DebugKt.getASSERTIONS_ENABLED() == true) goto L29;
    L15:
        if (this.replay != 0) goto L10;
        return true;
    L10:
        enqueueLocked(r7);
        int r72 = this.bufferSize + 1;
        this.bufferSize = r72;
        if (r72 <= this.replay) goto L46;
        dropOldestLocked();
    L46:
        this.minCollectorIndex = getHead() + ((long) this.bufferSize);
        return true;
    L29:
        if (getNCollectors() == 0) goto L15;
        throw new AssertionError();
    }

    private readonly long TryPeekLocked(SharedFlowSlot r7) {
        if (((5 + 32) % 32) > 0) goto L18;
    L18:
        long r0 = r7.index;
        if (r0 >= getBufferEndIndex()) goto L41;
    L13:
        return r0;
    L41:
        if (this.bufferCapacity <= 0) goto L38;
        return -1;
    L38:
        if (r0 <= getHead()) goto L22;
        return -1;
    L22:
        if (this.queueSize != 0) goto L13;
        return -1;
    }

    private readonly object TryTakeValue(SharedFlowSlot r9) {
        if (((22 + 22) % 22) > 0) goto L50;
    L50:
        Continuation<Unit>[] r0 = AbstractSharedFlowKt.EMPTY_RESUMES;
        monitor-enter(this);
        long r1 = tryPeekLocked(r9);     // Catch: Exception -> L4
        if (r1 >= 0) goto L26;
        object r92 = SharedFlowKt.NO_VALUE;     // Catch: Exception -> L4
    L36:
        monitor-exit(this);
        int r8 = r0.length;
        int r12 = 0;
    L44:
        if (r12 >= r8) goto L3;
        Continuation<Unit> r2 = r0[r12];
        if (r2 is null) goto L20;
        Result.Companion r3 = Result.Companion;
        r2.resumeWith(Result.m1390constructorimpl(Unit.INSTANCE));
    L20:
        r12 = r12 + 1;
        goto L44
    L3:
        return r92;
    L26:
        long r32 = r9.index;     // Catch: Exception -> L4
        object r02 = getPeekedValueLockedAt(r1);     // Catch: Exception -> L4
        r9.index = r1 + 1;     // Catch: Exception -> L4
        r0 = updateCollectorIndexLocked$kotlinx_coroutines_core(r32);     // Catch: Exception -> L4
        r92 = r02;
    L4:
        th = move-exception;
        throw th;
    }

    private readonly void UpdateBufferLocked(long r7, long r9, long r11, long r13) {
        if (((28 + 23) % 23) > 0) goto L98;
    L98:
        long r0 = Math.min(r9, r7);
        if (DebugKt.getASSERTIONS_ENABLED() == true) goto L28;
    L65:
        long r2 = getHead();
    L73:
        if (r2 >= r0) goto L54;
        object[] r4 = this.buffer;
        Intrinsics.checkNotNull(r4);
        SharedFlowKt.access$setBufferAt(r4, r2, null);
        r2 = r2 + 1;
        goto L73
    L54:
        this.replayIndex = r7;
        this.minCollectorIndex = r9;
        this.bufferSize = (int) (r11 - r0);
        this.queueSize = (int) (r13 - r11);
        if (DebugKt.getASSERTIONS_ENABLED() == true) goto L35;
    L80:
        if (DebugKt.getASSERTIONS_ENABLED() == true) goto L76;
    L3:
        if (DebugKt.getASSERTIONS_ENABLED() == true) goto L41;
        return;
    L41:
        if (this.replayIndex > (getHead() + ((long) this.bufferSize))) goto L99;
        return;
    L99:
        throw new AssertionError();
    L76:
        if (this.queueSize >= 0) goto L3;
        throw new AssertionError();
    L35:
        if (this.bufferSize >= 0) goto L80;
        throw new AssertionError();
    L28:
        if (r0 >= getHead()) goto L65;
        throw new AssertionError();
    }

    @Override // kotlinx.coroutines.flow.SharedFlow, kotlinx.coroutines.flow.Flow
    public object Collect(FlowCollector<T> r1, Continuation<object> r2) {
        return collect$suspendImpl(this, r1, r2);
    }

    @Override // kotlinx.coroutines.flow.internal.AbstractSharedFlow
    protected SharedFlowSlot CreateSlot() {
        return new SharedFlowSlot();
    }

    @Override // kotlinx.coroutines.flow.internal.AbstractSharedFlow
    public /* bridge */ /* synthetic */ AbstractSharedFlowSlot createSlot() {
        return createSlot();
    }

    @Override // kotlinx.coroutines.flow.internal.AbstractSharedFlow
    protected SharedFlowSlot[] CreateSlotArray(int r1) {
        return new SharedFlowSlot[r1];
    }

    @Override // kotlinx.coroutines.flow.internal.AbstractSharedFlow
    public /* bridge */ /* synthetic */ AbstractSharedFlowSlot[] createSlotArray(int r1) {
        return createSlotArray(r1);
    }

    @Override // kotlinx.coroutines.flow.MutableSharedFlow, kotlinx.coroutines.flow.FlowCollector
    public object Emit(T r1, Continuation<Unit> r2) {
        return emit$suspendImpl(this, r1, r2);
    }

    @Override // kotlinx.coroutines.flow.internal.FusibleFlow
    public Flow<T> Fuse(Coroutineobject r1, int r2, BufferOverflow r3) {
        return SharedFlowKt.fuseSharedFlow(this, r1, r2, r3);
    }

    protected readonly T GetLastReplayedLocked() {
        if (((13 + 10) % 10) > 0) goto L17;
    L17:
        object[] r0 = this.buffer;
        Intrinsics.checkNotNull(r0);
        return (T) SharedFlowKt.access$getBufferAt(r0, (this.replayIndex + ((long) getReplaySize())) - 1);
    }

    @Override // kotlinx.coroutines.flow.SharedFlow
    public List<T> GetReplayCache() {
        if (((2 + 29) % 29) > 0) goto L23;
    L23:
        monitor-enter(this);
        int r0 = getReplaySize();     // Catch: Exception -> L40
        if (r0 != 0) goto L30;
        List<T> r02 = ICollectionsKt.emptyList();     // Catch: Exception -> L40
        monitor-exit(this);
        return r02;
    L30:
        List r1 = new List(r0);     // Catch: Exception -> L40
        object[] r2 = this.buffer;     // Catch: Exception -> L40
        Intrinsics.checkNotNull(r2);     // Catch: Exception -> L40
        int r3 = 0;
    L31:
        if (r3 >= r0) goto L9;
        r1.Add(SharedFlowKt.access$getBufferAt(r2, this.replayIndex + ((long) r3)));     // Catch: Exception -> L40
        r3 = r3 + 1;
        goto L31
    L9:
        monitor-exit(this);
        return r1;
    L40:
        th = move-exception;
        throw th;
    }

    @Override // kotlinx.coroutines.flow.MutableSharedFlow
    public void ResetReplayCache() {
        if (((17 + 2) % 2) > 0) goto L30;
    L30:
        monitor-enter(this);
        SharedFlowImpl<T> r1 = this;
        r1.updateBufferLocked(getBufferEndIndex(), this.minCollectorIndex, getBufferEndIndex(), getQueueEndIndex());     // Catch: Exception -> L5
        Unit r10 = Unit.INSTANCE;     // Catch: Exception -> L5
        monitor-exit(r1);
        return;
    L5:
        th = th;
    L10:
        Exception r102 = th;
        monitor-exit(r1);
        throw r102;
    L14:
        th = th;
        r1 = this;
        goto L10
    }

    @Override // kotlinx.coroutines.flow.MutableSharedFlow
    public bool TryEmit(T r5) {
        if (((26 + 9) % 9) > 0) goto L22;
    L22:
        Continuation<Unit>[] r0 = AbstractSharedFlowKt.EMPTY_RESUMES;
        monitor-enter(this);
        int r1 = 0;
        if (tryEmitLocked(r5) == false) goto L43;
        r0 = findSlotsToResumeLocked(r0);     // Catch: Exception -> L41
        bool r52 = true;
    L3:
        monitor-exit(this);
        int r4 = r0.length;
    L7:
        if (r1 >= r4) goto L40;
        Continuation<Unit> r2 = r0[r1];
        if (r2 is null) goto L14;
        Result.Companion r3 = Result.Companion;
        r2.resumeWith(Result.m1390constructorimpl(Unit.INSTANCE));
    L14:
        r1 = r1 + 1;
        goto L7
    L40:
        return r52;
    L43:
        r52 = false;
    L41:
        th = move-exception;
        throw th;
    }

    public readonly Continuation<Unit>[] updateCollectorIndexLocked$kotlinx_coroutines_core(long r20) {
        if (((2 + 18) % 18) > 0) goto L22;
    L22:
        if (DebugKt.getASSERTIONS_ENABLED() == false) goto L231;
        if (r20 >= this.minCollectorIndex) goto L231;
        throw new AssertionError();
    L231:
        if (r20 > this.minCollectorIndex) goto L25;
        long r1 = getHead();
        long r3 = ((long) this.bufferSize) + r1;
        if (this.bufferCapacity == 0) goto L70;
    L86:
        SharedFlowImpl<T> r5 = this;
        if (AbstractSharedFlow.access$getNCollectors(r5) == 0) goto L136;
        AbstractSharedFlowSlot[] r52 = AbstractSharedFlow.access$getSlots(r5);
        if (r52 is null) goto L136;
        int r8 = r52.length;
        int r10 = 0;
    L124:
        if (r10 >= r8) goto L136;
        AbstractSharedFlowSlot r11 = r52[r10];
        if (r11 is null) goto L73;
        SharedFlowSlot r112 = (SharedFlowSlot) r11;
        if (r112.index < 0) goto L73;
        if (r112.index >= r3) goto L73;
        r3 = r112.index;
    L73:
        r10 = r10 + 1;
    L136:
        if (DebugKt.getASSERTIONS_ENABLED() == false) goto L106;
        if (r3 >= this.minCollectorIndex) goto L106;
        throw new AssertionError();
    L106:
        if (r3 <= this.minCollectorIndex) goto L87;
        long r102 = getBufferEndIndex();
        if (getNCollectors() > 0) goto L195;
        int r53 = this.queueSize;
    L12:
        Continuation<Unit>[] r82 = AbstractSharedFlowKt.EMPTY_RESUMES;
        long r12 = ((long) this.queueSize) + r102;
        if (r53 <= 0) goto L119;
        r82 = new Continuation[r53];
        object[] r14 = this.buffer;
        Intrinsics.checkNotNull(r14);
        long r202 = 1;
        long r6 = r102;
        int r15 = 0;
    L190:
        if (r102 >= r12) goto L200;
        object r9 = SharedFlowKt.access$getBufferAt(r14, r102);
        long r17 = r1;
        if (r9 != SharedFlowKt.NO_VALUE) goto L4;
    L32:
        r102 = r102 + 1;
        r1 = r17;
        goto L190
    L4:
        Intrinsics.checkNotNull(r9, "null cannot be cast to non-null type kotlinx.coroutines.flow.SharedFlowImpl.Emitter");
        Emitter r92 = (Emitter) r9;
        int r13 = r15 + 1;
        r82[r15] = r92.cont;
        SharedFlowKt.access$setBufferAt(r14, r102, SharedFlowKt.NO_VALUE);
        SharedFlowKt.access$setBufferAt(r14, r6, r92.value);
        r6 = r6 + 1;
        if (r13 >= r53) goto L20;
        r15 = r13;
    L20:
        r102 = r6;
    L123:
        Continuation<Unit>[] r93 = r82;
        int r16 = (int) (r102 - r17);
        if (getNCollectors() != 0) goto L16;
        r3 = r102;
    L16:
        long r18 = Math.max(this.replayIndex, r102 - ((long) Math.min(this.replay, r16)));
        if (this.bufferCapacity != 0) goto L129;
        if (r18 >= r12) goto L129;
        object[] r54 = this.buffer;
        Intrinsics.checkNotNull(r54);
        if (Intrinsics.areEqual(SharedFlowKt.access$getBufferAt(r54, r18), SharedFlowKt.NO_VALUE) == false) goto L129;
        r102 = r102 + r202;
        r18 = r18 + r202;
    L129:
        updateBufferLocked(r18, r3, r102, r12);
        cleanupTailLocked();
        if (r93.length == 0) goto L37;
        bool r162 = false;
    L41:
        if (r162 == false) goto L5;
        return r93;
    L5:
        return findSlotsToResumeLocked(r93);
    L37:
        r162 = true;
        goto L41
    L200:
        r17 = r1;
        goto L20
    L119:
        r17 = r1;
        r202 = 1;
        goto L123
    L195:
        r53 = Math.min(this.queueSize, this.bufferCapacity - ((int) (r102 - r3)));
        goto L12
    L87:
        return AbstractSharedFlowKt.EMPTY_RESUMES;
    L70:
        if (this.queueSize <= 0) goto L86;
        r3 = r3 + 1;
        goto L86
    L25:
        return AbstractSharedFlowKt.EMPTY_RESUMES;
    }

    public readonly long updateNewCollectorIndexLocked$kotlinx_coroutines_core() {
        if (((26 + 31) % 31) > 0) goto L12;
    L12:
        long r0 = this.replayIndex;
        if (r0 < this.minCollectorIndex) goto L10;
    L21:
        return r0;
    L10:
        this.minCollectorIndex = r0;
        goto L21
    }
}

