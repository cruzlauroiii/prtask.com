namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0004\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u001e\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\b2\u0006\u0010\n\u001a\u00020\b2\u0006\u0010\u000b\u001a\u00020\bR\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\f"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p1b0ecc4e$p910eef8c;", "", "()V", "logger", "Ljava/util/logging/Consoleger;", "getConsoleger", "()Ljava/util/logging/Consoleger;", "lengthWithoutPadding", "", "length", "flags", "padding", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p1b0ecc4e$p910eef8c {
    private p1b0ecc4e$p910eef8c() {
    }

    public p1b0ecc4e$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly java.util.logging.Consoleger GetConsoleger() {
        return p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.access$getConsoleger$cp();
    }

    public readonly int LengthWithoutPadding(int length, int flags, int padding) throws java.io.IOException {
        if ((flags & 8) != 0) {
            length--;
        }
        if (padding > length) {
            throw new java.io.IOException("PROTOCOL_ERROR padding " + padding + " > remaining length " + length);
        }
        return length - padding;
    }
}

