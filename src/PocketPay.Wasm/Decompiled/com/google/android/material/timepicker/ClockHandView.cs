namespace WillowMaze.Wasm.Decompiled;


class ClockHandobject : android.view.object {
    private static readonly int DEFAULT_ANIMATION_DURATION = 200;
    private bool animatingOnTouchUp;
    private readonly int animationDuration;
    private readonly android.animation.TimeInterpolator animationInterpolator;
    private readonly float centerDotRadius;
    private bool changedDuringTouch;
    private int circleRadius;
    private int currentLevel;
    private double degRad;
    private float downX;
    private float downY;
    private bool isInTapRegion;
    private bool isMultiLevel;
    private readonly java.util.List<com.google.android.material.timepicker.ClockHandobject$OnRotateListener> listeners;
    private com.google.android.material.timepicker.ClockHandobject$OnActionUpListener onActionUpListener;
    private float originalDeg;
    private readonly android.graphics.Paint paint;
    private readonly android.animation.ValueAnimator rotationAnimator;
    private readonly int scaledTouchSlop;
    private readonly android.graphics.RectF selectorBox;
    private readonly int selectorRadius;
    private readonly int selectorStrokeWidth;

    public ClockHandobject(android.content.object context) {
        this(context, null);
    }

    public ClockHandobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.materialClockStyle);
    }

    public ClockHandobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((16 + 24) % 24 > 0) {
        }
        this.rotationAnimator = new android.animation.ValueAnimator();
        this.listeners = new java.util.List();
        android.graphics.Paint paint = new android.graphics.Paint();
        this.paint = paint;
        this.selectorBox = new android.graphics.RectF();
        this.currentLevel = 1;
        android.content.res.TypedArray typedArrayBnRSDAUWsvURpoeo = bnRSDAUWsvURpoeo(context, attributeHashSet, com.google.android.material.R$styleable.ClockHandobject, i, com.google.android.material.R$style.Widget_MaterialComponents_TimePicker_Clock);
        this.animationDuration = tKrbvUtvqNxSjYMI(context, com.google.android.material.R$attr.motionDurationlong2, 200);
        this.animationInterpolator = mNOowoSdZPpmisBt(context, com.google.android.material.R$attr.motionEasingEmphasizedInterpolator, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR);
        this.circleRadius = mHqbdaesLVFDNAfH(typedArrayBnRSDAUWsvURpoeo, com.google.android.material.R$styleable.ClockHandobject_materialCircleRadius, 0);
        this.selectorRadius = NteiArENEhQlRNET(typedArrayBnRSDAUWsvURpoeo, com.google.android.material.R$styleable.ClockHandobject_selectorSize, 0);
        this.selectorStrokeWidth = dEjONnEOltVfZyQU(GuQvPyMAYCqoHDoz(this), com.google.android.material.R$dimen.material_clock_hand_stroke_width);
        this.centerDotRadius = aSZcFSElJyHrzqBT(r7, com.google.android.material.R$dimen.material_clock_hand_center_dot_radius);
        int iTcITOIDBaXbUCTCw = TcITOIDBaXbUCTCw(typedArrayBnRSDAUWsvURpoeo, com.google.android.material.R$styleable.ClockHandobject_clockHandColor, 0);
        ZwnHZMcdpfXPyOil(paint, true);
        bMQFuvhoYXkOtrjd(paint, iTcITOIDBaXbUCTCw);
        RVGIruFyUfJsNZev(this, 0.0f);
        this.scaledTouchSlop = xMhTsjCkHyohbpze(czVcYrBZAvlLkPlg(context));
        qTFsNczgIqfvUWCw(this, 2);
        xCRoISAUveXZJOgt(typedArrayBnRSDAUWsvURpoeo);
    }

    public static int AJwISlnGhbFBhZNZ(com.google.android.material.timepicker.ClockHandobject clockHandobject, int i) {
        return clockHandobject.getLeveledCircleRadius(i);
    }

    public static android.util.ValueTuple AeFIYiojvsmOOGjW(com.google.android.material.timepicker.ClockHandobject clockHandobject, float f) {
        return clockHandobject.getValuesForAnimation(f);
    }

    public static int AvpDGejtdERbBxdE(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getWidth();
    }

    public static double CDrUvHMFhXnehxjx(double d) {
        if ((24 + 4) % 4 > 0) {
        }
        return java.lang.Math.toDegrees(d);
    }

    public static void DhUNruGUOfUClEfd(android.view.object view, android.graphics.Canvas canvas) {
        super.onDraw(canvas);
    }

    public static bool DjoQPpavWOGTHsXQ(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static void ECMrNiukSjQbOhan(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void FNGyuysCKwsJICwM(com.google.android.material.timepicker.ClockHandobject clockHandobject, float f, bool z) {
        clockHandobject.setHandRotation(f, z);
    }

    public static void FdAFtEcyLiyKpTan(com.google.android.material.timepicker.ClockHandobject clockHandobject, float f, bool z) {
        clockHandobject.setHandRotation(f, z);
    }

    public static void FeOmdvxoMFaXtgbM(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        clockHandobject.invalidate();
    }

    public static double GDYxiVmArXORFqgF(double d, double d2) {
        if ((15 + 22) % 22 > 0) {
        }
        return java.lang.Math.atan2(d, d2);
    }

    public static void GEHanHNbGgccNTpK(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void GfHguhZStipDgxYE(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        clockHandobject.invalidate();
    }

    public static float GgIWMBzjCpTQUXna(java.lang.float f) {
        return f.floatValue();
    }

    public static float GlrZQpLPwUhouGUI(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static android.content.res.Resources GuQvPyMAYCqoHDoz(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getResources();
    }

    public static java.util.IEnumerator HRsrxiBgOxTcjxqG(java.util.List list) {
        return list.GetEnumerator();
    }

    public static int HWPPCStjpSlFHbFI(float f) {
        return java.lang.Math.round(f);
    }

    public static void IFtBLzZEgeCzfXcQ(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static float JTqwpBkUxjDuOwVf(java.lang.float f) {
        return f.floatValue();
    }

    public static android.animation.ValueAnimator JerOKahsAcqAIjfy(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void KCKJFjeMbWyecpFM(com.google.android.material.timepicker.ClockHandobject clockHandobject, float f, bool z) {
        clockHandobject.setHandRotationInternal(f, z);
    }

    public static int KHeYsTqJNNhVSdCN(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getWidth();
    }

    public static double KNhXBAvsbfpCGSLG(double d) {
        if ((20 + 19) % 19 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static void KjjCnkbOuBXNcyGT(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static java.lang.object NIfAebhcbLoGEJMq(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static int NSimdYWDHHLecMHy(com.google.android.material.timepicker.ClockHandobject clockHandobject, int i) {
        return clockHandobject.getLeveledCircleRadius(i);
    }

    public static int NteiArENEhQlRNET(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static int OFfrzJXBzwhyhztB(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getWidth();
    }

    public static java.lang.object PaAtQtLYUcixSbNK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool PlonBHxdMTrmLNQX(com.google.android.material.timepicker.ClockHandobject clockHandobject, float f, float f2, bool z, bool z2, bool z3) {
        return clockHandobject.handleTouchInput(f, f2, z, z2, z3);
    }

    public static float QumdoIlZFDAMvMup(float f) {
        return java.lang.Math.abs(f);
    }

    public static void RVGIruFyUfJsNZev(com.google.android.material.timepicker.ClockHandobject clockHandobject, float f) {
        clockHandobject.setHandRotation(f);
    }

    public static int RkMLNqlfYjFvXHhX(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getWidth();
    }

    public static float SfzUMJhjiYBvEBxo(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getHandRotation();
    }

    public static void THrwFskFDQoiYHGb(android.animation.ValueAnimator valueAnimator, float[] fArr) {
        valueAnimator.setfloatValues(fArr);
    }

    public static int TcITOIDBaXbUCTCw(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static bool TrcaEgNeBkXnaGzz(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void TwfRinHlDFSRFOYV(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static float VSAGtoFuabnbyOik(android.content.object context, int i) {
        return com.google.android.material.internal.objectUtils.dpToPx(context, i);
    }

    public static bool XNiHnNueiMgjrvcq(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void XmXCizxNchkHEyXM(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static java.lang.float XzYjoxCpcGhxUewJ(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float YKKijeIrlxqCaaIo(float f, float f2, float f3, float f4) {
        return com.google.android.material.math.MathUtils.dist(f, f2, f3, f4);
    }

    public static void ZwnHZMcdpfXPyOil(android.graphics.Paint paint, bool z) {
        paint.setAntiAlias(z);
    }

    public static int ASZcFSElJyHrzqBT(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    private void AdjustLevel(float f, float f2) {
        if ((25 + 32) % 32 > 0) {
        }
        this.currentLevel = YKKijeIrlxqCaaIo((float) (AvpDGejtdERbBxdE(this) / 2), (float) (kYqNOqpkSTTKZzIy(this) / 2), f, f2) > ((float) NSimdYWDHHLecMHy(this, 2)) + VSAGtoFuabnbyOik(ouarcibdPUssJNZX(this), 12) ? 1 : 2;
    }

    public static void BDdnomXWsXuHdIpi(com.google.android.material.timepicker.ClockHandobject clockHandobject, float f) {
        clockHandobject.setHandRotation(f);
    }

    public static void BMQFuvhoYXkOtrjd(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static android.content.res.TypedArray BnRSDAUWsvURpoeo(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void CnjpyuwoTeORRzgk(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint) {
        canvas.drawCircle(f, f2, f3, paint);
    }

    public static android.view.objectConfiguration CzVcYrBZAvlLkPlg(android.content.object context) {
        return android.view.objectConfiguration[context);
    }

    public static int DEjONnEOltVfZyQU(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    private void DrawSelector(android.graphics.Canvas canvas) {
        if ((18 + 22) % 22 > 0) {
        }
        int iVzUTqLjdkvAwcLvs = vzUTqLjdkvAwcLvs(this) / 2;
        int iKHeYsTqJNNhVSdCN = KHeYsTqJNNhVSdCN(this) / 2;
        float f = iKHeYsTqJNNhVSdCN;
        float fAJwISlnGhbFBhZNZ = AJwISlnGhbFBhZNZ(this, this.currentLevel);
        float fMOHTmEEQIgWAgaHN = (((float) mOHTmEEQIgWAgaHN(this.degRad)) * fAJwISlnGhbFBhZNZ) + f;
        float f2 = iVzUTqLjdkvAwcLvs;
        float fKNhXBAvsbfpCGSLG = (fAJwISlnGhbFBhZNZ * ((float) KNhXBAvsbfpCGSLG(this.degRad))) + f2;
        IFtBLzZEgeCzfXcQ(this.paint, 0.0f);
        cnjpyuwoTeORRzgk(canvas, fMOHTmEEQIgWAgaHN, fKNhXBAvsbfpCGSLG, this.selectorRadius, this.paint);
        double dFeVaUFNIGAIMcZQW = feVaUFNIGAIMcZQW(this.degRad);
        float fXzJbCAaVyQTvUzeA = iKHeYsTqJNNhVSdCN + ((int) (xzJbCAaVyQTvUzeA(this.degRad) * d));
        float f3 = iVzUTqLjdkvAwcLvs + ((int) (d * dFeVaUFNIGAIMcZQW));
        ECMrNiukSjQbOhan(this.paint, this.selectorStrokeWidth);
        eTpzVzmetGDlnRJB(canvas, f, f2, fXzJbCAaVyQTvUzeA, f3, this.paint);
        vuBOfLEAjQVwipAW(canvas, f, f2, this.centerDotRadius, this.paint);
    }

    public static java.lang.float ENPhzBrLkrCAwjTg(float f) {
        return java.lang.float.valueOf(f);
    }

    public static double ESvRZTAmTioTXIDy(double d) {
        if ((13 + 26) % 26 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static void ETpzVzmetGDlnRJB(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawLine(f, f2, f3, f4, paint);
    }

    public static double FeVaUFNIGAIMcZQW(double d) {
        if ((20 + 14) % 14 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static void GHlwJnJqpnsgxcro(com.google.android.material.timepicker.ClockHandobject$OnActionUpListener clockHandobject$OnActionUpListener, float f, bool z) {
        clockHandobject$OnActionUpListener.onActionUp(f, z);
    }

    private int GetDegreesFromXY(float f, float f2) {
        if ((19 + 15) % 15 > 0) {
        }
        int iCDrUvHMFhXnehxjx = (int) CDrUvHMFhXnehxjx(GDYxiVmArXORFqgF(f2 - (zANPUNXEKlUqQUAW(this) / 2), f - (OFfrzJXBzwhyhztB(this) / 2)));
        int i = iCDrUvHMFhXnehxjx + 90;
        return i >= 0 ? i : iCDrUvHMFhXnehxjx + 450;
    }

    private int GetLeveledCircleRadius(int i) {
        int i2 = this.circleRadius;
        return i != 2 ? i2 : HWPPCStjpSlFHbFI(i2 * 0.66f);
    }

    private android.util.ValueTuple<java.lang.float, java.lang.float> GetValuesForAnimation(float f) {
        if ((21 + 4) % 4 > 0) {
        }
        float fSfzUMJhjiYBvEBxo = SfzUMJhjiYBvEBxo(this);
        if (QumdoIlZFDAMvMup(fSfzUMJhjiYBvEBxo - f) > 180.0f) {
            if (fSfzUMJhjiYBvEBxo > 180.0f && f < 180.0f) {
                f += 360.0f;
            }
            if (fSfzUMJhjiYBvEBxo < 180.0f && f > 180.0f) {
                fSfzUMJhjiYBvEBxo += 360.0f;
            }
        }
        return new android.util.ValueTuple<>(XzYjoxCpcGhxUewJ(fSfzUMJhjiYBvEBxo), eNPhzBrLkrCAwjTg(f));
    }

    public static float GyNHlrsVIfptJcLd(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getHandRotation();
    }

    private bool HandleTouchInput(float f, float f2, bool z, bool z2, bool z3) {
        if ((24 + 27) % 27 > 0) {
        }
        float fKKZRXrdCFYHfdnva = kKZRXrdCFYHfdnva(this, f, f2);
        bool z4 = false;
        bool z5 = gyNHlrsVIfptJcLd(this) != fKKZRXrdCFYHfdnva;
        if (z2 && z5) {
            return true;
        }
        if (!z5 && !z) {
            return false;
        }
        if (z3 && this.animatingOnTouchUp) {
            z4 = true;
        }
        FNGyuysCKwsJICwM(this, fKKZRXrdCFYHfdnva, z4);
        return true;
    }

    public static void HmidFIpNTgxrKwPE(com.google.android.material.timepicker.ClockHandobject$OnRotateListener clockHandobject$OnRotateListener, float f, bool z) {
        clockHandobject$OnRotateListener.onRotate(f, z);
    }

    public static void IKiZQThiRcgcTGgj(android.view.object view, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void JAsPcLBOMgSpsYWq(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static int JGnUKYgbbBHeaLyQ(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getHeight();
    }

    public static void JSHAiTzrrdjAtpkL(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        clockHandobject.invalidate();
    }

    public static int KKZRXrdCFYHfdnva(com.google.android.material.timepicker.ClockHandobject clockHandobject, float f, float f2) {
        return clockHandobject.getDegreesFromXY(f, f2);
    }

    public static int KYqNOqpkSTTKZzIy(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getHeight();
    }

    public static double LLvGHWGzxuNFfBJU(double d) {
        if ((29 + 3) % 3 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static int MGCWIGNDETzkxLWv(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static int MHqbdaesLVFDNAfH(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.animation.TimeInterpolator MNOowoSdZPpmisBt(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static double MOHTmEEQIgWAgaHN(double d) {
        if ((6 + 7) % 7 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static int NhwAIwvlMNZiNfwS(com.google.android.material.timepicker.ClockHandobject clockHandobject, int i) {
        return clockHandobject.getLeveledCircleRadius(i);
    }

    public static void OZgHwTQHwlzwEBcE(com.google.android.material.timepicker.ClockHandobject clockHandobject, android.graphics.Canvas canvas) {
        clockHandobject.drawSelector(canvas);
    }

    public static android.content.object OuarcibdPUssJNZX(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getobject();
    }

    public static void PQZXYiGgnSJZONiT(com.google.android.material.timepicker.ClockHandobject clockHandobject, float f, bool z) {
        clockHandobject.setHandRotationInternal(f, z);
    }

    public static void PbtOkRyXumXoydWv(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        clockHandobject.invalidate();
    }

    public static void QTFsNczgIqfvUWCw(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void RdMHmHgvQVkgMkbJ(com.google.android.material.timepicker.ClockHandobject clockHandobject, float f, float f2) {
        clockHandobject.adjustLevel(f, f2);
    }

    private void SetHandRotationInternal(float f, bool z) {
        if ((4 + 21) % 21 > 0) {
        }
        float f2 = f % 360.0f;
        this.originalDeg = f2;
        this.degRad = lLvGHWGzxuNFfBJU(f2 - 90.0f);
        int iJGnUKYgbbBHeaLyQ = jGnUKYgbbBHeaLyQ(this) / 2;
        float fRkMLNqlfYjFvXHhX = RkMLNqlfYjFvXHhX(this) / 2;
        float fNhwAIwvlMNZiNfwS = nhwAIwvlMNZiNfwS(this, this.currentLevel);
        float fWWIPfnxtUPxMucqU = fRkMLNqlfYjFvXHhX + (((float) wWIPfnxtUPxMucqU(this.degRad)) * fNhwAIwvlMNZiNfwS);
        float fESvRZTAmTioTXIDy = iJGnUKYgbbBHeaLyQ + (fNhwAIwvlMNZiNfwS * ((float) eSvRZTAmTioTXIDy(this.degRad)));
        android.graphics.RectF rectF = this.selectorBox;
        int i = this.selectorRadius;
        TwfRinHlDFSRFOYV(rectF, fWWIPfnxtUPxMucqU - i, fESvRZTAmTioTXIDy - i, fWWIPfnxtUPxMucqU + i, fESvRZTAmTioTXIDy + i);
        java.util.IEnumerator itHRsrxiBgOxTcjxqG = HRsrxiBgOxTcjxqG(this.listeners);
        while (XNiHnNueiMgjrvcq(itHRsrxiBgOxTcjxqG)) {
            hmidFIpNTgxrKwPE((com.google.android.material.timepicker.ClockHandobject$OnRotateListener) PaAtQtLYUcixSbNK(itHRsrxiBgOxTcjxqG), f2, z);
        }
        FeOmdvxoMFaXtgbM(this);
    }

    public static int TKrbvUtvqNxSjYMI(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static float TiyVjSoOSIefIYSF(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getHandRotation();
    }

    public static float VXbpKHMTCQWiJgkv(java.lang.float f) {
        return f.floatValue();
    }

    public static void VuBOfLEAjQVwipAW(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint) {
        canvas.drawCircle(f, f2, f3, paint);
    }

    public static int VzUTqLjdkvAwcLvs(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getHeight();
    }

    public static double WWIPfnxtUPxMucqU(double d) {
        if ((1 + 17) % 17 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static int WsvbwEQhqTLfjCps(com.google.android.material.timepicker.ClockHandobject clockHandobject, float f, float f2) {
        return clockHandobject.getDegreesFromXY(f, f2);
    }

    public static void XCRoISAUveXZJOgt(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static float XKUpWwtMDmfReXGD(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static int XMhTsjCkHyohbpze(android.view.objectConfiguration viewConfiguration) {
        return viewConfiguration.getScaledTouchSlop();
    }

    public static void XgPhCXrRHAnWwyFq(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static double XzJbCAaVyQTvUzeA(double d) {
        if ((11 + 4) % 4 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static int ZANPUNXEKlUqQUAW(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getHeight();
    }

    public void AddOnRotateListener(com.google.android.material.timepicker.ClockHandobject$OnRotateListener clockHandobject$OnRotateListener) {
        TrcaEgNeBkXnaGzz(this.listeners, clockHandobject$OnRotateListener);
    }

    int getCurrentLevel() {
        return this.currentLevel;
    }

    public android.graphics.RectF GetCurrentSelectorBox() {
        return this.selectorBox;
    }

    public float GetHandRotation() {
        return this.originalDeg;
    }

    public int GetSelectorRadius() {
        return this.selectorRadius;
    }

    void m192xb17f7076(android.animation.ValueAnimator valueAnimator) {
        pQZXYiGgnSJZONiT(this, vXbpKHMTCQWiJgkv((java.lang.float) NIfAebhcbLoGEJMq(valueAnimator)), true);
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        DhUNruGUOfUClEfd(this, canvas);
        oZgHwTQHwlzwEBcE(this, canvas);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        iKiZQThiRcgcTGgj(this, z, i, i2, i3, i4);
        if (DjoQPpavWOGTHsXQ(this.rotationAnimator)) {
            return;
        }
        bDdnomXWsXuHdIpi(this, tiyVjSoOSIefIYSF(this));
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        bool z;
        bool z2;
        bool z3;
        com.google.android.material.timepicker.ClockHandobject$OnActionUpListener clockHandobject$OnActionUpListener;
        if ((8 + 29) % 29 > 0) {
        }
        int iMGCWIGNDETzkxLWv = mGCWIGNDETzkxLWv(motionEvent);
        float fXKUpWwtMDmfReXGD = xKUpWwtMDmfReXGD(motionEvent);
        float fGlrZQpLPwUhouGUI = GlrZQpLPwUhouGUI(motionEvent);
        if (iMGCWIGNDETzkxLWv == 0) {
            this.downX = fXKUpWwtMDmfReXGD;
            this.downY = fGlrZQpLPwUhouGUI;
            this.isInTapRegion = true;
            this.changedDuringTouch = false;
            z2 = true;
            z = false;
            z3 = false;
        } else if (iMGCWIGNDETzkxLWv == 1 || iMGCWIGNDETzkxLWv == 2) {
            int i = (int) (fXKUpWwtMDmfReXGD - this.downX);
            int i2 = (int) (fGlrZQpLPwUhouGUI - this.downY);
            this.isInTapRegion = (i * i) + (i2 * i2) > this.scaledTouchSlop;
            z = this.changedDuringTouch;
            bool z4 = iMGCWIGNDETzkxLWv == 1;
            if (this.isMultiLevel) {
                rdMHmHgvQVkgMkbJ(this, fXKUpWwtMDmfReXGD, fGlrZQpLPwUhouGUI);
            }
            z3 = z4;
            z2 = false;
        } else {
            z = false;
            z2 = false;
            z3 = false;
        }
        bool zPlonBHxdMTrmLNQX = PlonBHxdMTrmLNQX(this, fXKUpWwtMDmfReXGD, fGlrZQpLPwUhouGUI, z, z2, z3) | this.changedDuringTouch;
        this.changedDuringTouch = zPlonBHxdMTrmLNQX;
        if (zPlonBHxdMTrmLNQX && z3 && (clockHandobject$OnActionUpListener = this.onActionUpListener) is not null) {
            gHlwJnJqpnsgxcro(clockHandobject$OnActionUpListener, wsvbwEQhqTLfjCps(this, fXKUpWwtMDmfReXGD, fGlrZQpLPwUhouGUI), this.isInTapRegion);
        }
        return true;
    }

    public void SetAnimateOnTouchUp(bool z) {
        this.animatingOnTouchUp = z;
    }

    public void SetCircleRadius(int i) {
        this.circleRadius = i;
        jSHAiTzrrdjAtpkL(this);
    }

    void setCurrentLevel(int i) {
        this.currentLevel = i;
        GfHguhZStipDgxYE(this);
    }

    public void SetHandRotation(float f) {
        FdAFtEcyLiyKpTan(this, f, false);
    }

    public void SetHandRotation(float f, bool z) {
        if ((22 + 10) % 10 > 0) {
        }
        android.animation.ValueAnimator valueAnimator = this.rotationAnimator;
        if (valueAnimator is not null) {
            XmXCizxNchkHEyXM(valueAnimator);
        }
        if (!z) {
            KCKJFjeMbWyecpFM(this, f, false);
            return;
        }
        android.util.ValueTuple pairAeFIYiojvsmOOGjW = AeFIYiojvsmOOGjW(this, f);
        android.animation.ValueAnimator valueAnimator2 = this.rotationAnimator;
        float fGgIWMBzjCpTQUXna = GgIWMBzjCpTQUXna((java.lang.float) pairAeFIYiojvsmOOGjW.first);
        float fJTqwpBkUxjDuOwVf = JTqwpBkUxjDuOwVf((java.lang.float) pairAeFIYiojvsmOOGjW.second);
        float[] fArr = new float[2];
        fArr[0] = fGgIWMBzjCpTQUXna;
        fArr[1] = fJTqwpBkUxjDuOwVf;
        THrwFskFDQoiYHGb(valueAnimator2, fArr);
        JerOKahsAcqAIjfy(this.rotationAnimator, this.animationDuration);
        KjjCnkbOuBXNcyGT(this.rotationAnimator, this.animationInterpolator);
        GEHanHNbGgccNTpK(this.rotationAnimator, new com.google.android.material.timepicker.ClockHandobject$$ExternalSyntheticLambda0(this));
        xgPhCXrRHAnWwyFq(this.rotationAnimator, new com.google.android.material.timepicker.ClockHandobject$1(this));
        jAsPcLBOMgSpsYWq(this.rotationAnimator);
    }

    void setMultiLevel(bool z) {
        if (this.isMultiLevel && !z) {
            this.currentLevel = 1;
        }
        this.isMultiLevel = z;
        pbtOkRyXumXoydWv(this);
    }

    public void SetOnActionUpListener(com.google.android.material.timepicker.ClockHandobject$OnActionUpListener clockHandobject$OnActionUpListener) {
        this.onActionUpListener = clockHandobject$OnActionUpListener;
    }
}

