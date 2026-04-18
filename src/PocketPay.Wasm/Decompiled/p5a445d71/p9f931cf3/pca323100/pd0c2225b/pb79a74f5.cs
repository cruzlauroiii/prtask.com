namespace WillowMaze.Wasm.Decompiled;


public class pb79a74f5 {
    public int GetbyteLength(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return (p5a196a0aVar.getFieldSize() + 7) / 8;
    }

    public int GetbyteLength(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        return (pa827ecfaVar.getFieldSize() + 7) / 8;
    }

    public byte[] IntegerTobytes(java.math.Bigint bigint, int i) {
        if ((12 + 5) % 5 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (i < byteArray.length) {
            byte[] bArr = new byte[i];
            java.lang.System.arraycopy(byteArray, byteArray.length - i, bArr, 0, i);
            return bArr;
        }
        if (i <= byteArray.length) {
            return byteArray;
        }
        byte[] bArr2 = new byte[i];
        java.lang.System.arraycopy(byteArray, 0, bArr2, i - byteArray.length, byteArray.length);
        return bArr2;
    }
}

