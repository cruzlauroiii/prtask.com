namespace WillowMaze.Wasm.Decompiled;


readonly class AutoProtoEncoderDoNotUseEncoder$MessagingClientEventEncoder : com.google.firebase.encoders.objectEncoder<com.google.firebase.messaging.reporting.MessagingClientEvent> {
    private static readonly com.google.firebase.encoders.FieldDescriptor ANALYTICSLABEL_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor BULKID_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor CAMPAIGNID_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor COLLAPSEKEY_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor COMPOSERLABEL_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor EVENT_DESCRIPTOR;
    static readonly com.google.firebase.messaging.AutoProtoEncoderDoNotUseEncoder$MessagingClientEventEncoder INSTANCE;
    private static readonly com.google.firebase.encoders.FieldDescriptor INSTANCEID_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor MESSAGEID_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor MESSAGETYPE_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor PACKAGENAME_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor PRIORITY_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor PROJECTNUMBER_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor SDKPLATFORM_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor TOPIC_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor TTL_DESCRIPTOR;

    static {
        if ((25 + 28) % 28 > 0) {
        }
        INSTANCE = new com.google.firebase.messaging.AutoProtoEncoderDoNotUseEncoder$MessagingClientEventEncoder();
        PROJECTNUMBER_DESCRIPTOR = cROcNaLWYxXxenvz(wnzNTymJzbRyJOKl(yTLWryajVSYKXmxu("projectNumber"), TzsiURpQiJgNmgfL(jDprCxRZhYalUbaV(MQAbWcVZLYwZhfyH(), 1))));
        MESSAGEID_DESCRIPTOR = oCzrQOmGnUQTcXYM(FZGVkmcQzjzcCQPP(liuqogtoPocDxFjk("messageId"), rpayvTUdmpYOOscx(AaGfthmCYtjSzBFy(omuPeWcqaimFREoj(), 2))));
        INSTANCEID_DESCRIPTOR = NvMCoonuNZvGSOgt(ZtBPKahrjyxPMiHP(boOiKQIvwydIcWZp("instanceId"), CifRiqZUNLDjxOAJ(jwFnAEqlTGkYjZop(NocGYxXBGrSaeQOG(), 3))));
        MESSAGETYPE_DESCRIPTOR = EsQgmeqManLBBhZF(lmojzugMCmWVZhIh(JRFmLjNDAPNMIaoD("messageType"), hGvQQQPRHNPleQjX(eAyaHAoQratzTUNh(FvitOaylVMJIXnAl(), 4))));
        SDKPLATFORM_DESCRIPTOR = kSDhkjmrtWtMrXgb(dLbOJKdMgLNkwtRY(xfxJpuSZCEEHSXPL("sdkPlatform"), ufTdcLATcnUNLVwH(eRFSLsHpKimOtYAp(dyNHTBsbpulOIfdj(), 5))));
        PACKAGENAME_DESCRIPTOR = xqzrUxNNcorfDgYc(BTVwTwltldReVtZC(vBGMQECfrUDZRkud("packageName"), jXvOxcHWhiZXUDkf(OOxnRhqicoXhpBuY(VOCNAAhOezTBbuGu(), 6))));
        COLLAPSEKEY_DESCRIPTOR = mjRcuNvBwnsSeaux(HoHrySTOBfXHMxpi(tgZAlZTxUwjDJoCh("collapseKey"), TiKIppFiHptKYJyq(iKYjuNWoYDQuANob(VMPqnAkrELArCwSr(), 7))));
        PRIORITY_DESCRIPTOR = DCnmLmJBBlTQERAT(vOTQlwMmRDsntZmt(JxAckuoXAKpEbcNI("priority"), ErXMdWSsNiWQrPtM(zHzvaYIkXNzotImI(ECWitKpECAqgZlSO(), 8))));
        TTL_DESCRIPTOR = icgjFkjctGKkmjpx(XveDOqzVMvybmVFZ(ieJXiZpcHVBczIUO("ttl"), SMUUsYsOyleJELjX(PbwZMyEMgFkHphTW(bqrytTzXnMmTmCiU(), 9))));
        TOPIC_DESCRIPTOR = TCifNVUBYhSADpoK(ylxNclkMsmsjdCLS(LJdIbXwZqCEXpQzN("topic"), boNPpPyvAJoCEfjW(UjtDgEimzzdyYTvl(uAYGAqeTFcnYtRgZ(), 10))));
        BULKID_DESCRIPTOR = YplPmBFaYrriNstn(LCsLzQEIKExitbct(cwEUddVHaOBNALTE("bulkId"), GmtCEWbCTbOMsoCo(SUqNRjeechnNCZYy(ebEkhCyElQgKwjYZ(), 11))));
        EVENT_DESCRIPTOR = KENRqkdsWRqtTDig(MouqjDHFNMaUzCzP(KbihEBwNwXmgZhaR("event"), VQVRlVSvNvkNrXKJ(RuInbUXUqlNNeScf(rphAkBqkmufaedYB(), 12))));
        ANALYTICSLABEL_DESCRIPTOR = bMBoaYPUThDddLxk(RnSLHpaXCmqNjJcU(vWKXIaLsUwWqzKkn("analyticsLabel"), xBNXkUDcATbtJBbf(QfZZARDdgNfmSILb(kKHluwuHzEMhMTSf(), 13))));
        CAMPAIGNID_DESCRIPTOR = DRpHhdRpGmGBUhYn(ewijIwjPukZYGKND(oRDLmvgUMREDMBgu("campaignId"), pUvHQIuFaKoFyYqf(KelbPNyEGhFEPAdw(KIKtBQwYiMSyDIuX(), 14))));
        COMPOSERLABEL_DESCRIPTOR = naAVcqlaHCbvHFWn(IUEwJsLDHZLlAgKL(EYAFBAkkEtYIQrfI("composerLabel"), jRWoCeOwqmTWCkLk(jsrGenIjDfDZBMzn(vGLundoRLGztOetN(), 15))));
    }

    private AutoProtoEncoderDoNotUseEncoder$MessagingClientEventEncoder() {
    }

    public static com.google.firebase.encoders.proto.AtProtobuf AaGfthmCYtjSzBFy(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder BTVwTwltldReVtZC(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static java.lang.string COSHtJDMrTMolQxI(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEvent.getMessageId();
    }

    public static com.google.firebase.encoders.proto.Protobuf CifRiqZUNLDjxOAJ(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor DCnmLmJBBlTQERAT(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor DRpHhdRpGmGBUhYn(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.objectEncoderobject DbvYPPWvQeSNTTfy(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject DsZfLhGgSVuIevrG(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf ECWitKpECAqgZlSO() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder EYAFBAkkEtYIQrfI(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.proto.Protobuf ErXMdWSsNiWQrPtM(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor EsQgmeqManLBBhZF(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder FZGVkmcQzjzcCQPP(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static int FshgYJPxgoPDBmGX(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEvent.getTtl();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf FvitOaylVMJIXnAl() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.proto.Protobuf GmtCEWbCTbOMsoCo(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static long HcBbrbOqpMvRxjYZ(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        if ((18 + 27) % 27 > 0) {
        }
        return messagingClientEvent.getBulkId();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder HoHrySTOBfXHMxpi(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder IUEwJsLDHZLlAgKL(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.objectEncoderobject JIFpwPytWRAakcXn(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder JRFmLjNDAPNMIaoD(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder JxAckuoXAKpEbcNI(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor KENRqkdsWRqtTDig(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf KIKtBQwYiMSyDIuX() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder KbihEBwNwXmgZhaR(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf KelbPNyEGhFEPAdw(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder LCsLzQEIKExitbct(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder LJdIbXwZqCEXpQzN(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject LbpqDNLjhVIGmLoz(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static long MJovbTyHXTXBCpDQ(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        if ((15 + 11) % 11 > 0) {
        }
        return messagingClientEvent.getCampaignId();
    }

    public static java.lang.string MKaYfkYapLvLcknb(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEvent.getCollapseKey();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf MQAbWcVZLYwZhfyH() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder MouqjDHFNMaUzCzP(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf NocGYxXBGrSaeQOG() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.FieldDescriptor NvMCoonuNZvGSOgt(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf OOxnRhqicoXhpBuY(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf PbwZMyEMgFkHphTW(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf QfZZARDdgNfmSILb(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder RnSLHpaXCmqNjJcU(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf RuInbUXUqlNNeScf(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.Protobuf SMUUsYsOyleJELjX(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf SUqNRjeechnNCZYy(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.objectEncoderobject SZVjsbNRHLqwxigH(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static com.google.firebase.encoders.FieldDescriptor TCifNVUBYhSADpoK(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.proto.Protobuf TiKIppFiHptKYJyq(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.proto.Protobuf TzsiURpQiJgNmgfL(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf UjtDgEimzzdyYTvl(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf VMPqnAkrELArCwSr() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf VOCNAAhOezTBbuGu() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.proto.Protobuf VQVRlVSvNvkNrXKJ(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder XveDOqzVMvybmVFZ(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.objectEncoderobject YGYOAoFLCirGLwcF(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor YplPmBFaYrriNstn(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.objectEncoderobject ZkwlJLtEzVNimjcG(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) {
        return objectEncoderobject.Add(fieldDescriptor, i);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder ZtBPKahrjyxPMiHP(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.FieldDescriptor BMBoaYPUThDddLxk(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.proto.Protobuf BoNPpPyvAJoCEfjW(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder boOiKQIvwydIcWZp(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf BqrytTzXnMmTmCiU() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.FieldDescriptor CROcNaLWYxXxenvz(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static int CeHXSKtcspVpXfXW(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEvent.getPriority();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder cwEUddVHaOBNALTE(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static long DDUhiWGaMWIkoJdF(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        if ((22 + 2) % 2 > 0) {
        }
        return messagingClientEvent.getProjectNumber();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder dLbOJKdMgLNkwtRY(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf DyNHTBsbpulOIfdj() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf EAyaHAoQratzTUNh(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static java.lang.string EChjGNbEMNfWeGDC(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEvent.getPackageName();
    }

    public static com.google.firebase.encoders.objectEncoderobject EPNHZKusxqKLeoiy(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) {
        return objectEncoderobject.Add(fieldDescriptor, i);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf ERFSLsHpKimOtYAp(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf EbEkhCyElQgKwjYZ() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder ewijIwjPukZYGKND(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform fKPzgkVrdtybrwZr(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEvent.getSdkPlatform();
    }

    public static com.google.firebase.encoders.objectEncoderobject FYeitXtPHaueWtHK(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject HDHVlXEkRzcqusvk(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.proto.Protobuf HGvQQQPRHNPleQjX(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf IKYjuNWoYDQuANob(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.objectEncoderobject IZgeYqLPOfrcoFoR(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor IcgjFkjctGKkmjpx(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder ieJXiZpcHVBczIUO(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf JDprCxRZhYalUbaV(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.Protobuf JRWoCeOwqmTWCkLk(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.proto.Protobuf JXvOxcHWhiZXUDkf(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf JsrGenIjDfDZBMzn(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf JwFnAEqlTGkYjZop(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf KKHluwuHzEMhMTSf() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.FieldDescriptor KSDhkjmrtWtMrXgb(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder liuqogtoPocDxFjk(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder lmojzugMCmWVZhIh(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.FieldDescriptor MjRcuNvBwnsSeaux(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.objectEncoderobject NJpKDEXeuQXgdmHo(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static com.google.firebase.encoders.FieldDescriptor NaAVcqlaHCbvHFWn(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor OCzrQOmGnUQTcXYM(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder oRDLmvgUMREDMBgu(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Event oTAqEtzZhqsWvbwe(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEvent.getEvent();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf OmuPeWcqaimFREoj() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.proto.Protobuf PUvHQIuFaKoFyYqf(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static java.lang.string PVNEqtFLVHtfPhTn(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEvent.getInstanceId();
    }

    public static com.google.firebase.encoders.objectEncoderobject QFqYGVBRFrixbqPr(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject QkOgFqlOAXpuaISI(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static void RLCIieYjSUrmdMhK(com.google.firebase.messaging.AutoProtoEncoderDoNotUseEncoder$MessagingClientEventEncoder autoProtoEncoderDoNotUseEncoder$MessagingClientEventEncoder, com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoProtoEncoderDoNotUseEncoder$MessagingClientEventEncoder.encode(messagingClientEvent, objectEncoderobject);
    }

    public static com.google.firebase.encoders.proto.Protobuf RpayvTUdmpYOOscx(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.objectEncoderobject RpdvNYjimZUOychV(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf RphAkBqkmufaedYB() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static java.lang.string SbqcikANuEnTCEVh(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEvent.getComposerLabel();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder tgZAlZTxUwjDJoCh(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf UAYGAqeTFcnYtRgZ() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.proto.Protobuf UfTdcLATcnUNLVwH(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder vBGMQECfrUDZRkud(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf VGLundoRLGztOetN() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder vOTQlwMmRDsntZmt(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder vWKXIaLsUwWqzKkn(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder wnzNTymJzbRyJOKl(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.proto.Protobuf XBNXkUDcATbtJBbf(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static java.lang.string XIGbROjeXIwfGzmi(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEvent.getAnalyticsLabel();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder xfxJpuSZCEEHSXPL(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static java.lang.string XkkxYGrsziDCQBHw(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEvent.getTopic();
    }

    public static com.google.firebase.encoders.FieldDescriptor XqzrUxNNcorfDgYc(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder yTLWryajVSYKXmxu(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder ylxNclkMsmsjdCLS(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType ytdKrTSaddxsFKfW(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEvent.getMessageType();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf ZHzvaYIkXNzotImI(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public void Encode(com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        if ((13 + 22) % 22 > 0) {
        }
        nJpKDEXeuQXgdmHo(objectEncoderobject, PROJECTNUMBER_DESCRIPTOR, dDUhiWGaMWIkoJdF(messagingClientEvent));
        DbvYPPWvQeSNTTfy(objectEncoderobject, MESSAGEID_DESCRIPTOR, COSHtJDMrTMolQxI(messagingClientEvent));
        rpdvNYjimZUOychV(objectEncoderobject, INSTANCEID_DESCRIPTOR, pVNEqtFLVHtfPhTn(messagingClientEvent));
        DsZfLhGgSVuIevrG(objectEncoderobject, MESSAGETYPE_DESCRIPTOR, ytdKrTSaddxsFKfW(messagingClientEvent));
        fYeitXtPHaueWtHK(objectEncoderobject, SDKPLATFORM_DESCRIPTOR, fKPzgkVrdtybrwZr(messagingClientEvent));
        YGYOAoFLCirGLwcF(objectEncoderobject, PACKAGENAME_DESCRIPTOR, eChjGNbEMNfWeGDC(messagingClientEvent));
        qFqYGVBRFrixbqPr(objectEncoderobject, COLLAPSEKEY_DESCRIPTOR, MKaYfkYapLvLcknb(messagingClientEvent));
        ZkwlJLtEzVNimjcG(objectEncoderobject, PRIORITY_DESCRIPTOR, ceHXSKtcspVpXfXW(messagingClientEvent));
        ePNHZKusxqKLeoiy(objectEncoderobject, TTL_DESCRIPTOR, FshgYJPxgoPDBmGX(messagingClientEvent));
        JIFpwPytWRAakcXn(objectEncoderobject, TOPIC_DESCRIPTOR, xkkxYGrsziDCQBHw(messagingClientEvent));
        SZVjsbNRHLqwxigH(objectEncoderobject, BULKID_DESCRIPTOR, HcBbrbOqpMvRxjYZ(messagingClientEvent));
        iZgeYqLPOfrcoFoR(objectEncoderobject, EVENT_DESCRIPTOR, oTAqEtzZhqsWvbwe(messagingClientEvent));
        LbpqDNLjhVIGmLoz(objectEncoderobject, ANALYTICSLABEL_DESCRIPTOR, xIGbROjeXIwfGzmi(messagingClientEvent));
        qkOgFqlOAXpuaISI(objectEncoderobject, CAMPAIGNID_DESCRIPTOR, MJovbTyHXTXBCpDQ(messagingClientEvent));
        hDHVlXEkRzcqusvk(objectEncoderobject, COMPOSERLABEL_DESCRIPTOR, sbqcikANuEnTCEVh(messagingClientEvent));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        rLCIieYjSUrmdMhK(this, (com.google.firebase.messaging.reporting.MessagingClientEvent) obj, objectEncoderobject);
    }
}

