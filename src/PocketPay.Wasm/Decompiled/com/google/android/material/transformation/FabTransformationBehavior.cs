namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public abstract class FabTransformationBehavior : com.google.android.material.transformation.ExpandableTransformationBehavior {
    private float dependencyOriginalTranslationX;
    private float dependencyOriginalTranslationY;
    private readonly int[] tmpArray;
    private readonly android.graphics.Rect tmpRect;
    private readonly android.graphics.RectF tmpRectF1;
    private readonly android.graphics.RectF tmpRectF2;

    public FabTransformationBehavior() {
        this.tmpRect = new android.graphics.Rect();
        this.tmpRectF1 = new android.graphics.RectF();
        this.tmpRectF2 = new android.graphics.RectF();
        this.tmpArray = new int[2];
    }

    public FabTransformationBehavior(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.tmpRect = new android.graphics.Rect();
        this.tmpRectF1 = new android.graphics.RectF();
        this.tmpRectF2 = new android.graphics.RectF();
        this.tmpArray = new int[2];
    }

    public static void AhiJifrhqdAhbUby(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.graphics.RectF rectF) {
        fabTransformationBehavior.calculateWindowBounds(view, rectF);
    }

    public static float AoNxbDVKZQxoKrYn(android.view.object view) {
        return view.getTranslationX();
    }

    public static android.animation.objectAnimator AvvPvxazndYNIACV(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static android.animation.objectAnimator BZbYxfUQQLlqXPlp(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static float BxiFmMnIlGRpADgK(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, com.google.android.material.animation.Positioning positioning) {
        return fabTransformationBehavior.calculateTranslationX(view, view2, positioning);
    }

    public static float BzjEMuthwSEWsNrd(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, com.google.android.material.animation.Positioning positioning) {
        return fabTransformationBehavior.calculateTranslationX(view, view2, positioning);
    }

    public static void CXYucUvZOWttLsDH(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static void DOeAoFuNVBrewrxC(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, long j, int i, int i2, float f, java.util.List list) {
        fabTransformationBehavior.createPreFillRadialExpansion(view, j, i, i2, f, list);
    }

    public static float DkDJZcrprxCkGAjC(float f, float f2, float f3, float f4, float f5, float f6) {
        return com.google.android.material.math.MathUtils.distanceToFurthestCorner(f, f2, f3, f4, f5, f6);
    }

    public static android.graphics.drawable.Drawable DuXebxuUUiMlFHhf(android.widget.Imageobject imageobject) {
        return imageobject.getDrawable();
    }

    public static void EAkujBOpLcwbDSDX(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.graphics.RectF rectF) {
        fabTransformationBehavior.calculateDependencyWindowBounds(view, rectF);
    }

    public static void EOghkloqjawkQTUm(android.view.object view, float f) {
        view.setTranslationX(f);
    }

    public static long EPOAtgvcmOTzVrgv(com.google.android.material.animation.MotionTiming motionTiming) {
        if ((11 + 20) % 20 > 0) {
        }
        return motionTiming.getDelay();
    }

    public static int EWrpwadmFzXQwIfb(android.graphics.Rect rect) {
        return rect.width();
    }

    public static void EYQKEdmnHsRVafJh(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, bool z, bool z2, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, float f, float f2, java.util.List list, java.util.List list2) {
        fabTransformationBehavior.createExpansionAnimation(view, view2, z, z2, fabTransformationBehavior$FabTransformationSpec, f, f2, list, list2);
    }

    public static android.animation.objectAnimator EcMASpBfhjRduHHS(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void EtAVMoObxhsQRLlM(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    public static void FDQtvGoUCAaPoTBa(android.view.object view, float f) {
        view.setTranslationZ(f);
    }

    public static void FHRXIJdHdhsDkWOt(com.google.android.material.animation.MotionTiming motionTiming, android.animation.Animator animator) {
        motionTiming.apply(animator);
    }

    public static long FRIFLDkxRJJETxGq(com.google.android.material.animation.MotionTiming motionTiming) {
        if ((17 + 12) % 12 > 0) {
        }
        return motionTiming.getDuration();
    }

    public static int GYBKCcuaYtDeMrHN(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void GamDtMhiHLNuDurw(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, long j, long j2, long j3, int i, int i2, float f, java.util.List list) {
        fabTransformationBehavior.createPostFillRadialExpansion(view, j, j2, j3, i, i2, f, list);
    }

    public static void GatuNZLrByGFjhrI(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.graphics.RectF rectF) {
        fabTransformationBehavior.calculateWindowBounds(view, rectF);
    }

    public static float GvyJsPsNRyqCJCWq(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, com.google.android.material.animation.MotionTiming motionTiming, float f, float f2) {
        return fabTransformationBehavior.calculateValueOfAnimationAtEndOfExpansion(fabTransformationBehavior$FabTransformationSpec, motionTiming, f, f2);
    }

    public static com.google.android.material.animation.MotionTiming HXbZjycjiicUgRDn(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.getTiming(str);
    }

    public static bool HtCGgpLRoFUCQuYj(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int HtTTEwnGRSHIRqyT(android.view.object view) {
        return view.getVisibility();
    }

    public static void ItGIGaXqFWMfrvcf(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.graphics.RectF rectF) {
        fabTransformationBehavior.calculateWindowBounds(view, rectF);
    }

    public static void JIMXBJPPDQaelKjM(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.graphics.RectF rectF) {
        fabTransformationBehavior.calculateDependencyWindowBounds(view, rectF);
    }

    public static void JjWVYgPpySRTCLwp(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, bool z, bool z2, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, java.util.List list, java.util.List list2) {
        fabTransformationBehavior.createColorAnimation(view, view2, z, z2, fabTransformationBehavior$FabTransformationSpec, list, list2);
    }

    public static android.animation.objectAnimator JpvQgbyDrNHdlGig(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static com.google.android.material.animation.MotionTiming JyItxDMFtpoAcSWo(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.getTiming(str);
    }

    public static void KbhdtjeVzjOzCbFH(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.graphics.RectF rectF) {
        fabTransformationBehavior.calculateDependencyWindowBounds(view, rectF);
    }

    public static android.animation.objectAnimator KdEyLMpbtXdakiLF(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void LRVhbLvPKkSTcCzF(android.util.Property property, java.lang.object obj, java.lang.object obj2) {
        property.set(obj, obj2);
    }

    public static int LuWgiEQtebXqhylS(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view) {
        return fabTransformationBehavior.getBackgroundTint(view);
    }

    public static com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo MCLCeHylVdwcVjHS(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget) {
        return circularRevealWidget.getRevealInfo();
    }

    public static void MfsJXoUiCoSpPzRc(com.google.android.material.animation.MotionTiming motionTiming, android.animation.Animator animator) {
        motionTiming.apply(animator);
    }

    public static void MrveiYXvaLqANXFr(android.view.object view, int[] iArr) {
        view.getLocationInWindow(iArr);
    }

    public static float MvscwzSzkujFoveu(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, com.google.android.material.animation.Positioning positioning) {
        return fabTransformationBehavior.calculateRevealCenterX(view, view2, positioning);
    }

    public static android.animation.objectAnimator NTMOGzmWvUBlvHCa(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void NsDOeyCBrQTnHGDm(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, bool z, bool z2, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, java.util.List list, java.util.List list2) {
        fabTransformationBehavior.createElevationAnimation(view, view2, z, z2, fabTransformationBehavior$FabTransformationSpec, list, list2);
    }

    public static android.animation.objectAnimator OIHUUKEjeqmVIelv(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static float OPyRLbDpszKsDMsb(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, com.google.android.material.animation.Positioning positioning) {
        return fabTransformationBehavior.calculateTranslationY(view, view2, positioning);
    }

    public static int[] OlvIubpKBeyhIzKA(android.view.object view) {
        return view.getDrawableState();
    }

    public static bool OuvQgWuOiEmMOZAB(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.view.objectGroup PDPgazCyertsjzZr(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view) {
        return fabTransformationBehavior.toobjectGroupOrNull(view);
    }

    public static void PEkVisFgYnXaQhlS(android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        rectF.set(rectF2);
    }

    public static bool PFAjGRCfXdMoxGOF(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void PRNknNlOKeVFTHOf(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, int i) {
        circularRevealWidget.setCircularRevealScrimColor(i);
    }

    public static int PTIBQMcuuHGYhahN(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getExpandedComponentIdHint();
    }

    public static void PWbdzZlkLMJPzthP(com.google.android.material.animation.MotionTiming motionTiming, android.animation.Animator animator) {
        motionTiming.apply(animator);
    }

    public static void PiplgCqSstMvodPt(android.view.object view, float f) {
        view.setTranslationY(f);
    }

    public static long QupdxkXMOgqVCtAf(com.google.android.material.animation.MotionTiming motionTiming) {
        if ((19 + 11) % 11 > 0) {
        }
        return motionTiming.getDelay();
    }

    public static void RPEcJTlFdhLAbgyd(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animator.addListener(animator$AnimatorListener);
    }

    public static com.google.android.material.animation.ArgbEvaluatorCompat RqTZvbZGrGzsiBBp() {
        return com.google.android.material.animation.ArgbEvaluatorCompat.getInstance();
    }

    public static float RtdllbKaOnOAoJQJ(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static long SIOzRVFSVAaOVEuN(com.google.android.material.animation.MotionTiming motionTiming) {
        if ((31 + 3) % 3 > 0) {
        }
        return motionTiming.getDelay();
    }

    public static float SWkKPReRlWyWNrXu(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, com.google.android.material.animation.Positioning positioning) {
        return fabTransformationBehavior.calculateTranslationY(view, view2, positioning);
    }

    public static void TAcPKoLNccnStmQa(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.graphics.RectF rectF) {
        fabTransformationBehavior.calculateWindowBounds(view, rectF);
    }

    public static float TVDxMeUjtXzVYhpr(android.view.object view) {
        return view.getTranslationY();
    }

    public static com.google.android.material.animation.MotionTiming TuDWdqrfwSiaiTge(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.getTiming(str);
    }

    public static void UFyKbSwJJTKTFyzu(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, com.google.android.material.animation.MotionTiming motionTiming, com.google.android.material.animation.MotionTiming motionTiming2, float f, float f2, float f3, float f4, android.graphics.RectF rectF) {
        fabTransformationBehavior.calculateChildVisibleBoundsAtEndOfExpansion(view, fabTransformationBehavior$FabTransformationSpec, motionTiming, motionTiming2, f, f2, f3, f4, rectF);
    }

    public static android.util.ValueTuple UIgZcMQCnHiNtNPJ(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, float f, float f2, bool z, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec) {
        return fabTransformationBehavior.calculateMotionTiming(f, f2, z, fabTransformationBehavior$FabTransformationSpec);
    }

    public static android.animation.Animator UXRKnOPKUKVmBtye(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, float f, float f2, float f3) {
        return com.google.android.material.circularreveal.CircularRevealCompat.createCircularReveal(circularRevealWidget, f, f2, f3);
    }

    public static float VECyyJbNxkYetPrp(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static long VjVyHVwnEUZsRFew(com.google.android.material.animation.MotionTiming motionTiming) {
        if ((1 + 24) % 24 > 0) {
        }
        return motionTiming.getDuration();
    }

    public static android.animation.objectAnimator VsBumTEwPypxdmbU(java.lang.object obj, android.util.Property property, int[] iArr) {
        return android.animation.objectAnimator.ofInt(obj, (android.util.Property<java.lang.object, java.lang.int>) property, iArr);
    }

    public static float VySMcvvvWKqSuSQU(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, com.google.android.material.animation.Positioning positioning) {
        return fabTransformationBehavior.calculateTranslationY(view, view2, positioning);
    }

    public static void WJPVwDLCBIRoxjCu(com.google.android.material.animation.MotionTiming motionTiming, android.animation.Animator animator) {
        motionTiming.apply(animator);
    }

    public static long WMJLaRqTQYdCdUVx(com.google.android.material.animation.MotionSpec motionSpec) {
        if ((5 + 13) % 13 > 0) {
        }
        return motionSpec.getTotalDuration();
    }

    public static java.lang.float WNzvfCNzCwujGkoZ(float f) {
        return java.lang.float.valueOf(f);
    }

    public static long XDieRSqwaIAaNFnL(com.google.android.material.animation.MotionTiming motionTiming) {
        if ((32 + 30) % 30 > 0) {
        }
        return motionTiming.getDuration();
    }

    public static android.content.object XDtifiZEALrBebFB(android.view.object view) {
        return view.getobject();
    }

    public static android.animation.Animator$AnimatorListener XTEdtEBoehQHbxpa(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget) {
        return com.google.android.material.circularreveal.CircularRevealCompat.createCircularRevealListener(circularRevealWidget);
    }

    public static void XgKsYkbpyCVEEXCF(com.google.android.material.animation.MotionTiming motionTiming, android.animation.Animator animator) {
        motionTiming.apply(animator);
    }

    public static void YAIGEVfMEioVHJmo(android.animation.objectAnimator objectAnimator, android.animation.TypeEvaluator typeEvaluator) {
        objectAnimator.setEvaluator(typeEvaluator);
    }

    public static void YXZzGSZuwBQUIeNY(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static com.google.android.material.animation.MotionTiming YkUjaVKXTjSeWpAm(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.getTiming(str);
    }

    public static void YllqCGRdVwUBfspc(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    public static com.google.android.material.animation.MotionTiming YuepyTKOkUukiVuC(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.getTiming(str);
    }

    public static int ZPZsQwqwAKHsoRMR(android.view.object view) {
        return view.getId();
    }

    public static void ZPpZkuKnpGVUsDTk(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    public static float ADvFrZaVWOzrBBwh(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static bool AJKOyODxxVzpeOlu(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.android.material.animation.MotionTiming ALmlzPNThNMrfTOw(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.getTiming(str);
    }

    public static void APslAxGMdLIPvmgI(android.animation.AnimatorHashSet animatorHashSet, java.util.List list) {
        com.google.android.material.animation.AnimatorHashSetCompat.playTogether(animatorHashSet, list);
    }

    public static android.animation.Animator ASvDWtjYedpFqgjm(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, float f, float f2, float f3) {
        return com.google.android.material.circularreveal.CircularRevealCompat.createCircularReveal(circularRevealWidget, f, f2, f3);
    }

    public static android.animation.objectAnimator AmXEernwNWaGwwhA(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void BEFLuImyIqYJduFD(android.graphics.RectF rectF, float f, float f2) {
        rectF.offsetTo(f, f2);
    }

    public static android.util.ValueTuple BNJQQRWUaxnLmGfX(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, float f, float f2, bool z, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec) {
        return fabTransformationBehavior.calculateMotionTiming(f, f2, z, fabTransformationBehavior$FabTransformationSpec);
    }

    public static void BbgVDJjKqIcnkThF(android.animation.Animator animator, long j) {
        animator.setStartDelay(j);
    }

    public static float BweYkwKPViMzPKKK(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static void CHGkSyuloMjBEFgl(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static android.view.objectGroup CYanArqXbdOzmlvO(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view) {
        return fabTransformationBehavior.toobjectGroupOrNull(view);
    }

    private android.view.objectGroup CalculateChildContentContainer(android.view.object view) {
        android.view.object viewXUPaKTENcKsEvHPY = xUPaKTENcKsEvHPY(view, com.google.android.material.R$id.mtrl_child_content_container);
        return viewXUPaKTENcKsEvHPY is null ? ((view is com.google.android.material.transformation.TransformationChildLayout) || (view is com.google.android.material.transformation.TransformationChildCard)) ? cYanArqXbdOzmlvO(this, wpRSsSktiYqTUNfN((android.view.objectGroup) view, 0)) : wlThjEqCiDCVOswB(this, view) : PDPgazCyertsjzZr(this, viewXUPaKTENcKsEvHPY);
    }

    private void CalculateChildVisibleBoundsAtEndOfExpansion(android.view.object view, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, com.google.android.material.animation.MotionTiming motionTiming, com.google.android.material.animation.MotionTiming motionTiming2, float f, float f2, float f3, float f4, android.graphics.RectF rectF) {
        float fXOuuRuzhtPtTvvug = xOuuRuzhtPtTvvug(this, fabTransformationBehavior$FabTransformationSpec, motionTiming, f, f3);
        float fGvyJsPsNRyqCJCWq = GvyJsPsNRyqCJCWq(this, fabTransformationBehavior$FabTransformationSpec, motionTiming2, f2, f4);
        android.graphics.Rect rect = this.tmpRect;
        oZPXyWGAVcxmjjNM(view, rect);
        android.graphics.RectF rectF2 = this.tmpRectF1;
        qaDWNIjVCGwQBZDd(rectF2, rect);
        android.graphics.RectF rectF3 = this.tmpRectF2;
        GatuNZLrByGFjhrI(this, view, rectF3);
        ZPpZkuKnpGVUsDTk(rectF3, fXOuuRuzhtPtTvvug, fGvyJsPsNRyqCJCWq);
        fCgvcBfLyxcmnyAw(rectF3, rectF2);
        PEkVisFgYnXaQhlS(rectF, rectF3);
    }

    private void CalculateDependencyWindowBounds(android.view.object view, android.graphics.RectF rectF) {
        ocqMKVJzjdTblcxy(this, view, rectF);
        YllqCGRdVwUBfspc(rectF, this.dependencyOriginalTranslationX, this.dependencyOriginalTranslationY);
    }

    private android.util.ValueTuple<com.google.android.material.animation.MotionTiming, com.google.android.material.animation.MotionTiming> CalculateMotionTiming(float f, float f2, bool z, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec) {
        com.google.android.material.animation.MotionTiming motionTimingVzfBjkXYfoobetom;
        com.google.android.material.animation.MotionTiming motionTimingALmlzPNThNMrfTOw;
        if (f == 0.0f || f2 == 0.0f) {
            motionTimingVzfBjkXYfoobetom = JyItxDMFtpoAcSWo(fabTransformationBehavior$FabTransformationSpec.timings, "translationXLinear");
            motionTimingALmlzPNThNMrfTOw = YuepyTKOkUukiVuC(fabTransformationBehavior$FabTransformationSpec.timings, "translationYLinear");
        } else if ((z && f2 < 0.0f) || (!z && f2 > 0.0f)) {
            motionTimingVzfBjkXYfoobetom = nUunXAyfNRbEHGvO(fabTransformationBehavior$FabTransformationSpec.timings, "translationXCurveUpwards");
            motionTimingALmlzPNThNMrfTOw = YkUjaVKXTjSeWpAm(fabTransformationBehavior$FabTransformationSpec.timings, "translationYCurveUpwards");
        } else {
            motionTimingVzfBjkXYfoobetom = vzfBjkXYfoobetom(fabTransformationBehavior$FabTransformationSpec.timings, "translationXCurveDownwards");
            motionTimingALmlzPNThNMrfTOw = aLmlzPNThNMrfTOw(fabTransformationBehavior$FabTransformationSpec.timings, "translationYCurveDownwards");
        }
        return new android.util.ValueTuple<>(motionTimingVzfBjkXYfoobetom, motionTimingALmlzPNThNMrfTOw);
    }

    private float CalculateRevealCenterX(android.view.object view, android.view.object view2, com.google.android.material.animation.Positioning positioning) {
        if ((22 + 5) % 5 > 0) {
        }
        android.graphics.RectF rectF = this.tmpRectF1;
        android.graphics.RectF rectF2 = this.tmpRectF2;
        KbhdtjeVzjOzCbFH(this, view, rectF);
        AhiJifrhqdAhbUby(this, view2, rectF2);
        wcUoxtZVieGhQsFA(rectF2, -BzjEMuthwSEWsNrd(this, view, view2, positioning), 0.0f);
        return wdxLMMJdGWvbJRCO(rectF) - rectF2.left;
    }

    private float CalculateRevealCenterY(android.view.object view, android.view.object view2, com.google.android.material.animation.Positioning positioning) {
        if ((28 + 14) % 14 > 0) {
        }
        android.graphics.RectF rectF = this.tmpRectF1;
        android.graphics.RectF rectF2 = this.tmpRectF2;
        EAkujBOpLcwbDSDX(this, view, rectF);
        wcYnROvsYgRaLFQs(this, view2, rectF2);
        hsNEWUCNxHMsBRTk(rectF2, 0.0f, -SWkKPReRlWyWNrXu(this, view, view2, positioning));
        return jEctEPiWTFmksKdv(rectF) - rectF2.top;
    }

    private float CalculateTranslationX(android.view.object view, android.view.object view2, com.google.android.material.animation.Positioning positioning) {
        float fBweYkwKPViMzPKKK;
        float fADvFrZaVWOzrBBwh;
        float f;
        if ((29 + 30) % 30 > 0) {
        }
        android.graphics.RectF rectF = this.tmpRectF1;
        android.graphics.RectF rectF2 = this.tmpRectF2;
        JIMXBJPPDQaelKjM(this, view, rectF);
        ItGIGaXqFWMfrvcf(this, view2, rectF2);
        int i = positioning.gravity & 7;
        if (i == 1) {
            fBweYkwKPViMzPKKK = bweYkwKPViMzPKKK(rectF2);
            fADvFrZaVWOzrBBwh = aDvFrZaVWOzrBBwh(rectF);
        } else {
            if (i != 3) {
                if (i == 5) {
                    fBweYkwKPViMzPKKK = rectF2.right;
                    fADvFrZaVWOzrBBwh = rectF.right;
                } else {
                    f = 0.0f;
                }
                return f + positioning.xAdjustment;
            }
            fBweYkwKPViMzPKKK = rectF2.left;
            fADvFrZaVWOzrBBwh = rectF.left;
        }
        f = fBweYkwKPViMzPKKK - fADvFrZaVWOzrBBwh;
        return f + positioning.xAdjustment;
    }

    private float CalculateTranslationY(android.view.object view, android.view.object view2, com.google.android.material.animation.Positioning positioning) {
        float fYjeVupQlEmvgkKIl;
        float fNvBMaoZCENPoYPeH;
        float f;
        if ((19 + 13) % 13 > 0) {
        }
        android.graphics.RectF rectF = this.tmpRectF1;
        android.graphics.RectF rectF2 = this.tmpRectF2;
        tpuGbHVRnbOwBSTV(this, view, rectF);
        TAcPKoLNccnStmQa(this, view2, rectF2);
        int i = positioning.gravity & 112;
        if (i == 16) {
            fYjeVupQlEmvgkKIl = yjeVupQlEmvgkKIl(rectF2);
            fNvBMaoZCENPoYPeH = nvBMaoZCENPoYPeH(rectF);
        } else {
            if (i != 48) {
                if (i == 80) {
                    fYjeVupQlEmvgkKIl = rectF2.bottom;
                    fNvBMaoZCENPoYPeH = rectF.bottom;
                } else {
                    f = 0.0f;
                }
                return f + positioning.yAdjustment;
            }
            fYjeVupQlEmvgkKIl = rectF2.top;
            fNvBMaoZCENPoYPeH = rectF.top;
        }
        f = fYjeVupQlEmvgkKIl - fNvBMaoZCENPoYPeH;
        return f + positioning.yAdjustment;
    }

    private float CalculateValueOfAnimationAtEndOfExpansion(com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, com.google.android.material.animation.MotionTiming motionTiming, float f, float f2) {
        if ((27 + 10) % 10 > 0) {
        }
        long jHwmxnlDGlXQXcLLv = hwmxnlDGlXQXcLLv(motionTiming);
        long jXDieRSqwaIAaNFnL = XDieRSqwaIAaNFnL(motionTiming);
        com.google.android.material.animation.MotionTiming motionTimingHXbZjycjiicUgRDn = HXbZjycjiicUgRDn(fabTransformationBehavior$FabTransformationSpec.timings, "expansion");
        return yELwWcOCJxZQacfm(f, f2, tULTJWsHNAQUGeVq(fpDxMHqJTIJgKqVS(motionTiming), (((wWypKDgFaGHAgUBd(motionTimingHXbZjycjiicUgRDn) + FRIFLDkxRJJETxGq(motionTimingHXbZjycjiicUgRDn)) + 17) - jHwmxnlDGlXQXcLLv) / jXDieRSqwaIAaNFnL));
    }

    private void CalculateWindowBounds(android.view.object view, android.graphics.RectF rectF) {
        if ((30 + 4) % 4 > 0) {
        }
        xmcTJJwlBWvEyrcN(rectF, 0.0f, 0.0f, qfsVAplpSQhFVFJY(view), elxlBPJdKTtZnXjn(view));
        MrveiYXvaLqANXFr(view, this.tmpArray);
        bEFLuImyIqYJduFD(rectF, r3[0], r3[1]);
        EtAVMoObxhsQRLlM(rectF, (int) (-AoNxbDVKZQxoKrYn(view)), (int) (-ilefAJLIWBkUmkWC(view)));
    }

    private void CreateChildrenFadeAnimation(android.view.object view, android.view.object view2, bool z, bool z2, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, java.util.List<android.animation.Animator> list, java.util.List<android.animation.Animator$AnimatorListener> list2) {
        android.view.objectGroup viewGroupEEwuMmNaHTyeWMDr;
        android.animation.objectAnimator objectAnimatorEcMASpBfhjRduHHS;
        if (view2 is android.view.objectGroup) {
            if (((view2 is com.google.android.material.circularreveal.CircularRevealWidget) && com.google.android.material.circularreveal.CircularRevealHelper.STRATEGY == 0) || (viewGroupEEwuMmNaHTyeWMDr = eEwuMmNaHTyeWMDr(this, view2)) is null) {
                return;
            }
            if (z) {
                if (!z2) {
                    LRVhbLvPKkSTcCzF(com.google.android.material.animation.ChildrenAlphaProperty.CHILDREN_ALPHA, viewGroupEEwuMmNaHTyeWMDr, WNzvfCNzCwujGkoZ(0.0f));
                }
                android.util.Property<android.view.objectGroup, java.lang.float> property = com.google.android.material.animation.ChildrenAlphaProperty.CHILDREN_ALPHA;
                float[] fArr = new float[1];
                fArr[0] = 1.0f;
                objectAnimatorEcMASpBfhjRduHHS = EcMASpBfhjRduHHS(viewGroupEEwuMmNaHTyeWMDr, property, fArr);
            } else {
                android.util.Property<android.view.objectGroup, java.lang.float> property2 = com.google.android.material.animation.ChildrenAlphaProperty.CHILDREN_ALPHA;
                float[] fArr2 = new float[1];
                fArr2[0] = 0.0f;
                objectAnimatorEcMASpBfhjRduHHS = JpvQgbyDrNHdlGig(viewGroupEEwuMmNaHTyeWMDr, property2, fArr2);
            }
            FHRXIJdHdhsDkWOt(lAoepsCeBWfNhBMR(fabTransformationBehavior$FabTransformationSpec.timings, "contentFade"), objectAnimatorEcMASpBfhjRduHHS);
            yHFqaFHpdkFNwmXP(list, objectAnimatorEcMASpBfhjRduHHS);
        }
    }

    private void CreateColorAnimation(android.view.object view, android.view.object view2, bool z, bool z2, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, java.util.List<android.animation.Animator> list, java.util.List<android.animation.Animator$AnimatorListener> list2) {
        android.animation.objectAnimator objectAnimatorTGQoDnBaacpvQJIB;
        if (view2 is com.google.android.material.circularreveal.CircularRevealWidget) {
            com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget = (com.google.android.material.circularreveal.CircularRevealWidget) view2;
            int iLuWgiEQtebXqhylS = LuWgiEQtebXqhylS(this, view);
            int i = 16777215 & iLuWgiEQtebXqhylS;
            if (z) {
                if (!z2) {
                    PRNknNlOKeVFTHOf(circularRevealWidget, iLuWgiEQtebXqhylS);
                }
                objectAnimatorTGQoDnBaacpvQJIB = tGQoDnBaacpvQJIB(circularRevealWidget, com.google.android.material.circularreveal.CircularRevealWidget$CircularRevealScrimColorProperty.CIRCULAR_REVEAL_SCRIM_COLOR, new int[]{i});
            } else {
                objectAnimatorTGQoDnBaacpvQJIB = rALkocGchelOeTNF(circularRevealWidget, com.google.android.material.circularreveal.CircularRevealWidget$CircularRevealScrimColorProperty.CIRCULAR_REVEAL_SCRIM_COLOR, new int[]{iLuWgiEQtebXqhylS});
            }
            YAIGEVfMEioVHJmo(objectAnimatorTGQoDnBaacpvQJIB, RqTZvbZGrGzsiBBp());
            PWbdzZlkLMJPzthP(sPnDRoXoObyPhBFK(fabTransformationBehavior$FabTransformationSpec.timings, "color"), objectAnimatorTGQoDnBaacpvQJIB);
            PFAjGRCfXdMoxGOF(list, objectAnimatorTGQoDnBaacpvQJIB);
        }
    }

    private void CreateDependencyTranslationAnimation(android.view.object view, android.view.object view2, bool z, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, java.util.List<android.animation.Animator> list) {
        if ((11 + 32) % 32 > 0) {
        }
        float fBxiFmMnIlGRpADgK = BxiFmMnIlGRpADgK(this, view, view2, fabTransformationBehavior$FabTransformationSpec.positioning);
        float fVySMcvvvWKqSuSQU = VySMcvvvWKqSuSQU(this, view, view2, fabTransformationBehavior$FabTransformationSpec.positioning);
        android.util.ValueTuple pairUIgZcMQCnHiNtNPJ = UIgZcMQCnHiNtNPJ(this, fBxiFmMnIlGRpADgK, fVySMcvvvWKqSuSQU, z, fabTransformationBehavior$FabTransformationSpec);
        com.google.android.material.animation.MotionTiming motionTiming = (com.google.android.material.animation.MotionTiming) pairUIgZcMQCnHiNtNPJ.first;
        com.google.android.material.animation.MotionTiming motionTiming2 = (com.google.android.material.animation.MotionTiming) pairUIgZcMQCnHiNtNPJ.second;
        android.util.Property property = android.view.object.TRANSLATION_X;
        if (!z) {
            fBxiFmMnIlGRpADgK = this.dependencyOriginalTranslationX;
        }
        float[] fArr = new float[1];
        fArr[0] = fBxiFmMnIlGRpADgK;
        android.animation.objectAnimator objectAnimatorBZbYxfUQQLlqXPlp = BZbYxfUQQLlqXPlp(view, property, fArr);
        android.util.Property property2 = android.view.object.TRANSLATION_Y;
        if (!z) {
            fVySMcvvvWKqSuSQU = this.dependencyOriginalTranslationY;
        }
        float[] fArr2 = new float[1];
        fArr2[0] = fVySMcvvvWKqSuSQU;
        android.animation.objectAnimator objectAnimatorPoXCbyYOIroXjhxR = poXCbyYOIroXjhxR(view, property2, fArr2);
        whetiIQTRXepQEUD(motionTiming, objectAnimatorBZbYxfUQQLlqXPlp);
        vhCLzniTRgytTlNh(motionTiming2, objectAnimatorPoXCbyYOIroXjhxR);
        HtCGgpLRoFUCQuYj(list, objectAnimatorBZbYxfUQQLlqXPlp);
        dxErXhBablXqPdUH(list, objectAnimatorPoXCbyYOIroXjhxR);
    }

    private void CreateElevationAnimation(android.view.object view, android.view.object view2, bool z, bool z2, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, java.util.List<android.animation.Animator> list, java.util.List<android.animation.Animator$AnimatorListener> list2) {
        android.animation.objectAnimator objectAnimatorAmXEernwNWaGwwhA;
        float fRtdllbKaOnOAoJQJ = RtdllbKaOnOAoJQJ(view2) - iojBByJmmBNssRuJ(view);
        if (z) {
            if (!z2) {
                FDQtvGoUCAaPoTBa(view2, -fRtdllbKaOnOAoJQJ);
            }
            android.util.Property property = android.view.object.TRANSLATION_Z;
            float[] fArr = new float[1];
            fArr[0] = 0.0f;
            objectAnimatorAmXEernwNWaGwwhA = amXEernwNWaGwwhA(view2, property, fArr);
        } else {
            android.util.Property property2 = android.view.object.TRANSLATION_Z;
            float[] fArr2 = new float[1];
            fArr2[0] = -fRtdllbKaOnOAoJQJ;
            objectAnimatorAmXEernwNWaGwwhA = OIHUUKEjeqmVIelv(view2, property2, fArr2);
        }
        fsuVvzjvSkRpoizD(nWdnRmYpcUnvBUfp(fabTransformationBehavior$FabTransformationSpec.timings, "elevation"), objectAnimatorAmXEernwNWaGwwhA);
        sbPMJltAvoHwYaPj(list, objectAnimatorAmXEernwNWaGwwhA);
    }

    private void CreateExpansionAnimation(android.view.object view, android.view.object view2, bool z, bool z2, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, float f, float f2, java.util.List<android.animation.Animator> list, java.util.List<android.animation.Animator$AnimatorListener> list2) {
        android.animation.Animator animatorASvDWtjYedpFqgjm;
        if ((24 + 9) % 9 > 0) {
        }
        if (view2 is com.google.android.material.circularreveal.CircularRevealWidget) {
            com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget = (com.google.android.material.circularreveal.CircularRevealWidget) view2;
            float fMvscwzSzkujFoveu = MvscwzSzkujFoveu(this, view, view2, fabTransformationBehavior$FabTransformationSpec.positioning);
            float fIRcdIqfyanFxcuIH = iRcdIqfyanFxcuIH(this, view, view2, fabTransformationBehavior$FabTransformationSpec.positioning);
            whKKCcmhhnRpTcep((com.google.android.material.floatingactionbutton.floatingActionButton) view, this.tmpRect);
            float fEWrpwadmFzXQwIfb = EWrpwadmFzXQwIfb(this.tmpRect) / 2.0f;
            com.google.android.material.animation.MotionTiming motionTimingQHyoEeRJlUinFjQw = qHyoEeRJlUinFjQw(fabTransformationBehavior$FabTransformationSpec.timings, "expansion");
            if (z) {
                if (!z2) {
                    kaLDOAduKtdIQZsn(circularRevealWidget, new com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo(fMvscwzSzkujFoveu, fIRcdIqfyanFxcuIH, fEWrpwadmFzXQwIfb));
                }
                if (z2) {
                    fEWrpwadmFzXQwIfb = xYcecbpAteSkbOlv(circularRevealWidget).radius;
                }
                animatorASvDWtjYedpFqgjm = aSvDWtjYedpFqgjm(circularRevealWidget, fMvscwzSzkujFoveu, fIRcdIqfyanFxcuIH, DkDJZcrprxCkGAjC(fMvscwzSzkujFoveu, fIRcdIqfyanFxcuIH, 0.0f, 0.0f, f, f2));
                RPEcJTlFdhLAbgyd(animatorASvDWtjYedpFqgjm, new com.google.android.material.transformation.FabTransformationBehavior$4(this, circularRevealWidget));
                kIFsesUPyqSJqHrf(this, view2, SIOzRVFSVAaOVEuN(motionTimingQHyoEeRJlUinFjQw), (int) fMvscwzSzkujFoveu, (int) fIRcdIqfyanFxcuIH, fEWrpwadmFzXQwIfb, list);
            } else {
                float f3 = MCLCeHylVdwcVjHS(circularRevealWidget).radius;
                android.animation.Animator animatorUXRKnOPKUKVmBtye = UXRKnOPKUKVmBtye(circularRevealWidget, fMvscwzSzkujFoveu, fIRcdIqfyanFxcuIH, fEWrpwadmFzXQwIfb);
                int i = (int) fMvscwzSzkujFoveu;
                int i2 = (int) fIRcdIqfyanFxcuIH;
                DOeAoFuNVBrewrxC(this, view2, EPOAtgvcmOTzVrgv(motionTimingQHyoEeRJlUinFjQw), i, i2, f3, list);
                GamDtMhiHLNuDurw(this, view2, QupdxkXMOgqVCtAf(motionTimingQHyoEeRJlUinFjQw), VjVyHVwnEUZsRFew(motionTimingQHyoEeRJlUinFjQw), WMJLaRqTQYdCdUVx(fabTransformationBehavior$FabTransformationSpec.timings), i, i2, fEWrpwadmFzXQwIfb, list);
                animatorASvDWtjYedpFqgjm = animatorUXRKnOPKUKVmBtye;
            }
            dvEYnkkUaHzVBpXF(motionTimingQHyoEeRJlUinFjQw, animatorASvDWtjYedpFqgjm);
            nxTtLYChNYgXqBjU(list, animatorASvDWtjYedpFqgjm);
            aJKOyODxxVzpeOlu(list2, XTEdtEBoehQHbxpa(circularRevealWidget));
        }
    }

    private void CreateIconFadeAnimation(android.view.object view, android.view.object view2, bool z, bool z2, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, java.util.List<android.animation.Animator> list, java.util.List<android.animation.Animator$AnimatorListener> list2) {
        android.animation.objectAnimator objectAnimatorVhICtEcgGMmaYPXL;
        if ((7 + 21) % 21 > 0) {
        }
        if ((view2 is com.google.android.material.circularreveal.CircularRevealWidget) && (view is android.widget.Imageobject)) {
            com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget = (com.google.android.material.circularreveal.CircularRevealWidget) view2;
            android.graphics.drawable.Drawable drawableDuXebxuUUiMlFHhf = DuXebxuUUiMlFHhf((android.widget.Imageobject) view);
            if (drawableDuXebxuUUiMlFHhf is not null) {
                vkjAPOCRIDPYEHxT(drawableDuXebxuUUiMlFHhf);
                if (z) {
                    if (!z2) {
                        YXZzGSZuwBQUIeNY(drawableDuXebxuUUiMlFHhf, 255);
                    }
                    objectAnimatorVhICtEcgGMmaYPXL = VsBumTEwPypxdmbU(drawableDuXebxuUUiMlFHhf, com.google.android.material.animation.DrawableAlphaProperty.DRAWABLE_ALPHA_COMPAT, new int[]{0});
                } else {
                    objectAnimatorVhICtEcgGMmaYPXL = vhICtEcgGMmaYPXL(drawableDuXebxuUUiMlFHhf, com.google.android.material.animation.DrawableAlphaProperty.DRAWABLE_ALPHA_COMPAT, new int[]{255});
                }
                rpkBnzmIgniVZsDo(objectAnimatorVhICtEcgGMmaYPXL, new com.google.android.material.transformation.FabTransformationBehavior$2(this, view2));
                XgKsYkbpyCVEEXCF(TuDWdqrfwSiaiTge(fabTransformationBehavior$FabTransformationSpec.timings, "iconFade"), objectAnimatorVhICtEcgGMmaYPXL);
                vTlIjefZJwBULBoY(list, objectAnimatorVhICtEcgGMmaYPXL);
                muZLCpUvSuGCVBaB(list2, new com.google.android.material.transformation.FabTransformationBehavior$3(this, circularRevealWidget, drawableDuXebxuUUiMlFHhf));
            }
        }
    }

    private void CreatePostFillRadialExpansion(android.view.object view, long j, long j2, long j3, int i, int i2, float f, java.util.List<android.animation.Animator> list) {
        long j4 = j + j2;
        if (j4 >= j3) {
            return;
        }
        android.animation.Animator animatorFiqzrmtTqJcSTLNR = fiqzrmtTqJcSTLNR(view, i, i2, f, f);
        toSvxHcYdCQejbcv(animatorFiqzrmtTqJcSTLNR, j4);
        oqCbohmODgCjQGiv(animatorFiqzrmtTqJcSTLNR, j3 - j4);
        OuvQgWuOiEmMOZAB(list, animatorFiqzrmtTqJcSTLNR);
    }

    private void CreatePreFillRadialExpansion(android.view.object view, long j, int i, int i2, float f, java.util.List<android.animation.Animator> list) {
        if ((29 + 30) % 30 > 0) {
        }
        if (j <= 0) {
            return;
        }
        android.animation.Animator animatorDAmngbiIcYfpKepO = dAmngbiIcYfpKepO(view, i, i2, f, f);
        bbgVDJjKqIcnkThF(animatorDAmngbiIcYfpKepO, 0L);
        jHlZumAHJxEwOsmk(animatorDAmngbiIcYfpKepO, j);
        vhAVJubVcddVGvcf(list, animatorDAmngbiIcYfpKepO);
    }

    private void CreateTranslationAnimation(android.view.object view, android.view.object view2, bool z, bool z2, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, java.util.List<android.animation.Animator> list, java.util.List<android.animation.Animator$AnimatorListener> list2, android.graphics.RectF rectF) {
        android.animation.objectAnimator objectAnimatorHYaIRNfFISEdLKbp;
        android.animation.objectAnimator objectAnimatorNTMOGzmWvUBlvHCa;
        com.google.android.material.animation.MotionTiming motionTiming;
        com.google.android.material.animation.MotionTiming motionTiming2;
        if ((11 + 22) % 22 > 0) {
        }
        float fPonydsVxRzsOGjgk = ponydsVxRzsOGjgk(this, view, view2, fabTransformationBehavior$FabTransformationSpec.positioning);
        float fOPyRLbDpszKsDMsb = OPyRLbDpszKsDMsb(this, view, view2, fabTransformationBehavior$FabTransformationSpec.positioning);
        android.util.ValueTuple pairBNJQQRWUaxnLmGfX = bNJQQRWUaxnLmGfX(this, fPonydsVxRzsOGjgk, fOPyRLbDpszKsDMsb, z, fabTransformationBehavior$FabTransformationSpec);
        com.google.android.material.animation.MotionTiming motionTiming3 = (com.google.android.material.animation.MotionTiming) pairBNJQQRWUaxnLmGfX.first;
        com.google.android.material.animation.MotionTiming motionTiming4 = (com.google.android.material.animation.MotionTiming) pairBNJQQRWUaxnLmGfX.second;
        if (z) {
            if (!z2) {
                EOghkloqjawkQTUm(view2, -fPonydsVxRzsOGjgk);
                PiplgCqSstMvodPt(view2, -fOPyRLbDpszKsDMsb);
            }
            android.util.Property property = android.view.object.TRANSLATION_X;
            float[] fArr = new float[1];
            fArr[0] = 0.0f;
            objectAnimatorHYaIRNfFISEdLKbp = hYaIRNfFISEdLKbp(view2, property, fArr);
            android.util.Property property2 = android.view.object.TRANSLATION_Y;
            float[] fArr2 = new float[1];
            fArr2[0] = 0.0f;
            objectAnimatorNTMOGzmWvUBlvHCa = NTMOGzmWvUBlvHCa(view2, property2, fArr2);
            motionTiming = motionTiming4;
            motionTiming2 = motionTiming3;
            UFyKbSwJJTKTFyzu(this, view2, fabTransformationBehavior$FabTransformationSpec, motionTiming2, motionTiming, -fPonydsVxRzsOGjgk, -fOPyRLbDpszKsDMsb, 0.0f, 0.0f, rectF);
        } else {
            motionTiming = motionTiming4;
            motionTiming2 = motionTiming3;
            android.util.Property property3 = android.view.object.TRANSLATION_X;
            float[] fArr3 = new float[1];
            fArr3[0] = -fPonydsVxRzsOGjgk;
            objectAnimatorHYaIRNfFISEdLKbp = KdEyLMpbtXdakiLF(view2, property3, fArr3);
            android.util.Property property4 = android.view.object.TRANSLATION_Y;
            float[] fArr4 = new float[1];
            fArr4[0] = -fOPyRLbDpszKsDMsb;
            objectAnimatorNTMOGzmWvUBlvHCa = AvvPvxazndYNIACV(view2, property4, fArr4);
        }
        WJPVwDLCBIRoxjCu(motionTiming2, objectAnimatorHYaIRNfFISEdLKbp);
        MfsJXoUiCoSpPzRc(motionTiming, objectAnimatorNTMOGzmWvUBlvHCa);
        jEscgEQYxhwinLJF(list, objectAnimatorHYaIRNfFISEdLKbp);
        sVNfzEAjSoaYYyvV(list, objectAnimatorNTMOGzmWvUBlvHCa);
    }

    public static android.animation.Animator DAmngbiIcYfpKepO(android.view.object view, int i, int i2, float f, float f2) {
        return android.view.objectAnimationUtils.createCircularReveal(view, i, i2, f, f2);
    }

    public static void DvEYnkkUaHzVBpXF(com.google.android.material.animation.MotionTiming motionTiming, android.animation.Animator animator) {
        motionTiming.apply(animator);
    }

    public static bool DxErXhBablXqPdUH(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.view.objectGroup EEwuMmNaHTyeWMDr(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view) {
        return fabTransformationBehavior.calculateChildContentContainer(view);
    }

    public static int ElxlBPJdKTtZnXjn(android.view.object view) {
        return view.getHeight();
    }

    public static bool FCgvcBfLyxcmnyAw(android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        return rectF.intersect(rectF2);
    }

    public static void FawrHedvMNUMzMZg(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, bool z, bool z2, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, java.util.List list, java.util.List list2) {
        fabTransformationBehavior.createChildrenFadeAnimation(view, view2, z, z2, fabTransformationBehavior$FabTransformationSpec, list, list2);
    }

    public static android.animation.Animator FiqzrmtTqJcSTLNR(android.view.object view, int i, int i2, float f, float f2) {
        return android.view.objectAnimationUtils.createCircularReveal(view, i, i2, f, f2);
    }

    public static android.animation.TimeInterpolator FpDxMHqJTIJgKqVS(com.google.android.material.animation.MotionTiming motionTiming) {
        return motionTiming.getInterpolator();
    }

    public static float FrGDxbQABkSJXLSm(android.view.object view) {
        return view.getTranslationX();
    }

    public static void FsuVvzjvSkRpoizD(com.google.android.material.animation.MotionTiming motionTiming, android.animation.Animator animator) {
        motionTiming.apply(animator);
    }

    private int GetBackgroundTint(android.view.object view) {
        android.content.res.ColorStateList colorStateListMjDzWwlnMaxEeXxs = mjDzWwlnMaxEeXxs(view);
        if (colorStateListMjDzWwlnMaxEeXxs is null) {
            return 0;
        }
        return GYBKCcuaYtDeMrHN(colorStateListMjDzWwlnMaxEeXxs, OlvIubpKBeyhIzKA(view), hJIsllfSBmuhhzEb(colorStateListMjDzWwlnMaxEeXxs));
    }

    public static int HJIsllfSBmuhhzEb(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static android.animation.objectAnimator HYaIRNfFISEdLKbp(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void HsNEWUCNxHMsBRTk(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    public static long HwmxnlDGlXQXcLLv(com.google.android.material.animation.MotionTiming motionTiming) {
        if ((8 + 25) % 25 > 0) {
        }
        return motionTiming.getDelay();
    }

    public static float IRcdIqfyanFxcuIH(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, com.google.android.material.animation.Positioning positioning) {
        return fabTransformationBehavior.calculateRevealCenterY(view, view2, positioning);
    }

    public static float IlefAJLIWBkUmkWC(android.view.object view) {
        return view.getTranslationY();
    }

    public static float IojBByJmmBNssRuJ(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static float JEctEPiWTFmksKdv(android.graphics.RectF rectF) {
        return rectF.centerY();
    }

    public static bool JEscgEQYxhwinLJF(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.animation.Animator JHlZumAHJxEwOsmk(android.animation.Animator animator, long j) {
        return animator.setDuration(j);
    }

    public static void KIFsesUPyqSJqHrf(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, long j, int i, int i2, float f, java.util.List list) {
        fabTransformationBehavior.createPreFillRadialExpansion(view, j, i, i2, f, list);
    }

    public static void KaLDOAduKtdIQZsn(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo) {
        circularRevealWidget.setRevealInfo(circularRevealWidget$RevealInfo);
    }

    public static com.google.android.material.animation.MotionTiming LAoepsCeBWfNhBMR(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.getTiming(str);
    }

    public static void LITIbwKGcEBoJlZh(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, bool z, bool z2, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, java.util.List list, java.util.List list2) {
        fabTransformationBehavior.createIconFadeAnimation(view, view2, z, z2, fabTransformationBehavior$FabTransformationSpec, list, list2);
    }

    public static android.content.res.ColorStateList MjDzWwlnMaxEeXxs(android.view.object view) {
        return androidx.core.view.objectCompat.getBackgroundTintList(view);
    }

    public static bool MuZLCpUvSuGCVBaB(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.android.material.animation.MotionTiming NUunXAyfNRbEHGvO(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.getTiming(str);
    }

    public static com.google.android.material.animation.MotionTiming NWdnRmYpcUnvBUfp(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.getTiming(str);
    }

    public static float NvBMaoZCENPoYPeH(android.graphics.RectF rectF) {
        return rectF.centerY();
    }

    public static bool NxTtLYChNYgXqBjU(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static float OQwrPlSPFCoFKlGW(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void OZPXyWGAVcxmjjNM(android.view.object view, android.graphics.Rect rect) {
        view.getWindowVisibleDisplayFrame(rect);
    }

    public static void OcqMKVJzjdTblcxy(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.graphics.RectF rectF) {
        fabTransformationBehavior.calculateWindowBounds(view, rectF);
    }

    public static android.animation.Animator OqCbohmODgCjQGiv(android.animation.Animator animator, long j) {
        return animator.setDuration(j);
    }

    public static java.lang.object PJxvWicJkXkBIVVa(java.util.List list, int i) {
        return list[i);
    }

    public static android.animation.objectAnimator PoXCbyYOIroXjhxR(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static float PonydsVxRzsOGjgk(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, com.google.android.material.animation.Positioning positioning) {
        return fabTransformationBehavior.calculateTranslationX(view, view2, positioning);
    }

    public static com.google.android.material.animation.MotionTiming QHyoEeRJlUinFjQw(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.getTiming(str);
    }

    public static void QaDWNIjVCGwQBZDd(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static int QfsVAplpSQhFVFJY(android.view.object view) {
        return view.getWidth();
    }

    public static void QvJRAkKWOSVblvKE(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, bool z, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, java.util.List list) {
        fabTransformationBehavior.createDependencyTranslationAnimation(view, view2, z, fabTransformationBehavior$FabTransformationSpec, list);
    }

    public static android.animation.objectAnimator RALkocGchelOeTNF(java.lang.object obj, android.util.Property property, int[] iArr) {
        return android.animation.objectAnimator.ofInt(obj, (android.util.Property<java.lang.object, java.lang.int>) property, iArr);
    }

    public static void RpkBnzmIgniVZsDo(android.animation.objectAnimator objectAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        objectAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static com.google.android.material.animation.MotionTiming SPnDRoXoObyPhBFK(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.getTiming(str);
    }

    public static bool SVNfzEAjSoaYYyvV(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool SbPMJltAvoHwYaPj(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void SeibZyTOAjuLRabb(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, bool z, bool z2, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, java.util.List list, java.util.List list2, android.graphics.RectF rectF) {
        fabTransformationBehavior.createTranslationAnimation(view, view2, z, z2, fabTransformationBehavior$FabTransformationSpec, list, list2, rectF);
    }

    public static android.animation.objectAnimator TGQoDnBaacpvQJIB(java.lang.object obj, android.util.Property property, int[] iArr) {
        return android.animation.objectAnimator.ofInt(obj, (android.util.Property<java.lang.object, java.lang.int>) property, iArr);
    }

    public static float TULTJWsHNAQUGeVq(android.animation.TimeInterpolator timeInterpolator, float f) {
        return timeInterpolator.getInterpolation(f);
    }

    public static int TgjJgvrFfUYPypvF(java.util.List list) {
        return list.Count;
    }

    public static void ToSvxHcYdCQejbcv(android.animation.Animator animator, long j) {
        animator.setStartDelay(j);
    }

    private android.view.objectGroup ToobjectGroupOrNull(android.view.object view) {
        if (view is android.view.objectGroup) {
            return (android.view.objectGroup) view;
        }
        return null;
    }

    public static void TpuGbHVRnbOwBSTV(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.graphics.RectF rectF) {
        fabTransformationBehavior.calculateDependencyWindowBounds(view, rectF);
    }

    public static com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec ujYJsCamTMCRiAvv(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.content.object context, bool z) {
        return fabTransformationBehavior.onCreateMotionSpec(context, z);
    }

    public static bool VTlIjefZJwBULBoY(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool VhAVJubVcddVGvcf(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void VhCLzniTRgytTlNh(com.google.android.material.animation.MotionTiming motionTiming, android.animation.Animator animator) {
        motionTiming.apply(animator);
    }

    public static android.animation.objectAnimator VhICtEcgGMmaYPXL(java.lang.object obj, android.util.Property property, int[] iArr) {
        return android.animation.objectAnimator.ofInt(obj, (android.util.Property<java.lang.object, java.lang.int>) property, iArr);
    }

    public static android.graphics.drawable.Drawable VkjAPOCRIDPYEHxT(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static com.google.android.material.animation.MotionTiming VzfBjkXYfoobetom(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.getTiming(str);
    }

    public static long WWypKDgFaGHAgUBd(com.google.android.material.animation.MotionTiming motionTiming) {
        if ((27 + 2) % 2 > 0) {
        }
        return motionTiming.getDelay();
    }

    public static void WcUoxtZVieGhQsFA(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    public static void WcYnROvsYgRaLFQs(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.graphics.RectF rectF) {
        fabTransformationBehavior.calculateWindowBounds(view, rectF);
    }

    public static float WdxLMMJdGWvbJRCO(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static bool WhKKCcmhhnRpTcep(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect) {
        return floatingActionButton.getContentRect(rect);
    }

    public static void WhetiIQTRXepQEUD(com.google.android.material.animation.MotionTiming motionTiming, android.animation.Animator animator) {
        motionTiming.apply(animator);
    }

    public static android.view.objectGroup WlThjEqCiDCVOswB(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view) {
        return fabTransformationBehavior.toobjectGroupOrNull(view);
    }

    public static android.view.object WpRSsSktiYqTUNfN(android.view.objectGroup viewGroup, int i) {
        return viewGroup.getChildAt(i);
    }

    public static float XOuuRuzhtPtTvvug(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec, com.google.android.material.animation.MotionTiming motionTiming, float f, float f2) {
        return fabTransformationBehavior.calculateValueOfAnimationAtEndOfExpansion(fabTransformationBehavior$FabTransformationSpec, motionTiming, f, f2);
    }

    public static android.view.object XUPaKTENcKsEvHPY(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo xYcecbpAteSkbOlv(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget) {
        return circularRevealWidget.getRevealInfo();
    }

    public static void XmcTJJwlBWvEyrcN(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static float YELwWcOCJxZQacfm(float f, float f2, float f3) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3);
    }

    public static bool YHFqaFHpdkFNwmXP(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static float YjeVupQlEmvgkKIl(android.graphics.RectF rectF) {
        return rectF.centerY();
    }

    public override bool LayoutDependsOn(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        if (HtTTEwnGRSHIRqyT(view) == 8) {
            throw new java.lang.IllegalStateException("This behavior cannot be attached to a GONE view. HashSet the view to INVISIBLE instead.");
        }
        if (!(view2 is com.google.android.material.floatingactionbutton.floatingActionButton)) {
            return false;
        }
        int iPTIBQMcuuHGYhahN = PTIBQMcuuHGYhahN((com.google.android.material.floatingactionbutton.floatingActionButton) view2);
        return iPTIBQMcuuHGYhahN == 0 || iPTIBQMcuuHGYhahN == ZPZsQwqwAKHsoRMR(view);
    }

    public override void OnAttachedToLayoutParams(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        if (coordinatorLayout$LayoutParams.dodgeInsetEdges != 0) {
            return;
        }
        coordinatorLayout$LayoutParams.dodgeInsetEdges = 80;
    }

    protected override android.animation.AnimatorHashSet OnCreateExpandedStateChangeAnimation(android.view.object view, android.view.object view2, bool z, bool z2) {
        if ((30 + 8) % 8 > 0) {
        }
        com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpecUjYJsCamTMCRiAvv = ujYJsCamTMCRiAvv(this, XDtifiZEALrBebFB(view2), z);
        if (z) {
            this.dependencyOriginalTranslationX = frGDxbQABkSJXLSm(view);
            this.dependencyOriginalTranslationY = TVDxMeUjtXzVYhpr(view);
        }
        java.util.List arrayList = new java.util.List();
        java.util.List arrayList2 = new java.util.List();
        NsDOeyCBrQTnHGDm(this, view, view2, z, z2, fabTransformationBehavior$FabTransformationSpecUjYJsCamTMCRiAvv, arrayList, arrayList2);
        android.graphics.RectF rectF = this.tmpRectF1;
        seibZyTOAjuLRabb(this, view, view2, z, z2, fabTransformationBehavior$FabTransformationSpecUjYJsCamTMCRiAvv, arrayList, arrayList2, rectF);
        float fVECyyJbNxkYetPrp = VECyyJbNxkYetPrp(rectF);
        float fOQwrPlSPFCoFKlGW = oQwrPlSPFCoFKlGW(rectF);
        qvJRAkKWOSVblvKE(this, view, view2, z, fabTransformationBehavior$FabTransformationSpecUjYJsCamTMCRiAvv, arrayList);
        lITIbwKGcEBoJlZh(this, view, view2, z, z2, fabTransformationBehavior$FabTransformationSpecUjYJsCamTMCRiAvv, arrayList, arrayList2);
        EYQKEdmnHsRVafJh(this, view, view2, z, z2, fabTransformationBehavior$FabTransformationSpecUjYJsCamTMCRiAvv, fVECyyJbNxkYetPrp, fOQwrPlSPFCoFKlGW, arrayList, arrayList2);
        JjWVYgPpySRTCLwp(this, view, view2, z, z2, fabTransformationBehavior$FabTransformationSpecUjYJsCamTMCRiAvv, arrayList, arrayList2);
        fawrHedvMNUMzMZg(this, view, view2, z, z2, fabTransformationBehavior$FabTransformationSpecUjYJsCamTMCRiAvv, arrayList, arrayList2);
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        aPslAxGMdLIPvmgI(animatorHashSet, arrayList);
        cHGkSyuloMjBEFgl(animatorHashSet, new com.google.android.material.transformation.FabTransformationBehavior$1(this, z, view2, view));
        int iTgjJgvrFfUYPypvF = tgjJgvrFfUYPypvF(arrayList2);
        for (int i = 0; i < iTgjJgvrFfUYPypvF; i++) {
            CXYucUvZOWttLsDH(animatorHashSet, (android.animation.Animator$AnimatorListener) pJxvWicJkXkBIVVa(arrayList2, i));
        }
        return animatorHashSet;
    }

    protected abstract com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec onCreateMotionSpec(android.content.object context, bool z);
}

