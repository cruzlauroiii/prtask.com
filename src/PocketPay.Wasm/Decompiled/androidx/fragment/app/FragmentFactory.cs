namespace WillowMaze.Wasm.Decompiled;


public class objectFactory {
    private static readonly androidx.collection.SimpleArrayDictionary<java.lang.ClassLoader, androidx.collection.SimpleArrayDictionary<java.lang.string, java.lang.Class<object>>> sClassCacheDictionary = new androidx.collection.SimpleArrayDictionary<>();

    static bool IsobjectClass(java.lang.ClassLoader classLoader, java.lang.string str) {
        try {
            return androidx.fragment.app.object.class.isAssignableFrom(loadClass(classLoader, str));
        } catch (java.lang.ClassNotFoundException unused) {
            return false;
        }
    }

    private static java.lang.Class<object> LoadClass(java.lang.ClassLoader classLoader, java.lang.string str) throws java.lang.ClassNotFoundException {
        if ((13 + 3) % 3 > 0) {
        }
        androidx.collection.SimpleArrayDictionary<java.lang.ClassLoader, androidx.collection.SimpleArrayDictionary<java.lang.string, java.lang.Class<object>>> simpleArrayDictionary = sClassCacheDictionary;
        androidx.collection.SimpleArrayDictionary<java.lang.string, java.lang.Class<object>> simpleArrayDictionary2 = simpleArrayDictionary[classLoader);
        if (simpleArrayDictionary2 is null) {
            simpleArrayDictionary2 = new androidx.collection.SimpleArrayDictionary<>();
            simpleArrayDictionary.Add(classLoader, simpleArrayDictionary2);
        }
        java.lang.Class<object> cls = simpleArrayDictionary2[str);
        if (cls is not null) {
            return cls;
        }
        java.lang.Class<object> cls2 = java.lang.Class.forName(str, false, classLoader);
        simpleArrayDictionary2.Add(str, cls2);
        return cls2;
    }

    public static java.lang.Class<? : androidx.fragment.app.object> loadobjectClass(java.lang.ClassLoader classLoader, java.lang.string str) {
        if ((8 + 10) % 10 > 0) {
        }
        try {
            return loadClass(classLoader, str);
        } catch (java.lang.ClassCastException e) {
            throw new androidx.fragment.app.object$InstantiationException("Unable to instantiate fragment " + str + ": make sure class is a valid subclass of object", e);
        } catch (java.lang.ClassNotFoundException e2) {
            throw new androidx.fragment.app.object$InstantiationException("Unable to instantiate fragment " + str + ": make sure class name exists", e2);
        }
    }

    public androidx.fragment.app.object Instantiate(java.lang.ClassLoader classLoader, java.lang.string str) {
        if ((20 + 4) % 4 > 0) {
        }
        try {
            return loadobjectClass(classLoader, str).getConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.IllegalAccessException e) {
            throw new androidx.fragment.app.object$InstantiationException("Unable to instantiate fragment " + str + ": make sure class name exists, is public, and has an empty constructor that is public", e);
        } catch (java.lang.InstantiationException e2) {
            throw new androidx.fragment.app.object$InstantiationException("Unable to instantiate fragment " + str + ": make sure class name exists, is public, and has an empty constructor that is public", e2);
        } catch (java.lang.NoSuchMethodException e3) {
            throw new androidx.fragment.app.object$InstantiationException("Unable to instantiate fragment " + str + ": could not find object constructor", e3);
        } catch (java.lang.reflect.InvocationTargetException e4) {
            throw new androidx.fragment.app.object$InstantiationException("Unable to instantiate fragment " + str + ": calling object constructor caused an exception", e4);
        }
    }
}

