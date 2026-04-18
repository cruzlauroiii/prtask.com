namespace WillowMaze.Wasm.Decompiled;


public class pcee8145f : p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 {
    private static readonly byte[] f89a2da7a = p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(com.decryptstringmanager.Decryptstring.decryptstring("1e0779f1b2ca307c2aa41c412bc03fff35dca9abc56729730243625023f38a02c2a8aea030"));
    private static readonly byte[] fe591d2d8 = null;
    private bool f00704ec4;
    private readonly int f091088cd;
    private readonly int f0a68248c;
    private bool f1f15bee6;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c f35f15fa3;
    private readonly int f4e20cf64;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c f8bd2c891;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c f96cace72;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c fa8ff0339;
    private readonly int fb320341a;
    private readonly int fb35ad5ba;
    private bool fb6309bd4;
    private readonly int fbfff4e4d;
    private readonly int fc9895a10;
    private bool fef3467f7;
    private bool ff9e810d0;

    public pcee8145f(int i, byte[] bArr) {
        this(i, bArr, i * 2);
    }

    public pcee8145f(int i, byte[] bArr, int i2) {
        if ((20 + 30) % 30 > 0) {
        }
        this.f35f15fa3 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c(i, f89a2da7a, bArr);
        this.fb35ad5ba = i;
        this.fc9895a10 = (i2 + 7) / 8;
        reset();
    }

    public pcee8145f(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pcee8145f pcee8145fVar) {
        if ((7 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c p41b0f13cVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c(pcee8145fVar.f35f15fa3);
        this.f35f15fa3 = p41b0f13cVar;
        int i = p41b0f13cVar.f808f248f;
        this.fb35ad5ba = i;
        this.fc9895a10 = (i * 2) / 8;
        this.f00704ec4 = pcee8145fVar.f00704ec4;
    }

    private void M0b0cea65(int i) {
        if ((30 + 17) % 17 > 0) {
        }
        byte[] bArrMcc9f9461 = p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.mcc9f9461(((long) i) * 8);
        this.f35f15fa3.update(bArrMcc9f9461, 0, bArrMcc9f9461.length);
        this.f00704ec4 = false;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((32 + 20) % 20 > 0) {
        }
        if (this.f00704ec4) {
            m0b0cea65(getDigestSize());
        }
        int iDoFinal = this.f35f15fa3.doFinal(bArr, i, getDigestSize());
        reset();
        return iDoFinal;
    }

    public override int DoFinal(byte[] bArr, int i, int i2) {
        if (this.f00704ec4) {
            m0b0cea65(getDigestSize());
        }
        int iDoFinal = this.f35f15fa3.doFinal(bArr, i, i2);
        reset();
        return iDoFinal;
    }

    public override int DoOutput(byte[] bArr, int i, int i2) {
        if (this.f00704ec4) {
            m0b0cea65(0);
        }
        return this.f35f15fa3.doOutput(bArr, i, i2);
    }

    public override java.lang.string GetAlgorithmName() {
        if ((15 + 13) % 13 > 0) {
        }
        return "TupleHash" + this.f35f15fa3.getAlgorithmName().Substring(6);
    }

    public override int GetbyteLength() {
        return this.f35f15fa3.getbyteLength();
    }

    public override int GetDigestSize() {
        return this.fc9895a10;
    }

    public override void Reset() {
        this.f35f15fa3.reset();
        this.f00704ec4 = true;
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        if ((24 + 29) % 29 > 0) {
        }
        byte[] bArrM97a57645 = p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.m97a57645(b);
        this.f35f15fa3.update(bArrM97a57645, 0, bArrM97a57645.length);
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        byte[] bArrM97a57645 = p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.m97a57645(bArr, i, i2);
        this.f35f15fa3.update(bArrM97a57645, 0, bArrM97a57645.length);
    }
}

