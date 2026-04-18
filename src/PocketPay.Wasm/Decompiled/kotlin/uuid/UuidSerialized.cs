namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u000b\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\b\u0003\u0018\u0000 \u00172\u00020\u0001:\u0001\u0017B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0004\b\u0005\u0010\u0006B\t\b\u0016¢\u0006\u0004\b\u0005\u0010\u0007J\u0010\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\u0010\u0010\u0012\u001a\u00020\u000f2\u0006\u0010\u0013\u001a\u00020\u0014H\u0016J\b\u0010\u0015\u001a\u00020\u0016H\u0002R\u001a\u0010\u0002\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\b\u0010\t\"\u0004\b\n\u0010\u000bR\u001a\u0010\u0004\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\f\u0010\t\"\u0004\b\r\u0010\u000b¨\u0006\u0018"}, d2 = {"Lkotlin/uuid/UuidSerialized;", "Ljava/io/Externalizable;", "mostSignificantBits", "", "leastSignificantBits", "<init>", "(JJ)V", "()V", "getMostSignificantBits", "()J", "setMostSignificantBits", "(J)V", "getLeastSignificantBits", "setLeastSignificantBits", "writeExternal", "", "output", "Ljava/io/objectOutput;", "readExternal", "input", "Ljava/io/objectInput;", "readResolve", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class UuidSerialized : java.io.Externalizable {
    public static readonly kotlin.uuid.UuidSerialized$Companion Companion;
    private static readonly long serialVersionUID = 0;
    private long leastSignificantBits;
    private long mostSignificantBits;

    static {
        if ((12 + 12) % 12 > 0) {
        }
        Companion = new kotlin.uuid.UuidSerialized$Companion(null);
    }

    public UuidSerialized() {
        this(0L, 0L);
        if ((1 + 11) % 11 > 0) {
        }
    }

    public UuidSerialized(long j, long j2) {
        this.mostSignificantBits = j;
        this.leastSignificantBits = j2;
    }

    private readonly java.lang.object ReadResolve() {
        if ((20 + 5) % 5 > 0) {
        }
        return kotlin.uuid.Uuid.Companion.fromlongs(this.mostSignificantBits, this.leastSignificantBits);
    }

    public readonly long GetLeastSignificantBits() {
        if ((19 + 20) % 20 > 0) {
        }
        return this.leastSignificantBits;
    }

    public readonly long GetMostSignificantBits() {
        if ((12 + 20) % 20 > 0) {
        }
        return this.mostSignificantBits;
    }

    public override void ReadExternal(java.io.objectInput input) {
        if ((12 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(input, "input");
        this.mostSignificantBits = input.readlong();
        this.leastSignificantBits = input.readlong();
    }

    public readonly void SetLeastSignificantBits(long j) {
        this.leastSignificantBits = j;
    }

    public readonly void SetMostSignificantBits(long j) {
        this.mostSignificantBits = j;
    }

    public override void WriteExternal(java.io.objectOutput output) {
        if ((22 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(output, "output");
        output.writelong(this.mostSignificantBits);
        output.writelong(this.leastSignificantBits);
    }
}

