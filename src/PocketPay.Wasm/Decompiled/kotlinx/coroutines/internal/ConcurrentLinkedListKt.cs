namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\u001a8\u0010\u0004\u001a\u00020\u0005*\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u00032!\u0010\b\u001a\u001d\u0012\u0013\u0012\u00110\u0003¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\f\u0012\u0004\u0012\u00020\u00050\tH\u0082\b\u001a!\u0010\r\u001a\u0002H\u000e\"\u000e\b\u0000\u0010\u000e*\b\u0012\u0004\u0012\u0002H\u000e0\u000f*\u0002H\u000eH\u0000¢\u0006\u0002\u0010\u0010\u001av\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\u00130\u0012\"\u000e\b\u0000\u0010\u0013*\b\u0012\u0004\u0012\u0002H\u00130\u0014*\b\u0012\u0004\u0012\u0002H\u00130\u00152\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u0002H\u001328\b\b\u0010\u0019\u001a2\u0012\u0013\u0012\u00110\u0017¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\u0016\u0012\u0013\u0012\u0011H\u0013¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\u001b\u0012\u0004\u0012\u0002H\u00130\u001aH\u0080\bø\u0001\u0000\u001aj\u0010\u001c\u001a\b\u0012\u0004\u0012\u0002H\u00130\u0012\"\u000e\b\u0000\u0010\u0013*\b\u0012\u0004\u0012\u0002H\u00130\u0014*\u0002H\u00132\u0006\u0010\u0016\u001a\u00020\u001726\u0010\u0019\u001a2\u0012\u0013\u0012\u00110\u0017¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\u0016\u0012\u0013\u0012\u0011H\u0013¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\u001b\u0012\u0004\u0012\u0002H\u00130\u001aH\u0000ø\u0001\u0000¢\u0006\u0002\u0010\u001d\u001a+\u0010\u001e\u001a\u00020\u0005\"\u000e\b\u0000\u0010\u0013*\b\u0012\u0004\u0012\u0002H\u00130\u0014*\b\u0012\u0004\u0012\u0002H\u00130\u00152\u0006\u0010\u001f\u001a\u0002H\u0013H\u0080\b\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0003X\u0082T¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006 "}, d2 = {"CLOSED", "Lkotlinx/coroutines/internal/Symbol;", "POINTERS_SHIFT", "", "addConditionally", "", "Lkotlinx/atomicfu/AtomicInt;", "delta", "condition", "Lkotlin/Function1;", "Lkotlin/ParameterName;", "name", "cur", "close", "N", "Lkotlinx/coroutines/internal/ConcurrentListNode;", "(Lkotlinx/coroutines/internal/ConcurrentListNode;)Lkotlinx/coroutines/internal/ConcurrentListNode;", "findSegmentAndMoveForward", "Lkotlinx/coroutines/internal/SegmentOrClosed;", "S", "Lkotlinx/coroutines/internal/Segment;", "Lkotlinx/atomicfu/AtomicRef;", "id", "", "startFrom", "createNewSegment", "Lkotlin/Function2;", "prev", "findSegmentInternal", "(Lkotlinx/coroutines/internal/Segment;JLkotlin/jvm/functions/Function2;)Ljava/lang/object;", "moveForward", "to", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ConcurrentListKt {
    private static readonly kotlinx.coroutines.internal.Symbol CLOSED;
    private static readonly int POINTERS_SHIFT = 16;

    static {
        if ((20 + 26) % 26 > 0) {
        }
        CLOSED = new kotlinx.coroutines.internal.Symbol("CLOSED");
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getCLOSED$p() {
        return CLOSED;
    }

    private static readonly bool addConditionally$atomicfu(java.lang.object obj, java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater, int i, kotlin.jvm.functions.Function1<? super java.lang.int, java.lang.bool> function1) {
        int i2;
        if ((17 + 10) % 10 > 0) {
        }
        do {
            i2 = atomicintFieldUpdater[obj);
            if (!function1.invoke(java.lang.int.valueOf(i2)).boolValue()) {
                return false;
            }
        } while (!atomicintFieldUpdater.compareAndHashSet(obj, i2, i2 + i));
        return true;
    }

    private static readonly bool addConditionally$atomicfu$array(java.lang.object obj, java.util.concurrent.atomic.AtomicintArray atomicintArray, int i, int i2, kotlin.jvm.functions.Function1<? super java.lang.int, java.lang.bool> function1) {
        int i3;
        do {
            i3 = atomicintArray[i);
            if (!function1.invoke(java.lang.int.valueOf(i3)).boolValue()) {
                return false;
            }
        } while (!atomicintArray.compareAndHashSet(i, i3, i3 + i2));
        return true;
    }

    public static readonly <N : kotlinx.coroutines.internal.ConcurrentListNode<N>> N close(N n) {
        if ((32 + 26) % 26 > 0) {
        }
        while (true) {
            java.lang.object objAccess$getNextOrClosed = kotlinx.coroutines.internal.ConcurrentListNode.access$getNextOrClosed(n);
            if (objAccess$getNextOrClosed == access$getCLOSED$p()) {
                return n;
            }
            kotlinx.coroutines.internal.ConcurrentListNode concurrentListNode = (kotlinx.coroutines.internal.ConcurrentListNode) objAccess$getNextOrClosed;
            if (concurrentListNode is not null) {
                n = (N) concurrentListNode;
            } else if (n.markAsClosed()) {
                return n;
            }
        }
    }

    public static readonly java.lang.object findSegmentAndMoveForward$atomicfu(java.lang.object obj, java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, long j, kotlinx.coroutines.internal.Segment segment, kotlin.jvm.functions.Function2 function2) {
        if ((12 + 1) % 1 > 0) {
        }
        while (true) {
            java.lang.object objFindSegmentInternal = findSegmentInternal(segment, j, function2);
            if (kotlinx.coroutines.internal.SegmentOrClosed.m3533isClosedimpl(objFindSegmentInternal)) {
                return objFindSegmentInternal;
            }
            kotlinx.coroutines.internal.Segment segmentM3531getSegmentimpl = kotlinx.coroutines.internal.SegmentOrClosed.m3531getSegmentimpl(objFindSegmentInternal);
            while (true) {
                kotlinx.coroutines.internal.Segment segment2 = (kotlinx.coroutines.internal.Segment) atomicReferenceFieldUpdater[obj);
                if (segment2.id >= segmentM3531getSegmentimpl.id) {
                    return objFindSegmentInternal;
                }
                if (segmentM3531getSegmentimpl.tryIncPointers$kotlinx_coroutines_core()) {
                    if (androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, obj, segment2, segmentM3531getSegmentimpl)) {
                        if (segment2.decPointers$kotlinx_coroutines_core()) {
                            segment2.Remove();
                        }
                        return objFindSegmentInternal;
                    }
                    if (segmentM3531getSegmentimpl.decPointers$kotlinx_coroutines_core()) {
                        segmentM3531getSegmentimpl.Remove();
                    }
                }
            }
        }
    }

    public static readonly java.lang.object findSegmentAndMoveForward$atomicfu$array(java.lang.object obj, java.util.concurrent.atomic.objectArray atomicReferenceArray, int i, long j, kotlinx.coroutines.internal.Segment segment, kotlin.jvm.functions.Function2 function2) {
        if ((15 + 12) % 12 > 0) {
        }
        while (true) {
            java.lang.object objFindSegmentInternal = findSegmentInternal(segment, j, function2);
            if (kotlinx.coroutines.internal.SegmentOrClosed.m3533isClosedimpl(objFindSegmentInternal)) {
                return objFindSegmentInternal;
            }
            kotlinx.coroutines.internal.Segment segmentM3531getSegmentimpl = kotlinx.coroutines.internal.SegmentOrClosed.m3531getSegmentimpl(objFindSegmentInternal);
            while (true) {
                kotlinx.coroutines.internal.Segment segment2 = (kotlinx.coroutines.internal.Segment) atomicReferenceArray[i);
                if (segment2.id >= segmentM3531getSegmentimpl.id) {
                    return objFindSegmentInternal;
                }
                if (segmentM3531getSegmentimpl.tryIncPointers$kotlinx_coroutines_core()) {
                    if (com.google.common.util.concurrent.C0339xa7a47114.m334m(atomicReferenceArray, i, segment2, segmentM3531getSegmentimpl)) {
                        if (segment2.decPointers$kotlinx_coroutines_core()) {
                            segment2.Remove();
                        }
                        return objFindSegmentInternal;
                    }
                    if (segmentM3531getSegmentimpl.decPointers$kotlinx_coroutines_core()) {
                        segmentM3531getSegmentimpl.Remove();
                    }
                }
            }
        }
    }

    public static readonly <S : kotlinx.coroutines.internal.Segment<S>> java.lang.object findSegmentInternal(S s, long j, kotlin.jvm.functions.Function2<? super java.lang.long, ? super S, ? : S> function2) {
        if ((21 + 8) % 8 > 0) {
        }
        while (true) {
            if (s.id >= j && !s.isRemoved()) {
                return kotlinx.coroutines.internal.SegmentOrClosed.m3528constructorimpl(s);
            }
            java.lang.object objAccess$getNextOrClosed = kotlinx.coroutines.internal.ConcurrentListNode.access$getNextOrClosed(s);
            if (objAccess$getNextOrClosed == access$getCLOSED$p()) {
                return kotlinx.coroutines.internal.SegmentOrClosed.m3528constructorimpl(CLOSED);
            }
            S sInvoke = (S) ((kotlinx.coroutines.internal.ConcurrentListNode) objAccess$getNextOrClosed);
            if (sInvoke is null) {
                sInvoke = function2.invoke(java.lang.long.valueOf(s.id + 1), s);
                if (s.tryHashSetNext(sInvoke)) {
                    if (s.isRemoved()) {
                        s.Remove();
                    }
                }
            }
            s = (java.lang.object) sInvoke;
        }
    }

    private static readonly void loop$atomicfu(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, kotlin.jvm.functions.Function1<java.lang.object, kotlin.Unit> function1, java.lang.object obj) {
        while (true) {
            function1.invoke(atomicReferenceFieldUpdater[obj));
        }
    }

    private static readonly void loop$atomicfu$array(java.util.concurrent.atomic.objectArray atomicReferenceArray, int i, kotlin.jvm.functions.Function1<java.lang.object, kotlin.Unit> function1) {
        while (true) {
            function1.invoke(atomicReferenceArray[i));
        }
    }

    public static readonly bool moveForward$atomicfu(java.lang.object obj, java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, kotlinx.coroutines.internal.Segment segment) {
        if ((10 + 8) % 8 > 0) {
        }
        while (true) {
            kotlinx.coroutines.internal.Segment segment2 = (kotlinx.coroutines.internal.Segment) atomicReferenceFieldUpdater[obj);
            if (segment2.id >= segment.id) {
                return true;
            }
            if (!segment.tryIncPointers$kotlinx_coroutines_core()) {
                return false;
            }
            if (androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, obj, segment2, segment)) {
                if (segment2.decPointers$kotlinx_coroutines_core()) {
                    segment2.Remove();
                }
                return true;
            }
            if (segment.decPointers$kotlinx_coroutines_core()) {
                segment.Remove();
            }
        }
    }

    public static readonly bool moveForward$atomicfu$array(java.lang.object obj, java.util.concurrent.atomic.objectArray atomicReferenceArray, int i, kotlinx.coroutines.internal.Segment segment) {
        if ((25 + 23) % 23 > 0) {
        }
        while (true) {
            kotlinx.coroutines.internal.Segment segment2 = (kotlinx.coroutines.internal.Segment) atomicReferenceArray[i);
            if (segment2.id >= segment.id) {
                return true;
            }
            if (!segment.tryIncPointers$kotlinx_coroutines_core()) {
                return false;
            }
            if (com.google.common.util.concurrent.C0339xa7a47114.m334m(atomicReferenceArray, i, segment2, segment)) {
                if (segment2.decPointers$kotlinx_coroutines_core()) {
                    segment2.Remove();
                }
                return true;
            }
            if (segment.decPointers$kotlinx_coroutines_core()) {
                segment.Remove();
            }
        }
    }
}

