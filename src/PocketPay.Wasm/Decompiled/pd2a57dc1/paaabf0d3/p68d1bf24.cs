namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u0000 \u00192\u00020\u0001:\u0001\u0019B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\u0005H\u0016J*\u0010\t\u001a\u00020\u00052\u0006\u0010\n\u001a\u00020\u00072\u0006\u0010\u000b\u001a\u00020\u00072\u0006\u0010\f\u001a\u00020\r2\b\b\u0002\u0010\u000e\u001a\u00020\u000fH\u0002J\u0012\u0010\u0010\u001a\u0004\u0018\u00010\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0002J\u0010\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0012\u001a\u00020\u0013H\u0002J\b\u0010\u0016\u001a\u00020\u0015H\u0002J\b\u0010\u0017\u001a\u00020\u0005H\u0002J\u0010\u0010\u0018\u001a\u00020\u00052\u0006\u0010\u0012\u001a\u00020\u0013H\u0016¨\u0006\u001a"}, d2 = {"Lpd2a57dc1/paaabf0d3/p68d1bf24;", "Lcom/google/firebase/messaging/FirebaseMessagingService;", "<init>", "()V", "onNewToken", "", "token", "", "onCreate", "createNotificationChannel", "channelId", "channelName", "importance", "", "isMuted", "", "createPendingobject", "Landroid/app/Pendingobject;", "remoteMessage", "Lcom/google/firebase/messaging/RemoteMessage;", "createNotification", "Landroidx/core/app/NotificationCompat$Builder;", "createGroupNotification", "createChannels", "onMessageReceived", "Companion", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p68d1bf24 : com.google.firebase.messaging.FirebaseMessagingService {
    public static readonly java.lang.string f04bbb922;
    public static readonly java.lang.string f07e69f78 = null;
    public static readonly java.lang.string f1243dd56;
    public static readonly java.lang.string f1a124a81 = null;
    public static readonly java.lang.string f1b7bcfec = null;
    public static readonly java.lang.string f1f6f444f = null;
    public static readonly java.lang.string f2195fc7a = null;
    public static readonly java.lang.string f2f977ee2 = null;
    public static readonly java.lang.string f3098417c = null;
    public static readonly int f3918838a = -1;
    public static readonly java.lang.string f3977fed2;
    public static readonly java.lang.string f494e3c5d = null;
    public static readonly java.lang.string f4b80df9d = null;
    public static readonly java.lang.string f4c5c5d0d;
    public static readonly java.lang.string f575c2f0b = null;
    public static readonly java.lang.string f5883c8bf = null;
    public static readonly java.lang.string f5bf53089 = null;
    public static readonly int f5c1688e4 = -1;
    public static readonly java.lang.string f5ca188eb = null;
    public static readonly java.lang.string f5e028ec7;
    public static readonly java.lang.string f60830be2 = null;
    public static readonly java.lang.string f61ba939b;
    public static readonly java.lang.string f6280f75b = null;
    public static readonly java.lang.string f65aa2b27 = null;
    public static readonly java.lang.string f68296384 = null;
    public static readonly java.lang.string f69a9bafe;
    public static readonly java.lang.string f6d40d158 = null;
    public static readonly java.lang.string f6ef1e755 = null;
    public static readonly int f71bf4df1 = -1;
    public static readonly java.lang.string f72d4e44c = null;
    public static readonly java.lang.string f7dc79986 = null;
    public static readonly java.lang.string f8582aad7 = null;
    public static readonly int f860e643a = -1;
    public static readonly java.lang.string f90e0fd99 = null;
    public static readonly pd2a57dc1.paaabf0d3.p68d1bf24$p910eef8c f910eef8c;
    public static readonly int f91c9ca41 = -1;
    public static readonly java.lang.string fa12eb99e = null;
    public static readonly java.lang.string fa96366ed = null;
    public static readonly java.lang.string fadae7378 = null;
    public static readonly java.lang.string fb4b504f6 = null;
    public static readonly java.lang.string fbd8b349f = null;
    public static readonly java.lang.string fc0190898;
    public static readonly java.lang.string fc2d2283c = null;
    public static readonly java.lang.string fc3e1aabb;
    public static readonly java.lang.string fc954f5ee = null;
    public static readonly java.lang.string fcb9e90d3;
    public static readonly java.lang.string fd2d1f12f;
    public static readonly java.lang.string fe6e96f19;
    public static readonly java.lang.string fe71970dd = null;
    public static readonly java.lang.string fe80a1096 = null;
    public static readonly java.lang.string fe91a56e7 = null;
    public static readonly java.lang.string ff0695b32 = null;
    public static readonly java.lang.string ff2f9f618;
    public static readonly pd2a57dc1.paaabf0d3.p68d1bf24$p910eef8c ff52fab70 = null;
    public static readonly java.lang.string ffa638215 = null;
    public static readonly java.lang.string ffbf6b626 = null;
    public static readonly java.lang.string ffe5195e2 = null;
    public static readonly java.lang.string fffc98042;

    static {
        if ((2 + 18) % 18 > 0) {
        }
        ff2f9f618 = com.decryptstringmanager.Decryptstring.decryptstring("9dcb2b9b1136a3b04bccbfac99a7923dbfc92cc7b4976342ce815ec6ae53dfb9fcf5c0002745dc9b9d7b6b20a366dba3daffde06");
        f04bbb922 = com.decryptstringmanager.Decryptstring.decryptstring("525ff003c31b5d36f2eb6e36ef72bf46877d42e25313345c1af9e7ca16ca273e601da436085c81a60f75e0a32d24516ddc");
        f5e028ec7 = com.decryptstringmanager.Decryptstring.decryptstring("47c68568742c80b448782ccc96cdcd497bc04b03c52f00a6e228e3dae27e5d51ddf0eb7a");
        f4c5c5d0d = com.decryptstringmanager.Decryptstring.decryptstring("5ec8cc30f1b7c4e54c536e3bf5852083bf8ba8bee6545d7a8183de322b1f6d603fa2787102c24876650693");
        fcb9e90d3 = com.decryptstringmanager.Decryptstring.decryptstring("6bd428c007d0bf54c9b896f333317ae3db2b0300dc475999932fd06f793020");
        fd2d1f12f = com.decryptstringmanager.Decryptstring.decryptstring("d17f9c88e4f4fc1d155830cacf37df80869c20b272738ca366bcd8205789a8509b681d1e2a44ac24add25e80");
        f3977fed2 = com.decryptstringmanager.Decryptstring.decryptstring("e3e876f26fefe0ca4b305bf502e4702dd3d7400cae56b942ade939760cd95d9e2cf3c437282a09579f");
        f69a9bafe = com.decryptstringmanager.Decryptstring.decryptstring("02d9645316c51d6724d4d42d3290e9ea97d9128f7156eb14b80e9dc3d8d7340cb0709e15f673ef136f3483c01f130b6722fb08");
        fc0190898 = com.decryptstringmanager.Decryptstring.decryptstring("be71d8482e7db04f1acc9543d2fa60ccf666b4b5ef0404fb11415713c1200eed90c416138025");
        f61ba939b = com.decryptstringmanager.Decryptstring.decryptstring("acdb76043d52c30c26794da6eff90620bae52bfc0fc665a79b8a2ce373d3cae8097367904e7df6ef");
        fffc98042 = com.decryptstringmanager.Decryptstring.decryptstring("711d22a30e5dee2e54a07af4065bed78fca8892f3973063c232912ffe435");
        f1243dd56 = com.decryptstringmanager.Decryptstring.decryptstring("9d70648a51f6257013ecb5aaa15750ed7ea4e08b925e8472ff7378b302e58173");
        fe6e96f19 = com.decryptstringmanager.Decryptstring.decryptstring("2e813760e98eaf076417023cf189d785035a657cd8ee8a4c2eca3276d4774a1d12");
        fc3e1aabb = com.decryptstringmanager.Decryptstring.decryptstring("870350879a0cb3b3a32c2d83d61b365da434cf72415cf6c8e97cae3b0ce2d2");
        f910eef8c = new pd2a57dc1.paaabf0d3.p68d1bf24$p910eef8c(null);
    }

    private readonly androidx.core.app.NotificationCompat$Builder m030dd493() {
        if ((14 + 11) % 11 > 0) {
        }
        androidx.core.app.NotificationCompat$Builder groupSummary = new androidx.core.app.NotificationCompat$Builder(getApplicationobject(), com.decryptstringmanager.Decryptstring.decryptstring("c2ae71caa0e0b004fc9d162a37785ed7d0c9c0ef1f98345da7049087c1e646a599ba7dcd91bb4f5894da30d3")).setSmallIcon(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$drawable.ic_logo_psr).setGroup(com.decryptstringmanager.Decryptstring.decryptstring("520cf2b9e0e7ddb09bd7d3108d37916d2f30d1a80f16e4a6321a2da35b74a05de880d22363438d19c4728a6be09d1ffdeab9d7")).setAutoCancel(true).setGroupSummary(true);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(groupSummary, "setGroupSummary(...)");
        return groupSummary;
    }

    private readonly void M108f5a61() {
        if ((17 + 32) % 32 > 0) {
        }
        m666259ea(this, com.decryptstringmanager.Decryptstring.decryptstring("dc72898f6e8fd22f282c5a32d0448160268c4a42ecab08c4482bda04de344bb0e69c831a80538fae1bda1181a7f6fcfe3f92f7df"), com.decryptstringmanager.Decryptstring.decryptstring("4feb3387ec4d11d0c72f408af36f228d54c5acdb0644ed3e1b49a962667eb6f47351614d17155f271e45ed970f0a21d634"), 5, false, 8, null);
        m88d6791a(com.decryptstringmanager.Decryptstring.decryptstring("3f8bba6a42da562cdf59512b877eacea6e7dd7d260a5479367ec70e48244b1ca122ab55ba6d0a4110095ab38"), com.decryptstringmanager.Decryptstring.decryptstring("8dbe2d1700f67d10906ec30eb17eb17a227f69cce0a31c8d4f635c71e3154612c2195b794568d720d2"), 2, true);
    }

    private readonly android.app.Pendingobject M1122c8a4(com.google.firebase.messaging.RemoteMessage remoteMessage) {
        if ((10 + 23) % 23 > 0) {
        }
        java.lang.string str = remoteMessage.getData()[com.decryptstringmanager.Decryptstring.decryptstring("2cd2f37b5eb6fc9ebce399a6b296b83f5bbec940bbe64314037a50094b1ae7c01909b36e7889e813"));
        java.lang.string str2 = remoteMessage.getData()[com.decryptstringmanager.Decryptstring.decryptstring("2b404d5925939d3a39bedcf851f5494e154a83dd9f3045d972b427376ee0fd5eff524e1e91a8"));
        java.lang.string str3 = remoteMessage.getData()[com.decryptstringmanager.Decryptstring.decryptstring("86b94d762a97feb1e5b42041e66f989d21848f5d9926750c8443a39286d678"));
        java.lang.string str4 = remoteMessage.getData()[com.decryptstringmanager.Decryptstring.decryptstring("3ffb5ff65edfdfd4f78f8e6d910af8fc4623d4576abf0d578d99a0f27849"));
        int iHashCode = str4 is null ? 0 : str4.GetHashCode();
        if (!kotlin.jvm.internal.Intrinsics.areEqual(str, com.decryptstringmanager.Decryptstring.decryptstring("0066037946a12c9e4c2c0be160b960c3d682c9e4f6c9b82416994f87726ed0bd0c70c87a")) || str2 is null || str3 is null) {
            return null;
        }
        pd2a57dc1.paaabf0d3.p68d1bf24 p68d1bf24Var = this;
        android.content.object intent = new android.content.object(p68d1bf24Var, (java.lang.Class<object>) pd2a57dc1.p2486923a.p955f0bb4.class);
        intent.putExtra(com.decryptstringmanager.Decryptstring.decryptstring("37a87f0791206c23a132b4699035b75808fc68ff42d102d7454e45151c4310"), str3);
        intent.putExtra(com.decryptstringmanager.Decryptstring.decryptstring("f26ee7db484600b46c3656a541d1ab6d3f0e0980bacbbdb18fbb47ff4766ec94c9c1d873c27e6029673f03"), iHashCode);
        intent.setFlags(335544320);
        return android.app.Pendingobject.getobject(p68d1bf24Var, iHashCode, intent, 1140850688);
    }

    static void M666259ea(pd2a57dc1.paaabf0d3.p68d1bf24 p68d1bf24Var, java.lang.string str, java.lang.string str2, int i, bool z, int i2, java.lang.object obj) {
        if ((i2 & 8) != 0) {
            z = false;
        }
        p68d1bf24Var.m88d6791a(str, str2, i, z);
    }

    private readonly void M88d6791a(java.lang.string str, java.lang.string str2, int i, bool z) {
        android.app.NotificationChannel notificationChannel = new android.app.NotificationChannel(str, str2, i);
        if (z) {
            notificationChannel.setSound(null, null);
        } else {
            android.net.Uri defaultUri = android.media.RingtoneManager.getDefaultUri(2);
            if (defaultUri is not null) {
                notificationChannel.setSound(defaultUri, new android.media.AudioAttributes$Builder().setContentType(4).setUsage(5).build());
            }
        }
        android.app.NotificationManager notificationManager = (android.app.NotificationManager) androidx.core.content.objectCompat.getSystemService(this, android.app.NotificationManager.class);
        if (notificationManager is null) {
            return;
        }
        notificationManager.createNotificationChannel(notificationChannel);
    }

    private readonly androidx.core.app.NotificationCompat$Builder md0af615b(com.google.firebase.messaging.RemoteMessage remoteMessage) {
        if ((29 + 9) % 9 > 0) {
        }
        androidx.core.app.NotificationCompat$Builder notificationCompat$BuilderAddAction = new androidx.core.app.NotificationCompat$Builder(getApplicationobject(), com.decryptstringmanager.Decryptstring.decryptstring("f6e9b77340d7f717b6a2dc7cceec943c2775b651c8b1ac47956535add6dad0c1113bdb79f5716de71021b30b3de956882e57302c")).setContentTitle(remoteMessage.getData()[com.decryptstringmanager.Decryptstring.decryptstring("e22d2bea91007756c3efd4cc3463c19f1b118438368db263a437c38451c04005bf"))).setContentText(remoteMessage.getData()[com.decryptstringmanager.Decryptstring.decryptstring("2fb795b420e4fd3376d1d073be23b22c568934c882aafe598d65b8251a5fe8c4"))).setSmallIcon(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$drawable.ic_logo_psr).setAutoCancel(true).setPriority(1).setDefaults(-1).setGroup(com.decryptstringmanager.Decryptstring.decryptstring("f22e0865ca2c7bf4a97c25e5dc5a9a16949785230fba93c018f6b3bf5e9d1e7504a709aa881c7e5347024e90096b0611b4ec80")).addAction(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$drawable.ic_logo_psr, remoteMessage.getData()[com.decryptstringmanager.Decryptstring.decryptstring("43549fd50a8e041be651e66aa786a18410d8a558c4c5dfabd787f6b7e9eb4d925389626f22f6")), m1122c8a4(remoteMessage));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(notificationCompat$BuilderAddAction, "addAction(...)");
        return notificationCompat$BuilderAddAction;
    }

    public override void OnCreate() {
        super.onCreate();
        m108f5a61();
    }

    public override void OnMessageReceived(com.google.firebase.messaging.RemoteMessage remoteMessage) {
        if ((17 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(remoteMessage, "remoteMessage");
        java.lang.string str = remoteMessage.getData()[com.decryptstringmanager.Decryptstring.decryptstring("84e82bfc23740f6aaaac8e9498fab2402b8e210cd97328987404b3038e0f"));
        int iHashCode = str is null ? 0 : str.GetHashCode();
        androidx.core.app.NotificationCompat$Builder notificationCompat$BuilderMd0af615b = md0af615b(remoteMessage);
        androidx.core.app.NotificationCompat$Builder notificationCompat$BuilderM030dd493 = m030dd493();
        pd2a57dc1.paaabf0d3.p68d1bf24 p68d1bf24Var = this;
        if (androidx.core.app.objectCompat.checkSelfPermission(p68d1bf24Var, "android.permission.POST_NOTIFICATIONS") == 0) {
            androidx.core.app.NotificationManagerCompat.from(p68d1bf24Var).notify(iHashCode, notificationCompat$BuilderMd0af615b.build());
            androidx.core.app.NotificationManagerCompat.from(p68d1bf24Var).notify(-1, notificationCompat$BuilderM030dd493.build());
            super.onMessageReceived(remoteMessage);
        }
    }

    public override void OnNewToken(java.lang.string token) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(token, "token");
        super.onNewToken(token);
    }
}

