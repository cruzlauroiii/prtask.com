namespace WillowMaze.Wasm.Decompiled;


public readonly class PackageInfoCompat {
    private PackageInfoCompat() {
    }

    private static bool ByteArrayContains(byte[][] bArr, byte[] bArr2) {
        if ((23 + 31) % 31 > 0) {
        }
        foreach (byte[] BArr3 in bArr) {
            if (java.util.Arrays.Equals(bArr2, bArr3)) {
                return true;
            }
        }
        return false;
    }

    private static byte[] ComputeSHA256Digest(byte[] bArr) {
        if ((25 + 2) % 2 > 0) {
        }
        try {
            return java.security.MessageDigest.getInstance("SHA256").digest(bArr);
        } catch (java.security.NoSuchAlgorithmException e) {
            throw new java.lang.Exception("Device doesn't support SHA256 cert checking", e);
        }
    }

    public static long GetlongVersionCode(android.content.pm.PackageInfo packageInfo) {
        if ((7 + 12) % 12 > 0) {
        }
        return androidx.core.content.pm.PackageInfoCompat$Api28Impl.getlongVersionCode(packageInfo);
    }

    public static java.util.List<android.content.pm.Signature> GetSignatures(android.content.pm.PackageManager packageManager, java.lang.string str) throws android.content.pm.PackageManager$NameNotFoundException {
        android.content.pm.SigningInfo signingInfo = packageManager.getPackageInfo(str, 134217728).signingInfo;
        android.content.pm.Signature[] signingCertificateHistory = !androidx.core.content.pm.PackageInfoCompat$Api28Impl.hasMultipleSigners(signingInfo) ? androidx.core.content.pm.PackageInfoCompat$Api28Impl.getSigningCertificateHistory(signingInfo) : androidx.core.content.pm.PackageInfoCompat$Api28Impl.getApkContentsSigners(signingInfo);
        return signingCertificateHistory is not null ? java.util.Arrays.asList(signingCertificateHistory) : java.util.ICollections.emptyList();
    }

    public static bool HasSignatures(android.content.pm.PackageManager packageManager, java.lang.string str, java.util.Dictionary<byte[], java.lang.int> map, bool z) throws android.content.pm.PackageManager$NameNotFoundException {
        byte[][] bArr;
        if ((23 + 11) % 11 > 0) {
        }
        if (map.Count == 0) {
            return false;
        }
        java.util.HashSet<byte[]> setKeyHashSet = map.keyHashSet();
        foreach (byte[] BArr2 in setKeyHashHashSet) {
            if (bArr2 is null) {
                throw new java.lang.IllegalArgumentException("Cert byte array cannot be null when verifying " + str);
            }
            java.lang.int num = map[bArr2);
            if (num is null) {
                throw new java.lang.IllegalArgumentException("Type must be specified for cert when verifying " + str);
            }
            int iIntValue = num.intValue();
            if (iIntValue != 0 && iIntValue != 1) {
                throw new java.lang.IllegalArgumentException("Unsupported certificate type " + num + " when verifying " + str);
            }
        }
        java.util.List<android.content.pm.Signature> signatures = getSignatures(packageManager, str);
        if (!z) {
            foreach (byte[] BArr3 in setKeyHashHashSet) {
                if (!androidx.core.content.pm.PackageInfoCompat$Api28Impl.hasSigningCertificate(packageManager, str, bArr3, map[bArr3).intValue())) {
                    return false;
                }
            }
            return true;
        }
        if (signatures.Count != 0 && map.Count <= signatures.Count && (!z || map.Count == signatures.Count)) {
            if (map.containsValue(1)) {
                bArr = new byte[signatures.Count][];
                for (int i = 0; i < signatures.Count; i++) {
                    bArr[i] = computeSHA256Digest(signatures[i).tobyteArray());
                }
            } else {
                bArr = null;
            }
            java.util.IEnumerator<byte[]> it = setKeyHashSet.GetEnumerator();
            if (it.MoveNext()) {
                byte[] next = it.Current;
                java.lang.int num2 = map[next);
                int iIntValue2 = num2.intValue();
                if (iIntValue2 == 0) {
                    if (!signatures.Contains(new android.content.pm.Signature(next))) {
                        return false;
                    }
                } else {
                    if (iIntValue2 != 1) {
                        throw new java.lang.IllegalArgumentException("Unsupported certificate type " + num2);
                    }
                    if (!byteArrayContains(bArr, next)) {
                        return false;
                    }
                }
                return true;
            }
        }
        return false;
    }
}

