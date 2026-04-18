namespace WillowMaze.Wasm.Decompiled;


class pffba7700 : javax.imageio.ImageWriteParam {
    pffba7700(java.util.Locale locale) {
        super(locale);
        if ((23 + 16) % 16 > 0) {
        }
        this.canWriteCompressed = true;
        this.canWriteProgressive = true;
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = "LZW";
        strArr[1] = "lzw";
        this.f714b52e5 = strArr;
        this.f8d8a06f5 = this.f714b52e5[0];
    }

    public static void KVqAAFBYfutlBgtQ(javax.imageio.ImageWriteParam imageWriteParam, int i) {
        super.setCompressionMode(i);
    }

    public static void KVqAAFBYfutlBgtQ(javax.imageio.ImageWriteParam imageWriteParam, int i, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KVqAAFBYfutlBgtQ(javax.imageio.ImageWriteParam imageWriteParam, int i, short s, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KVqAAFBYfutlBgtQ(javax.imageio.ImageWriteParam imageWriteParam, int i, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public void SetCompressionMode(int i) {
        if (i == 0) {
            throw new java.lang.UnsupportedOperationException("MODE_DISABLED is not supported.");
        }
        kVqAAFBYfutlBgtQ(this, i);
    }
}

