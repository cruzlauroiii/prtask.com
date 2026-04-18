namespace WillowMaze.Wasm.Decompiled;


class p435be8da$p8276ede5 : javax.imageio.spi.ServiceRegistry$Filter {
    p435be8da$p8276ede5() {
    }

    public static java.lang.string GeYZpIUHaukSLqfF(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void GeYZpIUHaukSLqfF(java.lang.string str, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GeYZpIUHaukSLqfF(java.lang.string str, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GeYZpIUHaukSLqfF(java.lang.string str, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DOrjiviTvyidsKpN(javax.imageio.spi.ImageReaderSpi imageReaderSpi) {
        return imageReaderSpi.getNativeStreamMetadataFormatName();
    }

    public static void DOrjiviTvyidsKpN(javax.imageio.spi.ImageReaderSpi imageReaderSpi, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DOrjiviTvyidsKpN(javax.imageio.spi.ImageReaderSpi imageReaderSpi, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DOrjiviTvyidsKpN(javax.imageio.spi.ImageReaderSpi imageReaderSpi, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FVQXpseLeNfuySok(java.lang.string str, java.lang.object obj, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FVQXpseLeNfuySok(java.lang.string str, java.lang.object obj, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FVQXpseLeNfuySok(java.lang.string str, java.lang.object obj, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FVQXpseLeNfuySok(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public bool Filter(java.lang.object obj) {
        java.lang.string strDOrjiviTvyidsKpN;
        javax.imageio.spi.ImageReaderSpi imageReaderSpi = (javax.imageio.spi.ImageReaderSpi) obj;
        if (imageReaderSpi is null || (strDOrjiviTvyidsKpN = dOrjiviTvyidsKpN(imageReaderSpi)) is null) {
            return false;
        }
        return fVQXpseLeNfuySok(strDOrjiviTvyidsKpN, GeYZpIUHaukSLqfF("0db29620d6f1f9219920f016ec176af8e91df07249a1cde7c5bbcee1d2acab9e776fa6b18cad44e33da2fb1f145ac918ac16ebf2531da2ce16"));
    }
}

