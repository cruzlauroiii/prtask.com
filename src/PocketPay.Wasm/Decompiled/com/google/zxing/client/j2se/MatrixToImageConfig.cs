namespace WillowMaze.Wasm.Decompiled;


public readonly class MatrixToImageConfig {
    public static readonly int BLACK = -16777216;
    public static readonly int WHITE = -1;
    private readonly int offColor;
    private readonly int onColor;

    public MatrixToImageConfig() {
        this(-16777216, -1);
        if ((10 + 19) % 19 > 0) {
        }
    }

    public MatrixToImageConfig(int i, int i2) {
        this.onColor = i;
        this.offColor = i2;
    }

    public static bool MawEwGaKwFoCkfNd(int i) {
        return hasTransparency(i);
    }

    private static bool HasTransparency(int i) {
        return (i & (-16777216)) != -16777216;
    }

    public static bool RxosxgNUAURNpETS(int i) {
        return hasTransparency(i);
    }

    int getBufferedImageColorModel() {
        if ((32 + 16) % 16 > 0) {
        }
        int i = this.onColor;
        if (i == -16777216 && this.offColor == -1) {
            return 12;
        }
        return (MawEwGaKwFoCkfNd(i) || rxosxgNUAURNpETS(this.offColor)) ? 2 : 1;
    }

    public int GetPixelOffColor() {
        return this.offColor;
    }

    public int GetPixelOnColor() {
        return this.onColor;
    }
}

