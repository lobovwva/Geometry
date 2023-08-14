using Geometry.Figures;

namespace GeometryTests
{
    public class Tests
    {
        #region Circle

        /// <summary>
        /// ���� �� ������������� ������ �����
        /// </summary>
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-2f));
        }

        /// <summary>
        /// ��������� ���������� ������� �����
        /// </summary>
        [Test]
        public void CircleCalcSquareTest()
        {
            Assert.That((new Circle(1f).Square), Is.EqualTo(Math.PI));
            Assert.That((new Circle(2f).Square), Is.EqualTo(Math.PI * Math.Pow(2f, 2)));
        }

        #endregion

        #region RightTriangle

        /// <summary>
        /// ��������� ������������� ������� �������������� ������������
        /// </summary>
        [Test]
        public void RightTriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new RightTriangle(-1f, 0f));
            Assert.Throws<ArgumentOutOfRangeException>(() => new RightTriangle(0f, -1f));
        }

        /// <summary>
        /// ��������� ���������� ������� �������������� ������������
        /// </summary>
        [Test]
        public void RightTriangleCalcSquareTest()
        {
            Assert.That((new RightTriangle(4f, 3f)).Square, Is.EqualTo(6f));
        }

        #endregion

        #region Triangle

        /// <summary>
        /// ��������� ������������� ������� ������������
        /// </summary>
        [Test]
        public void TriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1f, 0f, 0f));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0f, -1f, 0f));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0f, 0f, -1f));
        }

        /// <summary>
        /// ��������� ������������� ��������� � ������ ������������
        /// </summary>
        [Test]
        public void TriangleNegativeBaseHeightTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1f, 0f));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0f, -1f));
        }

        /// <summary>
        /// ��������� ���������� ������� ������������
        /// </summary>
        [Test]
        public void TriangleCalcSquareTest()
        {
            Assert.That((new Triangle(4f, 3f)).Square, Is.EqualTo(6f));
            Assert.That((new Triangle(3f, 4f, 5f)).Square, Is.EqualTo(6f));
        }

        /// <summary>
        /// ��������� ����������� �� ������������� �����������
        /// </summary>
        [Test]
        public void TriangleIsRightAngleTest()
        {
            Assert.That((new Triangle(3f, 4f, 5f)).CheckIsRightAngled(), Is.EqualTo(true));
        }

        /// <summary>
        /// ��������� ����������� �� �� ������������� �����������
        /// </summary>
        [Test]
        public void TriangleIsNotRightAngleTest()
        {
            Assert.That((new Triangle(6f, 2f, 7f)).CheckIsRightAngled(), Is.EqualTo(false));
        }

        /// <summary>
        /// ��������� ������������� ����������� �� ������������� ����������� ��� �������� ������
        /// </summary>
        [Test]
        public void TriangleIsRightAngleExceptTest()
        {
            Assert.Throws<Exception>(() => (new Triangle(4f, 3f)).CheckIsRightAngled());
        }

        #endregion
    }
}