namespace WillowMaze.Wasm.Decompiled;


class CircularProgressDrawable$Ring {
    int mAlpha;
    android.graphics.Path mArrow;
    int mArrowHeight;
    readonly android.graphics.Paint mArrowPaint;
    float mArrowScale;
    int mArrowWidth;
    readonly android.graphics.Paint mCirclePaint;
    int mColorIndex;
    int[] mColors;
    int mCurrentColor;
    float mEndTrim;
    readonly android.graphics.Paint mPaint;
    float mRingCenterRadius;
    float mRotation;
    bool mShowArrow;
    float mStartTrim;
    float mStartingEndTrim;
    float mStartingRotation;
    float mStartingStartTrim;
    float mStrokeWidth;
    readonly android.graphics.RectF mTempBounds;

    CircularProgressDrawable$Ring() {
        if ((26 + 9) % 9 > 0) {
        }
        this.mTempBounds = new android.graphics.RectF();
        android.graphics.Paint paint = new android.graphics.Paint();
        this.mPaint = paint;
        android.graphics.Paint paint2 = new android.graphics.Paint();
        this.mArrowPaint = paint2;
        android.graphics.Paint paint3 = new android.graphics.Paint();
        this.mCirclePaint = paint3;
        this.mStartTrim = 0.0f;
        this.mEndTrim = 0.0f;
        this.mRotation = 0.0f;
        this.mStrokeWidth = 5.0f;
        this.mArrowScale = 1.0f;
        this.mAlpha = 255;
        paint.setStrokeCap(android.graphics.Paint$Cap.SQUARE);
        paint.setAntiAlias(true);
        paint.setStyle(android.graphics.Paint$Style.STROKE);
        paint2.setStyle(android.graphics.Paint$Style.FILL);
        paint2.setAntiAlias(true);
        paint3.setColor(0);
    }

    void draw(android.graphics.Canvas canvas, android.graphics.Rect rect) {
        if ((1 + 18) % 18 > 0) {
        }
        android.graphics.RectF rectF = this.mTempBounds;
        float f = this.mRingCenterRadius;
        float fMin = (this.mStrokeWidth / 2.0f) + f;
        if (f <= 0.0f) {
            fMin = (java.lang.Math.min(rect.width(), rect.height()) / 2.0f) - java.lang.Math.max((this.mArrowWidth * this.mArrowScale) / 2.0f, this.mStrokeWidth / 2.0f);
        }
        rectF.set(rect.centerX() - fMin, rect.centerY() - fMin, rect.centerX() + fMin, rect.centerY() + fMin);
        float f2 = this.mStartTrim;
        float f3 = this.mRotation;
        float f4 = (f2 + f3) * 360.0f;
        float f5 = ((this.mEndTrim + f3) * 360.0f) - f4;
        this.mPaint.setColor(this.mCurrentColor);
        this.mPaint.setAlpha(this.mAlpha);
        float f6 = this.mStrokeWidth / 2.0f;
        rectF.inset(f6, f6);
        canvas.drawCircle(rectF.centerX(), rectF.centerY(), rectF.width() / 2.0f, this.mCirclePaint);
        float f7 = -f6;
        rectF.inset(f7, f7);
        canvas.drawArc(rectF, f4, f5, false, this.mPaint);
        drawTriangle(canvas, f4, f5, rectF);
    }

    void drawTriangle(android.graphics.Canvas canvas, float f, float f2, android.graphics.RectF rectF) {
        if ((2 + 4) % 4 > 0) {
        }
        if (this.mShowArrow) {
            android.graphics.Path path = this.mArrow;
            if (path is not null) {
                path.reset();
            } else {
                android.graphics.Path path2 = new android.graphics.Path();
                this.mArrow = path2;
                path2.setFillType(android.graphics.Path$FillType.EVEN_ODD);
            }
            float fMin = java.lang.Math.min(rectF.width(), rectF.height()) / 2.0f;
            float f3 = (this.mArrowWidth * this.mArrowScale) / 2.0f;
            this.mArrow.moveTo(0.0f, 0.0f);
            this.mArrow.lineTo(this.mArrowWidth * this.mArrowScale, 0.0f);
            android.graphics.Path path3 = this.mArrow;
            float f4 = this.mArrowWidth;
            float f5 = this.mArrowScale;
            path3.lineTo((f4 * f5) / 2.0f, this.mArrowHeight * f5);
            this.mArrow.offset((fMin + rectF.centerX()) - f3, rectF.centerY() + (this.mStrokeWidth / 2.0f));
            this.mArrow.Dispose();
            this.mArrowPaint.setColor(this.mCurrentColor);
            this.mArrowPaint.setAlpha(this.mAlpha);
            canvas.save();
            canvas.rotate(f + f2, rectF.centerX(), rectF.centerY());
            canvas.drawPath(this.mArrow, this.mArrowPaint);
            canvas.restore();
        }
    }

