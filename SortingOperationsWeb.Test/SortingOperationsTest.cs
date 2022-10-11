using SortingOperationsWeb.Helper;

namespace SortingOperationsWeb.Test
{
    public class SortingOperationsTest
    {
        [Theory]
        [InlineData("abaccadcc", "ccccaaabd")]
        [InlineData("xyzxy", "xxyyz")]
        [InlineData("dulgvgzwqg", "gggdlquvwz")]
        [InlineData("gxtjtmtywr", "tttgjmrwxy")]
        [InlineData("hnlnxiupgt", "nnghilptux")]
        [InlineData("gzjotckivp", "cgijkoptvz")]
        [InlineData("dpwwsdptae", "ddppwwaest")]
        [InlineData("pcscpilknb", "ccppbiklns")]
        [InlineData("btvyhhmflf", "ffhhblmtvy")]
        [InlineData("artrtnqxcr", "rrrttacnqx")]
        [InlineData("nrtcmcoadn", "ccnnadmort")]
        [InlineData("fkdsgnekft", "ffkkdegnst")]
        [InlineData("wzenwebuau", "eeuuwwabnz")]
        [InlineData("vokfxzynwl", "fklnovwxyz")]
        [InlineData("neldfeyrxk", "eedfklnrxy")]
        [InlineData("wqadfiodgs", "ddafgioqsw")]
        [InlineData("ykiuvzfcbc", "ccbfikuvyz")]
        public void Sorting(string input, string expectedOutput)
        {
            var output = SortingOperations.Sorting(input);
            Assert.Equal(output, expectedOutput);
        }
    }
}