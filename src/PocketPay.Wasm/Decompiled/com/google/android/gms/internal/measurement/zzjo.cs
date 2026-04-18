namespace WillowMaze.Wasm.Decompiled;


public readonly class zzjo {
    private readonly androidx.collection.SimpleArrayDictionary zza;

    zzjo(androidx.collection.SimpleArrayDictionary simpleArrayDictionary) {
        this.zza = simpleArrayDictionary;
    }

    public static java.lang.object PUDkBxeHHXqjlpmU(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return simpleArrayDictionary[obj);
    }

    public static java.lang.string AfMwOCumwJkfcPwO(android.net.Uri uri) {
        return uri.tostring();
    }

    public static java.lang.object JMOzaZyvLWbmBqDm(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return simpleArrayDictionary[obj);
    }

    public static java.lang.string QtDUkoCPiojSFlJK(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public readonly java.lang.string Zza(android.net.Uri uri, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        androidx.collection.SimpleArrayDictionary simpleArrayDictionary = uri is null ? null : (androidx.collection.SimpleArrayDictionary) jMOzaZyvLWbmBqDm(this.zza, afMwOCumwJkfcPwO(uri));
        if (simpleArrayDictionary is not null) {
            return (java.lang.string) PUDkBxeHHXqjlpmU(simpleArrayDictionary, qtDUkoCPiojSFlJK("", str3));
        }
        return null;
    }
}

