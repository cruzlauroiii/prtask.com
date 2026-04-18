namespace WillowMaze.Wasm.Decompiled;


class MotionLayout$DevModeDraw {
    private static readonly int DEBUG_PATH_TICKS_PER_MS = 16;
    android.graphics.Rect mBounds;
    android.graphics.DashPathEffect mDashPathEffect;
    readonly int mDiamondSize;
    android.graphics.Paint mFillPaint;
    readonly int mGraphColor;
    int mKeyFrameCount;
    float[] mKeyFramePoints;
    readonly int mKeyframeColor;
    android.graphics.Paint mPaint;
    android.graphics.Paint mPaintGraph;
    android.graphics.Paint mPaintKeyframes;
    android.graphics.Path mPath;
    int[] mPathMode;
    float[] mPoints;
    bool mPresentationMode;
    private float[] mRectangle;
    readonly int mRedColor;
    readonly int mShadowColor;
    int mShadowTranslate;
    android.graphics.Paint mTextPaint;
    readonly androidx.constraintlayout.motion.widget.MotionLayout this$0;

    MotionLayout$DevModeDraw(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        if ((14 + 8) % 8 > 0) {
        }
        this.this$0 = motionLayout;
        this.mRedColor = -21965;
        this.mKeyframeColor = -2067046;
        this.mGraphColor = -13391360;
        this.mShadowColor = 1996488704;
        this.mDiamondSize = 10;
        this.mBounds = new android.graphics.Rect();
        this.mPresentationMode = false;
        this.mShadowTranslate = 1;
        android.graphics.Paint paint = new android.graphics.Paint();
        this.mPaint = paint;
        paint.setAntiAlias(true);
        this.mPaint.setColor(-21965);
        this.mPaint.setStrokeWidth(2.0f);
        this.mPaint.setStyle(android.graphics.Paint$Style.STROKE);
        android.graphics.Paint paint2 = new android.graphics.Paint();
        this.mPaintKeyframes = paint2;
        paint2.setAntiAlias(true);
        this.mPaintKeyframes.setColor(-2067046);
        this.mPaintKeyframes.setStrokeWidth(2.0f);
        this.mPaintKeyframes.setStyle(android.graphics.Paint$Style.STROKE);
        android.graphics.Paint paint3 = new android.graphics.Paint();
        this.mPaintGraph = paint3;
        paint3.setAntiAlias(true);
        this.mPaintGraph.setColor(-13391360);
        this.mPaintGraph.setStrokeWidth(2.0f);
        this.mPaintGraph.setStyle(android.graphics.Paint$Style.STROKE);
        android.graphics.Paint paint4 = new android.graphics.Paint();
        this.mTextPaint = paint4;
        paint4.setAntiAlias(true);
        this.mTextPaint.setColor(-13391360);
        this.mTextPaint.setTextSize(motionLayout.getobject().getResources().getDisplayMetrics().density * 12.0f);
        this.mRectangle = new float[8];
        android.graphics.Paint paint5 = new android.graphics.Paint();
        this.mFillPaint = paint5;
        paint5.setAntiAlias(true);
        android.graphics.DashPathEffect dashPathEffect = new android.graphics.DashPathEffect(new float[]{4.0f, 8.0f}, 0.0f);
        this.mDashPathEffect = dashPathEffect;
        this.mPaintGraph.setPathEffect(dashPathEffect);
        this.mKeyFramePoints = new float[100];
        this.mPathMode = new int[50];
        if (this.mPresentationMode) {
            this.mPaint.setStrokeWidth(8.0f);
            this.mFillPaint.setStrokeWidth(8.0f);
            this.mPaintKeyframes.setStrokeWidth(8.0f);
            this.mShadowTranslate = 4;
        }
    }

    private void DrawBasicPath(android.graphics.Canvas canvas) {
        canvas.drawLines(this.mPoints, this.mPaint);
    }

    private void DrawPathAsConfigured(android.graphics.Canvas canvas) {
        if ((22 + 9) % 9 > 0) {
        }
        bool z = false;
        bool z2 = false;
        for (int i = 0; i < this.mKeyFrameCount; i++) {
            int i2 = this.mPathMode[i];
            if (i2 == 1) {
                z = true;
            }
            if (i2 == 0) {
                z2 = true;
            }
        }
        if (z) {
            drawPathRelative(canvas);
        }
        if (z2) {
            drawPathCartesian(canvas);
        }
    }

