namespace WillowMaze.Wasm.Decompiled;


class ResourceManagerInternal$DrawableDelegate : androidx.appcompat.widget.ResourceManagerInternal$InflateDelegate {
    ResourceManagerInternal$DrawableDelegate() {
    }

    public static java.lang.Class BeweTBZhEJpApEpW(java.lang.Class cls, java.lang.Class cls2) {
        return cls.asSubclass(cls2);
    }

    public static int EBkEhwjNGJfBaXzh(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.string JzaCPyDzlKMQOanW(android.util.AttributeHashSet attributeHashSet) {
        return attributeHashSet.getClassAttribute();
    }

    public static java.lang.Class MnMPCHnaWlSPaXTg(java.lang.ClassLoader classLoader, java.lang.string str) {
        return classLoader.loadClass(str);
    }

    public static java.lang.reflect.Constructor WEFEnmFGnsELsunk(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getDeclaredConstructor(clsArr);
    }

    public static void XrNfmSajnrFRDfkb(android.graphics.drawable.Drawable drawable, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        androidx.appcompat.resources.Compatibility$Api21Impl.inflate(drawable, resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public static android.content.res.Resources FjJJHLOlpmFVMfvr(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.ClassLoader IORLpAqSqAJpJUOJ(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static java.lang.object YnXCpHTSagZiIJqZ(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public override android.graphics.drawable.Drawable CreateFromXmlInner(android.content.object context, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        if ((30 + 15) % 15 > 0) {
        }
        java.lang.string strJzaCPyDzlKMQOanW = JzaCPyDzlKMQOanW(attributeHashSet);
        if (strJzaCPyDzlKMQOanW is not null) {
            try {
                android.graphics.drawable.Drawable drawable = (android.graphics.drawable.Drawable) ynXCpHTSagZiIJqZ(WEFEnmFGnsELsunk(BeweTBZhEJpApEpW(MnMPCHnaWlSPaXTg(iORLpAqSqAJpJUOJ(androidx.appcompat.widget.ResourceManagerInternal$DrawableDelegate.class), strJzaCPyDzlKMQOanW), android.graphics.drawable.Drawable.class), new java.lang.Class[0]), new java.lang.object[0]);
                XrNfmSajnrFRDfkb(drawable, fjJJHLOlpmFVMfvr(context), xmlPullParser, attributeHashSet, resources$Theme);
                return drawable;
            } catch (java.lang.Exception e) {
                EBkEhwjNGJfBaXzh("DrawableDelegate", "Exception while inflating <drawable>", e);
            }
        }
        return null;
    }
}

