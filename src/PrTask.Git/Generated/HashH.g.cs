namespace PrTask.Git.Generated;

internal static partial class HashH
{
    internal const string SHA1_BACKEND = "SHA1_DC";
    internal const string SHA256_BACKEND = "SHA256_NETTLE";
    internal const string SHA256_BACKEND = "SHA256_GCRYPT";
    internal const string SHA256_BACKEND = "SHA256_BLK";
    internal const int GIT_HASH_UNKNOWN = 0;
    internal const int GIT_HASH_SHA1 = 1;
    internal const int GIT_HASH_SHA256 = 2;
    internal const int GIT_SHA1_FORMAT_ID = 0x73686131;
    internal const int GIT_SHA1_RAWSZ = 20;
    internal const int GIT_SHA1_BLKSZ = 64;
    internal const int GIT_SHA256_FORMAT_ID = 0x73323536;
    internal const int GIT_SHA256_RAWSZ = 32;
    internal const int GIT_SHA256_BLKSZ = 64;
    internal const int GET_OID_QUIETLY = 01;
    internal const int GET_OID_COMMIT = 02;
    internal const int GET_OID_COMMITTISH = 04;
    internal const int GET_OID_TREE = 010;
    internal const int GET_OID_TREEISH = 020;
    internal const int GET_OID_BLOB = 040;
    internal const int GET_OID_FOLLOW_SYMLINKS = 0100;
    internal const int GET_OID_RECORD_PATH = 0200;
    internal const int GET_OID_ONLY_TO_DIE = 04000;
    internal const int GET_OID_REQUIRE_PATH = 010000;
    internal const int GET_OID_HASH_ANY = 020000;
    internal const int GET_OID_SKIP_AMBIGUITY_CHECK = 040000;
    internal const int GET_OID_GENTLY = 0100000;
}
