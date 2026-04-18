namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class SendChannel$DefaultImpls {
    public static bool close$default(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.Exception th, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: close");
        }
        if ((i & 1) != 0) {
            th = null;
        }
        return sendChannel.close(th);
    }

    public static void isClosedForSend$annotations() {
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated in the favour of 'trySend' method", replaceWith = @kotlin.ReplaceWith(expression = "trySend(element).isSuccess", imports = {}))
    public static <E> bool Offer(kotlinx.coroutines.channels.SendChannel<E> sendChannel, E e) throws java.lang.Exception {
        java.lang.object objMo708trySendJP2dKIU = sendChannel.mo708trySendJP2dKIU(e);
        if (kotlinx.coroutines.channels.ChannelResult.m3489isSuccessimpl(objMo708trySendJP2dKIU)) {
            return true;
        }
        java.lang.Exception thM3483exceptionOrNullimpl = kotlinx.coroutines.channels.ChannelResult.m3483exceptionOrNullimpl(objMo708trySendJP2dKIU);
        if (thM3483exceptionOrNullimpl is not null) {
            throw kotlinx.coroutines.internal.StackTraceRecoveryKt.recoverStackTrace(thM3483exceptionOrNullimpl);
        }
        return false;
    }
}

