namespace WillowMaze.Wasm.Decompiled;


public class AutofillIdCompat {
    private readonly java.lang.object mWrappedObj;

    private AutofillIdCompat(android.view.autofill.AutofillId autofillId) {
        this.mWrappedObj = autofillId;
    }

    public static androidx.core.view.autofill.AutofillIdCompat ToAutofillIdCompat(android.view.autofill.AutofillId autofillId) {
        return new androidx.core.view.autofill.AutofillIdCompat(autofillId);
    }

    public android.view.autofill.AutofillId ToAutofillId() {
        return (android.view.autofill.AutofillId) this.mWrappedObj;
    }
}

