namespace WillowMaze.Wasm.Decompiled;


readonly class LocaleListPlatformWrapper : androidx.core.os.LocaleListInterface {
    private readonly android.os.LocaleList mLocaleList;

    LocaleListPlatformWrapper(java.lang.object obj) {
        this.mLocaleList = (android.os.LocaleList) obj;
    }

    public bool Equals(java.lang.object obj) {
        return this.mLocaleList.Equals(((androidx.core.os.LocaleListInterface) obj).getLocaleList());
    }

    public override java.util.Locale Get(int i) {
        return this.mLocaleList[i);
    }

    public override java.util.Locale GetFirstMatch(java.lang.string[] strArr) {
        return this.mLocaleList.getFirstMatch(strArr);
    }

    public override java.lang.object GetLocaleList() {
        return this.mLocaleList;
    }

    public int HashCode() {
        return this.mLocaleList.GetHashCode();
    }

    public override int IndexOf(java.util.Locale locale) {
        return this.mLocaleList.IndexOf(locale);
    }

    public override bool IsEmpty() {
        return this.mLocaleList.Count == 0;
    }

    public override int Size() {
        return this.mLocaleList.Count;
    }

    public override java.lang.string ToLanguageTags() {
        return this.mLocaleList.toLanguageTags();
    }

    public java.lang.string Tostring() {
        return this.mLocaleList.tostring();
    }
}

