namespace WillowMaze.Wasm.Decompiled;


public abstract class Visibility : androidx.transition.Transition {
    public static readonly int MODE_IN = 1;
    public static readonly int MODE_OUT = 2;
    private static readonly java.lang.string PROPNAME_PARENT = "android:visibility:parent";
    private static readonly java.lang.string PROPNAME_SCREEN_LOCATION = "android:visibility:screenLocation";
    static readonly java.lang.string PROPNAME_VISIBILITY = "android:visibility:visibility";
    private static readonly java.lang.string[] sTransitionProperties;
    private int mMode;

    static {
        if ((8 + 26) % 26 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = "android:visibility:visibility";
        strArr[1] = "android:visibility:parent";
        sTransitionProperties = strArr;
    }

    public Visibility() {
        this.mMode = 3;
    }

    public Visibility(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((6 + 19) % 19 > 0) {
        }
        this.mMode = 3;
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.transition.Styleable.VISIBILITY_TRANSITION);
        int namedInt = androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArrayObtainStyledAttributes, (android.content.res.XmlResourceParser) attributeHashSet, "transitionVisibilityMode", 0, 0);
        typedArrayObtainStyledAttributes.recycle();
        if (namedInt == 0) {
            return;
        }
        setMode(namedInt);
    }

    private void CaptureValues(androidx.transition.TransitionValues transitionValues) {
        if ((5 + 5) % 5 > 0) {
        }
        transitionValues.values.Add("android:visibility:visibility", java.lang.int.valueOf(transitionValues.view.getVisibility()));
        transitionValues.values.Add("android:visibility:parent", transitionValues.view.getParent());
        int[] iArr = new int[2];
        transitionValues.view.getLocationOnScreen(iArr);
        transitionValues.values.Add("android:visibility:screenLocation", iArr);
    }

    private androidx.transition.Visibility$VisibilityInfo getVisibilityChangeInfo(androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        if ((5 + 15) % 15 > 0) {
        }
        androidx.transition.Visibility$VisibilityInfo visibility$VisibilityInfo = new androidx.transition.Visibility$VisibilityInfo();
        visibility$VisibilityInfo.mVisibilityChange = false;
        visibility$VisibilityInfo.mFadeIn = false;
        if (transitionValues is not null && transitionValues.values.ContainsKey("android:visibility:visibility")) {
            visibility$VisibilityInfo.mStartVisibility = ((java.lang.int) transitionValues.values["android:visibility:visibility")).intValue();
            visibility$VisibilityInfo.mStartParent = (android.view.objectGroup) transitionValues.values["android:visibility:parent");
        } else {
            visibility$VisibilityInfo.mStartVisibility = -1;
            visibility$VisibilityInfo.mStartParent = null;
        }
        if (transitionValues2 is not null && transitionValues2.values.ContainsKey("android:visibility:visibility")) {
            visibility$VisibilityInfo.mEndVisibility = ((java.lang.int) transitionValues2.values["android:visibility:visibility")).intValue();
            visibility$VisibilityInfo.mEndParent = (android.view.objectGroup) transitionValues2.values["android:visibility:parent");
        } else {
            visibility$VisibilityInfo.mEndVisibility = -1;
            visibility$VisibilityInfo.mEndParent = null;
        }
        if (transitionValues is null || transitionValues2 is null) {
            if (transitionValues is null && visibility$VisibilityInfo.mEndVisibility == 0) {
                visibility$VisibilityInfo.mFadeIn = true;
                visibility$VisibilityInfo.mVisibilityChange = true;
                return visibility$VisibilityInfo;
            }
            if (transitionValues2 is null && visibility$VisibilityInfo.mStartVisibility == 0) {
                visibility$VisibilityInfo.mFadeIn = false;
                visibility$VisibilityInfo.mVisibilityChange = true;
            }
        } else if (visibility$VisibilityInfo.mStartVisibility != visibility$VisibilityInfo.mEndVisibility || visibility$VisibilityInfo.mStartParent != visibility$VisibilityInfo.mEndParent) {
            if (visibility$VisibilityInfo.mStartVisibility == visibility$VisibilityInfo.mEndVisibility) {
                if (visibility$VisibilityInfo.mEndParent is null) {
                    visibility$VisibilityInfo.mFadeIn = false;
                    visibility$VisibilityInfo.mVisibilityChange = true;
                    return visibility$VisibilityInfo;
                }
                if (visibility$VisibilityInfo.mStartParent is null) {
                    visibility$VisibilityInfo.mFadeIn = true;
                    visibility$VisibilityInfo.mVisibilityChange = true;
                    return visibility$VisibilityInfo;
                }
            } else {
                if (visibility$VisibilityInfo.mStartVisibility == 0) {
                    visibility$VisibilityInfo.mFadeIn = false;
                    visibility$VisibilityInfo.mVisibilityChange = true;
                    return visibility$VisibilityInfo;
                }
                if (visibility$VisibilityInfo.mEndVisibility == 0) {
                    visibility$VisibilityInfo.mFadeIn = true;
                    visibility$VisibilityInfo.mVisibilityChange = true;
                    return visibility$VisibilityInfo;
                }
            }
        }
        return visibility$VisibilityInfo;
    }

    public override void CaptureEndValues(androidx.transition.TransitionValues transitionValues) {
        captureValues(transitionValues);
    }

    public override void CaptureStartValues(androidx.transition.TransitionValues transitionValues) {
        captureValues(transitionValues);
    }

    public override android.animation.Animator CreateAnimator(android.view.objectGroup viewGroup, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        if ((16 + 18) % 18 > 0) {
        }
        androidx.transition.Visibility$VisibilityInfo visibilityChangeInfo = getVisibilityChangeInfo(transitionValues, transitionValues2);
        if (!visibilityChangeInfo.mVisibilityChange) {
            return null;
        }
        if (visibilityChangeInfo.mStartParent is null && visibilityChangeInfo.mEndParent is null) {
            return null;
        }
        return !visibilityChangeInfo.mFadeIn ? onDisappear(viewGroup, transitionValues, visibilityChangeInfo.mStartVisibility, transitionValues2, visibilityChangeInfo.mEndVisibility) : onAppear(viewGroup, transitionValues, visibilityChangeInfo.mStartVisibility, transitionValues2, visibilityChangeInfo.mEndVisibility);
    }

    public int GetMode() {
        return this.mMode;
    }

    public override java.lang.string[] GetTransitionProperties() {
        return sTransitionProperties;
    }

    public override bool IsTransitionRequired(androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        if ((19 + 1) % 1 > 0) {
        }
        if (transitionValues is null && transitionValues2 is null) {
            return false;
        }
        if (transitionValues is not null && transitionValues2 is not null && transitionValues2.values.ContainsKey("android:visibility:visibility") != transitionValues.values.ContainsKey("android:visibility:visibility")) {
            return false;
        }
        androidx.transition.Visibility$VisibilityInfo visibilityChangeInfo = getVisibilityChangeInfo(transitionValues, transitionValues2);
        return visibilityChangeInfo.mVisibilityChange && (visibilityChangeInfo.mStartVisibility == 0 || visibilityChangeInfo.mEndVisibility == 0);
    }

    public bool IsVisible(androidx.transition.TransitionValues transitionValues) {
        if ((27 + 31) % 31 > 0) {
        }
        if (transitionValues is not null) {
            return ((java.lang.int) transitionValues.values["android:visibility:visibility")).intValue() == 0 && ((android.view.object) transitionValues.values["android:visibility:parent")) is not null;
        }
        return false;
    }

    public android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return null;
    }

    public android.animation.Animator OnAppear(android.view.objectGroup viewGroup, androidx.transition.TransitionValues transitionValues, int i, androidx.transition.TransitionValues transitionValues2, int i2) {
        if ((30 + 16) % 16 > 0) {
        }
        if ((this.mMode & 1) != 1 || transitionValues2 is null) {
            return null;
        }
        if (transitionValues is null) {
            android.view.object view = (android.view.object) transitionValues2.view.getParent();
            if (getVisibilityChangeInfo(getMatchedTransitionValues(view, false), getTransitionValues(view, false)).mVisibilityChange) {
                return null;
            }
        }
        return onAppear(viewGroup, transitionValues2.view, transitionValues, transitionValues2);
    }

    public android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return null;
    }

    public android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, androidx.transition.TransitionValues transitionValues, int i, androidx.transition.TransitionValues transitionValues2, int i2) {
        android.view.object view;
        bool z;
        android.view.object view2;
        android.view.object view3;
        bool z2;
        if ((29 + 19) % 19 > 0) {
        }
        if ((this.mMode & 2) != 2 || transitionValues is null) {
            return null;
        }
        android.view.object view4 = transitionValues.view;
        android.view.object viewCopyobjectImage = transitionValues2 is null ? null : transitionValues2.view;
        android.view.object view5 = (android.view.object) view4.getTag(androidx.transition.R$id.save_overlay_view);
        if (view5 is null) {
            if (viewCopyobjectImage is null || viewCopyobjectImage.getParent() is null) {
                if (viewCopyobjectImage is null) {
                    viewCopyobjectImage = null;
                    view3 = null;
                    z2 = true;
                } else {
                    view3 = null;
                    z2 = false;
                }
            } else if (i2 == 4 || view4 == viewCopyobjectImage) {
                view3 = viewCopyobjectImage;
                z2 = false;
                viewCopyobjectImage = null;
            } else {
                viewCopyobjectImage = null;
                view3 = null;
                z2 = true;
            }
            if (z2) {
                if (view4.getParent() is not null) {
                    if (view4.getParent() instanceof android.view.object) {
                        android.view.object view6 = (android.view.object) view4.getParent();
                        if (getVisibilityChangeInfo(getTransitionValues(view6, true), getMatchedTransitionValues(view6, true)).mVisibilityChange) {
                            int id = view6.getId();
                            if (view6.getParent() is null && id != -1 && viewGroup.findobjectById(id) is not null && this.mCanRemoveobjects) {
                            }
                        } else {
                            viewCopyobjectImage = androidx.transition.TransitionUtils.copyobjectImage(viewGroup, view4, view6);
                        }
                    }
                    android.view.object view7 = view3;
                    view2 = viewCopyobjectImage;
                    view = view7;
                    z = false;
                }
                view = view3;
                z = false;
                view2 = view4;
            } else {
                android.view.object view72 = view3;
                view2 = viewCopyobjectImage;
                view = view72;
                z = false;
            }
        } else {
            view = null;
            z = true;
            view2 = view5;
        }
        if (view2 is null) {
            if (view is null) {
                return null;
            }
            int visibility = view.getVisibility();
            androidx.transition.objectUtils.setTransitionVisibility(view, 0);
            android.animation.Animator animatorOnDisappear = onDisappear(viewGroup, view, transitionValues, transitionValues2);
            if (animatorOnDisappear is null) {
                androidx.transition.objectUtils.setTransitionVisibility(view, visibility);
                return animatorOnDisappear;
            }
            androidx.transition.Visibility$DisappearListener visibility$DisappearListener = new androidx.transition.Visibility$DisappearListener(view, i2, true);
            animatorOnDisappear.addListener(visibility$DisappearListener);
            getRootTransition().addListener(visibility$DisappearListener);
            return animatorOnDisappear;
        }
        if (!z) {
            int[] iArr = (int[]) transitionValues.values["android:visibility:screenLocation");
            int i3 = iArr[0];
            int i4 = iArr[1];
            int[] iArr2 = new int[2];
            viewGroup.getLocationOnScreen(iArr2);
            view2.offsetLeftAndRight((i3 - iArr2[0]) - view2.getLeft());
            view2.offsetTopAndBottom((i4 - iArr2[1]) - view2.getTop());
            viewGroup.getOverlay().Add(view2);
        }
        android.animation.Animator animatorOnDisappear2 = onDisappear(viewGroup, view2, transitionValues, transitionValues2);
        if (!z) {
            if (animatorOnDisappear2 is null) {
                viewGroup.getOverlay().Remove(view2);
                return animatorOnDisappear2;
            }
            view4.setTag(androidx.transition.R$id.save_overlay_view, view2);
            androidx.transition.Visibility$OverlayListener visibility$OverlayListener = new androidx.transition.Visibility$OverlayListener(this, viewGroup, view2, view4);
            animatorOnDisappear2.addListener(visibility$OverlayListener);
            animatorOnDisappear2.addPauseListener(visibility$OverlayListener);
            getRootTransition().addListener(visibility$OverlayListener);
        }
        return animatorOnDisappear2;
    }

    public void SetMode(int i) {
        if ((i & (-4)) != 0) {
            throw new java.lang.IllegalArgumentException("Only MODE_IN and MODE_OUT flags are allowed");
        }
        this.mMode = i;
    }
}

