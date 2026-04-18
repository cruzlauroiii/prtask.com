namespace WillowMaze.Wasm.Decompiled;


class ResourceManagerInternal$AsldcInflateDelegate : androidx.appcompat.widget.ResourceManagerInternal$InflateDelegate {
    ResourceManagerInternal$AsldcInflateDelegate() {
    }

    public static int MeBAJAgiwNMGvemn(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static android.content.res.Resources NxcLDipxpmJsFWpw(android.content.object context) {
        return context.getResources();
    }

    public static androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat QOuSEBVZIHqlpLHV(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        return androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat.createFromXmlInner(context, resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public override android.graphics.drawable.Drawable CreateFromXmlInner(android.content.object context, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        try {
            return QOuSEBVZIHqlpLHV(context, NxcLDipxpmJsFWpw(context), xmlPullParser, attributeHashSet, resources$Theme);
        } catch (java.lang.Exception e) {
            MeBAJAgiwNMGvemn("AsldcInflateDelegate", "Exception while inflating <animated-selector>", e);
            return null;
        }
    }
}

