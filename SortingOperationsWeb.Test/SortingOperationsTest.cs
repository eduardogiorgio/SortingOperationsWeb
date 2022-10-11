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
        [InlineData("wzenwebuau", "eeuuwwabnz")]
        [InlineData("vokfxzynwl", "fklnovwxyz")]
        [InlineData("neldfeyrxk", "eedfklnrxy")]
        [InlineData("wqadfiodgs", "ddafgioqsw")]
        [InlineData("ykiuvzfcbc", "ccbfikuvyz")]
        [InlineData("qakmc", "ackmq")]
        [InlineData("rrtbk", "rrbkt")]
        [InlineData("vaixn", "ainvx")]
        [InlineData("wmpnj", "jmnpw")]
        [InlineData("uproi", "iopru")]
        [InlineData("btska", "abkst")]
        [InlineData("ejqwr", "ejqrw")]
        [InlineData("elwlg", "llegw")]
        [InlineData("oaoiy", "ooaiy")]
        [InlineData("hrqkn", "hknqr")]
        [InlineData("pzjim", "ijmpz")]
        [InlineData("njnfq", "nnfjq")]
        [InlineData("xyohs", "hosxy")]
        public void Sorting(string input, string expectedOutput)
        {
            var output = SortingOperations.Sorting(input);
            Assert.Equal(output, expectedOutput);
        }
    }
}