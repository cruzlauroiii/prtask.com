namespace WillowMaze.Wasm.Decompiled;

public class Pcc91dae7 : Pe8cda3fc
{
    public static string F0671aed8;
    public static string F07d8fac1;
    public static string F0918bb59;
    public static string F1170a4f8;
    public static string F14a0a16c;
    public static string F15e76f33;
    public static string F19bbfcfc;
    public static string F231f4b93;
    public static string F23afff8d;
    public static string F23b4b22a;
    public static string F253924b5;
    public static string F25c4ae77;
    public static string F26c1113e;
    public static string F2855f453;
    public static string F2be6ac96;
    private static pcc91dae7$p910eef8c F2e4410d9;
    public static string F2ec59e46;
    public static string F35f3c557;
    public static string F376fa1b1;
    public static string F37705ebf;
    public static string F3a64e0b7;
    public static string F3b5ad806;
    public static string F3b96433d;
    public static string F43235254;
    public static string F49ff9c01;
    public static string F4c16c8b9;
    public static string F50566acb;
    public static string F548f579c;
    public static string F5dd8dc6a;
    public static string F5e0fa327;
    public static string F5e71b8a0;
    public static string F60a605b8;
    public static string F65776ba2;
    public static string F81eaf506;
    public static string F82f3fad0;
    public static string F8746c3a6;
    private static pcc91dae7$p910eef8c F8e2699be;
    private static pcc91dae7$p910eef8c F910eef8c;
    public static string F9430c4cd;
    public static string F9d4231f2;
    public static string F9e2fb69f;
    public static string F9f277dd9;
    public static string Fa2804329;
    public static string Fa4f3689b;
    public static string Fa5d89229;
    public static string Fa74b2f17;
    public static string Fad1d138c;
    public static string Faf269d1d;
    public static string Fb1a3a6ab;
    public static string Fb2980b0c;
    public static string Fb2b5c1e0;
    public static string Fb56188d1;
    public static string Fb983809c;
    public static string Fbdcf6e06;
    public static string Fd5249db6;
    public static string Fd9b8086c;
    public static string Fe25bef8e;
    public static string Fe578a45a;
    public static string Fe816ba1d;
    public static string Fe9df55e8;
    public static string Fea3ed7d8;
    public static string Fef6e6183;
    public static string Ff2b265dd;
    public static string Ff421176f;
    public static string Ff45098f3;
    private readonly pa768caa9 F68c4283d;
    private readonly pa768caa9 F87c0cedc;
    private readonly pa768caa9 Fa7dffb48;
    private readonly pa768caa9 Fdc032c7b;

    private ValueTuple<object, object>[] M514fcc32(string P0, string P1)
    {
        // str: "f171264249008f28bc4e88bac0331038da42da676c59788e6dadef298847d60a2606bd45a39cc2"
        // str: "7ba0dc834036bf6850d5c96d35563986f30b0a2cac9ccac6f9c65d609bcaf86978bd58cd33"
        // call: TuplesKt.to
        // call: DecryptString.decryptString
        return default!;
    }

