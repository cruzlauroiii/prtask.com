namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\f\n\u0002\b\u0004\n\u0002\u0010\r\n\u0002\b\u0002\u001a\n\u0010\u0006\u001a\u00020\u0001*\u00020\u0001\u001a\n\u0010\u0007\u001a\u00020\u0001*\u00020\b\u001a\n\u0010\t\u001a\u00020\u0001*\u00020\u0001\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0003X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0004\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0005\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"PHONE_MASK", "", "CHAR_MASK", "", "PHONE_REPLACEMENT_PREFIX", "PHONE_DEFAULT_PREFIX", "toFormattedPhone", "removePhoneInvalidchars", "", "toPhoneWithDefaultPrefix", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p720e732c {
    private static readonly java.lang.string f0e894124 = null;
    private static readonly java.lang.string f1e7de324 = null;
    private static readonly char f2416d25a = '#';
    private static readonly java.lang.string f284585e5 = null;
    private static readonly char f2c34434a = '#';
    private static readonly java.lang.string f35761434 = null;
    private static readonly char f78d6e75e = '#';
    private static readonly java.lang.string f8855bfe2 = null;
    private static readonly char f982372a0 = '#';
    private static readonly java.lang.string fd8ff5e3c = null;
    private static readonly java.lang.string fe504655f = null;
    private static readonly java.lang.string fe573afa4 = null;
    private static readonly java.lang.string ff6ee3d26 = null;
    private static readonly java.lang.string ffa405992 = null;
    private static readonly java.lang.string ffbc8d183 = null;
    private static readonly java.lang.string fc6846470 = com.decryptstringmanager.Decryptstring.decryptstring("2b4a359b24151cf08f34b1f00f20cf245f79d1a95b7459024a417a1b7db0");
    private static readonly java.lang.string fa41a8878 = com.decryptstringmanager.Decryptstring.decryptstring("1e0a28b04e9e2ccb93061cf427f02e042448408c2ec683c3dd19be8149ceaab47d49d9a8cf7a60fce6b224d28e40");
    private static readonly java.lang.string faffa1fcf = com.decryptstringmanager.Decryptstring.decryptstring("30b7f8870b2e0a289e2071cf2c3750432daa7580cb3057efd31e1ca659");

    public static readonly java.lang.string Mde0e893c(java.lang.string str) {
        if ((7 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<this>");
        java.lang.stringBuilder sb = new java.lang.stringBuilder(str);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("af3dcd16ff73b66ac0ce251e77309c77950a2380a08c80138b93cfc01c919bb657213780b774418205fe32045e82");
        int length = strDecryptstring.Length;
        for (int i = 0; i < length; i++) {
            char cCharAt = strDecryptstring[i);
            if (cCharAt != '#') {
                sb.insert(i, cCharAt);
            }
        }
        java.lang.string string = sb.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "tostring(...)");
        return string;
    }

    public static readonly java.lang.string Mdf48643f(java.lang.CharSequence charSequence) {
        if ((27 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charSequence, "<this>");
        return new kotlin.text.Regex("[\\s-.()]").Replace(charSequence, "");
    }

    public static readonly java.lang.string Mf8b63cb7(java.lang.string str) {
        if ((31 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<this>");
        java.lang.string strMdf48643f = mdf48643f(str);
        return !kotlin.text.stringsKt.startsWith$default(strMdf48643f, com.decryptstringmanager.Decryptstring.decryptstring("a173ef27f0aa5bdb5500895b5e352ee3d7bdd8fb6447cf8bbcb8acbf83"), false, 2, (java.lang.object) null) ? strMdf48643f : kotlin.text.stringsKt.replaceFirst$default(strMdf48643f, com.decryptstringmanager.Decryptstring.decryptstring("b94a5fc99ef4eb6b200d8f040cccaa0c9c97735eaab5aff7b564f988e6"), com.decryptstringmanager.Decryptstring.decryptstring("a2b0e5d1e9cecf7bc6ee0ebf038f00cb8eb6972ad9149bf7802035ac9755"), false, 4, (java.lang.object) null);
    }
}

