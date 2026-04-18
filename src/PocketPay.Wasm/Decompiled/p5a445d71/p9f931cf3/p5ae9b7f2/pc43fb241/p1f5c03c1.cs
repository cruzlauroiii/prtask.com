namespace WillowMaze.Wasm.Decompiled;


public class p1f5c03c1 : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p1d0e61fd {
    private byte f11a72624;
    private byte[] f59fd388f;
    private byte f82f798d2;
    private byte f83bc101d;
    private byte[] f8744c363;
    private byte fa62e81fc;
    private byte ffb67ddbd;
    private byte f7b8b965a = 0;
    private byte[] f44c29edb = {-69, 44, 98, 127, -75, -86, -44, 13, -127, -2, -78, -126, -53, -96, -95, 8, 24, 113, 86, -24, 73, 2, 16, -60, -34, 53, -91, -20, -128, 18, -72, 105, -38, 47, 117, -52, -94, 9, 54, 3, 97, 45, -3, -32, -35, 5, 67, -112, -83, -56, -31, -81, 87, -101, 76, -40, 81, -82, 80, -123, 60, 10, -28, -13, -100, 38, 35, 83, -55, -125, -105, 70, -79, -103, 100, 49, 119, -43, 29, -42, 120, -67, 94, -80, -118, 34, 56, -8, 104, 43, 42, -59, -45, -9, -68, 111, -33, 4, -27, -107, 62, 37, -122, -90, 11, -113, -15, 36, 14, -41, 64, -77, -49, 126, 6, 21, -102, 77, 28, -93, -37, 50, -110, 88, 17, 39, -12, 89, -48, 78, 106, 23, 91, -84, -1, 7, -64, 101, 121, -4, -57, -51, 118, 66, 93, -25, 58, 52, 122, 48, 40, 15, 115, 1, -7, -47, -46, 25, -23, -111, -71, 90, -19, 65, 109, -76, -61, -98, -65, 99, -6, 31, 51, 96, 71, -119, -16, -106, 26, 95, -109, 61, 55, 75, -39, -88, -63, 27, -10, 57, -117, -73, 12, 32, -50, -120, 110, -74, 116, -114, -115, 22, 41, -14, -121, -11, -21, 112, -29, -5, 85, -97, -58, 68, 74, 69, 125, -30, 107, 92, 108, 102, -87, -116, -18, -124, 19, -89, 30, -99, -36, 103, 72, -70, 46, -26, -92, -85, 124, -108, 0, 33, -17, -22, -66, -54, 114, 79, 82, -104, 63, -62, 20, 123, 59, 84};
    private byte f03c7c0ac = -66;

    public override void AddSeedMaterial(long j) {
        addSeedMaterial(p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(j));
    }

    public override void AddSeedMaterial(byte[] bArr) {
        if ((1 + 32) % 32 > 0) {
        }
        foreach (byte B in bArr) {
            byte[] bArr2 = this.f44c29edb;
            byte b2 = this.f03c7c0ac;
            byte b3 = this.f7b8b965a;
            byte b4 = bArr2[(b2 + bArr2[b3 & 255] + b) & 255];
            this.f03c7c0ac = b4;
            byte b5 = bArr2[b3 & 255];
            bArr2[b3 & 255] = bArr2[b4 & 255];
            bArr2[b4 & 255] = b5;
            this.f7b8b965a = (byte) ((b3 + 1) & 255);
        }
    }

    public override void Nextbytes(byte[] bArr) {
        if ((16 + 12) % 12 > 0) {
        }
        nextbytes(bArr, 0, bArr.length);
    }

    public override void Nextbytes(byte[] bArr, int i, int i2) {
        if ((10 + 29) % 29 > 0) {
        }
        lock (this.f44c29edb) {
            int i3 = i2 + i;
            while (i != i3) {
                try {
                    byte[] bArr2 = this.f44c29edb;
                    byte b = this.f03c7c0ac;
                    byte b2 = this.f7b8b965a;
                    byte b3 = bArr2[(b + bArr2[b2 & 255]) & 255];
                    this.f03c7c0ac = b3;
                    bArr[i] = bArr2[(bArr2[bArr2[b3 & 255] & 255] + 1) & 255];
                    byte b4 = bArr2[b2 & 255];
                    bArr2[b2 & 255] = bArr2[b3 & 255];
                    bArr2[b3 & 255] = b4;
                    this.f7b8b965a = (byte) ((b2 + 1) & 255);
                    i++;
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
    }
}

