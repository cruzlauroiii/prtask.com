namespace WillowMaze.Wasm.Decompiled;


class LicenseClient$2 : com.pairip.licensecheck.ILicenseV2ResultListener$Stub {
    readonly com.pairip.licensecheck.LicenseClient val$client;

    LicenseClient$2(com.pairip.licensecheck.LicenseClient licenseClient) {
        this.val$client = licenseClient;
    }

    public override void VerifyLicense(int i, android.os.Dictionary<string, object> bundle) {
        com.pairip.licensecheck.LicenseClient.m930$$Nest$mprocessResponse(this.val$client, i, bundle);
    }
}

