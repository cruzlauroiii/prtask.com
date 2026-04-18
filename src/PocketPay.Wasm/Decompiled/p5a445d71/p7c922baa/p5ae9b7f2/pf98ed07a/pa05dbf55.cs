namespace WillowMaze.Wasm.Decompiled;


public class pa05dbf55 : java.io.Stream {
    protected p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f4f61175b;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f6607ba75;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc10f7796;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fd5f3e084;

    public pa05dbf55(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
    }

    public static int MYvcExKmFbsaIfnS(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void SDZCWzQNrMNhFpzV(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void IUSEGMdmFJxbbWzV(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte b) {
        pe5cfc515Var.update(b);
    }

    public static int IcebKyRQafKghjXm(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public byte[] GetDigest() {
        if ((5 + 3) % 3 > 0) {
        }
        byte[] bArr = new byte[MYvcExKmFbsaIfnS(this.fc10f7796)];
        icebKyRQafKghjXm(this.fc10f7796, bArr, 0);
        return bArr;
    }

    public override void Write(int i) throws java.io.IOException {
        iUSEGMdmFJxbbWzV(this.fc10f7796, (byte) i);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        SDZCWzQNrMNhFpzV(this.fc10f7796, bArr, i, i2);
    }
}

