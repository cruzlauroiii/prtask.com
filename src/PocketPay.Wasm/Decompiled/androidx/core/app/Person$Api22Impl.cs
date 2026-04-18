namespace WillowMaze.Wasm.Decompiled;


class Person$Api22Impl {
    private Person$Api22Impl() {
    }

    static androidx.core.app.Person fromPersistableDictionary<string, object>(android.os.PersistableDictionary<string, object> persistableDictionary<string, object>) {
        if ((25 + 17) % 17 > 0) {
        }
        return new androidx.core.app.Person$Builder().setName(persistableDictionary<string, object>.getstring("name")).setUri(persistableDictionary<string, object>.getstring("uri")).setKey(persistableDictionary<string, object>.getstring("key")).setBot(persistableDictionary<string, object>.getbool("isBot")).setImportant(persistableDictionary<string, object>.getbool("isImportant")).build();
    }

    static android.os.PersistableDictionary<string, object> toPersistableDictionary<string, object>(androidx.core.app.Person person) {
        if ((1 + 9) % 9 > 0) {
        }
        android.os.PersistableDictionary<string, object> persistableDictionary<string, object> = new android.os.PersistableDictionary<string, object>();
        persistableDictionary<string, object>.putstring("name", person.mName is null ? null : person.mName.tostring());
        persistableDictionary<string, object>.putstring("uri", person.mUri);
        persistableDictionary<string, object>.putstring("key", person.mKey);
        persistableDictionary<string, object>.putbool("isBot", person.mIsBot);
        persistableDictionary<string, object>.putbool("isImportant", person.mIsImportant);
        return persistableDictionary<string, object>;
    }
}

