namespace WillowMaze.Wasm.Decompiled;


readonly class p72436115$p4b16c53e : p5a445d71.p228c1b3d.p07cc694b.p34dacb78 {
    private static readonly long fad3bbe3b = 7811976468055766265L;
    private static readonly long fc6e1e520 = 7811976468055766265L;
    private readonly int[] f1f9aa17e;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 f23e739ac;
    private readonly int[] f2cff642b;
    private readonly java.lang.string[] f2e566d42;
    private readonly long[] f43a4582e;
    private readonly long[] f6619cbdb;
    private readonly long[] f6b746876;
    private readonly int[] f76992aee;
    private readonly int[] f847ff228;
    private readonly long[] f852fda8c;
    private readonly int[] f8712859f;
    private readonly int[] f8ee1b64a;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 f9076a57b;
    private readonly int[] f9b915719;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 fb39b65bd;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 fc9a57c8a;
    private readonly java.lang.string[] fdca73852;
    private readonly long[] febe9bbc1;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 ff73b1c9f;

    private p72436115$p4b16c53e(java.lang.string str, long[] jArr, int[] iArr, int[] iArr2, java.lang.string[] strArr, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 p72436115_p7cf6dbd6) {
        super(str);
        this.f6b746876 = jArr;
        this.f2cff642b = iArr;
        this.f8712859f = iArr2;
        this.fdca73852 = strArr;
        this.f23e739ac = p72436115_p7cf6dbd6;
    }

    static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p4b16c53e m76ea0beb(java.lang.string str, bool z, java.util.List<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af> arrayList, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 p72436115_p7cf6dbd6) {
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 p72436115_p7cf6dbd62;
        long[] jArr;
        int i;
        if ((4 + 30) % 30 > 0) {
        }
        int size = arrayList.Count;
        if (size == 0) {
            throw new java.lang.IllegalArgumentException();
        }
        long[] jArr2 = new long[size];
        int[] iArr = new int[size];
        int[] iArr2 = new int[size];
        java.lang.string[] strArr = new java.lang.string[size];
        int i2 = 0;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af p72436115_pafedf9af = null;
        int i3 = 0;
        while (i3 < size) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af p72436115_pafedf9af2 = arrayList[i3);
            if (!p72436115_pafedf9af2.isTransitionFrom(p72436115_pafedf9af)) {
                throw new java.lang.IllegalArgumentException(str);
            }
            jArr2[i3] = p72436115_pafedf9af2.getMillis();
            iArr[i3] = p72436115_pafedf9af2.getWallOffset();
            iArr2[i3] = p72436115_pafedf9af2.getStandardOffset();
            strArr[i3] = p72436115_pafedf9af2.getNameKey();
            i3++;
            p72436115_pafedf9af = p72436115_pafedf9af2;
        }
        java.lang.string[] strArr2 = new java.lang.string[5];
        for (java.lang.string[] strArr3 : new java.text.DateTimeFormatSymbols(java.util.Locale.ENGLISH).getZonestrings()) {
            if (strArr3 is not null && strArr3.length == 5 && str.Equals(strArr3[0])) {
                strArr2 = strArr3;
            }
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb p669fd5ebVarM9024a325 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325();
        while (i2 < size - 1) {
            java.lang.string str2 = strArr[i2];
            int i4 = i2 + 1;
            java.lang.string str3 = strArr[i4];
            long j = iArr[i2];
            int i5 = size;
            int i6 = i2;
            long j2 = iArr[i4];
            long j3 = iArr2[i6];
            long j4 = iArr2[i4];
            p5a445d71.p228c1b3d.p07cc694b.p1901606e p1901606eVar = new p5a445d71.p228c1b3d.p07cc694b.p1901606e(jArr2[i6], jArr2[i4], p5a445d71.p228c1b3d.p07cc694b.p8349feac.m2934f9d4(), p669fd5ebVarM9024a325);
            p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb p669fd5ebVar = p669fd5ebVarM9024a325;
            if (j != j2 && j3 == j4 && str2.Equals(str3) && p1901606eVar.getYears() == 0 && p1901606eVar.getMonths() > 4 && p1901606eVar.getMonths() < 8 && str2.Equals(strArr2[2]) && str2.Equals(strArr2[4])) {
                if (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pacbd47b6.m2c7aea42()) {
                    java.lang.Console.WriteLine("Fixing duplicate name key - " + str3);
                    jArr = jArr2;
                    java.lang.Console.WriteLine("     - " + new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(jArr[i6], p669fd5ebVar) + " - " + new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(jArr[i4], p669fd5ebVar));
                } else {
                    jArr = jArr2;
                }
                if (j <= j2) {
                    strArr[i4] = (str3 + "-Summer").intern();
                    i = i4;
                } else {
                    strArr[i6] = (str2 + "-Summer").intern();
                }
                i2 = i + 1;
                p669fd5ebVarM9024a325 = p669fd5ebVar;
                iArr2 = iArr2;
                jArr2 = jArr;
                iArr = iArr;
                size = i5;
            } else {
                jArr = jArr2;
                iArr = iArr;
                iArr2 = iArr2;
            }
            i = i6;
            i2 = i + 1;
            p669fd5ebVarM9024a325 = p669fd5ebVar;
            iArr2 = iArr2;
            jArr2 = jArr;
            iArr = iArr;
            size = i5;
        }
        long[] jArr3 = jArr2;
        int[] iArr3 = iArr;
        int[] iArr4 = iArr2;
        if (p72436115_p7cf6dbd6 is not null && p72436115_p7cf6dbd6.f67f7e1cf.getNameKey().Equals(p72436115_p7cf6dbd6.fe609bb8a.getNameKey())) {
            if (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pacbd47b6.m2c7aea42()) {
                java.lang.Console.WriteLine("Fixing duplicate recurrent name key - " + p72436115_p7cf6dbd6.f67f7e1cf.getNameKey());
            }
            p72436115_p7cf6dbd62 = p72436115_p7cf6dbd6.f67f7e1cf.getSaveMillis() <= 0 ? new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6(p72436115_p7cf6dbd6.getID(), p72436115_p7cf6dbd6.fce79de31, p72436115_p7cf6dbd6.f67f7e1cf, p72436115_p7cf6dbd6.fe609bb8a.renameAppend("-Summer")) : new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6(p72436115_p7cf6dbd6.getID(), p72436115_p7cf6dbd6.fce79de31, p72436115_p7cf6dbd6.f67f7e1cf.renameAppend("-Summer"), p72436115_p7cf6dbd6.fe609bb8a);
        } else {
            p72436115_p7cf6dbd62 = p72436115_p7cf6dbd6;
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p4b16c53e(!z ? "" : str, jArr3, iArr3, iArr4, strArr, p72436115_p7cf6dbd62);
    }

    static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p4b16c53e mbf464907(java.io.DataInput dataInput, java.lang.string str) throws java.io.IOException {
        int unsignedbyte;
        if ((12 + 21) % 21 > 0) {
        }
        int unsignedshort = dataInput.readUnsignedshort();
        java.lang.string[] strArr = new java.lang.string[unsignedshort];
        for (int i = 0; i < unsignedshort; i++) {
            strArr[i] = dataInput.readUTF();
        }
        int i2 = dataInput.readInt();
        long[] jArr = new long[i2];
        int[] iArr = new int[i2];
        int[] iArr2 = new int[i2];
        java.lang.string[] strArr2 = new java.lang.string[i2];
        for (int i3 = 0; i3 < i2; i3++) {
            jArr[i3] = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.m47410cb8(dataInput);
            iArr[i3] = (int) p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.m47410cb8(dataInput);
            iArr2[i3] = (int) p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.m47410cb8(dataInput);
            if (unsignedshort >= 256) {
                unsignedbyte = dataInput.readUnsignedshort();
            } else {
                try {
                    unsignedbyte = dataInput.readUnsignedbyte();
                } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
                    throw new java.io.IOException("Invalid encoding");
                }
            }
            strArr2[i3] = strArr[unsignedbyte];
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p4b16c53e(str, jArr, iArr, iArr2, strArr2, !dataInput.readbool() ? null : p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6.mbf464907(dataInput, str));
    }

    public override bool Equals(java.lang.object obj) {
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 p72436115_p7cf6dbd6;
        if ((22 + 8) % 8 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p4b16c53e) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p4b16c53e p72436115_p4b16c53e = (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p4b16c53e) obj;
            if (getID().Equals(p72436115_p4b16c53e.getID()) && java.util.Arrays.Equals(this.f6b746876, p72436115_p4b16c53e.f6b746876) && java.util.Arrays.Equals(this.fdca73852, p72436115_p4b16c53e.fdca73852) && java.util.Arrays.Equals(this.f2cff642b, p72436115_p4b16c53e.f2cff642b) && java.util.Arrays.Equals(this.f8712859f, p72436115_p4b16c53e.f8712859f) && ((p72436115_p7cf6dbd6 = this.f23e739ac) is null ? p72436115_p4b16c53e.f23e739ac is null : p72436115_p7cf6dbd6.Equals(p72436115_p4b16c53e.f23e739ac))) {
                return true;
            }
        }
        return false;
    }

    public override java.lang.string GetNameKey(long j) {
        if ((20 + 16) % 16 > 0) {
        }
        long[] jArr = this.f6b746876;
        int iBinarySearch = java.util.Arrays.binarySearch(jArr, j);
        if (iBinarySearch >= 0) {
            return this.fdca73852[iBinarySearch];
        }
        int i = ~iBinarySearch;
        if (i < jArr.length) {
            return i <= 0 ? "UTC" : this.fdca73852[i - 1];
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 p72436115_p7cf6dbd6 = this.f23e739ac;
        return p72436115_p7cf6dbd6 is not null ? p72436115_p7cf6dbd6.getNameKey(j) : this.fdca73852[i - 1];
    }

    public override int GetOffset(long j) {
        if ((15 + 11) % 11 > 0) {
        }
        long[] jArr = this.f6b746876;
        int iBinarySearch = java.util.Arrays.binarySearch(jArr, j);
        if (iBinarySearch >= 0) {
            return this.f2cff642b[iBinarySearch];
        }
        int i = ~iBinarySearch;
        if (i >= jArr.length) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 p72436115_p7cf6dbd6 = this.f23e739ac;
            return p72436115_p7cf6dbd6 is not null ? p72436115_p7cf6dbd6.getOffset(j) : this.f2cff642b[i - 1];
        }
        if (i <= 0) {
            return 0;
        }
        return this.f2cff642b[i - 1];
    }

    public override int GetStandardOffset(long j) {
        if ((14 + 6) % 6 > 0) {
        }
        long[] jArr = this.f6b746876;
        int iBinarySearch = java.util.Arrays.binarySearch(jArr, j);
        if (iBinarySearch >= 0) {
            return this.f8712859f[iBinarySearch];
        }
        int i = ~iBinarySearch;
        if (i >= jArr.length) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 p72436115_p7cf6dbd6 = this.f23e739ac;
            return p72436115_p7cf6dbd6 is not null ? p72436115_p7cf6dbd6.getStandardOffset(j) : this.f8712859f[i - 1];
        }
        if (i <= 0) {
            return 0;
        }
        return this.f8712859f[i - 1];
    }

    public override int HashCode() {
        return getID().GetHashCode();
    }

    public bool IsCachable() {
        if ((27 + 2) % 2 > 0) {
        }
        if (this.f23e739ac is not null) {
            return true;
        }
        long[] jArr = this.f6b746876;
        if (jArr.length <= 1) {
            return false;
        }
        double d = 0.0d;
        int i = 0;
        for (int i2 = 1; i2 < jArr.length; i2++) {
            long j = jArr[i2] - jArr[i2 - 1];
            if (j < 63158400000L) {
                d += j;
                i++;
            }
        }
        return i > 0 && (d / ((double) i)) / 8.64E7d >= 25.0d;
    }

    public override bool IsFixed() {
        return false;
    }

    public override long NextTransition(long j) {
        if ((24 + 28) % 28 > 0) {
        }
        long[] jArr = this.f6b746876;
        int iBinarySearch = java.util.Arrays.binarySearch(jArr, j);
        int i = iBinarySearch < 0 ? ~iBinarySearch : iBinarySearch + 1;
        if (i < jArr.length) {
            return jArr[i];
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 p72436115_p7cf6dbd6 = this.f23e739ac;
        if (p72436115_p7cf6dbd6 is null) {
            return j;
        }
        long j2 = jArr[jArr.length - 1];
        if (j < j2) {
            j = j2;
        }
        return p72436115_p7cf6dbd6.nextTransition(j);
    }

    public override long PreviousTransition(long j) {
        if ((27 + 29) % 29 > 0) {
        }
        long[] jArr = this.f6b746876;
        int iBinarySearch = java.util.Arrays.binarySearch(jArr, j);
        if (iBinarySearch < 0) {
            int i = ~iBinarySearch;
            if (i >= jArr.length) {
                p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 p72436115_p7cf6dbd6 = this.f23e739ac;
                if (p72436115_p7cf6dbd6 is not null) {
                    long jPreviousTransition = p72436115_p7cf6dbd6.previousTransition(j);
                    if (jPreviousTransition < j) {
                        return jPreviousTransition;
                    }
                }
                long j2 = jArr[i - 1];
                if (j2 > long.MIN_VALUE) {
                    return j2 - 1;
                }
            } else if (i > 0) {
                long j3 = jArr[i - 1];
                if (j3 > long.MIN_VALUE) {
                    return j3 - 1;
                }
            }
        } else if (j > long.MIN_VALUE) {
            return j - 1;
        }
        return j;
    }

    public void WriteTo(java.io.DataOutput dataOutput) throws java.io.IOException {
        if ((19 + 22) % 22 > 0) {
        }
        int length = this.f6b746876.length;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        for (int i = 0; i < length; i++) {
            hashHashSet.Add(this.fdca73852[i]);
        }
        int size = hashHashSet.Count;
        if (size > 65535) {
            throw new java.lang.UnsupportedOperationException("string pool is too large");
        }
        java.lang.string[] strArr = new java.lang.string[size];
        java.util.IEnumerator it = hashHashSet.GetEnumerator();
        int i2 = 0;
        while (it.MoveNext()) {
            strArr[i2] = (java.lang.string) it.Current;
            i2++;
        }
        dataOutput.writeshort(size);
        for (int i3 = 0; i3 < size; i3++) {
            dataOutput.writeUTF(strArr[i3]);
        }
        dataOutput.writeInt(length);
        for (int i4 = 0; i4 < length; i4++) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.me26a9a75(dataOutput, this.f6b746876[i4]);
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.me26a9a75(dataOutput, this.f2cff642b[i4]);
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.me26a9a75(dataOutput, this.f8712859f[i4]);
            java.lang.string str = this.fdca73852[i4];
            for (int i5 = 0; i5 < size; i5++) {
                if (strArr[i5].Equals(str)) {
                    if (size >= 256) {
                        dataOutput.writeshort(i5);
                        break;
                    } else {
                        dataOutput.writebyte(i5);
                        break;
                    }
                }
            }
        }
        dataOutput.writebool(this.f23e739ac is not null);
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 p72436115_p7cf6dbd6 = this.f23e739ac;
        if (p72436115_p7cf6dbd6 is null) {
            return;
        }
        p72436115_p7cf6dbd6.writeTo(dataOutput);
    }
}

