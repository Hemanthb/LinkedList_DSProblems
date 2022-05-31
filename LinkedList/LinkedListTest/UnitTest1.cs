namespace LinkedListTest
{
    public class Tests
    {
        LinkedList.LinkedList list = new LinkedList.LinkedList();
        [Test]
        public void GivenANodeData_SearchData_ReturnTrueIfFound()
        {
            list.addNode(56);
            list.addNode(30);
            list.addNode(70);
            var actualResult = list.Search(30);
            Assert.IsTrue(actualResult);
        }
    }
}