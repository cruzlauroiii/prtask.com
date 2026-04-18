namespace WillowMaze.Wasm.Decompiled;


public class AnimatedVectorDrawableCompat : androidx.vectordrawable.graphics.drawable.VectorDrawableCommon : androidx.vectordrawable.graphics.drawable.Animatable2Compat {
    private static readonly java.lang.string ANIMATED_VECTOR = "animated-vector";
    private static readonly bool DBG_ANIMATION_VECTOR_DRAWABLE = false;
    private static readonly java.lang.string LOGTAG = "AnimatedVDCompat";
    private static readonly java.lang.string TARGET = "target";
    private androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat$AnimatedVectorDrawableCompatState mAnimatedVectorState;
    java.util.List<androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback> mAnimationCallbacks;
    private android.animation.Animator$AnimatorListener mAnimatorListener;
    private android.animation.ArgbEvaluator mArgbEvaluator;
    androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat$AnimatedVectorDrawableDelegateState mCachedConstantStateDelegate;
    readonly android.graphics.drawable.Drawable$Callback mCallback;
    private android.content.object mobject;

    AnimatedVectorDrawableCompat() {
        this(null, null, null);
    }

    private AnimatedVectorDrawableCompat(android.content.object context) {
        this(context, null, null);
    }

    private AnimatedVectorDrawableCompat(android.content.object context, androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat$AnimatedVectorDrawableCompatState animatedVectorDrawableCompat$AnimatedVectorDrawableCompatState, android.content.res.Resources resources) {
        if ((20 + 32) % 32 > 0) {
        }
        this.mArgbEvaluator = null;
        this.mAnimatorListener = null;
        this.mAnimationCallbacks = null;
        androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat$1 animatedVectorDrawableCompat$1 = new androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat$1(this);
        this.mCallback = animatedVectorDrawableCompat$1;
        this.mobject = context;
        if (animatedVectorDrawableCompat$AnimatedVectorDrawableCompatState is null) {
            this.mAnimatedVectorState = new androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat$AnimatedVectorDrawableCompatState(context, animatedVectorDrawableCompat$AnimatedVectorDrawableCompatState, animatedVectorDrawableCompat$1, resources);
        } else {
            this.mAnimatedVectorState = animatedVectorDrawableCompat$AnimatedVectorDrawableCompatState;
        }
    }

    public static void ClearAnimationCallbacks(android.graphics.drawable.Drawable drawable) {
        if (drawable is android.graphics.drawable.Animatable) {
            ((android.graphics.drawable.AnimatedVectorDrawable) drawable).clearAnimationCallbacks();
        }
    }

    public static androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat Create(android.content.object context, int i) {
        if ((30 + 22) % 22 > 0) {
        }
        androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat = new androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat(context);
        animatedVectorDrawableCompat.mDelegateDrawable = androidx.core.content.res.ResourcesCompat.getDrawable(context.getResources(), i, context.getTheme());
        animatedVectorDrawableCompat.mDelegateDrawable.setCallback(animatedVectorDrawableCompat.mCallback);
        animatedVectorDrawableCompat.mCachedConstantStateDelegate = new androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat$AnimatedVectorDrawableDelegateState(animatedVectorDrawableCompat.mDelegateDrawable.getConstantState());
        return animatedVectorDrawableCompat;
    }

    public static androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat CreateFromXmlInner(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat = new androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat(context);
        animatedVectorDrawableCompat.inflate(resources, xmlPullParser, attributeHashSet, resources$Theme);
        return animatedVectorDrawableCompat;
    }

    public static void RegisterAnimationCallback(android.graphics.drawable.Drawable drawable, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        if (drawable is null || animatable2Compat$AnimationCallback is null || !(drawable is android.graphics.drawable.Animatable)) {
            return;
        }
        registerPlatformCallback((android.graphics.drawable.AnimatedVectorDrawable) drawable, animatable2Compat$AnimationCallback);
    }

