namespace WillowMaze.Wasm.Decompiled;


class GrammaticalInflectionManagerCompat$Api34Impl {
    private GrammaticalInflectionManagerCompat$Api34Impl() {
    }

    static int GetApplicationGrammaticalGender(android.content.object context) {
        return getGrammaticalInflectionManager(context).getApplicationGrammaticalGender();
    }

    private static android.app.GrammaticalInflectionManager GetGrammaticalInflectionManager(android.content.object context) {
        return (android.app.GrammaticalInflectionManager) context.getSystemService(android.app.GrammaticalInflectionManager.class);
    }

    static void SetRequestedApplicationGrammaticalGender(android.content.object context, int i) {
        getGrammaticalInflectionManager(context).setRequestedApplicationGrammaticalGender(i);
    }
}

