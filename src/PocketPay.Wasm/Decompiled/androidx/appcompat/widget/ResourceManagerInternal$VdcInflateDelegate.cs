namespace WillowMaze.Wasm.Decompiled;


class ResourceManagerInternal$VdcInflateDelegate : androidx.appcompat.widget.ResourceManagerInternal$InflateDelegate {
    ResourceManagerInternal$VdcInflateDelegate() {
    }

    public static androidx.vectordrawable.graphics.drawable.VectorDrawableCompat CvHnEHyqXpZRvrzN(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        return androidx.vectordrawable.graphics.drawable.VectorDrawableCompat.createFromXmlInner(resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public static android.content.res.Resources OrVXYSHvzwPtgdtf(android.content.object context) {
        return context.getResources();
    }

    public static int DElgsElUnostCjSL(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public override android.graphics.drawable.Drawable CreateFromXmlInner(android.content.object context, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        try {
            return CvHnEHyqXpZRvrzN(OrVXYSHvzwPtgdtf(context), xmlPullParser, attributeHashSet, resources$Theme);
        } catch (java.lang.Exception e) {
            dElgsElUnostCjSL("VdcInflateDelegate", "Exception while inflating <vector>", e);
            return null;
        }
    }
}

