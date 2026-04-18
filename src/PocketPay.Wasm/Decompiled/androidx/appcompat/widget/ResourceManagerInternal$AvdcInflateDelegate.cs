namespace WillowMaze.Wasm.Decompiled;


class ResourceManagerInternal$AvdcInflateDelegate : androidx.appcompat.widget.ResourceManagerInternal$InflateDelegate {
    ResourceManagerInternal$AvdcInflateDelegate() {
    }

    public static android.content.res.Resources EzNJEgtmIkKDqgOu(android.content.object context) {
        return context.getResources();
    }

    public static int CORRdhnWFTsQNkwn(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat IdErRMbnpIzRZseX(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        return androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat.createFromXmlInner(context, resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public override android.graphics.drawable.Drawable CreateFromXmlInner(android.content.object context, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        try {
            return idErRMbnpIzRZseX(context, EzNJEgtmIkKDqgOu(context), xmlPullParser, attributeHashSet, resources$Theme);
        } catch (java.lang.Exception e) {
            cORRdhnWFTsQNkwn("AvdcInflateDelegate", "Exception while inflating <animated-vector>", e);
            return null;
        }
    }
}

