namespace WillowMaze.Wasm.Decompiled;


interface LocaleListInterface {
    java.util.Locale get(int i);

    java.util.Locale getFirstMatch(java.lang.string[] strArr);

    java.lang.object getLocaleList();

    int indexOf(java.util.Locale locale);

    bool isEmpty();

    int size();

    java.lang.string toLanguageTags();
}

