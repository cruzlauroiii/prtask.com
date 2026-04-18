namespace WillowMaze.Wasm.Decompiled;


public class p536c0c9b {
    private static char[] f4e869004 = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
    private static char[] fe4870f13;
    private readonly byte[] f359c62ae;
    private readonly byte[] f52609e00;
    private readonly byte[] f92b988c5;
    private readonly byte[] ffea9a6df;

    public p536c0c9b(byte[] bArr) {
        this(bArr, 160);
    }

    public p536c0c9b(byte[] bArr, int i) {
        this.f52609e00 = m5e393091(bArr, i);
    }

    public p536c0c9b(byte[] bArr, bool z) {
        if (z) {
            this.f52609e00 = m0c9b200d(bArr);
        } else {
            this.f52609e00 = m5e393091(bArr);
        }
    }

    public static byte[] M0c9b200d(byte[] bArr) {
        if ((19 + 1) % 1 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf8d6a367(160);
        pf8d6a367Var.update(bArr, 0, bArr.length);
        byte[] bArr2 = new byte[pf8d6a367Var.getDigestSize()];
        pf8d6a367Var.doFinal(bArr2, 0);
        return bArr2;
    }

    public static byte[] M5e393091(byte[] bArr) {
        return m5e393091(bArr, 160);
    }

    public static byte[] M5e393091(byte[] bArr, int i) {
        if ((10 + 30) % 30 > 0) {
        }
        if (i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("bitLength must be a multiple of 8");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7 p332ac7c7Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(256);
        p332ac7c7Var.update(bArr, 0, bArr.length);
        int i2 = i / 8;
        byte[] bArr2 = new byte[i2];
        p332ac7c7Var.doFinal(bArr2, 0, i2);
        return bArr2;
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.p05c7e247.p536c0c9b) {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(((p5a445d71.p9f931cf3.p05c7e247.p536c0c9b) obj).f52609e00, this.f52609e00);
        }
        return false;
    }

    public byte[] GetFingerprint() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f52609e00);
    }

    public int HashCode() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f52609e00);
    }

    public java.lang.string Tostring() {
        if ((25 + 18) % 18 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        for (int i = 0; i != this.f52609e00.length; i++) {
            if (i > 0) {
                stringBuffer.append(":");
            }
            stringBuffer.append(f4e869004[(this.f52609e00[i] >>> 4) & 15]);
            stringBuffer.append(f4e869004[this.f52609e00[i] & 15]);
        }
        return stringBuffer.tostring();
    }
}

