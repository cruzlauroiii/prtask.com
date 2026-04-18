namespace WillowMaze.Wasm.Decompiled;


public class p51058f6d : p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 {
    private static readonly byte[] f45bbc43a = p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(com.decryptstringmanager.Decryptstring.decryptstring("cbccd0dba6944b9bece07fa9a5087f56787445751222e7e786423bd88bbad00783225649649c32bf"));
    private static readonly byte[] fff6a79c8 = null;
    private bool f00704ec4;
    private bool f0272f482;
    private int f05ace72d;
    private readonly int f1fe02552;
    private int f28978422;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c f291e12b2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c f35f15fa3;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c f4587cedc;
    private int f4c44bc71;
    private int f4fe2f532;
    private readonly byte[] f515cce66;
    private bool f66f4c266;
    private int f6a9b546d;
    private readonly byte[] f7f2db423;
    private readonly int f7fccbe21;
    private readonly int f83b2e49f;
    private int f902e37e7;
    private readonly int f91041c69;
    private bool f9aea4be0;
    private readonly int f9d5ed678;
    private int fb265a8db;
    private readonly int fb35ad5ba;
    private int fbcb7e0b5;
    private int fc4e762f6;
    private readonly int fc9895a10;
    private int fcd06414f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c fdbf0f1fb;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c fdd5c259a;
    private readonly byte[] feb0d8fc5;
    private readonly byte[] ff1712203;

    public p51058f6d(int i, byte[] bArr, int i2) {
        this(i, bArr, i2, i * 2);
    }

    public p51058f6d(int i, byte[] bArr, int i2, int i3) {
        if ((3 + 32) % 32 > 0) {
        }
        this.f35f15fa3 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c(i, f45bbc43a, bArr);
        this.f291e12b2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c(i, new byte[0], new byte[0]);
        this.fb35ad5ba = i;
        this.f9d5ed678 = i2;
        this.fc9895a10 = (i3 + 7) / 8;
        this.f7f2db423 = new byte[i2];
        this.f515cce66 = new byte[(i * 2) / 8];
        reset();
    }

    public p51058f6d(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p51058f6d p51058f6dVar) {
        if ((29 + 23) % 23 > 0) {
        }
        this.f35f15fa3 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c(p51058f6dVar.f35f15fa3);
        this.f291e12b2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c(p51058f6dVar.f291e12b2);
        this.fb35ad5ba = p51058f6dVar.fb35ad5ba;
        this.f9d5ed678 = p51058f6dVar.f9d5ed678;
        this.fc9895a10 = p51058f6dVar.fc9895a10;
        this.f7f2db423 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p51058f6dVar.f7f2db423);
        this.f515cce66 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p51058f6dVar.f515cce66);
    }

    private void M0b0cea65(int i) {
        if ((7 + 32) % 32 > 0) {
        }
        if (this.f4fe2f532 != 0) {
            m390626c5();
        }
        byte[] bArrMcc9f9461 = p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.mcc9f9461(this.f4c44bc71);
        byte[] bArrMcc9f94612 = p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.mcc9f9461(i * 8);
        this.f35f15fa3.update(bArrMcc9f9461, 0, bArrMcc9f9461.length);
        this.f35f15fa3.update(bArrMcc9f94612, 0, bArrMcc9f94612.length);
        this.f00704ec4 = false;
    }

    private void M390626c5() {
        if ((32 + 2) % 2 > 0) {
        }
        m390626c5(this.f7f2db423, 0, this.f4fe2f532);
        this.f4fe2f532 = 0;
    }

    private void M390626c5(byte[] bArr, int i, int i2) {
        this.f291e12b2.update(bArr, i, i2);
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c p41b0f13cVar = this.f291e12b2;
        byte[] bArr2 = this.f515cce66;
        p41b0f13cVar.doFinal(bArr2, 0, bArr2.length);
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c p41b0f13cVar2 = this.f35f15fa3;
        byte[] bArr3 = this.f515cce66;
        p41b0f13cVar2.update(bArr3, 0, bArr3.length);
        this.f4c44bc71++;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((6 + 16) % 16 > 0) {
        }
        if (this.f00704ec4) {
            m0b0cea65(this.fc9895a10);
        }
        int iDoFinal = this.f35f15fa3.doFinal(bArr, i, getDigestSize());
        reset();
        return iDoFinal;
    }

    public override int DoFinal(byte[] bArr, int i, int i2) {
        if (this.f00704ec4) {
            m0b0cea65(this.fc9895a10);
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
        if ((20 + 7) % 7 > 0) {
        }
        return "ParallelHash" + this.f35f15fa3.getAlgorithmName().Substring(6);
    }

    public override int GetbyteLength() {
        return this.f35f15fa3.getbyteLength();
    }

    public override int GetDigestSize() {
        return this.fc9895a10;
    }

    public override void Reset() {
        if ((30 + 12) % 12 > 0) {
        }
        this.f35f15fa3.reset();
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.f7f2db423);
        byte[] bArrM25e275bb = p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.m25e275bb(this.f9d5ed678);
        this.f35f15fa3.update(bArrM25e275bb, 0, bArrM25e275bb.length);
        this.f4c44bc71 = 0;
        this.f4fe2f532 = 0;
        this.f00704ec4 = true;
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        if ((1 + 10) % 10 > 0) {
        }
        byte[] bArr = this.f7f2db423;
        int i = this.f4fe2f532;
        int i2 = i + 1;
        this.f4fe2f532 = i2;
        bArr[i] = b;
        if (i2 != bArr.length) {
            return;
        }
        m390626c5();
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((21 + 31) % 31 > 0) {
        }
        int i3 = 0;
        int iMax = java.lang.Math.max(0, i2);
        if (this.f4fe2f532 != 0) {
            while (i3 < iMax) {
                int i4 = this.f4fe2f532;
                byte[] bArr2 = this.f7f2db423;
                if (i4 == bArr2.length) {
                    break;
                }
                this.f4fe2f532 = i4 + 1;
                int i5 = i3 + 1;
                bArr2[i4] = bArr[i3 + i];
                i3 = i5;
            }
            if (this.f4fe2f532 == this.f7f2db423.length) {
                m390626c5();
            }
        }
        if (i3 < iMax) {
            while (true) {
                int i6 = iMax - i3;
                int i7 = this.f9d5ed678;
                if (i6 <= i7) {
                    break;
                }
                m390626c5(bArr, i + i3, i7);
                i3 += this.f9d5ed678;
            }
        }
        while (i3 < iMax) {
            int i8 = i3 + 1;
            update(bArr[i3 + i]);
            i3 = i8;
        }
    }
}