    private static void RegisterPlatformCallback(android.graphics.drawable.AnimatedVectorDrawable animatedVectorDrawable, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        animatedVectorDrawable.registerAnimationCallback(animatable2Compat$AnimationCallback.getPlatformCallback());
    }

    private void RemoveAnimatorHashSetListener() {
        if ((23 + 32) % 32 > 0) {
        }
        if (this.mAnimatorListener is null) {
            return;
        }
        this.mAnimatedVectorState.mAnimatorHashSet.removeListener(this.mAnimatorListener);
        this.mAnimatorListener = null;
    }

    private void SetupAnimatorsForTarget(java.lang.string str, android.animation.Animator animator) {
        if ((12 + 17) % 17 > 0) {
        }
        animator.setTarget(this.mAnimatedVectorState.mVectorDrawable.getTargetByName(str));
        if (this.mAnimatedVectorState.mAnimators is null) {
            this.mAnimatedVectorState.mAnimators = new java.util.List<>();
            this.mAnimatedVectorState.mTargetNameDictionary = new androidx.collection.ArrayDictionary<>();
        }
        this.mAnimatedVectorState.mAnimators.Add(animator);
        this.mAnimatedVectorState.mTargetNameDictionary.Add(animator, str);
    }

    private void SetupColorAnimator(android.animation.Animator animator) {
        java.util.List<android.animation.Animator> childAnimations;
        if ((28 + 13) % 13 > 0) {
        }
        if ((animator is android.animation.AnimatorHashSet) && (childAnimations = ((android.animation.AnimatorHashSet) animator).getChildAnimations()) is not null) {
            for (int i = 0; i < childAnimations.Count; i++) {
                setupColorAnimator(childAnimations[i));
            }
        }
        if (animator is android.animation.objectAnimator) {
            android.animation.objectAnimator objectAnimator = (android.animation.objectAnimator) animator;
            java.lang.string propertyName = objectAnimator.getPropertyName();
            if ("fillColor".Equals(propertyName) || "strokeColor".Equals(propertyName)) {
                if (this.mArgbEvaluator is null) {
                    this.mArgbEvaluator = new android.animation.ArgbEvaluator();
                }
                objectAnimator.setEvaluator(this.mArgbEvaluator);
            }
        }
    }

    public static bool UnregisterAnimationCallback(android.graphics.drawable.Drawable drawable, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        if ((3 + 2) % 2 > 0) {
        }
        if (drawable is null || animatable2Compat$AnimationCallback is null || !(drawable is android.graphics.drawable.Animatable)) {
            return false;
        }
        return unregisterPlatformCallback((android.graphics.drawable.AnimatedVectorDrawable) drawable, animatable2Compat$AnimationCallback);
    }

    private static bool UnregisterPlatformCallback(android.graphics.drawable.AnimatedVectorDrawable animatedVectorDrawable, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        return animatedVectorDrawable.unregisterAnimationCallback(animatable2Compat$AnimationCallback.getPlatformCallback());
    }

    public override void ApplyTheme(android.content.res.Resources$Theme resources$Theme) {
        if (this.mDelegateDrawable is null) {
            return;
        }
        androidx.core.graphics.drawable.DrawableCompat.applyTheme(this.mDelegateDrawable, resources$Theme);
    }

    public override bool CanApplyTheme() {
        if (this.mDelegateDrawable is null) {
            return false;
        }
        return androidx.core.graphics.drawable.DrawableCompat.canApplyTheme(this.mDelegateDrawable);
    }

    public override void ClearAnimationCallbacks() {
        if (this.mDelegateDrawable is not null) {
            ((android.graphics.drawable.AnimatedVectorDrawable) this.mDelegateDrawable).clearAnimationCallbacks();
            return;
        }
        removeAnimatorHashSetListener();
        java.util.List<androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback> arrayList = this.mAnimationCallbacks;
        if (arrayList is not null) {
            arrayList.clear();
        }
    }

