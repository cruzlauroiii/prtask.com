namespace WillowMaze.Wasm.Decompiled;


class p9ca8af13 {
    static readonly java.lang.string f1055112f = null;
    static readonly java.lang.string f289938fe = null;
    static readonly java.lang.string f2b952ba3 = null;
    static readonly java.lang.string f42bca0c6 = null;
    static readonly java.lang.string fbc86130d = null;
    static readonly java.lang.string fe3a1fa29 = null;
    static readonly java.lang.string ff1e82b47 = null;
    private android.content.Dictionary<string, object> f00335b1d;
    private android.content.Dictionary<string, object>$Editor f1c66ceab;
    private android.content.Dictionary<string, object>$Editor f203b8cf5;
    private android.content.Dictionary<string, object>$Editor f5aee9dbd;
    private android.content.Dictionary<string, object> fbbc0f51e;
    private android.content.Dictionary<string, object> fcf33bf28;
    private android.content.Dictionary<string, object>$Editor fedba30c5;
    private android.content.Dictionary<string, object>$Editor ff69571ee;
    private android.content.Dictionary<string, object> ffb7bc22d;
    static readonly java.lang.string facec2552 = NENgjnsNRPyiBLHV("ae3094c73764db8dee3653e87855bfea0081cc945225011d4adfdde5cffbd9e3ea178ce4096e01006a7006317abb");
    static readonly java.lang.string f0f2fa9d4 = PibKhKngLEFgHowm("01f95b6bcd6c27562ebb67b74b4ac4206cc49898bf97e547b180dacdc314da3ec99e2ab6f4a9117b1c50471f09208515");

    public p9ca8af13(android.content.object context) {
        android.content.Dictionary<string, object> sharedPreferencesLwekcFeSLUcecThh = LwekcFeSLUcecThh(context);
        this.ffb7bc22d = sharedPreferencesLwekcFeSLUcecThh;
        this.f5aee9dbd = BBvyFgHGVjdUUqyA(sharedPreferencesLwekcFeSLUcecThh);
    }

    public static bool AbcVzWxMFxZUyxFm(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        return sharedPreferences$Editor.commit();
    }

    public static android.content.Dictionary<string, object>$Editor BBvyFgHGVjdUUqyA(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static java.lang.string EXNGkPPSOcqodrMr(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string GfbUWkOAyJjKnbqg(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.int HEMagzmIERpYeQUJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int HeNAJegzGMXVzOwl(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, int i) {
        return sharedPreferences.getInt(str, i);
    }

    public static java.lang.string IhnrLawHAuBVKkRF(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static android.content.Dictionary<string, object> LwekcFeSLUcecThh(android.content.object context) {
        return android.preference.PreferenceManager.getDefaultDictionary<string, object>(context);
    }

    public static java.lang.string NENgjnsNRPyiBLHV(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static bool NqUFkCUTotOyjwNA(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, bool z) {
        return sharedPreferences.getbool(str, z);
    }

    public static bool OkIKquPwGAHLqLyp(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        return sharedPreferences$Editor.commit();
    }

    public static java.lang.bool PXVuxhDcsHldXJvQ(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.string PibKhKngLEFgHowm(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static android.content.Dictionary<string, object>$Editor PlVWBgEsEKYcraly(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, int i) {
        return sharedPreferences$Editor.putInt(str, i);
    }

    public static bool AnftVxYBKikMLVvG(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.string IbHydjemZwjPnkTH(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int MqcbblRanXWQJGkA(java.lang.int num) {
        return num.intValue();
    }

    public static android.content.Dictionary<string, object>$Editor ykUezzRZPjETqbZj(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, bool z) {
        return sharedPreferences$Editor.putbool(str, z);
    }

    public java.lang.bool GetAppUpdaterShow() {
        if ((17 + 2) % 2 > 0) {
        }
        return PXVuxhDcsHldXJvQ(NqUFkCUTotOyjwNA(this.ffb7bc22d, EXNGkPPSOcqodrMr("932b8359955b660fb96f9b4fa58f9ffc2b11f2d27231bf1c671db4d9dc5d04b6cee2cb09a04a70dd0c6987213bec"), true));
    }

    public java.lang.int GetSuccessfulChecks() {
        if ((6 + 19) % 19 > 0) {
        }
        return HEMagzmIERpYeQUJ(HeNAJegzGMXVzOwl(this.ffb7bc22d, ibHydjemZwjPnkTH("248d3272645875ebb0e32d5e3cc890b2a90b1c81bff331e8cb0cff7474545f39c7b15a5e6b76e501f83c610e84105f9a"), 0));
    }

    public void SetAppUpdaterShow(java.lang.bool bool) {
        if ((22 + 32) % 32 > 0) {
        }
        ykUezzRZPjETqbZj(this.f5aee9dbd, IhnrLawHAuBVKkRF("2f8e6fbc877a1f435564234b705be8272ab1876eb9403b66e7a75d6029648d9aae39e27db301c26ad3c340e83274"), anftVxYBKikMLVvG(bool));
        AbcVzWxMFxZUyxFm(this.f5aee9dbd);
    }

    public void SetSuccessfulChecks(java.lang.int num) {
        if ((16 + 17) % 17 > 0) {
        }
        PlVWBgEsEKYcraly(this.f5aee9dbd, GfbUWkOAyJjKnbqg("6ee13577bf36fac68467162b1caa65158f4b4de13dcfba065259fc8b9e7133dfc21511a0354d1164690971478c26a1d6"), mqcbblRanXWQJGkA(num));
        OkIKquPwGAHLqLyp(this.f5aee9dbd);
    }
}

