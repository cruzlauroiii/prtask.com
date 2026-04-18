namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$ForPredicate : com.google.common.base.CharMatch {
    private readonly com.google.common.base.Predicate<java.lang.char> predicate;

    CharMatch$ForPredicate(com.google.common.base.Predicate<java.lang.char> predicate) {
        this.predicate = (com.google.common.base.Predicate) XsCNlqdRUucaYsSO(predicate);
    }

    public static java.lang.string BLjdJeOpYrvvLyfI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder EkezjIQbCtzzEsfk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object IayyNdHfAQTEDdiq(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder WseyQTqNmtaBghUc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object XsCNlqdRUucaYsSO(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder ClpsRMVbJLMnkTvx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DbZJlRCOcojtfWCk(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool EhACoMwFZDtCWwFL(com.google.common.base.Predicate predicate, java.lang.object obj) {
        return predicate.apply(obj);
    }

    public static bool KQLmbqLvBItgQOZD(com.google.common.base.CharMatch$ForPredicate charMatch$ForPredicate, java.lang.char ch) {
        return charMatch$ForPredicate.apply(ch);
    }

    public static bool TbhiArDjUtZSuZkI(com.google.common.base.Predicate predicate, java.lang.object obj) {
        return predicate.apply(obj);
    }

    public static int VKaIoUeULRdmUhXh(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string XwaHtnCUzgHkfkGi(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.char YuYtIViqPbwlMQab(char c) {
        return java.lang.char.valueOf(c);
    }

    public override bool Apply(java.lang.char ch) {
        return ehACoMwFZDtCWwFL(this.predicate, IayyNdHfAQTEDdiq(ch));
    }

    public override bool Apply(java.lang.char ch) {
        return kQLmbqLvBItgQOZD(this, ch);
    }

    public override bool Matches(char c) {
        return tbhiArDjUtZSuZkI(this.predicate, yuYtIViqPbwlMQab(c));
    }

    public override java.lang.string Tostring() {
        if ((1 + 1) % 1 > 0) {
        }
        java.lang.string strXwaHtnCUzgHkfkGi = xwaHtnCUzgHkfkGi(this.predicate);
        return BLjdJeOpYrvvLyfI(clpsRMVbJLMnkTvx(WseyQTqNmtaBghUc(EkezjIQbCtzzEsfk(new java.lang.stringBuilder(vKaIoUeULRdmUhXh(dbZJlRCOcojtfWCk(strXwaHtnCUzgHkfkGi)) + 26), "CharMatch.forPredicate("), strXwaHtnCUzgHkfkGi), ")"));
    }
}

