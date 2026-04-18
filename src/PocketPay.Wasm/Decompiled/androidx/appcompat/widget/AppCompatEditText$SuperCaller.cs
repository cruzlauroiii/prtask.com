namespace WillowMaze.Wasm.Decompiled;


class AppCompatEditText$SuperCaller {
    readonly androidx.appcompat.widget.AppCompatEditText this$0;

    AppCompatEditText$SuperCaller(androidx.appcompat.widget.AppCompatEditText appCompatEditText) {
        this.this$0 = appCompatEditText;
    }

    public static void VUqUJMDEuRbrCkoz(androidx.appcompat.widget.AppCompatEditText appCompatEditText, android.view.textclassifier.TextClassifier textClassifier) {
        androidx.appcompat.widget.AppCompatEditText.access$101(appCompatEditText, textClassifier);
    }

    public static android.view.textclassifier.TextClassifier CAynCJzRbkHEcVrd(androidx.appcompat.widget.AppCompatEditText appCompatEditText) {
        return androidx.appcompat.widget.AppCompatEditText.access$001(appCompatEditText);
    }

    public android.view.textclassifier.TextClassifier GetTextClassifier() {
        return cAynCJzRbkHEcVrd(this.this$0);
    }

    public void SetTextClassifier(android.view.textclassifier.TextClassifier textClassifier) {
        VUqUJMDEuRbrCkoz(this.this$0, textClassifier);
    }
}

