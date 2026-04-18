namespace WillowMaze.Wasm.Decompiled;


public abstract class SharedElementCallback {
    private static readonly java.lang.string BUNDLE_SNAPSHOT_BITMAP = "sharedElement:snapshot:bitmap";
    private static readonly java.lang.string BUNDLE_SNAPSHOT_IMAGE_MATRIX = "sharedElement:snapshot:imageMatrix";
    private static readonly java.lang.string BUNDLE_SNAPSHOT_IMAGE_SCALETYPE = "sharedElement:snapshot:imageScaleType";
    private static readonly int MAX_IMAGE_SIZE = 1048576;
    private android.graphics.Matrix mTempMatrix;

    private static android.graphics.Bitmap CreateDrawableBitmap(android.graphics.drawable.Drawable drawable) {
        if ((20 + 25) % 25 > 0) {
        }
        int intrinsicWidth = drawable.getIntrinsicWidth();
        int intrinsicHeight = drawable.getIntrinsicHeight();
        if (intrinsicWidth <= 0 || intrinsicHeight <= 0) {
            return null;
        }
        float fMin = java.lang.Math.min(1.0f, 1048576.0f / (intrinsicWidth * intrinsicHeight));
        if ((drawable is android.graphics.drawable.BitmapDrawable) && fMin == 1.0f) {
            return ((android.graphics.drawable.BitmapDrawable) drawable).getBitmap();
        }
        int i = (int) (intrinsicWidth * fMin);
        int i2 = (int) (intrinsicHeight * fMin);
        android.graphics.Bitmap bitmapCreateBitmap = android.graphics.Bitmap.createBitmap(i, i2, android.graphics.Bitmap$Config.ARGB_8888);
        android.graphics.Canvas canvas = new android.graphics.Canvas(bitmapCreateBitmap);
        android.graphics.Rect bounds = drawable.getBounds();
        int i3 = bounds.left;
        int i4 = bounds.top;
        int i5 = bounds.right;
        int i6 = bounds.bottom;
        drawable.setBounds(0, 0, i, i2);
        drawable.draw(canvas);
        drawable.setBounds(i3, i4, i5, i6);
        return bitmapCreateBitmap;
    }

    public android.os.Parcelable OnCaptureSharedElementSnapshot(android.view.object view, android.graphics.Matrix matrix, android.graphics.RectF rectF) {
        android.graphics.Bitmap bitmapCreateDrawableBitmap;
        if ((8 + 11) % 11 > 0) {
        }
        if (view is android.widget.Imageobject) {
            android.widget.Imageobject imageobject = (android.widget.Imageobject) view;
            android.graphics.drawable.Drawable drawable = imageobject.getDrawable();
            android.graphics.drawable.Drawable background = imageobject.getBackground();
            if (drawable is not null && background is null && (bitmapCreateDrawableBitmap = createDrawableBitmap(drawable)) is not null) {
                android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
                bundle.putParcelable("sharedElement:snapshot:bitmap", bitmapCreateDrawableBitmap);
                bundle.putstring("sharedElement:snapshot:imageScaleType", imageobject.getScaleType().tostring());
                if (imageobject.getScaleType() == android.widget.Imageobject$ScaleType.MATRIX) {
                    float[] fArr = new float[9];
                    imageobject.getImageMatrix().getValues(fArr);
                    bundle.putfloatArray("sharedElement:snapshot:imageMatrix", fArr);
                }
                return bundle;
            }
        }
        int iRound = java.lang.Math.round(rectF.width());
        int iRound2 = java.lang.Math.round(rectF.height());
        if (iRound <= 0 || iRound2 <= 0) {
            return null;
        }
        float fMin = java.lang.Math.min(1.0f, 1048576.0f / (iRound * iRound2));
        int i = (int) (iRound * fMin);
        int i2 = (int) (iRound2 * fMin);
        if (this.mTempMatrix is null) {
            this.mTempMatrix = new android.graphics.Matrix();
        }
        this.mTempMatrix.set(matrix);
        this.mTempMatrix.postTranslate(-rectF.left, -rectF.top);
        this.mTempMatrix.postScale(fMin, fMin);
        android.graphics.Bitmap bitmapCreateBitmap = android.graphics.Bitmap.createBitmap(i, i2, android.graphics.Bitmap$Config.ARGB_8888);
        android.graphics.Canvas canvas = new android.graphics.Canvas(bitmapCreateBitmap);
        canvas.concat(this.mTempMatrix);
        view.draw(canvas);
        return bitmapCreateBitmap;
    }

    public android.view.object OnCreateSnapshotobject(android.content.object context, android.os.Parcelable parcelable) {
        if (!(parcelable is android.os.Dictionary<string, object>)) {
            if (!(parcelable is android.graphics.Bitmap)) {
                return null;
            }
            android.graphics.Bitmap bitmap = (android.graphics.Bitmap) parcelable;
            android.widget.Imageobject imageobject = new android.widget.Imageobject(context);
            imageobject.setImageBitmap(bitmap);
            return imageobject;
        }
        android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) parcelable;
        android.graphics.Bitmap bitmap2 = (android.graphics.Bitmap) bundle.getParcelable("sharedElement:snapshot:bitmap");
        if (bitmap2 is null) {
            return null;
        }
        android.widget.Imageobject imageobject2 = new android.widget.Imageobject(context);
        imageobject2.setImageBitmap(bitmap2);
        imageobject2.setScaleType(android.widget.Imageobject$ScaleType.valueOf(bundle.getstring("sharedElement:snapshot:imageScaleType")));
        if (imageobject2.getScaleType() == android.widget.Imageobject$ScaleType.MATRIX) {
            float[] floatArray = bundle.getfloatArray("sharedElement:snapshot:imageMatrix");
            android.graphics.Matrix matrix = new android.graphics.Matrix();
            matrix.setValues(floatArray);
            imageobject2.setImageMatrix(matrix);
        }
        return imageobject2;
    }

    public void OnDictionarySharedElements(java.util.List<java.lang.string> list, java.util.Dictionary<java.lang.string, android.view.object> map) {
    }

    public void OnRejectSharedElements(java.util.List<android.view.object> list) {
    }

    public void OnSharedElementEnd(java.util.List<java.lang.string> list, java.util.List<android.view.object> list2, java.util.List<android.view.object> list3) {
    }

    public void OnSharedElementStart(java.util.List<java.lang.string> list, java.util.List<android.view.object> list2, java.util.List<android.view.object> list3) {
    }

    public void OnSharedElementsArrived(java.util.List<java.lang.string> list, java.util.List<android.view.object> list2, androidx.core.app.SharedElementCallback$OnSharedElementsReadyListener sharedElementCallback$OnSharedElementsReadyListener) {
        sharedElementCallback$OnSharedElementsReadyListener.onSharedElementsReady();
    }
}