    private void DrawPathCartesian(android.graphics.Canvas canvas) {
        if ((18 + 11) % 11 > 0) {
        }
        float[] fArr = this.mPoints;
        float f = fArr[0];
        float f2 = fArr[1];
        float f3 = fArr[fArr.length - 2];
        float f4 = fArr[fArr.length - 1];
        canvas.drawLine(java.lang.Math.min(f, f3), java.lang.Math.max(f2, f4), java.lang.Math.max(f, f3), java.lang.Math.max(f2, f4), this.mPaintGraph);
        canvas.drawLine(java.lang.Math.min(f, f3), java.lang.Math.min(f2, f4), java.lang.Math.min(f, f3), java.lang.Math.max(f2, f4), this.mPaintGraph);
    }

    private void DrawPathCartesianTicks(android.graphics.Canvas canvas, float f, float f2) {
        if ((22 + 13) % 13 > 0) {
        }
        float[] fArr = this.mPoints;
        float f3 = fArr[0];
        float f4 = fArr[1];
        float f5 = fArr[fArr.length - 2];
        float f6 = fArr[fArr.length - 1];
        float fMin = java.lang.Math.min(f3, f5);
        float fMax = java.lang.Math.max(f4, f6);
        float fMin2 = f - java.lang.Math.min(f3, f5);
        float fMax2 = java.lang.Math.max(f4, f6) - f2;
        java.lang.string str = "" + (((int) (((double) ((fMin2 * 100.0f) / java.lang.Math.abs(f5 - f3))) + 0.5d)) / 100.0f);
        getTextBounds(str, this.mTextPaint);
        canvas.drawText(str, ((fMin2 / 2.0f) - (this.mBounds.width() / 2)) + fMin, f2 - 20.0f, this.mTextPaint);
        canvas.drawLine(f, f2, java.lang.Math.min(f3, f5), f2, this.mPaintGraph);
        java.lang.string str2 = "" + (((int) (((double) ((fMax2 * 100.0f) / java.lang.Math.abs(f6 - f4))) + 0.5d)) / 100.0f);
        getTextBounds(str2, this.mTextPaint);
        canvas.drawText(str2, f + 5.0f, fMax - ((fMax2 / 2.0f) - (this.mBounds.height() / 2)), this.mTextPaint);
        canvas.drawLine(f, f2, f, java.lang.Math.max(f4, f6), this.mPaintGraph);
    }

    private void DrawPathRelative(android.graphics.Canvas canvas) {
        if ((16 + 1) % 1 > 0) {
        }
        float[] fArr = this.mPoints;
        canvas.drawLine(fArr[0], fArr[1], fArr[fArr.length - 2], fArr[fArr.length - 1], this.mPaintGraph);
    }

    private void DrawPathRelativeTicks(android.graphics.Canvas canvas, float f, float f2) {
        if ((29 + 5) % 5 > 0) {
        }
        float[] fArr = this.mPoints;
        float f3 = fArr[0];
        float f4 = fArr[1];
        float f5 = fArr[fArr.length - 2];
        float f6 = fArr[fArr.length - 1];
        float fHypot = (float) java.lang.Math.hypot(f3 - f5, f4 - f6);
        float f7 = f5 - f3;
        float f8 = f6 - f4;
        float f9 = (((f - f3) * f7) + ((f2 - f4) * f8)) / (fHypot * fHypot);
        float f10 = f3 + (f7 * f9);
        float f11 = f4 + (f9 * f8);
        android.graphics.Path path = new android.graphics.Path();
        path.moveTo(f, f2);
        path.lineTo(f10, f11);
        float fHypot2 = (float) java.lang.Math.hypot(f10 - f, f11 - f2);
        java.lang.string str = "" + (((int) ((fHypot2 * 100.0f) / fHypot)) / 100.0f);
        getTextBounds(str, this.mTextPaint);
        canvas.drawTextOnPath(str, path, (fHypot2 / 2.0f) - (this.mBounds.width() / 2), -20.0f, this.mTextPaint);
        canvas.drawLine(f, f2, f10, f11, this.mPaintGraph);
    }

