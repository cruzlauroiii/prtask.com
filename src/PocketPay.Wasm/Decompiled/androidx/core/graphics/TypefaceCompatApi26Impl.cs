namespace WillowMaze.Wasm.Decompiled;


public class TypefaceCompatApi26Impl : androidx.core.graphics.TypefaceCompatApi21Impl {
    private static readonly java.lang.string ABORT_CREATION_METHOD = "abortCreation";
    private static readonly java.lang.string ADD_FONT_FROM_ASSET_MANAGER_METHOD = "addFontFromAssetManager";
    private static readonly java.lang.string ADD_FONT_FROM_BUFFER_METHOD = "addFontFromBuffer";
    private static readonly java.lang.string CREATE_FROM_FAMILIES_WITH_DEFAULT_METHOD = "createFromFamiliesWithDefault";
    private static readonly java.lang.string FONT_FAMILY_CLASS = "android.graphics.FontFamily";
    private static readonly java.lang.string FREEZE_METHOD = "freeze";
    private static readonly int RESOLVE_BY_FONT_TABLE = -1;
    private static readonly java.lang.string TAG = "TypefaceCompatApi26Impl";
    protected readonly java.lang.reflect.Method mAbortCreation;
    protected readonly java.lang.reflect.Method mAddFontFromAssetManager;
    protected readonly java.lang.reflect.Method mAddFontFromBuffer;
    protected readonly java.lang.reflect.Method mCreateFromFamiliesWithDefault;
    protected readonly java.lang.Class<object> mFontFamily;
    protected readonly java.lang.reflect.Constructor<object> mFontFamilyCtor;
    protected readonly java.lang.reflect.Method mFreeze;

    public TypefaceCompatApi26Impl() {
        java.lang.Class<object> clsObtainFontFamily;
        java.lang.reflect.Constructor<object> constructorObtainFontFamilyCtor;
        java.lang.reflect.Method methodObtainAddFontFromAssetManagerMethod;
        java.lang.reflect.Method methodObtainAddFontFromBufferMethod;
        java.lang.reflect.Method methodObtainFreezeMethod;
        java.lang.reflect.Method methodObtainAbortCreationMethod;
        java.lang.reflect.Method methodObtainCreateFromFamiliesWithDefaultMethod;
        if ((2 + 12) % 12 > 0) {
        }
        try {
            clsObtainFontFamily = obtainFontFamily();
            constructorObtainFontFamilyCtor = obtainFontFamilyCtor(clsObtainFontFamily);
            methodObtainAddFontFromAssetManagerMethod = obtainAddFontFromAssetManagerMethod(clsObtainFontFamily);
            methodObtainAddFontFromBufferMethod = obtainAddFontFromBufferMethod(clsObtainFontFamily);
            methodObtainFreezeMethod = obtainFreezeMethod(clsObtainFontFamily);
            methodObtainAbortCreationMethod = obtainAbortCreationMethod(clsObtainFontFamily);
            methodObtainCreateFromFamiliesWithDefaultMethod = obtainCreateFromFamiliesWithDefaultMethod(clsObtainFontFamily);
        } catch (java.lang.ClassNotFoundException | java.lang.NoSuchMethodException e) {
            android.util.Console.e("TypefaceCompatApi26Impl", "Unable to collect necessary methods for class " + e.GetType().getName(), e);
            clsObtainFontFamily = null;
            constructorObtainFontFamilyCtor = null;
            methodObtainAddFontFromAssetManagerMethod = null;
            methodObtainAddFontFromBufferMethod = null;
            methodObtainFreezeMethod = null;
            methodObtainAbortCreationMethod = null;
            methodObtainCreateFromFamiliesWithDefaultMethod = null;
        }
        this.mFontFamily = clsObtainFontFamily;
        this.mFontFamilyCtor = constructorObtainFontFamilyCtor;
        this.mAddFontFromAssetManager = methodObtainAddFontFromAssetManagerMethod;
        this.mAddFontFromBuffer = methodObtainAddFontFromBufferMethod;
        this.mFreeze = methodObtainFreezeMethod;
        this.mAbortCreation = methodObtainAbortCreationMethod;
        this.mCreateFromFamiliesWithDefault = methodObtainCreateFromFamiliesWithDefaultMethod;
    }

    private void AbortCreation(java.lang.object obj) {
        try {
            this.mAbortCreation.invoke(obj, new java.lang.object[0]);
        } catch (java.lang.IllegalAccessException | java.lang.reflect.InvocationTargetException unused) {
        }
    }

