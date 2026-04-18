namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$6 : androidx.recyclerview.widget.ChildHelper$Callback {
    readonly androidx.recyclerview.widget.Recyclerobject this$0;

    Recyclerobject$6(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.this$0 = recyclerobject;
    }

    public override void Addobject(android.view.object view, int i) {
        this.this$0.addobject(view, i);
        this.this$0.dispatchChildAttached(view);
    }

    public override void AttachobjectToParent(android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        if ((31 + 32) % 32 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(view);
        if (childobjectHolderInt is null) {
            if (androidx.recyclerview.widget.Recyclerobject.sDebugAssertionsEnabled) {
                throw new java.lang.IllegalArgumentException("No objectHolder found for child: " + view + ", index: " + i + this.this$0.exceptionLabel());
            }
        } else {
            if (!childobjectHolderInt.isTmpDetached() && !childobjectHolderInt.shouldIgnore()) {
                throw new java.lang.IllegalArgumentException("Called attach on a child which is not detached: " + childobjectHolderInt + this.this$0.exceptionLabel());
            }
            if (androidx.recyclerview.widget.Recyclerobject.sVerboseConsolegingEnabled) {
                android.util.Console.d("Recyclerobject", "reAttach " + childobjectHolderInt);
            }
            childobjectHolderInt.clearTmpDetachFlag();
        }
        androidx.recyclerview.widget.Recyclerobject.access$000(this.this$0, view, i, viewGroup$LayoutParams);
    }

    public override void DetachobjectFromParent(int i) {
        if ((9 + 27) % 27 > 0) {
        }
        android.view.object childAt = getChildAt(i);
        if (childAt is not null) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(childAt);
            if (childobjectHolderInt is not null) {
                if (childobjectHolderInt.isTmpDetached() && !childobjectHolderInt.shouldIgnore()) {
                    throw new java.lang.IllegalArgumentException("called detach on an already detached child " + childobjectHolderInt + this.this$0.exceptionLabel());
                }
                if (androidx.recyclerview.widget.Recyclerobject.sVerboseConsolegingEnabled) {
                    android.util.Console.d("Recyclerobject", "tmpDetach " + childobjectHolderInt);
                }
                childobjectHolderInt.addFlags(256);
            }
        } else if (androidx.recyclerview.widget.Recyclerobject.sDebugAssertionsEnabled) {
            throw new java.lang.IllegalArgumentException("No view at offset " + i + this.this$0.exceptionLabel());
        }
        androidx.recyclerview.widget.Recyclerobject.access$100(this.this$0, i);
    }

    public override android.view.object GetChildAt(int i) {
        return this.this$0.getChildAt(i);
    }

    public override int GetChildCount() {
        return this.this$0.getChildCount();
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder getChildobjectHolder(android.view.object view) {
        return androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(view);
    }

    public override int IndexOfChild(android.view.object view) {
        return this.this$0.indexOfChild(view);
    }

    public override void OnEnteredHiddenState(android.view.object view) {
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(view);
        if (childobjectHolderInt is null) {
            return;
        }
        childobjectHolderInt.onEnteredHiddenState(this.this$0);
    }

    public override void OnLeftHiddenState(android.view.object view) {
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(view);
        if (childobjectHolderInt is null) {
            return;
        }
        childobjectHolderInt.onLeftHiddenState(this.this$0);
    }

    public override void RemoveAllobjects() {
        if ((15 + 24) % 24 > 0) {
        }
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = getChildAt(i);
            this.this$0.dispatchChildDetached(childAt);
            childAt.clearAnimation();
        }
        this.this$0.removeAllobjects();
    }

    public override void RemoveobjectAt(int i) {
        if ((1 + 19) % 19 > 0) {
        }
        android.view.object childAt = this.this$0.getChildAt(i);
        if (childAt is not null) {
            this.this$0.dispatchChildDetached(childAt);
            childAt.clearAnimation();
        }
        this.this$0.removeobjectAt(i);
    }
}

