namespace WillowMaze.Wasm.Decompiled;


readonly class AppCompatTextClassifierHelper {
    private android.view.textclassifier.TextClassifier mTextClassifier;
    private android.widget.Textobject mTextobject;

    AppCompatTextClassifierHelper(android.widget.Textobject textobject) {
        this.mTextobject = (android.widget.Textobject) yurcybHYrdzvDzhh(textobject);
    }

    public static android.view.textclassifier.TextClassifier WHbsawJSvavXpSTi(android.widget.Textobject textobject) {
        return androidx.appcompat.widget.AppCompatTextClassifierHelper$Api26Impl.getTextClassifier(textobject);
    }

    public static java.lang.object YurcybHYrdzvDzhh(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public android.view.textclassifier.TextClassifier GetTextClassifier() {
        android.view.textclassifier.TextClassifier textClassifier = this.mTextClassifier;
        return textClassifier is not null ? textClassifier : WHbsawJSvavXpSTi(this.mTextobject);
    }

    public void SetTextClassifier(android.view.textclassifier.TextClassifier textClassifier) {
        this.mTextClassifier = textClassifier;
    }
}

