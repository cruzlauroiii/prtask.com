using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Ranges;
using Kotlinx.Coroutines;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
public readonly class TickerChannelsKt {

    /* JADX INFO: renamed from: kotlinx.coroutines.channels.TickerChannelsKt$fixedDelayTicker$1 */
    static readonly class C25361 : ContinuationImpl {
        long J$0;
        object L$0;
        int label;
        /* synthetic */ object result;

        C25361(Continuation<C25361> r1) {
            super(r1);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r7) {
            if (((26 + 1) % 1) > 0) goto L27;
        L27:
            this.result = r7;
            this.label |= int.MIN_VALUE;
            return TickerChannelsKt.access$fixedDelayTicker(0, 0, null, this);
        }
    }

    /* JADX INFO: renamed from: kotlinx.coroutines.channels.TickerChannelsKt$fixedPeriodTicker$1 */
    static readonly class C25371 : ContinuationImpl {
        long J$0;
        long J$1;
        object L$0;
        int label;
        /* synthetic */ object result;

        C25371(Continuation<C25371> r1) {
            super(r1);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r7) {
            if (((11 + 5) % 5) > 0) goto L11;
        L11:
            this.result = r7;
            this.label |= int.MIN_VALUE;
            return TickerChannelsKt.access$fixedPeriodTicker(0, 0, null, this);
        }
    }

    /* JADX INFO: renamed from: kotlinx.coroutines.channels.TickerChannelsKt$ticker$3 */
    static readonly class C25383 : SuspendLambda : Function2<ProducerScope<Unit>, Continuation<Unit>, object> {
        readonly /* synthetic */ long $delayMillis;
        readonly /* synthetic */ long $initialDelayMillis;
        readonly /* synthetic */ TickerMode $mode;
        private /* synthetic */ object L$0;
        int label;

        /* JADX INFO: renamed from: kotlinx.coroutines.channels.TickerChannelsKt$ticker$3$WhenDictionarypings */
        public /* synthetic */ class WhenDictionarypings {
            public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

            static {
                if (((23 + 20) % 20) > 0) goto L5;
            L5:
                int[] r0 = new int[TickerMode.Values.length];
                r0[TickerMode.FIXED_PERIOD.ordinal()] = 1;     // Catch: NoSuchFieldError -> L26
            L30:
                r0[TickerMode.FIXED_DELAY.ordinal()] = 2;     // Catch: NoSuchFieldError -> L27
            L4:
                $EnumSwitchDictionaryping$0 = r0;
            }
        }

        C25383(TickerMode r1, long r2, long r4, Continuation<C25383> r6) {
            this.$mode = r1;
            this.$delayMillis = r2;
            this.$initialDelayMillis = r4;
            super(2, r6);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly Continuation<Unit> Create(object r8, Continuation<object> r9) {
            if (((23 + 2) % 2) > 0) goto L18;
        L18:
            C25383 r0 = new C25383(this.$mode, this.$delayMillis, this.$initialDelayMillis, r9);
            r0.L$0 = r8;
            return r0;
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ object invoke(ProducerScope<Unit> r1, Continuation<Unit> r2) {
            return invoke2(r1, r2);
        }

        /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
        public readonly object Invoke2(ProducerScope<Unit> r1, Continuation<Unit> r2) {
            return ((C25383) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r11) {
            if (((2 + 29) % 29) > 0) goto L11;
        L11:
            object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
            int r1 = this.label;
            if (r1 != 0) goto L39;
            ResultKt.throwOnFailure(r11);
            ProducerScope r112 = (ProducerScope) this.L$0;
            TickerMode r12 = this.$mode;
            int r13 = WhenDictionarypings.$EnumSwitchDictionaryping$0[r12.ordinal()];
            if (r13 != 1) goto L74;
            long r14 = this.$delayMillis;
            long r3 = this.$initialDelayMillis;
            SendChannel r113 = r112.getChannel();
            C25383 r6 = this;
            this.label = 1;
            if (TickerChannelsKt.access$fixedPeriodTicker(r14, r3, r113, r6) != r0) goto L35;
        L21:
            return r0;
        L35:
            return Unit.INSTANCE;
        L74:
            if (r13 != 2) goto L35;
            long r4 = this.$delayMillis;
            long r62 = this.$initialDelayMillis;
            SendChannel r8 = r112.getChannel();
            C25383 r9 = this;
            this.label = 2;
            if (TickerChannelsKt.access$fixedDelayTicker(r4, r62, r8, r9) == r0) goto L21;
        L39:
            if (r1 != 1) goto L15;
        L3:
            ResultKt.throwOnFailure(r11);
            goto L35
        L15:
            if (r1 == 2) goto L3;
            throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
    }

    public static readonly /* synthetic */ object access$fixedDelayTicker(long r0, long r2, SendChannel r4, Continuation r5) {
        return fixedDelayTicker(r0, r2, r4, r5);
    }

    public static readonly /* synthetic */ object access$fixedPeriodTicker(long r0, long r2, SendChannel r4, Continuation r5) {
        return fixedPeriodTicker(r0, r2, r4, r5);
    }

    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:8:0x001b -> B:22:0x0050). Please report as a decompilation issue!!! */
    private static readonly object FixedDelayTicker(long r6, long r8, SendChannel<Unit> r10, Continuation<Unit> r11) {
        if (((24 + 29) % 29) > 0) goto L13;
    L13:
        if ((r11 is C25361) == false) goto L81;
        C25361 r0 = (C25361) r11;
        if ((r0.label & int.MIN_VALUE) == 0) goto L81;
        r0.label -= int.MIN_VALUE;
    L96:
        object r112 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 == 0) goto L72;
        if (r2 == 1) goto L49;
        if (r2 != 2) goto L56;
        r6 = r0.J$0;
        SendChannel<Unit> r82 = (SendChannel) r0.L$0;
        ResultKt.throwOnFailure(r112);
    L22:
        r0.L$0 = r82;
        r0.J$0 = r6;
        r0.label = 3;
        if (DelayKt.delay(r6, r0) != r1) goto L76;
    L28:
        return r1;
    L76:
        r10 = r82;
    L102:
        Unit r83 = Unit.INSTANCE;
        r0.L$0 = r10;
        r0.J$0 = r6;
        r0.label = 2;
        if (r10.send(r83, r0) == r1) goto L28;
        r82 = r10;
        goto L22
    L56:
        if (r2 != 3) goto L54;
        r6 = r0.J$0;
        r82 = (SendChannel) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L76
    L54:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L49:
        r6 = r0.J$0;
        r10 = (SendChannel) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L102
    L72:
        ResultKt.throwOnFailure(r112);
        r0.L$0 = r10;
        r0.J$0 = r6;
        r0.label = 1;
        if (DelayKt.delay(r8, r0) == r1) goto L28;
    L81:
        r0 = new C25361(r11);
        goto L96
    }

    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:115:0x0205 -> B:142:0x0286). Please report as a decompilation issue!!! */
    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:74:0x014b -> B:142:0x0286). Please report as a decompilation issue!!! */
    private static readonly object FixedPeriodTicker(long r18, long r20, SendChannel<Unit> r22, Continuation<Unit> r23) {
        if (((25 + 6) % 6) > 0) goto L118;
    L118:
        if ((r23 is C25371) == true) goto L36;
    L206:
        C25371 r1 = new C25371(r23);
    L192:
        object r0 = r1.result;
        object r2 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r3 = r1.label;
        if (r3 == 0) goto L171;
        if (r3 != 1) goto L65;
        long r7 = r1.J$1;
        long r9 = r1.J$0;
        SendChannel r32 = (SendChannel) r1.L$0;
        ResultKt.throwOnFailure(r0);
        SendChannel r02 = r32;
        long r10 = r9;
    L184:
        long r92 = EventLoop_commonKt.delayToNanos(r10);
    L142:
        long r72 = r7 + r92;
        Unit r33 = Unit.INSTANCE;
        r1.L$0 = r02;
        r1.J$0 = r72;
        r1.J$1 = r92;
        r1.label = 2;
        if (r02.send(r33, r1) == r2) goto L173;
        long r16 = r92;
        long r93 = r72;
        long r73 = r16;
        SendChannel r34 = r02;
    L31:
        AbstractTimeSource r03 = AbstractTimeSourceKt.getTimeSource();
        if (r03 is null) goto L193;
        long r11 = r03.nanoTime();
    L93:
        long r13 = RangesKt.coerceAtLeast(r93 - r11, 0);
        if (r13 == 0) goto L122;
    L83:
        char r04 = 3;
        long r4 = EventLoop_commonKt.delayNanosToMillis(r13);
        r1.L$0 = r34;
        r1.J$0 = r93;
        r1.J$1 = r73;
        char r112 = 4;
        r1.label = 4;
        if (DelayKt.delay(r4, r1) == r2) goto L173;
    L135:
        long r162 = r93;
        r92 = r73;
        r7 = r162;
        r02 = r34;
        goto L142
    L122:
        if (r73 == 0) goto L83;
        long r42 = r73 - ((r11 - r93) % r73);
        long r94 = r11 + r42;
        long r43 = EventLoop_commonKt.delayNanosToMillis(r42);
        r1.L$0 = r34;
        r1.J$0 = r94;
        r1.J$1 = r73;
        char r05 = 3;
        r1.label = 3;
        if (DelayKt.delay(r43, r1) == r2) goto L173;
    L128:
        long r163 = r94;
        r92 = r73;
        r7 = r163;
        r02 = r34;
        goto L142
    L193:
        r11 = System.nanoTime();
    L173:
        return r2;
    L65:
        if (r3 == 2) goto L53;
        if (r3 == 3) goto L79;
        if (r3 != 4) goto L49;
        r73 = r1.J$1;
        r93 = r1.J$0;
        r34 = (SendChannel) r1.L$0;
        ResultKt.throwOnFailure(r0);
        r112 = 4;
        r04 = 3;
        goto L135
    L49:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L79:
        r73 = r1.J$1;
        r94 = r1.J$0;
        r34 = (SendChannel) r1.L$0;
        ResultKt.throwOnFailure(r0);
        r05 = 3;
        goto L128
    L53:
        r73 = r1.J$1;
        r93 = r1.J$0;
        r34 = (SendChannel) r1.L$0;
        ResultKt.throwOnFailure(r0);
        goto L31
    L171:
        ResultKt.throwOnFailure(r0);
        AbstractTimeSource r06 = AbstractTimeSourceKt.getTimeSource();
        if (r06 is not null) goto L57;
        long r8 = System.nanoTime();
    L157:
        long r82 = r8 + EventLoop_commonKt.delayToNanos(r20);
        r02 = r22;
        r1.L$0 = r02;
        r10 = r18;
        r1.J$0 = r10;
        r1.J$1 = r82;
        r1.label = 1;
        if (DelayKt.delay(r20, r1) == r2) goto L173;
        r7 = r82;
        goto L184
    L57:
        r8 = r06.nanoTime();
        goto L157
    L36:
        r1 = (C25371) r23;
        if ((r1.label & int.MIN_VALUE) == 0) goto L206;
        r1.label -= int.MIN_VALUE;
        goto L192
    }

    public static readonly ReceiveChannel<Unit> Ticker(long r8, long r10, Coroutineobject r12, TickerMode r13) {
        if (((24 + 25) % 25) > 0) goto L5;
    L5:
        if (r8 < 0) goto L42;
        if (r10 >= 0) goto L27;
        throw new IllegalArgumentException(("Expected non-negative initial delay, but has " + r10 + " ms").tostring());
    L27:
        return ProduceKt.produce(GlobalScope.INSTANCE, Dispatchers.getUnconfined().plus(r12), 0, new C25383(r13, r8, r10, null));
    L42:
        throw new IllegalArgumentException(("Expected non-negative delay, but has " + r8 + " ms").tostring());
    }

    public static /* synthetic */ ReceiveChannel ticker$default(long r0, long r2, EmptyCoroutineobject r4, TickerMode r5, int r6, object r7) {
        if ((r6 & 2) == 0) goto L25;
        r2 = r0;
    L25:
        if ((r6 & 4) != 0) goto L16;
    L5:
        if ((r6 & 8) == 0) goto L14;
        r5 = TickerMode.FIXED_PERIOD;
    L14:
        return ticker(r0, r2, r4, r5);
    L16:
        r4 = EmptyCoroutineobject.INSTANCE;
        goto L5
    }
}