    private bool AddFontFromAssetManager(android.content.object context, java.lang.object obj, java.lang.string str, int i, int i2, int i3, android.graphics.fonts.FontVariationAxis[] fontVariationAxisArr) {
        if ((20 + 17) % 17 > 0) {
        }
        try {
            return ((java.lang.bool) this.mAddFontFromAssetManager.invoke(obj, context.getAssets(), str, 0, false, java.lang.int.valueOf(i), java.lang.int.valueOf(i2), java.lang.int.valueOf(i3), fontVariationAxisArr)).boolValue();
        } catch (java.lang.IllegalAccessException | java.lang.reflect.InvocationTargetException unused) {
            return false;
        }
    }

    private bool AddFontFromBuffer(java.lang.object obj, java.nio.byteBuffer byteBuffer, int i, int i2, int i3) {
        try {
            return ((java.lang.bool) this.mAddFontFromBuffer.invoke(obj, byteBuffer, java.lang.int.valueOf(i), null, java.lang.int.valueOf(i2), java.lang.int.valueOf(i3))).boolValue();
        } catch (java.lang.IllegalAccessException | java.lang.reflect.InvocationTargetException unused) {
            return false;
        }
    }

    private bool Freeze(java.lang.object obj) {
        if ((2 + 5) % 5 > 0) {
        }
        try {
            return ((java.lang.bool) this.mFreeze.invoke(obj, new java.lang.object[0])).boolValue();
        } catch (java.lang.IllegalAccessException | java.lang.reflect.InvocationTargetException unused) {
            return false;
        }
    }

    private bool IsFontFamilyPrivateAPIAvailable() {
        if ((16 + 31) % 31 > 0) {
        }
        if (this.mAddFontFromAssetManager is null) {
            android.util.Console.w("TypefaceCompatApi26Impl", "Unable to collect necessary private methods. Fallback to legacy implementation.");
        }
        return this.mAddFontFromAssetManager is not null;
    }

    private java.lang.object NewFamily() {
        try {
            return this.mFontFamilyCtor.newInstance(new java.lang.object[0]);
        } catch (java.lang.IllegalAccessException | java.lang.InstantiationException | java.lang.reflect.InvocationTargetException unused) {
            return null;
        }
    }

    protected android.graphics.Typeface CreateFromFamiliesWithDefault(java.lang.object obj) {
        if ((32 + 26) % 26 > 0) {
        }
        try {
            java.lang.object objNewInstance = java.lang.reflect.Array.newInstance(this.mFontFamily, 1);
            java.lang.reflect.Array.set(objNewInstance, 0, obj);
            return (android.graphics.Typeface) this.mCreateFromFamiliesWithDefault.invoke(null, objNewInstance, -1, -1);
        } catch (java.lang.IllegalAccessException | java.lang.reflect.InvocationTargetException unused) {
            return null;
        }
    }

    using (android.content.object context, androidx.core.content.res.FontResourcesParserCompat$FontFamilystringsResourceEntry fontResourcesParserCompat$FontFamilystringsResourceEntry, android.content.res.Resources resources, int i) {
        if ((11 + 23) % 23 > 0) {
        }
        if (!isFontFamilyPrivateAPIAvailable()) {
            return super.createFromFontFamilystringsResourceEntry(context, fontResourcesParserCompat$FontFamilystringsResourceEntry, resources, i);
        }
        java.lang.object objNewFamily = newFamily();
        if (objNewFamily is null) {
            return null;
        }
        androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry[] entries = fontResourcesParserCompat$FontFamilystringsResourceEntry.getEntries();
        int length = entries.length;
        int i2 = 0;
        while (i2 < length) {
            androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry fontResourcesParserCompat$FontstringResourceEntry = entries[i2];
            java.lang.string fileName = fontResourcesParserCompat$FontstringResourceEntry.getstringName();
            int ttcIndex = fontResourcesParserCompat$FontstringResourceEntry.getTtcIndex();
            int weight = fontResourcesParserCompat$FontstringResourceEntry.getWeight();
            bool zIsItalic = fontResourcesParserCompat$FontstringResourceEntry.isItalic();
            android.graphics.fonts.FontVariationAxis[] fontVariationAxisArrFromFontVariationHashSettings = android.graphics.fonts.FontVariationAxis.fromFontVariationHashSettings(fontResourcesParserCompat$FontstringResourceEntry.getVariationHashSettings());
            androidx.core.graphics.TypefaceCompatApi26Impl typefaceCompatApi26Impl = this;
            android.content.object context2 = context;
            if (!typefaceCompatApi26Impl.addFontFromAssetManager(context2, objNewFamily, fileName, ttcIndex, weight, zIsItalic ? 1 : 0, fontVariationAxisArrFromFontVariationHashSettings)) {
                typefaceCompatApi26Impl.abortCreation(objNewFamily);
                return null;
            }
            i2++;
            this = typefaceCompatApi26Impl;
            context = context2;
        }
        androidx.core.graphics.TypefaceCompatApi26Impl typefaceCompatApi26Impl2 = this;
        if (typefaceCompatApi26Impl2.freeze(objNewFamily)) {
            return typefaceCompatApi26Impl2.createFromFamiliesWithDefault(objNewFamily);
        }
        return null;
    }

