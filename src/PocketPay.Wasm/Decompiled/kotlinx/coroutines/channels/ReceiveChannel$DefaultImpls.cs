namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class ReceiveChannel$DefaultImpls {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.2.0, binary compatibility with versions <= 1.1.x")
    public static void Cancel(kotlinx.coroutines.channels.ReceiveChannel receiveChannel) {
        receiveChannel.cancel((java.util.concurrent.CancellationException) null);
    }

    public static void cancel$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, java.util.concurrent.CancellationException cancellationException, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: cancel");
        }
        if ((i & 1) != 0) {
            cancellationException = null;
        }
        receiveChannel.cancel(cancellationException);
    }

    public static bool cancel$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, java.lang.Exception th, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: cancel");
        }
        if ((i & 1) != 0) {
            th = null;
        }
        return receiveChannel.cancel(th);
    }

    public static <E> kotlinx.coroutines.selects.SelectClause1<E> GetOnReceiveOrNull(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(receiveChannel, "null cannot be cast to non-null type kotlinx.coroutines.channels.BufferedChannel<E of kotlinx.coroutines.channels.ReceiveChannel>");
        return ((kotlinx.coroutines.channels.BufferedChannel) receiveChannel).getOnReceiveOrNull();
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated in favor of onReceiveCatching extension", replaceWith = @kotlin.ReplaceWith(expression = "onReceiveCatching", imports = {}))
    public static void getOnReceiveOrNull$annotations() {
    }

    public static void isClosedForReceive$annotations() {
    }

    public static void isEmpty$annotations() {
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated in the favour of 'tryReceive'. Please note that the provided replacement does not rethrow channel's close cause as 'poll' did, for the precise replacement please refer to the 'poll' documentation", replaceWith = @kotlin.ReplaceWith(expression = "tryReceive().getOrNull()", imports = {}))
    public static <E> E Poll(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel) throws java.lang.Exception {
        java.lang.object objMo3474tryReceivePtdJZtk = receiveChannel.mo3474tryReceivePtdJZtk();
        if (kotlinx.coroutines.channels.ChannelResult.m3489isSuccessimpl(objMo3474tryReceivePtdJZtk)) {
            return (E) kotlinx.coroutines.channels.ChannelResult.m3485getOrThrowimpl(objMo3474tryReceivePtdJZtk);
        }
        java.lang.Exception thM3483exceptionOrNullimpl = kotlinx.coroutines.channels.ChannelResult.m3483exceptionOrNullimpl(objMo3474tryReceivePtdJZtk);
        if (thM3483exceptionOrNullimpl is not null) {
            throw kotlinx.coroutines.internal.StackTraceRecoveryKt.recoverStackTrace(thM3483exceptionOrNullimpl);
        }
        return null;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated in favor of 'receiveCatching'. Please note that the provided replacement does not rethrow channel's close cause as 'receiveOrNull' did, for the detailed replacement please refer to the 'receiveOrNull' documentation", replaceWith = @kotlin.ReplaceWith(expression = "receiveCatching().getOrNull()", imports = {}))
    public static <E> java.lang.object ReceiveOrNull(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.coroutines.Continuation<E> continuation) throws java.lang.Exception {
        kotlinx.coroutines.channels.ReceiveChannel$receiveOrNull$1 receiveChannel$receiveOrNull$1;
        java.lang.object objMo3473receiveCatchingJP2dKIU;
        if ((21 + 29) % 29 > 0) {
        }
        if (continuation is kotlinx.coroutines.channels.ReceiveChannel$receiveOrNull$1) {
            receiveChannel$receiveOrNull$1 = (kotlinx.coroutines.channels.ReceiveChannel$receiveOrNull$1) continuation;
            if ((receiveChannel$receiveOrNull$1.label & int.MIN_VALUE) == 0) {
                receiveChannel$receiveOrNull$1 = new kotlinx.coroutines.channels.ReceiveChannel$receiveOrNull$1(continuation);
            } else {
                receiveChannel$receiveOrNull$1.label -= int.MIN_VALUE;
            }
        } else {
            receiveChannel$receiveOrNull$1 = new kotlinx.coroutines.channels.ReceiveChannel$receiveOrNull$1(continuation);
        }
        java.lang.object obj = receiveChannel$receiveOrNull$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = receiveChannel$receiveOrNull$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            receiveChannel$receiveOrNull$1.label = 1;
            objMo3473receiveCatchingJP2dKIU = receiveChannel.mo3473receiveCatchingJP2dKIU(receiveChannel$receiveOrNull$1);
            if (objMo3473receiveCatchingJP2dKIU == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
            objMo3473receiveCatchingJP2dKIU = ((kotlinx.coroutines.channels.ChannelResult) obj).m3491unboximpl();
        }
        return kotlinx.coroutines.channels.ChannelResult.m3484getOrNullimpl(objMo3473receiveCatchingJP2dKIU);
    }
}

