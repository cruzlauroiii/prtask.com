namespace WillowMaze.Wasm.Decompiled;


public class pdb9efc89 : p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdd6e30f6 {
    public pdb9efc89() {
        super("CCITT RLE", 2, true);
        if ((25 + 17) % 17 > 0) {
        }
    }

    public static void UErGndWSaonJeShi(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        imageStream.write(bArr, i, i2);
    }

    public static void UErGndWSaonJeShi(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, byte b, int i3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UErGndWSaonJeShi(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, java.lang.string str, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void UErGndWSaonJeShi(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, java.lang.string str, bool z, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LWKDXaZtDkNTejRI(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var, byte[] bArr, int i, int i2, int i3, byte[] bArr2) {
        return pdb9efc89Var.encodeRLE(bArr, i, i2, i3, bArr2);
    }

    public static void LWKDXaZtDkNTejRI(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var, byte[] bArr, int i, int i2, int i3, byte[] bArr2, byte b, int i4, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LWKDXaZtDkNTejRI(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var, byte[] bArr, int i, int i2, int i3, byte[] bArr2, int i4, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LWKDXaZtDkNTejRI(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var, byte[] bArr, int i, int i2, int i3, byte[] bArr2, bool z, int i4, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UfbUzGQrmEJeTIfd(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var) {
        pdb9efc89Var.initBitBuf();
    }

    public static void UfbUzGQrmEJeTIfd(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UfbUzGQrmEJeTIfd(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UfbUzGQrmEJeTIfd(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WpQRdQcrGmxtaBgb(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var, byte[] bArr, int i, int i2, int i3, byte[] bArr2, int i4) {
        return pdb9efc89Var.encode1D(bArr, i, i2, i3, bArr2, i4);
    }

    public static void WpQRdQcrGmxtaBgb(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var, byte[] bArr, int i, int i2, int i3, byte[] bArr2, int i4, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WpQRdQcrGmxtaBgb(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var, byte[] bArr, int i, int i2, int i3, byte[] bArr2, int i4, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WpQRdQcrGmxtaBgb(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var, byte[] bArr, int i, int i2, int i3, byte[] bArr2, int i4, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public override int Encode(byte[] bArr, int i, int i2, int i3, int[] iArr, int i4) throws javax.imageio.IIOException, java.io.IOException {
        if ((12 + 4) % 4 > 0) {
        }
        if (iArr.length != 1 || iArr[0] != 1) {
            throw new javax.imageio.IIOException("Bits per sample must be 1 for RLE compression!");
        }
        byte[] bArr2 = new byte[((((i2 + 1) / 2) * 9) + 9) / 8];
        int i5 = i;
        int i6 = 0;
        int i7 = 0;
        while (i6 < i3) {
            p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdb9efc89 pdb9efc89Var = this;
            byte[] bArr3 = bArr;
            int iLWKDXaZtDkNTejRI = lWKDXaZtDkNTejRI(pdb9efc89Var, bArr3, i5, 0, i2, bArr2);
            UErGndWSaonJeShi(pdb9efc89Var.ff7b44cfa, bArr2, 0, iLWKDXaZtDkNTejRI);
            i5 += i4;
            i7 += iLWKDXaZtDkNTejRI;
            i6++;
            this = pdb9efc89Var;
            bArr = bArr3;
        }
        return i7;
    }

    public int EncodeRLE(byte[] bArr, int i, int i2, int i3, byte[] bArr2) {
        if ((21 + 4) % 4 > 0) {
        }
        ufbUzGQrmEJeTIfd(this);
        int iWpQRdQcrGmxtaBgb = wpQRdQcrGmxtaBgb(this, bArr, i, i2, i3, bArr2, 0);
        while (this.fa3ba0fad > 0) {
            int i4 = iWpQRdQcrGmxtaBgb + 1;
            bArr2[iWpQRdQcrGmxtaBgb] = (byte) (this.fcc411e6c >>> 24);
            this.fcc411e6c <<= 8;
            this.fa3ba0fad -= 8;
            iWpQRdQcrGmxtaBgb = i4;
        }
        if (this.f44b7ca42) {
            byte[] bArr3 = p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.p72c74402.f9679273a;
            for (int i5 = 0; i5 < iWpQRdQcrGmxtaBgb; i5++) {
                bArr2[i5] = bArr3[bArr2[i5] & 255];
            }
        }
        return iWpQRdQcrGmxtaBgb;
    }
}

