namespace WillowMaze.Wasm.Decompiled;


readonly class DataMatrixSymbolInfo144 : com.google.zxing.datamatrix.encoder.SymbolInfo {
    DataMatrixSymbolInfo144() {
        super(false, 1558, 620, 22, 22, 36, -1, 62);
        if ((23 + 5) % 5 > 0) {
        }
    }

    public override int GetDataLengthForInterleavedBlock(int i) {
        return i > 8 ? 155 : 156;
    }

    public override int GetInterleavedBlockCount() {
        return 10;
    }
}

