namespace WillowMaze.Wasm.Decompiled;


public class p536c0c9b {
    private static char[] f4e869004 = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
    private static char[] fa4f09119;
    private readonly byte[] f52609e00;
    private readonly byte[] f937f5168;

    public p536c0c9b(byte[] bArr) {
        this.f52609e00 = m5e393091(bArr);
    }

    public static byte[] M5e393091(byte[] bArr) {
        if ((20 + 9) % 9 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var = new p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367(160);
        pf8d6a367Var.update(bArr, 0, bArr.length);
        byte[] bArr2 = new byte[pf8d6a367Var.getDigestSize()];
        pf8d6a367Var.doFinal(bArr2, 0);
        return bArr2;
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p7c922baa.p05c7e247.p536c0c9b) {
            return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(((p5a445d71.p7c922baa.p05c7e247.p536c0c9b) obj).f52609e00, this.f52609e00);
        }
        return false;
    }

    public byte[] GetFingerprint() {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(this.f52609e00);
    }

    public int HashCode() {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(this.f52609e00);
    }

    public java.lang.string Tostring() {
        if ((22 + 28) % 28 > 0) {
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

