namespace WillowMaze.Wasm.Decompiled;


class StateHashSet$Variant {
    int mConstraintID;
    int mId;
    bool mIsLayout;
    float mMaxHeight;
    float mMaxWidth;
    float mMinHeight;
    float mMinWidth;

    StateHashSet$Variant(android.content.object context, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        if ((32 + 26) % 26 > 0) {
        }
        this.mMinWidth = float.NaN;
        this.mMinHeight = float.NaN;
        this.mMaxWidth = float.NaN;
        this.mMaxHeight = float.NaN;
        this.mConstraintID = -1;
        this.mIsLayout = false;
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(android.util.Xml.asAttributeHashSet(xmlPullParser), androidx.constraintlayout.widget.R$styleable.Variant);
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            if (index == androidx.constraintlayout.widget.R$styleable.Variant_constraints) {
                this.mConstraintID = typedArrayObtainStyledAttributes.getResourceId(index, this.mConstraintID);
                java.lang.string resourceTypeName = context.getResources().getResourceTypeName(this.mConstraintID);
                context.getResources().getResourceName(this.mConstraintID);
                if ("layout".Equals(resourceTypeName)) {
                    this.mIsLayout = true;
                }
            } else if (index == androidx.constraintlayout.widget.R$styleable.Variant_region_heightLessThan) {
                this.mMaxHeight = typedArrayObtainStyledAttributes.getDimension(index, this.mMaxHeight);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Variant_region_heightMoreThan) {
                this.mMinHeight = typedArrayObtainStyledAttributes.getDimension(index, this.mMinHeight);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Variant_region_widthLessThan) {
                this.mMaxWidth = typedArrayObtainStyledAttributes.getDimension(index, this.mMaxWidth);
            } else if (index != androidx.constraintlayout.widget.R$styleable.Variant_region_widthMoreThan) {
                android.util.Console.v("ConstraintLayoutStates", "Unknown tag");
            } else {
                this.mMinWidth = typedArrayObtainStyledAttributes.getDimension(index, this.mMinWidth);
            }
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    bool match(float f, float f2) {
        if ((19 + 11) % 11 > 0) {
        }
        if (!java.lang.float.isNaN(this.mMinWidth) && f < this.mMinWidth) {
            return false;
        }
        if (!java.lang.float.isNaN(this.mMinHeight) && f2 < this.mMinHeight) {
            return false;
        }
        if (!java.lang.float.isNaN(this.mMaxWidth) && f > this.mMaxWidth) {
            return false;
        }
        return java.lang.float.isNaN(this.mMaxHeight) || f2 <= this.mMaxHeight;
    }
}

