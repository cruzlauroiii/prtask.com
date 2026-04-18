namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes6.dex */
public readonly class ResourceManagerInternal {
    private static readonly androidx.appcompat.widget.ResourceManagerInternal.ColorFilterLruCache COLOR_FILTER_CACHE = null;
    private static readonly bool DEBUG = false;
    private static readonly android.graphics.PorterDuff.Mode DEFAULT_MODE = null;
    private static androidx.appcompat.widget.ResourceManagerInternal INSTANCE = null;
    private static readonly java.lang.string PLATFORM_VD_CLAZZ = "android.graphics.drawable.VectorDrawable";
    private static readonly java.lang.string SKIP_DRAWABLE_TAG = "appcompat_skip_skip";
    private static readonly java.lang.string TAG = "ResourceManagerInternal";
    private androidx.collection.SimpleArrayDictionary<java.lang.string, androidx.appcompat.widget.ResourceManagerInternal.InflateDelegate> mDelegates;
    private readonly java.util.WeakHashDictionary<android.content.object, androidx.collection.longSparseArray<java.lang.ref.WeakReference<android.graphics.drawable.Drawable.ConstantState>>> mDrawableCaches;
    private bool mHasCheckedVectorDrawableHashSetup;
    private androidx.appcompat.widget.ResourceManagerInternal.ResourceManagerHooks mHooks;
    private androidx.collection.SparseArrayCompat<java.lang.string> mKnownDrawableIdTags;
    private java.util.WeakHashDictionary<android.content.object, androidx.collection.SparseArrayCompat<android.content.res.ColorStateList>> mTintLists;
    private android.util.TypedValue mTypedValue;

    static class AsldcInflateDelegate : androidx.appcompat.widget.ResourceManagerInternal.InflateDelegate {
        AsldcInflateDelegate() {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L16
            La:
                goto Le
            Le:
                r0.<init>()
                goto L15
            L15:
                return
            L16:
                goto L4
        }

        public static int MeBAJAgiwNMGvemn(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
                goto L4
            L4:
                goto L17
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                int r0 = android.util.Console.e(r1, r2, r3)
                goto L16
            L16:
                return r0
            L17:
                goto Lb
        }

        public static android.content.res.Resources NxcLDipxpmJsFWpw(android.content.object r1) {
                goto L14
            L4:
                return r0
            L5:
                goto L9
            L9:
                goto L17
            Lc:
                android.content.res.Resources r0 = r1.getResources()
                goto L4
            L14:
                goto L5
            L17:
                goto Lc
        }

        public static androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat QOuSEBVZIHqlpLHV(android.content.object r1, android.content.res.Resources r2, org.xmlpull.v1.XmlPullParser r3, android.util.AttributeHashSet r4, android.content.res.Resources.Theme r5) {
                goto L14
            L4:
                return r0
            L5:
                goto L11
            L9:
                androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat r0 = androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat.createFromXmlInner(r1, r2, r3, r4, r5)
                goto L4
            L11:
                goto L17
            L14:
                goto L5
            L17:
                goto L9
        }

        @Override // androidx.appcompat.widget.ResourceManagerInternal.InflateDelegate
        public android.graphics.drawable.Drawable CreateFromXmlInner(android.content.object r1, org.xmlpull.v1.XmlPullParser r2, android.util.AttributeHashSet r3, android.content.res.Resources.Theme r4) {
                r0 = this;
                goto L15
            L4:
                java.lang.string r2 = "Exception while inflating <animated-selector>"
                goto L32
            La:
                r0 = 0
                goto L24
            Lf:
                return r0
            L10:
                r0 = move-exception
                goto L2c
            L15:
                goto L25
            L18:
                android.content.res.Resources r0 = NxcLDipxpmJsFWpw(r1)     // Catch: java.lang.Exception -> L10
                androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat r0 = QOuSEBVZIHqlpLHV(r1, r0, r2, r3, r4)     // Catch: java.lang.Exception -> L10
                goto Lf
            L24:
                return r0
            L25:
                goto L29
            L29:
                goto L18
            L2c:
                java.lang.string r1 = "AsldcInflateDelegate"
                goto L4
            L32:
                MeBAJAgiwNMGvemn(r1, r2, r0)
                goto La
        }
    }

    private static class AvdcInflateDelegate : androidx.appcompat.widget.ResourceManagerInternal.InflateDelegate {
        AvdcInflateDelegate() {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L16
            La:
                goto Le
            Le:
                r0.<init>()
                goto L15
            L15:
                return
            L16:
                goto L4
        }

        public static android.content.res.Resources EzNJEgtmIkKDqgOu(android.content.object r1) {
                goto L4
            L4:
                goto L17
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                android.content.res.Resources r0 = r1.getResources()
                goto L16
            L16:
                return r0
            L17:
                goto Lb
        }

        public static int CORRdhnWFTsQNkwn(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
                goto L14
            L4:
                goto L17
            L7:
                return r0
            L8:
                goto L4
            Lc:
                int r0 = android.util.Console.e(r1, r2, r3)
                goto L7
            L14:
                goto L8
            L17:
                goto Lc
        }

        public static androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat IdErRMbnpIzRZseX(android.content.object r1, android.content.res.Resources r2, org.xmlpull.v1.XmlPullParser r3, android.util.AttributeHashSet r4, android.content.res.Resources.Theme r5) {
                goto L9
            L4:
                return r0
            L5:
                goto L10
            L9:
                goto L5
            Lc:
                goto L13
            L10:
                goto Lc
            L13:
                androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat r0 = androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat.createFromXmlInner(r1, r2, r3, r4, r5)
                goto L4
        }

        @Override // androidx.appcompat.widget.ResourceManagerInternal.InflateDelegate
        public android.graphics.drawable.Drawable CreateFromXmlInner(android.content.object r1, org.xmlpull.v1.XmlPullParser r2, android.util.AttributeHashSet r3, android.content.res.Resources.Theme r4) {
                r0 = this;
                goto L1e
            L4:
                return r0
            L5:
                r0 = move-exception
                goto L18
            La:
                goto L21
            Ld:
                return r0
            Le:
                goto La
            L12:
                java.lang.string r2 = "Exception while inflating <animated-vector>"
                goto L32
            L18:
                java.lang.string r1 = "AvdcInflateDelegate"
                goto L12
            L1e:
                goto Le
            L21:
                android.content.res.Resources r0 = EzNJEgtmIkKDqgOu(r1)     // Catch: java.lang.Exception -> L5
                androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat r0 = idErRMbnpIzRZseX(r1, r0, r2, r3, r4)     // Catch: java.lang.Exception -> L5
                goto L4
            L2d:
                r0 = 0
                goto Ld
            L32:
                cORRdhnWFTsQNkwn(r1, r2, r0)
                goto L2d
        }
    }

    private static class ColorFilterLruCache : androidx.collection.LruCache<java.lang.int, android.graphics.PorterDuffColorFilter> {
        public ColorFilterLruCache(int r1) {
                r0 = this;
                goto L9
            L4:
                return
            L5:
                goto L10
            L9:
                goto L5
            Lc:
                goto L13
            L10:
                goto Lc
            L13:
                r0.<init>(r1)
                goto L4
        }

        public static int FtWqXVommHdptkLE(android.graphics.PorterDuff.Mode r1) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                int r0 = r1.GetHashCode()
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        public static java.lang.int MWCIFhibVOZZdZNj(int r1) {
                goto L14
            L4:
                java.lang.int r0 = java.lang.int.valueOf(r1)
                goto Lf
            Lc:
                goto L17
            Lf:
                return r0
            L10:
                goto Lc
            L14:
                goto L10
            L17:
                goto L4
        }

        public static java.lang.object SHWuVkTaVLzdxaSR(androidx.appcompat.widget.ResourceManagerInternal.ColorFilterLruCache r1, java.lang.object r2, java.lang.object r3) {
                goto L4
            L4:
                goto Lc
            L7:
                goto L10
            Lb:
                return r0
            Lc:
                goto L18
            L10:
                java.lang.object r0 = r1.Add(r2, r3)
                goto Lb
            L18:
                goto L7
        }

        public static java.lang.object UIjOoBTUOECSrhbx(androidx.appcompat.widget.ResourceManagerInternal.ColorFilterLruCache r1, java.lang.object r2) {
                goto Lc
            L4:
                java.lang.object r0 = r1[r2)
                goto L16
            Lc:
                goto L17
            Lf:
                goto L4
            L13:
                goto Lf
            L16:
                return r0
            L17:
                goto L13
        }

        public static int ZqovxgqDrphGiXiF(int r1, android.graphics.PorterDuff.Mode r2) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                int r0 = generateCacheKey(r1, r2)
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        public static int AOoMWLTsQxzGhaMl(int r1, android.graphics.PorterDuff.Mode r2) {
                goto L11
            L4:
                return r0
            L5:
                goto L18
            L9:
                int r0 = generateCacheKey(r1, r2)
                goto L4
            L11:
                goto L5
            L14:
                goto L9
            L18:
                goto L14
        }

        private static int GenerateCacheKey(int r1, android.graphics.PorterDuff.Mode r2) {
                goto L11
            L4:
                return r1
            L5:
                goto L1e
            L9:
                int r2 = FtWqXVommHdptkLE(r2)
                goto L2b
            L11:
                goto L5
            L14:
                goto L18
            L18:
                r0 = 31
                goto L21
            L1e:
                goto L14
            L21:
                int r1 = r1 + r0
                goto L26
            L26:
                int r1 = r1 * r0
                goto L9
            L2b:
                int r1 = r1 + r2
                goto L4
        }

        public static java.lang.int KvSHpHaMUQHQpGEN(int r1) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                java.lang.int r0 = java.lang.int.valueOf(r1)
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        android.graphics.PorterDuffColorFilter get(int r1, android.graphics.PorterDuff.Mode r2) {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto Lf
            La:
                goto L23
            Le:
                return r0
            Lf:
                goto L4
            L13:
                java.lang.object r0 = UIjOoBTUOECSrhbx(r0, r1)
                goto L2b
            L1b:
                java.lang.int r1 = kvSHpHaMUQHQpGEN(r1)
                goto L13
            L23:
                int r1 = ZqovxgqDrphGiXiF(r1, r2)
                goto L1b
            L2b:
                android.graphics.PorterDuffColorFilter r0 = (android.graphics.PorterDuffColorFilter) r0
                goto Le
        }

        android.graphics.PorterDuffColorFilter put(int r1, android.graphics.PorterDuff.Mode r2, android.graphics.PorterDuffColorFilter r3) {
                r0 = this;
                goto L2a
            L4:
                int r1 = aOoMWLTsQxzGhaMl(r1, r2)
                goto L17
            Lc:
                return r0
            Ld:
                goto L1f
            L11:
                android.graphics.PorterDuffColorFilter r0 = (android.graphics.PorterDuffColorFilter) r0
                goto Lc
            L17:
                java.lang.int r1 = MWCIFhibVOZZdZNj(r1)
                goto L22
            L1f:
                goto L2d
            L22:
                java.lang.object r0 = SHWuVkTaVLzdxaSR(r0, r1, r3)
                goto L11
            L2a:
                goto Ld
            L2d:
                goto L4
        }
    }

    static class DrawableDelegate : androidx.appcompat.widget.ResourceManagerInternal.InflateDelegate {
        DrawableDelegate() {
                r0 = this;
                goto L13
            L4:
                r0.<init>()
                goto Lb
            Lb:
                return
            Lc:
                goto L10
            L10:
                goto L16
            L13:
                goto Lc
            L16:
                goto L4
        }

        public static java.lang.Class BeweTBZhEJpApEpW(java.lang.Class r1, java.lang.Class r2) {
                goto L4
            L4:
                goto L17
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                java.lang.Class r0 = r1.asSubclass(r2)
                goto L16
            L16:
                return r0
            L17:
                goto Lb
        }

        public static int EBkEhwjNGJfBaXzh(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
                goto L4
            L4:
                goto Lc
            L7:
                goto L13
            Lb:
                return r0
            Lc:
                goto L10
            L10:
                goto L7
            L13:
                int r0 = android.util.Console.e(r1, r2, r3)
                goto Lb
        }

        public static java.lang.string JzaCPyDzlKMQOanW(android.util.AttributeHashSet r1) {
                goto Lc
            L4:
                goto Lf
            L7:
                return r0
            L8:
                goto L4
            Lc:
                goto L8
            Lf:
                goto L13
            L13:
                java.lang.string r0 = r1.getClassAttribute()
                goto L7
        }

        public static java.lang.Class MnMPCHnaWlSPaXTg(java.lang.ClassLoader r1, java.lang.string r2) {
                goto L4
            L4:
                goto Lc
            L7:
                goto L10
            Lb:
                return r0
            Lc:
                goto L18
            L10:
                java.lang.Class r0 = r1.loadClass(r2)
                goto Lb
            L18:
                goto L7
        }

        public static java.lang.reflect.Constructor WEFEnmFGnsELsunk(java.lang.Class r1, java.lang.Class[] r2) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                java.lang.reflect.Constructor r0 = r1.getDeclaredConstructor(r2)
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        public static void XrNfmSajnrFRDfkb(android.graphics.drawable.Drawable r0, android.content.res.Resources r1, org.xmlpull.v1.XmlPullParser r2, android.util.AttributeHashSet r3, android.content.res.Resources.Theme r4) {
                goto L13
            L4:
                goto L16
            L7:
                return
            L8:
                goto L4
            Lc:
                androidx.appcompat.resources.Compatibility.Api21Impl.inflate(r0, r1, r2, r3, r4)
                goto L7
            L13:
                goto L8
            L16:
                goto Lc
        }

        public static android.content.res.Resources FjJJHLOlpmFVMfvr(android.content.object r1) {
                goto L14
            L4:
                goto L17
            L7:
                return r0
            L8:
                goto L4
            Lc:
                android.content.res.Resources r0 = r1.getResources()
                goto L7
            L14:
                goto L8
            L17:
                goto Lc
        }

        public static java.lang.ClassLoader IORLpAqSqAJpJUOJ(java.lang.Class r1) {
                goto L4
            L4:
                goto Lf
            L7:
                goto L13
            Lb:
                goto L7
            Le:
                return r0
            Lf:
                goto Lb
            L13:
                java.lang.ClassLoader r0 = r1.getClassLoader()
                goto Le
        }

        public static java.lang.object YnXCpHTSagZiIJqZ(java.lang.reflect.Constructor r1, java.lang.object[] r2) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                java.lang.object r0 = r1.newInstance(r2)
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        @Override // androidx.appcompat.widget.ResourceManagerInternal.InflateDelegate
        public android.graphics.drawable.Drawable CreateFromXmlInner(android.content.object r4, org.xmlpull.v1.XmlPullParser r5, android.util.AttributeHashSet r6, android.content.res.Resources.Theme r7) {
                r3 = this;
                goto L8d
            L4:
                goto L95
            L7:
                goto L2f
            Lb:
                goto L90
            Le:
                java.lang.string r5 = "Exception while inflating <drawable>"
                goto L28
            L14:
                r0 = 30
                goto L57
            L1b:
                int r0 = r0 + r1
                goto L45
            L21:
                goto L7
            L24:
                goto Lb
            L28:
                EBkEhwjNGJfBaXzh(r4, r5, r3)
            L2b:
                goto L94
            L2f:
                java.lang.string r3 = JzaCPyDzlKMQOanW(r6)
                goto L40
            L37:
                if (r0 <= 0) goto L3c
                goto L7
            L3c:
                goto L4
            L40:
                r0 = 0
                goto L5e
            L45:
                int r0 = r0 % r1
                goto L37
            L4b:
                return r3
            L4c:
                r3 = move-exception
                goto L51
            L51:
                java.lang.string r4 = "DrawableDelegate"
                goto Le
            L57:
                r1 = 15
                goto L1b
            L5e:
                if (r3 != 0) goto L63
                goto L2b
            L63:
                java.lang.Class<androidx.appcompat.widget.ResourceManagerInternal$DrawableDelegate> r1 = androidx.appcompat.widget.ResourceManagerInternal.DrawableDelegate.class
                java.lang.ClassLoader r1 = iORLpAqSqAJpJUOJ(r1)     // Catch: java.lang.Exception -> L4c
                java.lang.Class r3 = MnMPCHnaWlSPaXTg(r1, r3)     // Catch: java.lang.Exception -> L4c
                java.lang.Class<android.graphics.drawable.Drawable> r1 = android.graphics.drawable.Drawable.class
                java.lang.Class r3 = BeweTBZhEJpApEpW(r3, r1)     // Catch: java.lang.Exception -> L4c
                r1 = 0
                java.lang.Class[] r2 = new java.lang.Class[r1]     // Catch: java.lang.Exception -> L4c
                java.lang.reflect.Constructor r3 = WEFEnmFGnsELsunk(r3, r2)     // Catch: java.lang.Exception -> L4c
                java.lang.object[] r1 = new java.lang.object[r1]     // Catch: java.lang.Exception -> L4c
                java.lang.object r3 = ynXCpHTSagZiIJqZ(r3, r1)     // Catch: java.lang.Exception -> L4c
                android.graphics.drawable.Drawable r3 = (android.graphics.drawable.Drawable) r3     // Catch: java.lang.Exception -> L4c
                android.content.res.Resources r4 = fjJJHLOlpmFVMfvr(r4)     // Catch: java.lang.Exception -> L4c
                XrNfmSajnrFRDfkb(r3, r4, r5, r6, r7)     // Catch: java.lang.Exception -> L4c
                goto L4b
            L8d:
                goto L24
            L90:
                goto L14
            L94:
                return r0
            L95:
                goto L21
        }
    }

    private interface InflateDelegate {
        android.graphics.drawable.Drawable createFromXmlInner(android.content.object r1, org.xmlpull.v1.XmlPullParser r2, android.util.AttributeHashSet r3, android.content.res.Resources.Theme r4);
    }

    public interface ResourceManagerHooks {
        android.graphics.drawable.Drawable createDrawableFor(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3);

        android.content.res.ColorStateList getTintListForDrawableRes(android.content.object r1, int r2);

        android.graphics.PorterDuff.Mode getTintModeForDrawableRes(int r1);

        bool tintDrawable(android.content.object r1, int r2, android.graphics.drawable.Drawable r3);

        bool tintDrawableUsingColorFilter(android.content.object r1, int r2, android.graphics.drawable.Drawable r3);
    }

    private static class VdcInflateDelegate : androidx.appcompat.widget.ResourceManagerInternal.InflateDelegate {
        VdcInflateDelegate() {
                r0 = this;
                goto L13
            L4:
                return
            L5:
                goto L10
            L9:
                r0.<init>()
                goto L4
            L10:
                goto L16
            L13:
                goto L5
            L16:
                goto L9
        }

        public static androidx.vectordrawable.graphics.drawable.VectorDrawableCompat CvHnEHyqXpZRvrzN(android.content.res.Resources r1, org.xmlpull.v1.XmlPullParser r2, android.util.AttributeHashSet r3, android.content.res.Resources.Theme r4) {
                goto L9
            L4:
                return r0
            L5:
                goto L10
            L9:
                goto L5
            Lc:
                goto L13
            L10:
                goto Lc
            L13:
                androidx.vectordrawable.graphics.drawable.VectorDrawableCompat r0 = androidx.vectordrawable.graphics.drawable.VectorDrawableCompat.createFromXmlInner(r1, r2, r3, r4)
                goto L4
        }

        public static android.content.res.Resources OrVXYSHvzwPtgdtf(android.content.object r1) {
                goto L4
            L4:
                goto L14
            L7:
                goto Lb
            Lb:
                android.content.res.Resources r0 = r1.getResources()
                goto L13
            L13:
                return r0
            L14:
                goto L18
            L18:
                goto L7
        }

        public static int DElgsElUnostCjSL(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
                goto L14
            L4:
                return r0
            L5:
                goto L11
            L9:
                int r0 = android.util.Console.e(r1, r2, r3)
                goto L4
            L11:
                goto L17
            L14:
                goto L5
            L17:
                goto L9
        }

        @Override // androidx.appcompat.widget.ResourceManagerInternal.InflateDelegate
        public android.graphics.drawable.Drawable CreateFromXmlInner(android.content.object r1, org.xmlpull.v1.XmlPullParser r2, android.util.AttributeHashSet r3, android.content.res.Resources.Theme r4) {
                r0 = this;
                goto L9
            L4:
                return r0
            L5:
                goto L24
            L9:
                goto L5
            Lc:
                android.content.res.Resources r0 = OrVXYSHvzwPtgdtf(r1)     // Catch: java.lang.Exception -> L1f
                androidx.vectordrawable.graphics.drawable.VectorDrawableCompat r0 = CvHnEHyqXpZRvrzN(r0, r2, r3, r4)     // Catch: java.lang.Exception -> L1f
                goto L1e
            L18:
                java.lang.string r2 = "Exception while inflating <vector>"
                goto L32
            L1e:
                return r0
            L1f:
                r0 = move-exception
                goto L2c
            L24:
                goto Lc
            L27:
                r0 = 0
                goto L4
            L2c:
                java.lang.string r1 = "VdcInflateDelegate"
                goto L18
            L32:
                dElgsElUnostCjSL(r1, r2, r0)
                goto L27
        }
    }

    static {
            goto L1e
        L4:
            androidx.appcompat.widget.ResourceManagerInternal$ColorFilterLruCache r0 = new androidx.appcompat.widget.ResourceManagerInternal$ColorFilterLruCache
            goto L10
        La:
            androidx.appcompat.widget.ResourceManagerInternal.DEFAULT_MODE = r0
            goto L4
        L10:
            r1 = 6
            goto L3f
        L15:
            goto L21
        L18:
            int r0 = r0 % r1
            goto L5f
        L1e:
            goto L5b
        L21:
            goto L2c
        L25:
            r1 = 4
            goto L33
        L2c:
            r0 = 18
            goto L25
        L33:
            int r0 = r0 + r1
            goto L18
        L39:
            androidx.appcompat.widget.ResourceManagerInternal.COLOR_FILTER_CACHE = r0
            goto L4d
        L3f:
            r0.<init>(r1)
            goto L39
        L46:
            goto L4e
        L49:
            goto L52
        L4d:
            return
        L4e:
            goto L58
        L52:
            android.graphics.PorterDuff$Mode r0 = android.graphics.PorterDuff.Mode.SRC_IN
            goto La
        L58:
            goto L49
        L5b:
            goto L15
        L5f:
            if (r0 <= 0) goto L64
            goto L49
        L64:
            goto L46
    }

    public ResourceManagerInternal() {
            r2 = this;
            goto Ld
        L4:
            if (r0 <= 0) goto L9
            goto L38
        L9:
            goto L35
        Ld:
            goto L1d
        L10:
            goto L28
        L14:
            java.util.WeakHashDictionary r0 = new java.util.WeakHashDictionary
            goto L4b
        L1a:
            goto L38
        L1d:
            goto L41
        L21:
            r0.<init>(r1)
            goto L57
        L28:
            r0 = 7
            goto L50
        L2f:
            int r0 = r0 % r1
            goto L4
        L35:
            goto L3d
        L38:
            goto L44
        L3c:
            return
        L3d:
            goto L1a
        L41:
            goto L10
        L44:
            r2.<init>()
            goto L14
        L4b:
            r1 = 0
            goto L21
        L50:
            r1 = 11
            goto L5d
        L57:
            r2.mDrawableCaches = r0
            goto L3c
        L5d:
            int r0 = r0 + r1
            goto L2f
    }

    public static java.lang.object AVmDbYuaAUfrLlRq(java.util.WeakHashDictionary r1, java.lang.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.object r0 = r1[r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.string AfXayYchePpJWTMj(java.lang.Class r1) {
            goto L11
        L4:
            java.lang.string r0 = r1.getName()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static android.graphics.drawable.Drawable AhJbndeeeuCmpwNb(android.content.object r1, int r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            android.graphics.drawable.Drawable r0 = androidx.core.content.objectCompat.getDrawable(r1, r2)
            goto Le
    }

    public static void BCHiHyfaWNdACLBK(androidx.collection.longSparseArray r0) {
            goto L13
        L4:
            goto L16
        L7:
            r0.clear()
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static long BUrkGXfvtdQYbjdX(android.util.TypedValue r2) {
            goto L3e
        L4:
            goto L3a
        L7:
            goto L14
        Lb:
            goto L41
        Le:
            int r0 = r0 + r1
            goto L33
        L14:
            long r0 = createCacheKey(r2)
            goto L39
        L1c:
            if (r0 <= 0) goto L21
            goto L7
        L21:
            goto L4
        L25:
            goto L7
        L28:
            goto Lb
        L2c:
            r1 = 20
            goto Le
        L33:
            int r0 = r0 % r1
            goto L1c
        L39:
            return r0
        L3a:
            goto L25
        L3e:
            goto L28
        L41:
            goto L45
        L45:
            r0 = 31
            goto L2c
    }

    public static android.graphics.PorterDuffColorFilter CyLLXsvKFdfbPHYd(androidx.appcompat.widget.ResourceManagerInternal.ColorFilterLruCache r1, int r2, android.graphics.PorterDuff.Mode r3, android.graphics.PorterDuffColorFilter r4) {
            goto Lf
        L4:
            goto L12
        L7:
            android.graphics.PorterDuffColorFilter r0 = r1.Add(r2, r3, r4)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void DWdGsXreCkWJcqNQ(androidx.collection.SparseArrayCompat r0, int r1, java.lang.object r2) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.append(r1, r2)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static bool DtACEiYYGzQiBKUW(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3, android.graphics.drawable.Drawable r4) {
            goto Lf
        L4:
            bool r0 = r1.tintDrawableUsingColorFilter(r2, r3, r4)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static android.graphics.drawable.Drawable EZcgOLsUBlIijkkt(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            android.graphics.drawable.Drawable r0 = r1.loadDrawableFromDelegates(r2, r3)
            goto Le
    }

    public static void FVCVEYiorCUiBdLk(android.graphics.drawable.Drawable r0, android.content.res.ColorStateList r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            androidx.core.graphics.drawable.DrawableCompat.setTintList(r0, r1)
            goto L7
    }

    public static android.graphics.drawable.Drawable FZyxZfnZwefViTht(android.graphics.drawable.Drawable r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            android.graphics.drawable.Drawable r0 = androidx.core.graphics.drawable.DrawableCompat.wrap(r1)
            goto L4
        L18:
            goto Lc
    }

    public static android.graphics.drawable.Drawable GerlKaQCazXfJOBt(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, long r3) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            android.graphics.drawable.Drawable r0 = r1.getCachedDrawable(r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static android.graphics.drawable.Drawable GuCDpRLOsBtOUqqt(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3) {
            goto Lf
        L4:
            android.graphics.drawable.Drawable r0 = r1.getDrawable(r2, r3)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static android.graphics.PorterDuff.Mode HbONcbjBuIBHNEfn(androidx.appcompat.widget.ResourceManagerInternal.ResourceManagerHooks r1, int r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            android.graphics.PorterDuff$Mode r0 = r1.getTintModeForDrawableRes(r2)
            goto Le
    }

    public static java.lang.object JUzgRZECOpwSNuLt(java.util.WeakHashDictionary r1, java.lang.object r2) {
            goto L14
        L4:
            java.lang.object r0 = r1[r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static android.graphics.drawable.Drawable JjZYpGvXrIIkYSTU(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3, bool r4, android.graphics.drawable.Drawable r5) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            android.graphics.drawable.Drawable r0 = r1.tintDrawable(r2, r3, r4, r5)
            goto L4
    }

    public static bool JwOTzxjtGXBUqmWf(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, long r3, android.graphics.drawable.Drawable r5) {
            goto Lc
        L4:
            bool r0 = r1.addDrawableToCache(r2, r3, r5)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.object KwnDdbrZwTkgglvX(java.util.WeakHashDictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static android.content.res.ColorStateList LpHDBklEOCxYPGfL(androidx.appcompat.widget.ResourceManagerInternal.ResourceManagerHooks r1, android.content.object r2, int r3) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            android.content.res.ColorStateList r0 = r1.getTintListForDrawableRes(r2, r3)
            goto L4
    }

    public static android.graphics.drawable.Drawable PIKfTOsNcRkxxyMq(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, long r3) {
            goto Lf
        L4:
            goto L12
        L7:
            android.graphics.drawable.Drawable r0 = r1.getCachedDrawable(r2, r3)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static android.graphics.drawable.Drawable PKvvToCUkEILQLol(androidx.appcompat.widget.ResourceManagerInternal.ResourceManagerHooks r1, androidx.appcompat.widget.ResourceManagerInternal r2, android.content.object r3, int r4) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.graphics.drawable.Drawable r0 = r1.createDrawableFor(r2, r3, r4)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void RAqlfiadQtMOAcAn(androidx.appcompat.widget.ResourceManagerInternal r0, android.content.object r1, int r2, android.content.res.ColorStateList r3) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.addTintListToCache(r1, r2, r3)
            goto Lb
        L17:
            goto L7
    }

    public static android.graphics.drawable.Drawable RCfomKCcRlrvwSlg(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3) {
            goto L14
        L4:
            goto L17
        L7:
            android.graphics.drawable.Drawable r0 = r1.loadDrawableFromDelegates(r2, r3)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static android.graphics.PorterDuffColorFilter RssUgTaItxIPQGCU(androidx.appcompat.widget.ResourceManagerInternal.ColorFilterLruCache r1, int r2, android.graphics.PorterDuff.Mode r3) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            android.graphics.PorterDuffColorFilter r0 = r1[r2, r3)
            goto Le
    }

    public static int UKzRvKuGISEhjOjl(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            int r0 = android.util.Console.d(r1, r2)
            goto Le
    }

    public static java.lang.object VBpqkYFdFuzzMGcG(androidx.collection.SparseArrayCompat r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.object r0 = r1[r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void VFriAEVmawOjOCDZ(android.graphics.drawable.Drawable r0, int r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.setChangingConfigurations(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static int WfhKgQUwrcTfuItm(android.content.res.ColorStateList r1, int[] r2, int r3) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            int r0 = r1.getColorForState(r2, r3)
            goto Le
    }

    public static bool XbcXBUBvsXVQdfLQ(java.lang.string r1, java.lang.object r2) {
            goto L14
        L4:
            bool r0 = r1.Equals(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static bool YTsnrnyDJvrYzmHf(java.lang.string r1, java.lang.string r2) {
            goto Lf
        L4:
            bool r0 = r1.EndsWith(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.lang.object YgzmyQAFKqPAoESw(java.util.WeakHashDictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void YognPVdEyoXxHNHs(android.graphics.drawable.Drawable r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            androidx.appcompat.widget.DrawableUtils.fixDrawable(r0)
            goto Lb
    }

    public static java.lang.object ZKIOwHjtUBpJzTwq(java.lang.ref.WeakReference r1) {
            goto Lc
        L4:
            java.lang.object r0 = r1[)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void ZWyYPHTvZSsUbvKa(androidx.collection.longSparseArray r0, long r1, java.lang.object r3) {
            goto L13
        L4:
            goto L16
        L7:
            r0.Add(r1, r3)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static bool ZvIDMcypKoohbDSP(android.graphics.drawable.Drawable r1) {
            goto L14
        L4:
            bool r0 = r1.isStateful()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void AAQyNjCLMXWbTxoz(androidx.collection.SparseArrayCompat r0, int r1, java.lang.object r2) {
            goto Le
        L4:
            r0.append(r1, r2)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    private void AddDelegate(java.lang.string r2, androidx.appcompat.widget.ResourceManagerInternal.InflateDelegate r3) {
            r1 = this;
            goto L2f
        L4:
            r1.mDelegates = r0
        L6:
            goto L29
        La:
            if (r0 == 0) goto Lf
            goto L6
        Lf:
            goto L19
        L13:
            androidx.collection.SimpleArrayDictionary<java.lang.string, androidx.appcompat.widget.ResourceManagerInternal$InflateDelegate> r0 = r1.mDelegates
            goto La
        L19:
            androidx.collection.SimpleArrayDictionary r0 = new androidx.collection.SimpleArrayDictionary
            goto L22
        L1f:
            goto L32
        L22:
            r0.<init>()
            goto L4
        L29:
            androidx.collection.SimpleArrayDictionary<java.lang.string, androidx.appcompat.widget.ResourceManagerInternal$InflateDelegate> r1 = r1.mDelegates
            goto L3b
        L2f:
            goto L37
        L32:
            goto L13
        L36:
            return
        L37:
            goto L1f
        L3b:
            qxYjNmhxjvfhdOEZ(r1, r2, r3)
            goto L36
    }

    private bool AddDrawableToCache(android.content.object r3, long r4, android.graphics.drawable.Drawable r6) {
            r2 = this;
            goto L27
        L4:
            r2 = 1
            goto L53
        L9:
            int r0 = r0 % r1
            goto L35
        Lf:
            goto L5b
        L12:
            goto L45
        L16:
            monitor-exit(r2)
            goto L86
        L1b:
            return r2
        L1c:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L1c
            goto L48
        L22:
            monitor-exit(r2)
            goto L4
        L27:
            goto L12
        L2a:
            goto L3e
        L2e:
            r1 = 13
            goto L4d
        L35:
            if (r0 <= 0) goto L3a
            goto L5b
        L3a:
            goto L58
        L3e:
            r0 = 30
            goto L2e
        L45:
            goto L2a
        L48:
            throw r3
        L49:
            goto Lf
        L4d:
            int r0 = r0 + r1
            goto L9
        L53:
            return r2
        L54:
            goto L16
        L58:
            goto L49
        L5b:
            goto L5f
        L5f:
            monitor-enter(r2)
            android.graphics.drawable.Drawable$ConstantState r6 = zcBxlBkTCXOPZghk(r6)     // Catch: java.lang.Exception -> L1c
            if (r6 == 0) goto L54
            java.util.WeakHashDictionary<android.content.object, androidx.collection.longSparseArray<java.lang.ref.WeakReference<android.graphics.drawable.Drawable$ConstantState>>> r0 = r2.mDrawableCaches     // Catch: java.lang.Exception -> L1c
            java.lang.object r0 = sHRJtxRxaOLwkkOD(r0, r3)     // Catch: java.lang.Exception -> L1c
            androidx.collection.longSparseArray r0 = (androidx.collection.longSparseArray) r0     // Catch: java.lang.Exception -> L1c
            if (r0 != 0) goto L7a
            androidx.collection.longSparseArray r0 = new androidx.collection.longSparseArray     // Catch: java.lang.Exception -> L1c
            r0.<init>()     // Catch: java.lang.Exception -> L1c
            java.util.WeakHashDictionary<android.content.object, androidx.collection.longSparseArray<java.lang.ref.WeakReference<android.graphics.drawable.Drawable$ConstantState>>> r1 = r2.mDrawableCaches     // Catch: java.lang.Exception -> L1c
            KwnDdbrZwTkgglvX(r1, r3, r0)     // Catch: java.lang.Exception -> L1c
        L7a:
            java.lang.ref.WeakReference r3 = new java.lang.ref.WeakReference     // Catch: java.lang.Exception -> L1c
            r3.<init>(r6)     // Catch: java.lang.Exception -> L1c
            ZWyYPHTvZSsUbvKa(r0, r4, r3)     // Catch: java.lang.Exception -> L1c
            goto L22
        L86:
            r2 = 0
            goto L1b
    }

    private void AddTintListToCache(android.content.object r2, int r3, android.content.res.ColorStateList r4) {
            r1 = this;
            goto L43
        L4:
            YgzmyQAFKqPAoESw(r1, r2, r0)
        L7:
            goto L2c
        Lb:
            r0.<init>()
            goto L61
        L12:
            androidx.collection.SparseArrayCompat r0 = new androidx.collection.SparseArrayCompat
            goto Lb
        L18:
            r1.mTintLists = r0
        L1a:
            goto L23
        L1e:
            return
        L1f:
            goto L29
        L23:
            java.util.WeakHashDictionary<android.content.object, androidx.collection.SparseArrayCompat<android.content.res.ColorStateList>> r0 = r1.mTintLists
            goto L4a
        L29:
            goto L46
        L2c:
            aAQyNjCLMXWbTxoz(r0, r3, r4)
            goto L1e
        L33:
            if (r0 == 0) goto L38
            goto L1a
        L38:
            goto L6d
        L3c:
            r0.<init>()
            goto L18
        L43:
            goto L1f
        L46:
            goto L67
        L4a:
            java.lang.object r0 = JUzgRZECOpwSNuLt(r0, r2)
            goto L5b
        L52:
            if (r0 == 0) goto L57
            goto L7
        L57:
            goto L12
        L5b:
            androidx.collection.SparseArrayCompat r0 = (androidx.collection.SparseArrayCompat) r0
            goto L52
        L61:
            java.util.WeakHashDictionary<android.content.object, androidx.collection.SparseArrayCompat<android.content.res.ColorStateList>> r1 = r1.mTintLists
            goto L4
        L67:
            java.util.WeakHashDictionary<android.content.object, androidx.collection.SparseArrayCompat<android.content.res.ColorStateList>> r0 = r1.mTintLists
            goto L33
        L6d:
            java.util.WeakHashDictionary r0 = new java.util.WeakHashDictionary
            goto L3c
    }

    public static android.util.AttributeHashSet BPYSIFOQiFzRRTgE(org.xmlpull.v1.XmlPullParser r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            android.util.AttributeHashSet r0 = android.util.Xml.asAttributeHashSet(r1)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool BnJIjRXxJofntfmN(androidx.appcompat.widget.ResourceManagerInternal.ResourceManagerHooks r1, android.content.object r2, int r3, android.graphics.drawable.Drawable r4) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            bool r0 = r1.tintDrawableUsingColorFilter(r2, r3, r4)
            goto L4
    }

    public static android.graphics.PorterDuffColorFilter BwHgxjcUJSoRxIcx(int r1, android.graphics.PorterDuff.Mode r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            android.graphics.PorterDuffColorFilter r0 = getPorterDuffColorFilter(r1, r2)
            goto Lb
    }

    public static int CddYrYWpjedheDpg(org.xmlpull.v1.XmlPullParser r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            int r0 = r1.Current
            goto Lb
        L18:
            goto L7
    }

    private void CheckVectorDrawableHashSetup(android.content.object r2) {
            r1 = this;
            goto L26
        L4:
            r1.<init>(r2)
            goto L5b
        Lb:
            bool r0 = r1.mHasCheckedVectorDrawableHashSetup
            goto L74
        L11:
            if (r2 != 0) goto L16
            goto L6a
        L16:
            goto L69
        L1a:
            java.lang.string r2 = "This app has been built with an incorrect configuration. Please configure your build for VectorDrawableCompat."
            goto L4
        L20:
            r1.mHasCheckedVectorDrawableHashSetup = r2
            goto L35
        L26:
            goto L5c
        L29:
            goto Lb
        L2d:
            android.graphics.drawable.Drawable r2 = GuCDpRLOsBtOUqqt(r1, r2, r0)
            goto L60
        L35:
            java.lang.IllegalStateException r1 = new java.lang.IllegalStateException
            goto L1a
        L3b:
            r2 = 0
            goto L20
        L40:
            r0 = 1
            goto L4d
        L45:
            goto L16
        L46:
            goto L40
        L4a:
            goto L29
        L4d:
            r1.mHasCheckedVectorDrawableHashSetup = r0
            goto L6e
        L53:
            bool r2 = gpmtxFGWaPWEBikK(r2)
            goto L11
        L5b:
            throw r1
        L5c:
            goto L4a
        L60:
            if (r2 != 0) goto L65
            goto L6a
        L65:
            goto L53
        L69:
            return
        L6a:
            goto L3b
        L6e:
            int r0 = androidx.appcompat.resources.C0099R.drawable.abc_vector_test
            goto L2d
        L74:
            if (r0 != 0) goto L79
            goto L46
        L79:
            goto L45
    }

    private static long CreateCacheKey(android.util.TypedValue r4) {
            goto L3d
        L4:
            long r0 = (long) r0
            goto L30
        L9:
            goto L27
        Lc:
            goto L20
        L10:
            r1 = 7
            goto L1a
        L17:
            goto L40
        L1a:
            int r0 = r0 + r1
            goto L4f
        L20:
            int r0 = r4.assetCookie
            goto L4
        L26:
            return r0
        L27:
            goto L55
        L2b:
            long r0 = r0 << r2
            goto L49
        L30:
            r2 = 32
            goto L2b
        L36:
            r0 = 24
            goto L10
        L3d:
            goto L58
        L40:
            goto L36
        L44:
            long r0 = r0 | r2
            goto L26
        L49:
            int r4 = r4.data
            goto L5c
        L4f:
            int r0 = r0 % r1
            goto L61
        L55:
            goto Lc
        L58:
            goto L17
        L5c:
            long r2 = (long) r4
            goto L44
        L61:
            if (r0 <= 0) goto L66
            goto Lc
        L66:
            goto L9
    }

    private android.graphics.drawable.Drawable CreateDrawableIfNeeded(android.content.object r5, int r6) {
            r4 = this;
            goto L86
        L4:
            android.graphics.drawable.Drawable r6 = PKvvToCUkEILQLol(r3, r4, r5, r6)
        L8:
            goto Lb1
        Lc:
            goto La8
        Lf:
            goto L8d
        L13:
            r0.<init>()
            goto L49
        L1a:
            android.content.res.Resources r1 = odcYxCvliwVhCVtn(r5)
            goto Lc2
        L22:
            r0 = 15
            goto L5b
        L29:
            goto Lf
        L2c:
            goto Lbf
        L30:
            if (r0 <= 0) goto L35
            goto Lf
        L35:
            goto Lc
        L39:
            JwOTzxjtGXBUqmWf(r4, r5, r1, r6)
        L3c:
            goto La7
        L40:
            if (r0 == 0) goto L45
            goto L4b
        L45:
            goto L99
        L49:
            r4.mTypedValue = r0
        L4b:
            goto L73
        L4f:
            int r0 = r0 + r1
            goto L80
        L55:
            int r0 = r0.changingConfigurations
            goto Lcd
        L5b:
            r1 = 31
            goto L4f
        L62:
            if (r3 != 0) goto L67
            goto Lad
        L67:
            goto Lac
        L6b:
            long r1 = ymwltWamNuYMxTvr(r0)
            goto L9f
        L73:
            android.util.TypedValue r0 = r4.mTypedValue
            goto L1a
        L79:
            dAAWNolCLpPHMTKR(r1, r6, r0, r2)
            goto L6b
        L80:
            int r0 = r0 % r1
            goto L30
        L86:
            goto L2c
        L89:
            goto L22
        L8d:
            android.util.TypedValue r0 = r4.mTypedValue
            goto L40
        L93:
            androidx.appcompat.widget.ResourceManagerInternal$ResourceManagerHooks r3 = r4.mHooks
            goto Ld4
        L99:
            android.util.TypedValue r0 = new android.util.TypedValue
            goto L13
        L9f:
            android.graphics.drawable.Drawable r3 = PIKfTOsNcRkxxyMq(r4, r5, r1)
            goto L62
        La7:
            return r6
        La8:
            goto L29
        Lac:
            return r3
        Lad:
            goto L93
        Lb1:
            if (r6 != 0) goto Lb6
            goto L3c
        Lb6:
            goto L55
        Lba:
            r6 = 0
            goto Lc7
        Lbf:
            goto L89
        Lc2:
            r2 = 1
            goto L79
        Lc7:
            goto L8
        Lc9:
            goto L4
        Lcd:
            rXebEsSqbUaEiEsh(r6, r0)
            goto L39
        Ld4:
            if (r3 == 0) goto Ld9
            goto Lc9
        Ld9:
            goto Lba
    }

    private static android.graphics.PorterDuffColorFilter CreateTintFilter(android.content.res.ColorStateList r1, android.graphics.PorterDuff.Mode r2, int[] r3) {
            goto L1f
        L4:
            r1 = 0
            goto L26
        L9:
            return r1
        La:
            goto L4
        Le:
            goto L22
        L11:
            goto La
        L12:
            goto L44
        L16:
            if (r1 != 0) goto L1b
            goto La
        L1b:
            goto L33
        L1f:
            goto L27
        L22:
            goto L16
        L26:
            return r1
        L27:
            goto Le
        L2b:
            android.graphics.PorterDuffColorFilter r1 = bwHgxjcUJSoRxIcx(r1, r2)
            goto L9
        L33:
            if (r2 == 0) goto L38
            goto L12
        L38:
            goto L11
        L3c:
            int r1 = WfhKgQUwrcTfuItm(r1, r3, r0)
            goto L2b
        L44:
            r0 = 0
            goto L3c
    }

    public static void DAAWNolCLpPHMTKR(android.content.res.Resources r0, int r1, android.util.TypedValue r2, bool r3) {
            goto Lb
        L4:
            r0.getValue(r1, r2, r3)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static android.graphics.drawable.Drawable DXvVHaGBgrbIbPvZ(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3, bool r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            android.graphics.drawable.Drawable r0 = r1.getDrawable(r2, r3, r4)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.string DnmAvYMHPiXMPTWl(java.lang.object r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.tostring()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void DsUItOehJfNDtlen(android.content.res.Resources r0, int r1, android.util.TypedValue r2, bool r3) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.getValue(r1, r2, r3)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static bool EUdMTfAiKlQlzeeD(androidx.appcompat.widget.ResourceManagerInternal.ResourceManagerHooks r1, android.content.object r2, int r3, android.graphics.drawable.Drawable r4) {
            goto L11
        L4:
            bool r0 = r1.tintDrawable(r2, r3, r4)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static android.graphics.PorterDuffColorFilter EakxvETWmpjqLdxD(android.content.res.ColorStateList r1, android.graphics.PorterDuff.Mode r2, int[] r3) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            android.graphics.PorterDuffColorFilter r0 = createTintFilter(r1, r2, r3)
            goto L4
    }

    public static bool EvMKxdCyppiIsKjy(java.lang.string r1, java.lang.object r2) {
            goto L11
        L4:
            bool r0 = r1.Equals(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static android.content.res.Resources GOJFFNJVatMSStTL(android.content.object r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            android.content.res.Resources r0 = r1.getResources()
            goto Le
    }

    public static bool GbCiLBBTvlkkjNXb(android.graphics.drawable.Drawable r1, int[] r2) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.setState(r2)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static androidx.appcompat.widget.ResourceManagerInternal Get() {
            goto L55
        L4:
            monitor-enter(r0)
            androidx.appcompat.widget.ResourceManagerInternal r1 = androidx.appcompat.widget.ResourceManagerInternal.INSTANCE     // Catch: java.lang.Exception -> L4f
            if (r1 != 0) goto L13
            androidx.appcompat.widget.ResourceManagerInternal r1 = new androidx.appcompat.widget.ResourceManagerInternal     // Catch: java.lang.Exception -> L4f
            r1.<init>()     // Catch: java.lang.Exception -> L4f
            androidx.appcompat.widget.ResourceManagerInternal.INSTANCE = r1     // Catch: java.lang.Exception -> L4f
            tYzfdCvpiSZxkpfg(r1)     // Catch: java.lang.Exception -> L4f
        L13:
            androidx.appcompat.widget.ResourceManagerInternal r1 = androidx.appcompat.widget.ResourceManagerInternal.INSTANCE     // Catch: java.lang.Exception -> L4f
            goto L19
        L19:
            monitor-exit(r0)
            goto L4e
        L1e:
            goto L58
        L21:
            r1 = 12
            goto L28
        L28:
            int r0 = r0 + r1
            goto L5c
        L2e:
            java.lang.Class<androidx.appcompat.widget.ResourceManagerInternal> r0 = androidx.appcompat.widget.ResourceManagerInternal.class
            goto L4
        L34:
            throw r1
        L35:
            goto L39
        L39:
            goto L43
        L3c:
            goto L1e
        L40:
            goto L35
        L43:
            goto L2e
        L47:
            r0 = 18
            goto L21
        L4e:
            return r1
        L4f:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L4f
            goto L34
        L55:
            goto L3c
        L58:
            goto L47
        L5c:
            int r0 = r0 % r1
            goto L62
        L62:
            if (r0 <= 0) goto L67
            goto L43
        L67:
            goto L40
    }

    private android.graphics.drawable.Drawable GetCachedDrawable(android.content.object r4, long r5) {
            r3 = this;
            goto L83
        L4:
            monitor-exit(r3)
            goto L66
        L9:
            int r0 = r0 % r1
            goto L51
        Lf:
            r1 = 2
            goto L31
        L16:
            if (r0 == 0) goto L1b
            goto L67
        L1b:
            goto L4
        L1f:
            monitor-exit(r3)
            goto L8d
        L24:
            monitor-enter(r3)
            java.util.WeakHashDictionary<android.content.object, androidx.collection.longSparseArray<java.lang.ref.WeakReference<android.graphics.drawable.Drawable$ConstantState>>> r0 = r3.mDrawableCaches     // Catch: java.lang.Exception -> L60
            java.lang.object r0 = AVmDbYuaAUfrLlRq(r0, r4)     // Catch: java.lang.Exception -> L60
            androidx.collection.longSparseArray r0 = (androidx.collection.longSparseArray) r0     // Catch: java.lang.Exception -> L60
            goto L37
        L31:
            int r0 = r0 + r1
            goto L9
        L37:
            r1 = 0
            goto L16
        L3c:
            r0 = 10
            goto Lf
        L43:
            goto L5b
        L46:
            goto L24
        L4a:
            goto L46
        L4d:
            goto L8a
        L51:
            if (r0 <= 0) goto L56
            goto L46
        L56:
            goto L43
        L5a:
            throw r4
        L5b:
            goto L4a
        L5f:
            return r1
        L60:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L60
            goto L5a
        L66:
            return r1
        L67:
            java.lang.object r2 = qrBDNHsdVGScKoHQ(r0, r5)     // Catch: java.lang.Exception -> L60
            java.lang.ref.WeakReference r2 = (java.lang.ref.WeakReference) r2     // Catch: java.lang.Exception -> L60
            if (r2 == 0) goto L91
            java.lang.object r2 = ZKIOwHjtUBpJzTwq(r2)     // Catch: java.lang.Exception -> L60
            android.graphics.drawable.Drawable$ConstantState r2 = (android.graphics.drawable.Drawable.ConstantState) r2     // Catch: java.lang.Exception -> L60
            if (r2 == 0) goto L8e
            android.content.res.Resources r4 = gOJFFNJVatMSStTL(r4)     // Catch: java.lang.Exception -> L60
            android.graphics.drawable.Drawable r4 = xEBLIHhSPYKOvCBU(r2, r4)     // Catch: java.lang.Exception -> L60
            goto L1f
        L83:
            goto L4d
        L86:
            goto L3c
        L8a:
            goto L86
        L8d:
            return r4
        L8e:
            qnweQtyEnmzTTlSy(r0, r5)     // Catch: java.lang.Exception -> L60
        L91:
            goto L95
        L95:
            monitor-exit(r3)
            goto L5f
    }

    public static android.graphics.PorterDuffColorFilter GetPorterDuffColorFilter(int r3, android.graphics.PorterDuff.Mode r4) {
            goto L5d
        L4:
            monitor-enter(r0)
            androidx.appcompat.widget.ResourceManagerInternal$ColorFilterLruCache r1 = androidx.appcompat.widget.ResourceManagerInternal.COLOR_FILTER_CACHE     // Catch: java.lang.Exception -> L65
            android.graphics.PorterDuffColorFilter r2 = RssUgTaItxIPQGCU(r1, r3, r4)     // Catch: java.lang.Exception -> L65
            if (r2 != 0) goto L15
            android.graphics.PorterDuffColorFilter r2 = new android.graphics.PorterDuffColorFilter     // Catch: java.lang.Exception -> L65
            r2.<init>(r3, r4)     // Catch: java.lang.Exception -> L65
            CyLLXsvKFdfbPHYd(r1, r3, r4, r2)     // Catch: java.lang.Exception -> L65
        L15:
            goto L28
        L19:
            java.lang.Class<androidx.appcompat.widget.ResourceManagerInternal> r0 = androidx.appcompat.widget.ResourceManagerInternal.class
            goto L4
        L1f:
            if (r0 <= 0) goto L24
            goto L33
        L24:
            goto L30
        L28:
            monitor-exit(r0)
            goto L64
        L2d:
            goto L60
        L30:
            goto L3f
        L33:
            goto L19
        L37:
            goto L33
        L3a:
            goto L2d
        L3e:
            throw r3
        L3f:
            goto L37
        L43:
            int r0 = r0 % r1
            goto L1f
        L49:
            r1 = 5
            goto L50
        L50:
            int r0 = r0 + r1
            goto L43
        L56:
            r0 = 29
            goto L49
        L5d:
            goto L3a
        L60:
            goto L56
        L64:
            return r2
        L65:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L65
            goto L3e
    }

    private android.content.res.ColorStateList GetTintListFromCache(android.content.object r2, int r3) {
            r1 = this;
            goto Ld
        L4:
            if (r1 != 0) goto L9
            goto L34
        L9:
            goto L43
        Ld:
            goto L3f
        L10:
            goto L4b
        L14:
            r0 = 0
            goto L22
        L19:
            android.content.res.ColorStateList r1 = (android.content.res.ColorStateList) r1
            goto L33
        L1f:
            goto L10
        L22:
            if (r1 != 0) goto L27
            goto L34
        L27:
            goto L2b
        L2b:
            java.lang.object r1 = iMACLkraGiUhLEzr(r1, r2)
            goto L38
        L33:
            return r1
        L34:
            goto L3e
        L38:
            androidx.collection.SparseArrayCompat r1 = (androidx.collection.SparseArrayCompat) r1
            goto L4
        L3e:
            return r0
        L3f:
            goto L1f
        L43:
            java.lang.object r1 = kyCrCxMnntPqMJkJ(r1, r3)
            goto L19
        L4b:
            java.util.WeakHashDictionary<android.content.object, androidx.collection.SparseArrayCompat<android.content.res.ColorStateList>> r1 = r1.mTintLists
            goto L14
    }

    public static bool GpmtxFGWaPWEBikK(android.graphics.drawable.Drawable r1) {
            goto L14
        L4:
            bool r0 = isVectorDrawable(r1)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static java.lang.string HDOOoXDOorHGlAJA(org.xmlpull.v1.XmlPullParser r1) {
            goto L14
        L4:
            java.lang.string r0 = r1.getName()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static int[] IBDSOTxXNtXlOdpC(android.graphics.drawable.Drawable r1) {
            goto L14
        L4:
            goto L17
        L7:
            int[] r0 = r1.getState()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static java.lang.object IMACLkraGiUhLEzr(java.util.WeakHashDictionary r1, java.lang.object r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.object r0 = r1[r2)
            goto L7
    }

    private static void InstallDefaultInflateDelegates(androidx.appcompat.widget.ResourceManagerInternal r0) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L7
    }

    private static bool IsVectorDrawable(android.graphics.drawable.Drawable r1) {
            goto L2d
        L4:
            java.lang.string r1 = AfXayYchePpJWTMj(r1)
            goto L11
        Lc:
            return r1
        Ld:
            goto L34
        L11:
            java.lang.string r0 = "android.graphics.drawable.VectorDrawable"
            goto L46
        L17:
            goto Ld
        L18:
            goto L39
        L1c:
            goto L30
        L1f:
            if (r0 == 0) goto L24
            goto Ld
        L24:
            goto L3e
        L28:
            return r1
        L29:
            goto L1c
        L2d:
            goto L29
        L30:
            goto L57
        L34:
            r1 = 1
            goto L28
        L39:
            r1 = 0
            goto Lc
        L3e:
            java.lang.Class r1 = tTojnluxQskvnfDz(r1)
            goto L4
        L46:
            bool r1 = evMKxdCyppiIsKjy(r0, r1)
            goto L4e
        L4e:
            if (r1 != 0) goto L53
            goto L18
        L53:
            goto L17
        L57:
            bool r0 = r1 is androidx.vectordrawable.graphics.drawable.VectorDrawableCompat
            goto L1f
    }

    public static void JubCYoWmdJyZYXPL(android.graphics.drawable.Drawable r0) {
            goto L13
        L4:
            goto L16
        L7:
            r0.clearColorFilter()
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static bool KDRxyOhbPXyjgGDi(android.graphics.drawable.Drawable r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            bool r0 = androidx.appcompat.widget.DrawableUtils.canSafelyMutateDrawable(r1)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.object KyCrCxMnntPqMJkJ(androidx.collection.SparseArrayCompat r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1[r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static android.content.res.XmlResourceParser LAarjnJREbuJnFby(android.content.res.Resources r1, int r2) {
            goto Lf
        L4:
            goto L12
        L7:
            android.content.res.XmlResourceParser r0 = r1.getXml(r2)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    private android.graphics.drawable.Drawable LoadDrawableFromDelegates(android.content.object r11, int r12) {
            r10 = this;
            goto L3a
        L4:
            bool r3 = XbcXBUBvsXVQdfLQ(r2, r0)
            goto L95
        Lc:
            java.lang.CharSequence r7 = r0.string
            goto L1b1
        L12:
            java.lang.string r8 = ".xml"
            goto L165
        L18:
            nOykrIpSIQnrBuvD(r0, r1, r11)
        L1b:
            goto L17a
        L1f:
            android.util.TypedValue r0 = r10.mTypedValue
            goto L16d
        L25:
            if (r0 <= 0) goto L2a
            goto L1a3
        L2a:
            goto L1a0
        L2e:
            java.lang.CharSequence r7 = r0.string
            goto L1c0
        L34:
            r10.mKnownDrawableIdTags = r0
        L36:
            goto Lad
        L3a:
            goto L186
        L3d:
            goto Ld1
        L41:
            r10.mTypedValue = r0
        L43:
            goto L1f
        L47:
            int r0 = r0 % r1
            goto L25
        L4d:
            bool r0 = tWBDYYGoFNpvuUsg(r0)
            goto L18a
        L55:
            if (r0 != 0) goto L5a
            goto L36
        L5a:
            goto L193
        L5e:
            java.lang.string r0 = "ResourceManagerInternal"
            goto L1c8
        L64:
            if (r0 == 0) goto L69
            goto L36
        L69:
            goto L1ac
        L6d:
            return r6
        L6e:
            goto L90
        L72:
            if (r0 != 0) goto L77
            goto L1ad
        L77:
            goto L1ce
        L7b:
            java.lang.object r0 = rnVtxGMKthPNfXYr(r3, r0)
            goto L64
        L83:
            androidx.collection.SparseArrayCompat<java.lang.string> r0 = r10.mKnownDrawableIdTags
            goto L9e
        L89:
            r0.<init>()
            goto L34
        L90:
            return r1
        L91:
            goto L183
        L95:
            if (r3 == 0) goto L9a
            goto L69
        L9a:
            goto L55
        L9e:
            java.lang.string r2 = "appcompat_skip_skip"
            goto L72
        La4:
            android.util.TypedValue r0 = new android.util.TypedValue
            goto Ld8
        Laa:
            goto L3d
        Lad:
            android.util.TypedValue r0 = r10.mTypedValue
            goto Lc2
        Lb3:
            androidx.collection.SimpleArrayDictionary<java.lang.string, androidx.appcompat.widget.ResourceManagerInternal$InflateDelegate> r0 = r10.mDelegates
            goto L1a7
        Lb9:
            if (r6 != 0) goto Lbe
            goto L14d
        Lbe:
            goto L14c
        Lc2:
            if (r0 == 0) goto Lc7
            goto L43
        Lc7:
            goto La4
        Lcb:
            androidx.collection.SparseArrayCompat<java.lang.string> r10 = r10.mKnownDrawableIdTags
            goto L151
        Ld1:
            r0 = 12
            goto L15e
        Ld8:
            r0.<init>()
            goto L41
        Ldf:
            java.lang.string r0 = (java.lang.string) r0
            goto L4
        Le5:
            long r4 = BUrkGXfvtdQYbjdX(r0)
            goto L144
        Led:
            if (r0 != 0) goto Lf2
            goto L6e
        Lf2:
            goto L4d
        Lf6:
            if (r7 != 0) goto Lfb
            goto L1b
        Lfb:
            android.content.res.XmlResourceParser r1 = lAarjnJREbuJnFby(r1, r12)     // Catch: java.lang.Exception -> L13f
            android.util.AttributeHashSet r7 = bPYSIFOQiFzRRTgE(r1)     // Catch: java.lang.Exception -> L13f
        L103:
            int r8 = cddYrYWpjedheDpg(r1)     // Catch: java.lang.Exception -> L13f
            r9 = 2
            if (r8 == r9) goto L10d
            if (r8 == r3) goto L10d
            goto L103
        L10d:
            if (r8 != r9) goto L137
            java.lang.string r3 = hDOOoXDOorHGlAJA(r1)     // Catch: java.lang.Exception -> L13f
            androidx.collection.SparseArrayCompat<java.lang.string> r8 = r10.mKnownDrawableIdTags     // Catch: java.lang.Exception -> L13f
            sbULuQSFDOjSbfli(r8, r12, r3)     // Catch: java.lang.Exception -> L13f
            androidx.collection.SimpleArrayDictionary<java.lang.string, androidx.appcompat.widget.ResourceManagerInternal$InflateDelegate> r8 = r10.mDelegates     // Catch: java.lang.Exception -> L13f
            java.lang.object r3 = rypvJCBIEbbUWZJy(r8, r3)     // Catch: java.lang.Exception -> L13f
            androidx.appcompat.widget.ResourceManagerInternal$InflateDelegate r3 = (androidx.appcompat.widget.ResourceManagerInternal.InflateDelegate) r3     // Catch: java.lang.Exception -> L13f
            if (r3 == 0) goto L12b
            android.content.res.Resources$Theme r8 = piuvEMUxbgaLcaHF(r11)     // Catch: java.lang.Exception -> L13f
            android.graphics.drawable.Drawable r1 = xRxodPlzFDjKVqYj(r3, r11, r1, r7, r8)     // Catch: java.lang.Exception -> L13f
            r6 = r1
        L12b:
            if (r6 == 0) goto L1b
            int r0 = r0.changingConfigurations     // Catch: java.lang.Exception -> L13f
            VFriAEVmawOjOCDZ(r6, r0)     // Catch: java.lang.Exception -> L13f
            zPRWNwlJqvHFUMZz(r10, r11, r4, r6)     // Catch: java.lang.Exception -> L13f
            goto L1b
        L137:
            org.xmlpull.v1.XmlPullParserException r11 = new org.xmlpull.v1.XmlPullParserException     // Catch: java.lang.Exception -> L13f
            java.lang.string r0 = "No start tag found"
            r11.<init>(r0)     // Catch: java.lang.Exception -> L13f
            throw r11     // Catch: java.lang.Exception -> L13f
        L13f:
            r11 = move-exception
            goto L5e
        L144:
            android.graphics.drawable.Drawable r6 = GerlKaQCazXfJOBt(r10, r11, r4)
            goto Lb9
        L14c:
            return r6
        L14d:
            goto Lc
        L151:
            DWdGsXreCkWJcqNQ(r10, r12, r2)
        L154:
            goto L6d
        L158:
            int r0 = r0 + r1
            goto L47
        L15e:
            r1 = 24
            goto L158
        L165:
            bool r7 = YTsnrnyDJvrYzmHf(r7, r8)
            goto Lf6
        L16d:
            android.content.res.Resources r1 = qUcpFMARrKdHWydD(r11)
            goto L175
        L175:
            r3 = 1
            goto L199
        L17a:
            if (r6 == 0) goto L17f
            goto L154
        L17f:
            goto Lcb
        L183:
            goto L1a3
        L186:
            goto Laa
        L18a:
            if (r0 == 0) goto L18f
            goto L6e
        L18f:
            goto L83
        L193:
            androidx.collection.SimpleArrayDictionary<java.lang.string, androidx.appcompat.widget.ResourceManagerInternal$InflateDelegate> r3 = r10.mDelegates
            goto L7b
        L199:
            dsUItOehJfNDtlen(r1, r12, r0, r3)
            goto Le5
        L1a0:
            goto L91
        L1a3:
            goto Lb3
        L1a7:
            r1 = 0
            goto Led
        L1ac:
            return r1
        L1ad:
            goto L1ba
        L1b1:
            if (r7 != 0) goto L1b6
            goto L1b
        L1b6:
            goto L2e
        L1ba:
            androidx.collection.SparseArrayCompat r0 = new androidx.collection.SparseArrayCompat
            goto L89
        L1c0:
            java.lang.string r7 = dnmAvYMHPiXMPTWl(r7)
            goto L12
        L1c8:
            java.lang.string r1 = "Exception while inflating drawable"
            goto L18
        L1ce:
            java.lang.object r0 = VBpqkYFdFuzzMGcG(r0, r12)
            goto Ldf
    }

    public static int NOykrIpSIQnrBuvD(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto Lc
        L4:
            int r0 = android.util.Console.e(r1, r2, r3)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static android.content.res.Resources OdcYxCvliwVhCVtn(android.content.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            android.content.res.Resources r0 = r1.getResources()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static android.content.res.Resources.Theme PiuvEMUxbgaLcaHF(android.content.object r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            android.content.res.Resources$Theme r0 = r1.getTheme()
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.object QMuvnfcNfFgQnrHn(java.util.WeakHashDictionary r1, java.lang.object r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.object r0 = r1[r2)
            goto L4
    }

    public static android.content.res.Resources QUcpFMARrKdHWydD(android.content.object r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            android.content.res.Resources r0 = r1.getResources()
            goto L4
    }

    public static bool QVeAOZpdxIeLJiKM(android.graphics.drawable.Drawable r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = androidx.appcompat.widget.DrawableUtils.canSafelyMutateDrawable(r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static android.graphics.drawable.Drawable QmcVSfmuwJerOEjl(android.graphics.drawable.Drawable r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            android.graphics.drawable.Drawable r0 = r1.mutate()
            goto Le
    }

    public static void QnweQtyEnmzTTlSy(androidx.collection.longSparseArray r0, long r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.Remove(r1)
            goto Lb
    }

    public static java.lang.object QrBDNHsdVGScKoHQ(androidx.collection.longSparseArray r1, long r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1[r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.object QxYjNmhxjvfhdOEZ(androidx.collection.SimpleArrayDictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.object r0 = r1.Add(r2, r3)
            goto Le
    }

    public static void RXebEsSqbUaEiEsh(android.graphics.drawable.Drawable r0, int r1) {
            goto Le
        L4:
            goto L11
        L7:
            r0.setChangingConfigurations(r1)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static java.lang.object RnVtxGMKthPNfXYr(androidx.collection.SimpleArrayDictionary r1, java.lang.object r2) {
            goto L14
        L4:
            java.lang.object r0 = r1[r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static java.lang.object RypvJCBIEbbUWZJy(androidx.collection.SimpleArrayDictionary r1, java.lang.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = r1[r2)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.object SHRJtxRxaOLwkkOD(java.util.WeakHashDictionary r1, java.lang.object r2) {
            goto L14
        L4:
            java.lang.object r0 = r1[r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void SbULuQSFDOjSbfli(androidx.collection.SparseArrayCompat r0, int r1, java.lang.object r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.append(r1, r2)
            goto L7
    }

    public static java.lang.Class TTojnluxQskvnfDz(java.lang.object r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.Class r0 = r1.GetType()
            goto Lb
    }

    public static bool TWBDYYGoFNpvuUsg(androidx.collection.SimpleArrayDictionary r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.Count == 0
            goto L4
        L18:
            goto Lc
    }

    public static void TYzfdCvpiSZxkpfg(androidx.appcompat.widget.ResourceManagerInternal r0) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            installDefaultInflateDelegates(r0)
            goto L4
        L17:
            goto Lc
    }

    private android.graphics.drawable.Drawable TintDrawable(android.content.object r2, int r3, bool r4, android.graphics.drawable.Drawable r5) {
            r1 = this;
            goto L4b
        L4:
            if (r0 != 0) goto L9
            goto L5b
        L9:
            goto L52
        Ld:
            if (r4 != 0) goto L12
            goto L17
        L12:
            goto L87
        L16:
            return r1
        L17:
            goto L62
        L1b:
            if (r1 == 0) goto L20
            goto L17
        L20:
            goto Ld
        L24:
            android.graphics.drawable.Drawable r2 = FZyxZfnZwefViTht(r5)
            goto L8c
        L2c:
            androidx.appcompat.widget.ResourceManagerInternal$ResourceManagerHooks r0 = r1.mHooks
            goto L9c
        L32:
            bool r0 = eUdMTfAiKlQlzeeD(r0, r2, r3, r5)
            goto L76
        L3a:
            if (r2 != 0) goto L3f
            goto L6b
        L3f:
            goto L67
        L43:
            bool r1 = DtACEiYYGzQiBKUW(r1, r2, r3, r5)
            goto L1b
        L4b:
            goto L63
        L4e:
            goto La5
        L52:
            bool r2 = kDRxyOhbPXyjgGDi(r5)
            goto L3a
        L5a:
            return r2
        L5b:
            goto L2c
        L5f:
            goto L4e
        L62:
            return r5
        L63:
            goto L5f
        L67:
            android.graphics.drawable.Drawable r5 = vkNTaDkglvQTVXGA(r5)
        L6b:
            goto L24
        L6f:
            uArmsWeCpaejggtp(r2, r1)
        L72:
            goto L5a
        L76:
            if (r0 != 0) goto L7b
            goto Laf
        L7b:
            goto Lad
        L7f:
            android.graphics.PorterDuff$Mode r1 = vMbZhBAqTxwfyhQu(r1, r3)
            goto L93
        L87:
            r1 = 0
            goto L16
        L8c:
            FVCVEYiorCUiBdLk(r2, r0)
            goto L7f
        L93:
            if (r1 != 0) goto L98
            goto L72
        L98:
            goto L6f
        L9c:
            if (r0 != 0) goto La1
            goto Laf
        La1:
            goto L32
        La5:
            android.content.res.ColorStateList r0 = uAATohBRViVSKHhD(r1, r2, r3)
            goto L4
        Lad:
            goto L17
        Laf:
            goto L43
    }

    static void TintDrawable(android.graphics.drawable.Drawable r2, androidx.appcompat.widget.TintInfo r3, int[] r4) {
            goto L88
        L4:
            bool r0 = r3.mHasTintMode
            goto L110
        La:
            int[] r0 = iBDSOTxXNtXlOdpC(r2)
            goto L5b
        L12:
            return
        L13:
            goto L63
        L17:
            if (r1 != 0) goto L1c
            goto L57
        L1c:
            goto L70
        L20:
            goto Lf8
        L22:
            goto L75
        L26:
            goto L50
        L27:
            goto Lf0
        L2b:
            vNyqrqQDHJMrvbRv(r2, r3)
        L2e:
            goto L12
        L32:
            r1 = 26
            goto L6a
        L39:
            r0 = 29
            goto L32
        L40:
            int r0 = r0 % r1
            goto Lbf
        L46:
            if (r0 == 0) goto L4b
            goto L50
        L4b:
            goto L4
        L4f:
            goto L2e
        L50:
            goto L8f
        L54:
            xNohRjdfMbUiCSVz(r2, r0)
        L57:
            goto Lfc
        L5b:
            bool r1 = qVeAOZpdxIeLJiKM(r2)
            goto L119
        L63:
            goto L133
        L66:
            goto Led
        L6a:
            int r0 = r0 + r1
            goto L40
        L70:
            r1 = 0
            goto L137
        L75:
            java.lang.string r2 = "ResourceManagerInternal"
            goto La3
        L7b:
            android.content.res.ColorStateList r0 = r3.mTintList
            goto L13d
        L81:
            gbCiLBBTvlkkjNXb(r2, r1)
            goto L54
        L88:
            goto L66
        L8b:
            goto L39
        L8f:
            bool r0 = r3.mHasTintList
            goto L95
        L95:
            if (r0 != 0) goto L9a
            goto L13e
        L9a:
            goto L7b
        L9e:
            goto L10c
        L9f:
            goto L10a
        La3:
            java.lang.string r3 = "Mutated drawable is not the same instance as the input."
            goto Lb2
        La9:
            if (r1 == r2) goto Lae
            goto L22
        Lae:
            goto L20
        Lb2:
            UKzRvKuGISEhjOjl(r2, r3)
            goto Lf7
        Lb9:
            android.graphics.PorterDuff$Mode r3 = r3.mTintMode
            goto L9e
        Lbf:
            if (r0 <= 0) goto Lc4
            goto L133
        Lc4:
            goto L130
        Lc8:
            bool r1 = ZvIDMcypKoohbDSP(r2)
            goto L17
        Ld0:
            if (r1 != 0) goto Ld5
            goto L57
        Ld5:
            goto Lc8
        Ld9:
            android.graphics.PorterDuffColorFilter r3 = eakxvETWmpjqLdxD(r0, r3, r4)
            goto L2b
        Le1:
            bool r1 = r2 is android.graphics.drawable.LayerDrawable
            goto Ld0
        Le7:
            bool r1 = r3.mHasTintMode
            goto L122
        Led:
            goto L8b
        Lf0:
            jubCYoWmdJyZYXPL(r2)
            goto L4f
        Lf7:
            return
        Lf8:
            goto Le1
        Lfc:
            bool r0 = r3.mHasTintList
            goto L46
        L102:
            android.graphics.drawable.Drawable r1 = qmcVSfmuwJerOEjl(r2)
            goto La9
        L10a:
            android.graphics.PorterDuff$Mode r3 = androidx.appcompat.widget.ResourceManagerInternal.DEFAULT_MODE
        L10c:
            goto Ld9
        L110:
            if (r0 != 0) goto L115
            goto L27
        L115:
            goto L26
        L119:
            if (r1 != 0) goto L11e
            goto Lf8
        L11e:
            goto L102
        L122:
            if (r1 != 0) goto L127
            goto L9f
        L127:
            goto Lb9
        L12b:
            r0 = 0
        L12c:
            goto Le7
        L130:
            goto L13
        L133:
            goto La
        L137:
            int[] r1 = new int[r1]
            goto L81
        L13d:
            goto L12c
        L13e:
            goto L12b
    }

    public static android.graphics.drawable.Drawable TyRVdvpScTdiEtAV(androidx.appcompat.widget.VectorEnabledTintResources r1, int r2) {
            goto L14
        L4:
            android.graphics.drawable.Drawable r0 = r1.getDrawableCanonical(r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static android.content.res.ColorStateList UAATohBRViVSKHhD(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3) {
            goto L14
        L4:
            goto L17
        L7:
            android.content.res.ColorStateList r0 = r1.getTintList(r2, r3)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void UArmsWeCpaejggtp(android.graphics.drawable.Drawable r0, android.graphics.PorterDuff.Mode r1) {
            goto Lb
        L4:
            androidx.core.graphics.drawable.DrawableCompat.setTintMode(r0, r1)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static android.graphics.drawable.Drawable VEeSKbXTainTIYos(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3, bool r4, android.graphics.drawable.Drawable r5) {
            goto L14
        L4:
            goto L17
        L7:
            android.graphics.drawable.Drawable r0 = r1.tintDrawable(r2, r3, r4, r5)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static android.graphics.PorterDuff.Mode VMbZhBAqTxwfyhQu(androidx.appcompat.widget.ResourceManagerInternal r1, int r2) {
            goto L11
        L4:
            android.graphics.PorterDuff$Mode r0 = r1.getTintMode(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void VNyqrqQDHJMrvbRv(android.graphics.drawable.Drawable r0, android.graphics.ColorFilter r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.setColorFilter(r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static android.graphics.drawable.Drawable VkNTaDkglvQTVXGA(android.graphics.drawable.Drawable r1) {
            goto L14
        L4:
            goto L17
        L7:
            android.graphics.drawable.Drawable r0 = r1.mutate()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static android.content.res.ColorStateList WFVwAOBCDbhMjyOG(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3) {
            goto L14
        L4:
            android.content.res.ColorStateList r0 = r1.getTintListFromCache(r2, r3)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static android.graphics.drawable.Drawable XEBLIHhSPYKOvCBU(android.graphics.drawable.Drawable.ConstantState r1, android.content.res.Resources r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.graphics.drawable.Drawable r0 = r1.newDrawable(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool XNohRjdfMbUiCSVz(android.graphics.drawable.Drawable r1, int[] r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = r1.setState(r2)
            goto L7
    }

    public static android.graphics.drawable.Drawable XRxodPlzFDjKVqYj(androidx.appcompat.widget.ResourceManagerInternal.InflateDelegate r1, android.content.object r2, org.xmlpull.v1.XmlPullParser r3, android.util.AttributeHashSet r4, android.content.res.Resources.Theme r5) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            android.graphics.drawable.Drawable r0 = r1.createFromXmlInner(r2, r3, r4, r5)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static android.graphics.drawable.Drawable XWswKZtFTWFigCDo(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, int r3) {
            goto L14
        L4:
            android.graphics.drawable.Drawable r0 = r1.createDrawableIfNeeded(r2, r3)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void YYOtmchNatpWIJmN(androidx.appcompat.widget.ResourceManagerInternal r0, android.content.object r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.checkVectorDrawableHashSetup(r1)
            goto L4
        L17:
            goto Lc
    }

    public static long YmwltWamNuYMxTvr(android.util.TypedValue r2) {
            goto L3e
        L4:
            int r0 = r0 + r1
            goto L17
        La:
            return r0
        Lb:
            goto L30
        Lf:
            long r0 = createCacheKey(r2)
            goto La
        L17:
            int r0 = r0 % r1
            goto L1d
        L1d:
            if (r0 <= 0) goto L22
            goto L29
        L22:
            goto L26
        L26:
            goto Lb
        L29:
            goto Lf
        L2d:
            goto L41
        L30:
            goto L29
        L33:
            goto L2d
        L37:
            r0 = 26
            goto L45
        L3e:
            goto L33
        L41:
            goto L37
        L45:
            r1 = 20
            goto L4
    }

    public static bool ZPRWNwlJqvHFUMZz(androidx.appcompat.widget.ResourceManagerInternal r1, android.content.object r2, long r3, android.graphics.drawable.Drawable r5) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.addDrawableToCache(r2, r3, r5)
            goto L4
        L18:
            goto Lc
    }

    public static android.graphics.drawable.Drawable.ConstantState ZcBxlBkTCXOPZghk(android.graphics.drawable.Drawable r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.graphics.drawable.Drawable$ConstantState r0 = r1.getConstantState()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public android.graphics.drawable.Drawable GetDrawable(android.content.object r2, int r3) {
            r1 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L1c
        Lb:
            throw r2
        Lc:
            goto L21
        L10:
            monitor-exit(r1)
            goto L15
        L15:
            return r2
        L16:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L16
            goto Lb
        L1c:
            monitor-enter(r1)
            goto L24
        L21:
            goto L7
        L24:
            r0 = 0
            android.graphics.drawable.Drawable r2 = dXvVHaGBgrbIbPvZ(r1, r2, r3, r0)     // Catch: java.lang.Exception -> L16
            goto L10
    }

    synchronized android.graphics.drawable.Drawable GetDrawable(android.content.object r2, int r3, bool r4) {
            r1 = this;
            goto L9
        L4:
            throw r2
        L5:
            goto L15
        L9:
            goto L5
        Lc:
            goto L1f
        L10:
            monitor-exit(r1)
            goto L18
        L15:
            goto Lc
        L18:
            return r0
        L19:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L19
            goto L4
        L1f:
            monitor-enter(r1)
            yYOtmchNatpWIJmN(r1, r2)     // Catch: java.lang.Exception -> L19
            android.graphics.drawable.Drawable r0 = EZcgOLsUBlIijkkt(r1, r2, r3)     // Catch: java.lang.Exception -> L19
            if (r0 != 0) goto L2d
            android.graphics.drawable.Drawable r0 = xWswKZtFTWFigCDo(r1, r2, r3)     // Catch: java.lang.Exception -> L19
        L2d:
            if (r0 != 0) goto L33
            android.graphics.drawable.Drawable r0 = AhJbndeeeuCmpwNb(r2, r3)     // Catch: java.lang.Exception -> L19
        L33:
            if (r0 == 0) goto L39
            android.graphics.drawable.Drawable r0 = vEeSKbXTainTIYos(r1, r2, r3, r4, r0)     // Catch: java.lang.Exception -> L19
        L39:
            if (r0 == 0) goto L3e
            YognPVdEyoXxHNHs(r0)     // Catch: java.lang.Exception -> L19
        L3e:
            goto L10
    }

    synchronized android.content.res.ColorStateList GetTintList(android.content.object r2, int r3) {
            r1 = this;
            goto L2d
        L4:
            monitor-exit(r1)
            goto L9
        L9:
            return r0
        La:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L34
        L10:
            monitor-enter(r1)
            android.content.res.ColorStateList r0 = wFVwAOBCDbhMjyOG(r1, r2, r3)     // Catch: java.lang.Exception -> La
            if (r0 != 0) goto L26
            androidx.appcompat.widget.ResourceManagerInternal$ResourceManagerHooks r0 = r1.mHooks     // Catch: java.lang.Exception -> La
            if (r0 != 0) goto L1d
            r0 = 0
            goto L21
        L1d:
            android.content.res.ColorStateList r0 = LpHDBklEOCxYPGfL(r0, r2, r3)     // Catch: java.lang.Exception -> La
        L21:
            if (r0 == 0) goto L26
            RAqlfiadQtMOAcAn(r1, r2, r3, r0)     // Catch: java.lang.Exception -> La
        L26:
            goto L4
        L2a:
            goto L30
        L2d:
            goto L35
        L30:
            goto L10
        L34:
            throw r2
        L35:
            goto L2a
    }

    android.graphics.PorterDuff.Mode getTintMode(int r1) {
            r0 = this;
            goto L27
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L2a
        Lc:
            r0 = 0
            goto L22
        L11:
            if (r0 == 0) goto L16
            goto L23
        L16:
            goto Lc
        L1a:
            android.graphics.PorterDuff$Mode r0 = HbONcbjBuIBHNEfn(r0, r1)
            goto L4
        L22:
            return r0
        L23:
            goto L1a
        L27:
            goto L5
        L2a:
            goto L2e
        L2e:
            androidx.appcompat.widget.ResourceManagerInternal$ResourceManagerHooks r0 = r0.mHooks
            goto L11
    }

    public void OnConfigurationChanged(android.content.object r2) {
            r1 = this;
            goto L2a
        L4:
            return
        L5:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto Le
        Lb:
            goto L2d
        Le:
            throw r2
        Lf:
            goto Lb
        L13:
            monitor-exit(r1)
            goto L4
        L18:
            monitor-enter(r1)
            java.util.WeakHashDictionary<android.content.object, androidx.collection.longSparseArray<java.lang.ref.WeakReference<android.graphics.drawable.Drawable$ConstantState>>> r0 = r1.mDrawableCaches     // Catch: java.lang.Exception -> L5
            java.lang.object r2 = qMuvnfcNfFgQnrHn(r0, r2)     // Catch: java.lang.Exception -> L5
            androidx.collection.longSparseArray r2 = (androidx.collection.longSparseArray) r2     // Catch: java.lang.Exception -> L5
            if (r2 == 0) goto L26
            BCHiHyfaWNdACLBK(r2)     // Catch: java.lang.Exception -> L5
        L26:
            goto L13
        L2a:
            goto Lf
        L2d:
            goto L18
    }

    synchronized android.graphics.drawable.Drawable OnDrawableLoadedFromResources(android.content.object r2, androidx.appcompat.widget.VectorEnabledTintResources r3, int r4) {
            r1 = this;
            goto L9
        L4:
            return r2
        L5:
            goto L10
        L9:
            goto L40
        Lc:
            goto L1a
        L10:
            monitor-exit(r1)
            goto L15
        L15:
            r1 = 0
            goto L38
        L1a:
            monitor-enter(r1)
            android.graphics.drawable.Drawable r0 = RCfomKCcRlrvwSlg(r1, r2, r4)     // Catch: java.lang.Exception -> L39
            if (r0 != 0) goto L25
            android.graphics.drawable.Drawable r0 = tyRVdvpScTdiEtAV(r3, r4)     // Catch: java.lang.Exception -> L39
        L25:
            if (r0 == 0) goto L5
            r3 = 0
            android.graphics.drawable.Drawable r2 = JjZYpGvXrIIkYSTU(r1, r2, r4, r3, r0)     // Catch: java.lang.Exception -> L39
            goto L30
        L30:
            monitor-exit(r1)
            goto L4
        L35:
            goto Lc
        L38:
            return r1
        L39:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L39
            goto L3f
        L3f:
            throw r2
        L40:
            goto L35
    }

    public void SetHooks(androidx.appcompat.widget.ResourceManagerInternal.ResourceManagerHooks r1) {
            r0 = this;
            goto L15
        L4:
            monitor-enter(r0)
            r0.mHooks = r1     // Catch: java.lang.Exception -> L20
            goto L10
        Lb:
            throw r1
        Lc:
            goto L1c
        L10:
            monitor-exit(r0)
            goto L1f
        L15:
            goto Lc
        L18:
            goto L4
        L1c:
            goto L18
        L1f:
            return
        L20:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L20
            goto Lb
    }

    bool tintDrawableUsingColorFilter(android.content.object r1, int r2, android.graphics.drawable.Drawable r3) {
            r0 = this;
            goto L21
        L4:
            goto L24
        L7:
            r0 = 0
            goto L17
        Lc:
            r0 = 1
            goto L1c
        L11:
            androidx.appcompat.widget.ResourceManagerInternal$ResourceManagerHooks r0 = r0.mHooks
            goto L31
        L17:
            return r0
        L18:
            goto L4
        L1c:
            return r0
        L1d:
            goto L7
        L21:
            goto L18
        L24:
            goto L11
        L28:
            if (r0 != 0) goto L2d
            goto L1d
        L2d:
            goto Lc
        L31:
            if (r0 != 0) goto L36
            goto L1d
        L36:
            goto L3a
        L3a:
            bool r0 = bnJIjRXxJofntfmN(r0, r1, r2, r3)
            goto L28
    }
}

