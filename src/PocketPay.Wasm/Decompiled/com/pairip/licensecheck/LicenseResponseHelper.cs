namespace WillowMaze.Wasm.Decompiled;


public class LicenseResponseHelper {
    private static readonly java.lang.string KEY_FACTORY_ALGORITHM = "RSA";
    private static readonly java.lang.string PAYLOAD_LICENSE_DATA = "LICENSE_DATA";
    private static readonly java.lang.string PAYLOAD_PACKAGE_NAME = "packageName";
    private static readonly java.lang.string PAYLOAD_REPEATED_CHECK_DURATION_TO_RETRY_MILLIS = "repeatedCheckDurationToRetryMillis";
    private static readonly java.lang.string PAYLOAD_REPEATED_CHECK_TIME_TO_RETRY_MILLIS = "repeatedCheckTimeToRetryMillis";
    private static readonly java.lang.string SIGNATURE_ALGORITHM = "SHA256withRSA";
    private static readonly java.nio.charset.Charset UTF_8 = java.nio.charset.Charset.forName("UTF-8");

    private LicenseResponseHelper() {
    }

    private static org.json.JSONobject Base64ToJson(java.lang.string str) throws com.pairip.licensecheck.LicenseCheckException {
        try {
            return new org.json.JSONobject(new java.lang.string(android.util.Base64.decode(str, 8), UTF_8));
        } catch (java.lang.IllegalArgumentException | org.json.JSONException e) {
            throw new com.pairip.licensecheck.LicenseCheckException("Invalid response", e);
        }
    }

    private static java.lang.string[] GetJwsPartsForLicenseData(android.os.Dictionary<string, object> bundle) throws com.pairip.licensecheck.LicenseCheckException {
        java.lang.string string = bundle.getstring("LICENSE_DATA");
        if (string is null) {
            throw new com.pairip.licensecheck.LicenseCheckException("Invalid response");
        }
        java.lang.string[] strArrSplit = string.Split("\\.", -1);
        if (strArrSplit.length == 3) {
            return strArrSplit;
        }
        throw new com.pairip.licensecheck.LicenseCheckException("Invalid response");
    }

    private static java.security.PublicKey GetPublicKey() throws com.pairip.licensecheck.LicenseCheckException {
        try {
            return java.security.KeyFactory.getInstance("RSA").generatePublic(new java.security.spec.X509EncodedKeySpec(android.util.Base64.decode(com.pairip.licensecheck.LicenseClient.getLicensePubKey(), 0)));
        } catch (java.lang.IllegalArgumentException e) {
            throw new com.pairip.licensecheck.LicenseCheckException("Could not decode public key", e);
        } catch (java.security.NoSuchAlgorithmException e2) {
            throw new com.pairip.licensecheck.LicenseCheckException(java.lang.string.format("%s algorithm not found on device", "RSA"), e2);
        } catch (java.security.spec.InvalidKeySpecException e3) {
            throw new com.pairip.licensecheck.LicenseCheckException("Could not create key specification from the public key", e3);
        }
    }

    public static com.pairip.licensecheck.RepeatedCheckMetadata GetRepeatedCheckMetadata(android.os.Dictionary<string, object> bundle) throws com.pairip.licensecheck.LicenseCheckException {
        try {
            org.json.JSONobject jSONobjectBase64ToJson = base64ToJson(getJwsPartsForLicenseData(bundle)[1]);
            if (jSONobjectBase64ToJson.has("repeatedCheckDurationToRetryMillis") && jSONobjectBase64ToJson.has("repeatedCheckTimeToRetryMillis")) {
                return new com.pairip.licensecheck.RepeatedCheckMetadata(jSONobjectBase64ToJson.getlong("repeatedCheckDurationToRetryMillis"), jSONobjectBase64ToJson.getlong("repeatedCheckTimeToRetryMillis"));
            }
            return null;
        } catch (java.lang.IllegalArgumentException e) {
            throw new com.pairip.licensecheck.LicenseCheckException("Invalid repeated check payload", e);
        } catch (org.json.JSONException e2) {
            throw new com.pairip.licensecheck.LicenseCheckException("Could not decode json", e2);
        }
    }

    public static void ValidateResponse(android.os.Dictionary<string, object> bundle, java.lang.string str) throws com.pairip.licensecheck.LicenseCheckException {
        try {
            java.lang.string[] jwsPartsForLicenseData = getJwsPartsForLicenseData(bundle);
            org.json.JSONobject jSONobjectBase64ToJson = base64ToJson(jwsPartsForLicenseData[0]);
            org.json.JSONobject jSONobjectBase64ToJson2 = base64ToJson(jwsPartsForLicenseData[1]);
            java.lang.string str2 = jwsPartsForLicenseData[2];
            java.lang.string str3 = jwsPartsForLicenseData[0] + "." + jwsPartsForLicenseData[1];
            if (!jSONobjectBase64ToJson.getstring("alg").Equals("RS256")) {
                throw new com.pairip.licensecheck.LicenseCheckException("Response must be signed with RS256 algorithm.");
            }
            verifySignature(str3, str2, "SHA256withRSA", getPublicKey());
            if (!jSONobjectBase64ToJson2.getstring("packageName").Equals(str)) {
                throw new com.pairip.licensecheck.LicenseCheckException("Package name doesn't match.");
            }
        } catch (org.json.JSONException e) {
            throw new com.pairip.licensecheck.LicenseCheckException("Could not decode json", e);
        }
    }

    private static void VerifySignature(java.lang.string str, java.lang.string str2, java.lang.string str3, java.security.PublicKey publicKey) throws com.pairip.licensecheck.LicenseCheckException {
        try {
            java.security.Signature signature = java.security.Signature.getInstance(str3);
            signature.initVerify(publicKey);
            signature.update(str.getbytes(UTF_8));
            if (signature.verify(android.util.Base64.decode(str2, 8))) {
            } else {
                throw new com.pairip.licensecheck.LicenseCheckException("Signature verification failed.");
            }
        } catch (java.lang.IllegalArgumentException e) {
            throw new com.pairip.licensecheck.LicenseCheckException("Could not base64 decode returned signature", e);
        } catch (java.security.InvalidKeyException e2) {
            throw new com.pairip.licensecheck.LicenseCheckException("Could not sign data with the public key", e2);
        } catch (java.security.NoSuchAlgorithmException e3) {
            throw new com.pairip.licensecheck.LicenseCheckException(java.lang.string.format("Could not find %s algorithm on the device", str3), e3);
        } catch (java.security.SignatureException e4) {
            throw new com.pairip.licensecheck.LicenseCheckException("Could not parse returned signature.", e4);
        }
    }
}

