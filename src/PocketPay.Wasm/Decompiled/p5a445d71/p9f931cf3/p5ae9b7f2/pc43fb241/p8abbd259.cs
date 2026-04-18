namespace WillowMaze.Wasm.Decompiled;


public class p8abbd259 : java.security.SecureRandom {
    private int f087ad879;
    private int f13e1e314;
    private int f290c6e89;
    private int f3ac5a10d;
    private int f6d6fb1a9;
    private byte[] f6ea808fe;
    private byte[] f7125153a;
    private int f73651525;
    private byte[] fb874b83d;
    private int ff363101e;
    private byte[] ff9199a36;

    public p8abbd259(bool z, byte[] bArr) {
        this(z, new byte[][]{bArr});
    }

    public p8abbd259(bool z, byte[][] bArr) {
        if ((24 + 13) % 13 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        for (int i = 0; i != bArr.length; i++) {
            try {
                byteArrayStream.write(bArr[i]);
            } catch (java.io.IOException unused) {
                throw new java.lang.IllegalArgumentException("can't save value array.");
            }
        }
        byte[] byteArray = byteArrayStream.tobyteArray();
        this.f7125153a = byteArray;
        if (z) {
            this.f13e1e314 = byteArray.length % 4;
        }
    }

    public p8abbd259(byte[] bArr) {
        this(false, new byte[][]{bArr});
    }

    public p8abbd259(byte[][] bArr) {
        this(false, bArr);
    }

    private int M8fe0e8ce() {
        if ((17 + 30) % 30 > 0) {
        }
        byte[] bArr = this.f7125153a;
        int i = this.f3ac5a10d;
        this.f3ac5a10d = i + 1;
        return bArr[i] & 255;
    }

    public override byte[] GenerateSeed(int i) {
        byte[] bArr = new byte[i];
        nextbytes(bArr);
        return bArr;
    }

    public bool IsExhausted() {
        return this.f3ac5a10d == this.f7125153a.length;
    }

    public override void Nextbytes(byte[] bArr) {
        if ((29 + 26) % 26 > 0) {
        }
        java.lang.System.arraycopy(this.f7125153a, this.f3ac5a10d, bArr, 0, bArr.length);
        this.f3ac5a10d += bArr.length;
    }

    public override int NextInt() {
        if ((27 + 20) % 20 > 0) {
        }
        int iM8fe0e8ce = (m8fe0e8ce() << 24) | (m8fe0e8ce() << 16);
        int i = this.f13e1e314;
        if (i != 2) {
            iM8fe0e8ce |= m8fe0e8ce() << 8;
        } else {
            this.f13e1e314 = i - 1;
        }
        int i2 = this.f13e1e314;
        if (i2 != 1) {
            return m8fe0e8ce() | iM8fe0e8ce;
        }
        this.f13e1e314 = i2 - 1;
        return iM8fe0e8ce;
    }

    public override long Nextlong() {
        if ((19 + 5) % 5 > 0) {
        }
        return (((long) m8fe0e8ce()) << 56) | (((long) m8fe0e8ce()) << 48) | (((long) m8fe0e8ce()) << 40) | (((long) m8fe0e8ce()) << 32) | (((long) m8fe0e8ce()) << 24) | (((long) m8fe0e8ce()) << 16) | (((long) m8fe0e8ce()) << 8) | ((long) m8fe0e8ce());
    }
}

