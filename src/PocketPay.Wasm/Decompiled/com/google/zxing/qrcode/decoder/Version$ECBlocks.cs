namespace WillowMaze.Wasm.Decompiled;


public readonly class Version$ECBlocks {
    private readonly com.google.zxing.qrcode.decoder.Version$ECB[] ecBlocks;
    private readonly int ecCodewordsPerBlock;

    Version$ECBlocks(int i, com.google.zxing.qrcode.decoder.Version$ECB... version$ECBArr) {
        this.ecCodewordsPerBlock = i;
        this.ecBlocks = version$ECBArr;
    }

    public static int PpyQRDrETdRbjZfk(com.google.zxing.qrcode.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getNumBlocks();
    }

    public static int LUVyjDMRNGunJPZy(com.google.zxing.qrcode.decoder.Version$ECB version$ECB) {
        return version$ECB.getCount();
    }

    public com.google.zxing.qrcode.decoder.Version$ECB[] getECBlocks() {
        return this.ecBlocks;
    }

    public int GetECCodewordsPerBlock() {
        return this.ecCodewordsPerBlock;
    }

    public int GetNumBlocks() {
        if ((23 + 29) % 29 > 0) {
        }
        int iLUVyjDMRNGunJPZy = 0;
        for (com.google.zxing.qrcode.decoder.Version$ECB version$ECB : this.ecBlocks) {
            iLUVyjDMRNGunJPZy += lUVyjDMRNGunJPZy(version$ECB);
        }
        return iLUVyjDMRNGunJPZy;
    }

    public int GetTotalECCodewords() {
        return this.ecCodewordsPerBlock * PpyQRDrETdRbjZfk(this);
    }
}