    public void ReportAuthErrorEvent()
    {
        // str: "a72eb151bf74f7addbe61e357c69a59a791dbc75d0077afe1a5037e0d5756266362ab03eeff6f665ee2ec0"
        // call: DecryptString.decryptString
        // call: pa768caa9.reportEvent
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportAuthSuccessEvent()
    {
        // str: "127c4ef2dc853ea2a5e81b4d47cc54d8a3c516ce3cbf65423ab44b5f1f32af372d39fa96328fea8a3cd2607b39"
        // call: DecryptString.decryptString
        // call: pa768caa9.reportEvent
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportAuthorizationErrorCancelEvent()
    {
        // str: "0324e9e23990cedcfc29daa6443e85d082b51d3efa1e00d8ec3a77dd2ee08a6459c2aace881a71cf8ac7ec045fb7120f8..."
        // call: DecryptString.decryptString
        // call: pa768caa9.reportEvent
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportAuthorizationErrorSupportEvent()
    {
        // str: "584c156b5e200286b5a7b5edd3e5058dc1a92c6e5c6aade344fd0f81434df15a8cc58ad5129f1f6f2874bbcf726540d6b..."
        // call: pa768caa9.reportEvent
        // call: DecryptString.decryptString
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportAutoLoginErrorEvent(string P0, string P1)
    {
        // str: "employeeId"
        // str: "deviceId"
        // str: "e87566b562feb2aaef25741dce47c1f8e241ff9e919cd193464d6dc16a87dadbebaeb3646e3711f38808a1bce2d94e527a"
        // call: pcc91dae7.m514fcc32
        // call: DecryptString.decryptString
        // call: Intrinsics.checkNotNullParameter
        // call: Arrays.copyOf
        // call: pa768caa9.reportEvent
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportAutoLoginSuccessEvent(string P0, string P1)
    {
        // str: "31e4aec0e66d8d16efbd86d9a436c6b2c5c99bec67a87a8404b354e96283916aa11f67b95f10af84b965b43f3ce7e61fc..."
        // str: "deviceId"
        // str: "employeeId"
        // call: Intrinsics.checkNotNullParameter
        // call: pa768caa9.reportEvent
        // call: pcc91dae7.m514fcc32
        // call: Arrays.copyOf
        // call: DecryptString.decryptString
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportDeviceIsBlockedCancelEvent()
    {
        // str: "762915d6d39bf86f5544563dd31d617e5b324c8093c9ad05346baa61e6f48141acf1f45c88d212f94ef212b19e787dad6..."
        // call: DecryptString.decryptString
        // call: pa768caa9.reportEvent
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportDeviceIsBlockedSupportEvent()
    {
        // str: "8f3a2017972e7f302d38f8d3b40001ce29883d21fa7c0aa84b9cfa64f2d76c86ccd041fe4b5fd9ae13827f4b5c55cadd6..."
        // call: DecryptString.decryptString
        // call: pa768caa9.reportEvent
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportOpenTophEvent(string P0)
    {
        // str: "659b79d64b71b0c3f775753087e3367c87a8ebc17317d08e2f5a8b8bfe3dbfd1370e750065d2be517c3732c3"
        // str: "4b59002de870eb1b2c9eac3ee5e4c8e7c8c693192923a0cf57eb6fa54e8db37fe080c51c2a"
        // str: "startTapOnPhoneRoute"
        // call: DecryptString.decryptString
        // call: TuplesKt.to
        // call: pa768caa9.reportEvent
        // call: Intrinsics.checkNotNullParameter
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportPaymentPaybackErrorEvent()
    {
        // str: "5ecf64fb4e7559ab4f6174dcebc458e2d2c6dadaaad0ece2c09a552cd41255bda134e3da41c505d31f05e16e2f2f9746b..."
        // call: DecryptString.decryptString
        // call: pa768caa9.reportEvent
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportPaymentPaybackSuccessEvent()
    {
        // str: "ca7498f78b7d6f7c59c693d3d141f885f68fd7953284944055624ce32f651a63ad271b863a29cdd8ddcd028f0aadcb4a8..."
        // call: pa768caa9.reportEvent
        // call: DecryptString.decryptString
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportPaymentSellErrorEvent()
    {
        // str: "03f1989cd1126ee01aa3cf3e3e43f340718e7582c75dcf0b7028bdd2a06b64c7a29c614605298b3531d9e9b599304a2f4..."
        // call: pa768caa9.reportEvent
        // call: DecryptString.decryptString
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportPaymentSellSuccessEvent()
    {
        // str: "712fd3195ae5f0a22c365f601fd3e9d3c0a40d034ceb41dcfb6454f6e3846ef95a08a4095f3836ee6ef94d738f2853ce5..."
        // call: pa768caa9.reportEvent
        // call: DecryptString.decryptString
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportRequestEvent()
    {
        // str: "ef8d709b584a5ae456f4db2d21f852eaf175dbd5aa7e963b1d02d2a1722e7a054e357ac9905f5784"
        // call: pa768caa9.reportEvent
        // call: DecryptString.decryptString
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportVirtualDeviceAutoLoginErrorEvent(string P0)
    {
        // str: "28e3bd4add104d670c83516b59c15c03bfd2ac186d788882aab1d744b3292ef7679db092ca"
        // str: "deviceId"
        // str: "61cee74d39b81ede989399e19c35f56ffc8d503f27131a8e456b5c062ff7db08309b810e061657d95c5b87da18480787a..."
        // call: Intrinsics.checkNotNullParameter
        // call: TuplesKt.to
        // call: pa768caa9.reportEvent
        // call: DecryptString.decryptString
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportVirtualDeviceAutoLoginSuccessEvent(string P0)
    {
        // str: "deviceId"
        // str: "007bf5343ae6881a3da04b1d43e5f416b61942143d83d102ef464b1b0a7b613f6b1ec959267d17a803dc4afe7b7279b24..."
        // str: "bfb660d28b1baee7e958c7fd452ed7b2dadac3c266e27f6b6488d848a63e6738dcd31ad79c"
        // call: Intrinsics.checkNotNullParameter
        // call: DecryptString.decryptString
        // call: TuplesKt.to
        // call: pa768caa9.reportEvent
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

    public void ReportstartScreen()
    {
        // str: "780f0843cfa4cccd785a110b4ca68f0fd23c5c002b1d7a70719c228c770ac33385921b4677e63f"
        // call: pa768caa9.reportEvent
        // call: DecryptString.decryptString
        // field: p83f5c3ad.p68c4283d.pcc91dae7.f68c4283d
    }

}
