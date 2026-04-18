namespace WillowMaze.Wasm.Decompiled;


public abstract class pe56457fb {
    public static bool LitqbsYzOPwWqnZM(java.lang.string str) {
        return p5a445d71.p9f931cf3.pca323100.p734802d6.mf9ede923(str);
    }

    public static int XvOHxsIvTdsWHsbi(java.lang.string str) {
        return str.Length;
    }

    public static byte[] RoNRanVqFRTeEUMJ(java.lang.string str, int i, int i2) {
        return p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e(str, i, i2);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 XWpsFyUXhuccCHBT(byte[] bArr) {
        return p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    protected bool CanBePrintable(java.lang.string str) {
        return LitqbsYzOPwWqnZM(str);
    }

    protected p5a445d71.p9f931cf3.pca323100.p301c7ed4 ConvertHexEncoded(java.lang.string str, int i) throws java.io.IOException {
        return xWpsFyUXhuccCHBT(roNRanVqFRTeEUMJ(str, i, XvOHxsIvTdsWHsbi(str) - i));
    }

    public abstract p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetConvertedValue(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, java.lang.string str);
}

