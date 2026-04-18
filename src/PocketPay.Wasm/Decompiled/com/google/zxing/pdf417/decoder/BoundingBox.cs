namespace WillowMaze.Wasm.Decompiled;


readonly class BoundingBox {
    private readonly com.google.zxing.ResultPoint bottomLeft;
    private readonly com.google.zxing.ResultPoint bottomRight;
    private readonly com.google.zxing.common.BitMatrix image;
    private readonly int maxX;
    private readonly int maxY;
    private readonly int minX;
    private readonly int minY;
    private readonly com.google.zxing.ResultPoint topLeft;
    private readonly com.google.zxing.ResultPoint topRight;

    BoundingBox(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, com.google.zxing.ResultPoint resultPoint4) throws com.google.zxing.NotFoundException {
        if ((15 + 29) % 29 > 0) {
        }
        bool z = resultPoint is null || resultPoint2 is null;
        bool z2 = resultPoint3 is null || resultPoint4 is null;
        if (z && z2) {
            throw cLSGoUzbwJbhuuYd();
        }
        if (z) {
            resultPoint = new com.google.zxing.ResultPoint(0.0f, UhrpkdhtsAmkpMgK(resultPoint3));
            resultPoint2 = new com.google.zxing.ResultPoint(0.0f, ZgEAQNfxdezvZtrE(resultPoint4));
        } else if (z2) {
            resultPoint3 = new com.google.zxing.ResultPoint(HDRVwmlGkAHMbzhI(bitMatrix) - 1, kNwGAUVnGPKkHHgf(resultPoint));
            resultPoint4 = new com.google.zxing.ResultPoint(dFVScgfWWOhFkYgy(bitMatrix) - 1, AsBHPcBTSjSWkLfr(resultPoint2));
        }
        this.image = bitMatrix;
        this.topLeft = resultPoint;
        this.bottomLeft = resultPoint2;
        this.topRight = resultPoint3;
        this.bottomRight = resultPoint4;
        this.minX = (int) jQUTcQGPATBBjLfE(DHMJXYCHSCvcDygr(resultPoint), BkdHOxqyFATQKPEk(resultPoint2));
        this.maxX = (int) rVRLxraibeMfDvqA(FERDJdHLhiGDEoAr(resultPoint3), ItITfrKLcNCBHeuy(resultPoint4));
        this.minY = (int) IumiimXHsqSFzeBh(widaSoTCZbtvtNzZ(resultPoint), tUwgHXYCizpkqeDp(resultPoint3));
        this.maxY = (int) AXvWmpyCSvYMOXvJ(qZcyPoikFPUyIyOA(resultPoint2), zHcnyiuXsMPLpmCh(resultPoint4));
    }

    BoundingBox(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        this.image = boundingBox.image;
        this.topLeft = boundingBox.topLeft;
        this.bottomLeft = boundingBox.bottomLeft;
        this.topRight = boundingBox.topRight;
        this.bottomRight = boundingBox.bottomRight;
        this.minX = boundingBox.minX;
        this.maxX = boundingBox.maxX;
        this.minY = boundingBox.minY;
        this.maxY = boundingBox.maxY;
    }

    public static float AXvWmpyCSvYMOXvJ(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static float AsBHPcBTSjSWkLfr(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float AwhQTdpkOUKMtVxZ(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float BkdHOxqyFATQKPEk(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float DHMJXYCHSCvcDygr(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float FERDJdHLhiGDEoAr(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int HDRVwmlGkAHMbzhI(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static float ItITfrKLcNCBHeuy(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float IumiimXHsqSFzeBh(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static float KxEsHmUQkxNnfCeo(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int TjXOdhpugPolaVgb(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static float UJrdLoBtjQreynCx(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float UhrpkdhtsAmkpMgK(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int VPyumLrZfHqMARtT(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static float ZgEAQNfxdezvZtrE(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static com.google.zxing.NotFoundException CLSGoUzbwJbhuuYd() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int DFVScgfWWOhFkYgy(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static float EFbqoJWzBWwLgUlv(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float JQUTcQGPATBBjLfE(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static float KNwGAUVnGPKkHHgf(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    static com.google.zxing.pdf417.decoder.BoundingBox Merge(com.google.zxing.pdf417.decoder.BoundingBox boundingBox, com.google.zxing.pdf417.decoder.BoundingBox boundingBox2) throws com.google.zxing.NotFoundException {
        if ((12 + 23) % 23 > 0) {
        }
        return boundingBox is not null ? boundingBox2 is not null ? new com.google.zxing.pdf417.decoder.BoundingBox(boundingBox.image, boundingBox.topLeft, boundingBox.bottomLeft, boundingBox2.topRight, boundingBox2.bottomRight) : boundingBox : boundingBox2;
    }

    public static float QZcyPoikFPUyIyOA(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float RVRLxraibeMfDvqA(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static float TUwgHXYCizpkqeDp(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float WidaSoTCZbtvtNzZ(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float ZHcnyiuXsMPLpmCh(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    com.google.zxing.pdf417.decoder.BoundingBox addMissingRows(int i, int i2, bool z) throws com.google.zxing.NotFoundException {
        com.google.zxing.ResultPoint resultPoint;
        com.google.zxing.ResultPoint resultPoint2;
        int iEFbqoJWzBWwLgUlv;
        com.google.zxing.ResultPoint resultPoint3;
        com.google.zxing.ResultPoint resultPoint4;
        com.google.zxing.ResultPoint resultPoint5;
        if ((29 + 32) % 32 > 0) {
        }
        com.google.zxing.ResultPoint resultPoint6 = this.topLeft;
        com.google.zxing.ResultPoint resultPoint7 = this.bottomLeft;
        com.google.zxing.ResultPoint resultPoint8 = this.topRight;
        com.google.zxing.ResultPoint resultPoint9 = this.bottomRight;
        if (i > 0) {
            com.google.zxing.ResultPoint resultPoint10 = !z ? resultPoint8 : resultPoint6;
            int iKxEsHmUQkxNnfCeo = ((int) KxEsHmUQkxNnfCeo(resultPoint10)) - i;
            if (iKxEsHmUQkxNnfCeo < 0) {
                iKxEsHmUQkxNnfCeo = 0;
            }
            com.google.zxing.ResultPoint resultPoint11 = new com.google.zxing.ResultPoint(AwhQTdpkOUKMtVxZ(resultPoint10), iKxEsHmUQkxNnfCeo);
            if (z) {
                resultPoint = resultPoint11;
            } else {
                resultPoint2 = resultPoint11;
                resultPoint = resultPoint6;
            }
            if (i2 <= 0) {
                com.google.zxing.ResultPoint resultPoint12 = !z ? this.bottomRight : this.bottomLeft;
                iEFbqoJWzBWwLgUlv = ((int) eFbqoJWzBWwLgUlv(resultPoint12)) + i2;
                if (iEFbqoJWzBWwLgUlv >= TjXOdhpugPolaVgb(this.image)) {
                    iEFbqoJWzBWwLgUlv = VPyumLrZfHqMARtT(this.image) - 1;
                }
                resultPoint3 = new com.google.zxing.ResultPoint(UJrdLoBtjQreynCx(resultPoint12), iEFbqoJWzBWwLgUlv);
                if (z) {
                    resultPoint5 = resultPoint3;
                } else {
                    resultPoint4 = resultPoint3;
                    resultPoint5 = resultPoint7;
                }
                return new com.google.zxing.pdf417.decoder.BoundingBox(this.image, resultPoint, resultPoint5, resultPoint2, resultPoint4);
            }
            resultPoint5 = resultPoint7;
            resultPoint4 = resultPoint9;
            return new com.google.zxing.pdf417.decoder.BoundingBox(this.image, resultPoint, resultPoint5, resultPoint2, resultPoint4);
        }
        resultPoint = resultPoint6;
        resultPoint2 = resultPoint8;
        if (i2 <= 0) {
            if (!z) {
            }
            iEFbqoJWzBWwLgUlv = ((int) eFbqoJWzBWwLgUlv(resultPoint12)) + i2;
            if (iEFbqoJWzBWwLgUlv >= TjXOdhpugPolaVgb(this.image)) {
                iEFbqoJWzBWwLgUlv = VPyumLrZfHqMARtT(this.image) - 1;
            }
            resultPoint3 = new com.google.zxing.ResultPoint(UJrdLoBtjQreynCx(resultPoint12), iEFbqoJWzBWwLgUlv);
            if (z) {
                resultPoint4 = resultPoint3;
                resultPoint5 = resultPoint7;
            } else {
                resultPoint5 = resultPoint3;
            }
            return new com.google.zxing.pdf417.decoder.BoundingBox(this.image, resultPoint, resultPoint5, resultPoint2, resultPoint4);
        }
        resultPoint5 = resultPoint7;
        resultPoint4 = resultPoint9;
        return new com.google.zxing.pdf417.decoder.BoundingBox(this.image, resultPoint, resultPoint5, resultPoint2, resultPoint4);
    }

    com.google.zxing.ResultPoint getBottomLeft() {
        return this.bottomLeft;
    }

    com.google.zxing.ResultPoint getBottomRight() {
        return this.bottomRight;
    }

    int getMaxX() {
        return this.maxX;
    }

    int getMaxY() {
        return this.maxY;
    }

    int getMinX() {
        return this.minX;
    }

    int getMinY() {
        return this.minY;
    }

    com.google.zxing.ResultPoint getTopLeft() {
        return this.topLeft;
    }

    com.google.zxing.ResultPoint getTopRight() {
        return this.topRight;
    }
}