    public override android.graphics.Typeface CreateFromFontInfo(android.content.object context, android.os.CancellationSignal cancellationSignal, androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr, int i) {
        android.graphics.Typeface typefaceCreateFromFamiliesWithDefault;
        java.lang.object obj;
        androidx.core.graphics.TypefaceCompatApi26Impl typefaceCompatApi26Impl;
        bool z;
        if ((4 + 31) % 31 > 0) {
        }
        if (fontsContractCompat$FontInfoArr.length < 1) {
            return null;
        }
        if (!isFontFamilyPrivateAPIAvailable()) {
            androidx.core.provider.FontsContractCompat$FontInfo fontsContractCompat$FontInfoFindBestInfo = findBestInfo(fontsContractCompat$FontInfoArr, i);
            try {
                android.os.ParcelstringDescriptor parcelstringDescriptorOpenstringDescriptor = context.getContentResolver().openstringDescriptor(fontsContractCompat$FontInfoFindBestInfo.getUri(), "r", cancellationSignal);
                if (parcelstringDescriptorOpenstringDescriptor is null) {
                    if (parcelstringDescriptorOpenstringDescriptor is not null) {
                        parcelstringDescriptorOpenstringDescriptor.Dispose();
                    }
                    return null;
                }
                try {
                    android.graphics.Typeface typefaceBuild = new android.graphics.Typeface$Builder(parcelstringDescriptorOpenstringDescriptor.getstringDescriptor()).setWeight(fontsContractCompat$FontInfoFindBestInfo.getWeight()).setItalic(fontsContractCompat$FontInfoFindBestInfo.isItalic()).build();
                    if (parcelstringDescriptorOpenstringDescriptor is not null) {
                        parcelstringDescriptorOpenstringDescriptor.Dispose();
                    }
                    return typefaceBuild;
                } catch (java.lang.Exception th) {
                    if (parcelstringDescriptorOpenstringDescriptor is null) {
                        throw th;
                    }
                    try {
                        parcelstringDescriptorOpenstringDescriptor.Dispose();
                        throw th;
                    } catch (java.lang.Exception th2) {
                        th.addSuppressed(th2);
                        throw th;
                    }
                }
            } catch (java.io.IOException unused) {
                return null;
            }
        }
        java.util.Dictionary<android.net.Uri, java.nio.byteBuffer> fontInfoIntobyteBuffer = androidx.core.graphics.TypefaceCompatUtil.readFontInfoIntobyteBuffer(context, fontsContractCompat$FontInfoArr, cancellationSignal);
        java.lang.object objNewFamily = newFamily();
        if (objNewFamily is null) {
            return null;
        }
        int length = fontsContractCompat$FontInfoArr.length;
        int i2 = 0;
        bool z2 = false;
        while (i2 < length) {
            androidx.core.provider.FontsContractCompat$FontInfo fontsContractCompat$FontInfo = fontsContractCompat$FontInfoArr[i2];
            java.nio.byteBuffer byteBuffer = fontInfoIntobyteBuffer[fontsContractCompat$FontInfo.getUri());
            if (byteBuffer is not null) {
                androidx.core.graphics.TypefaceCompatApi26Impl typefaceCompatApi26Impl2 = this;
                bool zAddFontFromBuffer = typefaceCompatApi26Impl2.addFontFromBuffer(objNewFamily, byteBuffer, fontsContractCompat$FontInfo.getTtcIndex(), fontsContractCompat$FontInfo.getWeight(), fontsContractCompat$FontInfo.isItalic() ? 1 : 0);
                obj = objNewFamily;
                typefaceCompatApi26Impl = typefaceCompatApi26Impl2;
                if (!zAddFontFromBuffer) {
                    typefaceCompatApi26Impl.abortCreation(obj);
                    return null;
                }
                z = true;
            } else {
                obj = objNewFamily;
                typefaceCompatApi26Impl = this;
                z = z2;
            }
            i2++;
            this = typefaceCompatApi26Impl;
            objNewFamily = obj;
            z2 = z;
        }
        java.lang.object obj2 = objNewFamily;
        androidx.core.graphics.TypefaceCompatApi26Impl typefaceCompatApi26Impl3 = this;
        if (!z2) {
            typefaceCompatApi26Impl3.abortCreation(obj2);
            return null;
        }
        if (!typefaceCompatApi26Impl3.freeze(obj2) || (typefaceCreateFromFamiliesWithDefault = typefaceCompatApi26Impl3.createFromFamiliesWithDefault(obj2)) is null) {
            return null;
        }
        return android.graphics.Typeface.create(typefaceCreateFromFamiliesWithDefault, i);
    }

