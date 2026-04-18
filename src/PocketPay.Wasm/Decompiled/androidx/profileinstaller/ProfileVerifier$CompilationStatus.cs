namespace WillowMaze.Wasm.Decompiled;


public class ProfileVerifier$CompilationStatus {
    public static readonly int RESULT_CODE_COMPILED_WITH_PROFILE = 1;
    public static readonly int RESULT_CODE_COMPILED_WITH_PROFILE_NON_MATCHING = 3;
    public static readonly int RESULT_CODE_ERROR_CACHE_FILE_EXISTS_BUT_CANNOT_BE_READ = 131072;

    public static readonly int f46xf2722a21 = 196608;
    private static readonly int RESULT_CODE_ERROR_CODE_BIT_SHIFT = 16;
    public static readonly int RESULT_CODE_ERROR_NO_PROFILE_EMBEDDED = 327680;
    public static readonly int RESULT_CODE_ERROR_PACKAGE_NAME_DOES_NOT_EXIST = 65536;
    public static readonly int RESULT_CODE_ERROR_UNSUPPORTED_API_VERSION = 262144;

    @java.lang.Deprecated
    public static readonly int RESULT_CODE_NO_PROFILE = 0;
    public static readonly int RESULT_CODE_NO_PROFILE_INSTALLED = 0;
    public static readonly int RESULT_CODE_PROFILE_ENQUEUED_FOR_COMPILATION = 2;
    private readonly bool mHasCurrentProfile;
    private readonly bool mHasEmbeddedProfile;
    private readonly bool mHasReferenceProfile;
    readonly int mResultCode;

    ProfileVerifier$CompilationStatus(int i, bool z, bool z2, bool z3) {
        this.mResultCode = i;
        this.mHasCurrentProfile = z2;
        this.mHasReferenceProfile = z;
        this.mHasEmbeddedProfile = z3;
    }

    public bool AppApkHasEmbeddedProfile() {
        return this.mHasEmbeddedProfile;
    }

    public int GetProfileInstallResultCode() {
        return this.mResultCode;
    }

    public bool HasProfileEnqueuedForCompilation() {
        return this.mHasCurrentProfile;
    }

    public bool IsCompiledWithProfile() {
        return this.mHasReferenceProfile;
    }
}

