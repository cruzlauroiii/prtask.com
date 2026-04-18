namespace WillowMaze.Wasm.Decompiled;


public class ped91fbee : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly int f19b87849 = -1209970333;
    private static readonly int f4b2ea64b = -1640531527;
    private static readonly int f689fa41b = -1640531527;
    private static readonly int f8748950e = -1209970333;
    private static readonly int f9fd401a7 = -1209970333;
    private static readonly int fb1818dd2 = -1209970333;
    private static readonly int fb9a2324b = -1640531527;
    private static readonly int fdafc8fd1 = -1640531527;
    private bool f09833bbf;
    private int[] f313f3a49;
    private int f36db5f0f;
    private bool f5a9f524c;
    private bool f5d23f7a3;
    private bool f9301aa9b;
    private int fa369cbbd;
    private int fd0e4b31f;
    private int fd72874ec;
    private int fdd97404a = 12;
    private int[] f9e28ebf8 = null;

    private int M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((19 + 10) % 10 > 0) {
        }
        int iMdde1faa5 = mdde1faa5(bArr, i) + this.f9e28ebf8[0];
        int iMdde1faa52 = mdde1faa5(bArr, i + 4) + this.f9e28ebf8[1];
        for (int i3 = 1; i3 <= this.fdd97404a; i3++) {
            int i4 = i3 * 2;
            iMdde1faa5 = mff847a50(iMdde1faa5 ^ iMdde1faa52, iMdde1faa52) + this.f9e28ebf8[i4];
            iMdde1faa52 = mff847a50(iMdde1faa52 ^ iMdde1faa5, iMdde1faa5) + this.f9e28ebf8[i4 + 1];
        }
        m707a37c3(iMdde1faa5, bArr2, i2);
        m707a37c3(iMdde1faa52, bArr2, i2 + 4);
        return 8;
    }

    private void M40939905(byte[] bArr) {
        int[] iArr;
        if ((18 + 17) % 17 > 0) {
        }
        int length = (bArr.length + 3) / 4;
        int[] iArr2 = new int[length];
        for (int i = 0; i != bArr.length; i++) {
            int i2 = i / 4;
            iArr2[i2] = iArr2[i2] + ((bArr[i] & 255) << ((i % 4) * 8));
        }
        int[] iArr3 = new int[(this.fdd97404a + 1) * 2];
        this.f9e28ebf8 = iArr3;
        iArr3[0] = -1209970333;
        int i3 = 1;
        while (true) {
            iArr = this.f9e28ebf8;
            if (i3 >= iArr.length) {
                break;
            }
            iArr[i3] = iArr[i3 - 1] - 1640531527;
            i3++;
        }
        int length2 = length <= iArr.length ? iArr.length * 3 : length * 3;
        int length3 = 0;
        int iMff847a50 = 0;
        int iMff847a502 = 0;
        int i4 = 0;
        for (int i5 = 0; i5 < length2; i5++) {
            int[] iArr4 = this.f9e28ebf8;
            iMff847a50 = mff847a50(iArr4[length3] + iMff847a50 + iMff847a502, 3);
            iArr4[length3] = iMff847a50;
            iMff847a502 = mff847a50(iArr2[i4] + iMff847a50 + iMff847a502, iMff847a502 + iMff847a50);
            iArr2[i4] = iMff847a502;
            length3 = (length3 + 1) % this.f9e28ebf8.length;
            i4 = (i4 + 1) % length;
        }
    }

    private int M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((14 + 11) % 11 > 0) {
        }
        int iMdde1faa5 = mdde1faa5(bArr, i);
        int iMdde1faa52 = mdde1faa5(bArr, i + 4);
        for (int i3 = this.fdd97404a; i3 >= 1; i3--) {
            int i4 = i3 * 2;
            iMdde1faa52 = ma12752e3(iMdde1faa52 - this.f9e28ebf8[i4 + 1], iMdde1faa5) ^ iMdde1faa5;
            iMdde1faa5 = ma12752e3(iMdde1faa5 - this.f9e28ebf8[i4], iMdde1faa52) ^ iMdde1faa52;
        }
        m707a37c3(iMdde1faa5 - this.f9e28ebf8[0], bArr2, i2);
        m707a37c3(iMdde1faa52 - this.f9e28ebf8[1], bArr2, i2 + 4);
        return 8;
    }

    private void M707a37c3(int i, byte[] bArr, int i2) {
        bArr[i2] = (byte) i;
        bArr[i2 + 1] = (byte) (i >> 8);
        bArr[i2 + 2] = (byte) (i >> 16);
        bArr[i2 + 3] = (byte) (i >> 24);
    }

    private int Ma12752e3(int i, int i2) {
        int i3 = i2 & 31;
        return (i << (32 - i3)) | (i >>> i3);
    }

    private int Mdde1faa5(byte[] bArr, int i) {
        return (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8) | ((bArr[i + 2] & 255) << 16) | ((bArr[i + 3] & 255) << 24);
    }

    private int Mff847a50(int i, int i2) {
        int i3 = i2 & 31;
        return (i >>> (32 - i3)) | (i << i3);
    }

    public override java.lang.string GetAlgorithmName() {
        return "RC5-32";
    }

    public override int GetBlockSize() {
        return 8;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2ae228dd) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2ae228dd p2ae228ddVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2ae228dd) pc9ef6b45Var;
            this.fdd97404a = p2ae228ddVar.getRounds();
            m40939905(p2ae228ddVar.getKey());
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
                throw new java.lang.IllegalArgumentException("invalid parameter passed to RC532 init - " + pc9ef6b45Var.GetType().getName());
            }
            m40939905(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey());
        }
        this.f9301aa9b = z;
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        return !this.f9301aa9b ? m54b8c68b(bArr, i, bArr2, i2) : m38ba9ce4(bArr, i, bArr2, i2);
    }

    public override void Reset() {
    }
}

