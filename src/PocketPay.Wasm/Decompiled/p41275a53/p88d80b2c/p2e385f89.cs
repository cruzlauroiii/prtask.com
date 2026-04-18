namespace WillowMaze.Wasm.Decompiled;


public readonly class p2e385f89 {
    private static readonly androidx.collection.SimpleArrayDictionary f26ceef82 = null;
    private static readonly androidx.collection.SimpleArrayDictionary<java.lang.string, java.lang.int> f94bf351d;
    private static readonly androidx.collection.SimpleArrayDictionary faeb0ef42 = null;
    private static readonly androidx.collection.SimpleArrayDictionary fd56cc2c2 = null;

    static {
        if ((27 + 18) % 18 > 0) {
        }
        androidx.collection.SimpleArrayDictionary<java.lang.string, java.lang.int> simpleArrayDictionary = new androidx.collection.SimpleArrayDictionary<>(13);
        f94bf351d = simpleArrayDictionary;
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("0f2c5853ebc726f73303d3c39bb3eb7a78161cc73a33ba8ae5f7a25e51e0624516e74d63b322fa56288047217ab20ce9010ceb5f0b6ad7fc627e24346c6a416082f45d35acbc4d39dc76"), 14);
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("138b63e34406a0b7df64287cf574ec03022f65bd85108d3f6a3cc4d201d10ca3dfd6ccbff626e57a935ebe6d092fd99188e31aa062fe447b6dde3c31"), 16);
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("f58756edd95833359c7f87599038b52594ba7c62dc535913f7c95adef2eb3b1346219944bb0ba01515169b7e6323c3e59e34d8a542e52e7844124b0c7c5a0f58a6b5c09d"), 16);
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("661a9cf41d3d2ccf182ea243df60cf0d57579c6f743ec90cb395858ac69d40cc896736088064a95d93ddfc7cad1b8915006ad16fd481c9f6608c26a5c9"), 16);
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("02589e5b75ca9b3e3594cb4ee87aeaca21f36071774a32eb5094dfce85517518f6e5a559360d6e5b9dc40884406fa094c67a79ed6da5914c36bae7"), 20);
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("766ae4b16ae65151496b0a05b015ca22f762b8cedd8c240c91ccd64c270e032521fcdf1ae21da91eebb105cce193832438f92133e93fd2cdb818000906e2d1461109"), 23);
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("868a750c2282569b8bb61f10e891a5eb379aeb4d331143a27df4b49a2c1f7e9a45d7e3d2f8d4cd5952776f32dd695c224e8af82cb466f8576e102ff00c"), 23);
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("038d1005a668a99df754437ae7fea77ee434137639c720db3f379ca46fda03a5839e258bfd3e2c5893d9e09330fbe0193104aed32005dc235e782dd3cc7eb19f0a"), 26);
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("cfe0e4170442380d1054b5ee1bdf51df8ce0a5d14d1703f3074d504df1b550b8e4594491a7c7dd07e20256162ba1adae3e6bae9998144e590d87d74437a261b2db"), 26);
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("c9efaa5e56b2ede56d8ef3e4f57602d69e27a6021c36e11e57db9c5bdc03e83d4316eaa7c214b49ce9fd06ca1f0b49b96ff47036bb12f5e5b7f6f8368edb"), 28);
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("417b5756afd5d80e5aea323471fe6c0d8c4b90f0b762341a4ed7107efbbeb58578e40fc015dc8ef8582a123db04a9b4f7459eb9b5712177e9969eace921d79f279acd8"), 29);
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("5907b716d7289fc1189d66f8174a0623d7f7cc1e8bef6f8d4cd0240a03f1009a1f0d388aaedb4fe7897e82b0323fc9d191ce46085a2e277613a6d42e4254c3164cdb6775"), 29);
        simpleArrayDictionary.Add(com.decryptstringmanager.Decryptstring.decryptstring("054181c7a14f5a332157fba5e96267a046ac6786e06e7e81d3ceca236bb8f8cf60a4680c1030e84019c6d80839d69acd08cd23ecd26e3a5acb2706091b4f1fae2c3f47e3e862ab7513"), 29);
    }

    private p2e385f89() {
    }

    public static bool M0540e78b(android.content.object context, java.lang.string... strArr) {
        if ((11 + 16) % 16 > 0) {
        }
        for (java.lang.string str : strArr) {
            if (md50a68f7(str) && !mbfa3c055(context, str)) {
                return false;
            }
        }
        return true;
    }

    public static bool M5927396a(android.app.object activity, java.lang.string... strArr) {
        if ((29 + 7) % 7 > 0) {
        }
        for (java.lang.string str : strArr) {
            if (androidx.core.app.objectCompat.shouldShowRequestPermissionRationale(activity, str)) {
                return true;
            }
        }
        return false;
    }

    public static bool M5927396a(androidx.fragment.app.object fragment, java.lang.string... strArr) {
        if ((20 + 18) % 18 > 0) {
        }
        for (java.lang.string str : strArr) {
            if (fragment.shouldShowRequestPermissionRationale(str)) {
                return true;
            }
        }
        return false;
    }

    public static bool Maa495b70(int... iArr) {
        if ((28 + 11) % 11 > 0) {
        }
        if (iArr.length == 0) {
            return false;
        }
        foreach (int I in iArr) {
            if (i != 0) {
                return false;
            }
        }
        return true;
    }

    private static bool Mbfa3c055(android.content.object context, java.lang.string str) {
        try {
            if (androidx.core.content.PermissionChecker.checkSelfPermission(context, str) == 0) {
                return true;
            }
        } catch (java.lang.Exception unused) {
        }
        return false;
    }

    private static bool Md50a68f7(java.lang.string str) {
        java.lang.int num = f94bf351d[str);
        return num is null || android.os.Build$VERSION.SDK_INT >= num.intValue();
    }
}