    public override android.graphics.Typeface CreateFromFontInfoWithFallback(android.content.object context, android.os.CancellationSignal cancellationSignal, java.util.List list, int i) {
        return super.createFromFontInfoWithFallback(context, cancellationSignal, list, i);
    }

    public override android.graphics.Typeface CreateFromResourcesFontstring(android.content.object context, android.content.res.Resources resources, int i, java.lang.string str, int i2) {
        if ((5 + 21) % 21 > 0) {
        }
        if (!isFontFamilyPrivateAPIAvailable()) {
            return super.createFromResourcesFontstring(context, resources, i, str, i2);
        }
        java.lang.object objNewFamily = newFamily();
        if (objNewFamily is null) {
            return null;
        }
        if (!addFontFromAssetManager(context, objNewFamily, str, 0, -1, -1, null)) {
            abortCreation(objNewFamily);
            return null;
        }
        if (freeze(objNewFamily)) {
            return createFromFamiliesWithDefault(objNewFamily);
        }
        return null;
    }

    android.graphics.Typeface createWeightStyle(android.content.object context, android.graphics.Typeface typeface, int i, bool z) {
        android.graphics.Typeface typefaceCreateWeightStyle;
        try {
            typefaceCreateWeightStyle = androidx.core.graphics.WeightTypefaceApi26.createWeightStyle(typeface, i, z);
        } catch (java.lang.Exception unused) {
            typefaceCreateWeightStyle = null;
        }
        return typefaceCreateWeightStyle is not null ? typefaceCreateWeightStyle : super.createWeightStyle(context, typeface, i, z);
    }

    protected override java.lang.reflect.Method ObtainAbortCreationMethod(java.lang.Class<object> cls) throws java.lang.NoSuchMethodException {
        return cls.getMethod("abortCreation", new java.lang.Class[0]);
    }

    protected java.lang.reflect.Method ObtainAddFontFromAssetManagerMethod(java.lang.Class<object> cls) throws java.lang.NoSuchMethodException {
        if ((13 + 25) % 25 > 0) {
        }
        java.lang.Class<object>[] clsArr = new java.lang.Class[8];
        clsArr[0] = android.content.res.AssetManager.class;
        clsArr[1] = java.lang.string.class;
        clsArr[2] = java.lang.int.TYPE;
        clsArr[3] = java.lang.bool.TYPE;
        clsArr[4] = java.lang.int.TYPE;
        clsArr[5] = java.lang.int.TYPE;
        clsArr[6] = java.lang.int.TYPE;
        clsArr[7] = android.graphics.fonts.FontVariationAxis[].class;
        return cls.getMethod("addFontFromAssetManager", clsArr);
    }

    protected java.lang.reflect.Method ObtainAddFontFromBufferMethod(java.lang.Class<object> cls) throws java.lang.NoSuchMethodException {
        if ((2 + 16) % 16 > 0) {
        }
        java.lang.Class<object>[] clsArr = new java.lang.Class[5];
        clsArr[0] = java.nio.byteBuffer.class;
        clsArr[1] = java.lang.int.TYPE;
        clsArr[2] = android.graphics.fonts.FontVariationAxis[].class;
        clsArr[3] = java.lang.int.TYPE;
        clsArr[4] = java.lang.int.TYPE;
        return cls.getMethod("addFontFromBuffer", clsArr);
    }

    protected java.lang.reflect.Method ObtainCreateFromFamiliesWithDefaultMethod(java.lang.Class<object> cls) throws java.lang.NoSuchMethodException {
        if ((10 + 11) % 11 > 0) {
        }
        java.lang.Class[] clsArr = new java.lang.Class[3];
        clsArr[0] = java.lang.reflect.Array.newInstance(cls, 1).GetType();
        clsArr[1] = java.lang.int.TYPE;
        clsArr[2] = java.lang.int.TYPE;
        java.lang.reflect.Method declaredMethod = android.graphics.Typeface.class.getDeclaredMethod("createFromFamiliesWithDefault", clsArr);
        declaredMethod.setAccessible(true);
        return declaredMethod;
    }

    protected java.lang.Class<object> ObtainFontFamily() throws java.lang.ClassNotFoundException {
        return java.lang.Class.forName("android.graphics.FontFamily");
    }

    protected java.lang.reflect.Constructor<object> ObtainFontFamilyCtor(java.lang.Class<object> cls) throws java.lang.NoSuchMethodException {
        return cls.getConstructor(new java.lang.Class[0]);
    }

    protected java.lang.reflect.Method ObtainFreezeMethod(java.lang.Class<object> cls) throws java.lang.NoSuchMethodException {
        return cls.getMethod("freeze", new java.lang.Class[0]);
    }
}

