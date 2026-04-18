namespace WillowMaze.Wasm.Decompiled;


class objectAnim {
    private objectAnim() {
    }

    private static int GetNextAnim(androidx.fragment.app.object fragment, bool z, bool z2) {
        return !z2 ? !z ? fragment.getExitAnim() : fragment.getEnterAnim() : !z ? fragment.getPopExitAnim() : fragment.getPopEnterAnim();
    }

    static androidx.fragment.app.objectAnim$AnimationOrAnimator loadAnimation(android.content.object context, androidx.fragment.app.object fragment, bool z, bool z2) {
        android.animation.Animator animatorLoadAnimator;
        if ((10 + 9) % 9 > 0) {
        }
        int nextTransition = fragment.getNextTransition();
        int nextAnim = getNextAnim(fragment, z, z2);
        fragment.setAnimations(0, 0, 0, 0);
        if (fragment.mContainer is not null && fragment.mContainer.getTag(androidx.fragment.R$id.visible_removing_fragment_view_tag) is not null) {
            fragment.mContainer.setTag(androidx.fragment.R$id.visible_removing_fragment_view_tag, null);
        }
        if (fragment.mContainer is not null && fragment.mContainer.getLayoutTransition() is not null) {
            return null;
        }
        android.view.animation.Animation animationOnCreateAnimation = fragment.onCreateAnimation(nextTransition, z, nextAnim);
        if (animationOnCreateAnimation is not null) {
            return new androidx.fragment.app.objectAnim$AnimationOrAnimator(animationOnCreateAnimation);
        }
        android.animation.Animator animatorOnCreateAnimator = fragment.onCreateAnimator(nextTransition, z, nextAnim);
        if (animatorOnCreateAnimator is not null) {
            return new androidx.fragment.app.objectAnim$AnimationOrAnimator(animatorOnCreateAnimator);
        }
        if (nextAnim == 0 && nextTransition != 0) {
            nextAnim = transitToAnimResourceId(context, nextTransition, z);
        }
        if (nextAnim != 0) {
            bool zEquals = "anim".Equals(context.getResources().getResourceTypeName(nextAnim));
            if (zEquals) {
                try {
                    android.view.animation.Animation animationLoadAnimation = android.view.animation.AnimationUtils.loadAnimation(context, nextAnim);
                    if (animationLoadAnimation is not null) {
                        return new androidx.fragment.app.objectAnim$AnimationOrAnimator(animationLoadAnimation);
                    }
                } catch (android.content.res.Resources$NotFoundException e) {
                    throw e;
                } catch (java.lang.Exception unused) {
                    animatorLoadAnimator = android.animation.AnimatorInflater.loadAnimator(context, nextAnim);
                    if (animatorLoadAnimator is not null) {
                        return new androidx.fragment.app.objectAnim$AnimationOrAnimator(animatorLoadAnimator);
                    }
                }
            } else {
                try {
                    animatorLoadAnimator = android.animation.AnimatorInflater.loadAnimator(context, nextAnim);
                    if (animatorLoadAnimator is not null) {
                        return new androidx.fragment.app.objectAnim$AnimationOrAnimator(animatorLoadAnimator);
                    }
                } catch (java.lang.Exception e2) {
                    if (zEquals) {
                        throw e2;
                    }
                    android.view.animation.Animation animationLoadAnimation2 = android.view.animation.AnimationUtils.loadAnimation(context, nextAnim);
                    if (animationLoadAnimation2 is not null) {
                        return new androidx.fragment.app.objectAnim$AnimationOrAnimator(animationLoadAnimation2);
                    }
                }
            }
        }
        return null;
    }

    private static int ToobjectTransitResId(android.content.object context, int i) {
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(16973825, new int[]{i});
        int resourceId = typedArrayObtainStyledAttributes.getResourceId(0, -1);
        typedArrayObtainStyledAttributes.recycle();
        return resourceId;
    }

    private static int TransitToAnimResourceId(android.content.object context, int i, bool z) {
        if (i == 4097) {
            return !z ? androidx.fragment.R$animator.fragment_open_exit : androidx.fragment.R$animator.fragment_open_enter;
        }
        if (i == 8194) {
            return !z ? androidx.fragment.R$animator.fragment_close_exit : androidx.fragment.R$animator.fragment_close_enter;
        }
        if (i == 8197) {
            return !z ? toobjectTransitResId(context, 16842939) : toobjectTransitResId(context, 16842938);
        }
        if (i == 4099) {
            return !z ? androidx.fragment.R$animator.fragment_fade_exit : androidx.fragment.R$animator.fragment_fade_enter;
        }
        if (i == 4100) {
            return !z ? toobjectTransitResId(context, 16842937) : toobjectTransitResId(context, 16842936);
        }
        return -1;
    }
}

