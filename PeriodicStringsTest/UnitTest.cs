using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Program360
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test00()
        {
            string[] input = new string[] {
            };
            int[] expected = new int[] {
            };

            int[] actual = Program360.PeriodicStrings.process(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected.Length, actual.Length, "Incorrect number of results");
        }
        [TestMethod]
        public void Test01()
        {
            string[] input = new string[] {
                ""
            };
            int[] expected = new int[] {
                0
            };

            int[] actual = Program360.PeriodicStrings.process(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected.Length, actual.Length, "Incorrect number of results");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Incorrect result @ index[" + i + "]");
        }
        [TestMethod]
        public void Test02()
        {
            string[] input = new string[] {
                "aaaaaaaa"
            };
            int[] expected = new int[] {
                1
            };

            int[] actual = Program360.PeriodicStrings.process(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected.Length, actual.Length, "Incorrect number of results");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Incorrect result @ index[" + i + "]");
        }
        [TestMethod]
        public void Test03()
        {
            string[] input = new string[] {
                "abbaabbaabba"
            };
            int[] expected = new int[] {
                2
            };

            int[] actual = Program360.PeriodicStrings.process(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected.Length, actual.Length, "Incorrect number of results");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Incorrect result @ index[" + i + "]");
        }
        [TestMethod]
        public void Test04()
        {
            string[] input = new string[] {
                "abcdef"
            };
            int[] expected = new int[] {
                6
            };

            int[] actual = Program360.PeriodicStrings.process(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected.Length, actual.Length, "Incorrect number of results");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Incorrect result @ index[" + i + "]");
        }
        [TestMethod]
        public void Test05()
        {
            string[] input = new string[] {
                "ac/dcdirestraitsrushtotothestrutssantana42"+
                "2ac/dcdirestraitsrushtotothestrutssantana4"+
                "42ac/dcdirestraitsrushtotothestrutssantana"
            };
            int[] expected = new int[] {
                42
            };

            int[] actual = Program360.PeriodicStrings.process(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected.Length, actual.Length, "Incorrect number of results");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Incorrect result @ index[" + i + "]");
        }
        [TestMethod]
        public void Test06()
        {
            string[] input = new string[] {
                "xzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzxxzzx"
            };
            int[] expected = new int[] {
                2
            };

            int[] actual = Program360.PeriodicStrings.process(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected.Length, actual.Length, "Incorrect number of results");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Incorrect result @ index[" + i + "]");
        }
        [TestMethod]
        public void Test07()
        {
            string[] input = new string[] {
                "abbabbabba",
                "abcdabcddabcdabc",
                "aeiouuaeioouaei",
            };
            int[] expected = new int[] {
                5, 8, 5
            };

            int[] actual = Program360.PeriodicStrings.process(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected.Length, actual.Length, "Incorrect number of results");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Incorrect result @ index[" + i + "]");
        }
        [TestMethod]
        public void Test08()
        {
            string[] input = new string[] {
                "wvbiogkjbddwvbiogkjbbdwvbiogkjjbdwvbiogkkjbdwvbioggkjbdwvbioogkjbdwvbiiogkjbdwvbbiogkjbdwvvbiogkjbdw",
                "fmpflqseobguabcnfdsavmxromdywgtkqnheghemuaourswtygyjckwzdohminikrafaonbtigvwjaqpxmrtafttvrwtnajqgvwo",
                "aaaaaaaaaaaaaaaaaaaakaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaakaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            };
            int[] expected = new int[] {
                10, 100, 50
            };

            int[] actual = Program360.PeriodicStrings.process(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected.Length, actual.Length, "Incorrect number of results");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Incorrect result @ index[" + i + "]");
        }
        [TestMethod]
        public void Test09()
        {
            string[] input = new string[] {
                "miwfydptsxddmiwfydptsxxdmiwfydptssxdmiwfydpttsxdmiwfydpptsxdmiwfyddptsxdmiwfyydptsxdmiwffydptsxdmiw",
                "oesamaqcuxcqvoostmgnlhjxuambwyhrpiioesamaqcuxcqvoostmgnlhjxuambwyhrp",
                "srqwjzoxzyfwhnlkiyislhnpzwsnhipieyysrqwjzoxzyfwhnlkiyislhnpzwsnhipie"
            };
            int[] expected = new int[] {
                11, 34, 34
            };

            int[] actual = Program360.PeriodicStrings.process(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected.Length, actual.Length, "Incorrect number of results");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Incorrect result @ index[" + i + "]");
        }
        [TestMethod]
        public void Test10()
        {
            string[] input = new string[] {
                "bkxegzpfjonbpbbbkxegzpfjonbppbbkxegzpfjonbbpbbkxegzpfjonnbpbbkxegzpfjoonbpbbkxegzpfjjonbpbbkxegzpf",
                "gyoeairfyssgyoeairfyysgyoeairffysgyoeairrfysgyoeaiirfysgyoeaairfysgyoeeairfysgyooeairfysgyyoeairfysg",
                "iufdqgvviufdqggviufdqqgviufddqgviuffdqgviuufdqgviiufdqgvviufdqggviufdqqgviufddqgviuffdqgviuufdqgvi",
                "ylunoiiylunooiylunnoiyluunoiyllunoiyylunoiiylunooiylunnoiyluunoiyllunoiyylunoiiylunooiylunnoiylu",
                "llllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll",
                "pkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkppkkp",
                "gaivfdynngaivfdyyngaivfddyngaivffdyngaivvfdyngaiivfdyngaaivfdynggaivfdynngaivfdyyngaivfddyngaivf",
                "iqxufqztggiqxufqzttgiqxufqzztgiqxufqqztgiqxuffqztgiqxuufqztgiqxxufqztgiqqxufqztgiiqxufqztggiqxufqzt"
            };
            int[] expected = new int[] {
                14, 10, 7, 6, 1, 2, 8, 9
            };

            int[] actual = Program360.PeriodicStrings.process(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected.Length, actual.Length, "Incorrect number of results");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Incorrect result @ index[" + i + "]");
        }
    }
}
