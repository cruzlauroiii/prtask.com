namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\r*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\u00060\u0003j\u0002`\u0004J\b\u0010\t\u001a\u00020\nH\u0016J\u0018\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\u0002H\u0096\u0002¢\u0006\u0004\b\r\u0010\u000eJ\u0018\u0010\u000f\u001a\u00020\u00022\u0006\u0010\u0010\u001a\u00020\u0006H\u0096\u0002¢\u0006\u0004\b\u0011\u0010\u0012J\u0017\u0010\u0013\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\u0002H\u0016¢\u0006\u0004\b\u0014\u0010\u0012J\u0017\u0010\u0015\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\u0002H\u0016¢\u0006\u0004\b\u0016\u0010\u0012R\u0014\u0010\u0005\u001a\u00020\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0007\u0010\b¨\u0006\u0017"}, d2 = {"kotlin/collections/unsigned/UArraysKt___UArraysJvmKt$asList$1", "Lkotlin/collections/AbstractList;", "Lkotlin/UInt;", "Ljava/util/RandomAccess;", "Lkotlin/collections/RandomAccess;", "size", "", "getSize", "()I", "isEmpty", "", "contains", "element", "contains-WZ4Q5Ns", "(I)Z", "get", "index", "get-pVg5ArA", "(I)I", "indexOf", "indexOf-WZ4Q5Ns", "lastIndexOf", "lastIndexOf-WZ4Q5Ns", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class UArraysKt___UArraysJvmKt$asList$1 : kotlin.collections.AbstractList<kotlin.UInt> : java.util.RandomAccess {
    readonly int[] $this_asList;

    UArraysKt___UArraysJvmKt$asList$1(int[] iArr) {
        this.$this_asList = iArr;
    }

    public static bool JCVEybfUhRNBOidO(int[] iArr) {
        return kotlin.UIntArray.m1562isEmptyimpl(iArr);
    }

    public static int QXQNuHAGuOhsFvDr(kotlin.UInt uInt) {
        return uInt.m1518unboximpl();
    }

    public static bool RZVRznaqWNteQkpL(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$1 uArraysKt___UArraysJvmKt$asList$1, int i) {
        return uArraysKt___UArraysJvmKt$asList$1.m2465containsWZ4Q5Ns(i);
    }

    public static int TifAtRjzCfOpXdAT(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$1 uArraysKt___UArraysJvmKt$asList$1, int i) {
        return uArraysKt___UArraysJvmKt$asList$1.m2468lastIndexOfWZ4Q5Ns(i);
    }

    public static int UKVQshdmsppMudae(int[] iArr, int i) {
        return kotlin.UIntArray.m1547getpVg5ArA(iArr, i);
    }

    public static int AFrQkDcRinRRadnn(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$1 uArraysKt___UArraysJvmKt$asList$1, int i) {
        return uArraysKt___UArraysJvmKt$asList$1.m2466getpVg5ArA(i);
    }

    public static bool DIKtLYrTrhhEBTPR(int[] iArr, int i) {
        return kotlin.UIntArray.m1534containsWZ4Q5Ns(iArr, i);
    }

    public static int FgwWmYSDhJnsAxLD(int[] iArr) {
        return kotlin.UIntArray.m1551getSizeimpl(iArr);
    }

    public static int FoHRvePxVwVAaVwr(kotlin.UInt uInt) {
        return uInt.m1518unboximpl();
    }

    public static int IodhDwZLyyKMFcpH(int[] iArr, int i) {
        return kotlin.collections.ArraysKt.IndexOf(iArr, i);
    }

    public static kotlin.UInt PPGYSTxJFMWPpWLd(int i) {
        return kotlin.UInt.m1286boximpl(i);
    }

    public static int TMECYLeKqyNQeXwj(kotlin.UInt uInt) {
        return uInt.m1518unboximpl();
    }

    public static int XjiVVxPiNzRlgLbE(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$1 uArraysKt___UArraysJvmKt$asList$1, int i) {
        return uArraysKt___UArraysJvmKt$asList$1.m2467indexOfWZ4Q5Ns(i);
    }

    public static int YOTgFEWLpXEFlvXr(int[] iArr, int i) {
        return kotlin.collections.ArraysKt.LastIndexOf(iArr, i);
    }

    public override readonly bool Contains(java.lang.object obj) {
        if (obj is kotlin.UInt) {
            return RZVRznaqWNteQkpL(this, foHRvePxVwVAaVwr((kotlin.UInt) obj));
        }
        return false;
    }

    public bool M2465containsWZ4Q5Ns(int element) {
        return dIKtLYrTrhhEBTPR(this.$this_asList, element);
    }

    public override java.lang.object Get(int i) {
        return pPGYSTxJFMWPpWLd(aFrQkDcRinRRadnn(this, i));
    }

    public int M2466getpVg5ArA(int index) {
        return UKVQshdmsppMudae(this.$this_asList, index);
    }

    public override int GetSize() {
        return fgwWmYSDhJnsAxLD(this.$this_asList);
    }

    public override readonly int IndexOf(java.lang.object obj) {
        if (obj is kotlin.UInt) {
            return xjiVVxPiNzRlgLbE(this, tMECYLeKqyNQeXwj((kotlin.UInt) obj));
        }
        return -1;
    }

    public int M2467indexOfWZ4Q5Ns(int element) {
        return iodhDwZLyyKMFcpH(this.$this_asList, element);
    }

    public override bool IsEmpty() {
        return JCVEybfUhRNBOidO(this.$this_asList);
    }

    public override readonly int LastIndexOf(java.lang.object obj) {
        if (obj is kotlin.UInt) {
            return TifAtRjzCfOpXdAT(this, QXQNuHAGuOhsFvDr((kotlin.UInt) obj));
        }
        return -1;
    }

    public int M2468lastIndexOfWZ4Q5Ns(int element) {
        return yOTgFEWLpXEFlvXr(this.$this_asList, element);
    }
}