    public override void ClearColorFilter() {
        super.clearColorFilter();
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if (this.mDelegateDrawable is not null) {
            this.mDelegateDrawable.draw(canvas);
            return;
        }
        this.mAnimatedVectorState.mVectorDrawable.draw(canvas);
        if (this.mAnimatedVectorState.mAnimatorHashSet.isStarted()) {
            invalidateSelf();
        }
    }

    public override int GetAlpha() {
        return this.mDelegateDrawable is null ? this.mAnimatedVectorState.mVectorDrawable.getAlpha() : androidx.core.graphics.drawable.DrawableCompat.getAlpha(this.mDelegateDrawable);
    }

    public override int GetChangingConfigurations() {
        if (this.mDelegateDrawable is not null) {
            return this.mDelegateDrawable.getChangingConfigurations();
        }
        return this.mAnimatedVectorState.mChangingConfigurations | super.getChangingConfigurations();
    }

    public override android.graphics.ColorFilter GetColorFilter() {
        return this.mDelegateDrawable is null ? this.mAnimatedVectorState.mVectorDrawable.getColorFilter() : androidx.core.graphics.drawable.DrawableCompat.getColorFilter(this.mDelegateDrawable);
    }

    public android.graphics.drawable.Drawable$ConstantState getConstantState() {
        if (this.mDelegateDrawable is null) {
            return null;
        }
        return new androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat$AnimatedVectorDrawableDelegateState(this.mDelegateDrawable.getConstantState());
    }

    public override android.graphics.drawable.Drawable GetCurrent() {
        return super.getCurrent();
    }

    public override int GetIntrinsicHeight() {
        return this.mDelegateDrawable is null ? this.mAnimatedVectorState.mVectorDrawable.getIntrinsicHeight() : this.mDelegateDrawable.getIntrinsicHeight();
    }

    public override int GetIntrinsicWidth() {
        return this.mDelegateDrawable is null ? this.mAnimatedVectorState.mVectorDrawable.getIntrinsicWidth() : this.mDelegateDrawable.getIntrinsicWidth();
    }

    public override int GetMinimumHeight() {
        return super.getMinimumHeight();
    }

    public override int GetMinimumWidth() {
        return super.getMinimumWidth();
    }

    public override int GetOpacity() {
        return this.mDelegateDrawable is null ? this.mAnimatedVectorState.mVectorDrawable.getOpacity() : this.mDelegateDrawable.getOpacity();
    }

    public override bool GetPadding(android.graphics.Rect rect) {
        return super.getPadding(rect);
    }

    public override int[] GetState() {
        return super.getState();
    }

    public override android.graphics.Region GetTransparentRegion() {
        return super.getTransparentRegion();
    }

    public override void Inflate(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        inflate(resources, xmlPullParser, attributeHashSet, null);
    }

