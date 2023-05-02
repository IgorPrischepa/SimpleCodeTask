namespace SimpleCodeTask.Test
{
    public class SimpleCodeSolution
    {
        [Fact]
        public void ValidateRresult()
        {
            string[] A = { "unlock.microvirus.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us" };

            string[] B = { "microvirus.md", "visitwar.de", " piratebay.co.uk", " list.stolen.credit.card.us" };

            int[] ExpectedResult = { 1, 3, 4, 5 };

            int[] result = Solution.TaskSolution(A, B);

            Assert.Equal(ExpectedResult, result);
        }

        [Fact]
        public void ValidateRresult2()
        {
            string[] A = { "images.adult.hb", "ringo.adult.hb", "video.ringo.adult.hb" };

            string[] B = { "adult.hb" };

            int[] ExpectedResult = Array.Empty<int>();

            int[] result = Solution.TaskSolution(A, B);

            Assert.Equal(ExpectedResult, result);
        }
    }
}