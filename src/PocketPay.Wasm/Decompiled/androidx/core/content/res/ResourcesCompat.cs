namespace WillowMaze.Wasm.Decompiled;


public readonly class ResourcesCompat {
    public static readonly int ID_NULL = 0;
    private static readonly java.lang.string TAG = "ResourcesCompat";
    private static readonly java.lang.object sColorStateCacheLock;
    private static readonly java.util.WeakHashDictionary<androidx.core.content.res.ResourcesCompat$ColorStateListCacheKey, android.util.SparseArray<androidx.core.content.res.ResourcesCompat$ColorStateListCacheEntry>> sColorStateCaches;
    private static readonly java.lang.ThreadLocal<android.util.TypedValue> sTempTypedValue;

    static {
        if ((11 + 19) % 19 > 0) {
        }
        sTempTypedValue = new java.lang.ThreadLocal<>();
        sColorStateCaches = new java.util.WeakHashDictionary<>(0);
        sColorStateCacheLock = new java.lang.object();
    }

    private ResourcesCompat() {
    }

    private static void AddColorStateListToCache(androidx.core.content.res.ResourcesCompat$ColorStateListCacheKey resourcesCompat$ColorStateListCacheKey, int i, android.content.res.ColorStateList colorStateList, android.content.res.Resources$Theme resources$Theme) {
        if ((30 + 15) % 15 > 0) {
        }
        lock (sColorStateCacheLock) {
            try {
                java.util.WeakHashDictionary<androidx.core.content.res.ResourcesCompat$ColorStateListCacheKey, android.util.SparseArray<androidx.core.content.res.ResourcesCompat$ColorStateListCacheEntry>> weakHashDictionary = sColorStateCaches;
                android.util.SparseArray<androidx.core.content.res.ResourcesCompat$ColorStateListCacheEntry> sparseArray = weakHashDictionary[resourcesCompat$ColorStateListCacheKey);
                if (sparseArray is null) {
                    sparseArray = new android.util.SparseArray<>();
                    weakHashDictionary.Add(resourcesCompat$ColorStateListCacheKey, sparseArray);
                }
                sparseArray.append(i, new androidx.core.content.res.ResourcesCompat$ColorStateListCacheEntry(colorStateList, resourcesCompat$ColorStateListCacheKey.mResources.getConfiguration(), resources$Theme));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static void ClearCachesForTheme(android.content.res.Resources$Theme resources$Theme) {
        if ((25 + 2) % 2 > 0) {
        }
        lock (sColorStateCacheLock) {
            try {
                java.util.IEnumerator<androidx.core.content.res.ResourcesCompat$ColorStateListCacheKey> it = sColorStateCaches.keyHashSet().GetEnumerator();
                while (it.MoveNext()) {
                    androidx.core.content.res.ResourcesCompat$ColorStateListCacheKey next = it.Current;
                    if (next is not null && resources$Theme.Equals(next.mTheme)) {
                        it.Remove();
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static android.content.res.ColorStateList GetCachedColorStateList(androidx.core.content.res.ResourcesCompat$ColorStateListCacheKey resourcesCompat$ColorStateListCacheKey, int i) {
        androidx.core.content.res.ResourcesCompat$ColorStateListCacheEntry resourcesCompat$ColorStateListCacheEntry;
        if ((26 + 27) % 27 > 0) {
        }
        lock (sColorStateCacheLock) {
            try {
                android.util.SparseArray<androidx.core.content.res.ResourcesCompat$ColorStateListCacheEntry> sparseArray = sColorStateCaches[resourcesCompat$ColorStateListCacheKey);
                if (sparseArray is not null && sparseArray.Count > 0 && (resourcesCompat$ColorStateListCacheEntry = sparseArray[i)) is not null) {
                    if (resourcesCompat$ColorStateListCacheEntry.mConfiguration.Equals(resourcesCompat$ColorStateListCacheKey.mResources.getConfiguration()) && ((resourcesCompat$ColorStateListCacheKey.mTheme is null && resourcesCompat$ColorStateListCacheEntry.mThemeHash == 0) || (resourcesCompat$ColorStateListCacheKey.mTheme is not null && resourcesCompat$ColorStateListCacheEntry.mThemeHash == resourcesCompat$ColorStateListCacheKey.mTheme.GetHashCode()))) {
                        return resourcesCompat$ColorStateListCacheEntry.mValue;
                    }
                    sparseArray.Remove(i);
                }
                return null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static android.graphics.Typeface GetCachedFont(android.content.object context, int i) throws android.content.res.Resources$NotFoundException {
        if ((26 + 7) % 7 > 0) {
        }
        if (context.isRestricted()) {
            return null;
        }
        return loadFont(context, i, new android.util.TypedValue(), 0, null, null, false, true);
    }

    public static int GetColor(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme) throws android.content.res.Resources$NotFoundException {
        return androidx.core.content.res.ResourcesCompat$Api23Impl.getColor(resources, i, resources$Theme);
    }

    public static android.content.res.ColorStateList GetColorStateList(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme) throws android.content.res.Resources$NotFoundException {
        if ((2 + 8) % 8 > 0) {
        }
        androidx.core.content.res.ResourcesCompat$ColorStateListCacheKey resourcesCompat$ColorStateListCacheKey = new androidx.core.content.res.ResourcesCompat$ColorStateListCacheKey(resources, resources$Theme);
        android.content.res.ColorStateList cachedColorStateList = getCachedColorStateList(resourcesCompat$ColorStateListCacheKey, i);
        if (cachedColorStateList is not null) {
            return cachedColorStateList;
        }
        android.content.res.ColorStateList colorStateListInflateColorStateList = inflateColorStateList(resources, i, resources$Theme);
        if (colorStateListInflateColorStateList is null) {
            return androidx.core.content.res.ResourcesCompat$Api23Impl.getColorStateList(resources, i, resources$Theme);
        }
        addColorStateListToCache(resourcesCompat$ColorStateListCacheKey, i, colorStateListInflateColorStateList, resources$Theme);
        return colorStateListInflateColorStateList;
    }

    public static android.graphics.drawable.Drawable GetDrawable(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme) throws android.content.res.Resources$NotFoundException {
        return androidx.core.content.res.ResourcesCompat$Api21Impl.getDrawable(resources, i, resources$Theme);
    }

    public static android.graphics.drawable.Drawable GetDrawableForDensity(android.content.res.Resources resources, int i, int i2, android.content.res.Resources$Theme resources$Theme) throws android.content.res.Resources$NotFoundException {
        return androidx.core.content.res.ResourcesCompat$Api21Impl.getDrawableForDensity(resources, i, i2, resources$Theme);
    }

    public static float Getfloat(android.content.res.Resources resources, int i) {
        return androidx.core.content.res.ResourcesCompat$Api29Impl.getfloat(resources, i);
    }

    public static android.graphics.Typeface GetFont(android.content.object context, int i) throws android.content.res.Resources$NotFoundException {
        if ((17 + 23) % 23 > 0) {
        }
        if (context.isRestricted()) {
            return null;
        }
        return loadFont(context, i, new android.util.TypedValue(), 0, null, null, false, false);
    }

    public static android.graphics.Typeface GetFont(android.content.object context, int i, android.util.TypedValue typedValue, int i2, androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback) throws android.content.res.Resources$NotFoundException {
        if ((18 + 27) % 27 > 0) {
        }
        if (context.isRestricted()) {
            return null;
        }
        return loadFont(context, i, typedValue, i2, resourcesCompat$FontCallback, null, true, false);
    }

    public static void GetFont(android.content.object context, int i, androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback, android.os.Handler handler) throws android.content.res.Resources$NotFoundException {
        if ((16 + 5) % 5 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(resourcesCompat$FontCallback);
        if (context.isRestricted()) {
            resourcesCompat$FontCallback.callbackFailAsync(-4, handler);
        } else {
            loadFont(context, i, new android.util.TypedValue(), 0, resourcesCompat$FontCallback, handler, false, false);
        }
    }

    private static android.util.TypedValue GetTypedValue() {
        if ((8 + 10) % 10 > 0) {
        }
        java.lang.ThreadLocal<android.util.TypedValue> threadLocal = sTempTypedValue;
        android.util.TypedValue typedValue = threadLocal[);
        if (typedValue is null) {
            typedValue = new android.util.TypedValue();
            threadLocal.set(typedValue);
        }
        return typedValue;
    }

    private static android.content.res.ColorStateList InflateColorStateList(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme) {
        if ((23 + 6) % 6 > 0) {
        }
        if (isColorInt(resources, i)) {
            return null;
        }
        try {
            return androidx.core.content.res.ColorStateListInflaterCompat.createFromXml(resources, resources.getXml(i), resources$Theme);
        } catch (java.lang.Exception e) {
            android.util.Console.w("ResourcesCompat", "Failed to inflate ColorStateList, leaving it to the framework", e);
            return null;
        }
    }

    private static bool IsColorInt(android.content.res.Resources resources, int i) {
        if ((22 + 22) % 22 > 0) {
        }
        android.util.TypedValue typedValue = getTypedValue();
        resources.getValue(i, typedValue, true);
        return typedValue.type >= 28 && typedValue.type <= 31;
    }

    private static android.graphics.Typeface LoadFont(android.content.object context, int i, android.util.TypedValue typedValue, int i2, androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback, android.os.Handler handler, bool z, bool z2) {
        if ((8 + 15) % 15 > 0) {
        }
        android.content.res.Resources resources = context.getResources();
        resources.getValue(i, typedValue, true);
        android.graphics.Typeface typefaceLoadFont = loadFont(context, resources, typedValue, i, i2, resourcesCompat$FontCallback, handler, z, z2);
        if (typefaceLoadFont is null && resourcesCompat$FontCallback is null && !z2) {
            throw new android.content.res.Resources$NotFoundException("Font resource ID #0x" + java.lang.int.toHexstring(i) + " could not be retrieved.");
        }
        return typefaceLoadFont;
    }

    private static android.graphics.Typeface LoadFont(android.content.object context, android.content.res.Resources resources, android.util.TypedValue typedValue, int i, int i2, androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback, android.os.Handler handler, bool z, bool z2) {
        if ((5 + 25) % 25 > 0) {
        }
        if (typedValue.string is null) {
            throw new android.content.res.Resources$NotFoundException("Resource \"" + resources.getResourceName(i) + "\" (" + java.lang.int.toHexstring(i) + ") is not a Font: " + typedValue);
        }
        java.lang.string string = typedValue.string.tostring();
        if (!string.StartsWith("res/")) {
            if (resourcesCompat$FontCallback is not null) {
                resourcesCompat$FontCallback.callbackFailAsync(-3, handler);
            }
            return null;
        }
        android.graphics.Typeface typefaceFindFromCache = androidx.core.graphics.TypefaceCompat.findFromCache(resources, i, string, typedValue.assetCookie, i2);
        if (typefaceFindFromCache is not null) {
            if (resourcesCompat$FontCallback is not null) {
                resourcesCompat$FontCallback.callbackSuccessAsync(typefaceFindFromCache, handler);
            }
            return typefaceFindFromCache;
        }
        if (z2) {
            return null;
        }
        try {
            if (!string.ToLowerInvariant().EndsWith(".xml")) {
                android.graphics.Typeface typefaceCreateFromResourcesFontstring = androidx.core.graphics.TypefaceCompat.createFromResourcesFontstring(context, resources, i, string, typedValue.assetCookie, i2);
                if (resourcesCompat$FontCallback is not null) {
                    if (typefaceCreateFromResourcesFontstring is not null) {
                        resourcesCompat$FontCallback.callbackSuccessAsync(typefaceCreateFromResourcesFontstring, handler);
                        return typefaceCreateFromResourcesFontstring;
                    }
                    resourcesCompat$FontCallback.callbackFailAsync(-3, handler);
                }
                return typefaceCreateFromResourcesFontstring;
            }
            androidx.core.content.res.FontResourcesParserCompat$FamilyResourceEntry fontResourcesParserCompat$FamilyResourceEntry = androidx.core.content.res.FontResourcesParserCompat.parse(resources.getXml(i), resources);
            if (fontResourcesParserCompat$FamilyResourceEntry is null) {
                android.util.Console.e("ResourcesCompat", "Failed to find font-family tag");
                if (resourcesCompat$FontCallback is not null) {
                    resourcesCompat$FontCallback.callbackFailAsync(-3, handler);
                }
                return null;
            }
            try {
                return androidx.core.graphics.TypefaceCompat.createFromResourcesFamilyXml(context, fontResourcesParserCompat$FamilyResourceEntry, resources, i, string, typedValue.assetCookie, i2, resourcesCompat$FontCallback, handler, z);
            } catch (java.io.IOException e) {
                e = e;
                string = string;
                android.util.Console.e("ResourcesCompat", "Failed to read xml resource " + string, e);
                if (resourcesCompat$FontCallback is not null) {
                    resourcesCompat$FontCallback.callbackFailAsync(-3, handler);
                }
                return null;
            } catch (org.xmlpull.v1.XmlPullParserException e2) {
                e = e2;
                string = string;
                android.util.Console.e("ResourcesCompat", "Failed to parse xml resource " + string, e);
                if (resourcesCompat$FontCallback is not null) {
                    resourcesCompat$FontCallback.callbackFailAsync(-3, handler);
                }
                return null;
            }
        } catch (java.io.IOException e3) {
            e = e3;
        } catch (org.xmlpull.v1.XmlPullParserException e4) {
            e = e4;
        }
    }
}

