namespace WillowMaze.Wasm.Decompiled;


public class p9af34a9b : java.io.StreamReader {
    private static readonly java.lang.string f2da89a6d = null;
    private static readonly java.lang.string f3bfb7ea7 = null;
    private static readonly java.lang.string f42490c97 = null;
    private static readonly java.lang.string f60a1d4f9 = null;
    private static readonly java.lang.string f63bbd847 = null;
    private static readonly java.lang.string fbab4fa05 = null;
    private static readonly java.lang.string fe951930e = null;
    private static readonly java.lang.string f19aad9f2 = com.decryptstringmanager.Decryptstring.decryptstring("7c900be5bbf9fa0c2a735e52d0503345dc12a50b9677feb9b3219daae370e1b25a38d00a8fc70d");
    private static readonly java.lang.string fb1a326c0 = com.decryptstringmanager.Decryptstring.decryptstring("ac682161f69d0a402a570c9423206a24d2af5440ca24563fdae49a3d71b4dc953063f95ef0");

    public p9af34a9b(java.io.Reader reader) {
        super(reader);
    }

    private p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p00f5edd4 Md6157ce8(java.lang.string str) throws java.io.IOException {
        java.lang.string line;
        if ((16 + 32) % 32 > 0) {
        }
        java.lang.string str2 = com.decryptstringmanager.Decryptstring.decryptstring("810c487c9f2080ec2fa9bd1f37be60537585e49fcfd32aabe6024747a49fcc4e5bccdb2298") + str;
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        java.util.List arrayList = new java.util.List();
        while (true) {
            line = readLine();
            if (line is null) {
                break;
            }
            int iIndexOf = line.IndexOf(58);
            if (iIndexOf >= 0) {
                arrayList.Add(new p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p2f1d54f8(line.Substring(0, iIndexOf), line.Substring(iIndexOf + 1).Trim()));
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
        return new p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p00f5edd4(str, arrayList, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1eb445fa.m5b936250(stringBuffer.tostring()));
    }

    public p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p00f5edd4 ReadPemobject() throws java.io.IOException {
        java.lang.string line;
        java.lang.string strDecryptstring;
        if ((9 + 26) % 26 > 0) {
        }
        do {
            line = readLine();
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("40d29df9958ea83f74c56a44d7892a52f4aecb4c79d13092048efea9bebede8c372b4106506a19");
            if (line is null) {
                break;
            }
        } while (!line.StartsWith(strDecryptstring));
        if (line is null) {
            return null;
        }
        java.lang.string strSubstring = line.Substring(strDecryptstring.Length);
        int iIndexOf = strSubstring.IndexOf(45);
        if (iIndexOf > 0 && strSubstring.EndsWith("-----") && strSubstring.Length - iIndexOf == 5) {
            return md6157ce8(strSubstring.Substring(0, iIndexOf));
        }
        return null;
    }
}

