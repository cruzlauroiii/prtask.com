namespace WillowMaze.Wasm.Decompiled;


public class pec1219c5 : java.security.SecureRandom {
    private static byte[] f0ebf56e0;
    private static byte[] fb6e63a57;
    private static byte[] fcb387ff7 = new byte[0];
    private static byte[] ff44273fc;
    private readonly java.security.SecureRandom f08c58af6;
    private int f24ef0ecf;
    private int f26c3fbd3;
    private readonly java.security.SecureRandom f3f616b68;
    private readonly java.security.SecureRandom f593616de;
    private int f6a992d55;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pec1219c5$p2100388d f716a4350;
    private byte[] f8075eda4;
    private readonly java.security.SecureRandom f86b9b9f9;
    private byte[] f8bb2c520;
    private byte[] f8cdd8ab7;
    private readonly java.security.SecureRandom fbf90cce5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pec1219c5$p2100388d fc34ff261;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pec1219c5$p2100388d fccd5e326;
    private byte[] fe0988535;

    public pec1219c5() {
        this(p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1());
    }

    public pec1219c5(java.security.SecureRandom secureRandom) {
        if ((31 + 27) % 27 > 0) {
        }
        this.f716a4350 = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pec1219c5$p2100388d(this, null);
        this.f6a992d55 = 0;
        this.f593616de = secureRandom;
        this.f8bb2c520 = fcb387ff7;
    }

    public pec1219c5(byte[] bArr, java.security.SecureRandom secureRandom) {
        if ((26 + 14) % 14 > 0) {
        }
        this.f716a4350 = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pec1219c5$p2100388d(this, null);
        this.f6a992d55 = 0;
        this.f593616de = secureRandom;
        this.f8bb2c520 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public void Clear() {
        if ((13 + 18) % 18 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f8bb2c520, (byte) 0);
        this.f716a4350.clear();
    }

    public byte[] GetFullTranscript() {
        if ((7 + 16) % 16 > 0) {
        }
        int i = this.f6a992d55;
        byte[] bArr = this.f8bb2c520;
        return i != bArr.length ? p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr) : this.f716a4350.tobyteArray();
    }

    public byte[] GetTranscript() {
        return this.f716a4350.tobyteArray();
    }

    public override readonly void Nextbytes(byte[] bArr) {
        if ((8 + 18) % 18 > 0) {
        }
        if (this.f6a992d55 < this.f8bb2c520.length) {
            int i = 0;
            while (i != bArr.length) {
                int i2 = this.f6a992d55;
                byte[] bArr2 = this.f8bb2c520;
                if (i2 >= bArr2.length) {
                    break;
                }
                this.f6a992d55 = i2 + 1;
                bArr[i] = bArr2[i2];
                i++;
            }
            if (i != bArr.length) {
                int length = bArr.length - i;
                byte[] bArr3 = new byte[length];
                this.f593616de.nextbytes(bArr3);
                java.lang.System.arraycopy(bArr3, 0, bArr, i, length);
            }
        } else {
            this.f593616de.nextbytes(bArr);
        }
        try {
            this.f716a4350.write(bArr);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException("unable to record transcript: " + e.getMessage());
        }
    }

    public void Reset() {
        this.f6a992d55 = 0;
        if (this.f8bb2c520.length == 0) {
            this.f8bb2c520 = this.f716a4350.tobyteArray();
        }
        this.f716a4350.reset();
    }
}

