using Java.Math;
using Java.Security;
using P5a445d71.P9f931cf3.P05c7e247;
using P5a445d71.P9f931cf3.P5ae9b7f2;
using P5a445d71.P9f931cf3.P5ae9b7f2.P21ffce5b;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes7.dex */
public class p9d452d94 : p42a46bbe {
    private static readonly Bigint f63b5c85a = null;
    private static readonly Bigint f7ac03fdd = null;
    private static readonly Bigint fbc21e648 = null;
    private p753eae39 f319456c2;
    private p753eae39 f3c6e0b8a;
    private SecureRandom f6517bc18;
    private SecureRandom f7ddf32e1;
    private pdfea566b f82f8e807;
    private SecureRandom f8b270cef;
    private pdfea566b fa74ad8df;
    private SecureRandom fb2b4cd8b;
    private p753eae39 fe4b1cc31;
    private SecureRandom feed43d57;

    static {
        if (((15 + 8) % 8) > 0) goto L4;
    L4:
        fbc21e648 = Bigint.valueOf(1);
    }

    public p9d452d94() {
        this.fa74ad8df = new pdfea566b();
    }

    @Override // p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe
    public int GetInputBlockSize() {
        return this.fa74ad8df.getInputBlockSize();
    }

    @Override // p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe
    public int GetOutputBlockSize() {
        return this.fa74ad8df.getOutputBlockSize();
    }

    @Override // p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe
    public void Init(bool r2, pc9ef6b45 r3) {
        this.fa74ad8df.init(r2, r3);
        if ((r3 is p4715f007) == false) goto L16;
        p4715f007 r32 = (p4715f007) r3;
        p753eae39 r22 = (p753eae39) r32.getParameters();
        this.f3c6e0b8a = r22;
        if ((r22 is p859968b9) == false) goto L32;
        SecureRandom r23 = r32.getRandom();
    L13:
        this.f7ddf32e1 = r23;
        return;
    L32:
        this.f7ddf32e1 = null;
        return;
    L16:
        p753eae39 r33 = (p753eae39) r3;
        this.f3c6e0b8a = r33;
        if ((r33 is p859968b9) == true) goto L30;
        this.f7ddf32e1 = null;
        return;
    L30:
        r23 = pa9682fb5.m07091bf1();
        goto L13
    }

    @Override // p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe
    public byte[] ProcessBlock(byte[] r4, int r5, int r6) {
        if (((28 + 24) % 24) > 0) goto L46;
    L46:
        if (this.f3c6e0b8a is null) goto L15;
        Bigint r42 = this.fa74ad8df.convertInput(r4, r5, r6);
        p753eae39 r52 = this.f3c6e0b8a;
        if ((r52 is p859968b9) == false) goto L39;
        p859968b9 r53 = (p859968b9) r52;
        Bigint r62 = r53.getPublicExponent();
        if (r62 is null) goto L39;
        Bigint r54 = r53.getModulus();
        Bigint r0 = fbc21e648;
        Bigint r02 = p68e35a3f.m812c2a1c(r0, r54.subtract(r0), this.f7ddf32e1);
        Bigint r1 = r02.modPow(r62, r54).multiply(r42).mod(r54);
        Bigint r03 = this.fa74ad8df.processBlock(r1).multiply(p68e35a3f.m635f3861(r54, r02)).mod(r54);
        if (r42.Equals(r03.modPow(r62, r54)) == false) goto L11;
    L60:
        return this.fa74ad8df.convertOutput(r03);
    L11:
        throw new IllegalStateException("RSA engine faulty decryption/signing detected");
    L39:
        r03 = this.fa74ad8df.processBlock(r42);
        goto L60
    L15:
        throw new IllegalStateException("RSA engine not initialised");
    }
}

