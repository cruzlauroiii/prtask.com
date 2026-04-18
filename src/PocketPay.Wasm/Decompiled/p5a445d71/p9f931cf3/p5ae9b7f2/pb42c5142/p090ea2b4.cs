namespace WillowMaze.Wasm.Decompiled;


public class p090ea2b4 : p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 {
    public static readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p090ea2b4 f17f350a0 = null;
    public static readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p090ea2b4 f434db8a2 = null;
    public static readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p090ea2b4 f76425f17 = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p090ea2b4();
    public static readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p090ea2b4 fbeaddfb9 = null;
    public static readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p090ea2b4 fee6ea2c5 = null;

    private void M298e9e2e(java.math.Bigint bigint, java.math.Bigint bigint2, byte[] bArr, int i, int i2) {
        byte[] byteArray = checkValue(bigint, bigint2).tobyteArray();
        int iMax = java.lang.Math.max(0, byteArray.length - i2);
        int length = byteArray.length - iMax;
        int i3 = (i2 - length) + i;
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, i, i3, (byte) 0);
        java.lang.System.arraycopy(byteArray, iMax, bArr, i3, length);
    }

    protected java.math.Bigint CheckValue(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if (bigint2.signum() >= 0 && bigint2.compareTo(bigint) < 0) {
            return bigint2;
        }
        throw new java.lang.IllegalArgumentException("Value out of range");
    }

    public override java.math.Bigint[] Decode(java.math.Bigint bigint, byte[] bArr) {
        if ((21 + 29) % 29 > 0) {
        }
        int iM0894479c = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m0894479c(bigint);
        if (bArr.length != iM0894479c * 2) {
            throw new java.lang.IllegalArgumentException("Encoding has incorrect length");
        }
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        bigintArr[0] = decodeValue(bigint, bArr, 0, iM0894479c);
        bigintArr[1] = decodeValue(bigint, bArr, iM0894479c, iM0894479c);
        return bigintArr;
    }

    protected java.math.Bigint DecodeValue(java.math.Bigint bigint, byte[] bArr, int i, int i2) {
        return checkValue(bigint, new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i, i2 + i)));
    }

    public override byte[] Encode(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        if ((5 + 24) % 24 > 0) {
        }
        int iM0894479c = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m0894479c(bigint);
        byte[] bArr = new byte[iM0894479c * 2];
        m298e9e2e(bigint, bigint2, bArr, 0, iM0894479c);
        m298e9e2e(bigint, bigint3, bArr, iM0894479c, iM0894479c);
        return bArr;
    }
}

