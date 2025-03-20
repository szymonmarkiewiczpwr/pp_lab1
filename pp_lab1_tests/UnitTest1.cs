using pp_lab1;

[assembly: Parallelizable(ParallelScope.Children)]
namespace pp_lab1_tests
{
    public class Tests
    {
        private Problem? problemWithDefaultParams;
        private Problem? problemWithManualParams;

        [SetUp]
        public void Setup()
        {
            problemWithManualParams = new Problem(2, 123);
            problemWithDefaultParams = new Problem(1);
        }

        [Test]
        public void Test_Constructor_MaxWhenUnspecified()
        {
            Assert.That(10_000_000, Is.EqualTo(problemWithDefaultParams!.ItemsCount));
            Assert.That(10_000_000, Is.EqualTo(problemWithDefaultParams.AvaiableItems.Count));
        }

        [Test]
        public void Test_Constructor_EqualsOverwrittenParameter()
        {
            Assert.That(123, Is.EqualTo(problemWithManualParams!.ItemsCount));
            Assert.That(123, Is.EqualTo(problemWithManualParams.AvaiableItems.Count));
        }

        [Test]
        public void Test_ProblemSolve_RngVariant1_Capacity20()
        {
            List<BackpackItem> expectedItems = new List<BackpackItem>
            {
                new BackpackItem(10, 1),
                new BackpackItem(10, 1),
                new BackpackItem(10, 1),
                new BackpackItem(9, 1),
                new BackpackItem(9, 1),
                new BackpackItem(7, 1),
                new BackpackItem(7, 1),
                new BackpackItem(10, 2),
                new BackpackItem(10, 2),
                new BackpackItem(8, 2),
                new BackpackItem(8, 2),
                new BackpackItem(4, 1),
                new BackpackItem(8, 2),
                new BackpackItem(2, 1),
            };

            Problem problem = new Problem(1, 100);
            List<BackpackItem> items = problem.Solve(20);

            Assert.That(items, Is.EquivalentTo(expectedItems).Using(new BackpackItemComparator()));
        }

        [Test]
        public void Test_ProblemSolve_InvalidCase()
        {
            Problem problem = new Problem(1, 10);
            int invalidCapacity = 0;
            List<BackpackItem> emptyResult = problem.Solve(invalidCapacity);

            Assert.That(emptyResult, Is.Empty);
        }

        [Test]
        public void Test_ProblemSolve_AtLeastOneItemMeetsConstraints()
        {
            Problem problem = new Problem(1, 100);
            int validCapacity = 50;

            List<BackpackItem> result = problem.Solve(validCapacity);

            Assert.That(result.Count, Is.GreaterThan(0), "Expected at least one item to meet the constraints.");
        }

        [Test]
        public void Test_ProblemSolve_NoItemsMeetConstraints()
        {
            Problem problem = new Problem(1, 100);
            int tooSmallCapacity = 1;

            List<BackpackItem> result = problem.Solve(tooSmallCapacity);

            Assert.That(result, Is.Empty, "Expected no items to meet the constraints.");
        }
    }
}