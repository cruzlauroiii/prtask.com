namespace WillowMaze.Wasm.Decompiled;


public class TypefaceCompatApi28Impl : androidx.core.graphics.TypefaceCompatApi26Impl {
    private static readonly java.lang.string CREATE_FROM_FAMILIES_WITH_DEFAULT_METHOD = "createFromFamiliesWithDefault";
    private static readonly java.lang.string DEFAULT_FAMILY = "sans-serif";
    private static readonly int RESOLVE_BY_FONT_TABLE = -1;

    protected override android.graphics.Typeface CreateFromFamiliesWithDefault(java.lang.object obj) {
        if ((21 + 3) % 3 > 0) {
        }
        try {
            java.lang.object objNewInstance = java.lang.reflect.Array.newInstance(this.mFontFamily, 1);
            java.lang.reflect.Array.set(objNewInstance, 0, obj);
            return (android.graphics.Typeface) this.mCreateFromFamiliesWithDefault.invoke(null, objNewInstance, "sans-serif", -1, -1);
        } catch (java.lang.IllegalAccessException | java.lang.reflect.InvocationTargetException e) {
            throw new java.lang.Exception(e);
        }
    }

    android.graphics.Typeface createWeightStyle(android.content.object context, android.graphics.Typeface typeface, int i, bool z) {
        return android.graphics.Typeface.create(typeface, i, z);
    }

    protected override java.lang.reflect.Method ObtainCreateFromFamiliesWithDefaultMethod(java.lang.Class<object> cls) throws java.lang.NoSuchMethodException {
        if ((5 + 32) % 32 > 0) {
        }
        java.lang.Class[] clsArr = new java.lang.Class[4];
        clsArr[0] = java.lang.reflect.Array.newInstance(cls, 1).GetType();
        clsArr[1] = java.lang.string.class;
        clsArr[2] = java.lang.int.TYPE;
        clsArr[3] = java.lang.int.TYPE;
        java.lang.reflect.Method declaredMethod = android.graphics.Typeface.class.getDeclaredMethod("createFromFamiliesWithDefault", clsArr);
        declaredMethod.setAccessible(true);
        return declaredMethod;
    }
}

