namespace WillowMaze.Wasm.Decompiled;

public class P68d1bf24 : FirebaseMessagingService
{
    public static string F04bbb922;
    public static string F07e69f78;
    public static string F1243dd56;
    public static string F1a124a81;
    public static string F1b7bcfec;
    public static string F1f6f444f;
    public static string F2195fc7a;
    public static string F2f977ee2;
    public static string F3098417c;
    public static int F3918838a;
    public static string F3977fed2;
    public static string F494e3c5d;
    public static string F4b80df9d;
    public static string F4c5c5d0d;
    public static string F575c2f0b;
    public static string F5883c8bf;
    public static string F5bf53089;
    public static int F5c1688e4;
    public static string F5ca188eb;
    public static string F5e028ec7;
    public static string F60830be2;
    public static string F61ba939b;
    public static string F6280f75b;
    public static string F65aa2b27;
    public static string F68296384;
    public static string F69a9bafe;
    public static string F6d40d158;
    public static string F6ef1e755;
    public static int F71bf4df1;
    public static string F72d4e44c;
    public static string F7dc79986;
    public static string F8582aad7;
    public static int F860e643a;
    public static string F90e0fd99;
    public static p68d1bf24$p910eef8c F910eef8c;
    public static int F91c9ca41;
    public static string Fa12eb99e;
    public static string Fa96366ed;
    public static string Fadae7378;
    public static string Fb4b504f6;
    public static string Fbd8b349f;
    public static string Fc0190898;
    public static string Fc2d2283c;
    public static string Fc3e1aabb;
    public static string Fc954f5ee;
    public static string Fcb9e90d3;
    public static string Fd2d1f12f;
    public static string Fe6e96f19;
    public static string Fe71970dd;
    public static string Fe80a1096;
    public static string Fe91a56e7;
    public static string Ff0695b32;
    public static string Ff2f9f618;
    public static p68d1bf24$p910eef8c Ff52fab70;
    public static string Ffa638215;
    public static string Ffbf6b626;
    public static string Ffe5195e2;
    public static string Fffc98042;

    private NotificationCompat$Builder M030dd493()
    {
        // str: "setGroupSummary(...)"
        // str: "c2ae71caa0e0b004fc9d162a37785ed7d0c9c0ef1f98345da7049087c1e646a599ba7dcd91bb4f5894da30d3"
        // str: "520cf2b9e0e7ddb09bd7d3108d37916d2f30d1a80f16e4a6321a2da35b74a05de880d22363438d19c4728a6be09d1ffde..."
        // call: NotificationCompat$Builder.setGroup
        // call: p68d1bf24.getApplicationContext
        // call: NotificationCompat$Builder.<init>
        // call: DecryptString.decryptString
        // call: NotificationCompat$Builder.setAutoCancel
        // call: Intrinsics.checkNotNullExpressionValue
        // call: NotificationCompat$Builder.setGroupSummary
        // call: NotificationCompat$Builder.setSmallIcon
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$drawable.ic_logo_psr
        // type: NotificationCompat$Builder
        return default!;
    }

    private void M108f5a61()
    {
        // str: "8dbe2d1700f67d10906ec30eb17eb17a227f69cce0a31c8d4f635c71e3154612c2195b794568d720d2"
        // str: "4feb3387ec4d11d0c72f408af36f228d54c5acdb0644ed3e1b49a962667eb6f47351614d17155f271e45ed970f0a21d634"
        // str: "dc72898f6e8fd22f282c5a32d0448160268c4a42ecab08c4482bda04de344bb0e69c831a80538fae1bda1181a7f6fcfe3..."
        // str: "3f8bba6a42da562cdf59512b877eacea6e7dd7d260a5479367ec70e48244b1ca122ab55ba6d0a4110095ab38"
        // call: DecryptString.decryptString
        // call: p68d1bf24.m666259ea
        // call: p68d1bf24.m88d6791a
    }