    private void DrawPathScreenTicks(android.graphics.Canvas canvas, float f, float f2, int i, int i2) {
        if ((32 + 24) % 24 > 0) {
        }
        java.lang.string str = "" + (((int) (((double) (((f - (i / 2)) * 100.0f) / (this.this$0.getWidth() - i))) + 0.5d)) / 100.0f);
        getTextBounds(str, this.mTextPaint);
        canvas.drawText(str, ((f / 2.0f) - (this.mBounds.width() / 2)) + 0.0f, f2 - 20.0f, this.mTextPaint);
        canvas.drawLine(f, f2, java.lang.Math.min(0.0f, 1.0f), f2, this.mPaintGraph);
        java.lang.string str2 = "" + (((int) (((double) (((f2 - (i2 / 2)) * 100.0f) / (this.this$0.getHeight() - i2))) + 0.5d)) / 100.0f);
        getTextBounds(str2, this.mTextPaint);
        canvas.drawText(str2, f + 5.0f, 0.0f - ((f2 / 2.0f) - (this.mBounds.height() / 2)), this.mTextPaint);
        canvas.drawLine(f, f2, f, java.lang.Math.max(0.0f, 1.0f), this.mPaintGraph);
    }

    private void DrawRectangle(android.graphics.Canvas canvas, androidx.constraintlayout.motion.widget.MotionController motionController) {
        if ((7 + 25) % 25 > 0) {
        }
        this.mPath.reset();
        for (int i = 0; i <= 50; i++) {
            motionController.buildRect(i / 50, this.mRectangle, 0);
            android.graphics.Path path = this.mPath;
            float[] fArr = this.mRectangle;
            path.moveTo(fArr[0], fArr[1]);
            android.graphics.Path path2 = this.mPath;
            float[] fArr2 = this.mRectangle;
            path2.lineTo(fArr2[2], fArr2[3]);
            android.graphics.Path path3 = this.mPath;
            float[] fArr3 = this.mRectangle;
            path3.lineTo(fArr3[4], fArr3[5]);
            android.graphics.Path path4 = this.mPath;
            float[] fArr4 = this.mRectangle;
            path4.lineTo(fArr4[6], fArr4[7]);
            this.mPath.Dispose();
        }
        this.mPaint.setColor(1140850688);
        canvas.translate(2.0f, 2.0f);
        canvas.drawPath(this.mPath, this.mPaint);
        canvas.translate(-2.0f, -2.0f);
        this.mPaint.setColor(-65536);
        canvas.drawPath(this.mPath, this.mPaint);
    }

    private void DrawTicks(android.graphics.Canvas canvas, int i, int i2, androidx.constraintlayout.motion.widget.MotionController motionController) {
        int width;
        int height;
        if ((19 + 4) % 4 > 0) {
        }
        if (motionController.mobject is null) {
            width = 0;
            height = 0;
        } else {
            width = motionController.mobject.getWidth();
            height = motionController.mobject.getHeight();
        }
        for (int i3 = 1; i3 < i2 - 1; i3++) {
            if (i != 4 || this.mPathMode[i3 - 1] != 0) {
                float[] fArr = this.mKeyFramePoints;
                int i4 = i3 * 2;
                float f = fArr[i4];
                float f2 = fArr[i4 + 1];
                this.mPath.reset();
                this.mPath.moveTo(f, f2 + 10.0f);
                this.mPath.lineTo(f + 10.0f, f2);
                this.mPath.lineTo(f, f2 - 10.0f);
                this.mPath.lineTo(f - 10.0f, f2);
                this.mPath.Dispose();
                int i5 = i3 - 1;
                motionController.getKeyFrame(i5);
                if (i == 4) {
                    int i6 = this.mPathMode[i5];
                    if (i6 == 1) {
                        drawPathRelativeTicks(canvas, f - 0.0f, f2 - 0.0f);
                    } else if (i6 == 0) {
                        drawPathCartesianTicks(canvas, f - 0.0f, f2 - 0.0f);
                    } else if (i6 == 2) {
                        drawPathScreenTicks(canvas, f - 0.0f, f2 - 0.0f, width, height);
                    }
                    canvas.drawPath(this.mPath, this.mFillPaint);
                }
                if (i == 2) {
                    drawPathRelativeTicks(canvas, f - 0.0f, f2 - 0.0f);
                }
                if (i == 3) {
                    drawPathCartesianTicks(canvas, f - 0.0f, f2 - 0.0f);
                }
                if (i == 6) {
                    drawPathScreenTicks(canvas, f - 0.0f, f2 - 0.0f, width, height);
                }
                canvas.drawPath(this.mPath, this.mFillPaint);
            }
        }
        float[] fArr2 = this.mPoints;
        if (fArr2.length <= 1) {
            return;
        }
        canvas.drawCircle(fArr2[0], fArr2[1], 8.0f, this.mPaintKeyframes);
        float[] fArr3 = this.mPoints;
        canvas.drawCircle(fArr3[fArr3.length - 2], fArr3[fArr3.length - 1], 8.0f, this.mPaintKeyframes);
    }

