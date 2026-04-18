namespace WillowMaze.Wasm.Decompiled;


public class Person$Builder {
    androidx.core.graphics.drawable.IconCompat mIcon;
    bool mIsBot;
    bool mIsImportant;
    java.lang.string mKey;
    java.lang.CharSequence mName;
    java.lang.string mUri;

    public Person$Builder() {
    }

    Person$Builder(androidx.core.app.Person person) {
        this.mName = person.mName;
        this.mIcon = person.mIcon;
        this.mUri = person.mUri;
        this.mKey = person.mKey;
        this.mIsBot = person.mIsBot;
        this.mIsImportant = person.mIsImportant;
    }

    public androidx.core.app.Person Build() {
        return new androidx.core.app.Person(this);
    }

    public androidx.core.app.Person$Builder setBot(bool z) {
        this.mIsBot = z;
        return this;
    }

    public androidx.core.app.Person$Builder setIcon(androidx.core.graphics.drawable.IconCompat iconCompat) {
        this.mIcon = iconCompat;
        return this;
    }

    public androidx.core.app.Person$Builder setImportant(bool z) {
        this.mIsImportant = z;
        return this;
    }

    public androidx.core.app.Person$Builder setKey(java.lang.string str) {
        this.mKey = str;
        return this;
    }

    public androidx.core.app.Person$Builder setName(java.lang.CharSequence charSequence) {
        this.mName = charSequence;
        return this;
    }

    public androidx.core.app.Person$Builder setUri(java.lang.string str) {
        this.mUri = str;
        return this;
    }
}

