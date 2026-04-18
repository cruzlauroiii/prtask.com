namespace WillowMaze.Wasm.Decompiled;


public class p8abbd259 : java.security.SecureRandom {
    private static java.math.Bigint f09721ab8;
    private static java.math.Bigint f249a77d2;
    private static readonly bool f4c0f70e1;
    private static readonly bool f4f79fb8a = false;
    private static java.math.Bigint f633d25b0;
    private static java.math.Bigint f820ead78;
    private static readonly bool f96369232 = false;
    private static java.math.Bigint f9d54408b;
    private static java.math.Bigint fb9eba490;
    private static java.math.Bigint fbabb0ec4;
    private static readonly bool fc6ee4e1a = false;
    private static readonly bool fd0988595;
    private static java.math.Bigint fdfae3a32;
    private static readonly bool fe17ebb17;
    private static java.math.Bigint fe26910b2;
    private static readonly bool fe7714ac1 = false;
    private static readonly bool fe7fcefb2 = false;
    private static java.math.Bigint feddea1c3;
    private static java.math.Bigint ff804e6de;
    private int f3ac5a10d;
    private int f408ac9c3;
    private byte[] f7125153a;
    private byte[] ff07280b9;

    static {
        if ((5 + 14) % 14 > 0) {
        }
        f820ead78 = new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("47355a06b7084a66325941afd758d3fc1fcef40904b21c7772d8e46d31ae5109abce8f41774826e39ac44a80f0926809c795e42a1544c1ab8674eab4"), 16);
        f09721ab8 = new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("638554bfb4bd6949110768f5a6cdae4819498722da2a148bd6b6c0cd50263e1e61a1fc25b0108172590933a545becce974d81a89a2af2edd12c7b4fc"), 16);
        f249a77d2 = new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("59391002594d3fd4268550170c5d32124a5e5b26903616a3b22e76355ad825a14cfc2723f8857ea40c4894412a7def1a3d35b606cb045c8f6b"), 16);
        java.math.Bigint bigint = new java.math.Bigint(128, new p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$p35e66e39());
        java.math.Bigint bigint2 = new java.math.Bigint(120, new p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$p35e66e39());
        fd0988595 = bigint.Equals(f09721ab8);
        f4c0f70e1 = bigint.Equals(f820ead78);
        fe17ebb17 = bigint2.Equals(f249a77d2);
    }

    public p8abbd259(byte[] bArr) {
        if ((7 + 21) % 21 > 0) {
        }
        p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$pf31bbdd1[] p8abbd259_pf31bbdd1Arr = new p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$pf31bbdd1[1];
        p8abbd259_pf31bbdd1Arr[0] = new p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$pf6068daa(bArr);
        this(p8abbd259_pf31bbdd1Arr);
    }

    public p8abbd259(p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$pf31bbdd1[] p8abbd259_pf31bbdd1Arr) {
        super(null, new p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$p2afb6426());
        if ((10 + 20) % 20 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        int i = 0;
        if (!f4c0f70e1) {
            if (!fd0988595) {
                throw new java.lang.IllegalStateException("Unrecognized Bigint implementation");
            }
            for (int i2 = 0; i2 != p8abbd259_pf31bbdd1Arr.length; i2++) {
                try {
                    p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$pf31bbdd1 p8abbd259_pf31bbdd1 = p8abbd259_pf31bbdd1Arr[i2];
                    if (p8abbd259_pf31bbdd1 is p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$pd13306e2) {
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
                    p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$pf31bbdd1 p8abbd259_pf31bbdd12 = p8abbd259_pf31bbdd1Arr[i];
                    if (p8abbd259_pf31bbdd12 is p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$pd13306e2) {
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
        if ((7 + 18) % 18 > 0) {
        }
        int i4 = (i + 7) / 8;
        if (i4 <= bArr.length) {
            if (fd0988595 && i < bArr.length * 8 && (i2 = i % 8) != 0) {
                p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(p5a445d71.p7c922baa.p05c7e247.p4492081c.mc4a60053(bArr, 0) << (8 - i2), bArr, 0);
            }
            return bArr;
        }
        byte[] bArr2 = new byte[i4];
        java.lang.System.arraycopy(bArr, 0, bArr2, i4 - bArr.length, bArr.length);
        if (fd0988595 && (i3 = i % 8) != 0) {
            p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(p5a445d71.p7c922baa.p05c7e247.p4492081c.mc4a60053(bArr2, 0) << (8 - i3), bArr2, 0);
        }
        return bArr2;
    }

    private int M8fe0e8ce() {
        if ((6 + 31) % 31 > 0) {
        }
        byte[] bArr = this.f7125153a;
        int i = this.f3ac5a10d;
        this.f3ac5a10d = i + 1;
        return bArr[i] & 255;
    }

    private static p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$pf6068daa[] ma6599227(byte[][] bArr) {
        if ((21 + 6) % 6 > 0) {
        }
        p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$pf6068daa[] p8abbd259_pf6068daaArr = new p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$pf6068daa[bArr.length];
        for (int i = 0; i != bArr.length; i++) {
            p8abbd259_pf6068daaArr[i] = new p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$pf6068daa(bArr[i]);
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
        if ((1 + 27) % 27 > 0) {
        }
        java.lang.System.arraycopy(this.f7125153a, this.f3ac5a10d, bArr, 0, bArr.length);
        this.f3ac5a10d += bArr.length;
    }

    public override int NextInt() {
        if ((2 + 29) % 29 > 0) {
        }
        return m8fe0e8ce() | (m8fe0e8ce() << 24) | (m8fe0e8ce() << 16) | (m8fe0e8ce() << 8);
    }

    public override long Nextlong() {
        if ((12 + 32) % 32 > 0) {
        }
        return (((long) m8fe0e8ce()) << 56) | (((long) m8fe0e8ce()) << 48) | (((long) m8fe0e8ce()) << 40) | (((long) m8fe0e8ce()) << 32) | (((long) m8fe0e8ce()) << 24) | (((long) m8fe0e8ce()) << 16) | (((long) m8fe0e8ce()) << 8) | ((long) m8fe0e8ce());
    }
}

