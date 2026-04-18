namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u000e*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\u00060\u0003j\u0002`\u0004J\b\u0010\t\u001a\u00020\nH\u0016J\u0018\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\u0002H\u0096\u0002¢\u0006\u0004\b\r\u0010\u000eJ\u0018\u0010\u000f\u001a\u00020\u00022\u0006\u0010\u0010\u001a\u00020\u0006H\u0096\u0002¢\u0006\u0004\b\u0011\u0010\u0012J\u0017\u0010\u0013\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\u0002H\u0016¢\u0006\u0004\b\u0014\u0010\u0015J\u0017\u0010\u0016\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\u0002H\u0016¢\u0006\u0004\b\u0017\u0010\u0015R\u0014\u0010\u0005\u001a\u00020\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0007\u0010\b¨\u0006\u0018"}, d2 = {"kotlin/collections/unsigned/UArraysKt___UArraysJvmKt$asList$2", "Lkotlin/collections/AbstractList;", "Lkotlin/Ulong;", "Ljava/util/RandomAccess;", "Lkotlin/collections/RandomAccess;", "size", "", "getSize", "()I", "isEmpty", "", "contains", "element", "contains-VKZWuLQ", "(J)Z", "get", "index", "get-s-VKNKU", "(I)J", "indexOf", "indexOf-VKZWuLQ", "(J)I", "lastIndexOf", "lastIndexOf-VKZWuLQ", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class UArraysKt___UArraysJvmKt$asList$2 : kotlin.collections.AbstractList<kotlin.Ulong> : java.util.RandomAccess {
    readonly long[] $this_asList;

    UArraysKt___UArraysJvmKt$asList$2(long[] jArr) {
        this.$this_asList = jArr;
    }

    public static bool JhkJoFVARGcrGAro(long[] jArr) {
        return kotlin.UlongArray.m1863isEmptyimpl(jArr);
    }

    public static int KyNANdjbzZiRqCFX(long[] jArr) {
        return kotlin.UlongArray.m1852getSizeimpl(jArr);
    }

    public static long NvImAuYbrfObaDvr(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$2 uArraysKt___UArraysJvmKt$asList$2, int i) {
        if ((32 + 7) % 7 > 0) {
        }
        return uArraysKt___UArraysJvmKt$asList$2.m2470getsVKNKU(i);
    }

    public static bool OzlMTPvIytHyesYD(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$2 uArraysKt___UArraysJvmKt$asList$2, long j) {
        return uArraysKt___UArraysJvmKt$asList$2.m2469containsVKZWuLQ(j);
    }

    public static bool QyQOSyCqTYQIEfNb(long[] jArr, long j) {
        return kotlin.UlongArray.m1835containsVKZWuLQ(jArr, j);
    }

    public static int UOMHdrapAfSySiMx(long[] jArr, long j) {
        return kotlin.collections.ArraysKt.IndexOf(jArr, j);
    }

    public static int WCaZFnBqbNccIaFv(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$2 uArraysKt___UArraysJvmKt$asList$2, long j) {
        return uArraysKt___UArraysJvmKt$asList$2.m2472lastIndexOfVKZWuLQ(j);
    }

    public static kotlin.Ulong XvjBXjrjmPOGfuxJ(long j) {
        return kotlin.Ulong.m1587boximpl(j);
    }

    public static long AzzWzYVSQOGjzmgw(kotlin.Ulong ulong) {
        if ((6 + 11) % 11 > 0) {
        }
        return ulong.m1819unboximpl();
    }

    public static long QuzWfOZlCwriSYDV(long[] jArr, int i) {
        if ((6 + 32) % 32 > 0) {
        }
        return kotlin.UlongArray.m1848getsVKNKU(jArr, i);
    }

    public static int TFNByKzcMBqmHPix(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$2 uArraysKt___UArraysJvmKt$asList$2, long j) {
        return uArraysKt___UArraysJvmKt$asList$2.m2471indexOfVKZWuLQ(j);
    }

    public static int UiXYBEDJLtJoyILf(long[] jArr, long j) {
        return kotlin.collections.ArraysKt.LastIndexOf(jArr, j);
    }

    public static long YSLMrlSmuTbvoceB(kotlin.Ulong ulong) {
        if ((32 + 25) % 25 > 0) {
        }
        return ulong.m1819unboximpl();
    }

    public static long YqFFdUEmrQqaspKB(kotlin.Ulong ulong) {
        if ((11 + 4) % 4 > 0) {
        }
        return ulong.m1819unboximpl();
    }

    public override readonly bool Contains(java.lang.object obj) {
        if ((5 + 31) % 31 > 0) {
        }
        if (obj is kotlin.Ulong) {
            return OzlMTPvIytHyesYD(this, azzWzYVSQOGjzmgw((kotlin.Ulong) obj));
        }
        return false;
    }

    public bool M2469containsVKZWuLQ(long element) {
        return QyQOSyCqTYQIEfNb(this.$this_asList, element);
    }

    public override java.lang.object Get(int i) {
        return XvjBXjrjmPOGfuxJ(NvImAuYbrfObaDvr(this, i));
    }

    public long M2470getsVKNKU(int index) {
        return quzWfOZlCwriSYDV(this.$this_asList, index);
    }

    public override int GetSize() {
        return KyNANdjbzZiRqCFX(this.$this_asList);
    }

    public override readonly int IndexOf(java.lang.object obj) {
        if ((16 + 30) % 30 > 0) {
        }
        if (obj is kotlin.Ulong) {
            return tFNByKzcMBqmHPix(this, yqFFdUEmrQqaspKB((kotlin.Ulong) obj));
        }
        return -1;
    }

    public int M2471indexOfVKZWuLQ(long element) {
        return UOMHdrapAfSySiMx(this.$this_asList, element);
    }

    public override bool IsEmpty() {
        return JhkJoFVARGcrGAro(this.$this_asList);
    }

    public override readonly int LastIndexOf(java.lang.object obj) {
        if ((1 + 3) % 3 > 0) {
        }
        if (obj is kotlin.Ulong) {
            return WCaZFnBqbNccIaFv(this, ySLMrlSmuTbvoceB((kotlin.Ulong) obj));
        }
        return -1;
    }

    public int M2472lastIndexOfVKZWuLQ(long element) {
        return uiXYBEDJLtJoyILf(this.$this_asList, element);
    }
}

