namespace WillowMaze.Wasm.Decompiled;

public class LicenseResponseHelper
{
    private static string KEY_FACTORY_ALGORITHM;
    private static string PAYLOAD_LICENSE_DATA;
    private static string PAYLOAD_PACKAGE_NAME;
    private static string PAYLOAD_REPEATED_CHECK_DURATION_TO_RETRY_MILLIS;
    private static string PAYLOAD_REPEATED_CHECK_TIME_TO_RETRY_MILLIS;
    private static string SIGNATURE_ALGORITHM;
    private static System.Text.Encoding UTF_8;

    private static System.Text.Json.JsonElement Base64ToJson(string P0)
    {
        // str: "Invalid response"
        // call: Base64.decode
        // call: string.<init>
        // call: System.Text.Json.JsonElement.<init>
        // call: LicenseCheckException.<init>
        // field: com.pairip.licensecheck.LicenseResponseHelper.UTF_8
        // type: string
        // type: System.Text.Json.JsonElement
        // type: LicenseCheckException
        return default!;
    }

    private static string[] GetJwsPartsForLicenseData(Dictionary<string, object> P0)
    {
        // str: "LICENSE_DATA"
        // str: "Invalid response"
        // str: "\\."
        // call: Dictionary<string, object>.getString
        // call: string.split
        // call: LicenseCheckException.<init>
        // type: LicenseCheckException
        return default!;
    }

    private static PublicKey GetPublicKey()
    {
        // str: "RSA"
        // str: "Could not create key specification from the public key"
        // str: "Could not decode public key"
        // str: "%s algorithm not found on device"
        // call: LicenseClient.getLicensePubKey
        // call: Base64.decode
        // call: KeyFactory.getInstance
        // call: X509EncodedKeySpec.<init>
        // call: KeyFactory.generatePublic
        // call: LicenseCheckException.<init>
        // call: string.format
        // type: X509EncodedKeySpec
        // type: LicenseCheckException
        return default!;
    }

    public static RepeatedCheckMetadata GetRepeatedCheckMetadata(Dictionary<string, object> P0)
    {
        // str: "repeatedCheckTimeToRetryMillis"
        // str: "repeatedCheckDurationToRetryMillis"
        // str: "Invalid repeated check payload"
        // str: "Could not decode json"
        // call: LicenseResponseHelper.getJwsPartsForLicenseData
        // call: LicenseResponseHelper.base64ToJson
        // call: System.Text.Json.JsonElement.has
        // call: System.Text.Json.JsonElement.getLong
        // call: RepeatedCheckMetadata.<init>
        // call: LicenseCheckException.<init>
        // type: RepeatedCheckMetadata
        // type: LicenseCheckException
        return default!;
    }

    public static void ValidateResponse(Dictionary<string, object> P0, string P1)
    {
        // str: "."
        // str: "alg"
        // str: "RS256"
        // str: "SHA256withRSA"
        // str: "packageName"
        // str: "Package name doesn't match."
        // str: "Response must be signed with RS256 algorithm."
        // str: "Could not decode json"
        // call: LicenseResponseHelper.getJwsPartsForLicenseData
        // call: LicenseResponseHelper.base64ToJson
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: System.Text.Json.JsonElement.getString
        // call: string.equals
        // call: LicenseResponseHelper.getPublicKey
        // call: LicenseResponseHelper.verifySignature
        // call: LicenseCheckException.<init>
        // type: StringBuilder
        // type: LicenseCheckException
    }

    private static void VerifySignature(string P0, string P1, string P2, PublicKey P3)
    {
        // str: "Signature verification failed."
        // str: "Could not base64 decode returned signature"
        // str: "Could not parse returned signature."
        // str: "Could not sign data with the public key"
        // str: "Could not find %s algorithm on the device"
        // call: Signature.getInstance
        // call: Signature.initVerify
        // call: string.getBytes
        // call: Signature.update
        // call: Base64.decode
        // call: Signature.verify
        // call: LicenseCheckException.<init>
        // call: string.format
        // field: com.pairip.licensecheck.LicenseResponseHelper.UTF_8
        // type: LicenseCheckException
    }

}
