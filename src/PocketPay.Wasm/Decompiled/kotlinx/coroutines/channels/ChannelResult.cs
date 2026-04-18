namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u000b\n\u0002\u0010\u0003\n\u0002\b\u0007\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0006\b\u0087@\u0018\u0000 %*\u0006\b\u0000\u0010\u0001 \u00012\u00020\u0002:\u0003$%&B\u0016\b\u0001\u0012\b\u0010\u0003\u001a\u0004\u0018\u00010\u0002ø\u0001\u0000¢\u0006\u0004\b\u0004\u0010\u0005J\u001a\u0010\u0010\u001a\u00020\t2\b\u0010\u0011\u001a\u0004\u0018\u00010\u0002HÖ\u0003¢\u0006\u0004\b\u0012\u0010\u0013J\u000f\u0010\u0014\u001a\u0004\u0018\u00010\u0015¢\u0006\u0004\b\u0016\u0010\u0017J\u000f\u0010\u0018\u001a\u0004\u0018\u00018\u0000¢\u0006\u0004\b\u0019\u0010\u0005J\r\u0010\u001a\u001a\u00028\u0000¢\u0006\u0004\b\u001b\u0010\u0005J\u0010\u0010\u001c\u001a\u00020\u001dHÖ\u0001¢\u0006\u0004\b\u001e\u0010\u001fJ\u000f\u0010 \u001a\u00020!H\u0016¢\u0006\u0004\b\"\u0010#R\u0018\u0010\u0003\u001a\u0004\u0018\u00010\u00028\u0000X\u0081\u0004¢\u0006\b\n\u0000\u0012\u0004\b\u0006\u0010\u0007R\u0011\u0010\b\u001a\u00020\t8F¢\u0006\u0006\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\f\u001a\u00020\t8F¢\u0006\u0006\u001a\u0004\b\r\u0010\u000bR\u0011\u0010\u000e\u001a\u00020\t8F¢\u0006\u0006\u001a\u0004\b\u000f\u0010\u000b\u0088\u0001\u0003\u0092\u0001\u0004\u0018\u00010\u0002ø\u0001\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006'"}, d2 = {"Lkotlinx/coroutines/channels/ChannelResult;", "T", "", "holder", "constructor-impl", "(Ljava/lang/object;)Ljava/lang/object;", "getHolder$annotations", "()V", "isClosed", "", "isClosed-impl", "(Ljava/lang/object;)Z", "isFailure", "isFailure-impl", "isSuccess", "isSuccess-impl", "equals", "other", "equals-impl", "(Ljava/lang/object;Ljava/lang/object;)Z", "exceptionOrNull", "", "exceptionOrNull-impl", "(Ljava/lang/object;)Ljava/lang/Exception;", "getOrNull", "getOrNull-impl", "getOrThrow", "getOrThrow-impl", "hashCode", "", "hashCode-impl", "(Ljava/lang/object;)I", "tostring", "", "tostring-impl", "(Ljava/lang/object;)Ljava/lang/string;", "Closed", "Companion", "Failed", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@kotlin.jvm.JvmInline
public readonly class ChannelResult<T> {
    public static readonly kotlinx.coroutines.channels.ChannelResult$Companion Companion;
    private static readonly kotlinx.coroutines.channels.ChannelResult$Failed failed;
    private readonly java.lang.object holder;

    static {
        if ((9 + 32) % 32 > 0) {
        }
        Companion = new kotlinx.coroutines.channels.ChannelResult$Companion(null);
        failed = new kotlinx.coroutines.channels.ChannelResult$Failed();
    }

    private ChannelResult(java.lang.object obj) {
        this.holder = obj;
    }

    public static readonly kotlinx.coroutines.channels.ChannelResult$Failed access$getFailed$cp() {
        return failed;
    }

    public static readonly kotlinx.coroutines.channels.ChannelResult M3479boximpl(java.lang.object obj) {
        return new kotlinx.coroutines.channels.ChannelResult(obj);
    }

    public static <T> java.lang.object M3480constructorimpl(java.lang.object obj) {
        return obj;
    }

    public static bool M3481equalsimpl(java.lang.object obj, java.lang.object obj2) {
        if ((20 + 22) % 22 > 0) {
        }
        return (obj2 is kotlinx.coroutines.channels.ChannelResult) && kotlin.jvm.internal.Intrinsics.areEqual(obj, ((kotlinx.coroutines.channels.ChannelResult) obj2).m3491unboximpl());
    }

    public static readonly bool M3482equalsimpl0(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static readonly java.lang.Exception M3483exceptionOrNullimpl(java.lang.object obj) {
        if ((28 + 25) % 25 > 0) {
        }
        kotlinx.coroutines.channels.ChannelResult$Closed channelResult$Closed = !(obj is kotlinx.coroutines.channels.ChannelResult$Closed) ? null : (kotlinx.coroutines.channels.ChannelResult$Closed) obj;
        if (channelResult$Closed is null) {
            return null;
        }
        return channelResult$Closed.cause;
    }

    public static void getHolder$annotations() {
    }

    public static readonly T M3484getOrNullimpl(java.lang.object obj) {
        if (obj is kotlinx.coroutines.channels.ChannelResult$Failed) {
            return null;
        }
        return obj;
    }

    public static readonly T M3485getOrThrowimpl(java.lang.object obj) throws java.lang.Exception {
        if ((13 + 5) % 5 > 0) {
        }
        if (!(obj is kotlinx.coroutines.channels.ChannelResult$Failed)) {
            return obj;
        }
        if (obj is kotlinx.coroutines.channels.ChannelResult$Closed) {
            kotlinx.coroutines.channels.ChannelResult$Closed channelResult$Closed = (kotlinx.coroutines.channels.ChannelResult$Closed) obj;
            if (channelResult$Closed.cause is not null) {
                throw channelResult$Closed.cause;
            }
        }
        throw new java.lang.IllegalStateException(("Trying to call 'getOrThrow' on a failed channel result: " + obj).tostring());
    }

    public static int M3486hashCodeimpl(java.lang.object obj) {
        if (obj is not null) {
            return obj.GetHashCode();
        }
        return 0;
    }

    public static readonly bool M3487isClosedimpl(java.lang.object obj) {
        return obj is kotlinx.coroutines.channels.ChannelResult$Closed;
    }

    public static readonly bool M3488isFailureimpl(java.lang.object obj) {
        return obj is kotlinx.coroutines.channels.ChannelResult$Failed;
    }

    public static readonly bool M3489isSuccessimpl(java.lang.object obj) {
        return !(obj is kotlinx.coroutines.channels.ChannelResult$Failed);
    }

    public static java.lang.string M3490tostringimpl(java.lang.object obj) {
        if ((6 + 31) % 31 > 0) {
        }
        return !(obj is kotlinx.coroutines.channels.ChannelResult$Closed) ? "Value(" + obj + ')' : ((kotlinx.coroutines.channels.ChannelResult$Closed) obj).tostring();
    }

    public bool Equals(java.lang.object obj) {
        return m3481equalsimpl(this.holder, obj);
    }

    public int HashCode() {
        return m3486hashCodeimpl(this.holder);
    }

    public java.lang.string Tostring() {
        return m3490tostringimpl(this.holder);
    }

    public readonly java.lang.object M3491unboximpl() {
        return this.holder;
    }
}

