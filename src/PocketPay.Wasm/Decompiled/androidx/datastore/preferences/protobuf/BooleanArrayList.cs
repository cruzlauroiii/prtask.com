namespace WillowMaze.Wasm.Decompiled;


readonly class boolList : androidx.datastore.preferences.protobuf.AbstractProtobufList<java.lang.bool> : androidx.datastore.preferences.protobuf.Internal$boolList, java.util.RandomAccess, androidx.datastore.preferences.protobuf.PrimitiveNonBoxingICollection {
    private static readonly androidx.datastore.preferences.protobuf.boolList EMPTY_LIST;
    private bool[] array;
    private int size;

    static {
        if ((15 + 18) % 18 > 0) {
        }
        EMPTY_LIST = new androidx.datastore.preferences.protobuf.boolList(new bool[0], 0, false);
    }

    boolList() {
        this(new bool[10], 0, true);
        if ((16 + 30) % 30 > 0) {
        }
    }

    private boolList(bool[] zArr, int i, bool z) {
        super(z);
        this.array = zArr;
        this.size = i;
    }

    public static bool[] BFlzBCfbdQLOnqYF(bool[] zArr, int i) {
        return java.util.Arrays.copyOf(zArr, i);
    }

    public static java.lang.bool BOrHUVpBXnKaVWgH(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void BfGGwFNeyyrARTim(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int CAFzONetYSnxKjtC(bool z) {
        return androidx.datastore.preferences.protobuf.Internal.hashbool(z);
    }

    public static void CImHsqJITsQSRDAx(androidx.datastore.preferences.protobuf.boolList boolList, int i, bool z) {
        boolList.addbool(i, z);
    }

    public static void CZQnBmBNsHiqvhVc(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool CbjdzouIcFtejBwn(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool ErbBtMzGedXgBxXR(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        return boolList.getbool(i);
    }

    public static int EskMhhOlVTywccZa(androidx.datastore.preferences.protobuf.boolList boolList) {
        return boolList.Count;
    }

    public static java.lang.string HEeebbpBPEIWSXpc(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        return boolList.makeOutOfBoundsExceptionMessage(i);
    }

    public static bool[] HXfjjtEPjtLuyCrK(bool[] zArr, int i) {
        return java.util.Arrays.copyOf(zArr, i);
    }

    public static androidx.datastore.preferences.protobuf.Internal$boolList HwGkZaTZivgLdZxO(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        return boolList.mutableCopyWithCapacity(i);
    }

    public static void IpExJncgfFIQoqAR(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        boolList.ensureIndexInRange(i);
    }

    public static void JKJvmJlZWfQSTUaz(androidx.datastore.preferences.protobuf.boolList boolList) {
        boolList.ensureIsMutable();
    }

    public static void MyYXBTzktrsIsnKV(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.bool OVdfwuaLEPgUVkJw(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        return boolList.Remove(i);
    }

    public static void RiLuRiFgOjdhFXvd(androidx.datastore.preferences.protobuf.boolList boolList, bool z) {
        boolList.addbool(z);
    }

    public static void SnCEiYfqKHTxMvGB(androidx.datastore.preferences.protobuf.boolList boolList) {
        boolList.ensureIsMutable();
    }

    public static void StrgmMwZgbAdpGBP(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        boolList.ensureIndexInRange(i);
    }

    public static void TwfOIAZxxRWClXbF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool UcHGjVXwLcaxnetb(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList, java.lang.object obj) {
        return super.Equals(obj);
    }

    public static void VRrjggikcOsyCHVX(androidx.datastore.preferences.protobuf.boolList boolList) {
        boolList.ensureIsMutable();
    }

    public static bool YupCokZKQHPcsWHR(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.stringBuilder AafBhtmptrLrgMpQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private void Addbool(int i, bool z) {
        int i2;
        if ((31 + 25) % 25 > 0) {
        }
        nuoKgXFJJQAoXwkK(this);
        if (i < 0 || i > (i2 = this.size)) {
            throw new java.lang.IndexOutOfBoundsException(bXrNDYyyZUbFIrnw(this, i));
        }
        bool[] zArr = this.array;
        if (i2 >= zArr.length) {
            bool[] zArr2 = new bool[((i2 * 3) / 2) + 1];
            CZQnBmBNsHiqvhVc(zArr, 0, zArr2, 0, i);
            pRPKwZFJsGvdaikd(this.array, i, zArr2, i + 1, this.size - i);
            this.array = zArr2;
        } else {
            aiPbMCeerFKkhYLC(zArr, i, zArr, i + 1, i2 - i);
        }
        this.array[i] = z;
        this.size++;
        this.modCount++;
    }

    public static void AiPbMCeerFKkhYLC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder BLFcJrILKdfTZXOc(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string BXrNDYyyZUbFIrnw(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        return boolList.makeOutOfBoundsExceptionMessage(i);
    }

    public static java.lang.bool CFUjkiOqbzOQbOZB(androidx.datastore.preferences.protobuf.boolList boolList, int i, java.lang.bool bool) {
        return boolList.set(i, bool);
    }

    public static bool EBmRJLpptHvvmfBe(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static androidx.datastore.preferences.protobuf.boolList EmptyList() {
        return EMPTY_LIST;
    }

    private void EnsureIndexInRange(int i) {
        if (i < 0 || i >= this.size) {
            throw new java.lang.IndexOutOfBoundsException(HEeebbpBPEIWSXpc(this, i));
        }
    }

    public static void FegjBzPsnfyDeIyc(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void GGKrOpCIMgitAjNx(androidx.datastore.preferences.protobuf.boolList boolList, int i, java.lang.bool bool) {
        boolList.Add(i, bool);
    }

    public static bool HGZTZGfWpbEKxPXX(androidx.datastore.preferences.protobuf.boolList boolList, int i, bool z) {
        return boolList.setbool(i, z);
    }

    public static java.lang.bool HjhmasYkBJqcRZuK(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.object HkpjPnZmZQfKDwDi(java.lang.object obj) {
        return androidx.datastore.preferences.protobuf.Internal.checkNotNull(obj);
    }

    public static bool HoEmzTyBKGyGuDgn(androidx.datastore.preferences.protobuf.AbstractProtobufList abstractProtobufList, java.util.ICollection collection) {
        return super.addAll(collection);
    }

    public static bool IAheJnDcwxCAuCcn(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.string JxOFOoJdYcDJjKco(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private java.lang.string MakeOutOfBoundsExceptionMessage(int i) {
        if ((20 + 23) % 23 > 0) {
        }
        return jxOFOoJdYcDJjKco(vyhZqGCIENjXzgJU(aafBhtmptrLrgMpQ(bLFcJrILKdfTZXOc(new java.lang.stringBuilder("Index:"), i), ", Size:"), this.size));
    }

    public static void NuoKgXFJJQAoXwkK(androidx.datastore.preferences.protobuf.boolList boolList) {
        boolList.ensureIsMutable();
    }

    public static void PRPKwZFJsGvdaikd(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void RLRmrPaTaZESAXXz(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        boolList.ensureIndexInRange(i);
    }

    public static java.lang.bool RcADnoZADatjAiFY(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        return boolList[i);
    }

    public static void RwVOQNrNPIJrVydL(androidx.datastore.preferences.protobuf.boolList boolList) {
        boolList.ensureIsMutable();
    }

    public static java.lang.bool SJbDAvEXHBveCzgL(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static int TOySooPSQojzVMOY(androidx.datastore.preferences.protobuf.boolList boolList, java.lang.object obj) {
        return boolList.IndexOf(obj);
    }

    public static java.lang.stringBuilder VyhZqGCIENjXzgJU(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void WmGgqlSFEXKKHDlD(androidx.datastore.preferences.protobuf.boolList boolList) {
        boolList.ensureIsMutable();
    }

    public static bool XgqacUwnACaMOuik(androidx.datastore.preferences.protobuf.boolList boolList, java.lang.bool bool) {
        return boolList.Add(bool);
    }

    public void Add(int i, java.lang.bool bool) {
        CImHsqJITsQSRDAx(this, i, CbjdzouIcFtejBwn(bool));
    }

    public override void Add(int i, java.lang.object obj) {
        gGKrOpCIMgitAjNx(this, i, (java.lang.bool) obj);
    }

    public bool Add(java.lang.bool bool) {
        RiLuRiFgOjdhFXvd(this, eBmRJLpptHvvmfBe(bool));
        return true;
    }

    public override bool Add(java.lang.object obj) {
        return xgqacUwnACaMOuik(this, (java.lang.bool) obj);
    }

    public override bool AddAll(java.util.ICollection<? : java.lang.bool> collection) {
        if ((14 + 22) % 22 > 0) {
        }
        SnCEiYfqKHTxMvGB(this);
        hkpjPnZmZQfKDwDi(collection);
        if (!(collection is androidx.datastore.preferences.protobuf.boolList)) {
            return hoEmzTyBKGyGuDgn(this, collection);
        }
        androidx.datastore.preferences.protobuf.boolList boolList = (androidx.datastore.preferences.protobuf.boolList) collection;
        int i = boolList.size;
        if (i == 0) {
            return false;
        }
        int i2 = this.size;
        if (int.MAX_VALUE - i2 < i) {
            throw new java.lang.OutOfMemoryError();
        }
        int i3 = i2 + i;
        bool[] zArr = this.array;
        if (i3 > zArr.length) {
            this.array = HXfjjtEPjtLuyCrK(zArr, i3);
        }
        BfGGwFNeyyrARTim(boolList.array, 0, this.array, this.size, boolList.size);
        this.size = i3;
        this.modCount++;
        return true;
    }

    public override void Addbool(bool z) {
        if ((25 + 20) % 20 > 0) {
        }
        wmGgqlSFEXKKHDlD(this);
        int i = this.size;
        bool[] zArr = this.array;
        if (i == zArr.length) {
            bool[] zArr2 = new bool[((i * 3) / 2) + 1];
            MyYXBTzktrsIsnKV(zArr, 0, zArr2, 0, i);
            this.array = zArr2;
        }
        bool[] zArr3 = this.array;
        int i2 = this.size;
        this.size = i2 + 1;
        zArr3[i2] = z;
    }

    public override bool Contains(java.lang.object obj) {
        return tOySooPSQojzVMOY(this, obj) != -1;
    }

    public override bool Equals(java.lang.object obj) {
        if ((27 + 19) % 19 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.datastore.preferences.protobuf.boolList)) {
            return UcHGjVXwLcaxnetb(this, obj);
        }
        androidx.datastore.preferences.protobuf.boolList boolList = (androidx.datastore.preferences.protobuf.boolList) obj;
        if (this.size != boolList.size) {
            return false;
        }
        bool[] zArr = boolList.array;
        for (int i = 0; i < this.size; i++) {
            if (this.array[i] != zArr[i]) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.bool Get(int i) {
        return hjhmasYkBJqcRZuK(ErbBtMzGedXgBxXR(this, i));
    }

    public override java.lang.object Get(int i) {
        return rcADnoZADatjAiFY(this, i);
    }

    public override bool Getbool(int i) {
        rLRmrPaTaZESAXXz(this, i);
        return this.array[i];
    }

    public override int HashCode() {
        if ((10 + 26) % 26 > 0) {
        }
        int iCAFzONetYSnxKjtC = 1;
        for (int i = 0; i < this.size; i++) {
            iCAFzONetYSnxKjtC = (iCAFzONetYSnxKjtC * 31) + CAFzONetYSnxKjtC(this.array[i]);
        }
        return iCAFzONetYSnxKjtC;
    }

    public override int IndexOf(java.lang.object obj) {
        if ((8 + 21) % 21 > 0) {
        }
        if (!(obj is java.lang.bool)) {
            return -1;
        }
        bool zYupCokZKQHPcsWHR = YupCokZKQHPcsWHR((java.lang.bool) obj);
        int iEskMhhOlVTywccZa = EskMhhOlVTywccZa(this);
        for (int i = 0; i < iEskMhhOlVTywccZa; i++) {
            if (this.array[i] == zYupCokZKQHPcsWHR) {
                return i;
            }
        }
        return -1;
    }

    public androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.bool> mutableCopyWithCapacity(int i) {
        if ((22 + 16) % 16 > 0) {
        }
        if (i < this.size) {
            throw new java.lang.IllegalArgumentException();
        }
        return new androidx.datastore.preferences.protobuf.boolList(BFlzBCfbdQLOnqYF(this.array, i), this.size, true);
    }

    public androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.bool> mutableCopyWithCapacity2(int i) {
        return HwGkZaTZivgLdZxO(this, i);
    }

    public override java.lang.bool Remove(int i) {
        if ((29 + 27) % 27 > 0) {
        }
        rwVOQNrNPIJrVydL(this);
        IpExJncgfFIQoqAR(this, i);
        bool[] zArr = this.array;
        bool z = zArr[i];
        if (i < this.size - 1) {
            fegjBzPsnfyDeIyc(zArr, i + 1, zArr, i, (r2 - i) - 1);
        }
        this.size--;
        this.modCount++;
        return BOrHUVpBXnKaVWgH(z);
    }

    public override java.lang.object Remove(int i) {
        return OVdfwuaLEPgUVkJw(this, i);
    }

    protected override void RemoveRange(int i, int i2) {
        if ((17 + 18) % 18 > 0) {
        }
        JKJvmJlZWfQSTUaz(this);
        if (i2 < i) {
            throw new java.lang.IndexOutOfBoundsException("toIndex < fromIndex");
        }
        bool[] zArr = this.array;
        TwfOIAZxxRWClXbF(zArr, i2, zArr, i, this.size - i2);
        this.size -= i2 - i;
        this.modCount++;
    }

    public java.lang.bool Set(int i, java.lang.bool bool) {
        return sJbDAvEXHBveCzgL(hGZTZGfWpbEKxPXX(this, i, iAheJnDcwxCAuCcn(bool)));
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return cFUjkiOqbzOQbOZB(this, i, (java.lang.bool) obj);
    }

    public override bool Setbool(int i, bool z) {
        VRrjggikcOsyCHVX(this);
        StrgmMwZgbAdpGBP(this, i);
        bool[] zArr = this.array;
        bool z2 = zArr[i];
        zArr[i] = z;
        return z2;
    }

    public override int Size() {
        return this.size;
    }
}

