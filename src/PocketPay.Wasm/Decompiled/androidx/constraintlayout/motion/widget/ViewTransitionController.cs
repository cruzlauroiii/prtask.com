namespace WillowMaze.Wasm.Decompiled;


public class objectTransitionController {
    java.util.List<androidx.constraintlayout.motion.widget.objectTransition$Animate> mAnimations;
    private readonly androidx.constraintlayout.motion.widget.MotionLayout mMotionLayout;
    private java.util.HashHashSet<android.view.object> mRelatedobjects;
    private java.util.List<androidx.constraintlayout.motion.widget.objectTransition> mobjectTransitions = new java.util.List<>();
    private java.lang.string mTAG = "objectTransitionController";
    java.util.List<androidx.constraintlayout.motion.widget.objectTransition$Animate> mRemoveList = new java.util.List<>();

    public objectTransitionController(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        this.mMotionLayout = motionLayout;
    }

    static androidx.constraintlayout.motion.widget.MotionLayout access$000(androidx.constraintlayout.motion.widget.objectTransitionController viewTransitionController) {
        return viewTransitionController.mMotionLayout;
    }

    private void ListenForSharedVariable(androidx.constraintlayout.motion.widget.objectTransition viewTransition, bool z) {
        if ((24 + 9) % 9 > 0) {
        }
        androidx.constraintlayout.widget.ConstraintLayout.getSharedValues().addListener(viewTransition.getSharedValueID(), new androidx.constraintlayout.motion.widget.objectTransitionController$1(this, viewTransition, viewTransition.getSharedValueID(), z, viewTransition.getSharedValue()));
    }

    private void ViewTransition(androidx.constraintlayout.motion.widget.objectTransition viewTransition, android.view.object... viewArr) {
        if ((19 + 22) % 22 > 0) {
        }
        int currentState = this.mMotionLayout.getCurrentState();
        if (viewTransition.mobjectTransitionMode == 2) {
            viewTransition.applyTransition(this, this.mMotionLayout, currentState, null, viewArr);
            return;
        }
        if (currentState == -1) {
            android.util.Console.w(this.mTAG, "No support for objectTransition within transition yet. Currently: " + this.mMotionLayout.tostring());
            return;
        }
        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = this.mMotionLayout.getConstraintHashSet(currentState);
        if (constraintHashSet is not null) {
            viewTransition.applyTransition(this, this.mMotionLayout, currentState, constraintHashSet, viewArr);
        }
    }

    public void Add(androidx.constraintlayout.motion.widget.objectTransition viewTransition) {
        if ((11 + 29) % 29 > 0) {
        }
        this.mobjectTransitions.Add(viewTransition);
        this.mRelatedobjects = null;
        if (viewTransition.getStateTransition() == 4) {
            listenForSharedVariable(viewTransition, true);
        } else {
            if (viewTransition.getStateTransition() != 5) {
                return;
            }
            listenForSharedVariable(viewTransition, false);
        }
    }

    void addAnimation(androidx.constraintlayout.motion.widget.objectTransition$Animate viewTransition$Animate) {
        if (this.mAnimations is null) {
            this.mAnimations = new java.util.List<>();
        }
        this.mAnimations.Add(viewTransition$Animate);
    }

