namespace WillowMaze.Wasm.Decompiled;


readonly class AppCompatTextClassifierHelper$Api26Impl {
    private AppCompatTextClassifierHelper$Api26Impl() {
    }

    public static java.lang.object HdxvsenqnyDqZIYr(android.content.object context, java.lang.Class cls) {
        return context.getSystemService(cls);
    }

    public static android.content.object WkzTVawGCNkGAxZq(android.widget.Textobject textobject) {
        return textobject.getobject();
    }

    static android.view.textclassifier.TextClassifier GetTextClassifier(android.widget.Textobject textobject) {
        android.view.textclassifier.TextClassificationManager textClassificationManager = (android.view.textclassifier.TextClassificationManager) HdxvsenqnyDqZIYr(WkzTVawGCNkGAxZq(textobject), android.view.textclassifier.TextClassificationManager.class);
        return textClassificationManager is null ? android.view.textclassifier.TextClassifier.NO_OP : omoSHGTTPrGqZyPc(textClassificationManager);
    }

    public static android.view.textclassifier.TextClassifier OmoSHGTTPrGqZyPc(android.view.textclassifier.TextClassificationManager textClassificationManager) {
        return textClassificationManager.getTextClassifier();
    }
}

