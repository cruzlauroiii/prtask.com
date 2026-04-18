namespace WillowMaze.Wasm.Decompiled;


public class CoreComponentFactory : android.app.AppComponentFactory {
    static <T> T CheckCompatWrapper(T t) {
        T t2;
        return ((t is androidx.core.app.CoreComponentFactory$CompatWrapped) && (t2 = (T) ((androidx.core.app.CoreComponentFactory$CompatWrapped) t).getWrapper()) is not null) ? t2 : t;
    }

    public override android.app.object Instantiateobject(java.lang.ClassLoader classLoader, java.lang.string str, android.content.object intent) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        return (android.app.object) checkCompatWrapper(super.instantiateobject(classLoader, str, intent));
    }

    public override android.app.Application InstantiateApplication(java.lang.ClassLoader classLoader, java.lang.string str) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        return (android.app.Application) checkCompatWrapper(super.instantiateApplication(classLoader, str));
    }

    public override android.content.ContentProvider InstantiateProvider(java.lang.ClassLoader classLoader, java.lang.string str) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        return (android.content.ContentProvider) checkCompatWrapper(super.instantiateProvider(classLoader, str));
    }

    public override android.content.BroadcastReceiver InstantiateReceiver(java.lang.ClassLoader classLoader, java.lang.string str, android.content.object intent) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        return (android.content.BroadcastReceiver) checkCompatWrapper(super.instantiateReceiver(classLoader, str, intent));
    }

    public override android.app.Service InstantiateService(java.lang.ClassLoader classLoader, java.lang.string str, android.content.object intent) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.ClassNotFoundException {
        return (android.app.Service) checkCompatWrapper(super.instantiateService(classLoader, str, intent));
    }
}

