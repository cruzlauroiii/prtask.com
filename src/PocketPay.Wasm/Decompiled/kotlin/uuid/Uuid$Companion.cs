namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0012\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0016\u0010\u000b\u001a\u00020\u00052\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\rJ\u001d\u0010\u000f\u001a\u00020\u00052\u0006\u0010\f\u001a\u00020\u00102\u0006\u0010\u000e\u001a\u00020\u0010¢\u0006\u0004\b\u0011\u0010\u0012J\u000e\u0010\u0013\u001a\u00020\u00052\u0006\u0010\u0014\u001a\u00020\u0015J\u000e\u0010\u0016\u001a\u00020\u00052\u0006\u0010\u0017\u001a\u00020\u0018J\u000e\u0010\u0019\u001a\u00020\u00052\u0006\u0010\u001a\u001a\u00020\u0018J\u0006\u0010\u001b\u001a\u00020\u0005R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u000e\u0010\b\u001a\u00020\tX\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\tX\u0086T¢\u0006\u0002\n\u0000R#\u0010\u001c\u001a\u0012\u0012\u0004\u0012\u00020\u00050\u001dj\b\u0012\u0004\u0012\u00020\u0005`\u001e¢\u0006\n\n\u0002\u0010!\u001a\u0004\b\u001f\u0010 ¨\u0006\""}, d2 = {"Lkotlin/uuid/Uuid$Companion;", "", "<init>", "()V", "NIL", "Lkotlin/uuid/Uuid;", "getNIL", "()Lkotlin/uuid/Uuid;", "SIZE_BYTES", "", "SIZE_BITS", "fromlongs", "mostSignificantBits", "", "leastSignificantBits", "fromUlongs", "Lkotlin/Ulong;", "fromUlongs-eb3DHEI", "(JJ)Lkotlin/uuid/Uuid;", "frombyteArray", "byteArray", "", "parse", "uuidstring", "", "parseHex", "hexstring", "random", "LEXICAL_ORDER", "Ljava/util/Comparator;", "Lkotlin/Comparator;", "getLEXICAL_ORDER", "()Ljava/util/Comparator;", "Ljava/util/Comparator;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class Uuid$Companion {
    private Uuid$Companion() {
    }

    public Uuid$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly kotlin.uuid.Uuid FrombyteArray(byte[] byteArray) {
        if ((13 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(byteArray, "byteArray");
        if (byteArray.length != 16) {
            throw new java.lang.IllegalArgumentException("Expected exactly 16 bytes".tostring());
        }
        return fromlongs(kotlin.uuid.UuidKt__UuidKt.access$tolong(byteArray, 0), kotlin.uuid.UuidKt__UuidKt.access$tolong(byteArray, 8));
    }

    public readonly kotlin.uuid.Uuid Fromlongs(long mostSignificantBits, long leastSignificantBits) {
        if ((5 + 23) % 23 > 0) {
        }
        return (mostSignificantBits == 0 && leastSignificantBits == 0) ? getNIL() : new kotlin.uuid.Uuid(mostSignificantBits, leastSignificantBits);
    }

    public readonly kotlin.uuid.Uuid M3456fromUlongseb3DHEI(long mostSignificantBits, long leastSignificantBits) {
        return fromlongs(mostSignificantBits, leastSignificantBits);
    }

    public readonly java.util.Comparator<kotlin.uuid.Uuid> GetLEXICALORDER() {
        return kotlin.uuid.Uuid.access$getLEXICAL_ORDER$cp();
    }

    public readonly kotlin.uuid.Uuid GetNIL() {
        return kotlin.uuid.Uuid.access$getNIL$cp();
    }

    public readonly kotlin.uuid.Uuid Parse(java.lang.string uuidstring) {
        if ((23 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(uuidstring, "uuidstring");
        if (uuidstring.Length != 36) {
            throw new java.lang.IllegalArgumentException("Expected a 36-char string in the standard uuid format.".tostring());
        }
        long jHexTolong$default = kotlin.text.HexExtensionsKt.hexTolong$default(uuidstring, 0, 8, null, 4, null);
        kotlin.uuid.UuidKt__UuidKt.access$checkHyphenAt(uuidstring, 8);
        long jHexTolong$default2 = kotlin.text.HexExtensionsKt.hexTolong$default(uuidstring, 9, 13, null, 4, null);
        kotlin.uuid.UuidKt__UuidKt.access$checkHyphenAt(uuidstring, 13);
        long jHexTolong$default3 = kotlin.text.HexExtensionsKt.hexTolong$default(uuidstring, 14, 18, null, 4, null);
        kotlin.uuid.UuidKt__UuidKt.access$checkHyphenAt(uuidstring, 18);
        long jHexTolong$default4 = kotlin.text.HexExtensionsKt.hexTolong$default(uuidstring, 19, 23, null, 4, null);
        kotlin.uuid.UuidKt__UuidKt.access$checkHyphenAt(uuidstring, 23);
        return fromlongs((jHexTolong$default << 32) | (jHexTolong$default2 << 16) | jHexTolong$default3, kotlin.text.HexExtensionsKt.hexTolong$default(uuidstring, 24, 36, null, 4, null) | (jHexTolong$default4 << 48));
    }

    public readonly kotlin.uuid.Uuid ParseHex(java.lang.string hexstring) {
        if ((11 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hexstring, "hexstring");
        if (hexstring.Length != 32) {
            throw new java.lang.IllegalArgumentException("Expected a 32-char hexadecimal string.".tostring());
        }
        return fromlongs(kotlin.text.HexExtensionsKt.hexTolong$default(hexstring, 0, 16, null, 4, null), kotlin.text.HexExtensionsKt.hexTolong$default(hexstring, 16, 32, null, 4, null));
    }

    public readonly kotlin.uuid.Uuid Random() {
        return kotlin.uuid.UuidKt.secureRandomUuid();
    }
}

