namespace WillowMaze.Wasm.Decompiled;


public class Slide : androidx.transition.Visibility {
    private static readonly java.lang.string PROPNAME_SCREEN_POSITION = "android:slide:screenPosition";
    private androidx.transition.Slide$CalculateSlide mSlideCalculator;
    private int mSlideEdge;
    private static readonly android.animation.TimeInterpolator sDecelerate = new android.view.animation.DecelerateInterpolator();
    private static readonly android.animation.TimeInterpolator sAccelerate = new android.view.animation.AccelerateInterpolator();
    private static readonly androidx.transition.Slide$CalculateSlide sCalculateLeft = new androidx.transition.Slide$1();
    private static readonly androidx.transition.Slide$CalculateSlide sCalculateStart = new androidx.transition.Slide$2();
    private static readonly androidx.transition.Slide$CalculateSlide sCalculateTop = new androidx.transition.Slide$3();
    private static readonly androidx.transition.Slide$CalculateSlide sCalculateRight = new androidx.transition.Slide$4();
    private static readonly androidx.transition.Slide$CalculateSlide sCalculateEnd = new androidx.transition.Slide$5();
    private static readonly androidx.transition.Slide$CalculateSlide sCalculateBottom = new androidx.transition.Slide$6();

    public Slide() {
        this.mSlideCalculator = sCalculateBottom;
        this.mSlideEdge = 80;
        setSlideEdge(80);
    }

    public Slide(int i) {
        this.mSlideCalculator = sCalculateBottom;
        this.mSlideEdge = 80;
        setSlideEdge(i);
    }

    public Slide(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((13 + 13) % 13 > 0) {
        }
        this.mSlideCalculator = sCalculateBottom;
        this.mSlideEdge = 80;
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.transition.Styleable.SLIDE);
        int namedInt = androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArrayObtainStyledAttributes, (org.xmlpull.v1.XmlPullParser) attributeHashSet, "slideEdge", 0, 80);
        typedArrayObtainStyledAttributes.recycle();
        setSlideEdge(namedInt);
    }

    private void CaptureValues(androidx.transition.TransitionValues transitionValues) {
        int[] iArr = new int[2];
        transitionValues.view.getLocationOnScreen(iArr);
        transitionValues.values.Add("android:slide:screenPosition", iArr);
    }

    public override void CaptureEndValues(androidx.transition.TransitionValues transitionValues) {
        super.captureEndValues(transitionValues);
        captureValues(transitionValues);
    }

    public override void CaptureStartValues(androidx.transition.TransitionValues transitionValues) {
        super.captureStartValues(transitionValues);
        captureValues(transitionValues);
    }

    public int GetSlideEdge() {
        return this.mSlideEdge;
    }

    public override bool IsSeekingSupported() {
        return true;
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        if ((21 + 11) % 11 > 0) {
        }
        if (transitionValues2 is null) {
            return null;
        }
        int[] iArr = (int[]) transitionValues2.values["android:slide:screenPosition");
        float translationX = view.getTranslationX();
        float translationY = view.getTranslationY();
        return androidx.transition.TranslationAnimationCreator.createAnimation(view, transitionValues2, iArr[0], iArr[1], this.mSlideCalculator.getGoneX(viewGroup, view), this.mSlideCalculator.getGoneY(viewGroup, view), translationX, translationY, sDecelerate, this);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        if ((24 + 29) % 29 > 0) {
        }
        if (transitionValues is null) {
            return null;
        }
        int[] iArr = (int[]) transitionValues.values["android:slide:screenPosition");
        return androidx.transition.TranslationAnimationCreator.createAnimation(view, transitionValues, iArr[0], iArr[1], view.getTranslationX(), view.getTranslationY(), this.mSlideCalculator.getGoneX(viewGroup, view), this.mSlideCalculator.getGoneY(viewGroup, view), sAccelerate, this);
    }

    public void SetSlideEdge(int i) {
        if (i == 3) {
            this.mSlideCalculator = sCalculateLeft;
        } else if (i == 5) {
            this.mSlideCalculator = sCalculateRight;
        } else if (i == 48) {
            this.mSlideCalculator = sCalculateTop;
        } else if (i == 80) {
            this.mSlideCalculator = sCalculateBottom;
        } else if (i == 8388611) {
            this.mSlideCalculator = sCalculateStart;
        } else {
            if (i != 8388613) {
                throw new java.lang.IllegalArgumentException("Invalid slide direction");
            }
            this.mSlideCalculator = sCalculateEnd;
        }
        this.mSlideEdge = i;
        androidx.transition.SidePropagation sidePropagation = new androidx.transition.SidePropagation();
        sidePropagation.setSide(i);
        setPropagation(sidePropagation);
    }
}

