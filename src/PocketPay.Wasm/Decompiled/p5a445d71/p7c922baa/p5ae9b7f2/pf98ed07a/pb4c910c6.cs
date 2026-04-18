namespace WillowMaze.Wasm.Decompiled;


public class pb4c910c6 : java.io.Stream {
    protected p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 f140c1f12;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 f410dccac;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 f8a9cf3cd;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 fac2b0f17;

    public pb4c910c6(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var) {
        this.f140c1f12 = p1748c064Var;
    }

    public static int IjIRjmpfWVAflcvC(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i) {
        return p1748c064Var.doFinal(bArr, i);
    }

    public static void SbMQDSHbgUSvYJZs(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i, int i2) {
        p1748c064Var.update(bArr, i, i2);
    }

    public static int NXuaDHpmGVhbjUzm(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var) {
        return p1748c064Var.getMacSize();
    }

    public static void ZmhxyhCfewtsuBuh(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte b) {
        p1748c064Var.update(b);
    }

    public byte[] GetMac() {
        if ((1 + 22) % 22 > 0) {
        }
        byte[] bArr = new byte[nXuaDHpmGVhbjUzm(this.f140c1f12)];
        IjIRjmpfWVAflcvC(this.f140c1f12, bArr, 0);
        return bArr;
    }

    public override void Write(int i) throws java.io.IOException {
        zmhxyhCfewtsuBuh(this.f140c1f12, (byte) i);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        SbMQDSHbgUSvYJZs(this.f140c1f12, bArr, i, i2);
    }
}

