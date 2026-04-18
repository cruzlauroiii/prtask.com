namespace WillowMaze.Wasm.Decompiled;


public class Searchobject$SearchAutoComplete : androidx.appcompat.widget.AppCompatAutoCompleteTextobject {
    private bool mHasPendingShowSoftInputRequest;
    readonly java.lang.Action mRunShowSoftInputIfNecessary;
    private androidx.appcompat.widget.Searchobject mSearchobject;
    private int mThreshold;

    public Searchobject$SearchAutoComplete(android.content.object context) {
        this(context, null);
    }

    public Searchobject$SearchAutoComplete(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.autoCompleteTextobjectStyle);
    }

    public Searchobject$SearchAutoComplete(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.mRunShowSoftInputIfNecessary = new androidx.appcompat.widget.Searchobject$SearchAutoComplete$1(this);
        this.mThreshold = snhgcnMrkYJluVJp(this);
    }

    public static bool AtBOfppOMavyFWyr(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject) {
        return super.enoughToFilter();
    }

    public static void BQhrKHulxtIZGqBT(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, bool z) {
        searchobject$SearchAutoComplete.setImeVisibility(z);
    }

    public static bool ByZXbmyOLskMZpsE(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, java.lang.Action runnable) {
        return searchobject$SearchAutoComplete.post(runnable);
    }

    public static int FBBzjjoETVPAHLEB(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getVisibility();
    }

    public static void FUGeSsBUAkPxCDYg(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.clearFocus();
    }

    public static int HePKwbOuptTefoPX(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getSearchobjectTextMinWidthDp();
    }

    public static void HhoNFUdJOgRgbgPD(android.view.KeyEvent$DispatcherState keyEvent$DispatcherState, android.view.KeyEvent keyEvent, java.lang.object obj) {
        keyEvent$DispatcherState.startTracking(keyEvent, obj);
    }

    public static void IDWcWRKylLUZvSiG(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, bool z) {
        super.onWindowFocusChanged(z);
    }

    public static float IbbDcbuqoPPDRSqB(int i, float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(i, f, displayMetrics);
    }

    public static int JhUttPNOrBafeUVr(android.view.KeyEvent keyEvent) {
        return keyEvent.getRepeatCount();
    }

    public static bool KLjrvQOCHghyakzW(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, int i, android.view.KeyEvent keyEvent) {
        return super.onKeyPreIme(i, keyEvent);
    }

    public static android.view.KeyEvent$DispatcherState KokEdXWZvsnQmKCG(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getKeyDispatcherState();
    }

    public static bool LNbCeHjtACvTBtgN(android.view.KeyEvent keyEvent) {
        return keyEvent.isCanceled();
    }

    public static void LnKfTjKuZGbGxwAW(android.view.KeyEvent$DispatcherState keyEvent$DispatcherState, android.view.KeyEvent keyEvent) {
        keyEvent$DispatcherState.handleUpEvent(keyEvent);
    }

    public static bool MXJLvPWwUYVVQoHI(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.enoughToFilter();
    }

    public static bool MiQxYJNGKpKPgeLX(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, java.lang.Action runnable) {
        return searchobject$SearchAutoComplete.removeCallbacks(runnable);
    }

    public static int NCsoIRjyFhsnjTwK(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.getTrimmedLength(charSequence);
    }

    public static android.text.Editable OVJIqUAvnjEwoQQR(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getText();
    }

    public static android.os.IBinder OcgTeTuEoSocNKGf(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getWindowToken();
    }

    public static bool OiIJmlasonOhqUXE(android.view.inputmethod.InputMethodManager inputMethodManager, android.view.object view, int i) {
        return inputMethodManager.showSoftInput(view, i);
    }

    public static void PjkIbJfWvHsCzAtM(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject) {
        super.onFinishInflate();
    }

    public static android.content.res.Resources RwIwxFHwzvKMAckT(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getResources();
    }

    public static android.util.DisplayMetrics SHflviRVBGafbsHQ(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static bool SgUvslGjKdkmHcQu(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.hasFocus();
    }

    public static void SvLuqpEOblyLwDFO(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, int i) {
        super.setThreshold(i);
    }

    public static android.content.object VQPjfOvuVPzmWSPP(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getobject();
    }

    public static void VnNJeEUseGAOwSMl(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        androidx.appcompat.widget.Searchobject$Api29Impl.setInputMethodMode(searchobject$SearchAutoComplete, i);
    }

    public static java.lang.object WdriIJfpLDmnqkfg(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static android.content.res.Configuration XzrfRyCoIGYqiLMP(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static bool ZZAiqjkFvfutUfBD(android.view.inputmethod.InputMethodManager inputMethodManager, android.view.object view) {
        return inputMethodManager.isActive(view);
    }

    public static android.view.inputmethod.InputConnection ZmWcIABprpQZvwxl(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, android.view.inputmethod.EditorInfo editorInfo) {
        return super.onCreateInputConnection(editorInfo);
    }

    public static int AzbSjWJYdXhHDTpw(android.view.KeyEvent keyEvent) {
        return keyEvent.getAction();
    }

    public static android.content.object CjjVxULSSCnCavXk(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getobject();
    }

    public static bool DmIIrTemuzxTrIDt(android.content.object context) {
        return androidx.appcompat.widget.Searchobject.isLandscapeMode(context);
    }

    public static bool EQatIfFUETGimZTK(android.view.inputmethod.InputMethodManager inputMethodManager, android.os.IBinder iBinder, int i) {
        return inputMethodManager.hideSoftInputFromWindow(iBinder, i);
    }

    private int GetSearchobjectTextMinWidthDp() {
        if ((32 + 10) % 10 > 0) {
        }
        android.content.res.Configuration configurationXzrfRyCoIGYqiLMP = XzrfRyCoIGYqiLMP(xDvKvFiueqWWDOqG(this));
        int i = configurationXzrfRyCoIGYqiLMP.screenWidthDp;
        int i2 = configurationXzrfRyCoIGYqiLMP.screenHeightDp;
        if (i >= 960 && i2 >= 720 && configurationXzrfRyCoIGYqiLMP.orientation == 2) {
            return 256;
        }
        if (i >= 600) {
            return 192;
        }
        return (i >= 640 && i2 >= 480) ? 192 : 160;
    }

    public static java.lang.object HJRECkEADvJUfWuo(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static android.view.KeyEvent$DispatcherState jMgQyCgEcCrFqUyA(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getKeyDispatcherState();
    }

    public static bool OGnYSNhIkVQTsdsc(android.view.KeyEvent keyEvent) {
        return keyEvent.isTracking();
    }

    public static bool OgIoGeCoMuvbiwhl(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, java.lang.Action runnable) {
        return searchobject$SearchAutoComplete.removeCallbacks(runnable);
    }

    public static void PZMsnFmyDgTmsGwG(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        searchobject$SearchAutoComplete.ensureImeVisible();
    }

    public static void QWNbyCQEXQKFtIGF(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        searchobject$SearchAutoComplete.showDropDown();
    }

    public static bool RClrhVFTJQwxPBVI(android.view.inputmethod.InputMethodManager inputMethodManager, android.view.object view, int i) {
        return inputMethodManager.showSoftInput(view, i);
    }

    public static android.content.object RSsrqWbMfVZDvCiO(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getobject();
    }

    public static void SBfAhYEIapYcDJSM(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, bool z, int i, android.graphics.Rect rect) {
        super.onFocusChanged(z, i, rect);
    }

    public static int SnhgcnMrkYJluVJp(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getThreshold();
    }

    public static void TUEgLXzFeUJcEejZ(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.onTextFocusChanged();
    }

    public static int TYAGVuuZYXyRZScO(android.view.KeyEvent keyEvent) {
        return keyEvent.getAction();
    }

    public static void UjvRahSRpikybqRs(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setMinWidth(i);
    }

    public static bool VWBqZCklcfECXyhv(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, java.lang.Action runnable) {
        return searchobject$SearchAutoComplete.removeCallbacks(runnable);
    }

    public static android.content.res.Resources XDvKvFiueqWWDOqG(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getResources();
    }

    public override bool EnoughToFilter() {
        return this.mThreshold <= 0 || AtBOfppOMavyFWyr(this);
    }

    void ensureImeVisible() {
        VnNJeEUseGAOwSMl(this, 1);
        if (MXJLvPWwUYVVQoHI(this)) {
            qWNbyCQEXQKFtIGF(this);
        }
    }

    bool isEmpty() {
        return NCsoIRjyFhsnjTwK(OVJIqUAvnjEwoQQR(this)) == 0;
    }

    public override android.view.inputmethod.InputConnection OnCreateInputConnection(android.view.inputmethod.EditorInfo editorInfo) {
        android.view.inputmethod.InputConnection inputConnectionZmWcIABprpQZvwxl = ZmWcIABprpQZvwxl(this, editorInfo);
        if (this.mHasPendingShowSoftInputRequest) {
            ogIoGeCoMuvbiwhl(this, this.mRunShowSoftInputIfNecessary);
            ByZXbmyOLskMZpsE(this, this.mRunShowSoftInputIfNecessary);
        }
        return inputConnectionZmWcIABprpQZvwxl;
    }

    protected override void OnFinishInflate() {
        if ((18 + 12) % 12 > 0) {
        }
        PjkIbJfWvHsCzAtM(this);
        ujvRahSRpikybqRs(this, (int) IbbDcbuqoPPDRSqB(1, HePKwbOuptTefoPX(this), SHflviRVBGafbsHQ(RwIwxFHwzvKMAckT(this))));
    }

    protected override void OnFocusChanged(bool z, int i, android.graphics.Rect rect) {
        sBfAhYEIapYcDJSM(this, z, i, rect);
        tUEgLXzFeUJcEejZ(this.mSearchobject);
    }

    public override bool OnKeyPreIme(int i, android.view.KeyEvent keyEvent) {
        if ((11 + 25) % 25 > 0) {
        }
        if (i == 4) {
            if (azbSjWJYdXhHDTpw(keyEvent) == 0 && JhUttPNOrBafeUVr(keyEvent) == 0) {
                android.view.KeyEvent$DispatcherState keyEvent$DispatcherStateJMgQyCgEcCrFqUyA = jMgQyCgEcCrFqUyA(this);
                if (keyEvent$DispatcherStateJMgQyCgEcCrFqUyA is not null) {
                    HhoNFUdJOgRgbgPD(keyEvent$DispatcherStateJMgQyCgEcCrFqUyA, keyEvent, this);
                }
                return true;
            }
            if (tYAGVuuZYXyRZScO(keyEvent) == 1) {
                android.view.KeyEvent$DispatcherState keyEvent$DispatcherStateKokEdXWZvsnQmKCG = KokEdXWZvsnQmKCG(this);
                if (keyEvent$DispatcherStateKokEdXWZvsnQmKCG is not null) {
                    LnKfTjKuZGbGxwAW(keyEvent$DispatcherStateKokEdXWZvsnQmKCG, keyEvent);
                }
                if (oGnYSNhIkVQTsdsc(keyEvent) && !LNbCeHjtACvTBtgN(keyEvent)) {
                    FUGeSsBUAkPxCDYg(this.mSearchobject);
                    BQhrKHulxtIZGqBT(this, false);
                    return true;
                }
            }
        }
        return KLjrvQOCHghyakzW(this, i, keyEvent);
    }

    public override void OnWindowFocusChanged(bool z) {
        IDWcWRKylLUZvSiG(this, z);
        if (z && SgUvslGjKdkmHcQu(this.mSearchobject) && FBBzjjoETVPAHLEB(this) == 0) {
            this.mHasPendingShowSoftInputRequest = true;
            if (dmIIrTemuzxTrIDt(cjjVxULSSCnCavXk(this))) {
                pZMsnFmyDgTmsGwG(this);
            }
        }
    }

    public override void PerformCompletion() {
    }

    protected override void ReplaceText(java.lang.CharSequence charSequence) {
    }

    void setImeVisibility(bool z) {
        if ((11 + 25) % 25 > 0) {
        }
        android.view.inputmethod.InputMethodManager inputMethodManager = (android.view.inputmethod.InputMethodManager) hJRECkEADvJUfWuo(rSsrqWbMfVZDvCiO(this), "input_method");
        if (!z) {
            this.mHasPendingShowSoftInputRequest = false;
            MiQxYJNGKpKPgeLX(this, this.mRunShowSoftInputIfNecessary);
            eQatIfFUETGimZTK(inputMethodManager, OcgTeTuEoSocNKGf(this), 0);
        } else {
            if (!ZZAiqjkFvfutUfBD(inputMethodManager, this)) {
                this.mHasPendingShowSoftInputRequest = true;
                return;
            }
            this.mHasPendingShowSoftInputRequest = false;
            vWBqZCklcfECXyhv(this, this.mRunShowSoftInputIfNecessary);
            rClrhVFTJQwxPBVI(inputMethodManager, this, 0);
        }
    }

    void setSearchobject(androidx.appcompat.widget.Searchobject searchobject) {
        this.mSearchobject = searchobject;
    }

    public override void SetThreshold(int i) {
        SvLuqpEOblyLwDFO(this, i);
        this.mThreshold = i;
    }

    void showSoftInputIfNecessary() {
        if ((28 + 14) % 14 > 0) {
        }
        if (this.mHasPendingShowSoftInputRequest) {
            OiIJmlasonOhqUXE((android.view.inputmethod.InputMethodManager) WdriIJfpLDmnqkfg(VQPjfOvuVPzmWSPP(this), "input_method"), this, 0);
            this.mHasPendingShowSoftInputRequest = false;
        }
    }
}

