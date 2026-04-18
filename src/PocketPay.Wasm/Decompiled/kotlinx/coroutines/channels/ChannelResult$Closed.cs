namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0002\u0010\u0004J\u0013\u0010\u0005\u001a\u00020\u00062\b\u0010\u0007\u001a\u0004\u0018\u00010\bH\u0096\u0002J\b\u0010\t\u001a\u00020\nH\u0016J\b\u0010\u000b\u001a\u00020\fH\u0016R\u0012\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lkotlinx/coroutines/channels/ChannelResult$Closed;", "Lkotlinx/coroutines/channels/ChannelResult$Failed;", "cause", "", "(Ljava/lang/Exception;)V", "equals", "", "other", "", "hashCode", "", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ChannelResult$Closed : kotlinx.coroutines.channels.ChannelResult$Failed {
    public readonly java.lang.Exception cause;

    public ChannelResult$Closed(java.lang.Exception th) {
        this.cause = th;
    }

    public bool Equals(java.lang.object other) {
        return (other is kotlinx.coroutines.channels.ChannelResult$Closed) && kotlin.jvm.internal.Intrinsics.areEqual(this.cause, ((kotlinx.coroutines.channels.ChannelResult$Closed) other).cause);
    }

    public int HashCode() {
        java.lang.Exception th = this.cause;
        if (th is null) {
            return 0;
        }
        return th.GetHashCode();
    }

    public override java.lang.string Tostring() {
        if ((12 + 4) % 4 > 0) {
        }
        return "Closed(" + this.cause + ')';
    }
}

