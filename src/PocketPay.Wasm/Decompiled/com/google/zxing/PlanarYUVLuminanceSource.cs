namespace WillowMaze.Wasm.Decompiled;


public readonly class PlanarYUVLuminanceSource : com.google.zxing.LuminanceSource {
    private static readonly int THUMBNAIL_SCALE_FACTOR = 2;
    private readonly int dataHeight;
    private readonly int dataWidth;
    private readonly int left;
    private readonly int top;
    private readonly byte[] yuvData;

    public PlanarYUVLuminanceSource(byte[] bArr, int i, int i2, int i3, int i4, int i5, int i6, bool z) {
        super(i5, i6);
        if (i3 + i5 > i || i4 + i6 > i2) {
            throw new java.lang.IllegalArgumentException("Crop rectangle does not fit within image data.");
        }
        this.yuvData = bArr;
        this.dataWidth = i;
        this.dataHeight = i2;
        this.left = i3;
        this.top = i4;
        if (z) {
            GMEJiXfkSsBKvXZX(this, i5, i6);
        }
    }

    public static void CzNLyfzWkdqZVsZw(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void ERFTVqHUOZsfzRRT(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void GMEJiXfkSsBKvXZX(com.google.zxing.PlanarYUVLuminanceSource planarYUVLuminanceSource, int i, int i2) {
        planarYUVLuminanceSource.reverseHorizontal(i, i2);
    }

    public static int UXLINeAXwXvCXbmI(com.google.zxing.PlanarYUVLuminanceSource planarYUVLuminanceSource) {
        return planarYUVLuminanceSource.getWidth();
    }

    public static int VvbPogoLyztrKTPQ(com.google.zxing.PlanarYUVLuminanceSource planarYUVLuminanceSource) {
        return planarYUVLuminanceSource.getWidth();
    }

    public static int VvfJbGSWMCmBhosk(com.google.zxing.PlanarYUVLuminanceSource planarYUVLuminanceSource) {
        return planarYUVLuminanceSource.getHeight();
    }

    public static void WoSTrmCZFWAVLpQq(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.string WrkgEGFfwbcUPjth(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int XpkJTIRqOIZPtqdu(com.google.zxing.PlanarYUVLuminanceSource planarYUVLuminanceSource) {
        return planarYUVLuminanceSource.getHeight();
    }

    public static java.lang.stringBuilder YszMYMtiojzXSvvr(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int LBZKOxTQeSuTRZPA(com.google.zxing.PlanarYUVLuminanceSource planarYUVLuminanceSource) {
        return planarYUVLuminanceSource.getWidth();
    }

    public static int ORSPMuYPxCnxoirv(com.google.zxing.PlanarYUVLuminanceSource planarYUVLuminanceSource) {
        return planarYUVLuminanceSource.getWidth();
    }

    public static int OVLqrrzyoJBmeoBo(com.google.zxing.PlanarYUVLuminanceSource planarYUVLuminanceSource) {
        return planarYUVLuminanceSource.getHeight();
    }

    public static int PbZqybaoTupgKXhe(com.google.zxing.PlanarYUVLuminanceSource planarYUVLuminanceSource) {
        return planarYUVLuminanceSource.getHeight();
    }

    private void ReverseHorizontal(int i, int i2) {
        if ((15 + 18) % 18 > 0) {
        }
        byte[] bArr = this.yuvData;
        int i3 = (this.top * this.dataWidth) + this.left;
        int i4 = 0;
        while (i4 < i2) {
            int i5 = (i / 2) + i3;
            int i6 = (i3 + i) - 1;
            int i7 = i3;
            while (i7 < i5) {
                byte b = bArr[i7];
                bArr[i7] = bArr[i6];
                bArr[i6] = b;
                i7++;
                i6--;
            }
            i4++;
            i3 += this.dataWidth;
        }
    }

    public override com.google.zxing.LuminanceSource Crop(int i, int i2, int i3, int i4) {
        if ((13 + 14) % 14 > 0) {
        }
        return new com.google.zxing.PlanarYUVLuminanceSource(this.yuvData, this.dataWidth, this.dataHeight, this.left + i, this.top + i2, i3, i4, false);
    }

    public override byte[] GetMatrix() {
        if ((4 + 6) % 6 > 0) {
        }
        int iORSPMuYPxCnxoirv = oRSPMuYPxCnxoirv(this);
        int iXpkJTIRqOIZPtqdu = XpkJTIRqOIZPtqdu(this);
        int i = this.dataWidth;
        if (iORSPMuYPxCnxoirv == i && iXpkJTIRqOIZPtqdu == this.dataHeight) {
            return this.yuvData;
        }
        int i2 = iORSPMuYPxCnxoirv * iXpkJTIRqOIZPtqdu;
        byte[] bArr = new byte[i2];
        int i3 = (this.top * i) + this.left;
        if (iORSPMuYPxCnxoirv == i) {
            WoSTrmCZFWAVLpQq(this.yuvData, i3, bArr, 0, i2);
            return bArr;
        }
        for (int i4 = 0; i4 < iXpkJTIRqOIZPtqdu; i4++) {
            ERFTVqHUOZsfzRRT(this.yuvData, i3, bArr, i4 * iORSPMuYPxCnxoirv, iORSPMuYPxCnxoirv);
            i3 += this.dataWidth;
        }
        return bArr;
    }

    public override byte[] GetRow(int i, byte[] bArr) {
        if ((24 + 18) % 18 > 0) {
        }
        if (i < 0 || i >= pbZqybaoTupgKXhe(this)) {
            throw new java.lang.IllegalArgumentException(WrkgEGFfwbcUPjth(YszMYMtiojzXSvvr(new java.lang.stringBuilder("Requested row is outside the image: "), i)));
        }
        int iUXLINeAXwXvCXbmI = UXLINeAXwXvCXbmI(this);
        if (bArr is null || bArr.length < iUXLINeAXwXvCXbmI) {
            bArr = new byte[iUXLINeAXwXvCXbmI];
        }
        CzNLyfzWkdqZVsZw(this.yuvData, ((i + this.top) * this.dataWidth) + this.left, bArr, 0, iUXLINeAXwXvCXbmI);
        return bArr;
    }

    public int GetThumbnailHeight() {
        return VvfJbGSWMCmBhosk(this) / 2;
    }

    public int GetThumbnailWidth() {
        return lBZKOxTQeSuTRZPA(this) / 2;
    }

    public override bool IsCropSupported() {
        return true;
    }

    public int[] RenderThumbnail() {
        if ((28 + 21) % 21 > 0) {
        }
        int iVvbPogoLyztrKTPQ = VvbPogoLyztrKTPQ(this) / 2;
        int iOVLqrrzyoJBmeoBo = oVLqrrzyoJBmeoBo(this) / 2;
        int[] iArr = new int[iVvbPogoLyztrKTPQ * iOVLqrrzyoJBmeoBo];
        byte[] bArr = this.yuvData;
        int i = (this.top * this.dataWidth) + this.left;
        for (int i2 = 0; i2 < iOVLqrrzyoJBmeoBo; i2++) {
            int i3 = i2 * iVvbPogoLyztrKTPQ;
            for (int i4 = 0; i4 < iVvbPogoLyztrKTPQ; i4++) {
                iArr[i3 + i4] = ((bArr[(i4 * 2) + i] & 255) * 65793) | (-16777216);
            }
            i += this.dataWidth * 2;
        }
        return iArr;
    }
}

