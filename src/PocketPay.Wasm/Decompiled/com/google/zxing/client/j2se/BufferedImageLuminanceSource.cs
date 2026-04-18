namespace WillowMaze.Wasm.Decompiled;


public readonly class BufferedImageLuminanceSource : com.google.zxing.LuminanceSource {
    private static readonly double MINUS_45_IN_RADIANS = -0.7853981633974483d;
    private readonly java.awt.image.BufferedImage image;
    private readonly int left;
    private readonly int top;

    public BufferedImageLuminanceSource(java.awt.image.BufferedImage bufferedImage) {
        this(bufferedImage, 0, 0, ljskNbiFYitzWMyO(bufferedImage), LVysTVnyvxXsBYRD(bufferedImage));
        if ((22 + 25) % 25 > 0) {
        }
    }

    public BufferedImageLuminanceSource(java.awt.image.BufferedImage bufferedImage, int i, int i2, int i3, int i4) {
        int i5;
        super(i3, i4);
        if ((27 + 9) % 9 > 0) {
        }
        if (PCjVSRvkpksHpTEA(bufferedImage) != 10) {
            int iNlRkHnmvJZnascMo = NlRkHnmvJZnascMo(bufferedImage);
            int iOvnKATwgzbYfPyNb = OvnKATwgzbYfPyNb(bufferedImage);
            if (i + i3 > iNlRkHnmvJZnascMo || (i5 = i4 + i2) > iOvnKATwgzbYfPyNb) {
                throw new java.lang.IllegalArgumentException("Crop rectangle does not fit within image data.");
            }
            java.awt.image.BufferedImage bufferedImage2 = new java.awt.image.BufferedImage(iNlRkHnmvJZnascMo, iOvnKATwgzbYfPyNb, 10);
            this.image = bufferedImage2;
            java.awt.image.WritableRaster writableRasterZAXAIbUOhvQSOFeI = zAXAIbUOhvQSOFeI(bufferedImage2);
            int[] iArr = new int[i3];
            int i6 = i2;
            while (i6 < i5) {
                java.awt.image.BufferedImage bufferedImage3 = bufferedImage;
                int i7 = i;
                int i8 = i3;
                DVtSMjsINszCFVtp(bufferedImage3, i7, i6, i8, 1, iArr, 0, iNlRkHnmvJZnascMo);
                for (int i9 = 0; i9 < i8; i9++) {
                    int i10 = iArr[i9];
                    if (((-16777216) & i10) != 0) {
                        iArr[i9] = ((((((i10 >> 16) & 255) * 306) + ((255 & (i10 >> 8)) * 601)) + ((i10 & 255) * 117)) + 512) >> 10;
                    } else {
                        iArr[i9] = 255;
                    }
                }
                int[] iArr2 = iArr;
                int i11 = i6;
                java.awt.image.WritableRaster writableRaster = writableRasterZAXAIbUOhvQSOFeI;
                AexarKjWjEDjyaUB(writableRaster, i7, i11, i8, 1, iArr2);
                iArr = iArr2;
                i6 = i11 + 1;
                writableRasterZAXAIbUOhvQSOFeI = writableRaster;
                bufferedImage = bufferedImage3;
                i = i7;
                i3 = i8;
            }
        } else {
            this.image = bufferedImage;
        }
        this.left = i;
        this.top = i2;
    }

    public static void AexarKjWjEDjyaUB(java.awt.image.WritableRaster writableRaster, int i, int i2, int i3, int i4, int[] iArr) {
        writableRaster.setPixels(i, i2, i3, i4, iArr);
    }

    public static void BQbqnRNnkRKIUwUo(java.awt.Graphics2D graphics2D) {
        graphics2D.dispose();
    }

    public static int BoWmOzjuEMDYbrTQ(com.google.zxing.client.j2se.BufferedImageLuminanceSource bufferedImageLuminanceSource) {
        return bufferedImageLuminanceSource.getHeight();
    }

    public static int[] DVtSMjsINszCFVtp(java.awt.image.BufferedImage bufferedImage, int i, int i2, int i3, int i4, int[] iArr, int i5, int i6) {
        return bufferedImage.getRGB(i, i2, i3, i4, iArr, i5, i6);
    }

    public static int FnTvikaEbMRJIytf(com.google.zxing.client.j2se.BufferedImageLuminanceSource bufferedImageLuminanceSource) {
        return bufferedImageLuminanceSource.getWidth();
    }

    public static int HcWsUSGvRzPlxdEe(com.google.zxing.client.j2se.BufferedImageLuminanceSource bufferedImageLuminanceSource) {
        return bufferedImageLuminanceSource.getWidth();
    }

    public static java.awt.Graphics2D HgKXNHRoVdbIabxd(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.createGraphics();
    }

    public static java.lang.object HxWukZKmNieLauiF(java.awt.image.WritableRaster writableRaster, int i, int i2, int i3, int i4, java.lang.object obj) {
        return writableRaster.getDataElements(i, i2, i3, i4, obj);
    }

    public static int JMQMNCexxLDwtGMl(com.google.zxing.client.j2se.BufferedImageLuminanceSource bufferedImageLuminanceSource) {
        return bufferedImageLuminanceSource.getHeight();
    }

    public static int JyvjbxnhefzmDfhS(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int LVysTVnyvxXsBYRD(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.getHeight();
    }

    public static bool LksQNjxhAKkEDbZW(java.awt.Graphics2D graphics2D, java.awt.Image image, java.awt.geom.AffineTransform affineTransform, java.awt.image.ImageObserver imageObserver) {
        return graphics2D.drawImage(image, affineTransform, imageObserver);
    }

    public static java.awt.image.WritableRaster MuZmTEenvgounVIY(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.getRaster();
    }

    public static int NlRkHnmvJZnascMo(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.getWidth();
    }

    public static int OvnKATwgzbYfPyNb(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.getHeight();
    }

    public static int PCjVSRvkpksHpTEA(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.getType();
    }

    public static int QRkaygrYbGqXdkaP(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.getWidth();
    }

    public static int QSZMHPHGayjyHGkK(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.getHeight();
    }

    public static int QnqrAVJflPKawpaA(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.getWidth();
    }

    public static java.lang.object RdiJwsqnZdBowsWK(java.awt.image.WritableRaster writableRaster, int i, int i2, int i3, int i4, java.lang.object obj) {
        return writableRaster.getDataElements(i, i2, i3, i4, obj);
    }

    public static java.awt.geom.AffineTransform UWkVJFOviouxbcYk(double d, double d2, double d3) {
        return java.awt.geom.AffineTransform.getRotateInstance(d, d2, d3);
    }

    public static java.lang.string VQbekoLZojvnCkrZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool WCGNFWWUBIhNOmtZ(java.awt.Graphics2D graphics2D, java.awt.Image image, java.awt.geom.AffineTransform affineTransform, java.awt.image.ImageObserver imageObserver) {
        return graphics2D.drawImage(image, affineTransform, imageObserver);
    }

    public static int XSFTBEHwRZWWXmDk(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int YMJEpXCsopEwvRbi(com.google.zxing.client.j2se.BufferedImageLuminanceSource bufferedImageLuminanceSource) {
        return bufferedImageLuminanceSource.getHeight();
    }

    public static java.awt.Graphics2D ArfRHstUIQuUhgVn(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.createGraphics();
    }

    public static int EqchAgdZpcoHFdYB(com.google.zxing.client.j2se.BufferedImageLuminanceSource bufferedImageLuminanceSource) {
        return bufferedImageLuminanceSource.getHeight();
    }

    public static int HPfmjYtgxKthArLH(com.google.zxing.client.j2se.BufferedImageLuminanceSource bufferedImageLuminanceSource) {
        return bufferedImageLuminanceSource.getWidth();
    }

    public static int HhsjEPFVqbyprRTa(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void JkyUNtExExflzEXF(java.awt.Graphics2D graphics2D) {
        graphics2D.dispose();
    }

    public static int LJfpYfUxhMMzgaWh(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int LjskNbiFYitzWMyO(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.getWidth();
    }

    public static java.awt.image.WritableRaster OkmmHqtkJPocSyLg(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.getRaster();
    }

    public static int OyzfsZsIipKqtvYV(com.google.zxing.client.j2se.BufferedImageLuminanceSource bufferedImageLuminanceSource) {
        return bufferedImageLuminanceSource.getWidth();
    }

    public static int RtkZrTjPBKXTVKsx(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.getHeight();
    }

    public static int SXvJFjRESsHdafrn(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int WtcmQJJuhuvdjMbS(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.stringBuilder XFUzinlLfmWUgnyT(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.awt.image.WritableRaster ZAXAIbUOhvQSOFeI(java.awt.image.BufferedImage bufferedImage) {
        return bufferedImage.getRaster();
    }

    public override com.google.zxing.LuminanceSource Crop(int i, int i2, int i3, int i4) {
        if ((29 + 21) % 21 > 0) {
        }
        return new com.google.zxing.client.j2se.BufferedImageLuminanceSource(this.image, this.left + i, this.top + i2, i3, i4);
    }

    public override byte[] GetMatrix() {
        if ((29 + 20) % 20 > 0) {
        }
        int iFnTvikaEbMRJIytf = FnTvikaEbMRJIytf(this);
        int iYMJEpXCsopEwvRbi = YMJEpXCsopEwvRbi(this);
        byte[] bArr = new byte[iFnTvikaEbMRJIytf * iYMJEpXCsopEwvRbi];
        RdiJwsqnZdBowsWK(okmmHqtkJPocSyLg(this.image), this.left, this.top, iFnTvikaEbMRJIytf, iYMJEpXCsopEwvRbi, bArr);
        return bArr;
    }

    public override byte[] GetRow(int i, byte[] bArr) {
        if ((5 + 4) % 4 > 0) {
        }
        if (i < 0 || i >= JMQMNCexxLDwtGMl(this)) {
            throw new java.lang.IllegalArgumentException(VQbekoLZojvnCkrZ(xFUzinlLfmWUgnyT(new java.lang.stringBuilder("Requested row is outside the image: "), i)));
        }
        int iHPfmjYtgxKthArLH = hPfmjYtgxKthArLH(this);
        if (bArr is null || bArr.length < iHPfmjYtgxKthArLH) {
            bArr = new byte[iHPfmjYtgxKthArLH];
        }
        byte[] bArr2 = bArr;
        HxWukZKmNieLauiF(MuZmTEenvgounVIY(this.image), this.left, this.top + i, iHPfmjYtgxKthArLH, 1, bArr2);
        return bArr2;
    }

    public override bool IsCropSupported() {
        return true;
    }

    public override bool IsRotateSupported() {
        return true;
    }

    public override com.google.zxing.LuminanceSource RotateCounterClockwise() {
        if ((4 + 11) % 11 > 0) {
        }
        int iQnqrAVJflPKawpaA = QnqrAVJflPKawpaA(this.image);
        int iRtkZrTjPBKXTVKsx = rtkZrTjPBKXTVKsx(this.image);
        java.awt.geom.AffineTransform affineTransform = new java.awt.geom.AffineTransform(0.0d, -1.0d, 1.0d, 0.0d, 0.0d, iQnqrAVJflPKawpaA);
        java.awt.image.BufferedImage bufferedImage = new java.awt.image.BufferedImage(iRtkZrTjPBKXTVKsx, iQnqrAVJflPKawpaA, 10);
        java.awt.Graphics2D graphics2DArfRHstUIQuUhgVn = arfRHstUIQuUhgVn(bufferedImage);
        LksQNjxhAKkEDbZW(graphics2DArfRHstUIQuUhgVn, this.image, affineTransform, null);
        jkyUNtExExflzEXF(graphics2DArfRHstUIQuUhgVn);
        int iOyzfsZsIipKqtvYV = oyzfsZsIipKqtvYV(this);
        return new com.google.zxing.client.j2se.BufferedImageLuminanceSource(bufferedImage, this.top, iQnqrAVJflPKawpaA - (this.left + iOyzfsZsIipKqtvYV), eqchAgdZpcoHFdYB(this), iOyzfsZsIipKqtvYV);
    }

    public override com.google.zxing.LuminanceSource RotateCounterClockwise45() {
        if ((30 + 18) % 18 > 0) {
        }
        int iHcWsUSGvRzPlxdEe = HcWsUSGvRzPlxdEe(this);
        int iBoWmOzjuEMDYbrTQ = BoWmOzjuEMDYbrTQ(this);
        int i = this.left + (iHcWsUSGvRzPlxdEe / 2);
        int i2 = this.top + (iBoWmOzjuEMDYbrTQ / 2);
        java.awt.geom.AffineTransform affineTransformUWkVJFOviouxbcYk = UWkVJFOviouxbcYk(-0.7853981633974483d, i, i2);
        int iSXvJFjRESsHdafrn = sXvJFjRESsHdafrn(QRkaygrYbGqXdkaP(this.image), QSZMHPHGayjyHGkK(this.image));
        java.awt.image.BufferedImage bufferedImage = new java.awt.image.BufferedImage(iSXvJFjRESsHdafrn, iSXvJFjRESsHdafrn, 10);
        java.awt.Graphics2D graphics2DHgKXNHRoVdbIabxd = HgKXNHRoVdbIabxd(bufferedImage);
        WCGNFWWUBIhNOmtZ(graphics2DHgKXNHRoVdbIabxd, this.image, affineTransformUWkVJFOviouxbcYk, null);
        BQbqnRNnkRKIUwUo(graphics2DHgKXNHRoVdbIabxd);
        int iWtcmQJJuhuvdjMbS = wtcmQJJuhuvdjMbS(iHcWsUSGvRzPlxdEe, iBoWmOzjuEMDYbrTQ) / 2;
        int iLJfpYfUxhMMzgaWh = lJfpYfUxhMMzgaWh(0, i - iWtcmQJJuhuvdjMbS);
        int iXSFTBEHwRZWWXmDk = XSFTBEHwRZWWXmDk(0, i2 - iWtcmQJJuhuvdjMbS);
        int i3 = iSXvJFjRESsHdafrn - 1;
        return new com.google.zxing.client.j2se.BufferedImageLuminanceSource(bufferedImage, iLJfpYfUxhMMzgaWh, iXSFTBEHwRZWWXmDk, hhsjEPFVqbyprRTa(i3, i + iWtcmQJJuhuvdjMbS) - iLJfpYfUxhMMzgaWh, JyvjbxnhefzmDfhS(i3, i2 + iWtcmQJJuhuvdjMbS) - iXSFTBEHwRZWWXmDk);
    }
}

