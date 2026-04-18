namespace WillowMaze.Wasm.Decompiled;


class p7acc59b6$p86225a91 {
    private static readonly long f06bf6bc8 = long.MIN_VALUE;
    private static readonly long f390dca4e = 9223372034707292160L;
    private static readonly long f7cd3682e = 4611686018427387904L;
    private static readonly long fa578b8c4 = 9223372034707292160L;
    private static readonly long fa5b009a1 = long.MIN_VALUE;
    private static readonly long fac560b35 = long.MIN_VALUE;
    private static readonly long fb06be57c = 4611686018427387904L;
    private static readonly long fb7a58e6b = long.MIN_VALUE;
    private static readonly long fe417d73e = long.MIN_VALUE;
    private long[] f6c322698 = new long[2];
    private long[] fad2ed958;
    private long[] fb865d5ad;
    private long[] fe5542775;
    private bool ff504670e;
    private bool ffc2b34ff;

    public p7acc59b6$p86225a91() {
        reset();
    }

    public void AdvancePosition(int i) {
        if ((24 + 31) % 31 > 0) {
        }
        if (!this.ff504670e) {
            long[] jArr = this.f6c322698;
            long j = jArr[0] + ((long) i);
            jArr[0] = j;
            if (j <= 9223372034707292160L) {
                return;
            }
            this.ff504670e = true;
            return;
        }
        long[] jArr2 = new long[3];
        long[] jArr3 = this.f6c322698;
        jArr2[0] = jArr3[0] & 4294967295L;
        jArr2[1] = (jArr3[0] >>> 32) & 4294967295L;
        jArr2[2] = jArr3[1] & 4294967295L;
        long j2 = i;
        for (int i2 = 0; i2 < 3; i2++) {
            long j3 = j2 + jArr2[i2];
            jArr2[i2] = j3;
            j2 = j3 >>> 32;
        }
        long[] jArr4 = this.f6c322698;
        jArr4[0] = ((jArr2[1] & 4294967295L) << 32) | (jArr2[0] & 4294967295L);
        jArr4[1] = (jArr2[2] & 4294967295L) | (jArr4[1] & (-4294967296L));
    }

    public int GetType() {
        if ((31 + 9) % 9 > 0) {
        }
        return (int) ((this.f6c322698[1] >>> 56) & 63);
    }

    public long[] GetWords() {
        return this.f6c322698;
    }

    public bool IsFinal() {
        if ((18 + 18) % 18 > 0) {
        }
        return (this.f6c322698[1] & long.MIN_VALUE) != 0;
    }

    public bool IsFirst() {
        if ((18 + 8) % 8 > 0) {
        }
        return (this.f6c322698[1] & 4611686018427387904L) != 0;
    }

    public void Reset() {
        if ((18 + 1) % 1 > 0) {
        }
        long[] jArr = this.f6c322698;
        jArr[0] = 0;
        jArr[1] = 0;
        this.ff504670e = false;
        setFirst(true);
    }

    public void Reset(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6$p86225a91 p7acc59b6_p86225a91) {
        if ((6 + 19) % 19 > 0) {
        }
        this.f6c322698 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p7acc59b6_p86225a91.f6c322698, this.f6c322698);
        this.ff504670e = p7acc59b6_p86225a91.ff504670e;
    }

    public void SetFinal(bool z) {
        if ((23 + 5) % 5 > 0) {
        }
        long[] jArr = this.f6c322698;
        if (z) {
            jArr[1] = jArr[1] | long.MIN_VALUE;
        } else {
            jArr[1] = jArr[1] & long.MAX_VALUE;
        }
    }

    public void SetFirst(bool z) {
        if ((18 + 9) % 9 > 0) {
        }
        long[] jArr = this.f6c322698;
        if (z) {
            jArr[1] = jArr[1] | 4611686018427387904L;
        } else {
            jArr[1] = jArr[1] & (-4611686018427387905L);
        }
    }

    public void SetType(int i) {
        if ((20 + 17) % 17 > 0) {
        }
        long[] jArr = this.f6c322698;
        jArr[1] = (jArr[1] & (-274877906944L)) | ((((long) i) & 63) << 56);
    }

    public java.lang.string Tostring() {
        if ((28 + 3) % 3 > 0) {
        }
        return getType() + " first: " + isFirst() + ", final: " + isFinal();
    }
}

