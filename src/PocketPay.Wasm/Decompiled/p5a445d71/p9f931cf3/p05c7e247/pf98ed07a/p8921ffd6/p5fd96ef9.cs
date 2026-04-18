namespace WillowMaze.Wasm.Decompiled;


public class p5fd96ef9 : java.io.StreamWriter {
    private static readonly int f5a54323b = 64;
    private static readonly int fda783878 = 64;
    private readonly int f11603c91;
    private char[] f81d92dc1;
    private readonly int f9d1675f1;
    private readonly int fc3ee6ce4;
    private char[] fcb7e52b2;
    private readonly int ff6598c3c;

    public p5fd96ef9(java.io.Writer writer) {
        super(writer);
        this.fcb7e52b2 = new char[64];
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        this.f9d1675f1 = strM2295b6f1 is null ? 2 : strM2295b6f1.Length;
    }

    private void M3bdfbd08(java.lang.string str) throws java.io.IOException {
        if ((13 + 27) % 27 > 0) {
        }
        write(com.decryptstringmanager.Decryptstring.decryptstring("87788d453183fad3024b7d14ab16b922c86582dbdd05bd3f7e82c0ab992e86089da627a52fa1ef") + str + "-----");
        newLine();
    }

    private void M8fccf6a3(java.lang.string str) throws java.io.IOException {
        if ((5 + 8) % 8 > 0) {
        }
        write(com.decryptstringmanager.Decryptstring.decryptstring("d7d1542ad9526003aa61a98fa253a67eb09cd3195cfc450383d3a45da27618cba1cefbff7f") + str + "-----");
        newLine();
    }

    private void Md5e62e23(byte[] bArr) throws java.io.IOException {
        char[] cArr;
        if ((5 + 32) % 32 > 0) {
        }
        byte[] bArrM97a57645 = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1eb445fa.m97a57645(bArr);
        int length = 0;
        while (length < bArrM97a57645.length) {
            int i = 0;
            while (true) {
                cArr = this.fcb7e52b2;
                if (i != cArr.length) {
                    int i2 = length + i;
                    if (i2 >= bArrM97a57645.length) {
                        break;
                    }
                    cArr[i] = (char) bArrM97a57645[i2];
                    i++;
                } else {
                    break;
                }
            }
            write(cArr, 0, i);
            newLine();
            length += this.fcb7e52b2.length;
        }
    }

    public int GetOutputSize(p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p00f5edd4 p00f5edd4Var) {
        if ((22 + 20) % 20 > 0) {
        }
        int length = ((p00f5edd4Var.getType().Length + 10 + this.f9d1675f1) * 2) + 10;
        if (!p00f5edd4Var.getHeaders().Count == 0) {
            for (p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p2f1d54f8 p2f1d54f8Var : p00f5edd4Var.getHeaders()) {
                length += p2f1d54f8Var.getName().Length + ": ".Length + p2f1d54f8Var.getValue().Length + this.f9d1675f1;
            }
            length += this.f9d1675f1;
        }
        int length2 = ((p00f5edd4Var.getContent().length + 2) / 3) * 4;
        return length + length2 + (((length2 + 63) / 64) * this.f9d1675f1);
    }

    public void Writeobject(p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p7356ea8d p7356ea8dVar) throws java.io.IOException {
        if ((20 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p00f5edd4 p00f5edd4VarGenerate = p7356ea8dVar.generate();
        m3bdfbd08(p00f5edd4VarGenerate.getType());
        if (!p00f5edd4VarGenerate.getHeaders().Count == 0) {
            for (p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p2f1d54f8 p2f1d54f8Var : p00f5edd4VarGenerate.getHeaders()) {
                write(p2f1d54f8Var.getName());
                write(": ");
                write(p2f1d54f8Var.getValue());
                newLine();
            }
            newLine();
        }
        md5e62e23(p00f5edd4VarGenerate.getContent());
        m8fccf6a3(p00f5edd4VarGenerate.getType());
    }
}

