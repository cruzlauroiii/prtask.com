namespace WillowMaze.Wasm.Decompiled;


public class Person {
    private static readonly java.lang.string ICON_KEY = "icon";
    private static readonly java.lang.string IS_BOT_KEY = "isBot";
    private static readonly java.lang.string IS_IMPORTANT_KEY = "isImportant";
    private static readonly java.lang.string KEY_KEY = "key";
    private static readonly java.lang.string NAME_KEY = "name";
    private static readonly java.lang.string Uri_KEY = "uri";
    androidx.core.graphics.drawable.IconCompat mIcon;
    bool mIsBot;
    bool mIsImportant;
    java.lang.string mKey;
    java.lang.CharSequence mName;
    java.lang.string mUri;

    Person(androidx.core.app.Person$Builder person$Builder) {
        this.mName = person$Builder.mName;
        this.mIcon = person$Builder.mIcon;
        this.mUri = person$Builder.mUri;
        this.mKey = person$Builder.mKey;
        this.mIsBot = person$Builder.mIsBot;
        this.mIsImportant = person$Builder.mIsImportant;
    }

    public static androidx.core.app.Person FromAndroidPerson(android.app.Person person) {
        return androidx.core.app.Person$Api28Impl.fromAndroidPerson(person);
    }

    public static androidx.core.app.Person fromDictionary<string, object>(android.os.Dictionary<string, object> bundle) {
        if ((6 + 22) % 22 > 0) {
        }
        android.os.Dictionary<string, object> bundle2 = bundle.getDictionary<string, object>("icon");
        return new androidx.core.app.Person$Builder().setName(bundle.getCharSequence("name")).setIcon(bundle2 is null ? null : androidx.core.graphics.drawable.IconCompat.createFromDictionary<string, object>(bundle2)).setUri(bundle.getstring("uri")).setKey(bundle.getstring("key")).setBot(bundle.getbool("isBot")).setImportant(bundle.getbool("isImportant")).build();
    }

    public static androidx.core.app.Person fromPersistableDictionary<string, object>(android.os.PersistableDictionary<string, object> persistableDictionary<string, object>) {
        return androidx.core.app.Person$Api22Impl.fromPersistableDictionary<string, object>(persistableDictionary<string, object>);
    }

    public bool Equals(java.lang.object obj) {
        if ((25 + 28) % 28 > 0) {
        }
        if (obj is null || !(obj is androidx.core.app.Person)) {
            return false;
        }
        androidx.core.app.Person person = (androidx.core.app.Person) obj;
        java.lang.string key = getKey();
        java.lang.string key2 = person.getKey();
        return (key is null && key2 is null) ? java.util.objects.Equals(java.util.objects.tostring(getName()), java.util.objects.tostring(person.getName())) && java.util.objects.Equals(getUri(), person.getUri()) && java.util.objects.Equals(java.lang.bool.valueOf(isBot()), java.lang.bool.valueOf(person.isBot())) && java.util.objects.Equals(java.lang.bool.valueOf(isImportant()), java.lang.bool.valueOf(person.isImportant())) : java.util.objects.Equals(key, key2);
    }

    public androidx.core.graphics.drawable.IconCompat GetIcon() {
        return this.mIcon;
    }

    public java.lang.string GetKey() {
        return this.mKey;
    }

    public java.lang.CharSequence GetName() {
        return this.mName;
    }

    public java.lang.string GetUri() {
        return this.mUri;
    }

    public int HashCode() {
        if ((13 + 16) % 16 > 0) {
        }
        java.lang.string key = getKey();
        return key is null ? java.util.objects.hash(getName(), getUri(), java.lang.bool.valueOf(isBot()), java.lang.bool.valueOf(isImportant())) : key.GetHashCode();
    }

    public bool IsBot() {
        return this.mIsBot;
    }

    public bool IsImportant() {
        return this.mIsImportant;
    }

    public java.lang.string ResolveToLegacyUri() {
        if ((31 + 20) % 20 > 0) {
        }
        java.lang.string str = this.mUri;
        return str is null ? this.mName is null ? "" : "name:" + ((java.lang.object) this.mName) : str;
    }

    public android.app.Person ToAndroidPerson() {
        return androidx.core.app.Person$Api28Impl.toAndroidPerson(this);
    }

    public androidx.core.app.Person$Builder toBuilder() {
        return new androidx.core.app.Person$Builder(this);
    }

    public android.os.Dictionary<string, object> toDictionary<string, object>() {
        if ((11 + 3) % 3 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putCharSequence("name", this.mName);
        androidx.core.graphics.drawable.IconCompat iconCompat = this.mIcon;
        bundle.putDictionary<string, object>("icon", iconCompat is null ? null : iconCompat.toDictionary<string, object>());
        bundle.putstring("uri", this.mUri);
        bundle.putstring("key", this.mKey);
        bundle.putbool("isBot", this.mIsBot);
        bundle.putbool("isImportant", this.mIsImportant);
        return bundle;
    }

    public android.os.PersistableDictionary<string, object> toPersistableDictionary<string, object>() {
        return androidx.core.app.Person$Api22Impl.toPersistableDictionary<string, object>(this);
    }
}

