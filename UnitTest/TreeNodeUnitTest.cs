using System;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class TreeNodeUnitTest
    {
        [TestMethod]
        public void CreateTreeNode()
        {
            TreeNode tn = new TreeNode(1);
            tn.left = new TreeNode(2);

            Assert.IsNotNull(tn.left);
        }


    }
}
