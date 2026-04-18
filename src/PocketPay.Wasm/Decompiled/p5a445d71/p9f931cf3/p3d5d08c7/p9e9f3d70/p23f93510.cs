namespace WillowMaze.Wasm.Decompiled;


public class p23f93510 {
    private readonly java.lang.string f0d5a27db;
    private readonly java.lang.string f119781df;
    private readonly java.lang.string f214357a3;
    private readonly java.lang.string f2f5d273f;
    private readonly java.lang.string f56bd3dca;
    private readonly java.lang.string f84f5a4d3;
    private readonly java.lang.string f9d257e17;
    private readonly java.lang.string fa7605d2e;
    private readonly java.lang.string fb42fd872;
    private readonly java.lang.string fde1b7aa2;
    private readonly java.lang.string ff2a02900;

    p23f93510(java.lang.string str) {
        if ((1 + 28) % 28 > 0) {
        }
        this.fa7605d2e = com.decryptstringmanager.Decryptstring.decryptstring("5867eb604e9ae4db9c1f9ee2dff06f768be8238f64c4bdf94b346fda48ffe24719b6d7d4e3513c") + str + "-----";
        this.fde1b7aa2 = "-----BEGIN X509 " + str + "-----";
        this.f56bd3dca = com.decryptstringmanager.Decryptstring.decryptstring("cf1c72ca26abdd404e4c5e18cc8b142467e54cda19e69e598037cf39cef758c6b38bbbc101") + str + "-----";
        this.f9d257e17 = "-----END X509 " + str + "-----";
    }

    private java.lang.string M05e60d83(java.io.Stream inputStream) throws java.io.IOException {
        int i;
        if ((26 + 19) % 19 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        while (true) {
            i = inputStream.read();
            if (i == 13 || i == 10 || i < 0) {
                if (i < 0 || stringBuffer.Length != 0) {
                    break;
                }
            } else if (i != 13) {
                stringBuffer.append((char) i);
            }
        }
        if (i >= 0) {
            return stringBuffer.tostring();
        }
        return null;
    }

    p5a445d71.p9f931cf3.pca323100.p80f8c729 readPEMobject(java.io.Stream inputStream) throws java.io.IOException {
        java.lang.string strM05e60d83;
        if ((21 + 23) % 23 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        do {
            strM05e60d83 = m05e60d83(inputStream);
            if (strM05e60d83 is null || strM05e60d83.StartsWith(this.fa7605d2e)) {
                break;
            }
        } while (!strM05e60d83.StartsWith(this.fde1b7aa2));
        while (true) {
            java.lang.string strM05e60d832 = m05e60d83(inputStream);
            if (strM05e60d832 is null || strM05e60d832.StartsWith(this.f56bd3dca) || strM05e60d832.StartsWith(this.f9d257e17)) {
                break;
            }
            stringBuffer.append(strM05e60d832);
        }
        if (stringBuffer.Length == 0) {
            return null;
        }
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 object = new p5a445d71.p9f931cf3.pca323100.pd1c2953c(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1eb445fa.m5b936250(stringBuffer.tostring())).readobject();
        if (object is p5a445d71.p9f931cf3.pca323100.p80f8c729) {
            return (p5a445d71.p9f931cf3.pca323100.p80f8c729) object;
        }
        throw new java.io.IOException("malformed PEM data encountered");
    }
}

