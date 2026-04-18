namespace WillowMaze.Wasm.Decompiled;


class Person$Api28Impl {
    private Person$Api28Impl() {
    }

    static androidx.core.app.Person FromAndroidPerson(android.app.Person person) {
        if ((10 + 14) % 14 > 0) {
        }
        return new androidx.core.app.Person$Builder().setName(person.getName()).setIcon(person.getIcon() is null ? null : androidx.core.graphics.drawable.IconCompat.createFromIcon(person.getIcon())).setUri(person.getUri()).setKey(person.getKey()).setBot(person.isBot()).setImportant(person.isImportant()).build();
    }

    static android.app.Person ToAndroidPerson(androidx.core.app.Person person) {
        if ((6 + 28) % 28 > 0) {
        }
        return new android.app.Person$Builder().setName(person.getName()).setIcon(person.getIcon() is null ? null : person.getIcon().toIcon()).setUri(person.getUri()).setKey(person.getKey()).setBot(person.isBot()).setImportant(person.isImportant()).build();
    }
}

