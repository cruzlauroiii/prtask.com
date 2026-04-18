namespace WillowMaze.Wasm.Decompiled;


public class pa4e7e45a : p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 {
    public static readonly int f31ca6c79 = 65535;
    private static readonly int f4582481e = 32;
    public static readonly int f5c7a5317 = 65535;
    private static readonly long f71af6dbc = 4294967296L;
    public static readonly int f7282a2c7 = 65535;
    private static readonly int f74481af7 = 32;
    private static readonly long fb9c54880 = 4294967296L;
    private static readonly long fd86bfc42 = 4294967296L;
    private static readonly long ff76b576d = 4294967296L;
    public static readonly int ff859b706 = 65535;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p97fb89a8 f0800fc57;
    private int f0ce597be;
    private int f0e7785c4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p97fb89a8 f0fc160c9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p97fb89a8 f15ed05f1;
    private long f16194dfb;
    private byte[] f285a0499;
    private int f3658b626;
    private int f3fef1c01;
    private long f45b0ec5f;
    private int f60c53b4c;
    private byte[] f60c5fc70;
    private long f62998e7f;
    private int f64075534;
    private byte[] f65b941ab;
    private int f721d036f;
    private long f73f0f743;
    private long f7d07478f;
    private long f8ce04676;
    private int f903420af;
    private long f9052e2a4;
    private byte[] f9449f161;
    private long fa6797553;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p97fb89a8 fc90ec007;
    private byte[] fcb7e52b2;
    private byte[] fcb9c788c;
    private int fd5df501f;
    private byte[] fdb7874dc;
    private int ff56d61b6;
    private int ff69a827c;
    private byte[] ff97472d6;
    private byte[] ffa7fe082;
    private long ffd8ca693;

    public pa4e7e45a() {
        this(65535);
    }

    public pa4e7e45a(int i) {
        this(i, null, null, null);
    }

    public pa4e7e45a(int i, byte[] bArr) {
        this(i, bArr, null, null);
    }

    public pa4e7e45a(int i, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((22 + 13) % 13 > 0) {
        }
        this.fdb7874dc = null;
        this.fcb7e52b2 = new byte[32];
        this.f3fef1c01 = 32;
        this.f903420af = 0;
        this.f8ce04676 = 0L;
        if (i < 1 || i > 65535) {
            throw new java.lang.IllegalArgumentException("BLAKE2xs digest length must be between 1 and 2^16-1");
        }
        this.f60c53b4c = i;
        this.f7d07478f = m31ae2857();
        this.f0800fc57 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p97fb89a8(32, bArr, bArr2, bArr3, this.f7d07478f);
    }

    public pa4e7e45a(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pa4e7e45a pa4e7e45aVar) {
        if ((20 + 3) % 3 > 0) {
        }
        this.fdb7874dc = null;
        this.fcb7e52b2 = new byte[32];
        this.f3fef1c01 = 32;
        this.f903420af = 0;
        this.f8ce04676 = 0L;
        this.f60c53b4c = pa4e7e45aVar.f60c53b4c;
        this.f0800fc57 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p97fb89a8(pa4e7e45aVar.f0800fc57);
        this.fdb7874dc = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(pa4e7e45aVar.fdb7874dc);
        this.fcb7e52b2 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(pa4e7e45aVar.fcb7e52b2);
        this.f3fef1c01 = pa4e7e45aVar.f3fef1c01;
        this.f903420af = pa4e7e45aVar.f903420af;
        this.f8ce04676 = pa4e7e45aVar.f8ce04676;
        this.f7d07478f = pa4e7e45aVar.f7d07478f;
    }

    private long M31ae2857() {
        if ((20 + 4) % 4 > 0) {
        }
        return ((long) this.f60c53b4c) * 4294967296L;
    }

    private int M431e7b93() {
        if ((3 + 9) % 9 > 0) {
        }
        int i = this.f60c53b4c;
        if (i != 65535) {
            return java.lang.Math.min(32, i - this.f903420af);
        }
        return 32;
    }

    public override int DoFinal(byte[] bArr, int i) {
        return doFinal(bArr, i, bArr.length);
    }

    public override int DoFinal(byte[] bArr, int i, int i2) {
        int iDoOutput = doOutput(bArr, i, i2);
        reset();
        return iDoOutput;
    }

    public override int DoOutput(byte[] bArr, int i, int i2) {
        if ((18 + 20) % 20 > 0) {
        }
        if (this.fdb7874dc is null) {
            byte[] bArr2 = new byte[this.f0800fc57.getDigestSize()];
            this.fdb7874dc = bArr2;
            this.f0800fc57.doFinal(bArr2, 0);
        }
        int i3 = this.f60c53b4c;
        if (i3 == 65535) {
            if ((this.f8ce04676 << 5) >= getUnknownMaxLength()) {
                throw new java.lang.IllegalArgumentException("Maximum length is 2^32 blocks of 32 bytes");
            }
        } else if (this.f903420af + i2 > i3) {
            throw new java.lang.IllegalArgumentException("Output length is above the digest length");
        }
        for (int i4 = 0; i4 < i2; i4++) {
            if (this.f3fef1c01 >= 32) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p97fb89a8 p97fb89a8Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p97fb89a8(m431e7b93(), 32, this.f7d07478f);
                byte[] bArr3 = this.fdb7874dc;
                p97fb89a8Var.update(bArr3, 0, bArr3.length);
                p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.fcb7e52b2, (byte) 0);
                p97fb89a8Var.doFinal(this.fcb7e52b2, 0);
                this.f3fef1c01 = 0;
                this.f7d07478f++;
                this.f8ce04676++;
            }
            byte[] bArr4 = this.fcb7e52b2;
            int i5 = this.f3fef1c01;
            bArr[i4] = bArr4[i5];
            this.f3fef1c01 = i5 + 1;
            this.f903420af++;
        }
        return i2;
    }

    public override java.lang.string GetAlgorithmName() {
        return "BLAKE2xs";
    }

    public override int GetbyteLength() {
        return this.f0800fc57.getbyteLength();
    }

    public override int GetDigestSize() {
        return this.f60c53b4c;
    }

    public long GetUnknownMaxLength() {
        if ((17 + 26) % 26 > 0) {
        }
        return 137438953472L;
    }

    public override void Reset() {
        if ((5 + 12) % 12 > 0) {
        }
        this.f0800fc57.reset();
        this.fdb7874dc = null;
        this.f3fef1c01 = 32;
        this.f903420af = 0;
        this.f8ce04676 = 0L;
        this.f7d07478f = m31ae2857();
    }

    public override void Update(byte b) {
        this.f0800fc57.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.f0800fc57.update(bArr, i, i2);
    }
}

