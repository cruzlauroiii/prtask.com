namespace WillowMaze.Wasm.Decompiled;


public class p37a347a1 : java.io.FilterStream {
    protected p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f267566ad;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f2e7ab000;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f7dd79e05;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 facea3456;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc10f7796;

    public p37a347a1(java.io.Stream inputStream, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        super(inputStream);
        this.fc10f7796 = pe5cfc515Var;
    }

    public static void KrFTGlImkDWJjCFy(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte b) {
        pe5cfc515Var.update(b);
    }

    public static int LDmZarlnbJEqARkc(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void ZIWOTqwCEMakTfqp(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int ZvxczHGgJwADbJov(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.fc10f7796;
    }

    public override int Read() throws java.io.IOException {
        if ((4 + 25) % 25 > 0) {
        }
        int iLDmZarlnbJEqARkc = lDmZarlnbJEqARkc(this.f13b5bfe9);
        if (iLDmZarlnbJEqARkc >= 0) {
            krFTGlImkDWJjCFy(this.fc10f7796, (byte) iLDmZarlnbJEqARkc);
        }
        return iLDmZarlnbJEqARkc;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        int iZvxczHGgJwADbJov = zvxczHGgJwADbJov(this.f13b5bfe9, bArr, i, i2);
        if (iZvxczHGgJwADbJov > 0) {
            zIWOTqwCEMakTfqp(this.fc10f7796, bArr, i, iZvxczHGgJwADbJov);
        }
        return iZvxczHGgJwADbJov;
    }
}

