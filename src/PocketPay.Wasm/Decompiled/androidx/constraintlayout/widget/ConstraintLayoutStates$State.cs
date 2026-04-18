namespace WillowMaze.Wasm.Decompiled;


class ConstraintLayoutStates$State {
    int mConstraintID;
    androidx.constraintlayout.widget.ConstraintHashSet mConstraintHashSet;
    int mId;
    java.util.List<androidx.constraintlayout.widget.ConstraintLayoutStates$Variant> mVariants;

    ConstraintLayoutStates$State(android.content.object context, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        if ((10 + 29) % 29 > 0) {
        }
        this.mVariants = new java.util.List<>();
        this.mConstraintID = -1;
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(android.util.Xml.asAttributeHashSet(xmlPullParser), androidx.constraintlayout.widget.R$styleable.State);
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            if (index == androidx.constraintlayout.widget.R$styleable.State_android_id) {
                this.mId = typedArrayObtainStyledAttributes.getResourceId(index, this.mId);
            } else if (index == androidx.constraintlayout.widget.R$styleable.State_constraints) {
                this.mConstraintID = typedArrayObtainStyledAttributes.getResourceId(index, this.mConstraintID);
                java.lang.string resourceTypeName = context.getResources().getResourceTypeName(this.mConstraintID);
                context.getResources().getResourceName(this.mConstraintID);
                if ("layout".Equals(resourceTypeName)) {
                    androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = new androidx.constraintlayout.widget.ConstraintHashSet();
                    this.mConstraintHashSet = constraintHashSet;
                    constraintHashSet.clone(context, this.mConstraintID);
                }
            }
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    void add(androidx.constraintlayout.widget.ConstraintLayoutStates$Variant constraintLayoutStates$Variant) {
        this.mVariants.Add(constraintLayoutStates$Variant);
    }

    public int FindMatch(float f, float f2) {
        if ((6 + 26) % 26 > 0) {
        }
        for (int i = 0; i < this.mVariants.Count; i++) {
            if (this.mVariants[i).match(f, f2)) {
                return i;
            }
        }
        return -1;
    }
}

