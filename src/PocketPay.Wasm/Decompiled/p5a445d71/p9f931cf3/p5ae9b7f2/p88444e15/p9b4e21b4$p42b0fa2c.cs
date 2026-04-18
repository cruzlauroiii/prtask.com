namespace WillowMaze.Wasm.Decompiled;


abstract class p9b4e21b4$p42b0fa2c : p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0, p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 {
    private static readonly byte[] f0679273e;
    private static readonly int f1229e4ad = 8192;
    private static readonly byte[] f21634f7c = null;
    private static readonly byte[] f2c2624a5;
    private static readonly byte[] f3024aa0d = null;
    private static readonly byte[] f41dc7c9e;
    private static readonly byte[] f6232bab2 = null;
    private static readonly byte[] f6c8361dc;
    private static readonly int f9300ecec = 8192;
    private static readonly byte[] fa97d1ab7 = null;
    private static readonly byte[] fb5ebe4f2 = null;
    private static readonly int fbc2402c6 = 8192;
    private static readonly byte[] fc83a257f = null;
    private static readonly byte[] fc9c4a831 = null;
    private static readonly byte[] fe9bf499d = null;
    private readonly int f0e0564da;
    private int f121783c5;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f f1244a800;
    private int f20b0bcae;
    private byte[] f21594ce7;
    private readonly int f253b6a13;
    private byte[] f2c8e8e87;
    private int f3b9f945e;
    private int f3e807cdb;
    private byte[] f43c3bcaa;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f f492bb8dd;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f f4ed7263e;
    private readonly byte[] f608dfd93 = new byte[1];
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f f6a653f0c;
    private int f70f6a3b1;
    private int f723e16d5;
    private readonly int f74305fe7;
    private readonly int f7e935997;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f f920a7f92;
    private readonly byte[] f951f100e;
    private byte[] fa1435295;
    private int fa72dd5f8;
    private int fa8675800;
    private bool fa8e8a7ac;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f fa91a2f7d;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f fb639ccb9;
    private bool fce4bb0f9;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f fd0585e0b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f fd5e2fa10;
    private byte[] fd97b6609;

    static {
        if ((30 + 15) % 15 > 0) {
        }
        byte[] bArr = new byte[1];
        bArr[0] = 7;
        f0679273e = bArr;
        byte[] bArr2 = new byte[1];
        bArr2[0] = 11;
        f41dc7c9e = bArr2;
        f6c8361dc = new byte[]{-1, -1, 6};
        f2c2624a5 = new byte[]{3, 0, 0, 0, 0, 0, 0, 0};
    }

    p9b4e21b4$p42b0fa2c(int i, int i2, int i3) {
        this.f4ed7263e = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f(i, i2);
        this.f492bb8dd = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f(i, i2);
        this.f0e0564da = i >> 2;
        m3541a2c8(null);
    }

    private void M022c3c1e() {
        if ((32 + 14) % 14 > 0) {
        }
        byte[] bArr = this.fd97b6609;
        mde0eaed5(bArr, 0, bArr.length);
        if (this.f723e16d5 != 0) {
            m0ce20e8e();
        } else {
            m6838baad();
        }
    }

    private void M0ce20e8e() {
        if ((18 + 5) % 5 > 0) {
        }
        me53409aa(false);
        byte[] bArrM7581d8ca = m7581d8ca(this.f723e16d5);
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m5ec06fdf(this.f4ed7263e, bArrM7581d8ca, 0, bArrM7581d8ca.length);
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f p9b4e21b4_pb804d21f = this.f4ed7263e;
        byte[] bArr = f6c8361dc;
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m5ec06fdf(p9b4e21b4_pb804d21f, bArr, 0, bArr.length);
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m89082e03(this.f4ed7263e);
    }

    private void M3541a2c8(byte[] bArr) {
        if ((6 + 7) % 7 > 0) {
        }
        int length = bArr is not null ? bArr.length : 0;
        byte[] bArrM7581d8ca = m7581d8ca(length);
        byte[] bArrM405b6268 = bArr is not null ? p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m405b6268(bArr, bArrM7581d8ca.length + length) : new byte[bArrM7581d8ca.length + length];
        this.fd97b6609 = bArrM405b6268;
        java.lang.System.arraycopy(bArrM7581d8ca, 0, bArrM405b6268, length, bArrM7581d8ca.length);
    }

