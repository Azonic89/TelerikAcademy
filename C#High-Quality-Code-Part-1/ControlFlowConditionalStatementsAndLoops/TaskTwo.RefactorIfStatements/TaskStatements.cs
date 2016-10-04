namespace TaskTwo.RefactorIfStatements
{
    using System;

    using TaskOne.Chef.Contracts;

    public class TaskStatements
    {
        public static void CookPeeledVegetable(IChef chef, IVegetable vegetable)
        {
            if (vegetable == null)
            {
                return;
            }

            IContainable preparedMeal;
            if (vegetable.IsPeeled && !vegetable.IsRotten)
            {
                preparedMeal = chef.GetBowl();
            }
        }

        public static void ShouldVisitCell(int x, int minX, int maxX, int y, int minY, int maxY)
        {
            var cellShouldBeVisited = CheckIfCellShouldBeVisited(x, y);
            var cellIsInBounds = CheckIfCellCoordinatesAreInBounds(x, minX, maxX, y, minY, maxY);

            if (cellIsInBounds && cellShouldBeVisited)
            {
                VisitCell(x, y);
            }
        }

        private static void VisitCell(int x, int y)
        {
            throw new NotImplementedException();
        }

        private static bool CheckIfCellShouldBeVisited(int x, int y)
        {
            throw new NotImplementedException();
        }

        private static bool CheckIfCellCoordinatesAreInBounds(int x, int minX, int maxX, int y, int minY, int maxY)
        {
            throw new NotImplementedException();
        }
    }
}
