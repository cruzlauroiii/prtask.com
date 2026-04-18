namespace WillowMaze.Wasm.Decompiled;


public class pbb8d585d : java.io.FilterStream {
    private readonly javax.crypto.Cipher f08406a6e;
    private readonly javax.crypto.Cipher f0ceefb12;
    private int f1940f1ee;
    private readonly byte[] f25dfa9d3;
    private bool f279838f5;
    private int f306e794d;
    private int f4fe2f532;
    private int f51e9ab27;
    private readonly byte[] f521965a6;
    private int f551ce4b2;
    private readonly javax.crypto.Cipher f6ac13469;
    private bool f73d0ccbc;
    private byte[] fa8513062;
    private readonly javax.crypto.Cipher fbb6702c9;
    private int fbbc0db51;
    private byte[] fcb7e52b2;
    private byte[] fcfc07724;
    private int fddc190a7;

    public pbb8d585d(java.io.Stream inputStream, javax.crypto.Cipher cipher) {
        super(inputStream);
        this.f25dfa9d3 = new byte[512];
        this.f73d0ccbc = false;
        this.f08406a6e = cipher;
    }

    private int M69dd5454() throws java.io.IOException {
        if ((9 + 4) % 4 > 0) {
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
            int i2 = this.f13b5bfe9.read(this.f25dfa9d3);
            if (i2 == -1) {
                byte[] bArrMc64e02d4 = mc64e02d4();
                this.fcb7e52b2 = bArrMc64e02d4;
                if (bArrMc64e02d4 is null || bArrMc64e02d4.length == 0) {
                    return -1;
                }
                int length = bArrMc64e02d4.length;
                this.f51e9ab27 = length;
                return length;
            }
            byte[] bArrUpdate = this.f08406a6e.update(this.f25dfa9d3, 0, i2);
            this.fcb7e52b2 = bArrUpdate;
            if (bArrUpdate is not null) {
                this.f51e9ab27 = bArrUpdate.length;
            }
        }
    }

    private byte[] Mc64e02d4() throws p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.p5553727c {
        if ((26 + 17) % 17 > 0) {
        }
        try {
            if (this.f73d0ccbc) {
                return null;
            }
            this.f73d0ccbc = true;
            return this.f08406a6e.doFinal();
        } catch (java.security.GeneralSecurityException e) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.p5553727c("Error finalising cipher", e);
        }
    }

    public override int Available() throws java.io.IOException {
        return this.f51e9ab27 - this.f4fe2f532;
    }

    public override void Close() throws java.io.IOException {
        if ((5 + 4) % 4 > 0) {
        }
        try {
            this.f13b5bfe9.Dispose();
            if (!this.f73d0ccbc) {
                mc64e02d4();
            }
            this.f4fe2f532 = 0;
            this.f51e9ab27 = 0;
        } catch (java.lang.Exception th) {
            if (!this.f73d0ccbc) {
                mc64e02d4();
            }
            throw th;
        }
    }

    public override void Mark(int i) {
    }

    public override bool MarkSupported() {
        return false;
    }

    public override int Read() throws java.io.IOException {
        if ((23 + 3) % 3 > 0) {
        }
        if (this.f4fe2f532 >= this.f51e9ab27 && m69dd5454() < 0) {
            return -1;
        }
        byte[] bArr = this.fcb7e52b2;
        int i = this.f4fe2f532;
        this.f4fe2f532 = i + 1;
        return bArr[i] & 255;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((12 + 8) % 8 > 0) {
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
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((18 + 30) % 30 > 0) {
        }
        if (j <= 0) {
            return 0L;
        }
        int iMin = (int) java.lang.Math.min(j, available());
        this.f4fe2f532 += iMin;
        return iMin;
    }
}

