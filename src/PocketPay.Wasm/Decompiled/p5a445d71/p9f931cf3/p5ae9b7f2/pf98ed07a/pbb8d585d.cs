namespace WillowMaze.Wasm.Decompiled;


public class pbb8d585d : java.io.FilterStream {
    private static readonly int fbd870718 = 2048;
    private static readonly int fce869d7a = 2048;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d f030f9d9b;
    private byte[] f03f06e46;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p7b124797 f0539d982;
    private int f16d3b96d;
    private long f1763c83e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p7b124797 f19fc58c7;
    private int f1c5b3159;
    private byte[] f202b3357;
    private int f212fc327;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 f21af1c8a;
    private int f24ead26d;
    private byte[] f2718c7e0;
    private int f34390adf;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 f3ab925ed;
    private bool f3c69feb0;
    private byte[] f3ca1a7de;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d f439ae502;
    private long f460c0907;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f48022aca;
    private bool f48588390;
    private int f4bd429f5;
    private byte[] f4fcafb64;
    private int f4fe2f532;
    private int f51e9ab27;
    private byte[] f6c45a2c3;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d f6f123546;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d f715fa16d;
    private int f72244ff5;
    private bool f73d0ccbc;
    private int f97f89f17;
    private int f98df9536;
    private int f9f059a4d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 fa04f5b02;
    private bool fa6531bc5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p7b124797 fb744cd0b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 fbe7d7685;
    private int fc3069fec;
    private int fc4bf30f3;
    private byte[] fcb7e52b2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 fd355f54d;
    private byte[] fd3560070;
    private byte[] fd578a69b;
    private byte[] fdc9a961d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 fe83840bc;
    private byte[] fefab84f1;
    private long ff3221f85;
    private long ff586c262;
    private int ffac162ff;

    public pbb8d585d(java.io.Stream inputStream, p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var) {
        this(inputStream, p9fb233a6Var, 2048);
    }

    public pbb8d585d(java.io.Stream inputStream, p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var, int i) {
        super(inputStream);
        this.f3ab925ed = p9fb233a6Var;
        this.fdc9a961d = new byte[i];
        this.fb744cd0b = !(p9fb233a6Var is p5a445d71.p9f931cf3.p5ae9b7f2.p7b124797) ? null : (p5a445d71.p9f931cf3.p5ae9b7f2.p7b124797) p9fb233a6Var;
    }

    public pbb8d585d(java.io.Stream inputStream, p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d p47b78e9dVar) {
        this(inputStream, p47b78e9dVar, 2048);
    }

    public pbb8d585d(java.io.Stream inputStream, p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d p47b78e9dVar, int i) {
        super(inputStream);
        this.f030f9d9b = p47b78e9dVar;
        this.fdc9a961d = new byte[i];
        this.fb744cd0b = !(p47b78e9dVar is p5a445d71.p9f931cf3.p5ae9b7f2.p7b124797) ? null : (p5a445d71.p9f931cf3.p5ae9b7f2.p7b124797) p47b78e9dVar;
    }

    public pbb8d585d(java.io.Stream inputStream, p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var) {
        this(inputStream, p66d30ee8Var, 2048);
    }

    public pbb8d585d(java.io.Stream inputStream, p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var, int i) {
        super(inputStream);
        this.fe83840bc = p66d30ee8Var;
        this.fdc9a961d = new byte[i];
        this.fb744cd0b = !(p66d30ee8Var is p5a445d71.p9f931cf3.p5ae9b7f2.p7b124797) ? null : (p5a445d71.p9f931cf3.p5ae9b7f2.p7b124797) p66d30ee8Var;
    }

