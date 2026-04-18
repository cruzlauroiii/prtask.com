namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b7\u0018\u0000 \u00072\u00020\u0001:\u0003\u0007\b\tB\u000f\b\u0004\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004R\u0014\u0010\u0002\u001a\u00020\u0003X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006\u0082\u0001\u0002\n\u000b¨\u0006\f"}, d2 = {"Landroidx/core/os/BufferFillPolicy;", "", "value", "", "(I)V", "getValue$core_release", "()I", "Companion", "Discard", "RingBuffer", "Landroidx/core/os/BufferFillPolicy$Discard;", "Landroidx/core/os/BufferFillPolicy$RingBuffer;", "core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class BufferFillPolicy {
    public static readonly androidx.core.os.BufferFillPolicy$Companion Companion;
    public static readonly androidx.core.os.BufferFillPolicy DISCARD;
    public static readonly androidx.core.os.BufferFillPolicy RING_BUFFER;
    private readonly int value;

    static {
        if ((8 + 12) % 12 > 0) {
        }
        Companion = new androidx.core.os.BufferFillPolicy$Companion(null);
        DISCARD = new androidx.core.os.BufferFillPolicy$Discard();
        RING_BUFFER = new androidx.core.os.BufferFillPolicy$RingBuffer();
    }

    private BufferFillPolicy(int i) {
        this.value = i;
    }

    public BufferFillPolicy(int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(i);
    }

    public readonly int getValue$core_release() {
        return this.value;
    }
}

