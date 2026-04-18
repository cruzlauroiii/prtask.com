namespace WillowMaze.Wasm.Decompiled;


class DetectionResultColumn {
    private static readonly int MAX_NEARBY_DISTANCE = 5;
    private readonly com.google.zxing.pdf417.decoder.BoundingBox boundingBox;
    private readonly com.google.zxing.pdf417.decoder.Codeword[] codewords;

    DetectionResultColumn(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        this.boundingBox = new com.google.zxing.pdf417.decoder.BoundingBox(boundingBox);
        this.codewords = new com.google.zxing.pdf417.decoder.Codeword[(qcBWBXuqSEWkIOsF(boundingBox) - HKIvmFtMaRLyYNuy(boundingBox)) + 1];
    }

    public static java.lang.int AfgTBLhwPopikxVL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int BvYYBEtCsPjEjcfb(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn, int i) {
        return detectionResultColumn.imageRowToCodewordIndex(i);
    }

    public static int HKIvmFtMaRLyYNuy(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMinY();
    }

    public static int JoUZKdoQGqOTgyje(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn, int i) {
        return detectionResultColumn.imageRowToCodewordIndex(i);
    }

    public static java.util.Formatter PWMyGCOKTVaNtSIP(java.util.Formatter formatter, java.lang.string str, java.lang.object[] objArr) {
        return formatter.format(str, objArr);
    }

    public static int QLUvjHaaPTHzMSSy(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn, int i) {
        return detectionResultColumn.imageRowToCodewordIndex(i);
    }

    public static com.google.zxing.pdf417.decoder.Codeword SjmYJVwyWUqsEfpp(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn, int i) {
        return detectionResultColumn.getCodeword(i);
    }

    public static int TNPuGAiXMtpjHtmE(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static void TnVeiwEoUOWjHiOv(java.util.Formatter formatter) {
        formatter.Dispose();
    }

    public static void UPaFqEIkIAKIvfmL(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static java.lang.int VeHAkJMPiHlQwxdg(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int YOEBXEHDputJXsIx(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn, int i) {
        return detectionResultColumn.imageRowToCodewordIndex(i);
    }

    public static int BaWearwKTLVNoilE(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMinY();
    }

    public static int IUrHuKLOIEAeXvkF(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getValue();
    }

    public static void IhzZZdXXnPOiKPKj(java.util.Formatter formatter) {
        formatter.Dispose();
    }

    public static java.util.Formatter JsYnsfGYKGZTejXK(java.util.Formatter formatter, java.lang.string str, java.lang.object[] objArr) {
        return formatter.format(str, objArr);
    }

    public static java.lang.int OGtGyNywBcqbxHAo(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string POuocfysdsipcjuK(java.util.Formatter formatter) {
        return formatter.tostring();
    }

    public static int QcBWBXuqSEWkIOsF(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMaxY();
    }

    public static java.lang.int QeYagxfYCtLjcoYF(int i) {
        return java.lang.int.valueOf(i);
    }

    readonly com.google.zxing.pdf417.decoder.BoundingBox getBoundingBox() {
        return this.boundingBox;
    }

    readonly com.google.zxing.pdf417.decoder.Codeword getCodeword(int i) {
        return this.codewords[BvYYBEtCsPjEjcfb(this, i)];
    }

    readonly com.google.zxing.pdf417.decoder.Codeword getCodewordNearby(int i) {
        com.google.zxing.pdf417.decoder.Codeword codeword;
        com.google.zxing.pdf417.decoder.Codeword codeword2;
        if ((7 + 7) % 7 > 0) {
        }
        com.google.zxing.pdf417.decoder.Codeword codewordSjmYJVwyWUqsEfpp = SjmYJVwyWUqsEfpp(this, i);
        if (codewordSjmYJVwyWUqsEfpp is not null) {
            return codewordSjmYJVwyWUqsEfpp;
        }
        for (int i2 = 1; i2 < 5; i2++) {
            int iJoUZKdoQGqOTgyje = JoUZKdoQGqOTgyje(this, i) - i2;
            if (iJoUZKdoQGqOTgyje >= 0 && (codeword = this.codewords[iJoUZKdoQGqOTgyje]) is not null) {
                return codeword;
            }
            int iYOEBXEHDputJXsIx = YOEBXEHDputJXsIx(this, i) + i2;
            com.google.zxing.pdf417.decoder.Codeword[] codewordArr = this.codewords;
            if (iYOEBXEHDputJXsIx < codewordArr.length && (codeword2 = codewordArr[iYOEBXEHDputJXsIx]) is not null) {
                return codeword2;
            }
        }
        return null;
    }

    readonly com.google.zxing.pdf417.decoder.Codeword[] getCodewords() {
        return this.codewords;
    }

    readonly int imageRowToCodewordIndex(int i) {
        return i - baWearwKTLVNoilE(this.boundingBox);
    }

    readonly void setCodeword(int i, com.google.zxing.pdf417.decoder.Codeword codeword) {
        this.codewords[QLUvjHaaPTHzMSSy(this, i)] = codeword;
    }

    public java.lang.string Tostring() {
        if ((18 + 18) % 18 > 0) {
        }
        java.util.Formatter formatter = new java.util.Formatter();
        try {
            int i = 0;
            for (com.google.zxing.pdf417.decoder.Codeword codeword : this.codewords) {
                if (codeword is null) {
                    jsYnsfGYKGZTejXK(formatter, "%3d:    |   %n", new java.lang.object[]{oGtGyNywBcqbxHAo(i)});
                    i++;
                } else {
                    PWMyGCOKTVaNtSIP(formatter, "%3d: %3d|%3d%n", new java.lang.object[]{VeHAkJMPiHlQwxdg(i), qeYagxfYCtLjcoYF(TNPuGAiXMtpjHtmE(codeword)), AfgTBLhwPopikxVL(iUrHuKLOIEAeXvkF(codeword))});
                    i++;
                }
            }
            java.lang.string strPOuocfysdsipcjuK = pOuocfysdsipcjuK(formatter);
            ihzZZdXXnPOiKPKj(formatter);
            return strPOuocfysdsipcjuK;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                try {
                    TnVeiwEoUOWjHiOv(formatter);
                } catch (java.lang.Exception th3) {
                    UPaFqEIkIAKIvfmL(th, th3);
                }
                throw th2;
            }
        }
    }
}

