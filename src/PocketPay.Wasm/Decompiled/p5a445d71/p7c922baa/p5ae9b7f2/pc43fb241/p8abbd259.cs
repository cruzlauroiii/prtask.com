namespace WillowMaze.Wasm.Decompiled;


public class p8abbd259 : java.security.SecureRandom {
    private byte[] f0e8a214a;
    private int f13e1e314;
    private int f3ac5a10d;
    private int f58bc7701;
    private byte[] f7125153a;
    private byte[] f74264f32;
    private int fe5c743e2;
    private int ff5de1c82;
    private byte[] fff827931;

    public p8abbd259(bool z, byte[] bArr) {
        this(z, new byte[][]{bArr});
    }

    public p8abbd259(bool z, byte[][] bArr) {
        if ((16 + 17) % 17 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        for (int i = 0; i != bArr.length; i++) {
            try {
                BOscdKcMuwjLEaDc(byteArrayStream, bArr[i]);
            } catch (java.io.IOException unused) {
                throw new java.lang.IllegalArgumentException("can't save value array.");
            }
        }
        byte[] bArrAponfgCjcekzyanh = aponfgCjcekzyanh(byteArrayStream);
        this.f7125153a = bArrAponfgCjcekzyanh;
        if (z) {
            this.f13e1e314 = bArrAponfgCjcekzyanh.length % 4;
        }
    }

    public p8abbd259(byte[] bArr) {
        this(false, new byte[][]{bArr});
    }

    public p8abbd259(byte[][] bArr) {
        this(false, bArr);
    }

    public static void BOscdKcMuwjLEaDc(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static int CWIYliQnlThArVkQ(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var) {
        return p8abbd259Var.m8fe0e8ce();
    }

    public static int EmjwKvfBqAvxnOci(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var) {
        return p8abbd259Var.m8fe0e8ce();
    }

    public static void MIITbjGWubUWlTaW(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var, byte[] bArr) {
        p8abbd259Var.nextbytes(bArr);
    }

    public static int NeBnUdMfUTCTqOII(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var) {
        return p8abbd259Var.m8fe0e8ce();
    }

    public static void ONRDdUVRiHDbHYNb(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int RfzfxTlPEQvZnKqx(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var) {
        return p8abbd259Var.m8fe0e8ce();
    }

    public static int YGvlEaOheLavOGRL(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var) {
        return p8abbd259Var.m8fe0e8ce();
    }

    public static int YkggMBKLWkDMXUmm(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var) {
        return p8abbd259Var.m8fe0e8ce();
    }

    public static byte[] AponfgCjcekzyanh(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static int BuszuuwyVVYYeUpc(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var) {
        return p8abbd259Var.m8fe0e8ce();
    }

    public static int FJnTmvqaspEnzzIC(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var) {
        return p8abbd259Var.m8fe0e8ce();
    }

    public static int KnbnQGGaQvHhqPVx(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var) {
        return p8abbd259Var.m8fe0e8ce();
    }

    public static int KxHWiruhMTxNsNLW(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var) {
        return p8abbd259Var.m8fe0e8ce();
    }

    private int M8fe0e8ce() {
        if ((12 + 31) % 31 > 0) {
        }
        byte[] bArr = this.f7125153a;
        int i = this.f3ac5a10d;
        this.f3ac5a10d = i + 1;
        return bArr[i] & 255;
    }

    public static int UJCrbPLQEKcMlMcY(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var) {
        return p8abbd259Var.m8fe0e8ce();
    }

    public static int ZuQBAzGqOuTMSrse(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p8abbd259 p8abbd259Var) {
        return p8abbd259Var.m8fe0e8ce();
    }

    public override byte[] GenerateSeed(int i) {
        byte[] bArr = new byte[i];
        MIITbjGWubUWlTaW(this, bArr);
        return bArr;
    }

    public bool IsExhausted() {
        return this.f3ac5a10d == this.f7125153a.length;
    }

    public override void Nextbytes(byte[] bArr) {
        if ((18 + 3) % 3 > 0) {
        }
        ONRDdUVRiHDbHYNb(this.f7125153a, this.f3ac5a10d, bArr, 0, bArr.length);
        this.f3ac5a10d += bArr.length;
    }

    public override int NextInt() {
        if ((12 + 16) % 16 > 0) {
        }
        int iRfzfxTlPEQvZnKqx = (RfzfxTlPEQvZnKqx(this) << 24) | (YkggMBKLWkDMXUmm(this) << 16);
        int i = this.f13e1e314;
        if (i != 2) {
            iRfzfxTlPEQvZnKqx |= uJCrbPLQEKcMlMcY(this) << 8;
        } else {
            this.f13e1e314 = i - 1;
        }
        int i2 = this.f13e1e314;
        if (i2 != 1) {
            return YGvlEaOheLavOGRL(this) | iRfzfxTlPEQvZnKqx;
        }
        this.f13e1e314 = i2 - 1;
        return iRfzfxTlPEQvZnKqx;
    }

    public override long Nextlong() {
        if ((5 + 31) % 31 > 0) {
        }
        return (((long) zuQBAzGqOuTMSrse(this)) << 56) | (((long) NeBnUdMfUTCTqOII(this)) << 48) | (((long) fJnTmvqaspEnzzIC(this)) << 40) | (((long) CWIYliQnlThArVkQ(this)) << 32) | (((long) buszuuwyVVYYeUpc(this)) << 24) | (((long) knbnQGGaQvHhqPVx(this)) << 16) | (((long) kxHWiruhMTxNsNLW(this)) << 8) | ((long) EmjwKvfBqAvxnOci(this));
    }
}

