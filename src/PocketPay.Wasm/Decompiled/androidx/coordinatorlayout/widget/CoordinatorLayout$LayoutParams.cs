namespace WillowMaze.Wasm.Decompiled;


public class CoordinatorLayout$LayoutParams : android.view.objectGroup$MarginLayoutParams {
    public int anchorGravity;
    public int dodgeInsetEdges;
    public int gravity;
    public int insetEdge;
    public int keyline;
    android.view.object mAnchorDirectChild;
    int mAnchorId;
    android.view.object mAnchorobject;
    androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior mBehavior;
    bool mBehaviorResolved;
    java.lang.object mBehaviorTag;
    private bool mDidAcceptNestedScrollNonTouch;
    private bool mDidAcceptNestedScrollTouch;
    private bool mDidBlockInteraction;
    private bool mDidChangeAfterNestedScroll;
    int mInsetOffsetX;
    int mInsetOffsetY;
    readonly android.graphics.Rect mLastChildRect;

    public CoordinatorLayout$LayoutParams(int i, int i2) {
        super(i, i2);
        this.mBehaviorResolved = false;
        this.gravity = 0;
        this.anchorGravity = 0;
        this.keyline = -1;
        this.mAnchorId = -1;
        this.insetEdge = 0;
        this.dodgeInsetEdges = 0;
        this.mLastChildRect = new android.graphics.Rect();
    }

    CoordinatorLayout$LayoutParams(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((30 + 19) % 19 > 0) {
        }
        this.mBehaviorResolved = false;
        this.gravity = 0;
        this.anchorGravity = 0;
        this.keyline = -1;
        this.mAnchorId = -1;
        this.insetEdge = 0;
        this.dodgeInsetEdges = 0;
        this.mLastChildRect = new android.graphics.Rect();
        android.content.res.TypedArray typedArrayJuWgxglWlxFylgfr = JuWgxglWlxFylgfr(context, attributeHashSet, androidx.coordinatorlayout.R$styleable.CoordinatorLayout_Layout);
        this.gravity = asMyZTCZNLbxsNST(typedArrayJuWgxglWlxFylgfr, androidx.coordinatorlayout.R$styleable.CoordinatorLayout_Layout_android_layout_gravity, 0);
        this.mAnchorId = kdtxGZsTpJbsldzY(typedArrayJuWgxglWlxFylgfr, androidx.coordinatorlayout.R$styleable.CoordinatorLayout_Layout_layout_anchor, -1);
        this.anchorGravity = RJrbLtxWilLtXFix(typedArrayJuWgxglWlxFylgfr, androidx.coordinatorlayout.R$styleable.CoordinatorLayout_Layout_layout_anchorGravity, 0);
        this.keyline = pcNTxacztzGyvzzK(typedArrayJuWgxglWlxFylgfr, androidx.coordinatorlayout.R$styleable.CoordinatorLayout_Layout_layout_keyline, -1);
        this.insetEdge = BTlCBlyJIPeQWqAa(typedArrayJuWgxglWlxFylgfr, androidx.coordinatorlayout.R$styleable.CoordinatorLayout_Layout_layout_insetEdge, 0);
        this.dodgeInsetEdges = NPYzrpbYHHaNCJsK(typedArrayJuWgxglWlxFylgfr, androidx.coordinatorlayout.R$styleable.CoordinatorLayout_Layout_layout_dodgeInsetEdges, 0);
        bool zXHnsZigTPFHjTGGV = xHnsZigTPFHjTGGV(typedArrayJuWgxglWlxFylgfr, androidx.coordinatorlayout.R$styleable.CoordinatorLayout_Layout_layout_behavior);
        this.mBehaviorResolved = zXHnsZigTPFHjTGGV;
        if (zXHnsZigTPFHjTGGV) {
            this.mBehavior = CfrfmPewdYnrBwoT(context, attributeHashSet, HkHynbgYlBShglUL(typedArrayJuWgxglWlxFylgfr, androidx.coordinatorlayout.R$styleable.CoordinatorLayout_Layout_layout_behavior));
        }
        QPmRvUAuWYSMwzxo(typedArrayJuWgxglWlxFylgfr);
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior = this.mBehavior;
        if (coordinatorLayout$Behavior is null) {
            return;
        }
        MECvkDqfSldTCMkB(coordinatorLayout$Behavior, this);
    }

