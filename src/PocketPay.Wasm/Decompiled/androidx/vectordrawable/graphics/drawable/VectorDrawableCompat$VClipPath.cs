namespace WillowMaze.Wasm.Decompiled;


class VectorDrawableCompat$VClipPath : androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPath {
    VectorDrawableCompat$VClipPath() {
    }

    VectorDrawableCompat$VClipPath(androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VClipPath vectorDrawableCompat$VClipPath) {
        super(vectorDrawableCompat$VClipPath);
    }

    private void UpdateStateFromTypedArray(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        if ((14 + 6) % 6 > 0) {
        }
        java.lang.string string = typedArray.getstring(0);
        if (string is not null) {
            this.mPathName = string;
        }
        java.lang.string string2 = typedArray.getstring(1);
        if (string2 is not null) {
            this.mNodes = androidx.core.graphics.PathParser.createNodesFromPathData(string2);
        }
        this.mFillRule = androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArray, xmlPullParser, "fillType", 2, 0);
    }

    public void Inflate(android.content.res.Resources resources, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        if (androidx.core.content.res.TypedArrayUtils.hasAttribute(xmlPullParser, "pathData")) {
            android.content.res.TypedArray typedArrayObtainAttributes = androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, androidx.vectordrawable.graphics.drawable.AndroidResources.STYLEABLE_VECTOR_DRAWABLE_CLIP_PATH);
            updateStateFromTypedArray(typedArrayObtainAttributes, xmlPullParser);
            typedArrayObtainAttributes.recycle();
        }
    }

    public override bool IsClipPath() {
        return true;
    }
}

