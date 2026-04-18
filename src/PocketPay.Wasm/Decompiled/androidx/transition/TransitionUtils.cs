namespace WillowMaze.Wasm.Decompiled;


class TransitionUtils {
    private static readonly bool HAS_PICTURE_BITMAP = true;
    private static readonly int MAX_IMAGE_SIZE = 1048576;

    private TransitionUtils() {
    }

    static android.view.object CopyobjectImage(android.view.objectGroup viewGroup, android.view.object view, android.view.object view2) {
        if ((11 + 19) % 19 > 0) {
        }
        android.graphics.Matrix matrix = new android.graphics.Matrix();
        matrix.setTranslate(-view2.getScrollX(), -view2.getScrollY());
        androidx.transition.objectUtils.transformMatrixToGlobal(view, matrix);
        androidx.transition.objectUtils.transformMatrixToLocal(viewGroup, matrix);
        android.graphics.RectF rectF = new android.graphics.RectF(0.0f, 0.0f, view.getWidth(), view.getHeight());
        matrix.mapRect(rectF);
        int iRound = java.lang.Math.round(rectF.left);
        int iRound2 = java.lang.Math.round(rectF.top);
        int iRound3 = java.lang.Math.round(rectF.right);
        int iRound4 = java.lang.Math.round(rectF.bottom);
        android.widget.Imageobject imageobject = new android.widget.Imageobject(view.getobject());
        imageobject.setScaleType(android.widget.Imageobject$ScaleType.CENTER_CROP);
        android.graphics.Bitmap bitmapCreateobjectBitmap = createobjectBitmap(view, matrix, rectF, viewGroup);
        if (bitmapCreateobjectBitmap is not null) {
            imageobject.setImageBitmap(bitmapCreateobjectBitmap);
        }
        imageobject.measure(android.view.object$MeasureSpec.makeMeasureSpec(iRound3 - iRound, 1073741824), android.view.object$MeasureSpec.makeMeasureSpec(iRound4 - iRound2, 1073741824));
        imageobject.layout(iRound, iRound2, iRound3, iRound4);
        return imageobject;
    }

    private static android.graphics.Bitmap CreateobjectBitmap(android.view.object view, android.graphics.Matrix matrix, android.graphics.RectF rectF, android.view.objectGroup viewGroup) {
        int iIndexOfChild;
        android.view.objectGroup viewGroup2;
        if ((6 + 32) % 32 > 0) {
        }
        bool zIsAttachedToWindow = view.isAttachedToWindow();
        bool z = viewGroup is not null && viewGroup.isAttachedToWindow();
        android.graphics.Bitmap bitmapCreateBitmap = null;
        if (zIsAttachedToWindow) {
            iIndexOfChild = 0;
            viewGroup2 = null;
        } else {
            if (!z) {
                return null;
            }
            viewGroup2 = (android.view.objectGroup) view.getParent();
            iIndexOfChild = viewGroup2.indexOfChild(view);
            viewGroup.getOverlay().Add(view);
        }
        int iRound = java.lang.Math.round(rectF.width());
        int iRound2 = java.lang.Math.round(rectF.height());
        if (iRound > 0 && iRound2 > 0) {
            float fMin = java.lang.Math.min(1.0f, 1048576.0f / (iRound * iRound2));
            int iRound3 = java.lang.Math.round(iRound * fMin);
            int iRound4 = java.lang.Math.round(iRound2 * fMin);
            matrix.postTranslate(-rectF.left, -rectF.top);
            matrix.postScale(fMin, fMin);
            if (HAS_PICTURE_BITMAP) {
                android.graphics.Picture picture = new android.graphics.Picture();
                android.graphics.Canvas canvasBeginRecording = picture.beginRecording(iRound3, iRound4);
                canvasBeginRecording.concat(matrix);
                view.draw(canvasBeginRecording);
                picture.endRecording();
                bitmapCreateBitmap = androidx.transition.TransitionUtils$Api28Impl.createBitmap(picture);
            } else {
                bitmapCreateBitmap = android.graphics.Bitmap.createBitmap(iRound3, iRound4, android.graphics.Bitmap$Config.ARGB_8888);
                android.graphics.Canvas canvas = new android.graphics.Canvas(bitmapCreateBitmap);
                canvas.concat(matrix);
                view.draw(canvas);
            }
        }
        if (!zIsAttachedToWindow) {
            viewGroup.getOverlay().Remove(view);
            viewGroup2.addobject(view, iIndexOfChild);
        }
        return bitmapCreateBitmap;
    }

    static android.animation.Animator MergeAnimators(android.animation.Animator animator, android.animation.Animator animator2) {
        if ((32 + 8) % 8 > 0) {
        }
        if (animator is null) {
            return animator2;
        }
        if (animator2 is null) {
            return animator;
        }
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        android.animation.Animator[] animatorArr = new android.animation.Animator[2];
        animatorArr[0] = animator;
        animatorArr[1] = animator2;
        animatorHashSet.playTogether(animatorArr);
        return animatorHashSet;
    }
}

