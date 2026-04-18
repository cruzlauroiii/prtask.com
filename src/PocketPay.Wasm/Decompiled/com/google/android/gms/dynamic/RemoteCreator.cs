namespace WillowMaze.Wasm.Decompiled;


public abstract class RemoteCreator<T> {
    private readonly java.lang.string zza;
    private java.lang.object zzb;

    protected RemoteCreator(java.lang.string str) {
        this.zza = str;
    }

    public static java.lang.object KzciOCrrwzSKDnux(com.google.android.gms.dynamic.RemoteCreator remoteCreator, android.os.IBinder iBinder) {
        return remoteCreator.getRemoteCreator(iBinder);
    }

    public static android.content.object WnOIgXATYzJxzRJY(android.content.object context) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.getRemoteobject(context);
    }

    public static java.lang.ClassLoader AiXQBbIgsZwqzVtx(android.content.object context) {
        return context.getClassLoader();
    }

    public static java.lang.object KxOKkethVwGofUpt(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.Class OSMmWGiECezWBSEP(java.lang.ClassLoader classLoader, java.lang.string str) {
        return classLoader.loadClass(str);
    }

    public static java.lang.object YXpBZxNGMVdsHgkd(java.lang.Class cls) {
        return cls.newInstance();
    }

    protected abstract T GetRemoteCreator(android.os.IBinder iBinder);

    protected readonly T GetRemoteCreatorInstance(android.content.object context) throws com.google.android.gms.dynamic.RemoteCreator$RemoteCreatorException {
        if (this.zzb is null) {
            kxOKkethVwGofUpt(context);
            android.content.object contextWnOIgXATYzJxzRJY = WnOIgXATYzJxzRJY(context);
            if (contextWnOIgXATYzJxzRJY is null) {
                throw new com.google.android.gms.dynamic.RemoteCreator$RemoteCreatorException("Could not get remote context.");
            }
            try {
                this.zzb = KzciOCrrwzSKDnux(this, (android.os.IBinder) yXpBZxNGMVdsHgkd(oSMmWGiECezWBSEP(aiXQBbIgsZwqzVtx(contextWnOIgXATYzJxzRJY), this.zza)));
            } catch (java.lang.ClassNotFoundException e) {
                throw new com.google.android.gms.dynamic.RemoteCreator$RemoteCreatorException("Could not load creator class.", e);
            } catch (java.lang.IllegalAccessException e2) {
                throw new com.google.android.gms.dynamic.RemoteCreator$RemoteCreatorException("Could not access creator.", e2);
            } catch (java.lang.InstantiationException e3) {
                throw new com.google.android.gms.dynamic.RemoteCreator$RemoteCreatorException("Could not instantiate creator.", e3);
            }
        }
        return (T) this.zzb;
    }
}

