namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u000b\b\u0010\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B9\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\"\b\u0002\u0010\u0007\u001a\u001c\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00020\t\u0018\u00010\bj\n\u0012\u0004\u0012\u00028\u0000\u0018\u0001`\n¢\u0006\u0002\u0010\u000bJ\u001e\u0010\u000f\u001a\u00020\t2\n\u0010\u0010\u001a\u0006\u0012\u0002\b\u00030\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\u0013H\u0014J\u0019\u0010\u0014\u001a\u00020\t2\u0006\u0010\u0012\u001a\u00028\u0000H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0015J\u001b\u0010\u0016\u001a\u00020\r2\u0006\u0010\u0012\u001a\u00028\u0000H\u0090@ø\u0001\u0000¢\u0006\u0004\b\u0017\u0010\u0015J\r\u0010\u0018\u001a\u00020\rH\u0010¢\u0006\u0002\b\u0019J&\u0010\u001a\u001a\b\u0012\u0004\u0012\u00020\t0\u001b2\u0006\u0010\u0012\u001a\u00028\u0000H\u0016ø\u0001\u0001ø\u0001\u0002ø\u0001\u0000¢\u0006\u0004\b\u001c\u0010\u001dJ.\u0010\u001e\u001a\b\u0012\u0004\u0012\u00020\t0\u001b2\u0006\u0010\u0012\u001a\u00028\u00002\u0006\u0010\u001f\u001a\u00020\rH\u0002ø\u0001\u0001ø\u0001\u0002ø\u0001\u0000¢\u0006\u0004\b \u0010!J&\u0010\"\u001a\b\u0012\u0004\u0012\u00020\t0\u001b2\u0006\u0010\u0012\u001a\u00028\u0000H\u0002ø\u0001\u0001ø\u0001\u0002ø\u0001\u0000¢\u0006\u0004\b#\u0010\u001dJ.\u0010$\u001a\b\u0012\u0004\u0012\u00020\t0\u001b2\u0006\u0010\u0012\u001a\u00028\u00002\u0006\u0010\u001f\u001a\u00020\rH\u0002ø\u0001\u0001ø\u0001\u0002ø\u0001\u0000¢\u0006\u0004\b%\u0010!R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\f\u001a\u00020\r8TX\u0094\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\u000eR\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u000f\n\u0002\b\u0019\n\u0002\b!\n\u0005\b¡\u001e0\u0001¨\u0006&"}, d2 = {"Lkotlinx/coroutines/channels/ConflatedBufferedChannel;", "E", "Lkotlinx/coroutines/channels/BufferedChannel;", "capacity", "", "onBufferOverflow", "Lkotlinx/coroutines/channels/BufferOverflow;", "onUndeliveredElement", "Lkotlin/Function1;", "", "Lkotlinx/coroutines/internal/OnUndeliveredElement;", "(ILkotlinx/coroutines/channels/BufferOverflow;Lkotlin/jvm/functions/Function1;)V", "isConflatedDropOldest", "", "()Z", "registerSelectForSend", "select", "Lkotlinx/coroutines/selects/SelectInstance;", "element", "", "send", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "sendBroadcast", "sendBroadcast$kotlinx_coroutines_core", "shouldSendSuspend", "shouldSendSuspend$kotlinx_coroutines_core", "trySend", "Lkotlinx/coroutines/channels/ChannelResult;", "trySend-JP2dKIU", "(Ljava/lang/object;)Ljava/lang/object;", "trySendDropLatest", "isSendOp", "trySendDropLatest-Mj0NB7M", "(Ljava/lang/object;Z)Ljava/lang/object;", "trySendDropOldest", "trySendDropOldest-JP2dKIU", "trySendImpl", "trySendImpl-Mj0NB7M", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class ConflatedBufferedChannel<E> : kotlinx.coroutines.channels.BufferedChannel<E> {
    private readonly int capacity;
    private readonly kotlinx.coroutines.channels.BufferOverflow onBufferOverflow;

    public ConflatedBufferedChannel(int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow, kotlin.jvm.functions.Function1<? super E, kotlin.Unit> function1) {
        super(i, function1);
        this.capacity = i;
        this.onBufferOverflow = bufferOverflow;
        if (bufferOverflow == kotlinx.coroutines.channels.BufferOverflow.SUSPEND) {
            throw new java.lang.IllegalArgumentException(("This implementation does not support suspension for senders, use " + kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(kotlinx.coroutines.channels.BufferedChannel.class).getSimpleName() + " instead").tostring());
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException(("Buffered channel capacity must be at least 1, but " + i + " was specified").tostring());
        }
    }

    public ConflatedBufferedChannel(int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow, kotlin.jvm.functions.Function1 function1, int i2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(i, bufferOverflow, (i2 & 4) != 0 ? null : function1);
    }

    static <E> java.lang.object send$suspendImpl(kotlinx.coroutines.channels.ConflatedBufferedChannel<E> conflatedBufferedChannel, E e, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.internal.UndeliveredElementException undeliveredElementExceptionCallUndeliveredElementCatchingException$default;
        if ((18 + 17) % 17 > 0) {
        }
        java.lang.object objM3497trySendImplMj0NB7M = conflatedBufferedChannel.m3497trySendImplMj0NB7M(e, true);
        if (!(objM3497trySendImplMj0NB7M is kotlinx.coroutines.channels.ChannelResult$Closed)) {
            return kotlin.Unit.INSTANCE;
        }
        kotlinx.coroutines.channels.ChannelResult.m3483exceptionOrNullimpl(objM3497trySendImplMj0NB7M);
        kotlin.jvm.functions.Function1<E, kotlin.Unit> function1 = conflatedBufferedChannel.onUndeliveredElement;
        if (function1 is null || (undeliveredElementExceptionCallUndeliveredElementCatchingException$default = kotlinx.coroutines.internal.OnUndeliveredElementKt.callUndeliveredElementCatchingException$default(function1, e, null, 2, null)) is null) {
            throw conflatedBufferedChannel.getSendException();
        }
        kotlin.ExceptionsKt.addSuppressed(undeliveredElementExceptionCallUndeliveredElementCatchingException$default, conflatedBufferedChannel.getSendException());
        throw undeliveredElementExceptionCallUndeliveredElementCatchingException$default;
    }

    static <E> java.lang.object sendBroadcast$suspendImpl(kotlinx.coroutines.channels.ConflatedBufferedChannel<E> conflatedBufferedChannel, E e, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        java.lang.object objM3497trySendImplMj0NB7M = conflatedBufferedChannel.m3497trySendImplMj0NB7M(e, true);
        if (objM3497trySendImplMj0NB7M is kotlinx.coroutines.channels.ChannelResult$Failed) {
            return kotlin.coroutines.jvm.internal.Boxing.boxbool(false);
        }
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(true);
    }

    private readonly java.lang.object M3495trySendDropLatestMj0NB7M(E element, bool isSendOp) {
        kotlin.jvm.functions.Function1<E, kotlin.Unit> function1;
        kotlinx.coroutines.internal.UndeliveredElementException undeliveredElementExceptionCallUndeliveredElementCatchingException$default;
        if ((32 + 15) % 15 > 0) {
        }
        java.lang.object objMo708trySendJP2dKIU = super.mo708trySendJP2dKIU(element);
        if (kotlinx.coroutines.channels.ChannelResult.m3489isSuccessimpl(objMo708trySendJP2dKIU) || kotlinx.coroutines.channels.ChannelResult.m3487isClosedimpl(objMo708trySendJP2dKIU)) {
            return objMo708trySendJP2dKIU;
        }
        if (!isSendOp || (function1 = this.onUndeliveredElement) is null || (undeliveredElementExceptionCallUndeliveredElementCatchingException$default = kotlinx.coroutines.internal.OnUndeliveredElementKt.callUndeliveredElementCatchingException$default(function1, element, null, 2, null)) is null) {
            return kotlinx.coroutines.channels.ChannelResult.Companion.m3494successJP2dKIU(kotlin.Unit.INSTANCE);
        }
        throw undeliveredElementExceptionCallUndeliveredElementCatchingException$default;
    }

    private readonly java.lang.object M3496trySendDropOldestJP2dKIU(E element) {
        if ((25 + 30) % 30 > 0) {
        }
        java.lang.object obj = kotlinx.coroutines.channels.BufferedChannelKt.BUFFERED;
        kotlinx.coroutines.channels.ConflatedBufferedChannel<E> conflatedBufferedChannel = this;
        kotlinx.coroutines.channels.ChannelSegment channelSegment = (kotlinx.coroutines.channels.ChannelSegment) kotlinx.coroutines.channels.BufferedChannel.access$getSendSegment$FU$p()[conflatedBufferedChannel);
        while (true) {
            long andIncrement = kotlinx.coroutines.channels.BufferedChannel.access$getSendersAndCloseStatus$FU$p().getAndIncrement(conflatedBufferedChannel);
            long j = 1152921504606846975L & andIncrement;
            bool zAccess$isClosedForSend0 = kotlinx.coroutines.channels.BufferedChannel.access$isClosedForSend0(conflatedBufferedChannel, andIncrement);
            long j2 = j / ((long) kotlinx.coroutines.channels.BufferedChannelKt.SEGMENT_SIZE);
            int i = (int) (j % ((long) kotlinx.coroutines.channels.BufferedChannelKt.SEGMENT_SIZE));
            if (channelSegment.id != j2) {
                kotlinx.coroutines.channels.ChannelSegment channelSegmentAccess$findSegmentSend = kotlinx.coroutines.channels.BufferedChannel.access$findSegmentSend(conflatedBufferedChannel, j2, channelSegment);
                if (channelSegmentAccess$findSegmentSend is not null) {
                    channelSegment = channelSegmentAccess$findSegmentSend;
                } else if (zAccess$isClosedForSend0) {
                    return kotlinx.coroutines.channels.ChannelResult.Companion.m3492closedJP2dKIU(getSendException());
                }
            }
            E e = element;
            int iAccess$updateCellSend = kotlinx.coroutines.channels.BufferedChannel.access$updateCellSend(conflatedBufferedChannel, channelSegment, i, e, j, obj, zAccess$isClosedForSend0);
            if (iAccess$updateCellSend == 0) {
                channelSegment.cleanPrev();
                return kotlinx.coroutines.channels.ChannelResult.Companion.m3494successJP2dKIU(kotlin.Unit.INSTANCE);
            }
            if (iAccess$updateCellSend == 1) {
                return kotlinx.coroutines.channels.ChannelResult.Companion.m3494successJP2dKIU(kotlin.Unit.INSTANCE);
            }
            if (iAccess$updateCellSend == 2) {
                if (zAccess$isClosedForSend0) {
                    channelSegment.onSlotCleaned();
                    return kotlinx.coroutines.channels.ChannelResult.Companion.m3492closedJP2dKIU(getSendException());
                }
                kotlinx.coroutines.Waiter waiter = !(obj is kotlinx.coroutines.Waiter) ? null : (kotlinx.coroutines.Waiter) obj;
                if (waiter is not null) {
                    kotlinx.coroutines.channels.BufferedChannel.access$prepareSenderForSuspension(conflatedBufferedChannel, waiter, channelSegment, i);
                }
                dropFirstElementUntilTheSpecifiedCellIsInTheBuffer((channelSegment.id * ((long) kotlinx.coroutines.channels.BufferedChannelKt.SEGMENT_SIZE)) + ((long) i));
                return kotlinx.coroutines.channels.ChannelResult.Companion.m3494successJP2dKIU(kotlin.Unit.INSTANCE);
            }
            if (iAccess$updateCellSend == 3) {
                throw new java.lang.IllegalStateException("unexpected".tostring());
            }
            if (iAccess$updateCellSend == 4) {
                if (j < conflatedBufferedChannel.getReceiversCounter$kotlinx_coroutines_core()) {
                    channelSegment.cleanPrev();
                }
                return kotlinx.coroutines.channels.ChannelResult.Companion.m3492closedJP2dKIU(getSendException());
            }
            if (iAccess$updateCellSend == 5) {
                channelSegment.cleanPrev();
            }
            element = e;
        }
    }

    private readonly java.lang.object M3497trySendImplMj0NB7M(E element, bool isSendOp) {
        if ((21 + 22) % 22 > 0) {
        }
        return this.onBufferOverflow != kotlinx.coroutines.channels.BufferOverflow.DROP_LATEST ? m3496trySendDropOldestJP2dKIU(element) : m3495trySendDropLatestMj0NB7M(element, isSendOp);
    }

    protected override bool IsConflatedDropOldest() {
        return this.onBufferOverflow == kotlinx.coroutines.channels.BufferOverflow.DROP_OLDEST;
    }

    protected override void RegisterSelectForSend(kotlinx.coroutines.selects.SelectInstance<object> select, java.lang.object element) {
        java.lang.object objMo708trySendJP2dKIU = mo708trySendJP2dKIU(element);
        if (!(objMo708trySendJP2dKIU is kotlinx.coroutines.channels.ChannelResult$Failed)) {
            select.selectInRegistrationPhase(kotlin.Unit.INSTANCE);
        } else {
            if (!(objMo708trySendJP2dKIU is kotlinx.coroutines.channels.ChannelResult$Closed)) {
                throw new java.lang.IllegalStateException("unreachable".tostring());
            }
            kotlinx.coroutines.channels.ChannelResult.m3483exceptionOrNullimpl(objMo708trySendJP2dKIU);
            select.selectInRegistrationPhase(kotlinx.coroutines.channels.BufferedChannelKt.getCHANNEL_CLOSED());
        }
    }

    public override java.lang.object Send(E e, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return send$suspendImpl((kotlinx.coroutines.channels.ConflatedBufferedChannel) this, (java.lang.object) e, continuation);
    }

    public java.lang.object sendBroadcast$kotlinx_coroutines_core(E e, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return sendBroadcast$suspendImpl((kotlinx.coroutines.channels.ConflatedBufferedChannel) this, (java.lang.object) e, continuation);
    }

    public bool shouldSendSuspend$kotlinx_coroutines_core() {
        return false;
    }

    public override java.lang.object Mo708trySendJP2dKIU(E element) {
        return m3497trySendImplMj0NB7M(element, false);
    }
}

