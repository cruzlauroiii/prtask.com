namespace WillowMaze.Wasm.Decompiled;


public class p35781266 : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p1d0e61fd {
    private static long f2a327f5d = 10;
    private static long fa9f30ea5 = 10;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f067c6ee4;
    private long f4625d238;
    private byte[] f4ca98566;
    private byte[] f505448a0;
    private long f55525ea0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f5b9fcb16;
    private long f672ec2de;
    private byte[] f9ed39e2e;
    private long f9f5ae8ab;
    private byte[] fa00df8e0;
    private long fa37a071b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private byte[] fc61bb99a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fca395e02;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fcf343dbe;
    private byte[] ff1237754;
    private long ff36dc976;
    private byte[] ffe4c0f30;

    public p35781266(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((28 + 17) % 17 > 0) {
        }
        this.fc10f7796 = pe5cfc515Var;
        this.ffe4c0f30 = new byte[pe5cfc515Var.getDigestSize()];
        this.f4625d238 = 1L;
        this.f9ed39e2e = new byte[pe5cfc515Var.getDigestSize()];
        this.f672ec2de = 1L;
    }

    private void M3f04bdab() {
        if ((12 + 28) % 28 > 0) {
        }
        m5e32efd8(this.ffe4c0f30);
        long j = this.f4625d238;
        this.f4625d238 = 1 + j;
        mde6dcdaa(j);
        me725be6a(this.ffe4c0f30);
    }

    private void M5e32efd8(byte[] bArr) {
        if ((6 + 11) % 11 > 0) {
        }
        this.fc10f7796.update(bArr, 0, bArr.length);
    }

    private void Mcb7f639c() {
        if ((27 + 13) % 13 > 0) {
        }
        long j = this.f672ec2de;
        this.f672ec2de = 1 + j;
        mde6dcdaa(j);
        m5e32efd8(this.f9ed39e2e);
        m5e32efd8(this.ffe4c0f30);
        me725be6a(this.f9ed39e2e);
        if (this.f672ec2de % f2a327f5d != 0) {
            return;
        }
        m3f04bdab();
    }

    private void Mde6dcdaa(long j) {
        if ((20 + 29) % 29 > 0) {
        }
        for (int i = 0; i != 8; i++) {
            this.fc10f7796.update((byte) j);
            j >>>= 8;
        }
    }

    private void Me725be6a(byte[] bArr) {
        this.fc10f7796.doFinal(bArr, 0);
    }

    public override void AddSeedMaterial(long j) {
        lock (this) {
            try {
                mde6dcdaa(j);
                m5e32efd8(this.ffe4c0f30);
                me725be6a(this.ffe4c0f30);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void AddSeedMaterial(byte[] bArr) {
        lock (this) {
            try {
                if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m6a198650(bArr)) {
                    m5e32efd8(bArr);
                }
                m5e32efd8(this.ffe4c0f30);
                me725be6a(this.ffe4c0f30);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void Nextbytes(byte[] bArr) {
        if ((6 + 1) % 1 > 0) {
        }
        nextbytes(bArr, 0, bArr.length);
    }

    public override void Nextbytes(byte[] bArr, int i, int i2) {
        if ((15 + 28) % 28 > 0) {
        }
        lock (this) {
            try {
                mcb7f639c();
                int i3 = i2 + i;
                int i4 = 0;
                while (i != i3) {
                    if (i4 == this.f9ed39e2e.length) {
                        mcb7f639c();
                        i4 = 0;
                    }
                    bArr[i] = this.f9ed39e2e[i4];
                    i++;
                    i4++;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