    private PendingIntent M1122c8a4(RemoteMessage P0)
    {
        // str: "3ffb5ff65edfdfd4f78f8e6d910af8fc4623d4576abf0d578d99a0f27849"
        // str: "f26ee7db484600b46c3656a541d1ab6d3f0e0980bacbbdb18fbb47ff4766ec94c9c1d873c27e6029673f03"
        // str: "0066037946a12c9e4c2c0be160b960c3d682c9e4f6c9b82416994f87726ed0bd0c70c87a"
        // str: "2cd2f37b5eb6fc9ebce399a6b296b83f5bbec940bbe64314037a50094b1ae7c01909b36e7889e813"
        // str: "2b404d5925939d3a39bedcf851f5494e154a83dd9f3045d972b427376ee0fd5eff524e1e91a8"
        // str: "37a87f0791206c23a132b4699035b75808fc68ff42d102d7454e45151c4310"
        // str: "86b94d762a97feb1e5b42041e66f989d21848f5d9926750c8443a39286d678"
        // call: Dictionary<string, object>.get
        // call: DecryptString.decryptString
        // call: PendingIntent.getActivity
        // call: object.<init>
        // call: RemoteMessage.getData
        // call: object.hashCode
        // call: Intrinsics.areEqual
        // call: object.putExtra
        // call: object.setFlags
        // type: p955f0bb4
        // type: object
        return default!;
    }

    private static void M666259ea(p68d1bf24 P0, string P1, string P2, int P3, bool P4, int P5, object P6)
    {
        // call: p68d1bf24.m88d6791a
    }

    private void M88d6791a(string P0, string P1, int P2, bool P3)
    {
        // call: NotificationChannel.setSound
        // call: ContextCompat.getSystemService
        // call: RingtoneManager.getDefaultUri
        // call: NotificationManager.createNotificationChannel
        // call: AudioAttributes$Builder.build
        // call: AudioAttributes$Builder.<init>
        // call: AudioAttributes$Builder.setUsage
        // call: AudioAttributes$Builder.setContentType
        // call: NotificationChannel.<init>
        // type: NotificationManager
        // type: AudioAttributes$Builder
        // type: NotificationChannel
    }

    private NotificationCompat$Builder Md0af615b(RemoteMessage P0)
    {
        // str: "2fb795b420e4fd3376d1d073be23b22c568934c882aafe598d65b8251a5fe8c4"
        // str: "addAction(...)"
        // str: "43549fd50a8e041be651e66aa786a18410d8a558c4c5dfabd787f6b7e9eb4d925389626f22f6"
        // str: "f6e9b77340d7f717b6a2dc7cceec943c2775b651c8b1ac47956535add6dad0c1113bdb79f5716de71021b30b3de956882..."
        // str: "e22d2bea91007756c3efd4cc3463c19f1b118438368db263a437c38451c04005bf"
        // str: "f22e0865ca2c7bf4a97c25e5dc5a9a16949785230fba93c018f6b3bf5e9d1e7504a709aa881c7e5347024e90096b0611b..."
        // call: Intrinsics.checkNotNullExpressionValue
        // call: RemoteMessage.getData
        // call: NotificationCompat$Builder.setGroup
        // call: DecryptString.decryptString
        // call: NotificationCompat$Builder.<init>
        // call: NotificationCompat$Builder.setPriority
        // call: NotificationCompat$Builder.setContentTitle
        // call: Dictionary<string, object>.get
        // call: p68d1bf24.m1122c8a4
        // call: p68d1bf24.getApplicationContext
        // call: NotificationCompat$Builder.setAutoCancel
        // call: NotificationCompat$Builder.setDefaults
        // call: NotificationCompat$Builder.setContentText
        // call: NotificationCompat$Builder.setSmallIcon
        // call: NotificationCompat$Builder.addAction
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$drawable.ic_logo_psr
        // type: NotificationCompat$Builder
        return default!;
    }

    public void OnCreate()
    {
        // call: p68d1bf24.m108f5a61
        // call: FirebaseMessagingService.onCreate
    }

    public void OnMessageReceived(RemoteMessage P0)
    {
        // str: "84e82bfc23740f6aaaac8e9498fab2402b8e210cd97328987404b3038e0f"
        // str: "android.permission.POST_NOTIFICATIONS"
        // str: "remoteMessage"
        // call: p68d1bf24.m030dd493
        // call: object.hashCode
        // call: FirebaseMessagingService.onMessageReceived
        // call: Intrinsics.checkNotNullParameter
        // call: Dictionary<string, object>.get
        // call: NotificationCompat$Builder.build
        // call: NotificationManagerCompat.notify
        // call: DecryptString.decryptString
        // call: NotificationManagerCompat.from
        // call: ActivityCompat.checkSelfPermission
        // call: p68d1bf24.md0af615b
        // call: RemoteMessage.getData
    }

    public void OnNewToken(string P0)
    {
        // str: "token"
        // call: FirebaseMessagingService.onNewToken
        // call: Intrinsics.checkNotNullParameter
    }

}
