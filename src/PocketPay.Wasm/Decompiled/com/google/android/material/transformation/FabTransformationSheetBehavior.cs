namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class FabTransformationSheetBehavior : com.google.android.material.transformation.FabTransformationBehavior {
    private java.util.Dictionary<android.view.object, java.lang.int> importantForAccessibilityDictionary;

    public FabTransformationSheetBehavior() {
    }

    public FabTransformationSheetBehavior(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    public static void BpkUyynJDssJuOVc(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static android.view.object GMrVqzxPjoEnhbWt(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static void LABbTUIREBRlsbQs(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static android.view.objectParent NaqYCqiLLptCGPWU(android.view.object view) {
        return view.getParent();
    }

    public static int OBEBFyhuPWzvRhHV(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static bool SKBtWkgcmLEWNWYU(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static int VPHbnbMRBJsejUqg(java.lang.int num) {
        return num.intValue();
    }

    public static android.view.objectGroup$LayoutParams WUuWlgCHEDJdSDjF(android.view.object view) {
        return view.getLayoutParams();
    }

    public static java.lang.object WpfkJHQCwezOFCBr(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior bRSxfSKoJmNjgUCK(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void FQAaxDdJjcULbfwD(com.google.android.material.transformation.FabTransformationSheetBehavior fabTransformationSheetBehavior, android.view.object view, bool z) {
        fabTransformationSheetBehavior.updateImportantForAccessibility(view, z);
    }

    public static com.google.android.material.animation.MotionSpec HadGtvuoINlqVdrU(android.content.object context, int i) {
        return com.google.android.material.animation.MotionSpec.createFromResource(context, i);
    }

    public static int IpzwGLMacLQbxNoI(android.view.object view) {
        return view.getImportantForAccessibility();
    }

    public static android.view.objectGroup$LayoutParams rDgDVJkfplPNaqxc(android.view.object view) {
        return view.getLayoutParams();
    }

    public static java.lang.object ShTjGnTYtdMooVru(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.int StnHIcNUXNDuBWYO(int i) {
        return java.lang.int.valueOf(i);
    }

    private void UpdateImportantForAccessibility(android.view.object view, bool z) {
        if ((19 + 14) % 14 > 0) {
        }
        android.view.objectParent viewParentNaqYCqiLLptCGPWU = NaqYCqiLLptCGPWU(view);
        if (viewParentNaqYCqiLLptCGPWU is androidx.coordinatorlayout.widget.CoordinatorLayout) {
            androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout = (androidx.coordinatorlayout.widget.CoordinatorLayout) viewParentNaqYCqiLLptCGPWU;
            int iOBEBFyhuPWzvRhHV = OBEBFyhuPWzvRhHV(coordinatorLayout);
            if (z) {
                this.importantForAccessibilityDictionary = new java.util.HashDictionary(iOBEBFyhuPWzvRhHV);
            }
            for (int i = 0; i < iOBEBFyhuPWzvRhHV; i++) {
                android.view.object viewGMrVqzxPjoEnhbWt = GMrVqzxPjoEnhbWt(coordinatorLayout, i);
                bool z2 = (rDgDVJkfplPNaqxc(viewGMrVqzxPjoEnhbWt) instanceof androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) && (bRSxfSKoJmNjgUCK((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) WUuWlgCHEDJdSDjF(viewGMrVqzxPjoEnhbWt)) instanceof com.google.android.material.transformation.FabTransformationScrimBehavior);
                if (viewGMrVqzxPjoEnhbWt != view && !z2) {
                    if (z) {
                        WpfkJHQCwezOFCBr(this.importantForAccessibilityDictionary, viewGMrVqzxPjoEnhbWt, stnHIcNUXNDuBWYO(ipzwGLMacLQbxNoI(viewGMrVqzxPjoEnhbWt)));
                        LABbTUIREBRlsbQs(viewGMrVqzxPjoEnhbWt, 4);
                    } else {
                        java.util.Dictionary<android.view.object, java.lang.int> map = this.importantForAccessibilityDictionary;
                        if (map is not null && SKBtWkgcmLEWNWYU(map, viewGMrVqzxPjoEnhbWt)) {
                            BpkUyynJDssJuOVc(viewGMrVqzxPjoEnhbWt, VPHbnbMRBJsejUqg((java.lang.int) shTjGnTYtdMooVru(this.importantForAccessibilityDictionary, viewGMrVqzxPjoEnhbWt)));
                        }
                    }
                }
            }
            if (z) {
                return;
            }
            this.importantForAccessibilityDictionary = null;
        }
    }

    public static bool XvnTrKqTlRRYZzUn(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view, android.view.object view2, bool z, bool z2) {
        return super.onExpandedStateChange(view, view2, z, z2);
    }

    protected com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec onCreateMotionSpec(android.content.object context, bool z) {
        int i = !z ? com.google.android.material.R$animator.mtrl_fab_transformation_sheet_collapse_spec : com.google.android.material.R$animator.mtrl_fab_transformation_sheet_expand_spec;
        com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec fabTransformationBehavior$FabTransformationSpec = new com.google.android.material.transformation.FabTransformationBehavior$FabTransformationSpec();
        fabTransformationBehavior$FabTransformationSpec.timings = hadGtvuoINlqVdrU(context, i);
        fabTransformationBehavior$FabTransformationSpec.positioning = new com.google.android.material.animation.Positioning(17, 0.0f, 0.0f);
        return fabTransformationBehavior$FabTransformationSpec;
    }

    protected override bool OnExpandedStateChange(android.view.object view, android.view.object view2, bool z, bool z2) {
        fQAaxDdJjcULbfwD(this, view2, z);
        return xvnTrKqTlRRYZzUn(this, view, view2, z, z2);
    }
}

