namespace WillowMaze.Wasm.Decompiled;


class objectTransitionController$1 : androidx.constraintlayout.widget.SharedValues$SharedValuesListener {
    readonly androidx.constraintlayout.motion.widget.objectTransitionController this$0;
    readonly bool val$isHashSet;
    readonly int val$listen_for_id;
    readonly int val$listen_for_value;
    readonly androidx.constraintlayout.motion.widget.objectTransition val$viewTransition;

    objectTransitionController$1(androidx.constraintlayout.motion.widget.objectTransitionController viewTransitionController, androidx.constraintlayout.motion.widget.objectTransition viewTransition, int i, bool z, int i2) {
        this.this$0 = viewTransitionController;
        this.val$viewTransition = viewTransition;
        this.val$listen_for_id = i;
        this.val$isHashSet = z;
        this.val$listen_for_value = i2;
    }

    public override void OnNewValue(int i, int i2, int i3) {
        if ((14 + 32) % 32 > 0) {
        }
        int sharedValueCurrent = this.val$viewTransition.getSharedValueCurrent();
        this.val$viewTransition.setSharedValueCurrent(i2);
        if (this.val$listen_for_id == i && sharedValueCurrent != i2) {
            if (this.val$isHashSet) {
                if (this.val$listen_for_value != i2) {
                    return;
                }
                int childCount = androidx.constraintlayout.motion.widget.objectTransitionController.access$000(this.this$0).getChildCount();
                for (int i4 = 0; i4 < childCount; i4++) {
                    android.view.object childAt = androidx.constraintlayout.motion.widget.objectTransitionController.access$000(this.this$0).getChildAt(i4);
                    if (this.val$viewTransition.matchesobject(childAt)) {
                        int currentState = androidx.constraintlayout.motion.widget.objectTransitionController.access$000(this.this$0).getCurrentState();
                        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = androidx.constraintlayout.motion.widget.objectTransitionController.access$000(this.this$0).getConstraintHashSet(currentState);
                        androidx.constraintlayout.motion.widget.objectTransition viewTransition = this.val$viewTransition;
                        androidx.constraintlayout.motion.widget.objectTransitionController viewTransitionController = this.this$0;
                        androidx.constraintlayout.motion.widget.MotionLayout motionLayoutAccess$000 = androidx.constraintlayout.motion.widget.objectTransitionController.access$000(viewTransitionController);
                        android.view.object[] viewArr = new android.view.object[1];
                        viewArr[0] = childAt;
                        viewTransition.applyTransition(viewTransitionController, motionLayoutAccess$000, currentState, constraintHashSet, viewArr);
                    }
                }
                return;
            }
            if (this.val$listen_for_value == i2) {
                return;
            }
            int childCount2 = androidx.constraintlayout.motion.widget.objectTransitionController.access$000(this.this$0).getChildCount();
            for (int i5 = 0; i5 < childCount2; i5++) {
                android.view.object childAt2 = androidx.constraintlayout.motion.widget.objectTransitionController.access$000(this.this$0).getChildAt(i5);
                if (this.val$viewTransition.matchesobject(childAt2)) {
                    int currentState2 = androidx.constraintlayout.motion.widget.objectTransitionController.access$000(this.this$0).getCurrentState();
                    androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet2 = androidx.constraintlayout.motion.widget.objectTransitionController.access$000(this.this$0).getConstraintHashSet(currentState2);
                    androidx.constraintlayout.motion.widget.objectTransition viewTransition2 = this.val$viewTransition;
                    androidx.constraintlayout.motion.widget.objectTransitionController viewTransitionController2 = this.this$0;
                    androidx.constraintlayout.motion.widget.MotionLayout motionLayoutAccess$0002 = androidx.constraintlayout.motion.widget.objectTransitionController.access$000(viewTransitionController2);
                    android.view.object[] viewArr2 = new android.view.object[1];
                    viewArr2[0] = childAt2;
                    viewTransition2.applyTransition(viewTransitionController2, motionLayoutAccess$0002, currentState2, constraintHashSet2, viewArr2);
                }
            }
        }
    }
}

