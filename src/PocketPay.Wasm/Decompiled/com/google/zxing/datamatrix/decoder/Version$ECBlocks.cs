namespace WillowMaze.Wasm.Decompiled;


readonly class Version$ECBlocks {
    private readonly com.google.zxing.datamatrix.decoder.Version$ECB[] ecBlocks;
    private readonly int ecCodewords;

    private Version$ECBlocks(int i, com.google.zxing.datamatrix.decoder.Version$ECB version$ECB) {
        this.ecCodewords = i;
        com.google.zxing.datamatrix.decoder.Version$ECB[] version$ECBArr = new com.google.zxing.datamatrix.decoder.Version$ECB[1];
        version$ECBArr[0] = version$ECB;
        this.ecBlocks = version$ECBArr;
    }

    Version$ECBlocks(int i, com.google.zxing.datamatrix.decoder.Version$ECB version$ECB, com.google.zxing.datamatrix.decoder.Version$1 version$1) {
        this(i, version$ECB);
    }

    private Version$ECBlocks(int i, com.google.zxing.datamatrix.decoder.Version$ECB version$ECB, com.google.zxing.datamatrix.decoder.Version$ECB version$ECB2) {
        this.ecCodewords = i;
        com.google.zxing.datamatrix.decoder.Version$ECB[] version$ECBArr = new com.google.zxing.datamatrix.decoder.Version$ECB[2];
        version$ECBArr[0] = version$ECB;
        version$ECBArr[1] = version$ECB2;
        this.ecBlocks = version$ECBArr;
    }

    Version$ECBlocks(int i, com.google.zxing.datamatrix.decoder.Version$ECB version$ECB, com.google.zxing.datamatrix.decoder.Version$ECB version$ECB2, com.google.zxing.datamatrix.decoder.Version$1 version$1) {
        this(i, version$ECB, version$ECB2);
    }

    com.google.zxing.datamatrix.decoder.Version$ECB[] getECBlocks() {
        return this.ecBlocks;
    }

    int getECCodewords() {
        return this.ecCodewords;
    }
}