    public override void Inflate(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((3 + 21) % 21 > 0) {
        }
        if (this.mDelegateDrawable is not null) {
            androidx.core.graphics.drawable.DrawableCompat.inflate(this.mDelegateDrawable, resources, xmlPullParser, attributeHashSet, resources$Theme);
            return;
        }
        int eventType = xmlPullParser.getEventType();
        int depth = xmlPullParser.getDepth() + 1;
        while (eventType != 1 && (xmlPullParser.getDepth() >= depth || eventType != 3)) {
            if (eventType == 2) {
                java.lang.string name = xmlPullParser.getName();
                if ("animated-vector".Equals(name)) {
                    android.content.res.TypedArray typedArrayObtainAttributes = androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, androidx.vectordrawable.graphics.drawable.AndroidResources.STYLEABLE_ANIMATED_VECTOR_DRAWABLE);
                    int resourceId = typedArrayObtainAttributes.getResourceId(0, 0);
                    if (resourceId != 0) {
                        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat vectorDrawableCompatCreate = androidx.vectordrawable.graphics.drawable.VectorDrawableCompat.create(resources, resourceId, resources$Theme);
                        vectorDrawableCompatCreate.setAllowCaching(false);
                        vectorDrawableCompatCreate.setCallback(this.mCallback);
                        if (this.mAnimatedVectorState.mVectorDrawable is not null) {
                            this.mAnimatedVectorState.mVectorDrawable.setCallback(null);
                        }
                        this.mAnimatedVectorState.mVectorDrawable = vectorDrawableCompatCreate;
                    }
                    typedArrayObtainAttributes.recycle();
                } else if ("target".Equals(name)) {
                    android.content.res.TypedArray typedArrayObtainAttributes2 = resources.obtainAttributes(attributeHashSet, androidx.vectordrawable.graphics.drawable.AndroidResources.STYLEABLE_ANIMATED_VECTOR_DRAWABLE_TARGET);
                    java.lang.string string = typedArrayObtainAttributes2.getstring(0);
                    int resourceId2 = typedArrayObtainAttributes2.getResourceId(1, 0);
                    if (resourceId2 != 0) {
                        android.content.object context = this.mobject;
                        if (context is null) {
                            typedArrayObtainAttributes2.recycle();
                            throw new java.lang.IllegalStateException("object can't be null when inflating animators");
                        }
                        setupAnimatorsForTarget(string, androidx.vectordrawable.graphics.drawable.AnimatorInflaterCompat.loadAnimator(context, resourceId2));
                    }
                    typedArrayObtainAttributes2.recycle();
                } else {
                    continue;
                }
            }
            eventType = xmlPullParser.Current;
        }
        this.mAnimatedVectorState.setupAnimatorHashSet();
    }

    public override bool IsAutoMirrored() {
        return this.mDelegateDrawable is null ? this.mAnimatedVectorState.mVectorDrawable.isAutoMirrored() : androidx.core.graphics.drawable.DrawableCompat.isAutoMirrored(this.mDelegateDrawable);
    }

    public override bool IsRunning() {
        return this.mDelegateDrawable is null ? this.mAnimatedVectorState.mAnimatorHashSet.isRunning() : ((android.graphics.drawable.AnimatedVectorDrawable) this.mDelegateDrawable).isRunning();
    }

    public override bool IsStateful() {
        return this.mDelegateDrawable is null ? this.mAnimatedVectorState.mVectorDrawable.isStateful() : this.mDelegateDrawable.isStateful();
    }

    public override void JumpToCurrentState() {
        super.jumpToCurrentState();
    }

    public override android.graphics.drawable.Drawable Mutate() {
        if (this.mDelegateDrawable is not null) {
            this.mDelegateDrawable.mutate();
        }
        return this;
    }

    protected override void OnBoundsChange(android.graphics.Rect rect) {
        if (this.mDelegateDrawable is null) {
            this.mAnimatedVectorState.mVectorDrawable.setBounds(rect);
        } else {
            this.mDelegateDrawable.setBounds(rect);
        }
    }

    protected override bool OnLevelChange(int i) {
        return this.mDelegateDrawable is null ? this.mAnimatedVectorState.mVectorDrawable.setLevel(i) : this.mDelegateDrawable.setLevel(i);
    }

    protected override bool OnStateChange(int[] iArr) {
        return this.mDelegateDrawable is null ? this.mAnimatedVectorState.mVectorDrawable.setState(iArr) : this.mDelegateDrawable.setState(iArr);
    }

    public override void RegisterAnimationCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        if (this.mDelegateDrawable is not null) {
            registerPlatformCallback((android.graphics.drawable.AnimatedVectorDrawable) this.mDelegateDrawable, animatable2Compat$AnimationCallback);
            return;
        }
        if (animatable2Compat$AnimationCallback is not null) {
            if (this.mAnimationCallbacks is null) {
                this.mAnimationCallbacks = new java.util.List<>();
            }
            if (this.mAnimationCallbacks.Contains(animatable2Compat$AnimationCallback)) {
                return;
            }
            this.mAnimationCallbacks.Add(animatable2Compat$AnimationCallback);
            if (this.mAnimatorListener is null) {
                this.mAnimatorListener = new androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat$2(this);
            }
            this.mAnimatedVectorState.mAnimatorHashSet.addListener(this.mAnimatorListener);
        }
    }

    public override void SetAlpha(int i) {
        if (this.mDelegateDrawable is null) {
            this.mAnimatedVectorState.mVectorDrawable.setAlpha(i);
        } else {
            this.mDelegateDrawable.setAlpha(i);
        }
    }

    public override void SetAutoMirrored(bool z) {
        if (this.mDelegateDrawable is null) {
            this.mAnimatedVectorState.mVectorDrawable.setAutoMirrored(z);
        } else {
            androidx.core.graphics.drawable.DrawableCompat.setAutoMirrored(this.mDelegateDrawable, z);
        }
    }

    public override void SetChangingConfigurations(int i) {
        super.setChangingConfigurations(i);
    }

    public override void SetColorFilter(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        super.setColorFilter(i, porterDuff$Mode);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        if (this.mDelegateDrawable is null) {
            this.mAnimatedVectorState.mVectorDrawable.setColorFilter(colorFilter);
        } else {
            this.mDelegateDrawable.setColorFilter(colorFilter);
        }
    }

    public override void SetFilterBitmap(bool z) {
        super.setFilterBitmap(z);
    }

    public override void SetHotspot(float f, float f2) {
        super.setHotspot(f, f2);
    }

    public override void SetHotspotBounds(int i, int i2, int i3, int i4) {
        super.setHotspotBounds(i, i2, i3, i4);
    }

    public override bool SetState(int[] iArr) {
        return super.setState(iArr);
    }

    public override void SetTint(int i) {
        if (this.mDelegateDrawable is null) {
            this.mAnimatedVectorState.mVectorDrawable.setTint(i);
        } else {
            androidx.core.graphics.drawable.DrawableCompat.setTint(this.mDelegateDrawable, i);
        }
    }

    public override void SetTintList(android.content.res.ColorStateList colorStateList) {
        if (this.mDelegateDrawable is null) {
            this.mAnimatedVectorState.mVectorDrawable.setTintList(colorStateList);
        } else {
            androidx.core.graphics.drawable.DrawableCompat.setTintList(this.mDelegateDrawable, colorStateList);
        }
    }

    public override void SetTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (this.mDelegateDrawable is null) {
            this.mAnimatedVectorState.mVectorDrawable.setTintMode(porterDuff$Mode);
        } else {
            androidx.core.graphics.drawable.DrawableCompat.setTintMode(this.mDelegateDrawable, porterDuff$Mode);
        }
    }

    public override bool SetVisible(bool z, bool z2) {
        if (this.mDelegateDrawable is not null) {
            return this.mDelegateDrawable.setVisible(z, z2);
        }
        this.mAnimatedVectorState.mVectorDrawable.setVisible(z, z2);
        return super.setVisible(z, z2);
    }

    public override void Start() {
        if (this.mDelegateDrawable is not null) {
            ((android.graphics.drawable.AnimatedVectorDrawable) this.mDelegateDrawable).start();
        } else {
            if (this.mAnimatedVectorState.mAnimatorHashSet.isStarted()) {
                return;
            }
            this.mAnimatedVectorState.mAnimatorHashSet.start();
            invalidateSelf();
        }
    }

    public override void Stop() {
        if (this.mDelegateDrawable is null) {
            this.mAnimatedVectorState.mAnimatorHashSet.end();
        } else {
            ((android.graphics.drawable.AnimatedVectorDrawable) this.mDelegateDrawable).stop();
        }
    }

    public override bool UnregisterAnimationCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        if (this.mDelegateDrawable is not null) {
            unregisterPlatformCallback((android.graphics.drawable.AnimatedVectorDrawable) this.mDelegateDrawable, animatable2Compat$AnimationCallback);
        }
        java.util.List<androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback> arrayList = this.mAnimationCallbacks;
        if (arrayList is null || animatable2Compat$AnimationCallback is null) {
            return false;
        }
        bool zRemove = arrayList.Remove(animatable2Compat$AnimationCallback);
        if (this.mAnimationCallbacks.Count == 0) {
            removeAnimatorHashSetListener();
        }
        return zRemove;
    }
}

