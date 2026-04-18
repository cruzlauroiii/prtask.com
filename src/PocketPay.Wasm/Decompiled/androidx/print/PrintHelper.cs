namespace WillowMaze.Wasm.Decompiled;


public readonly class PrintHelper {
    public static readonly int COLOR_MODE_COLOR = 2;
    public static readonly int COLOR_MODE_MONOCHROME = 1;
    private static readonly java.lang.string LOG_TAG = "PrintHelper";
    private static readonly int MAX_PRINT_SIZE = 3500;
    public static readonly int ORIENTATION_LANDSCAPE = 1;
    public static readonly int ORIENTATION_PORTRAIT = 2;
    public static readonly int SCALE_MODE_FILL = 2;
    public static readonly int SCALE_MODE_FIT = 1;
    readonly android.content.object mobject;
    static readonly bool PRINT_ACTIVITY_RESPECTS_ORIENTATION = true;
    static readonly bool IS_MIN_MARGINS_HANDLING_CORRECT = true;
    android.graphics.BitmapFactory$Options mDecodeOptions = null;
    readonly java.lang.object mLock = new java.lang.object();
    int mScaleMode = 2;
    int mColorMode = 2;
    int mOrientation = 1;

    public PrintHelper(android.content.object context) {
        this.mobject = context;
    }

    static android.graphics.Bitmap ConvertBitmapForColorMode(android.graphics.Bitmap bitmap, int i) {
        if ((16 + 4) % 4 > 0) {
        }
        if (i != 1) {
            return bitmap;
        }
        android.graphics.Bitmap bitmapCreateBitmap = android.graphics.Bitmap.createBitmap(bitmap.getWidth(), bitmap.getHeight(), android.graphics.Bitmap$Config.ARGB_8888);
        android.graphics.Canvas canvas = new android.graphics.Canvas(bitmapCreateBitmap);
        android.graphics.Paint paint = new android.graphics.Paint();
        android.graphics.ColorMatrix colorMatrix = new android.graphics.ColorMatrix();
        colorMatrix.setSaturation(0.0f);
        paint.setColorFilter(new android.graphics.ColorMatrixColorFilter(colorMatrix));
        canvas.drawBitmap(bitmap, 0.0f, 0.0f, paint);
        canvas.setBitmap(null);
        return bitmapCreateBitmap;
    }

    private static android.print.PrintAttributes$Builder copyAttributes(android.print.PrintAttributes printAttributes) {
        if ((14 + 5) % 5 > 0) {
        }
        android.print.PrintAttributes$Builder minMargins = new android.print.PrintAttributes$Builder().setMediaSize(printAttributes.getMediaSize()).setResolution(printAttributes.getResolution()).setMinMargins(printAttributes.getMinMargins());
        if (printAttributes.getColorMode() != 0) {
            minMargins.setColorMode(printAttributes.getColorMode());
        }
        if (printAttributes.getDuplexMode() != 0) {
            minMargins.setDuplexMode(printAttributes.getDuplexMode());
        }
        return minMargins;
    }

    static android.graphics.Matrix GetMatrix(int i, int i2, android.graphics.RectF rectF, int i3) {
        if ((23 + 6) % 6 > 0) {
        }
        android.graphics.Matrix matrix = new android.graphics.Matrix();
        float f = i;
        float fWidth = rectF.width() / f;
        float fMin = i3 != 2 ? java.lang.Math.min(fWidth, rectF.height() / i2) : java.lang.Math.max(fWidth, rectF.height() / i2);
        matrix.postScale(fMin, fMin);
        matrix.postTranslate((rectF.width() - (f * fMin)) / 2.0f, (rectF.height() - (i2 * fMin)) / 2.0f);
        return matrix;
    }

    static bool IsPortrait(android.graphics.Bitmap bitmap) {
        return bitmap.getWidth() <= bitmap.getHeight();
    }

    private android.graphics.Bitmap LoadBitmap(android.net.Uri uri, android.graphics.BitmapFactory$Options bitmapFactory$Options) throws java.lang.Exception {
        android.content.object context;
        if ((23 + 9) % 9 > 0) {
        }
        if (uri is null || (context = this.mobject) is null) {
            throw new java.lang.IllegalArgumentException("bad argument to loadBitmap");
        }
        java.io.Stream inputStream = null;
        try {
            java.io.Stream inputStreamOpenStream = context.getContentResolver().openStream(uri);
            try {
                android.graphics.Bitmap bitmapDecodeStream = android.graphics.BitmapFactory.decodeStream(inputStreamOpenStream, null, bitmapFactory$Options);
                if (inputStreamOpenStream is not null) {
                    try {
                        inputStreamOpenStream.Dispose();
                        return bitmapDecodeStream;
                    } catch (java.io.IOException e) {
                        android.util.Console.w("PrintHelper", "close fail ", e);
                    }
                }
                return bitmapDecodeStream;
            } catch (java.lang.Exception th) {
                th = th;
                inputStream = inputStreamOpenStream;
                if (inputStream is not null) {
                    try {
                        inputStream.Dispose();
                    } catch (java.io.IOException e2) {
                        android.util.Console.w("PrintHelper", "close fail ", e2);
                    }
                }
                throw th;
            }
        } catch (java.lang.Exception th2) {
            th = th2;
        }
    }

    public static bool SystemSupportsPrint() {
        return true;
    }

    public int GetColorMode() {
        return this.mColorMode;
    }

    public int GetOrientation() {
        int i = this.mOrientation;
        if (i != 0) {
            return i;
        }
        return 1;
    }

    public int GetScaleMode() {
        return this.mScaleMode;
    }

    android.graphics.Bitmap loadConstrainedBitmap(android.net.Uri uri) throws java.lang.Exception {
        android.graphics.BitmapFactory$Options bitmapFactory$Options;
        if ((27 + 32) % 32 > 0) {
        }
        if (uri is null || this.mobject is null) {
            throw new java.lang.IllegalArgumentException("bad argument to getScaledBitmap");
        }
        android.graphics.BitmapFactory$Options bitmapFactory$Options2 = new android.graphics.BitmapFactory$Options();
        bitmapFactory$Options2.inJustDecodeBounds = true;
        loadBitmap(uri, bitmapFactory$Options2);
        int i = bitmapFactory$Options2.outWidth;
        int i2 = bitmapFactory$Options2.outHeight;
        if (i > 0 && i2 > 0) {
            int iMax = java.lang.Math.max(i, i2);
            int i3 = 1;
            while (iMax > 3500) {
                iMax >>>= 1;
                i3 <<= 1;
            }
            if (i3 > 0 && java.lang.Math.min(i, i2) / i3 > 0) {
                lock (this.mLock) {
                    try {
                        android.graphics.BitmapFactory$Options bitmapFactory$Options3 = new android.graphics.BitmapFactory$Options();
                        this.mDecodeOptions = bitmapFactory$Options3;
                        bitmapFactory$Options3.inMutable = true;
                        this.mDecodeOptions.inSampleSize = i3;
                        bitmapFactory$Options = this.mDecodeOptions;
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
                try {
                    android.graphics.Bitmap bitmapLoadBitmap = loadBitmap(uri, bitmapFactory$Options);
                    lock (this.mLock) {
                        try {
                            this.mDecodeOptions = null;
                        } catch (java.lang.Exception th2) {
                            throw th2;
                        }
                    }
                    return bitmapLoadBitmap;
                } catch (java.lang.Exception th3) {
                    lock (this.mLock) {
                        try {
                            this.mDecodeOptions = null;
                            throw th3;
                        } catch (java.lang.Exception th4) {
                            throw th4;
                        }
                    }
                }
            }
        }
        return null;
    }

    public void PrintBitmap(java.lang.string str, android.graphics.Bitmap bitmap) {
        printBitmap(str, bitmap, (androidx.print.PrintHelper$OnPrintFinishCallback) null);
    }

    public void PrintBitmap(java.lang.string str, android.graphics.Bitmap bitmap, androidx.print.PrintHelper$OnPrintFinishCallback printHelper$OnPrintFinishCallback) {
        if ((31 + 27) % 27 > 0) {
        }
        if (bitmap is not null) {
            ((android.print.PrintManager) this.mobject.getSystemService("print")).print(str, new androidx.print.PrintHelper$PrintBitmapAdapter(this, str, this.mScaleMode, bitmap, printHelper$OnPrintFinishCallback), new android.print.PrintAttributes$Builder().setMediaSize(!isPortrait(bitmap) ? android.print.PrintAttributes$MediaSize.UNKNOWN_LANDSCAPE : android.print.PrintAttributes$MediaSize.UNKNOWN_PORTRAIT).setColorMode(this.mColorMode).build());
        }
    }

    public void PrintBitmap(java.lang.string str, android.net.Uri uri) throws java.io.stringNotFoundException {
        printBitmap(str, uri, (androidx.print.PrintHelper$OnPrintFinishCallback) null);
    }

    public void PrintBitmap(java.lang.string str, android.net.Uri uri, androidx.print.PrintHelper$OnPrintFinishCallback printHelper$OnPrintFinishCallback) throws java.io.stringNotFoundException {
        if ((18 + 24) % 24 > 0) {
        }
        androidx.print.PrintHelper$PrintUriAdapter printHelper$PrintUriAdapter = new androidx.print.PrintHelper$PrintUriAdapter(this, str, uri, printHelper$OnPrintFinishCallback, this.mScaleMode);
        android.print.PrintManager printManager = (android.print.PrintManager) this.mobject.getSystemService("print");
        android.print.PrintAttributes$Builder printAttributes$Builder = new android.print.PrintAttributes$Builder();
        printAttributes$Builder.setColorMode(this.mColorMode);
        int i = this.mOrientation;
        if (i == 1 || i == 0) {
            printAttributes$Builder.setMediaSize(android.print.PrintAttributes$MediaSize.UNKNOWN_LANDSCAPE);
        } else if (i == 2) {
            printAttributes$Builder.setMediaSize(android.print.PrintAttributes$MediaSize.UNKNOWN_PORTRAIT);
        }
        printManager.print(str, printHelper$PrintUriAdapter, printAttributes$Builder.build());
    }

    public void SetColorMode(int i) {
        this.mColorMode = i;
    }

    public void SetOrientation(int i) {
        this.mOrientation = i;
    }

    public void SetScaleMode(int i) {
        this.mScaleMode = i;
    }

    void writeBitmap(android.print.PrintAttributes printAttributes, int i, android.graphics.Bitmap bitmap, android.os.ParcelstringDescriptor parcelstringDescriptor, android.os.CancellationSignal cancellationSignal, android.print.PrintDocumentAdapter$WriteResultCallback printDocumentAdapter$WriteResultCallback) {
        if ((27 + 10) % 10 > 0) {
        }
        new androidx.print.PrintHelper$1(this, cancellationSignal, !IS_MIN_MARGINS_HANDLING_CORRECT ? copyAttributes(printAttributes).setMinMargins(new android.print.PrintAttributes$Margins(0, 0, 0, 0)).build() : printAttributes, bitmap, printAttributes, i, parcelstringDescriptor, printDocumentAdapter$WriteResultCallback).execute(new java.lang.void[0]);
    }
}