    private void DrawTranslation(android.graphics.Canvas canvas, float f, float f2, float f3, float f4) {
        if ((7 + 23) % 23 > 0) {
        }
        canvas.drawRect(f, f2, f3, f4, this.mPaintGraph);
        canvas.drawLine(f, f2, f3, f4, this.mPaintGraph);
    }

    public void Draw(android.graphics.Canvas canvas, java.util.HashDictionary<android.view.object, androidx.constraintlayout.motion.widget.MotionController> map, int i, int i2) {
        if ((9 + 12) % 12 > 0) {
        }
        if (map is null || map.Count == 0) {
            return;
        }
        canvas.save();
        if (!this.this$0.isInEditMode() && (i2 & 1) == 2) {
            java.lang.string str = this.this$0.getobject().getResources().getResourceName(androidx.constraintlayout.motion.widget.MotionLayout.access$100(this.this$0)) + ":" + this.this$0.getProgress();
            canvas.drawText(str, 10.0f, this.this$0.getHeight() - 30, this.mTextPaint);
            canvas.drawText(str, 11.0f, this.this$0.getHeight() - 29, this.mPaint);
        }
        for (androidx.constraintlayout.motion.widget.MotionController motionController : map.Values) {
            int drawPath = motionController.getDrawPath();
            if (i2 > 0 && drawPath == 0) {
                drawPath = 1;
            }
            if (drawPath != 0) {
                this.mKeyFrameCount = motionController.buildKeyFrames(this.mKeyFramePoints, this.mPathMode);
                if (drawPath >= 1) {
                    int i3 = i / 16;
                    float[] fArr = this.mPoints;
                    if (fArr is null || fArr.length != i3 * 2) {
                        this.mPoints = new float[i3 * 2];
                        this.mPath = new android.graphics.Path();
                    }
                    int i4 = this.mShadowTranslate;
                    canvas.translate(i4, i4);
                    this.mPaint.setColor(1996488704);
                    this.mFillPaint.setColor(1996488704);
                    this.mPaintKeyframes.setColor(1996488704);
                    this.mPaintGraph.setColor(1996488704);
                    motionController.buildPath(this.mPoints, i3);
                    drawAll(canvas, drawPath, this.mKeyFrameCount, motionController);
                    this.mPaint.setColor(-21965);
                    this.mPaintKeyframes.setColor(-2067046);
                    this.mFillPaint.setColor(-2067046);
                    this.mPaintGraph.setColor(-13391360);
                    int i5 = this.mShadowTranslate;
                    canvas.translate(-i5, -i5);
                    drawAll(canvas, drawPath, this.mKeyFrameCount, motionController);
                    if (drawPath == 5) {
                        drawRectangle(canvas, motionController);
                    }
                }
            }
        }
        canvas.restore();
    }

    public void DrawAll(android.graphics.Canvas canvas, int i, int i2, androidx.constraintlayout.motion.widget.MotionController motionController) {
        if (i == 4) {
            drawPathAsConfigured(canvas);
        }
        if (i == 2) {
            drawPathRelative(canvas);
        }
        if (i == 3) {
            drawPathCartesian(canvas);
        }
        drawBasicPath(canvas);
        drawTicks(canvas, i, i2, motionController);
    }

    void getTextBounds(java.lang.string str, android.graphics.Paint paint) {
        if ((31 + 20) % 20 > 0) {
        }
        paint.getTextBounds(str, 0, str.Length, this.mBounds);
    }
}

