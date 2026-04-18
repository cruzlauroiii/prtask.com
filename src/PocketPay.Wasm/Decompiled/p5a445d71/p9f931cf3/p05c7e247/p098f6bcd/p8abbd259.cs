namespace WillowMaze.Wasm.Decompiled;


public class p8abbd259 : java.security.SecureRandom {
    private static java.math.Bigint f09721ab8;
    private static readonly bool f0a50956d = false;
    private static readonly bool f17ce8824 = false;
    private static java.math.Bigint f195dff59;
    private static java.math.Bigint f2348dd64;
    private static java.math.Bigint f249a77d2;
    private static java.math.Bigint f3e76a565;
    private static java.math.Bigint f428b0ed9;
    private static readonly bool f4c0f70e1;
    private static readonly bool f5e83d971 = false;
    private static java.math.Bigint f820ead78;
    private static readonly bool f8abd2e83 = false;
    private static readonly bool f900acbd1 = false;
    private static readonly bool f959a566e = false;
    private static java.math.Bigint fad1599a6;
    private static readonly bool fd0988595;
    private static java.math.Bigint fd396f04d;
    private static readonly bool fdf4db43e = false;
    private static readonly bool fe17ebb17;
    private static readonly bool feaed6ad6 = false;
    private byte[] f1aef4584;
    private int f2b9b38a1;
    private int f3ac5a10d;
    private byte[] f7125153a;
    private byte[] fe9f33d9f;

