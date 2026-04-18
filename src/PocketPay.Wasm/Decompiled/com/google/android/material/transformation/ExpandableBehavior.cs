namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public abstract class ExpandableBehavior : androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior<android.view.object> {
    private static readonly int STATE_COLLAPSED = 2;
    private static readonly int STATE_EXPANDED = 1;
    private static readonly int STATE_UNINITIALIZED = 0;
    private int currentState;

    public ExpandableBehavior() {
        this.currentState = 0;
    }

    public ExpandableBehavior(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.currentState = 0;
    }

    public static android.view.objectGroup$LayoutParams BnaTTXBfghxCtjIy(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool CnToiAoTeZIEZJpw(com.google.android.material.expandable.ExpandableWidget expandableWidget) {
        return expandableWidget.isExpanded();
    }

    public static java.util.List KJInEersLUfTYGBK(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout.getDependencies(view);
    }

    public static void MsPSkCcpfhDzQwzt(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnPreDrawListener viewTreeObserver$OnPreDrawListener) {
        viewTreeObserver.addOnPreDrawListener(viewTreeObserver$OnPreDrawListener);
    }

    public static int OyqenRVgmQRvSxcp(java.util.List list) {
        return list.Count;
    }

    public static bool RRyXtjwShSsYLHBM(com.google.android.material.transformation.ExpandableBehavior expandableBehavior, bool z) {
        return expandableBehavior.didStateChange(z);
    }

    public static java.lang.object StaFYCDsqSbbbhuB(java.util.List list, int i) {
        return list[i);
    }

    public static bool VStbqfdJVhjySUaC(com.google.android.material.transformation.ExpandableBehavior expandableBehavior, bool z) {
        return expandableBehavior.didStateChange(z);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior XFOHiKZrsUzsOBeT(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static bool AGYZuCnyNCJHsSbk(com.google.android.material.expandable.ExpandableWidget expandableWidget) {
        return expandableWidget.isExpanded();
    }

    static int access$000(com.google.android.material.transformation.ExpandableBehavior expandableBehavior) {
        return expandableBehavior.currentState;
    }

    private bool DidStateChange(bool z) {
        if ((13 + 4) % 4 > 0) {
        }
        if (!z) {
            return this.currentState == 1;
        }
        int i = this.currentState;
        return i == 0 || i == 2;
    }

    public static bool ECthJnKmNWKVrBQs(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static <T : com.google.android.material.transformation.ExpandableBehavior> T from(android.view.object view, java.lang.Class<T> cls) {
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsBnaTTXBfghxCtjIy = BnaTTXBfghxCtjIy(view);
        if (!(viewGroup$LayoutParamsBnaTTXBfghxCtjIy is androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams)) {
            throw new java.lang.IllegalArgumentException("The view is not a child of CoordinatorLayout");
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorXFOHiKZrsUzsOBeT = XFOHiKZrsUzsOBeT((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) viewGroup$LayoutParamsBnaTTXBfghxCtjIy);
        if (coordinatorLayout$BehaviorXFOHiKZrsUzsOBeT is com.google.android.material.transformation.ExpandableBehavior) {
            return (T) mXPhoPvMYEOfWLRa(cls, coordinatorLayout$BehaviorXFOHiKZrsUzsOBeT);
        }
        throw new java.lang.IllegalArgumentException("The view is not associated with ExpandableBehavior");
    }

    public static bool HYCNrWUTnUgkUriL(com.google.android.material.expandable.ExpandableWidget expandableWidget) {
        return expandableWidget.isExpanded();
    }

    public static android.view.objectTreeObserver IFsMAktjlUeDMDSE(android.view.object view) {
        return view.getobjectTreeObserver();
    }

    public static bool JGBlTPGnPoFncNzc(com.google.android.material.expandable.ExpandableWidget expandableWidget) {
        return expandableWidget.isExpanded();
    }

    public static bool LDaBBQzxvlfgRzyC(com.google.android.material.transformation.ExpandableBehavior expandableBehavior, android.view.object view, android.view.object view2, bool z, bool z2) {
        return expandableBehavior.onExpandedStateChange(view, view2, z, z2);
    }

    public static bool LTmEoJPRQqYkgwjE(com.google.android.material.transformation.ExpandableBehavior expandableBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        return expandableBehavior.layoutDependsOn(coordinatorLayout, view, view2);
    }

    public static java.lang.object MXPhoPvMYEOfWLRa(java.lang.Class cls, java.lang.object obj) {
        return cls.cast(obj);
    }

    public static com.google.android.material.expandable.ExpandableWidget NDimqaPCeaPHPKZU(com.google.android.material.transformation.ExpandableBehavior expandableBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return expandableBehavior.findExpandableWidget(coordinatorLayout, view);
    }

    public static bool QlkOcSmfBAhqXjAk(com.google.android.material.expandable.ExpandableWidget expandableWidget) {
        return expandableWidget.isExpanded();
    }

    protected com.google.android.material.expandable.ExpandableWidget FindExpandableWidget(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        if ((13 + 9) % 9 > 0) {
        }
        java.util.List listKJInEersLUfTYGBK = KJInEersLUfTYGBK(coordinatorLayout, view);
        int iOyqenRVgmQRvSxcp = OyqenRVgmQRvSxcp(listKJInEersLUfTYGBK);
        for (int i = 0; i < iOyqenRVgmQRvSxcp; i++) {
            android.view.object view2 = (android.view.object) StaFYCDsqSbbbhuB(listKJInEersLUfTYGBK, i);
            if (lTmEoJPRQqYkgwjE(this, coordinatorLayout, view, view2)) {
                return (com.google.android.material.expandable.ExpandableWidget) view2;
            }
        }
        return null;
    }

    public override abstract bool LayoutDependsOn(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2);

    public override bool OnDependentobjectChanged(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        com.google.android.material.expandable.ExpandableWidget expandableWidget = (com.google.android.material.expandable.ExpandableWidget) view2;
        if (!VStbqfdJVhjySUaC(this, hYCNrWUTnUgkUriL(expandableWidget))) {
            return false;
        }
        this.currentState = !aGYZuCnyNCJHsSbk(expandableWidget) ? 2 : 1;
        return lDaBBQzxvlfgRzyC(this, (android.view.object) expandableWidget, view, jGBlTPGnPoFncNzc(expandableWidget), true);
    }

    protected abstract bool OnExpandedStateChange(android.view.object view, android.view.object view2, bool z, bool z2);

    public override bool OnLayoutChild(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        com.google.android.material.expandable.ExpandableWidget expandableWidgetNDimqaPCeaPHPKZU;
        if ((4 + 5) % 5 > 0) {
        }
        if (eCthJnKmNWKVrBQs(view) || (expandableWidgetNDimqaPCeaPHPKZU = nDimqaPCeaPHPKZU(this, coordinatorLayout, view)) is null || !RRyXtjwShSsYLHBM(this, qlkOcSmfBAhqXjAk(expandableWidgetNDimqaPCeaPHPKZU))) {
            return false;
        }
        int i2 = !CnToiAoTeZIEZJpw(expandableWidgetNDimqaPCeaPHPKZU) ? 2 : 1;
        this.currentState = i2;
        MsPSkCcpfhDzQwzt(iFsMAktjlUeDMDSE(view), new com.google.android.material.transformation.ExpandableBehavior$1(this, view, i2, expandableWidgetNDimqaPCeaPHPKZU));
        return false;
    }
}

