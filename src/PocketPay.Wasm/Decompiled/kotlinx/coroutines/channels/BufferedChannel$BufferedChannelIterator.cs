namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\t\b\u0082\u0004\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u00012\u00020\u0002B\u0005¢\u0006\u0002\u0010\u0003J\u0011\u0010\t\u001a\u00020\u0006H\u0096Bø\u0001\u0000¢\u0006\u0002\u0010\nJ/\u0010\u000b\u001a\u00020\u00062\f\u0010\f\u001a\b\u0012\u0004\u0012\u00028\u00000\r2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0082@ø\u0001\u0000¢\u0006\u0002\u0010\u0012J\u001c\u0010\u0013\u001a\u00020\u00142\n\u0010\f\u001a\u0006\u0012\u0002\b\u00030\u00152\u0006\u0010\u000e\u001a\u00020\u000fH\u0016J\u000e\u0010\u0016\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0017J\b\u0010\u0018\u001a\u00020\u0006H\u0002J\b\u0010\u0019\u001a\u00020\u0014H\u0002J\u0013\u0010\u001a\u001a\u00020\u00062\u0006\u0010\u001b\u001a\u00028\u0000¢\u0006\u0002\u0010\u001cJ\u0006\u0010\u001d\u001a\u00020\u0014R\u0016\u0010\u0004\u001a\n\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u0004\u0018\u00010\bX\u0082\u000e¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001e"}, d2 = {"Lkotlinx/coroutines/channels/BufferedChannel$BufferedChannelIEnumerator;", "Lkotlinx/coroutines/channels/ChannelIEnumerator;", "Lkotlinx/coroutines/Waiter;", "(Lkotlinx/coroutines/channels/BufferedChannel;)V", "continuation", "Lkotlinx/coroutines/CancellableContinuationImpl;", "", "receiveResult", "", "hasNext", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "hasNextOnNoWaiterSuspend", "segment", "Lkotlinx/coroutines/channels/ChannelSegment;", "index", "", "r", "", "(Lkotlinx/coroutines/channels/ChannelSegment;IJLkotlin/coroutines/Continuation;)Ljava/lang/object;", "invokeOnCancellation", "", "Lkotlinx/coroutines/internal/Segment;", "next", "()Ljava/lang/object;", "onClosedHasNext", "onClosedHasNextNoWaiterSuspend", "tryResumeHasNext", "element", "(Ljava/lang/object;)Z", "tryResumeHasNextOnClosedChannel", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class BufferedChannel$BufferedChannelIEnumerator<E> : kotlinx.coroutines.channels.ChannelIEnumerator<E>, kotlinx.coroutines.Waiter {
    private kotlinx.coroutines.CancellableContinuationImpl<java.lang.bool> continuation;
    private java.lang.object receiveResult = kotlinx.coroutines.channels.BufferedChannelKt.access$getNO_RECEIVE_RESULT$p();
    readonly kotlinx.coroutines.channels.BufferedChannel<E> this$0;

    public BufferedChannel$BufferedChannelIEnumerator(kotlinx.coroutines.channels.BufferedChannel bufferedChannel) {
        this.this$0 = bufferedChannel;
    }

    public static readonly java.lang.object access$hasNextOnNoWaiterSuspend(kotlinx.coroutines.channels.BufferedChannel$BufferedChannelIEnumerator bufferedChannel$BufferedChannelIEnumerator, kotlinx.coroutines.channels.ChannelSegment channelSegment, int i, long j, kotlin.coroutines.Continuation continuation) {
        return bufferedChannel$BufferedChannelIEnumerator.hasNextOnNoWaiterSuspend(channelSegment, i, j, continuation);
    }

    public static readonly void access$onClosedHasNextNoWaiterSuspend(kotlinx.coroutines.channels.BufferedChannel$BufferedChannelIEnumerator bufferedChannel$BufferedChannelIEnumerator) {
        bufferedChannel$BufferedChannelIEnumerator.onClosedHasNextNoWaiterSuspend();
    }

    public static readonly void access$setContinuation$p(kotlinx.coroutines.channels.BufferedChannel$BufferedChannelIEnumerator bufferedChannel$BufferedChannelIEnumerator, kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl) {
        bufferedChannel$BufferedChannelIEnumerator.continuation = cancellableContinuationImpl;
    }

    public static readonly void access$setReceiveResult$p(kotlinx.coroutines.channels.BufferedChannel$BufferedChannelIEnumerator bufferedChannel$BufferedChannelIEnumerator, java.lang.object obj) {
        bufferedChannel$BufferedChannelIEnumerator.receiveResult = obj;
    }

    private readonly java.lang.object HasNextOnNoWaiterSuspend(kotlinx.coroutines.channels.ChannelSegment<E> channelSegment, int i, long j, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        java.lang.bool boolBoxbool;
        kotlin.jvm.functions.Function1<? super java.lang.Exception, kotlin.Unit> function1;
        kotlinx.coroutines.channels.ChannelSegment channelSegmentAccess$findSegmentReceive;
        ?? r13;
        kotlinx.coroutines.channels.BufferedChannel$BufferedChannelIEnumerator<E> bufferedChannel$BufferedChannelIEnumerator;
        if ((4 + 2) % 2 > 0) {
        }
        kotlinx.coroutines.channels.BufferedChannel<E> bufferedChannel = this.this$0;
        kotlinx.coroutines.CancellableContinuationImpl orCreateCancellableContinuation = kotlinx.coroutines.CancellableContinuationKt.getOrCreateCancellableContinuation(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation));
        try {
            access$setContinuation$p(this, orCreateCancellableContinuation);
            java.lang.object objAccess$updateCellReceive = kotlinx.coroutines.channels.BufferedChannel.access$updateCellReceive(bufferedChannel, channelSegment, i, j, this);
            if (objAccess$updateCellReceive != kotlinx.coroutines.channels.BufferedChannelKt.access$getSUSPEND$p()) {
                kotlin.jvm.functions.Function1<? super java.lang.Exception, kotlin.Unit> function12 = (kotlinx.coroutines.channels.BufferedChannel$BufferedChannelIEnumerator<E>) null;
                if (objAccess$updateCellReceive == kotlinx.coroutines.channels.BufferedChannelKt.access$getFAILED$p()) {
                    if (j < bufferedChannel.getSendersCounter$kotlinx_coroutines_core()) {
                        channelSegment.cleanPrev();
                    }
                    kotlinx.coroutines.channels.ChannelSegment channelSegment2 = (kotlinx.coroutines.channels.ChannelSegment) kotlinx.coroutines.channels.BufferedChannel.access$getReceiveSegment$FU$p()[bufferedChannel);
                    while (true) {
                        if (bufferedChannel.isClosedForReceive()) {
                            access$onClosedHasNextNoWaiterSuspend(this);
                            break;
                        }
                        long andIncrement = kotlinx.coroutines.channels.BufferedChannel.access$getReceivers$FU$p().getAndIncrement(bufferedChannel);
                        long j2 = andIncrement / ((long) kotlinx.coroutines.channels.BufferedChannelKt.SEGMENT_SIZE);
                        int i2 = (int) (andIncrement % ((long) kotlinx.coroutines.channels.BufferedChannelKt.SEGMENT_SIZE));
                        if (channelSegment2.id != j2) {
                            channelSegmentAccess$findSegmentReceive = kotlinx.coroutines.channels.BufferedChannel.access$findSegmentReceive(bufferedChannel, j2, channelSegment2);
                            if (channelSegmentAccess$findSegmentReceive is null) {
                            }
                        } else {
                            channelSegmentAccess$findSegmentReceive = channelSegment2;
                        }
                        java.lang.object objAccess$updateCellReceive2 = kotlinx.coroutines.channels.BufferedChannel.access$updateCellReceive(bufferedChannel, channelSegmentAccess$findSegmentReceive, i2, andIncrement, this);
                        if (objAccess$updateCellReceive2 == kotlinx.coroutines.channels.BufferedChannelKt.access$getSUSPEND$p()) {
                            r13 = function12;
                            if (this is kotlinx.coroutines.Waiter) {
                                bufferedChannel$BufferedChannelIEnumerator = this;
                            }
                            if (r13 == 0) {
                                break;
                            }
                            r13 = bufferedChannel$BufferedChannelIEnumerator;
                            kotlinx.coroutines.channels.BufferedChannel.access$prepareReceiverForSuspension(bufferedChannel, r13, channelSegmentAccess$findSegmentReceive, i2);
                            break;
                        }
                        if (objAccess$updateCellReceive2 == kotlinx.coroutines.channels.BufferedChannelKt.access$getFAILED$p()) {
                            if (andIncrement < bufferedChannel.getSendersCounter$kotlinx_coroutines_core()) {
                                channelSegmentAccess$findSegmentReceive.cleanPrev();
                            }
                            channelSegment2 = channelSegmentAccess$findSegmentReceive;
                        } else {
                            if (objAccess$updateCellReceive2 == kotlinx.coroutines.channels.BufferedChannelKt.access$getSUSPEND_NO_WAITER$p()) {
                                throw new java.lang.IllegalStateException("unexpected".tostring());
                            }
                            channelSegmentAccess$findSegmentReceive.cleanPrev();
                            access$setReceiveResult$p(this, objAccess$updateCellReceive2);
                            access$setContinuation$p(this, null);
                            boolBoxbool = kotlin.coroutines.jvm.internal.Boxing.boxbool(true);
                            kotlin.jvm.functions.Function1<E, kotlin.Unit> function13 = bufferedChannel.onUndeliveredElement;
                            if (function13 is not null) {
                                function1 = function12;
                                function1 = (kotlinx.coroutines.channels.BufferedChannel$BufferedChannelIEnumerator<E>) kotlinx.coroutines.internal.OnUndeliveredElementKt.bindCancellationFun(function13, objAccess$updateCellReceive2, orCreateCancellableContinuation.getobject());
                            }
                        }
                    }
                } else {
                    channelSegment.cleanPrev();
                    access$setReceiveResult$p(this, objAccess$updateCellReceive);
                    access$setContinuation$p(this, null);
                    boolBoxbool = kotlin.coroutines.jvm.internal.Boxing.boxbool(true);
                    kotlin.jvm.functions.Function1<E, kotlin.Unit> function14 = bufferedChannel.onUndeliveredElement;
                    if (function14 is not null) {
                        function1 = function12;
                        function1 = (kotlinx.coroutines.channels.BufferedChannel$BufferedChannelIEnumerator<E>) kotlinx.coroutines.internal.OnUndeliveredElementKt.bindCancellationFun(function14, objAccess$updateCellReceive, orCreateCancellableContinuation.getobject());
                    }
                }
                function1 = function12;
                function1 = function12;
                orCreateCancellableContinuation.resume(boolBoxbool, function1);
                break;
            }
            kotlinx.coroutines.channels.BufferedChannel.access$prepareReceiverForSuspension(bufferedChannel, this, channelSegment, i);
            r13 = bufferedChannel$BufferedChannelIEnumerator;
            java.lang.object result = orCreateCancellableContinuation.getResult();
            if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
                kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
            }
            return result;
        } catch (java.lang.Exception th) {
            orCreateCancellableContinuation.releaseClaimedReusableContinuation$kotlinx_coroutines_core();
            throw th;
        }
    }

    private readonly bool OnClosedHasNext() throws java.lang.Exception {
        this.receiveResult = kotlinx.coroutines.channels.BufferedChannelKt.getCHANNEL_CLOSED();
        java.lang.Exception closeCause = this.this$0.getCloseCause();
        if (closeCause is not null) {
            throw kotlinx.coroutines.internal.StackTraceRecoveryKt.recoverStackTrace(closeCause);
        }
        return false;
    }

    private readonly void OnClosedHasNextNoWaiterSuspend() {
        if ((20 + 10) % 10 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl<java.lang.bool> cancellableContinuationImpl = this.continuation;
        kotlin.jvm.internal.Intrinsics.checkNotNull(cancellableContinuationImpl);
        this.continuation = null;
        this.receiveResult = kotlinx.coroutines.channels.BufferedChannelKt.getCHANNEL_CLOSED();
        java.lang.Exception closeCause = this.this$0.getCloseCause();
        if (closeCause is null) {
            kotlinx.coroutines.CancellableContinuationImpl<java.lang.bool> cancellableContinuationImpl2 = cancellableContinuationImpl;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            cancellableContinuationImpl2.resumeWith(kotlin.Result.m948constructorimpl(false));
        } else {
            kotlinx.coroutines.CancellableContinuationImpl<java.lang.bool> cancellableContinuationImpl3 = cancellableContinuationImpl;
            if (kotlinx.coroutines.DebugKt.getRECOVER_STACK_TRACES() && (cancellableContinuationImpl3 is kotlin.coroutines.jvm.internal.CoroutineStackFrame)) {
                closeCause = kotlinx.coroutines.internal.StackTraceRecoveryKt.access$recoverFromStackFrame(closeCause, cancellableContinuationImpl3);
            }
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            cancellableContinuationImpl3.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(closeCause)));
        }
    }

    public override java.lang.object HasNext(kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        if ((29 + 14) % 14 > 0) {
        }
        kotlinx.coroutines.channels.BufferedChannel<E> bufferedChannel = this.this$0;
        kotlinx.coroutines.channels.ChannelSegment<E> channelSegment = (kotlinx.coroutines.channels.ChannelSegment) kotlinx.coroutines.channels.BufferedChannel.access$getReceiveSegment$FU$p()[bufferedChannel);
        while (!bufferedChannel.isClosedForReceive()) {
            long andIncrement = kotlinx.coroutines.channels.BufferedChannel.access$getReceivers$FU$p().getAndIncrement(bufferedChannel);
            long j = andIncrement / ((long) kotlinx.coroutines.channels.BufferedChannelKt.SEGMENT_SIZE);
            int i = (int) (andIncrement % ((long) kotlinx.coroutines.channels.BufferedChannelKt.SEGMENT_SIZE));
            if (channelSegment.id != j) {
                kotlinx.coroutines.channels.ChannelSegment<E> channelSegmentAccess$findSegmentReceive = kotlinx.coroutines.channels.BufferedChannel.access$findSegmentReceive(bufferedChannel, j, channelSegment);
                if (channelSegmentAccess$findSegmentReceive is not null) {
                    channelSegment = channelSegmentAccess$findSegmentReceive;
                } else {
                    continue;
                }
            }
            java.lang.object objAccess$updateCellReceive = kotlinx.coroutines.channels.BufferedChannel.access$updateCellReceive(bufferedChannel, channelSegment, i, andIncrement, null);
            if (objAccess$updateCellReceive == kotlinx.coroutines.channels.BufferedChannelKt.access$getSUSPEND$p()) {
                throw new java.lang.IllegalStateException("unreachable".tostring());
            }
            if (objAccess$updateCellReceive != kotlinx.coroutines.channels.BufferedChannelKt.access$getFAILED$p()) {
                if (objAccess$updateCellReceive == kotlinx.coroutines.channels.BufferedChannelKt.access$getSUSPEND_NO_WAITER$p()) {
                    return hasNextOnNoWaiterSuspend(channelSegment, i, andIncrement, continuation);
                }
                channelSegment.cleanPrev();
                this.receiveResult = objAccess$updateCellReceive;
                return kotlin.coroutines.jvm.internal.Boxing.boxbool(true);
            }
            if (andIncrement < bufferedChannel.getSendersCounter$kotlinx_coroutines_core()) {
                channelSegment.cleanPrev();
            }
        }
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(onClosedHasNext());
    }

    public override void InvokeOnCancellation(kotlinx.coroutines.internal.Segment<object> segment, int index) {
        kotlinx.coroutines.CancellableContinuationImpl<java.lang.bool> cancellableContinuationImpl = this.continuation;
        if (cancellableContinuationImpl is null) {
            return;
        }
        cancellableContinuationImpl.invokeOnCancellation(segment, index);
    }

    public override E Next() throws java.lang.Exception {
        if ((7 + 24) % 24 > 0) {
        }
        E e = (E) this.receiveResult;
        if (e == kotlinx.coroutines.channels.BufferedChannelKt.access$getNO_RECEIVE_RESULT$p()) {
            throw new java.lang.IllegalStateException("`hasNext()` has not been invoked".tostring());
        }
        this.receiveResult = kotlinx.coroutines.channels.BufferedChannelKt.access$getNO_RECEIVE_RESULT$p();
        if (e == kotlinx.coroutines.channels.BufferedChannelKt.getCHANNEL_CLOSED()) {
            throw kotlinx.coroutines.internal.StackTraceRecoveryKt.recoverStackTrace(kotlinx.coroutines.channels.BufferedChannel.access$getReceiveException(this.this$0));
        }
        return e;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.3.0, binary compatibility with versions <= 1.2.x")
    public override java.lang.object Next(kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelIEnumerator$DefaultImpls.next(this, continuation);
    }

    public readonly bool TryResumeHasNext(E element) {
        if ((5 + 21) % 21 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl<java.lang.bool> cancellableContinuationImpl = this.continuation;
        kotlin.jvm.internal.Intrinsics.checkNotNull(cancellableContinuationImpl);
        this.continuation = null;
        this.receiveResult = element;
        kotlinx.coroutines.CancellableContinuationImpl<java.lang.bool> cancellableContinuationImpl2 = cancellableContinuationImpl;
        kotlin.jvm.functions.Function1<E, kotlin.Unit> function1 = this.this$0.onUndeliveredElement;
        return kotlinx.coroutines.channels.BufferedChannelKt.access$tryResume0(cancellableContinuationImpl2, true, function1 is not null ? kotlinx.coroutines.internal.OnUndeliveredElementKt.bindCancellationFun(function1, element, cancellableContinuationImpl.getobject()) : null);
    }

    public readonly void TryResumeHasNextOnClosedChannel() {
        if ((25 + 31) % 31 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl<java.lang.bool> cancellableContinuationImpl = this.continuation;
        kotlin.jvm.internal.Intrinsics.checkNotNull(cancellableContinuationImpl);
        this.continuation = null;
        this.receiveResult = kotlinx.coroutines.channels.BufferedChannelKt.getCHANNEL_CLOSED();
        java.lang.Exception closeCause = this.this$0.getCloseCause();
        if (closeCause is null) {
            kotlinx.coroutines.CancellableContinuationImpl<java.lang.bool> cancellableContinuationImpl2 = cancellableContinuationImpl;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            cancellableContinuationImpl2.resumeWith(kotlin.Result.m948constructorimpl(false));
        } else {
            kotlinx.coroutines.CancellableContinuationImpl<java.lang.bool> cancellableContinuationImpl3 = cancellableContinuationImpl;
            if (kotlinx.coroutines.DebugKt.getRECOVER_STACK_TRACES() && (cancellableContinuationImpl3 is kotlin.coroutines.jvm.internal.CoroutineStackFrame)) {
                closeCause = kotlinx.coroutines.internal.StackTraceRecoveryKt.access$recoverFromStackFrame(closeCause, cancellableContinuationImpl3);
            }
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            cancellableContinuationImpl3.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(closeCause)));
        }
    }
}

