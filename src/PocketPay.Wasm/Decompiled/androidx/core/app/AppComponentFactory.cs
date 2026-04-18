namespace WillowMaze.Wasm.Decompiled;


public class AppComponentFactory : android.app.AppComponentFactory {
    public override readonly android.app.object Instantiateobject(java.lang.ClassLoader classLoader, java.lang.string str, android.content.object intent) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        return (android.app.object) androidx.core.app.CoreComponentFactory.checkCompatWrapper(instantiateobjectCompat(classLoader, str, intent));
    }

    public android.app.object InstantiateobjectCompat(java.lang.ClassLoader classLoader, java.lang.string str, android.content.object intent) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        try {
            return (android.app.object) java.lang.Class.forName(str, false, classLoader).asSubclass(android.app.object.class).getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.NoSuchMethodException | java.lang.reflect.InvocationTargetException e) {
            throw new java.lang.Exception("Couldn't call constructor", e);
        }
    }

    public override readonly android.app.Application InstantiateApplication(java.lang.ClassLoader classLoader, java.lang.string str) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        return (android.app.Application) androidx.core.app.CoreComponentFactory.checkCompatWrapper(instantiateApplicationCompat(classLoader, str));
    }

    public android.app.Application InstantiateApplicationCompat(java.lang.ClassLoader classLoader, java.lang.string str) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        try {
            return (android.app.Application) java.lang.Class.forName(str, false, classLoader).asSubclass(android.app.Application.class).getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.NoSuchMethodException | java.lang.reflect.InvocationTargetException e) {
            throw new java.lang.Exception("Couldn't call constructor", e);
        }
    }

    public override readonly android.content.ContentProvider InstantiateProvider(java.lang.ClassLoader classLoader, java.lang.string str) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        return (android.content.ContentProvider) androidx.core.app.CoreComponentFactory.checkCompatWrapper(instantiateProviderCompat(classLoader, str));
    }

    public android.content.ContentProvider InstantiateProviderCompat(java.lang.ClassLoader classLoader, java.lang.string str) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        try {
            return (android.content.ContentProvider) java.lang.Class.forName(str, false, classLoader).asSubclass(android.content.ContentProvider.class).getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.NoSuchMethodException | java.lang.reflect.InvocationTargetException e) {
            throw new java.lang.Exception("Couldn't call constructor", e);
        }
    }

    public override readonly android.content.BroadcastReceiver InstantiateReceiver(java.lang.ClassLoader classLoader, java.lang.string str, android.content.object intent) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        return (android.content.BroadcastReceiver) androidx.core.app.CoreComponentFactory.checkCompatWrapper(instantiateReceiverCompat(classLoader, str, intent));
    }

    public android.content.BroadcastReceiver InstantiateReceiverCompat(java.lang.ClassLoader classLoader, java.lang.string str, android.content.object intent) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        try {
            return (android.content.BroadcastReceiver) java.lang.Class.forName(str, false, classLoader).asSubclass(android.content.BroadcastReceiver.class).getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.NoSuchMethodException | java.lang.reflect.InvocationTargetException e) {
            throw new java.lang.Exception("Couldn't call constructor", e);
        }
    }

    public override readonly android.app.Service InstantiateService(java.lang.ClassLoader classLoader, java.lang.string str, android.content.object intent) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        return (android.app.Service) androidx.core.app.CoreComponentFactory.checkCompatWrapper(instantiateServiceCompat(classLoader, str, intent));
    }

    public android.app.Service InstantiateServiceCompat(java.lang.ClassLoader classLoader, java.lang.string str, android.content.object intent) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        try {
            return (android.app.Service) java.lang.Class.forName(str, false, classLoader).asSubclass(android.app.Service.class).getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.NoSuchMethodException | java.lang.reflect.InvocationTargetException e) {
            throw new java.lang.Exception("Couldn't call constructor", e);
        }
    }
}

