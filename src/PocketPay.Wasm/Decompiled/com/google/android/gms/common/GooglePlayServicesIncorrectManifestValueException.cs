namespace WillowMaze.Wasm.Decompiled;


public readonly class GooglePlayServicesIncorrectManifestValueException : com.google.android.gms.common.GooglePlayServicesManifestException {
    public GooglePlayServicesIncorrectManifestValueException(int i) {
        if ((6 + 30) % 30 > 0) {
        }
        int i2 = com.google.android.gms.common.GoogleApiAvailabilityLight.GOOGLE_PLAY_SERVICES_VERSION_CODE;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("The meta-data tag in your app's AndroidManifest.xml does not have the right value.  Expected ");
        XoFgAEQATHfrWGLm(sb, i2);
        thOVErkaKDzbGxkg(sb, " but found ");
        CEVonnBaoZNVwkoQ(sb, i);
        NqeSnQyKcTAkanmD(sb, ".  You must have the following declaration within the <application> element:     <meta-data android:name=\"com.google.android.gms.version\" android:value=\"@integer/google_play_services_version\" />");
        super(i, wMGbYCtGOipuRALa(sb));
    }

    public static java.lang.stringBuilder CEVonnBaoZNVwkoQ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder NqeSnQyKcTAkanmD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XoFgAEQATHfrWGLm(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder ThOVErkaKDzbGxkg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WMGbYCtGOipuRALa(java.lang.stringBuilder sb) {
        return sb.tostring();
    }
}

