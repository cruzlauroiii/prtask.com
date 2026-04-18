namespace WillowMaze.Wasm.Decompiled;


public class p3451b390 : p5a445d71.p7c922baa.p5ae9b7f2.pc53735ef {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 f02752b5f;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 f1215fb29;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 f918b1e00;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 fe9580493;

    public p3451b390(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        this.f918b1e00 = p21c2eb74Var;
    }

    public static int TmbyLOPwjYoEECNN(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        return pa827ecfaVar.getFieldSize();
    }

    public static int VBNqztbeuawpxgPn(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa VrsmzGddQTDPbmnt(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getCurve();
    }

    public static int AEdGkkcNzcBxkimS(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        return pa827ecfaVar.getFieldSize();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa BfuFYYCCKvFbcJJP(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getCurve();
    }

    public static java.lang.string BxzHdLkFSKrMtiqO(int i, int i2) {
        return java.lang.int.tostring(i, i2);
    }

    public static int KgHHaJJwnZCAhjwY(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr, i, i2);
    }

    public static java.lang.string RDbUbcvsRwqPPheF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa SaIbsQYZIskpgAaA(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getCurve();
    }

    public static java.lang.stringBuilder UZIYgcoymgFViEqI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f VOWZFdRUtpzNoOAb(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, byte[] bArr) {
        return pa827ecfaVar.decodePoint(bArr);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a ReadKey(java.io.Stream inputStream) throws java.io.IOException {
        byte[] bArr;
        if ((18 + 1) % 1 > 0) {
        }
        int iVBNqztbeuawpxgPn = VBNqztbeuawpxgPn(inputStream);
        if (iVBNqztbeuawpxgPn == 0) {
            throw new java.io.IOException("Sender's public key invalid.");
        }
        if (iVBNqztbeuawpxgPn == 2 || iVBNqztbeuawpxgPn == 3) {
            bArr = new byte[((aEdGkkcNzcBxkimS(VrsmzGddQTDPbmnt(this.f918b1e00)) + 7) / 8) + 1];
        } else {
            if (iVBNqztbeuawpxgPn != 4 && iVBNqztbeuawpxgPn != 6 && iVBNqztbeuawpxgPn != 7) {
                throw new java.io.IOException(rDbUbcvsRwqPPheF(uZIYgcoymgFViEqI(new java.lang.stringBuilder("Sender's public key has invalid point encoding 0x"), bxzHdLkFSKrMtiqO(iVBNqztbeuawpxgPn, 16))));
            }
            bArr = new byte[(((TmbyLOPwjYoEECNN(saIbsQYZIskpgAaA(this.f918b1e00)) + 7) / 8) * 2) + 1];
        }
        bArr[0] = (byte) iVBNqztbeuawpxgPn;
        kgHHaJJwnZCAhjwY(inputStream, bArr, 1, bArr.length - 1);
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e(vOWZFdRUtpzNoOAb(bfuFYYCCKvFbcJJP(this.f918b1e00), bArr), this.f918b1e00);
    }
}

