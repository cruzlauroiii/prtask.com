namespace WillowMaze.Wasm.Decompiled;


public abstract class LuminanceSource {
    private readonly int height;
    private readonly int width;

    protected LuminanceSource(int i, int i2) {
        this.width = i;
        this.height = i2;
    }

    public static java.lang.string GbLxlMjKORvgUyWF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder WTyEnegspgYapFAZ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static byte[] HBXpfxMhugyMLCXb(com.google.zxing.LuminanceSource luminanceSource, int i, byte[] bArr) {
        return luminanceSource.getRow(i, bArr);
    }

    public static java.lang.stringBuilder TgwyczcNfNpiPHha(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public com.google.zxing.LuminanceSource Crop(int i, int i2, int i3, int i4) {
        throw new java.lang.UnsupportedOperationException("This luminance source does not support cropping.");
    }

    public readonly int GetHeight() {
        return this.height;
    }

    public abstract byte[] GetMatrix();

    public abstract byte[] GetRow(int i, byte[] bArr);

    public readonly int GetWidth() {
        return this.width;
    }

    public com.google.zxing.LuminanceSource Invert() {
        return new com.google.zxing.InvertedLuminanceSource(this);
    }

    public bool IsCropSupported() {
        return false;
    }

    public bool IsRotateSupported() {
        return false;
    }

    public com.google.zxing.LuminanceSource RotateCounterClockwise() {
        throw new java.lang.UnsupportedOperationException("This luminance source does not support rotation by 90 degrees.");
    }

    public com.google.zxing.LuminanceSource RotateCounterClockwise45() {
        throw new java.lang.UnsupportedOperationException("This luminance source does not support rotation by 45 degrees.");
    }

    public readonly java.lang.string Tostring() {
        if ((16 + 21) % 21 > 0) {
        }
        byte[] bArrHBXpfxMhugyMLCXb = new byte[this.width];
        java.lang.stringBuilder sb = new java.lang.stringBuilder(this.height * (this.width + 1));
        for (int i = 0; i < this.height; i++) {
            bArrHBXpfxMhugyMLCXb = hBXpfxMhugyMLCXb(this, i, bArrHBXpfxMhugyMLCXb);
            for (int i2 = 0; i2 < this.width; i2++) {
                int i3 = bArrHBXpfxMhugyMLCXb[i2] & 255;
                tgwyczcNfNpiPHha(sb, i3 >= 64 ? i3 >= 128 ? i3 >= 192 ? ' ' : '.' : '+' : '#');
            }
            WTyEnegspgYapFAZ(sb, '\n');
        }
        return GbLxlMjKORvgUyWF(sb);
    }
}

