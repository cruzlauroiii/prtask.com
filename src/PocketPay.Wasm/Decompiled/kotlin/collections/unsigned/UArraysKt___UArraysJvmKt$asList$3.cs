namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u000e*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\u00060\u0003j\u0002`\u0004J\b\u0010\t\u001a\u00020\nH\u0016J\u0018\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\u0002H\u0096\u0002¢\u0006\u0004\b\r\u0010\u000eJ\u0018\u0010\u000f\u001a\u00020\u00022\u0006\u0010\u0010\u001a\u00020\u0006H\u0096\u0002¢\u0006\u0004\b\u0011\u0010\u0012J\u0017\u0010\u0013\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\u0002H\u0016¢\u0006\u0004\b\u0014\u0010\u0015J\u0017\u0010\u0016\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\u0002H\u0016¢\u0006\u0004\b\u0017\u0010\u0015R\u0014\u0010\u0005\u001a\u00020\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0007\u0010\b¨\u0006\u0018"}, d2 = {"kotlin/collections/unsigned/UArraysKt___UArraysJvmKt$asList$3", "Lkotlin/collections/AbstractList;", "Lkotlin/Ubyte;", "Ljava/util/RandomAccess;", "Lkotlin/collections/RandomAccess;", "size", "", "getSize", "()I", "isEmpty", "", "contains", "element", "contains-7apg3OU", "(B)Z", "get", "index", "get-w2LRezQ", "(I)B", "indexOf", "indexOf-7apg3OU", "(B)I", "lastIndexOf", "lastIndexOf-7apg3OU", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class UArraysKt___UArraysJvmKt$asList$3 : kotlin.collections.AbstractList<kotlin.Ubyte> : java.util.RandomAccess {
    readonly byte[] $this_asList;

    UArraysKt___UArraysJvmKt$asList$3(byte[] bArr) {
        this.$this_asList = bArr;
    }

    public static bool ANDqSxYPGxLfeqLv(byte[] bArr, byte b) {
        return kotlin.UbyteArray.m1233contains7apg3OU(bArr, b);
    }

    public static byte AfyHJabDqeERtCeB(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$3 uArraysKt___UArraysJvmKt$asList$3, int i) {
        return uArraysKt___UArraysJvmKt$asList$3.m2474getw2LRezQ(i);
    }

    public static byte DPddNwefkwiXdnAi(kotlin.Ubyte ubyte) {
        return ubyte.m1217unboximpl();
    }

    public static int QSYRwcNHFDnjxPWE(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$3 uArraysKt___UArraysJvmKt$asList$3, byte b) {
        return uArraysKt___UArraysJvmKt$asList$3.m2476lastIndexOf7apg3OU(b);
    }

    public static int RLPIDZfHoZcjkZCK(byte[] bArr, byte b) {
        return kotlin.collections.ArraysKt.LastIndexOf(bArr, b);
    }

    public static byte TMdleCVNGVhqTwKf(byte[] bArr, int i) {
        return kotlin.UbyteArray.m1246getw2LRezQ(bArr, i);
    }

    public static int UoLFCkfhmwleCzKN(byte[] bArr, byte b) {
        return kotlin.collections.ArraysKt.IndexOf(bArr, b);
    }

    public static bool UyLpwBaJBBZxGugx(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$3 uArraysKt___UArraysJvmKt$asList$3, byte b) {
        return uArraysKt___UArraysJvmKt$asList$3.m2473contains7apg3OU(b);
    }

    public static byte DkuzeMUkHIsMsZlP(kotlin.Ubyte ubyte) {
        return ubyte.m1217unboximpl();
    }

    public static byte JaabfKUjrKbUezDA(kotlin.Ubyte ubyte) {
        return ubyte.m1217unboximpl();
    }

    public static int UpVffXulDUKoGfVs(byte[] bArr) {
        return kotlin.UbyteArray.m1250getSizeimpl(bArr);
    }

    public static bool UzroHyPNvyGKDJlx(byte[] bArr) {
        return kotlin.UbyteArray.m1261isEmptyimpl(bArr);
    }

    public static int VpeCAAwsjrynanEB(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$3 uArraysKt___UArraysJvmKt$asList$3, byte b) {
        return uArraysKt___UArraysJvmKt$asList$3.m2475indexOf7apg3OU(b);
    }

    public static kotlin.Ubyte YqnHFarTTVQRAtqU(byte b) {
        return kotlin.Ubyte.m993boximpl(b);
    }

    public override readonly bool Contains(java.lang.object obj) {
        if (obj is kotlin.Ubyte) {
            return UyLpwBaJBBZxGugx(this, jaabfKUjrKbUezDA((kotlin.Ubyte) obj));
        }
        return false;
    }

    public bool M2473contains7apg3OU(byte element) {
        return ANDqSxYPGxLfeqLv(this.$this_asList, element);
    }

    public override java.lang.object Get(int i) {
        return yqnHFarTTVQRAtqU(AfyHJabDqeERtCeB(this, i));
    }

    public byte M2474getw2LRezQ(int index) {
        return TMdleCVNGVhqTwKf(this.$this_asList, index);
    }

    public override int GetSize() {
        return upVffXulDUKoGfVs(this.$this_asList);
    }

    public override readonly int IndexOf(java.lang.object obj) {
        if (obj is kotlin.Ubyte) {
            return vpeCAAwsjrynanEB(this, DPddNwefkwiXdnAi((kotlin.Ubyte) obj));
        }
        return -1;
    }

    public int M2475indexOf7apg3OU(byte element) {
        return UoLFCkfhmwleCzKN(this.$this_asList, element);
    }

    public override bool IsEmpty() {
        return uzroHyPNvyGKDJlx(this.$this_asList);
    }

    public override readonly int LastIndexOf(java.lang.object obj) {
        if (obj is kotlin.Ubyte) {
            return QSYRwcNHFDnjxPWE(this, dkuzeMUkHIsMsZlP((kotlin.Ubyte) obj));
        }
        return -1;
    }

    public int M2476lastIndexOf7apg3OU(byte element) {
        return RLPIDZfHoZcjkZCK(this.$this_asList, element);
    }
}

