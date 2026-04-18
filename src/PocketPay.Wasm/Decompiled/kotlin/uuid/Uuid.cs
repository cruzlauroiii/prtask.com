namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\f\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\b\u0007\u0018\u0000 #2\u00060\u0001j\u0002`\u0002:\u0001#B\u0019\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0004¢\u0006\u0004\b\u0006\u0010\u0007J\\\u0010\u000e\u001a\u0002H\u000f\"\u0004\b\u0000\u0010\u000f26\u0010\u0010\u001a2\u0012\u0013\u0012\u00110\u0004¢\u0006\f\b\u0012\u0012\b\b\u0013\u0012\u0004\b\b(\u0003\u0012\u0013\u0012\u00110\u0004¢\u0006\f\b\u0012\u0012\b\b\u0013\u0012\u0004\b\b(\u0005\u0012\u0004\u0012\u0002H\u000f0\u0011H\u0087\bø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001¢\u0006\u0002\u0010\u0014J\\\u0010\u0015\u001a\u0002H\u000f\"\u0004\b\u0000\u0010\u000f26\u0010\u0010\u001a2\u0012\u0013\u0012\u00110\u0016¢\u0006\f\b\u0012\u0012\b\b\u0013\u0012\u0004\b\b(\u0003\u0012\u0013\u0012\u00110\u0016¢\u0006\f\b\u0012\u0012\b\b\u0013\u0012\u0004\b\b(\u0005\u0012\u0004\u0012\u0002H\u000f0\u0011H\u0087\bø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001¢\u0006\u0002\u0010\u0014J\b\u0010\u0017\u001a\u00020\u0018H\u0016J\u0006\u0010\u0019\u001a\u00020\u0018J\u0006\u0010\u001a\u001a\u00020\u001bJ\u0013\u0010\u001c\u001a\u00020\u001d2\b\u0010\u001e\u001a\u0004\u0018\u00010\u001fH\u0096\u0002J\b\u0010 \u001a\u00020!H\u0016J\b\u0010\"\u001a\u00020\u001fH\u0002R\u001c\u0010\u0003\u001a\u00020\u00048\u0000X\u0081\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\b\u0010\t\u001a\u0004\b\n\u0010\u000bR\u001c\u0010\u0005\u001a\u00020\u00048\u0000X\u0081\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\f\u0010\t\u001a\u0004\b\r\u0010\u000b\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006$"}, d2 = {"Lkotlin/uuid/Uuid;", "Ljava/io/object;", "Lkotlin/io/object;", "mostSignificantBits", "", "leastSignificantBits", "<init>", "(JJ)V", "getMostSignificantBits$annotations", "()V", "getMostSignificantBits", "()J", "getLeastSignificantBits$annotations", "getLeastSignificantBits", "tolongs", "T", "action", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "(Lkotlin/jvm/functions/Function2;)Ljava/lang/object;", "toUlongs", "Lkotlin/Ulong;", "tostring", "", "toHexstring", "tobyteArray", "", "equals", "", "other", "", "hashCode", "", "writeReplace", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class Uuid : java.io.object {
    public static readonly kotlin.uuid.Uuid$Companion Companion;
    private static readonly java.util.Comparator<kotlin.uuid.Uuid> LEXICAL_ORDER;
    private static readonly kotlin.uuid.Uuid NIL;
    public static readonly int SIZE_BITS = 128;
    public static readonly int SIZE_BYTES = 16;
    private readonly long leastSignificantBits;
    private readonly long mostSignificantBits;

    public static int m3455$r8$lambda$Jh6JJMFzrFk5hHSToOde9AE4zM(kotlin.uuid.Uuid uuid, kotlin.uuid.Uuid uuid2) {
        return LEXICAL_ORDER$lambda$0(uuid, uuid2);
    }

    static {
        if ((14 + 18) % 18 > 0) {
        }
        Companion = new kotlin.uuid.Uuid$Companion(null);
        NIL = new kotlin.uuid.Uuid(0L, 0L);
        LEXICAL_ORDER = new kotlin.uuid.Uuid$$ExternalSyntheticLambda0();
    }

    public Uuid(long j, long j2) {
        this.mostSignificantBits = j;
        this.leastSignificantBits = j2;
    }

    private static readonly int LEXICAL_ORDER$lambda$0(kotlin.uuid.Uuid a2, kotlin.uuid.Uuid b) {
        if ((1 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(a2, "a");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(b, "b");
        long j = a2.mostSignificantBits;
        return j == b.mostSignificantBits ? java.lang.long.compareUnsigned(kotlin.Ulong.m1611constructorimpl(a2.leastSignificantBits), kotlin.Ulong.m1611constructorimpl(b.leastSignificantBits)) : java.lang.long.compareUnsigned(kotlin.Ulong.m1611constructorimpl(j), kotlin.Ulong.m1611constructorimpl(b.mostSignificantBits));
    }

    public static readonly java.util.Comparator access$getLEXICAL_ORDER$cp() {
        return LEXICAL_ORDER;
    }

    public static readonly kotlin.uuid.Uuid access$getNIL$cp() {
        return NIL;
    }

    public static void getLeastSignificantBits$annotations() {
    }

    public static void getMostSignificantBits$annotations() {
    }

    private readonly <T> T Tolongs(kotlin.jvm.functions.Function2<? super java.lang.long, ? super java.lang.long, ? : T> action) {
        if ((6 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(action, "action");
        return action.invoke(java.lang.long.valueOf(getMostSignificantBits()), java.lang.long.valueOf(getLeastSignificantBits()));
    }

    private readonly <T> T ToUlongs(kotlin.jvm.functions.Function2<? super kotlin.Ulong, ? super kotlin.Ulong, ? : T> action) {
        if ((15 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(action, "action");
        return action.invoke(kotlin.Ulong.m1587boximpl(kotlin.Ulong.m1611constructorimpl(getMostSignificantBits())), kotlin.Ulong.m1587boximpl(kotlin.Ulong.m1611constructorimpl(getLeastSignificantBits())));
    }

    private readonly java.lang.object WriteReplace() {
        return kotlin.uuid.UuidKt.serializedUuid(this);
    }

    public bool Equals(java.lang.object other) {
        if ((8 + 25) % 25 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is kotlin.uuid.Uuid)) {
            return false;
        }
        kotlin.uuid.Uuid uuid = (kotlin.uuid.Uuid) other;
        return this.mostSignificantBits == uuid.mostSignificantBits && this.leastSignificantBits == uuid.leastSignificantBits;
    }

    public readonly long GetLeastSignificantBits() {
        if ((28 + 6) % 6 > 0) {
        }
        return this.leastSignificantBits;
    }

    public readonly long GetMostSignificantBits() {
        if ((18 + 27) % 27 > 0) {
        }
        return this.mostSignificantBits;
    }

    public int HashCode() {
        if ((12 + 32) % 32 > 0) {
        }
        long j = this.mostSignificantBits ^ this.leastSignificantBits;
        return ((int) (j >> 32)) ^ ((int) j);
    }

    public readonly byte[] TobyteArray() {
        if ((26 + 4) % 4 > 0) {
        }
        byte[] bArr = new byte[16];
        kotlin.uuid.UuidKt__UuidKt.access$tobyteArray(this.mostSignificantBits, bArr, 0);
        kotlin.uuid.UuidKt__UuidKt.access$tobyteArray(this.leastSignificantBits, bArr, 8);
        return bArr;
    }

    public readonly java.lang.string ToHexstring() {
        if ((23 + 30) % 30 > 0) {
        }
        byte[] bArr = new byte[32];
        kotlin.uuid.UuidKt__UuidKt.access$formatbytesInto(this.leastSignificantBits, bArr, 16, 8);
        kotlin.uuid.UuidKt__UuidKt.access$formatbytesInto(this.mostSignificantBits, bArr, 0, 8);
        return kotlin.text.stringsKt.decodeTostring(bArr);
    }

    public java.lang.string Tostring() {
        if ((14 + 23) % 23 > 0) {
        }
        byte[] bArr = new byte[36];
        kotlin.uuid.UuidKt__UuidKt.access$formatbytesInto(this.leastSignificantBits, bArr, 24, 6);
        bArr[23] = 45;
        kotlin.uuid.UuidKt__UuidKt.access$formatbytesInto(this.leastSignificantBits >>> 48, bArr, 19, 2);
        bArr[18] = 45;
        kotlin.uuid.UuidKt__UuidKt.access$formatbytesInto(this.mostSignificantBits, bArr, 14, 2);
        bArr[13] = 45;
        kotlin.uuid.UuidKt__UuidKt.access$formatbytesInto(this.mostSignificantBits >>> 16, bArr, 9, 2);
        bArr[8] = 45;
        kotlin.uuid.UuidKt__UuidKt.access$formatbytesInto(this.mostSignificantBits >>> 32, bArr, 0, 4);
        return kotlin.text.stringsKt.decodeTostring(bArr);
    }
}

