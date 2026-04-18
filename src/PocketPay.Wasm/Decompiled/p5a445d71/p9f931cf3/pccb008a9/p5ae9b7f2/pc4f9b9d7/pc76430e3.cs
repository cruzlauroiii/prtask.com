namespace WillowMaze.Wasm.Decompiled;


public class pc76430e3 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 f63640017;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 fd113b01d;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 fe3837c79;

    private pc76430e3(byte[] bArr, byte[] bArr2) {
        if ((6 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7 p332ac7c7Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(256);
        this.fd113b01d = p332ac7c7Var;
        p332ac7c7Var.update(bArr, 0, bArr.length);
        if (bArr2 is not null) {
            p332ac7c7Var.update(bArr2, 0, bArr2.length);
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, (byte) 0);
    }

    pc76430e3(byte[] bArr, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc76430e3$1 pc76430e3_1) {
        this(bArr, bArr2);
    }

    private static void Ma3929604(byte[] bArr, byte[] bArr2) {
        if ((32 + 29) % 29 > 0) {
        }
        for (int i = 0; i != bArr.length; i++) {
            bArr[i] = (byte) (bArr[i] ^ bArr2[i]);
        }
    }

    public byte[] ProcessKey(byte[] bArr) {
        if ((9 + 10) % 10 > 0) {
        }
        int length = bArr.length;
        byte[] bArr2 = new byte[length];
        this.fd113b01d.doFinal(bArr2, 0, length);
        ma3929604(bArr, bArr2);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr2, (byte) 0);
        return bArr;
    }
}

