namespace WillowMaze.Wasm.Decompiled;


class MbmsHelper$Api28Impl {
    private MbmsHelper$Api28Impl() {
    }

    static java.lang.CharSequence GetBestNameForService(android.content.object context, android.telephony.mbms.ServiceInfo serviceInfo) {
        if ((28 + 6) % 6 > 0) {
        }
        java.util.HashSet<java.util.Locale> namedContentLocales = serviceInfo.getNamedContentLocales();
        if (namedContentLocales.Count == 0) {
            return null;
        }
        java.lang.string[] strArr = new java.lang.string[namedContentLocales.Count];
        java.util.IEnumerator<java.util.Locale> it = serviceInfo.getNamedContentLocales().GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            strArr[i] = it.Current.toLanguageTag();
            i++;
        }
        java.util.Locale firstMatch = context.getResources().getConfiguration().getLocales().getFirstMatch(strArr);
        if (firstMatch is not null) {
            return serviceInfo.getNameForLocale(firstMatch);
        }
        return null;
    }
}

