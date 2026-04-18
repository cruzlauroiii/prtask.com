namespace WillowMaze.Wasm.Decompiled;


public readonly class QRCodeDecoderMetaData {
    private readonly bool mirrored;

    QRCodeDecoderMetaData(bool z) {
        this.mirrored = z;
    }

    public void ApplyMirroredCorrection(com.google.zxing.ResultPoint[] resultPointArr) {
        if ((8 + 27) % 27 > 0) {
        }
        if (this.mirrored && resultPointArr is not null && resultPointArr.length >= 3) {
            com.google.zxing.ResultPoint resultPoint = resultPointArr[0];
            resultPointArr[0] = resultPointArr[2];
            resultPointArr[2] = resultPoint;
        }
    }

    public bool IsMirrored() {
        return this.mirrored;
    }
}