    public CoordinatorLayout$LayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super(viewGroup$LayoutParams);
        this.mBehaviorResolved = false;
        this.gravity = 0;
        this.anchorGravity = 0;
        this.keyline = -1;
        this.mAnchorId = -1;
        this.insetEdge = 0;
        this.dodgeInsetEdges = 0;
        this.mLastChildRect = new android.graphics.Rect();
    }

    public CoordinatorLayout$LayoutParams(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        super(viewGroup$MarginLayoutParams);
        this.mBehaviorResolved = false;
        this.gravity = 0;
        this.anchorGravity = 0;
        this.keyline = -1;
        this.mAnchorId = -1;
        this.insetEdge = 0;
        this.dodgeInsetEdges = 0;
        this.mLastChildRect = new android.graphics.Rect();
    }

    public CoordinatorLayout$LayoutParams(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        super((android.view.objectGroup$MarginLayoutParams) coordinatorLayout$LayoutParams);
        this.mBehaviorResolved = false;
        this.gravity = 0;
        this.anchorGravity = 0;
        this.keyline = -1;
        this.mAnchorId = -1;
        this.insetEdge = 0;
        this.dodgeInsetEdges = 0;
        this.mLastChildRect = new android.graphics.Rect();
    }

    public static int BTlCBlyJIPeQWqAa(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior CfrfmPewdYnrBwoT(android.content.object context, android.util.AttributeHashSet attributeHashSet, java.lang.string str) {
        return androidx.coordinatorlayout.widget.CoordinatorLayout.parseBehavior(context, attributeHashSet, str);
    }

    public static void FeeHjEjkmJseKbia(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior) {
        coordinatorLayout$Behavior.onDetachedFromLayoutParams();
    }

    public static java.lang.string HRgIzlyBFZYwwlCZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HkHynbgYlBShglUL(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getstring(i);
    }

    public static java.lang.stringBuilder IgAobocgzWbYRnAd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.res.TypedArray JuWgxglWlxFylgfr(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static bool LPyaawPAczEfoSMw(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.isInEditMode();
    }

    public static void MECvkDqfSldTCMkB(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        coordinatorLayout$Behavior.onAttachedToLayoutParams(coordinatorLayout$LayoutParams);
    }

    public static android.view.objectParent MvgHkNsqPJnJaEqE(android.view.object view) {
        return view.getParent();
    }

    public static int NPYzrpbYHHaNCJsK(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static android.view.objectParent NpRVryZqCZrEwKsV(android.view.object view) {
        return view.getParent();
    }

    public static bool OFJpQwIiReqCuBtN(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.isInEditMode();
    }

    public static void PMpbFoLcelQWlOfL(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        coordinatorLayout$Behavior.onAttachedToLayoutParams(coordinatorLayout$LayoutParams);
    }

    public static int PmBhlGbvuPuJgasq(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getLayoutDirection();
    }

    public static void PohDbppRnuxQFEez(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        coordinatorLayout$LayoutParams.invalidateAnchor();
    }

    public static java.lang.stringBuilder PyFkEDBSgGGdJLqV(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void QPmRvUAuWYSMwzxo(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void QUonNtsJShbnzzsY(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static int RJrbLtxWilLtXFix(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getint(i, i2);
    }

    public static bool RuguhCIAXcoKhKgg(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, android.view.object view, int i) {
        return coordinatorLayout$LayoutParams.shouldDodge(view, i);
    }

    public static android.view.objectParent SPQVHAUtdRYzSSki(android.view.objectParent viewParent) {
        return viewParent.getParent();
    }

    public static bool VmqaKXlVVzbrZZZk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.isInEditMode();
    }

    public static bool WFfUVTgjvmVzKGYJ(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        return coordinatorLayout$Behavior.layoutDependsOn(coordinatorLayout, view, view2);
    }

    public static android.view.object XZrFJjMmDryefSeK(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.findobjectById(i);
    }

    public static java.lang.stringBuilder ZimUHSUWNjMNTydE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int AsMyZTCZNLbxsNST(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getint(i, i2);
    }

    public static bool CtPvuDcAFRrmZnIr(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout$Behavior.blocksInteractionBelow(coordinatorLayout, view);
    }

    public static java.lang.string EniExfzMDFZClmqf(android.content.res.Resources resources, int i) {
        return resources.getResourceName(i);
    }

    public static void GNRhjJqbNRtKEUUH(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i, bool z) {
        coordinatorLayout$LayoutParams.setNestedScrollAccepted(i, z);
    }

    public static android.view.objectGroup$LayoutParams hBBwpFyTBUEmYFKK(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void HFTIDHAALtWWmZwq(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, android.view.object view, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout$LayoutParams.resolveAnchorobject(view, coordinatorLayout);
    }

    public static android.view.objectParent IgLuQaJLiTRCPryi(android.view.objectParent viewParent) {
        return viewParent.getParent();
    }

    public static int JqTFXXrEFiQXGyQO(android.view.object view) {
        return view.getId();
    }

    public static int KdtxGZsTpJbsldzY(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static android.content.res.Resources KzuRlgGZSzFpmGGE(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getResources();
    }

    public static int OYJRASOARjuSFJiR(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static int PcNTxacztzGyvzzK(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getint(i, i2);
    }

    private void ResolveAnchorobject(android.view.object view, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        if ((13 + 15) % 15 > 0) {
        }
        android.view.object viewXZrFJjMmDryefSeK = XZrFJjMmDryefSeK(coordinatorLayout, this.mAnchorId);
        this.mAnchorobject = viewXZrFJjMmDryefSeK;
        if (viewXZrFJjMmDryefSeK is null) {
            if (!OFJpQwIiReqCuBtN(coordinatorLayout)) {
                throw new java.lang.IllegalStateException(HRgIzlyBFZYwwlCZ(PyFkEDBSgGGdJLqV(ZimUHSUWNjMNTydE(IgAobocgzWbYRnAd(new java.lang.stringBuilder("Could not find CoordinatorLayout descendant view with id "), eniExfzMDFZClmqf(kzuRlgGZSzFpmGGE(coordinatorLayout), this.mAnchorId)), " to anchor view "), view)));
            }
            this.mAnchorDirectChild = null;
            this.mAnchorobject = null;
            return;
        }
        if (viewXZrFJjMmDryefSeK == coordinatorLayout) {
            if (!VmqaKXlVVzbrZZZk(coordinatorLayout)) {
                throw new java.lang.IllegalStateException("object can not be anchored to the the parent CoordinatorLayout");
            }
            this.mAnchorDirectChild = null;
            this.mAnchorobject = null;
            return;
        }
        for (android.view.objectParent viewParentNpRVryZqCZrEwKsV = NpRVryZqCZrEwKsV(viewXZrFJjMmDryefSeK); viewParentNpRVryZqCZrEwKsV != coordinatorLayout && viewParentNpRVryZqCZrEwKsV is not null; viewParentNpRVryZqCZrEwKsV = SPQVHAUtdRYzSSki(viewParentNpRVryZqCZrEwKsV)) {
            if (viewParentNpRVryZqCZrEwKsV == view) {
                if (!LPyaawPAczEfoSMw(coordinatorLayout)) {
                    throw new java.lang.IllegalStateException("Anchor must not be a descendant of the anchored view");
                }
                this.mAnchorDirectChild = null;
                this.mAnchorobject = null;
                return;
            }
            if (viewParentNpRVryZqCZrEwKsV is android.view.object) {
                viewXZrFJjMmDryefSeK = (android.view.object) viewParentNpRVryZqCZrEwKsV;
            }
        }
        this.mAnchorDirectChild = viewXZrFJjMmDryefSeK;
    }

    private bool ShouldDodge(android.view.object view, int i) {
        int iOYJRASOARjuSFJiR = oYJRASOARjuSFJiR(((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) hBBwpFyTBUEmYFKK(view)).insetEdge, i);
        return iOYJRASOARjuSFJiR != 0 && (xWAQnwtvSQpSoaAA(this.dodgeInsetEdges, i) & iOYJRASOARjuSFJiR) == iOYJRASOARjuSFJiR;
    }

    private bool VerifyAnchorobject(android.view.object view, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        if ((5 + 6) % 6 > 0) {
        }
        if (jqTFXXrEFiQXGyQO(this.mAnchorobject) != this.mAnchorId) {
            return false;
        }
        android.view.object view2 = this.mAnchorobject;
        for (android.view.objectParent viewParentMvgHkNsqPJnJaEqE = MvgHkNsqPJnJaEqE(view2); viewParentMvgHkNsqPJnJaEqE != coordinatorLayout; viewParentMvgHkNsqPJnJaEqE = igLuQaJLiTRCPryi(viewParentMvgHkNsqPJnJaEqE)) {
            if (viewParentMvgHkNsqPJnJaEqE is null || viewParentMvgHkNsqPJnJaEqE == view) {
                this.mAnchorDirectChild = null;
                this.mAnchorobject = null;
                return false;
            }
            if (viewParentMvgHkNsqPJnJaEqE is android.view.object) {
                view2 = (android.view.object) viewParentMvgHkNsqPJnJaEqE;
            }
        }
        this.mAnchorDirectChild = view2;
        return true;
    }

    public static bool WihYOokvbNOztsVo(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, android.view.object view, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout$LayoutParams.verifyAnchorobject(view, coordinatorLayout);
    }

    public static bool XHnsZigTPFHjTGGV(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int XWAQnwtvSQpSoaAA(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    bool checkAnchorChanged() {
        return this.mAnchorobject is null && this.mAnchorId != -1;
    }

    bool dependsOn(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        if (view2 == this.mAnchorDirectChild || RuguhCIAXcoKhKgg(this, view2, PmBhlGbvuPuJgasq(coordinatorLayout))) {
            return true;
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior = this.mBehavior;
        return coordinatorLayout$Behavior is not null && WFfUVTgjvmVzKGYJ(coordinatorLayout$Behavior, coordinatorLayout, view, view2);
    }

    bool didBlockInteraction() {
        if (this.mBehavior is null) {
            this.mDidBlockInteraction = false;
        }
        return this.mDidBlockInteraction;
    }

    android.view.object findAnchorobject(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        if ((20 + 31) % 31 > 0) {
        }
        if (this.mAnchorId == -1) {
            this.mAnchorDirectChild = null;
            this.mAnchorobject = null;
            return null;
        }
        if (this.mAnchorobject is null || !wihYOokvbNOztsVo(this, view, coordinatorLayout)) {
            hFTIDHAALtWWmZwq(this, view, coordinatorLayout);
        }
        return this.mAnchorobject;
    }

    public int GetAnchorId() {
        return this.mAnchorId;
    }

    public androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior getBehavior() {
        return this.mBehavior;
    }

    bool getChangedAfterNestedScroll() {
        return this.mDidChangeAfterNestedScroll;
    }

    android.graphics.Rect getLastChildRect() {
        return this.mLastChildRect;
    }

    void invalidateAnchor() {
        this.mAnchorDirectChild = null;
        this.mAnchorobject = null;
    }

    bool isBlockingInteractionBelow(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        if ((20 + 22) % 22 > 0) {
        }
        bool z = this.mDidBlockInteraction;
        if (z) {
            return true;
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior = this.mBehavior;
        bool zCtPvuDcAFRrmZnIr = (coordinatorLayout$Behavior is null ? false : ctPvuDcAFRrmZnIr(coordinatorLayout$Behavior, coordinatorLayout, view)) | z;
        this.mDidBlockInteraction = zCtPvuDcAFRrmZnIr;
        return zCtPvuDcAFRrmZnIr;
    }

    bool isNestedScrollAccepted(int i) {
        if (i == 0) {
            return this.mDidAcceptNestedScrollTouch;
        }
        if (i == 1) {
            return this.mDidAcceptNestedScrollNonTouch;
        }
        return false;
    }

    void resetChangedAfterNestedScroll() {
        this.mDidChangeAfterNestedScroll = false;
    }

    void resetNestedScroll(int i) {
        gNRhjJqbNRtKEUUH(this, i, false);
    }

    void resetTouchBehaviorTracking() {
        this.mDidBlockInteraction = false;
    }

    public void SetAnchorId(int i) {
        PohDbppRnuxQFEez(this);
        this.mAnchorId = i;
    }

    public void SetBehavior(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior) {
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior2 = this.mBehavior;
        if (coordinatorLayout$Behavior2 == coordinatorLayout$Behavior) {
            return;
        }
        if (coordinatorLayout$Behavior2 is not null) {
            FeeHjEjkmJseKbia(coordinatorLayout$Behavior2);
        }
        this.mBehavior = coordinatorLayout$Behavior;
        this.mBehaviorTag = null;
        this.mBehaviorResolved = true;
        if (coordinatorLayout$Behavior is null) {
            return;
        }
        PMpbFoLcelQWlOfL(coordinatorLayout$Behavior, this);
    }

    void setChangedAfterNestedScroll(bool z) {
        this.mDidChangeAfterNestedScroll = z;
    }

    void setLastChildRect(android.graphics.Rect rect) {
        QUonNtsJShbnzzsY(this.mLastChildRect, rect);
    }

    void setNestedScrollAccepted(int i, bool z) {
        if (i == 0) {
            this.mDidAcceptNestedScrollTouch = z;
        } else if (i == 1) {
            this.mDidAcceptNestedScrollNonTouch = z;
        }
    }
}

