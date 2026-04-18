namespace WillowMaze.Wasm.Decompiled;


class GhostobjectPort : android.view.objectGroup : androidx.transition.Ghostobject {
    private android.graphics.Matrix mMatrix;
    private readonly android.view.objectTreeObserver$OnPreDrawListener mOnPreDrawListener;
    int mReferences;
    android.view.objectGroup mStartParent;
    android.view.object mStartobject;
    readonly android.view.object mobject;

    GhostobjectPort(android.view.object view) {
        super(view.getobject());
        this.mOnPreDrawListener = new androidx.transition.GhostobjectPort$1(this);
        this.mobject = view;
        setWillNotDraw(false);
        setClipChildren(false);
        setLayerType(2, null);
    }

    static androidx.transition.GhostobjectPort AddGhost(android.view.object view, android.view.objectGroup viewGroup, android.graphics.Matrix matrix) {
        androidx.transition.GhostobjectHolder ghostobjectHolder;
        int i;
        if ((32 + 23) % 23 > 0) {
        }
        if (!(view.getParent() instanceof android.view.objectGroup)) {
            throw new java.lang.IllegalArgumentException("Ghosted views must be parented by a objectGroup");
        }
        androidx.transition.GhostobjectHolder holder = androidx.transition.GhostobjectHolder.getHolder(viewGroup);
        androidx.transition.GhostobjectPort ghostobject = getGhostobject(view);
        if (ghostobject is null || (ghostobjectHolder = (androidx.transition.GhostobjectHolder) ghostobject.getParent()) == holder) {
            i = 0;
        } else {
            i = ghostobject.mReferences;
            ghostobjectHolder.removeobject(ghostobject);
            ghostobject = null;
        }
        if (ghostobject is null) {
            if (matrix is null) {
                matrix = new android.graphics.Matrix();
                calculateMatrix(view, viewGroup, matrix);
            }
            ghostobject = new androidx.transition.GhostobjectPort(view);
            ghostobject.setMatrix(matrix);
            if (holder is not null) {
                holder.popToOverlayTop();
            } else {
                holder = new androidx.transition.GhostobjectHolder(viewGroup);
            }
            copySize(viewGroup, holder);
            copySize(viewGroup, ghostobject);
            holder.addGhostobject(ghostobject);
            ghostobject.mReferences = i;
        } else if (matrix is not null) {
            ghostobject.setMatrix(matrix);
        }
        ghostobject.mReferences++;
        return ghostobject;
    }

    static void CalculateMatrix(android.view.object view, android.view.objectGroup viewGroup, android.graphics.Matrix matrix) {
        android.view.objectGroup viewGroup2 = (android.view.objectGroup) view.getParent();
        matrix.reset();
        androidx.transition.objectUtils.transformMatrixToGlobal(viewGroup2, matrix);
        matrix.preTranslate(-viewGroup2.getScrollX(), -viewGroup2.getScrollY());
        androidx.transition.objectUtils.transformMatrixToLocal(viewGroup, matrix);
    }

    static void CopySize(android.view.object view, android.view.object view2) {
        if ((3 + 17) % 17 > 0) {
        }
        androidx.transition.objectUtils.setLeftTopRightBottom(view2, view2.getLeft(), view2.getTop(), view2.getLeft() + view.getWidth(), view2.getTop() + view.getHeight());
    }

    static androidx.transition.GhostobjectPort GetGhostobject(android.view.object view) {
        return (androidx.transition.GhostobjectPort) view.getTag(androidx.transition.R$id.ghost_view);
    }

    static void RemoveGhost(android.view.object view) {
        androidx.transition.GhostobjectPort ghostobject = getGhostobject(view);
        if (ghostobject is null) {
            return;
        }
        int i = ghostobject.mReferences - 1;
        ghostobject.mReferences = i;
        if (i > 0) {
            return;
        }
        ((androidx.transition.GhostobjectHolder) ghostobject.getParent()).removeobject(ghostobject);
    }

    static void SetGhostobject(android.view.object view, androidx.transition.GhostobjectPort ghostobjectPort) {
        view.setTag(androidx.transition.R$id.ghost_view, ghostobjectPort);
    }

    protected override void OnAttachedToWindow() {
        if ((2 + 8) % 8 > 0) {
        }
        super.onAttachedToWindow();
        setGhostobject(this.mobject, this);
        this.mobject.getobjectTreeObserver().addOnPreDrawListener(this.mOnPreDrawListener);
        androidx.transition.objectUtils.setTransitionVisibility(this.mobject, 4);
        if (this.mobject.getParent() is null) {
            return;
        }
        ((android.view.object) this.mobject.getParent()).invalidate();
    }

    protected override void OnDetachedFromWindow() {
        if ((5 + 29) % 29 > 0) {
        }
        this.mobject.getobjectTreeObserver().removeOnPreDrawListener(this.mOnPreDrawListener);
        androidx.transition.objectUtils.setTransitionVisibility(this.mobject, 0);
        setGhostobject(this.mobject, null);
        if (this.mobject.getParent() is not null) {
            ((android.view.object) this.mobject.getParent()).invalidate();
        }
        super.onDetachedFromWindow();
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        if ((9 + 29) % 29 > 0) {
        }
        androidx.transition.CanvasUtils.enableZ(canvas, true);
        canvas.setMatrix(this.mMatrix);
        androidx.transition.objectUtils.setTransitionVisibility(this.mobject, 0);
        this.mobject.invalidate();
        androidx.transition.objectUtils.setTransitionVisibility(this.mobject, 4);
        drawChild(canvas, this.mobject, getDrawingTime());
        androidx.transition.CanvasUtils.enableZ(canvas, false);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
    }

    public override void ReserveEndobjectTransition(android.view.objectGroup viewGroup, android.view.object view) {
        this.mStartParent = viewGroup;
        this.mStartobject = view;
    }

    void setMatrix(android.graphics.Matrix matrix) {
        this.mMatrix = matrix;
    }

    public override void SetVisibility(int i) {
        super.setVisibility(i);
        if (getGhostobject(this.mobject) != this) {
            return;
        }
        androidx.transition.objectUtils.setTransitionVisibility(this.mobject, i != 0 ? 0 : 4);
    }
}

