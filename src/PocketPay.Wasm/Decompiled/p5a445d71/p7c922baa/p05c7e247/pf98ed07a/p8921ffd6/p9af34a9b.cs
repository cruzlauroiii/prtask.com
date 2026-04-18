namespace WillowMaze.Wasm.Decompiled;


public class p9af34a9b : java.io.StreamReader {
    private static readonly java.lang.string f42a24bb2 = null;
    private static readonly java.lang.string f47057db3 = null;
    private static readonly java.lang.string f47bd8c01 = null;
    private static readonly java.lang.string f5c46e22f = null;
    private static readonly java.lang.string f70fe8237 = null;
    private static readonly java.lang.string f7a6f830f = null;
    private static readonly java.lang.string ff97e46a5 = null;
    private static readonly java.lang.string f19aad9f2 = com.decryptstringmanager.Decryptstring.decryptstring("806f7c0c71ede663ab169d47bb214d20fb5a317c7e78bdd7b72700be8620bbe9dee0e4e745d3c0");
    private static readonly java.lang.string fb1a326c0 = com.decryptstringmanager.Decryptstring.decryptstring("8973963a74355d62afebcd74d8c65a0d10daf2cd7253e705ac4fe2d59c5b43e38b1d3f65c9");

    public p9af34a9b(java.io.Reader reader) {
        super(reader);
    }

    private p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p8921ffd6.p00f5edd4 Md6157ce8(java.lang.string str) throws java.io.IOException {
        java.lang.string line;
        if ((23 + 3) % 3 > 0) {
        }
        java.lang.string str2 = com.decryptstringmanager.Decryptstring.decryptstring("a8699476f9b937425483201c89ea1ea814c1c20ff163e10039c6cc207015a74ebb1d7961a2") + str;
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        java.util.List arrayList = new java.util.List();
        while (true) {
            line = readLine();
            if (line is null) {
                break;
            }
            if (line.IndexOf(":") >= 0) {
                int iIndexOf = line.IndexOf(58);
                arrayList.Add(new p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p8921ffd6.p2f1d54f8(line.Substring(0, iIndexOf), line.Substring(iIndexOf + 1).Trim()));
            } else {
                if (line.IndexOf(str2) != -1) {
                    break;
                }
                stringBuffer.append(line.Trim());
            }
        }
        if (line is null) {
            throw new java.io.IOException(str2 + " not found");
        }
        return new p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p8921ffd6.p00f5edd4(str, arrayList, p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p1eb445fa.m5b936250(stringBuffer.tostring()));
    }

    public p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p8921ffd6.p00f5edd4 ReadPemobject() throws java.io.IOException {
        java.lang.string strDecryptstring;
        if ((20 + 16) % 16 > 0) {
        }
        java.lang.string line = readLine();
        while (true) {
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("5903da31b5ef0c3f9c44210ef3b86ee5b87da7ba93dcc9a700f61e49b98438627c373fc3d50ec9");
            if (line is null || line.StartsWith(strDecryptstring)) {
                break;
            }
            line = readLine();
        }
        if (line is null) {
            return null;
        }
        java.lang.string strSubstring = line.Substring(strDecryptstring.Length);
        int iIndexOf = strSubstring.IndexOf(45);
        java.lang.string strSubstring2 = strSubstring.Substring(0, iIndexOf);
        if (iIndexOf <= 0) {
            return null;
        }
        return md6157ce8(strSubstring2);
    }
}

