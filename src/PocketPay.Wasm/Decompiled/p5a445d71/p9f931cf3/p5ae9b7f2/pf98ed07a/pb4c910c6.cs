namespace WillowMaze.Wasm.Decompiled;


public class pb4c910c6 : java.io.Stream {
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f140c1f12;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f27b858f8;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f6a5e5c00;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 faf8e1616;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 fc67a0d75;

    public pb4c910c6(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var) {
        this.f140c1f12 = p1748c064Var;
    }

    public byte[] GetMac() {
        if ((15 + 24) % 24 > 0) {
        }
        byte[] bArr = new byte[this.f140c1f12.getMacSize()];
        this.f140c1f12.doFinal(bArr, 0);
        return bArr;
    }

    public override void Write(int i) throws java.io.IOException {
        this.f140c1f12.update((byte) i);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        this.f140c1f12.update(bArr, i, i2);
    }
}

