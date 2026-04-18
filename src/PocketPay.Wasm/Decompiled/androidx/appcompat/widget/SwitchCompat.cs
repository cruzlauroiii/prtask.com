namespace WillowMaze.Wasm.Decompiled;


public class SwitchCompat : android.widget.CompoundButton : androidx.appcompat.widget.EmojiCompatConfigurationobject {
    private static readonly java.lang.string ACCESSIBILITY_EVENT_CLASS_NAME = "android.widget.Switch";
    private static readonly int[] CHECKED_STATE_SET;
    private static readonly int MONOSPACE = 3;
    private static readonly int SANS = 1;
    private static readonly int SERIF = 2;
    private static readonly int THUMB_ANIMATION_DURATION = 250;
    private static readonly android.util.Property<androidx.appcompat.widget.SwitchCompat, java.lang.float> THUMB_POS;
    private static readonly int TOUCH_MODE_DOWN = 1;
    private static readonly int TOUCH_MODE_DRAGGING = 2;
    private static readonly int TOUCH_MODE_IDLE = 0;
    private androidx.appcompat.widget.AppCompatEmojiTextHelper mAppCompatEmojiTextHelper;
    private androidx.appcompat.widget.SwitchCompat$EmojiCompatInitCallback mEmojiCompatInitCallback;
    private bool mEnforceSwitchWidth;
    private bool mHasThumbTint;
    private bool mHasThumbTintMode;
    private bool mHasTrackTint;
    private bool mHasTrackTintMode;
    private int mMinFlingVelocity;
    private android.text.Layout mOffLayout;
    private android.text.Layout mOnLayout;
    android.animation.objectAnimator mPositionAnimator;
    private bool mShowText;
    private bool mSplitTrack;
    private int mSwitchBottom;
    private int mSwitchHeight;
    private int mSwitchLeft;
    private int mSwitchMinWidth;
    private int mSwitchPadding;
    private int mSwitchRight;
    private int mSwitchTop;
    private android.text.method.TransformationMethod mSwitchTransformationMethod;
    private int mSwitchWidth;
    private readonly android.graphics.Rect mTempRect;
    private android.content.res.ColorStateList mTextColors;
    private readonly androidx.appcompat.widget.AppCompatTextHelper mTextHelper;
    private java.lang.CharSequence mTextOff;
    private java.lang.CharSequence mTextOffTransformed;
    private java.lang.CharSequence mTextOn;
    private java.lang.CharSequence mTextOnTransformed;
    private readonly android.text.TextPaint mTextPaint;
    private android.graphics.drawable.Drawable mThumbDrawable;
    float mThumbPosition;
    private int mThumbTextPadding;
    private android.content.res.ColorStateList mThumbTintList;
    private android.graphics.PorterDuff$Mode mThumbTintMode;
    private int mThumbWidth;
    private int mTouchMode;
    private int mTouchSlop;
    private float mTouchX;
    private float mTouchY;
    private android.graphics.drawable.Drawable mTrackDrawable;
    private android.content.res.ColorStateList mTrackTintList;
    private android.graphics.PorterDuff$Mode mTrackTintMode;
    private android.view.VelocityTracker mVelocityTracker;

    static {
        if ((25 + 23) % 23 > 0) {
        }
        THUMB_POS = new androidx.appcompat.widget.SwitchCompat$1(java.lang.float.class, "thumbPos");
        CHECKED_STATE_SET = new int[]{16842912};
    }

    public SwitchCompat(android.content.object context) {
        this(context, null);
    }

