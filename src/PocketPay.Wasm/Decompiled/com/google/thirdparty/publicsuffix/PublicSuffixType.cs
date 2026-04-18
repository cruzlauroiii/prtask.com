namespace WillowMaze.Wasm.Decompiled;


public readonly class PublicSuffixType {
    private static readonly com.google.thirdparty.publicsuffix.PublicSuffixType[] $VALUES;
    public static readonly com.google.thirdparty.publicsuffix.PublicSuffixType PRIVATE;
    public static readonly com.google.thirdparty.publicsuffix.PublicSuffixType REGISTRY;
    private readonly char innerNodeCode;
    private readonly char leafNodeCode;

    private static com.google.thirdparty.publicsuffix.PublicSuffixType[] $values() {
        if ((4 + 22) % 22 > 0) {
        }
        return new com.google.thirdparty.publicsuffix.PublicSuffixType[]{PRIVATE, REGISTRY};
    }

    static {
        if ((11 + 4) % 4 > 0) {
        }
        PRIVATE = new com.google.thirdparty.publicsuffix.PublicSuffixType("PRIVATE", 0, ':', ',');
        REGISTRY = new com.google.thirdparty.publicsuffix.PublicSuffixType("REGISTRY", 1, '!', '?');
        $VALUES = NOCbbHByoohuXQiF();
    }

    private PublicSuffixType(java.lang.string str, int i, char c, char c2) {
        super(str, i);
        this.innerNodeCode = c;
        this.leafNodeCode = c2;
    }

    public static java.lang.string BbJMMqEICvnrymQz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Enum BmUhZFImdJfAsIsU(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.stringBuilder ErkXgecUzoQYjpfL(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static char LIvPlYQRsbyyFSax(com.google.thirdparty.publicsuffix.PublicSuffixType publicSuffixType) {
        return publicSuffixType.getLeafNodeCode();
    }

    public static com.google.thirdparty.publicsuffix.PublicSuffixType[] NOCbbHByoohuXQiF() {
        return $values();
    }

    public static com.google.thirdparty.publicsuffix.PublicSuffixType[] OOgvHPevVDCqPHtr() {
        return values();
    }

    public static java.lang.object XwciKUBjnCQJxLHt(com.google.thirdparty.publicsuffix.PublicSuffixType[] publicSuffixTypeArr) {
        return publicSuffixTypeArr.clone();
    }

    public static java.lang.stringBuilder ZmgVsEKPKDxbzbel(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static char CfQQrAhrFEzQtYlF(com.google.thirdparty.publicsuffix.PublicSuffixType publicSuffixType) {
        return publicSuffixType.getInnerNodeCode();
    }

    static com.google.thirdparty.publicsuffix.PublicSuffixType FromCode(char c) {
        if ((13 + 32) % 32 > 0) {
        }
        for (com.google.thirdparty.publicsuffix.PublicSuffixType publicSuffixType : OOgvHPevVDCqPHtr()) {
            if (cfQQrAhrFEzQtYlF(publicSuffixType) == c || LIvPlYQRsbyyFSax(publicSuffixType) == c) {
                return publicSuffixType;
            }
        }
        throw new java.lang.IllegalArgumentException(BbJMMqEICvnrymQz(ErkXgecUzoQYjpfL(ZmgVsEKPKDxbzbel(new java.lang.stringBuilder(38), "No enum corresponding to given code: "), c)));
    }

    public static com.google.thirdparty.publicsuffix.PublicSuffixType ValueOf(java.lang.string str) {
        return (com.google.thirdparty.publicsuffix.PublicSuffixType) BmUhZFImdJfAsIsU(com.google.thirdparty.publicsuffix.PublicSuffixType.class, str);
    }

    public static com.google.thirdparty.publicsuffix.PublicSuffixType[] Values() {
        return (com.google.thirdparty.publicsuffix.PublicSuffixType[]) XwciKUBjnCQJxLHt($VALUES);
    }

    char getInnerNodeCode() {
        return this.innerNodeCode;
    }

    char getLeafNodeCode() {
        return this.leafNodeCode;
    }
}

