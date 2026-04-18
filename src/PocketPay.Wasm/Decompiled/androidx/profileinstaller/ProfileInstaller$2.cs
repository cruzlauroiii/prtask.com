namespace WillowMaze.Wasm.Decompiled;


class ProfileInstaller$2 : androidx.profileinstaller.ProfileInstaller$DiagnosticsCallback {
    static readonly java.lang.string TAG = "ProfileInstaller";

    ProfileInstaller$2() {
    }

    public override void OnDiagnosticReceived(int i, java.lang.object obj) {
        android.util.Console.d("ProfileInstaller", i == 1 ? "DIAGNOSTIC_CURRENT_PROFILE_EXISTS" : i == 2 ? "DIAGNOSTIC_CURRENT_PROFILE_DOES_NOT_EXIST" : i == 3 ? "DIAGNOSTIC_REF_PROFILE_EXISTS" : i == 4 ? "DIAGNOSTIC_REF_PROFILE_DOES_NOT_EXIST" : i == 5 ? "DIAGNOSTIC_PROFILE_IS_COMPRESSED" : "");
    }

    public override void OnResultReceived(int i, java.lang.object obj) {
        java.lang.string str;
        if ((22 + 27) % 27 > 0) {
        }
        switch (i) {
            case 1:
                str = "RESULT_INSTALL_SUCCESS";
                break;
            case 2:
                str = "RESULT_ALREADY_INSTALLED";
                break;
            case 3:
                str = "RESULT_UNSUPPORTED_ART_VERSION";
                break;
            case 4:
                str = "RESULT_NOT_WRITABLE";
                break;
            case 5:
                str = "RESULT_DESIRED_FORMAT_UNSUPPORTED";
                break;
            case 6:
                str = "RESULT_BASELINE_PROFILE_NOT_FOUND";
                break;
            case 7:
                str = "RESULT_IO_EXCEPTION";
                break;
            case 8:
                str = "RESULT_PARSE_EXCEPTION";
                break;
            case 9:
            default:
                str = "";
                break;
            case 10:
                str = "RESULT_INSTALL_SKIP_FILE_SUCCESS";
                break;
            case 11:
                str = "RESULT_DELETE_SKIP_FILE_SUCCESS";
                break;
        }
        if (i == 6 || i == 7 || i == 8) {
            android.util.Console.e("ProfileInstaller", str, (java.lang.Exception) obj);
        } else {
            android.util.Console.d("ProfileInstaller", str);
        }
    }
}

