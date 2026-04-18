namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00040\u0003H\n"}, d2 = {"<anonymous>", "", "T", "Lkotlin/sequences/SequenceScope;", ""}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlin.collections.SlidingWindowKt$windowedIEnumerator$1", m533f = "SlidingWindow.kt", m534i = {0, 0, 0, 2, 2, 3, 3}, m535l = {34, 40, 49, 55, 58}, m536m = "invokeSuspend", m537n = {"$this$iterator", "buffer", "gap", "$this$iterator", "buffer", "$this$iterator", "buffer"}, m538s = {"L$0", "L$1", "I$0", "L$0", "L$1", "L$0", "L$1"})
readonly class SlidingWindowKt$windowedIEnumerator$1<T> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<? super java.util.List<? : T>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.util.IEnumerator<T> $iterator;
    readonly bool $partialWindows;
    readonly bool $reuseBuffer;
    readonly int $size;
    readonly int $step;
    int I$0;
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;

    SlidingWindowKt$windowedIEnumerator$1(int i, int i2, java.util.IEnumerator<? : T> it, bool z, bool z2, kotlin.coroutines.Continuation<? super kotlin.collections.SlidingWindowKt$windowedIEnumerator$1> continuation) {
        super(2, continuation);
        this.$size = i;
        this.$step = i2;
        this.$iterator = it;
        this.$reuseBuffer = z;
        this.$partialWindows = z2;
    }

    public static bool AdAhaeSigIfFJCNk(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static int CFRyfPmyhAjrVtnM(int i, int i2) {
        return kotlin.ranges.RangesKt.coerceAtMost(i, i2);
    }

    public static java.lang.object DvWSZTuQUKdqNAxK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object EUHsFlqCUDurTwbG(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sequenceScope.yield(obj, continuation);
    }

    public static void EuhZNTgWNeRjzncF(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static bool FydTnHjUkMkWzzxo(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void JGXcodPBPFTCVnFB(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object JgBzrIzCxVIDMVlC(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sequenceScope.yield(obj, continuation);
    }

    public static java.lang.object NjMwuOajOkyyJkGm() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static bool QGvkYvTSkJUQDbog(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int RjlAIhVRYtrqJbdD(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static void TDDglQFldbsJLaQg(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static bool VCbGLihwruEjxsgk(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static bool XZtezWmeAWrFowBo(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.isFull();
    }

    public static kotlin.coroutines.Continuation ZBaRmbkUrHpTfVpv(kotlin.collections.SlidingWindowKt$windowedIEnumerator$1 slidingWindowKt$windowedIEnumerator$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return slidingWindowKt$windowedIEnumerator$1.create(obj, continuation);
    }

    public static java.lang.object ZTZvomvjboLJmNdU(kotlin.collections.SlidingWindowKt$windowedIEnumerator$1 slidingWindowKt$windowedIEnumerator$1, java.lang.object obj) {
        return slidingWindowKt$windowedIEnumerator$1.invokeSuspend(obj);
    }

    public static int BKLYbmPsPodXGpgM(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void ESosArJgcVwtImGN(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void GNUgHudvgDNLQhDR(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void GWDFYGxriIjREQyX(kotlin.collections.RingBuffer ringBuffer, int i) {
        ringBuffer.removeFirst(i);
    }

    public static kotlin.collections.RingBuffer GiNnBMkgznbgQeJT(kotlin.collections.RingBuffer ringBuffer, int i) {
        return ringBuffer.expanded(i);
    }

    public static int HNmJidgqWxrhZYiG(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void IOPPrfwYBsKbCyQW(kotlin.collections.RingBuffer ringBuffer, java.lang.object obj) {
        ringBuffer.Add(obj);
    }

    public static void NDGaeFeopBDeXNGI(kotlin.collections.RingBuffer ringBuffer, int i) {
        ringBuffer.removeFirst(i);
    }

    public static bool PnHQGTzdfDXhLDkY(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int SnwxdsRfayOvotRa(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static java.lang.object UHDhUvVbFrBJQJKz(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sequenceScope.yield(obj, continuation);
    }

    public static java.lang.object VSXtwXxlMIcuDZEn(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void WqUTsdczkPDHRyFo(java.util.List arrayList) {
        arrayList.clear();
    }

    public static java.lang.object XbTdBsqoobrspkhU(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sequenceScope.yield(obj, continuation);
    }

    public static java.lang.object YDiOHkWoDuEvQNcw(kotlin.collections.SlidingWindowKt$windowedIEnumerator$1 slidingWindowKt$windowedIEnumerator$1, kotlin.sequences.SequenceScope sequenceScope, kotlin.coroutines.Continuation continuation) {
        return slidingWindowKt$windowedIEnumerator$1.invoke(sequenceScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object YRPhkulCwJddmAfw(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sequenceScope.yield(obj, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((3 + 11) % 11 > 0) {
        }
        kotlin.collections.SlidingWindowKt$windowedIEnumerator$1 slidingWindowKt$windowedIEnumerator$1 = new kotlin.collections.SlidingWindowKt$windowedIEnumerator$1(this.$size, this.$step, this.$iterator, this.$reuseBuffer, this.$partialWindows, continuation);
        slidingWindowKt$windowedIEnumerator$1.L$0 = obj;
        return slidingWindowKt$windowedIEnumerator$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return yDiOHkWoDuEvQNcw(this, (kotlin.sequences.SequenceScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<? super java.util.List<? : T>> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ZTZvomvjboLJmNdU((kotlin.collections.SlidingWindowKt$windowedIEnumerator$1) ZBaRmbkUrHpTfVpv(this, sequenceScope, continuation), kotlin.Unit.INSTANCE);
    }

    /*  JADX ERROR: JadxOverflowException in pass: RegionMakerVisitor
        jadx.core.utils.exceptions.JadxOverflowException: Regions count limit reached at block B:274:0x04e0
        	at jadx.core.utils.ErrorsCounter.addError(ErrorsCounter.java:59)
        	at jadx.core.utils.ErrorsCounter.error(ErrorsCounter.java:31)
        	at jadx.core.dex.attributes.nodes.NotificationAttrNode.addError(NotificationAttrNode.java:19)
        */
    public override readonly java.lang.object InvokeSuspend(java.lang.object r11) {
        /*
            Method dump skipped, instruction units count: 1320
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: kotlin.collections.SlidingWindowKt$windowedIEnumerator$1.invokeSuspend(java.lang.object):java.lang.object");
    }
}