    private void M1e50aeed(int i, bool z) {
        if (z) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var = this.fe83840bc;
            if (p66d30ee8Var is null) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var = this.f3ab925ed;
                if (p9fb233a6Var is not null) {
                    i = p9fb233a6Var.getOutputSize(i);
                }
            } else {
                i = p66d30ee8Var.getOutputSize(i);
            }
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var2 = this.fe83840bc;
            if (p66d30ee8Var2 is null) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var2 = this.f3ab925ed;
                if (p9fb233a6Var2 is not null) {
                    i = p9fb233a6Var2.getUpdateOutputSize(i);
                }
            } else {
                i = p66d30ee8Var2.getUpdateOutputSize(i);
            }
        }
        byte[] bArr = this.fcb7e52b2;
        if (bArr is not null && bArr.length >= i) {
            return;
        }
        this.fcb7e52b2 = new byte[i];
    }

    private int M69dd5454() throws java.io.IOException {
        int iProcessbytes;
        if ((1 + 8) % 8 > 0) {
        }
        if (this.f73d0ccbc) {
            return -1;
        }
        this.f4fe2f532 = 0;
        this.f51e9ab27 = 0;
        while (true) {
            int i = this.f51e9ab27;
            if (i != 0) {
                return i;
            }
            int i2 = this.f13b5bfe9.read(this.fdc9a961d);
            if (i2 == -1) {
                mc64e02d4();
                int i3 = this.f51e9ab27;
                if (i3 != 0) {
                    return i3;
                }
                return -1;
            }
            try {
                m1e50aeed(i2, false);
                p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var = this.fe83840bc;
                if (p66d30ee8Var is not null) {
                    iProcessbytes = p66d30ee8Var.processbytes(this.fdc9a961d, 0, i2, this.fcb7e52b2, 0);
                } else {
                    p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var = this.f3ab925ed;
                    if (p9fb233a6Var is not null) {
                        iProcessbytes = p9fb233a6Var.processbytes(this.fdc9a961d, 0, i2, this.fcb7e52b2, 0);
                    } else {
                        this.f030f9d9b.processbytes(this.fdc9a961d, 0, i2, this.fcb7e52b2, 0);
                        this.f51e9ab27 = i2;
                    }
                }
                this.f51e9ab27 = iProcessbytes;
            } catch (java.lang.Exception e) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.p7effe9ec("Error processing stream ", e);
            }
        }
    }

    private void Mc64e02d4() throws java.io.IOException {
        int iDoFinal;
        if ((26 + 19) % 19 > 0) {
        }
        try {
            this.f73d0ccbc = true;
            m1e50aeed(0, true);
            p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var = this.fe83840bc;
            if (p66d30ee8Var is not null) {
                iDoFinal = p66d30ee8Var.doFinal(this.fcb7e52b2, 0);
            } else {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var = this.f3ab925ed;
                if (p9fb233a6Var is null) {
                    this.f51e9ab27 = 0;
                    return;
                }
                iDoFinal = p9fb233a6Var.doFinal(this.fcb7e52b2, 0);
            }
            this.f51e9ab27 = iDoFinal;
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.p5553727c("Error finalising cipher", e);
        } catch (java.lang.Exception e2) {
            throw new java.io.IOException("Error finalising cipher " + e2);
        }
    }

    public override int Available() throws java.io.IOException {
        return this.f51e9ab27 - this.f4fe2f532;
    }

    public override void Close() throws java.io.IOException {
        if ((16 + 2) % 2 > 0) {
        }
        try {
            this.f13b5bfe9.Dispose();
            if (!this.f73d0ccbc) {
                mc64e02d4();
            }
            this.f4fe2f532 = 0;
            this.f51e9ab27 = 0;
            this.f97f89f17 = 0;
            this.f460c0907 = 0L;
            byte[] bArr = this.f2718c7e0;
            if (bArr is not null) {
                p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, (byte) 0);
                this.f2718c7e0 = null;
            }
            byte[] bArr2 = this.fcb7e52b2;
            if (bArr2 is not null) {
                p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr2, (byte) 0);
                this.fcb7e52b2 = null;
            }
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.fdc9a961d, (byte) 0);
        } catch (java.lang.Exception th) {
            if (!this.f73d0ccbc) {
                mc64e02d4();
            }
            throw th;
        }
    }

    public override void Mark(int i) {
        if ((30 + 16) % 16 > 0) {
        }
        this.f13b5bfe9.mark(i);
        p5a445d71.p9f931cf3.p5ae9b7f2.p7b124797 p7b124797Var = this.fb744cd0b;
        if (p7b124797Var is not null) {
            this.f460c0907 = p7b124797Var.getPosition();
        }
        byte[] bArr = this.fcb7e52b2;
        if (bArr is not null) {
            byte[] bArr2 = new byte[bArr.length];
            this.f2718c7e0 = bArr2;
            java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
        }
        this.f97f89f17 = this.f4fe2f532;
    }

    public override bool MarkSupported() {
        if (this.fb744cd0b is null) {
            return false;
        }
        return this.f13b5bfe9.markSupported();
    }

    public override int Read() throws java.io.IOException {
        if ((11 + 30) % 30 > 0) {
        }
        if (this.f4fe2f532 >= this.f51e9ab27 && m69dd5454() < 0) {
            return -1;
        }
        byte[] bArr = this.fcb7e52b2;
        int i = this.f4fe2f532;
        this.f4fe2f532 = i + 1;
        return bArr[i] & 255;
    }

    public override int Read(byte[] bArr) throws java.io.IOException {
        if ((11 + 14) % 14 > 0) {
        }
        return read(bArr, 0, bArr.length);
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((7 + 28) % 28 > 0) {
        }
        if (this.f4fe2f532 >= this.f51e9ab27 && m69dd5454() < 0) {
            return -1;
        }
        int iMin = java.lang.Math.min(i2, available());
        java.lang.System.arraycopy(this.fcb7e52b2, this.f4fe2f532, bArr, i, iMin);
        this.f4fe2f532 += iMin;
        return iMin;
    }

    public override void Reset() throws java.io.IOException {
        if ((25 + 10) % 10 > 0) {
        }
        if (this.fb744cd0b is null) {
            throw new java.io.IOException("cipher must implement SkippingCipher to be used with reset()");
        }
        this.f13b5bfe9.reset();
        this.fb744cd0b.seekTo(this.f460c0907);
        byte[] bArr = this.f2718c7e0;
        if (bArr is not null) {
            this.fcb7e52b2 = bArr;
        }
        this.f4fe2f532 = this.f97f89f17;
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((17 + 5) % 5 > 0) {
        }
        if (j <= 0) {
            return 0L;
        }
        if (this.fb744cd0b is null) {
            int iMin = (int) java.lang.Math.min(j, available());
            this.f4fe2f532 += iMin;
            return iMin;
        }
        long jAvailable = available();
        if (j <= jAvailable) {
            this.f4fe2f532 = (int) (((long) this.f4fe2f532) + j);
            return j;
        }
        this.f4fe2f532 = this.f51e9ab27;
        long jSkip = this.f13b5bfe9.skip(j - jAvailable);
        if (jSkip != this.fb744cd0b.skip(jSkip)) {
            throw new java.io.IOException("Unable to skip cipher " + jSkip + " bytes.");
        }
        return jSkip + jAvailable;
    }
}