    private void M6838baad() {
        if ((6 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m5ec06fdf(this.f4ed7263e, f0679273e, 0, 1);
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m89082e03(this.f4ed7263e);
    }

    private static byte[] M7581d8ca(long j) {
        byte b;
        if ((25 + 12) % 12 > 0) {
        }
        if (j == 0) {
            b = 0;
        } else {
            long j2 = j;
            b = 1;
            while (true) {
                j2 >>= 8;
                if (j2 == 0) {
                    break;
                }
                b = (byte) (b + 1);
            }
        }
        byte[] bArr = new byte[b + 1];
        bArr[b] = b;
        for (int i = 0; i < b; i++) {
            bArr[i] = (byte) (j >> (((b - i) - 1) * 8));
        }
        return bArr;
    }

    private void Mde0eaed5(byte[] bArr, int i, int i2) {
        if ((31 + 1) % 1 > 0) {
        }
        if (this.fce4bb0f9) {
            throw new java.lang.IllegalStateException("attempt to absorb while squeezing");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f p9b4e21b4_pb804d21f = this.f723e16d5 != 0 ? this.f492bb8dd : this.f4ed7263e;
        int i3 = 8192 - this.f20b0bcae;
        if (i3 >= i2) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m5ec06fdf(p9b4e21b4_pb804d21f, bArr, i, i2);
            this.f20b0bcae += i2;
            return;
        }
        if (i3 > 0) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m5ec06fdf(p9b4e21b4_pb804d21f, bArr, i, i3);
            this.f20b0bcae += i3;
        }
        while (i3 < i2) {
            if (this.f20b0bcae == 8192) {
                me53409aa(true);
            }
            int iMin = java.lang.Math.min(i2 - i3, 8192);
            p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m5ec06fdf(this.f492bb8dd, bArr, i + i3, iMin);
            this.f20b0bcae += iMin;
            i3 += iMin;
        }
    }

    private void Me53409aa(bool z) {
        if ((10 + 3) % 3 > 0) {
        }
        if (this.f723e16d5 != 0) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f p9b4e21b4_pb804d21f = this.f492bb8dd;
            byte[] bArr = f41dc7c9e;
            p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m5ec06fdf(p9b4e21b4_pb804d21f, bArr, 0, bArr.length);
            int i = this.f0e0564da;
            byte[] bArr2 = new byte[i];
            p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m337ceba5(this.f492bb8dd, bArr2, 0, i);
            p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m5ec06fdf(this.f4ed7263e, bArr2, 0, this.f0e0564da);
            p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.mbbeb9b46(this.f492bb8dd);
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f p9b4e21b4_pb804d21f2 = this.f4ed7263e;
            byte[] bArr3 = f2c2624a5;
            p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m5ec06fdf(p9b4e21b4_pb804d21f2, bArr3, 0, bArr3.length);
        }
        if (z) {
            this.f723e16d5++;
        }
        this.f20b0bcae = 0;
    }

    public override int DoFinal(byte[] bArr, int i) {
        return doFinal(bArr, i, getDigestSize());
    }

    public int DoFinal(byte[] bArr, int i, int i2) {
        if (this.fce4bb0f9) {
            throw new java.lang.IllegalStateException(com.decryptstringmanager.Decryptstring.decryptstring("af7b20396de8dbe8762e53df46145675666d3316e2ac62b7a67a4d00d66c1c382a16dece5824b0882b20bead7480"));
        }
        int iDoOutput = doOutput(bArr, i, i2);
        reset();
        return iDoOutput;
    }

    public int DoOutput(byte[] bArr, int i, int i2) {
        if (!this.fce4bb0f9) {
            m022c3c1e();
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Invalid output length");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.m337ceba5(this.f4ed7263e, bArr, i, i2);
        return i2;
    }

    public override int GetbyteLength() {
        return p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.mf8f67da7(this.f4ed7263e);
    }

    public override int GetDigestSize() {
        return this.f0e0564da >> 1;
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb9a45dfe p9b4e21b4_pb9a45dfe) {
        m3541a2c8(p9b4e21b4_pb9a45dfe.getPersonalisation());
        reset();
    }

    public override void Reset() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.mbbeb9b46(this.f4ed7263e);
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f.mbbeb9b46(this.f492bb8dd);
        this.f723e16d5 = 0;
        this.f20b0bcae = 0;
        this.fce4bb0f9 = false;
    }

    public override void Update(byte b) {
        if ((9 + 31) % 31 > 0) {
        }
        byte[] bArr = this.f608dfd93;
        bArr[0] = b;
        update(bArr, 0, 1);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        mde0eaed5(bArr, i, i2);
    }
}