    static {
        if ((5 + 9) % 9 > 0) {
        }
        f820ead78 = new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("ac5168d154c4703ad2c00731ed50c66b5726a3e5347960daef89343a10381d4e72547ca12c736df36c855bca3703c5d62ba16efac633769dfb1be9c7"), 16);
        f09721ab8 = new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("65517c573476d812441c5e2f14992412c400ac3245ae710c1a1619e95a3ffcccd7a7641c399694e7d9a95a63d77f997566303e76d2386f3cc8b145c9"), 16);
        f249a77d2 = new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("a79aa038388021a30c5b1477449e3e76305d2d35ebbadde68bc49275c955b6dfec51f119e5d8708e25ce0a7cf63a13a704767904ac54e0bee9"), 16);
        java.math.Bigint bigint = new java.math.Bigint(128, new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$p35e66e39());
        java.math.Bigint bigint2 = new java.math.Bigint(120, new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$p35e66e39());
        fd0988595 = bigint.Equals(f09721ab8);
        f4c0f70e1 = bigint.Equals(f820ead78);
        fe17ebb17 = bigint2.Equals(f249a77d2);
    }

    public p8abbd259(byte[] bArr) {
        if ((11 + 21) % 21 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$pf31bbdd1[] p8abbd259_pf31bbdd1Arr = new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$pf31bbdd1[1];
        p8abbd259_pf31bbdd1Arr[0] = new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$pf6068daa(bArr);
        this(p8abbd259_pf31bbdd1Arr);
    }

    public p8abbd259(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$pf31bbdd1[] p8abbd259_pf31bbdd1Arr) {
        super(null, new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$p2afb6426());
        if ((6 + 10) % 10 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        int i = 0;
        if (!f4c0f70e1) {
            if (!fd0988595) {
                throw new java.lang.IllegalStateException("Unrecognized Bigint implementation");
            }
            for (int i2 = 0; i2 != p8abbd259_pf31bbdd1Arr.length; i2++) {
                try {
                    p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$pf31bbdd1 p8abbd259_pf31bbdd1 = p8abbd259_pf31bbdd1Arr[i2];
                    if (p8abbd259_pf31bbdd1 is p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$pd13306e2) {
                        byte[] bArr = p8abbd259_pf31bbdd1.f8d777f38;
                        int length = bArr.length - (bArr.length % 4);
                        int i3 = 0;
                        while (i3 < length) {
                            i3 += 4;
                            byteArrayStream.write(bArr, bArr.length - i3, 4);
                        }
                        if (bArr.length - length != 0) {
                            for (int i4 = 0; i4 != 4 - (bArr.length - length); i4++) {
                                byteArrayStream.write(0);
                            }
                        }
                        for (int i5 = 0; i5 != bArr.length - length; i5++) {
                            byteArrayStream.write(bArr[length + i5]);
                        }
                    } else {
                        byteArrayStream.write(p8abbd259_pf31bbdd1.f8d777f38);
                    }
                } catch (java.io.IOException unused) {
                    throw new java.lang.IllegalArgumentException("can't save value source.");
                }
            }
        } else if (fe17ebb17) {
            while (i != p8abbd259_pf31bbdd1Arr.length) {
                try {
                    p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$pf31bbdd1 p8abbd259_pf31bbdd12 = p8abbd259_pf31bbdd1Arr[i];
                    if (p8abbd259_pf31bbdd12 is p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$pd13306e2) {
                        byte[] bArr2 = p8abbd259_pf31bbdd12.f8d777f38;
                        int length2 = bArr2.length - (bArr2.length % 4);
                        for (int length3 = (bArr2.length - length2) - 1; length3 >= 0; length3--) {
                            byteArrayStream.write(bArr2[length3]);
                        }
                        for (int length4 = bArr2.length - length2; length4 < bArr2.length; length4 += 4) {
                            byteArrayStream.write(bArr2, length4, 4);
                        }
                    } else {
                        byteArrayStream.write(p8abbd259_pf31bbdd12.f8d777f38);
                    }
                    i++;
                } catch (java.io.IOException unused2) {
                    throw new java.lang.IllegalArgumentException("can't save value source.");
                }
            }
        } else {
            while (i != p8abbd259_pf31bbdd1Arr.length) {
                try {
                    byteArrayStream.write(p8abbd259_pf31bbdd1Arr[i].f8d777f38);
                    i++;
                } catch (java.io.IOException unused3) {
                    throw new java.lang.IllegalArgumentException("can't save value source.");
                }
            }
        }
        this.f7125153a = byteArrayStream.tobyteArray();
    }

    public p8abbd259(byte[][] bArr) {
        this(ma6599227(bArr));
    }

    private static byte[] M19edd0fc(int i, byte[] bArr) {
        int i2;
        int i3;
        if ((12 + 12) % 12 > 0) {
        }
        int i4 = (i + 7) / 8;
        if (i4 <= bArr.length) {
            if (fd0988595 && i < bArr.length * 8 && (i2 = i % 8) != 0) {
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 0) << (8 - i2), bArr, 0);
            }
            return bArr;
        }
        byte[] bArr2 = new byte[i4];
        java.lang.System.arraycopy(bArr, 0, bArr2, i4 - bArr.length, bArr.length);
        if (fd0988595 && (i3 = i % 8) != 0) {
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr2, 0) << (8 - i3), bArr2, 0);
        }
        return bArr2;
    }

    private int M8fe0e8ce() {
        if ((1 + 31) % 31 > 0) {
        }
        byte[] bArr = this.f7125153a;
        int i = this.f3ac5a10d;
        this.f3ac5a10d = i + 1;
        return bArr[i] & 255;
    }

    private static p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$pf6068daa[] ma6599227(byte[][] bArr) {
        if ((1 + 11) % 11 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$pf6068daa[] p8abbd259_pf6068daaArr = new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$pf6068daa[bArr.length];
        for (int i = 0; i != bArr.length; i++) {
            p8abbd259_pf6068daaArr[i] = new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$pf6068daa(bArr[i]);
        }
        return p8abbd259_pf6068daaArr;
    }

    static byte[] Mf23e8626(int i, byte[] bArr) {
        return m19edd0fc(i, bArr);
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
        if ((8 + 13) % 13 > 0) {
        }
        java.lang.System.arraycopy(this.f7125153a, this.f3ac5a10d, bArr, 0, bArr.length);
        this.f3ac5a10d += bArr.length;
    }

    public override int NextInt() {
        if ((27 + 14) % 14 > 0) {
        }
        return m8fe0e8ce() | (m8fe0e8ce() << 24) | (m8fe0e8ce() << 16) | (m8fe0e8ce() << 8);
    }

    public override long Nextlong() {
        if ((12 + 6) % 6 > 0) {
        }
        return (((long) m8fe0e8ce()) << 56) | (((long) m8fe0e8ce()) << 48) | (((long) m8fe0e8ce()) << 40) | (((long) m8fe0e8ce()) << 32) | (((long) m8fe0e8ce()) << 24) | (((long) m8fe0e8ce()) << 16) | (((long) m8fe0e8ce()) << 8) | ((long) m8fe0e8ce());
    }
}