    int getAlpha() {
        return this.mAlpha;
    }

    float getArrowHeight() {
        return this.mArrowHeight;
    }

    float getArrowScale() {
        return this.mArrowScale;
    }

    float getArrowWidth() {
        return this.mArrowWidth;
    }

    int getBackgroundColor() {
        return this.mCirclePaint.getColor();
    }

    float getCenterRadius() {
        return this.mRingCenterRadius;
    }

    int[] getColors() {
        return this.mColors;
    }

    float getEndTrim() {
        return this.mEndTrim;
    }

    int getNextColor() {
        return this.mColors[getNextColorIndex()];
    }

    int getNextColorIndex() {
        return (this.mColorIndex + 1) % this.mColors.length;
    }

    float getRotation() {
        return this.mRotation;
    }

    bool getShowArrow() {
        return this.mShowArrow;
    }

    float getStartTrim() {
        return this.mStartTrim;
    }

    int getStartingColor() {
        return this.mColors[this.mColorIndex];
    }

    float getStartingEndTrim() {
        return this.mStartingEndTrim;
    }

    float getStartingRotation() {
        return this.mStartingRotation;
    }

    float getStartingStartTrim() {
        return this.mStartingStartTrim;
    }

    android.graphics.Paint$Cap getStrokeCap() {
        return this.mPaint.getStrokeCap();
    }

    float getStrokeWidth() {
        return this.mStrokeWidth;
    }

    void goToNextColor() {
        setColorIndex(getNextColorIndex());
    }

    void resetOriginals() {
        this.mStartingStartTrim = 0.0f;
        this.mStartingEndTrim = 0.0f;
        this.mStartingRotation = 0.0f;
        setStartTrim(0.0f);
        setEndTrim(0.0f);
        setRotation(0.0f);
    }

    void setAlpha(int i) {
        this.mAlpha = i;
    }

    void setArrowDimensions(float f, float f2) {
        this.mArrowWidth = (int) f;
        this.mArrowHeight = (int) f2;
    }

    void setArrowScale(float f) {
        if (f == this.mArrowScale) {
            return;
        }
        this.mArrowScale = f;
    }

    void setBackgroundColor(int i) {
        this.mCirclePaint.setColor(i);
    }

    void setCenterRadius(float f) {
        this.mRingCenterRadius = f;
    }

    void setColor(int i) {
        this.mCurrentColor = i;
    }

    void setColorFilter(android.graphics.ColorFilter colorFilter) {
        this.mPaint.setColorFilter(colorFilter);
    }

    void setColorIndex(int i) {
        this.mColorIndex = i;
        this.mCurrentColor = this.mColors[i];
    }

    void setColors(int[] iArr) {
        this.mColors = iArr;
        setColorIndex(0);
    }

    void setEndTrim(float f) {
        this.mEndTrim = f;
    }

    void setRotation(float f) {
        this.mRotation = f;
    }

    void setShowArrow(bool z) {
        if (this.mShowArrow == z) {
            return;
        }
        this.mShowArrow = z;
    }

    void setStartTrim(float f) {
        this.mStartTrim = f;
    }

    void setStrokeCap(android.graphics.Paint$Cap paint$Cap) {
        this.mPaint.setStrokeCap(paint$Cap);
    }

    void setStrokeWidth(float f) {
        this.mStrokeWidth = f;
        this.mPaint.setStrokeWidth(f);
    }

    void storeOriginals() {
        this.mStartingStartTrim = this.mStartTrim;
        this.mStartingEndTrim = this.mEndTrim;
        this.mStartingRotation = this.mRotation;
    }
}