    public SwitchCompat(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.switchStyle);
    }

    public SwitchCompat(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((10 + 1) % 1 > 0) {
        }
        this.mThumbTintList = null;
        this.mThumbTintMode = null;
        this.mHasThumbTint = false;
        this.mHasThumbTintMode = false;
        this.mTrackTintList = null;
        this.mTrackTintMode = null;
        this.mHasTrackTint = false;
        this.mHasTrackTintMode = false;
        this.mVelocityTracker = PlgwynVFDqsFNROs();
        this.mEnforceSwitchWidth = true;
        this.mTempRect = new android.graphics.Rect();
        RfYYUHxMbunmFEfr(this, nbNyOSyeaVvgdAuH(this));
        android.text.TextPaint textPaint = new android.text.TextPaint(1);
        this.mTextPaint = textPaint;
        textPaint.density = DueyWUYqQiHhFMxO(kMyBPMydyvICPGLG(this)).density;
        androidx.appcompat.widget.TintTypedArray tintTypedArrayPzUFGyHyferFzaOY = pzUFGyHyferFzaOY(context, attributeHashSet, androidx.appcompat.R$styleable.SwitchCompat, i, 0);
        uYuJTcpHveXIBqWl(this, context, androidx.appcompat.R$styleable.SwitchCompat, attributeHashSet, ieyUGQpusfPirzZF(tintTypedArrayPzUFGyHyferFzaOY), i, 0);
        android.graphics.drawable.Drawable drawablePhaFGDNoTGtYvBLW = phaFGDNoTGtYvBLW(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_android_thumb);
        this.mThumbDrawable = drawablePhaFGDNoTGtYvBLW;
        if (drawablePhaFGDNoTGtYvBLW is not null) {
            XWONhmZEqRHqrxTw(drawablePhaFGDNoTGtYvBLW, this);
        }
        android.graphics.drawable.Drawable drawablePzhAHUArNQUjXTzP = pzhAHUArNQUjXTzP(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_track);
        this.mTrackDrawable = drawablePzhAHUArNQUjXTzP;
        if (drawablePzhAHUArNQUjXTzP is not null) {
            zqMNmcqydlcvnBNG(drawablePzhAHUArNQUjXTzP, this);
        }
        FNsiEdHCFzpKPVzM(this, tLKAqXZkXSABmXIu(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_android_textOn));
        QdDoUBQMLQedjpyZ(this, RgnMkwpbWmWIuCfz(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_android_textOff));
        this.mShowText = QJRHCiPlZJOpVxqX(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_showText, true);
        this.mThumbTextPadding = zgOfpGsXKrrwIszt(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_thumbTextPadding, 0);
        this.mSwitchMinWidth = tPPEjcwVpmMsotSu(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_switchMinWidth, 0);
        this.mSwitchPadding = QGmfmsPlbYSqXQFT(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_switchPadding, 0);
        this.mSplitTrack = APLsPgQrSmAqNjyS(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_splitTrack, false);
        android.content.res.ColorStateList colorStateListWKNemtkSfVTSQKbJ = WKNemtkSfVTSQKbJ(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_thumbTint);
        if (colorStateListWKNemtkSfVTSQKbJ is not null) {
            this.mThumbTintList = colorStateListWKNemtkSfVTSQKbJ;
            this.mHasThumbTint = true;
        }
        android.graphics.PorterDuff$Mode porterDuff$ModeBCKANHdQOONLJOve = bCKANHdQOONLJOve(qpEbjarFyDWFAejj(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_thumbTintMode, -1), null);
        if (this.mThumbTintMode != porterDuff$ModeBCKANHdQOONLJOve) {
            this.mThumbTintMode = porterDuff$ModeBCKANHdQOONLJOve;
            this.mHasThumbTintMode = true;
        }
        if (this.mHasThumbTint || this.mHasThumbTintMode) {
            hViybpztlyaWZMaD(this);
        }
        android.content.res.ColorStateList colorStateListMPeXPMOrVNSiwcaE = mPeXPMOrVNSiwcaE(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_trackTint);
        if (colorStateListMPeXPMOrVNSiwcaE is not null) {
            this.mTrackTintList = colorStateListMPeXPMOrVNSiwcaE;
            this.mHasTrackTint = true;
        }
        android.graphics.PorterDuff$Mode porterDuff$ModeZRmIULXzfmokYxWn = ZRmIULXzfmokYxWn(mFnDAnCjoIehhlgN(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_trackTintMode, -1), null);
        if (this.mTrackTintMode != porterDuff$ModeZRmIULXzfmokYxWn) {
            this.mTrackTintMode = porterDuff$ModeZRmIULXzfmokYxWn;
            this.mHasTrackTintMode = true;
        }
        if (this.mHasTrackTint || this.mHasTrackTintMode) {
            kgapwmMKYcohbDmm(this);
        }
        int iOgiSMUWtegxeXqcM = OgiSMUWtegxeXqcM(tintTypedArrayPzUFGyHyferFzaOY, androidx.appcompat.R$styleable.SwitchCompat_switchTextAppearance, 0);
        if (iOgiSMUWtegxeXqcM != 0) {
            WElCCESRDqdNrrNs(this, context, iOgiSMUWtegxeXqcM);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = new androidx.appcompat.widget.AppCompatTextHelper(this);
        this.mTextHelper = appCompatTextHelper;
        AUBqjQatRolapxko(appCompatTextHelper, attributeHashSet, i);
        BMNEhsoKdFEsoqCF(tintTypedArrayPzUFGyHyferFzaOY);
        android.view.objectConfiguration viewConfigurationVJjYcGtwabiwHsAJ = vJjYcGtwabiwHsAJ(context);
        this.mTouchSlop = dMQTSXtFWRukyjIy(viewConfigurationVJjYcGtwabiwHsAJ);
        this.mMinFlingVelocity = HKbvdlJklpwlELfz(viewConfigurationVJjYcGtwabiwHsAJ);
        XsbEKXkCrrblwZdU(TOyLlEeLYrgMvvPX(this), attributeHashSet, i);
        maAQgHNanhqwKfvZ(this);
        wMJQGARhGOcLOhlB(this, orLOFfZuFHYdClKV(this));
    }

    public static bool AGYhgaSNwCmFWpJT(android.widget.CompoundButton compoundButton, android.graphics.drawable.Drawable drawable) {
        return super.verifyDrawable(drawable);
    }

    public static bool ALBmFdNakjcfBbuT(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static bool APLsPgQrSmAqNjyS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static void AUBqjQatRolapxko(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void AiNKqTTpRQtcSrQf(android.text.TextPaint textPaint, float f) {
        textPaint.setTextSkewX(f);
    }

    public static void ArRaEbLgpSVAcXJY(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.setOffStateDescriptionOnRAndAbove();
    }

    public static int AymKnNzdDxLwdJET(android.widget.CompoundButton compoundButton) {
        return super.getCompoundPaddingLeft();
    }

    public static int BFWEkelifsAOBrIJ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void BMNEhsoKdFEsoqCF(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static float BNAccuxuTUyOWzAh(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static bool BbSlvBprMOZaGZxW(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static androidx.appcompat.widget.TintTypedArray BlwJyRpiBUdRNEZt(android.content.object context, int i, int[] iArr) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, i, iArr);
    }

    public static void BswXgVHhuwIxPkCU(android.widget.CompoundButton compoundButton, float f, float f2) {
        super.drawableHotspotChanged(f, f2);
    }

    public static android.content.object CCgQHTdHxFszQmiJ(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getobject();
    }

    public static int CIpFzMaukUDQujkZ(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getWidth();
    }

    public static int CaZEZmXHxEYywFJx(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getMeasuredWidthAndState();
    }

    public static int ClVwAfBbXKRVcPUb(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int CtGvwSCIcGlumhJL(android.text.Layout layout) {
        return layout.getWidth();
    }

    public static void CwDIHKGlxxeXNJGt(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.requestLayout();
    }

    public static bool DBcVhrCqdhOtBxqC(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.isEnabled();
    }

    public static void DGXhPLtQEvwwTaIq(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static android.graphics.Typeface DLDLCWCGIiuUUQfk(android.text.TextPaint textPaint) {
        return textPaint.getTypeface();
    }

    public static int DNsBJmHjVXrUNqha(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void DfmctjQOLEWSNUBQ(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void DuOFAHwLBqHxasqf(android.widget.CompoundButton compoundButton) {
        super.drawableStateChanged();
    }

    public static android.util.DisplayMetrics DueyWUYqQiHhFMxO(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static void EFtcFVGPZKQAkebc(android.widget.CompoundButton compoundButton, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(accessibilityEvent);
    }

    public static int EizumpiANqrfMFyo(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static java.lang.CharSequence ErTitixAcyNmzGKu(android.text.method.TransformationMethod transformationMethod, java.lang.CharSequence charSequence, android.view.object view) {
        return transformationMethod.getTransformation(charSequence, view);
    }

    public static android.graphics.Rect FMJfAAFOWzJablqP(android.graphics.drawable.Drawable drawable) {
        return androidx.appcompat.widget.DrawableUtils.getOpticalBounds(drawable);
    }

    public static void FMuMtifmlIXmBJvH(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.invalidate();
    }

    public static void FNsiEdHCFzpKPVzM(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        switchCompat.setTextOnInternal(charSequence);
    }

    public static int FPHPNzebzmHysqjw(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool FVqbVaqTbQwQaPUq(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static int FkNyKcsYPqsQdIUi(android.text.Layout layout) {
        return layout.getWidth();
    }

    public static void FlkappJKMBYOggzD(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static bool GBtSKExNPAqNdGEH(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static int GFyIqYTcJkzdudZC(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getPaddingTop();
    }

    public static void GUKOTdWRAFIILYWQ(android.view.VelocityTracker velocityTracker) {
        velocityTracker.clear();
    }

    public static int[] GfizBkpJCpPZfOeg(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getDrawableState();
    }

    public static int GhExaEcoOvoiCGlN(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getGravity();
    }

    public static int HKbvdlJklpwlELfz(android.view.objectConfiguration viewConfiguration) {
        return viewConfiguration.getScaledMinimumFlingVelocity();
    }

    public static bool HPqoeQjFmmdDSCEe(android.graphics.Typeface typeface, java.lang.object obj) {
        return typeface.Equals(obj);
    }

    public static android.content.res.Resources HRMItSkAyVldNmnD(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getResources();
    }

    public static android.content.object HSQseYwWjzFmVpDb(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getobject();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper HUqdolKNxWwxGcYw(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getEmojiTextobjectHelper();
    }

    public static bool HVjUjoZFsgIVBhaX(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void HWMApqwTmudNZhPD(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        switchCompat.setTextOffInternal(charSequence);
    }

    public static void HuAuWEtdqbHFqYan(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.requestLayout();
    }

    public static bool HyzGcQEspxcmnira(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.isChecked();
    }

    public static void IIQxkykPbcZRGnJu(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        switchCompat.setTextOffInternal(charSequence);
    }

    public static int IRGCcyYtWEUKxtun(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static android.graphics.Rect ItMOgFoHEJfTyOLK(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static bool JJVRjwIbgMxCnFhh(android.widget.CompoundButton compoundButton, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static void JOdokeUARZgLlSwv(android.widget.CompoundButton compoundButton, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static bool JkBaduhWQGYrCqPu(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper) {
        return appCompatEmojiTextHelper.isEnabled();
    }

    public static float JksGVjFTpixBiZvb(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static void JrRzgqtUsnuxyTeZ(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void JrjFoKMRDYSZCKdw(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.invalidate();
    }

    public static void KScswHVAtkYxDtBo(androidx.appcompat.widget.SwitchCompat switchCompat, android.view.MotionEvent motionEvent) {
        switchCompat.stopDrag(motionEvent);
    }

    public static void KlZdMJbjxYgIobeB(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.requestLayout();
    }

    public static bool KuBoqKBySSEZmJtA(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getTargetCheckedState();
    }

    public static bool LKkmElwvlznhBTiH(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static void LPNjILkrpXvRhZgO(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static bool LTTqeLuQVcWqlYRh(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper) {
        return appCompatEmojiTextHelper.isEnabled();
    }

    public static float LWAEWffsCwZgFWud(android.text.TextPaint textPaint) {
        return textPaint.getTextSize();
    }

    public static int[] LcCmCTuJPSBCzZtE(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getDrawableState();
    }

    public static android.text.InputFilter[] LdjfnIeZAkFiASpq(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.text.InputFilter[] inputFilterArr) {
        return appCompatEmojiTextHelper.getFilters(inputFilterArr);
    }

    public static void LeAGKzOAJZYDPXtX(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.applyThumbTint();
    }

    public static void LpBXPdUShhLKnFIT(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        drawable.copyBounds(rect);
    }

    public static android.graphics.drawable.Drawable LvzsIASsvqTcMsSL(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getBackground();
    }

    public static void MBwTkgQKFKZMiHCj(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.requestLayout();
    }

    public static android.graphics.Rect MUzYKskxoiKXuXAQ(android.graphics.drawable.Drawable drawable) {
        return androidx.appcompat.widget.DrawableUtils.getOpticalBounds(drawable);
    }

    public static int MlIUBsSWNGRuUgAG(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getThumbOffset();
    }

    public static void MwxeqVBQlHAzDpSt(android.graphics.drawable.Drawable drawable) {
        drawable.jumpToCurrentState();
    }

    public static java.util.List MxqYXYaZBfJmUEof(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return accessibilityEvent.getText();
    }

    public static void NGAeggdXLipqiUYs(android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.CharSequence charSequence) {
        accessibilityEvent.setClassName(charSequence);
    }

    public static android.content.res.ColorStateList NJrKfJtoYxQNfJag(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static int NKmsSEnbqYrTGgMY(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void NYuLUbwssnQwXENJ(androidx.appcompat.widget.SwitchCompat switchCompat, bool z) {
        switchCompat.setChecked(z);
    }

    public static bool NbxDoeoxXkseRGul(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static void NjVmqxPRHDEHSffI(android.view.MotionEvent motionEvent, int i) {
        motionEvent.setAction(i);
    }

    public static bool NxMpgijlkZiQwulk(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static int OHFQtvKaVmYPhcpl(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getPaddingBottom();
    }

    public static void OajNvAWPMpZDOxzJ(android.text.TextPaint textPaint, bool z) {
        textPaint.setFakeBoldText(z);
    }

    public static int OgiSMUWtegxeXqcM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void OibOSgRKfcsJGbTV(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        androidx.core.graphics.drawable.DrawableCompat.setHotspotBounds(drawable, i, i2, i3, i4);
    }

    public static bool OpIbkMDcFyNwOlpl(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static int OyxyNHqPsasCgIcH(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void PBhikRyFTAWsdcTJ(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static int[] PLTfhVYVRekCgpHh(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getDrawableState();
    }

    public static int PVnCfhxjSuQSmFQK(android.widget.CompoundButton compoundButton) {
        return super.getCompoundPaddingLeft();
    }

    public static android.view.objectParent PkXwbfDvgtOEkRHV(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getParent();
    }

    public static android.view.VelocityTracker PlgwynVFDqsFNROs() {
        return android.view.VelocityTracker.obtain();
    }

    public static void PnlddiMlYVcsdOSp(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.Typeface typeface, int i) {
        switchCompat.setSwitchTypeface(typeface, i);
    }

    public static void QCOGntTnBNLHjpLO(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.setupEmojiCompatLoadCallback();
    }

    public static void QFfIOrTmDEdlKVRl(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.drawable.Drawable drawable) {
        switchCompat.setTrackDrawable(drawable);
    }

    public static void QGfrflWfbZqBXRvD(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static int QGmfmsPlbYSqXQFT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static int QHsGXBLNmybzyyBF(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static bool QJRHCiPlZJOpVxqX(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static void QdDoUBQMLQedjpyZ(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        switchCompat.setTextOffInternal(charSequence);
    }

    public static java.lang.CharSequence QlqRNNlZnVRJrWwR(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getText();
    }

    public static android.graphics.Typeface QnzcjSMWwbVfaBHM(android.text.TextPaint textPaint, android.graphics.Typeface typeface) {
        return textPaint.setTypeface(typeface);
    }

    public static void REOrXGwtOqKDCsTx(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.requestLayout();
    }

    public static void RJEYPFZFDzrRJfHW(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.invalidate();
    }

    public static android.graphics.Typeface RPWYUAfrpdDTicTq(int i) {
        return android.graphics.Typeface.defaultFromStyle(i);
    }

    public static bool RfUhKaXyALEcKfFO(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Region$Op region$Op) {
        return canvas.clipRect(rect, region$Op);
    }

    public static void RfYYUHxMbunmFEfr(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static java.lang.CharSequence RgnMkwpbWmWIuCfz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static void RoiIYVVzSqLsPgik(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        switchCompat.setTextOnInternal(charSequence);
    }

    public static bool RvssaZSfSubeyqod() {
        return androidx.emoji2.text.EmojiCompat.isConfigured();
    }

    public static void SJddoUJhplTHiKHg(android.graphics.drawable.Drawable drawable) {
        drawable.jumpToCurrentState();
    }

    public static bool SUMmwvGlXFYYttpK(android.widget.CompoundButton compoundButton, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static android.view.MotionEvent SXGZfNNQqGSpGyFW(android.view.MotionEvent motionEvent) {
        return android.view.MotionEvent.obtain(motionEvent);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper SdhBFMWiJljQFZDz(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getEmojiTextobjectHelper();
    }

    public static void SlNziIhKhSdUgFbl(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.setOnStateDescriptionOnRAndAbove();
    }

    public static void SpLpRInojdNHrtwC(androidx.appcompat.widget.SwitchCompat switchCompat, bool z) {
        switchCompat.animateThumbToCheckedState(z);
    }

    public static float SyTGURghtkVyIxRn(java.lang.CharSequence charSequence, android.text.TextPaint textPaint) {
        return android.text.Layout.getDesiredWidth(charSequence, textPaint);
    }

    public static bool TLmgaBmJVRviyPnr(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.isChecked();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper TOyLlEeLYrgMvvPX(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getEmojiTextobjectHelper();
    }

    public static void TzwuwOebkfssSWFl(android.text.TextPaint textPaint, float f) {
        textPaint.setTextSize(f);
    }

    public static void UGHiCJSMEAvHFBoV(android.widget.CompoundButton compoundButton, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static android.graphics.drawable.Drawable UJHaFzqehtLjOYDc(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void URvoLKLAqrIlCVVZ(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setAllCaps(z);
    }

    public static void UjSiwVkMIwOeadqv(android.animation.objectAnimator objectAnimator) {
        objectAnimator.cancel();
    }

    public static void UuMpbZMWQuazaZOe(android.widget.CompoundButton compoundButton, android.view.ActionMode$Callback actionMode$Callback) {
        super.setCustomSelectionActionModeCallback(actionMode$Callback);
    }

    public static void UwDezxUvdNjLyEou(android.widget.CompoundButton compoundButton, android.graphics.Canvas canvas) {
        super.onDraw(canvas);
    }

    public static float VdFxPkRprqJPrbiC(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void WElCCESRDqdNrrNs(androidx.appcompat.widget.SwitchCompat switchCompat, android.content.object context, int i) {
        switchCompat.setSwitchTextAppearance(context, i);
    }

    public static void WIbUubYmEgDuDLsN(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        switchCompat.setTextOffInternal(charSequence);
    }

    public static android.content.res.ColorStateList WKNemtkSfVTSQKbJ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static bool WSuTKtzykszSpVAq(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void WaYIOUaxbusPQZhd(android.text.TextPaint textPaint, int i) {
        textPaint.setColor(i);
    }

    public static bool WdgxFiTLjnLOcOXQ(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static void WhQEhXBedTjYGoxc(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.core.view.objectCompat.setStateDescription(view, charSequence);
    }

    public static void WvuPSxysxWRyozbu(androidx.appcompat.widget.SwitchCompat switchCompat, bool z) {
        switchCompat.setChecked(z);
    }

    public static int WwloUPIXtVzmRWjk(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getHeight();
    }

    public static android.text.method.TransformationMethod XBHWHlUCgBlGXxzf(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.text.method.TransformationMethod transformationMethod) {
        return appCompatEmojiTextHelper.wrapTransformationMethod(transformationMethod);
    }

    public static int[] XMrUcfklXwnEYNmc(android.widget.CompoundButton compoundButton, int i) {
        return super.onCreateDrawableState(i);
    }

    public static int XWFMlamWgVUpxfVW(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void XWONhmZEqRHqrxTw(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static int XYBwNZSbhpzmAXnI(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static int XbwUZDdSbHyjgReM(android.widget.CompoundButton compoundButton) {
        return super.getCompoundPaddingRight();
    }

    public static void XdHVjhRybuPKWtAe(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setClassName(charSequence);
    }

    public static int XpipLNZQsuTVrTKT(android.text.Layout layout) {
        return layout.getHeight();
    }

    public static void XsbEKXkCrrblwZdU(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatEmojiTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static android.graphics.Rect YEtyxGexWdiAGsMk(android.graphics.drawable.Drawable drawable) {
        return androidx.appcompat.widget.DrawableUtils.getOpticalBounds(drawable);
    }

    public static void YGdlVCxDikshUOqv(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.requestLayout();
    }

    public static int YOkzuSuOXOjuYNOk(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getThumbOffset();
    }

    public static android.graphics.Rect YluHxonnGNWwFRQf(android.graphics.drawable.Drawable drawable) {
        return androidx.appcompat.widget.DrawableUtils.getOpticalBounds(drawable);
    }

    public static int YmzEGkflUNXGguYw(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void YqhHTssXSkWCMtSs(android.animation.objectAnimator objectAnimator) {
        objectAnimator.start();
    }

    public static bool YrZvxVnxpFghHLeW(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static void ZGWJgaZEAcXBliYD(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        switchCompat.setTextOnInternal(charSequence);
    }

    public static android.graphics.PorterDuff$Mode ZRmIULXzfmokYxWn(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return androidx.appcompat.widget.DrawableUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static void ZTvbAZJODfsjKfjc(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.drawable.Drawable drawable) {
        switchCompat.setThumbDrawable(drawable);
    }

    public static float AHXEaxsHqmABgApS(float f) {
        return java.lang.Math.abs(f);
    }

    public static void AHsCfkISIffKbQeB(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static bool AMZayyrwFqImRRSP(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static void APSZCYyXNaeQgVXD(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.invalidate();
    }

    public static void AVYsOkiVdJKgGvbd(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.invalidate();
    }

    public static android.os.IBinder AibeuzJFxSlkzjgL(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getWindowToken();
    }

    public static bool AldDmDKOMqmlGKCL(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.isEnabled();
    }

    public static java.lang.CharSequence AlytNdkCrOLFiXbR(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        return switchCompat.doTransformForOnOffText(charSequence);
    }

    private void AnimateThumbToCheckedState(bool z) {
        if ((25 + 9) % 9 > 0) {
        }
        float f = !z ? 0.0f : 1.0f;
        android.util.Property<androidx.appcompat.widget.SwitchCompat, java.lang.float> property = THUMB_POS;
        float[] fArr = new float[1];
        fArr[0] = f;
        android.animation.objectAnimator objectAnimatorHpjnkqdNwYZmfUxL = hpjnkqdNwYZmfUxL(this, property, fArr);
        this.mPositionAnimator = objectAnimatorHpjnkqdNwYZmfUxL;
        jGgpabgDcesLmzgC(objectAnimatorHpjnkqdNwYZmfUxL, 250L);
        tVCHLmYoHhAlwpNK(this.mPositionAnimator, true);
        YqhHTssXSkWCMtSs(this.mPositionAnimator);
    }

    private void ApplyThumbTint() {
        if ((5 + 3) % 3 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.mThumbDrawable;
        if (drawable is null) {
            return;
        }
        if (this.mHasThumbTint || this.mHasThumbTintMode) {
            android.graphics.drawable.Drawable drawableRuKouBJwxuAKizHr = ruKouBJwxuAKizHr(UJHaFzqehtLjOYDc(drawable));
            this.mThumbDrawable = drawableRuKouBJwxuAKizHr;
            if (this.mHasThumbTint) {
                aHsCfkISIffKbQeB(drawableRuKouBJwxuAKizHr, this.mThumbTintList);
            }
            if (this.mHasThumbTintMode) {
                bNGaHPMjivohvBeh(this.mThumbDrawable, this.mThumbTintMode);
            }
            if (kNoLFnyWBTdihLPb(this.mThumbDrawable)) {
                GBtSKExNPAqNdGEH(this.mThumbDrawable, GfizBkpJCpPZfOeg(this));
            }
        }
    }

    private void ApplyTrackTint() {
        if ((24 + 15) % 15 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.mTrackDrawable;
        if (drawable is null) {
            return;
        }
        if (this.mHasTrackTint || this.mHasTrackTintMode) {
            android.graphics.drawable.Drawable drawableRBmusGiOlKMiFNjl = rBmusGiOlKMiFNjl(pzTAiUauHMaUyHEs(drawable));
            this.mTrackDrawable = drawableRBmusGiOlKMiFNjl;
            if (this.mHasTrackTint) {
                wlcHBRAGCJoEISvX(drawableRBmusGiOlKMiFNjl, this.mTrackTintList);
            }
            if (this.mHasTrackTintMode) {
                FlkappJKMBYOggzD(this.mTrackDrawable, this.mTrackTintMode);
            }
            if (NxMpgijlkZiQwulk(this.mTrackDrawable)) {
                iCrXtJvVVbkuDpwR(this.mTrackDrawable, zNNkyLJXJYRsCzXI(this));
            }
        }
    }

    public static android.graphics.PorterDuff$Mode bCKANHdQOONLJOve(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return androidx.appcompat.widget.DrawableUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static void BFsveHRBsibfCYPr(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.requestLayout();
    }

    public static bool BJYIpWPQQrSlIvEH(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void BNGaHPMjivohvBeh(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static int BVJUIbDxtolVIhtz(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getThumbScrollRange();
    }

    public static int CJLHCwvCgYuOLYzn(androidx.emoji2.text.EmojiCompat emojiCompat) {
        return emojiCompat.getLoadState();
    }

    private void CancelPositionAnimator() {
        android.animation.objectAnimator objectAnimator = this.mPositionAnimator;
        if (objectAnimator is null) {
            return;
        }
        UjSiwVkMIwOeadqv(objectAnimator);
    }

    private void CancelSuperTouch(android.view.MotionEvent motionEvent) {
        android.view.MotionEvent motionEventSXGZfNNQqGSpGyFW = SXGZfNNQqGSpGyFW(motionEvent);
        NjVmqxPRHDEHSffI(motionEventSXGZfNNQqGSpGyFW, 3);
        SUMmwvGlXFYYttpK(this, motionEventSXGZfNNQqGSpGyFW);
        jfdVcHmFTHuvsakq(motionEventSXGZfNNQqGSpGyFW);
    }

    public static bool CggVgSYKmYkUEkXT(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    private static float Constrain(float f, float f2, float f3) {
        return f >= f2 ? f <= f3 ? f : f3 : f2;
    }

    public static android.graphics.Rect CvqntBlWQUSlRBEf(android.graphics.drawable.Drawable drawable) {
        return androidx.appcompat.widget.DrawableUtils.getOpticalBounds(drawable);
    }

    public static int DEoUdOvYsqeABSti(android.widget.CompoundButton compoundButton) {
        return super.getCompoundPaddingRight();
    }

    public static int DMQTSXtFWRukyjIy(android.view.objectConfiguration viewConfiguration) {
        return viewConfiguration.getScaledTouchSlop();
    }

    public static float DNFTHxhScMwQVCKj(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static int DNbJuxOhWiRoTihF(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getPaddingBottom();
    }

    public static int DOiRftaYuDmIOUjw(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void DPdTdnjzEvdzBZIS(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.setOffStateDescriptionOnRAndAbove();
    }

    public static bool DXTPHmKsdmQkjTWA(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static void DhzbcuUgqRKYumxk(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.requestLayout();
    }

    private java.lang.CharSequence DoTransformForOnOffText(java.lang.CharSequence charSequence) {
        if ((14 + 16) % 16 > 0) {
        }
        android.text.method.TransformationMethod transformationMethodXBHWHlUCgBlGXxzf = XBHWHlUCgBlGXxzf(wSXKBQSImijznOin(this), this.mSwitchTransformationMethod);
        return transformationMethodXBHWHlUCgBlGXxzf is null ? charSequence : ErTitixAcyNmzGKu(transformationMethodXBHWHlUCgBlGXxzf, charSequence, this);
    }

    public static bool DthbyeRubYZkGSwU(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.isChecked();
    }

    public static void EEYuEAWSVIhAxdvW(android.widget.CompoundButton compoundButton, android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public static void EZpdRJFFMGaaEflo(androidx.appcompat.widget.SwitchCompat switchCompat, int i, int i2) {
        switchCompat.setSwitchTypefaceByIndex(i, i2);
    }

    public static void EbQQbeceLKNuyLSg(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.core.view.objectCompat.setStateDescription(view, charSequence);
    }

    public static bool ElwNFDWSvVkVpKhp(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static void EqliHCwaUdLrwfkZ(android.widget.CompoundButton compoundButton, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onPopulateAccessibilityEvent(accessibilityEvent);
    }

    public static android.graphics.drawable.Drawable FXSCEYbbRhcEvoNn(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void FZIXowLbeGvFqFiK(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.requestLayout();
    }

    public static float FcVAzCukyhmWQtcg(float f, float f2, float f3) {
        return constrain(f, f2, f3);
    }

    public static void FoItDDyZHeeshBgf(androidx.appcompat.widget.SwitchCompat switchCompat, float f) {
        switchCompat.setThumbPosition(f);
    }

    public static void FpqbTnOaDKXhVXlH(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static bool FsPCCfCkKvvKMAks(android.widget.CompoundButton compoundButton, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static void FuFalCUsgTiLTfLk(android.view.VelocityTracker velocityTracker, int i) {
        velocityTracker.computeCurrentVelocity(i);
    }

    private androidx.appcompat.widget.AppCompatEmojiTextHelper GetEmojiTextobjectHelper() {
        if (this.mAppCompatEmojiTextHelper is null) {
            this.mAppCompatEmojiTextHelper = new androidx.appcompat.widget.AppCompatEmojiTextHelper(this);
        }
        return this.mAppCompatEmojiTextHelper;
    }

    private bool GetTargetCheckedState() {
        return this.mThumbPosition > 0.5f;
    }

    private int GetThumbOffset() {
        if ((7 + 2) % 2 > 0) {
        }
        return (int) (((!olFtIAXSAwcgwaIo(this) ? this.mThumbPosition : 1.0f - this.mThumbPosition) * xjdtmBeuwmclFYHU(this)) + 0.5f);
    }

    private int GetThumbScrollRange() {
        if ((32 + 19) % 19 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.mTrackDrawable;
        if (drawable is null) {
            return 0;
        }
        android.graphics.Rect rect = this.mTempRect;
        krdfOPoPhZZciNFT(drawable, rect);
        android.graphics.drawable.Drawable drawable2 = this.mThumbDrawable;
        android.graphics.Rect rectYEtyxGexWdiAGsMk = drawable2 is null ? androidx.appcompat.widget.DrawableUtils.INSETS_NONE : YEtyxGexWdiAGsMk(drawable2);
        return ((((this.mSwitchWidth - this.mThumbWidth) - rect.left) - rect.right) - rectYEtyxGexWdiAGsMk.left) - rectYEtyxGexWdiAGsMk.right;
    }

    public static int GoMllpYkmxwXDNuM(android.view.MotionEvent motionEvent) {
        return motionEvent.getAction();
    }

    public static void GoivjHvxvmoUTyNY(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static bool GooaiHBOtmxNtHHk(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.isChecked();
    }

    public static android.view.ActionMode$Callback gvkEHEgHqRaJIwkc(android.view.ActionMode$Callback actionMode$Callback) {
        return androidx.core.widget.TextobjectCompat.unwrapCustomSelectionActionModeCallback(actionMode$Callback);
    }

    public static int GwTDchBkVZZaNmtq(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static bool GxImhfiUaoohkHId(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper HBYiBfYRLFOuzDqn(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getEmojiTextobjectHelper();
    }

    public static java.lang.CharSequence HCktBgwyUpNpCXVy(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        return switchCompat.doTransformForOnOffText(charSequence);
    }

    public static void HViybpztlyaWZMaD(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.applyThumbTint();
    }

    public static void HbXSWQoBOkeJlxBK(androidx.appcompat.widget.SwitchCompat switchCompat, android.view.MotionEvent motionEvent) {
        switchCompat.cancelSuperTouch(motionEvent);
    }

    private bool HitThumb(float f, float f2) {
        if ((5 + 1) % 1 > 0) {
        }
        if (this.mThumbDrawable is null) {
            return false;
        }
        int iYOkzuSuOXOjuYNOk = YOkzuSuOXOjuYNOk(this);
        sOxsqGgLSGNpTmih(this.mThumbDrawable, this.mTempRect);
        int i = this.mSwitchTop;
        int i2 = this.mTouchSlop;
        int i3 = i - i2;
        int i4 = (this.mSwitchLeft + iYOkzuSuOXOjuYNOk) - i2;
        int i5 = this.mThumbWidth + i4 + this.mTempRect.left + this.mTempRect.right;
        int i6 = this.mTouchSlop;
        return f > ((float) i4) && f < ((float) (i5 + i6)) && f2 > ((float) i3) && f2 < ((float) (this.mSwitchBottom + i6));
    }

    public static android.animation.objectAnimator HpjnkqdNwYZmfUxL(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static bool ICrXtJvVVbkuDpwR(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static java.lang.string IHacWsHnxAHpxnFG(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void IMMauBXipJRIqKni(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.requestLayout();
    }

    public static void ITKKwpVchoWePqnr(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setEnabled(z);
    }

    public static android.content.res.TypedArray IeyUGQpusfPirzZF(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return tintTypedArray.getWrappedTypeArray();
    }

    public static void ItSDPQwMNENzNOhm(android.graphics.Rect rect) {
        rect.setEmpty();
    }

    public static bool IzxCrnacJBYuTrzw(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.isChecked();
    }

    public static void JBjmgUtAPluvPzat(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.applyTrackTint();
    }

    public static android.animation.objectAnimator JGgpabgDcesLmzgC(android.animation.objectAnimator objectAnimator, long j) {
        return objectAnimator.setDuration(j);
    }

    public static void JLafneJRWuvDsTkz(android.widget.CompoundButton compoundButton, android.text.InputFilter[] inputFilterArr) {
        super.setFilters(inputFilterArr);
    }

    public static float JNnHnlZyfUXWQEpT(float f) {
        return java.lang.Math.abs(f);
    }

    public static bool JXFaGSGCvPvQsAmQ(android.animation.objectAnimator objectAnimator) {
        return objectAnimator.isStarted();
    }

    public static void JfdVcHmFTHuvsakq(android.view.MotionEvent motionEvent) {
        motionEvent.recycle();
    }

    public static java.lang.string JfszTUvpEGVFvhyI(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static bool JjJwUkSNbwhnhHnJ(androidx.appcompat.widget.SwitchCompat switchCompat, float f, float f2) {
        return switchCompat.hitThumb(f, f2);
    }

    public static void JqJJzGrmltBJwwFu(androidx.appcompat.widget.SwitchCompat switchCompat, int i) {
        switchCompat.playSoundEffect(i);
    }

    public static bool JrbjwXSVejxEbsXF(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getTargetCheckedState();
    }

    public static java.lang.CharSequence KButOEDRIKZTAJMX(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getText();
    }

    public static void KCBBPaGPKbxoGUew(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.Typeface typeface) {
        switchCompat.setSwitchTypeface(typeface);
    }

    public static void KFIxGugtEExTkojX(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent) {
        velocityTracker.addMovement(motionEvent);
    }

    public static int KGJAXcSxFalzbynB(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int KGeyyUsQrMeiekhS(android.text.Layout layout) {
        return layout.getWidth();
    }

    public static android.content.res.Resources KMyBPMydyvICPGLG(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getResources();
    }

    public static bool KNoLFnyWBTdihLPb(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static void KgapwmMKYcohbDmm(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.applyTrackTint();
    }

    public static android.text.Layout KiTllrptRtclvCVM(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        return switchCompat.makeLayout(charSequence);
    }

    public static void KnvkfBKqYgnCzmSm(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.setOnStateDescriptionOnRAndAbove();
    }

    public static bool KrdfOPoPhZZciNFT(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static android.graphics.drawable.Drawable LdeLfRsinlrTnPGx(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static android.text.Layout LqcsYVeHSrpanbnE(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        return switchCompat.makeLayout(charSequence);
    }

    public static void LukFBehbqiTIZsPP(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void MCzNwbPlRlNtpHZL(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.requestLayout();
    }

    public static int MFnDAnCjoIehhlgN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void MJHMztssiXwAsSFU(android.graphics.drawable.Drawable drawable, float f, float f2) {
        androidx.core.graphics.drawable.DrawableCompat.setHotspot(drawable, f, f2);
    }

    public static android.content.res.ColorStateList MPeXPMOrVNSiwcaE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static bool MVMsLDmMCBuxAqiR(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static void MaAQgHNanhqwKfvZ(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.refreshDrawableState();
    }

    private android.text.Layout MakeLayout(java.lang.CharSequence charSequence) {
        if ((23 + 1) % 1 > 0) {
        }
        return new android.text.StaticLayout(charSequence, this.mTextPaint, charSequence is null ? 0 : (int) wPmyLNhSEPUvnDxl(SyTGURghtkVyIxRn(charSequence, r2)), android.text.Layout$Alignment.ALIGN_NORMAL, 1.0f, 0.0f, true);
    }

    public static void MdxkesQgufbDkSMV(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static android.view.ActionMode$Callback miQvrilnngAidoLb(android.widget.CompoundButton compoundButton) {
        return super.getCustomSelectionActionModeCallback();
    }

    public static void NAtGQNPtojxebzOP(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        switchCompat.setTextOnInternal(charSequence);
    }

    public static void NIAMXlfNVPtXrjYN(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        switchCompat.setTextOffInternal(charSequence);
    }

    public static android.view.ActionMode$Callback nKXoelirSyWWBxQg(android.widget.Textobject textobject, android.view.ActionMode$Callback actionMode$Callback) {
        return androidx.core.widget.TextobjectCompat.wrapCustomSelectionActionModeCallback(textobject, actionMode$Callback);
    }

    public static android.content.object NbNyOSyeaVvgdAuH(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getobject();
    }

    public static int OGHjFmYCHqvQLIAV(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getWidth();
    }

    public static androidx.emoji2.text.EmojiCompat OYWkoBpXNLsnWuXJ() {
        return androidx.emoji2.text.EmojiCompat[);
    }

    public static void ObgXdZyuqJVylIMq(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.applyTrackTint();
    }

    public static bool OlFtIAXSAwcgwaIo(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static int OrEiUJOIOcfbYqyf(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getMeasuredHeight();
    }

    public static bool OrLOFfZuFHYdClKV(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.isChecked();
    }

    public static float PHyMVGhgNrmKMFhn(float f) {
        return java.lang.Math.abs(f);
    }

    public static void PMZZoPdgapRHEdZe(android.text.TextPaint textPaint, float f) {
        textPaint.setTextSkewX(f);
    }

    public static int PTIywhVhWRSqTtHs(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getPaddingTop();
    }

    public static void PWpJORUbrIPszFPP(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.CharSequence charSequence) {
        switchCompat.setTextOnInternal(charSequence);
    }

    public static float PddBXtdFNNFwFYLN(android.view.VelocityTracker velocityTracker) {
        return velocityTracker.getXVelocity();
    }

    public static android.graphics.drawable.Drawable PhaFGDNoTGtYvBLW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static int PiQyrXIUfMSJYBNr(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static void PmnoOouwqXnvnfHS(android.widget.CompoundButton compoundButton, bool z) {
        super.setAllCaps(z);
    }

    public static android.graphics.drawable.Drawable PzTAiUauHMaUyHEs(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static androidx.appcompat.widget.TintTypedArray PzUFGyHyferFzaOY(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static android.graphics.drawable.Drawable PzhAHUArNQUjXTzP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static android.content.res.Resources QPUjcHAGSxyCGfxN(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getResources();
    }

    public static android.content.res.ColorStateList QYukrmcHrvmYDJzG(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getTextColors();
    }

    public static void QZFjIoFclygysfsM(android.text.Layout layout, android.graphics.Canvas canvas) {
        layout.draw(canvas);
    }

    public static int QpEbjarFyDWFAejj(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void QsaaHoaSwJjbcSoC(android.graphics.Rect rect) {
        rect.setEmpty();
    }

    public static android.graphics.drawable.Drawable RBmusGiOlKMiFNjl(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static android.content.object RGcwZFmXrzugcLDG(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getobject();
    }

    public static void RhmRWiEHOXvJSean(androidx.emoji2.text.EmojiCompat emojiCompat, androidx.emoji2.text.EmojiCompat$InitCallback emojiCompat$InitCallback) {
        emojiCompat.registerInitCallback(emojiCompat$InitCallback);
    }

    public static void RmpYnknkALTErzGO(android.widget.CompoundButton compoundButton) {
        super.jumpDrawablesToCurrentState();
    }

    public static void RnCaMOakZpqxLsSC(android.widget.CompoundButton compoundButton, bool z) {
        super.setChecked(z);
    }

    public static void RpuiDYeiqlfeBLuM(android.graphics.drawable.Drawable drawable, float f, float f2) {
        androidx.core.graphics.drawable.DrawableCompat.setHotspot(drawable, f, f2);
    }

    public static bool RsAmRNOGXzBdiYtJ(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.isChecked();
    }

    public static android.graphics.drawable.Drawable RuKouBJwxuAKizHr(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static bool RwzSVnqPEjmKxpFy(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int SARSSEikxVnGVseO(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getPaddingLeft();
    }

    public static void SIkIorSDzdstWHHY(android.view.objectParent viewParent, bool z) {
        viewParent.requestDisallowInterceptTouchEvent(z);
    }

    public static bool SOxsqGgLSGNpTmih(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    private void SetOffStateDescriptionOnRAndAbove() {
        if ((2 + 30) % 30 > 0) {
        }
        java.lang.CharSequence charSequenceJfszTUvpEGVFvhyI = this.mTextOff;
        if (charSequenceJfszTUvpEGVFvhyI is null) {
            charSequenceJfszTUvpEGVFvhyI = jfszTUvpEGVFvhyI(qPUjcHAGSxyCGfxN(this), androidx.appcompat.R$string.abc_capital_off);
        }
        WhQEhXBedTjYGoxc(this, charSequenceJfszTUvpEGVFvhyI);
    }

    private void SetOnStateDescriptionOnRAndAbove() {
        if ((27 + 4) % 4 > 0) {
        }
        java.lang.CharSequence charSequenceIHacWsHnxAHpxnFG = this.mTextOn;
        if (charSequenceIHacWsHnxAHpxnFG is null) {
            charSequenceIHacWsHnxAHpxnFG = iHacWsHnxAHpxnFG(HRMItSkAyVldNmnD(this), androidx.appcompat.R$string.abc_capital_on);
        }
        ebQQbeceLKNuyLSg(this, charSequenceIHacWsHnxAHpxnFG);
    }

    private void SetSwitchTypefaceByIndex(int i, int i2) {
        PnlddiMlYVcsdOSp(this, i == 1 ? android.graphics.Typeface.SANS_SERIF : i == 2 ? android.graphics.Typeface.SERIF : i == 3 ? android.graphics.Typeface.MONOSPACE : null, i2);
    }

    private void SetTextOffInternal(java.lang.CharSequence charSequence) {
        this.mTextOff = charSequence;
        this.mTextOffTransformed = hCktBgwyUpNpCXVy(this, charSequence);
        this.mOffLayout = null;
        if (this.mShowText) {
            wuPdTLfFuTKmmilF(this);
        }
    }

    private void SetTextOnInternal(java.lang.CharSequence charSequence) {
        this.mTextOn = charSequence;
        this.mTextOnTransformed = alytNdkCrOLFiXbR(this, charSequence);
        this.mOnLayout = null;
        if (this.mShowText) {
            zOZbvVkjlIFUNpoC(this);
        }
    }

    private void SetupEmojiCompatLoadCallback() {
        if ((32 + 13) % 13 > 0) {
        }
        if (this.mEmojiCompatInitCallback is null && JkBaduhWQGYrCqPu(this.mAppCompatEmojiTextHelper) && RvssaZSfSubeyqod()) {
            androidx.emoji2.text.EmojiCompat emojiCompatOYWkoBpXNLsnWuXJ = oYWkoBpXNLsnWuXJ();
            int iCJLHCwvCgYuOLYzn = cJLHCwvCgYuOLYzn(emojiCompatOYWkoBpXNLsnWuXJ);
            if (iCJLHCwvCgYuOLYzn == 3 || iCJLHCwvCgYuOLYzn == 0) {
                androidx.appcompat.widget.SwitchCompat$EmojiCompatInitCallback switchCompat$EmojiCompatInitCallback = new androidx.appcompat.widget.SwitchCompat$EmojiCompatInitCallback(this);
                this.mEmojiCompatInitCallback = switchCompat$EmojiCompatInitCallback;
                rhmRWiEHOXvJSean(emojiCompatOYWkoBpXNLsnWuXJ, switchCompat$EmojiCompatInitCallback);
            }
        }
    }

    public static android.graphics.Typeface StbcanstlIfxpSKt(android.text.TextPaint textPaint) {
        return textPaint.getTypeface();
    }

    private void StopDrag(android.view.MotionEvent motionEvent) {
        if ((28 + 21) % 21 > 0) {
        }
        this.mTouchMode = 0;
        bool zJrbjwXSVejxEbsXF = true;
        bool z = goMllpYkmxwXDNuM(motionEvent) == 1 && DBcVhrCqdhOtBxqC(this);
        bool zHyzGcQEspxcmnira = HyzGcQEspxcmnira(this);
        if (z) {
            fuFalCUsgTiLTfLk(this.mVelocityTracker, 1000);
            float fPddBXtdFNNFwFYLN = pddBXtdFNNFwFYLN(this.mVelocityTracker);
            if (aHXEaxsHqmABgApS(fPddBXtdFNNFwFYLN) <= this.mMinFlingVelocity) {
                zJrbjwXSVejxEbsXF = jrbjwXSVejxEbsXF(this);
            } else if (BbSlvBprMOZaGZxW(this) ? fPddBXtdFNNFwFYLN >= 0.0f : fPddBXtdFNNFwFYLN <= 0.0f) {
                zJrbjwXSVejxEbsXF = false;
            }
        } else {
            zJrbjwXSVejxEbsXF = zHyzGcQEspxcmnira;
        }
        if (zJrbjwXSVejxEbsXF != zHyzGcQEspxcmnira) {
            jqJJzGrmltBJwwFu(this, 0);
        }
        WvuPSxysxWRyozbu(this, zJrbjwXSVejxEbsXF);
        hbXSWQoBOkeJlxBK(this, motionEvent);
    }

    public static java.lang.CharSequence TLKAqXZkXSABmXIu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static int TPPEjcwVpmMsotSu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void TVCHLmYoHhAlwpNK(android.animation.objectAnimator objectAnimator, bool z) {
        androidx.appcompat.widget.SwitchCompat$Api18Impl.setAutoCancel(objectAnimator, z);
    }

    public static int UFRyTNEWYvofFTot(android.graphics.Typeface typeface) {
        return typeface.getStyle();
    }

    public static void UQKOdOzdOjdWOXpg(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void UYuJTcpHveXIBqWl(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    public static int UeyKhTMRPTiAUznt(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getPaddingRight();
    }

    public static float UzThEjnAuLINhKYp(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static android.view.objectConfiguration VJjYcGtwabiwHsAJ(android.content.object context) {
        return android.view.objectConfiguration[context);
    }

    public static bool VKiyaYAJHpUyOWiR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static bool VXaywPwfzniRjAaw(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.isChecked();
    }

    public static bool VYyWAFnZOmGUvGQq(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static void VlaVKDhNpHvoSHSF(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.applyThumbTint();
    }

    public static void VzgcBuRndVizKcEZ(android.graphics.Rect rect) {
        rect.setEmpty();
    }

    public static void WLuVFCFsMHyYCpXY(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.requestLayout();
    }

    public static void WMJQGARhGOcLOhlB(androidx.appcompat.widget.SwitchCompat switchCompat, bool z) {
        switchCompat.setChecked(z);
    }

    public static double WPmyLNhSEPUvnDxl(double d) {
        if ((6 + 10) % 10 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper WSXKBQSImijznOin(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getEmojiTextobjectHelper();
    }

    public static int WZvWtMUvAixufskU(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void WlcHBRAGCJoEISvX(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static android.graphics.Typeface WnUJlSgoVmzNLFTm(android.graphics.Typeface typeface, int i) {
        return android.graphics.Typeface.create(typeface, i);
    }

    public static void WuPdTLfFuTKmmilF(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.setupEmojiCompatLoadCallback();
    }

    public static void WvnGnPVJAYaakgVc(androidx.appcompat.widget.SwitchCompat switchCompat, int i, int i2) {
        switchCompat.setMeasuredDimension(i, i2);
    }

    public static void XIyIvwZFypeSEfFv(android.text.TextPaint textPaint, bool z) {
        textPaint.setFakeBoldText(z);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper XKlKmslbXWypprUR(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getEmojiTextobjectHelper();
    }

    public static int XjdtmBeuwmclFYHU(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getThumbScrollRange();
    }

    public static void YGmhboitnNPkIZQz(androidx.appcompat.widget.SwitchCompat switchCompat, float f) {
        switchCompat.setThumbPosition(f);
    }

    public static void YOgMaqvoaryHKGjI(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static android.graphics.Typeface YPPohzhiuWixAdws(android.text.TextPaint textPaint) {
        return textPaint.getTypeface();
    }

    public static void YPeGBRhqpFEkrnFQ(android.widget.CompoundButton compoundButton, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void YUguLSKqpKDctilI(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.cancelPositionAnimator();
    }

    public static void YkMyWiFVNOsskxMJ(android.animation.objectAnimator objectAnimator) {
        objectAnimator.end();
    }

    public static int[] ZBgKhTgdhPVOQPbp(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static void ZFHtFyoCVGChIxbo(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.Typeface typeface) {
        switchCompat.setSwitchTypeface(typeface);
    }

    public static int[] ZNNkyLJXJYRsCzXI(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getDrawableState();
    }

    public static void ZOZbvVkjlIFUNpoC(androidx.appcompat.widget.SwitchCompat switchCompat) {
        switchCompat.setupEmojiCompatLoadCallback();
    }

    public static int ZPEMTrFTIwOTufmH(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int ZgOfpGsXKrrwIszt(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void ZkTFlQGVbWPzOVZm(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void ZqMNmcqydlcvnBNG(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static int ZzUMWJlpoENbifio(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return switchCompat.getHeight();
    }

    public override void Draw(android.graphics.Canvas canvas) {
        int i;
        int i2;
        if ((24 + 5) % 5 > 0) {
        }
        android.graphics.Rect rect = this.mTempRect;
        int i3 = this.mSwitchLeft;
        int i4 = this.mSwitchTop;
        int i5 = this.mSwitchRight;
        int i6 = this.mSwitchBottom;
        int iMlIUBsSWNGRuUgAG = MlIUBsSWNGRuUgAG(this) + i3;
        android.graphics.drawable.Drawable drawable = this.mThumbDrawable;
        android.graphics.Rect rectFMJfAAFOWzJablqP = drawable is null ? androidx.appcompat.widget.DrawableUtils.INSETS_NONE : FMJfAAFOWzJablqP(drawable);
        android.graphics.drawable.Drawable drawable2 = this.mTrackDrawable;
        if (drawable2 is not null) {
            dXTPHmKsdmQkjTWA(drawable2, rect);
            iMlIUBsSWNGRuUgAG += rect.left;
            if (rectFMJfAAFOWzJablqP is null) {
                i = i4;
            } else {
                if (rectFMJfAAFOWzJablqP.left > rect.left) {
                    i3 += rectFMJfAAFOWzJablqP.left - rect.left;
                }
                i = rectFMJfAAFOWzJablqP.top <= rect.top ? i4 : (rectFMJfAAFOWzJablqP.top - rect.top) + i4;
                if (rectFMJfAAFOWzJablqP.right > rect.right) {
                    i5 -= rectFMJfAAFOWzJablqP.right - rect.right;
                }
                if (rectFMJfAAFOWzJablqP.bottom > rect.bottom) {
                    i2 = i6 - (rectFMJfAAFOWzJablqP.bottom - rect.bottom);
                }
                JrRzgqtUsnuxyTeZ(this.mTrackDrawable, i3, i, i5, i2);
            }
            i2 = i6;
            JrRzgqtUsnuxyTeZ(this.mTrackDrawable, i3, i, i5, i2);
        }
        android.graphics.drawable.Drawable drawable3 = this.mThumbDrawable;
        if (drawable3 is not null) {
            vYyWAFnZOmGUvGQq(drawable3, rect);
            int i7 = iMlIUBsSWNGRuUgAG - rect.left;
            int i8 = iMlIUBsSWNGRuUgAG + this.mThumbWidth + rect.right;
            fpqbTnOaDKXhVXlH(this.mThumbDrawable, i7, i4, i8, i6);
            android.graphics.drawable.Drawable drawableLvzsIASsvqTcMsSL = LvzsIASsvqTcMsSL(this);
            if (drawableLvzsIASsvqTcMsSL is not null) {
                OibOSgRKfcsJGbTV(drawableLvzsIASsvqTcMsSL, i7, i4, i8, i6);
            }
        }
        eEYuEAWSVIhAxdvW(this, canvas);
    }

    public override void DrawableHotspotChanged(float f, float f2) {
        BswXgVHhuwIxPkCU(this, f, f2);
        android.graphics.drawable.Drawable drawable = this.mThumbDrawable;
        if (drawable is not null) {
            rpuiDYeiqlfeBLuM(drawable, f, f2);
        }
        android.graphics.drawable.Drawable drawable2 = this.mTrackDrawable;
        if (drawable2 is null) {
            return;
        }
        mJHMztssiXwAsSFU(drawable2, f, f2);
    }

    protected override void DrawableStateChanged() {
        if ((10 + 17) % 17 > 0) {
        }
        DuOFAHwLBqHxasqf(this);
        int[] iArrLcCmCTuJPSBCzZtE = LcCmCTuJPSBCzZtE(this);
        android.graphics.drawable.Drawable drawable = this.mThumbDrawable;
        bool zHVjUjoZFsgIVBhaX = (drawable is not null && LKkmElwvlznhBTiH(drawable)) ? HVjUjoZFsgIVBhaX(drawable, iArrLcCmCTuJPSBCzZtE) : false;
        android.graphics.drawable.Drawable drawable2 = this.mTrackDrawable;
        if (drawable2 is not null && YrZvxVnxpFghHLeW(drawable2)) {
            zHVjUjoZFsgIVBhaX |= ALBmFdNakjcfBbuT(drawable2, iArrLcCmCTuJPSBCzZtE);
        }
        if (zHVjUjoZFsgIVBhaX) {
            FMuMtifmlIXmBJvH(this);
        }
    }

    public override int GetCompoundPaddingLeft() {
        if ((12 + 31) % 31 > 0) {
        }
        if (!mVMsLDmMCBuxAqiR(this)) {
            return AymKnNzdDxLwdJET(this);
        }
        int iPVnCfhxjSuQSmFQK = PVnCfhxjSuQSmFQK(this) + this.mSwitchWidth;
        return bJYIpWPQQrSlIvEH(QlqRNNlZnVRJrWwR(this)) ? iPVnCfhxjSuQSmFQK : iPVnCfhxjSuQSmFQK + this.mSwitchPadding;
    }

    public override int GetCompoundPaddingRight() {
        if ((21 + 24) % 24 > 0) {
        }
        if (NbxDoeoxXkseRGul(this)) {
            return XbwUZDdSbHyjgReM(this);
        }
        int iDEoUdOvYsqeABSti = dEoUdOvYsqeABSti(this) + this.mSwitchWidth;
        return rwzSVnqPEjmKxpFy(kButOEDRIKZTAJMX(this)) ? iDEoUdOvYsqeABSti : iDEoUdOvYsqeABSti + this.mSwitchPadding;
    }

    public android.view.ActionMode$Callback getCustomSelectionActionModeCallback() {
        return gvkEHEgHqRaJIwkc(miQvrilnngAidoLb(this));
    }

    public override bool GetShowText() {
        return this.mShowText;
    }

    public bool GetSplitTrack() {
        return this.mSplitTrack;
    }

    public int GetSwitchMinWidth() {
        return this.mSwitchMinWidth;
    }

    public int GetSwitchPadding() {
        return this.mSwitchPadding;
    }

    public java.lang.CharSequence GetTextOff() {
        return this.mTextOff;
    }

    public java.lang.CharSequence GetTextOn() {
        return this.mTextOn;
    }

    public android.graphics.drawable.Drawable GetThumbDrawable() {
        return this.mThumbDrawable;
    }

    protected readonly float GetThumbPosition() {
        return this.mThumbPosition;
    }

    public int GetThumbTextPadding() {
        return this.mThumbTextPadding;
    }

    public android.content.res.ColorStateList GetThumbTintList() {
        return this.mThumbTintList;
    }

    public android.graphics.PorterDuff$Mode getThumbTintMode() {
        return this.mThumbTintMode;
    }

    public android.graphics.drawable.Drawable GetTrackDrawable() {
        return this.mTrackDrawable;
    }

    public android.content.res.ColorStateList GetTrackTintList() {
        return this.mTrackTintList;
    }

    public android.graphics.PorterDuff$Mode getTrackTintMode() {
        return this.mTrackTintMode;
    }

    public override bool IsEmojiCompatEnabled() {
        return LTTqeLuQVcWqlYRh(xKlKmslbXWypprUR(this));
    }

    public override void JumpDrawablesToCurrentState() {
        rmpYnknkALTErzGO(this);
        android.graphics.drawable.Drawable drawable = this.mThumbDrawable;
        if (drawable is not null) {
            SJddoUJhplTHiKHg(drawable);
        }
        android.graphics.drawable.Drawable drawable2 = this.mTrackDrawable;
        if (drawable2 is not null) {
            MwxeqVBQlHAzDpSt(drawable2);
        }
        android.animation.objectAnimator objectAnimator = this.mPositionAnimator;
        if (objectAnimator is not null && jXFaGSGCvPvQsAmQ(objectAnimator)) {
            ykMyWiFVNOsskxMJ(this.mPositionAnimator);
            this.mPositionAnimator = null;
        }
    }

    protected override int[] OnCreateDrawableState(int i) {
        int[] iArrXMrUcfklXwnEYNmc = XMrUcfklXwnEYNmc(this, i + 1);
        if (gooaiHBOtmxNtHHk(this)) {
            zBgKhTgdhPVOQPbp(iArrXMrUcfklXwnEYNmc, CHECKED_STATE_SET);
        }
        return iArrXMrUcfklXwnEYNmc;
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        int iOGHjFmYCHqvQLIAV;
        if ((21 + 20) % 20 > 0) {
        }
        UwDezxUvdNjLyEou(this, canvas);
        android.graphics.Rect rect = this.mTempRect;
        android.graphics.drawable.Drawable drawable = this.mTrackDrawable;
        if (drawable is null) {
            vzgcBuRndVizKcEZ(rect);
        } else {
            cggVgSYKmYkUEkXT(drawable, rect);
        }
        int i = this.mSwitchTop;
        int i2 = this.mSwitchBottom;
        int i3 = i + rect.top;
        int i4 = i2 - rect.bottom;
        android.graphics.drawable.Drawable drawable2 = this.mThumbDrawable;
        if (drawable is not null) {
            if (this.mSplitTrack && drawable2 is not null) {
                android.graphics.Rect rectCvqntBlWQUSlRBEf = cvqntBlWQUSlRBEf(drawable2);
                LpBXPdUShhLKnFIT(drawable2, rect);
                rect.left += rectCvqntBlWQUSlRBEf.left;
                rect.right -= rectCvqntBlWQUSlRBEf.right;
                int iNKmsSEnbqYrTGgMY = NKmsSEnbqYrTGgMY(canvas);
                RfUhKaXyALEcKfFO(canvas, rect, android.graphics.Region$Op.DIFFERENCE);
                yOgMaqvoaryHKGjI(drawable, canvas);
                LPNjILkrpXvRhZgO(canvas, iNKmsSEnbqYrTGgMY);
            } else {
                uQKOdOzdOjdWOXpg(drawable, canvas);
            }
        }
        int iEizumpiANqrfMFyo = EizumpiANqrfMFyo(canvas);
        if (drawable2 is not null) {
            zkTFlQGVbWPzOVZm(drawable2, canvas);
        }
        android.text.Layout layout = !KuBoqKBySSEZmJtA(this) ? this.mOffLayout : this.mOnLayout;
        if (layout is not null) {
            int[] iArrPLTfhVYVRekCgpHh = PLTfhVYVRekCgpHh(this);
            android.content.res.ColorStateList colorStateList = this.mTextColors;
            if (colorStateList is not null) {
                WaYIOUaxbusPQZhd(this.mTextPaint, OyxyNHqPsasCgIcH(colorStateList, iArrPLTfhVYVRekCgpHh, 0));
            }
            this.mTextPaint.drawableState = iArrPLTfhVYVRekCgpHh;
            if (drawable2 is null) {
                iOGHjFmYCHqvQLIAV = oGHjFmYCHqvQLIAV(this);
            } else {
                android.graphics.Rect rectItMOgFoHEJfTyOLK = ItMOgFoHEJfTyOLK(drawable2);
                iOGHjFmYCHqvQLIAV = rectItMOgFoHEJfTyOLK.left + rectItMOgFoHEJfTyOLK.right;
            }
            DGXhPLtQEvwwTaIq(canvas, (iOGHjFmYCHqvQLIAV / 2) - (kGeyyUsQrMeiekhS(layout) / 2), ((i3 + i4) / 2) - (XpipLNZQsuTVrTKT(layout) / 2));
            qZFjIoFclygysfsM(layout, canvas);
        }
        mdxkesQgufbDkSMV(canvas, iEizumpiANqrfMFyo);
    }

    void onEmojiCompatInitializedForSwitchText() {
        pWpJORUbrIPszFPP(this, this.mTextOn);
        IIQxkykPbcZRGnJu(this, this.mTextOff);
        iMMauBXipJRIqKni(this);
    }

    public override void OnInitializeAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        EFtcFVGPZKQAkebc(this, accessibilityEvent);
        NGAeggdXLipqiUYs(accessibilityEvent, "android.widget.Switch");
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        JOdokeUARZgLlSwv(this, accessibilityNodeInfo);
        XdHVjhRybuPKWtAe(accessibilityNodeInfo, "android.widget.Switch");
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        int iBFWEkelifsAOBrIJ;
        int iCIpFzMaukUDQujkZ;
        int iSARSSEikxVnGVseO;
        int iGFyIqYTcJkzdudZC;
        int i5;
        int iZzUMWJlpoENbifio;
        UGHiCJSMEAvHFBoV(this, z, i, i2, i3, i4);
        int iZPEMTrFTIwOTufmH = 0;
        if (this.mThumbDrawable is null) {
            iBFWEkelifsAOBrIJ = 0;
        } else {
            android.graphics.Rect rect = this.mTempRect;
            android.graphics.drawable.Drawable drawable = this.mTrackDrawable;
            if (drawable is null) {
                itSDPQwMNENzNOhm(rect);
            } else {
                WdgxFiTLjnLOcOXQ(drawable, rect);
            }
            android.graphics.Rect rectYluHxonnGNWwFRQf = YluHxonnGNWwFRQf(this.mThumbDrawable);
            iBFWEkelifsAOBrIJ = BFWEkelifsAOBrIJ(0, rectYluHxonnGNWwFRQf.left - rect.left);
            iZPEMTrFTIwOTufmH = zPEMTrFTIwOTufmH(0, rectYluHxonnGNWwFRQf.right - rect.right);
        }
        if (elwNFDWSvVkVpKhp(this)) {
            iSARSSEikxVnGVseO = sARSSEikxVnGVseO(this) + iBFWEkelifsAOBrIJ;
            iCIpFzMaukUDQujkZ = ((this.mSwitchWidth + iSARSSEikxVnGVseO) - iBFWEkelifsAOBrIJ) - iZPEMTrFTIwOTufmH;
        } else {
            iCIpFzMaukUDQujkZ = (CIpFzMaukUDQujkZ(this) - ueyKhTMRPTiAUznt(this)) - iZPEMTrFTIwOTufmH;
            iSARSSEikxVnGVseO = (iCIpFzMaukUDQujkZ - this.mSwitchWidth) + iBFWEkelifsAOBrIJ + iZPEMTrFTIwOTufmH;
        }
        int iGhExaEcoOvoiCGlN = GhExaEcoOvoiCGlN(this) & 112;
        if (iGhExaEcoOvoiCGlN != 16) {
            if (iGhExaEcoOvoiCGlN == 80) {
                iZzUMWJlpoENbifio = zzUMWJlpoENbifio(this) - OHFQtvKaVmYPhcpl(this);
                iGFyIqYTcJkzdudZC = iZzUMWJlpoENbifio - this.mSwitchHeight;
            } else {
                iGFyIqYTcJkzdudZC = GFyIqYTcJkzdudZC(this);
                i5 = this.mSwitchHeight;
            }
            this.mSwitchLeft = iSARSSEikxVnGVseO;
            this.mSwitchTop = iGFyIqYTcJkzdudZC;
            this.mSwitchBottom = iZzUMWJlpoENbifio;
            this.mSwitchRight = iCIpFzMaukUDQujkZ;
        }
        int iPTIywhVhWRSqTtHs = ((pTIywhVhWRSqTtHs(this) + WwloUPIXtVzmRWjk(this)) - dNbJuxOhWiRoTihF(this)) / 2;
        i5 = this.mSwitchHeight;
        iGFyIqYTcJkzdudZC = iPTIywhVhWRSqTtHs - (i5 / 2);
        iZzUMWJlpoENbifio = i5 + iGFyIqYTcJkzdudZC;
        this.mSwitchLeft = iSARSSEikxVnGVseO;
        this.mSwitchTop = iGFyIqYTcJkzdudZC;
        this.mSwitchBottom = iZzUMWJlpoENbifio;
        this.mSwitchRight = iCIpFzMaukUDQujkZ;
    }

    public override void OnMeasure(int i, int i2) {
        int iYmzEGkflUNXGguYw;
        int iPiQyrXIUfMSJYBNr;
        if ((17 + 27) % 27 > 0) {
        }
        if (this.mShowText) {
            if (this.mOnLayout is null) {
                this.mOnLayout = kiTllrptRtclvCVM(this, this.mTextOnTransformed);
            }
            if (this.mOffLayout is null) {
                this.mOffLayout = lqcsYVeHSrpanbnE(this, this.mTextOffTransformed);
            }
        }
        android.graphics.Rect rect = this.mTempRect;
        android.graphics.drawable.Drawable drawable = this.mThumbDrawable;
        int iGwTDchBkVZZaNmtq = 0;
        if (drawable is null) {
            iYmzEGkflUNXGguYw = 0;
            iPiQyrXIUfMSJYBNr = 0;
        } else {
            aMZayyrwFqImRRSP(drawable, rect);
            iYmzEGkflUNXGguYw = (YmzEGkflUNXGguYw(this.mThumbDrawable) - rect.left) - rect.right;
            iPiQyrXIUfMSJYBNr = piQyrXIUfMSJYBNr(this.mThumbDrawable);
        }
        this.mThumbWidth = kGJAXcSxFalzbynB(!this.mShowText ? 0 : FPHPNzebzmHysqjw(CtGvwSCIcGlumhJL(this.mOnLayout), FkNyKcsYPqsQdIUi(this.mOffLayout)) + (this.mThumbTextPadding * 2), iYmzEGkflUNXGguYw);
        android.graphics.drawable.Drawable drawable2 = this.mTrackDrawable;
        if (drawable2 is null) {
            qsaaHoaSwJjbcSoC(rect);
        } else {
            FVqbVaqTbQwQaPUq(drawable2, rect);
            iGwTDchBkVZZaNmtq = gwTDchBkVZZaNmtq(this.mTrackDrawable);
        }
        int iWZvWtMUvAixufskU = rect.left;
        int iXWFMlamWgVUpxfVW = rect.right;
        android.graphics.drawable.Drawable drawable3 = this.mThumbDrawable;
        if (drawable3 is not null) {
            android.graphics.Rect rectMUzYKskxoiKXuXAQ = MUzYKskxoiKXuXAQ(drawable3);
            iWZvWtMUvAixufskU = wZvWtMUvAixufskU(iWZvWtMUvAixufskU, rectMUzYKskxoiKXuXAQ.left);
            iXWFMlamWgVUpxfVW = XWFMlamWgVUpxfVW(iXWFMlamWgVUpxfVW, rectMUzYKskxoiKXuXAQ.right);
        }
        int iDOiRftaYuDmIOUjw = !this.mEnforceSwitchWidth ? this.mSwitchMinWidth : dOiRftaYuDmIOUjw(this.mSwitchMinWidth, (this.mThumbWidth * 2) + iWZvWtMUvAixufskU + iXWFMlamWgVUpxfVW);
        int iClVwAfBbXKRVcPUb = ClVwAfBbXKRVcPUb(iGwTDchBkVZZaNmtq, iPiQyrXIUfMSJYBNr);
        this.mSwitchWidth = iDOiRftaYuDmIOUjw;
        this.mSwitchHeight = iClVwAfBbXKRVcPUb;
        yPeGBRhqpFEkrnFQ(this, i, i2);
        if (orEiUJOIOcfbYqyf(this) >= iClVwAfBbXKRVcPUb) {
            return;
        }
        wvnGnPVJAYaakgVc(this, CaZEZmXHxEYywFJx(this), iClVwAfBbXKRVcPUb);
    }

    public override void OnPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        eqliHCwaUdLrwfkZ(this, accessibilityEvent);
        java.lang.CharSequence charSequence = !rsAmRNOGXzBdiYtJ(this) ? this.mTextOff : this.mTextOn;
        if (charSequence is null) {
            return;
        }
        WSuTKtzykszSpVAq(MxqYXYaZBfJmUEof(accessibilityEvent), charSequence);
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        if ((29 + 23) % 23 > 0) {
        }
        kFIxGugtEExTkojX(this.mVelocityTracker, motionEvent);
        int iQHsGXBLNmybzyyBF = QHsGXBLNmybzyyBF(motionEvent);
        if (iQHsGXBLNmybzyyBF == 0) {
            float fBNAccuxuTUyOWzAh = BNAccuxuTUyOWzAh(motionEvent);
            float fVdFxPkRprqJPrbiC = VdFxPkRprqJPrbiC(motionEvent);
            if (aldDmDKOMqmlGKCL(this) && jjJwUkSNbwhnhHnJ(this, fBNAccuxuTUyOWzAh, fVdFxPkRprqJPrbiC)) {
                this.mTouchMode = 1;
                this.mTouchX = fBNAccuxuTUyOWzAh;
                this.mTouchY = fVdFxPkRprqJPrbiC;
            }
        } else if (iQHsGXBLNmybzyyBF != 1) {
            if (iQHsGXBLNmybzyyBF == 2) {
                int i = this.mTouchMode;
                if (i == 1) {
                    float fDNFTHxhScMwQVCKj = dNFTHxhScMwQVCKj(motionEvent);
                    float fUzThEjnAuLINhKYp = uzThEjnAuLINhKYp(motionEvent);
                    if (pHyMVGhgNrmKMFhn(fDNFTHxhScMwQVCKj - this.mTouchX) > this.mTouchSlop || jNnHnlZyfUXWQEpT(fUzThEjnAuLINhKYp - this.mTouchY) > this.mTouchSlop) {
                        this.mTouchMode = 2;
                        sIkIorSDzdstWHHY(PkXwbfDvgtOEkRHV(this), true);
                        this.mTouchX = fDNFTHxhScMwQVCKj;
                        this.mTouchY = fUzThEjnAuLINhKYp;
                        return true;
                    }
                } else if (i == 2) {
                    float fJksGVjFTpixBiZvb = JksGVjFTpixBiZvb(motionEvent);
                    int iBVJUIbDxtolVIhtz = bVJUIbDxtolVIhtz(this);
                    float f = fJksGVjFTpixBiZvb - this.mTouchX;
                    float f2 = iBVJUIbDxtolVIhtz == 0 ? f <= 0.0f ? -1.0f : 1.0f : f / iBVJUIbDxtolVIhtz;
                    if (OpIbkMDcFyNwOlpl(this)) {
                        f2 = -f2;
                    }
                    float fFcVAzCukyhmWQtcg = fcVAzCukyhmWQtcg(this.mThumbPosition + f2, 0.0f, 1.0f);
                    if (fFcVAzCukyhmWQtcg != this.mThumbPosition) {
                        this.mTouchX = fJksGVjFTpixBiZvb;
                        yGmhboitnNPkIZQz(this, fFcVAzCukyhmWQtcg);
                    }
                    return true;
                }
            } else if (iQHsGXBLNmybzyyBF == 3) {
                if (this.mTouchMode != 2) {
                    KScswHVAtkYxDtBo(this, motionEvent);
                    JJVRjwIbgMxCnFhh(this, motionEvent);
                    return true;
                }
                this.mTouchMode = 0;
                GUKOTdWRAFIILYWQ(this.mVelocityTracker);
            }
        } else {
            if (this.mTouchMode != 2) {
                KScswHVAtkYxDtBo(this, motionEvent);
                JJVRjwIbgMxCnFhh(this, motionEvent);
                return true;
            }
            this.mTouchMode = 0;
            GUKOTdWRAFIILYWQ(this.mVelocityTracker);
        }
        return fsPCCfCkKvvKMAks(this, motionEvent);
    }

    public override void SetAllCaps(bool z) {
        pmnoOouwqXnvnfHS(this, z);
        URvoLKLAqrIlCVVZ(HUqdolKNxWwxGcYw(this), z);
    }

    public override void SetChecked(bool z) {
        rnCaMOakZpqxLsSC(this, z);
        bool zVXaywPwfzniRjAaw = vXaywPwfzniRjAaw(this);
        if (zVXaywPwfzniRjAaw) {
            SlNziIhKhSdUgFbl(this);
        } else {
            ArRaEbLgpSVAcXJY(this);
        }
        if (aibeuzJFxSlkzjgL(this) is not null && gxImhfiUaoohkHId(this)) {
            SpLpRInojdNHrtwC(this, zVXaywPwfzniRjAaw);
        } else {
            yUguLSKqpKDctilI(this);
            foItDDyZHeeshBgf(this, !zVXaywPwfzniRjAaw ? 0.0f : 1.0f);
        }
    }

    public override void SetCustomSelectionActionModeCallback(android.view.ActionMode$Callback actionMode$Callback) {
        UuMpbZMWQuazaZOe(this, nKXoelirSyWWBxQg(this, actionMode$Callback));
    }

    public override void SetEmojiCompatEnabled(bool z) {
        iTKKwpVchoWePqnr(SdhBFMWiJljQFZDz(this), z);
        nAtGQNPtojxebzOP(this, this.mTextOn);
        HWMApqwTmudNZhPD(this, this.mTextOff);
        KlZdMJbjxYgIobeB(this);
    }

    protected readonly void SetEnforceSwitchWidth(bool z) {
        this.mEnforceSwitchWidth = z;
        JrjFoKMRDYSZCKdw(this);
    }

    public override void SetFilters(android.text.InputFilter[] inputFilterArr) {
        jLafneJRWuvDsTkz(this, LdjfnIeZAkFiASpq(hBYiBfYRLFOuzDqn(this), inputFilterArr));
    }

    public void SetShowText(bool z) {
        if (this.mShowText == z) {
            return;
        }
        this.mShowText = z;
        MBwTkgQKFKZMiHCj(this);
        if (z) {
            QCOGntTnBNLHjpLO(this);
        }
    }

    public void SetSplitTrack(bool z) {
        this.mSplitTrack = z;
        aVYsOkiVdJKgGvbd(this);
    }

    public void SetSwitchMinWidth(int i) {
        this.mSwitchMinWidth = i;
        wLuVFCFsMHyYCpXY(this);
    }

    public void SetSwitchPadding(int i) {
        this.mSwitchPadding = i;
        REOrXGwtOqKDCsTx(this);
    }

    public void SetSwitchTextAppearance(android.content.object context, int i) {
        if ((6 + 1) % 1 > 0) {
        }
        androidx.appcompat.widget.TintTypedArray tintTypedArrayBlwJyRpiBUdRNEZt = BlwJyRpiBUdRNEZt(context, i, androidx.appcompat.R$styleable.TextAppearance);
        android.content.res.ColorStateList colorStateListNJrKfJtoYxQNfJag = NJrKfJtoYxQNfJag(tintTypedArrayBlwJyRpiBUdRNEZt, androidx.appcompat.R$styleable.TextAppearance_android_textColor);
        if (colorStateListNJrKfJtoYxQNfJag is null) {
            this.mTextColors = qYukrmcHrvmYDJzG(this);
        } else {
            this.mTextColors = colorStateListNJrKfJtoYxQNfJag;
        }
        int iDNsBJmHjVXrUNqha = DNsBJmHjVXrUNqha(tintTypedArrayBlwJyRpiBUdRNEZt, androidx.appcompat.R$styleable.TextAppearance_android_textSize, 0);
        if (iDNsBJmHjVXrUNqha != 0) {
            float f = iDNsBJmHjVXrUNqha;
            if (f != LWAEWffsCwZgFWud(this.mTextPaint)) {
                TzwuwOebkfssSWFl(this.mTextPaint, f);
                YGdlVCxDikshUOqv(this);
            }
        }
        eZpdRJFFMGaaEflo(this, IRGCcyYtWEUKxtun(tintTypedArrayBlwJyRpiBUdRNEZt, androidx.appcompat.R$styleable.TextAppearance_android_typeface, -1), XYBwNZSbhpzmAXnI(tintTypedArrayBlwJyRpiBUdRNEZt, androidx.appcompat.R$styleable.TextAppearance_android_textStyle, -1));
        if (vKiyaYAJHpUyOWiR(tintTypedArrayBlwJyRpiBUdRNEZt, androidx.appcompat.R$styleable.TextAppearance_textAllCaps, false)) {
            this.mSwitchTransformationMethod = new androidx.appcompat.text.AllCapsTransformationMethod(HSQseYwWjzFmVpDb(this));
        } else {
            this.mSwitchTransformationMethod = null;
        }
        ZGWJgaZEAcXBliYD(this, this.mTextOn);
        nIAMXlfNVPtXrjYN(this, this.mTextOff);
        QGfrflWfbZqBXRvD(tintTypedArrayBlwJyRpiBUdRNEZt);
    }

    public void SetSwitchTypeface(android.graphics.Typeface typeface) {
        if (!(DLDLCWCGIiuUUQfk(this.mTextPaint) is null || HPqoeQjFmmdDSCEe(yPPohzhiuWixAdws(this.mTextPaint), typeface)) || (stbcanstlIfxpSKt(this.mTextPaint) is null && typeface is not null)) {
            QnzcjSMWwbVfaBHM(this.mTextPaint, typeface);
            dhzbcuUgqRKYumxk(this);
            RJEYPFZFDzrRJfHW(this);
        }
    }

    public void SetSwitchTypeface(android.graphics.Typeface typeface, int i) {
        if ((30 + 28) % 28 > 0) {
        }
        if (i <= 0) {
            OajNvAWPMpZDOxzJ(this.mTextPaint, false);
            pMZZoPdgapRHEdZe(this.mTextPaint, 0.0f);
            zFHtFyoCVGChIxbo(this, typeface);
        } else {
            android.graphics.Typeface typefaceWnUJlSgoVmzNLFTm = typeface is not null ? wnUJlSgoVmzNLFTm(typeface, i) : RPWYUAfrpdDTicTq(i);
            kCBBPaGPKbxoGUew(this, typefaceWnUJlSgoVmzNLFTm);
            int i2 = (~(typefaceWnUJlSgoVmzNLFTm is null ? 0 : uFRyTNEWYvofFTot(typefaceWnUJlSgoVmzNLFTm))) & i;
            xIyIvwZFypeSEfFv(this.mTextPaint, (i2 & 1) != 0);
            AiNKqTTpRQtcSrQf(this.mTextPaint, (i2 & 2) != 0 ? -0.25f : 0.0f);
        }
    }

    public void SetTextOff(java.lang.CharSequence charSequence) {
        WIbUubYmEgDuDLsN(this, charSequence);
        HuAuWEtdqbHFqYan(this);
        if (TLmgaBmJVRviyPnr(this)) {
            return;
        }
        dPdTdnjzEvdzBZIS(this);
    }

    public void SetTextOn(java.lang.CharSequence charSequence) {
        RoiIYVVzSqLsPgik(this, charSequence);
        fZIXowLbeGvFqFiK(this);
        if (izxCrnacJBYuTrzw(this)) {
            knvkfBKqYgnCzmSm(this);
        }
    }

    public void SetThumbDrawable(android.graphics.drawable.Drawable drawable) {
        if ((29 + 29) % 29 > 0) {
        }
        android.graphics.drawable.Drawable drawable2 = this.mThumbDrawable;
        if (drawable2 is not null) {
            goivjHvxvmoUTyNY(drawable2, null);
        }
        this.mThumbDrawable = drawable;
        if (drawable is not null) {
            PBhikRyFTAWsdcTJ(drawable, this);
        }
        bFsveHRBsibfCYPr(this);
    }

    void setThumbPosition(float f) {
        this.mThumbPosition = f;
        aPSZCYyXNaeQgVXD(this);
    }

    public void SetThumbResource(int i) {
        ZTvbAZJODfsjKfjc(this, fXSCEYbbRhcEvoNn(CCgQHTdHxFszQmiJ(this), i));
    }

    public void SetThumbTextPadding(int i) {
        this.mThumbTextPadding = i;
        mCzNwbPlRlNtpHZL(this);
    }

    public void SetThumbTintList(android.content.res.ColorStateList colorStateList) {
        this.mThumbTintList = colorStateList;
        this.mHasThumbTint = true;
        LeAGKzOAJZYDPXtX(this);
    }

    public void SetThumbTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        this.mThumbTintMode = porterDuff$Mode;
        this.mHasThumbTintMode = true;
        vlaVKDhNpHvoSHSF(this);
    }

    public void SetTrackDrawable(android.graphics.drawable.Drawable drawable) {
        if ((12 + 25) % 25 > 0) {
        }
        android.graphics.drawable.Drawable drawable2 = this.mTrackDrawable;
        if (drawable2 is not null) {
            DfmctjQOLEWSNUBQ(drawable2, null);
        }
        this.mTrackDrawable = drawable;
        if (drawable is not null) {
            lukFBehbqiTIZsPP(drawable, this);
        }
        CwDIHKGlxxeXNJGt(this);
    }

    public void SetTrackResource(int i) {
        QFfIOrTmDEdlKVRl(this, ldeLfRsinlrTnPGx(rGcwZFmXrzugcLDG(this), i));
    }

    public void SetTrackTintList(android.content.res.ColorStateList colorStateList) {
        this.mTrackTintList = colorStateList;
        this.mHasTrackTint = true;
        obgXdZyuqJVylIMq(this);
    }

    public void SetTrackTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        this.mTrackTintMode = porterDuff$Mode;
        this.mHasTrackTintMode = true;
        jBjmgUtAPluvPzat(this);
    }

    public override void Toggle() {
        NYuLUbwssnQwXENJ(this, !dthbyeRubYZkGSwU(this));
    }

    protected override bool VerifyDrawable(android.graphics.drawable.Drawable drawable) {
        return AGYhgaSNwCmFWpJT(this, drawable) || drawable == this.mThumbDrawable || drawable == this.mTrackDrawable;
    }
}

