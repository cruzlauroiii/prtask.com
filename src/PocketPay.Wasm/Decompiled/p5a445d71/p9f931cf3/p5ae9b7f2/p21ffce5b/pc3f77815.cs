namespace WillowMaze.Wasm.Decompiled;


public class pc3f77815 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private static readonly int f1ebf232d = 32;
    private static readonly int f7d790f0b = 32;
    private byte[] f2955ce8e;
    private byte[] f6d1b230c;
    private byte[] f7fb2a209;
    private byte[] f84fecbde;
    private byte[] fad4772a5;
    private byte[] fd410a99a;
    private byte[] fe376736e;

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3f77815 M3c6e0b8a(byte[] bArr) {
        if ((8 + 32) % 32 > 0) {
        }
        if (bArr is null || bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("Invalid keyLength");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3f77815 pc3f77815Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3f77815();
        pc3f77815Var.f6d1b230c = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        return pc3f77815Var;
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3f77815 M5c18ef72(byte[] bArr) {
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("Invalid context");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3f77815 pc3f77815Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3f77815();
        pc3f77815Var.fad4772a5 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        return pc3f77815Var;
    }

    public void ClearKey() {
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f6d1b230c, (byte) 0);
    }

    public byte[] Getobject() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fad4772a5);
    }

    public byte[] GetKey() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f6d1b230c);
    }
}