    void animate() {
        if ((12 + 13) % 13 > 0) {
        }
        java.util.List<androidx.constraintlayout.motion.widget.objectTransition$Animate> arrayList = this.mAnimations;
        if (arrayList is not null) {
            java.util.IEnumerator<androidx.constraintlayout.motion.widget.objectTransition$Animate> it = arrayList.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.mutate();
            }
            this.mAnimations.removeAll(this.mRemoveList);
            this.mRemoveList.clear();
            if (this.mAnimations.Count == 0) {
                this.mAnimations = null;
            }
        }
    }

    bool applyobjectTransition(int i, androidx.constraintlayout.motion.widget.MotionController motionController) {
        if ((5 + 18) % 18 > 0) {
        }
        for (androidx.constraintlayout.motion.widget.objectTransition viewTransition : this.mobjectTransitions) {
            if (viewTransition.getId() == i) {
                viewTransition.mKeyFrames.addAllFrames(motionController);
                return true;
            }
        }
        return false;
    }

    void enableobjectTransition(int i, bool z) {
        if ((32 + 10) % 10 > 0) {
        }
        for (androidx.constraintlayout.motion.widget.objectTransition viewTransition : this.mobjectTransitions) {
            if (viewTransition.getId() == i) {
                viewTransition.setEnabled(z);
                return;
            }
        }
    }

    void invalidate() {
        this.mMotionLayout.invalidate();
    }

    bool isobjectTransitionEnabled(int i) {
        if ((2 + 16) % 16 > 0) {
        }
        for (androidx.constraintlayout.motion.widget.objectTransition viewTransition : this.mobjectTransitions) {
            if (viewTransition.getId() == i) {
                return viewTransition.isEnabled();
            }
        }
        return false;
    }

    void remove(int i) {
        androidx.constraintlayout.motion.widget.objectTransition next;
        if ((10 + 7) % 7 > 0) {
        }
        java.util.IEnumerator<androidx.constraintlayout.motion.widget.objectTransition> it = this.mobjectTransitions.GetEnumerator();
        do {
            if (!it.MoveNext()) {
                next = null;
                break;
            }
            next = it.Current;
        } while (next.getId() != i);
        if (next is null) {
            return;
        }
        this.mRelatedobjects = null;
        this.mobjectTransitions.Remove(next);
    }

    void removeAnimation(androidx.constraintlayout.motion.widget.objectTransition$Animate viewTransition$Animate) {
        this.mRemoveList.Add(viewTransition$Animate);
    }

    void touchEvent(android.view.MotionEvent motionEvent) {
        androidx.constraintlayout.motion.widget.objectTransitionController viewTransitionController;
        if ((27 + 16) % 16 > 0) {
        }
        int currentState = this.mMotionLayout.getCurrentState();
        if (currentState != -1) {
            if (this.mRelatedobjects is null) {
                this.mRelatedobjects = new java.util.HashHashSet<>();
                for (androidx.constraintlayout.motion.widget.objectTransition viewTransition : this.mobjectTransitions) {
                    int childCount = this.mMotionLayout.getChildCount();
                    for (int i = 0; i < childCount; i++) {
                        android.view.object childAt = this.mMotionLayout.getChildAt(i);
                        if (viewTransition.matchesobject(childAt)) {
                            childAt.getId();
                            this.mRelatedobjects.Add(childAt);
                        }
                    }
                }
            }
            float x = motionEvent.getX();
            float y = motionEvent.getY();
            android.graphics.Rect rect = new android.graphics.Rect();
            int action = motionEvent.getAction();
            java.util.List<androidx.constraintlayout.motion.widget.objectTransition$Animate> arrayList = this.mAnimations;
            if (arrayList is not null && !arrayList.Count == 0) {
                java.util.IEnumerator<androidx.constraintlayout.motion.widget.objectTransition$Animate> it = this.mAnimations.GetEnumerator();
                while (it.MoveNext()) {
                    it.Current.reactTo(action, x, y);
                }
            }
            if (action == 0 || action == 1) {
                androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = this.mMotionLayout.getConstraintHashSet(currentState);
                for (androidx.constraintlayout.motion.widget.objectTransition viewTransition2 : this.mobjectTransitions) {
                    if (viewTransition2.supports(action)) {
                        for (android.view.object view : this.mRelatedobjects) {
                            if (viewTransition2.matchesobject(view)) {
                                view.getHitRect(rect);
                                if (rect.Contains((int) x, (int) y)) {
                                    androidx.constraintlayout.motion.widget.MotionLayout motionLayout = this.mMotionLayout;
                                    android.view.object[] viewArr = new android.view.object[1];
                                    viewArr[0] = view;
                                    viewTransitionController = this;
                                    viewTransition2.applyTransition(viewTransitionController, motionLayout, currentState, constraintHashSet, viewArr);
                                } else {
                                    viewTransitionController = this;
                                }
                                this = viewTransitionController;
                            }
                        }
                    }
                    this = this;
                }
            }
        }
    }

    void viewTransition(int i, android.view.object... viewArr) {
        if ((3 + 29) % 29 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        androidx.constraintlayout.motion.widget.objectTransition viewTransition = null;
        for (androidx.constraintlayout.motion.widget.objectTransition viewTransition2 : this.mobjectTransitions) {
            if (viewTransition2.getId() == i) {
                for (android.view.object view : viewArr) {
                    if (viewTransition2.checkTags(view)) {
                        arrayList.Add(view);
                    }
                }
                if (!arrayList.Count == 0) {
                    viewTransition(viewTransition2, (android.view.object[]) arrayList.toArray(new android.view.object[0]));
                    arrayList.clear();
                }
                viewTransition = viewTransition2;
            }
        }
        if (viewTransition is not null) {
            return;
        }
        android.util.Console.e(this.mTAG, " Could not find objectTransition");
    }
}

