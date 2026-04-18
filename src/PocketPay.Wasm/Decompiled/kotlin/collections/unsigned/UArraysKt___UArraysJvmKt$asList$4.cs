namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u000e*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\u00060\u0003j\u0002`\u0004J\b\u0010\t\u001a\u00020\nH\u0016J\u0018\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\u0002H\u0096\u0002¢\u0006\u0004\b\r\u0010\u000eJ\u0018\u0010\u000f\u001a\u00020\u00022\u0006\u0010\u0010\u001a\u00020\u0006H\u0096\u0002¢\u0006\u0004\b\u0011\u0010\u0012J\u0017\u0010\u0013\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\u0002H\u0016¢\u0006\u0004\b\u0014\u0010\u0015J\u0017\u0010\u0016\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\u0002H\u0016¢\u0006\u0004\b\u0017\u0010\u0015R\u0014\u0010\u0005\u001a\u00020\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0007\u0010\b¨\u0006\u0018"}, d2 = {"kotlin/collections/unsigned/UArraysKt___UArraysJvmKt$asList$4", "Lkotlin/collections/AbstractList;", "Lkotlin/Ushort;", "Ljava/util/RandomAccess;", "Lkotlin/collections/RandomAccess;", "size", "", "getSize", "()I", "isEmpty", "", "contains", "element", "contains-xj2QHRw", "(S)Z", "get", "index", "get-Mh2AYeg", "(I)S", "indexOf", "indexOf-xj2QHRw", "(S)I", "lastIndexOf", "lastIndexOf-xj2QHRw", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class UArraysKt___UArraysJvmKt$asList$4 : kotlin.collections.AbstractList<kotlin.Ushort> : java.util.RandomAccess {
    readonly short[] $this_asList;

    UArraysKt___UArraysJvmKt$asList$4(short[] sArr) {
        this.$this_asList = sArr;
    }

    public static int BgNgmxpmBJchnxUz(short[] sArr) {
        return kotlin.UshortArray.m2257getSizeimpl(sArr);
    }

    public static short CuNXgMVdOaSEXdQK(short[] sArr, int i) {
        return kotlin.UshortArray.m2253getMh2AYeg(sArr, i);
    }

    public static int DsuqGaUNPztVCQep(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$4 uArraysKt___UArraysJvmKt$asList$4, short s) {
        return uArraysKt___UArraysJvmKt$asList$4.m2479indexOfxj2QHRw(s);
    }

    public static bool HIPtTsDzOlJYZLlN(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$4 uArraysKt___UArraysJvmKt$asList$4, short s) {
        return uArraysKt___UArraysJvmKt$asList$4.m2477containsxj2QHRw(s);
    }

    public static short HaYEQdYpPSAzVyPq(kotlin.Ushort ushort) {
        return ushort.m2224unboximpl();
    }

    public static int INDtjdOhhkeNJvKv(short[] sArr, short s) {
        return kotlin.collections.ArraysKt.LastIndexOf(sArr, s);
    }

    public static short PzkEnoDSTZjjqtOB(kotlin.Ushort ushort) {
        return ushort.m2224unboximpl();
    }

    public static short UqVpGmvHHcoKKZdR(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$4 uArraysKt___UArraysJvmKt$asList$4, int i) {
        return uArraysKt___UArraysJvmKt$asList$4.m2478getMh2AYeg(i);
    }

    public static kotlin.Ushort YfhuHKJvNUUSKhmU(short s) {
        return kotlin.Ushort.m2000boximpl(s);
    }

    public static bool AkRCxApAeXauPkec(short[] sArr, short s) {
        return kotlin.UshortArray.m2240containsxj2QHRw(sArr, s);
    }

    public static int CxCsdJmIpNLbLDdp(kotlin.collections.unsigned.UArraysKt___UArraysJvmKt$asList$4 uArraysKt___UArraysJvmKt$asList$4, short s) {
        return uArraysKt___UArraysJvmKt$asList$4.m2480lastIndexOfxj2QHRw(s);
    }

    public static int CyRJBWroMRCObeKj(short[] sArr, short s) {
        return kotlin.collections.ArraysKt.IndexOf(sArr, s);
    }

    public static short FLwWKTggrthBqBZb(kotlin.Ushort ushort) {
        return ushort.m2224unboximpl();
    }

    public static bool OunetiflmYvYpnTb(short[] sArr) {
        return kotlin.UshortArray.m2268isEmptyimpl(sArr);
    }

    public override readonly bool Contains(java.lang.object obj) {
        if (obj is kotlin.Ushort) {
            return HIPtTsDzOlJYZLlN(this, HaYEQdYpPSAzVyPq((kotlin.Ushort) obj));
        }
        return false;
    }

    public bool M2477containsxj2QHRw(short element) {
        return akRCxApAeXauPkec(this.$this_asList, element);
    }

    public override java.lang.object Get(int i) {
        return YfhuHKJvNUUSKhmU(UqVpGmvHHcoKKZdR(this, i));
    }

    public short M2478getMh2AYeg(int index) {
        return CuNXgMVdOaSEXdQK(this.$this_asList, index);
    }

    public override int GetSize() {
        return BgNgmxpmBJchnxUz(this.$this_asList);
    }

    public override readonly int IndexOf(java.lang.object obj) {
        if (obj is kotlin.Ushort) {
            return DsuqGaUNPztVCQep(this, PzkEnoDSTZjjqtOB((kotlin.Ushort) obj));
        }
        return -1;
    }

    public int M2479indexOfxj2QHRw(short element) {
        return cyRJBWroMRCObeKj(this.$this_asList, element);
    }

    public override bool IsEmpty() {
        return ounetiflmYvYpnTb(this.$this_asList);
    }

    public override readonly int LastIndexOf(java.lang.object obj) {
        if (obj is kotlin.Ushort) {
            return cxCsdJmIpNLbLDdp(this, fLwWKTggrthBqBZb((kotlin.Ushort) obj));
        }
        return -1;
    }

    public int M2480lastIndexOfxj2QHRw(short element) {
        return INDtjdOhhkeNJvKv(this.$this_asList, element);
    }
}

