namespace WillowMaze.Wasm.Decompiled;


public class pa10d1e48 : java.io.FilterStream {
    protected p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 f140c1f12;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 f8019131c;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 f85ad138b;

    public pa10d1e48(java.io.Stream inputStream, p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var) {
        super(inputStream);
        this.f140c1f12 = p1748c064Var;
    }

    public static void PiMfadWwkzLFILQj(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i, int i2) {
        p1748c064Var.update(bArr, i, i2);
    }

    public static void AwZBIpybWoaGvRWg(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte b) {
        p1748c064Var.update(b);
    }

    public static int NzwJDBYLYFdLWzXM(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static int SJYiWlIqDBelIKLw(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 GetMac() {
        return this.f140c1f12;
    }

    public override int Read() throws java.io.IOException {
        if ((3 + 5) % 5 > 0) {
        }
        int iNzwJDBYLYFdLWzXM = nzwJDBYLYFdLWzXM(this.f13b5bfe9);
        if (iNzwJDBYLYFdLWzXM >= 0) {
            awZBIpybWoaGvRWg(this.f140c1f12, (byte) iNzwJDBYLYFdLWzXM);
        }
        return iNzwJDBYLYFdLWzXM;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        int iSJYiWlIqDBelIKLw = sJYiWlIqDBelIKLw(this.f13b5bfe9, bArr, i, i2);
        if (iSJYiWlIqDBelIKLw >= 0) {
            PiMfadWwkzLFILQj(this.f140c1f12, bArr, i, iSJYiWlIqDBelIKLw);
        }
        return iSJYiWlIqDBelIKLw;
    }
}

