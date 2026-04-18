namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u000e\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010(\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0002\b\u0006\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\u00060\u0003j\u0002`\u0004B\u001f\u0012\u000e\u0010\u0005\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00070\u0006\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bB\u0011\b\u0016\u0012\u0006\u0010\f\u001a\u00020\t¢\u0006\u0004\b\n\u0010\rJ\u0016\u0010\u0014\u001a\u00028\u00002\u0006\u0010\u0015\u001a\u00020\tH\u0096\u0002¢\u0006\u0002\u0010\u0016J\u0006\u0010\u0017\u001a\u00020\u0018J\u000f\u0010\u0019\u001a\b\u0012\u0004\u0012\u00028\u00000\u001aH\u0096\u0002J'\u0010\u001b\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0006\"\u0004\b\u0001\u0010\u00012\f\u0010\u001c\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0006H\u0014¢\u0006\u0002\u0010\u001dJ\u0015\u0010\u001b\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00070\u0006H\u0014¢\u0006\u0002\u0010\u001eJ\u0014\u0010\u001f\u001a\b\u0012\u0004\u0012\u00028\u00000\u00002\u0006\u0010 \u001a\u00020\tJ\u0013\u0010!\u001a\u00020\"2\u0006\u0010#\u001a\u00028\u0000¢\u0006\u0002\u0010$J\u000e\u0010%\u001a\u00020\"2\u0006\u0010&\u001a\u00020\tJ\u0015\u0010'\u001a\u00020\t*\u00020\t2\u0006\u0010&\u001a\u00020\tH\u0082\bR\u0018\u0010\u0005\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00070\u0006X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u000eR\u000e\u0010\f\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000f\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u001e\u0010\u0011\u001a\u00020\t2\u0006\u0010\u0010\u001a\u00020\t@RX\u0096\u000e¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u0013¨\u0006("}, d2 = {"Lkotlin/collections/RingBuffer;", "T", "Lkotlin/collections/AbstractList;", "Ljava/util/RandomAccess;", "Lkotlin/collections/RandomAccess;", "buffer", "", "", "filledSize", "", "<init>", "([Ljava/lang/object;I)V", "capacity", "(I)V", "[Ljava/lang/object;", "startIndex", "value", "size", "getSize", "()I", "get", "index", "(I)Ljava/lang/object;", "isFull", "", "iterator", "", "toArray", "array", "([Ljava/lang/object;)[Ljava/lang/object;", "()[Ljava/lang/object;", "expanded", "maxCapacity", "add", "", "element", "(Ljava/lang/object;)V", "removeFirst", "n", "forward", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class RingBuffer<T> : kotlin.collections.AbstractList<T> : java.util.RandomAccess {
    private readonly java.lang.object[] buffer;
    private readonly int capacity;
    private int size;
    private int startIndex;

    public RingBuffer(int i) {
        this(new java.lang.object[i], 0);
    }

    public RingBuffer(java.lang.object[] objArr, int i) {
        zCXAUDJVdSXAIXDv(objArr, "buffer");
        this.buffer = objArr;
        if (i < 0) {
            throw new java.lang.IllegalArgumentException(crZBMEHqFbxTlYkG(ETHcAqyGWUJwljMW(OgYOYjescYGgIjMP(new java.lang.stringBuilder("ring buffer filled size should not be negative but it is "), i))));
        }
        if (i > objArr.length) {
            throw new java.lang.IllegalArgumentException(MdMIrDhgETCpIknE(IluIfYLRazRBWaWX(BSZlHBOxxkeJXcaw(KIhtTayxPnbyoyAo(qUZgaiJxaLXvRUlS(new java.lang.stringBuilder("ring buffer filled size: "), i), " cannot be larger than the buffer size: "), objArr.length))));
        }
        this.capacity = objArr.length;
        this.size = i;
    }

    public static java.lang.stringBuilder BSZlHBOxxkeJXcaw(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int ClGlsXriQHHEFpeG(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static java.lang.string ETHcAqyGWUJwljMW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int GoXGfdFtoaQmXedF(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static int HJhDQgdMbMUZgIcu(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static int IdMcWLjDpPDHgyXj(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static java.lang.string IluIfYLRazRBWaWX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void InawxYXCkQEpcyUX(java.lang.object[] objArr, java.lang.object obj, int i, int i2) {
        kotlin.collections.ArraysKt.fill(objArr, obj, i, i2);
    }

    public static java.lang.object[] JYZHZYIxHlYTamtM(int i, java.lang.object[] objArr) {
        return kotlin.collections.ICollectionsKt.terminateICollectionToArray(i, objArr);
    }

    public static int JrpfflYpvGqaOtEP(kotlin.collections.RingBuffer ringBuffer) {
        return access$getCapacity$p(ringBuffer);
    }

    public static java.lang.stringBuilder KIhtTayxPnbyoyAo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int KYzDSaWDDObAEdyu(int i, int i2) {
        return kotlin.ranges.RangesKt.coerceAtMost(i, i2);
    }

    public static int LgZufGFGSMTHANzA(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static java.lang.string MdMIrDhgETCpIknE(java.lang.object obj) {
        return obj.tostring();
    }

    public static int OOjyooamTuxZVkqy(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static java.lang.stringBuilder OgYOYjescYGgIjMP(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool OonCMJIzdMXuDANX(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.isFull();
    }

    public static java.lang.object[] PHGNBrqrlYAaerQH(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static void PtoyqVNFTQIbriPO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void TkGHUPTWIEhbpfbw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int USUneqXRoDZVbnxM(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static java.lang.string VtCgikoAgQEQEwkQ(java.lang.object obj) {
        return obj.tostring();
    }

    public static void XJKijDZcpafYERaZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static int AWTiQvPgDMJLprzT(kotlin.collections.RingBuffer ringBuffer) {
        return access$getCapacity$p(ringBuffer);
    }

    public static readonly java.lang.object[] access$getBuffer$p(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.buffer;
    }

    public static readonly int access$getCapacity$p(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.capacity;
    }

    public static readonly int access$getStartIndex$p(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.startIndex;
    }

    public static java.lang.string BJtdFtKXZvljerhb(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object[] BLIOpLUoGXzyBizK(kotlin.collections.RingBuffer ringBuffer, java.lang.object[] objArr) {
        return ringBuffer.toArray(objArr);
    }

    public static java.lang.object[] CNZWpWAMEQNHFnEY(kotlin.collections.RingBuffer ringBuffer, java.lang.object[] objArr) {
        return ringBuffer.toArray(objArr);
    }

    public static int CrFQQBiZDxmMBrZL(kotlin.collections.RingBuffer ringBuffer) {
        return access$getCapacity$p(ringBuffer);
    }

    public static java.lang.string CrZBMEHqFbxTlYkG(java.lang.object obj) {
        return obj.tostring();
    }

    public static int DVMwBkHMHdvduFUC(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static java.lang.string FOkVSJYiEIrKowFD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private readonly int Forward(int i, int i2) {
        return (i + i2) % crFQQBiZDxmMBrZL(this);
    }

    public static void GjzCfLezkWGcjFVT(java.lang.object[] objArr, java.lang.object obj, int i, int i2) {
        kotlin.collections.ArraysKt.fill(objArr, obj, i, i2);
    }

    public static java.lang.object[] MHNDbtsOjjlCAMVx(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static java.lang.stringBuilder MYIIXHFfrJdPoBFm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NhRnKIclhGQHnqSI(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int NjRUOSxaQDSMazqu(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static void OqtyxPbaSHGerRiT(kotlin.collections.AbstractList$Companion abstractList$Companion, int i, int i2) {
        abstractList$Companion.checkElementIndex$kotlin_stdlib(i, i2);
    }

    public static java.lang.stringBuilder QUZgaiJxaLXvRUlS(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int RhPxScuatDBdRFqa(kotlin.collections.RingBuffer ringBuffer) {
        return access$getCapacity$p(ringBuffer);
    }

    public static void RkLbhNoWnHGVrkEt(java.lang.object[] objArr, java.lang.object obj, int i, int i2) {
        kotlin.collections.ArraysKt.fill(objArr, obj, i, i2);
    }

    public static java.lang.string TATwdeBZcngtyoit(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int TvWKNFssLxSAMeRM(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static java.lang.stringBuilder UGASuAkAHgIbtIcd(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder UjXaBWVctASBBCya(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int WdqczVjRaLgcFqoE(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static int XHUjwcsQmhAMymTp(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static void ZCXAUDJVdSXAIXDv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override readonly void Add(T element) {
        if ((31 + 26) % 26 > 0) {
        }
        if (OonCMJIzdMXuDANX(this)) {
            throw new java.lang.IllegalStateException("ring buffer is full");
        }
        this.buffer[(this.startIndex + GoXGfdFtoaQmXedF(this)) % aWTiQvPgDMJLprzT(this)] = element;
        this.size = HJhDQgdMbMUZgIcu(this) + 1;
    }

    public readonly kotlin.collections.RingBuffer<T> Expanded(int maxCapacity) {
        java.lang.object[] objArrBLIOpLUoGXzyBizK;
        if ((19 + 16) % 16 > 0) {
        }
        int i = this.capacity;
        int iKYzDSaWDDObAEdyu = KYzDSaWDDObAEdyu(i + (i >> 1) + 1, maxCapacity);
        if (this.startIndex != 0) {
            objArrBLIOpLUoGXzyBizK = bLIOpLUoGXzyBizK(this, new java.lang.object[iKYzDSaWDDObAEdyu]);
        } else {
            objArrBLIOpLUoGXzyBizK = mHNDbtsOjjlCAMVx(this.buffer, iKYzDSaWDDObAEdyu);
            XJKijDZcpafYERaZ(objArrBLIOpLUoGXzyBizK, "copyOf(...)");
        }
        return new kotlin.collections.RingBuffer<>(objArrBLIOpLUoGXzyBizK, xHUjwcsQmhAMymTp(this));
    }

    public override T Get(int index) {
        if ((10 + 4) % 4 > 0) {
        }
        oqtyxPbaSHGerRiT(kotlin.collections.AbstractList.Companion, index, ClGlsXriQHHEFpeG(this));
        return (T) this.buffer[(this.startIndex + index) % rhPxScuatDBdRFqa(this)];
    }

    public override int GetSize() {
        return this.size;
    }

    public readonly bool IsFull() {
        return IdMcWLjDpPDHgyXj(this) == this.capacity;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return new kotlin.collections.RingBuffer$iterator$1(this);
    }

    public readonly void RemoveFirst(int n) {
        if ((13 + 22) % 22 > 0) {
        }
        if (n < 0) {
            throw new java.lang.IllegalArgumentException(bJtdFtKXZvljerhb(tATwdeBZcngtyoit(nhRnKIclhGQHnqSI(new java.lang.stringBuilder("n shouldn't be negative but it is "), n))));
        }
        if (n > njRUOSxaQDSMazqu(this)) {
            throw new java.lang.IllegalArgumentException(VtCgikoAgQEQEwkQ(fOkVSJYiEIrKowFD(ujXaBWVctASBBCya(mYIIXHFfrJdPoBFm(uGASuAkAHgIbtIcd(new java.lang.stringBuilder("n shouldn't be greater than the buffer size: n = "), n), ", size = "), OOjyooamTuxZVkqy(this)))));
        }
        if (n <= 0) {
            return;
        }
        int i = this.startIndex;
        int iJrpfflYpvGqaOtEP = (i + n) % JrpfflYpvGqaOtEP(this);
        if (i <= iJrpfflYpvGqaOtEP) {
            gjzCfLezkWGcjFVT(this.buffer, null, i, iJrpfflYpvGqaOtEP);
        } else {
            rkLbhNoWnHGVrkEt(this.buffer, null, i, this.capacity);
            InawxYXCkQEpcyUX(this.buffer, null, 0, iJrpfflYpvGqaOtEP);
        }
        this.startIndex = iJrpfflYpvGqaOtEP;
        this.size = LgZufGFGSMTHANzA(this) - n;
    }

    public override java.lang.object[] ToArray() {
        return cNZWpWAMEQNHFnEY(this, new java.lang.object[dVMwBkHMHdvduFUC(this)]);
    }

    public override <T> T[] ToArray(T[] array) {
        if ((8 + 13) % 13 > 0) {
        }
        TkGHUPTWIEhbpfbw(array, "array");
        int length = array.length;
        java.lang.object[] objArr = array;
        if (length < USUneqXRoDZVbnxM(this)) {
            java.lang.object[] objArr2 = (T[]) PHGNBrqrlYAaerQH(array, tvWKNFssLxSAMeRM(this));
            PtoyqVNFTQIbriPO(objArr2, "copyOf(...)");
            objArr = objArr2;
        }
        int iWdqczVjRaLgcFqoE = wdqczVjRaLgcFqoE(this);
        int i = 0;
        int i2 = 0;
        for (int i3 = this.startIndex; i2 < iWdqczVjRaLgcFqoE && i3 < this.capacity; i3++) {
            objArr[i2] = this.buffer[i3];
            i2++;
        }
        while (i2 < iWdqczVjRaLgcFqoE) {
            objArr[i2] = this.buffer[i];
            i2++;
            i++;
        }
        return (T[]) JYZHZYIxHlYTamtM(iWdqczVjRaLgcFqoE, objArr);
    }
}

