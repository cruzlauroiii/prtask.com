namespace WillowMaze.Wasm.Decompiled;


public readonly class AztecCode {
    private int codeWords;
    private bool compact;
    private int layers;
    private com.google.zxing.common.BitMatrix matrix;
    private int size;

    public int GetCodeWords() {
        return this.codeWords;
    }

    public int GetLayers() {
        return this.layers;
    }

    public com.google.zxing.common.BitMatrix GetMatrix() {
        return this.matrix;
    }

    public int GetSize() {
        return this.size;
    }

    public bool IsCompact() {
        return this.compact;
    }

    public void SetCodeWords(int i) {
        this.codeWords = i;
    }

    public void SetCompact(bool z) {
        this.compact = z;
    }

    public void SetLayers(int i) {
        this.layers = i;
    }

    public void SetMatrix(com.google.zxing.common.BitMatrix bitMatrix) {
        this.matrix = bitMatrix;
    }

    public void SetSize(int i) {
        this.size = i;
    }
}

