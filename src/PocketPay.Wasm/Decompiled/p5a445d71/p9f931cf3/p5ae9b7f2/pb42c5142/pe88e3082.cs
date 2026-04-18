namespace WillowMaze.Wasm.Decompiled;


public class pe88e3082 : p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 {
    public static readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe88e3082 f1fe07ceb = null;
    public static readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe88e3082 f76425f17 = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe88e3082();

    protected java.math.Bigint CheckValue(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if (bigint2.signum() >= 0 && (bigint is null || bigint2.compareTo(bigint) < 0)) {
            return bigint2;
        }
        throw new java.lang.IllegalArgumentException("Value out of range");
    }

    public override java.math.Bigint[] Decode(java.math.Bigint bigint, byte[] bArr) throws java.io.IOException {
        if ((3 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr);
        if (p80f8c729Var.Count == 2) {
            java.math.Bigint bigintDecodeValue = decodeValue(bigint, p80f8c729Var, 0);
            java.math.Bigint bigintDecodeValue2 = decodeValue(bigint, p80f8c729Var, 1);
            if (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(encode(bigint, bigintDecodeValue, bigintDecodeValue2), bArr)) {
                java.math.Bigint[] bigintArr = new java.math.Bigint[2];
                bigintArr[0] = bigintDecodeValue;
                bigintArr[1] = bigintDecodeValue2;
                return bigintArr;
            }
        }
        throw new java.lang.IllegalArgumentException("Malformed signature");
    }

    protected java.math.Bigint DecodeValue(java.math.Bigint bigint, p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return checkValue(bigint, ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729Var.getobjectAt(i)).getValue());
    }

    public override byte[] Encode(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        encodeValue(bigint, pd6ccb7fcVar, bigint2);
        encodeValue(bigint, pd6ccb7fcVar, bigint3);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("26fb01c3327acfeb24e8c17b0eda53b44f577232ca449bf010193d296564ea"));
    }

    protected void EncodeValue(java.math.Bigint bigint, p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, java.math.Bigint bigint2) {
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(checkValue(bigint, bigint2)));
    }
}

